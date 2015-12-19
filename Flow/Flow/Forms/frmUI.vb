'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmUI
    Private varMouseDown As Boolean = False


    Private Sub frmUI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown 'KeyUp
        Dim flowKeyCode As Integer = getFlowKeyCodeFromKeyValue(e.KeyValue)

        'Exiting if the key pressed was a key which can not hold actions / shortcuts (Alt, Ctrl etc)
        If flowKeyCode = 0 Then Exit Sub

        Dim key As clsCommand = clsLayoutManager.commands(flowKeyCode)
        If flowKeyCode > 0 Then
            If key.isAssigned = True Then

                clsKeyPressHandler.executeCommand(flowKeyCode)
            Else
                clsKeyConfigurator.configureKey(flowKeyCode)
            End If
        End If

        'End If
    End Sub

    Private Shared Function getFlowKeyCodeFromKeyValue(ByVal keyValue As Integer) As Integer
        Dim cultureKey As Xml.XmlNode
        cultureKey = clsFlowGeneral.UserCulture.SelectSingleNode("//key[@keyValue='" & keyValue & "']")
        If cultureKey Is Nothing Then
            Return 0
        Else
            Return CInt(cultureKey.Attributes.GetNamedItem("flowKeyCode").InnerText)
        End If
    End Function 'Converts a keyValue (from a keyup event) to the corresponding FlowKeyCode. Returns 0 if no FlowKeyCode found (shift, alt, control keys etc)


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = clsGlobalHotKeys.WM_HOTKEY Then
            clsGlobalHotKeys.handleHotKeyEvent(m.WParam)
        End If
        MyBase.WndProc(m)
    End Sub 'System wide hotkey event handling

#Region "Form dragging / moving"
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

#End Region


#Region "Form loading and disposing"
    Private Sub frmUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        addEventHandlers()
        nfIcon.Icon = My.Resources.Notification
        nfIcon.Visible = True


        'GT. 08.03.2010 -- "Register Product" is hidden after registration
        'If clsExpireDateMechanism.Activated Then
        '    Me.contextMainMenu.Items.Item(6).Visible = False 'hiding "Register product" menu item
        'End If

        'GT. 05.03.2010 -- check for an autoupdates
        'If My.Settings.AutoUpdates = True Then            //GT. 05.12.2010 -- just removed AutoUpdater compoтent
        '    automaticUpdater.ForceCheckForUpdate()
        'End If

        'GT. 06.07.2010 -- adjusting font size
        Dim font As Font = labCurrentLayout.Font

        Dim newFontSize As Single = font.Size * (clsRender.defaultFontResolution / clsRender.getDPI)
        labCurrentLayout.Font = New Font(font.Name, newFontSize, font.Style)

        font = Label1.Font
        newFontSize = font.Size * (clsRender.defaultFontResolution / clsRender.getDPI)
        Label1.Font = New Font(font.Name, newFontSize, font.Style)

    End Sub

    Private Sub frmUI_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        clsFlowGeneral.closeFlow()
    End Sub
#End Region

    Private Sub addEventHandlers()
        Dim keyPanelControl As Panel
        For Each objControl As Control In Me.Controls
            If TypeOf objControl Is Panel And LCase(Strings.Left(objControl.Name, 5)) = "panel" Then
                keyPanelControl = CType(objControl, Panel)

                AddHandler keyPanelControl.MouseEnter, AddressOf keyMouseEnterHandler
                AddHandler keyPanelControl.MouseLeave, AddressOf keyMouseLeaveHandler
                AddHandler keyPanelControl.MouseUp, AddressOf key_MouseClick
                AddHandler keyPanelControl.MouseDoubleClick, AddressOf key_MouseClick

                AddHandler keyPanelControl.DragDrop, AddressOf keyMouseDragDropHandler
                AddHandler keyPanelControl.DragEnter, AddressOf keyMouseDragEnterHandler
                AddHandler keyPanelControl.MouseDown, AddressOf keyMouseDownHandler
                AddHandler keyPanelControl.MouseUp, AddressOf keyMouseUpHandler
                AddHandler keyPanelControl.MouseMove, AddressOf keyMouseMoveHandler
            End If
        Next
    End Sub

#Region "Mouse click handlers"
    Private Sub key_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pboxHoverEffect.MouseClick, pboxHoverEffect.MouseDoubleClick
        Dim flowKeyCode As Integer = getKeycodeWithMouseFocus()
        If flowKeyCode > 0 Then
            Dim buttonClicked As String = LCase(e.Button.ToString)
            Dim key As New clsCommand(flowKeyCode)
            If buttonClicked = "left" Then
                key_LeftClick(flowKeyCode)
            Else 'Right click
                If key.isFlowCommand = False Then key_RightClick(flowKeyCode, sender)
            End If
        End If
    End Sub

    Private Sub key_LeftClick(ByVal flowKeyCode As Integer)
        Dim key As New clsCommand(flowKeyCode)

        'Left-Clicking on an ASSIGNED key, should execute it. 
        'Left-Clicking on an UNASSIGNED key, should go directly to the configure form.
        If key.isAssigned = True Then
            clsKeyPressHandler.executeCommand(flowKeyCode)
        Else
            clsKeyConfigurator.configureKey(flowKeyCode)
        End If
    End Sub
    Private Sub key_RightClick(ByVal flowKeyCode As Integer, ByVal sender As Object)
        Dim key As New clsCommand(flowKeyCode)

        'Right-Clicking on an ASSIGNED key, should display the popup.
        'Right-Clicking on an UNASSIGNED key, should go directly to the configure form.
        If key.isAssigned = True Then
            showConfigPopup(sender, flowKeyCode)
        Else
            clsKeyConfigurator.configureKey(flowKeyCode)
        End If
    End Sub
#End Region

#Region "Drag-drop handlers"
    Private Sub keyMouseDragDropHandler(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim droppedObject As Object = e.Data.GetData(DataFormats.FileDrop)

        If Not droppedObject Is Nothing Then dragDropFromOutsideFlow(sender, e)
    End Sub
    Private Sub dragDropFromOutsideFlow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim flowKeyCodeDestinationCommand As Integer = getKeycodeWithMouseFocus()

        If flowKeyCodeDestinationCommand > 0 Then
            Dim fileFolderName As String = CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString
            Dim command As New clsCommand(flowKeyCodeDestinationCommand)
            If command.isFlowCommand = True Then Exit Sub

            If command.isAssigned = False Then
                clsKeyConfigurator.addCommandFromDragDrop(flowKeyCodeDestinationCommand, fileFolderName)
            Else
                If MsgBox("Do you want to replace the existing command with " & fileFolderName & "?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                    clsKeyConfigurator.removeCommand(flowKeyCodeDestinationCommand, False)
                    clsKeyConfigurator.addCommandFromDragDrop(flowKeyCodeDestinationCommand, fileFolderName)
                End If
            End If
        End If


    End Sub

    Private Sub dragDropFromInsideFlow(ByVal sourceKeycode As Integer, ByVal destKeycode As Integer)
        Dim sourceCommand As New clsCommand(sourceKeycode)
        Dim destinationCommand As New clsCommand(destKeycode)

        If sourceCommand.physicalKey.flowKeyCode = destinationCommand.physicalKey.flowKeyCode Then
            key_LeftClick(sourceCommand.physicalKey.flowKeyCode)
        Else
            'Preventing drag/drop of flow commands
            If sourceCommand.isFlowCommand = True Then Exit Sub
            If destinationCommand.isFlowCommand = True Then Exit Sub 'GT. 10.03.2010 -- we can't drag command to the flow command.

            'Determining whether command needs to be switched with another command, or copied+removed.
            If destinationCommand.isAssigned = False And sourceCommand.isAssigned = True Then
                clsKeyConfigurator.copyCommand(sourceCommand.physicalKey.flowKeyCode, destinationCommand.physicalKey.flowKeyCode)
                clsKeyConfigurator.removeCommand(sourceCommand.physicalKey.flowKeyCode, False)
            Else
                If sourceCommand.isAssigned = True Then clsKeyConfigurator.switchCommands(sourceCommand.physicalKey.flowKeyCode, destinationCommand.physicalKey.flowKeyCode) 'Sourcecommand needs to be assigned, else we'll encounter an error when trying to switch an empty command with an assigned one.
            End If

            clsRender.clearCommandDisplay()
        End If
    End Sub

    Private Sub keyMouseDragEnterHandler(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter

        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Public mouseDownKeycode As Integer
    Private Sub keyMouseDownHandler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseDown, pboxHoverEffect.MouseDown
        varMouseDown = True
        mouseDownKeycode = getKeycodeWithMouseFocus()
    End Sub
    Private Sub keyMouseUpHandler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseUp, pboxHoverEffect.MouseUp
        varMouseDown = False
        Dim mouseUpKeycode As Integer = getKeycodeWithMouseFocus()

        If Not mouseDownKeycode = mouseUpKeycode And mouseUpKeycode > 0 And mouseDownKeycode > 0 Then
            dragDropFromInsideFlow(mouseDownKeycode, mouseUpKeycode)
        End If
    End Sub
    Private Sub keyMouseMoveHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If varMouseDown = True Then sender.DoDragDrop(sender.Name, DragDropEffects.Copy)
        varMouseDown = False
    End Sub
#End Region

#Region "Mouseover handlers"
    Private Sub keyMouseEnterHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim flowKeyCode As Integer = getFlowKeyCodeFromPanelName(sender.Name)
        If panConfigPopup.Visible = True Then panConfigPopup.Visible = False
        clsRender.displayCommand(flowKeyCode)
        sender.BackGroundImage = My.Resources.keyHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub keyMouseLeaveHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clsRender.clearCommandDisplay()
        sender.BackGroundImage = Nothing
        Cursor = Cursors.Default
    End Sub
#End Region

    Private Function getFlowKeyCodeFromPanelName(ByVal panelName As String) As Integer
        Return CInt(panelName.Remove(0, 5))
    End Function 'Gets flow key code by removing the first 5 characters from the panels's name. This works as all key panels are named "Panel[flowkeycode]" (without brackets)

#Region "Right click configure menu methods"
    Private focusStillInsidePopupMenu As Boolean = False
    Private Sub panelConfigPopup_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panConfigPopup.MouseLeave
        If focusStillInsidePopupMenu = False Then panConfigPopup.Visible = False

    End Sub
    Private Sub configButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAssign.MouseEnter, btnEdit.MouseEnter, btnRemove.MouseEnter
        focusStillInsidePopupMenu = True
    End Sub
    Private Sub configButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAssign.MouseLeave, btnEdit.MouseLeave, btnRemove.MouseLeave
        focusStillInsidePopupMenu = False
    End Sub

    Private Sub btnAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssign.Click
        Dim flowKeyCode As Integer = CInt(panConfigPopup.Tag)
        hideConfigPopup()
        clsKeyConfigurator.configureKey(flowKeyCode)
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim flowKeyCode As Integer = CInt(panConfigPopup.Tag)

        hideConfigPopup()

        If CBool(sender.ModifierKeys And Keys.Shift) Then   'Shift pressed when button clicked: Remove without asking for verification
            clsKeyConfigurator.removeCommand(flowKeyCode, True)
        Else
            If MsgBox("Are you sure you want to remove this action?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                clsKeyConfigurator.removeCommand(flowKeyCode, True)
            End If
        End If
        'clsRender.renderCommandLayoutOnUI() 'GT. 20.01.10 -- added to solve "key labels disappearing" issue.
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim flowKeyCode As Integer = CInt(panConfigPopup.Tag)
        clsKeyConfigurator.FlowKeyCodeToConfigure = flowKeyCode

        hideConfigPopup()

        frmEditKey.Show()
    End Sub

    Private Sub hideConfigPopup()
        panConfigPopup.Visible = False
        panConfigPopup.Tag = ""
    End Sub
    Private Sub showConfigPopup(ByVal sender As System.Object, ByVal flowKeyCode As Integer)
        Dim point As System.Drawing.Point

        point.X = sender.Location.X - 70
        point.Y = sender.Location.Y - 10

        'Variations in case of abnormal sized keys (space (95) and numpad plus key (58))
        If flowKeyCode = 95 Then point.X = sender.Location.X
        If flowKeyCode = 58 Then
            point.X = sender.Location.X - 75
            point.Y = sender.location.y + 20
        End If


        panConfigPopup.Location = point
        panConfigPopup.Tag = flowKeyCode

        If panConfigPopup.Left < 0 Then panConfigPopup.Left = 0
        If panConfigPopup.Right > Me.Width Then panConfigPopup.Left = Me.Width - panConfigPopup.Width

        panConfigPopup.Visible = True
        panConfigPopup.BringToFront()
    End Sub

#End Region

#Region "Context menu methods"
    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mousePosition As New Point(frmUI.MousePosition.X, frmUI.MousePosition.Y)

        contextMainMenu.Show(mousePosition)
    End Sub

    Private Sub menuitemExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitemExit.Click
        clsFlowGeneral.closeFlow() 'GT. 02.02.2010 'closing flow application
        'Me.Close
    End Sub


    Private Sub menuitemSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitemSettings.Click
        frmSettings.Show()
    End Sub

    'Private Sub registerProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterProductToolStripMenuItem.Click
    '    frmActivation.Show()
    'End Sub

    Private Sub menuitemShowHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitemShowHide.Click
        If Me.Visible Then
            clsFlowGeneral.hideFlow()
        Else
            clsFlowGeneral.displayFlow()
        End If

    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        frmHelp.Show()
    End Sub

    Private Sub menuLayouts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLayouts.Click
        frmLayoutManager.Show()
    End Sub
#End Region

#Region "Key text rendering objects"
    Private keyTextFont As New Font("Arial", 8)
    Private objColor As Color = System.Drawing.ColorTranslator.FromHtml("#5f5f5f")
    Private objBrush As New SolidBrush(objColor)
    Private iconDestination As New Rectangle(0, 0, 24, 24)
#End Region
    Private counter As Integer = 0
    Private Sub frmUI_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim command As clsCommand

        For Each command In clsLayoutManager.commands
            If command Is Nothing Then

            Else
                iconDestination.Location = command.physicalKey.iconRenderPosition
                If command.isAssigned = True Then e.Graphics.DrawImage(command.commandIcon, iconDestination)
            End If
        Next
    End Sub


#Region "Menu button, contextmenu, trayicon and help messages"


    Private Sub PictureBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Dim mousePosition As New Point(frmUI.MousePosition.X, frmUI.MousePosition.Y)
        contextMainMenu.Show(mousePosition)
    End Sub

    Private Sub PictureBox34_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenu.MouseEnter
        btnMenu.Image = My.Resources.MenuButtonHover
    End Sub

    Private Sub PictureBox34_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenu.MouseLeave
        btnMenu.Image = My.Resources.MenuButton
    End Sub


    Private Sub nfIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nfIcon.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'clsFlowGeneral.displayFlow()  //we're hiding flow here, as getLostFocus event has a higher priority
        End If
    End Sub

    Private Sub nfIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nfIcon.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then clsFlowGeneral.displayFlow()
    End Sub

    Private Sub timerHelp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerHelp.Tick
        clsUserHelp.hideHelp()
    End Sub
#End Region

    Private Sub frmUI_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If ActiveForm Is Nothing Then clsFlowGeneral.hideFlow()
    End Sub

    Private Sub frmUI_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim keyWithMouseFocus = getKeycodeWithMouseFocus()

        If keyWithMouseFocus > 0 Then
            clsRender.displayCommand(keyWithMouseFocus)
        Else
            If Me.panCommandDisplay.Visible = True Then clsRender.clearCommandDisplay()

        End If
    End Sub

    Private Function getKeycodeWithMouseFocus() As Integer
        Dim key As clsOSK.physicalKey
        Dim currentMouseLocation As Point = Me.PointToClient(MousePosition)
        For Each key In clsOSK.physicalKeys
            If key.panelBounds.Contains(currentMouseLocation) Then
                Return key.flowKeyCode
            End If
        Next
        Return 0
    End Function

#Region "Hiding form from ALT+Tab"
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            ' turn on WS_EX_TOOLWINDOW style bit
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
#End Region

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Size = New Size(1000, 460)
    'End Sub

    Private Sub contextMainMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles contextMainMenu.Opening

    End Sub
End Class

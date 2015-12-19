'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmConfigureKey

    Private Sub closeForm(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmConfigureKey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        labKeyIndicator.Text = clsRender.getConfigLabKeyText(clsFlowGeneral.getKeyTextFromFlowCode(clsKeyConfigurator.FlowKeyCodeToConfigure))
        Me.Location = frmUI.Location

        'GT. 09.07.2010 -- adjusting text according to fontsize
        Dim font As Font = labWhatShouldHappen.Font
        Dim newFontSize As Single = font.Size * (clsRender.defaultFontResolution / clsRender.getDPI)
        labWhatShouldHappen.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.

    End Sub


#Region "Configure button click handlers"
    Private Sub configureOpenFile(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBtnOpenFile.Click
        fileBrowser.ShowDialog()
        If fileBrowser.FileName.Length > 0 Then
            frmFinalizeConfigure.selectedFilePath = fileBrowser.FileName
            frmFinalizeConfigure.finalizeConfigureType = "file"
            Dim frmFinalize As New frmFinalizeConfigure(Me)
            frmFinalize.Show()
        End If
    End Sub

    Private Sub configureOpenFolder(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBtnOpenFolder.Click
        folderBrowser.ShowDialog()
        If folderBrowser.SelectedPath.Length > 0 Then
            frmFinalizeConfigure.selectedFolderPath = folderBrowser.SelectedPath
            frmFinalizeConfigure.finalizeConfigureType = "folder"
            Dim frmFinalize As New frmFinalizeConfigure(Me)
            frmFinalize.Show()
        End If

    End Sub

    Private Sub configureStartApp(ByVal sender As Object, ByVal e As System.EventArgs) Handles rBtnStartApp.Click
        frmConfigureApp.Show()
    End Sub

    Private Sub configureOpenWebsite(ByVal sender As Object, ByVal e As System.EventArgs) Handles rBtnOpenWebsite.Click
        frmConfigureUrl.Show()
    End Sub

    Private Sub configureNavToLayout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rBtnNavToLayout.Click
        frmConfigureExistingLayout.Show()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmUI.Show()
        Me.Close()
    End Sub
#End Region

#Region "Common for Configure forms"
    'We do the escape keypress handling a bit different on frmConfigureKey than in the other forms.
    'We have to do the actual formclosing (calling btnCancel) in keyup, as otherwise, the form 
    'would be closed, and the keyup event on frmUI would trigger, thereby closing both forms.
    Private escapePressed As Boolean = False
    Private Sub frmConfigureKey_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, btnCancel.KeyPress, rBtnNavToLayout.KeyPress, rBtnOpenFile.KeyPress, rBtnOpenFolder.KeyPress, rBtnOpenWebsite.KeyPress, rBtnStartApp.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Escape, Keys.C
                escapePressed = True
        End Select
    End Sub
#End Region

    Private Sub frmConfigureKey_keyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp, btnCancel.KeyUp, rBtnNavToLayout.KeyUp, rBtnOpenFile.KeyUp, rBtnOpenFolder.KeyUp, rBtnOpenWebsite.KeyUp, rBtnStartApp.KeyUp
        If escapePressed = True Then btnCancel_Click(sender, e)
    End Sub


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
End Class
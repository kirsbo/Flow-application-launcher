'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmConfigureExistingLayout

    Private Sub frmConfigureExistingLayout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        labKeyIndicator.Text = clsRender.getConfigLabKeyText(clsFlowGeneral.getKeyTextFromFlowCode(clsKeyConfigurator.FlowKeyCodeToConfigure))
        populateListLayouts()
        Me.Location = frmUI.Location
    End Sub

    Private Sub populateListLayouts()
        Dim dirFiles() As String = IO.Directory.GetFiles(My.Settings.InstalledPath & My.Settings.PathCommandLayouts)
        For Each dirFile As String In dirFiles
            listLayouts.Items.Add(makeNewListBoxItem(System.IO.Path.GetFileNameWithoutExtension(dirFile)))
        Next
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If listLayouts.SelectedItem Is Nothing Then
            MsgBox("Please select a layout before continuing")
        Else
            Dim selectedLayout As String = listLayouts.SelectedItems.Item(0).Text & ".xml"
            frmFinalizeConfigure.selectedLayoutPath = selectedLayout
            frmFinalizeConfigure.finalizeConfigureType = "layout"

            Dim frmFinalize As New frmFinalizeConfigure(Me)
            frmFinalize.Show()
        End If
    End Sub

    Private Sub listLayouts_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listLayouts.MouseDoubleClick
        btnNext_Click(sender, e)
    End Sub
    Private Function makeNewListBoxItem(ByVal itemText As String) As Telerik.WinControls.UI.RadListBoxItem
        Dim newItem As New Telerik.WinControls.UI.RadListBoxItem
        newItem.Text = itemText
        Return newItem
    End Function

#Region "Common for Configure forms"
    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        '' -- by DS.2010-02-05
        Try
            frmConfigureKey.Show()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub frmConfigureExistingLayout_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, btnNext.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                btnNext_Click(sender, e)
            Case Keys.Escape
                btnBack_Click(sender, e)
        End Select

    End Sub
#End Region

    Private Sub btnCreateLayout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateLayout.Click
        frmConfigureNewLayout.Show()
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
Friend Class frmConfigureNewLayout

    Private Sub frmConfigureNewLayout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        labKeyIndicator.Text = clsRender.getConfigLabKeyText(clsFlowGeneral.getKeyTextFromFlowCode(clsKeyConfigurator.FlowKeyCodeToConfigure))
        Me.Location = frmUI.Location
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click

        If txtLayoutName.Text.Length > 0 Then
            Dim enteredLayout As String = txtLayoutName.Text & ".xml"
            frmFinalizeConfigure.selectedLayoutPath = enteredLayout
            frmFinalizeConfigure.finalizeConfigureType = "layout"
            Dim frmFinalize As New frmFinalizeConfigure(Me)
            frmFinalize.Show()
        Else
            MsgBox("Please enter a layout name before continuing")
        End If

    End Sub
#Region "Common for Configure forms"
    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmConfigureExistingLayout.Show()
        frmConfigureExistingLayout.btnNext.Focus()
    End Sub
    Private Sub frmConfigureNewLayout_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, txtLayoutName.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                btnNext_Click(sender, e)
            Case Keys.Escape
                btnBack_Click(sender, e)
        End Select
    End Sub
#End Region

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
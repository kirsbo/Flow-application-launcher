'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmConfigureUrl

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If txtURL.Text.Length > 0 Then
            frmFinalizeConfigure.enteredURL = txtURL.Text
            frmFinalizeConfigure.finalizeConfigureType = "url"

            Dim frmFinalize As New frmFinalizeConfigure(Me)
            frmFinalize.Show()
        Else
            MsgBox("Please enter a website address (URL)")
            Exit Sub
        End If

    End Sub

#Region "Common for Configure forms"
    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        ' frmConfigureKey.ShowDialog()
    End Sub
    Private Sub frmConfigureUrl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, txtURL.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                btnNext_Click(sender, e)
            Case Keys.Escape
                btnBack_Click(sender, e)
        End Select
    End Sub
#End Region

    Private Sub frmConfigureUrl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        labKeyIndicator.Text = clsRender.getConfigLabKeyText(clsFlowGeneral.getKeyTextFromFlowCode(clsKeyConfigurator.FlowKeyCodeToConfigure))
        Me.Location = frmUI.Location
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
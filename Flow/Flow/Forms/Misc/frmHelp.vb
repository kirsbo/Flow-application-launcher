'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmHelp

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub btnTutorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutorial.Click
        frmTutorialStep1.Show()
    End Sub

    Private Sub btnForums_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForums.Click
        Dim url As String = "http://support.theflowsolution.com/"
        Process.Start(url)
        Me.Close()
        clsFlowGeneral.hideFlow()
    End Sub

    Private Sub btnOnlineHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOnlineHelp.Click
        Dim url As String = "http://support.theflowsolution.com/"
        Process.Start(url)
        Me.Close()
        clsFlowGeneral.hideFlow()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        frmAbout.Show()
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

    Private Sub frmHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = frmUI.Location
    End Sub
End Class

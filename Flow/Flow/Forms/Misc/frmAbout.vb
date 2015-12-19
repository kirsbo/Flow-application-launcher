Imports System.IO.Path

'GT. 21.02.2010 -- revision of class code is completed.
Friend Class frmAbout

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        labCulture.Text = "Culture: " & My.Settings.CultureName
        labEdition.Text = "Edition: " & My.Settings.Edition
        labVersion.Text = "Version: " & My.Settings.Version
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

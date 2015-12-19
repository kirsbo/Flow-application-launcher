'GT. 21.02.2010 -- revision of class code is completed.


Public Class clsUserHelp
    Public Shared Sub hideHelp()
        frmUI.labHelpText.Visible = False
        frmUI.iconHelp.Visible = False
    End Sub
    Public Shared Sub displayHelp(ByVal helpText As String)
        frmUI.labHelpText.Text = helpText
        frmUI.iconHelp.Load(clsImages.FullIconGalleryPath & clsImages.defaultHelpImg)
        frmUI.labHelpText.Visible = True
        frmUI.iconHelp.Visible = True
        frmUI.timerHelp.Start()
    End Sub
End Class

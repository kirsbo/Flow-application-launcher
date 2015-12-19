Friend Class frmWelcome

    'GT. 21.02.2010 -- revision of class code is completed.
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        frmWelcomeFinish.Show()
        Me.Close()
    End Sub

    Private Sub frmWelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim font As Font = welcomeText.Font

        Dim newFontSize As Single = Font.Size * (clsRender.defaultFontResolution / clsRender.getDPI)
        welcomeText.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.


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
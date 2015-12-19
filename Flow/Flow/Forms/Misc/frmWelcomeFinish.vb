'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmWelcomeFinish
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        frmTutorialStep1.StartPosition = FormStartPosition.CenterScreen
        frmTutorialStep1.Show()
    End Sub

    Private Sub btnNothanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNothanks.Click
        MsgBox("If you need to review the tutorial at a later time, it can be accessed from the Help menu." & vbLf & vbLf & "REMEMBER: To show / hide Flow you must hold down the ALT key and Q at the same time. Enjoy!")

        clsFlowGeneral.initializeFlow()
        Me.Close()
    End Sub

    Private Sub frmWelcomeFinish_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim radManager As New Telerik.WinControls.RadThemeManager
        'Dim themeSrc As New Telerik.WinControls.ThemeSource
        'themeSrc.ThemeLocation = My.Resources.ButtonTheme

        'radManager.LoadedThemes.Add(themeSrc)

        'MessageBox.Show(radManager.LoadedThemes.Count.ToString)

        'themeSrc.SetValue(Telerik.WinControls.VisualElement.FontProperty, "Courier New, 1.75pt")
        'MessageBox.Show(themeSrc.GetValue(Telerik.WinControls.VisualElement.FontProperty).ToString)

        Dim font As Font = Label1.Font
        'Dim font1 As Font
        Dim ratio As Single = clsRender.defaultFontResolution / clsRender.getDPI

        Dim newFontSize As Single = font.Size * ratio / 1.05
        Label1.Font = New Font(font.Name, newFontSize)


        'font1 = btnOK.Font
        'newFontSize = font1.Size * ratio
        'btnOK.Font = New Font(font1.Name, newFontSize * 2)
        'btnNothanks.Font = New Font(font1.Name, newFontSize)



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

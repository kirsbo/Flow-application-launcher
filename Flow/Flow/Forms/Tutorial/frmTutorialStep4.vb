'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmTutorialStep4

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click, btnClose.Click
        'If My.Settings.IsFirstTimeAppRuns = True Then  
        'If clsFlowGeneral.IsFirstRun = True Then 'GT. 16.02.2010 -- Alternative for My.Settings.IsFirstTimeAppRuns
        '    clsFlowGeneral.firstRun()
        '    frmWelcomeFinish.Close()
        'End If
        frmWelcomeFinish.Close()
        frmTutorialStep1.Close()
        frmTutorialStep2.Close()
        frmTutorialStep3.Close()
        clsFlowGeneral.initializeFlow()
        Me.Close()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'GT. 03.03.2010 -- the same stuff as we do on btnDone click
        'frmWelcomeFinish.Close()
        'frmTutorialStep1.Close()
        'frmTutorialStep2.Close()
        'frmTutorialStep3.Close()
        'Me.Close()
    End Sub

    Private Sub frmTutorialStep4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Location = frmUI.Location
        Me.StartPosition = FormStartPosition.CenterParent 'GT. 13.06.2010 -- to prevent form's showing on the left top of the screen.
        If frmHelp.Visible = True Then
            Me.Location = frmUI.Location
        End If
        Dim font As Font = Label1.Font
        Dim newFontSize As Single = font.Size * (clsRender.defaultFontResolution / clsRender.getDPI)
        Label1.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.
        Label2.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.
        Label3.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.
        Label6.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.
        Label7.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.
        Label8.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.

        font = Label9.Font
        newFontSize = font.Size * (clsRender.defaultFontResolution / clsRender.getDPI)
        Label9.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.

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

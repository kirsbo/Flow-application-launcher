Imports ErrorHandling

'GT. 21.02.2010 -- revision of class code is completed.
Friend Class frmSplash
    Friend fadeCompleted As Boolean = False
    Friend formToLoad As String
    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'clsUnhandledExceptionManager.AddHandler() 'GT. 07.02.2010 -- Unhandled Exception Manager Handler added. ' GT. 05.12.2010 -- Error handling component has been removed
        If My.Settings.ShowSplashScreen = True Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Minimized
        End If

        Dim font As Font = labelCopyright.Font
        Dim newFontSize As Single = font.Size * (clsRender.defaultFontResolution / clsRender.getDPI)
        labelCopyright.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.


        'If clsExpireDateMechanism.Activated Then
        labelCopyright.Text = "          Flow " & My.Settings.Version & " " & My.Settings.Edition & " - Vitesse Digital Ltd. All rights reserved. Registered version."
        'Else
        '    Dim trialPeriod As Integer = clsExpireDateMechanism.getTrialPeriod
        '    labelCopyright.Text = "     Flow " & My.Settings.Version & " " & My.Settings.Edition & " - Vitesse Digital Ltd. All rights reserved. " & trialPeriod & " days left in your trial."
        'End If
        timerFadeIn.Start()
    End Sub

    Private Sub timerFadeIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerFadeIn.Tick
        If fadeCompleted = False Then
            Me.Opacity += 0.1
            If Me.Opacity = 1 Then fadeCompleted = True
        Else
            timerFadeIn.Stop()
            timerLoadApplication.Start()
        End If
    End Sub

    Private Sub timerLoadApplication_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerLoadApplication.Tick
        'Dim frmMain As New frmUI
        timerLoadApplication.Stop()
        timerFadeOut.Start()
    End Sub

    Private Sub timerFadeOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerFadeOut.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            timerFadeOut.Stop()
            'If My.Settings.IsFirstTimeAppRuns = True Then
            If clsFlowGeneral.IsFirstRun = True Then 'GT. 16.02.2010 -- Alternative for My.Settings.IsFirstTimeAppRuns
                clsFlowGeneral.firstRun()
            Else
                clsFlowGeneral.initializeFlow()
            End If
            'Me.Hide()
        End If
    End Sub
End Class

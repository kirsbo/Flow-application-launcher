'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmTutorialStep2

    Private Sub btnCanIMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanIMake.Click
        If LCase(btnCanIMake.Text) = "ok, got it" Then
            btnCanIMake.Text = "OK, but how do I know what an icon does?"
            pboxSwitchLayout.Visible = False
            labMouseover.Visible = False
            labMaintext.Visible = True
        Else
            btnCanIMake.Text = "OK, got it"
            pboxSwitchLayout.Visible = True
            labMouseover.Visible = True
            labMaintext.Visible = False
        End If


    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub

    Private Sub frmTutorialStep2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Location = frmUI.Location
        Me.StartPosition = FormStartPosition.CenterParent 'GT. 13.06.2010 -- to prevent form's showing on the left top of the screen.
        If frmHelp.Visible = True Then
            Me.Location = frmUI.Location
        End If

        Dim font As Font = Label1.Font
        Dim newFontSize As Single = font.Size * (clsRender.defaultFontResolution / clsRender.getDPI)
        Label1.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.

        font = Label2.Font
        newFontSize = font.Size * (clsRender.defaultFontResolution / clsRender.getDPI)
        Label2.Font = New Font(font.Name, newFontSize, font.Style)

        font = labMouseover.Font
        newFontSize = font.Size * (clsRender.defaultFontResolution / clsRender.getDPI)
        labMouseover.Font = New Font(font.Name, newFontSize, font.Style)
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        frmTutorialStep3.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmWelcomeFinish.Close()
        frmTutorialStep1.Close()
        clsFlowGeneral.initializeFlow() 'GT. 03.03.2010 -- we must initialize flow anyway when the user closes a tutorial screen
        Me.Close()
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

'GT. 21.02.2010 -- revision of class code is completed.
Friend Class frmTutorialStep1

    Private Sub btnChangeTriggerKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeTriggerKey.Click
        btnChangeTriggerKey.Visible = False
        labChangeKeyCombo.Visible = True
        pboxChangeKeyCombo.Visible = True
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        frmTutorialStep2.Show()
    End Sub

    Private Sub frmTutorialStep1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterParent 'GT. 13.06.2010 -- to prevent form's showing on the left top of the screen.
        If frmHelp.Visible = True Then
            Me.Location = frmUI.Location
        End If

        Dim font As Font = Label1.Font
        Dim newFontSize As Single = font.Size * (clsRender.defaultFontResolution / clsRender.getDPI) / 1.05
        Label1.Font = New Font(font.Name, newFontSize, font.Style) ' GT. 22.06.2010 - sets a font size of the welcome message corresponding to windows font size DPI.

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        clsFlowGeneral.initializeFlow() 'GT. 03.03.2010 -- we must initialize flow anyway when the user closes a tutorial screen
        frmWelcomeFinish.Close()
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

'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmSettings
    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = frmUI.Location
        InitControls()
        LoadSettings()
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        If triggerCombinationIsValid() = True Then
            saveSettings()
            Me.Close()
        End If
        Me.Location = frmUI.Location
    End Sub

    Private Sub saveSettings()
        My.Settings.TriggerKey = getTriggerKeyString()
        If radioSoundOn.Checked = True Then
            My.Settings.SoundEnabled = True
        Else
            My.Settings.SoundEnabled = False
        End If
        If radioDisplayLayoutHome.Checked = True Then
            My.Settings.RevertToHomeLayoutOnActivation = True
        Else
            My.Settings.RevertToHomeLayoutOnActivation = False
        End If

        If checkUpdates.Checked = True Then
            My.Settings.AutoUpdates = True
        Else
            My.Settings.AutoUpdates = False
        End If
        My.Settings.Save()

        If splashScreen.Checked = True Then
            My.Settings.ShowSplashScreen = True
        Else
            My.Settings.ShowSplashScreen = False
        End If
        clsGlobalHotKeys.unregisterHotkeys()
        clsGlobalHotKeys.registerHotkeys()
    End Sub ' saves settings to user.confif file

#Region "Trigger key validation methods"


    Private Function triggerCombinationIsValid() As Boolean
        If checkControl.Checked = True And checkAlt.Checked = True And checkWinkey.Checked = True Then
            MsgBox("You can only select 2 modifiers (CTRL, ALT, Winkey) at a time.")
            Return False
        End If
        If txtTriggerKey.Text.Length = 0 Then
            MsgBox("You need to select a trigger key before saving.")
            Return False
        End If

        If triggerCombinationIsIllegal() = True Then
            Return False
        Else
            Return True
        End If


    End Function

    Private Function triggerCombinationIsIllegal() As Boolean
        Dim triggerKeyString = getTriggerKeyString()
        Dim illegalCombinationFound As Boolean = False

        Select Case LCase(triggerKeyString)
            Case "ctrl-c", "ctrl-v", "ctrl-z", "ctrl-y", "ctrl-x", "ctrl-s"
                illegalCombinationFound = True
            Case "win-f", "win-e"
                illegalCombinationFound = True
        End Select

        If illegalCombinationFound = True Then
            MsgBox("The " & triggerKeyString & " key combination is reserved by Windows. Please select another combination.")
            Return True
        Else
            Return False
        End If
    End Function 'Returns true if the trigger combination contains illegal combinations (reserved by the OS, like ctrl+z, ctrl+c, win+e etc)

#End Region

    Private Function getTriggerKeyString() As String
        Dim strCombination As String = ""

        If checkControl.Checked = True Then
            strCombination = strCombination & "Ctrl" & "-"
        End If
        If checkAlt.Checked = True Then
            strCombination = strCombination & "Alt" & "-"
        End If
        If checkWinkey.Checked = True Then
            strCombination = strCombination & "Win" & "-"
        End If
        strCombination = strCombination & txtTriggerKey.Text.ToUpper()
        Return strCombination
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

#Region "Form initialization"
    Private Sub InitControls()
        checkAlt.Checked = False
        checkControl.Checked = False
        checkWinkey.Checked = False
        checkUpdates.Checked = False
        txtTriggerKey.Text = ""

    End Sub

    Private Sub LoadSettings()
        Dim strCombination As String

        strCombination = My.Settings.TriggerKey

        If strCombination.ToUpper.Contains("CTRL") Then checkControl.Checked = True
        If strCombination.ToUpper.Contains("ALT") Then checkAlt.Checked = True
        If strCombination.ToUpper.Contains("WIN") Then checkWinkey.Checked = True

        txtTriggerKey.Text = strCombination.Substring(strCombination.LastIndexOf("-") + 1, 1)

        If My.Settings.SoundEnabled = True Then
            radioSoundOn.Checked = True
        Else
            radioSoundoff.Checked = True
        End If

        If My.Settings.RevertToHomeLayoutOnActivation = True Then
            radioDisplayLayoutHome.Checked = True
        Else
            radioDisplayLayoutPrevious.Checked = True
        End If

        If My.Settings.AutoUpdates = True Then
            checkUpdates.Checked = True
        Else
            checkUpdates.Checked = False
        End If

        If My.Settings.ShowSplashScreen = True Then
            splashScreen.Checked = True
        Else
            splashScreen.Checked = False
        End If
    End Sub
#End Region

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
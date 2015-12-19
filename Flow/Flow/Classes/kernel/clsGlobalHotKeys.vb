Option Explicit On
'Option Strict On

Imports System.Runtime.InteropServices
Imports System.Diagnostics

'GT. 21.02.2010 -- revision of class code is completed.

' Kernel class is for storing WinAPI constant and declarations, subs for hotkey capturing,
' hotkey registration and unregistration.

Public Class clsGlobalHotKeys

#Region "Hotkey capture constants"
    '#########################

    ''' <summary>
    ''' Contains costant declarations.
    ''' </summary>

    Private Const KEYEVENTF_EXTENDEDKEY As Integer = &H1
    Private Const KEYEVENTF_KEYUP As Integer = &H2
    Public Const WM_HOTKEY As Integer = &H312
#End Region

#Region "Virtual key codes"
    'Vitrual-key codes
    Private Const VK_RBUTTON As Integer = &H2 ' Right mouse button
    Private Const VK_CANCEL As Integer = &H3 ' Ctrl-Break processing
    Private Const VK_BACK As Integer = &H8 'Backspace key
    Private Const VK_TAB As Integer = &H9 ' Tab key
    Private Const VK_RETURN As Integer = &HD 'Enter key
    Private Const VK_SHIFT As Integer = &H10 'Shift key
    Private Const VK_CONTROL As Integer = &H11 'Ctrl key
    Private Const VK_MENU As Integer = &H12 'Alt key
    Private Const VK_PAUSE As Integer = &H13 'Pause key
    Private Const VK_CAPITAL As Integer = &H14 'Caps Lock key
    Private Const VK_ESCAPE As Integer = &H1B 'Escape key
    Private Const VK_SPACE As Integer = &H20 'Spacebar key
    Private Const VK_PRIOR As Integer = &H21 'PageUp key
    Private Const VK_NEXT As Integer = &H22 'PageDown key
    Private Const VK_END As Integer = &H23 'End key
    Private Const VK_HOME As Integer = &H24 'Home key
    Private Const VK_LEFT As Integer = &H25 'Left arrow key
    Private Const VK_UP As Integer = &H26 'Up arrow key
    Private Const VK_RIGHT As Integer = &H27 'Right arrow key
    Private Const VK_DOWN As Integer = &H28 'Down arrow key
    Private Const VK_SELECT As Integer = &H29 'Select key
    Private Const VK_EXECUTE As Integer = &H2B 'Execute key
    Private Const VK_SNAPSHOT As Integer = &H2C 'Print screen key
    Private Const VK_INSERT As Integer = &H2D 'Insert key
    Private Const VK_DELETE As Integer = &H2E 'Delete key
    Private Const VK_HELP As Integer = &H2F 'Help key
    Private Const VK_LWIN As Integer = &H5B 'Left Windows key on a Microsoft Natural Keyboard
    Private Const VK_RWIN As Integer = &H5C 'Right Windows key on a Microsoft Natural Keyboard

    Private Const VK_NUMPAD0 As Integer = &H60
    Private Const VK_NUMPAD1 As Integer = &H61
    Private Const VK_NUMPAD2 As Integer = &H62
    Private Const VK_NUMPAD3 As Integer = &H63
    Private Const VK_NUMPAD4 As Integer = &H64
    Private Const VK_NUMPAD5 As Integer = &H65
    Private Const VK_NUMPAD6 As Integer = &H66
    Private Const VK_NUMPAD7 As Integer = &H67
    Private Const VK_NUMPAD8 As Integer = &H68
    Private Const VK_NUMPAD9 As Integer = &H69
    Private Const VK_NUMPADMULTIPLY As Integer = &H6A ' Numpad multiply key
    Private Const VK_NUMPADENTER As Integer = &HD ' Numpad enter key
    Private Const VK_ADD As Integer = &H6B 'Numpad add key
    Private Const VK_SEPARATOR As Integer = &H6C 'Numpad separator key
    Private Const VK_NUMPADSUBTRACT As Integer = &H6D ' Numpad subtract key
    Private Const VK_DECIMAL As Integer = &H6E 'Numpad decimal key
    Private Const VK_DIVIDE As Integer = &H6F 'Numpad divide key

    Private Const VK_F1 As Integer = &H70 ' F1 key
    Private Const VK_F2 As Integer = &H71 ' F2 key
    Private Const VK_F3 As Integer = &H72 ' F3 key
    Private Const VK_F4 As Integer = &H73 ' F4 key
    Private Const VK_F5 As Integer = &H74 ' F5 key
    Private Const VK_F6 As Integer = &H75 ' F6 key
    Private Const VK_F7 As Integer = &H76 ' F7 key
    Private Const VK_F8 As Integer = &H77 ' F8 key
    Private Const VK_F9 As Integer = &H78 ' F9 key
    Private Const VK_F10 As Integer = &H79 ' F10 key
    Private Const VK_F11 As Integer = &H7A ' F11 key
    Private Const VK_F12 As Integer = &H7B ' F12 key

    Private Const VK_NUMLOCK As Integer = &H90 ' Numlock key
    Private Const VK_SCROLL As Integer = &H91 'Scroll lock key
    Private Const VK_LSHIFT As Integer = &HA0 ' Left shift
    Private Const VK_RSHIFT As Integer = &HA1 ' Right shift
    Private Const VK_LCONTROL As Integer = &HA2 ' Left Ctrl
    Private Const VK_RCONTROL As Integer = &HA3 ' Right Ctrl
    Private Const VK_LMENU As Integer = &HA4 ' Left Alt
    Private Const VK_RMENU As Integer = &HA5 ' Right Alt

    Private Const VK_PLAY As Integer = &HFA ' Play key
#End Region

#Region "Modifiers codes"
    ' Modifiers codes
    Private Const MOD_NONE As Integer = 0
    Private Const MOD_ALT As Integer = &H1 'Alt key
    Private Const MOD_CONTROL As Integer = &H2 ' Ctrl key
    Private Const MOD_SHIFT As Integer = &H4 ' Shift key
    Private Const MOD_WIN As Integer = &H8 ' Win key
#End Region


#Region "Hotkey and keyboard API declarations"
    '###########################
    ''' <summary>
    ''' Wrappers to winAPI functions. Function is used to registration hotkeys, simulate a keypress
    ''' </summary>
    Public Declare Function RegisterHotKey Lib "user32" _
    (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer

    Public Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    Private Declare Sub keybd_event Lib "user32" _
    (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)

    'Private Declare Function GetKeyboardState Lib "user32" (ByVal pbKeyState As Byte) As Long
    'Private Declare Function SetKeyboardState Lib "user32" (ByVal lppbKeyState As Byte) As Long

#End Region


    Private Shared bCapsLockRevert As Boolean
    Private Shared sCapsLockStartStatus As String
    Private Shared sCapsLockCurrentStatus As String

    Private Enum KeysWithStatus
        CapsLock = VK_CAPITAL
        NumLock = VK_NUMLOCK
        ScrollLock = VK_SCROLL
    End Enum

#Region "Exposed properties"

    ''' <summary>
    ''' Defines necessity for revert Caps Lock state
    ''' </summary>
    ''' <returns>false if Caps Lock state needs to revert, true otherwise</returns>

    Public Shared Property CapsLockRevert() As Boolean
        Get
            Return bCapsLockRevert
        End Get
        Set(ByVal value As Boolean)
            bCapsLockRevert = value
        End Set
    End Property

    Public Shared Property CapsLockStartStatus() As String
        Get
            Return sCapsLockStartStatus
        End Get
        Set(ByVal value As String)
            sCapsLockStartStatus = value
        End Set
    End Property

    Public Shared Property CapsLockCurrentStatus() As String
        Get
            Return sCapsLockCurrentStatus
        End Get
        Set(ByVal value As String)
            sCapsLockCurrentStatus = value
        End Set
    End Property
#End Region

    Shared Sub New()
        CapsLockRevert = False
        CapsLockStartStatus = CapsLockIndicator()
        CapsLockCurrentStatus = Nothing
    End Sub

    Public Shared Sub handleHotKeyEvent(ByVal hotkeyID As IntPtr)
        If frmUI.Visible = True Then
            clsFlowGeneral.hideFlow()
        Else
            clsFlowGeneral.displayFlow()
        End If
    End Sub

#Region "subs related to the caps lock support"

    Public Shared Function CapsLockIndicator() As String
        If Control.IsKeyLocked(Keys.CapsLock) Then
            '           MessageBox.Show("Caps Lock is on")
            Return "Caps Lock is on"
        Else
            '          MessageBox.Show("Caps Lock is off")
            Return "Caps Lock is off"
        End If
    End Function

    Public Shared Sub _handleHotKeyEvent(ByVal hotkeyID As IntPtr)
        Select Case (hotkeyID.ToString)
            Case "9" 'Trigger key event
                If getVKCode(My.Settings.TriggerKey) = KeysWithStatus.CapsLock Then
                    'Revert status of CapsLock
                    If CapsLockRevert = False Then
                        If frmUI.Visible = True Then
                            clsFlowGeneral.hideFlow()
                        Else
                            clsFlowGeneral.displayFlow()
                        End If
                        If CapsLockCurrentStatus <> CapsLockStartStatus Then
                            revertCapsLock()
                            CapsLockRevert = True
                        End If
                    Else
                        CapsLockRevert = False
                    End If
                Else
                    If frmUI.Visible = True Then
                        clsFlowGeneral.hideFlow()
                    Else
                        clsFlowGeneral.displayFlow()
                    End If
                End If
        End Select
    End Sub

    ''' <summary>
    '''CapsLock handling
    ''' </summary>
    Public Shared Sub revertCapsLock()
        'need for some reason
        System.Threading.Thread.Sleep(100)
        'MessageBox.Show("Reverts Caps Lock key")
        'Simulate the Key Press
        keybd_event(System.Windows.Forms.Keys.CapsLock, &H14, KEYEVENTF_EXTENDEDKEY Or 0, 0)
        ' Simulate the Key Release
        keybd_event(System.Windows.Forms.Keys.CapsLock, &H14, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    End Sub

    Public Shared Function getVKCode(ByVal triggerKey As String) As Integer
        'Dim triggerKey As String = clsFlowGeneral.TriggerKey
        Dim result As Integer

        If getModifiers(triggerKey) = MOD_NONE Then
            Select Case (triggerKey.ToLower)
                Case "capslock"
                    result = VK_CAPITAL
                Case "numlcok"
                    result = VK_NUMLOCK
                Case "scrolllock"
                    result = VK_SCROLL
                Case "f1"
                    result = VK_F1
                Case "f2"
                    result = VK_F2
                Case "f3"
                    result = VK_F3
                Case "f4"
                    result = VK_F4
                Case "f5"
                    result = VK_F5
                Case "f6"
                    result = VK_F6
                Case "f7"
                    result = VK_F7
                Case "f8"
                    result = VK_F8
                Case "f9"
                    result = VK_F9
                Case "f10"
                    result = VK_F10
                Case "f11"
                    result = VK_F11
                Case "f12"
                    result = VK_F12
                Case "tab"
                    result = VK_TAB
                Case "context"
                    result = VK_RBUTTON
                Case Else 'Virtual keys for keyboard keys: '0'..'9', 'A'..'Z' withoht modifiers
                    result = Asc(triggerKey.ToUpper)
            End Select

        Else 'Virtual keys for keyboard keys: '0'..'9', 'A'..'Z' with modifiers
            Dim startIndex As Integer = triggerKey.ToUpper.IndexOf("-") + 1
            Dim subTriggerString As String = triggerKey.ToUpper.Substring(startIndex)
            startIndex = subTriggerString.ToUpper.IndexOf("-")
            If startIndex = -1 Then ' two-key comination
                result = Asc(subTriggerString)
            Else
                result = Asc(subTriggerString.Substring(startIndex + 1))
            End If
        End If
        Return result

    End Function


#End Region 'not used in the flow 0.8

    Public Shared Function getModifiers(ByVal triggerKey As String) As Integer
        'Dim triggerKey As String = clsFlowGeneral.TriggerKey
        Dim result As Integer

        result = MOD_NONE
        If triggerKey.ToLower.Contains("alt") Then
            result = result + MOD_ALT
        End If
        If triggerKey.ToLower.Contains("ctrl") Then
            result = result + MOD_CONTROL
        End If
        If triggerKey.ToUpper.ToLower.Contains("shift") Then
            result = result + MOD_SHIFT
        End If
        If triggerKey.ToLower.Contains("win") Then
            result = result + MOD_WIN
        End If

        Return result

    End Function

#Region "Hotkey registration and unregistration"
    Public Shared Sub registerHotkeys()
        RegisterHotKey(frmUI.Handle, 9, getModifiers(My.Settings.TriggerKey), getVKCode(My.Settings.TriggerKey)) 'must be commented out when using locale builder
        'RegisterHotKey(frmUI.Handle, 9, MOD_NONE, VK_CAPITAL) 
    End Sub
    Public Shared Sub unregisterHotkeys()
        UnregisterHotKey(frmUI.Handle, 9)
    End Sub
#End Region

End Class
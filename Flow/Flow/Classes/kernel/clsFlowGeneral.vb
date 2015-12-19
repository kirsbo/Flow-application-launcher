Option Explicit On
'Option Strict On

Imports Microsoft.Win32

'GT. 21.02.2010 -- revision of class code is completed.

' Kernel class is used for general tasks, such as initialization, error handling
' and similar. It also handles hotkey registration.


Public Class clsFlowGeneral

    Private Shared mxCulture As New Xml.XmlDocument
    Private Shared sClipboardData As String 'MK 20.01.10

    Private Shared startTimeStamp As TimeSpan
    Private Shared stopTimeStamp As TimeSpan

    Private Shared mutex As System.Threading.Mutex
    Private Shared bIsFirstRun As Boolean 'GT. 16.02.2010 -- For the settings files removing under non-admin user
    Public Const flowRegistryKey As String = "Software\Microsoft\MediaPlayer\Objects\Text"


#Region " Exposed Properties "
    Public Shared Property UserCulture() As Xml.XmlDocument
        Get
            Return mxCulture
        End Get
        Set(ByVal value As Xml.XmlDocument)
            mxCulture = value
        End Set
    End Property

    Public Shared Property ClipboardDataFromActiveApp() As String
        Get
            Return sClipboardData
        End Get
        Set(ByVal value As String)
            sClipboardData = value
        End Set
    End Property


    Public Shared Property IsFirstRun() As Boolean

        Get
            Dim regKey As RegistryKey
            'regKey = Registry.LocalMachine.OpenSubKey(clsExpireDateMechanism.flowRegistryKey, False) 'GT. 05.12.2010
            regKey = Registry.LocalMachine.OpenSubKey(flowRegistryKey, False)
            If 0 = regKey.GetValue("helpIndex", 0) Then
                Return True
            Else
                Return False
            End If

            Return bIsFirstRun
        End Get
        Set(ByVal value As Boolean)
            Dim regKey As RegistryKey
            'regKey = Registry.LocalMachine.OpenSubKey(clsExpireDateMechanism.flowRegistryKey, True)
            regKey = Registry.LocalMachine.OpenSubKey(flowRegistryKey, True) 'GT. 05.12.2010
            If True = value Then
                regKey.SetValue("helpIndex", 0)
            Else
                regKey.SetValue("helpIndex", 1)
            End If
        End Set
    End Property
#End Region

#Region "Flow Initialization"

    Public Shared Sub initializeFlow()
        'If Not clsExpireDateMechanism.Activated Then 'GT. 02.02.2010 -- check the activation status in the registry
        '    If clsExpireDateMechanism.trialPeriodExpired Then
        '        'activationForm.BringToFront()
        '        frmActivation.ShowDialog()
        '    End If
        'End If
        'startTimeStamp = Now.TimeOfDay 'GT 04.02.2010 -- for the expire date mechanism support
        clsGlobalHotKeys.registerHotkeys()

        If My.Settings.IsFirstTimeAppRuns = True Then 'GT 07.03.2010 -- saving local user settings (see task #121)
            firstRun()
        End If

        loadCulture()
        'loadFlowControlIcons() 'GT. 08.03.2010 --actually it's an empty method.

        clsAppSearch.Search()

        clsLayoutManager.loadDefaultLayout()

        'Must be after load default layout
        clsOSK.preparingForPhysicalKeyBuilding()
        clsOSK.buildPhysicalKeysArray()


        'If clsExpireDateMechanism.Activated Then
        '    frmUI.contextMainMenu.Items.Item(6).Visible = False 'hiding "Register product" menu item
        'End If

        'GT. 11.02.2010 -- creates a mutex object to prevent the installation upgrade or  
        'unistallation process when the flow is running
        mutex = New System.Threading.Mutex(False, "flowMutex")
        If mutex Is Nothing Then
            MessageBox.Show("Mutex object creation error")
        End If
    End Sub

#End Region

    Public Shared Sub firstRun()
        '## SHOULD BE ENABLED FOR RELEASE 
        My.Settings.InstalledPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & _
        "\" & "Vitesse Digital\Flow\" 'GT. 16.02.2010 --

        '## SHOULD BE ENABLED FOR DEBUG 
        'My.Settings.InstalledPath = Application.StartupPath & "\"

        clsDefaultLayoutConfigurator.createDefaultLayout("Start.xml")
        clsDefaultLayoutConfigurator.createMicrosoftOfficeLayout("MS Office.xml")

        clsFlowGeneral.IsFirstRun = False 'GT. 16.02.2010 -- Alternative for My.Settings.IsFirstTimeAppRuns
        My.Settings.IsFirstTimeAppRuns = False
        My.Settings.DefaultLayoutFilename = "Start.xml"
        My.Settings.Save() 'GT. 09.02.2010 

        frmWelcome.Show()
    End Sub 'Runs the first time the user runs Flow

    'Private Shared Sub loadFlowControlIcons()
    '    'frmUI.PictureBox1.Image = My.Resources.Minimize 'Setting the Escape key's "Minimize" icon
    '    'frmUI.PictureBox38.Image = My.Resources.GoToDefaultLayout 'Setting the Backspace key's "Go to default layout" icon
    'End Sub

    Public Shared Sub loadCulture()
        'Dim currentCulture As String = InputLanguage.CurrentInputLanguage.Culture.IetfLanguageTag
        Dim currentCulture As String = InputLanguage.CurrentInputLanguage.Culture.Name 'GT. 07.07.2010
        'MessageBox.Show(System.Globalization.CultureInfo.CurrentCulture.Name)
        'MessageBox.Show(InputLanguage.CurrentInputLanguage.Culture.Name)
        currentCulture = InputLanguage.CurrentInputLanguage.Culture.Name
        Dim cultureFilePath As String = My.Settings.InstalledPath & My.Settings.PathCultures & currentCulture & ".xml"
        Dim installpath As String = My.Settings.InstalledPath

        If IO.File.Exists(cultureFilePath) = False Then
            'Setting default culture

            cultureFilePath = My.Settings.InstalledPath & My.Settings.PathCultures & "en-US.xml"
        End If
        mxCulture.Load(cultureFilePath)
        My.Settings.CultureName = currentCulture
        My.Settings.Save()
    End Sub


    Public Shared Function getKeyTextFromFlowCode(ByVal flowKeyCode As Integer) As String
        Dim labelText As String = clsOSK.physicalKeys(flowKeyCode).keyText
        If labelText.Length = 1 Then
            Return UCase(labelText)
        Else
            Return labelText
        End If
    End Function 'Gets the local culture's text value for a specific flowKeyCode

    Public Shared Function getTimeOfFlowRunning() As TimeSpan
        Return stopTimeStamp - startTimeStamp
    End Function

#Region "Flow termination"
    'Contains flow termination sub
    Public Shared Sub closeFlow()
        clsGlobalHotKeys.unregisterHotkeys()
        frmSplash.Close()
        stopTimeStamp = Now.TimeOfDay

        'clsExpireDateMechanism.updateUsagePeriod()  -- GT. 05.12.2010 
    End Sub
#End Region

#Region "Flow hide and display handling"

    Public Shared Sub hideFlow()
        frmUI.Hide()
        frmUI.menuitemShowHide.Image = My.Resources.LogoSmall
        frmUI.menuitemShowHide.Text = "Activate Flow"
        clsRender.clearCommandDisplay()
        mutex = New System.Threading.Mutex(False, "flowMutex")
    End Sub

    Private Shared firstOskDisplayInRun As Boolean = True
    Public Shared Sub displayFlow()
        'MK 20/01/2010 added functionality for grabbing what the user has selected in his active application
        'captureClipboardDataFromActiveApp() 'MK 28/01/2010 commmented out as it gave some errors, needs reworking

        'If it's first time OSK is shown (in the current session), then load default layout, else we encounter a strange error where all icons are in topleft of screen
        If firstOskDisplayInRun = True Then
            clsLayoutManager.loadDefaultLayout()
            firstOskDisplayInRun = False
        Else
            If My.Settings.RevertToHomeLayoutOnActivation = True Then clsLayoutManager.loadDefaultLayout()
        End If

        frmUI.menuitemShowHide.Image = My.Resources.iconLargeMinimize
        frmUI.menuitemShowHide.Text = "Hide Flow"

        loadCulture()
        clsOSK.buildPhysicalKeysArray()
        frmUI.Show()
        frmUI.BringToFront()
        frmUI.Activate()
        frmUI.Focus()

        clsSound.playSound(clsSound.sounds.DisplayFlow)

    End Sub

    Private Shared Sub captureClipboardDataFromActiveApp()
        'This sub is used when displaying Flow: It grabs whatever data the user has
        'selected in his current application and saves it to a public property in
        'clsFlowGeneral. This data can then be used by command handlers. After the 
        'selected data is saved, we put whichever content the user might have had already
        'in their clipboard, back into the clipboard.
        'Added by MK 20/01/2010

        Dim currentClipBoardData As Object = Clipboard.GetDataObject

        SendKeys.SendWait("^c") 'Send control C
        'If Clipboard.GetFileDropList.Count = 0 Then MsgBox("not a file")
        For Each fileName In Clipboard.GetFileDropList()
            Debug.Write(fileName)
        Next

        ClipboardDataFromActiveApp = Clipboard.GetText

        Clipboard.SetDataObject(currentClipBoardData)
    End Sub
#End Region

#Region "Error handling"

    Public Shared Sub exceptionHandler(ByVal ex As Exception)
        writeToErrorLog(ex.ToString)
        MsgBox("An exception occured - Please check ErrorLog.txt")
    End Sub 'Logs exception and displays a messagebox

    Private Shared Sub writeToErrorLog(ByVal errorText As String)
        Dim objWriter As New System.IO.StreamWriter(Application.StartupPath() & "\ErrorLog.txt", True)
        objWriter.WriteLine(Now() & ": " & errorText & vbLf & vbLf & "------------------------------") 'Writing timestamp and error message
        objWriter.Close()
    End Sub 'Writes text to ErrorLog.txt

#End Region

End Class

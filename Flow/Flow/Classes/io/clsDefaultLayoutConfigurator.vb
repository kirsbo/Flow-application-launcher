Option Explicit On
Option Strict On

''GT. 21.02.2010 -- revision of class code is completed.

' Class is used to create default layouts
Public Class clsDefaultLayoutConfigurator

    Private Shared xmlDocumentNewDefaultLayout As New Xml.XmlDocument

    Public Shared Property DefaultLayout() As Xml.XmlDocument
        Get
            Return xmlDocumentNewDefaultLayout
        End Get
        Set(ByVal value As Xml.XmlDocument)
            xmlDocumentNewDefaultLayout = value
        End Set
    End Property

    'Creates default layout with flow keys: google, notepad, calculator, solitaire, my documents, media player
    'Actually we need "Control panel" key on this layout as well.
    Public Shared Sub createDefaultLayout(ByVal layoutFileName As String)
        Dim newLayoutFile As New Xml.XmlDocument
        Dim commandXML As Xml.XmlNode
        Dim flowKey As Integer

        Dim system32Folder As String = Environment.GetFolderPath(Environment.SpecialFolder.System)
        Dim windowsFolder As String = system32Folder.Remove(system32Folder.Length - 9, 9)
        Dim programFilesFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        Dim myDocumentsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        If My.Settings.IsFirstTimeAppRuns = True Then
            'If clsFlowGeneral.IsFirstRun = True Then
            newLayoutFile.Load(My.Settings.InstalledPath & My.Settings.PathXmlTemplates & "CommandLayout.xml")

            'flowKey = 77 'X key
            'commandXML = clsCommandHandlers.createCommandXMLForLaunchHandler("rundll32 shell32,Control_RunDLL")
            'clsKeyConfigurator.editCommandKey(flowKey, "Open Control Panel", "Default\folder.png", "launchHandler", commandXML, newLayoutFile)
            flowKey = 47 'O key
            commandXML = clsCommandHandlers.createCommandXMLForChangeLayoutHandler("MS Office.xml")
            clsKeyConfigurator.editCommand(flowKey, "Switch to Office layout", "Applications\MSOffice.png", "changeLayoutHandler", commandXML, newLayoutFile)

            flowKey = 64 'G key
            commandXML = clsCommandHandlers.createCommandXMLForLaunchHandler("www.google.com")
            clsKeyConfigurator.editCommand(flowKey, "Open www.google.com", "Websites\www.google.com.png", "launchHandler", commandXML, newLayoutFile)

            flowKey = 81 'N key
            commandXML = clsCommandHandlers.createCommandXMLForLaunchHandler(windowsFolder & "\notepad.exe")
            clsKeyConfigurator.editCommand(flowKey, "Run Notepad", "Applications\notepad.png", "launchHandler", commandXML, newLayoutFile)

            flowKey = 78 'C key
            commandXML = clsCommandHandlers.createCommandXMLForLaunchHandler(system32Folder & "\calc.exe")
            clsKeyConfigurator.editCommand(flowKey, "Run Calculator", "Applications\calculator.png", "launchHandler", commandXML, newLayoutFile)

            flowKey = 61 'S key
            Select Case LCase(clsWinInfo.getWindowsVersion)
                Case "windows xp", "Windows server 2003"
                    commandXML = clsCommandHandlers.createCommandXMLForLaunchHandler(system32Folder & "\FreeCell.exe")
                Case "windows vista", "windows server 2008", "windows 7"
                    commandXML = clsCommandHandlers.createCommandXMLForLaunchHandler(programFilesFolder & "\Microsoft Games\FreeCell\FreeCell.exe")
            End Select
            clsKeyConfigurator.editCommand(flowKey, "Run Solitaire", "Applications\freecell.png", "launchHandler", commandXML, newLayoutFile)

            flowKey = 82 'M key
            commandXML = clsCommandHandlers.createCommandXMLForLaunchHandler(programFilesFolder & "\Windows Media Player\wmplayer.exe")
            clsKeyConfigurator.editCommand(flowKey, "Run Windows Media Player", "Applications\wmp.png", "launchHandler", commandXML, newLayoutFile)

            flowKey = 62 'D key
            commandXML = clsCommandHandlers.createCommandXMLForLaunchHandler(myDocumentsFolder)
            clsKeyConfigurator.editCommand(flowKey, "Open My documents", "Default\folder.png", "launchHandler", commandXML, newLayoutFile)

            'Save the change
            Try
                newLayoutFile.Save(My.Settings.InstalledPath & My.Settings.PathCommandLayouts & layoutFileName)
            Catch ex As Exception
                'MessageBox.Show(ex.ToString)
            End Try

        End If 'isFirstRun = true
    End Sub

    Public Shared Sub createMicrosoftOfficeLayout(ByVal layoutFileName As String)
        Dim newLayoutFile As New Xml.XmlDocument
        Dim commandXML As Xml.XmlNode
        Dim flowKey() As Integer = {60, 41, 46, 81, 47, 48, 45, 40, 79}
        Dim commandPath As String
        'Dim applicationIconPath() As String
        Dim iconPath As String

        Dim officeName As clsMSOffice.officeType
        Dim application As clsMSOffice.msOfficeApplication
        Dim isMSOffiseInstalled As Boolean = False

        For officeName = clsMSOffice.officeType.Office97 To clsMSOffice.officeType.Office2010
            For application = clsMSOffice.msOfficeApplication.Access To clsMSOffice.msOfficeApplication.Word
                If clsMSOffice.isInstalled(application, officeName) Then
                    clsMSOffice.applicationPaths(application) = clsMSOffice.getApplicationPath(application)
                    isMSOffiseInstalled = True 'if the msoffice isn't installed, we don't have to create this layout
                End If
            Next
        Next

        If My.Settings.IsFirstTimeAppRuns = True Then
            'If clsFlowGeneral.IsFirstRun = True Then

            If isMSOffiseInstalled Then
                newLayoutFile.Load(My.Settings.InstalledPath & My.Settings.PathXmlTemplates & "CommandLayout.xml")

                For application = clsMSOffice.msOfficeApplication.Access To clsMSOffice.msOfficeApplication.Word
                    If clsMSOffice.applicationPaths(application) Is Nothing Then
                        ' do nothing
                    Else
                        commandPath = clsMSOffice.applicationPaths(application)
                        commandXML = clsCommandHandlers.createCommandXMLForLaunchHandler(commandPath)
                        If clsImages.exeIconExists(application.ToString & ".") Then 'if an application icons exist
                            iconPath = clsImages.appImgPath & application.ToString & ".png"
                        Else
                            iconPath = clsImages.defaultUnknownImg 'assign an icon by default, if it is not found
                        End If
                        clsKeyConfigurator.editCommand(flowKey(application), "Run " & application.ToString, iconPath, "launchHandler", commandXML, newLayoutFile)
                    End If
                Next

                'Save the change

                Try
                    newLayoutFile.Save(My.Settings.InstalledPath & My.Settings.PathCommandLayouts & layoutFileName)
                Catch ex As Exception
                    'MessageBox.Show(ex.ToString)
                End Try
            End If
        End If
    End Sub

End Class

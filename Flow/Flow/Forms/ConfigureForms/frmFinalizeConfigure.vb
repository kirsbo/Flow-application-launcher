Imports System.IO.Path

'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmFinalizeConfigure
    Public Shared selectedFilePath As String 'Path of the file selected in the FileDialog on the preceding form (frmConfigureKey)
    Public Shared selectedFolderPath As String 'Path of the folder selected in the FolderDialog on the preceding form (frmConfigureKey)
    Public Shared applicationPath As String 'Path of the .exe file selected in the FileDialog
    Public Shared applicationName As String ' Name of an appication selected in listInstalledApps
    Public Shared enteredURL As String
    Public Shared selectedLayoutPath As String 'Path of the folder selected in the FolderDialog on the preceding form (frmConfigureKey)

    Public Shared finalizeConfigureType As String
    Private sSelectedPath As String ' Command XML parameter

    Private commandName As String
    Public Shared commandImagePath As String 'Needs to be public, so it can be changed from the icon gallery if the user wants to

    Private Sub frmFinalizeConfigureFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DoubleBuffered = True
        Select Case finalizeConfigureType
            Case "file"
                commandName = getCommandNameFromFilename(selectedFilePath)
                commandImagePath = clsImages.getCommandImagePathFromFilename(selectedFilePath)
                sSelectedPath = selectedFilePath

            Case "folder"
                commandName = "Open " & selectedFolderPath
                commandImagePath = clsImages.defaultFolderImg
                sSelectedPath = selectedFolderPath
            Case "application"
                commandName = "Run " & applicationName
                sSelectedPath = applicationPath 'fullpath\appname.lnk
                applicationPath = commandImagePath 'fullpath\appname.exe or installer\appicon.exe
                extractIconFromApplication()
            Case "url"
                commandName = "Open " & enteredURL
                commandImagePath = getCommandImagePath()
                sSelectedPath = clsKeyConfigurator.getUriFromString(enteredURL).ToString  'GT. 22.03.2010 -- add "http://" prefix
                getCommandImagePath()
            Case "layout"
                commandName = getCommandName()
                commandImagePath = clsImages.defaultLayoutImg
        End Select

        labKeyIndicator.Text = clsRender.getConfigLabKeyText(clsFlowGeneral.getKeyTextFromFlowCode(clsKeyConfigurator.FlowKeyCodeToConfigure))
        btnImg.Image = Image.FromFile(clsImages.FullIconGalleryPath & commandImagePath) ' pboxIcon.
        Me.Location = frmUI.Location
    End Sub

#Region "Common for Configure forms"
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        'Select Case finalizeConfigureType
        '    Case "file", "folder", "layout"
        '        frmConfigureKey.ShowDialog()
        '    Case "application"
        '        'frmConfigureApp.listInstalledApps.Items.Clear()
        '        frmConfigureApp.ShowDialog()
        '    Case "url"
        '        frmConfigureUrl.txtURL.Text = enteredURL
        '        frmConfigureUrl.ShowDialog()
        'End Select

    End Sub
    Private Sub frmFinalizeConfigure_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, btnDone.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                btnDone_Click(sender, e)
            Case Keys.Escape
                btnBack_Click(sender, e)
        End Select
    End Sub
#End Region

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Dim commandXML As Xml.XmlNode
        Dim flowKeyCodeToConfigure As Integer

        Select Case finalizeConfigureType
            Case "layout"
                commandXML = clsCommandHandlers.createCommandXMLForChangeLayoutHandler(selectedLayoutPath)
                'Create a new layout, if it does not already exist (this means user chose to create a new layout,
                'instead of selecting an existing one).
                Dim commandLayoutPath As String = My.Settings.InstalledPath & My.Settings.PathCommandLayouts & selectedLayoutPath
                If System.IO.File.Exists(commandLayoutPath) = False Then
                    clsLayoutManager.createNewLayout(selectedLayoutPath)
                End If

            Case Else
                commandXML = clsCommandHandlers.createCommandXMLForLaunchHandler(sSelectedPath)
        End Select

        flowKeyCodeToConfigure = clsKeyConfigurator.FlowKeyCodeToConfigure

        Select Case finalizeConfigureType
            Case "layout"
                clsKeyConfigurator.editCommand(flowKeyCodeToConfigure, commandName, commandImagePath, "changeLayoutHandler", commandXML)
            Case Else
                clsKeyConfigurator.editCommand(flowKeyCodeToConfigure, commandName, commandImagePath, "launchHandler", commandXML)
        End Select

        frmUI.Show()

        frmConfigureKey.Close()
        If gCallingForm.Name = "frmConfigureNewLayout" Then frmConfigureExistingLayout.Close()
        gCallingForm.Close()
        Me.Close()
    End Sub

    Private Sub btnChooseFromGallery_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChooseFromGallery.Click, btnImg.Click
        If frmIconGallery.ShowDialog() = Windows.Forms.DialogResult.OK Then
            commandImagePath = clsKeyConfigurator.NewCommandIconPath
            btnImg.Image = Image.FromFile(clsImages.FullIconGalleryPath & commandImagePath)
        End If

    End Sub

#Region "Finalize file configure"
    Private Function getCommandNameFromFilename(ByVal selectedFilePath As String) As String
        If GetExtension(selectedFilePath) = ".exe" Then
            Return "Open " & GetFileNameWithoutExtension(selectedFilePath)
        Else
            Return "Open " & GetFileName(selectedFilePath)
        End If
    End Function

#End Region

#Region "Finalize application configure"
    Private Function extractIconFromApplication() As Boolean
        Dim destinationFolder As String = clsImages.appImgPath

        Try
            clsImages.extractAndSaveIconFromFile(applicationPath, applicationName, _
                clsImages.FullIconGalleryPath & clsImages.appImgPath)

            btnImg.Image = Image.FromFile(clsImages.FullIconGalleryPath & clsImages.appImgPath _
                                            & applicationName & clsImages.defaultImageFormat)

            commandImagePath = clsImages.appImgPath & applicationName & clsImages.defaultImageFormat
        Catch ex As Exception 'GT. 12.02.2010 -- rare exeption, rises when we try use a link of the unistalled application.
            'MessageBox.Show(ex.ToString)
            commandImagePath = clsImages.defaultUnknownImg
        End Try
    End Function
#End Region

#Region "Finalize configure url"
    Private Function getCommandImagePath() As String
        Try
            Dim convertedUri As System.Uri = clsKeyConfigurator.getUriFromString(enteredURL)
            clsImages.saveIconFromURLAndReturnPath(convertedUri)

            Dim websiteImageRelativePath = clsImages.webImgPath & convertedUri.Host & clsImages.defaultImageFormat
            Dim websiteImageAbsolutePath = clsImages.FullIconGalleryPath & websiteImageRelativePath


            If System.IO.File.Exists(websiteImageAbsolutePath) = True Then
                Return websiteImageRelativePath
            Else
                Return clsImages.defaultURLImg
            End If
        Catch ex As Exception 'If URI could not be converted for some reason
            Return clsImages.defaultURLImg
        End Try
    End Function
#End Region

#Region "Finalize configure layout"
    Private Function getCommandName() As String
        Return "Switch to " & System.IO.Path.GetFileNameWithoutExtension(selectedLayoutPath) & " layout"
    End Function
#End Region
    Public Sub New(ByVal callingForm As Form)
        InitializeComponent()
        gCallingForm = callingForm
    End Sub
    Public Shared gCallingForm As Form


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
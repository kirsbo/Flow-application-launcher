Imports System.Runtime.InteropServices
Imports System.IO.Path
Imports System.IO.File
Imports System.Drawing.Imaging

'GT. 19.02.2010 -- revision of class code is completed.

Public Class clsImages

    '******************************** CLASS DESCRIPTION ******************************************
    '* The IMAGEHANDLING module, handles everything image related. It handles for example the 
    '* functionality of grabbing images from exe files and URL's, as well as saving these. It also
    '* handles saving of extensions, as well as various check functions, which checks if images
    '* already exists, for applications, extensions, websites etc.
    '******************************** END CLASS DESCRIPTION **************************************

#Region "Constants and exposed properties"
    Private Shared sFullIconGalleryPath As String = My.Settings.InstalledPath & My.Settings.PathIconGallery
    Public Const defaultFolderImg As String = "Default\folder.png"
    Public Const defaultFileImg As String = "Default\file.png"
    Public Const defaultURLImg As String = "Default\link.png"
    Public Const defaultLayoutImg As String = "Default\keyboard.png"
    Public Const defaultUnknownImg As String = "Default\unknown.png"
    Public Const defaultHelpImg As String = "Default\Help.png"
    Public Const addCommandImg As String = "Default\Add.png"
    Public Const flowCommandHideImg As String = "Default\Minimize.png"
    Public Const flowCommandDefaultLayoutImg As String = "Default\Home.png"
    Public Const defaultImageFormat As String = ".png"
    Public Const webImgPath As String = "Websites\"
    Public Const appImgPath As String = "Applications\"
    Public Const extImgPath As String = "File Extensions\"
    Public Const myImgPath As String = "My icons\"

    Public Shared Property FullIconGalleryPath() As String
        Get
            Return sFullIconGalleryPath
        End Get
        Set(ByVal value As String)
            sFullIconGalleryPath = value
        End Set
    End Property

#End Region

#Region "API structures and functions"
    Private Structure SHFILEINFO
        Public hIcon As IntPtr            ' : icon
        Public iIcon As Integer           ' : icondex
        Public dwAttributes As Integer    ' : SFGAO_ flags
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
        Public szTypeName As String
    End Structure
    Private Declare Auto Function SHGetFileInfo Lib "shell32.dll" _
            (ByVal pszPath As String, _
             ByVal dwFileAttributes As Integer, _
             ByRef psfi As SHFILEINFO, _
             ByVal cbFileInfo As Integer, _
             ByVal uFlags As Integer) As IntPtr

    Private Const SHGFI_ICON = &H100
    Private Const SHGFI_SMALLICON = &H1
    Private Const SHGFI_LARGEICON = &H0    ' Large icon
    Private nIndex = 0
#End Region

#Region "'Image exist' checks"
    Public Shared Function extensionImageExists(ByVal fileExtension As String) As Boolean
        If Strings.Left(fileExtension, 1) = "." Then
            fileExtension = fileExtension.Remove(0, 1)
        End If

        If System.IO.File.Exists(FullIconGalleryPath & extImgPath & fileExtension & ".png") And fileExtension <> "exe" Then
            Return True
        ElseIf System.IO.File.Exists(FullIconGalleryPath & appImgPath & fileExtension & ".png") Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function exeIconExists(ByVal fileName As String) As Boolean
        If System.IO.File.Exists(FullIconGalleryPath & appImgPath & GetFileNameWithoutExtension(fileName) & defaultImageFormat) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function websiteIconExists(ByVal hostName As String) As Boolean
        If System.IO.File.Exists(FullIconGalleryPath & webImgPath & hostName & defaultImageFormat) Then
            Return True
        Else
            Return False
        End If
    End Function 'Needs to be public, as its accessed from frmEnterURL
#End Region

#Region "URL related image handling"
    Public Shared Function saveIconFromURLAndReturnPath(ByVal url As Uri) As String
        Try
            Dim iconURL = clsKeyConfigurator.getUrlPrefix(url) & url.Host & "/favicon.ico"
            Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim stream As System.IO.Stream = response.GetResponseStream()
            Dim favicon As Image = Image.FromStream(stream)
            favicon.Save(FullIconGalleryPath & webImgPath & url.Host & defaultImageFormat, System.Drawing.Imaging.ImageFormat.Png)
            Return webImgPath & url.Host & defaultImageFormat
        Catch 'If the website favicon cannot be found, then return default url image
            Return defaultURLImg
        End Try
    End Function
#End Region

#Region "Extension images"
    Public Shared Function getCommandImagePathFromFilename(ByVal selectedFilePath As String) As String
        If extensionImageExists(GetExtension(selectedFilePath)) = True Then
            Return clsImages.getPathToExtensionImage(GetExtension(selectedFilePath))
        Else
            If GetExtension(selectedFilePath) = ".exe" Then
                extractAndSaveIconFromFile(selectedFilePath, GetFileNameWithoutExtension(selectedFilePath), FullIconGalleryPath & appImgPath)
                Return appImgPath & GetFileNameWithoutExtension(selectedFilePath) & defaultImageFormat
            Else
                Return clsImages.defaultFileImg
            End If
        End If
    End Function
    Private Function getExtensionImagePath(ByVal fileExtension As String) As String
        Return extImgPath & fileExtension.Substring(1) & defaultImageFormat
    End Function
    Public Shared Function getPathToExtensionImage(ByVal fileExtension As String) As String
        Return extImgPath & fileExtension.Substring(1) & defaultImageFormat
    End Function
    Private Sub addToExtensionLibrary(ByVal filePath As String)
        extractAndSaveIconFromFile(filePath, GetExtension(filePath).Substring(1), FullIconGalleryPath & extImgPath) 'Extracts and saves file as ext.bmp
    End Sub
#End Region

#Region "Image retrieval and saving functionality"
    Public Function getImagePathFromFilePath(ByVal filePath As String) As String
        Dim fileNameWithoutExtension As String = GetFileNameWithoutExtension(filePath)
        Dim fileExtension As String = GetExtension(filePath)
        Dim fileName As String = GetFileName(filePath)
        Select Case LCase(fileExtension).Substring(1)
            Case "exe"
                If exeIconExists(fileName) = True Then
                    Return appImgPath & fileNameWithoutExtension & defaultImageFormat
                Else
                    addToImagesFolder(filePath) 'Extract icon from exe and save in images library as png
                    Return appImgPath & fileNameWithoutExtension & defaultImageFormat
                End If
            Case Else
                If extensionImageExists(fileExtension) = False Then addToExtensionLibrary(filePath)
                Return getExtensionImagePath(fileExtension)
        End Select

    End Function
    Private Sub addToImagesFolder(ByVal filePath As String)
        extractAndSaveIconFromFile(filePath, GetFileNameWithoutExtension(filePath), FullIconGalleryPath & appImgPath)
    End Sub
    Public Shared Sub convertToPngAndSave(ByVal filePath As String)
        Dim imageToConvert As Image
        imageToConvert = Image.FromFile(filePath)
        Try
            imageToConvert.Save(FullIconGalleryPath & myImgPath & GetFileNameWithoutExtension(filePath) & defaultImageFormat, ImageFormat.Png)
        Catch ex As Exception
            MsgBox("File already exists.")
        End Try
    End Sub
    Public Shared Sub extractAndSaveIconFromFile(ByVal filePath As String, ByVal saveToFileName As String, ByVal destinationFolder As String)
        saveToFileName = saveToFileName & defaultImageFormat
        Dim saveToPath As String = destinationFolder & saveToFileName
        If IO.File.Exists(saveToPath) = False Then
            Dim hImgLarge As IntPtr  'The handle to the system image list.
            Dim shinfo As SHFILEINFO
            shinfo = New SHFILEINFO()
            shinfo.szDisplayName = New String(Chr(0), 260)
            shinfo.szTypeName = New String(Chr(0), 80)
            hImgLarge = SHGetFileInfo(filePath, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_LARGEICON) 'Use this to get the large icon.
            'The icon is returned in the hIcon member of the shinfo struct.

            Dim myIcon As System.Drawing.Icon = System.Drawing.Icon.FromHandle(shinfo.hIcon)
            Dim extractedIcon As Bitmap = System.Drawing.Icon.FromHandle(shinfo.hIcon).ToBitmap

            extractedIcon.Save(saveToPath, System.Drawing.Imaging.ImageFormat.Png)
        Else
            'Image already exists
        End If


    End Sub
#End Region
End Class

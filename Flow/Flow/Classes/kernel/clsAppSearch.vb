Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text

'GT. 21.02.2010 -- revision of class code is completed.

' Class retrieves information about the installed applications. Applications are define from
' "All programs" folder, "uninstall" and "help" files are excluded.
Public Class clsAppSearch

    Private Const DefaultFileMask As String = "*.lnk"
    Private Const DefaultDirectoryMask As String = "*"

#Region " Member variables "

    Private Shared directoryInfoInitial As DirectoryInfo
    Private Shared sDirectoryMask As String
    Private Shared sFileMask As String

    Private Shared arrayListApplicationPath As New ArrayList
    Private Shared arrayListApplicationName As New ArrayList

#End Region

#Region " Exposed Properties "

    Public Shared Property InitialDirectory() As DirectoryInfo
        Get
            Return directoryInfoInitial
        End Get
        Set(ByVal Value As DirectoryInfo)
            directoryInfoInitial = Value
        End Set
    End Property

    Public Shared ReadOnly Property ApplicationNames() As Object
        Get
            Return arrayListApplicationName.ToArray
        End Get
    End Property

#End Region

#Region " Constructors & Destructors"
    ' Defines folder for installed applications search subject to system version.
    Shared Sub New()

        Select Case LCase(clsWinInfo.getWindowsVersion)
            Case "windows xp", "Windows server 2003"
                Dim programsDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Programs)
                'Dim user As String = Environment.UserName
                'programsDataFolder = programsDataFolder.Replace(user, "All Users") 'GT. 07.02.2010 -- For XP and Windows server 2003 only


                Dim splashIndex As Integer
                Dim secondSplashIndex As Integer
                Dim thirdSplashIndex As Integer
                Dim startIndex As Integer
                splashIndex = programsDataFolder.IndexOf("\")
                startIndex = splashIndex + 1
                secondSplashIndex = programsDataFolder.IndexOf("\", startIndex)
                startIndex = secondSplashIndex + 1
                thirdSplashIndex = programsDataFolder.IndexOf("\", startIndex)

                Dim pathPart1, pathPath2 As String

                pathPart1 = programsDataFolder.Substring(0, secondSplashIndex)
                pathPath2 = programsDataFolder.Substring(thirdSplashIndex + 1, programsDataFolder.Length - thirdSplashIndex - 1)

                InitialDirectory = New IO.DirectoryInfo(pathPart1 & "\All users\" & pathPath2)

                If Not InitialDirectory.Exists Then
                    InitialDirectory = New IO.DirectoryInfo(pathPart1 & "\All users.WINDOWS\" & pathPath2)
                End If

            Case "windows vista", "windows server 2008", "windows 7"
                Dim commonApplicationDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
                Dim programsDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Programs)
                Dim applicationDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                programsDataFolder = programsDataFolder.Replace(applicationDataFolder, commonApplicationDataFolder)
                InitialDirectory = New IO.DirectoryInfo(programsDataFolder)

        End Select

    End Sub

    Protected Overrides Sub Finalize()
        arrayListApplicationPath = Nothing
        arrayListApplicationName = Nothing
        MyBase.Finalize()
    End Sub

#End Region

#Region "Application searching subs"

    Public Shared Sub Search( _
        Optional ByVal BaseDirectory As DirectoryInfo = Nothing, _
        Optional ByVal FileMask As String = Nothing, _
        Optional ByVal DirectoryMask As String = Nothing)

        If Not IsNothing(BaseDirectory) Then
            directoryInfoInitial = BaseDirectory
        End If

        If IsNothing(directoryInfoInitial) Then
            Throw New ArgumentException("Directory isn't defined!", "Directory")
        End If

        If IsNothing(FileMask) Then
            sFileMask = DefaultFileMask
        Else
            sFileMask = FileMask
        End If


        If IsNothing(DirectoryMask) Then
            sDirectoryMask = DefaultDirectoryMask
        Else
            sDirectoryMask = DirectoryMask
        End If

        DoSearch(InitialDirectory)
    End Sub

    ''' <summary>
    ''' Recursive search for installed application from "All programs" folder.
    ''' </summary>
    ''' <param name="BaseDirectory">Directory that contains programs links.</param>

    Private Shared Sub DoSearch(ByVal BaseDirectory As DirectoryInfo)
        Dim str As String
        Try
            For Each file In BaseDirectory.GetFiles(sFileMask)
                str = file.Name.Remove(file.Name.Length - 4) ' remove .lnk from application name
                If Not str.ToLower.Contains("uninstall") Or str.ToLower.Contains("readme") Then
                    arrayListApplicationName.Add(str)
                    arrayListApplicationPath.Add(file.FullName)
                End If
            Next

            '_Files.AddRange(BaseDirectory.GetFiles(_FileMask))

        Catch u As UnauthorizedAccessException   ' DS. UnauthorizedAccessException
        Catch ex As Exception
        End Try
        Try
            Dim Directories() As DirectoryInfo = BaseDirectory.GetDirectories(sDirectoryMask)
            'arrayListDirectories.AddRange(Directories)

            For Each di As DirectoryInfo In Directories
                DoSearch(di)
            Next
        Catch u As Exception 'UnauthorizedAccessException
            'Catch ex As Exception
        End Try
    End Sub
#End Region

    ''' <summary>
    ''' Get an application location specified by name of installed application.
    ''' </summary>
    ''' <param name="applicationName">name of application</param>
    ''' <returns>string that contaion a full path to application link from "All Programs folder"</returns>
    Public Shared Function getApplicationPath(ByVal applicationName As String) As String
        Return arrayListApplicationPath(arrayListApplicationName.IndexOf(applicationName)).ToString
    End Function



End Class

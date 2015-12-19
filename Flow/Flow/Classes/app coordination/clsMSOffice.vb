Imports Microsoft.Win32

'GT. 19.02.2010 -- revision of class code completed.

'Provides an information about the installed office applications
Public Class clsMSOffice

    Private Const officeRegistryKey As String = "Software\Microsoft\Office"
    Public Shared registryInstalledPath As String 'MS office registry installed path 

    Private Shared applicationFileName() As String = {"msaccess.exe", "excel.exe", "infopath.exe", "onenote.exe", "outlook.exe", "powerpnt.exe", "mspub.exe", "winword.exe", "visio.exe"}
    Public Shared applicationPaths(9) As String 'full path to .exe file for the office application

#Region "Public Enumerations"
    Public Enum msOfficeApplication
        Access
        Excel
        InfoPath
        OneNote
        Outlook
        PowerPoint
        Publisher
        Word
        Visio
    End Enum

    Public Enum officeType
        Office97 = 8
        Office2000 = 9
        OfficeXP = 10
        Office2003 = 11
        Office2007 = 12
        Office2010 = 14
    End Enum
#End Region

#Region "Public methods"
    'Returns true if the specified office application is installed
    Public Shared Function isInstalled(ByVal application As msOfficeApplication, ByVal officeVersion As Double) As Boolean
        Dim regKey As RegistryKey
        Dim subKey As String

        subKey = "\" & officeVersion & ".0" & "\" & application.ToString & "\" & "InstallRoot\"

        Try
            regKey = Registry.LocalMachine.OpenSubKey(officeRegistryKey & subKey, False)
        Catch ex As Exception
            'TO DO: build msoffice.xml by "All programs" folder
            Return False
        End Try
        If regKey Is Nothing Then
            Return False
        Else
            registryInstalledPath = regKey.GetValue("Path", "")
            If registryInstalledPath <> "" Then
                Return True
            Else
                Return False
            End If
        End If

        regKey.Close()
    End Function

    Public Shared Function getApplicationPath(ByVal application As msOfficeApplication) As String

        If registryInstalledPath <> "" Then
            Return registryInstalledPath & applicationFileName(application)
        Else
            Return Nothing
        End If

    End Function
#End Region
End Class

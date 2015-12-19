Option Explicit On
Option Strict On

'GT. 19.02.2010 -- revision of class code is completed.

' Class clsShellLink associated with IShellLinkA/IPersistFile interfaces.

Imports System.Runtime.InteropServices
Imports System.Text


Public Class clsShellLink

#Region "Constants, enumerations, structures"
    Private Enum SLGP_FLAGS
        SLGP_SHORTPATH = 1
        SLGP_UNCPRIORITY = 2
        SLGP_RAWPATH = 4
    End Enum

    Private Enum STGMCONSTS
        STGM_DIRECT = &H0
        STGM_TRANSACTED = &H10000
        STGM_SIMPLE = &H8000000
        STGM_READ = &H0
        STGM_WRITE = &H1
        STGM_READWRITE = &H2
        STGM_SHARE_DENY_NONE = &H40
        STGM_SHARE_DENY_READ = &H30
        STGM_SHARE_DENY_WRITE = &H20
        STGM_SHARE_EXCLUSIVE = &H10
        STGM_PRIORITY = &H40000
        STGM_DELETEONRELEASE = &H4000000
        STGM_NOSCRATCH = &H100000
        STGM_CREATE = &H1000
        STGM_CONVERT = &H20000
        STGM_FAILIFTHERE = &H0
        STGM_NOSNAPSHOT = &H200000
        STGM_DIRECT_SWMR = &H400000
    End Enum

    Const MAX_PATH As Integer = 260

    Private Structure WIN32_FIND_DATA
        Public dwFileAttributes As Integer
        Public ftCreationTime As Long   ' FILETIME
        Public ftLastAccessTime As Long ' FILETIME
        Public ftLastWriteTime As Long  ' FILETIME
        Public nFileSizeHigh As Integer
        Public nFileSizeLow As Integer
        Public dwReserved0 As Integer
        Public dwReserved1 As Integer
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=MAX_PATH)> Public cFileName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=14)> Public cAlternate As String
    End Structure

#End Region

    Private link As IShellLinkA
    Private sExeFileName As StringBuilder

    Private Class CLSID
        Public Data1 As Integer
        Public Data2 As Short
        Public Data3 As Short
        Public Data4() As Byte

        Public Sub New()
            Data4 = New Byte(8) {}
        End Sub
    End Class

    'IPersist interface import
    <ComImport(), Guid("0000010b-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> Private Interface IPersistFile
        Sub GetClassID(ByRef pClassID As CLSID)
        Sub IsDirty()
        Sub Load(<MarshalAs(UnmanagedType.BStr)> ByVal pszFileName As String, ByVal dwMode As Integer)
    End Interface

    'IShellLinkA interface import
    <ComImport(), Guid("000214EE-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> Private Interface IShellLinkA
        Sub GetPath(<Out(), MarshalAs(UnmanagedType.LPStr)> ByVal pszFile As StringBuilder, ByVal cch As Integer, ByRef pfd As WIN32_FIND_DATA, ByVal fFlags As Integer)
        Sub GetIconLocation(<Out(), MarshalAs(UnmanagedType.LPStr)> ByVal pszIconPath As StringBuilder, ByVal cch As Integer, ByRef piIcon As Integer)
    End Interface

    Public Sub New()
        Dim type As Type = type.GetTypeFromCLSID(New Guid("00021401-0000-0000-C000-000000000046"))
        link = DirectCast(Activator.CreateInstance(type), IShellLinkA)
    End Sub

#Region "public methods"
    Public Function GetLinkInfo(ByVal linkFilePath As String) As String
        Dim wfd As New WIN32_FIND_DATA
        Dim cPersistFile As IPersistFile ' An explorer IPersistFile instance

        If System.IO.File.Exists(linkFilePath) Then
            cPersistFile = DirectCast(link, IPersistFile)   ' Implement cShellLink's IPersistFile interface
            cPersistFile.Load(linkFilePath, STGMCONSTS.STGM_DIRECT)

            sExeFileName = New StringBuilder(MAX_PATH)
            ' Get the command line exe name & path of shortcut, see wfd for more information
            link.GetPath(sExeFileName, MAX_PATH, wfd, SLGP_FLAGS.SLGP_UNCPRIORITY) ' Retrieve UNC name

            Return sExeFileName.ToString
        Else
            MessageBox.Show("Cannot retrive an information from the .lnk")
            Return Nothing
        End If
    End Function
#End Region

End Class

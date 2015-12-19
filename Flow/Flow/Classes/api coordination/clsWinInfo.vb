Option Strict On
Option Explicit On

'GT. 19.02.2010 -- revision of class code is completed.

Imports System

'Class retrieves information about the current operating system.
Public Class clsWinInfo

    Private Shared versionWindow As Version = Environment.OSVersion.Version
    Private Const VER_NT_WORKSTATION As Integer = 2


    Public Shared Function getWindowsVersion() As String
        Dim majorVersion As Integer = versionWindow.Major
        Dim minorVersion As Integer = versionWindow.Minor
        Dim platformID As Integer = Environment.OSVersion.Platform

        If majorVersion = 5 And minorVersion = 0 Then
            Return "Windows 2000"
        ElseIf majorVersion = 5 And minorVersion = 1 Then
            Return ("Windows XP")
        ElseIf majorVersion = 5 And minorVersion = 2 Then
            Return "Windows Server 2003"
        ElseIf majorVersion = 6 And minorVersion = 0 And platformID = VER_NT_WORKSTATION Then
            Return "Windows Vista"
        ElseIf majorVersion = 6 And minorVersion = 0 And platformID <> VER_NT_WORKSTATION Then
            Return "Windows Server 2008"
        ElseIf majorVersion = 6 And minorVersion = 1 And platformID <> VER_NT_WORKSTATION Then
            Return "Windows Server 2008 R2"
        ElseIf majorVersion = 6 And minorVersion = 1 And platformID = VER_NT_WORKSTATION Then
            Return "Windows 7"
        Else
            Return ("Unknown Windows version")
        End If
    End Function

End Class

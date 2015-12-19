Option Explicit On
Option Strict On

'GT. 19.02.2010 -- revision of class code is completed.

'clsAppCapture class contains subs for application capture and resume
Public Class clsAppCapture

    Private Shared sPreviousActiveApplication As String
    Private Shared ptrActiveProcessID As IntPtr
    Private Shared processAppActiveProcess As Process
    Private Shared ptrAppHandle, ptrPreviousAppHandle As IntPtr
    Private Shared boolAppCaptured As Boolean
    Private Shared sAppTitle, sAppDescription, sAppName As String

#Region " Public Properties "
    Public Shared ReadOnly Property AppDescription() As String
        Get
            Return sAppDescription
        End Get
    End Property
    Public Shared ReadOnly Property AppName() As String
        Get
            Return sAppName
        End Get
    End Property
#End Region

#Region "Application capture and resume - Subs and functions"
    Public Shared Sub captureActiveApp()
        GetWindowThreadProcessId(GetForegroundWindow(), CInt(ptrActiveProcessID))
        processAppActiveProcess = Process.GetProcessById(CInt(ptrActiveProcessID))
        ptrAppHandle = processAppActiveProcess.MainWindowHandle
        sAppTitle = processAppActiveProcess.MainWindowTitle
        sAppDescription = getDescriptionFromProcess(processAppActiveProcess)
        sAppName = getNameFromProcess(processAppActiveProcess)
    End Sub

    Public Shared Function getHandleOfForegroundWindow() As IntPtr
        GetWindowThreadProcessId(GetForegroundWindow(), CInt(ptrActiveProcessID))
        Return Process.GetProcessById(CInt(ptrActiveProcessID)).MainWindowHandle
    End Function

    Public Shared Function getProcessOfForegroundWindow() As Process
        GetWindowThreadProcessId(GetForegroundWindow(), CInt(ptrActiveProcessID))
        Return Process.GetProcessById(CInt(ptrActiveProcessID))
    End Function

    Public Shared Sub resumePreviousActiveApp()
        Dim Win32Help As New clsWin32Helper
        clsWin32Helper.SetForegroundWindow(ptrAppHandle)
        System.Threading.Thread.Sleep(100)
    End Sub

    Public Shared Sub setPreviousAppHandle()
        ptrPreviousAppHandle = ptrAppHandle
    End Sub

    Private Shared Function getNameFromProcess(ByVal targetProcess As Process) As String
        Dim fileInfo As FileVersionInfo
        Try

            If IO.File.Exists(targetProcess.MainModule.FileName) = True Then
                fileInfo = FileVersionInfo.GetVersionInfo(targetProcess.MainModule.FileName)
                Return fileInfo.ProductName
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return targetProcess.ProcessName
        End Try
    End Function

    Private Shared Function getDescriptionFromProcess(ByVal targetProcess As Process) As String
        Dim fileInfo As FileVersionInfo
        Try
            If IO.File.Exists(targetProcess.MainModule.FileName) = True Then
                fileInfo = FileVersionInfo.GetVersionInfo(targetProcess.MainModule.FileName)
                Return fileInfo.FileDescription
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return targetProcess.ProcessName
        End Try
    End Function

#End Region

#Region "Application capture and resume - API functions and classes"
    Public NotInheritable Class clsWin32Helper
        <System.Runtime.InteropServices.DllImport("user32.dll", _
        EntryPoint:="SetForegroundWindow", _
        CallingConvention:=Runtime.InteropServices.CallingConvention.StdCall, _
        CharSet:=Runtime.InteropServices.CharSet.Unicode, SetLastError:=True)> _
        Public Shared Function _
        SetForegroundWindow(ByVal handle As IntPtr) As Boolean
            ' Leave function empty
        End Function

        <System.Runtime.InteropServices.DllImport("user32.dll", _
        EntryPoint:="ShowWindow", _
        CallingConvention:=Runtime.InteropServices.CallingConvention.StdCall, _
        CharSet:=Runtime.InteropServices.CharSet.Unicode, SetLastError:=True)> _
        Public Shared Function ShowWindow(ByVal handle As IntPtr, _
        ByVal nCmd As Int32) As Boolean
            ' Leave function empty
        End Function
    End Class

    Declare Function GetForegroundWindow Lib "user32.dll" () As Int32

    Declare Function GetWindowThreadProcessId Lib "user32.dll" ( _
        ByVal hwnd As Int32, _
        ByRef lpdwProcessId As Int32) As Int32
#End Region

End Class

'Option Strict On
Option Explicit On

'GT. 21.02.2010 -- revision of class code is completed.

Public Class clsKeyPressHandler

#Region "Supporting methods for the mouse and keypress handlers"

    Public Shared Sub executeCommand(ByVal flowKeyCode As Integer)
        Dim key As New clsCommand(flowKeyCode)
        clsSound.playSound(clsSound.sounds.ExecuteCommand)

        If key.isFlowCommand = True Then
            executeFlowCommand(flowKeyCode)
            Exit Sub
        End If

        Dim commandHandlerRef As clsCommandHandlers
        commandHandlerRef = New clsCommandHandlers

        Dim myArgs(0) As Object
        myArgs(0) = key.commandXMLNode


        Try
            Dim commandExecutionResult As Integer = CallByName(commandHandlerRef, key.handlerMethod, CallType.Method, myArgs)

            If commandExecutionResult = clsCommandHandlers.GeneralException Then
                frmUI.mouseDownKeycode = -1 'GT. 22.02.2010 -- to resolved "jumping" icon when the command removing aborted.
                clsSound.playSound(clsSound.sounds.Alert)
                Dim result As MsgBoxResult
                result = MsgBox("An error occured in the action you were trying to run. This is usually due to a missing file, folder, layout or application on your system." & vbLf & vbLf & "Would you like to remove the action from the layout?", MsgBoxStyle.YesNoCancel)
                If result = MsgBoxResult.Yes Then
                    clsKeyConfigurator.removeCommand(flowKeyCode, True)
                End If

                'ElseIf commandExecutionResult = clsCommandHandlers.Win32Exception Then
                'frmUI.mouseDownKeycode = -1
                'Shell("rundll32.exe shell32.dll, OpenAs_RunDLL " & key.commandNode.InnerText)

            Else
                '##The following select case should be replaced with a check if the <command> tag has a 
                'hideFlowOnExecute="true" attribute. This attribute has not been added to the xml 
                'definition yet, so until then, we just use a select case. The entire check is due to some commands
                'should be able to override the default behavior of hiding flow after a command. For example in 
                'changeLayout commands, we do not want flow to be hidden afterwards.
                Select Case key.handlerMethod
                    Case "changeLayoutHandler"
                    Case Else
                        clsFlowGeneral.hideFlow()
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub 'Determines appropriate command handler and sends command to execution in the clsCommandHandlers class


    Private Shared Sub executeFlowCommand(ByVal flowKeyCode As Integer)
        Select Case flowKeyCode
            Case clsCommand.Keys.Esc
                clsFlowGeneral.hideFlow()
                Exit Sub
            Case clsCommand.Keys.Tab
                clsLayoutManager.loadDefaultLayout()
                Exit Sub
        End Select
    End Sub
#End Region
End Class

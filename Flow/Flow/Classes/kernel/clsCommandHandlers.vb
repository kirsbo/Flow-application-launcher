Imports System.Xml
'GT. 21.02.2010 -- revision of class code is completed.

'Class is used to launch flow commands
<System.Reflection.ObfuscationAttribute(Feature:="renaming", ApplyToMembers:=True)> _
Public Class clsCommandHandlers
    Public Const CommandSuccefullyExecuted = 0
    Public Const GeneralException = -1
    Public Const Win32Exception = -2
    Public Const ERROR_NO_ASSOCIATION = 1155
    Public Const FILE_NOT_FOUND = 2

    Public Shared Function launchHandler(ByVal commandXML As XmlNode) As Integer
        Dim stringToLaunch As String
        stringToLaunch = commandXML.FirstChild.InnerText

        'If <input> tag is found in launchstring, handle user input
        Dim inputParam As XmlNode = commandXML.FirstChild.SelectSingleNode("./input")
        If Not inputParam Is Nothing Then
            Dim inputDialog As New frmInput
            Dim inputTitle As String = inputParam.Attributes.GetNamedItem("title").InnerText
            Dim inputValue As String = ""
            Dim inputNodePositionIndex As Integer = commandXML.FirstChild.InnerXml.ToString.IndexOf("<input")

            If inputDialog.ShowDialog(inputTitle, "", inputValue) = Windows.Forms.DialogResult.OK And inputValue.Length > 0 Then
                stringToLaunch = stringToLaunch.Insert(inputNodePositionIndex, inputValue)
            End If
        End If

        'Do the actual launching
        Try
            System.Diagnostics.Process.Start(stringToLaunch)
            Return CommandSuccefullyExecuted
        Catch e As System.ComponentModel.Win32Exception
            If e.NativeErrorCode = FILE_NOT_FOUND Then
                Return GeneralException 
            End If
            If e.NativeErrorCode = ERROR_NO_ASSOCIATION Then
                Shell("rundll32.exe shell32.dll, OpenAs_RunDLL " & stringToLaunch) 'GT. 20.03.2010 -- shows "open with" dialog in windows xp
            End If
            Return Win32Exception
        Catch e As Exception
            'MessageBox.Show(ex.ToString)
            Return GeneralException
        End Try
    End Function 'Handles launcher commands. Anything that can be launched by process.start gets handled by this sub.

    Public Shared Function changeLayoutHandler(ByVal commandXML As XmlNode) As Boolean
        Dim layoutToLoad As String
        layoutToLoad = commandXML.FirstChild.InnerText
        If IO.File.Exists(My.Settings.InstalledPath & My.Settings.PathCommandLayouts & layoutToLoad) = True Then
            clsLayoutManager.loadLayout(layoutToLoad)
            Return CommandSuccefullyExecuted
        Else
            Return GeneralException
        End If

    End Function 'Handles change layout commands.

#Region "CommandXML creation"

    Public Shared Function createCommandXMLForLaunchHandler(ByVal stringToLaunch As String) As XmlNode
        Dim commandXMLdoc As New XmlDocument
        Dim commandXMLnode As XmlNode

        commandXMLdoc.AppendChild(commandXMLdoc.CreateElement("commandXML"))

        commandXMLnode = commandXMLdoc.SelectSingleNode("//commandXML")

        commandXMLnode.AppendChild(commandXMLdoc.CreateElement("launchString"))
        commandXMLnode.SelectSingleNode("//launchString").InnerText = stringToLaunch

        Return commandXMLnode
    End Function

    Public Shared Function createCommandXMLForChangeLayoutHandler(ByVal layoutFileNameWithExtension As String) As XmlNode
        Dim commandXMLdoc As New XmlDocument
        Dim commandXMLnode As XmlNode

        commandXMLdoc.AppendChild(commandXMLdoc.CreateElement("commandXML"))

        commandXMLnode = commandXMLdoc.SelectSingleNode("//commandXML")

        commandXMLnode.AppendChild(commandXMLdoc.CreateElement("layoutFileName"))
        commandXMLnode.SelectSingleNode("//layoutFileName").InnerText = layoutFileNameWithExtension

        Return commandXMLnode
    End Function

#End Region
End Class

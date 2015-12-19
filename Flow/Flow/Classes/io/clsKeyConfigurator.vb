Option Explicit On
'Option Strict On

Imports System.Xml

'GT. 19.02.2010 -- revision of class code is completed.

Public Class clsKeyConfigurator
    Private Shared msFlowKeyCodeToConfigure As String
    Private Shared msNewCommandIconPath As String   'Used by frmIconGallery to register which image was selected by the user in the icon gallery

#Region "Exposed properties"
    Public Shared Property FlowKeyCodeToConfigure() As Integer
        Get
            Return msFlowKeyCodeToConfigure
        End Get
        Set(ByVal value As Integer)
            msFlowKeyCodeToConfigure = value
        End Set
    End Property
    Public Shared Property NewCommandIconPath() As String
        Get
            Return msNewCommandIconPath
        End Get
        Set(ByVal value As String)
            msNewCommandIconPath = value
        End Set
    End Property
#End Region

    Public Shared Sub configureKey(ByVal flowKeyCode As Integer)
        FlowKeyCodeToConfigure = flowKeyCode
        frmConfigureKey.Show()
    End Sub

#Region "Drag drop configuration"
    Public Shared Sub switchCommands(ByVal command1FlowKeyCode As Integer, ByVal command2FlowKeyCode As Integer)
        Dim command1Node As Xml.XmlNode
        Dim command2Node As Xml.XmlNode
        Dim copyOfCommand1Node As Xml.XmlNode
        Dim copyOfCommand2Node As Xml.XmlNode

        command1Node = clsLayoutManager.CurrentLayout.SelectSingleNode("//key[@flowKeyCode='" & command1FlowKeyCode & "']")
        command2Node = clsLayoutManager.CurrentLayout.SelectSingleNode("//key[@flowKeyCode='" & command2FlowKeyCode & "']")

        copyOfCommand1Node = command1Node.Clone
        copyOfCommand2Node = command2Node.Clone

        command1Node.ReplaceChild(copyOfCommand2Node.FirstChild, command1Node.FirstChild)
        command2Node.ReplaceChild(copyOfCommand1Node.FirstChild, command2Node.FirstChild)
        saveCurrentCommandLayout()
        'clsLayoutManager.CurrentLayout.SelectSingleNode("//key[@flowKeyCode='" & command1FlowKeyCode & "']").ReplaceChild(command2Node.FirstChild,

    End Sub
    Public Shared Sub copyCommand(ByVal sourceFlowKeyCode As Integer, ByVal destinationFlowKeyCode As Integer)
        Dim sourceKey As New clsCommand(sourceFlowKeyCode)
        Dim destKey As New clsCommand(destinationFlowKeyCode)

        If destKey.isAssigned = True Then
            destKey.keyNode.ReplaceChild(clsLayoutManager.CurrentLayout.ImportNode(sourceKey.commandNode, True), destKey.commandNode)
        Else
            destKey.keyNode.AppendChild(clsLayoutManager.CurrentLayout.ImportNode(sourceKey.commandNode, True))
        End If

        saveCurrentCommandLayout()
    End Sub
#End Region

    Public Shared Sub removeCommand(ByVal flowKeyCode As Integer, ByVal showHelpText As Boolean)
        Dim commandToRemove As New clsCommand(flowKeyCode)
        Dim commandName As String = commandToRemove.commandName

        commandToRemove.keyNode.RemoveChild(commandToRemove.commandNode)

        saveCurrentCommandLayout()

        If showHelpText = True Then clsUserHelp.displayHelp("The action '" & commandName & "' was removed from the current layout")
    End Sub

    Public Shared Sub addCommandFromDragDrop(ByVal flowKeyCode As Integer, ByVal dragDropFileFolderName As String)
        Dim commandName As String
        Dim iconPath As String

        Select Case isStringFileOrFolder(dragDropFileFolderName)
            Case "file"
                commandName = "Open " & System.IO.Path.GetFileName(dragDropFileFolderName)
                iconPath = clsImages.getCommandImagePathFromFilename(dragDropFileFolderName)
            Case "folder"
                commandName = "Open " & dragDropFileFolderName
                iconPath = clsImages.defaultFolderImg
            Case Else
                Exit Sub 'Somehow the drag dropped item was not a file or folder
        End Select

        editCommand(flowKeyCode, commandName, iconPath, "launchHandler", clsCommandHandlers.createCommandXMLForLaunchHandler(dragDropFileFolderName))
        'clsRender.renderCommandLayoutOnUI()
    End Sub

    Private Shared Function isStringFileOrFolder(ByVal fileFolderPath As String) As String
        Dim fileInfo As New IO.FileInfo(fileFolderPath)
        If fileInfo.Exists = True Then Return "file"

        Dim folderInfo As New IO.DirectoryInfo(fileFolderPath)
        If folderInfo.Exists = True Then Return "folder"

        Return "neither file or folder"
    End Function


    Public Shared Sub editCommand(ByVal flowKeyCode As Integer, ByVal name As String, ByVal iconPath As String, ByVal handlerMethod As String, ByVal commandXML As XmlNode)
        Dim commandNode As XmlNode
        Dim newKeyNode As New Xml.XmlDocument
        Dim currentCommandLayout As Xml.XmlDocument = clsLayoutManager.CurrentLayout

        'Loading <Key> template from KeyCommand.xml and set flowKeyCode attribute
        newKeyNode.Load(My.Settings.InstalledPath() & My.Settings.PathXmlTemplates & "KeyCommand.xml")
        newKeyNode.SelectSingleNode("//key").Attributes.GetNamedItem("flowKeyCode").InnerText = flowKeyCode

        'Get <command> node, set attributes and replace <commandXML> with passed <commandXML> node
        commandNode = newKeyNode.SelectSingleNode("//command")
        commandNode.Attributes.GetNamedItem("handlerMethod").InnerText = handlerMethod
        commandNode.Attributes.GetNamedItem("name").InnerText = name
        commandNode.Attributes.GetNamedItem("icon").InnerText = iconPath
        commandNode.ReplaceChild(newKeyNode.ImportNode(commandXML, True), commandNode.FirstChild) 'Replacing template's empty <commandXML> node with passed <commandXML> node

        'Get <key> node from current layout, and replace it with the newly generated <key> node
        Dim nodeToReplace As Xml.XmlNode
        nodeToReplace = currentCommandLayout.SelectSingleNode("//key[@flowKeyCode='" & flowKeyCode & "']")
        nodeToReplace.ParentNode.ReplaceChild(currentCommandLayout.ImportNode(newKeyNode.SelectSingleNode("//key"), True), nodeToReplace)

        'Save the change
        saveCurrentCommandLayout()
    End Sub

    'GT. 04.02.2010 -- Saves command key for any layout,it's similar to editCommand sub, so must be refactored.
    Public Shared Sub editCommand(ByVal flowKeyCode As Integer, ByVal name As String, ByVal iconPath As String, ByVal handlerMethod As String, ByVal commandXML As XmlNode, ByVal Layout As Xml.XmlDocument)
        Dim commandNode As XmlNode
        Dim newKeyNode As New Xml.XmlDocument

        'Loading <Key> template from KeyCommand.xml and set flowKeyCode attribute
        newKeyNode.Load(My.Settings.InstalledPath() & My.Settings.PathXmlTemplates & "KeyCommand.xml")
        newKeyNode.SelectSingleNode("//key").Attributes.GetNamedItem("flowKeyCode").InnerText = flowKeyCode

        'Get <command> node, set attributes and replace <commandXML> with passed <commandXML> node
        commandNode = newKeyNode.SelectSingleNode("//command")
        commandNode.Attributes.GetNamedItem("handlerMethod").InnerText = handlerMethod
        commandNode.Attributes.GetNamedItem("name").InnerText = name
        commandNode.Attributes.GetNamedItem("icon").InnerText = iconPath
        commandNode.ReplaceChild(newKeyNode.ImportNode(commandXML, True), commandNode.FirstChild) 'Replacing template's empty <commandXML> node with passed <commandXML> node

        'Get <key> node from the layout, and replace it with the newly generated <key> node
        Dim nodeToReplace As Xml.XmlNode
        nodeToReplace = Layout.SelectSingleNode("//key[@flowKeyCode='" & flowKeyCode & "']")
        nodeToReplace.ParentNode.ReplaceChild(Layout.ImportNode(newKeyNode.SelectSingleNode("//key"), True), nodeToReplace)

    End Sub

    Public Shared Sub editCommandNameAndImage(ByVal flowKeyCode As Integer, ByVal name As String, ByVal iconPath As String)
        Dim commandNode As XmlNode
        Dim currentCommandLayout As Xml.XmlDocument = clsLayoutManager.CurrentLayout
        commandNode = currentCommandLayout.SelectSingleNode("//key[@flowKeyCode='" & flowKeyCode & "']").FirstChild
        commandNode.Attributes.GetNamedItem("name").InnerText = name
        commandNode.Attributes.GetNamedItem("icon").InnerText = iconPath
        saveCurrentCommandLayout()
    End Sub
    Public Shared Sub editCommandLaunchString(ByVal flowKeyCode As Integer, ByVal launchString As String)
        Dim commandNode As New clsCommand(flowKeyCode)
        commandNode.commandXMLNode.FirstChild.InnerXml = launchString
        saveCurrentCommandLayout()
    End Sub

    Private Shared Sub saveCurrentCommandLayout()
        Dim currentLayoutPath As New Uri(clsLayoutManager.CurrentLayout.BaseURI)
        clsLayoutManager.CurrentLayout.Save(currentLayoutPath.LocalPath)
        clsLayoutManager.updateCurrentLayout()

    End Sub

#Region "Various supporting methods"
    Public Shared Function getUriFromString(ByVal url As String) As System.Uri
        If url.IndexOf("http://") <> -1 Or url.IndexOf("https://") <> -1 Or url.IndexOf("ftp://") <> -1 Then
            'Do nothing
        Else
            url = "http://" & url
        End If
        Dim convertedUri As New System.Uri(url)
        Return convertedUri
    End Function 'Validates URL (appends http:// if no prefix found) and returns Uri

    Public Shared Function getUrlPrefix(ByVal url As Uri) As String
        If url.AbsoluteUri.IndexOf("http://") <> -1 Then Return "http://"
        If url.AbsoluteUri.IndexOf("https://") <> -1 Then Return "https://"
        If url.AbsoluteUri.IndexOf("ftp://") <> -1 Then Return "ftp://"
        Return "http://"
    End Function 'Returns prefix of URL (http, https, ftp etc)

    Public Shared Function keyHasCommandInCurrentKeyset(ByVal flowKeyCode As Integer) As Boolean
        Dim keyNode As Xml.XmlNode
        keyNode = clsLayoutManager.CurrentLayout.SelectSingleNode("//key[@flowKeyCode='" & flowKeyCode & "']")
        If keyNode.ChildNodes.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
End Class

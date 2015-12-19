'GT. 21.02.2010 -- revision of class code is completed.

Public Class clsCommand
    Public keyNode As Xml.XmlNode
    Public commandNode As Xml.XmlNode
    Public commandXMLNode As Xml.XmlNode

    Public physicalKey As clsOSK.physicalKey

    Public handlerMethod As String
    Public commandName As String
    Public commandIconRelativePath As String
    Public commandIconFullPath As String
    Public commandIcon As Bitmap

    Public isAssigned As Boolean
    Public isFlowCommand As Boolean

    Public Enum Keys
        Esc = 1
        Tab = 38
    End Enum

    Public Sub New(ByVal flowKeyCode As Integer)
        keyNode = clsLayoutManager.CurrentLayout.SelectSingleNode("//key[@flowKeyCode='" & flowKeyCode & "']")

        physicalKey = clsOSK.physicalKeys(flowKeyCode)

        isFlowCommand = determineIfCommandKey(flowKeyCode)

        If keyNode.FirstChild Is Nothing Then
            isAssigned = False
            commandName = "Click to assign a new action"
            commandIconRelativePath = clsImages.addCommandImg
        Else
            handlerMethod = keyNode.FirstChild.Attributes.GetNamedItem("handlerMethod").InnerText
            commandName = keyNode.FirstChild.Attributes.GetNamedItem("name").InnerText
            commandIconRelativePath = keyNode.FirstChild.Attributes.GetNamedItem("icon").InnerText
            commandNode = keyNode.FirstChild
            commandXMLNode = keyNode.FirstChild.FirstChild
            isAssigned = True
        End If

        If isFlowCommand = True Then
            isAssigned = True
            commandIconRelativePath = getFlowCommandImagePath(physicalKey.flowKeyCode)
            If flowKeyCode = Keys.Esc Then
                commandName = "Minimize Flow"
            ElseIf flowKeyCode = Keys.Tab Then
                commandName = "Go to the 'Home' layout"
            End If
        End If

        commandIconFullPath = clsImages.FullIconGalleryPath & commandIconRelativePath

        'If for some reason the icon does not exist, then we use a default "unknown" icon instead.
        If IO.File.Exists(commandIconFullPath) = False Then commandIconFullPath = clsImages.FullIconGalleryPath & clsImages.defaultUnknownImg
        commandIcon = Image.FromFile(commandIconFullPath)

    End Sub

    Private Shared Function determineIfCommandKey(ByVal flowKeyCode As Integer) As Boolean
        Select Case flowKeyCode
            Case Keys.Esc, Keys.Tab
                Return True
            Case Else
                Return False
        End Select
    End Function

    Private Shared Function getFlowCommandImagePath(ByVal flowKeyCode As Integer) As String
        Select Case flowKeyCode
            Case Keys.Esc
                Return clsImages.flowCommandHideImg
            Case Keys.Tab
                Return clsImages.flowCommandDefaultLayoutImg
            Case Else
                Return clsImages.defaultHelpImg
        End Select
    End Function
End Class

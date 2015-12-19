'GT. 21.02.2010 -- revision of class code is completed.

' Class is used for rendering OSK keys.

'<System.Reflection.ObfuscationAttribute(Feature:="renaming", ApplyToMembers:=False)> _
Public Class clsOSK

    '<System.Reflection.ObfuscationAttribute(Feature:="renaming")> _
    'Private Shared info As System.Reflection.FieldInfo


    Public Structure physicalKey
        Dim flowKeyCode As Integer

        Dim keyText As String
        Dim keyTextRenderPosition As Point

        Dim iconRenderPosition As Point
        Dim panelControl As Panel

        Dim panelBounds As Rectangle
    End Structure

    Public Shared physicalKeys(103) As physicalKey

    'Public Shared Sub old_buildPhysicalKeysArray()
    '    Dim keyNodes As Xml.XmlNodeList = clsFlowGeneral.UserCulture.SelectNodes("//key")
    '    Dim keyNode As Xml.XmlNode

    '    Dim flowKeyCode As Integer
    '    Dim keyChar As String

    '    Dim objKeyPanelControl As Panel
    '    For Each keyNode In keyNodes
    '        flowKeyCode = CInt(keyNode.Attributes("flowKeyCode").InnerText)

    '        keyChar = keyNode.Attributes("keyChar").InnerText
    '        If keyChar.Length = 1 Then keyChar = UCase(keyChar)

    '        objKeyPanelControl = getControlByName("Panel" & flowKeyCode)

    '        physicalKeys(flowKeyCode).panelControl = objKeyPanelControl
    '        physicalKeys(flowKeyCode).panelBounds = New Rectangle(objKeyPanelControl.Location.X, objKeyPanelControl.Location.Y, objKeyPanelControl.Size.Width, objKeyPanelControl.Size.Height)
    '        physicalKeys(flowKeyCode).flowKeyCode = flowKeyCode
    '        physicalKeys(flowKeyCode).keyText = keyChar
    '        physicalKeys(flowKeyCode).keyTextRenderPosition = objKeyPanelControl.Location
    '        physicalKeys(flowKeyCode).iconRenderPosition = getIconRenderPosition(objKeyPanelControl)
    '    Next
    '    renderPhysicalKeys()
    'End Sub 'Builds an array of the physicalKey structure, for use in frmUI painting of key labels

    Public Shared Sub buildPhysicalKeysArray()
        Dim keyNodes As Xml.XmlNodeList = clsFlowGeneral.UserCulture.SelectNodes("//key")
        Dim keyNode As Xml.XmlNode

        Dim flowKeyCode As Integer
        Dim keyChar As String

        Dim objKeyPanelControl As Panel
        For Each keyNode In keyNodes
            flowKeyCode = CInt(keyNode.Attributes("flowKeyCode").InnerText)

            keyChar = keyNode.Attributes("keyChar").InnerText
            If keyChar.Length = 1 Then keyChar = UCase(keyChar)

            'objKeyPanelControl = getControlByName("Panel" & flowKeyCode)
            objKeyPanelControl = physicalKeys(flowKeyCode).panelControl
            'physicalKeys(flowKeyCode).panelControl = objKeyPanelControl
            physicalKeys(flowKeyCode).panelBounds = New Rectangle(objKeyPanelControl.Location.X, objKeyPanelControl.Location.Y, objKeyPanelControl.Size.Width, objKeyPanelControl.Size.Height)
            physicalKeys(flowKeyCode).flowKeyCode = flowKeyCode
            physicalKeys(flowKeyCode).keyText = keyChar
            physicalKeys(flowKeyCode).keyTextRenderPosition = objKeyPanelControl.Location
            physicalKeys(flowKeyCode).iconRenderPosition = getIconRenderPosition(objKeyPanelControl)
        Next
        renderPhysicalKeys()
    End Sub 'Builds an array of the physicalKey structure, for use in frmUI painting of key labels

    Private Shared keyTextFont As New Font("Arial", 8)
    Private Shared objColor As Color = System.Drawing.ColorTranslator.FromHtml("#5f5f5f")
    Private Shared objBrush As New SolidBrush(objColor)
    Private Shared iconDestination As New Rectangle(0, 0, 24, 24)

    Private Shared Sub renderPhysicalKeys()

        'Dim b As New Bitmap(frmUI.BackgroundImage)
        frmUI.BackgroundImage = My.Resources.OSK_1024x768 'GT. 07.07.2010 -- to clean up previously culture keytext
        Dim g As Graphics = Graphics.FromImage(frmUI.BackgroundImage)
        Dim physicalKey As physicalKey
        For Each physicalKey In physicalKeys

            g.DrawString(physicalKey.keyText, keyTextFont, objBrush, physicalKey.keyTextRenderPosition)

        Next
    End Sub

#Region "Misc supporting methods"
    Private Shared Function getIconRenderPosition(ByVal parentPanelControl As Panel) As Point
        Dim x, y As Integer

        x = parentPanelControl.Location.X + (parentPanelControl.Width / 2) - 13
        y = parentPanelControl.Location.Y + (parentPanelControl.Height - 26)

        Dim iconRenderPosition As New Point(x, y)
        Return iconRenderPosition
    End Function

    'GT. 09.03.2010 - commented out, since it leads to reflection

    'Private Shared Function getControlByName(ByVal controlName As String) As Control
    '    'There needs to be a "_" in front of the name for some reason
    '    Dim info As System.Reflection.FieldInfo = frmUI.GetType().GetField("_" & controlName, _
    '    System.Reflection.BindingFlags.NonPublic Or _
    '    System.Reflection.BindingFlags.Instance Or _
    '    System.Reflection.BindingFlags.Public Or _
    '    System.Reflection.BindingFlags.IgnoreCase)
    '    If info Is Nothing Then Return Nothing

    '    Dim o As Object = info.GetValue(frmUI)
    '    Return o
    'End Function 'Find and returns a control object based on that objects name property

    Public Shared Sub preparingForPhysicalKeyBuilding()
        physicalKeys(1).panelControl = frmUI.Panel1
        physicalKeys(2).panelControl = frmUI.Panel2
        physicalKeys(3).panelControl = frmUI.Panel3
        physicalKeys(4).panelControl = frmUI.Panel4
        physicalKeys(5).panelControl = frmUI.Panel5
        physicalKeys(6).panelControl = frmUI.Panel6
        physicalKeys(7).panelControl = frmUI.Panel7
        physicalKeys(8).panelControl = frmUI.Panel8
        physicalKeys(9).panelControl = frmUI.Panel9
        physicalKeys(10).panelControl = frmUI.Panel10
        physicalKeys(11).panelControl = frmUI.Panel11
        physicalKeys(12).panelControl = frmUI.Panel12
        physicalKeys(13).panelControl = frmUI.Panel13
        physicalKeys(14).panelControl = frmUI.Panel14
        physicalKeys(15).panelControl = frmUI.Panel15
        physicalKeys(16).panelControl = frmUI.Panel16
        physicalKeys(17).panelControl = frmUI.Panel17
        physicalKeys(18).panelControl = frmUI.Panel18
        physicalKeys(19).panelControl = frmUI.Panel19
        physicalKeys(20).panelControl = frmUI.Panel20
        physicalKeys(21).panelControl = frmUI.Panel21
        physicalKeys(22).panelControl = frmUI.Panel22
        physicalKeys(23).panelControl = frmUI.Panel23
        physicalKeys(24).panelControl = frmUI.Panel24
        physicalKeys(25).panelControl = frmUI.Panel25
        physicalKeys(26).panelControl = frmUI.Panel26
        physicalKeys(27).panelControl = frmUI.Panel27
        physicalKeys(28).panelControl = frmUI.Panel28
        physicalKeys(29).panelControl = frmUI.Panel29
        physicalKeys(30).panelControl = frmUI.Panel30
        physicalKeys(31).panelControl = frmUI.Panel31
        physicalKeys(32).panelControl = frmUI.Panel32
        physicalKeys(33).panelControl = frmUI.Panel33
        physicalKeys(35).panelControl = frmUI.Panel35
        physicalKeys(36).panelControl = frmUI.Panel36
        physicalKeys(37).panelControl = frmUI.Panel37
        physicalKeys(38).panelControl = frmUI.Panel38
        physicalKeys(39).panelControl = frmUI.Panel39
        physicalKeys(40).panelControl = frmUI.Panel40
        physicalKeys(41).panelControl = frmUI.Panel41
        physicalKeys(42).panelControl = frmUI.Panel42
        physicalKeys(43).panelControl = frmUI.Panel43

        physicalKeys(65).panelControl = frmUI.Panel65
        physicalKeys(64).panelControl = frmUI.Panel64
        physicalKeys(63).panelControl = frmUI.Panel63
        physicalKeys(62).panelControl = frmUI.Panel62
        physicalKeys(61).panelControl = frmUI.Panel61
        physicalKeys(60).panelControl = frmUI.Panel60
        physicalKeys(70).panelControl = frmUI.Panel70
        physicalKeys(66).panelControl = frmUI.Panel66
        physicalKeys(69).panelControl = frmUI.Panel69
        physicalKeys(67).panelControl = frmUI.Panel67
        physicalKeys(68).panelControl = frmUI.Panel68
        physicalKeys(82).panelControl = frmUI.Panel82
        physicalKeys(85).panelControl = frmUI.Panel85
        physicalKeys(83).panelControl = frmUI.Panel83
        physicalKeys(84).panelControl = frmUI.Panel84
        physicalKeys(81).panelControl = frmUI.Panel81
        physicalKeys(80).panelControl = frmUI.Panel80
        physicalKeys(79).panelControl = frmUI.Panel79
        physicalKeys(78).panelControl = frmUI.Panel78
        physicalKeys(77).panelControl = frmUI.Panel77
        physicalKeys(76).panelControl = frmUI.Panel76
        physicalKeys(44).panelControl = frmUI.Panel44
        physicalKeys(54).panelControl = frmUI.Panel54
        physicalKeys(53).panelControl = frmUI.Panel53
        physicalKeys(52).panelControl = frmUI.Panel52
        physicalKeys(57).panelControl = frmUI.Panel57
        physicalKeys(56).panelControl = frmUI.Panel56
        physicalKeys(55).panelControl = frmUI.Panel55
        physicalKeys(58).panelControl = frmUI.Panel58
        physicalKeys(90).panelControl = frmUI.Panel90
        physicalKeys(89).panelControl = frmUI.Panel89
        physicalKeys(88).panelControl = frmUI.Panel88
        physicalKeys(74).panelControl = frmUI.Panel74
        physicalKeys(73).panelControl = frmUI.Panel73
        physicalKeys(72).panelControl = frmUI.Panel72
        physicalKeys(101).panelControl = frmUI.Panel101
        physicalKeys(100).panelControl = frmUI.Panel100
        physicalKeys(99).panelControl = frmUI.Panel99
        physicalKeys(102).panelControl = frmUI.Panel102
        physicalKeys(103).panelControl = frmUI.Panel103
        physicalKeys(87).panelControl = frmUI.Panel87
        physicalKeys(45).panelControl = frmUI.Panel45
        physicalKeys(46).panelControl = frmUI.Panel46
        physicalKeys(47).panelControl = frmUI.Panel47
        physicalKeys(48).panelControl = frmUI.Panel48
        physicalKeys(49).panelControl = frmUI.Panel49
        physicalKeys(50).panelControl = frmUI.Panel50
        physicalKeys(51).panelControl = frmUI.Panel51
        physicalKeys(95).panelControl = frmUI.Panel95

    End Sub 'The alternative code for the getControlByName() sub, need for the correct obfuscation. see task #130,#

#End Region

End Class

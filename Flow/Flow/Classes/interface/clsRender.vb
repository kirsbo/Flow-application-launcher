Imports System.Xml

'GT. 21.02.2010 -- revision of class code is completed.

Public Class clsRender

    Public Const defaultFontResolution = 96
    Public Const defaultButtonFontSize = 15.75
    'Public Shared keyPanels(103) As Panel

    'Private Shared Function isFlowControlKeyCode(ByVal flowKeyCode) As Boolean
    '    Select Case flowKeyCode
    '        Case 1, 38
    '            Return True
    '        Case Else
    '            Return False
    '    End Select
    'End Function 'This function returns true if the flowKeyCode paramameter is the keycode for a flow control (buttons such as Escape (1), Tab (38), etc)

#Region "Command display area methods"
    Public Shared Sub clearCommandDisplay()
        frmUI.labCommandName.Text = ""
        frmUI.imageLargeIcon.Image = Nothing
        frmUI.panCommandDisplay.Visible = False

        frmUI.labKey.Text = ""
        frmUI.panKeyIndicator.Visible = False

        removeFocusEffect()
    End Sub 'Clears the displayed command on frmUI

    Public Shared Sub displayCommand(ByVal flowKeyCode As Integer)
        Dim command As New clsCommand(flowKeyCode)
        frmUI.labCommandName.Text = command.commandName
        frmUI.imageLargeIcon.Load(command.commandIconFullPath)
        frmUI.labKey.Text = command.physicalKey.keyText

        adjustLabKeyFontSize(command.physicalKey.keyText)
        frmUI.panCommandDisplay.Visible = True
        frmUI.panKeyIndicator.Visible = True

        setFocusEffect(flowKeyCode)
    End Sub 'Displays a command on frmUI

    Private Shared Sub setFocusEffect(ByVal flowKeyCode As Integer)
        Dim command As New clsCommand(flowKeyCode)
        frmUI.pboxHoverEffect.Size = command.physicalKey.panelControl.Size
        frmUI.pboxHoverEffect.Location = command.physicalKey.panelControl.Location
        frmUI.pboxHoverEffect.Visible = True
        frmUI.pboxHoverEffect.Tag = flowKeyCode 'pboxHoverEffect's tag property is used to store the flowKeyCode of the currently selected key
        frmUI.Cursor = Cursors.Hand
    End Sub
    Private Shared Sub removeFocusEffect()
        frmUI.pboxHoverEffect.Visible = False
        frmUI.Cursor = Cursors.Default
        frmUI.pboxHoverEffect.Tag = 0 'pboxHoverEffect's tag property is used to store the flowKeyCode, however when there is no key selected, it gets set to 0 meaning it's unselected.
    End Sub

    Private Shared Sub adjustLabKeyFontSize(ByVal keyText As String)
        Dim labKey As Label = frmUI.labKey
        Dim labFontSize As Single
        Dim labLocation As New System.Drawing.Point

        'Select Case keyText.Length
        '    Case 1
        '        labFontSize = 36
        '    Case 2
        '        labFontSize = 30
        '    Case 3
        '        labFontSize = 20
        '    Case 6
        '        labFontSize = 14
        '    Case Else
        '        labFontSize = 15.75
        'End Select
        Dim ratio As Double = defaultFontResolution / getDPI()
        Select Case keyText.Length
            Case 1
                labFontSize = 36 * ratio
            Case 2
                labFontSize = 30 * ratio
            Case 3
                labFontSize = 20 * ratio
            Case 6
                labFontSize = 14 * ratio
            Case Else
                labFontSize = 15.75 * ratio
        End Select

        Dim objFont As New Font("Calibri", labFontSize, FontStyle.Bold) '## The default font (Calibri) for the big key label should come from settings
        labKey.Font = objFont
    End Sub 'Adjusts the frmUI.labKey font so that the text fits the red square background
#End Region

#Region "Various supporting methods"

    Public Shared Function getDPI() As Single
        Dim pop As Graphics = frmUI.CreateGraphics
        'MessageBox.Show(pop.DpiX & " - " & pop.DpiY)
        Return pop.DpiX
    End Function ' GT. 18.06.2010 --Gets system font size in DPI.

    Public Shared Sub adjustFontSizeInButtonTheme()
        Dim doc As New XmlDocument

        Dim nodes As XmlNodeList
        Dim node As XmlNode
        Dim ratio As Double = defaultFontResolution / getDPI()
        Dim size As Single = defaultButtonFontSize * ratio

        Dim fontSize As String = size.ToString("F", System.Globalization.CultureInfo.CreateSpecificCulture("en-CA"))
        Dim sw As New System.IO.StringWriter
        Dim tx As New XmlTextWriter(sw)
        'doc.Load("buttontheme.xml")
        doc.LoadXml(My.Resources.ButtonTheme)
        nodes = doc.SelectNodes("//XmlPropertySetting")
        For Each node In nodes
            If node.Attributes.GetNamedItem("Property").InnerText = "Telerik.WinControls.VisualElement.Font" Then
                'Console.WriteLine(node.Attributes.GetNamedItem("Value").InnerText.ToString)
                node.Attributes.GetNamedItem("Value").InnerText = "Calibri, " & fontSize & "pt"
                'doc.Save("buttontheme.xml")
                doc.WriteTo(tx)
                'My.Resources.ButtonTheme = sw.ToString
            End If
        Next
    End Sub

    Public Shared Sub setCurrentLayoutLabel(ByVal layoutFilename As String)
        Dim layoutName As String = System.IO.Path.GetFileNameWithoutExtension(layoutFilename)
        frmUI.labCurrentLayout.Text = layoutName
    End Sub

    'Private Shared Function MashasFunction(ByVal labelWidth As Integer) As Integer
    '    Const panelWidth As Integer = 62
    '    Return (panelWidth - labelWidth) / 2
    'End Function 'Just here to avoid problems with the mrs., for removing her function. /MK

    Public Shared Function getConfigLabKeyText(ByVal labelText As String) As String
        Dim fontSize As String
        Dim returnText As String = labelText

        If labelText.Length > 1 Then
            fontSize = 40
            If labelText.Length > 2 Then fontSize = 20
            If labelText.Length > 6 Then fontSize = 14
            returnText = "<html><size=" & fontSize & "><b>" & clsFlowGeneral.getKeyTextFromFlowCode(clsKeyConfigurator.FlowKeyCodeToConfigure) & "</b></html>"
        End If

        Return returnText
    End Function

#End Region
End Class

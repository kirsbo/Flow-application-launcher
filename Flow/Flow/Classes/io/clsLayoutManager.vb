Imports System.Xml
Imports System.IO

'GT. 21.02.2010 -- revision of class code is completed.
Public Class clsLayoutManager

    Private Shared xmlCurrentLayout As New Xml.XmlDocument
    Public Shared fullLayoutFolderPath As String = My.Settings.InstalledPath & My.Settings.PathCommandLayouts
    Public Shared commands(103) As clsCommand

    Private Shared Sub buildCommandArray()
        Dim key As XmlNode
        Dim keyList As XmlNodeList = CurrentLayout.SelectNodes("//keys/key")
        Dim flowKeyCode As Integer

        For Each key In keyList
            flowKeyCode = CInt(key.Attributes.GetNamedItem("flowKeyCode").InnerText)
            commands(flowKeyCode) = New clsCommand(flowKeyCode)
        Next
    End Sub
    Public Shared Sub updateCurrentLayout()
        buildCommandArray()
        frmUI.Invalidate()
    End Sub

    Public Shared Sub loadLayout(ByVal layoutFilename As String)
        Dim strFullPath As String = My.Settings.InstalledPath & My.Settings.PathCommandLayouts & layoutFilename
        Try
            xmlCurrentLayout.Load(strFullPath)
        Catch ex As System.IO.FileNotFoundException
            'We can only encounter FileNotFoundException when loading the default layout, since we 
            'handle non-existing layouts in the changeLayout command handler.
            'This exception happens only in a very rare situation, if user has manually deleted all layouts 
            'from layout folder. 
            MsgBox("No 'Home' layout found. Creating new 'Home' layout.")
            createNewLayout("Start.xml")
            strFullPath = My.Settings.InstalledPath & My.Settings.PathCommandLayouts & "Start.xml"
            My.Settings.DefaultLayoutFilename = "Start.xml"
            My.Settings.Save()
            xmlCurrentLayout.Load(strFullPath)
        End Try

        buildCommandArray()

        clsRender.clearCommandDisplay()
        clsRender.setCurrentLayoutLabel(layoutFilename)
        frmUI.Invalidate()
    End Sub
#Region "experiment"
    '    Private Shared keyTextFont As New Font("Arial", 8)
    '    Private Shared objColor As Color = System.Drawing.ColorTranslator.FromHtml("#5f5f5f")
    '    Private Shared objBrush As New SolidBrush(objColor)
    '    Private Shared iconDestination As New Rectangle(0, 0, 24, 24)
    '    Public Shared Sub manualPaint()

    '        Dim b As New Bitmap(frmUI.BackgroundImage)
    '        Dim g As Graphics = Graphics.FromImage(frmUI.BackgroundImage)

    '        Dim command As clsCommand

    '        For Each command In clsLayoutManager.commands
    '            If command Is Nothing Then

    '            Else
    '                g.DrawString(command.physicalKey.keyText & "22", keyTextFont, objBrush, command.physicalKey.keyTextRenderPosition)
    '            End If
    '        Next
    '    End Sub
#End Region
    Public Shared Sub loadDefaultLayout()
        loadLayout(My.Settings.DefaultLayoutFilename)
    End Sub

    Public Shared Property CurrentLayout() As Xml.XmlDocument
        Get
            Return xmlCurrentLayout
        End Get
        Set(ByVal value As Xml.XmlDocument)
            xmlCurrentLayout = value
        End Set
    End Property
    Public Shared Function layoutExists(ByVal layoutName As String) As Boolean
        Dim layoutPath As String = My.Settings.InstalledPath & My.Settings.PathCommandLayouts & layoutName & ".xml"

        Return IO.File.Exists(layoutPath)
    End Function
    Public Shared Sub createNewLayout(ByVal layoutFilename As String)
        Dim newLayoutFile As New Xml.XmlDocument
        newLayoutFile.Load(My.Settings.InstalledPath & My.Settings.PathXmlTemplates & "CommandLayout.xml")
        newLayoutFile.Save(My.Settings.InstalledPath & My.Settings.PathCommandLayouts & layoutFilename)
    End Sub

    Public Shared Sub renameLayout(ByVal layoutName As String, ByVal newLayoutName As String)
        'MessageBox.Show(fullLayoutFolderPath)
        If layoutExists(newLayoutName) = False Then
            Dim sourceLayoutPath As String = fullLayoutFolderPath & layoutName & ".xml"
            Dim destLayoutPath As String = fullLayoutFolderPath & newLayoutName & ".xml"
            Try
                updateCommandLayout("//layoutFileName", layoutName, newLayoutName) 'GT. 22.03.2010 -- updating command layout after a layout's name been changed in th
                IO.File.Move(sourceLayoutPath, destLayoutPath)
                If isDefaultLayout(layoutName) = True Then
                    My.Settings.DefaultLayoutFilename = newLayoutName & ".xml"
                    My.Settings.Save()
                End If
            Catch ex As Exception
                MsgBox("An error occured during renaming process.")
                'MessageBox.Show(ex.ToString)
            End Try
        Else
            MsgBox("There is already a layout with that name. Please try again.")
        End If
    End Sub

    Public Shared Sub setDefaultLayout(ByVal layoutName As String)
        My.Settings.DefaultLayoutFilename = layoutName & ".xml"
        My.Settings.Save()
        MsgBox(layoutName & " is now your 'Home' layout.")
    End Sub

    Public Shared Sub deleteLayout(ByVal layoutName As String, ByVal askForConfirmation As Boolean)
        Dim layoutFullPath As String = My.Settings.InstalledPath & My.Settings.PathCommandLayouts & layoutName & ".xml"

        If isDefaultLayout(layoutName) = True Then
            MsgBox(layoutName & " can not be deleted as it is your 'Home' layout. " & vbLf & vbLf & "To delete it, you will first need to set another layout as your 'Home' layout.")
        Else
            If askForConfirmation = True Then
                If MsgBox("Are you sure you want to delete the '" & layoutName & "' layout?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then IO.File.Delete(layoutFullPath)
            Else
                IO.File.Delete(layoutFullPath)
            End If
        End If
    End Sub

    Public Shared Sub duplicateLayout(ByVal layoutName As String, ByVal newLayoutName As String)
        If layoutExists(newLayoutName) = False Then
            Dim sourceLayoutPath As String = fullLayoutFolderPath & layoutName & ".xml"
            Dim destLayoutPath As String = fullLayoutFolderPath & newLayoutName & ".xml"

            Dim sourceDoc As New Xml.XmlDocument()

            Try
                sourceDoc.Load(sourceLayoutPath)
                sourceDoc.Save(destLayoutPath)
            Catch ex As Exception
                MsgBox("An error occured during duplicating process")
            End Try
        Else
            MsgBox("There is already a layout with that name. Please try again.")
        End If
    End Sub

    Public Shared Function isDefaultLayout(ByVal layoutName As String) As Boolean
        If LCase(My.Settings.DefaultLayoutFilename) = LCase(layoutName) & ".xml" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Shared Function updateXML(ByVal layoutName As String, ByVal nodeName As String, ByVal oldValue As String, ByVal newValue As String)
        Dim commandLayout As New Xml.XmlDocument
        Dim newXMLNodes As XmlNodeList

        Try
            commandLayout.Load(layoutName)
            newXMLNodes = commandLayout.SelectNodes(nodeName)
            If newXMLNodes.Count > 0 Then
                For Each xmlNode As XmlNode In newXMLNodes
                    If xmlNode.InnerText = oldValue & ".xml" Then
                        xmlNode.InnerText = newValue & ".xml" 'updating layoutFileName node
                    End If
                Next
                commandLayout.Save(layoutName)
            End If
            Return True
        Catch
            MessageBox.Show("Error occurs while command layout" & layoutName & "updating")
            Return False
        End Try
    End Function

    Public Shared Sub updateCommandLayout(ByVal nodeName As String, ByVal oldValue As String, ByVal newValue As String)
        'Dim commmandLayouts As New ArrayList
        'Dim commandLayoutDirectory As DirectoryInfo = New DirectoryInfo(My.Settings.PathCommandLayouts)
        Dim commandLayoutDirectory As DirectoryInfo = New DirectoryInfo(fullLayoutFolderPath) 'GT. 18.06.2010 - to fix bug with layout's renaming.

        For Each commandLayout In commandLayoutDirectory.GetFiles("*.xml")
            updateXML(commandLayout.FullName, nodeName, oldValue, newValue)
        Next
    End Sub

End Class

'Imports System.Xml
Imports System.IO.Path

'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmConfigureApp

    Private Sub frmConfigureApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        labKeyIndicator.Text = clsRender.getConfigLabKeyText(clsFlowGeneral.getKeyTextFromFlowCode(clsKeyConfigurator.FlowKeyCodeToConfigure))
        clearAndLoadInstalledApps()
        listInstalledApps.Select()

        If listInstalledApps.Items.Count <= 0 Then
            appSearchButton.Visible = True
            MessageBox.Show("Please set path to ""Programs"" folder by pressing on AppSearch button. " & vbNewLine & "Usually it something like C:\Documents and Settings\All users\Start Menu\Programs")
        End If
        Me.Location = frmUI.Location
    End Sub

    Private Sub clearAndLoadInstalledApps()
        listInstalledApps.Items.Clear()
        Dim installedApp As String
        For Each installedApp In clsAppSearch.ApplicationNames
            If installedApp.Length > 42 Then installedApp = Strings.Left(installedApp, 39) & "..."

            'Only add item if it's not a duplicate
            If listInstalledApps.FindStringExact(installedApp) = -1 Then listInstalledApps.Items.Add(installedApp)
        Next
        listInstalledApps.Sorted = True
        If listInstalledApps.Items.Count > 0 Then
            listInstalledApps.SelectedIndex = 0
        End If
    End Sub

    Private Sub BrowseToExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseToExe.Click
        Dim fileName As String

        fileApplicationBrowser.ShowDialog()
        If fileApplicationBrowser.FileName.Length > 0 Then
            fileName = GetFileName(fileApplicationBrowser.FileName)
            frmFinalizeConfigure.applicationName = fileName.Remove(fileName.Length - 4)
            frmFinalizeConfigure.applicationPath = fileApplicationBrowser.FileName
            frmFinalizeConfigure.finalizeConfigureType = "application"

            Dim frmFinalize As New frmFinalizeConfigure(Me)
            frmFinalize.Show()
        End If
    End Sub ' Show a dialog for browsing .exe 

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        If listInstalledApps.SelectedItem Is Nothing Then
            MsgBox("Please select an application before continuing")
        Else
            Dim applicationName As String
            applicationName = listInstalledApps.SelectedItem
            frmFinalizeConfigure.applicationName = applicationName

            Dim linkPath As String = clsAppSearch.getApplicationPath(applicationName)
            Dim lnk As New clsShellLink
            frmFinalizeConfigure.applicationPath = clsAppSearch.getApplicationPath(applicationName)
            frmFinalizeConfigure.finalizeConfigureType = "application"
            frmFinalizeConfigure.commandImagePath = lnk.GetLinkInfo(linkPath)

            Dim frmFinalize As New frmFinalizeConfigure(Me)
            frmFinalize.Show()
        End If
    End Sub 'Listbox dblclick or Next button click event handler


#Region "Common for Configure forms"
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        listInstalledApps.Items.Clear()

        Me.Close()
    End Sub
    Private Sub frmConfigureApp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, btnNext.KeyPress, btnBack.KeyPress, btnBrowseToExe.KeyPress, listInstalledApps.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                btnNext_Click(sender, e)
            Case Keys.Escape
                btnBack_Click(sender, e)
        End Select
    End Sub
#End Region


#Region "Hiding form from ALT+Tab"
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            ' turn on WS_EX_TOOLWINDOW style bit
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
#End Region

    Private Sub listInstalledApps_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listInstalledApps.MouseDoubleClick
        If listInstalledApps.SelectedItem IsNot Nothing Then
            btnNext_Click(sender, e)
        End If
    End Sub


    Private Sub appSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appSearchButton.Click
        Dim folderBrowser As New System.Windows.Forms.FolderBrowserDialog

        folderBrowser.ShowDialog()
        If folderBrowser.SelectedPath.Length > 0 Then
            clsAppSearch.InitialDirectory = New IO.DirectoryInfo(folderBrowser.SelectedPath)
            clsAppSearch.Search()
            clearAndLoadInstalledApps()
            appSearchButton.Visible = False
        End If
    End Sub
End Class
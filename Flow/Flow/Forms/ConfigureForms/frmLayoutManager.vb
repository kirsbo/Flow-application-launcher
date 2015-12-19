Imports System.Xml

'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmLayoutManager
    Private Sub frmConfigureExistingLayout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = frmUI.Location
        clearAndPopulateListLayouts(0)
        Me.Location = frmUI.Location
    End Sub

    Private Sub clearAndPopulateListLayouts(ByVal indexToFocus As Integer)
        listLayouts.Items.Clear()
        Dim dirFiles() As String = IO.Directory.GetFiles(My.Settings.InstalledPath & My.Settings.PathCommandLayouts)
        For Each dirFile As String In dirFiles
            listLayouts.Items.Add(makeNewListBoxItem(System.IO.Path.GetFileNameWithoutExtension(dirFile)))
        Next
        If listLayouts.Items.Count < indexToFocus + 1 Then
            listLayouts.SelectedIndex = indexToFocus - 1
        Else
            listLayouts.SelectedIndex = indexToFocus
        End If

    End Sub

    Private Function makeNewListBoxItem(ByVal itemText As String) As Telerik.WinControls.UI.RadListBoxItem
        Dim newItem As New Telerik.WinControls.UI.RadListBoxItem
        newItem.Text = itemText
        Return newItem
    End Function

#Region "Common for Configure forms"
    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub frmLayoutmanager_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, listLayouts.KeyPress, btnDelete.KeyPress, btnDone.KeyPress, btnDuplicate.KeyPress, btnMakeNew.KeyPress, btnRename.KeyPress, btnSetDefault.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                btnDone_Click(sender, e)
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
#End Region

    Private Sub btnMakeNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMakeNew.Click
        Dim newLayoutName As String = ""
        Dim inputDialog As New frmInput
        If inputDialog.ShowDialog("Enter new layout name", "", newLayoutName) = Windows.Forms.DialogResult.OK And newLayoutName.Length > 0 Then
            If clsLayoutManager.layoutExists(newLayoutName) = False Then
                clsLayoutManager.createNewLayout(newLayoutName & ".xml")
                clearAndPopulateListLayouts(0)
            Else
                MsgBox("There is already a layout with that name. Please try again.")
            End If
        End If

    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        clsLayoutManager.loadDefaultLayout()
        Me.Close()
    End Sub

    Private Sub btnDuplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplicate.Click
        Dim newLayoutName As String = ""
        Dim selectedLayoutName As String = listLayouts.SelectedText

        Dim inputDialog As New frmInput

        If inputDialog.ShowDialog("Enter name of new layout", selectedLayoutName, newLayoutName) = Windows.Forms.DialogResult.OK Then
            If newLayoutName.Length > 0 Then
                clsLayoutManager.duplicateLayout(selectedLayoutName, newLayoutName)
                clearAndPopulateListLayouts(listLayouts.SelectedIndex)
            End If

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim selectedLayoutName As String = listLayouts.SelectedText
        If My.Computer.Keyboard.ShiftKeyDown = True Then
            clsLayoutManager.deleteLayout(selectedLayoutName, False)
        Else
            clsLayoutManager.deleteLayout(selectedLayoutName, True)
        End If

        clearAndPopulateListLayouts(listLayouts.SelectedIndex)
    End Sub


    Private Sub btnRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRename.Click
        Dim newLayoutName As String = ""
        Dim selectedLayoutName As String = listLayouts.SelectedText

        Dim inputDialog As New frmInput
        If inputDialog.ShowDialog("Enter new name of layout", selectedLayoutName, newLayoutName) = Windows.Forms.DialogResult.OK Then
            If newLayoutName.Length > 0 Then
                clsLayoutManager.renameLayout(selectedLayoutName, newLayoutName)
                clearAndPopulateListLayouts(listLayouts.SelectedIndex)
            End If

        End If

    End Sub


    Private Sub btnSetDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetDefault.Click
        My.Settings.DefaultLayoutFilename = listLayouts.SelectedText & ".xml"
        My.Settings.Save()
        MsgBox(listLayouts.SelectedText & " is now your 'Home' layout.")
    End Sub


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
End Class
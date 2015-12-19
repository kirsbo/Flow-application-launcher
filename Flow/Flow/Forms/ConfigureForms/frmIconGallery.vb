Imports System.IO
Imports System.IO.Path

'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmIconGallery
    Private currentlyViewedFolder As String
    Private Sub frmIconGallery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        clearAndLoadCategories()
        clearAndLoadImages(clsImages.FullIconGalleryPath & clsImages.myImgPath)
        Me.Location = frmUI.Location
    End Sub
    Private Sub clearAndLoadCategories()
        listCategories.Items.Clear()
        Dim iconGalleryInfo As New IO.DirectoryInfo(clsImages.FullIconGalleryPath)
        Dim iconFolder As System.IO.DirectoryInfo
        Dim folderName As String
        Dim newListBoxItem As New Telerik.WinControls.UI.RadListBoxItem
        For Each iconFolder In iconGalleryInfo.GetDirectories
            folderName = LCase(iconFolder.Name)
            If folderShouldBeExcluded(folderName) = False Then
                'newListBoxItem.text = iconFolder.Name
                listCategories.Items.Add(makeNewListBoxItem(iconFolder.Name))
            End If
        Next
        listCategories.Sorted = True
        listCategories.Sorted = False

        listCategories.Items.Insert(0, makeNewListBoxItem("My icons"))
        listCategories.SelectedIndex = 0
    End Sub
    Private Function makeNewListBoxItem(ByVal itemText As String) As Telerik.WinControls.UI.RadListBoxItem
        Dim newItem As New Telerik.WinControls.UI.RadListBoxItem
        newItem.Text = itemText
        Return newItem
    End Function
    Private Function folderShouldBeExcluded(ByVal folderName As String) As Boolean
        folderName = LCase(folderName)
        If folderName = "my icons" Or folderName = ".svn" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub loadImages(ByVal folderPath As String)
        Dim dirFiles() As String = IO.Directory.GetFiles(folderPath)
        Dim counter As Integer = 0
        Dim di As New DirectoryInfo(folderPath)
        currentlyViewedFolder = di.Name & "\" 'Should return last folder in chain, for example "websites\" instead of "[fullgallerypath\]websites\"

        For Each dirFile As String In dirFiles
            If GetExtension(dirFile) = clsImages.defaultImageFormat Then 'File needs to be defaultImageFormat (png) for them to be shown
                listIcons.Images.Add(Image.FromFile(dirFile))
                lvIcons.Items.Add(GetFileNameWithoutExtension(dirFile), counter)
                counter = counter + 1
            End If
        Next
    End Sub
    Private Sub clearAndLoadImages(ByVal folderPath As String)
        listIcons.Images.Clear()
        lvIcons.Items.Clear()
        loadImages(folderPath)
    End Sub

    Private Sub lvIcons_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvIcons.DoubleClick
        btnDone_Click(sender, e)
    End Sub

    Private Sub btnMyicons_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        clearAndLoadImages(clsImages.FullIconGalleryPath & clsImages.myImgPath)
    End Sub

    Private Sub btnAppIcons_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        clearAndLoadImages(clsImages.FullIconGalleryPath & clsImages.appImgPath)
    End Sub

    Private Sub btnWebIcons_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        clearAndLoadImages(clsImages.FullIconGalleryPath & clsImages.webImgPath)
    End Sub

    Private Sub btnExtIcons_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        clearAndLoadImages(clsImages.FullIconGalleryPath & clsImages.extImgPath)
    End Sub

    Private Sub btnAddnew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddnew.Click
        Dim fileDialog As OpenFileDialog = New OpenFileDialog()
        With fileDialog
            .Title = "Choose image"
            .InitialDirectory = "c:\"
            .Filter = "Image files|*.png;*.jpg;*.bmp;*.gif"
            .FilterIndex = 2
            .RestoreDirectory = True
        End With

        If fileDialog.ShowDialog() = DialogResult.OK Then
            clsImages.convertToPngAndSave(fileDialog.FileName)
            clearAndLoadImages(clsImages.FullIconGalleryPath & clsImages.myImgPath)
            selectListItemByName(GetFileNameWithoutExtension(fileDialog.FileName))
        End If
    End Sub
    Private Sub selectListItemByName(ByVal listItemName As String)
        lvIcons.FindItemWithText(listItemName).Selected = True
        lvIcons.Select()
        lvIcons.FindItemWithText(listItemName).EnsureVisible()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#Region "Common for Configure forms"
    Private Sub frmIconGallery_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, btnDone.KeyPress, lvIcons.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                btnDone_Click(sender, e)
            Case Keys.Escape
                btnCancel_Click(sender, e)
        End Select
    End Sub
#End Region
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        If lvIcons.SelectedItems.Count > 0 Then
            clsKeyConfigurator.NewCommandIconPath = currentlyViewedFolder & lvIcons.SelectedItems.Item(0).Text & clsImages.defaultImageFormat
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("Please select an icon before continuing")
        End If
    End Sub

    Private Sub listCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listCategories.SelectedIndexChanged
        clearAndLoadImages(clsImages.FullIconGalleryPath & listCategories.SelectedText & "\")
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

    Private Sub menuItemDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemDelete.Click
        If lvIcons.SelectedItems.Count = 0 Then Exit Sub

        Dim fileToDelete As String = clsImages.FullIconGalleryPath & currentlyViewedFolder & lvIcons.SelectedItems.Item(0).Text & clsImages.defaultImageFormat

        Try
            System.IO.File.Delete(fileToDelete)
        Catch ex As IOException
            MsgBox("This icon cannot be deleted, as it exists in one or more layouts. To delete the icon, you will have to first remove the associated action from all layouts, and then try again. ")
        End Try

        clearAndLoadImages(clsImages.FullIconGalleryPath & listCategories.SelectedText & "\")

    End Sub
End Class
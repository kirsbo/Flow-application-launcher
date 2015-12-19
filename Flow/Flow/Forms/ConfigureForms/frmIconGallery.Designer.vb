<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIconGallery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ThemeSource1 As Telerik.WinControls.ThemeSource = New Telerik.WinControls.ThemeSource()
        Me.lvIcons = New System.Windows.Forms.ListView()
        Me.contextImages = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuItemDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.listIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnAddnew = New Telerik.WinControls.UI.RadButton()
        Me.btnDone = New Telerik.WinControls.UI.RadButton()
        Me.labCurrentLayout = New System.Windows.Forms.Label()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.listCategories = New Telerik.WinControls.UI.RadListBox()
        Me.contextImages.SuspendLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvIcons
        '
        Me.lvIcons.ContextMenuStrip = Me.contextImages
        Me.lvIcons.LargeImageList = Me.listIcons
        Me.lvIcons.Location = New System.Drawing.Point(298, 78)
        Me.lvIcons.Name = "lvIcons"
        Me.lvIcons.Size = New System.Drawing.Size(666, 303)
        Me.lvIcons.TabIndex = 0
        Me.lvIcons.UseCompatibleStateImageBehavior = False
        '
        'contextImages
        '
        Me.contextImages.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemDelete})
        Me.contextImages.Name = "contextImages"
        Me.contextImages.Size = New System.Drawing.Size(108, 26)
        '
        'menuItemDelete
        '
        Me.menuItemDelete.Name = "menuItemDelete"
        Me.menuItemDelete.Size = New System.Drawing.Size(107, 22)
        Me.menuItemDelete.Text = "Delete"
        '
        'listIcons
        '
        Me.listIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.listIcons.ImageSize = New System.Drawing.Size(48, 48)
        Me.listIcons.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(886, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 35)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.ThemeName = "ButtonTheme"
        '
        'btnAddnew
        '
        Me.btnAddnew.BackColor = System.Drawing.Color.Transparent
        Me.btnAddnew.Location = New System.Drawing.Point(41, 403)
        Me.btnAddnew.Name = "btnAddnew"
        Me.btnAddnew.Size = New System.Drawing.Size(235, 36)
        Me.btnAddnew.TabIndex = 26
        Me.btnAddnew.TabStop = False
        Me.btnAddnew.Text = "Add &new icon"
        Me.btnAddnew.ThemeName = "ButtonTheme"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.Location = New System.Drawing.Point(886, 428)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(102, 35)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "&Done"
        Me.btnDone.ThemeName = "ButtonTheme"
        '
        'labCurrentLayout
        '
        Me.labCurrentLayout.BackColor = System.Drawing.Color.Transparent
        Me.labCurrentLayout.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCurrentLayout.ForeColor = System.Drawing.Color.White
        Me.labCurrentLayout.Location = New System.Drawing.Point(62, 26)
        Me.labCurrentLayout.Name = "labCurrentLayout"
        Me.labCurrentLayout.Size = New System.Drawing.Size(200, 45)
        Me.labCurrentLayout.TabIndex = 169
        Me.labCurrentLayout.Text = "Icon categories"
        Me.labCurrentLayout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadThemeManager1
        '
        ThemeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource1.ThemeLocation = "Flow.ThemeListboxV2.xml"
        Me.RadThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {ThemeSource1})
        '
        'listCategories
        '
        Me.listCategories.FormatString = "{0}"
        Me.listCategories.Location = New System.Drawing.Point(41, 78)
        Me.listCategories.Name = "listCategories"
        Me.listCategories.Size = New System.Drawing.Size(235, 303)
        Me.listCategories.TabIndex = 170
        Me.listCategories.ThemeName = "New Theme"
        CType(Me.listCategories.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'frmIconGallery
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.listCategories)
        Me.Controls.Add(Me.labCurrentLayout)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnAddnew)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lvIcons)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIconGallery"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        Me.TopMost = True
        Me.contextImages.ResumeLayout(False)
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvIcons As System.Windows.Forms.ListView
    Friend WithEvents listIcons As System.Windows.Forms.ImageList
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAddnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDone As Telerik.WinControls.UI.RadButton
    Friend WithEvents labCurrentLayout As System.Windows.Forms.Label
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents listCategories As Telerik.WinControls.UI.RadListBox
    Friend WithEvents contextImages As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuItemDelete As System.Windows.Forms.ToolStripMenuItem
End Class

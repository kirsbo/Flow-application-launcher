<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLayoutManager
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
        Dim ThemeSource1 As Telerik.WinControls.ThemeSource = New Telerik.WinControls.ThemeSource()
        Dim ThemeSource2 As Telerik.WinControls.ThemeSource = New Telerik.WinControls.ThemeSource()
        Me.btnDone = New Telerik.WinControls.UI.RadButton()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.listLayouts = New Telerik.WinControls.UI.RadListBox()
        Me.btnDuplicate = New Telerik.WinControls.UI.RadButton()
        Me.btnDelete = New Telerik.WinControls.UI.RadButton()
        Me.btnSetDefault = New Telerik.WinControls.UI.RadButton()
        Me.btnRename = New Telerik.WinControls.UI.RadButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMakeNew = New Telerik.WinControls.UI.RadButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listLayouts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDuplicate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSetDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRename, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMakeNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnDone.Location = New System.Drawing.Point(886, 469)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(102, 35)
        Me.btnDone.TabIndex = 2
        Me.btnDone.TabStop = False
        Me.btnDone.Text = "&OK"
        Me.btnDone.ThemeName = "ButtonTheme"
        '
        'RadThemeManager1
        '
        ThemeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource1.ThemeLocation = "Flow.ThemeListboxV2.xml"
        ThemeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource2.ThemeLocation = "Flow.ButtonTheme.xml"
        Me.RadThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {ThemeSource1, ThemeSource2})
        '
        'listLayouts
        '
        Me.listLayouts.FormatString = "{0}"
        Me.listLayouts.Location = New System.Drawing.Point(240, 146)
        Me.listLayouts.Name = "listLayouts"
        Me.listLayouts.Size = New System.Drawing.Size(239, 247)
        Me.listLayouts.Sorted = Telerik.WinControls.Enumerations.SortStyle.Ascending
        Me.listLayouts.TabIndex = 59
        Me.listLayouts.ThemeName = "New Theme"
        '
        'btnDuplicate
        '
        Me.btnDuplicate.BackColor = System.Drawing.Color.Transparent
        Me.btnDuplicate.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnDuplicate.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnDuplicate.Location = New System.Drawing.Point(547, 259)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.Size = New System.Drawing.Size(239, 35)
        Me.btnDuplicate.TabIndex = 60
        Me.btnDuplicate.Text = "Make a &copy"
        Me.btnDuplicate.ThemeName = "ButtonTheme"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnDelete.Location = New System.Drawing.Point(547, 200)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(239, 35)
        Me.btnDelete.TabIndex = 61
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.ThemeName = "ButtonTheme"
        '
        'btnSetDefault
        '
        Me.btnSetDefault.BackColor = System.Drawing.Color.Transparent
        Me.btnSetDefault.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnSetDefault.Font = New System.Drawing.Font("Calibri", 15.25!)
        Me.btnSetDefault.Location = New System.Drawing.Point(547, 146)
        Me.btnSetDefault.Name = "btnSetDefault"
        Me.btnSetDefault.Size = New System.Drawing.Size(239, 35)
        Me.btnSetDefault.TabIndex = 62
        Me.btnSetDefault.Text = "&Set this layout as 'Home'"
        Me.btnSetDefault.ThemeName = "ButtonTheme"
        '
        'btnRename
        '
        Me.btnRename.BackColor = System.Drawing.Color.Transparent
        Me.btnRename.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnRename.Font = New System.Drawing.Font("Calibri", 15.25!)
        Me.btnRename.Location = New System.Drawing.Point(547, 313)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(239, 35)
        Me.btnRename.TabIndex = 65
        Me.btnRename.Text = "&Rename"
        Me.btnRename.ThemeName = "ButtonTheme"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(378, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 39)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Layout management"
        '
        'btnMakeNew
        '
        Me.btnMakeNew.BackColor = System.Drawing.Color.Transparent
        Me.btnMakeNew.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnMakeNew.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnMakeNew.Location = New System.Drawing.Point(240, 414)
        Me.btnMakeNew.Name = "btnMakeNew"
        Me.btnMakeNew.Size = New System.Drawing.Size(239, 35)
        Me.btnMakeNew.TabIndex = 68
        Me.btnMakeNew.Text = "Create &new layout"
        Me.btnMakeNew.ThemeName = "ButtonTheme"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(294, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "List of layouts"
        '
        'frmLayoutManager
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMakeNew)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnSetDefault)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDuplicate)
        Me.Controls.Add(Me.listLayouts)
        Me.Controls.Add(Me.btnDone)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLayoutManager"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        Me.TopMost = True
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listLayouts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDuplicate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSetDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRename, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMakeNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDone As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents listLayouts As Telerik.WinControls.UI.RadListBox
    Friend WithEvents btnDuplicate As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSetDefault As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnRename As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnMakeNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

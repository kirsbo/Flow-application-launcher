<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigureKey
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
        Me.labWhatShouldHappen = New System.Windows.Forms.Label()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.fileBrowser = New System.Windows.Forms.OpenFileDialog()
        Me.radThemeConfigureKey = New Telerik.WinControls.RadThemeManager()
        Me.rBtnOpenFile = New Telerik.WinControls.UI.RadButton()
        Me.rBtnOpenFolder = New Telerik.WinControls.UI.RadButton()
        Me.rBtnStartApp = New Telerik.WinControls.UI.RadButton()
        Me.rBtnOpenWebsite = New Telerik.WinControls.UI.RadButton()
        Me.rBtnNavToLayout = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.labKeyIndicator = New Telerik.WinControls.UI.RadLabel()
        CType(Me.rBtnOpenFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rBtnOpenFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rBtnStartApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rBtnOpenWebsite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rBtnNavToLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labWhatShouldHappen
        '
        Me.labWhatShouldHappen.AutoSize = True
        Me.labWhatShouldHappen.BackColor = System.Drawing.Color.Transparent
        Me.labWhatShouldHappen.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labWhatShouldHappen.ForeColor = System.Drawing.Color.White
        Me.labWhatShouldHappen.Location = New System.Drawing.Point(199, 120)
        Me.labWhatShouldHappen.Name = "labWhatShouldHappen"
        Me.labWhatShouldHappen.Size = New System.Drawing.Size(602, 36)
        Me.labWhatShouldHappen.TabIndex = 3
        Me.labWhatShouldHappen.Text = "What should happen when this button is pressed?"
        '
        'radThemeConfigureKey
        '
        ThemeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource1.ThemeLocation = "Flow.LabelTheme.xml"
        ThemeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource2.ThemeLocation = "Flow.ButtonTheme.xml"
        Me.radThemeConfigureKey.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {ThemeSource1, ThemeSource2})
        '
        'rBtnOpenFile
        '
        Me.rBtnOpenFile.BackColor = System.Drawing.Color.Transparent
        Me.rBtnOpenFile.Location = New System.Drawing.Point(325, 187)
        Me.rBtnOpenFile.Name = "rBtnOpenFile"
        Me.rBtnOpenFile.Size = New System.Drawing.Size(341, 36)
        Me.rBtnOpenFile.TabIndex = 2
        Me.rBtnOpenFile.Text = "Open a &File"
        Me.rBtnOpenFile.ThemeName = "ButtonTheme"
        '
        'rBtnOpenFolder
        '
        Me.rBtnOpenFolder.BackColor = System.Drawing.Color.Transparent
        Me.rBtnOpenFolder.Location = New System.Drawing.Point(325, 248)
        Me.rBtnOpenFolder.Name = "rBtnOpenFolder"
        Me.rBtnOpenFolder.Size = New System.Drawing.Size(341, 36)
        Me.rBtnOpenFolder.TabIndex = 3
        Me.rBtnOpenFolder.Text = "Open a F&older"
        Me.rBtnOpenFolder.ThemeName = "ButtonTheme"
        '
        'rBtnStartApp
        '
        Me.rBtnStartApp.BackColor = System.Drawing.Color.Transparent
        Me.rBtnStartApp.Location = New System.Drawing.Point(325, 308)
        Me.rBtnStartApp.Name = "rBtnStartApp"
        Me.rBtnStartApp.Size = New System.Drawing.Size(341, 36)
        Me.rBtnStartApp.TabIndex = 4
        Me.rBtnStartApp.Text = "Start an &Application"
        Me.rBtnStartApp.ThemeName = "ButtonTheme"
        '
        'rBtnOpenWebsite
        '
        Me.rBtnOpenWebsite.BackColor = System.Drawing.Color.Transparent
        Me.rBtnOpenWebsite.Location = New System.Drawing.Point(325, 368)
        Me.rBtnOpenWebsite.Name = "rBtnOpenWebsite"
        Me.rBtnOpenWebsite.Size = New System.Drawing.Size(341, 36)
        Me.rBtnOpenWebsite.TabIndex = 5
        Me.rBtnOpenWebsite.Text = "Open a &Website"
        Me.rBtnOpenWebsite.ThemeName = "ButtonTheme"
        '
        'rBtnNavToLayout
        '
        Me.rBtnNavToLayout.BackColor = System.Drawing.Color.Transparent
        Me.rBtnNavToLayout.Location = New System.Drawing.Point(325, 428)
        Me.rBtnNavToLayout.Name = "rBtnNavToLayout"
        Me.rBtnNavToLayout.Size = New System.Drawing.Size(341, 36)
        Me.rBtnNavToLayout.TabIndex = 6
        Me.rBtnNavToLayout.Text = "Go to another &Layout"
        Me.rBtnNavToLayout.ThemeName = "ButtonTheme"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(886, 467)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 35)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.ThemeName = "ButtonTheme"
        '
        'labKeyIndicator
        '
        Me.labKeyIndicator.AutoSize = False
        Me.labKeyIndicator.BackColor = System.Drawing.Color.Transparent
        Me.labKeyIndicator.Location = New System.Drawing.Point(456, 28)
        Me.labKeyIndicator.Name = "labKeyIndicator"
        '
        '
        '
        Me.labKeyIndicator.RootElement.StretchHorizontally = True
        Me.labKeyIndicator.RootElement.StretchVertically = True
        Me.labKeyIndicator.Size = New System.Drawing.Size(82, 87)
        Me.labKeyIndicator.TabIndex = 16
        Me.labKeyIndicator.Text = "W"
        Me.labKeyIndicator.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.labKeyIndicator.TextWrap = True
        Me.labKeyIndicator.ThemeName = "LabelTheme"
        '
        'frmConfigureKey
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.labKeyIndicator)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.rBtnOpenWebsite)
        Me.Controls.Add(Me.rBtnNavToLayout)
        Me.Controls.Add(Me.rBtnStartApp)
        Me.Controls.Add(Me.rBtnOpenFolder)
        Me.Controls.Add(Me.rBtnOpenFile)
        Me.Controls.Add(Me.labWhatShouldHappen)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfigureKey"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        Me.TopMost = True
        CType(Me.rBtnOpenFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rBtnOpenFolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rBtnStartApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rBtnOpenWebsite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rBtnNavToLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labWhatShouldHappen As System.Windows.Forms.Label
    Friend WithEvents folderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents fileBrowser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents radThemeConfigureKey As Telerik.WinControls.RadThemeManager
    Friend WithEvents rBtnOpenFile As Telerik.WinControls.UI.RadButton
    Friend WithEvents rBtnStartApp As Telerik.WinControls.UI.RadButton
    Friend WithEvents rBtnOpenFolder As Telerik.WinControls.UI.RadButton
    Friend WithEvents rBtnOpenWebsite As Telerik.WinControls.UI.RadButton
    Friend WithEvents rBtnNavToLayout As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents labKeyIndicator As Telerik.WinControls.UI.RadLabel
End Class

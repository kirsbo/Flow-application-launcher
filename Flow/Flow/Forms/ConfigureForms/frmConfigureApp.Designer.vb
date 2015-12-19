<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigureApp
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
        Me.labWhatShouldHappen = New System.Windows.Forms.Label()
        Me.labOr = New System.Windows.Forms.Label()
        Me.fileApplicationBrowser = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrowseToExe = New Telerik.WinControls.UI.RadButton()
        Me.btnNext = New Telerik.WinControls.UI.RadButton()
        Me.btnBack = New Telerik.WinControls.UI.RadButton()
        Me.labKeyIndicator = New Telerik.WinControls.UI.RadLabel()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.RadListBoxItem1 = New Telerik.WinControls.UI.RadListBoxItem()
        Me.listInstalledApps = New System.Windows.Forms.ListBox()
        Me.appSearchButton = New Telerik.WinControls.UI.RadButton()
        CType(Me.btnBrowseToExe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appSearchButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labWhatShouldHappen
        '
        Me.labWhatShouldHappen.AutoSize = True
        Me.labWhatShouldHappen.BackColor = System.Drawing.Color.Transparent
        Me.labWhatShouldHappen.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labWhatShouldHappen.ForeColor = System.Drawing.Color.White
        Me.labWhatShouldHappen.Location = New System.Drawing.Point(298, 120)
        Me.labWhatShouldHappen.Name = "labWhatShouldHappen"
        Me.labWhatShouldHappen.Size = New System.Drawing.Size(404, 36)
        Me.labWhatShouldHappen.TabIndex = 39
        Me.labWhatShouldHappen.Text = "Select from installed applications"
        '
        'labOr
        '
        Me.labOr.AutoSize = True
        Me.labOr.BackColor = System.Drawing.Color.Transparent
        Me.labOr.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labOr.ForeColor = System.Drawing.Color.White
        Me.labOr.Location = New System.Drawing.Point(483, 404)
        Me.labOr.Name = "labOr"
        Me.labOr.Size = New System.Drawing.Size(44, 36)
        Me.labOr.TabIndex = 44
        Me.labOr.Text = "Or"
        '
        'fileApplicationBrowser
        '
        Me.fileApplicationBrowser.Filter = "Executables|*.exe"
        '
        'btnBrowseToExe
        '
        Me.btnBrowseToExe.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowseToExe.Location = New System.Drawing.Point(332, 466)
        Me.btnBrowseToExe.Name = "btnBrowseToExe"
        Me.btnBrowseToExe.Size = New System.Drawing.Size(341, 36)
        Me.btnBrowseToExe.TabIndex = 3
        Me.btnBrowseToExe.Text = "Browse to &application"
        Me.btnBrowseToExe.ThemeName = "ButtonTheme"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnNext.Location = New System.Drawing.Point(886, 428)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(102, 35)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "&Next"
        Me.btnNext.ThemeName = "ButtonTheme"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnBack.Location = New System.Drawing.Point(886, 469)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(102, 35)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "&Back"
        Me.btnBack.ThemeName = "ButtonTheme"
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
        Me.labKeyIndicator.TabIndex = 48
        Me.labKeyIndicator.Text = "W"
        Me.labKeyIndicator.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.labKeyIndicator.TextWrap = True
        Me.labKeyIndicator.ThemeName = "LabelTheme"
        '
        'RadThemeManager1
        '
        ThemeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource1.ThemeLocation = "Flow.ThemeListboxV2.xml"
        Me.RadThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {ThemeSource1})
        '
        'RadListBoxItem1
        '
        Me.RadListBoxItem1.Name = "RadListBoxItem1"
        Me.RadListBoxItem1.Text = "12345678901234567890123456789012345678901234567890123456"
        '
        'listInstalledApps
        '
        Me.listInstalledApps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listInstalledApps.FormattingEnabled = True
        Me.listInstalledApps.ItemHeight = 18
        Me.listInstalledApps.Location = New System.Drawing.Point(301, 174)
        Me.listInstalledApps.Name = "listInstalledApps"
        Me.listInstalledApps.Size = New System.Drawing.Size(398, 202)
        Me.listInstalledApps.TabIndex = 50
        '
        'appSearchButton
        '
        Me.appSearchButton.BackColor = System.Drawing.Color.Transparent
        Me.appSearchButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.appSearchButton.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.appSearchButton.Location = New System.Drawing.Point(716, 253)
        Me.appSearchButton.Name = "appSearchButton"
        Me.appSearchButton.Size = New System.Drawing.Size(136, 35)
        Me.appSearchButton.TabIndex = 51
        Me.appSearchButton.Text = "&AppSearch"
        Me.appSearchButton.ThemeName = "ButtonTheme"
        Me.appSearchButton.Visible = False
        '
        'frmConfigureApp
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.appSearchButton)
        Me.Controls.Add(Me.listInstalledApps)
        Me.Controls.Add(Me.labKeyIndicator)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBrowseToExe)
        Me.Controls.Add(Me.labOr)
        Me.Controls.Add(Me.labWhatShouldHappen)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfigureApp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        Me.TopMost = True
        CType(Me.btnBrowseToExe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appSearchButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labWhatShouldHappen As System.Windows.Forms.Label
    Friend WithEvents labOr As System.Windows.Forms.Label
    Friend WithEvents fileApplicationBrowser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnBrowseToExe As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnNext As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnBack As Telerik.WinControls.UI.RadButton
    Friend WithEvents labKeyIndicator As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents RadListBoxItem1 As Telerik.WinControls.UI.RadListBoxItem
    Friend WithEvents listInstalledApps As System.Windows.Forms.ListBox
    Friend WithEvents appSearchButton As Telerik.WinControls.UI.RadButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigureExistingLayout
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
        Me.labOr = New System.Windows.Forms.Label()
        Me.labWhatShouldHappen = New System.Windows.Forms.Label()
        Me.btnCreateLayout = New Telerik.WinControls.UI.RadButton()
        Me.labKeyIndicator = New Telerik.WinControls.UI.RadLabel()
        Me.btnBack = New Telerik.WinControls.UI.RadButton()
        Me.btnNext = New Telerik.WinControls.UI.RadButton()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.listLayouts = New Telerik.WinControls.UI.RadListBox()
        CType(Me.btnCreateLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listLayouts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.labOr.TabIndex = 51
        Me.labOr.Text = "Or"
        '
        'labWhatShouldHappen
        '
        Me.labWhatShouldHappen.AutoSize = True
        Me.labWhatShouldHappen.BackColor = System.Drawing.Color.Transparent
        Me.labWhatShouldHappen.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labWhatShouldHappen.ForeColor = System.Drawing.Color.White
        Me.labWhatShouldHappen.Location = New System.Drawing.Point(336, 120)
        Me.labWhatShouldHappen.Name = "labWhatShouldHappen"
        Me.labWhatShouldHappen.Size = New System.Drawing.Size(337, 36)
        Me.labWhatShouldHappen.TabIndex = 47
        Me.labWhatShouldHappen.Text = "Select from existing layouts"
        '
        'btnCreateLayout
        '
        Me.btnCreateLayout.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateLayout.Location = New System.Drawing.Point(332, 466)
        Me.btnCreateLayout.Name = "btnCreateLayout"
        Me.btnCreateLayout.Size = New System.Drawing.Size(341, 36)
        Me.btnCreateLayout.TabIndex = 3
        Me.btnCreateLayout.TabStop = False
        Me.btnCreateLayout.Text = "&Create a new layout"
        Me.btnCreateLayout.ThemeName = "ButtonTheme"
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
        Me.labKeyIndicator.TabIndex = 58
        Me.labKeyIndicator.Text = "W"
        Me.labKeyIndicator.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.labKeyIndicator.TextWrap = True
        Me.labKeyIndicator.ThemeName = "LabelTheme"
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
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "&Back"
        Me.btnBack.ThemeName = "ButtonTheme"
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
        'RadThemeManager1
        '
        ThemeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource1.ThemeLocation = "Flow.ThemeListboxV2.xml"
        Me.RadThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {ThemeSource1})
        '
        'listLayouts
        '
        Me.listLayouts.FormatString = "{0}"
        Me.listLayouts.Location = New System.Drawing.Point(301, 174)
        Me.listLayouts.Name = "listLayouts"
        Me.listLayouts.Size = New System.Drawing.Size(398, 202)
        Me.listLayouts.TabIndex = 59
        Me.listLayouts.ThemeName = "New Theme"
        '
        'frmConfigureExistingLayout
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.listLayouts)
        Me.Controls.Add(Me.labKeyIndicator)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCreateLayout)
        Me.Controls.Add(Me.labOr)
        Me.Controls.Add(Me.labWhatShouldHappen)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfigureExistingLayout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        Me.TopMost = True
        CType(Me.btnCreateLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listLayouts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labOr As System.Windows.Forms.Label
    Friend WithEvents labWhatShouldHappen As System.Windows.Forms.Label
    Friend WithEvents btnCreateLayout As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnBack As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnNext As Telerik.WinControls.UI.RadButton
    Friend WithEvents labKeyIndicator As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents listLayouts As Telerik.WinControls.UI.RadListBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.txtTriggerKey = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkWinkey = New System.Windows.Forms.CheckBox()
        Me.checkControl = New System.Windows.Forms.CheckBox()
        Me.checkAlt = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnDone = New Telerik.WinControls.UI.RadButton()
        Me.radThemeSettings = New Telerik.WinControls.RadThemeManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radioSoundOn = New System.Windows.Forms.RadioButton()
        Me.radioSoundoff = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radioDisplayLayoutHome = New System.Windows.Forms.RadioButton()
        Me.radioDisplayLayoutPrevious = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.checkUpdates = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.splashScreen = New System.Windows.Forms.CheckBox()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTriggerKey
        '
        Me.txtTriggerKey.Location = New System.Drawing.Point(675, 166)
        Me.txtTriggerKey.MaxLength = 1
        Me.txtTriggerKey.Name = "txtTriggerKey"
        Me.txtTriggerKey.Size = New System.Drawing.Size(25, 26)
        Me.txtTriggerKey.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(579, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "and"
        '
        'checkWinkey
        '
        Me.checkWinkey.AutoSize = True
        Me.checkWinkey.BackColor = System.Drawing.Color.Transparent
        Me.checkWinkey.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkWinkey.ForeColor = System.Drawing.Color.White
        Me.checkWinkey.Location = New System.Drawing.Point(449, 170)
        Me.checkWinkey.Name = "checkWinkey"
        Me.checkWinkey.Size = New System.Drawing.Size(146, 28)
        Me.checkWinkey.TabIndex = 15
        Me.checkWinkey.Text = "Windows key"
        Me.checkWinkey.UseVisualStyleBackColor = False
        '
        'checkControl
        '
        Me.checkControl.AutoSize = True
        Me.checkControl.BackColor = System.Drawing.Color.Transparent
        Me.checkControl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkControl.ForeColor = System.Drawing.Color.White
        Me.checkControl.Location = New System.Drawing.Point(290, 170)
        Me.checkControl.Name = "checkControl"
        Me.checkControl.Size = New System.Drawing.Size(99, 28)
        Me.checkControl.TabIndex = 14
        Me.checkControl.Text = "Control"
        Me.checkControl.UseVisualStyleBackColor = False
        '
        'checkAlt
        '
        Me.checkAlt.AutoSize = True
        Me.checkAlt.BackColor = System.Drawing.Color.Transparent
        Me.checkAlt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAlt.ForeColor = System.Drawing.Color.White
        Me.checkAlt.Location = New System.Drawing.Point(390, 170)
        Me.checkAlt.Name = "checkAlt"
        Me.checkAlt.Size = New System.Drawing.Size(60, 28)
        Me.checkAlt.TabIndex = 13
        Me.checkAlt.Text = "Alt"
        Me.checkAlt.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(640, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "1) To display Flow, the following key combination should be pressed:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(423, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 59)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Settings"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnCancel.Location = New System.Drawing.Point(886, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 35)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.ThemeName = "ButtonTheme"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnDone.Location = New System.Drawing.Point(886, 428)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(102, 35)
        Me.btnDone.TabIndex = 25
        Me.btnDone.Text = "&Done"
        Me.btnDone.ThemeName = "ButtonTheme"
        '
        'radThemeSettings
        '
        ThemeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource1.ThemeLocation = "Flow.LabelTheme.xml"
        ThemeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource2.ThemeLocation = "Flow.ButtonTheme.xml"
        Me.radThemeSettings.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {ThemeSource1, ThemeSource2})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(264, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 28)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "2) Sound effects"
        '
        'radioSoundOn
        '
        Me.radioSoundOn.AutoSize = True
        Me.radioSoundOn.BackColor = System.Drawing.Color.Transparent
        Me.radioSoundOn.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.radioSoundOn.ForeColor = System.Drawing.Color.White
        Me.radioSoundOn.Location = New System.Drawing.Point(35, 12)
        Me.radioSoundOn.Name = "radioSoundOn"
        Me.radioSoundOn.Size = New System.Drawing.Size(59, 28)
        Me.radioSoundOn.TabIndex = 28
        Me.radioSoundOn.TabStop = True
        Me.radioSoundOn.Text = "On"
        Me.radioSoundOn.UseVisualStyleBackColor = False
        '
        'radioSoundoff
        '
        Me.radioSoundoff.AutoSize = True
        Me.radioSoundoff.BackColor = System.Drawing.Color.Transparent
        Me.radioSoundoff.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.radioSoundoff.ForeColor = System.Drawing.Color.White
        Me.radioSoundoff.Location = New System.Drawing.Point(124, 12)
        Me.radioSoundoff.Name = "radioSoundoff"
        Me.radioSoundoff.Size = New System.Drawing.Size(60, 28)
        Me.radioSoundoff.TabIndex = 29
        Me.radioSoundoff.TabStop = True
        Me.radioSoundoff.Text = "Off"
        Me.radioSoundoff.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(264, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(614, 28)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "3) [Advanced] When activating Flow, display the following layout:"
        '
        'radioDisplayLayoutHome
        '
        Me.radioDisplayLayoutHome.AutoSize = True
        Me.radioDisplayLayoutHome.BackColor = System.Drawing.Color.Transparent
        Me.radioDisplayLayoutHome.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.radioDisplayLayoutHome.ForeColor = System.Drawing.Color.White
        Me.radioDisplayLayoutHome.Location = New System.Drawing.Point(26, 11)
        Me.radioDisplayLayoutHome.Name = "radioDisplayLayoutHome"
        Me.radioDisplayLayoutHome.Size = New System.Drawing.Size(158, 28)
        Me.radioDisplayLayoutHome.TabIndex = 31
        Me.radioDisplayLayoutHome.TabStop = True
        Me.radioDisplayLayoutHome.Text = """Home"" layout"
        Me.radioDisplayLayoutHome.UseVisualStyleBackColor = False
        '
        'radioDisplayLayoutPrevious
        '
        Me.radioDisplayLayoutPrevious.AutoSize = True
        Me.radioDisplayLayoutPrevious.BackColor = System.Drawing.Color.Transparent
        Me.radioDisplayLayoutPrevious.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.radioDisplayLayoutPrevious.ForeColor = System.Drawing.Color.White
        Me.radioDisplayLayoutPrevious.Location = New System.Drawing.Point(194, 10)
        Me.radioDisplayLayoutPrevious.Name = "radioDisplayLayoutPrevious"
        Me.radioDisplayLayoutPrevious.Size = New System.Drawing.Size(284, 28)
        Me.radioDisplayLayoutPrevious.TabIndex = 32
        Me.radioDisplayLayoutPrevious.TabStop = True
        Me.radioDisplayLayoutPrevious.Text = "My previously selected layout"
        Me.radioDisplayLayoutPrevious.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.radioSoundOn)
        Me.Panel1.Controls.Add(Me.radioSoundoff)
        Me.Panel1.Location = New System.Drawing.Point(255, 244)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 43)
        Me.Panel1.TabIndex = 35
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.radioDisplayLayoutHome)
        Me.Panel2.Controls.Add(Me.radioDisplayLayoutPrevious)
        Me.Panel2.Location = New System.Drawing.Point(264, 336)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 40)
        Me.Panel2.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(264, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(310, 28)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "4) Check for updates on start up"
        '
        'checkUpdates
        '
        Me.checkUpdates.AutoSize = True
        Me.checkUpdates.BackColor = System.Drawing.Color.Transparent
        Me.checkUpdates.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkUpdates.ForeColor = System.Drawing.Color.White
        Me.checkUpdates.Location = New System.Drawing.Point(290, 426)
        Me.checkUpdates.Name = "checkUpdates"
        Me.checkUpdates.Size = New System.Drawing.Size(151, 28)
        Me.checkUpdates.TabIndex = 14
        Me.checkUpdates.Text = "Automatically"
        Me.checkUpdates.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(263, 454)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(264, 28)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "5) Splash screen on startup"
        '
        'splashScreen
        '
        Me.splashScreen.AutoSize = True
        Me.splashScreen.BackColor = System.Drawing.Color.Transparent
        Me.splashScreen.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.splashScreen.ForeColor = System.Drawing.Color.White
        Me.splashScreen.Location = New System.Drawing.Point(290, 483)
        Me.splashScreen.Name = "splashScreen"
        Me.splashScreen.Size = New System.Drawing.Size(81, 28)
        Me.splashScreen.TabIndex = 38
        Me.splashScreen.Text = "Show"
        Me.splashScreen.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.splashScreen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTriggerKey)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.checkWinkey)
        Me.Controls.Add(Me.checkUpdates)
        Me.Controls.Add(Me.checkControl)
        Me.Controls.Add(Me.checkAlt)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.Text = "Flow"
        Me.TopMost = True
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTriggerKey As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents checkWinkey As System.Windows.Forms.CheckBox
    Friend WithEvents checkControl As System.Windows.Forms.CheckBox
    Friend WithEvents checkAlt As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDone As Telerik.WinControls.UI.RadButton
    Friend WithEvents radThemeSettings As Telerik.WinControls.RadThemeManager
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radioSoundOn As System.Windows.Forms.RadioButton
    Friend WithEvents radioSoundoff As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents radioDisplayLayoutHome As System.Windows.Forms.RadioButton
    Friend WithEvents radioDisplayLayoutPrevious As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents checkUpdates As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents splashScreen As System.Windows.Forms.CheckBox
End Class

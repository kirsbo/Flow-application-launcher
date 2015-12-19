<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutorialStep1
    Inherits Flow.baseform

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelCommandDisplay = New System.Windows.Forms.Panel()
        Me.btnChangeTriggerKey = New Telerik.WinControls.UI.RadButton()
        Me.pboxChangeKeyCombo = New System.Windows.Forms.PictureBox()
        Me.labChangeKeyCombo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imageLargeIcon = New System.Windows.Forms.PictureBox()
        Me.btnNext = New Telerik.WinControls.UI.RadButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCommandDisplay.SuspendLayout()
        CType(Me.btnChangeTriggerKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxChangeKeyCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageLargeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(380, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 39)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "First things to know!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Flow.My.Resources.Resources.Tutor_ActivateFlow2
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 435)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'panelCommandDisplay
        '
        Me.panelCommandDisplay.BackColor = System.Drawing.Color.Transparent
        Me.panelCommandDisplay.BackgroundImage = Global.Flow.My.Resources.Resources.transparentLargeBox
        Me.panelCommandDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelCommandDisplay.Controls.Add(Me.btnChangeTriggerKey)
        Me.panelCommandDisplay.Controls.Add(Me.pboxChangeKeyCombo)
        Me.panelCommandDisplay.Controls.Add(Me.labChangeKeyCombo)
        Me.panelCommandDisplay.Controls.Add(Me.Label1)
        Me.panelCommandDisplay.Controls.Add(Me.imageLargeIcon)
        Me.panelCommandDisplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.panelCommandDisplay.Location = New System.Drawing.Point(313, 125)
        Me.panelCommandDisplay.Name = "panelCommandDisplay"
        Me.panelCommandDisplay.Size = New System.Drawing.Size(611, 309)
        Me.panelCommandDisplay.TabIndex = 312
        '
        'btnChangeTriggerKey
        '
        Me.btnChangeTriggerKey.BackColor = System.Drawing.Color.Transparent
        Me.btnChangeTriggerKey.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnChangeTriggerKey.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnChangeTriggerKey.Location = New System.Drawing.Point(39, 174)
        Me.btnChangeTriggerKey.Name = "btnChangeTriggerKey"
        Me.btnChangeTriggerKey.Size = New System.Drawing.Size(532, 67)
        Me.btnChangeTriggerKey.TabIndex = 314
        Me.btnChangeTriggerKey.Text = "OK, but what if I want to change the Alt + Q combination?"
        Me.btnChangeTriggerKey.ThemeName = "ButtonTheme"
        '
        'pboxChangeKeyCombo
        '
        Me.pboxChangeKeyCombo.Image = Global.Flow.My.Resources.Resources.Tutor_Settings
        Me.pboxChangeKeyCombo.Location = New System.Drawing.Point(442, 174)
        Me.pboxChangeKeyCombo.Name = "pboxChangeKeyCombo"
        Me.pboxChangeKeyCombo.Size = New System.Drawing.Size(130, 115)
        Me.pboxChangeKeyCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxChangeKeyCombo.TabIndex = 315
        Me.pboxChangeKeyCombo.TabStop = False
        Me.pboxChangeKeyCombo.Visible = False
        '
        'labChangeKeyCombo
        '
        Me.labChangeKeyCombo.AutoSize = True
        Me.labChangeKeyCombo.BackColor = System.Drawing.Color.Transparent
        Me.labChangeKeyCombo.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labChangeKeyCombo.ForeColor = System.Drawing.Color.White
        Me.labChangeKeyCombo.Location = New System.Drawing.Point(36, 206)
        Me.labChangeKeyCombo.Name = "labChangeKeyCombo"
        Me.labChangeKeyCombo.Size = New System.Drawing.Size(345, 78)
        Me.labChangeKeyCombo.TabIndex = 314
        Me.labChangeKeyCombo.Text = "You can change the key combination " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that activates / hides Flow. This setting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "c" & _
            "an be accessed from the Flow button. "
        Me.labChangeKeyCombo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(69, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 52)
        Me.Label1.TabIndex = 313
        Me.Label1.Text = "You activate Flow by pressing Alt + Q down at the same time. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can hide it, a" & _
            "lso by pressing Alt + Q."
        '
        'imageLargeIcon
        '
        Me.imageLargeIcon.BackColor = System.Drawing.Color.Transparent
        Me.imageLargeIcon.Image = Global.Flow.My.Resources.Resources.iconLargeHelp
        Me.imageLargeIcon.Location = New System.Drawing.Point(15, 16)
        Me.imageLargeIcon.Name = "imageLargeIcon"
        Me.imageLargeIcon.Size = New System.Drawing.Size(48, 48)
        Me.imageLargeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageLargeIcon.TabIndex = 63
        Me.imageLargeIcon.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnNext.Location = New System.Drawing.Point(886, 469)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(102, 35)
        Me.btnNext.TabIndex = 313
        Me.btnNext.Text = "&Next"
        Me.btnNext.ThemeName = "ButtonTheme"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(821, 469)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 314
        Me.Label2.Text = "1 of 4"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(946, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 38)
        Me.btnClose.TabIndex = 320
        Me.btnClose.Text = "X"
        Me.btnClose.ThemeName = "ButtonTheme"
        '
        'frmTutorialStep1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.panelCommandDisplay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmTutorialStep1"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCommandDisplay.ResumeLayout(False)
        Me.panelCommandDisplay.PerformLayout()
        CType(Me.btnChangeTriggerKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxChangeKeyCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageLargeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents panelCommandDisplay As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents imageLargeIcon As System.Windows.Forms.PictureBox
    Friend WithEvents pboxChangeKeyCombo As System.Windows.Forms.PictureBox
    Friend WithEvents labChangeKeyCombo As System.Windows.Forms.Label
    Friend WithEvents btnNext As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnChangeTriggerKey As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton

End Class

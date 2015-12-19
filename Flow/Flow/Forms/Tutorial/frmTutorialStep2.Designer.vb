<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutorialStep2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTutorialStep2))
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.panelCommandDisplay = New System.Windows.Forms.Panel
        Me.pboxSwitchLayout = New System.Windows.Forms.PictureBox
        Me.labMouseover = New System.Windows.Forms.Label
        Me.labMaintext = New System.Windows.Forms.Label
        Me.btnCanIMake = New Telerik.WinControls.UI.RadButton
        Me.pboxChangeKeyCombo = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.imageLargeIcon = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnNext = New Telerik.WinControls.UI.RadButton
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton
        Me.btnClose = New Telerik.WinControls.UI.RadButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCommandDisplay.SuspendLayout()
        CType(Me.pboxSwitchLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCanIMake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxChangeKeyCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageLargeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label4.Size = New System.Drawing.Size(273, 39)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Layouts and actions"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Flow.My.Resources.Resources.Tutor_Layout
        Me.PictureBox1.Location = New System.Drawing.Point(445, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(505, 260)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(491, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 19)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "This is a layout. This is what you will see when activating Flow." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'panelCommandDisplay
        '
        Me.panelCommandDisplay.BackColor = System.Drawing.Color.Transparent
        Me.panelCommandDisplay.BackgroundImage = Global.Flow.My.Resources.Resources.transparentLargeBox
        Me.panelCommandDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelCommandDisplay.Controls.Add(Me.pboxSwitchLayout)
        Me.panelCommandDisplay.Controls.Add(Me.labMouseover)
        Me.panelCommandDisplay.Controls.Add(Me.labMaintext)
        Me.panelCommandDisplay.Controls.Add(Me.btnCanIMake)
        Me.panelCommandDisplay.Controls.Add(Me.pboxChangeKeyCombo)
        Me.panelCommandDisplay.Controls.Add(Me.Label2)
        Me.panelCommandDisplay.Controls.Add(Me.imageLargeIcon)
        Me.panelCommandDisplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.panelCommandDisplay.Location = New System.Drawing.Point(12, 113)
        Me.panelCommandDisplay.Name = "panelCommandDisplay"
        Me.panelCommandDisplay.Size = New System.Drawing.Size(409, 368)
        Me.panelCommandDisplay.TabIndex = 313
        '
        'pboxSwitchLayout
        '
        Me.pboxSwitchLayout.BackColor = System.Drawing.Color.Transparent
        Me.pboxSwitchLayout.Image = Global.Flow.My.Resources.Resources.Tutor_SwitchToLayout
        Me.pboxSwitchLayout.Location = New System.Drawing.Point(7, 174)
        Me.pboxSwitchLayout.Name = "pboxSwitchLayout"
        Me.pboxSwitchLayout.Size = New System.Drawing.Size(394, 66)
        Me.pboxSwitchLayout.TabIndex = 323
        Me.pboxSwitchLayout.TabStop = False
        Me.pboxSwitchLayout.Visible = False
        '
        'labMouseover
        '
        Me.labMouseover.BackColor = System.Drawing.Color.Transparent
        Me.labMouseover.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labMouseover.ForeColor = System.Drawing.Color.White
        Me.labMouseover.Location = New System.Drawing.Point(4, 102)
        Me.labMouseover.Name = "labMouseover"
        Me.labMouseover.Size = New System.Drawing.Size(408, 52)
        Me.labMouseover.TabIndex = 319
        Me.labMouseover.Text = "You just move the mouse over an icon and its" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "action will be displayed in the top" & _
            " of the screen."
        Me.labMouseover.Visible = False
        '
        'labMaintext
        '
        Me.labMaintext.BackColor = System.Drawing.Color.Transparent
        Me.labMaintext.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labMaintext.ForeColor = System.Drawing.Color.White
        Me.labMaintext.Location = New System.Drawing.Point(3, 102)
        Me.labMaintext.Name = "labMaintext"
        Me.labMaintext.Size = New System.Drawing.Size(403, 115)
        Me.labMaintext.TabIndex = 316
        Me.labMaintext.Text = resources.GetString("labMaintext.Text")
        '
        'btnCanIMake
        '
        Me.btnCanIMake.BackColor = System.Drawing.Color.Transparent
        Me.btnCanIMake.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnCanIMake.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnCanIMake.Location = New System.Drawing.Point(8, 272)
        Me.btnCanIMake.Name = "btnCanIMake"
        Me.btnCanIMake.Size = New System.Drawing.Size(390, 60)
        Me.btnCanIMake.TabIndex = 314
        Me.btnCanIMake.Text = "OK, but how do I know what an icon does?"
        Me.btnCanIMake.ThemeName = "ButtonTheme"
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 52)
        Me.Label2.TabIndex = 313
        Me.Label2.Text = "A layout is an on-screen keyboard with icons representing actions. "
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(726, 486)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 316
        Me.Label5.Text = "2 of 4"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnNext.Location = New System.Drawing.Point(886, 469)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(102, 35)
        Me.btnNext.TabIndex = 315
        Me.btnNext.Text = "&Next"
        Me.btnNext.ThemeName = "ButtonTheme"
        '
        'RadButton1
        '
        Me.RadButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.RadButton1.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.RadButton1.Location = New System.Drawing.Point(778, 469)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(102, 35)
        Me.RadButton1.TabIndex = 317
        Me.RadButton1.Text = "&Previous"
        Me.RadButton1.ThemeName = "ButtonTheme"
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
        'frmTutorialStep2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.panelCommandDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmTutorialStep2"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCommandDisplay.ResumeLayout(False)
        CType(Me.pboxSwitchLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCanIMake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxChangeKeyCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageLargeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelCommandDisplay As System.Windows.Forms.Panel
    Friend WithEvents btnCanIMake As Telerik.WinControls.UI.RadButton
    Friend WithEvents pboxChangeKeyCombo As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents imageLargeIcon As System.Windows.Forms.PictureBox
    Friend WithEvents labMaintext As System.Windows.Forms.Label
    Friend WithEvents labMouseover As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNext As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents pboxSwitchLayout As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton

End Class

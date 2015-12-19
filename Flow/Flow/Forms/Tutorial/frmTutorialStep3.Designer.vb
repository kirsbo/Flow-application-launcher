<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutorialStep3
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.panelCommandDisplay = New System.Windows.Forms.Panel
        Me.labRightClick = New System.Windows.Forms.Label
        Me.pboxRightClick = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCanIMake = New Telerik.WinControls.UI.RadButton
        Me.pboxChangeKeyCombo = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.imageLargeIcon = New System.Windows.Forms.PictureBox
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnNext = New Telerik.WinControls.UI.RadButton
        Me.btnClose = New Telerik.WinControls.UI.RadButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCommandDisplay.SuspendLayout()
        CType(Me.pboxRightClick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCanIMake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxChangeKeyCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageLargeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label4.Location = New System.Drawing.Point(363, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(351, 39)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Configuring actions / keys"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Flow.My.Resources.Resources.Tutor_Configure
        Me.PictureBox1.Location = New System.Drawing.Point(445, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(505, 260)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(447, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "You can assign a file, folder, application, website and layout change to a key"
        '
        'panelCommandDisplay
        '
        Me.panelCommandDisplay.BackColor = System.Drawing.Color.Transparent
        Me.panelCommandDisplay.BackgroundImage = Global.Flow.My.Resources.Resources.transparentLargeBox
        Me.panelCommandDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelCommandDisplay.Controls.Add(Me.labRightClick)
        Me.panelCommandDisplay.Controls.Add(Me.pboxRightClick)
        Me.panelCommandDisplay.Controls.Add(Me.Label3)
        Me.panelCommandDisplay.Controls.Add(Me.btnCanIMake)
        Me.panelCommandDisplay.Controls.Add(Me.pboxChangeKeyCombo)
        Me.panelCommandDisplay.Controls.Add(Me.Label2)
        Me.panelCommandDisplay.Controls.Add(Me.imageLargeIcon)
        Me.panelCommandDisplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.panelCommandDisplay.Location = New System.Drawing.Point(12, 113)
        Me.panelCommandDisplay.Name = "panelCommandDisplay"
        Me.panelCommandDisplay.Size = New System.Drawing.Size(409, 368)
        Me.panelCommandDisplay.TabIndex = 314
        '
        'labRightClick
        '
        Me.labRightClick.BackColor = System.Drawing.Color.Transparent
        Me.labRightClick.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRightClick.ForeColor = System.Drawing.Color.White
        Me.labRightClick.Location = New System.Drawing.Point(11, 271)
        Me.labRightClick.Name = "labRightClick"
        Me.labRightClick.Size = New System.Drawing.Size(400, 53)
        Me.labRightClick.TabIndex = 324
        Me.labRightClick.Text = "For editing, replacing or deleting an action, right-click the key and select from" & _
            " the popup:"
        Me.labRightClick.Visible = False
        '
        'pboxRightClick
        '
        Me.pboxRightClick.BackColor = System.Drawing.Color.Transparent
        Me.pboxRightClick.Image = Global.Flow.My.Resources.Resources.Tutor_Configpopup
        Me.pboxRightClick.Location = New System.Drawing.Point(118, 318)
        Me.pboxRightClick.Name = "pboxRightClick"
        Me.pboxRightClick.Size = New System.Drawing.Size(143, 50)
        Me.pboxRightClick.TabIndex = 322
        Me.pboxRightClick.TabStop = False
        Me.pboxRightClick.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 139)
        Me.Label3.TabIndex = 316
        Me.Label3.Text = "1) Left click on an empty key. Then set the desired action, as shown on the right" & _
            "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2) Drag a file / folder from the desktop to a key." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3) Drag a key to anot" & _
            "her key (switch positions)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnCanIMake
        '
        Me.btnCanIMake.BackColor = System.Drawing.Color.Transparent
        Me.btnCanIMake.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnCanIMake.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnCanIMake.Location = New System.Drawing.Point(15, 272)
        Me.btnCanIMake.Name = "btnCanIMake"
        Me.btnCanIMake.Size = New System.Drawing.Size(372, 60)
        Me.btnCanIMake.TabIndex = 314
        Me.btnCanIMake.Text = "What if I want to replace an existing key?"
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
        Me.Label2.Location = New System.Drawing.Point(69, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 52)
        Me.Label2.TabIndex = 313
        Me.Label2.Text = "You can configure actions for your keys in a few different ways. "
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
        'RadButton1
        '
        Me.RadButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.RadButton1.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.RadButton1.Location = New System.Drawing.Point(778, 469)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(102, 35)
        Me.RadButton1.TabIndex = 320
        Me.RadButton1.Text = "&Previous"
        Me.RadButton1.ThemeName = "ButtonTheme"
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
        Me.Label5.TabIndex = 319
        Me.Label5.Text = "3 of 4"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnNext.Location = New System.Drawing.Point(886, 469)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(102, 35)
        Me.btnNext.TabIndex = 318
        Me.btnNext.Text = "&Next"
        Me.btnNext.ThemeName = "ButtonTheme"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(946, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 38)
        Me.btnClose.TabIndex = 321
        Me.btnClose.Text = "X"
        Me.btnClose.ThemeName = "ButtonTheme"
        '
        'frmTutorialStep3
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
        Me.Name = "frmTutorialStep3"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCommandDisplay.ResumeLayout(False)
        CType(Me.pboxRightClick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCanIMake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxChangeKeyCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageLargeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelCommandDisplay As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCanIMake As Telerik.WinControls.UI.RadButton
    Friend WithEvents pboxChangeKeyCombo As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents imageLargeIcon As System.Windows.Forms.PictureBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNext As Telerik.WinControls.UI.RadButton
    Friend WithEvents pboxRightClick As System.Windows.Forms.PictureBox
    Friend WithEvents labRightClick As System.Windows.Forms.Label
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcomeFinish
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
        Me.components = New System.ComponentModel.Container()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOK = New Telerik.WinControls.UI.RadButton()
        Me.panelCommandDisplay = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imageLargeIcon = New System.Windows.Forms.PictureBox()
        Me.btnNothanks = New Telerik.WinControls.UI.RadButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCommandDisplay.SuspendLayout()
        CType(Me.imageLargeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNothanks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(397, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 39)
        Me.Label4.TabIndex = 316
        Me.Label4.Text = "Welcome to Flow!"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnOK.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnOK.Location = New System.Drawing.Point(301, 316)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(475, 45)
        Me.btnOK.TabIndex = 317
        Me.btnOK.Text = "OK, sounds good!"
        Me.btnOK.ThemeName = "ButtonTheme"
        '
        'panelCommandDisplay
        '
        Me.panelCommandDisplay.BackColor = System.Drawing.Color.Transparent
        Me.panelCommandDisplay.BackgroundImage = Global.Flow.My.Resources.Resources.TransparentBox
        Me.panelCommandDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelCommandDisplay.Controls.Add(Me.Label1)
        Me.panelCommandDisplay.Controls.Add(Me.imageLargeIcon)
        Me.panelCommandDisplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.panelCommandDisplay.Location = New System.Drawing.Point(189, 157)
        Me.panelCommandDisplay.Name = "panelCommandDisplay"
        Me.panelCommandDisplay.Size = New System.Drawing.Size(672, 84)
        Me.panelCommandDisplay.TabIndex = 319
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(599, 52)
        Me.Label1.TabIndex = 317
        Me.Label1.Text = "Before starting, it is HIGHLY recommended to take the 4 step tutorial." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We promis" & _
            "e it won't take more than a few minutes."
        '
        'imageLargeIcon
        '
        Me.imageLargeIcon.BackColor = System.Drawing.Color.Transparent
        Me.imageLargeIcon.Image = Global.Flow.My.Resources.Resources.iconLargeHelp
        Me.imageLargeIcon.Location = New System.Drawing.Point(17, 16)
        Me.imageLargeIcon.Name = "imageLargeIcon"
        Me.imageLargeIcon.Size = New System.Drawing.Size(48, 48)
        Me.imageLargeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageLargeIcon.TabIndex = 316
        Me.imageLargeIcon.TabStop = False
        '
        'btnNothanks
        '
        Me.btnNothanks.BackColor = System.Drawing.Color.Transparent
        Me.btnNothanks.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnNothanks.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnNothanks.Location = New System.Drawing.Point(301, 440)
        Me.btnNothanks.Name = "btnNothanks"
        Me.btnNothanks.Size = New System.Drawing.Size(475, 45)
        Me.btnNothanks.TabIndex = 320
        Me.btnNothanks.Text = "No thanks, I already know my way around the app."
        Me.btnNothanks.ThemeName = "ButtonTheme"
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'frmWelcomeFinish
        '
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.btnNothanks)
        Me.Controls.Add(Me.panelCommandDisplay)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmWelcomeFinish"
        Me.TopMost = True
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCommandDisplay.ResumeLayout(False)
        Me.panelCommandDisplay.PerformLayout()
        CType(Me.imageLargeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNothanks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOK As Telerik.WinControls.UI.RadButton
    Friend WithEvents panelCommandDisplay As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents imageLargeIcon As System.Windows.Forms.PictureBox
    Friend WithEvents btnNothanks As Telerik.WinControls.UI.RadButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class

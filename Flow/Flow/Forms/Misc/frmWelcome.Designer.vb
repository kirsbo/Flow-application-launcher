<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.btnNext = New Telerik.WinControls.UI.RadButton()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.panelCommandDisplay = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.welcomeText = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCommandDisplay.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnNext.Location = New System.Drawing.Point(886, 467)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(102, 35)
        Me.btnNext.TabIndex = 312
        Me.btnNext.Text = "&Next"
        Me.btnNext.ThemeName = "ButtonTheme"
        '
        'RadThemeManager1
        '
        ThemeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource1.ThemeLocation = "Flow.ButtonTheme.xml"
        ThemeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource2.ThemeLocation = "Flow.LabelTheme.xml"
        Me.RadThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {ThemeSource1, ThemeSource2})
        '
        'panelCommandDisplay
        '
        Me.panelCommandDisplay.BackColor = System.Drawing.Color.Transparent
        Me.panelCommandDisplay.BackgroundImage = Global.Flow.My.Resources.Resources.transparentLargeBox
        Me.panelCommandDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelCommandDisplay.Controls.Add(Me.PictureBox1)
        Me.panelCommandDisplay.Controls.Add(Me.welcomeText)
        Me.panelCommandDisplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.panelCommandDisplay.Location = New System.Drawing.Point(123, 101)
        Me.panelCommandDisplay.Name = "panelCommandDisplay"
        Me.panelCommandDisplay.Size = New System.Drawing.Size(794, 344)
        Me.panelCommandDisplay.TabIndex = 314
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Flow.My.Resources.Resources.Logo500x500
        Me.PictureBox1.Location = New System.Drawing.Point(562, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 317
        Me.PictureBox1.TabStop = False
        '
        'welcomeText
        '
        Me.welcomeText.BackColor = System.Drawing.Color.Transparent
        Me.welcomeText.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeText.ForeColor = System.Drawing.Color.White
        Me.welcomeText.Location = New System.Drawing.Point(23, 19)
        Me.welcomeText.Name = "welcomeText"
        Me.welcomeText.Size = New System.Drawing.Size(745, 329)
        Me.welcomeText.TabIndex = 316
        Me.welcomeText.Text = resources.GetString("welcomeText.Text")
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
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Welcome to Flow!"
        '
        'frmWelcome
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.panelCommandDisplay)
        Me.Controls.Add(Me.btnNext)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWelcome"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        Me.TopMost = True
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCommandDisplay.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents panelCommandDisplay As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents welcomeText As System.Windows.Forms.Label
End Class

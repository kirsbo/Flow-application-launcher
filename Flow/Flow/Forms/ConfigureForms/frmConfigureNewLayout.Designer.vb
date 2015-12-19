<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigureNewLayout
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
        Me.txtLayoutName = New System.Windows.Forms.TextBox()
        Me.labWhatShouldHappen = New System.Windows.Forms.Label()
        Me.labKeyIndicator = New Telerik.WinControls.UI.RadLabel()
        Me.btnBack = New Telerik.WinControls.UI.RadButton()
        Me.btnNext = New Telerik.WinControls.UI.RadButton()
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLayoutName
        '
        Me.txtLayoutName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLayoutName.Location = New System.Drawing.Point(333, 244)
        Me.txtLayoutName.MaxLength = 50
        Me.txtLayoutName.Name = "txtLayoutName"
        Me.txtLayoutName.Size = New System.Drawing.Size(340, 35)
        Me.txtLayoutName.TabIndex = 40
        '
        'labWhatShouldHappen
        '
        Me.labWhatShouldHappen.AutoSize = True
        Me.labWhatShouldHappen.BackColor = System.Drawing.Color.Transparent
        Me.labWhatShouldHappen.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labWhatShouldHappen.ForeColor = System.Drawing.Color.White
        Me.labWhatShouldHappen.Location = New System.Drawing.Point(354, 120)
        Me.labWhatShouldHappen.Name = "labWhatShouldHappen"
        Me.labWhatShouldHappen.Size = New System.Drawing.Size(288, 36)
        Me.labWhatShouldHappen.TabIndex = 39
        Me.labWhatShouldHappen.Text = "Enter new layout name"
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
        Me.labKeyIndicator.TabIndex = 51
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
        Me.btnBack.TabIndex = 50
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
        Me.btnNext.TabIndex = 49
        Me.btnNext.Text = "&Next"
        Me.btnNext.ThemeName = "ButtonTheme"
        '
        'frmConfigureNewLayout
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.labKeyIndicator)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtLayoutName)
        Me.Controls.Add(Me.labWhatShouldHappen)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfigureNewLayout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        Me.TopMost = True
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLayoutName As System.Windows.Forms.TextBox
    Friend WithEvents labWhatShouldHappen As System.Windows.Forms.Label
    Friend WithEvents labKeyIndicator As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnBack As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnNext As Telerik.WinControls.UI.RadButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInput
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
        Me.panelCommandDisplay = New System.Windows.Forms.Panel()
        Me.labText = New System.Windows.Forms.Label()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnOK = New Telerik.WinControls.UI.RadButton()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.pboxIcon = New System.Windows.Forms.PictureBox()
        Me.radThemeConfigureKey = New Telerik.WinControls.RadThemeManager()
        Me.panelCommandDisplay.SuspendLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelCommandDisplay
        '
        Me.panelCommandDisplay.BackColor = System.Drawing.Color.Transparent
        Me.panelCommandDisplay.BackgroundImage = Global.Flow.My.Resources.Resources.transparentLargeBox
        Me.panelCommandDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelCommandDisplay.Controls.Add(Me.labText)
        Me.panelCommandDisplay.Controls.Add(Me.btnCancel)
        Me.panelCommandDisplay.Controls.Add(Me.btnOK)
        Me.panelCommandDisplay.Controls.Add(Me.txtInput)
        Me.panelCommandDisplay.Controls.Add(Me.pboxIcon)
        Me.panelCommandDisplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.panelCommandDisplay.Location = New System.Drawing.Point(109, 27)
        Me.panelCommandDisplay.Name = "panelCommandDisplay"
        Me.panelCommandDisplay.Size = New System.Drawing.Size(256, 212)
        Me.panelCommandDisplay.TabIndex = 315
        '
        'labText
        '
        Me.labText.BackColor = System.Drawing.Color.Transparent
        Me.labText.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labText.ForeColor = System.Drawing.Color.White
        Me.labText.Location = New System.Drawing.Point(61, 16)
        Me.labText.Name = "labText"
        Me.labText.Size = New System.Drawing.Size(192, 50)
        Me.labText.TabIndex = 316
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnCancel.Location = New System.Drawing.Point(135, 174)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 35)
        Me.btnCancel.TabIndex = 322
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.ThemeName = "ButtonTheme"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnOK.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnOK.Location = New System.Drawing.Point(18, 174)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(102, 35)
        Me.btnOK.TabIndex = 321
        Me.btnOK.Text = "&OK"
        Me.btnOK.ThemeName = "ButtonTheme"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(8, 98)
        Me.txtInput.MaxLength = 50
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(235, 35)
        Me.txtInput.TabIndex = 1
        '
        'pboxIcon
        '
        Me.pboxIcon.Image = Global.Flow.My.Resources.Resources.iconLargeExclamation
        Me.pboxIcon.Location = New System.Drawing.Point(7, 13)
        Me.pboxIcon.Name = "pboxIcon"
        Me.pboxIcon.Size = New System.Drawing.Size(48, 48)
        Me.pboxIcon.TabIndex = 317
        Me.pboxIcon.TabStop = False
        '
        'radThemeConfigureKey
        '
        ThemeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource1.ThemeLocation = "Flow.LabelTheme.xml"
        ThemeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource2.ThemeLocation = "Flow.ButtonTheme.xml"
        Me.radThemeConfigureKey.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {ThemeSource1, ThemeSource2})
        '
        'frmInput
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgInput
        Me.ClientSize = New System.Drawing.Size(500, 257)
        Me.Controls.Add(Me.panelCommandDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInput"
        Me.TopMost = True
        Me.panelCommandDisplay.ResumeLayout(False)
        Me.panelCommandDisplay.PerformLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelCommandDisplay As System.Windows.Forms.Panel
    Friend WithEvents pboxIcon As System.Windows.Forms.PictureBox
    Friend WithEvents labText As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnOK As Telerik.WinControls.UI.RadButton
    Friend WithEvents radThemeConfigureKey As Telerik.WinControls.RadThemeManager
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim ThemeSource1 As Telerik.WinControls.ThemeSource = New Telerik.WinControls.ThemeSource()
        Dim ThemeSource2 As Telerik.WinControls.ThemeSource = New Telerik.WinControls.ThemeSource()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDone = New Telerik.WinControls.UI.RadButton()
        Me.btnOnlineHelp = New Telerik.WinControls.UI.RadButton()
        Me.btnTutorial = New Telerik.WinControls.UI.RadButton()
        Me.btnForums = New Telerik.WinControls.UI.RadButton()
        Me.btnAbout = New Telerik.WinControls.UI.RadButton()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOnlineHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTutorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnForums, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(405, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 39)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Help resources"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnDone.Location = New System.Drawing.Point(886, 467)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(102, 35)
        Me.btnDone.TabIndex = 321
        Me.btnDone.Text = "&Done"
        Me.btnDone.ThemeName = "ButtonTheme"
        '
        'btnOnlineHelp
        '
        Me.btnOnlineHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnOnlineHelp.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnOnlineHelp.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnOnlineHelp.Location = New System.Drawing.Point(398, 159)
        Me.btnOnlineHelp.Name = "btnOnlineHelp"
        Me.btnOnlineHelp.Size = New System.Drawing.Size(222, 35)
        Me.btnOnlineHelp.TabIndex = 322
        Me.btnOnlineHelp.Text = "&Online help"
        Me.btnOnlineHelp.ThemeName = "ButtonTheme"
        '
        'btnTutorial
        '
        Me.btnTutorial.BackColor = System.Drawing.Color.Transparent
        Me.btnTutorial.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnTutorial.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnTutorial.Location = New System.Drawing.Point(398, 294)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(222, 35)
        Me.btnTutorial.TabIndex = 323
        Me.btnTutorial.Text = "View &tutorial"
        Me.btnTutorial.ThemeName = "ButtonTheme"
        '
        'btnForums
        '
        Me.btnForums.BackColor = System.Drawing.Color.Transparent
        Me.btnForums.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnForums.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnForums.Location = New System.Drawing.Point(398, 227)
        Me.btnForums.Name = "btnForums"
        Me.btnForums.Size = New System.Drawing.Size(222, 35)
        Me.btnForums.TabIndex = 324
        Me.btnForums.Text = "View &forums"
        Me.btnForums.ThemeName = "ButtonTheme"
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnAbout.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnAbout.Location = New System.Drawing.Point(398, 362)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(222, 35)
        Me.btnAbout.TabIndex = 325
        Me.btnAbout.Text = "&About Flow"
        Me.btnAbout.ThemeName = "ButtonTheme"
        '
        'RadThemeManager1
        '
        ThemeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource1.ThemeLocation = "Flow.ButtonTheme.xml"
        ThemeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource2.ThemeLocation = "Flow.LabelTheme.xml"
        Me.RadThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {ThemeSource1, ThemeSource2})
        '
        'frmHelp
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnForums)
        Me.Controls.Add(Me.btnTutorial)
        Me.Controls.Add(Me.btnOnlineHelp)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmHelp"
        Me.TopMost = True
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOnlineHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTutorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnForums, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDone As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnOnlineHelp As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnTutorial As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnForums As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAbout As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager

End Class

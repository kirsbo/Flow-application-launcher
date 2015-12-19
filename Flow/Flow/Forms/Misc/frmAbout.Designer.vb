<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.btnDone = New Telerik.WinControls.UI.RadButton()
        Me.labCulture = New System.Windows.Forms.Label()
        Me.labVersion = New System.Windows.Forms.Label()
        Me.labEdition = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(415, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 39)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "About Flow"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnDone.Location = New System.Drawing.Point(886, 467)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(102, 35)
        Me.btnDone.TabIndex = 319
        Me.btnDone.Text = "&Done"
        Me.btnDone.ThemeName = "ButtonTheme"
        '
        'labCulture
        '
        Me.labCulture.BackColor = System.Drawing.Color.Transparent
        Me.labCulture.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCulture.ForeColor = System.Drawing.Color.White
        Me.labCulture.Location = New System.Drawing.Point(315, 304)
        Me.labCulture.Name = "labCulture"
        Me.labCulture.Size = New System.Drawing.Size(325, 32)
        Me.labCulture.TabIndex = 320
        Me.labCulture.Text = "Culture: "
        '
        'labVersion
        '
        Me.labVersion.BackColor = System.Drawing.Color.Transparent
        Me.labVersion.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVersion.ForeColor = System.Drawing.Color.White
        Me.labVersion.Location = New System.Drawing.Point(315, 246)
        Me.labVersion.Name = "labVersion"
        Me.labVersion.Size = New System.Drawing.Size(325, 32)
        Me.labVersion.TabIndex = 321
        Me.labVersion.Text = "Version number: 1.0"
        '
        'labEdition
        '
        Me.labEdition.BackColor = System.Drawing.Color.Transparent
        Me.labEdition.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEdition.ForeColor = System.Drawing.Color.White
        Me.labEdition.Location = New System.Drawing.Point(315, 192)
        Me.labEdition.Name = "labEdition"
        Me.labEdition.Size = New System.Drawing.Size(325, 32)
        Me.labEdition.TabIndex = 322
        Me.labEdition.Text = "Edition: Flow Light"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(290, 481)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(433, 21)
        Me.Label3.TabIndex = 323
        Me.Label3.Text = "Copyright Vitesse Digital Limited 2009-2010  - All rights reserved"
        '
        'frmAbout
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labEdition)
        Me.Controls.Add(Me.labVersion)
        Me.Controls.Add(Me.labCulture)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmAbout"
        Me.TopMost = True
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDone As Telerik.WinControls.UI.RadButton
    Friend WithEvents labCulture As System.Windows.Forms.Label
    Friend WithEvents labVersion As System.Windows.Forms.Label
    Friend WithEvents labEdition As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class

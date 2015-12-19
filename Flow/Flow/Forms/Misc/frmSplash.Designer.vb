<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Me.labelCopyright = New System.Windows.Forms.Label()
        Me.timerFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.timerLoadApplication = New System.Windows.Forms.Timer(Me.components)
        Me.timerFadeOut = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'labelCopyright
        '
        Me.labelCopyright.AutoSize = True
        Me.labelCopyright.BackColor = System.Drawing.Color.Transparent
        Me.labelCopyright.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCopyright.ForeColor = System.Drawing.Color.White
        Me.labelCopyright.Location = New System.Drawing.Point(18, 239)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(437, 15)
        Me.labelCopyright.TabIndex = 0
        Me.labelCopyright.Text = "Flow 0.8 (Beta) - Vitesse Digital Ltd. All rights reserved. X days left in your t" & _
            "rial."
        '
        'timerFadeIn
        '
        Me.timerFadeIn.Interval = 25
        '
        'timerLoadApplication
        '
        Me.timerLoadApplication.Interval = 1000
        '
        'timerFadeOut
        '
        Me.timerFadeOut.Interval = 25
        '
        'frmSplash
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.Splash
        Me.ClientSize = New System.Drawing.Size(500, 257)
        Me.Controls.Add(Me.labelCopyright)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.Opacity = 0.0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelCopyright As System.Windows.Forms.Label
    Friend WithEvents timerFadeIn As System.Windows.Forms.Timer
    Friend WithEvents timerLoadApplication As System.Windows.Forms.Timer
    Friend WithEvents timerFadeOut As System.Windows.Forms.Timer
End Class

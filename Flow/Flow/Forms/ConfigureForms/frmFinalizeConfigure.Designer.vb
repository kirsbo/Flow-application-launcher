<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinalizeConfigure
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
        Me.btnChooseFromGallery = New Telerik.WinControls.UI.RadButton()
        Me.btnDone = New Telerik.WinControls.UI.RadButton()
        Me.btnBack = New Telerik.WinControls.UI.RadButton()
        Me.labWhatShouldHappen = New Telerik.WinControls.UI.RadLabel()
        Me.labOr = New Telerik.WinControls.UI.RadLabel()
        Me.labKeyIndicator = New Telerik.WinControls.UI.RadLabel()
        Me.btnImg = New Telerik.WinControls.UI.RadButton()
        CType(Me.btnChooseFromGallery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labWhatShouldHappen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labOr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChooseFromGallery
        '
        Me.btnChooseFromGallery.BackColor = System.Drawing.Color.Transparent
        Me.btnChooseFromGallery.Location = New System.Drawing.Point(334, 428)
        Me.btnChooseFromGallery.Name = "btnChooseFromGallery"
        Me.btnChooseFromGallery.Size = New System.Drawing.Size(341, 36)
        Me.btnChooseFromGallery.TabIndex = 22
        Me.btnChooseFromGallery.Text = "&Choose from icon gallery"
        Me.btnChooseFromGallery.ThemeName = "ButtonTheme"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnDone.Location = New System.Drawing.Point(886, 428)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(102, 35)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.ThemeName = "ButtonTheme"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnBack.Location = New System.Drawing.Point(886, 469)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(102, 35)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "&Back"
        Me.btnBack.ThemeName = "ButtonTheme"
        '
        'labWhatShouldHappen
        '
        Me.labWhatShouldHappen.BackColor = System.Drawing.Color.Transparent
        Me.labWhatShouldHappen.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.labWhatShouldHappen.ForeColor = System.Drawing.Color.White
        Me.labWhatShouldHappen.Location = New System.Drawing.Point(412, 125)
        Me.labWhatShouldHappen.Name = "labWhatShouldHappen"
        '
        '
        '
        Me.labWhatShouldHappen.RootElement.ForeColor = System.Drawing.Color.White
        Me.labWhatShouldHappen.Size = New System.Drawing.Size(178, 40)
        Me.labWhatShouldHappen.TabIndex = 25
        Me.labWhatShouldHappen.Text = "Use this icon?"
        Me.labWhatShouldHappen.TextWrap = True
        '
        'labOr
        '
        Me.labOr.BackColor = System.Drawing.Color.Transparent
        Me.labOr.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.labOr.ForeColor = System.Drawing.Color.White
        Me.labOr.Location = New System.Drawing.Point(478, 339)
        Me.labOr.Name = "labOr"
        '
        '
        '
        Me.labOr.RootElement.ForeColor = System.Drawing.Color.White
        Me.labOr.Size = New System.Drawing.Size(40, 40)
        Me.labOr.TabIndex = 26
        Me.labOr.Text = "Or"
        Me.labOr.TextWrap = True
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
        Me.labKeyIndicator.TabIndex = 55
        Me.labKeyIndicator.Text = "W"
        Me.labKeyIndicator.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.labKeyIndicator.TextWrap = True
        Me.labKeyIndicator.ThemeName = "LabelTheme"
        '
        'btnImg
        '
        Me.btnImg.BackColor = System.Drawing.Color.Transparent
        Me.btnImg.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnImg.ImageScalingSize = New System.Drawing.Size(1, 1)
        Me.btnImg.Location = New System.Drawing.Point(465, 224)
        Me.btnImg.Name = "btnImg"
        Me.btnImg.Size = New System.Drawing.Size(64, 64)
        Me.btnImg.TabIndex = 56
        Me.btnImg.ThemeName = "ButtonTheme"
        CType(Me.btnImg.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btnImg.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = True
        CType(Me.btnImg.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = True
        CType(Me.btnImg.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Stretch
        CType(Me.btnImg.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ForcedScalingSize = New System.Drawing.Size(48, 48)
        CType(Me.btnImg.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(48, 48)
        CType(Me.btnImg.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.[Auto]
        CType(Me.btnImg.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(48, 48)
        '
        'frmFinalizeConfigure
        '
        Me.AcceptButton = Me.btnDone
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.btnImg)
        Me.Controls.Add(Me.labKeyIndicator)
        Me.Controls.Add(Me.labOr)
        Me.Controls.Add(Me.labWhatShouldHappen)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnChooseFromGallery)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFinalizeConfigure"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        Me.TopMost = True
        CType(Me.btnChooseFromGallery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labWhatShouldHappen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labOr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChooseFromGallery As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDone As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnBack As Telerik.WinControls.UI.RadButton
    Friend WithEvents labWhatShouldHappen As Telerik.WinControls.UI.RadLabel
    Friend WithEvents labOr As Telerik.WinControls.UI.RadLabel
    Friend WithEvents labKeyIndicator As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnImg As Telerik.WinControls.UI.RadButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditKey
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
        Me.labKeyIndicator = New Telerik.WinControls.UI.RadLabel()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnDone = New Telerik.WinControls.UI.RadButton()
        Me.labWhatShouldHappen = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.btnImg = New Telerik.WinControls.UI.RadButton()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labWhatShouldHappen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.labKeyIndicator.Size = New System.Drawing.Size(84, 89)
        Me.labKeyIndicator.TabIndex = 49
        Me.labKeyIndicator.Text = "W"
        Me.labKeyIndicator.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.labKeyIndicator.TextWrap = True
        Me.labKeyIndicator.ThemeName = "LabelTheme"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = Global.Flow.My.Resources.Resources.iconSmallClose
        Me.btnCancel.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnCancel.Image = Global.Flow.My.Resources.Resources.iconSmallClose
        Me.btnCancel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCancel.ImageScalingSize = New System.Drawing.Size(1, 1)
        Me.btnCancel.Location = New System.Drawing.Point(886, 469)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 35)
        Me.btnCancel.TabIndex = 51
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.ThemeName = "ButtonTheme"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 20.25!)
        Me.btnDone.Location = New System.Drawing.Point(886, 428)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(102, 35)
        Me.btnDone.TabIndex = 50
        Me.btnDone.Text = "Done"
        Me.btnDone.ThemeName = "ButtonTheme"
        CType(Me.btnDone.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        CType(Me.btnDone.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Done"
        CType(Me.btnDone.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.btnDone.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(5.0!, 0.0!)
        '
        'labWhatShouldHappen
        '
        Me.labWhatShouldHappen.BackColor = System.Drawing.Color.Transparent
        Me.labWhatShouldHappen.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.labWhatShouldHappen.ForeColor = System.Drawing.Color.White
        Me.labWhatShouldHappen.Location = New System.Drawing.Point(325, 352)
        Me.labWhatShouldHappen.Name = "labWhatShouldHappen"
        '
        '
        '
        Me.labWhatShouldHappen.RootElement.ForeColor = System.Drawing.Color.White
        Me.labWhatShouldHappen.Size = New System.Drawing.Size(62, 40)
        Me.labWhatShouldHappen.TabIndex = 53
        Me.labWhatShouldHappen.Text = "Icon"
        Me.labWhatShouldHappen.TextWrap = True
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.RadLabel1.ForeColor = System.Drawing.Color.White
        Me.RadLabel1.Location = New System.Drawing.Point(325, 179)
        Me.RadLabel1.Name = "RadLabel1"
        '
        '
        '
        Me.RadLabel1.RootElement.ForeColor = System.Drawing.Color.White
        Me.RadLabel1.Size = New System.Drawing.Size(82, 40)
        Me.RadLabel1.TabIndex = 54
        Me.RadLabel1.Text = "Name"
        Me.RadLabel1.TextWrap = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(456, 184)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(340, 35)
        Me.txtName.TabIndex = 1
        '
        'RadThemeManager1
        '
        ThemeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource1.ThemeLocation = "Flow.ButtonTheme.xml"
        ThemeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
        ThemeSource2.ThemeLocation = "Flow.LabelTheme.xml"
        Me.RadThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {ThemeSource1, ThemeSource2})
        '
        'btnImg
        '
        Me.btnImg.BackColor = System.Drawing.Color.Transparent
        Me.btnImg.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnImg.ImageScalingSize = New System.Drawing.Size(1, 1)
        Me.btnImg.Location = New System.Drawing.Point(456, 339)
        Me.btnImg.Name = "btnImg"
        Me.btnImg.Size = New System.Drawing.Size(64, 64)
        Me.btnImg.TabIndex = 57
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
        'txtAction
        '
        Me.txtAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAction.Location = New System.Drawing.Point(456, 262)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(340, 35)
        Me.txtAction.TabIndex = 58
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.RadLabel2.ForeColor = System.Drawing.Color.White
        Me.RadLabel2.Location = New System.Drawing.Point(325, 257)
        Me.RadLabel2.Name = "RadLabel2"
        '
        '
        '
        Me.RadLabel2.RootElement.ForeColor = System.Drawing.Color.White
        Me.RadLabel2.Size = New System.Drawing.Size(88, 40)
        Me.RadLabel2.TabIndex = 59
        Me.RadLabel2.Text = "Action"
        Me.RadLabel2.TextWrap = True
        '
        'frmEditKey
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Flow.My.Resources.Resources.BgImageLarge1024x768
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1000, 514)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.btnImg)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.labWhatShouldHappen)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.labKeyIndicator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditKey"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flow"
        CType(Me.labKeyIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labWhatShouldHappen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labKeyIndicator As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDone As Telerik.WinControls.UI.RadButton
    Friend WithEvents labWhatShouldHappen As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents btnImg As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtAction As System.Windows.Forms.TextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
End Class

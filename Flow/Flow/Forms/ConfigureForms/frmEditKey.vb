'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmEditKey

    Private Sub frmEditKey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

        Dim command As New clsCommand(clsKeyConfigurator.FlowKeyCodeToConfigure)
        labKeyIndicator.Text = clsRender.getConfigLabKeyText(command.physicalKey.keyText)
        txtAction.Text = command.commandXMLNode.FirstChild.InnerText
        txtName.Text = command.commandName
        sCommandImagePath = command.commandIconRelativePath
        btnImg.Image = Image.FromFile(command.commandIconFullPath)
        Me.Location = frmUI.Location
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmUI.Show()
        Me.Close()
    End Sub

    Private Sub btnImg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImg.Click
        If frmIconGallery.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sCommandImagePath = clsKeyConfigurator.NewCommandIconPath
            btnImg.Image = Image.FromFile(clsImages.FullIconGalleryPath & sCommandImagePath)
        End If
    End Sub

    Private Shared sCommandImagePath As String

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        clsKeyConfigurator.editCommandNameAndImage(clsKeyConfigurator.FlowKeyCodeToConfigure, txtName.Text, sCommandImagePath)

        If txtAction.Text.Contains("&") Or txtAction.Text.Contains("<") Or txtAction.Text.Contains(">") Then
            MessageBox.Show(" Action names can not contain special characters")
        Else
            clsKeyConfigurator.editCommandLaunchString(clsKeyConfigurator.FlowKeyCodeToConfigure, txtAction.Text)
            frmUI.Show()
            Me.Close()
        End If
    End Sub

#Region "Common for Configure forms"

    Private Sub frmEditKey_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, btnDone.KeyPress, txtName.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                btnDone_Click(sender, e)
            Case Keys.Escape
                btnCancel_Click(sender, e)
        End Select
    End Sub
#End Region

#Region "Hiding form from ALT+Tab"
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            ' turn on WS_EX_TOOLWINDOW style bit
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
#End Region
End Class
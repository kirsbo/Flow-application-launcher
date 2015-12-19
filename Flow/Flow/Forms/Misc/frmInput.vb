'GT. 21.02.2010 -- revision of class code is completed.

Friend Class frmInput
    Protected sReturnText As String = ""

    Protected bitmapIcon As Bitmap

    Public Overloads Function ShowDialog(ByVal PromptText As String, ByVal DefaultText As String, ByRef EnteredText As String) As System.Windows.Forms.DialogResult
        Me.labText.Text = PromptText
        Me.txtInput.Text = DefaultText
        Me.ShowDialog()
        EnteredText = sReturnText
        Return Me.DialogResult
    End Function

    Private Sub frmInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        sReturnText = Me.txtInput.Text

        If sReturnText.Contains("*") Or sReturnText.Contains("?") Or sReturnText.Contains(">") Or sReturnText.Contains("<") Then
            MessageBox.Show("Layout names can not contain special characters")
            sReturnText = ""
        End If
        Me.Close()
    End Sub

    Private Sub frmInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, btnOK.KeyPress, btnCancel.KeyPress, txtInput.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                btnOK_Click(sender, e)
            Case Keys.Escape
                btnCancel_Click(sender, e)
        End Select
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        sReturnText = ""
        Me.Close()
    End Sub

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
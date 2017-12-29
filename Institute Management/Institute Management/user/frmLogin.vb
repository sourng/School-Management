Public Class frmLogin



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Me.txtUserName.Text = "admin" And Me.txtPassword.Text = "admin" Then

            frmMain.Show()
            Me.Hide()

        End If
        'Me.Close()
    End Sub
End Class

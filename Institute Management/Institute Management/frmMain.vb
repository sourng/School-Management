Public Class frmMain

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click

    End Sub

    Private Sub btnUsers_MouseHover(sender As Object, e As EventArgs) Handles btnUsers.MouseHover
        Me.btnUsers.BackColor = Color.Azure

    End Sub

    Private Sub btnUsers_MouseLeave(sender As Object, e As EventArgs) Handles btnUsers.MouseLeave
        Me.btnUsers.BackColor = Color.Coral


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
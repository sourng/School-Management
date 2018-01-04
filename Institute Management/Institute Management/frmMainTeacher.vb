Public Class frmMainTeacher

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmLogin.Visible = True

    End Sub
End Class
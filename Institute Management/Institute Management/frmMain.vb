﻿Public Class frmMain

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click

    End Sub

    Private Sub btnUsers_MouseHover(sender As Object, e As EventArgs) Handles btnUsers.MouseHover
        Me.btnUsers.BackColor = Color.Azure

    End Sub

    Private Sub btnUsers_MouseLeave(sender As Object, e As EventArgs) Handles btnUsers.MouseLeave
        Me.btnUsers.BackColor = Color.Coral


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.PictureBox1.Image = Image.FromFile(getImage("image_users", "sourng.jpg"))
        Me.lbl_user.Text = "អ្នក​កំពុង​ប្រើ :​​ " & UserName & vbNewLine & userGroup_name_kh




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmLogin.Show()

    End Sub
End Class
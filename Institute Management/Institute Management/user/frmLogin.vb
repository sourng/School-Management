Public Class frmLogin



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If IsLogin(Trim(Me.txtUserName.Text), Trim(Me.txtPassword.Text)) = True Then
            'Dim frm As New userMain_form
            If userMain_form = "frmMain" Then
                frmMain.Show()
            ElseIf userMain_form = "frmMainOffice" Then
                frmMainOffice.Show()
            ElseIf userMain_form = "frmMainDept" Then
                frmMainDept.Show()
            ElseIf userMain_form = "frmMainTeacher" Then
                frmMainTeacher.Show()
            Else
                frmMain.Show()
            End If

            Me.Hide()
        Else
            MsgBox("Please check your admin user")
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsConnectionAvailable() = True Then
            ConnectDB()
            Me.btnLogin.Enabled = True
            Me.txtPassword.Enabled = True
            Me.txtUserName.Enabled = True


        Else
            MsgBox("Please check your Internet connection")
            Me.btnLogin.Enabled = False
            Me.txtPassword.Enabled = False
            Me.txtUserName.Enabled = False

        End If


    End Sub
End Class

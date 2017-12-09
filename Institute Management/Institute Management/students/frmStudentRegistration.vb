Public Class frmStudentRegistration
    Private KhmerInput As InputLanguage
    Private EnglishInput As InputLanguage
    Private Sub frmStudentRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage
    End Sub
    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KhmerInput = InputLanguage.CurrentInputLanguage
        EnglishInput = InputLanguage.CurrentInputLanguage
        'Iterate to find the available Arabic and English Keyboards
        Dim count As Integer
        count = InputLanguage.InstalledInputLanguages.Count
        For i As Integer = 1 To (count - 1)
            If InputLanguage.InstalledInputLanguages(i).LayoutName.Contains("Khmer") = True Then
                'Found an Khmer Keyboard
                KhmerInput = InputLanguage.InstalledInputLanguages(i)
            Else
                If InputLanguage.InstalledInputLanguages(i).LayoutName.Contains("English") = True Then
                    'Found an English Keyboard
                    EnglishInput = InputLanguage.InstalledInputLanguages(i)
                End If
            End If
        Next i
    End Sub
    Private Sub btnBrowIm_Click(sender As Object, e As EventArgs) Handles btnBrowIm.Click
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim imagePath1 = OpenFileDialog.FileName
            PictureBox.Image = Image.FromFile(imagePath1)
        End If
    End Sub
    Private Sub btnCapter_Click(sender As Object, e As EventArgs) Handles btnCapter.Click
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub
    Private Sub txtFNameEN_GotFocus(sender As Object, e As EventArgs) Handles txtFNameEN.GotFocus
        InputLanguage.CurrentInputLanguage = EnglishInput
    End Sub
    Private Sub txtFNameKH_GotFocus(sender As Object, e As EventArgs) Handles txtFNameKH.GotFocus
        InputLanguage.CurrentInputLanguage = KhmerInput
    End Sub

    Private Sub txtLNameEN_TextChanged(sender As Object, e As EventArgs) Handles txtLNameEN.TextChanged
        InputLanguage.CurrentInputLanguage = EnglishInput
    End Sub

    Private Sub txtLNameKH_TextChanged(sender As Object, e As EventArgs) Handles txtLNameKH.TextChanged
        InputLanguage.CurrentInputLanguage = KhmerInput
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class frmStudentRegistration
    Private KhmerInput As InputLanguage
    Private EnglishInput As InputLanguage

    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader

    Dim save_edit As Boolean = False
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte

    ' Address Detail
    Dim province_id As Integer = 0
    Dim district_id As Integer = 0
    Dim commune_id As Integer = 0
    Dim MaritalStatus As Integer = 0



    Private Sub frmStudentRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage
    End Sub
    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()

        Me.Text = "Student Register"

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


        Call AddData2Combo("SELECT province_kh FROM tbl_province", Me.cboProvice)
        Call AddData2Combo("SELECT tm_name_kh FROM tbl_transport_method", Me.cboTransportMethod)

        Call AddData2Combo("SELECT ms_name_kh FROM tbl_marital_status", Me.cboMaritalStatus)

    End Sub


    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()
            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"
            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                Pic1.ImageLocation = imgpath
            End If
            OFD = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub cboProvice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvice.SelectedIndexChanged
        Me.cboDistrict.Items.Clear()
        'If cboProvice.Text <> "" Then
        province_id = GetID_BySQL("SELECT province_id FROM tbl_province WHERE province_kh='" & cboProvice.Text & "'")
        Call AddData2Combo("SELECT District_kh FROM tbl_district WHERE province_id=" & province_id, cboDistrict)

        'End If

    End Sub

    Private Sub cboDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistrict.SelectedIndexChanged
        Me.cboCommune.Items.Clear()

        'If cboDistrict.Text <> "" Then
        district_id = GetID_BySQL("SELECT district_id FROM tbl_district WHERE District_kh='" & cboDistrict.Text & "'")
        Call AddData2Combo("SELECT commune_kh FROM tbl_commune WHERE district_id=" & district_id, cboCommune)
        commune_id = GetID_BySQL("SELECT commune_id FROM tbl_commune WHERE commune_kh='" & cboCommune.Text & "'")
        'End If

    End Sub

    Private Sub txtFNameKh_GotFocus(sender As Object, e As EventArgs) Handles txtFNameKh.GotFocus
        InputLanguage.CurrentInputLanguage = KhmerInput
    End Sub
    Private Sub txtFNameKh_TextChanged(sender As Object, e As EventArgs) Handles txtFNameKh.TextChanged

    End Sub

    Private Sub txtLNameKH_GotFocus(sender As Object, e As EventArgs) Handles txtLNameKH.GotFocus
        InputLanguage.CurrentInputLanguage = KhmerInput
    End Sub

    Private Sub txtFNameEN_GotFocus(sender As Object, e As EventArgs) Handles txtFNameEN.GotFocus
        InputLanguage.CurrentInputLanguage = EnglishInput
    End Sub

    Private Sub txtLNameEN_GotFocus(sender As Object, e As EventArgs) Handles txtLNameEN.GotFocus
        InputLanguage.CurrentInputLanguage = EnglishInput
    End Sub
End Class
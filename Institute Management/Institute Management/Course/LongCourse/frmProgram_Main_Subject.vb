Imports MySql.Data.MySqlClient
Public Class frmProgram_Main_Subject
    Private InputLang As New InputLanguages 'For Switching Language

    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader

    Dim save_edit As Boolean = False
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Private Sub Register_Long_Program_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        GetDataToListViewImage()

    End Sub
    Private Sub GetDataToListViewImage()
        'Create ImageList objects. 
        Dim imageListLarge As New ImageList()
        imageListLarge.ImageSize = New Size(64, 64)
        imageListLarge.ColorDepth = ColorDepth.Depth32Bit


        Me.LVMainProgram.Items.Clear()
        Dim arrImage() As Byte
        Dim i As Integer = 0

        Try
            'conn = New MySqlConnection
            'conn.ConnectionString = My.Settings.Conn
            MysqlConn.Open()
            Dim sql As String
            sql = "SELECT * FROM tbl_program_main_subject"
            cmd = New MySqlCommand(sql, MysqlConn)
            dr = cmd.ExecuteReader

            Do While dr.Read = True

                arrImage = dr(3)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Dim image6 = Bitmap.FromStream(mstream)
                imageListLarge.Images.AddRange({image6})

                Me.LVMainProgram.Items.Add(dr(1), i)
                i = i + 1

            Loop
            'Assign the ImageList objects to the ListView.
            'LVMainProgram.LargeImageList = imageListLarge
            LVMainProgram.SmallImageList = imageListLarge


        Catch ex As MySqlException
            MysqlConn.Close()
            MsgBox(ex.Message)
            Exit Try

        Finally
            MysqlConn.Close()
            dr.Close()
        End Try
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

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged


        'Create ImageList objects. 
        Dim imageListLarge As New ImageList()
        imageListLarge.ImageSize = New Size(90, 90)
        imageListLarge.ColorDepth = ColorDepth.Depth32Bit


        Me.LVMainProgram.Items.Clear()
        Dim arrImage() As Byte
        Dim i As Integer = 0

        Try
          
            MysqlConn.Open()
            Dim sql As String

            sql = "SELECT * FROM tbl_program_main_subject where (pms_id LIKE '%" & txtFind.Text & "%' or pms_name_kh LIKE '%" & txtFind.Text & "%' OR pms_name_en LIKE '%" & txtFind.Text & "%')"
            cmd = New MySqlCommand(sql, MysqlConn)

            dr = cmd.ExecuteReader

            Do While dr.Read = True

                arrImage = dr(3)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Dim image6 = Bitmap.FromStream(mstream)
                imageListLarge.Images.AddRange({image6})

                Me.LVMainProgram.Items.Add(dr(1), i)
                i = i + 1

            Loop
            'Assign the ImageList objects to the ListView.
            LVMainProgram.LargeImageList = imageListLarge

        Catch ex As MySqlException
            MysqlConn.Close()
            MsgBox(ex.Message)
            Exit Try

        Finally
            MysqlConn.Close()
            dr.Close()
        End Try


      
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim j As Integer = LVMainProgram.Items.Count
        If Me.txt_pms_name_kh.Text = "" Then
            MsgBox("Please Fill in Province Khmer")
            Label2.ForeColor = Color.Red

            Me.txt_pms_name_kh.Focus()
        ElseIf Me.txt_pms_name_en.Text = "" Then
            MsgBox("Please fill in Province English")
            Label3.ForeColor = Color.Red
            Me.txt_pms_name_en.Focus()
        Else
            If save_edit = False Then
                Label2.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                Try

                    'Image
                    Dim mstream As New System.IO.MemoryStream()
                    Pic1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
                    arrImage = mstream.GetBuffer()
                    Dim FileSize As UInt32
                    FileSize = mstream.Length

                    mstream.Close()

                    ' End Image operator

                    MysqlConn.Open()
                    Dim Query As String
                    Query = "INSERT INTO tbl_program_main_subject(pms_name_kh,pms_name_en, pms_note,pms_image) VALUES (@pms_name_kh, @pms_name_en,@pms_note,@pms_image)"
                    cmd.Connection = MysqlConn
                    cmd.CommandText = Query
                    cmd.Parameters.AddWithValue("@pms_name_kh", txt_pms_name_kh.Text)
                    cmd.Parameters.AddWithValue("@pms_name_en", txt_pms_name_en.Text)
                    cmd.Parameters.AddWithValue("@pms_note", txt_pms_note.Text)
                    cmd.Parameters.AddWithValue("@pms_image", arrImage)


                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Province Record hass been Saved!")
                    Else
                        MsgBox("No record has been saved!")
                    End If
                    cmd.Parameters.Clear()
                    MysqlConn.Close()



                    Pic1.Image = Nothing

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            Else
                Label2.ForeColor = Color.Black
                Label3.ForeColor = Color.Black

                Try
                    'Image
                    Dim mstream As New System.IO.MemoryStream()
                    Pic1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
                    arrImage = mstream.GetBuffer()
                    Dim FileSize As UInt32
                    FileSize = mstream.Length

                    mstream.Close()

                    ' End Image operator

                    MysqlConn.Open()
                    Dim Query As String

                    Query = "UPDATE tbl_program_main_subject SET pms_name_kh=@pms_name_kh,pms_name_en=@pms_name_en,pms_note=@pms_note,pms_image=@pms_image WHERE pms_id =@pms_id"
                    cmd.Connection = MysqlConn
                    cmd.CommandText = Query
                    cmd.Parameters.AddWithValue("@pms_name_kh", txt_pms_name_kh.Text)
                    cmd.Parameters.AddWithValue("@pms_name_en", txt_pms_name_en.Text)
                    cmd.Parameters.AddWithValue("@pms_note", txt_pms_note.Text)
                    cmd.Parameters.AddWithValue("@pms_image", arrImage)
                    cmd.Parameters.AddWithValue("@pms_id", txtpms_id.Text)

                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Provice Record hass been Update!")
                    Else
                        MsgBox("No record has been Updated!")
                    End If
                    cmd.Parameters.Clear()
                    MysqlConn.Close()



                    Pic1.Image = Nothing

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try

            End If

            GetDataToListViewImage()
            Call clear()

        End If
    End Sub

    Private Sub clear()
        save_edit = False
        Me.txtpms_id.Text = ""
        Me.txt_pms_name_en.Text = ""
        Me.txt_pms_name_kh.Text = ""
        Me.txt_pms_note.Text = ""
        Me.Pic1.Image = Nothing
        Me.txt_pms_name_kh.Focus()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        clear()

    End Sub

    Private Sub LVMainProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVMainProgram.SelectedIndexChanged
        Dim i As Integer
        For i = 0 To Me.LVMainProgram.Items.Count - 1
            If LVMainProgram.Items(i).Selected Then

                save_edit = True
                ShowDetail(LVMainProgram.Items(i).Text)

            End If
        Next
    End Sub

    Private Sub ShowDetail(ByVal Param As String)
        Dim Sql As String

        Sql = "SELECT * FROM tbl_program_main_subject WHERE pms_id=" & Val(Param) & " OR pms_name_kh='" & Param & "'"

        MysqlConn.Open()
        With cmd
            .Connection = MysqlConn
            .CommandText = Sql
        End With
        Dim arrImage() As Byte
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            Me.txtpms_id.Text = publictable.Rows(0).Item(0)
            Me.txt_pms_name_kh.Text = publictable.Rows(0).Item(1)
            Me.txt_pms_name_en.Text = publictable.Rows(0).Item(2)
            Me.txt_pms_note.Text = publictable.Rows(0).Item(4)

            arrImage = publictable.Rows(0).Item(3)
            Dim mstream As New System.IO.MemoryStream(arrImage)
            Pic1.Image = Image.FromStream(mstream)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()

            MysqlConn.Close()

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim SqlStr As String

        Try
            If (MsgBox("Are you sure you want to delete the item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                SqlStr = "DELETE FROM tbl_program_main_subject WHERE pms_id=" & Me.txtpms_id.Text
                MysqlConn.Open()
                Dim mysc As New MySqlCommand(SqlStr, MysqlConn)
                mysc.ExecuteNonQuery()
                MsgBox("Data Deleted!", MsgBoxStyle.Information)
                MysqlConn.Close()

                GetDataToListViewImage()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MysqlConn.Close()
        End Try
    End Sub

    Private Sub txt_pms_name_kh_GotFocus(sender As Object, e As EventArgs) Handles txt_pms_name_kh.GotFocus
        InputLang.KhmerKeyboard()
    End Sub

    Private Sub txt_pms_name_en_GotFocus(sender As Object, e As EventArgs) Handles txt_pms_name_en.GotFocus
        InputLang.EnglishKeyboard()
    End Sub

   
    Private Sub txt_pms_name_kh_TextChanged(sender As Object, e As EventArgs) Handles txt_pms_name_kh.TextChanged

    End Sub
End Class
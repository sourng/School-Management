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
        imageListLarge.ImageSize = New Size(90, 90)
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
            'conn = New MySqlConnection
            'conn.ConnectionString = My.Settings.Conn
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
        'Dim j As Integer = lvProvince.Items.Count
        'If Me.txtProvince_Kh.Text = "" Then
        '    MsgBox("Please Fill in Province Khmer")
        '    lbl_province_kh.ForeColor = Color.Red

        '    Me.txtProvince_Kh.Focus()
        'ElseIf Me.txtProvince_En.Text = "" Then
        '    MsgBox("Please fill in Province English")
        '    lbl_province_en.ForeColor = Color.Red
        '    Me.txtProvince_En.Focus()
        'Else
        '    If save_edit = False Then
        '        lbl_province_kh.ForeColor = Color.Black
        '        lbl_province_en.ForeColor = Color.Black




        '        'Save Data From form to Database table name tbl_users

        '        'Dim READER As MySqlDataReader
        '        Try

        '            'Image
        '            Dim mstream As New System.IO.MemoryStream()
        '            Pic1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        '            arrImage = mstream.GetBuffer()
        '            Dim FileSize As UInt32
        '            FileSize = mstream.Length

        '            mstream.Close()

        '            ' End Image operator

        '            MysqlConn.Open()
        '            Dim Query As String
        '            Query = "INSERT INTO tbl_program_main_subject(pms_name_kh,pms_name_en, pms_note,pms_image) VALUES (@pms_name_kh, @pms_name_en,@pms_note,pms_image)"
        '            cmd.Connection = MysqlConn
        '            cmd.CommandText = Query
        '            cmd.Parameters.AddWithValue("@pms_name_kh", txt_pms_name_kh.Text)
        '            cmd.Parameters.AddWithValue("@pms_name_en", txt_pms_name_en.Text)
        '            cmd.Parameters.AddWithValue("@pms_note", txt_pms_note.Text)
        '            cmd.Parameters.AddWithValue("@pms_image", arrImage)


        '            Dim r As Integer
        '            r = cmd.ExecuteNonQuery()
        '            If r > 0 Then
        '                MsgBox("Province Record hass been Saved!")
        '            Else
        '                MsgBox("No record has been saved!")
        '            End If
        '            cmd.Parameters.Clear()
        '            MysqlConn.Close()

        '            'lvProvince.Items.Add(Me.txtID.Text)
        '            'lvProvince.Items(j).SubItems.Add(Me.txtProvince_Kh.Text)
        '            'lvProvince.Items(j).SubItems.Add(Me.txtProvince_En.Text)

        '            Pic1.Image = Nothing

        '        Catch ex As MySqlException
        '            MessageBox.Show(ex.Message)
        '        Finally
        '            MysqlConn.Dispose()
        '        End Try
        '    Else
        '        'lbl_province_kh.ForeColor = Color.Black
        '        'lbl_province_en.ForeColor = Color.Black



        '        Try
        '            'Image
        '            Dim mstream As New System.IO.MemoryStream()
        '            Pic1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        '            arrImage = mstream.GetBuffer()
        '            Dim FileSize As UInt32
        '            FileSize = mstream.Length

        '            mstream.Close()

        '            ' End Image operator

        '            MysqlConn.Open()
        '            Dim Query As String

        '            Query = "UPDATE tbl_program_main_subject SET pms_name_kh=@pms_name_kh,pms_name_en=@pms_name_en,pms_note=@pms_note,pms_image=@pms_image WHERE pms_id =@pms_id"
        '            cmd.Connection = MysqlConn
        '            cmd.CommandText = Query
        '            cmd.Parameters.AddWithValue("@pms_name_kh", txt_pms_name_kh.Text)
        '            cmd.Parameters.AddWithValue("@pms_name_en", txt_pms_name_en.Text)
        '            cmd.Parameters.AddWithValue("@pms_note", txt_pms_note.Text)
        '            cmd.Parameters.AddWithValue("@pms_image", arrImage)
        '            cmd.Parameters.AddWithValue("@pms_id", txtpms_id.Text)

        '            Dim r As Integer
        '            r = cmd.ExecuteNonQuery()
        '            If r > 0 Then
        '                MsgBox("Provice Record hass been Update!")
        '            Else
        '                MsgBox("No record has been Updated!")
        '            End If
        '            cmd.Parameters.Clear()
        '            MysqlConn.Close()



        '            LVMainProgram.Items.Add(Me.txtpms_id.Text)
        '            LVMainProgram.Items(j).SubItems.Add(Me.txt_pms_name_kh.Text)
        '            LVMainProgram.Items(j).SubItems.Add(Me.txt_pms_name_en.Text)

        '            Pic1.Image = Nothing

        '        Catch ex As MySqlException
        '            MessageBox.Show(ex.Message)
        '        Finally
        '            MysqlConn.Dispose()
        '        End Try

        '    End If

        '    GetDataToListViewImage()
        '    Call Clear()

        'End If
    End Sub

    Private Sub clear()
        Me.txtpms_id.Text = ""
        Me.txt_pms_name_en.Text = ""
        Me.txt_pms_name_kh.Text = ""
        Me.txt_pms_note.Text = ""
        Me.Pic1.Image = Nothing

    End Sub
End Class
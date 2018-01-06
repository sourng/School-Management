Imports MySql.Data.MySqlClient
Public Class frmProvince
    Private InputLang As New InputLanguages 'For Switching Language

    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader

    Dim save_edit As Boolean = False
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte

    Private Sub txtProvince_Kh_GotFocus(sender As Object, e As EventArgs) Handles txtProvince_Kh.GotFocus
        InputLang.KhmerKeyboard()
    End Sub
    Private Sub txtProvince_En_GotFocus(sender As Object, e As EventArgs) Handles txtProvince_En.GotFocus
        InputLang.EnglishKeyboard()
    End Sub

    Private Sub frmProvince_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()  'Call Function Connection
        GetDataToListViewImage()

        GetDataToListView()

    End Sub

    Private Sub GetDataToListView()
        lvProvince.Items.Clear()
        Try
            'conn = New MySqlConnection
            'conn.ConnectionString = My.Settings.Conn
            MysqlConn.Open()
            Dim sql As String
            sql = "SELECT * FROM tbl_province"
            cmd = New MySqlCommand(sql, MysqlConn)
            dr = cmd.ExecuteReader
            Dim list As ListViewItem
            Do While dr.Read = True
                list = New ListViewItem(dr(0).ToString)
                list.SubItems.Add(dr(1))
                list.SubItems.Add(dr(2))
                'list.SubItems.Add(dr(3))
                'list.SubItems.Add(dr(4))
                'list.SubItems.Add(dr(5))
                'list.SubItems.Add(dr(6))
                'list.SubItems.Add(dr(7))
                'list.SubItems.Add(dr(8))

                lvProvince.Items.Add(list)
            Loop
        Catch ex As MySqlException
            MysqlConn.Close()
            MsgBox(ex.Message)
            Exit Try

        Finally
            MysqlConn.Close()
            dr.Close()
        End Try
    End Sub


    Private Sub GetDataToListViewImage()
        'Create ImageList objects. 
        Dim imageListLarge As New ImageList()
        imageListLarge.ImageSize = New Size(90, 90)
        imageListLarge.ColorDepth = ColorDepth.Depth32Bit


        lvProvince.Items.Clear()
        Dim arrImage() As Byte
        Dim i As Integer = 0

        Try
            'conn = New MySqlConnection
            'conn.ConnectionString = My.Settings.Conn
            MysqlConn.Open()
            Dim sql As String
            sql = "SELECT * FROM tbl_province"
            cmd = New MySqlCommand(sql, MysqlConn)
            dr = cmd.ExecuteReader
           
            Do While dr.Read = True

                arrImage = dr(3)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Dim image6 = Bitmap.FromStream(mstream)
                imageListLarge.Images.AddRange({image6})

                Me.ListView1.Items.Add(dr(1), i)
                i = i + 1

            Loop
            'Assign the ImageList objects to the ListView.
            ListView1.LargeImageList = imageListLarge

        Catch ex As MySqlException
            MysqlConn.Close()
            MsgBox(ex.Message)
            Exit Try

        Finally
            MysqlConn.Close()
            dr.Close()
        End Try
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'If IsConnectionAvailable() = True Then
        '    MsgBox("The Internet is Connected !")
        'Else
        '    MsgBox("The Internet is not Connected !")
        'End If
        Clear()
    End Sub
    Private Sub Clear()
        save_edit = False
        Me.txtID.Text = ""
        Me.txtProvince_Kh.Text = ""
        Me.txtProvince_En.Text = ""

        Me.txtID.Text = lvProvince.Items.Count + 1
        Me.txtProvince_Kh.Focus()

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim j As Integer = lvProvince.Items.Count
        If Me.txtProvince_Kh.Text = "" Then
            MsgBox("Please Fill in Province Khmer")
            lbl_province_kh.ForeColor = Color.Red

            Me.txtProvince_Kh.Focus()
        ElseIf Me.txtProvince_En.Text = "" Then
            MsgBox("Please fill in Province English")
            lbl_province_en.ForeColor = Color.Red
            Me.txtProvince_En.Focus()
        Else
            If save_edit = False Then
                lbl_province_kh.ForeColor = Color.Black
                lbl_province_en.ForeColor = Color.Black

               


                'Save Data From form to Database table name tbl_users

                'Dim READER As MySqlDataReader
                Try

                    'Image
                    Dim mstream As New System.IO.MemoryStream()
                    Pic1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    arrImage = mstream.GetBuffer()
                    Dim FileSize As UInt32
                    FileSize = mstream.Length

                    mstream.Close()

                    ' End Image operator

                    MysqlConn.Open()
                    Dim Query As String
                    Query = "INSERT INTO tbl_province(province_kh,province_en, Image) VALUES (@province_kh, @province_en,@Image)"
                    cmd.Connection = MysqlConn
                    cmd.CommandText = Query
                    cmd.Parameters.AddWithValue("@province_kh", txtProvince_Kh.Text)
                    cmd.Parameters.AddWithValue("@province_en", txtProvince_En.Text)
                    
                    cmd.Parameters.AddWithValue("@Image", arrImage)
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Province Record hass been Saved!")
                    Else
                        MsgBox("No record has been saved!")
                    End If
                    cmd.Parameters.Clear()
                    MysqlConn.Close()

                    lvProvince.Items.Add(Me.txtID.Text)
                    lvProvince.Items(j).SubItems.Add(Me.txtProvince_Kh.Text)
                    lvProvince.Items(j).SubItems.Add(Me.txtProvince_En.Text)

                    Pic1.Image = Nothing

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            Else
                lbl_province_kh.ForeColor = Color.Black
                lbl_province_en.ForeColor = Color.Black

               

                Try
                    'Image
                    Dim mstream As New System.IO.MemoryStream()
                    Pic1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    arrImage = mstream.GetBuffer()
                    Dim FileSize As UInt32
                    FileSize = mstream.Length

                    mstream.Close()

                    ' End Image operator

                    MysqlConn.Open()
                    Dim Query As String

                    'Query = "UPDATE tbl_province SET province_kh ='" + txtProvince_Kh.Text + "',"
                    'Query = Query + "province_en = '" + txtProvince_En.Text + "'"
                    'Query = Query + " WHERE province_id = " + txtID.Text

                    'MysqlConn.Open()

                    Query = "UPDATE tbl_province SET province_kh=@province_kh,province_en=@province_en,Image=@Image WHERE province_id =@province_id"
                    cmd.Connection = MysqlConn
                    cmd.CommandText = Query
                    cmd.Parameters.AddWithValue("@province_kh", txtProvince_Kh.Text)
                    cmd.Parameters.AddWithValue("@province_en", txtProvince_En.Text)
                    cmd.Parameters.AddWithValue("@Image", arrImage)
                    cmd.Parameters.AddWithValue("@province_id", txtID.Text)

                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Provice Record hass been Update!")
                    Else
                        MsgBox("No record has been Updated!")
                    End If
                    cmd.Parameters.Clear()
                    MysqlConn.Close()



                    lvProvince.Items.Add(Me.txtID.Text)
                    lvProvince.Items(j).SubItems.Add(Me.txtProvince_Kh.Text)
                    lvProvince.Items(j).SubItems.Add(Me.txtProvince_En.Text)

                    Pic1.Image = Nothing

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try

            End If
            
            GetDataToListView()
            Call Clear()

        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub lvProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProvince.SelectedIndexChanged
        Dim i As Integer
        For i = 0 To Me.lvProvince.Items.Count - 1
            If lvProvince.Items(i).Selected Then
                Me.txtID.Text = lvProvince.Items(i).Text
                'Me.txtProvince_Kh.Text = lvProvince.Items(i).SubItems(1).Text
                'Me.txtProvince_En.Text = lvProvince.Items(i).SubItems(2).Text
                save_edit = True
                ShowDetail(Me.txtID.Text)
                Me.txtTotalDistrict.Text = sql_count("Select * FROM tbl_district WHERE province_id =" & txtID.Text)
            End If
        Next
    End Sub

    Private Sub ShowDetail(ByVal Param As String)
        Dim Sql As String

        Sql = "SELECT * FROM tbl_province WHERE province_id=" & Val(Param) & " OR province_kh='" & Param & "'"
        'conn.ConnectionString = Myconnection
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
            Me.txtID.Text = publictable.Rows(0).Item(0)
            Me.txtProvince_Kh.Text = publictable.Rows(0).Item(1)
            Me.txtProvince_En.Text = publictable.Rows(0).Item(2)

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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim SqlStr As String

        Try
            If (MsgBox("Are you sure you want to delete the item?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                SqlStr = "DELETE FROM tbl_province WHERE province_id=" & Me.txtID.Text
                MysqlConn.Open()
                Dim mysc As New MySqlCommand(SqlStr, MysqlConn)
                mysc.ExecuteNonQuery()
                MsgBox("Data Deleted!", MsgBoxStyle.Information)
                MysqlConn.Close()

                GetDataToListView()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MysqlConn.Close()
        End Try
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        
        lvProvince.Items.Clear()
        Try
            'conn = New MySqlConnection
            'conn.ConnectionString = My.Settings.Conn
            MysqlConn.Open()
            Dim sql As String
            sql = "SELECT * FROM tbl_province where (province_id LIKE '%" & txtFind.Text & "%' or province_kh LIKE '%" & txtFind.Text & "%' OR province_en LIKE '%" & txtFind.Text & "%')"
            cmd = New MySqlCommand(sql, MysqlConn)
            dr = cmd.ExecuteReader
            Dim list As ListViewItem
            Do While dr.Read = True
                list = New ListViewItem(dr(0).ToString)
                list.SubItems.Add(dr(1))
                list.SubItems.Add(dr(2))
                'list.SubItems.Add(dr(3))
                'list.SubItems.Add(dr(4))
                'list.SubItems.Add(dr(5))
                'list.SubItems.Add(dr(6))
                'list.SubItems.Add(dr(7))
                'list.SubItems.Add(dr(8))

                lvProvince.Items.Add(list)
            Loop
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim i As Integer
        For i = 0 To Me.ListView1.Items.Count - 1
            If ListView1.Items(i).Selected Then
                Me.txtID.Text = ListView1.Items(i).Text
                save_edit = True
                ShowDetail(Me.txtID.Text)
                Me.txtTotalDistrict.Text = sql_count("Select * FROM tbl_district WHERE province_id =" & txtID.Text)
            End If
        Next
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

    End Sub
End Class
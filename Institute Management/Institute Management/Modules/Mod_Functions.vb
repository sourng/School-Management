Imports MySql.Data.MySqlClient
Module Mod_Functions
    Public MysqlConn As New MySqlConnection
    Public user_type, UserName, user_email, userteacher_id, userFamilyNameKH, userFirstNameKH, userEmail, userPassword, userPhoto As String
    Public user_group_id, userGroup_name_kh, userUser_level_id, userLevel_name_kh, userLevel_number As String
    Public btnUserAdd, btnUserDelete, btnUserEdite, btnUserSearch, btnUserPrint As Boolean

    Public userMain_form As String




    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader

    Public Sub ConnectDB()

        MysqlConn.ConnectionString = My.Settings.Conn ' ("server=localhost;user id=root;password=;database=vb_training")
        Try
            MysqlConn.Open()
            'MessageBox.Show("Connection to Database has been opened.")
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    'Login 
    Public Function IsLogin(ByVal Email As String, ByVal Pass As String) As Boolean
        Dim CheckCon As Boolean
        Dim sql As String
        Dim publictable As New DataTable

        Try

            MysqlConn.Open()
            'Dim sql As String
            sql = "SELECT t.teacher_id,t.FamilyNameKH,t.FirstNameKH,t.email,t.password,t.photo,ug.user_group_id,ug.group_name_kh,"
            sql = sql + "ug.main_form,ul.user_level_id,ul.level_name_kh,ul.level_number,ul.add,ul.delete,ul.edit,ul.search,ul.print "
            sql = sql + " FROM tbl_teacher as t INNER JOIN tbl_user_group as ug ON t.user_group_id=ug.user_group_id INNER JOIN "
            sql = sql + " tbl_user_level as ul ON t.user_level_id=ul.user_level_id WHERE Email ='" & Email & "' And password = '" & Pass & "'"


            'cmd = New MySqlCommand(sql, MysqlConn)
            'dr = cmd.ExecuteReader
            With cmd
                .Connection = MysqlConn
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(publictable)

            If publictable.Rows.Count > 0 Then

                user_email = publictable.Rows(0).Item(3)  'ទាញយក​ Email
                UserName = publictable.Rows(0).Item(1) & " " & publictable.Rows(0).Item(2) '​ទាញយក​ឈ្មោះ​

                userteacher_id = publictable.Rows(0).Item(0)
                userFamilyNameKH = publictable.Rows(0).Item(1)
                userFirstNameKH = publictable.Rows(0).Item(2)
                userEmail = publictable.Rows(0).Item(3)
                userPassword = publictable.Rows(0).Item(4)
                userPhoto = publictable.Rows(0).Item(5)
                user_group_id = publictable.Rows(0).Item(6)
                userGroup_name_kh = publictable.Rows(0).Item(7)
                userMain_form = publictable.Rows(0).Item(8)
                userUser_level_id = publictable.Rows(0).Item(9)
                userLevel_name_kh = publictable.Rows(0).Item(10)
                userLevel_number = publictable.Rows(0).Item(11)

                If publictable.Rows(0).Item(12) = 1 Then
                    btnUserAdd = True
                Else
                    btnUserAdd = False
                End If
                If publictable.Rows(0).Item(13) = 1 Then
                    btnUserDelete = True
                Else
                    btnUserDelete = False
                End If

                If publictable.Rows(0).Item(14) = 1 Then
                    btnUserEdite = True
                Else
                    btnUserEdite = False
                End If

                If publictable.Rows(0).Item(15) = 1 Then
                    btnUserSearch = True
                Else
                    btnUserSearch = False
                End If
                If publictable.Rows(0).Item(16) = 1 Then
                    btnUserPrint = True
                Else
                    btnUserPrint = False
                End If
                CheckCon = True

               
            Else
                CheckCon = False
                'MsgBox("Contact administrator to registered!")

            End If



        Catch ex As MySqlException
            MysqlConn.Close()
            MsgBox(ex.Message)
            Exit Try

        Finally
            MysqlConn.Close()
            'dr.Close()
            da.Dispose()
        End Try

        Return CheckCon

    End Function

    'Check Internet Connection
    Public Function IsConnectionAvailable() As Boolean
        Dim objUrl As New System.Uri("http://www.google.com")
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objresp As System.Net.WebResponse

        Try
            objresp = objWebReq.GetResponse
            objresp.Close()
            objresp = Nothing
            Return True

        Catch ex As Exception
            objresp = Nothing
            objWebReq = Nothing
            Return False
        End Try
    End Function

    'Count Field
    Function sql_count(ByVal sqlStr As String) As Integer
        Dim countNumber As Integer = 0
        MysqlConn.Open()
        Try
            cmd = New MySqlCommand(sqlStr, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                countNumber = countNumber + 1

            Loop

        Catch ex As MySqlException
            MysqlConn.Close()
            MsgBox(ex.Message)
            Exit Try

        Finally
            MysqlConn.Close()
            dr.Close()

        End Try

        Return countNumber
    End Function

    ' Get ID
    Function GetID_BySQL(ByVal sqlStr As String) As Integer
        'Dim countNumber As Integer = 0
        Dim getID As Integer = 0

        MysqlConn.Open()
        Try
            cmd = New MySqlCommand(sqlStr, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                getID = dr(0)

            Loop

        Catch ex As MySqlException
            MysqlConn.Close()
            MsgBox(ex.Message)
            Exit Try

        Finally
            MysqlConn.Close()
            dr.Close()

        End Try

        Return getID
    End Function

    'Add Data To Combo
    Public Sub AddData2Combo(ByVal SQLString As String, ByVal ComboName As ComboBox)
        ComboName.Items.Clear()
        Try
            'conn = New MySqlConnection
            'conn.ConnectionString = My.Settings.Conn
            If MysqlConn.State = ConnectionState.Closed Then
                MysqlConn.Open()
            End If

            cmd = New MySqlCommand(SQLString, MysqlConn)
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                ComboName.Items.Add(dr(0))
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



End Module

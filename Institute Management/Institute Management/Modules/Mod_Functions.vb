Imports MySql.Data.MySqlClient
Module Mod_Functions
    Public MysqlConn As New MySqlConnection
    Public user_type, UserName, user_email As String
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
End Module

Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReport_province

    Private Sub frmReport_province_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet1
        If MysqlConn.State = ConnectionState.Closed Then
            MysqlConn.Open()
        End If

        adapter.SelectCommand = New MySqlCommand("SELECT province_id,province_kh,province_en FROM tbl_province WHERE province_id= " & Me.txtID.Text, MysqlConn)
        adapter.Fill(ds.Tables(0))
        ReportViewer1.ProcessingMode = ProcessingMode.Local


        Dim path As String
        path = My.Application.Info.DirectoryPath
        'Dim path1 As String = path.Replace("\bin\Debug", "\")
        Dim path1 As String = path.Replace("\bin\Debug", "\Reports")

        ReportViewer1.LocalReport.ReportPath = path1 & ("\Report1.rdlc")

        'ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & ("\Report1.rdlc")
        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))


        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()


    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim daa As MySqlDataAdapter
    Dim dtt As DataTable
    Dim cmdd As MySqlCommand
    Dim conn As MySqlConnection
    Dim sql As String
    Public petition_id As Integer = Nothing
    Sub view()
        'Try
        '    con.Open()

        '    sql = "SELECT * FROM petition_record WHERE petition_id = '" & 58 & "'"

        '    da = New MySqlDataAdapter(sql, con)
        '    dt = New DataTable
        '    da.Fill(dt)


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'con.Close()
        'da.Dispose()
        conn.Open()
        cmdd = New MySqlCommand("SELECT * FROM petition_record WHERE petition_id = '" & petition_id & "'", conn)
        dtt = New DataTable
        daa = New MySqlDataAdapter(cmdd)
        daa.Fill(dtt)
        conn.Close()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_petition")

        Dim mrpt As New report_certificate
        view()
        mrpt.SetDataSource(dtt)
        'CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = mrpt
        CrystalReportViewer1.Refresh()
        'Dim myreport As New report_certificate
        'view()
        'myreport.SetDataSource(dt)
        ''CrystalReportViewer1.ReportSource = Nothing
        'CrystalReportViewer1.ReportSource = myreport
        'CrystalReportViewer1.Refresh()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class
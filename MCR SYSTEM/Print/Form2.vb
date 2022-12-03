Imports MySql.Data.MySqlClient

Public Class Form2
    Dim daa As MySqlDataAdapter
    Dim dtt As DataTable
    Dim cmdd As MySqlCommand
    Dim conn As MySqlConnection
    Dim sql As String
    Public petition_id As Integer = Nothing
    Sub view()

        Dim cce As String = "CORRECTION OF CLERICAL ERROR"
        Dim cfn As String = "CHANGE FIRST NAME"

        con.Open()
        cmdd = New MySqlCommand("SELECT upper(`doc_owner`) as doc_owner, upper(`year`) as year, upper(`ra`) as ra, upper(`petition_num`) as petition_num, upper(`type_doc`) as type_doc, upper(`year_final`) as year_final, upper(`petition_label`) as petition_label, upper(head_name) as head_name FROM `petition_record` INNER JOIN tbl_head  WHERE petition_id = '" & petition_id & "'", con)
        dtt = New DataTable
            daa = New MySqlDataAdapter(cmdd)
            daa.Fill(dtt)
        con.Close()
        cmdd.Dispose()
        daa.Dispose()


    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_petition")

        Dim mrpt As New report_certificate
        view()
        mrpt.SetDataSource(dtt)

        CrystalReportViewer1.ReportSource = mrpt
        CrystalReportViewer1.Refresh()
        dtt.Dispose()

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
    Sub save()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode = Keys.P Then
            'here goes your code to print the report
            CrystalReportViewer1.PrintReport()
        End If
    End Sub
End Class
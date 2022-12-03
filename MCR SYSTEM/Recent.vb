Imports System.Data.SqlClient
Public Class Recent
    'Public Shared 
    Private Sub Recent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql1 As String = "SELECT concat(p.petition_num, '-', p.year)as petition_num, upper(p.doc_owner) AS doc_owner, 
        upper(p.gender) AS gender, upper(p.name_of_petitioner) AS name_of_petitioner, upper(p.type_doc) AS type_doc, upper(p.municipality) AS municipality, 
        upper(p.province) AS province, upper(CONCAT_WS(', ', nullif(p.certificate, ''), nullif(p.certificate_2, ''), nullif(p.certificate_3, ''))) AS certificate , 
        upper(p.year_final) AS year_final, ra FROM petition_record AS p INNER JOIN recent_activity AS r ON p.petition_id = r.petition_id ORDER BY p.petition_id DESC"

        sql = "SELECT p.petition_id, p.petition_num, p.doc_owner, p.gender, p.name_of_petitioner, p.type_doc, p.municipality, p.province FROM petition_record as p INNER JOIN recent_activity as r ON p.petition_id = r.petition_id ORDER BY r.recent_id DESC"
        loaddtg(DataGridView2, sql1)

        sql = "SELECT COUNT(petition_id) as TOTAL FROM petition_record"
        Try
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
                'Dim count As Int32 = CType(.ExecuteScalar(), Int32)
                'Me.Text = "TOTAL NUMBER OF RECORDS " + String.Format("{0}", count)
                Me.Text = "TOTAL RECORDS " + dt.Rows.Count.ToString()

            End With



            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DataGridView1.Columns(0).Visible = False
        con.Close()
        cmd.Dispose()

    End Sub
End Class
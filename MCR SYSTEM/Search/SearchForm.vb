﻿Imports MySql.Data.MySqlClient
Public Class SearchForm
    Public Shared type As String
    Public Shared pet_num As String
    Dim id As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sql = "SELECT `petition_id` AS "", `petition_num` AS "PETITION NUMBER", `doc_owner` AS "DOCUMENT OWNER", 
        '    `gender` AS GENDER, `name_of_petitioner` AS NAME, `type_doc` AS "TYPE Of DOCUMENT", `municipality` AS MUNICIPALITY, 
        '    `province` AS PROVINCEFROM FROM `petition_record` "

        btnedit.Enabled = False
        btndelete.Enabled = False
        print.Enabled = False
        txtSearch.Text = ""
        Dim counter As Integer = 1
        Dim total As String

        'sql = "SELECT petition_id,petition_num, doc_owner, gender, name_of_petitioner, type_doc, municipality, province FROM petition_record WHERE type_doc = '" & type & "' AND petition_num LIKE '%" & pet_num & "%' LIMIT 10 ORDER BY petition_id ASC"
        sql = "SELECT petition_id,concat(petition_label, '-', petition_num, '-', year)as petition, upper(doc_owner) AS doc_owner, 
                upper(gender) AS gender, upper(name_of_petitioner) AS name_of_petitioner, upper(type_doc) AS type_doc, upper(municipality) AS municipality, 
                upper(province) AS province, upper(CONCAT_WS(', ', nullif(certificate, ''), nullif(certificate_2, ''), nullif(certificate_3, ''))) AS certificate , upper(year_final) AS year_final, ra FROM petition_record WHERE type_doc = '" & type.Trim & "' AND petition_label LIKE '%" & pet_num & "%' ORDER BY petition_id DESC"
        loaddtg(DataGridView2, sql)

        'Try

        '    con.Open()
        '    da = New MySqlDataAdapter(sql, con)
        '    dt = New DataTable
        '    da.Fill(dt)
        '    If dt.Rows.Count = 0 Then
        '        MsgBox("No Records")

        '    Else
        '        DataGridView2.DataSource = dt
        '    End If



        'Catch ex As Exception

        'End Try
        'con.Close()
        'da.Dispose()

        sql = "SELECT COUNT(petition_id) as TOTAL FROM petition_record WHERE type_doc = '" & type & "'"
        Try
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
                'Dim count As Int32 = CType(.ExecuteScalar(), Int32)
                'Me.Text = "TOTAL NUMBER OF RECORDS " + String.Format("{0}", count)
                Me.Text = "TOTAL NUMBER OF RECORDS " + dt.Rows.Count.ToString()

            End With



            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DataGridView2.Columns(0).Visible = False
        con.Close()
        cmd.Dispose()



        'MsgBox(type)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnedit.Click

        With edit_form
            Me.Close()
            .edit_id = DataGridView2.CurrentRow.Cells(0).Value
            .Show()
            'Me.Dispose()
        End With


    End Sub




    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sql = "SELECT petition_id, concat(petition_label, '-', petition_num, '-', year)as petition, ra, UPPER(doc_owner) AS doc_owner, UPPER(gender) AS gender, UPPER(name_of_petitioner) AS name_of_petitioner, UPPER(type_doc) AS type_doc,UPPER(municipality) AS municipality, UPPER(province) AS province, UPPER(CONCAT_WS(', ', nullif(certificate, ''), nullif(certificate_2, ''), nullif(certificate_3, ''))) AS certificate, year_final 
            FROM petition_record WHERE (concat(petition_label, '-', petition_num, '-', year) LIKE '%" & txtSearch.Text & "%'   OR doc_owner LIKE '%" & txtSearch.Text & "%' 
            OR gender LIKE '%" & txtSearch.Text & "%' OR name_of_petitioner LIKE '%" & txtSearch.Text & "%' OR type_doc LIKE '%" & txtSearch.Text & "%' OR municipality LIKE '%" & txtSearch.Text & "%' 
            OR province LIKE '%" & txtSearch.Text & "%' OR certificate LIKE '%" & txtSearch.Text & "%' OR ra LIKE '%" & txtSearch.Text & "%')  AND (type_doc = '" & type.Trim & "') AND (petition_label LIKE '%" & pet_num & "%') ORDER BY petition_id DESC"

        loaddtg(DataGridView2, sql)




    End Sub


    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            con.Open()

            sql = "DELETE FROM petition_record WHERE petition_id = '" & id & "'"
            With cmd
                .CommandText = sql
                .Connection = con
                Dim result = .ExecuteNonQuery


            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


        Call SearchForm_Load(sender, e)
        Me.Refresh()

    End Sub



    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        btnedit.Enabled = True
        btndelete.Enabled = True
        print.Enabled = True
        id = DataGridView2.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridView2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView2.RowPostPaint
        'Using sb As SolidBrush = New SolidBrush(DataGridView2.RowHeadersDefaultCellStyle.ForeColor)
        '    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, sb, e.RowBounds.Location.X, e.RowBounds.Location.Y + 4)
        'End Using
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            sql = "SELECT petition_id, concat(petition_label, '-', petition_num, '-', year)as petition, ra, UPPER(doc_owner) AS doc_owner, UPPER(gender) AS gender, UPPER(name_of_petitioner) AS name_of_petitioner, UPPER(type_doc) AS type_doc,UPPER(municipality) AS municipality, UPPER(province) AS province, UPPER(CONCAT_WS(', ', nullif(certificate, ''), nullif(certificate_2, ''), nullif(certificate_3, ''))) AS certificate, upper(year_final) as year_final
            FROM petition_record WHERE (concat(petition_label, '-', petition_num, '-', year) LIKE '%" & txtSearch.Text & "%'   OR doc_owner LIKE '%" & txtSearch.Text & "%' 
            OR gender LIKE '%" & txtSearch.Text & "%' OR name_of_petitioner LIKE '%" & txtSearch.Text & "%' OR type_doc LIKE '%" & txtSearch.Text & "%' OR municipality LIKE '%" & txtSearch.Text & "%' 
            OR province LIKE '%" & txtSearch.Text & "%' OR certificate LIKE '%" & txtSearch.Text & "%' OR ra LIKE '%" & txtSearch.Text & "%')  AND (type_doc = '" & type.Trim & "') AND (petition_label LIKE '%" & pet_num & "%') ORDER BY petition_id DESC"

            'sql = "SELECT petition_num, doc_owner, gender, name_of_petitioner, type_doc,municipality, province 
            '      FROM petition_record WHERE petition_num LIKE '%" & txtSearch.Text & "%'"
            loaddtg(DataGridView2, sql)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Txtrefresh_Click(sender As Object, e As EventArgs) Handles txtrefresh.Click
        Call SearchForm_Load(sender, e)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub SearchForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles print.Click
        'GLOBALid = DataGridView2.CurrentRow.Cells(0).Value
        'sql = "SELECT * FROM petition_record "
        'reportsAll(sql, "Comclearance", Form2.CrystalReportViewer1)
        'Form2.Show()
        cert_auth.petition_id = DataGridView2.CurrentRow.Cells(0).Value
        cert_posting.petition_id = DataGridView2.CurrentRow.Cells(0).Value
        With Form3
            'Me.Close()
            .id = DataGridView2.CurrentRow.Cells(0).Value
            '.ShowDialog()
        End With

        With type_of_cert
            .ShowDialog()
        End With

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT petition_id, concat(petition_label, '-', petition_num, '-', year)as petition, ra, UPPER(doc_owner) AS doc_owner, UPPER(gender) AS gender, UPPER(name_of_petitioner) AS name_of_petitioner, UPPER(type_doc) AS type_doc,UPPER(municipality) AS municipality, UPPER(province) AS province, UPPER(CONCAT_WS(', ', nullif(certificate, ''), nullif(certificate_2, ''), nullif(certificate_3, ''))) AS certificate, year_final 
            FROM petition_record WHERE (concat(petition_label, '-', petition_num, '-', year) LIKE '%" & txtSearch.Text & "%'   OR doc_owner LIKE '%" & txtSearch.Text & "%' 
            OR gender LIKE '%" & txtSearch.Text & "%' OR name_of_petitioner LIKE '%" & txtSearch.Text & "%' OR type_doc LIKE '%" & txtSearch.Text & "%' OR municipality LIKE '%" & txtSearch.Text & "%' 
            OR province LIKE '%" & txtSearch.Text & "%' OR certificate LIKE '%" & txtSearch.Text & "%' OR ra LIKE '%" & txtSearch.Text & "%')  AND (type_doc = '" & type.Trim & "') AND (petition_label LIKE '%" & pet_num & "%') ORDER BY petition_id DESC"

        loaddtg(DataGridView2, sql)


    End Sub
End Class
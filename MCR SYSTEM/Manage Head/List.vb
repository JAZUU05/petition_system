Imports MySql.Data.MySqlClient
Public Class List
    Dim id As Integer = Nothing
    Sub add()
        Try
            con.Open()
            sql = "INSERT INTO tbl_head(head_name) VALUES (@head_name)"
            With cmd
                .Connection = con
                .CommandText = sql
                .Parameters.AddWithValue("@head_name", txtname.Text)
                .ExecuteNonQuery()
            End With

            txtname.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
    End Sub

    Sub edit()
        Try
            con.Open()
            sql = "UPDATE tbl_head SET head_name = @head_name WHERE head_id = @head_id"

            With cmd
                .CommandText = sql
                .Connection = con
                .Parameters.Clear()
                .Parameters.AddWithValue("@head_name", txtname.Text)
                .Parameters.AddWithValue("@head_id", id)
                .ExecuteNonQuery()
            End With
            txtname.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()

    End Sub
    Private Sub Btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        If txtname.Text = "" Then
            MsgBox("Enter Name", MsgBoxStyle.Information, "Insert")
        Else
            add()
            Call List_Load(sender, e)
        End If

    End Sub

    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT head_id as ID, head_name as NAME FROM tbl_head"
        loaddtg(DataGridView1, sql)
        If dt.Rows.Count > 0 Then
            btnnew.Enabled = False
        Else
            btnnew.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        id = DataGridView1.CurrentRow.Cells(0).Value

        Try
            con.Open()
            sql = "SELECT head_name FROM tbl_head WHERE head_id = '" & id & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            txtname.Text = dt.Rows(0).Item("head_name")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
        dt.Dispose()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        id = DataGridView1.CurrentRow.Cells(0).Value

        Try
            con.Open()
            sql = "SELECT head_name FROM tbl_head WHERE head_id = '" & id & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            txtname.Text = dt.Rows(0).Item("head_name")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
        dt.Dispose()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtname.Text = "" Then
            MsgBox("Select Row", MsgBoxStyle.Information, "Update")
        Else
            edit()
            Call List_Load(sender, e)
        End If
    End Sub

    Private Sub List_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        txtname.Clear()
        id = Nothing
    End Sub
End Class
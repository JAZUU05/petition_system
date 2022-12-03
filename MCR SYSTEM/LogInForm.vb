Imports MySql.Data.MySqlClient
Public Class LogInForm
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim con As MySqlConnection = mysqldb()
        Dim da As MySqlDataAdapter
        Dim cmd As New MySqlCommand
        Dim dt As DataTable


        Try
            con.Open()
            Dim sql As String = "SELECT * FROM login WHERE username = '" & txtuser.Text & "' AND password = '" & txtpass.Text & "'"
            Dim result As String

            With cmd
                .CommandText = sql
                .Connection = con
                'result = .ExecuteNonQuery()


            End With

            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

            Else
                MsgBox("Invalid Username/Password", MsgBoxStyle.Exclamation, "Login Error")
            End If



            con.Close()

        Catch ex As Exception

        End Try

        If txtuser.Text = "admin" And txtpass.Text = "admin" Then

        End If
    End Sub

    Private Sub Txtpass_Enter(sender As Object, e As EventArgs) Handles txtpass.Enter
        'Dim da As SqlDataAdapter
        'Dim cmd As New SqlCommand
        'Dim dt As DataTable


        'Try
        '    con.Open()
        '    Dim sql As String = "SELECT * FROM login WHERE username = '" & txtuser.Text & "' AND password = '" & txtpass.Text & "'"
        '    Dim result As String

        '    With cmd
        '        .CommandText = sql
        '        .Connection = con
        '        'result = .ExecuteNonQuery()


        '    End With

        '    dt = New DataTable
        '    da = New SqlDataAdapter(sql, con)
        '    da.Fill(dt)

        '    If dt.Rows.Count > 0 Then
        '        With MainForm
        '            .ExitToolStripMenuItem.Visible = False
        '            .add_new.Visible = True
        '            .help.Visible = True
        '            .LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '            .search.Visible = True
        '        End With
        '        txtpass.Text = ""
        '        txtuser.Text = ""
        '        Me.Close()
        '    Else
        '        MsgBox("Invalid Username/Password", MsgBoxStyle.Exclamation, "Login Error")
        '    End If



        '    con.Close()

        'Catch ex As Exception

        'End Try

        'If txtuser.Text = "admin" And txtpass.Text = "admin" Then

        'End If
    End Sub

    Private Sub LogInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
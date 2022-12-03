Imports System.IO.StreamReader
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class add1
    Public Shared pet_num As String = ""
    Public Shared type_doc As String = ""

    Dim cert As String = ""
    Dim autth As String = ""
    Dim finn As String = ""
    Dim result As String
    Dim gender As String



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Sub insert()
        con.Open()
        Dim sql As String = "INSERT INTO petition_record(petition_num, year, doc_owner, gender,
                                name_of_petitioner, type_doc, municipality, province, certificate, certificate_2, certificate_3, year_final, ra) 
                                VALUES (@petition_num, @year, @doc_owner, @gender, @name_of_petitioner, @type_doc, @municipality, @province, @certificate, @certificate_2, @certificate_3, @year_final, @ra)"
        With cmd
            .CommandText = sql
            .Connection = con
            .Parameters.Clear()
            .Parameters.Add("@petition_num", MySqlDbType.VarChar).Value = txtPet.Text
            .Parameters.Add("@year", MySqlDbType.VarChar).Value = year.Text
            .Parameters.Add("@doc_owner", MySqlDbType.VarChar).Value = txtDocOw.Text
            .Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender
            .Parameters.Add("@name_of_petitioner", MySqlDbType.VarChar).Value = txtNamePet.Text
            .Parameters.Add("@type_doc", MySqlDbType.VarChar).Value = txtTypeDoc.Text
            .Parameters.Add("@municipality", MySqlDbType.VarChar).Value = txtMun.Text
            .Parameters.Add("@province", MySqlDbType.VarChar).Value = txtprov.Text
            .Parameters.Add("@certificate", MySqlDbType.VarChar).Value = cert
            .Parameters.Add("@certificate_2", MySqlDbType.VarChar).Value = autth
            .Parameters.Add("@certificate_3", MySqlDbType.VarChar).Value = finn
            .Parameters.Add("@year_final", MySqlDbType.VarChar).Value = TextBox1.Text
            .Parameters.Add("@ra", MySqlDbType.VarChar).Value = ra.Text
            '.Parameters.Add("@image", MySqlDbType.LongBlob).Value = ms.ToArray()

            result = .ExecuteNonQuery()

            MsgBox("Record Inserted", MsgBoxStyle.Information, "Inserted")
            clear()

            con.Close()

        End With
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim con As MySqlConnection = mysqldb()
        Dim cmd As New MySqlCommand


        Try

            Dim ms As New MemoryStream
            'PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

            If rbMale.Checked = True Then
                gender = rbMale.Text
            ElseIf rbFemale.Checked = True Then
                gender = rbFemale.Text
            End If




            If txtDocOw.Text = "" Then
                MsgBox("Some Fields Cannot be Empty")
                Label15.Visible = True
            ElseIf txtNamePet.Text = "" Then
                MsgBox("Some Fields Cannot be Empty")
                Label14.Visible = True
            ElseIf year.Text = "" Then
                MsgBox("Some Fields Cannot be Empty")
                Label12.Visible = True
            ElseIf ra.Text = "" Then
                MsgBox("Some Fields Cannot be Empty")
                Label13.Visible = True


            Else
                If TextBox1.Enabled = True Then
                    If TextBox1.Text = "" Then
                        MsgBox("Some Fields Cannot be Empty")
                        Label10.Visible = True
                    Else


                        insert()

                    End If
                Else

                    insert()


                End If


            End If
            Call Add1_Load(sender, e)



            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub clear()

        For Each ctrl As Control In GroupBox2.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = ""
            End If

        Next

        txtMun.Text = ""
        txtprov.Text = "Cagayan"
        rbFemale.Checked = False
        rbMale.Checked = False
        auth.Checked = False
        fin.Checked = False
        cert_post.Checked = False
        txtPet.Text = pet_num
        txtTypeDoc.Text = type_doc
        TextBox1.Text = ""
        TextBox1.Enabled = False
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbInsert.Enter

    End Sub

    Private Sub Add1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'With frmAddCCE
        '    txtTypeDoc.Text = .Button1.Text
        'End With

        txtTypeDoc.Enabled = False
        txtprov.Text = "Cagayan"
        txtprov.Enabled = False



        sql = "SELECT petition_id, concat(petition_num, '-',year)as petition, ra, upper(doc_owner) AS doc_owner, upper(gender) AS gender, upper(name_of_petitioner) AS name_of_petitioner, upper(type_doc) AS type_doc, upper(municipality) AS municipality, upper(province) AS province, upper(CONCAT_WS(', ', nullif(certificate, ''), nullif(certificate_2, ''), nullif(certificate_3, ''))) AS certificate, year_final FROM petition_record WHERE petition_num LIKE '%" & pet_num & "%' AND type_doc = '" & txtTypeDoc.Text & "' ORDER BY petition_id DESC"

        loaddtg(DataGridView1, sql)
        DataGridView1.Columns(0).Visible = False

        sql = "SELECT COUNT(petition_id) as TOTAL FROM petition_record WHERE type_doc = '" & type_doc & "'"
        Try
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
                'Dim count As Int32 = CType(.ExecuteScalar(), Int32)
                'Me.Text = "TOTAL NUMBER OF RECORDS " + String.Format("{0}", count)
                Me.Text = "ADD RECORDS " + "(TOTAL RECORDS " + dt.Rows.Count.ToString() + ")"

            End With



            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DataGridView1.Columns(0).Visible = False
        con.Close()
        cmd.Dispose()



    End Sub

    Private Sub TxtPet_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Year_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        Label12.Visible = False
    End Sub

    Private Sub Ra_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        Label13.Visible = False
    End Sub

    Private Sub TxtPet_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtPet_KeyPress(sender As Object, e As KeyPressEventArgs)
        'If e.KeyChar = Chr(13) Then
        '    year.Focus()
        'End If
    End Sub

    Private Sub TxtPet_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            year.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub Year_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ra.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub Ra_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtDocOw.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub TxtDocOw_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtNamePet.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub TxtNamePet_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtTypeDoc.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub TxtTypeDoc_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtMun.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub TxtMun_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMun.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprov.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub Txtprov_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprov.KeyDown

    End Sub

    Private Sub Txtprov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprov.KeyPress

    End Sub

    Private Sub Txtprov_Enter(sender As Object, e As EventArgs) Handles txtprov.Enter

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        Label10.Visible = False
    End Sub

    Private Sub Fin_MouseClick(sender As Object, e As MouseEventArgs) Handles fin.MouseClick
        If fin.Checked = True Then
            TextBox1.Enabled = True
            finn = fin.Text
        Else
            TextBox1.Enabled = False
            TextBox1.Clear()
            finn = ""
        End If
    End Sub

    Private Sub Txtprov_TextChanged(sender As Object, e As EventArgs) Handles txtprov.TextChanged

    End Sub

    Private Sub Cert_post_MouseClick(sender As Object, e As MouseEventArgs) Handles cert_post.MouseClick

        If cert_post.Checked = True Then
            cert = cert_post.Text
        Else
            cert = ""
        End If

    End Sub

    Private Sub Auth_MouseClick(sender As Object, e As MouseEventArgs) Handles auth.MouseClick
        If auth.Checked = True Then
            autth = auth.Text
        Else
            autth = ""
        End If
    End Sub

    Private Sub Fin_CheckedChanged(sender As Object, e As EventArgs) Handles fin.CheckedChanged

    End Sub

    Private Sub Cert_post_CheckedChanged(sender As Object, e As EventArgs) Handles cert_post.CheckedChanged

    End Sub

    Private Sub TxtDocOw_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtDocOw_KeyPress(sender As Object, e As KeyPressEventArgs)
        Label15.Visible = False
    End Sub

    Private Sub TxtNamePet_KeyPress(sender As Object, e As KeyPressEventArgs)
        Label14.Visible = False
    End Sub

    Private Sub Year_KeyDown_1(sender As Object, e As KeyEventArgs) Handles year.KeyDown
        If e.KeyCode = Keys.Enter Then
            ra.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub Year_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles year.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True
            End If
        End If

        Label12.Visible = False
    End Sub

    Private Sub TxtNamePet_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtNamePet.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTypeDoc.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub TxtPet_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtPet.KeyDown
        If e.KeyCode = Keys.Enter Then
            year.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub Ra_KeyDown_1(sender As Object, e As KeyEventArgs) Handles ra.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDocOw.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub Ra_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles ra.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True
            End If
        End If

        Label13.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TxtNamePet_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtNamePet.KeyPress
        Label14.Visible = False
    End Sub

    Private Sub TxtDocOw_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtDocOw.KeyPress
        Label15.Visible = False
    End Sub

    Private Sub TxtDocOw_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtDocOw.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNamePet.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub
End Class
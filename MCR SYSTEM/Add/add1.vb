Imports System.IO.StreamReader
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class add1
    Public Shared pet_num As String = ""
    Public Shared type_doc As String = ""

    Dim id As Integer
    Dim cert As String = ""
    Dim autth As String = ""
    Dim finn As String = ""
    Dim result As String
    Dim gender As String




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Sub insert()
        con.Open()
        Dim sql As String = "INSERT INTO petition_record(petition_label, petition_num, year, doc_owner, gender,
                                name_of_petitioner, type_doc, municipality, province, certificate, cert_from, cert_to, certificate_2, certificate_3, year_final, ra) 
                                VALUES (@petition_label, @petition_num, @year, @doc_owner, @gender, @name_of_petitioner, @type_doc, @municipality, @province, @certificate, @cert_from, @cert_to, @certificate_2, @certificate_3, @year_final, @ra)"
        With cmd
            .CommandText = sql
            .Connection = con
            .Parameters.Clear()
            .Parameters.Add("@petition_label", MySqlDbType.VarChar).Value = cbolabel.Text
            .Parameters.Add("@petition_num", MySqlDbType.VarChar).Value = txtPet.Text
            .Parameters.Add("@year", MySqlDbType.VarChar).Value = year.Text
            .Parameters.Add("@doc_owner", MySqlDbType.VarChar).Value = txtDocOw.Text
            .Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender
            .Parameters.Add("@name_of_petitioner", MySqlDbType.VarChar).Value = txtNamePet.Text
            .Parameters.Add("@type_doc", MySqlDbType.VarChar).Value = txtTypeDoc.Text
            .Parameters.Add("@municipality", MySqlDbType.VarChar).Value = txtMun.Text
            .Parameters.Add("@province", MySqlDbType.VarChar).Value = txtprov.Text
            .Parameters.Add("@certificate", MySqlDbType.VarChar).Value = cert
            .Parameters.Add("@cert_from", MySqlDbType.VarChar).Value = txtfrom.Text
            .Parameters.Add("@cert_to", MySqlDbType.VarChar).Value = txtto.Text
            .Parameters.Add("@certificate_2", MySqlDbType.VarChar).Value = autth
            .Parameters.Add("@certificate_3", MySqlDbType.VarChar).Value = finn
            .Parameters.Add("@year_final", MySqlDbType.VarChar).Value = txtyear.Text
            .Parameters.Add("@ra", MySqlDbType.VarChar).Value = ra.Text
            '.Parameters.Add("@image", MySqlDbType.LongBlob).Value = ms.ToArray()

            result = .ExecuteNonQuery()

            cbolabel.Text = "--SELECT--"
            txtfrom.Enabled = False
            txtto.Enabled = False
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

            For Each ctrl As Control In Me.Controls
                If ctrl.GetType Is GetType(TextBox) Then
                    If ctrl.Text = "" Then
                        MessageBox.Show("Some Fields Cannot be Empty")
                        Return
                    End If
                End If

            Next

            For Each ctrl As Control In GroupBox2.Controls
                If ctrl.GetType Is GetType(TextBox) Then
                    If ctrl.Text = "" Then
                        MessageBox.Show("Some Fields Cannot be Empty")
                        Return
                    End If
                End If

                If ctrl.GetType Is GetType(ComboBox) Then
                    If ctrl.Text = "--SELECT--" Then
                        MessageBox.Show("Some Fields Cannot be Empty")
                        Return
                    End If
                End If
            Next


            If txtyear.Enabled = True Then
                If txtyear.Text = "" Then
                    MsgBox("Some Fields Cannot be Empty")

                Else


                    insert()

                End If
            Else

                insert()


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
        For Each ctrl As Control In GroupBox2.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                ctrl.Text = "--SELECT--"
            End If

        Next

        txtprov.Text = "Cagayan"
        txtMun.Text = "Peñablanca"
        rbFemale.Checked = False
        rbMale.Checked = False
        auth.Checked = False
        fin.Checked = False
        cert_post.Checked = False
        txtPet.Text = pet_num
        txtMun.Clear()
        txtyear.Enabled = False
        txtyear.Clear()
        txtfrom.Clear()
        txtto.Clear()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbInsert.Enter

    End Sub

    Private Sub Add1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtprov.Text = "Cagayan"
        txtprov.Enabled = False
        txtMun.Text = "Peñablanca"
        txtMun.Enabled = False
        Button1.Enabled = False
        btndelete.Enabled = False

        'sql = "SELECT petition_id, concat(petition_num, '-',year)as petition, ra, upper(doc_owner) AS doc_owner, upper(gender) AS gender, upper(name_of_petitioner) AS name_of_petitioner, upper(type_doc) AS type_doc, upper(municipality) AS municipality, upper(province) AS province, upper(CONCAT_WS(', ', nullif(certificate, ''), nullif(certificate_2, ''), nullif(certificate_3, ''))) AS certificate, year_final FROM petition_record WHERE petition_num LIKE '%" & pet_num & "%' AND type_doc = '" & txtTypeDoc.Text & "' ORDER BY petition_id DESC"
        sql = "SELECT petition_id, concat(petition_label, '-',petition_num, '-',year)as petition, ra, upper(doc_owner) AS doc_owner, upper(gender) AS gender, upper(name_of_petitioner) AS name_of_petitioner, upper(type_doc) AS type_doc, upper(municipality) AS municipality, upper(province) AS province, upper(CONCAT_WS(', ', nullif(certificate, ''), nullif(certificate_2, ''), nullif(certificate_3, ''))) AS certificate, upper(year_final) AS year_final FROM petition_record  ORDER BY petition_id DESC"

        loaddtg(DataGridView1, sql)
        DataGridView1.Columns(0).Visible = False

        sql = "SELECT COUNT(petition_id) as TOTAL FROM petition_record "
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

    Private Sub Year_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Ra_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtPet_Enter(sender As Object, e As EventArgs)

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

    Private Sub Fin_MouseClick(sender As Object, e As MouseEventArgs) Handles fin.MouseClick
        If fin.Checked = True Then
            txtyear.Enabled = True

            finn = fin.Text

        Else
            txtyear.Enabled = False

            txtyear.Clear()
            finn = ""
        End If
    End Sub

    Private Sub Cert_post_MouseClick(sender As Object, e As MouseEventArgs) Handles cert_post.MouseClick

        If cert_post.Checked = True Then
            cert = cert_post.Text
            txtfrom.Enabled = True
            txtto.Enabled = True
        Else
            txtfrom.Enabled = False
            txtto.Enabled = False
            cert = ""
            txtfrom.Clear()
            txtto.Clear()
        End If
    End Sub

    Private Sub Auth_MouseClick(sender As Object, e As MouseEventArgs) Handles auth.MouseClick
        If auth.Checked = True Then
            autth = auth.Text
        Else
            autth = ""
        End If
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
    End Sub

    Private Sub TxtDocOw_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtDocOw.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNamePet.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If
    End Sub

    Private Sub Add1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnSave.Enabled = False
        Button1.Enabled = True
        btndelete.Enabled = True
        id = DataGridView1.CurrentRow.Cells(0).Value
        Try
            con.Open()
            sql = "SELECT * FROM petition_record WHERE petition_id = " & id & ""

            With cmd
                .Connection = con
                .CommandText = sql
                .ExecuteNonQuery()
            End With

            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            txtPet.Text = dt.Rows(0).Item("petition_num").ToString()
            cbolabel.Text = dt.Rows(0).Item("petition_label").ToString()
            year.Text = dt.Rows(0).Item("year").ToString()
            ra.Text = dt.Rows(0).Item("ra").ToString()
            txtDocOw.Text = dt.Rows(0).Item("doc_owner").ToString()
            txtNamePet.Text = dt.Rows(0).Item("name_of_petitioner").ToString()
            txtMun.Text = dt.Rows(0).Item("municipality").ToString()
            txtprov.Text = dt.Rows(0).Item("province").ToString()
            txtTypeDoc.Text = dt.Rows(0).Item("type_doc").ToString()
            txtfrom.Text = dt.Rows(0).Item("cert_from").ToString()
            txtto.Text = dt.Rows(0).Item("cert_to").ToString()
            txtyear.Text = dt.Rows(0).Item("year_final").ToString()

            If dt.Rows(0).Item("gender").ToString = "Male" Then
                rbMale.Checked = True
            Else
                rbFemale.Checked = True
            End If

            If dt.Rows(0).Item("certificate") = "Certificate Of Posting" Then
                cert_post.Checked = True
                txtfrom.Enabled = True
                txtto.Enabled = True
            Else
                txtfrom.Enabled = False
                txtto.Enabled = False
                cert_post.Checked = False
            End If


            If dt.Rows(0).Item("certificate_2") = "Authenticity" Then
                auth.Checked = True
            Else
                auth.Checked = False
            End If

            If dt.Rows(0).Item("certificate_3") = "Finality" Then
                fin.Checked = True
                txtyear.Text = dt.Rows(0).Item("year_final")
                txtyear.Enabled = True
            Else
                fin.Checked = False

                txtyear.Enabled = False
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            da.Dispose()
            dt.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rbMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        Try
            con.Open()
            sql = "UPDATE petition_record SET petition_label = @petition_label, petition_num = @pet_num,year = @year, ra = @ra ,doc_owner = @doc_owner ,gender = @gender ,name_of_petitioner = @name_of_pet ,type_doc = @type_doc,
            municipality = @mun ,province = @prov ,certificate = @certificate, cert_from = @cert_from, cert_to = @cert_to, certificate_2 = @certificate_2, certificate_3 = @certificate_3, year_final = @year_final WHERE petition_id = '" & id & "'"

            With cmd
                .CommandText = sql
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@petition_label", MySqlDbType.VarChar).Value = cbolabel.Text
                .Parameters.Add("@pet_num", MySqlDbType.VarChar).Value = txtPet.Text
                .Parameters.Add("@doc_owner", MySqlDbType.VarChar).Value = txtDocOw.Text
                .Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender
                .Parameters.Add("@name_of_pet", MySqlDbType.VarChar).Value = txtNamePet.Text
                .Parameters.Add("@type_doc", MySqlDbType.VarChar).Value = txtTypeDoc.Text
                .Parameters.Add("@mun", MySqlDbType.VarChar).Value = txtMun.Text
                .Parameters.Add("@prov", MySqlDbType.VarChar).Value = txtprov.Text
                .Parameters.Add("@ra", MySqlDbType.Int32).Value = ra.Text
                .Parameters.Add("@year", MySqlDbType.Int32).Value = year.Text
                '.Parameters.Add("@year_final", MySqlDbType.VarChar).Value = txtyear.Text
                .Parameters.Add("@certificate", MySqlDbType.VarChar).Value = cert
                .Parameters.Add("@cert_from", MySqlDbType.VarChar).Value = txtfrom.Text
                .Parameters.Add("@cert_to", MySqlDbType.VarChar).Value = txtto.Text
                .Parameters.Add("@certificate_2", MySqlDbType.VarChar).Value = autth
                .Parameters.Add("@certificate_3", MySqlDbType.VarChar).Value = finn
                .Parameters.Add("@year_final", MySqlDbType.VarChar).Value = txtyear.Text
                Dim res As String = .ExecuteNonQuery
                If res > 0 Then

                    For Each ctrl As Control In gbInsert.Controls
                        If ctrl.GetType Is GetType(TextBox) Then
                            ctrl.Text = ""
                        End If
                    Next
                    rbFemale.Checked = False
                    rbMale.Checked = False
                    auth.Checked = False
                    fin.Checked = False
                    cert_post.Checked = False
                    clear()
                    btnSave.Enabled = True
                    Button1.Enabled = False
                    btndelete.Enabled = False



                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try
        Call Add1_Load(sender, e)
        Me.Refresh()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            con.Open()
            sql = "DELETE FROM petition_record WHERE petition_id = @id"
            With cmd
                .Parameters.Clear()
                .CommandText = sql
                .Connection = con
                .Parameters.AddWithValue("@id", id)
                .ExecuteNonQuery()
            End With
            rbFemale.Checked = False
            rbMale.Checked = False
            auth.Checked = False
            fin.Checked = False
            cert_post.Checked = False
            clear()
            btnSave.Enabled = True
            Button1.Enabled = False
            btndelete.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
        Call Add1_Load(sender, e)
        Me.Refresh()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Imports System.IO.Stream
Imports System.IO
Public Class edit_form
    Public Shared edit_id As Integer

    Dim cert As String = ""
    Dim autth As String = ""
    Dim finn As String = ""
    Dim gender As String

    Private Sub Edit_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ms As MemoryStream
        Dim img As Byte()
        sql = "SELECT petition_id, petition_label, petition_num, year, ra, doc_owner, gender, name_of_petitioner, type_doc, 
                    municipality, province, certificate, cert_from, cert_to, certificate_2, certificate_3, year_final FROM petition_record WHERE  petition_id = '" & edit_id & "'"

        Try

            con.Open()
            With cmd
                .Parameters.Clear()
                .CommandText = sql
                .Connection = con
                .ExecuteNonQuery()

            End With

            da = New MySqlDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)

            cbolabel.Text = dt.Rows(0).Item("petition_label")
            txtPet.Text = dt.Rows(0).Item("petition_num")
            txtProv.Text = dt.Rows(0).Item("province")
            txtTypeDoc.Text = dt.Rows(0).Item("type_doc")
            txtMun.Text = dt.Rows(0).Item("municipality")
            txtNamePet.Text = dt.Rows(0).Item("name_of_petitioner")
            txtDocOw.Text = dt.Rows(0).Item("doc_owner")
            year.Text = dt.Rows(0).Item("year")
            ra.Text = dt.Rows(0).Item("ra")
            'txtyear.Text = dt.Rows(0).Item("year_final")
            txtfrom.Text = dt.Rows(0).Item("cert_from")
            txtto.Text = dt.Rows(0).Item("cert_to")
            If dt.Rows(0).Item("gender") = "Male" Then
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
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        da.Dispose()
        dt.Dispose()


    End Sub


    Private Sub TxtPet_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub TxtDocOw_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub TxtNamePet_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub TxtTypeDoc_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub TxtMun_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub TxtProv_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub RbMale_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub RbFemale_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub BtnInsert_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs)



    End Sub
    Sub edit()
        con.Open()
        sql = "UPDATE petition_record SET petition_label = @petition_label, petition_num = @pet_num,year = @year, ra = @ra ,doc_owner = @doc_owner ,gender = @gender ,name_of_petitioner = @name_of_pet ,type_doc = @type_doc,
            municipality = @mun ,province = @prov ,certificate = @certificate, cert_from = @cert_from, cert_to = @cert_to, certificate_2 = @certificate_2, certificate_3 = @certificate_3, year_final = @year_final WHERE petition_id = '" & edit_id & "'"

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
                MsgBox("Record Updated", MsgBoxStyle.Information, "Record Updated")


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




            End If
            con.Close()
            edit_id = 0
            Me.Close()

            SearchForm.ShowDialog()
        End With
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If rbMale.Checked = True Then
            gender = rbMale.Text
        Else
            gender = rbFemale.Text
        End If

        If cert_post.Checked = True Then
            cert = cert_post.Text
        End If

        If auth.Checked = True Then
            autth = auth.Text
        End If

        If fin.Checked = True Then
            finn = fin.Text
        End If


        Try

            edit()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'cmd.Dispose()


    End Sub

    Private Sub Txtyear_KeyPress(sender As Object, e As KeyPressEventArgs)
        'If Asc(e.KeyChar) <> 8 Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '        e.Handled = True
        '    End If
        'End If

    End Sub

    Private Sub Fin_MouseClick(sender As Object, e As MouseEventArgs) Handles fin.MouseClick
        If fin.Checked = True Then
            finn = fin.Text
            txtyear.Enabled = True
        Else
            txtyear.Enabled = False
            txtyear.Text = ""
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
            txtfrom.Text = ""
            txtto.Text = ""
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

    Private Sub Edit_form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'edit_id = ""
        'SearchForm.Show()
    End Sub

    Private Sub Edit_form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Me.Close()

    End Sub
End Class
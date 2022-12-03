Public Class frmAddCF
    Private Sub RadioButton2_MouseClick(sender As Object, e As MouseEventArgs)

        'add1.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub Rb_birth_MouseClick(sender As Object, e As MouseEventArgs)
        add1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Type_Document_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCFAddBirth_Click(sender As Object, e As EventArgs) Handles btnCFAddBirth.Click
        With add1
            .txtTypeDoc.Text = btnCFAddBirth.Text
            .txtPet.Text = Label1.Text
            .pet_num = Label1.Text
            .type_doc = btnCFAddBirth.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub BtnCFAddMarriage_Click(sender As Object, e As EventArgs) Handles btnCFAddMarriage.Click
        With add1
            .txtTypeDoc.Text = btnCFAddMarriage.Text
            .txtPet.Text = Label1.Text
            .pet_num = Label1.Text
            .type_doc = btnCFAddMarriage.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub BtnCFAddDeath_Click(sender As Object, e As EventArgs) Handles btnCFAddDeath.Click
        With add1
            .txtTypeDoc.Text = btnCFAddDeath.Text
            .txtPet.Text = Label1.Text
            .pet_num = Label1.Text
            .type_doc = btnCFAddDeath.Text
            .ShowDialog()
        End With
    End Sub
End Class
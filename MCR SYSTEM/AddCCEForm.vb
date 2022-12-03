Public Class frmAddCCE

    Public type As String

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        With add1
            .txtTypeDoc.Text = Button1.Text
            .txtPet.Text = Label1.Text
            .pet_num = Label1.Text
            .type_doc = Button1.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With add1
            .txtTypeDoc.Text = Button2.Text
            .txtPet.Text = Label1.Text
            .pet_num = Label1.Text
            .type_doc = Button2.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With add1
            .txtTypeDoc.Text = Button3.Text
            .txtPet.Text = Label1.Text
            .pet_num = Label1.Text
            .type_doc = Button3.Text
            .ShowDialog()
        End With
    End Sub
End Class
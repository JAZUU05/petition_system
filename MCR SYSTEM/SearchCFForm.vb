Public Class frmSearchCF
    Private Sub CFForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With SearchForm
            .txtSearch.Text = ""
            .type = Button1.Text
            .pet_num = Label1.Text
            .ShowDialog()
        End With
        'SearchForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'SearchForm.ShowDialog()
        With SearchForm
            .txtSearch.Text = ""
            .pet_num = Label1.Text
            .type = Button2.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'SearchForm.ShowDialog()
        With SearchForm
            .txtSearch.Text = ""
            .pet_num = Label1.Text
            .type = Button3.Text
            .ShowDialog()
        End With
    End Sub
End Class
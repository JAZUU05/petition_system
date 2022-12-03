Public Class frmSearchCCE
    Dim getSession As String
    Private Sub RadioButton2_MouseClick(sender As Object, e As MouseEventArgs)

        'add1.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub Rb_birth_MouseClick(sender As Object, e As MouseEventArgs)
        add1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Type_Document_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Text = "SEARCH PETITION " + Label1.Text
    End Sub

    Private Sub BtnSearchBirth_Click(sender As Object, e As EventArgs) Handles btnCCESearchBirth.Click
        With SearchForm
            .txtSearch.Text = ""
            .pet_num = Label1.Text
            .type = btnCCESearchBirth.Text
            .ShowDialog()
        End With
        'SearchForm.type = btnCCESearchBirth.Text
        'SearchForm.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub BtnCCESearchMarriage_Click(sender As Object, e As EventArgs) Handles btnCCESearchMarriage.Click
        With SearchForm
            .txtSearch.Text = ""
            .type = btnCCESearchMarriage.Text
            .pet_num = Label1.Text
            .ShowDialog()
        End With
        'SearchForm.type = btnCCESearchMarriage.Text
        'SearchForm.ShowDialog()
    End Sub

    Private Sub BtnCCESearchDeath_Click(sender As Object, e As EventArgs) Handles btnCCESearchDeath.Click
        With SearchForm
            .txtSearch.Text = ""
            .type = btnCCESearchDeath.Text
            .pet_num = Label1.Text
            .ShowDialog()
        End With
        'SearchForm.type = btnCCESearchDeath.Text
        'SearchForm.ShowDialog()
    End Sub
End Class
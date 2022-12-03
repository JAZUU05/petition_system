Public Class Form3
    Public id As String
    Public type As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'With Form2
        '    Me.Close()
        '    .petition_id = id
        '    .ShowDialog()
        'End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'With cfn
        '    Me.Close()
        '    .petition_id = id
        '    .ShowDialog()
        'End With
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If type = "CCE" Then
            Button1.Enabled = False
            btnSave.Enabled = True
        ElseIf type = "CFN" Then
            btnSave.Enabled = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'With cce_cfn
        '    Me.Close()
        '    .petition_id = id
        '    .ShowDialog()
        'End With
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub btncfn_Click(sender As Object, e As EventArgs) Handles btncfn.Click
        'With cfn
        '    Me.Close()
        '    .petition_id = id
        '    .ShowDialog()
        'End With
    End Sub

    Private Sub btncce_cfn_Click(sender As Object, e As EventArgs) Handles btncce_cfn.Click
        'With cce_cfn
        '    Me.Close()
        '    .petition_id = id
        '    .ShowDialog()
        'End With
    End Sub

    Private Sub BtnSave_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        With cfn
            Me.Close()
            .petition_id = id
            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        With cce_cfn
            Me.Close()
            .petition_id = id
            .ShowDialog()
        End With
    End Sub

    Private Sub BtnSave_Click_2(sender As Object, e As EventArgs) Handles btnSave.Click
        With Form2
            Me.Close()
            .petition_id = id
            .ShowDialog()
        End With
    End Sub
End Class
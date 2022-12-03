Public Class type_of_cert
    Public id As String
    Public type As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With cert_auth
            'Me.Close()
            '.petition_id = id
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With Form3
            'Me.Close()

            .ShowDialog()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With cert_posting
            'Me.Close()
            '.petition_id = id
            .ShowDialog()
        End With
    End Sub
End Class
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Label3.Text = Integer.Parse(TextBox1.Text) + Integer.Parse(TextBox2.Text)
        Catch ex As Exception
            Label3.Text = ex.Message
        End Try
    End Sub
End Class
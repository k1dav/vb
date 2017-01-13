Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "gotop" And TextBox2.Text = "1234" Then
            Dim f As New Form1
            f.Show()
        Else
            MessageBox.Show("Wrong ac or pwd")
        End If
    End Sub
End Class
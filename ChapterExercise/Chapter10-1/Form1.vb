Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "帳號"
        Label2.Text = "密碼"
        Button1.Text = "登入"
        Button2.Text = "離開"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "1234" And TextBox2.Text = "123") Then
            Process.Start("http://www.google.com.tw/")
        Else
            MessageBox.Show("帳號密碼輸入錯誤")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class

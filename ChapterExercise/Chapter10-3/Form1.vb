Public Class Form1
    Public Function s(ByVal n As Integer) As Single
        If (n = 1) Then
            Return 1
        Else
            Return 1 / n + s(n - 1)
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "答案為："
        Label2.Text = "計算 1+1/2+1/3+1/4+... 1/n 請輸入n"
        Button1.Text = "計算"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "答案為：" & s(TextBox1.Text)
    End Sub
End Class

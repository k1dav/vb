Public Class Form1
    Public Function s(ByVal n As Integer) As Integer
        If (n = 2) Then
            Return 2
        Else
            Return n * s(n - 2)
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "答案為："
        Label2.Text = "計算 2*4*6*8*...*n 請輸入n"
        Button1.Text = "計算"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "答案為：" & s(TextBox1.Text)
    End Sub
End Class

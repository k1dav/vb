Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text >= 100000) Then
            Label2.Text = "利率為：4%"
            Label3.Text = "會員等級為：A級會員"
        ElseIf (TextBox1.Text >= 50000) Then
            Label2.Text = "利率為：2%"
            Label3.Text = "會員等級為：B級會員"
        Else
            Label2.Text = "利率為：2%"
            Label3.Text = "會員等級為：C級會員"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "存款金額"
        Label2.Text = "利率為："
        Label3.Text = "會員等級為："
    End Sub
End Class

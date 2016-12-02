Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "你好"
        Label1.Text = "姓名"
        Button1.Text = "確定"
        RadioButton2.Text = "男"
        RadioButton1.Text = "女"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton2.Checked = True) Then
            MessageBox.Show(TextBox1.Text + "先生你好！")
        Else
            MessageBox.Show(TextBox1.Text + "小姐你好！")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
    End Sub
End Class

Public Class Form1
    Dim r As New Random()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "投注量"
        Label2.Text = "總數量"
        Button1.Text = "啟動"
        Button2.Text = "停止"
        Timer1.Enabled = False

        TextBox1.Text = "100"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text - NumericUpDown1.Value
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim s As String
        s = changephoto()
        PictureBox1.Image = New Bitmap(s)
        PictureBox1.ImageLocation = s
        s = changephoto()
        PictureBox2.Image = New Bitmap(s)
        PictureBox2.ImageLocation = s
        s = changephoto()
        PictureBox3.Image = New Bitmap(s)
        PictureBox3.ImageLocation = s

    End Sub

    Function changephoto() As String

        Dim n As Integer = r.Next(1, 5)
        If n = 1 Then
            Return "C:\Users\k1dav\Documents\GitHub\vb\images\0.jpg"
        ElseIf n = 2 Then
            Return "C:\Users\k1dav\Documents\GitHub\vb\images\1.jpg"
        ElseIf n = 3 Then
            Return "C:\Users\k1dav\Documents\GitHub\vb\images\2.jpg"
        Else
            Return "C:\Users\k1dav\Documents\GitHub\vb\images\3.jpg"
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        If PictureBox1.ImageLocation = PictureBox2.ImageLocation And PictureBox1.ImageLocation = PictureBox3.ImageLocation Then
            If PictureBox1.ImageLocation = "C:\Users\k1dav\Documents\GitHub\vb\images\0.jpg" Then
                TextBox1.Text = TextBox1.Text + NumericUpDown1.Value * 2
            ElseIf PictureBox1.ImageLocation = "C:\Users\k1dav\Documents\GitHub\vb\images\1.jpg" Then
                TextBox1.Text = TextBox1.Text + NumericUpDown1.Value * 10
            ElseIf PictureBox1.ImageLocation = "C:\Users\k1dav\Documents\GitHub\vb\images\2.jpg" Then
                TextBox1.Text = TextBox1.Text + NumericUpDown1.Value * 15
            ElseIf PictureBox1.ImageLocation = "C:\Users\k1dav\Documents\GitHub\vb\images\3.jpg" Then
                TextBox1.Text = TextBox1.Text + NumericUpDown1.Value * 20
            End If

        End If
    End Sub
End Class

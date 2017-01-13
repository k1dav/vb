Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label1.Text = "透明:" & TrackBar1.Value.ToString
        DisplayRGB()
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label2.Text = "紅色:" & TrackBar2.Value.ToString
        DisplayRGB()
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        Label3.Text = "綠色:" & TrackBar3.Value.ToString
        DisplayRGB()
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        Label4.Text = "藍色:" & TrackBar4.Value.ToString
        DisplayRGB()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Sub DisplayRGB()
        PictureBox1.BackColor = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value, TrackBar4.Value)
    End Sub
End Class

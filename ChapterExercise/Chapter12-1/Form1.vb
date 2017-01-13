Public Class Form1
    Dim counter As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If (counter = 0) Then
            PictureBox1.Image = New Bitmap("C:\Users\k1dav\Documents\GitHub\vb\images\RUNNER1.GIF")
            run()
        ElseIf (counter = 1) Then
            PictureBox1.Image = New Bitmap("C:\Users\k1dav\Documents\GitHub\vb\images\RUNNER2.GIF")
            run()
        ElseIf (counter = 2) Then
            PictureBox1.Image = New Bitmap("C:\Users\k1dav\Documents\GitHub\vb\images\RUNNER3.GIF")
            run()
        Else
            PictureBox1.Image = New Bitmap("C:\Users\k1dav\Documents\GitHub\vb\images\RUNNER4.GIF")
            run()
        End If
        counter = (counter + 1) Mod 4
    End Sub
    Sub run()
        PictureBox1.Left -= HScrollBar1.Value
        If PictureBox1.Left + PictureBox1.Width <= 0 Then
            PictureBox1.Left = Me.Width
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

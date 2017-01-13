Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Label2.Text = OpenFileDialog1.FileName()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inforeader As System.IO.FileInfo
        inforeader = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName())
        RichTextBox1.Text = "1.檔名" & OpenFileDialog1.SafeFileName & vbCrLf & "2.路徑" & OpenFileDialog1.FileName & vbCrLf & "3.檔案大小" & inforeader.Length
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class

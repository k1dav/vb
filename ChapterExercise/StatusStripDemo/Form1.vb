Public Class Form1
    ' 宣告 num 整數變數用來記錄目前的圖片索引編號，0表示第1張
    Dim num As Integer = 0

    ' 建立 photo 字串陣列用來存放照片的名稱
    ' 陣列元素索引範圍photo(0)~photo(4)
    Dim photo() As String = {"企鵝", "沙漠", "無尾熊", "菊花", "鬱金香"}

    ' 定義ShowPic()方法，可在PictureBox1顯示目前的圖片
    ' 在toolStripStatusLabel1顯示目前的圖片名稱
    Sub ShowPic()
        ' 在PictureBox1上顯示photo[num]陣列元素的圖檔
        PictureBox1.Image = New Bitmap(photo(num) & ".jpg")
        ToolStripStatusLabel1.Text = "圖片名稱：" & photo(num)
    End Sub
    '  表單載入時執行
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        ShowPic()   ' 呼叫ShowPic方法在pictureBox1顯示圖片
    End Sub
    ' 按 [第一張] 執行
    Private Sub 第一張ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 第一張ToolStripMenuItem.Click
        num = 0
        ShowPic()
    End Sub
    ' 按 [上一張] 執行
    Private Sub 上一張ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 上一張ToolStripMenuItem.Click
        num -= 1   ' num圖片索引編號減1，表示顯示上一張
        ' 若num圖片索引編號小於1，則另num由最後一張開始
        If num < 0 Then
            num = photo.GetUpperBound(0)
        End If
        ShowPic()
    End Sub
    ' 按 [下一張] 執行
    Private Sub 下一張ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 下一張ToolStripMenuItem.Click
        num += 1  ' num圖片索引編號加1，表示顯示下一張
        ' 若num圖片索引編號大於最後一張圖的索引編號
        ' 則另num為0，表示由第一張開始顯示
        If num > photo.GetUpperBound(0) Then
            num = 0
        End If
        ShowPic()
    End Sub
    ' 按 [最末張] 執行
    Private Sub 最末張ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 最末張ToolStripMenuItem.Click
        ' 另num由最後一張索引編號開始
        num = photo.GetUpperBound(0)
        ShowPic()
    End Sub

End Class

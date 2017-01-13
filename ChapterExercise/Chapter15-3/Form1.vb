Public Class Form1

    '  表單載入時執行
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "記事本 2.0版"
        ' 使FichTextBox1填滿整個表單
        RichTextBox1.Dock = DockStyle.Fill
        ' 使FontDialog1預設出現色彩下拉式清單
        FontDialog1.ShowColor = True
        ' 使ColorDialog1預設出現自訂色彩區段
        ColorDialog1.FullOpen = True
        OpenFileDialog1.Filter = "RTF格式(*.rtf)|*.rtf|Word文件(*.doc;docx)|*.doc;*.docx|所有檔案(*.*)|*.*"
        SaveFileDialog1.Filter = "RTF格式(*.rtf)|*.rtf|Word文件(*.doc;docx)|*.doc;*.docx|所有檔案(*.*)|*.*"
    End Sub

    '  執行功能表的 [字型] 指令時執行此事件處理程序
    Private Sub 字型ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字型ToolStripMenuItem.Click
        ' 判斷開啟字型對話方塊時是否按下 [確定] 鈕
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' 將字型對話方塊選取的字型樣式指定給RichTextBox1中選取文字
            RichTextBox1.SelectionFont = FontDialog1.Font
            ' 將字型對話方塊選取的色彩指定給RichTextBox1中選取的文字色彩(即前景色)
            RichTextBox1.SelectionColor = FontDialog1.Color
        End If
    End Sub

    '  執行功能表的 [色彩/前景色] 指令時執行此事件處理程序
    Private Sub 前景色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 前景色ToolStripMenuItem.Click
        ' 判斷開啟色彩對話方塊時是否按下 [確定] 鈕
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' 將色彩對話方塊選取的色彩指定給RichTextBox1中選取文字的前景色
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    ' 執行功能表的 [色彩/背景色] 指令時執行此事件處理程序
    Private Sub 背景色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 背景色ToolStripMenuItem.Click
        ' 判斷開啟色彩對話方塊時是否沒有按下 [消取] 鈕
        If ColorDialog1.ShowDialog() <> DialogResult.Cancel Then
            ' 將色彩對話方塊選取的色彩指定給RichTextBox1中選取文字的背景色
            RichTextBox1.SelectionBackColor = ColorDialog1.Color
        End If
    End Sub

    '執行功能表的 [檔案/開啟舊檔] 指令時執行此事件處理程序
    Private Sub 開啟舊檔ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開啟舊檔ToolStripMenuItem.Click
        ' 打開開啟舊檔對話方塊並判斷是否按下 [確定] 鈕 
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' 使用RichTextBox1的LoadFile方法載入開啟舊檔對話方塊指定的檔案
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    ' 執行功能表的 [檔案/儲存檔案] 指令時執行此事件處理程序
    Private Sub 儲存檔案ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 儲存檔案ToolStripMenuItem.Click
        ' 打開另存新增對話方塊並判斷是否按下 [確定] 鈕
        SaveFileDialog1.FileName = OpenFileDialog1.FileName
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' 使用RichTextBox1的SaveFile方法將RichTextBox1內的資料
            ' 存入另存新檔對話方塊指定的檔案內
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    ' 執行功能表的 [檔案/清除] 指令時執行此事件處理程序
    Private Sub 清除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 清除ToolStripMenuItem.Click
        RichTextBox1.Text = ""
    End Sub

    ' 執行功能表的 [檔案/結束] 指令時執行此事件處理程序
    Private Sub 結束ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 結束ToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class

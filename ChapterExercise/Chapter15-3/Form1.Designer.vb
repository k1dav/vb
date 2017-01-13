<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.檔案ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開啟舊檔ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.儲存檔案ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.結束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字型ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.色彩ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.前景色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.背景色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.檔案ToolStripMenuItem, Me.字型ToolStripMenuItem, Me.色彩ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(232, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "menuStrip1"
        '
        '檔案ToolStripMenuItem
        '
        Me.檔案ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開啟舊檔ToolStripMenuItem, Me.儲存檔案ToolStripMenuItem, Me.清除ToolStripMenuItem, Me.結束ToolStripMenuItem})
        Me.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem"
        Me.檔案ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.檔案ToolStripMenuItem.Text = "檔案"
        '
        '開啟舊檔ToolStripMenuItem
        '
        Me.開啟舊檔ToolStripMenuItem.Name = "開啟舊檔ToolStripMenuItem"
        Me.開啟舊檔ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.開啟舊檔ToolStripMenuItem.Text = "開啟舊檔"
        '
        '儲存檔案ToolStripMenuItem
        '
        Me.儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem"
        Me.儲存檔案ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.儲存檔案ToolStripMenuItem.Text = "儲存檔案"
        '
        '清除ToolStripMenuItem
        '
        Me.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem"
        Me.清除ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.清除ToolStripMenuItem.Text = "清除"
        '
        '結束ToolStripMenuItem
        '
        Me.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem"
        Me.結束ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.結束ToolStripMenuItem.Text = "結束"
        '
        '字型ToolStripMenuItem
        '
        Me.字型ToolStripMenuItem.Name = "字型ToolStripMenuItem"
        Me.字型ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.字型ToolStripMenuItem.Text = "字型"
        '
        '色彩ToolStripMenuItem
        '
        Me.色彩ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.前景色ToolStripMenuItem, Me.背景色ToolStripMenuItem})
        Me.色彩ToolStripMenuItem.Name = "色彩ToolStripMenuItem"
        Me.色彩ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.色彩ToolStripMenuItem.Text = "色彩"
        '
        '前景色ToolStripMenuItem
        '
        Me.前景色ToolStripMenuItem.Name = "前景色ToolStripMenuItem"
        Me.前景色ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.前景色ToolStripMenuItem.Text = "前景色"
        '
        '背景色ToolStripMenuItem
        '
        Me.背景色ToolStripMenuItem.Name = "背景色ToolStripMenuItem"
        Me.背景色ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.背景色ToolStripMenuItem.Text = "背景色"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(41, 51)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 188)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Private WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Private WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents 字型ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents 色彩ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents 前景色ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents 背景色ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents 檔案ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 開啟舊檔ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 儲存檔案ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 結束ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class

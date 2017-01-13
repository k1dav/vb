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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.檔案FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開檔ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.存檔ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.結束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.項目符號ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboSize = New System.Windows.Forms.ToolStripComboBox()
        Me.cboFontColor = New System.Windows.Forms.ToolStripComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.檔案FToolStripMenuItem, Me.項目符號ToolStripMenuItem, Me.cboSize, Me.cboFontColor})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(415, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '檔案FToolStripMenuItem
        '
        Me.檔案FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開檔ToolStripMenuItem, Me.存檔ToolStripMenuItem, Me.清除ToolStripMenuItem, Me.結束ToolStripMenuItem})
        Me.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem"
        Me.檔案FToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.檔案FToolStripMenuItem.Text = "檔案(F)"
        '
        '開檔ToolStripMenuItem
        '
        Me.開檔ToolStripMenuItem.Name = "開檔ToolStripMenuItem"
        Me.開檔ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.開檔ToolStripMenuItem.Text = "開檔"
        '
        '存檔ToolStripMenuItem
        '
        Me.存檔ToolStripMenuItem.Name = "存檔ToolStripMenuItem"
        Me.存檔ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.存檔ToolStripMenuItem.Text = "存檔"
        '
        '清除ToolStripMenuItem
        '
        Me.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem"
        Me.清除ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.清除ToolStripMenuItem.Text = "清除"
        '
        '結束ToolStripMenuItem
        '
        Me.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem"
        Me.結束ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.結束ToolStripMenuItem.Text = "結束"
        '
        '項目符號ToolStripMenuItem
        '
        Me.項目符號ToolStripMenuItem.Name = "項目符號ToolStripMenuItem"
        Me.項目符號ToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.項目符號ToolStripMenuItem.Text = "項目符號"
        '
        'cboSize
        '
        Me.cboSize.Items.AddRange(New Object() {"9", "10", "12", "14", "16"})
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(121, 24)
        Me.cboSize.Text = "字型大小"
        '
        'cboFontColor
        '
        Me.cboFontColor.Items.AddRange(New Object() {"黑", "紅", "綠", "藍"})
        Me.cboFontColor.Name = "cboFontColor"
        Me.cboFontColor.Size = New System.Drawing.Size(121, 24)
        Me.cboFontColor.Text = "字型色彩"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(283, 85)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 193)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 檔案FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 開檔ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 存檔ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 結束ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 項目符號ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cboFontColor As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox

End Class

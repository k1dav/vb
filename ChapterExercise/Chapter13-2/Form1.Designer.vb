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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.開檔ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.存檔ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.清除ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.結束ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.紅ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.黑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.綠ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.藍ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.檔案FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開檔ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.存檔ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.結束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.項目符號ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboSize = New System.Windows.Forms.ToolStripComboBox()
        Me.cboFontColor = New System.Windows.Forms.ToolStripComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(377, 106)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(132, 119)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripStatusLabel1, Me.ToolStripDropDownButton2, Me.ToolStripStatusLabel2, Me.ToolStripDropDownButton3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 276)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(647, 26)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.結束ToolStripMenuItem1, Me.清除ToolStripMenuItem1, Me.存檔ToolStripMenuItem1, Me.開檔ToolStripMenuItem1})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(34, 24)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(69, 21)
        Me.ToolStripStatusLabel1.Text = "字型大小"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem4, Me.ToolStripMenuItem3, Me.ToolStripMenuItem2})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(34, 24)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.藍ToolStripMenuItem, Me.綠ToolStripMenuItem, Me.黑ToolStripMenuItem, Me.紅ToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(34, 24)
        Me.ToolStripDropDownButton3.Text = "ToolStripDropDownButton3"
        '
        '開檔ToolStripMenuItem1
        '
        Me.開檔ToolStripMenuItem1.Name = "開檔ToolStripMenuItem1"
        Me.開檔ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.開檔ToolStripMenuItem1.Text = "開檔"
        '
        '存檔ToolStripMenuItem1
        '
        Me.存檔ToolStripMenuItem1.Name = "存檔ToolStripMenuItem1"
        Me.存檔ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.存檔ToolStripMenuItem1.Text = "存檔"
        '
        '清除ToolStripMenuItem1
        '
        Me.清除ToolStripMenuItem1.Name = "清除ToolStripMenuItem1"
        Me.清除ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.清除ToolStripMenuItem1.Text = "清除"
        '
        '結束ToolStripMenuItem1
        '
        Me.結束ToolStripMenuItem1.Name = "結束ToolStripMenuItem1"
        Me.結束ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.結束ToolStripMenuItem1.Text = "結束"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(39, 21)
        Me.ToolStripStatusLabel2.Text = "色彩"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(181, 26)
        Me.ToolStripMenuItem2.Text = "9"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(181, 26)
        Me.ToolStripMenuItem3.Text = "10"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(181, 26)
        Me.ToolStripMenuItem4.Text = "11"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(181, 26)
        Me.ToolStripMenuItem5.Text = "12"
        '
        '紅ToolStripMenuItem
        '
        Me.紅ToolStripMenuItem.Name = "紅ToolStripMenuItem"
        Me.紅ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.紅ToolStripMenuItem.Text = "紅"
        '
        '黑ToolStripMenuItem
        '
        Me.黑ToolStripMenuItem.Name = "黑ToolStripMenuItem"
        Me.黑ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.黑ToolStripMenuItem.Text = "黑"
        '
        '綠ToolStripMenuItem
        '
        Me.綠ToolStripMenuItem.Name = "綠ToolStripMenuItem"
        Me.綠ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.綠ToolStripMenuItem.Text = "綠"
        '
        '藍ToolStripMenuItem
        '
        Me.藍ToolStripMenuItem.Name = "藍ToolStripMenuItem"
        Me.藍ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.藍ToolStripMenuItem.Text = "藍"
        '
        '檔案FToolStripMenuItem
        '
        Me.檔案FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開檔ToolStripMenuItem, Me.存檔ToolStripMenuItem, Me.清除ToolStripMenuItem, Me.結束ToolStripMenuItem})
        Me.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem"
        Me.檔案FToolStripMenuItem.Size = New System.Drawing.Size(69, 27)
        Me.檔案FToolStripMenuItem.Text = "檔案(F)"
        '
        '開檔ToolStripMenuItem
        '
        Me.開檔ToolStripMenuItem.Name = "開檔ToolStripMenuItem"
        Me.開檔ToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.開檔ToolStripMenuItem.Text = "開檔"
        '
        '存檔ToolStripMenuItem
        '
        Me.存檔ToolStripMenuItem.Name = "存檔ToolStripMenuItem"
        Me.存檔ToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.存檔ToolStripMenuItem.Text = "存檔"
        '
        '清除ToolStripMenuItem
        '
        Me.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem"
        Me.清除ToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.清除ToolStripMenuItem.Text = "清除"
        '
        '結束ToolStripMenuItem
        '
        Me.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem"
        Me.結束ToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.結束ToolStripMenuItem.Text = "結束"
        '
        '項目符號ToolStripMenuItem
        '
        Me.項目符號ToolStripMenuItem.Name = "項目符號ToolStripMenuItem"
        Me.項目符號ToolStripMenuItem.Size = New System.Drawing.Size(81, 27)
        Me.項目符號ToolStripMenuItem.Text = "項目符號"
        '
        'cboSize
        '
        Me.cboSize.Items.AddRange(New Object() {"9", "10", "12", "14", "16"})
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(160, 27)
        Me.cboSize.Text = "字型大小"
        '
        'cboFontColor
        '
        Me.cboFontColor.Items.AddRange(New Object() {"黑", "紅", "綠", "藍"})
        Me.cboFontColor.Name = "cboFontColor"
        Me.cboFontColor.Size = New System.Drawing.Size(160, 27)
        Me.cboFontColor.Text = "字型色彩"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.檔案FToolStripMenuItem, Me.項目符號ToolStripMenuItem, Me.cboSize, Me.cboFontColor})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(647, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 302)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents 結束ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 清除ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 存檔ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 開檔ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents 藍ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 綠ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 黑ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 紅ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 檔案FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 開檔ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 存檔ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 清除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 結束ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 項目符號ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboSize As ToolStripComboBox
    Friend WithEvents cboFontColor As ToolStripComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
End Class

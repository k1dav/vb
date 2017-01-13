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
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.字型ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新細明體ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.標楷體ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.顏色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.前景ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.白色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.淺藍色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.黃色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.背景ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.白色ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.淺藍色ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.黃色ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.字型ToolStripMenuItem, Me.顏色ToolStripMenuItem, Me.ToolStripComboBox1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(470, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '字型ToolStripMenuItem
        '
        Me.字型ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新細明體ToolStripMenuItem, Me.標楷體ToolStripMenuItem})
        Me.字型ToolStripMenuItem.Name = "字型ToolStripMenuItem"
        Me.字型ToolStripMenuItem.Size = New System.Drawing.Size(51, 27)
        Me.字型ToolStripMenuItem.Text = "字型"
        '
        '新細明體ToolStripMenuItem
        '
        Me.新細明體ToolStripMenuItem.Name = "新細明體ToolStripMenuItem"
        Me.新細明體ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.新細明體ToolStripMenuItem.Text = "新細明體"
        '
        '標楷體ToolStripMenuItem
        '
        Me.標楷體ToolStripMenuItem.Name = "標楷體ToolStripMenuItem"
        Me.標楷體ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.標楷體ToolStripMenuItem.Text = "標楷體"
        '
        '顏色ToolStripMenuItem
        '
        Me.顏色ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.前景ToolStripMenuItem, Me.背景ToolStripMenuItem})
        Me.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem"
        Me.顏色ToolStripMenuItem.Size = New System.Drawing.Size(51, 27)
        Me.顏色ToolStripMenuItem.Text = "顏色"
        '
        '前景ToolStripMenuItem
        '
        Me.前景ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.白色ToolStripMenuItem, Me.淺藍色ToolStripMenuItem, Me.黃色ToolStripMenuItem})
        Me.前景ToolStripMenuItem.Name = "前景ToolStripMenuItem"
        Me.前景ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.前景ToolStripMenuItem.Text = "前景"
        '
        '白色ToolStripMenuItem
        '
        Me.白色ToolStripMenuItem.Name = "白色ToolStripMenuItem"
        Me.白色ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.白色ToolStripMenuItem.Text = "白色"
        '
        '淺藍色ToolStripMenuItem
        '
        Me.淺藍色ToolStripMenuItem.Name = "淺藍色ToolStripMenuItem"
        Me.淺藍色ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.淺藍色ToolStripMenuItem.Text = "淺藍色"
        '
        '黃色ToolStripMenuItem
        '
        Me.黃色ToolStripMenuItem.Name = "黃色ToolStripMenuItem"
        Me.黃色ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.黃色ToolStripMenuItem.Text = "黃色"
        '
        '背景ToolStripMenuItem
        '
        Me.背景ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.白色ToolStripMenuItem1, Me.淺藍色ToolStripMenuItem1, Me.黃色ToolStripMenuItem1})
        Me.背景ToolStripMenuItem.Name = "背景ToolStripMenuItem"
        Me.背景ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.背景ToolStripMenuItem.Text = "背景"
        '
        '白色ToolStripMenuItem1
        '
        Me.白色ToolStripMenuItem1.Name = "白色ToolStripMenuItem1"
        Me.白色ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.白色ToolStripMenuItem1.Text = "白色"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"12", "24", "48"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 27)
        '
        '淺藍色ToolStripMenuItem1
        '
        Me.淺藍色ToolStripMenuItem1.Name = "淺藍色ToolStripMenuItem1"
        Me.淺藍色ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.淺藍色ToolStripMenuItem1.Text = "淺藍色"
        '
        '黃色ToolStripMenuItem1
        '
        Me.黃色ToolStripMenuItem1.Name = "黃色ToolStripMenuItem1"
        Me.黃色ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.黃色ToolStripMenuItem1.Text = "黃色"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "程式設計經典"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 356)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 字型ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新細明體ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 標楷體ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 顏色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 前景ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 白色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 淺藍色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 黃色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 背景ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 白色ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents 淺藍色ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 黃色ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class

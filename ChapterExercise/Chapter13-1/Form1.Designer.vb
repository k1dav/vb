﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.最末張ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.下一張ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上一張ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.第一張ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.第一張ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.上一張ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.下一張ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.最末張ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 252)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(408, 26)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(161, 21)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.最末張ToolStripMenuItem, Me.下一張ToolStripMenuItem, Me.上一張ToolStripMenuItem, Me.第一張ToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.StatusStripDemo.My.Resources.Resources.OPEN
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(34, 24)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        '最末張ToolStripMenuItem
        '
        Me.最末張ToolStripMenuItem.Name = "最末張ToolStripMenuItem"
        Me.最末張ToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.最末張ToolStripMenuItem.Text = "最末張"
        '
        '下一張ToolStripMenuItem
        '
        Me.下一張ToolStripMenuItem.Name = "下一張ToolStripMenuItem"
        Me.下一張ToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.下一張ToolStripMenuItem.Text = "下一張"
        '
        '上一張ToolStripMenuItem
        '
        Me.上一張ToolStripMenuItem.Name = "上一張ToolStripMenuItem"
        Me.上一張ToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.上一張ToolStripMenuItem.Text = "上一張"
        '
        '第一張ToolStripMenuItem
        '
        Me.第一張ToolStripMenuItem.Name = "第一張ToolStripMenuItem"
        Me.第一張ToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.第一張ToolStripMenuItem.Text = "第一張"
        '
        'PictureBox1
        '
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(376, 218)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.第一張ToolStripMenuItem1, Me.上一張ToolStripMenuItem1, Me.下一張ToolStripMenuItem1, Me.最末張ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(130, 108)
        '
        '第一張ToolStripMenuItem1
        '
        Me.第一張ToolStripMenuItem1.Name = "第一張ToolStripMenuItem1"
        Me.第一張ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.第一張ToolStripMenuItem1.Text = "第一張"
        '
        '上一張ToolStripMenuItem1
        '
        Me.上一張ToolStripMenuItem1.Name = "上一張ToolStripMenuItem1"
        Me.上一張ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.上一張ToolStripMenuItem1.Text = "上一張"
        '
        '下一張ToolStripMenuItem1
        '
        Me.下一張ToolStripMenuItem1.Name = "下一張ToolStripMenuItem1"
        Me.下一張ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.下一張ToolStripMenuItem1.Text = "下一張"
        '
        '最末張ToolStripMenuItem1
        '
        Me.最末張ToolStripMenuItem1.Name = "最末張ToolStripMenuItem1"
        Me.最末張ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.最末張ToolStripMenuItem1.Text = "最末張"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 278)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents 最末張ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 下一張ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 上一張ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 第一張ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 第一張ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 上一張ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 下一張ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 最末張ToolStripMenuItem1 As ToolStripMenuItem
End Class
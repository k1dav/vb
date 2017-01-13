Public Class Form1
    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.Click

    End Sub

    Private Sub 綠色ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 新細明體ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新細明體ToolStripMenuItem.Click
        Label1.Font = New Font("新細明體", Label1.Font.Size)
    End Sub

    Private Sub 標楷體ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 標楷體ToolStripMenuItem.Click
        Label1.Font = New Font("標楷體", Label1.Font.Size)
    End Sub

    Private Sub 白色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 白色ToolStripMenuItem.Click
        Label1.ForeColor = Color.White
    End Sub

    Private Sub 淺藍色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 淺藍色ToolStripMenuItem.Click
        Label1.ForeColor = Color.AliceBlue
    End Sub

    Private Sub 黃色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 黃色ToolStripMenuItem.Click
        Label1.ForeColor = Color.Yellow
    End Sub

    Private Sub 白色ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 白色ToolStripMenuItem1.Click
        Label1.BackColor = Color.White
    End Sub

    Private Sub 淺藍色ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 淺藍色ToolStripMenuItem1.Click
        Label1.BackColor = Color.AliceBlue
    End Sub

    Private Sub 黃色ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 黃色ToolStripMenuItem1.Click
        Label1.BackColor = Color.Yellow
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Label1.Font = New Font(Label1.Font.Style, ToolStripComboBox1.Text)
    End Sub
End Class

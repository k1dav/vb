Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "DVD List"
        Label2.Text = "Rented List"
        Button1.Text = ">>"
        Button2.Text = "<<"
        ListBox1.Items.Add("葉問2")
        ListBox1.Items.Add("鋼鐵人2")
        ListBox1.Items.Add("慾望城市2")
        ListBox1.Items.Add("史瑞克4")
        ListBox1.Items.Add("火影忍者")
        ListBox1.Items.Add("降世神通")
        ListBox1.Items.Add("惡夜特警隊")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.Items.Add(ListBox1.SelectedItem())
        ListBox1.Items.Remove(ListBox1.SelectedItem())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add(ListBox2.SelectedItem())
        ListBox2.Items.Remove(ListBox2.SelectedItem())
    End Sub
End Class

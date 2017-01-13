Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "類別"
        ComboBox1.Items.Add("動作")
        ComboBox1.Items.Add("布袋戲")
        ComboBox1.Items.Add("卡通")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CheckedListBox1.Items.Clear()
        If ComboBox1.Text = "動作" Then
            CheckedListBox1.Items.Add("葉問1")
            CheckedListBox1.Items.Add("葉問2")
            CheckedListBox1.Items.Add("龍潭虎穴")
            CheckedListBox1.Items.Add("一刀傾域")
        ElseIf ComboBox1.Text = "布袋戲" Then
            CheckedListBox1.Items.Add("霹靂神州")
            CheckedListBox1.Items.Add("霹靂神州II")
            CheckedListBox1.Items.Add("霹靂神州III")
            CheckedListBox1.Items.Add("霹靂天啟")
            CheckedListBox1.Items.Add("霹靂IV")
        ElseIf ComboBox1.Text = "卡通" Then
            CheckedListBox1.Items.Add("Dora")
            CheckedListBox1.Items.Add("YOYOMAN")
            CheckedListBox1.Items.Add("多啦A夢")
            CheckedListBox1.Items.Add("火影忍首")
        End If
    End Sub
End Class

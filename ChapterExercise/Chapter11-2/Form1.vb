Public Class Form1
    Dim f1 As FontStyle
    Dim f2 As FontStyle
    Dim f3 As FontStyle
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "字型"
        Label2.Text = "顏色"
        GroupBox1.Text = "樣式"
        ComboBox1.Text = "新細明體"
        ComboBox1.Items.Add("標楷體")
        Dim color() As String = {"紅色", "橘色", "黃色", "綠色"}
        ListBox1.Items.AddRange(color)
        CheckBox1.Text = "粗體"
        CheckBox2.Text = "斜體"
        CheckBox3.Text = "底線"
        CheckBox4.Text = "正常"
        Label3.Text = "測試用"
        Label3.Font = New Font("新細明體", 24)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MessageBox.Show(ComboBox1.Text)
        Label3.Font = New Font(ComboBox1.Text, 24)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If (ListBox1.Text = "紅色") Then
            Label3.ForeColor = Color.Red
        ElseIf (ListBox1.Text = "橘色") Then
            Label3.ForeColor = Color.Orange
        ElseIf (ListBox1.Text = "黃色") Then
            Label3.ForeColor = Color.Yellow
        ElseIf (ListBox1.Text = "綠色") Then
            Label3.ForeColor = Color.Green
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            f1 = FontStyle.Bold
        Else
            f1 = FontStyle.Regular
        End If
        Label3.Font = New Font(Label3.Text, 24, f1 Or f2 Or f3)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = True) Then
            f2 = FontStyle.Italic
        Else
            f2 = FontStyle.Regular
        End If
        Label3.Font = New Font(Label3.Text, 24, f1 Or f2 Or f3)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked = True) Then
            f3 = FontStyle.Underline
        Else
            f3 = FontStyle.Regular
        End If
        Label3.Font = New Font(Label3.Text, 24, f1 Or f2 Or f3)
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If (CheckBox4.Checked = True) Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            Label3.Font = New Font(Label3.Text, 24)
        Else
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            Label3.Font = New Font(Label3.Text, 24, f1 Or f2 Or f3)
        End If

    End Sub
End Class

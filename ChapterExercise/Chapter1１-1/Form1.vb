Public Class Form1
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
        RadioButton1.Text = "粗體"
        RadioButton2.Text = "斜體"
        RadioButton3.Text = "底線"
        RadioButton4.Text = "正常"
        Label3.Text = "測試用"
        Label3.Font = New Font("新細明體", 24)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MessageBox.Show(ComboBox1.Text)
        Label3.Font = New Font(ComboBox1.Text, 24)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If (RadioButton1.Checked = True) Then
            Label3.Font = New Font(ComboBox1.Text, 24, FontStyle.Bold)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked = True) Then
            Label3.Font = New Font(ComboBox1.Text, 24, FontStyle.Italic)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If (RadioButton3.Checked = True) Then
            Label3.Font = New Font(ComboBox1.Text, 24, FontStyle.Underline)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If (RadioButton4.Checked = True) Then
            Label3.Font = New Font(ComboBox1.Text, 24)
        End If
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
End Class

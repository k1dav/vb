Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text="姓名"
        Label2.Text="產品"
        GroupBox1.Text="付款方式"
        Dim p() As String = {"Ps2", "PSP", "XBOX"}
        CheckedListBox1.Items.AddRange(p)
        Button1.Text = "確定"
        RadioButton1.Text = "ATM"
        RadioButton2.Text = "貨到付款"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = TextBox1.Text + "你好，你購買了"
        For index As Integer = 0 To CheckedListBox1.Items.Count - 1
            If (CheckedListBox1.GetItemChecked(index)) Then
                Label3.Text = Label3.Text + CheckedListBox1.Items(index).ToString() + "， "
            End If
        Next
        If (RadioButton1.Checked = True) Then
            Label3.Text = Label3.Text + "付款方式為ATM"
        End If
        If (RadioButton2.Checked = True) Then
            Label3.Text = Label3.Text + "付款方式為貨到付款"
        End If

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class

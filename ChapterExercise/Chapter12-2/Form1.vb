Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Name"
        Label2.Text = "Product"
        Label4.Text = "Delivery Date"
        Label5.Text = ""

        CheckedListBox1.Items.Add("XBOX 360")
        CheckedListBox1.Items.Add("PSP")
        CheckedListBox1.Items.Add("PS2")
        GroupBox1.Text = "Payment"
        RadioButton1.Text = "貨到付款"
        RadioButton2.Text = "ATM"
        DateTimePicker1.MinDate = DateTime.Today
        Button1.Text = "Submit"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = TextBox1.Text & "你好，你買了"
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(i) Then
                Label5.Text = Label5.Text & CheckedListBox1.Items(i).ToString & " "
            End If
        Next
        Label5.Text = Label5.Text & "付款方式為"
        If RadioButton1.Checked Then
            Label5.Text = Label5.Text & "貨到付款" & vbCrLf
        Else
            Label5.Text = Label5.Text & "ATM" & vbCrLf
        End If
        Label5.Text = Label5.Text & "產品於" & DateTimePicker1.Value.ToShortDateString & "送達，謝謝"
    End Sub


    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class

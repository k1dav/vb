Public Class Form1
    Dim pid() As String = {"A001", "A002", "A003", "A004", "A005"}
    Dim pname() As String = {"XBOX", "PC", "PSP", "PS2", "PS4"}
    Dim price() As Integer = {10, 20, 30, 40, 50}
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If TextBox1.TextLength < 4 Then
            If TextBox1.SelectionStart = 0 Then
                Dim s As String = e.KeyChar.ToString.ToUpper()
                If s > "Z" Or s < "A" Then
                    e.Handled = True
                End If

            Else
                If e.KeyChar > "9" Or e.KeyChar < "0" Then
                    e.Handled = True
                End If

            End If
        Else
            If e.KeyChar <> vbBack Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pid.Contains(TextBox1.Text) Then
            Dim s As Integer = Array.IndexOf(pid, TextBox1.Text)
            Label2.Text = pname(s) & "單價" & price(s)
        Else
            Label2.Text = "無產品編號" & TextBox1.Text.ToString & "產品"
        End If

    End Sub
End Class

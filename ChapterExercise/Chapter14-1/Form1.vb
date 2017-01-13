Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_DockChanged(sender As Object, e As EventArgs) Handles Button1.DockChanged

    End Sub

    Private Sub Button1_DragDrop(sender As Object, e As DragEventArgs) Handles Button1.DragDrop


    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown

    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        If e.Button = MouseButtons.Left Then
            Button1.Left = Button1.Left + e.X
            Button1.Top = Button1.Top + e.Y

        End If

    End Sub
End Class

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'Database1DataSet.Table' 資料表。您可以視需要進行移動或移除。
        Me.TableTableAdapter.Fill(Me.Database1DataSet.Table)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TableTableAdapter.Update(Me.Database1DataSet.Table)
    End Sub
End Class

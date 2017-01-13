Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim cnStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;" &
                "AttachDbFilename=|DataDirectory|ch17DB.mdf;" &
                "Integrated Security=True;“
    Sub showdata()
        Using cn As New SqlConnection
            cn.ConnectionString = cnStr
            Dim daBook As New SqlDataAdapter("SELECT * FROM 書籍 ORDER BY 書號 DESC", cn)
            Dim ds As New DataSet()
            daBook.Fill(ds, "書籍")
            DataGridView1.DataSource = ds.Tables("書籍")
        End Using
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using cn As New SqlConnection
            cn.ConnectionString = cnStr
            cn.Open()
            'Dim sqlstr As String = "INSERT INTO 書籍(書號,書名,單價,數量) VALUES('" & TextBox1.Text.Replace("'", "''") & "','" & TextBox2.Text.Replace("'", "''") & "'," & Val(TextBox3.Text) & "," & Val(TextBox4.Text) & ")"
            Dim sqlstr As String = "INSERT INTO 書籍(書號,書名,單價,數量)" & "VALUES(@id,@name,@price,@q)"
            Dim cmd As New SqlCommand(sqlstr, cn)
            cmd.Parameters.Add(New SqlParameter("@id", SqlDbType.NVarChar))
            cmd.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar))
            cmd.Parameters.Add(New SqlParameter("@price", SqlDbType.Int))
            cmd.Parameters.Add(New SqlParameter("@q", SqlDbType.Int))
            cmd.Parameters("@id").Value = TextBox1.Text
            cmd.Parameters("@name").Value = TextBox2.Text
            cmd.Parameters("@price").Value = TextBox3.Text
            cmd.Parameters("@q").Value = TextBox4.Text
            cmd.ExecuteNonQuery()
        End Using
        showdata()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using cn As New SqlConnection
            cn.ConnectionString = cnStr
            cn.Open()
            'Dim sqlstr As String = "UPDATE 書籍 SET 書名 = '" & TextBox2.Text.Replace("'", "''") & "',單價='" & Val(TextBox3.Text) & " ',數量=" & Val(TextBox4.Text) & "WHERE 書號 = " & Val(TextBox1.Text) & ""
            Dim sqlstr As String = "UPDATE 書籍 SET 書名 = @name ,單價=@price,數量=@q WHERE 書號=@id"
            Dim cmd As New SqlCommand(sqlstr, cn)
            cmd.Parameters.Add(New SqlParameter("@id", SqlDbType.NVarChar))
            cmd.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar))
            cmd.Parameters.Add(New SqlParameter("@price", SqlDbType.Int))
            cmd.Parameters.Add(New SqlParameter("@q", SqlDbType.Int))
            cmd.Parameters("@id").Value = TextBox1.Text
            cmd.Parameters("@name").Value = TextBox2.Text
            cmd.Parameters("@price").Value = TextBox3.Text
            cmd.Parameters("@q").Value = TextBox4.Text
            cmd.ExecuteNonQuery()
        End Using
        showdata()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button4.Click
        Using cn As New SqlConnection
            cn.ConnectionString = cnStr
            cn.Open()
            Dim sqlstr As String = "SELECT * FROM 書籍 WHERE (書名 LIKE @id)"
            Dim cmd As New SqlCommand(sqlstr, cn)
            cmd.Parameters.Add(New SqlParameter("@id", SqlDbType.NVarChar))
            cmd.Parameters("@id").Value = "%" & TextBox2.Text & "%"

            Dim daBook As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (daBook.Fill(ds, "書籍")) Then
                DataGridView1.DataSource = ds.Tables("書籍")
            Else
                DataGridView1.DataSource = ""
            End If


        End Using
    End Sub
End Class

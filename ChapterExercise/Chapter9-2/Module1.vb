Imports System.IO
Module Module1

    Sub Main()
        Dim hit(6) As Integer
        Dim r As New Random
        Dim fname As FileInfo
        Dim sw As StreamWriter
        Try
            Console.WriteLine("請輸入輸出檔案位置")
            fname = New FileInfo(Console.ReadLine())
            sw = fname.AppendText()
            sw.WriteLine("開獎號碼" + vbTab + vbTab + vbTab + vbTab + vbTab + "特別號")
        Catch ex As Exception

        End Try
        For index As Integer = 1 To 10
            For i As Integer = 0 To 6
                hit(i) = r.Next(1, 50)
                For j As Integer = 0 To i - 1
                    If (hit(i) = hit(j)) Then
                        hit(i) = r.Next(1, 50)
                        j = 0
                    End If
                Next
            Next

            For Each num As Integer In hit
                sw.Write(num & vbTab)
            Next
            sw.Write(vbCrLf)
        Next
        sw.Close()
        Console.Read()
    End Sub

End Module

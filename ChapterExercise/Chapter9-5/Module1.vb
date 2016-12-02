
Module Module1
    Public Function multi(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x * y
    End Function

    Sub Main()
        Try
            Dim a As Integer = multi(1000000000, 1000000000)
            Dim b(10) As Integer
            For i As Integer = 0 To 10
                Console.WriteLine(b(i))
            Next
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try

        Console.Read()
    End Sub

End Module

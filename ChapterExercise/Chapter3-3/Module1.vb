Module Module1

    Sub Main()
        Dim num As Integer = 2
        Do While (num <= 1000)
            Dim counter As Integer = 0
            For index = 1 To num ^ (1 / 2)
                If (num Mod index = 0) Then
                    counter += 1
                End If
            Next
            If (counter = 1) Then
                Console.Write(CType(num, String) + " ")
            End If
            num += 1
        Loop
        Console.Read()
    End Sub

End Module

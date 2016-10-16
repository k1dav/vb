Module Module1

    Sub FindPrime(ByVal max)
        For index As Integer = 2 To max
            Dim counter As Integer = 0
            For i As Integer = 1 To index ^ (1 / 2)
                If (index Mod i = 0) Then
                    counter += 1
                End If
            Next
            If (counter = 1) Then
                Console.Write(index & " ")
            End If
        Next
    End Sub

    Sub Main()
        Dim max As Integer
        Console.WriteLine("找質數，請輸入要找的範圍最大值：")
        max = Console.ReadLine()
        FindPrime(max)

        Console.Read()
    End Sub

End Module

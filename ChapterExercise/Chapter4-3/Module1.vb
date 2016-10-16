Module Module1

    Sub Main()
        Dim num(9) As Integer
        For index As Integer = 0 To num.Length - 1
            Console.Write("Please input No.{0} num:", index + 1)
            num(index) = Console.ReadLine()
        Next

        Array.Sort(num)
        For Each n As Integer In num
            Console.Write("{0} ", n)
        Next

        Console.Read()
    End Sub

End Module

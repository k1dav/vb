Module Module1

    Sub Main()
        Dim check As Char = "y"
        Do While (check = "Y" Or check = "y")
            Dim str, str1 As String
            Dim counter As Integer
            Console.WriteLine("請輸入欲重覆的字串變數")
            str = Console.ReadLine()
            Console.WriteLine("請輸入欲重覆的次數")
            counter = Integer.Parse(Console.ReadLine())
            str1 = ""
            For index = 1 To counter
                str1 += str
            Next
            Console.WriteLine(str1)
            Console.WriteLine("是否繼續(y/n)")
            check = Console.ReadLine()
        Loop

        Console.Read()
    End Sub

End Module

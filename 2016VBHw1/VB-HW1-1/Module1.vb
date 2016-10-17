Module Module1

    Sub Main()
        Console.WriteLine("請輸入一個整數")
        Dim num As Integer = Console.ReadLine()
        Console.WriteLine("即將計算 0 ~ {0} 偶數的加總", num)
        Dim sum As Integer

        Do While (num >= 0)
            If (num Mod 2 = 0) Then
                sum += num
            End If
            num -= 1
        Loop

        Console.WriteLine("總合是 {0}", sum)

        Console.Read()
    End Sub

End Module

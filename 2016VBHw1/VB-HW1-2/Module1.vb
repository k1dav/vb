Module Module1

    Sub Main()
        Console.WriteLine("請輸入消費金額")
        Dim pay As Integer = Console.ReadLine()
        Console.WriteLine("請輸入收取金額")
        Dim give As Integer = Console.ReadLine()
        While (give < pay)
            Console.WriteLine("收取現金不足{0}請重新輸入", vbCrLf)
            Console.WriteLine("請輸入消費金額")
            pay = Console.ReadLine()
            Console.WriteLine("請輸入收取金額")
            give = Console.ReadLine()
        End While

        Dim charge As Integer = give - pay
        Console.WriteLine("應找金額：{0}", charge)
        While (charge > 0)
            If (charge \ 1000 > 0) Then
                Console.WriteLine("1000元紙鈔：{0}{1}", vbTab, charge \ 1000)
                charge = charge Mod 1000
            ElseIf (charge \ 500 > 0) Then
                Console.WriteLine("500元紙鈔：{0}{1}", vbTab, charge \ 500)
                charge = charge Mod 500
            ElseIf (charge \ 100 > 0) Then
                Console.WriteLine("100元紙鈔：{0}{1}", vbTab, charge \ 100)
                charge = charge Mod 100
            ElseIf (charge \ 50 > 0) Then
                Console.WriteLine("50元硬幣：{0}{1}", vbTab, charge \ 50)
                charge = charge Mod 50
            ElseIf (charge \ 10 > 0) Then
                Console.WriteLine("10元硬幣：{0}{1}", vbTab, charge \ 10)
                charge = charge Mod 10
            ElseIf (charge \ 5 > 0) Then
                Console.WriteLine("5元硬幣：{0}{1}", vbTab, charge \ 5)
                charge = charge Mod 5
            ElseIf (charge \ 1 > 0) Then
                Console.WriteLine("1元硬幣：{0}{1}", vbTab, charge \ 1)
                charge = charge Mod 1
            End If
        End While

        Console.Read()
    End Sub

End Module

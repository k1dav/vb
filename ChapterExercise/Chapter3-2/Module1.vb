Module Module1

    Sub Main()
        Console.WriteLine("請輸入信用卡前二碼")
        Dim num As Integer = Console.ReadLine()
        Select Case (num)
            Case 3 : Console.WriteLine("聯合信用卡")
            Case 35 : Console.WriteLine("JCB信用卡")
            Case 45 To 46 : Console.WriteLine("VISA信用卡")
            Case 54 To 55 : Console.WriteLine("MASTER信用卡")
            Case Else : Console.WriteLine("非商業用的信用卡")
        End Select
        Console.Read()
    End Sub

End Module

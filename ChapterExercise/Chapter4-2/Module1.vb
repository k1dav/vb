Module Module1

    Function getMaxAndMin(ByVal num() As Integer, ByRef min As Integer) As Integer
        Dim max As Integer = num(0)
        min = num(0)
        For index As Integer = 1 To num.Length - 1
            If (num(index) > max) Then
                max = num(index)
            End If
            If (num(index) < min) Then
                min = num(index)
            End If
        Next
        Return max
    End Function

    Sub Main()
        Dim num(4) As Integer
        Dim min, max As Integer
        For i As Integer = 0 To num.Length - 1
            Console.Write("Please input No.{0} number:", i + 1)
            num(i) = Console.ReadLine()
        Next
        max = getMaxAndMin(num, min)
        Console.WriteLine("Max = {0} , Min = {1}", max, min)

        Console.Read()
    End Sub

End Module

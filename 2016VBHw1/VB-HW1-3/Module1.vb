Module Module1
    Function GetMax(ByVal n() As Integer, ByRef max() As Integer)
        Array.Sort(n)
        Dim i As Integer = 0
        For index As Integer = n.Length - 1 To n.Length - 3 Step -1
            max(i) = n(index)
            i += 1
        Next
        Return " "
    End Function

    Sub Main()
        Dim num(9) As Integer
        Dim r As New Random()
        For index As Integer = 0 To num.Length - 1
            num(index) = r.Next(1, 201)
            Dim counter As Integer = 0
            Dim j As Integer = 0
            While (j < index)
                If (num(index) = num(j)) Then
                    num(index) = r.Next(1, 201)
                    j = 0
                End If
                j += 1
            End While
        Next
        Dim max(2) As Integer
        For Each index As Integer In num
            Console.Write(index & " ")
        Next
        Console.WriteLine()
        Console.Write("MAX:")
        GetMax(num, max)
        For Each index As Integer In max
            Console.Write(index & " ")
        Next

        Console.Read()
    End Sub

End Module
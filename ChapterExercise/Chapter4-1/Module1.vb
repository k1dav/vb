Module Module1

    Function GetMax(ByVal x, ByVal y) As Integer
        If (x > y) Then
            Return x
        Else
            Return y
        End If
    End Function

    Function GetMax(ByVal x, ByVal y, ByVal z) As Integer
        Dim max As Integer = x
        If (y > max) Then
            max = y
        End If
        If (z > max) Then
            max = z
        End If
        Return max
    End Function

    Function GetMax(ByVal x()) As Integer
        Dim max As Integer = x(0)
        For index As Integer = 1 To x.Length - 1
            If (x(index) > max) Then
                max = x(index)
            End If
        Next
        Return max
    End Function

    Sub Main()
        Dim max As Integer
        max = GetMax(1, 9)
        Console.WriteLine(max)
        max = GetMax(5, 9, 4)
        Console.WriteLine(max)
        max = GetMax({0, 1, 5, 9, 7, 6, 4, 12, 3})
        Console.WriteLine(max)

        Console.Read()
    End Sub

End Module

Module Module1

    Sub GetRank(ByRef score(,) As Single)
        Dim sum As Integer = 0
        For index As Integer = 0 To UBound(score, 2)
            For i As Integer = 0 To UBound(score, 1) - 1
                score(UBound(score, 1), index) += score(index, i)
            Next
            sum += score(UBound(score, 1), index)
        Next
        Dim avg As Single = sum / (UBound(score, 2) + 1)
        'Console.WriteLine("平均分數：{0}", avg)
        For choose As Integer = 0 To UBound(score, 2)
            Dim number As Single = score(UBound(score, 1), 0)
            Dim counter As Integer = 0
            For index As Integer = 0 To UBound(score, 2)
                For i As Integer = 0 To UBound(score, 2)
                    If (score(UBound(score, 1), i) > number) Then
                        number = score(UBound(score, 1), i)
                        counter = i
                    End If
                Next
            Next
            Console.WriteLine()
            Console.WriteLine("第{0}位學生，分數：{1}，{2}", counter + 1, number,
                              IIf(score(UBound(score, 1), counter) > avg, "正取" & choose + 1, "備取"))
            score(UBound(score, 1), counter) = -1
        Next

    End Sub

    Sub Main()
        Randomize()
        Console.WriteLine("請輸入評審人數")
        Dim p As Integer = CType(Console.ReadLine(), Integer)
        Console.WriteLine("請輸入學生人數")
        Dim s As Integer = CType(Console.ReadLine(), Integer)
        Dim score(p, s - 1) As Single

        For index As Integer = 0 To UBound(score, 1) - 1
            For i As Integer = 0 To UBound(score, 2)
                'Console.Write("請第{0}個評審輸入第{1}個學生的分數", i + 1, index + 1)
                score(index, i) = CType(Console.ReadLine(), Single)
                'score(index, i) = CInt(Int((100 * Rnd()) + 1))
            Next
        Next

        GetRank(score)

        Console.Read()
    End Sub

End Module

Module Module1
    Class Student
        Public Id As String
        Public Sname As String
        Public Shared Num As Integer
        Private _Chi As Integer
        Property Chi As Integer
            Get
                Return _Chi
            End Get
            Set(value As Integer)
                If (value > 100 Or value < 0) Then
                    Throw New Exception()
                End If
                _Chi = value
            End Set
        End Property
        Private _Eng As Integer
        Property Eng As Integer
            Get
                Return _Eng
            End Get
            Set(value As Integer)
                If (value > 100 Or value < 0) Then
                    Throw New Exception()
                End If
                _Eng = value
            End Set
        End Property
        Private _Bcc As Integer
        Property Bcc As Integer
            Get
                Return _Bcc
            End Get
            Set(value As Integer)
                If (value > 100 Or value < 0) Then
                    Throw New Exception()
                End If
                _Bcc = value
            End Set
        End Property
        Public Function GetAvg() As Single
            Return (_Chi + _Eng + _Bcc) / 3
        End Function
        Public Function GetStudentNum() As Integer
            Return Num
        End Function
    End Class

    Sub Main()
        Console.WriteLine("請輸入學生個數：")
        Dim n As Integer = Integer.Parse(Console.ReadLine())
        Dim s(n - 1) As Student
        For index As Integer = 0 To n - 1
            s(index) = New Student()
            Console.WriteLine("請輸入學生學號：")
            s(index).Id = Console.ReadLine()
            Console.WriteLine("請輸入學生姓名：")
            s(index).Sname = Console.ReadLine()
            Console.WriteLine("請輸入學生國文：")
            s(index).Chi = Integer.Parse(Console.ReadLine())
            Console.WriteLine("請輸入學生英文：")
            s(index).Eng = Integer.Parse(Console.ReadLine())
            Console.WriteLine("請輸入學生數學：")
            s(index).Bcc = Integer.Parse(Console.ReadLine())
            Student.Num += 1
            Console.WriteLine("學生平均分數為：{0}", s(index).GetAvg())
            Console.WriteLine("創建成功，目前學生人數為{0}", s(index).GetStudentNum)
            Console.WriteLine()
        Next
        Console.WriteLine("請輸入欲查詢的學生姓名")
        Dim sn As String = Console.ReadLine()
        Dim c As Integer = 0
        For Each p As Student In s
            If (p.Id = sn) Then
                Console.WriteLine("學號：{0},姓名：{1},國文：{2},英文：{3},數學：{4}", p.Id, p.Sname, p.Chi, p.Eng, p.Bcc)
                c += 1
                Exit For
            End If
        Next
        If (c = 0) Then
            Console.WriteLine("找不到該學生")
        End If

        Console.Read()
    End Sub

End Module

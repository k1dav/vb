Module Module1
    Class Student
        Public Shared count As Integer = 0
        Private _Sid As String
        Private _Name As String
        Private _Hegiht As Integer
        Private _Weight As Integer
        Private _BMI As Single

        Sub SetData(ByVal sid As String, ByVal name As String, ByVal height As Integer, ByVal weight As Integer)
            Me._Sid = sid
            Me._Name = name
            If (height <= 0 Or weight <= 0) Then
                Throw New SetException()
            End If
            Me._Hegiht = height
            Me._Weight = weight
            count += 1
            _BMI = weight / ((height / 100) ^ 2)
            If (Me._BMI < 18.5 Or Me._BMI >= 24) Then
                Throw New BMIException()
            End If
        End Sub

        Sub GetData()
            Console.WriteLine("學號：{0}{1}姓名：{2}{3}身高：{4}{5}體重：{6}{7}BMI：{8}",
                              Me._Sid, vbTab, Me._Name, vbTab, Me._Hegiht, vbTab, Me._Weight, vbTab, Me._BMI)
        End Sub

    End Class

    Class SetException
        Inherits Exception
        Public Overrides Function ToString() As String
            Return "身高或體重設定錯誤"
        End Function
    End Class

    Class BMIException
        Inherits Exception
        Public Overrides Function ToString() As String
            Return "BMI未在正常範圍"
        End Function
    End Class

    Sub Main()
        Dim sel As Integer
        Dim students(100) As Student
        While (sel <> -1)
            Console.WriteLine("請輸入學號：(輸入-1離開)")
            sel = Integer.Parse(Console.ReadLine())

            If (sel = -1) Then
                Exit While
            End If

            students(Student.count) = New Student()
            Console.WriteLine("請輸入姓名：(輸入-1離開)")
            Dim n As String = Console.ReadLine()
            Console.WriteLine("請輸入身高(cm)：(輸入-1離開)")
            Dim h As Integer = Integer.Parse(Console.ReadLine())
            Console.WriteLine("請輸入體重：(輸入-1離開)")
            Dim w As Integer = Integer.Parse(Console.ReadLine())

            Try
                students(Student.count).SetData(sel, n, h, w)
            Catch ex1 As BMIException
                Console.WriteLine(ex1.ToString())
            Catch ex2 As SetException
                Console.WriteLine(ex2.ToString())
            End Try
        End While

        For index As Integer = 0 To Student.count - 1
            students(index).GetData()
        Next
        Console.WriteLine("總共{0}位學生", Student.count)

    End Sub
End Module

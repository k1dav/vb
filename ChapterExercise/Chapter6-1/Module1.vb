Module Module1
    Class Emplyee
        Private _Salary As Integer()
        Private _EName As String()
        Public Event ShowError()

        Public Sub New(ByVal num)
            _Salary = New Integer(num) {}
            _EName = New String(num) {}
        End Sub

        Public Property Salary(ByVal index) As String
            Get
                Return _Salary(index)
            End Get
            Set(ByVal v As String)
                Dim value = Integer.Parse(v)
                If (value < 20000 Or value > 40000) Then
                    RaiseEvent ShowError()
                Else
                    _Salary(index) = value
                End If
            End Set
        End Property

        Public Property EName(ByVal index) As String
            Get
                Return _EName(index)
            End Get
            Set(Str As String)
                _EName(index) = Str
            End Set
        End Property

        Public Sub PrintData(ByVal index As Integer)
            Console.WriteLine("Name:{0}{1}Salary:{2}", EName(index), vbTab, Salary(index))
        End Sub


        Public Sub SearchData(ByVal name As String)
            Dim result As Integer = Array.IndexOf(_EName, name)
            If (result < 0) Then
                Console.WriteLine("查無此人")
            Else
                PrintData(result)
            End If
        End Sub

    End Class

    Sub ErrorValue()
        Console.WriteLine("薪水必須介於二萬至四萬之間")
    End Sub

    Sub Main()
        Console.WriteLine("請輸入員工人數")
        Dim num As Integer = Console.ReadLine()
        Dim staff As New Emplyee(num - 1)
        AddHandler staff.ShowError, AddressOf ErrorValue
        For index As Integer = 0 To num - 1
            Console.Write("請輸入第{0}員工姓名：", index + 1)
            staff.EName(index) = Console.ReadLine()
            Console.Write("請輸入第{0}員工薪水：", index + 1)
            staff.Salary(index) = Console.ReadLine()
        Next

        For index As Integer = 0 To num - 1
            staff.PrintData(index)
        Next

        Console.WriteLine("請輸入欲查詢員工的姓名")
        Dim name As String = Console.ReadLine()
        staff.SearchData(name)

        Console.Read()
    End Sub

End Module

Module Module1

    Class Shape
        Protected _a As Single
        Public Overridable Sub Area(ByVal x As Single)
        End Sub
        Public Overridable Sub Area(ByVal x As Single, ByVal y As Single)
        End Sub
    End Class

    Class Circle
        Inherits Shape
        Public Overrides Sub Area(ByVal x As Single)
            _a = x * x * Math.PI
            Console.WriteLine("面積為：" & _a)
        End Sub
    End Class

    Class Triangle
        Inherits Shape
        Public Overrides Sub Area(ByVal x As Single, ByVal y As Single)
            _a = x * y / 2
            Console.WriteLine("面積為：" & _a)
        End Sub
    End Class

    Class Rectangle
        Inherits Shape
        Public Overrides Sub Area(ByVal x As Single, ByVal y As Single)
            _a = x * y
            Console.WriteLine("面積為：" & _a)
        End Sub
    End Class

    Sub Main()
        Dim c As New Circle
        Console.WriteLine("請輸入圓的半徑")
        Dim cr As Integer = Integer.Parse(Console.ReadLine())
        c.Area(cr)

        Dim t As New Triangle
        Console.WriteLine("請輸入三角形的底")
        Dim b As Integer = Integer.Parse(Console.ReadLine())
        Console.WriteLine("請輸入三角形的高")
        Dim h As Integer = Integer.Parse(Console.ReadLine())
        t.Area(b, h)

        Dim r As New Rectangle
        Console.WriteLine("請輸入長方形的長")
        Dim l As Integer = Integer.Parse(Console.ReadLine())
        Console.WriteLine("請輸入長方形的寬")
        Dim w As Integer = Integer.Parse(Console.ReadLine())
        r.Area(l, w)

        Console.Read()
    End Sub
End Module

Module Module1

    Class Shape
        Protected _a As Single
        Public Overridable Sub Area(ByVal x As Single)
        End Sub
    End Class

    Class Circle
        Inherits Shape
        Public Overridable Sub Area(ByVal x As Single)
            _a = x * x * Math.PI
            Console.WriteLine(_a)
        End Sub
    End Class

    Class Triangle
        Inherits Shape
        Public Overridable Sub Area(ByVal x As Single, ByVal y As Single)
            _a = x * y / 2
            Console.WriteLine(_a)
        End Sub
    End Class

    Class Rectangle
        Inherits Shape
        Public Overridable Sub Area(ByVal x As Single, ByVal y As Single)
            _a = x * y
            Console.WriteLine(_a)
        End Sub
    End Class

    Sub Main()
        Dim c As New Circle
        c.Area(1)

        Dim t As New Triangle
        t.Area(10, 10)

        Dim r As New Rectangle
        r.Area(10, 10)

        Console.Read()
    End Sub
End Module

Module Module1
    Class Student
        Shared count As Integer = 0
        Private _Sid As String
        Private _Name As String
        Private _Hegiht As Integer
        Private _Weight As Integer
        Sub SetData(ByVal sid As String, ByVal name As String, ByVal height As Integer, ByVal weight As Integer)
            _Sid = sid
            _Name = name
            _Hegiht = height
            _Weight = weight
            count += 1
        End Sub
    End Class

    Class SetException
        Inherits Exception

    End Class
    Sub Main()

    End Sub

End Module

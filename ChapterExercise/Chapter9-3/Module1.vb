Module Module1
    Class Product
        Private Id As String
        Private Pname As String
        Private Price As Integer
        Sub SetData(ByVal i As String, ByVal n As String, ByVal p As Integer)
            Id = i
            Pname = n
            If (p <= 0) Then
                Throw New ProductException()
            Else
                Price = p
            End If
        End Sub
    End Class

    Class ProductException
        Inherits Exception
        Public Overrides Function ToString() As String
            Return "產品價格<=0"
        End Function
        Public Overrides ReadOnly Property Message As String
            Get
                Return "產品價格錯誤"
            End Get
        End Property
        Public Sub ShowSourceException()
            Console.WriteLine(Source)
        End Sub
    End Class
    Sub Main()

    End Sub

End Module

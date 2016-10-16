Module Module1
    Enum State As Integer
        Binary = 2
        Octal = 8
        Hex = 16
    End Enum

    Sub Main()
        Console.WriteLine("Binary Const : {0}", CType(State.Binary, String))
        Console.WriteLine("Octal Const : {0}", CType(State.Octal, String))
        Console.WriteLine("Hex Const : {0}", CType(State.Hex, String))
        Console.Read()
    End Sub

End Module

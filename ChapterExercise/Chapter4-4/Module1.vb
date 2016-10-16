Module Module1

    Sub Main()
        Dim name(5) As String
        Dim score(5) As Integer

        For index As Integer = 0 To name.Length - 1
            Console.Write("Please input the name:")
            name(index) = Console.ReadLine()
            Console.Write("Please input the {0}'s score:", name(index))
            score(index) = Console.ReadLine()
        Next

        Console.WriteLine("Name" + vbTab + vbTab + "Score")
        For i As Integer = 0 To name.Length - 1
            Console.WriteLine(name(i) + vbTab + vbTab & score(i))
        Next

        Dim search As Integer
        Console.Write("Please input the score you want to search:")
        search = Console.ReadLine()
        Dim result As Integer = Array.IndexOf(score, search)
        Console.WriteLine("{0} : {1}", name(result), CType(score(result), String))

        Console.Read()
    End Sub

End Module

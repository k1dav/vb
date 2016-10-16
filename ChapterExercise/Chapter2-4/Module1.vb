Module Module1
    Structure Student
        Public Id, Score As Integer
        Public Name As String
    End Structure

    Sub Main()
        Dim Peter As Student
        Dim Mary As Student
        Console.WriteLine("Input Peter's Id")
        Peter.Id = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Input Peter's Name")
        Peter.Name = Console.ReadLine()
        Console.WriteLine("Input Peter's Score")
        Peter.Score = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Input Mary's Id")
        Mary.Id = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Input Mary's Name")
        Mary.Name = Console.ReadLine()
        Console.WriteLine("Input Mary's Score")
        Mary.Score = Integer.Parse(
            Console.ReadLine())

        Console.Read()

    End Sub

End Module

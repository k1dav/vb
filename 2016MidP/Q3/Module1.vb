Imports System.IO

Module Module1

    Sub Main()
        Dim dir As New FileInfo("C:\Users\Hope\OneDrive\Github\vb\2016MidP\1.txt")
        If (dir.Exists) Then
        Else
            dir.Create()
        End If
        Dim sw As StreamWriter = dir.AppendText()

        Dim num(49) As Integer
        For index As Integer = 0 To num.Length - 1
            num(index) = index
        Next
        Dim c_n(49) As Boolean
        Dim r As New Random

        Dim hit(5) As Integer
        For index As Integer = 1 To 6
            Dim n As Integer = r.Next(1, 50)
            While (c_n(n) = True)
                n = r.Next(1, 50)
            End While
            hit(index - 1) = n
            c_n(n) = True
        Next

        For Each n As Integer In hit
            Console.Write("{0} ", n)
        Next
        Console.WriteLine()


        Dim check(5) As Integer
        While (True)
            For index As Integer = 1 To 6
                Console.WriteLine("請輸入第{0}個樂透數字", index)
                check(index - 1) = CInt(Console.ReadLine())
                While ((check(index - 1) > 49 Or check(index - 1) < 1))
                    Console.WriteLine("數字超過範圍")
                    Console.WriteLine("請重新輸入第{0}個樂透數字", index)
                    check(index - 1) = CInt(Console.ReadLine())
                End While
                For i As Integer = 1 To index - 1
                    While (check(index - 1) = check(i - 1))
                        Console.WriteLine("數字重覆")
                        Console.WriteLine("請重新輸入第{0}個樂透數字", index)
                        check(index - 1) = CInt(Console.ReadLine())
                        While ((check(index - 1) > 49 Or check(index - 1) < 1))
                            Console.WriteLine("數字超過範圍")
                            Console.WriteLine("請重新輸入第{0}個樂透數字", index)
                            check(index - 1) = CInt(Console.ReadLine())
                        End While
                        i = 1
                    End While
                Next
            Next

            For index As Integer = 0 To check.Length - 1
                Dim counter As Integer = 0
                For i As Integer = 0 To hit.Length - 1
                    If (check(index) = hit(i)) Then
                        Console.Write("{" & check(index) & "} ")
                        sw.Write("{" & check(index) & "} ")
                        counter += 1
                        Exit For
                    End If
                Next
                If (counter = 0) Then
                    Console.Write(check(index) & " ")
                    sw.Write(check(index) & " ")
                End If
            Next
            sw.Write(vbCrLf)
            sw.Flush()


            Console.WriteLine("輸入-1離開，任意數字繼續")
            Dim c As Integer = Console.ReadLine()
            If (c = -1) Then
                Exit While
            End If
        End While
        sw.Close()

        Console.Read()
    End Sub

End Module

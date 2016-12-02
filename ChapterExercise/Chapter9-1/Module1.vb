Imports System.IO
Module Module1

    Sub Main()
        Dim fname1 As FileInfo
        Dim fname2 As FileInfo
        Try
            Console.WriteLine("請輸入第一個檔案的路徑：")
            fname1 = New FileInfo(Console.ReadLine())
            Console.WriteLine("請輸入第二個檔案的路徑：")
            fname2 = New FileInfo(Console.ReadLine())
        Catch ex As Exception

        End Try
        Dim sr As StreamReader = fname1.OpenText()
        Dim sw As StreamWriter = fname2.AppendText()
        sw.Write(sr.ReadToEnd)
        sr.Close()
        sw.Close()

        sr = fname2.OpenText()
        Console.WriteLine(sr.ReadToEnd)

        Console.Read()
    End Sub

End Module

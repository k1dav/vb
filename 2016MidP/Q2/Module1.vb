Module Module1

    Public Enum Statu
        Lent
        Lendable
        Limited
    End Enum

    Class Collection
        Public Property Id As Integer
        Public Property Status As Statu
        Shared Property Total As Integer
        Public Overridable Sub Lend()
        End Sub
    End Class

    Class Book
        Inherits Collection
        Private Pages As Integer
        Sub SetData(ByVal p As Integer)
            Pages = p
        End Sub
        Public Overridable Sub Lend()
            If (Me.Status <> Statu.Lendable) Then
                Throw New LendException()
            End If
            If (Total >= 5) Then
                Throw New QtyException()
            End If
            Me.Status = Statu.Lent
            Total += 1
        End Sub
        Function GetData() As Integer
            Return Pages
        End Function
    End Class

    Class Media
        Inherits Collection
        Private Type As String
        Sub SetData(ByVal t As String)
            Type = t
        End Sub
        Public Overridable Sub Lend()
            If (Me.Status <> Statu.Lendable) Then
                Throw New LendException()
            End If
            If (Total >= 5) Then
                Throw New QtyException()
            End If
            Me.Status = Statu.Lent
            Total += 1
        End Sub
        Function GetData() As String
            Return Type
        End Function
    End Class

    Class QtyException
        Inherits Exception
        Public Overrides Function ToString() As String
            Return "你的外借總數已超過規定上限!!"
        End Function
    End Class

    Class LendException
        Inherits Exception
        Public Overrides Function ToString() As String
            Return "該項目不得外借!!"
        End Function
    End Class

    Sub Main()
        Randomize()
        Dim books(10) As Book
        Dim medias(10) As Media

        For index As Integer = 0 To books.Length - 1
            books(index) = New Book()
            books(index).Id = CInt(Int(Rnd() * 1000000 + 1))
            books(index).Status = Statu.Lendable
            books(index).SetData(CInt(Int(Rnd() * 1000 + 1)))
        Next

        For index As Integer = 0 To medias.Length - 1
            medias(index) = New Media()
            medias(index).Id = CInt(Int(Rnd() * 1000000 + 1))
            medias(index).Status = Statu.Lendable
            If (medias(index).Id Mod 3 = 0) Then
                medias(index).SetData("CD")
            ElseIf (medias(index).Id Mod 3 = 1) Then
                medias(index).SetData("DVD")
            Else
                medias(index).SetData("BD")
            End If

        Next

        Do While (True)
            Dim sel As Integer
            Dim choose As Integer
            Console.WriteLine("欲借出的館藏：1.書籍 2.視聽資料 3.結束")
            sel = Console.ReadLine()
            Console.WriteLine()
            Try
                Select Case sel
                    Case 1
                        Dim counter As Integer = 1
                        For Each b As Book In books
                            Console.Write(counter & ".{0}", vbTab)
                            Console.WriteLine("Book_ID:{0}{1}Status:{2}{3}Pages:{4}",
                                          b.Id, vbTab, b.Status, vbTab, b.GetData)
                            counter += 1
                        Next

                        Console.WriteLine("請輸入欲借的第幾本書：")
                        choose = Console.ReadLine()
                        books(choose - 1).Lend()


                    Case 2
                        Dim counter As Integer = 1
                        For Each m As Media In medias
                            Console.Write(counter & ".{0}", vbTab)
                            Console.WriteLine("Media_ID:{0}{1}Status:{2}{3}Pages:{4}",
                                              m.Id, vbTab, m.Status, vbTab, m.GetData)
                            counter += 1
                        Next
                        Console.WriteLine("請輸入欲借的第幾項視聽資料：")
                        choose = Console.ReadLine()
                        medias(choose - 1).Lend()
                    Case 3
                        Exit Do
                End Select
            Catch ex As QtyException
                Console.WriteLine(ex.ToString)
            Catch ex2 As LendException
                Console.WriteLine(ex2.ToString)
            End Try
        Loop

        Console.WriteLine("外借數量：{0}，書籍總數：{1}，視聽資料總數：{2}",
                              Collection.Total, books.Length, medias.Length)

        Console.Read()
    End Sub
End Module

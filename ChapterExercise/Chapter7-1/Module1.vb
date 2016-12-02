Imports Chapter7_1

Module Module1
    ' 定義Traffic交通工具類別
    Interface Traffic
        Sub SpeedUp()    '  SpeedUp是空白，允許被子類別覆寫
    End Interface

    ' 定義Car車子類別繼承自交通工具類別
    Class Car
        Implements Traffic
        Dim _miles As Integer = 0

        Public Sub SpeedUp() Implements Traffic.SpeedUp
            _miles += 2
            Console.WriteLine("駕駛車子, 加速中, 前進{0}公里", _miles.ToString())
        End Sub
    End Class

    ' 定義Airplane飛機類別繼承自交通工具類別
    Class Airplane
        Implements Traffic
        Dim _miles As Integer = 0

        Public Sub SpeedUp() Implements Traffic.SpeedUp
            _miles += 15
            Console.WriteLine("駕駛飛機, 加速中, 前進{0}公里", _miles.ToString())
        End Sub

    End Class

    Sub Main()
        Dim myCar As New Car()
        ' myAirplane是Airplane類別的物件實體, 同時繼承Traffic類別
        Dim myAirplane As New Airplane()
        Dim input As String
        Do While True
            Console.Write("請問要駕駛->1.車子  2.飛機  其他.離開：")
            input = Console.ReadLine()
            If input = 1 Then
                myCar.SpeedUp()      ' 開車子,r參考指向myCar物件實體
            ElseIf input = "2" Then
                myAirplane.SpeedUp() ' 開飛機,r參考指向myAirplane物件實體
            Else
                Exit Do
            End If
            Console.WriteLine()
        Loop
        Console.Read()
    End Sub

End Module

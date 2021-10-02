Imports System

Module _02
    Sub Main(args As String())
        Dim a As Integer = Integer.Parse(Console.ReadLine())
        Dim b As Integer = Integer.Parse(Console.ReadLine())
        Dim c As Integer = Integer.Parse(Console.ReadLine())

        Dim res As Double = Ave(a, b, c)
        Console.WriteLine(res)
    End Sub

    Function Ave(a As Integer, b As Integer, c As Integer)
        Dim _sum As Integer = a + b + c
        Dim _ave As Double = _sum / 3
        Return _ave
    End Function
End Module
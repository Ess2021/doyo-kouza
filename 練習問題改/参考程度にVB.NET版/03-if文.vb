Imports System

Module _03
    Sub Main(args As String())
        Dim n As Integer = Integer.Parse(Console.ReadLine())

        If n < 20 Then
            Console.WriteLine("あなたは未成年です")
        Else
            Console.WriteLine("あなたは成人です")
        End If
    End Sub
End Module

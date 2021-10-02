Imports System

Module _04
    Sub Main(args As String())
        Dim m As Integer = Integer.Parse(Console.ReadLine())
        Dim n As Integer = Integer.Parse(Console.ReadLine())

        For i = m To n - 1
            If i Mod 2 = 0 Then
                Console.WriteLine(i)
            End If
        Next

        '別解
        'For i = m + (m Mod 2) To n - 1 Step 2
        '    Console.WriteLine(i)
        'Next
    End Sub
End Module

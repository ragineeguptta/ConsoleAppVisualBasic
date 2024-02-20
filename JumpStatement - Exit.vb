Imports System
Imports System.Security.Cryptography.X509Certificates

Module JumpStatement1
    Sub Main1(args As String())
        'Visual Basic For Loop with Exit Statement
        'For i As Integer = 1 To 4
        '    If i = 3 Then Exit For
        '    Console.WriteLine("i value: {0}", i)
        'Next


        'Visual Basic While Loop with Exit Statement
        'Dim i As Integer = 1
        'While i < 4
        '    Console.WriteLine("i value: {0}", i)
        '    i += 1
        '    If i = 2 Then Exit While
        'End While


        'Visual Basic Do-While Loop with Exit Statement
        Dim i As Integer = 1
        Do
            Console.WriteLine("i value: {0}", i)
            i += 1
            If i = 3 Then Exit Do
        Loop While i < 4

        Console.WriteLine("Press enter key to exit")
        Console.ReadLine()
    End Sub
End Module

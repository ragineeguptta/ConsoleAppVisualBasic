Imports System
Imports System.Security.Cryptography.X509Certificates

Module JumpStatement2
    Sub Main2(args As String())
        'Visual Basic For Loop with Continue Statement
        'For i As Integer = 1 To 4
        '    If i = 3 Then Continue For
        '    Console.WriteLine("i value: {0}", i)
        'Next


        'Visual Basic While Loop with Continue Statement
        'Dim i As Integer = 0
        'While i < 4
        '    i += 1
        '    If i = 2 Then Continue While
        '    Console.WriteLine("i value: {0}", i)
        'End While


        'Visual Basic Do-While Loop with Continue Statement
        Dim i As Integer = 1S
        Do
            Console.WriteLine("i value: {0}", i)
            i += 1
            If i = 2 Then Continue Do
        Loop While i < 4

        Console.WriteLine("Press enter key to exit")
        Console.ReadLine()
    End Sub
End Module

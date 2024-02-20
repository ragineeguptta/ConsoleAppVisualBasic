Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main(args As String())

        'For Loop
        'For i As Integer = 1 To 4
        '    Console.WriteLine("Value of i is {0}", i)
        'Next
        'Console.WriteLine("Press enter key to exit")

        'While Loop
        'Dim i As Integer = 1
        'While i <= 4
        '    Console.WriteLine("i value {0}", i)
        '    i += 1
        'End While


        'Do While Loop
        'Dim i As Integer = 5
        'Do
        '    Console.WriteLine("Vaule of i {0}", i)
        '    i += 1
        'Loop While i <= 14


        'Foreach Loop with Array 
        Dim names As String() = New String(2) {"Raginee", "Gunjan", "Shashi"}
        For Each name As String In names
            Console.WriteLine("My name is {0}", name)
        Next

        Console.WriteLine("Press enter key to exit")

        Console.ReadLine()
    End Sub
End Module

Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main(args As String())
        Dim x As Integer = 5
        Dim result As String
        If x = 10 Then
            Console.WriteLine("Wrong")
        ElseIf x < 10 Then
            Console.WriteLine("vALUE IS LESS THAN 10")
        Else
            Console.WriteLine("Again wrong value")
        End If

        'Ternary Operator

        result = If((x = 5), "Right", "Wrong")
        Console.WriteLine(result)

        'Select Case

        Select Case x
            Case 10
                Console.WriteLine("Value is 10")
            Case 5
                Console.WriteLine("Value is 5")
            Case Else
                Console.WriteLine("Value is not satisfying")
        End Select

        Console.ReadLine()
    End Sub
End Module

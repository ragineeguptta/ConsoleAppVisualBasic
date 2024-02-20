Imports System
Imports System.Formats
Imports System.Security.Cryptography.X509Certificates

Module JumpStatement3
    Sub Main3(args As String())
        'Visual Basic Goto Statement with For Loop Example
        '        For i As Integer = 1 To 10 - 1
        '            If i = 5 Then
        '                GoTo endloop
        '            End If
        '            Console.WriteLine("i value:{0}", i)
        '        Next
        'endloop:
        '        Console.WriteLine("The end")


        'Visual Basic Goto Statement with Select Statement
        Dim i As Integer = 3, j As Integer = 0
        Select Case i
            Case 1
Case1:
                j += 20
                Console.WriteLine("j value is {0}", j)
            Case 2
                j += 5
                GoTo Case1
            Case 3
                j += 30
                GoTo Case1
            Case Else
                Console.WriteLine("Not Known")
        End Select
        Console.WriteLine("Press Enter Key to Exit..")
        Console.ReadLine()
    End Sub
End Module

Imports System
Imports System.Formats
Imports System.Security.Cryptography.X509Certificates

Module JumpStatement
    Sub Main(args As String())
        Dim i As Integer = 10, j As Integer = 20, result As Integer = 0
        result = SumofNumbers(i, j)
        Console.WriteLine("Result: {0}", result)
        Console.WriteLine("Press Enter Key to Exit..")
        Console.ReadLine()


    End Sub
    Public Function SumofNumbers(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim x As Integer = a + b
        Return x
    End Function
End Module

Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Public Class [Class]
        Public age As Integer
    End Class
    Sub Main(args As String())
        Dim id As Integer
        Dim name As String = "Raginee Gupta"
        Dim percentage As Double = 10.23
        Dim gender As Char = "F"c
        Dim isVerified As Boolean
        id = 10
        isVerified = True


        'Console.WriteLine("Id:{0}", id)
        'Console.WriteLine("Name:{0}", name)
        'Console.WriteLine("Percentage:{0}", percentage)
        'Console.WriteLine("Gender:{0}", gender)
        'Console.WriteLine("Verified:{0}", isVerified)

        Dim p1 As [Class] = New [Class]()
        p1.age = 20
        Console.WriteLine("Age: " & p1.age)
        Console.ReadLine()
    End Sub
End Module

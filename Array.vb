Imports System
Imports System.Formats
Imports System.Security.Cryptography.X509Certificates

Module Array
    Sub Main(args As String())
        ' Declaring and Initializing an array with size of 5
        Dim array As Integer() = New Integer(4) {}
        ' Defining and assigning an elements at the same time
        Dim array2 As Integer() = New Integer(4) {1, 2, 3, 4, 5}
        ' Initialize with 5 elements will indicates the size of an array
        Dim array3 As Integer() = New Integer() {1, 2, 3, 4, 5}
        ' Another way to initialize an array without size
        Dim array4 As Integer() = {1, 2, 3, 4, 5}
        ' Declare an array without initialization
        Dim array5 As Integer()
        array5 = New Integer() {1, 2, 3, 4, 5}


        Console.WriteLine(array5(2))
        Console.ReadLine()



    End Sub
End Module

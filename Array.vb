Imports System
Imports System.Collections.Immutable
Imports System.Formats
Imports System.Security.Cryptography.X509Certificates
Imports System.Array

Module Array
    Sub MainA(args As String())
        ' Declaring and Initializing an array with size of 5
        'Dim array As Integer() = New Integer(4) {}
        ' Defining and assigning an elements at the same time
        Dim array2 As Integer() = New Integer(4) {1, 2, 3, 4, 5}
        ' Initialize with 5 elements will indicates the size of an array
        Dim array3 As Integer() = New Integer() {1, 2, 3, 4, 5}
        ' Another way to initialize an array without size
        Dim array4 As Integer() = {1, 2, 3, 4, 5}
        ' Declare an array without initialization
        Dim array5 As Integer()
        array5 = New Integer() {1, 2, 3, 4, 5}


        'Console.WriteLine(array5(2))

        'For i As Integer = 0 To array4.Length - 1
        '    Console.WriteLine(array4(i))
        'Next

        'For Each i As Integer In array5
        '    Console.WriteLine(i)
        'Next


        Dim arr As Integer() = New Integer(4) {1, 4, 2, 3, 5}
        Console.WriteLine("---Initial Array Elements---")
        For Each i As Integer In arr
            Console.WriteLine(i)
        Next

        System.Array.Sort(arr)

        Console.WriteLine("---Elements After Sort---")

        For Each i As Integer In arr

            Console.WriteLine(i)

        Next

        System.Array.Reverse(arr)

        Console.WriteLine("---Elements After Reverse---")

        For Each i As Integer In arr

            Console.WriteLine(i)

        Next

        Console.WriteLine("Press Enter Key to Exit..")
        Console.ReadLine()



    End Sub
End Module

Imports System
Imports System.Collections.Immutable
Imports System.Formats
Imports System.Security.Cryptography.X509Certificates
Imports System.Array

Module MultidimensionalArray
    Sub Main1(args As String())

        '' Two Dimensional Array
        'Dim arr As Integer(,) = New Integer(3, 1) {}
        'Dim arr2D As Integer(,) = New Integer(2, 1) {{4, 5}, {2, 3}, {1, 1}}
        'Dim arr2D1 As Integer(,) = New Integer(,) {{7, 8}, {6, 0}}

        '' Three Dimensional Array
        'Dim arr3 As Integer(,,) = New Integer(3, 1, 2) {}
        'Dim array3D As Integer(,,) = New Integer(1, 1, 2) {{{1, 1, 1}, {2, 4, 3}}, {{1, 8, 2}, {3, 9, 1}}}

        'Console.WriteLine(arr2D(1, 0))

        'Console.WriteLine(array3D(1, 1, 1))


        ' Two Dimensional Array
        Dim array2D As Integer(,) = New Integer(2, 1) {{4, 5}, {5, 0}, {3, 1}}

        ' Three Dimensional Array
        Dim array3D As Integer(,,) = New Integer(1, 1, 2) {{{1, 2, 3}, {4, 5, 6}}, {{7, 8, 9}, {10, 11, 12}}}

        Console.WriteLine("---Two Dimensional Array Elements---")
        For i As Integer = 0 To 3 - 1
            For j As Integer = 0 To 2 - 1
                Console.WriteLine("a[{0},{1}] = {2}", i, j, array2D(i, j))
            Next
        Next

        Console.WriteLine("---Three Dimensional Array Elements---")
        For i As Integer = 0 To 2 - 1
            For j As Integer = 0 To 2 - 1
                For k As Integer = 0 To 3 - 1
                    Console.WriteLine("a[{0},{1},{2}] = {3}", i, j, k, array3D(i, j, k))
                Next
            Next
        Next

        Console.WriteLine("Press Enter Key to Exit..")
        Console.ReadLine()


    End Sub
End Module

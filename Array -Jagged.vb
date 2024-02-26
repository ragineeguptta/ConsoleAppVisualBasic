Imports System
Imports System.Collections.Immutable
Imports System.Formats
Imports System.Security.Cryptography.X509Certificates
Imports System.Array

Module JaggedArray
    Sub Main(args As String())
        ' Jagged Array with Single Dimensional Array
        Dim jarray As Integer()() = New Integer(2)() {}
        jarray(0) = New Integer(4) {1, 3, 2, 3, 1}
        jarray(1) = New Integer(2) {12, 32, 21}
        jarray(2) = New Integer() {1, 32, 13, 1, 3, 33}

        ' Jagged Array with Two Dimensional Array

        Dim jarray11 As Integer()(,) = New Integer(2)(,) {}

        jarray11(0) = New Integer(1, 1) {{15, 24}, {43, 54}}

        jarray11(1) = New Integer(,) {{11, 12}, {13, 14}, {25, 26}}

        jarray11(2) = New Integer(3, 2) {}

        ' Initializing an Array on Declaration

        Dim jarray21 As Integer()() = New Integer()() {New Integer() {1, 2, 3, 4, 5}, New Integer() {98, 56, 45}, New Integer() {32}}


        ' Jagged Array with Single Dimensional Array

        Dim jarray22 As Integer()() = New Integer(2)() {}

        jarray22(0) = New Integer(4) {1, 2, 3, 4, 5}

        jarray22(1) = New Integer(2) {10, 20, 30}

        jarray22(2) = New Integer() {12, 50, 60, 70, 32}

        Console.WriteLine("---Jagged Array with Single Dimensional Elements---" & vbLf)

        For i As Integer = 0 To jarray22.Length - 1

            Console.Write("Element[{0}]: ", i)

            For j As Integer = 0 To jarray22(i).Length - 1

                Console.Write("{0}{1}", jarray22(i)(j), If(j = (jarray22(i).Length - 1), "", " "))

            Next

            Console.WriteLine()

        Next

        ' Jagged Array with Two Dimensional Array

        Dim jarray1 As Integer()(,) = New Integer(1)(,) {}

        jarray1(0) = New Integer(1, 1) {{15, 24}, {43, 54}}

        jarray1(1) = New Integer(,) {{11, 12}, {13, 14}, {25, 26}}

        Console.WriteLine(vbLf & "---Jagged Array with Mult-Dimensional Elements---" & vbLf)

        For i As Integer = 0 To jarray1.Length - 1

            Console.Write("Element[{0}]: ", i)

            For j As Integer = 0 To jarray1(i).GetLength(0) - 1

                Console.Write("{")

                For k As Integer = 0 To jarray1(i).GetLength(1) - 1

                    Console.Write("{0}{1}", jarray1(i)(j, k), If(k = (jarray1(i).GetLength(1) - 1), "", " "))

                Next

                Console.Write("{0}{1}", "}", If(j < jarray1.GetLength(0), ", ", ""))

            Next

            Console.WriteLine()

        Next

        Console.WriteLine(vbLf & "Press Enter Key to Exit..")

        Console.ReadLine()


    End Sub
End Module

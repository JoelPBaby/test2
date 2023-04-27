Module Module1

    Sub Main()
        Dim a(1, 1) As Integer
        Dim b(1, 1) As Integer
        Dim c(1, 1) As Integer
        Dim i As Integer
        Dim j As Integer
        For i = 0 To 1
            For j = 0 To 1
                Console.WriteLine("Enter matrix1 element: ")
                a(i, j) = Console.ReadLine()
            Next
        Next

        Console.WriteLine("Entered Elements")

        For i = 0 To 1
            For j = 0 To 1
                Console.Write(" " & a(i, j))
            Next
            Console.WriteLine()
        Next

        For i = 0 To 1
            For j = 0 To 1
                Console.WriteLine("Enter matrix2 element: ")
                b(i, j) = Console.ReadLine()
            Next
        Next
        Console.WriteLine("Entered Elements")

        For i = 0 To 1
            For j = 0 To 1
                Console.Write(" " & b(i, j))
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("Sum of Matrix:")
        For i = 0 To 1
            For j = 0 To 1
                c(i, j) = a(i, j) + b(i, j)
            Next
        Next
        Console.WriteLine()
        For i = 0 To 1
            For j = 0 To 1
                Console.Write(" " & c(i, j))
            Next
            Console.WriteLine()
        Next
    End Sub

End Module

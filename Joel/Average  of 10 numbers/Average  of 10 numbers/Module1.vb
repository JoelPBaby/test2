Module Module1

    Sub Main()
        Dim i As Integer
        Dim avg As Double
        Dim sum = 0
        Dim brr(10) As Integer
        For i = 1 To 10
            Console.WriteLine("Enter Numbers " & i)
            brr(i) = Console.ReadLine()
        Next
        Console.WriteLine("Entered elements are : ")
        For i = 1 To 10
            Console.WriteLine((i) & "-> " & brr(i))
        Next
        Console.WriteLine("      Average of 10 Numbers     ")
        For i = 1 To 10
            sum = sum + brr(i)
            avg = sum / 10
        Next
        Console.WriteLine("Average: " & avg)
    End Sub

End Module

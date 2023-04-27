Module Even

    Sub Main()
        Dim a, i As Integer
        Dim count = 0
        Dim brr(10) As Integer

        For i = 1 To 10
            Console.WriteLine("Enter Numbers " & i)
            brr(i) = Console.ReadLine()
        Next
        Console.WriteLine("Entered elements are : ")
        For i = 1 To 10
            Console.WriteLine((i) & "-> " & brr(i))
        Next
        For i = 1 To 10
            If (brr(i) Mod 2 = 0) Then
                count += 1
            End If
        Next
        Console.WriteLine("Total even numbers are: " & count)
    End Sub

End Module

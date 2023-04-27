Module Module1
    Sub Main()
        Dim n As Integer
        Dim max = 0
        Dim count = 0
        Console.WriteLine("Enter array limit: ")
        n = Console.ReadLine()
        Dim arr(n) As Integer
        For i = 1 To n
            Console.WriteLine("Enter array element " & i)
            arr(i) = Console.ReadLine()
        Next
        Console.WriteLine("Entered Elements")
        For i = 1 To n
            Console.WriteLine(arr(i))
            If (max < arr(i)) Then
                max = arr(i)
            End If
        Next
        For i = 1 To n
            If (max = arr(i)) Then
                count += 1
            End If
        Next
        Console.WriteLine("Largest element in the array is : " & max)
        Console.WriteLine("Element " & max & " occured " & count & " times")

    End Sub

End Module

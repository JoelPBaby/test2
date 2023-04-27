Module Search

    Sub Main()
        Dim n, srch, i As Integer
        Console.WriteLine("Enter the limit of Array: ")
        n = Console.ReadLine()
        Dim arr(n), c As Integer
        For i = 0 To n - 1
            Console.WriteLine("Enter element " & i)
            arr(i) = Console.ReadLine()
        Next
        Console.WriteLine("Enter the element to Search: ")
        srch = Console.ReadLine()
        For i = 0 To n
            If srch = arr(i) Then
                Console.WriteLine("Element Found at postion " & i)
                c = 1
                Exit For
            End If
        Next
        If c = 0 Then
            Console.WriteLine("Item not Found")
        End If

    End Sub
End Module

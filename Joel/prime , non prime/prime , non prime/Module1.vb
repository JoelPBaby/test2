Module Module1

    Sub Main()

        Dim i, n, e, k, q As Integer
        q = 0
        k = 0

        Console.WriteLine("Enter limit of the array:")
        n = Console.ReadLine()
        Dim arr(n) As Integer
        Dim p(n) As Integer
        Dim b(n) As Integer

        For i = 0 To n - 1
            Console.WriteLine("Enter elements:")
            arr(i) = Console.ReadLine()
        Next
        For i = 0 To n - 1
            e = 0
            For j = 1 To arr(i)
                If arr(i) Mod j = 0 Then

                    e = e + 1
                End If
            Next
            If e = 2 Then
                p(k) = arr(i)
                k = k + 1
            Else


                b(q) = arr(i)
                q = q + 1
            End If
        Next

        Console.WriteLine("prime numbers are:")
        For i = 0 To k - 1
            Console.Write("{0} ", p(i))
        Next
        Console.WriteLine()
        Console.WriteLine("Non prime numbers are:")
        For i = 0 To q - 1
            Console.Write("{0} ", b(i))
        Next
        Console.WriteLine()
    End Sub
End Module
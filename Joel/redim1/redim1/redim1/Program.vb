Imports System

Module Program
    Sub Main()
        Dim a() As Integer
        Dim n, k As Integer

        Console.Write("Enter the arraysize:")
        n = Console.ReadLine()
        ReDim a(n)
        For i = 0 To n - 1 Step 1
            Console.Write("Enter the element:")
            a(i) = Console.ReadLine()
        Next
        Console.Write("Enter the new arraysize:")
        k = Console.ReadLine()
        ReDim Preserve a(k)
        For i = n To k - 1 Step 1
            Console.Write("Enter the new element :")
            a(i) = Console.ReadLine()
        Next
        Console.Write("print elements in the array:")
        For i = 0 To k - 1 Step 1
            Console.WriteLine(a(i))
        Next


    End Sub
End Module

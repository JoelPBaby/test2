Module Module1
    Sub Main()
        Dim a, b As Integer
        Dim sum = 0
1:
        While a < 2
            Console.WriteLine("    OPTIONS    ")
            Console.WriteLine("-----------------------")
            Console.WriteLine("1. Enter Number: |")
            Console.WriteLine("2. Exit and Print Sum |")
            Console.WriteLine("")
            Console.WriteLine("Enter your Choice: ")
            a = Console.ReadLine()
            If a = 1 Then
                Console.WriteLine("Enter the number: ")
                b = Console.ReadLine()
                sum = sum + b
            End If
            If a = 2 Then
                Console.WriteLine("Sum is: " & sum)
            End If
            While a > 2
                Console.WriteLine("Invalid Option !")
                Exit While
            End While
            GoTo 1
        End While
    End Sub
End Module

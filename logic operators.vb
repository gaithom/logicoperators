Module Module1
    Sub Main()
        Dim a As Boolean = True
        Dim b As Boolean = True
        Dim c As Integer = 5
        Dim d As Integer = 20
        'logical And, Or and Xor Checking
        If (a And b) Then
            Console.WriteLine("Line 1 - Condition is true")
        End If
        If (a Or b) Then
            Console.WriteLine("Line 2 - Condition is true")
        End If
        If (a Xor b) Then
            Console.WriteLine("Line 3 - Condition is true")
        End If
        'bitwise And, Or and Xor Checking
        If (c And d) Then
            Console.WriteLine("Line 4 - Condition is true")
        End If
        If (c Or d) Then
            Console.WriteLine("Line 5 - Condition is true")
        End If
        If (c Or d) Then
            Console.WriteLine("Line 6 - Condition is true")
        End If
        'Only logical operators
        If (a AndAlso b) Then
            Console.WriteLine("Line 7 - Condition is true")
        End If
        If (a OrElse b) Then

            Console.WriteLine("Line 8 - Condition is true")
        End If
        ' lets change the value of a and b
        a = False
        b = True
        If (a And b) Then
            Console.WriteLine("Line 9 - Condition is true")
        Else
            Console.WriteLine("Line 9 - Condition is not true")
        End If
        If (Not (a And b)) Then
            Console.WriteLine("Line 10 - Condition is true")
        End If
        Console.ReadLine()
    End Sub
End Module





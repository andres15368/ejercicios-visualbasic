Module Module1

    Sub Main()
        Dim num As Integer
        Dim comprobacion As Boolean = True

        Console.WriteLine("bienvenido a mi programa primo o no primo")
        Console.WriteLine("digite el numero")
        num = Console.ReadLine

        For i As Integer = 2 To num - 1
            If num Mod 2 = 0 Then
                comprobacion = False
            End If

        Next
        If comprobacion = False Then
            Console.WriteLine("no es numero primo")
        Else
            Console.WriteLine("es un numero primo ")

        End If
        Console.ReadLine()


    End Sub

End Module

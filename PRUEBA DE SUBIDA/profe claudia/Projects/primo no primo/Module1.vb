Module Module1

    Sub Main()
        Dim a As Integer
        Console.WriteLine("ingrese el año")
        a = Console.ReadLine()

        If (a Mod 4 = 0 And a Mod 100 <> 0 Or a Mod 400 = 0) Then
            Console.Write("el año es bifiesto")
        Else
            Console.WriteLine("el año no es bifiesto")


        End If
        Console.ReadKey()



    End Sub

End Module

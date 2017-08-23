Module Module1

    Sub Main()
        Dim cadena As Integer
        Dim resultado As Integer
        Console.WriteLine("introzca numero de tabla de multiplicar ")
        For i = 1 To 10
            cadena = Console.ReadLine()
            For a As Integer = 1 To 10
                resultado = a * cadena
                Console.Write(a & " * " cadena " &  " = " & resultado)
            Next
        Next
        Console.ReadLine()

    End Sub

End Module

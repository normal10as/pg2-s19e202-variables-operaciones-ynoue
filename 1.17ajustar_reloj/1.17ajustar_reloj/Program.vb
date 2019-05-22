Imports System.DateTime

Module Program
    Sub Main()
        Dim dia, hora As Integer
        Dim horacreada As Date


        Console.WriteLine("ingrese un numero entre (1 - 31):")
        dia = Console.ReadLine()

        Console.WriteLine("ingrese una hora (0 - 24):")
        hora = Console.ReadLine()


        horacreada = New Date(Now.Year, Now.Month, dia, hora, Now.Minute, Now.Second)

        Console.WriteLine("La fecha creada es {0}", horacreada)

    End Sub
End Module

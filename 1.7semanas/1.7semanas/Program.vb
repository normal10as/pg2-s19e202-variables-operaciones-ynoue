Imports System

Module semanas
    Sub Main()

        Const diasemana As Integer = 7
        Const horadia As Integer = 24
        Const minutodia As Integer = 60

        Dim numerocualquiera As Byte

        Console.WriteLine("ingrese un numero de la semana:")
        numerocualquiera = Console.ReadLine()


        Console.WriteLine(numerocualquiera / diasemana)
        Console.WriteLine(numerocualquiera * horadia)
        Console.WriteLine(numerocualquiera * minutodia)




    End Sub
End Module

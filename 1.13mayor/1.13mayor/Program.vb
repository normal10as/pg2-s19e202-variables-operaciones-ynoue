Imports System

Module Program
    Sub Main()

        Dim nume1, nume2, nume3 As Integer

        Console.WriteLine("ingrese un numero:")
        nume1 = Console.ReadLine()
        Console.WriteLine("ingrese un numero:")
        nume2 = Console.ReadLine()
        Console.WriteLine("ingrese un numero:")
        nume3 = Console.ReadLine()

        Console.WriteLine("el numero mayor de los 3 es {0}", Math.Max(Math.Max(nume1, nume2), nume3))




    End Sub
End Module

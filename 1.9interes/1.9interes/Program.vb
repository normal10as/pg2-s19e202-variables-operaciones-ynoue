Imports System

Module Program
    Sub main()
        Dim m As Single
        Dim r As Single
        Dim t As UShort
        Dim i As Single

        Console.WriteLine("ingrese el monto:")
        m = Console.ReadLine()
        Console.WriteLine("ingrse el interes:")
        r = Console.ReadLine()
        Console.WriteLine("ingrese el tiempo:")
        t = Console.ReadLine()

        i = m * r * t / 360 * 100
        Console.WriteLine("el interes es {0} ", i)

        Console.WriteLine("el monto total es {0}", i + m)







    End Sub
End Module

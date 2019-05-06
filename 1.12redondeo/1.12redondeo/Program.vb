Imports System

Module Program
    Sub Main()

        Dim real As Double

        Console.WriteLine("ingrese un nuemro real: ")
        real = Console.ReadLine()

        Console.WriteLine("celing {0}", Math.Ceiling(real))
        Console.WriteLine("floor{0}", Math.Floor(real))
        Console.WriteLine("round {0}", Math.Round(real, 2))
        Console.WriteLine("trouncate {0}", Math.Truncate(real))


    End Sub
End Module

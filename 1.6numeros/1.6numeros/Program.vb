Imports System

Module Program
    Sub Main()

        Dim uno, dos, tres, cuatro, sumatoria, total As Integer

        Console.WriteLine("ingrese un numero : ")
        uno = Console.ReadLine()
        Console.WriteLine("ingrese un numero : ")
        dos = Console.ReadLine()
        Console.WriteLine("ingrese un numero : ")
        tres = Console.ReadLine()
        Console.WriteLine("ingrese un numero : ")
        cuatro = Console.ReadLine()


        sumatoria = sumatoria + (uno + dos + tres + cuatro)
        Console.WriteLine("el resultado de la suma es :" & sumatoria)
        total = total + (sumatoria / 2)
        Console.WriteLine("la media de los numero es :" & total)








    End Sub
End Module

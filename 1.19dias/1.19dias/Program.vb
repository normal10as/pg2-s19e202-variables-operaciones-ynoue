Imports System

Enum dias
    domingo = 1
    lunes = 2
    martes = 3
    miercoles = 4
    jueves = 5
    viernes = 6
    sabado = 7
End Enum

Module Program
    Sub Main(args As String())
        Dim diaingresado As Integer

        Console.WriteLine("ingrese un dia: (1-7)")
        diaingresado = Console.ReadLine

        Console.WriteLine(CType(diaingresado, dias).ToString)
    End Sub
End Module
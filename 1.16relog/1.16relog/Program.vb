Imports System.DateTime
Module reloj
    Sub Main()

        Dim anio, mes, hora, minuto, dia As Integer

        anio = Now.Year
        mes = Now.Month
        hora = Now.Hour
        minuto = Now.Minute
        dia = Now.DayOfYear

        Console.WriteLine("El anio de ejecucion es {0}", anio)
        Console.WriteLine("El dia de ejecucion es {0}", dia)
        Console.WriteLine("El mes de ejecucion es {0}", mes)
        Console.WriteLine("La hora de ejecucion es {0}", hora)
        Console.WriteLine("El minuto de ejecucion es {0}", minuto)
    End Sub
End Module
Imports System.DateTime

Module Program
    Sub Main()
        Dim dia As Integer
        Dim fechaingresada, fechacreada As Date

        Console.WriteLine("Ingrese un dia: (1-31)")
        dia = Console.ReadLine

        Console.WriteLine("Ingrese una fecha: #mm/dd/aaaa#")
        fechaingresada = Console.ReadLine

        fechacreada = fechaingresada.AddDays(dia)

        Console.WriteLine("La fecha creada con varibale es: " & fechacreada.Date)

        Console.WriteLine("La fecha creada es sin variable: " & fechaingresada.Date.AddDays(dia))
    End Sub
End Module
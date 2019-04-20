Imports System

Module Program
    Sub Main()
        Dim nombre As String
        Dim apellido As String
        Dim fechanacimiento As Date

        Console.WriteLine("ingrese el nombre: ")
        nombre = Console.ReadLine()
        Console.WriteLine("ingrese el apellido: ")
        apellido = Console.ReadLine()
        Console.WriteLine("ingrese la fecha de nacimiento: ")
        fechanacimiento = Console.ReadLine()

        Console.WriteLine(apellido & " " & nombre & " nacio el " & fechanacimiento)
    End Sub
End Module

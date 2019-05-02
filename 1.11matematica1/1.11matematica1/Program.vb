Imports System

Module Program
    Sub Main()

        Dim numero As Integer
        Dim valorab As Integer
        Dim elevado As Integer
        Dim raiz As Integer

        Console.WriteLine("ingrese una variable:")
        numero = Console.ReadLine()

        valorab = Math.Abs(numero)
        elevado = Math.Pow(numero, 10)
        raiz = Math.Sqrt(numero)

        Console.WriteLine("su valor absoluto es: " & " " & valorab & " " & "elevado a la decima potencia: " & " " & elevado & " " & "su raiz cuadrada: " & " " & raiz)




    End Sub
End Module

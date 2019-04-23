Imports System

Module Program
    Sub Main()
        Dim nombredepersona As String
        Dim numerodedocumento As UInteger
        Dim lugardenacimiento As String
        Dim fechadenacimiento As Date
        Dim alturacorporal As Byte
        Dim argentino As Boolean
        Dim temperatura As SByte
        Dim nombrecalle As String
        Dim alturacalle As UShort
        Dim distanciaciudades As UShort
        Dim profundidadmar As UShort
        Dim cantidadhabitantes As Integer
        Dim pesoproducto As Decimal
        Dim montoarticulo As Decimal


        nombredepersona = "Pepe Sanchez"
        numerodedocumento = 20124596
        lugardenacimiento = "Posadas"
        fechadenacimiento = # 9/10/1990 #
        alturacorporal = 175
        argentino = True
        temperatura = 35
        nombrecalle = "los lapachos"
        alturacalle = 1365
        distanciaciudades = 20.5
        profundidadmar = 75.3
        cantidadhabitantes = 370000000
        pesoproducto = 500
        montoarticulo = 40


        Console.WriteLine("Nombre :" & nombredepersona)
        Console.WriteLine("Documento : " & numerodedocumento)
        Console.WriteLine("Lugar de Nacimiento : " & lugardenacimiento)
        Console.WriteLine("fecha de Nacimiento : " & fechadenacimiento)
        Console.WriteLine("Altura Corporal : " & alturacorporal)
        Console.WriteLine("Argetino : " & argentino)
        Console.WriteLine("temperatura mbiente : " & temperatura & "°")
        Console.WriteLine("Nombre de calle : " & nombrecalle)
        Console.WriteLine("Altura de calle : " & alturacalle)
        Console.WriteLine("Distancia entre dos ciudades:" & distanciaciudades & " " & "km")
        Console.WriteLine("Profundidad del mar : " & profundidadmar & " " & "km")
        Console.WriteLine("Cantidad de habitantes : " & cantidadhabitantes)
        Console.WriteLine("Peso de un producto : " & pesoproducto & " " & "Grs")
        Console.WriteLine("Monto de articulo : " & "$" & montoarticulo)



    End Sub
End Module

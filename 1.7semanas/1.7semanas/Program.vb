Imports System

Module semanas
    Sub Main()

        Const diasanio As Integer = 365
        Const dialaboral As Integer = 7
        Const diasemana As Integer = 5

        Dim semanasanio As Integer
        Dim semanalaboral As Integer

        semanasanio = (diasanio / dialaboral)
        semanalaboral = ((diasanio / diasemana) - (diasanio / dialaboral))

        Console.WriteLine("las semanas del anio son : {0}", semanasanio)
        Console.Write("las semanas laborales  son : {0}", semanalaboral)



    End Sub
End Module

Module Module1

    Sub Main()
        Dim diasdelanio As UShort = 365
        Dim diaslaborales As UShort
        Dim diasemana As Byte = 7
        Dim operacion As UShort
        Dim semanaanio As UShort = diasdelanio / diasemana
        Console.WriteLine("Dias del anio: " & " " & diasdelanio)
        Console.WriteLine("semanas del anio: " & " " & semanaanio)

        Console.Read()



    End Sub

End Module

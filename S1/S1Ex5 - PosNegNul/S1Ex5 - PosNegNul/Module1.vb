Module Module1

    Sub Main()
        Console.Write("Veuillez entrer un nombre entier : ")
        Dim entier As Integer = CInt(Console.ReadLine())

        If entier < 0 Then
            Console.WriteLine($"Le nombre {entier} est negatif")
        ElseIf entier > 0 Then
            Console.WriteLine($"Le nombre {entier} est possitif")
        Else
            Console.WriteLine($"Le nombre {entier} est nul")
        End If

        Console.ReadKey()
    End Sub

End Module

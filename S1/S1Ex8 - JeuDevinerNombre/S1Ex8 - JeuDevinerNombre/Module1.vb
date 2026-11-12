Module Module1

    Sub Main()
        Dim nombreADeviner = New Random().Next(1, 101)
        Dim nombreUser = 0
        Dim nbEssais = 0
        While nombreUser <> nombreADeviner
            Console.Write("Entrez votre nb : ")
            nbEssais += 1
            nombreUser = CInt(Console.ReadLine())
            If nombreUser > nombreADeviner Then
                Console.WriteLine("Trop grand !")
            ElseIf nombreUser < nombreADeviner Then
                Console.WriteLine("Trop petit !")
            Else
                Console.WriteLine($"bravo vous avez trouvé en {nbEssais} essais")
            End If
        End While

        Console.WriteLine($"{vbCrLf}{vbCrLf}pressez une touche pour quit")
        Console.ReadKey()

    End Sub

End Module

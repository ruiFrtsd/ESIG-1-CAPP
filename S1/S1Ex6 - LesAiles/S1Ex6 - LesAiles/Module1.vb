Module Module1

    Sub Main()
        Console.Write("Entrez un prix initial : ")
        Dim prixInit As Integer = CInt(Console.ReadLine())
        Console.Write("Entrez un type de voyageur : ")
        Dim typeVoyageur As Integer = CInt(Console.ReadLine())
        Console.Write("Entrez un nombres de vols : ")
        Dim nbVols As Integer = CInt(Console.ReadLine())

        If prixInit < 0 Then
            Console.WriteLine("Le prix initial doit etre positif")
        End If
        If typeVoyageur <> 1 And typeVoyageur <> 2 And typeVoyageur <> 3 Then
            Console.WriteLine("type de voyageur inconnu")
        End If
        If nbVols < 0 Then
            Console.WriteLine("Le nombre de vols ne peut pas etre positif")
        End If
        Console.Read()
    End Sub

End Module

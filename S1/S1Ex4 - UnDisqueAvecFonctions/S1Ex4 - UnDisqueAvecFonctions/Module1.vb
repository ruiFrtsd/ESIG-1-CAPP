Module Module1

    Function perimetreCal(rayon As Double) As Double
        Dim perimetre = 2 * Math.PI * rayon

        Return perimetre
    End Function
    Function aireCal(rayon As Double) As Double
        Dim aire = Math.PI * Math.Pow(CDbl(rayon), 2)

        Return aire
    End Function

    Function afficherResultats(rayon As Integer) As String
        Console.WriteLine()
        Console.WriteLine($"    Le perimètre est {perimetreCal(rayon):0.00} unité-s de longueur")
        Console.WriteLine($"    L'aire est {aireCal(rayon):0.00} unité-s d'aire")
        Console.WriteLine()
        Console.WriteLine("Pressez une touche pour quitter l'application...")

    End Function

    Sub Main()
        Console.WriteLine("Calculs de perimètre et de l'aire d'un disque")
        Console.WriteLine()
        Console.Write("Veuillez donner le rayon du disque : ")
        Dim rayon As Integer = CInt(Console.ReadLine())

        afficherResultats(rayon)
        Console.ReadKey()

    End Sub

End Module

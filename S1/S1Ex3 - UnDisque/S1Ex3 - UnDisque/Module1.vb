Module Module1

    Sub Main()
        Console.WriteLine("Calculs de perimètre et de l'aire d'un disque")
        Console.WriteLine()
        Console.Write("Veuillez donner le rayon du disque : ")
        Dim rayon As Integer = CInt(Console.ReadLine())

        Dim perimetre = 2 * Math.PI * rayon

        Dim aire = Math.PI * Math.Pow(CDbl(rayon), 2)

        Console.WriteLine()
        Console.WriteLine($"    Le perimètre est {perimetre:0.00} unité-s de longueur")
        Console.WriteLine($"    L'aire est {aire:0.00} unité-s d'aire")
        Console.WriteLine()
        Console.WriteLine("Pressez une touche pour quitter l'application...")
        Console.ReadKey()


    End Sub

End Module

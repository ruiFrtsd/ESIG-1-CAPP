Module Module1

    Sub Main()
        Console.Write("Quel est votre prénom ? ")
        Dim prenom As String = Console.ReadLine()
        Console.Write("Quel est votre nom ? ")
        Dim nom As String = Console.ReadLine()
        Console.Write("Quel est votre année de naissance ? ")
        Dim age As Integer = CInt(Console.ReadLine())

        Console.WriteLine()
        Console.WriteLine($"Bonjour {prenom} {nom}. Vous avez {Year(Now) - age} ans.")
        Console.WriteLine()


        Console.Write("Pressez sur une touche pour quitter l'application... ")
        Console.ReadKey()

    End Sub

End Module

Module Module1

    Sub Main()
        Console.Write("Entrez une valeur de K : ")
        Dim k As Integer = CInt(Console.ReadLine)

        Console.Write("Entrez une valeur de N : ")
        Dim n As Integer = CInt(Console.ReadLine)

        Console.WriteLine("Table de multiplication de " + CStr(n) + " : ")

        For index = 1 To k
            Console.WriteLine(CStr(index) + " x " + CStr(n) + " = " + CStr(index * n))
        Next

        Console.Read()
    End Sub

End Module

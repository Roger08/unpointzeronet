Module ModPrgm
    Sub Main()
        ' -- Définitions tableaux --
        ReDim PlayerTemp(MAX_PLAYERS)
        ReDim Player(MAX_PLAYERS)

        ' -- Chargement serveur --
        Call Init()
        Console.Read()
    End Sub
End Module

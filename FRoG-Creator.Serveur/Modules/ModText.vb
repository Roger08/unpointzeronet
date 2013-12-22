
' ######################################
' ##         FRoG Creator 1.0         ##
' ##   Module de gestion des textes   ##
' ## Dernière modification : XX/XX/XX ##
' ######################################

Module ModText
    Public Sub Show(ByVal Message As String)
        Console.WriteLine("> " & Message)
    End Sub

    Public Sub ShowSuccess(ByVal Message As String)
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("> OK : " & Message)
        Console.ForegroundColor = ConsoleColor.DarkGray
    End Sub

    Public Sub ShowError(ByVal Message As String)
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("> ERROR : " & Message)
        Console.ForegroundColor = ConsoleColor.DarkGray
    End Sub

    Public Sub ShowInfo(ByVal Message As String)
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("> " & Message)
        Console.ForegroundColor = ConsoleColor.DarkGray
    End Sub
End Module

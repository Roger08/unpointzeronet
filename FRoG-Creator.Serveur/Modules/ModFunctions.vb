Imports System.IO

' ######################################
' ##         FRoG Creator 1.0         ##
' ##   Fonctions vitales au serveur   ##
' ## Dernière modification : XX/XX/XX ##
' ######################################

Module ModFunctions

    ' - Trouve un slot disponible pour un nouveau client
    Public Function FindFreeSlot() As Byte
        Dim temp As Byte

        For i = 1 To MAX_PLAYERS
            If Not PlayerTemp(i).Connected Then
                temp = i
                Exit For
            End If
        Next

        Return (temp)
    End Function

    ' - Verifie si le pseudo est déjà pris
    Public Function FreeCharName(ByVal name As String) As Boolean
        Dim temp As Boolean = True

        Dim Chars() As String = File.ReadAllLines("Comptes/Charlist.txt")

        For i = 0 To Chars.Length - 1
            If Chars(i).ToLower = name.ToLower Then
                temp = False
                Return (temp)
            End If
        Next

        Return temp
    End Function
End Module

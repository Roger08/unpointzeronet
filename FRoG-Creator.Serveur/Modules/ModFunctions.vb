
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

End Module

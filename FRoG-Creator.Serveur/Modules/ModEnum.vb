
' ######################################
' ##         FRoG Creator 1.0         ##
' ##     Enumérations des paquets     ##
' ## Dernière modification : XX/XX/XX ##
' ######################################

Module ModEnum

    ' -- Paquets envoyés par le client --
    Public Enum ClientPacket As Byte
        ' Client
        Login

        ' Editeur
        ELogin
    End Enum

    ' -- Paquets envoyés par le serveur --
    Public Enum ServerPacket As Byte
        ' Client
        LoginReturn

        ' Editeur
        ELoginReturn
    End Enum

End Module

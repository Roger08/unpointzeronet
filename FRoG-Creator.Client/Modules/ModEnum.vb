Module ModEnum

    ' -- Paquets envoyés par le client --
    Public Enum ClientPacket As Byte
        ' Client
        Login
        Register
        NewChar
    End Enum

    ' -- Paquets envoyés par le serveur --
    Public Enum ServerPacket As Byte
        ' Client
        LoginReturn
        RegisterReturn
        Message
        SendChars
        NewCharReturn
    End Enum

    ' -- Types de messages affichés par le client/l'éditeur --
    Public Enum ClientMessageType As Byte
        Fatal
        Info
    End Enum

End Module

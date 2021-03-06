﻿Imports System.Net.Sockets
Imports System.Text

Module ModNetwork

    ' - Initialisation du protocole réseau
    Public Sub Init()
        ' Initialisation des structures
        Call InitStructures()

        ' Initialisation des paquets
        Call InitPackets()

        ' Initialisation + connexion du socket
        _Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Try
            _Socket.Connect("localhost", Port)
        Catch
            MsgBox("Le serveur semble indisponible, veuillez vous reconnecter ultérieurement.", MsgBoxStyle.Critical, "Erreur de connexion")
            End
        End Try
        _Stream = New NetworkStream(_Socket)
        Call Gameloop()
    End Sub

    ' - Initialisation des différents paquets provenant du serveur
    Public Sub InitPackets()
        PaquetHandler.Add(ServerPacket.Message, AddressOf DispMessage)
        PaquetHandler.Add(ServerPacket.LoginReturn, AddressOf LoginReturn)
        PaquetHandler.Add(ServerPacket.SendChars, AddressOf GetChars)
        PaquetHandler.Add(ServerPacket.NewCharReturn, AddressOf NewCharReturn)
    End Sub

    ' - Deconnecte le client
    Public Sub LogOut()
        _Socket.Close()
        _Stream = Nothing
        '_Stream.Dispose()
    End Sub

    ' - Envoi de paquet
    Public Sub SendPacket(ByVal Packet As String)
        Dim PacketByte() As Byte

        If _Socket.Connected Then
            Try
                PacketByte = ASCIIEncoding.UTF8.GetBytes(Packet & SEP & FIN)
                _Stream.Write(PacketByte, 0, PacketByte.Length)
                _Stream.Flush()
            Catch
                MsgBox("Erreur lors de l'envoi du paquet", MsgBoxStyle.Critical, "Erreur fatale")
                End
            End Try
        End If
    End Sub

    ' - Récéption du paquet
    Public Sub ReceivePackets()

        ' - Variables utilisées pour la récéption + le traitement du paquet
        Dim PacketByte() As Byte
        Dim PacketString As String
        Dim Packet() As String
        Dim temp() As String

        ' - Boucle de récéption des paquets
        With _Socket
            If .Connected Then
                If .Poll(10, SelectMode.SelectRead) And .Available = 0 Then
                    ' Socket serveur semble déconnecté
                    Call LogOut()

                ElseIf .Available > 0 Then

                    ' - Socket client semble connecté et à envoyé un paquet
                    ReDim PacketByte(.Available) ' Défini la taille du paquet
                    _Stream.Read(PacketByte, 0, PacketByte.Length) ' Lecture du paquet
                    PacketString = ASCIIEncoding.UTF8.GetString(PacketByte) ' Convertion du paquet
                    Packet = PacketString.Split(FIN) ' Découpe des paquets possiblement collés

                    ' - Boucle vérifiant que plusieurs paquet ne sont pas collés
                    For i = 0 To Packet.Length - 2
                        ' - Traite le paquet
                        temp = Packet(i).Split(SEP) ' Récupère l'entête
                        Try
                            PaquetHandler(CByte(temp(0)))(Packet(i)) ' Apelle la fonction correspondante au paquet
                        Catch
                        End Try
                    Next
                End If
            End If
        End With
    End Sub

#Region "Actions necessitant des paquets"

#End Region

#Region "Actions enclenchées par les paquets"
    Public Sub DispMessage(ByVal Datas As String)
        ' Récupère le corps du paquet
        Dim Data() As String = Datas.Split(SEP)

        If Data(1) = ClientMessageType.Fatal Then
            MsgBox(Data(2), MsgBoxStyle.Critical, "Erreur")
        ElseIf Data(1) = ClientMessageType.Info Then
            MsgBox(Data(2), MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Public Sub LoginReturn(ByVal Datas As String)
        ' Récupère le corps du paquet
        Dim Data() As String = Datas.Split(SEP)

        frmCharSelect.Show()
        frmMainMenu.Visible = False
    End Sub

    Public Sub GetChars(ByVal Datas As String)
        ' Récupère le corps du paquet
        Dim Data() As String = Datas.Split(SEP)

        MyIndex = Data(1)
        ReDim Player(MyIndex).Charac(MAX_CHARS)

        For i = 0 To MAX_CHARS
            Player(MyIndex).Charac(i).Name = Data(7 * i + 2)
            Player(MyIndex).Charac(i).Level = Data(7 * i + 3)
            Player(MyIndex).Charac(i).Classe = Data(7 * i + 4)
            Player(MyIndex).Charac(i).Sex = Data(7 * i + 5)
            Player(MyIndex).Charac(i).Map = Data(7 * i + 6)
            Player(MyIndex).Charac(i).X = Data(7 * i + 7)
            Player(MyIndex).Charac(i).Y = Data(7 * i + 8)
        Next
    End Sub

    Public Sub NewCharReturn(ByVal Datas As String)
        ' Récupère le corps du paquet
        Dim Data() As String = Datas.Split(SEP)

        With Player(MyIndex).Charac(Data(1))
            .Name = Data(2)
            .Level = Data(3)
            .Classe = Data(4)
            .Sex = Data(5)
            .Map = Data(6)
            .X = Data(7)
            .Y = Data(8)
        End With

        Call frmCharSelect.DispCharlist(Data(1))
        frmCharSelect.pnlNewChar.Visible = False
    End Sub
#End Region

End Module

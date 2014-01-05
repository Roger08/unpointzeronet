Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Text
Imports System.IO

' ######################################
' ##         FRoG Creator 1.0         ##
' ##     Module de gestion réseau     ##
' ## Dernière modification : XX/XX/XX ##
' ######################################

Module ModNetwork

    ' - Initialisation du protocole réseau
    Public Sub Init()
        ' Initialisation des paquets
        Call InitPackets()

        ' Initialisation du socket
        _Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        _Socket.Bind(New IPEndPoint(IPAddress.Any, Port))
        _Socket.Listen(0)
        Call ShowInfo("Serveur ouvert sur le port " & Port)

        ' Lancement de l'écoute
        _Socket.BeginAccept(AddressOf AcceptClient, Nothing)
    End Sub

    ' - Initialisation des différents paquets provenant du client
    Public Sub InitPackets()
        PaquetHandler.Add(ClientPacket.Login, AddressOf Login)
        PaquetHandler.Add(ClientPacket.Register, AddressOf Register)
        PaquetHandler.Add(ClientPacket.NewChar, AddressOf NewChar)
    End Sub

    ' - Accepte un client de manière asynchrone
    Public Sub AcceptClient(ByVal IR As IAsyncResult)
        Try
            CurrentIndex = FindFreeSlot()

            With PlayerTemp(CurrentIndex)
                '.Receiver.Dispose()
                .Socket = _Socket.EndAccept(IR)
                .IP = (CType(.Socket.RemoteEndPoint, IPEndPoint).Address.ToString)
                LstIndex.Add(CurrentIndex)
                .Connected = True
                Call ShowInfo("Un client vient de se connecter sur le slot #" & CurrentIndex & " depuis l'IP " & .IP & ".")
                .Stream = New NetworkStream(.Socket)
                .Thread = New Thread(AddressOf ReceivePackets)
                .Thread.Start()
            End With
        Catch
        End Try

        _Socket.BeginAccept(AddressOf AcceptClient, Nothing)
    End Sub

    Private Sub ReceivePackets()
        Dim index As Integer = LstIndex(LstIndex.Count - 1)
        ' - Variables utilisées pour la récéption + le traitement du paquet
        Dim PacketByte() As Byte
        Dim PacketString As String
        Dim Packet() As String
        Dim temp() As String

        ' - Boucle de récéption des paquets
        With PlayerTemp(index)
            While .Socket.Connected
                If .Socket.Poll(10, SelectMode.SelectRead) And .Socket.Available = 0 Then
                    ' Socket client semble déconnecté
                    Call LogOut(index)

                ElseIf .Socket.Available > 0 Then
                    ' - Socket client semble connecté et à envoyé un paquet
                    ReDim PacketByte(.Socket.Available) ' Défini la taille du paquet
                    .Stream.Read(PacketByte, 0, PacketByte.Length) ' Lecture du paquet
                    PacketString = ASCIIEncoding.UTF8.GetString(PacketByte) ' Convertion du paquet
                    Packet = PacketString.Split(FIN) ' Découpe des paquets possiblement collés

                    ' - Boucle vérifiant que plusieurs paquet ne sont pas collés
                    For i = 0 To Packet.Length - 2
                        ' - Traite le paquet
                        Try
                            temp = Packet(i).Split(SEP) ' Récupère l'entête
                            PaquetHandler(CByte(temp(0)))(index, Packet(i)) ' Apelle la fonction correspondante au paquet
                        Catch
                            Call ShowError("Erreur lors du traitement du paquet")
                        End Try
                    Next
                End If
            End While
        End With
    End Sub

    ' - Déconnecte un client
    Public Sub LogOut(ByVal index As Integer)
        'Dim tempPseudo As String = Joueur(index).NomPerso
        LstIndex.Remove(index)

        'If Not Joueur(index).Nom = Nothing Then
        'Call ShowDeconnexion(Joueur(index).Nom & "/" & Joueur(index).NomPerso & " vient de se deconnecter")
        ' TODO : Nettoyage des infos du joueur
        'End If

        ' TODO : Envoie aux autres client le joueur "vide"

        ' TODO : Afficher aux autres joueur la déconnexion

        With PlayerTemp(index)
            Call ShowInfo("Client sur le slot #" & index & " vient de se deconnecter")
            .Socket.Close()
            .Connected = False
            .InGame = False
            .Stream = Nothing
            .Thread.Abort()
        End With
    End Sub

    ' - Envoyer un paquet à tous les clients
    Public Sub SendToAllClients(ByVal Packet As String)
        For i = 0 To LstIndex.Count - 1
            Call SendPacket(LstIndex(i), Packet)
        Next
    End Sub

    ' - Envoyer un paquet à tous les joueurs
    Public Sub SendToAllPlayers(ByVal Packet As String)
        For i = 0 To LstIndex.Count - 1
            If PlayerTemp(LstIndex(i)).InGame Then
                Call SendPacket(LstIndex(i), Packet)
            End If
        Next
    End Sub

    ' - Envoyer un Paquet à un client
    Public Sub SendPacket(ByVal index As Integer, ByVal Packet As String)
        Dim PacketByte() As Byte

        If PlayerTemp(index).Connected Then
            Try
                PacketByte = ASCIIEncoding.UTF8.GetBytes(Packet & SEP & FIN)
                PlayerTemp(index).Stream.Write(PacketByte, 0, PacketByte.Length)
                PlayerTemp(index).Stream.Flush()
                Thread.Sleep(5)
            Catch
                Call ShowError("Erreur lors de l'envoie du paquet au client #" & index)
            End Try
        End If
    End Sub

#Region "Actions necessitant des paquets"
    Public Sub SendMessage(ByVal index As Integer, ByVal MessageType As Byte, ByVal Message As String)
        Call SendPacket(index, ServerPacket.Message & SEP & MessageType & SEP & Message)
    End Sub

    Public Sub SendChars(ByVal index As Integer)
        Dim Packet As String = ServerPacket.SendChars & SEP & index & SEP
        ReDim Player(index).Charac(MAX_CHARS)
        For i = 0 To MAX_CHARS
            Packet = Packet & Player(index).Charac(i).Name & SEP
            Packet = Packet & Player(index).Charac(i).Level & SEP
            Packet = Packet & Player(index).Charac(i).Classe & SEP
            Packet = Packet & Player(index).Charac(i).Sex & SEP
            Packet = Packet & Player(index).Charac(i).Map & SEP
            Packet = Packet & Player(index).Charac(i).X & SEP
            Packet = Packet & Player(index).Charac(i).Y & SEP
        Next
        Call SendPacket(index, Packet)
    End Sub
#End Region

#Region "Actions enclenchées par les paquets"
    Public Sub Login(ByVal index As Integer, ByVal Datas As String)
        ' Récupère le corps du paquet
        ' (LOGIN SEP MOT_DE_PASSE)
        Dim Data() As String = Datas.Split(SEP)

        If Not Data(1).Length < 3 Or Not Data(2).Length < 5 Then
            If File.Exists("Comptes/" & Data(1).ToLower & ".fcj") Then
                Call LoadPlayer(index, Data(1))
                If Player(index).Password = Data(2) Then
                    If Not PlayerTemp(index).InGame Then
                        'TODO : Envoyer les infos au client
                        Call SendChars(index)
                        Call SendPacket(index, ServerPacket.LoginReturn)
                    Else
                        Call SendMessage(index, ClientMessageType.Fatal, "Le joueur est déjà connecté !")
                    End If
                Else
                    Call SendMessage(index, ClientMessageType.Fatal, "Identifiants incorrects !")
                End If
            Else
                Call SendMessage(index, ClientMessageType.Fatal, "Identifiants incorrects !")
            End If
        End If
    End Sub

    Public Sub Register(ByVal index As Integer, ByVal Datas As String)
        ' Récupère le corps du paquet
        Dim Data() As String = Datas.Split(SEP)

        If Not Data(1).Length < 3 Or Not Data(2).Length < 5 Then
            If Not File.Exists("Comptes/" & Data(1).ToLower & ".fcj") Then
                Player(index).Username = Data(1)
                Player(index).Password = Data(2)
                Call SavePlayer(index)
                Call ShowInfo("Le compte " & Data(1) & " vient d'être créé")
                Call ClearPlayer(index)
                Call SendMessage(index, ClientMessageType.Info, "Votre compte a bien été créé !")
            Else
                Call SendMessage(index, ClientMessageType.Fatal, "Ce compte existe déjà !")
            End If
        End If
    End Sub

    Public Sub NewChar(ByVal index As Integer, ByVal Datas As String)

    End Sub
#End Region
End Module

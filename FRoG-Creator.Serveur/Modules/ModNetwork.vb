Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Text

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
    Public Sub SendToAllClients(ByVal Paquet As String)
        For i = 0 To LstIndex.Count - 1
            Call EnvoyerPaquet(LstIndex(i), Paquet)
        Next
    End Sub

    ' - Envoyer un paquet à tous les joueurs
    Public Sub SendToAllPlayers(ByVal Paquet As String)
        For i = 0 To LstIndex.Count - 1
            If PlayerTemp(LstIndex(i)).InGame Then
                Call EnvoyerPaquet(LstIndex(i), Paquet)
            End If
        Next
    End Sub

    ' - Envoyer un Paquet à un client
    Public Sub EnvoyerPaquet(ByVal index As Byte, ByVal Paquet As String)
        Dim PaquetByte() As Byte

        If PlayerTemp(index).Connected Then
            Try
                PaquetByte = ASCIIEncoding.UTF8.GetBytes(Paquet & SEP & FIN)
                PlayerTemp(index).Stream.Write(PaquetByte, 0, PaquetByte.Length)
                PlayerTemp(index).Stream.Flush()
                Thread.Sleep(5)
            Catch
                Call ShowError("Erreur lors de l'envoie du paquet au client #" & index)
            End Try
        End If
    End Sub

    Public Sub Login(ByVal index As Integer, ByVal Datas As String)

    End Sub

End Module

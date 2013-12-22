Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports FRoG_Creator.Format.ClsStructures

Module ModDB

    ' - Charge en mémoire un Player
    Public Sub LoadPlayer(ByVal index As Integer, ByVal username As String)
        Dim FluxFichier As Stream
        Dim Deserialiseur As New BinaryFormatter

        FluxFichier = File.OpenRead("Comptes/" & username.ToLower & ".wotg")
        Player(index) = CType(Deserialiseur.Deserialize(FluxFichier), PlayerRec)
        FluxFichier.Close() : FluxFichier.Dispose()
    End Sub

    ' - Efface un Player de la mémoire
    Public Sub ClearPlayer(ByVal index As Integer)
        Player(index) = New PlayerRec
    End Sub

    ' - Sauvegarde un Player
    Public Sub SavePlayer(ByVal index As Integer)
        Dim FluxFichier As Stream
        Dim Serialiseur As New BinaryFormatter

        If Not Player(index).Username = Nothing Then
            FluxFichier = File.Create("Comptes/" & Player(index).Username.ToLower & ".wotg")
            Serialiseur.Serialize(FluxFichier, Player(index))
            FluxFichier.Close()
        End If
    End Sub

End Module

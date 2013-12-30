Imports System.Net.Sockets
Imports System.IO
Imports System.Threading

Public Class ClsStructures

    Public Structure PlayerTempRec
        Dim Socket As Socket
        Dim Stream As NetworkStream
        Dim Buffer() As Byte
        Dim BufPosition As Integer
        Dim Thread As Thread
        Dim IP As String
        Dim Connected As Boolean
        Dim InGame As Boolean
    End Structure

    <Serializable()>
    Public Structure PlayerRec
        Dim Username As String
        Dim Password As String

        Dim Charac() As CharRec
    End Structure

    <Serializable()>
    Public Structure CharRec
        Dim Name As String
        Dim Sex As Byte
        Dim Classe As Byte
        Dim Level As Integer
        Dim Exp As Integer
        Dim Access As Byte

        'Vie
        Dim HP As Integer
        Dim MP As Integer
        Dim SP As Integer

        'Position
        Dim Map As Integer
        Dim X As Integer
        Dim Y As Integer
        Dim Dir As Byte

        'Statistiques
        Dim STR As Integer
        Dim DEF As Integer
        Dim SPEED As Integer
        Dim MAGI As Integer
        Dim Points As Integer

        Dim ArmorSlot As Integer
        Dim WeaponSlot As Integer
        Dim HelmetSlot As Integer
        Dim ShieldSlot As Integer
        Dim PetSlot As Integer
    End Structure

End Class

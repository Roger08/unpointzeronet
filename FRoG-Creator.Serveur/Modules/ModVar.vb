Imports System.Net.Sockets
Imports FRoG_Creator.Format.ClsStructures

' ##########################################
' ##           FRoG Creator 1.0           ##
' ##   Module de stockage des variables   ##
' ##   Dernière modification : XX/XX/XX   ##
' ##########################################

Module ModVar

    ' -- Variables réseau --
    Public _Socket As Socket
    Public Port As Integer = 4000
    Public CurrentIndex As Byte
    Public LstIndex As New ArrayList
    Public SEP As Char = Chr(0)
    Public FIN As Char = Chr(237)
    Public PaquetHandler As New Dictionary(Of Byte, Action(Of Byte, String))

    ' -- Variables structures --
    Public PlayerTemp() As PlayerTempRec

    ' -- Variables Max --
    Public MAX_PLAYERS As Integer = 500

End Module

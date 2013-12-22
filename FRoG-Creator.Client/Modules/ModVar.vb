Imports System.Net.Sockets
Imports FRoG_Creator.Format.ClsStructures

Module ModVar

    ' -- Variables réseau --
    Public _Socket As Socket
    Public _Stream As NetworkStream
    Public Port As Integer = 4000
    Public MyIndex As Byte
    Public SEP As Char = Chr(0)
    Public FIN As Char = Chr(237)
    Public LstIndex As New ArrayList
    Public PaquetHandler As New Dictionary(Of Byte, Action(Of String))

    ' -- Variables structures --
    Public PlayerTemp() As PlayerTempRec
    Public Player() As PlayerRec

    ' -- Variables Max --
    Public MAX_PLAYERS As Integer = 500

End Module

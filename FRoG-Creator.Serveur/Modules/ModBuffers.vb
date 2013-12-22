Imports System.Text

' ######################################
' ##         FRoG Creator 1.0         ##
' ##  Module de gestion des buffers   ##
' ## Dernière modification : XX/XX/XX ##
' ######################################

' -- Ce module n'est actuellement pas utilisé, les fonctions sont disponibles pour ceux qui souhaitent les intégrer --

Module ModBuffers

    ' -- Ecriture --
    Private Sub Write(ByVal index As Integer, ByVal data As Byte)
        With PlayerTemp(index)
            ReDim Preserve .Buffer(.BufPosition + 1)
            .Buffer(.BufPosition) = data
            .BufPosition += 1
        End With
    End Sub

    Public Sub WriteByte(ByVal index As Integer, ByVal data As Byte)
        Call Write(index, data)
    End Sub

    Public Sub WriteInt(ByVal index As Integer, ByVal data As Integer)
        Call WriteString(index, data.ToString())
    End Sub

    Public Sub WriteLong(ByVal index As Integer, ByVal data As Long)
        Call WriteString(index, data)
    End Sub

    Public Sub WriteString(ByVal index As Integer, ByVal data As String)
        Dim tmp() As Byte = ASCIIEncoding.UTF8.GetBytes(data)
        Call Write(index, tmp.Length)

        For i = 0 To tmp.Length - 1
            Call Write(index, tmp(i))
        Next
    End Sub

    ' -- Lecture --
    Private Function Read(ByVal index As Integer, ByRef Buffer() As Byte, ByRef Position As Integer) As Byte
        Position += 1
        Return Buffer(Position - 1)
    End Function

    Public Function ReadByte(ByVal index As Integer, ByRef Buffer() As Byte, ByRef Position As Integer) As Byte
        Return Read(index, Buffer, Position)
    End Function

    Public Function ReadInt(ByVal index As Integer, ByRef Buffer() As Byte, ByRef Position As Integer) As Integer
        Return Int(ReadString(index, Buffer, Position))
    End Function

    Public Function ReadLong(ByVal index As Integer, ByRef Buffer() As Byte, ByRef Position As Integer) As Long
        Return CLng(ReadString(index, Buffer, Position))
    End Function

    Public Function ReadString(ByVal index As Integer, ByRef Buffer() As Byte, ByRef Position As Integer) As String
        Dim tmp(ReadByte(index, Buffer, Position) - 1) As Byte

        For i = 0 To tmp.Length - 1
            tmp(i) = ReadByte(index, Buffer, Position)
        Next

        Return ASCIIEncoding.UTF8.GetString(tmp)
    End Function
End Module

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
    End Structure

End Class

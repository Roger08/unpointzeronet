Module ModGame

    Public Sub Gameloop()
        While _Socket.Connected

            ' - Reception des paquets
            Call ReceivePackets()

            If PlayerTemp(MyIndex).InGame Then
                ' - Rafraichissement de l'image
            End If
        End While
    End Sub
End Module
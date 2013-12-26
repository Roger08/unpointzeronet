Module ModGame

    Public Sub Gameloop()
        While _Socket.Connected

            ' - Reception des paquets
            Call ReceivePackets()

            If PlayerTemp(MyIndex).InGame Then
                ' - Rafraichissement de l'image
            End If

            Application.DoEvents()
        End While
    End Sub
End Module
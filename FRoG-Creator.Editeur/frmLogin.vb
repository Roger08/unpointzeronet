Imports System.Text
Imports System.Threading
Imports System.Net
Imports System.Net.Sockets

Public Class frmLogin

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' TODO : Chargement des options
    End Sub

    Private Sub Form1_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Call Init()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Not txtAccount.Text.Length < 3 Then
            If Not txtPswd.Text.Length < 5 Then
                Call SendPacket(ClientPacket.ELogin & SEP & txtAccount.Text & SEP & txtPswd.Text)
            Else
                MsgBox("Votre mot de passe ne peut pas faire moins de 5 caractères !", MsgBoxStyle.Critical, "Erreur de connexion")
            End If
        Else
            MsgBox("Votre pseudo ne peut pas faire moins de 3 carractères !", MsgBoxStyle.Critical, "Erreur de connexion")
        End If
    End Sub
End Class

Imports System.Net.Sockets
Imports System.Text

Public Class frmMainMenu

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Not txtInPseudo.Text.Length < 3 Then
            If Not txtInPswd.Text.Length < 5 Then
                If txtInPswd.Text = txtInPswd2.Text Then
                    ' TODO : Inscription
                Else
                    MsgBox("Les mots de passe sont différents.", MsgBoxStyle.Critical, "Erreur")
                End If
            Else
                MsgBox("Votre mot de passe doit faire au moins 5 caractères", MsgBoxStyle.Critical, "Erreur")
            End If
        Else
            MsgBox("Votre pseudo doit faire au moins 3 caractères.", MsgBoxStyle.Critical, "Erreur")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Not txtPseudo.Text.Length < 3 Then
            If Not txtpswd.Text.Length < 5 Then
                ' TODO : Connexion
            Else
                MsgBox("Votre mot de passe doit faire au moins 5 caractères", MsgBoxStyle.Critical, "Erreur")
            End If
        Else
            MsgBox("Votre pseudo doit faire au moins 3 caractères.", MsgBoxStyle.Critical, "Erreur")
        End If
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        pnlLogin.Visible = False
        pnlRegister.Visible = True
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        pnlLogin.Visible = True
        pnlRegister.Visible = False
    End Sub
End Class

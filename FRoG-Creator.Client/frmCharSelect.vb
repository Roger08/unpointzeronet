Imports FRoG_Creator.Format.ClsStructures

Public Class frmCharSelect

    Dim tmpIndex As Byte = 0
    Dim tmpSex As Byte = 0
    Dim Charlst(MAX_CHARS) As Collection

    Private Sub frmCharSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Charlst(0) = New Collection
        Charlst(0).Add(Name1)
        Charlst(0).Add(lblClass1)
        Charlst(0).Add(lblLevel1)
        Charlst(0).Add(btSelect1)
        Charlst(0).Add(btDelete1)

        Charlst(1) = New Collection
        Charlst(1).Add(Name2)
        Charlst(1).Add(lblClass2)
        Charlst(1).Add(lblLevel2)
        Charlst(1).Add(btSelect2)
        Charlst(1).Add(btDelete2)

        Charlst(2) = New Collection
        Charlst(2).Add(Name3)
        Charlst(2).Add(lblClass3)
        Charlst(2).Add(lblLevel3)
        Charlst(2).Add(btSelect3)
        Charlst(2).Add(btDelete3)

        Charlst(3) = New Collection
        Charlst(3).Add(Name4)
        Charlst(3).Add(lblClass4)
        Charlst(3).Add(lblLevel4)
        Charlst(3).Add(btSelect4)
        Charlst(3).Add(btDelete4)

        For i = 0 To 3
            If Not Player(MyIndex).Charac(i).Name = "" Then
                Call DispCharlist(i)
            Else
                Charlst(i).Item(1).text = "Slot libre"
                Charlst(i).Item(2).visible = False
                Charlst(i).Item(3).visible = False
                Charlst(i).Item(4).text = "Créer un personnage"
                Charlst(i).Item(5).visible = False
            End If
        Next
    End Sub

    Public Sub DispCharlist(ByVal charnum As Byte)
        Charlst(charnum).Item(1).visible = True
        Charlst(charnum).Item(2).visible = True
        Charlst(charnum).Item(3).visible = True
        Charlst(charnum).Item(4).visible = True
        Charlst(charnum).Item(5).visible = True
        Charlst(charnum).Item(4).text = "Choisir"

        With Player(MyIndex).Charac(charnum)
            Charlst(charnum).Item(1).text = .Name
            'TODO : Afficher les infos
        End With
    End Sub

    Private Sub btSelect1_Click(sender As System.Object, e As System.EventArgs) Handles btSelect1.Click
        If Not Player(MyIndex).Charac(0).Name = "" Then

        Else
            tmpIndex = 0
            pnlNewChar.Visible = True
        End If
    End Sub

    Private Sub btSelect2_Click(sender As System.Object, e As System.EventArgs) Handles btSelect2.Click
        If Not Player(MyIndex).Charac(1).Name = "" Then

        Else
            tmpIndex = 1
            pnlNewChar.Visible = True
        End If
    End Sub

    Private Sub btSelect3_Click(sender As System.Object, e As System.EventArgs) Handles btSelect3.Click
        If Not Player(MyIndex).Charac(2).Name = "" Then

        Else
            tmpIndex = 2
            pnlNewChar.Visible = True
        End If
    End Sub

    Private Sub btSelect4_Click(sender As System.Object, e As System.EventArgs) Handles btSelect4.Click
        If Not Player(MyIndex).Charac(3).Name = "" Then

        Else
            tmpIndex = 3
            pnlNewChar.Visible = True
        End If
    End Sub

    Private Sub btOK_Click(sender As System.Object, e As System.EventArgs) Handles btOK.Click
        If Not txtName.Text.Length < 3 Then
            If lstClass.SelectedIndex > 0 Then
                Call SendPacket(ClientPacket.NewChar & SEP & tmpIndex & SEP & txtName.Text & SEP & lstClass.SelectedIndex & SEP & tmpSex)
            Else
                Call SendPacket(ClientPacket.NewChar & SEP & tmpIndex & SEP & txtName.Text & SEP & 0 & SEP & tmpSex)
            End If
        Else
            MsgBox("Le nom de votre personnage doit comporter au moins 3 carractères !", MsgBoxStyle.Critical, "Erreur")
        End If
    End Sub
End Class
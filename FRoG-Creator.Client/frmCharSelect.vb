Imports FRoG_Creator.Format.ClsStructures

Public Class frmCharSelect

    Private Sub frmCharSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Charlst(MAX_CHARS) As Collection

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
                With Player(MyIndex).Charac(i)
                    Charlst(i).Item(1).text = .Name
                    'TODO : Afficher les infos
                End With
            Else
                Charlst(i).Item(1).text = "Slot libre"
                Charlst(i).Item(2).visible = False
                Charlst(i).Item(3).visible = False
                Charlst(i).Item(4).text = "Créer un personnage"
                Charlst(i).Item(5).visible = False
            End If
        Next
    End Sub

    Private Sub btSelect1_Click(sender As System.Object, e As System.EventArgs) Handles btSelect1.Click
        If Not Player(MyIndex).Charac(0).Name = "" Then

        Else
            frmNewChar.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub btSelect2_Click(sender As System.Object, e As System.EventArgs) Handles btSelect2.Click
        If Not Player(MyIndex).Charac(1).Name = "" Then

        Else
            frmNewChar.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub btSelect3_Click(sender As System.Object, e As System.EventArgs) Handles btSelect3.Click
        If Not Player(MyIndex).Charac(2).Name = "" Then

        Else
            frmNewChar.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub btSelect4_Click(sender As System.Object, e As System.EventArgs) Handles btSelect4.Click
        If Not Player(MyIndex).Charac(3).Name = "" Then

        Else
            frmNewChar.Show()
            Me.Visible = False
        End If
    End Sub
End Class
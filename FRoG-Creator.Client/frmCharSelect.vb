Imports FRoG_Creator.Format.ClsStructures

Public Class frmCharSelect

    Private Sub frmCharSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Charlst(3) As Collection

        Charlst(0) = New Collection
        Charlst(0).Add(Name1)

        Charlst(1) = New Collection
        Charlst(1).Add(Name2)

        Charlst(2) = New Collection
        Charlst(2).Add(Name3)

        Charlst(3) = New Collection
        Charlst(3).Add(Name4)

        'temp
        ReDim Player(MyIndex).Charac(3)

        For i = 0 To 3
            If Not Player(MyIndex).Charac(i).Name = "" Then

            Else
                Charlst(i).Item(1).text = "Slot libre"
            End If
        Next
    End Sub

End Class
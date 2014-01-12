<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharSelect
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlCharlist = New System.Windows.Forms.Panel()
        Me.pnlNewChar = New System.Windows.Forms.Panel()
        Me.picSprite = New System.Windows.Forms.PictureBox()
        Me.btOK = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.btMale = New System.Windows.Forms.Label()
        Me.lstClass = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btDelete4 = New System.Windows.Forms.Label()
        Me.btSelect4 = New System.Windows.Forms.Label()
        Me.lblLevel4 = New System.Windows.Forms.Label()
        Me.lblClass4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Name4 = New System.Windows.Forms.Label()
        Me.btDelete3 = New System.Windows.Forms.Label()
        Me.btSelect3 = New System.Windows.Forms.Label()
        Me.lblLevel3 = New System.Windows.Forms.Label()
        Me.lblClass3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Name3 = New System.Windows.Forms.Label()
        Me.btDelete2 = New System.Windows.Forms.Label()
        Me.btSelect2 = New System.Windows.Forms.Label()
        Me.lblLevel2 = New System.Windows.Forms.Label()
        Me.lblClass2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Name2 = New System.Windows.Forms.Label()
        Me.btDelete1 = New System.Windows.Forms.Label()
        Me.btSelect1 = New System.Windows.Forms.Label()
        Me.lblLevel1 = New System.Windows.Forms.Label()
        Me.lblClass1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Name1 = New System.Windows.Forms.Label()
        Me.pnlCharlist.SuspendLayout()
        Me.pnlNewChar.SuspendLayout()
        CType(Me.picSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCharlist
        '
        Me.pnlCharlist.Controls.Add(Me.pnlNewChar)
        Me.pnlCharlist.Controls.Add(Me.btDelete4)
        Me.pnlCharlist.Controls.Add(Me.btSelect4)
        Me.pnlCharlist.Controls.Add(Me.lblLevel4)
        Me.pnlCharlist.Controls.Add(Me.lblClass4)
        Me.pnlCharlist.Controls.Add(Me.PictureBox3)
        Me.pnlCharlist.Controls.Add(Me.Name4)
        Me.pnlCharlist.Controls.Add(Me.btDelete3)
        Me.pnlCharlist.Controls.Add(Me.btSelect3)
        Me.pnlCharlist.Controls.Add(Me.lblLevel3)
        Me.pnlCharlist.Controls.Add(Me.lblClass3)
        Me.pnlCharlist.Controls.Add(Me.PictureBox4)
        Me.pnlCharlist.Controls.Add(Me.Name3)
        Me.pnlCharlist.Controls.Add(Me.btDelete2)
        Me.pnlCharlist.Controls.Add(Me.btSelect2)
        Me.pnlCharlist.Controls.Add(Me.lblLevel2)
        Me.pnlCharlist.Controls.Add(Me.lblClass2)
        Me.pnlCharlist.Controls.Add(Me.PictureBox2)
        Me.pnlCharlist.Controls.Add(Me.Name2)
        Me.pnlCharlist.Controls.Add(Me.btDelete1)
        Me.pnlCharlist.Controls.Add(Me.btSelect1)
        Me.pnlCharlist.Controls.Add(Me.lblLevel1)
        Me.pnlCharlist.Controls.Add(Me.lblClass1)
        Me.pnlCharlist.Controls.Add(Me.PictureBox1)
        Me.pnlCharlist.Controls.Add(Me.Name1)
        Me.pnlCharlist.Location = New System.Drawing.Point(12, 12)
        Me.pnlCharlist.Name = "pnlCharlist"
        Me.pnlCharlist.Size = New System.Drawing.Size(404, 347)
        Me.pnlCharlist.TabIndex = 0
        '
        'pnlNewChar
        '
        Me.pnlNewChar.Controls.Add(Me.picSprite)
        Me.pnlNewChar.Controls.Add(Me.btOK)
        Me.pnlNewChar.Controls.Add(Me.lblFemale)
        Me.pnlNewChar.Controls.Add(Me.btMale)
        Me.pnlNewChar.Controls.Add(Me.lstClass)
        Me.pnlNewChar.Controls.Add(Me.txtName)
        Me.pnlNewChar.Location = New System.Drawing.Point(0, 0)
        Me.pnlNewChar.Name = "pnlNewChar"
        Me.pnlNewChar.Size = New System.Drawing.Size(404, 347)
        Me.pnlNewChar.TabIndex = 1
        Me.pnlNewChar.Visible = False
        '
        'picSprite
        '
        Me.picSprite.Location = New System.Drawing.Point(189, 200)
        Me.picSprite.Name = "picSprite"
        Me.picSprite.Size = New System.Drawing.Size(32, 64)
        Me.picSprite.TabIndex = 11
        Me.picSprite.TabStop = False
        '
        'btOK
        '
        Me.btOK.AutoSize = True
        Me.btOK.Location = New System.Drawing.Point(155, 290)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(102, 13)
        Me.btOK.TabIndex = 10
        Me.btOK.Text = "Créer le personnage"
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.Location = New System.Drawing.Point(233, 147)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(41, 13)
        Me.lblFemale.TabIndex = 9
        Me.lblFemale.Text = "Femme"
        '
        'btMale
        '
        Me.btMale.AutoSize = True
        Me.btMale.Location = New System.Drawing.Point(128, 147)
        Me.btMale.Name = "btMale"
        Me.btMale.Size = New System.Drawing.Size(43, 13)
        Me.btMale.TabIndex = 8
        Me.btMale.Text = "Homme"
        '
        'lstClass
        '
        Me.lstClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstClass.FormattingEnabled = True
        Me.lstClass.Location = New System.Drawing.Point(96, 92)
        Me.lstClass.Name = "lstClass"
        Me.lstClass.Size = New System.Drawing.Size(212, 21)
        Me.lstClass.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(96, 43)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(212, 20)
        Me.txtName.TabIndex = 6
        '
        'btDelete4
        '
        Me.btDelete4.AutoSize = True
        Me.btDelete4.Location = New System.Drawing.Point(308, 275)
        Me.btDelete4.Name = "btDelete4"
        Me.btDelete4.Size = New System.Drawing.Size(54, 13)
        Me.btDelete4.TabIndex = 77
        Me.btDelete4.Text = "Supprimer"
        '
        'btSelect4
        '
        Me.btSelect4.AutoSize = True
        Me.btSelect4.Location = New System.Drawing.Point(254, 275)
        Me.btSelect4.Name = "btSelect4"
        Me.btSelect4.Size = New System.Drawing.Size(38, 13)
        Me.btSelect4.TabIndex = 76
        Me.btSelect4.Text = "Choisir"
        '
        'lblLevel4
        '
        Me.lblLevel4.AutoSize = True
        Me.lblLevel4.Location = New System.Drawing.Point(295, 247)
        Me.lblLevel4.Name = "lblLevel4"
        Me.lblLevel4.Size = New System.Drawing.Size(41, 13)
        Me.lblLevel4.TabIndex = 75
        Me.lblLevel4.Text = "Niveau"
        '
        'lblClass4
        '
        Me.lblClass4.AutoSize = True
        Me.lblClass4.Location = New System.Drawing.Point(295, 234)
        Me.lblClass4.Name = "lblClass4"
        Me.lblClass4.Size = New System.Drawing.Size(38, 13)
        Me.lblClass4.TabIndex = 74
        Me.lblClass4.Text = "Classe"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(257, 208)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 64)
        Me.PictureBox3.TabIndex = 73
        Me.PictureBox3.TabStop = False
        '
        'Name4
        '
        Me.Name4.AutoSize = True
        Me.Name4.Location = New System.Drawing.Point(295, 221)
        Me.Name4.Name = "Name4"
        Me.Name4.Size = New System.Drawing.Size(58, 13)
        Me.Name4.TabIndex = 72
        Me.Name4.Text = "Nom perso"
        '
        'btDelete3
        '
        Me.btDelete3.AutoSize = True
        Me.btDelete3.Location = New System.Drawing.Point(96, 275)
        Me.btDelete3.Name = "btDelete3"
        Me.btDelete3.Size = New System.Drawing.Size(54, 13)
        Me.btDelete3.TabIndex = 71
        Me.btDelete3.Text = "Supprimer"
        '
        'btSelect3
        '
        Me.btSelect3.AutoSize = True
        Me.btSelect3.Location = New System.Drawing.Point(42, 275)
        Me.btSelect3.Name = "btSelect3"
        Me.btSelect3.Size = New System.Drawing.Size(38, 13)
        Me.btSelect3.TabIndex = 70
        Me.btSelect3.Text = "Choisir"
        '
        'lblLevel3
        '
        Me.lblLevel3.AutoSize = True
        Me.lblLevel3.Location = New System.Drawing.Point(83, 247)
        Me.lblLevel3.Name = "lblLevel3"
        Me.lblLevel3.Size = New System.Drawing.Size(41, 13)
        Me.lblLevel3.TabIndex = 69
        Me.lblLevel3.Text = "Niveau"
        '
        'lblClass3
        '
        Me.lblClass3.AutoSize = True
        Me.lblClass3.Location = New System.Drawing.Point(83, 234)
        Me.lblClass3.Name = "lblClass3"
        Me.lblClass3.Size = New System.Drawing.Size(38, 13)
        Me.lblClass3.TabIndex = 68
        Me.lblClass3.Text = "Classe"
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(45, 208)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 64)
        Me.PictureBox4.TabIndex = 67
        Me.PictureBox4.TabStop = False
        '
        'Name3
        '
        Me.Name3.AutoSize = True
        Me.Name3.Location = New System.Drawing.Point(83, 221)
        Me.Name3.Name = "Name3"
        Me.Name3.Size = New System.Drawing.Size(58, 13)
        Me.Name3.TabIndex = 66
        Me.Name3.Text = "Nom perso"
        '
        'btDelete2
        '
        Me.btDelete2.AutoSize = True
        Me.btDelete2.Location = New System.Drawing.Point(308, 125)
        Me.btDelete2.Name = "btDelete2"
        Me.btDelete2.Size = New System.Drawing.Size(54, 13)
        Me.btDelete2.TabIndex = 65
        Me.btDelete2.Text = "Supprimer"
        '
        'btSelect2
        '
        Me.btSelect2.AutoSize = True
        Me.btSelect2.Location = New System.Drawing.Point(254, 125)
        Me.btSelect2.Name = "btSelect2"
        Me.btSelect2.Size = New System.Drawing.Size(38, 13)
        Me.btSelect2.TabIndex = 64
        Me.btSelect2.Text = "Choisir"
        '
        'lblLevel2
        '
        Me.lblLevel2.AutoSize = True
        Me.lblLevel2.Location = New System.Drawing.Point(295, 97)
        Me.lblLevel2.Name = "lblLevel2"
        Me.lblLevel2.Size = New System.Drawing.Size(41, 13)
        Me.lblLevel2.TabIndex = 63
        Me.lblLevel2.Text = "Niveau"
        '
        'lblClass2
        '
        Me.lblClass2.AutoSize = True
        Me.lblClass2.Location = New System.Drawing.Point(295, 84)
        Me.lblClass2.Name = "lblClass2"
        Me.lblClass2.Size = New System.Drawing.Size(38, 13)
        Me.lblClass2.TabIndex = 62
        Me.lblClass2.Text = "Classe"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(257, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 64)
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'Name2
        '
        Me.Name2.AutoSize = True
        Me.Name2.Location = New System.Drawing.Point(295, 71)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(58, 13)
        Me.Name2.TabIndex = 60
        Me.Name2.Text = "Nom perso"
        '
        'btDelete1
        '
        Me.btDelete1.AutoSize = True
        Me.btDelete1.Location = New System.Drawing.Point(96, 125)
        Me.btDelete1.Name = "btDelete1"
        Me.btDelete1.Size = New System.Drawing.Size(54, 13)
        Me.btDelete1.TabIndex = 59
        Me.btDelete1.Text = "Supprimer"
        '
        'btSelect1
        '
        Me.btSelect1.AutoSize = True
        Me.btSelect1.Location = New System.Drawing.Point(42, 125)
        Me.btSelect1.Name = "btSelect1"
        Me.btSelect1.Size = New System.Drawing.Size(38, 13)
        Me.btSelect1.TabIndex = 58
        Me.btSelect1.Text = "Choisir"
        '
        'lblLevel1
        '
        Me.lblLevel1.AutoSize = True
        Me.lblLevel1.Location = New System.Drawing.Point(83, 97)
        Me.lblLevel1.Name = "lblLevel1"
        Me.lblLevel1.Size = New System.Drawing.Size(41, 13)
        Me.lblLevel1.TabIndex = 57
        Me.lblLevel1.Text = "Niveau"
        '
        'lblClass1
        '
        Me.lblClass1.AutoSize = True
        Me.lblClass1.Location = New System.Drawing.Point(83, 84)
        Me.lblClass1.Name = "lblClass1"
        Me.lblClass1.Size = New System.Drawing.Size(38, 13)
        Me.lblClass1.TabIndex = 56
        Me.lblClass1.Text = "Classe"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(45, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 64)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Name1
        '
        Me.Name1.AutoSize = True
        Me.Name1.Location = New System.Drawing.Point(83, 71)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(58, 13)
        Me.Name1.TabIndex = 54
        Me.Name1.Text = "Nom perso"
        '
        'frmCharSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 376)
        Me.Controls.Add(Me.pnlCharlist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCharSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Séléction du personnage"
        Me.pnlCharlist.ResumeLayout(False)
        Me.pnlCharlist.PerformLayout()
        Me.pnlNewChar.ResumeLayout(False)
        Me.pnlNewChar.PerformLayout()
        CType(Me.picSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCharlist As System.Windows.Forms.Panel
    Friend WithEvents pnlNewChar As System.Windows.Forms.Panel
    Friend WithEvents btDelete4 As System.Windows.Forms.Label
    Friend WithEvents btSelect4 As System.Windows.Forms.Label
    Friend WithEvents lblLevel4 As System.Windows.Forms.Label
    Friend WithEvents lblClass4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Name4 As System.Windows.Forms.Label
    Friend WithEvents btDelete3 As System.Windows.Forms.Label
    Friend WithEvents btSelect3 As System.Windows.Forms.Label
    Friend WithEvents lblLevel3 As System.Windows.Forms.Label
    Friend WithEvents lblClass3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Name3 As System.Windows.Forms.Label
    Friend WithEvents btDelete2 As System.Windows.Forms.Label
    Friend WithEvents btSelect2 As System.Windows.Forms.Label
    Friend WithEvents lblLevel2 As System.Windows.Forms.Label
    Friend WithEvents lblClass2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Name2 As System.Windows.Forms.Label
    Friend WithEvents btDelete1 As System.Windows.Forms.Label
    Friend WithEvents btSelect1 As System.Windows.Forms.Label
    Friend WithEvents lblLevel1 As System.Windows.Forms.Label
    Friend WithEvents lblClass1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Name1 As System.Windows.Forms.Label
    Friend WithEvents picSprite As System.Windows.Forms.PictureBox
    Friend WithEvents btOK As System.Windows.Forms.Label
    Friend WithEvents lblFemale As System.Windows.Forms.Label
    Friend WithEvents btMale As System.Windows.Forms.Label
    Friend WithEvents lstClass As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
End Class

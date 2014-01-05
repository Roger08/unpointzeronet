<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewChar
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lstClass = New System.Windows.Forms.ComboBox()
        Me.btMale = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.btOK = New System.Windows.Forms.Label()
        Me.picSprite = New System.Windows.Forms.PictureBox()
        CType(Me.picSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(22, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(212, 20)
        Me.txtName.TabIndex = 0
        '
        'lstClass
        '
        Me.lstClass.FormattingEnabled = True
        Me.lstClass.Location = New System.Drawing.Point(22, 77)
        Me.lstClass.Name = "lstClass"
        Me.lstClass.Size = New System.Drawing.Size(212, 21)
        Me.lstClass.TabIndex = 1
        '
        'btMale
        '
        Me.btMale.AutoSize = True
        Me.btMale.Location = New System.Drawing.Point(54, 132)
        Me.btMale.Name = "btMale"
        Me.btMale.Size = New System.Drawing.Size(43, 13)
        Me.btMale.TabIndex = 2
        Me.btMale.Text = "Homme"
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.Location = New System.Drawing.Point(159, 132)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(41, 13)
        Me.lblFemale.TabIndex = 3
        Me.lblFemale.Text = "Femme"
        '
        'btOK
        '
        Me.btOK.AutoSize = True
        Me.btOK.Location = New System.Drawing.Point(81, 275)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(102, 13)
        Me.btOK.TabIndex = 4
        Me.btOK.Text = "Créer le personnage"
        '
        'picSprite
        '
        Me.picSprite.Location = New System.Drawing.Point(115, 185)
        Me.picSprite.Name = "picSprite"
        Me.picSprite.Size = New System.Drawing.Size(32, 64)
        Me.picSprite.TabIndex = 5
        Me.picSprite.TabStop = False
        '
        'frmNewChar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 309)
        Me.Controls.Add(Me.picSprite)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.lblFemale)
        Me.Controls.Add(Me.btMale)
        Me.Controls.Add(Me.lstClass)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNewChar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNewChar"
        CType(Me.picSprite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lstClass As System.Windows.Forms.ComboBox
    Friend WithEvents btMale As System.Windows.Forms.Label
    Friend WithEvents lblFemale As System.Windows.Forms.Label
    Friend WithEvents btOK As System.Windows.Forms.Label
    Friend WithEvents picSprite As System.Windows.Forms.PictureBox
End Class

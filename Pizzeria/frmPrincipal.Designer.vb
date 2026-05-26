<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblogin = New System.Windows.Forms.Label()
        Me.lbMDP = New System.Windows.Forms.Label()
        Me.tblogin = New System.Windows.Forms.TextBox()
        Me.tbMDP = New System.Windows.Forms.TextBox()
        Me.btnConnexion = New System.Windows.Forms.Button()
        Me.lbNumCaisse = New System.Windows.Forms.Label()
        Me.cbNumCaisse = New System.Windows.Forms.ComboBox()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Authentifiez-vous"
        '
        'lblogin
        '
        Me.lblogin.AutoSize = True
        Me.lblogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblogin.Location = New System.Drawing.Point(39, 123)
        Me.lblogin.Name = "lblogin"
        Me.lblogin.Size = New System.Drawing.Size(49, 18)
        Me.lblogin.TabIndex = 1
        Me.lblogin.Text = "Login"
        '
        'lbMDP
        '
        Me.lbMDP.AutoSize = True
        Me.lbMDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMDP.Location = New System.Drawing.Point(38, 156)
        Me.lbMDP.Name = "lbMDP"
        Me.lbMDP.Size = New System.Drawing.Size(117, 20)
        Me.lbMDP.TabIndex = 2
        Me.lbMDP.Text = "Mot de passe"
        '
        'tblogin
        '
        Me.tblogin.Location = New System.Drawing.Point(161, 121)
        Me.tblogin.Name = "tblogin"
        Me.tblogin.Size = New System.Drawing.Size(164, 20)
        Me.tblogin.TabIndex = 3
        '
        'tbMDP
        '
        Me.tbMDP.Location = New System.Drawing.Point(161, 158)
        Me.tbMDP.Name = "tbMDP"
        Me.tbMDP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbMDP.Size = New System.Drawing.Size(164, 20)
        Me.tbMDP.TabIndex = 4
        '
        'btnConnexion
        '
        Me.btnConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnexion.Location = New System.Drawing.Point(117, 213)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(135, 31)
        Me.btnConnexion.TabIndex = 5
        Me.btnConnexion.Text = "Connexion"
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'lbNumCaisse
        '
        Me.lbNumCaisse.AutoSize = True
        Me.lbNumCaisse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumCaisse.Location = New System.Drawing.Point(33, 292)
        Me.lbNumCaisse.Name = "lbNumCaisse"
        Me.lbNumCaisse.Size = New System.Drawing.Size(245, 24)
        Me.lbNumCaisse.TabIndex = 6
        Me.lbNumCaisse.Text = "Votre numéro de caisse :"
        '
        'cbNumCaisse
        '
        Me.cbNumCaisse.FormattingEnabled = True
        Me.cbNumCaisse.Location = New System.Drawing.Point(37, 337)
        Me.cbNumCaisse.Name = "cbNumCaisse"
        Me.cbNumCaisse.Size = New System.Drawing.Size(215, 21)
        Me.cbNumCaisse.TabIndex = 7
        '
        'btnValider
        '
        Me.btnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.Location = New System.Drawing.Point(37, 391)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(118, 29)
        Me.btnValider.TabIndex = 8
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Violet
        Me.ClientSize = New System.Drawing.Size(485, 587)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.cbNumCaisse)
        Me.Controls.Add(Me.lbNumCaisse)
        Me.Controls.Add(Me.btnConnexion)
        Me.Controls.Add(Me.tbMDP)
        Me.Controls.Add(Me.tblogin)
        Me.Controls.Add(Me.lbMDP)
        Me.Controls.Add(Me.lblogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPrincipal"
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblogin As Label
    Friend WithEvents lbMDP As Label
    Friend WithEvents tblogin As TextBox
    Friend WithEvents tbMDP As TextBox
    Friend WithEvents btnConnexion As Button
    Friend WithEvents lbNumCaisse As Label
    Friend WithEvents cbNumCaisse As ComboBox
    Friend WithEvents btnValider As Button
End Class

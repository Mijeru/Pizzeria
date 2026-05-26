<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisie
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAjouterPizza = New System.Windows.Forms.Button()
        Me.cbPizzas = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAjouterMenu = New System.Windows.Forms.Button()
        Me.cbMenus = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnAjouterSupplement = New System.Windows.Forms.Button()
        Me.cbSupplements = New System.Windows.Forms.ComboBox()
        Me.lstPanier = New System.Windows.Forms.ListBox()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.cbModeReglement = New System.Windows.Forms.ComboBox()
        Me.lbModeReglement = New System.Windows.Forms.Label()
        Me.btnTicketClient = New System.Windows.Forms.Button()
        Me.btnNouvelleCommande = New System.Windows.Forms.Button()
        Me.btnDeconnexion = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Saisir la commande client"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(48, 86)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(208, 248)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAjouterPizza)
        Me.TabPage1.Controls.Add(Me.cbPizzas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(200, 222)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pizza"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAjouterPizza
        '
        Me.btnAjouterPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouterPizza.Location = New System.Drawing.Point(51, 189)
        Me.btnAjouterPizza.Name = "btnAjouterPizza"
        Me.btnAjouterPizza.Size = New System.Drawing.Size(94, 30)
        Me.btnAjouterPizza.TabIndex = 1
        Me.btnAjouterPizza.Text = "Ajouter"
        Me.btnAjouterPizza.UseVisualStyleBackColor = True
        '
        'cbPizzas
        '
        Me.cbPizzas.FormattingEnabled = True
        Me.cbPizzas.Location = New System.Drawing.Point(7, 7)
        Me.cbPizzas.Name = "cbPizzas"
        Me.cbPizzas.Size = New System.Drawing.Size(187, 21)
        Me.cbPizzas.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAjouterMenu)
        Me.TabPage2.Controls.Add(Me.cbMenus)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(200, 222)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Menu"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAjouterMenu
        '
        Me.btnAjouterMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouterMenu.Location = New System.Drawing.Point(48, 190)
        Me.btnAjouterMenu.Name = "btnAjouterMenu"
        Me.btnAjouterMenu.Size = New System.Drawing.Size(94, 29)
        Me.btnAjouterMenu.TabIndex = 1
        Me.btnAjouterMenu.Text = "Ajouter"
        Me.btnAjouterMenu.UseVisualStyleBackColor = True
        '
        'cbMenus
        '
        Me.cbMenus.FormattingEnabled = True
        Me.cbMenus.Location = New System.Drawing.Point(4, 7)
        Me.cbMenus.Name = "cbMenus"
        Me.cbMenus.Size = New System.Drawing.Size(190, 21)
        Me.cbMenus.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnAjouterSupplement)
        Me.TabPage3.Controls.Add(Me.cbSupplements)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(200, 222)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Supplement"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnAjouterSupplement
        '
        Me.btnAjouterSupplement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouterSupplement.Location = New System.Drawing.Point(48, 188)
        Me.btnAjouterSupplement.Name = "btnAjouterSupplement"
        Me.btnAjouterSupplement.Size = New System.Drawing.Size(84, 31)
        Me.btnAjouterSupplement.TabIndex = 1
        Me.btnAjouterSupplement.Text = "Ajouter"
        Me.btnAjouterSupplement.UseVisualStyleBackColor = True
        '
        'cbSupplements
        '
        Me.cbSupplements.FormattingEnabled = True
        Me.cbSupplements.Location = New System.Drawing.Point(4, 7)
        Me.cbSupplements.Name = "cbSupplements"
        Me.cbSupplements.Size = New System.Drawing.Size(190, 21)
        Me.cbSupplements.TabIndex = 0
        '
        'lstPanier
        '
        Me.lstPanier.BackColor = System.Drawing.Color.DarkGray
        Me.lstPanier.FormattingEnabled = True
        Me.lstPanier.Location = New System.Drawing.Point(390, 115)
        Me.lstPanier.Name = "lstPanier"
        Me.lstPanier.Size = New System.Drawing.Size(222, 160)
        Me.lstPanier.TabIndex = 2
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(387, 288)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(39, 13)
        Me.lbTotal.TabIndex = 3
        Me.lbTotal.Text = "Label2"
        '
        'cbModeReglement
        '
        Me.cbModeReglement.BackColor = System.Drawing.Color.DarkGray
        Me.cbModeReglement.FormattingEnabled = True
        Me.cbModeReglement.Location = New System.Drawing.Point(52, 378)
        Me.cbModeReglement.Name = "cbModeReglement"
        Me.cbModeReglement.Size = New System.Drawing.Size(204, 21)
        Me.cbModeReglement.TabIndex = 4
        '
        'lbModeReglement
        '
        Me.lbModeReglement.AutoSize = True
        Me.lbModeReglement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbModeReglement.Location = New System.Drawing.Point(52, 359)
        Me.lbModeReglement.Name = "lbModeReglement"
        Me.lbModeReglement.Size = New System.Drawing.Size(149, 16)
        Me.lbModeReglement.TabIndex = 5
        Me.lbModeReglement.Text = "Mode de règlement :"
        '
        'btnTicketClient
        '
        Me.btnTicketClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTicketClient.Location = New System.Drawing.Point(390, 304)
        Me.btnTicketClient.Name = "btnTicketClient"
        Me.btnTicketClient.Size = New System.Drawing.Size(201, 30)
        Me.btnTicketClient.TabIndex = 6
        Me.btnTicketClient.Text = "Imprimer le ticket"
        Me.btnTicketClient.UseVisualStyleBackColor = True
        '
        'btnNouvelleCommande
        '
        Me.btnNouvelleCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNouvelleCommande.Location = New System.Drawing.Point(343, 415)
        Me.btnNouvelleCommande.Name = "btnNouvelleCommande"
        Me.btnNouvelleCommande.Size = New System.Drawing.Size(164, 37)
        Me.btnNouvelleCommande.TabIndex = 7
        Me.btnNouvelleCommande.Text = "Nouvelle commande"
        Me.btnNouvelleCommande.UseVisualStyleBackColor = True
        '
        'btnDeconnexion
        '
        Me.btnDeconnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeconnexion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeconnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeconnexion.Location = New System.Drawing.Point(531, 415)
        Me.btnDeconnexion.Name = "btnDeconnexion"
        Me.btnDeconnexion.Size = New System.Drawing.Size(124, 37)
        Me.btnDeconnexion.TabIndex = 8
        Me.btnDeconnexion.Text = "Déconnexion"
        Me.btnDeconnexion.UseVisualStyleBackColor = True
        '
        'frmSaisie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumOrchid
        Me.ClientSize = New System.Drawing.Size(679, 464)
        Me.Controls.Add(Me.btnDeconnexion)
        Me.Controls.Add(Me.btnNouvelleCommande)
        Me.Controls.Add(Me.btnTicketClient)
        Me.Controls.Add(Me.lbModeReglement)
        Me.Controls.Add(Me.cbModeReglement)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.lstPanier)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSaisie"
        Me.Text = "frmSaisie"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cbPizzas As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cbMenus As ComboBox
    Friend WithEvents cbSupplements As ComboBox
    Friend WithEvents btnAjouterPizza As Button
    Friend WithEvents btnAjouterMenu As Button
    Friend WithEvents btnAjouterSupplement As Button
    Friend WithEvents lstPanier As ListBox
    Friend WithEvents lbTotal As Label
    Friend WithEvents cbModeReglement As ComboBox
    Friend WithEvents lbModeReglement As Label
    Friend WithEvents btnTicketClient As Button
    Friend WithEvents btnNouvelleCommande As Button
    Friend WithEvents btnDeconnexion As Button
End Class

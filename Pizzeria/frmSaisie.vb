Public Class frmSaisie

    Dim uneCommande As New Commande(frmPrincipal.numBorne)

    Private Sub frmSaisie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Remplir cbPizzas
        For Each unePizza In CollectionPizzas.lesPizzas
            cbPizzas.Items.Add(unePizza.LireNomPizza())
        Next

        ' Remplir cbMenus
        For Each unMenu In CollectionMenus.lesMenus
            cbMenus.Items.Add(unMenu.LireLibelle())
        Next

        ' Remplir cbSupplements
        For Each unSupplement In CollectionSupplements.lesSupplements
            cbSupplements.Items.Add(unSupplement.LireLibelle())
        Next

        ' Remplir le mode de règlement
        cbModeReglement.Items.Add("Espèces")
        cbModeReglement.Items.Add("Carte Bancaire")
        cbModeReglement.Items.Add("Ticket Restaurant")
        cbModeReglement.Items.Add("Lydia")
        cbModeReglement.Items.Add("PayLib")
        cbModeReglement.Items.Add("Chèque Vacances")
        ' Masquer le total tant qu'aucun produit n'est sélectionné
        lbTotal.Visible = False
        ' Désactiver l'édition du ticket tant qu'il n'y a pas d'article et de mode de paiement
        btnTicketClient.Enabled = False
    End Sub

    Private Sub cbModeReglement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModeReglement.SelectedIndexChanged
        ' Protection contre SelectedItem = Nothing (par ex. SelectedIndex = -1)
        If cbModeReglement.SelectedIndex = -1 OrElse cbModeReglement.SelectedItem Is Nothing Then
            Return
        End If

        uneCommande.SaisirMode(cbModeReglement.SelectedItem.ToString())
        ' Activer le bouton ticket uniquement s'il y a au moins un article
        btnTicketClient.Enabled = (lstPanier.Items.Count > 0)
    End Sub

    ' --- Ajouter Pizza ---
    Private Sub btnAjouterPizza_Click(sender As Object, e As EventArgs) Handles btnAjouterPizza.Click
        If cbPizzas.SelectedIndex = -1 Then
            MessageBox.Show("Sélectionnez une pizza.")
            Exit Sub
        End If

        Dim unePizza As Pizza = CollectionPizzas.lesPizzas(cbPizzas.SelectedIndex)
        uneCommande.AjouterArticle(unePizza)
        lstPanier.Items.Add(unePizza.LireNomPizza() & " - " & unePizza.LirePrixHT() & " €")
        lbTotal.Text = "Total TTC : " & uneCommande.CalculTotalTTC() & " €"
        lbTotal.Visible = True
        btnTicketClient.Enabled = (cbModeReglement.SelectedIndex <> -1)
    End Sub

    ' --- Ajouter Menu ---
    Private Sub btnAjouterMenu_Click(sender As Object, e As EventArgs) Handles btnAjouterMenu.Click
        If cbMenus.SelectedIndex = -1 Then
            MessageBox.Show("Sélectionnez un menu.")
            Exit Sub
        End If

        Dim unMenu As MenuPizzeria = CollectionMenus.lesMenus(cbMenus.SelectedIndex)
        uneCommande.AjouterArticle(unMenu)
        lstPanier.Items.Add(unMenu.LireLibelle() & " - " & unMenu.LirePrixHT() & " €")
        lbTotal.Text = "Total TTC : " & uneCommande.CalculTotalTTC() & " €"
        lbTotal.Visible = True
        btnTicketClient.Enabled = (cbModeReglement.SelectedIndex <> -1)
    End Sub

    ' --- Ajouter Supplément ---
    Private Sub btnAjouterSupplement_Click(sender As Object, e As EventArgs) Handles btnAjouterSupplement.Click
        If cbSupplements.SelectedIndex = -1 Then
            MessageBox.Show("Sélectionnez un supplément.")
            Exit Sub
        End If

        Dim unSupplement As Supplement = CollectionSupplements.lesSupplements(cbSupplements.SelectedIndex)
        uneCommande.AjouterArticle(unSupplement)
        lstPanier.Items.Add(unSupplement.LireLibelle() & " - " & unSupplement.LirePrixHT() & " €")
        lbTotal.Text = "Total TTC : " & uneCommande.CalculTotalTTC() & " €"
        lbTotal.Visible = True
        btnTicketClient.Enabled = (cbModeReglement.SelectedIndex <> -1)
    End Sub

    Private Sub lstPanier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPanier.SelectedIndexChanged

    End Sub
    Private Sub lstPanier_DoubleClick(sender As Object, e As EventArgs) Handles lstPanier.DoubleClick
        If lstPanier.SelectedIndex = -1 Then
            Exit Sub
        End If

        Dim index As Integer = lstPanier.SelectedIndex
        uneCommande.SupprimerArticle(index)
        lstPanier.Items.RemoveAt(index)
        If lstPanier.Items.Count = 0 Then
            lbTotal.Visible = False
            btnTicketClient.Enabled = False
        Else
            lbTotal.Text = "Total : " & uneCommande.CalculTotalTTC() & " €"
            ' Le bouton ticket dépend aussi du mode de paiement
            btnTicketClient.Enabled = (cbModeReglement.SelectedIndex <> -1)
        End If
    End Sub

    Private Sub btnTicketClient_Click(sender As Object, e As EventArgs) Handles btnTicketClient.Click
        uneCommande.EditerTicketClient()
        uneCommande.EditerTicketCuisine()
        uneCommande.EnregistrerCommande(frmPrincipal.leServeur.LireCodeServeur())
    End Sub

    Private Sub btnNouvelleCommande_Click(sender As Object, e As EventArgs) Handles btnNouvelleCommande.Click
        ' Vider le panier
        lstPanier.Items.Clear()
        ' Remettre le total à 0
        lbTotal.Text = "Total : 0.00 €"
        lbTotal.Visible = False
        ' Remettre le mode de règlement à vide
        cbModeReglement.SelectedIndex = -1
        ' Créer une nouvelle commande
        uneCommande = New Commande(frmPrincipal.numBorne)
        btnTicketClient.Enabled = False
    End Sub

    Private Sub btnDeconnexion_Click(sender As Object, e As EventArgs) Handles btnDeconnexion.Click
        ' Cacher frmSaisie
        Me.Hide()
        ' Réinitialiser les champs de connexion
        frmPrincipal.tblogin.Text = ""
        frmPrincipal.tbMDP.Text = ""
        ' Masquer la sélection de caisse pour que l'utilisateur ne voie pas les bornes avant connexion
        frmPrincipal.cbNumCaisse.Visible = False
        frmPrincipal.lbNumCaisse.Visible = False
        frmPrincipal.btnValider.Visible = False
        frmPrincipal.cbNumCaisse.SelectedIndex = -1
        frmPrincipal.btnValider.Enabled = False
        ' Réinitialiser les informations de session
        frmPrincipal.leServeur = Nothing
        frmPrincipal.numBorne = 0
        ' Réafficher frmPrincipal
        frmPrincipal.Show()
    End Sub
End Class
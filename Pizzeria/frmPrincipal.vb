Imports MySql.Data.MySqlClient
Public Class frmPrincipal
    Public Shared laConnexion As Connexion

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laConnexion = New Connexion()

        ' ---  Masquer les contrôles de sélection de borne ---
        cbNumCaisse.Visible = False
        lbNumCaisse.Visible = False
        btnValider.Visible = False

        CollectionPizzas.Remplir()
        CollectionMenus.Remplir()
        CollectionSupplements.Remplir()
        CollectionServeurs.Remplir()
        CollectionBornes.Remplir()
        ' Remplir la liste des caisses
        For Each uneBorne In CollectionBornes.lesBornes
            cbNumCaisse.Items.Add(uneBorne)
        Next
    End Sub
    ' Variable globale : borne choisie par le serveur
    Public Shared numBorne As Integer

    ' Variable globale : serveur connecté
    Public Shared leServeur As Serveur


    Private Sub tblogin_TextChanged(sender As Object, e As EventArgs) Handles tblogin.TextChanged, tblogin.TextChanged

    End Sub

    Private Sub tbMDP_TextChanged(sender As Object, e As EventArgs) Handles tbMDP.TextChanged, tbMDP.TextChanged

    End Sub

    Private Sub cbNumCaisse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNumCaisse.SelectedIndexChanged
        If cbNumCaisse.SelectedIndex = -1 Then
            btnValider.Enabled = False
            Return
        End If

        ' Affecter la borne sélectionnée à la variable globale
        Try
            numBorne = CInt(cbNumCaisse.SelectedItem)
            btnValider.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Numéro de caisse invalide.", "Erreur", MessageBoxButtons.OK)
            btnValider.Enabled = False
        End Try
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If cbNumCaisse.SelectedIndex = -1 Then
            MessageBox.Show("Sélectionnez une caisse.", "Information", MessageBoxButtons.OK)
            Exit Sub
        End If

        ' Numéro de borne déjà affecté dans l'événement SelectedIndexChanged, mais s'assurer
        numBorne = CInt(cbNumCaisse.SelectedItem)

        ' Ouvrir la fenêtre de saisie et masquer la connexion
        Dim saisie As New frmSaisie()
        saisie.Show()
        Me.Hide()
    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Dim trouve As Boolean = False
        For Each unServeur In CollectionServeurs.lesServeurs
            If unServeur.Authentifier(tblogin.Text, tbMDP.Text) Then
                trouve = True
                leServeur = unServeur
                Exit For
            End If
        Next

        If trouve Then
            ' afficher la sélection de caisse
            cbNumCaisse.Visible = True
            lbNumCaisse.Visible = True
            btnValider.Visible = True
        Else
            MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK)
        End If
    End Sub
End Class

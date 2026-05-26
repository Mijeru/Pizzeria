Imports MySql.Data.MySqlClient

Public Class CollectionServeurs

    Public Shared lesServeurs As New List(Of Serveur)

    Public Shared Sub Remplir()
        Dim requete As String = "SELECT * FROM serveur"
        Dim cmd As New MySqlCommand(requete, frmPrincipal.laConnexion.m_connexion)
        Dim lecteur As MySqlDataReader = cmd.ExecuteReader()

        While lecteur.Read()
            Dim unServeur As New Serveur(
                lecteur("CodeServeur"),
                lecteur("NomServeur"),
                lecteur("PrenomServeur"),
                lecteur("Login"),
                lecteur("MDP"))
            lesServeurs.Add(unServeur)
        End While

        lecteur.Close()
    End Sub

End Class
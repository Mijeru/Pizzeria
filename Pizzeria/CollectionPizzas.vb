Imports MySql.Data.MySqlClient

Public Class CollectionPizzas

    Public Shared lesPizzas As New List(Of Pizza)

    Public Shared Sub Remplir()
        Dim requete As String = "SELECT * FROM pizza"
        Dim cmd As New MySqlCommand(requete, frmPrincipal.laConnexion.m_connexion)
        Dim lecteur As MySqlDataReader = cmd.ExecuteReader()

        While lecteur.Read()
            Dim unePizza As New Pizza(
                lecteur("NumPizza"),
                lecteur("NomPizza"),
                lecteur("PrixHTpizza"),
                lecteur("CategoriePizza"))
            lesPizzas.Add(unePizza)
        End While

        lecteur.Close()
    End Sub

End Class
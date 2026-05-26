Imports MySql.Data.MySqlClient

Public Class CollectionMenus

    Public Shared lesMenus As New List(Of MenuPizzeria)

    Public Shared Sub Remplir()
        Dim requete As String = "SELECT * FROM menu"
        Dim cmd As New MySqlCommand(requete, frmPrincipal.laConnexion.m_connexion)
        Dim lecteur As MySqlDataReader = cmd.ExecuteReader()

        While lecteur.Read()
            Dim unMenu As New MenuPizzeria(
                lecteur("NumMenu"),
                lecteur("LibelleMenu"),
                lecteur("DescriptionMenu"),
                lecteur("PrixHTmenu"))
            lesMenus.Add(unMenu)
        End While

        lecteur.Close()
    End Sub

End Class
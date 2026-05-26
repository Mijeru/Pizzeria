Imports MySql.Data.MySqlClient

Public Class CollectionSupplements

    Public Shared lesSupplements As New List(Of Supplement)

    Public Shared Sub Remplir()
        Dim requete As String = "SELECT * FROM supplement"
        Dim cmd As New MySqlCommand(requete, frmPrincipal.laConnexion.m_connexion)
        Dim lecteur As MySqlDataReader = cmd.ExecuteReader()

        While lecteur.Read()
            Dim unSupplement As New Supplement(
                lecteur("NumSupplement"),
                lecteur("LibelleSupplement"),
                lecteur("PrixHTsupplement"))
            lesSupplements.Add(unSupplement)
        End While

        lecteur.Close()
    End Sub

End Class
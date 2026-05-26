Imports MySql.Data.MySqlClient

Public Class CollectionBornes

    Public Shared lesBornes As New List(Of Byte)

    Public Shared Sub Remplir()
        Dim requete As String = "SELECT * FROM borne"
        Dim cmd As New MySqlCommand(requete, frmPrincipal.laConnexion.m_connexion)
        Dim lecteur As MySqlDataReader = cmd.ExecuteReader()

        While lecteur.Read()
            lesBornes.Add(lecteur("NumBorne"))
        End While

        lecteur.Close()
    End Sub

End Class
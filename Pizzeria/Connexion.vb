Imports MySql.Data.MySqlClient

Public Class Connexion

    Public m_connexion As MySqlConnection

    Public Sub New()
        m_connexion = New MySqlConnection(
            "server=localhost;" &
            "database=pizzeria;" &
            "uid=root;" &
            "pwd=;")
        m_connexion.Open()
    End Sub

End Class
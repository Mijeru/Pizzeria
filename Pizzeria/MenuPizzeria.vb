Public Class MenuPizzeria

    ' --- Attributs ---
    Private m_numMenu As Integer
    Private m_libelle As String
    Private m_description As String
    Private m_prixHT As Decimal
    Private Const TAUX_TVA As Decimal = 0.1D

    ' --- Constructeur ---
    Public Sub New(num As Integer, libelle As String, desc As String, prix As Decimal)
        m_numMenu = num
        m_libelle = libelle
        m_description = desc
        m_prixHT = prix
    End Sub

    ' --- Getters ---
    Public Function LireNumMenu() As Integer
        Return m_numMenu
    End Function

    Public Function LireLibelle() As String
        Return m_libelle
    End Function

    Public Function LireDescription() As String
        Return m_description
    End Function

    Public Function LirePrixHT() As Decimal
        Return m_prixHT
    End Function

    Public Function LireTVA() As Decimal
        Return TAUX_TVA
    End Function

    Public Function LirePrixTTC() As Decimal
        Return Math.Round(m_prixHT * (1 + TAUX_TVA), 2)
    End Function

End Class
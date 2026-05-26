Public Class Pizza

    ' --- Attributs ---
    Private m_numPizza As Integer
    Private m_nomPizza As String
    Private m_prixHT As Decimal
    Private m_categorie As String
    Private Const TAUX_TVA As Decimal = 0.1D ' TVA 10% restauration

    ' --- Constructeur ---
    Public Sub New(num As Integer, nom As String, prix As Decimal, cat As String)
        m_numPizza = num
        m_nomPizza = nom
        m_prixHT = prix
        m_categorie = cat
    End Sub

    ' --- Getters ---
    Public Function LireNumPizza() As Integer
        Return m_numPizza
    End Function

    Public Function LireNomPizza() As String
        Return m_nomPizza
    End Function

    Public Function LirePrixHT() As Decimal
        Return m_prixHT
    End Function

    Public Function LireCategorie() As String
        Return m_categorie
    End Function

    Public Function LireTVA() As Decimal
        Return TAUX_TVA
    End Function

    Public Function LirePrixTTC() As Decimal
        Return Math.Round(m_prixHT * (1 + TAUX_TVA), 2)
    End Function

End Class
Public Class Serveur

    Private m_codeServeur As String
    Private m_nomServeur As String
    Private m_prenomServeur As String
    Private m_login As String
    Private m_mdp As String
    Private m_mesCommandes As New List(Of Commande)

    Public Sub New(cSer As String, nSer As String, pSer As String,
                   lSer As String, mdpSer As String)
        m_codeServeur = cSer
        m_nomServeur = nSer
        m_prenomServeur = pSer
        m_login = lSer
        m_mdp = mdpSer
    End Sub

    Private Function HashSHA256(mdp As String) As String
        Dim sha As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
        Dim bytes() As Byte = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(mdp))
        Dim sb As New System.Text.StringBuilder()
        For Each b As Byte In bytes
            sb.Append(b.ToString("x2"))
        Next
        Return sb.ToString()
    End Function

    Public Function Authentifier(loginSer As String, mdpSer As String) As Boolean
        Return (m_login = loginSer AndAlso m_mdp = HashSHA256(mdpSer))
    End Function

    Public Function LireCodeServeur() As String
        Return m_codeServeur
    End Function

    Public Function LireNomServeur() As String
        Return m_nomServeur
    End Function

    Public Function LirePrenomServeur() As String
        Return m_prenomServeur
    End Function

    Public Sub NouvelleCommande(numBorne As Integer)
        Dim uneCommande As New Commande(numBorne)
        m_mesCommandes.Add(uneCommande)
    End Sub

    Public ReadOnly Property MesCommandes() As List(Of Commande)
        Get
            Return m_mesCommandes
        End Get
    End Property

End Class
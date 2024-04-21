Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Resultat
    Inherits Form
    Private DataGridView1 As DataGridView

    Private Property DataTable As Object

    Public Sub ChargerDonnees()
        Dim idDemande As Integer
        Dim dataTable As New DataTable()

        ' Chaîne de connexion à votre base de données MySQL
        Dim connectionString As String = "datasource=localhost;database=gestionnaire;port=3306;username=root;password="

        ' Requête SQL pour récupérer les données de la table Demande en fonction de iddemande et du statut de la table Resultat
        Dim query As String = "SELECT * FROM   demandes  WHERE idDemande = @idDemande   AND idDemande IN (SELECT idDemande FROM Resultat WHERE Statut = r.Statut)"
        Using connection As New MySqlConnection(connectionString),
              command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@idDemande", idDemande)

            connection.Open()

            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Assurez-vous que le DataGridView1 est correctement initialisé et ajouté au formulaire
       
    End Sub

    Private Sub Resultat_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=localhost;user id=root;password=;database=gestionnaire"
        Dim dataTable As New DataTable()

        Try
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "SELECT d.Demandeur, d.Categories, d.description, d.Departement, d.cout, d.DateDebut, d.DateFin, r.Statut FROM demandes d JOIN Resultat r ON d.idDemande = r.idDemande WHERE r.Statut = (SELECT Statut FROM Resultat WHERE idDemande = d.idDemande ORDER BY idResultat LIMIT 1);"


                Using command As New MySqlCommand(query, connection)
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(dataTable)
                        GunaDataGridView1.DataSource = dataTable
                        GunaDataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
                        ' Définition de la couleur BlueRoyal
                     

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dispose()
        Dim formPrincipal As New Form3
        formPrincipal.ShowDialog()
    End Sub

    Private Sub DataGidview1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub
End Class


Imports MySql.Data.MySqlClient

Public Class Gestion

    Private selectedRow As DataGridViewRow

    Property RecupererDonnees As DataTable

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dispose()
        Dim formPrincipal As New Form3
        formPrincipal.ShowDialog()
    End Sub

    Private Sub Gestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Récupération des données depuis la base de données
        Dim connectionString As String = "server=localhost;user id=root;password=;database=gestionnaire"
        Dim dataTable As New DataTable()

        Try
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "SELECT idDemande,Demandeur,Categories,description,Departement,cout,DateDebut,DateFin FROM demandes"
                Using command As New MySqlCommand(query, connection)
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(dataTable)
                        Resultats.DataSource = dataTable
                        Resultats.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Resultats_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        ' Stocker la ligne sélectionnée
        If e.RowIndex >= 0 Then
            selectedRow = Resultats.Rows(e.RowIndex)
        End If
    End Sub

    Private Sub ButtonApprouver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonApprouver.Click
        TraiterDemande("Approuvé")
    End Sub

    Private Sub ButtonRefuser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonRefuser.Click
        TraiterDemande("Refusé")
    End Sub

    Private Sub ButtonEnAttente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonEnAttente.Click
        TraiterDemande("En Attente")
    End Sub

    Public Sub TraiterDemande(ByVal statut As String)
        If selectedRow IsNot Nothing Then
            Try
                Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=gestionnaire")
                    connection.Open()

                    ' Récupérer les informations de la colonne sélectionnée
                    Dim nom As String = selectedRow.Cells("Demandeur").Value.ToString() ' Remplacez "Nom" par le nom de la colonne correspondante
                    Dim cout As Decimal = Convert.ToDecimal(selectedRow.Cells("Cout").Value) ' Remplacez "Cout" par le nom de la colonne correspondante
                    Dim dateDebut As Date = Convert.ToDateTime(selectedRow.Cells("Debut").Value) ' Remplacez "DateDebut" par le nom de la colonne correspondante
                    Dim dateFin As Date = Convert.ToDateTime(selectedRow.Cells("Fin").Value) ' Remplacez "DateFin" par le nom de la colonne correspondante
                    Dim departement As String = selectedRow.Cells("Departement").Value.ToString() ' Remplacez "Departement" par le nom de la colonne correspondante
                    Dim categorie As String = selectedRow.Cells("Categories").Value.ToString() ' Remplacez "Categorie" par le nom de la colonne correspondante

                    Dim idDemande As Integer = Convert.ToInt32(selectedRow.Cells("numero").Value) ' Supposons que l'identifiant de la demande est dans une colonne appelée "idDemande"


                    ' Mettre à jour le statut dans la table "Resultat" en fonction de l'ID de la demande
                    Dim updateQuery As String = "INSERT INTO resultat (idDemande, statut) VALUES (@idDemande, @statut)"
                    Using command As New MySqlCommand(updateQuery, connection)
                        command.Parameters.Add("@idDemande", MySqlDbType.Int32).Value = idDemande
                        command.Parameters.Add("@statut", MySqlDbType.VarChar).Value = statut
                        command.ExecuteNonQuery()
                    End Using



                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Veuillez sélectionner une ligne avant de cliquer sur le bouton.")
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Resultats_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class



Imports MySql.Data.MySqlClient

Public Class employe
    Dim connectionString As String = "server=localhost;user=root;password=;database=gestionnaire"

    Private Sub Textboxprenom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textboxprenom.TextChanged
    End Sub

    Private Sub Textboxnom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textboxnom.TextChanged
    End Sub

    Private Sub GunaLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel3.Click
    End Sub
    Private Sub ChargerDonnees()
        Dim dataTable As New DataTable()

        Try
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "SELECT nom, prenom, tel, motDePasse FROM employe"
                Using command As New MySqlCommand(query, connection)
                    connection.Open()
                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(dataTable)
                        DataGridView1.DataSource = dataTable
                        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub employe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChargerDonnees()
    End Sub


    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        Dim nom As String = Textboxnom.Text
        Dim prenom As String = Textboxprenom.Text
        Dim tel As String = Textboxtel.Text
        Dim motDePasse As String = code.Text

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("Connexion à la base de données réussie !")

                Dim query As String = "INSERT INTO Employe (nom, prenom, tel, motDePasse) VALUES (@nom, @prenom, @tel, @motDePasse)"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@nom", nom)
                    command.Parameters.AddWithValue("@prenom", prenom)
                    command.Parameters.AddWithValue("@tel", tel)
                    command.Parameters.AddWithValue("@motDePasse", motDePasse)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Données insérées avec succès !")
                    ChargerDonnees()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
End Class

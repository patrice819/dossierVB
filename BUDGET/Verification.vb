Imports MySql.Data.MySqlClient

Public Class verification
    Dim connexion As New MySqlConnection("datasource=localhost;database=gestionnaire;port=3306;username=root;password=")

    Private Sub Projet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connexion.Open()
            'MsgBox("Connexion effectuée avec succès")'

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            connexion.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Admin As String = TextBox1.Text
        Dim Depart As String = TextBox2.Text
        Dim Password As String = TextBox3.Text

        Try
            If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "") Then
                MessageBox.Show("Remplissez les champs")
            Else
                connexion.Open()
                Dim command As New MySqlCommand("SELECT * FROM gerer WHERE nom=@nom AND Departement=@Departement AND password=@password", connexion)
                command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = Admin
                command.Parameters.Add("@Departement", MySqlDbType.VarChar).Value = Depart
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                If table.Rows.Count <= 0 Then
                    MessageBox.Show("Vous n'êtes pas autorisé à accéder à ces données")
                Else
                    MessageBox.Show("Bienvenue Monsieur " & Admin)
                    Gestion.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connexion.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Votre code pour Button2_Click
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

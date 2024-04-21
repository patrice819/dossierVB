Imports System.Globalization
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Demande


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles descriptiontxt.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nom.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dispose()
        Dim formPrincipal As New Form3
        formPrincipal.ShowDialog()
    End Sub
    Private Sub BtnSoumettre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSoumettre.Click
        Try
            Dim demandeur As String = nom.Text
            Dim des As String = descriptiontxt.Text
            Dim somme As String = Couttxt.Text
            Dim categorie As String = categorietxt.SelectedItem.ToString
            Dim departement As String = Departementtxt.SelectedItem.ToString
            Dim debut As Date = DateDebut.Value
            Dim Fin As Date = DateFin.Value

            ' Valider les champs
            If demandeur = "" Or des = "" Or somme = "" Or categorie = "" Or departement = "" Then
                MessageBox.Show("Veuillez remplir tous les champs.")
                Return
            End If

            ' Valider le champ "somme" pour s'assurer qu'il ne contient que des chiffres
            Dim coutValid As Double
            If Not Double.TryParse(somme, coutValid) Then
                MessageBox.Show("Le champ 'somme' doit contenir uniquement des chiffres.")
                Return
            End If

            If DateDebut.Value >= DateFin.Value Then
                MessageBox.Show("La date de début doit être postérieure à la date de fin.")
                Return
            End If


            ' Récupération de l'ID du gérant en fonction du département
            Dim gerantID As Integer
            Dim connectionString As String = "server=localhost;user id=root;password=;database=gestionnaire"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT ID FROM gerer WHERE Departement = @Departement"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Departement", departement)
                    gerantID = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using

            ' Insertion dans une base de données '
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO demandes(Demandeur, description, Categories, Departement, cout, DateDebut, DateFin, ID) VALUES (@Demandeur, @description, @Categories, @Departement, @cout, @DateDebut, @DateFin, @ID)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Demandeur", demandeur)
                    command.Parameters.AddWithValue("@description", des)
                    command.Parameters.AddWithValue("@Categories", categorie)
                    command.Parameters.AddWithValue("@Departement", departement)
                    command.Parameters.AddWithValue("@cout", somme)
                    command.Parameters.AddWithValue("@DateDebut", debut)
                    command.Parameters.AddWithValue("@DateFin", Fin)
                    command.Parameters.AddWithValue("@ID", gerantID)
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Afficher un message de succès '
            MessageBox.Show("Insertion effectuée avec succès.")
        Catch ex As Exception
            ' Gérer l'exception ici en affichant un message d'erreur '
            MessageBox.Show("Une erreur s'est produite : " & ex.Message)
        End Try
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnuler.Click

    End Sub

    Private Sub Demande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub




    Private Function ex() As Object
        Try
            ' Implémenter le comportement de la méthode "ex" ici '
            ' Si la méthode n'est pas implémentée, déclencher une exception NotImplementedException '
            Throw New NotImplementedException("La méthode 'ex' n'est pas implémentée")
        Catch exNotImplemented As NotImplementedException
            ' Gérer l'exception NotImplementedException ici si nécessaire '
            Console.WriteLine("Une méthode non implémentée a été déclenchée : " & exNotImplemented.Message)
            ' Retourner l'exception comme valeur de retour '
            Return exNotImplemented
        Catch otherEx As Exception
            ' Gérer d'autres exceptions ici si nécessaire '
            Console.WriteLine("Une erreur s'est produite dans la méthode 'ex' : " & otherEx.Message)
            ' Retourner l'exception comme valeur de retour '
            Return otherEx
        End Try
    End Function


End Class
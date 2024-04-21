Imports MySql.Data.MySqlClient

Public Class login
    Dim conn As New MySqlConnection("datasource=localhost;database=gestionnaire;port=3306;username=root;password=")



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try
            conn.Open()
            MsgBox("   Connexion effectuer Succes")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()

        Dim user = TextBox1.Text
        Dim code = TextBox2.Text

        If (user = "" Or code = "") Then
            MsgBox("Remplissez les champs")
        ElseIf (code = "Admin") Then
            Dispose()
            Form2.ShowDialog()
        ElseIf (code = "Emp@") Then
            Form3.ShowDialog()
        Else
            MsgBox("Access refuser!!!")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dispose()
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

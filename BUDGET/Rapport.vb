Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Printing
Public Class Rapport

    Private Property DataGridView1 As Object

    Private Sub Rapport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=localhost;user id=root;password=;database=gestionnaire"
        Dim dataTable1 As New DataTable() ' Premier DataTable pour le premier diagramme en barres
        Dim dataTable2 As New DataTable() ' Deuxième DataTable pour le deuxième diagramme circulaire
        Dim dataTable3 As New DataTable() ' Troisième DataTable pour le troisième diagramme en courbes

        Try
            Using connection As New MySqlConnection(connectionString)
                ' Récupération des données pour le premier diagramme en barres
                Dim query1 As String = "SELECT Departement, Cout FROM demandes"
                Using command1 As New MySqlCommand(query1, connection)
                    connection.Open()
                    Using adapter1 As New MySqlDataAdapter(command1)
                        adapter1.Fill(dataTable1)
                    End Using
                End Using

                ' Afficher les données dans le premier graphique en barres
                DisplayBarChart(dataTable1, Chart1)
            End Using

            ' Récupération des données pour le deuxième diagramme circulaire
            Using connection2 As New MySqlConnection(connectionString)
                Dim query2 As String = "SELECT Categories, Cout FROM demandes"
                Using command2 As New MySqlCommand(query2, connection2)
                    connection2.Open()
                    Using adapter2 As New MySqlDataAdapter(command2)
                        adapter2.Fill(dataTable2)
                    End Using
                End Using

                ' Afficher les données dans le deuxième graphique circulaire
                DisplayPieChart(dataTable2, Chart2)
            End Using

            ' Récupération des données pour le troisième diagramme en courbes
            Using connection3 As New MySqlConnection(connectionString)
                Dim query3 As String = "SELECT d.Departement, r.Statut FROM demandes d JOIN (SELECT idDemande, Statut FROM Resultat) r ON d.idDemande = r.idDemande WHERE r.idDemande = d.idDemande AND r.Statut = (SELECT Statut FROM Resultat WHERE idDemande = d.idDemande LIMIT 1)"
                Using command3 As New MySqlCommand(query3, connection3)
                    connection3.Open()
                    Using adapter3 As New MySqlDataAdapter(command3)
                        adapter3.Fill(dataTable3)
                    End Using

                    ' Afficher les données dans le troisième diagramme en courbes (Line Chart) (Chart3)
                    DisplayStackedBarChart(dataTable3, Chart3)
                End Using
            End Using
              

        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayBarChart(ByVal dataTable As DataTable, ByVal chart As Chart)
        If chart Is Nothing Then
            chart = New Chart()
            chart.Size = New Drawing.Size(400, 300)
            Me.Controls.Add(chart)
        End If

        chart.Series.Clear()
        chart.Series.Add("Cout")
        chart.Series("Cout").ChartType = SeriesChartType.Bar

        For Each row As DataRow In dataTable.Rows
            Dim department As String = row("Departement").ToString()
            Dim cost As Decimal = Convert.ToDecimal(row("Cout"))

            Dim point As New DataPoint()
            point.AxisLabel = department
            point.YValues = {CDbl(cost)}
            chart.Series("Cout").Points.Add(point)
        Next

        ' Ajouter les étiquettes pour chaque point du diagramme à barres
        For Each series As Series In chart.Series
            For Each point As DataPoint In series.Points
                point.Label = "#VALY"
            Next
        Next

        chart.ChartAreas(0).AxisX.Title = "Département"
        chart.ChartAreas(0).AxisY.Title = "Coût"
        chart.Titles.Add("Coûts par Département")

        chart.Update()
    End Sub

    Private Sub DisplayPieChart(ByVal dataTable As DataTable, ByVal chart As Chart)
        If chart Is Nothing Then
            chart = New Chart()
            chart.Size = New Drawing.Size(400, 300)
            Me.Controls.Add(chart)
        End If

        chart.Series.Clear()
        chart.Series.Add("Cout")
        chart.Series("Cout").ChartType = SeriesChartType.Pie

        ' Utiliser un dictionnaire pour stocker les valeurs cumulatives de chaque catégorie
        Dim categoryValues As New Dictionary(Of String, Decimal)

        For Each row As DataRow In dataTable.Rows
            Dim category As String = row("Categories").ToString()
            Dim cost As Decimal = Convert.ToDecimal(row("Cout"))

            ' Si la catégorie existe déjà dans le dictionnaire, ajouter la valeur à la catégorie existante
            If categoryValues.ContainsKey(category) Then
                categoryValues(category) += cost
            Else
                ' Sinon, ajouter la catégorie et la valeur au dictionnaire
                categoryValues.Add(category, cost)
            End If
        Next

        ' Ajouter les valeurs cumulatives au graphique
        For Each kvp As KeyValuePair(Of String, Decimal) In categoryValues
            chart.Series("Cout").Points.AddXY(kvp.Key, kvp.Value)
        Next

        ' Ajouter les étiquettes pour chaque point du diagramme circulaire
        For Each point As DataPoint In chart.Series("Cout").Points
            point.Label = "#VALX" & vbCrLf & "#PERCENT{P0}"
        Next

        chart.Titles.Add("Répartition des Coûts par Catégories")

        chart.Update()
    End Sub

    Private Sub DisplayStackedBarChart(ByVal dataTable As DataTable, ByVal chart As Chart)
        ' Effacer les séries existantes du diagramme
        chart.Series.Clear()

        ' Créer une liste pour stocker les noms de département uniques
        Dim uniqueDepartments As New List(Of String)

        ' Parcourir les lignes du DataTable et ajouter les noms de département uniques
        For Each row As DataRow In dataTable.Rows
            Dim department As String = row("Departement").ToString()
            If Not uniqueDepartments.Contains(department) Then
                uniqueDepartments.Add(department)
            End If
        Next

        ' Ajouter les valeurs uniques de "Statut"
        Dim uniqueStatusValues As New List(Of String)
        For Each row As DataRow In dataTable.Rows
            Dim status As String = row("Statut").ToString()
            If Not uniqueStatusValues.Contains(status) Then
                uniqueStatusValues.Add(status)
            End If
        Next

        ' Parcourir les noms de département uniques et créer une série pour chaque département
        For Each department As String In uniqueDepartments
            Dim newSeries As New Series(department)
            newSeries.ChartType = SeriesChartType.StackedBar

            ' Ajouter la série au graphique
            chart.Series.Add(newSeries)

            ' Parcourir les lignes du DataTable pour ce département et ajouter les points à la série
            For Each row As DataRow In dataTable.Rows
                If row("Departement").ToString() = department Then
                    Dim status As String = row("Statut").ToString()

                    ' Ajouter le point à la série
                    Dim point As New DataPoint()
                    point.AxisLabel = department
                    point.YValues = {uniqueStatusValues.IndexOf(status) + 1} ' Index + 1 pour éviter la valeur 0
                    newSeries.Points.Add(point)
                End If
            Next
        Next

        ' Ajouter ces lignes après l'ajout des séries au contrôle Chart
        chart.ChartAreas(0).AxisX.Title = "Département"
        chart.ChartAreas(0).AxisY.Title = "Statut"
        chart.ChartAreas(0).AxisX.MajorGrid.Enabled = True
        chart.ChartAreas(0).AxisY.MajorGrid.Enabled = True

        ' Ajuster l'échelle de l'axe Y
        chart.ChartAreas(0).AxisY.Minimum = 0
        chart.ChartAreas(0).AxisY.Maximum = uniqueStatusValues.Count + 1

        ' Ajouter le titre au diagramme
        chart.Titles.Add("Diagramme à Barres Empilées : Statut en fonction des Départements")

        ' Ajouter les étiquettes pour chaque point du diagramme à barres empilées
        For Each series As Series In chart.Series
            For Each point As DataPoint In series.Points
                point.Label = uniqueStatusValues(CInt(point.YValues(0)) - 1)
            Next
        Next

        ' Mettre à jour le graphique
        chart.Update()
    End Sub
      


    ' ... (Autres méthodes et événements)

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim printDocument As New Printing.PrintDocument()

        AddHandler printDocument.PrintPage, AddressOf PrintPageHandler

        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Dim bitmap As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.Width, Me.Height))
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub



    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dispose()
        Dim formPrincipal As New Form3
        formPrincipal.ShowDialog()

    End Sub

    Private Sub Chart2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart2.Click

    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub
End Class

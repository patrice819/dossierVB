<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Demande
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.descriptiontxt = New System.Windows.Forms.TextBox()
        Me.Couttxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.categorietxt = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnSoumettre = New System.Windows.Forms.Button()
        Me.DateFin = New System.Windows.Forms.DateTimePicker()
        Me.DateDebut = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Departementtxt = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom  :"
        '
        'nom
        '
        Me.nom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(208, 122)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(316, 26)
        Me.nom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description  :"
        '
        'descriptiontxt
        '
        Me.descriptiontxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptiontxt.Location = New System.Drawing.Point(208, 184)
        Me.descriptiontxt.Multiline = True
        Me.descriptiontxt.Name = "descriptiontxt"
        Me.descriptiontxt.Size = New System.Drawing.Size(316, 50)
        Me.descriptiontxt.TabIndex = 6
        '
        'Couttxt
        '
        Me.Couttxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Couttxt.Location = New System.Drawing.Point(208, 257)
        Me.Couttxt.Name = "Couttxt"
        Me.Couttxt.Size = New System.Drawing.Size(316, 26)
        Me.Couttxt.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cout estimés :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Categories  :"
        '
        'categorietxt
        '
        Me.categorietxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorietxt.FormattingEnabled = True
        Me.categorietxt.Items.AddRange(New Object() {"Materiels informatiques ", "Formation", "Service proffessionels", "Publicite", "Divers"})
        Me.categorietxt.Location = New System.Drawing.Point(208, 331)
        Me.categorietxt.Name = "categorietxt"
        Me.categorietxt.Size = New System.Drawing.Size(316, 27)
        Me.categorietxt.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox1.Controls.Add(Me.BtnSoumettre)
        Me.GroupBox1.Controls.Add(Me.DateFin)
        Me.GroupBox1.Controls.Add(Me.DateDebut)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(600, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 315)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Importantes"
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnAnnuler.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnuler.ForeColor = System.Drawing.Color.Black
        Me.BtnAnnuler.Location = New System.Drawing.Point(238, 197)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(188, 51)
        Me.BtnAnnuler.TabIndex = 22
        Me.BtnAnnuler.Text = "Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'BtnSoumettre
        '
        Me.BtnSoumettre.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnSoumettre.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSoumettre.ForeColor = System.Drawing.Color.Black
        Me.BtnSoumettre.Location = New System.Drawing.Point(6, 197)
        Me.BtnSoumettre.Name = "BtnSoumettre"
        Me.BtnSoumettre.Size = New System.Drawing.Size(188, 52)
        Me.BtnSoumettre.TabIndex = 21
        Me.BtnSoumettre.Text = "Soumettre"
        Me.BtnSoumettre.UseVisualStyleBackColor = False
        '
        'DateFin
        '
        Me.DateFin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFin.Location = New System.Drawing.Point(106, 122)
        Me.DateFin.Name = "DateFin"
        Me.DateFin.Size = New System.Drawing.Size(170, 26)
        Me.DateFin.TabIndex = 20
        '
        'DateDebut
        '
        Me.DateDebut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDebut.Location = New System.Drawing.Point(106, 51)
        Me.DateDebut.Name = "DateDebut"
        Me.DateDebut.Size = New System.Drawing.Size(170, 26)
        Me.DateDebut.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Fin :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Début :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(470, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(391, 36)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "DEMANDE DE BUDGET"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Location = New System.Drawing.Point(1, 589)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1204, 32)
        Me.Panel2.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Departement  :"
        '
        'Departementtxt
        '
        Me.Departementtxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departementtxt.FormattingEnabled = True
        Me.Departementtxt.Items.AddRange(New Object() {"Informatique", "Gestion des Resssources Humaines", "Service  Client", "Marketing", "Administration Generale", "Logistique"})
        Me.Departementtxt.Location = New System.Drawing.Point(208, 406)
        Me.Departementtxt.Name = "Departementtxt"
        Me.Departementtxt.Size = New System.Drawing.Size(316, 27)
        Me.Departementtxt.TabIndex = 22
        '
        'Demande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1206, 623)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Departementtxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.categorietxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Couttxt)
        Me.Controls.Add(Me.descriptiontxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Demande"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire de demande"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents descriptiontxt As System.Windows.Forms.TextBox
    Friend WithEvents Couttxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents categorietxt As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateDebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSoumettre As System.Windows.Forms.Button
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Departementtxt As System.Windows.Forms.ComboBox
End Class

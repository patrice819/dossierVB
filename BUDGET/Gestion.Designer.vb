<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonEnAttente = New System.Windows.Forms.Button()
        Me.ButtonRefuser = New System.Windows.Forms.Button()
        Me.ButtonApprouver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BoutonApprouver = New System.Windows.Forms.Button()
        Me.Refuser = New System.Windows.Forms.Button()
        Me.Resultats = New Guna.UI.WinForms.GunaDataGridView()
        CType(Me.Resultats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 1
        '
        'ButtonEnAttente
        '
        Me.ButtonEnAttente.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonEnAttente.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnAttente.Location = New System.Drawing.Point(317, 413)
        Me.ButtonEnAttente.Name = "ButtonEnAttente"
        Me.ButtonEnAttente.Size = New System.Drawing.Size(157, 48)
        Me.ButtonEnAttente.TabIndex = 11
        Me.ButtonEnAttente.Text = "en Attente"
        Me.ButtonEnAttente.UseVisualStyleBackColor = False
        '
        'ButtonRefuser
        '
        Me.ButtonRefuser.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonRefuser.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefuser.Location = New System.Drawing.Point(600, 413)
        Me.ButtonRefuser.Name = "ButtonRefuser"
        Me.ButtonRefuser.Size = New System.Drawing.Size(157, 48)
        Me.ButtonRefuser.TabIndex = 14
        Me.ButtonRefuser.Text = "Rejeter"
        Me.ButtonRefuser.UseVisualStyleBackColor = False
        '
        'ButtonApprouver
        '
        Me.ButtonApprouver.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonApprouver.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonApprouver.Location = New System.Drawing.Point(57, 415)
        Me.ButtonApprouver.Name = "ButtonApprouver"
        Me.ButtonApprouver.Size = New System.Drawing.Size(157, 48)
        Me.ButtonApprouver.TabIndex = 15
        Me.ButtonApprouver.Text = "Appprouver"
        Me.ButtonApprouver.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(490, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTES DES DEMANDES"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(890, 411)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 52)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Menu Principal"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BoutonApprouver
        '
        Me.BoutonApprouver.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoutonApprouver.Location = New System.Drawing.Point(57, 506)
        Me.BoutonApprouver.Name = "BoutonApprouver"
        Me.BoutonApprouver.Size = New System.Drawing.Size(157, 48)
        Me.BoutonApprouver.TabIndex = 15
        Me.BoutonApprouver.Text = "Appprouver"
        Me.BoutonApprouver.UseVisualStyleBackColor = True
        '
        'Refuser
        '
        Me.Refuser.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refuser.Location = New System.Drawing.Point(599, 510)
        Me.Refuser.Name = "Refuser"
        Me.Refuser.Size = New System.Drawing.Size(157, 48)
        Me.Refuser.TabIndex = 14
        Me.Refuser.Text = "Rejeter"
        Me.Refuser.UseVisualStyleBackColor = True
        '
        'Resultats
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Resultats.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Resultats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Resultats.BackgroundColor = System.Drawing.Color.White
        Me.Resultats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Resultats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Resultats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Resultats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Resultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Resultats.DefaultCellStyle = DataGridViewCellStyle3
        Me.Resultats.EnableHeadersVisualStyles = False
        Me.Resultats.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Resultats.Location = New System.Drawing.Point(12, 69)
        Me.Resultats.Name = "Resultats"
        Me.Resultats.RowHeadersVisible = False
        Me.Resultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Resultats.Size = New System.Drawing.Size(1129, 312)
        Me.Resultats.TabIndex = 20
        Me.Resultats.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.Resultats.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Resultats.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Resultats.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Resultats.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Resultats.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Resultats.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Resultats.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Resultats.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Resultats.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Resultats.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Resultats.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Resultats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Resultats.ThemeStyle.HeaderStyle.Height = 21
        Me.Resultats.ThemeStyle.ReadOnly = False
        Me.Resultats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Resultats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Resultats.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Resultats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Resultats.ThemeStyle.RowsStyle.Height = 22
        Me.Resultats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Resultats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 477)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Resultats)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonApprouver)
        Me.Controls.Add(Me.ButtonRefuser)
        Me.Controls.Add(Me.ButtonEnAttente)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Gestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualisation de la demande"
        CType(Me.Resultats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonEnAttente As System.Windows.Forms.Button
    Friend WithEvents ButtonRefuser As System.Windows.Forms.Button
    Friend WithEvents ButtonApprouver As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BoutonApprouver As System.Windows.Forms.Button
    Friend WithEvents Refuser As System.Windows.Forms.Button
    Friend WithEvents Resultats As Guna.UI.WinForms.GunaDataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssistenz
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim KorrespondenzLabel As System.Windows.Forms.Label
        Dim Korrespondenz_fremdsprachigLabel As System.Windows.Forms.Label
        Dim ÜbersetzungenLabel As System.Windows.Forms.Label
        Dim TermineLabel As System.Windows.Forms.Label
        Dim PräsentationenLabel As System.Windows.Forms.Label
        Dim ReiseplanungLabel As System.Windows.Forms.Label
        Dim ReisekostenabrechnungLabel As System.Windows.Forms.Label
        Dim VeranstaltungsmanagementLabel As System.Windows.Forms.Label
        Dim ProjektmanagementLabel As System.Windows.Forms.Label
        Dim DokumentenmanagementLabel As System.Windows.Forms.Label
        Dim SonstigeLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DokumentenmanagementComboBox = New System.Windows.Forms.ComboBox()
        Me.Bew_assistenzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.ProjektmanagementComboBox = New System.Windows.Forms.ComboBox()
        Me.VeranstaltungsmanagementComboBox = New System.Windows.Forms.ComboBox()
        Me.TermineComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SonstigeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PräsentationenComboBox = New System.Windows.Forms.ComboBox()
        Me.ReisekostenabrechnungComboBox = New System.Windows.Forms.ComboBox()
        Me.ReiseplanungComboBox = New System.Windows.Forms.ComboBox()
        Me.ÜbersetzungenComboBox = New System.Windows.Forms.ComboBox()
        Me.Korrespondenz_fremdsprachigComboBox = New System.Windows.Forms.ComboBox()
        Me.KorrespondenzComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Bew_assistenzTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bew_assistenzTableAdapter()
        KorrespondenzLabel = New System.Windows.Forms.Label()
        Korrespondenz_fremdsprachigLabel = New System.Windows.Forms.Label()
        ÜbersetzungenLabel = New System.Windows.Forms.Label()
        TermineLabel = New System.Windows.Forms.Label()
        PräsentationenLabel = New System.Windows.Forms.Label()
        ReiseplanungLabel = New System.Windows.Forms.Label()
        ReisekostenabrechnungLabel = New System.Windows.Forms.Label()
        VeranstaltungsmanagementLabel = New System.Windows.Forms.Label()
        ProjektmanagementLabel = New System.Windows.Forms.Label()
        DokumentenmanagementLabel = New System.Windows.Forms.Label()
        SonstigeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Bew_assistenzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KorrespondenzLabel
        '
        KorrespondenzLabel.AutoSize = True
        KorrespondenzLabel.Location = New System.Drawing.Point(16, 28)
        KorrespondenzLabel.Name = "KorrespondenzLabel"
        KorrespondenzLabel.Size = New System.Drawing.Size(116, 16)
        KorrespondenzLabel.TabIndex = 0
        KorrespondenzLabel.Text = "Korrespondenz:"
        '
        'Korrespondenz_fremdsprachigLabel
        '
        Korrespondenz_fremdsprachigLabel.AutoSize = True
        Korrespondenz_fremdsprachigLabel.Location = New System.Drawing.Point(510, 18)
        Korrespondenz_fremdsprachigLabel.Name = "Korrespondenz_fremdsprachigLabel"
        Korrespondenz_fremdsprachigLabel.Size = New System.Drawing.Size(116, 32)
        Korrespondenz_fremdsprachigLabel.TabIndex = 2
        Korrespondenz_fremdsprachigLabel.Text = "Korrespondenz " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fremdsprachig:"
        '
        'ÜbersetzungenLabel
        '
        ÜbersetzungenLabel.AutoSize = True
        ÜbersetzungenLabel.Location = New System.Drawing.Point(919, 28)
        ÜbersetzungenLabel.Name = "ÜbersetzungenLabel"
        ÜbersetzungenLabel.Size = New System.Drawing.Size(116, 16)
        ÜbersetzungenLabel.TabIndex = 4
        ÜbersetzungenLabel.Text = "Übersetzungen:"
        '
        'TermineLabel
        '
        TermineLabel.AutoSize = True
        TermineLabel.Location = New System.Drawing.Point(16, 30)
        TermineLabel.Name = "TermineLabel"
        TermineLabel.Size = New System.Drawing.Size(149, 16)
        TermineLabel.TabIndex = 6
        TermineLabel.Text = "Terminmanagement:"
        '
        'PräsentationenLabel
        '
        PräsentationenLabel.AutoSize = True
        PräsentationenLabel.Location = New System.Drawing.Point(919, 80)
        PräsentationenLabel.Name = "PräsentationenLabel"
        PräsentationenLabel.Size = New System.Drawing.Size(116, 16)
        PräsentationenLabel.TabIndex = 6
        PräsentationenLabel.Text = "Präsentationen:"
        '
        'ReiseplanungLabel
        '
        ReiseplanungLabel.AutoSize = True
        ReiseplanungLabel.Location = New System.Drawing.Point(16, 85)
        ReiseplanungLabel.Name = "ReiseplanungLabel"
        ReiseplanungLabel.Size = New System.Drawing.Size(108, 16)
        ReiseplanungLabel.TabIndex = 8
        ReiseplanungLabel.Text = "Reiseplanung:"
        '
        'ReisekostenabrechnungLabel
        '
        ReisekostenabrechnungLabel.AutoSize = True
        ReisekostenabrechnungLabel.Location = New System.Drawing.Point(452, 85)
        ReisekostenabrechnungLabel.Name = "ReisekostenabrechnungLabel"
        ReisekostenabrechnungLabel.Size = New System.Drawing.Size(180, 16)
        ReisekostenabrechnungLabel.TabIndex = 10
        ReisekostenabrechnungLabel.Text = "Reisekostenabrechnung:"
        '
        'VeranstaltungsmanagementLabel
        '
        VeranstaltungsmanagementLabel.AutoSize = True
        VeranstaltungsmanagementLabel.Location = New System.Drawing.Point(428, 30)
        VeranstaltungsmanagementLabel.Name = "VeranstaltungsmanagementLabel"
        VeranstaltungsmanagementLabel.Size = New System.Drawing.Size(204, 16)
        VeranstaltungsmanagementLabel.TabIndex = 7
        VeranstaltungsmanagementLabel.Text = "Veranstaltungsmanagement:"
        '
        'ProjektmanagementLabel
        '
        ProjektmanagementLabel.AutoSize = True
        ProjektmanagementLabel.Location = New System.Drawing.Point(887, 30)
        ProjektmanagementLabel.Name = "ProjektmanagementLabel"
        ProjektmanagementLabel.Size = New System.Drawing.Size(150, 16)
        ProjektmanagementLabel.TabIndex = 8
        ProjektmanagementLabel.Text = "Projektmanagement:"
        '
        'DokumentenmanagementLabel
        '
        DokumentenmanagementLabel.AutoSize = True
        DokumentenmanagementLabel.Location = New System.Drawing.Point(16, 88)
        DokumentenmanagementLabel.Name = "DokumentenmanagementLabel"
        DokumentenmanagementLabel.Size = New System.Drawing.Size(187, 16)
        DokumentenmanagementLabel.TabIndex = 9
        DokumentenmanagementLabel.Text = "Dokumentenmanagement:"
        '
        'SonstigeLabel
        '
        SonstigeLabel.AutoSize = True
        SonstigeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SonstigeLabel.Location = New System.Drawing.Point(16, 137)
        SonstigeLabel.Name = "SonstigeLabel"
        SonstigeLabel.Size = New System.Drawing.Size(138, 30)
        SonstigeLabel.TabIndex = 25
        SonstigeLabel.Text = "Sonstige " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Assistenztätigkeiten:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1245, 414)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1234, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Bitte geben Sie Ihre Kenntnisse bei Assistenztätigkeiten an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.DokumentenmanagementComboBox)
        Me.GroupBox2.Controls.Add(Me.ProjektmanagementComboBox)
        Me.GroupBox2.Controls.Add(Me.VeranstaltungsmanagementComboBox)
        Me.GroupBox2.Controls.Add(Me.TermineComboBox)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(SonstigeLabel)
        Me.GroupBox2.Controls.Add(DokumentenmanagementLabel)
        Me.GroupBox2.Controls.Add(ProjektmanagementLabel)
        Me.GroupBox2.Controls.Add(Me.SonstigeTextBox)
        Me.GroupBox2.Controls.Add(VeranstaltungsmanagementLabel)
        Me.GroupBox2.Controls.Add(TermineLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1234, 253)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Management:"
        '
        'DokumentenmanagementComboBox
        '
        Me.DokumentenmanagementComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "dokumentenmanagement", True))
        Me.DokumentenmanagementComboBox.FormattingEnabled = True
        Me.DokumentenmanagementComboBox.Location = New System.Drawing.Point(222, 85)
        Me.DokumentenmanagementComboBox.Name = "DokumentenmanagementComboBox"
        Me.DokumentenmanagementComboBox.Size = New System.Drawing.Size(174, 24)
        Me.DokumentenmanagementComboBox.TabIndex = 4
        '
        'Bew_assistenzBindingSource
        '
        Me.Bew_assistenzBindingSource.DataMember = "bew_assistenz"
        Me.Bew_assistenzBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProjektmanagementComboBox
        '
        Me.ProjektmanagementComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "projektmanagement", True))
        Me.ProjektmanagementComboBox.FormattingEnabled = True
        Me.ProjektmanagementComboBox.Location = New System.Drawing.Point(1043, 27)
        Me.ProjektmanagementComboBox.Name = "ProjektmanagementComboBox"
        Me.ProjektmanagementComboBox.Size = New System.Drawing.Size(185, 24)
        Me.ProjektmanagementComboBox.TabIndex = 3
        '
        'VeranstaltungsmanagementComboBox
        '
        Me.VeranstaltungsmanagementComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "veranstaltungsmanagement", True))
        Me.VeranstaltungsmanagementComboBox.FormattingEnabled = True
        Me.VeranstaltungsmanagementComboBox.Location = New System.Drawing.Point(641, 27)
        Me.VeranstaltungsmanagementComboBox.Name = "VeranstaltungsmanagementComboBox"
        Me.VeranstaltungsmanagementComboBox.Size = New System.Drawing.Size(174, 24)
        Me.VeranstaltungsmanagementComboBox.TabIndex = 2
        '
        'TermineComboBox
        '
        Me.TermineComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "termine", True))
        Me.TermineComboBox.FormattingEnabled = True
        Me.TermineComboBox.Location = New System.Drawing.Point(222, 27)
        Me.TermineComboBox.Name = "TermineComboBox"
        Me.TermineComboBox.Size = New System.Drawing.Size(174, 24)
        Me.TermineComboBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Wheat
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(624, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 60)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Assistenz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SonstigeTextBox
        '
        Me.SonstigeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "sonstige", True))
        Me.SonstigeTextBox.Location = New System.Drawing.Point(198, 134)
        Me.SonstigeTextBox.Multiline = True
        Me.SonstigeTextBox.Name = "SonstigeTextBox"
        Me.SonstigeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SonstigeTextBox.Size = New System.Drawing.Size(297, 100)
        Me.SonstigeTextBox.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.PräsentationenComboBox)
        Me.GroupBox1.Controls.Add(Me.ReisekostenabrechnungComboBox)
        Me.GroupBox1.Controls.Add(Me.ReiseplanungComboBox)
        Me.GroupBox1.Controls.Add(Me.ÜbersetzungenComboBox)
        Me.GroupBox1.Controls.Add(Me.Korrespondenz_fremdsprachigComboBox)
        Me.GroupBox1.Controls.Add(Me.KorrespondenzComboBox1)
        Me.GroupBox1.Controls.Add(ReisekostenabrechnungLabel)
        Me.GroupBox1.Controls.Add(ReiseplanungLabel)
        Me.GroupBox1.Controls.Add(PräsentationenLabel)
        Me.GroupBox1.Controls.Add(ÜbersetzungenLabel)
        Me.GroupBox1.Controls.Add(Korrespondenz_fremdsprachigLabel)
        Me.GroupBox1.Controls.Add(KorrespondenzLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1234, 120)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assistenz"
        '
        'PräsentationenComboBox
        '
        Me.PräsentationenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "präsentationen", True))
        Me.PräsentationenComboBox.FormattingEnabled = True
        Me.PräsentationenComboBox.Location = New System.Drawing.Point(1041, 77)
        Me.PräsentationenComboBox.Name = "PräsentationenComboBox"
        Me.PräsentationenComboBox.Size = New System.Drawing.Size(187, 24)
        Me.PräsentationenComboBox.TabIndex = 6
        '
        'ReisekostenabrechnungComboBox
        '
        Me.ReisekostenabrechnungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "reisekostenabrechnung", True))
        Me.ReisekostenabrechnungComboBox.FormattingEnabled = True
        Me.ReisekostenabrechnungComboBox.Location = New System.Drawing.Point(641, 82)
        Me.ReisekostenabrechnungComboBox.Name = "ReisekostenabrechnungComboBox"
        Me.ReisekostenabrechnungComboBox.Size = New System.Drawing.Size(186, 24)
        Me.ReisekostenabrechnungComboBox.TabIndex = 5
        '
        'ReiseplanungComboBox
        '
        Me.ReiseplanungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "reiseplanung", True))
        Me.ReiseplanungComboBox.FormattingEnabled = True
        Me.ReiseplanungComboBox.Location = New System.Drawing.Point(222, 80)
        Me.ReiseplanungComboBox.Name = "ReiseplanungComboBox"
        Me.ReiseplanungComboBox.Size = New System.Drawing.Size(186, 24)
        Me.ReiseplanungComboBox.TabIndex = 4
        '
        'ÜbersetzungenComboBox
        '
        Me.ÜbersetzungenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "übersetzungen", True))
        Me.ÜbersetzungenComboBox.FormattingEnabled = True
        Me.ÜbersetzungenComboBox.Location = New System.Drawing.Point(1041, 25)
        Me.ÜbersetzungenComboBox.Name = "ÜbersetzungenComboBox"
        Me.ÜbersetzungenComboBox.Size = New System.Drawing.Size(185, 24)
        Me.ÜbersetzungenComboBox.TabIndex = 3
        '
        'Korrespondenz_fremdsprachigComboBox
        '
        Me.Korrespondenz_fremdsprachigComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "korrespondenz_fremdsprachig", True))
        Me.Korrespondenz_fremdsprachigComboBox.FormattingEnabled = True
        Me.Korrespondenz_fremdsprachigComboBox.Location = New System.Drawing.Point(641, 25)
        Me.Korrespondenz_fremdsprachigComboBox.Name = "Korrespondenz_fremdsprachigComboBox"
        Me.Korrespondenz_fremdsprachigComboBox.Size = New System.Drawing.Size(185, 24)
        Me.Korrespondenz_fremdsprachigComboBox.TabIndex = 2
        '
        'KorrespondenzComboBox1
        '
        Me.KorrespondenzComboBox1.BackColor = System.Drawing.Color.White
        Me.KorrespondenzComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_assistenzBindingSource, "korrespondenz", True))
        Me.KorrespondenzComboBox1.FormattingEnabled = True
        Me.KorrespondenzComboBox1.Location = New System.Drawing.Point(222, 25)
        Me.KorrespondenzComboBox1.Name = "KorrespondenzComboBox1"
        Me.KorrespondenzComboBox1.Size = New System.Drawing.Size(185, 24)
        Me.KorrespondenzComboBox1.TabIndex = 1
        '
        'Bew_assistenzTableAdapter
        '
        Me.Bew_assistenzTableAdapter.ClearBeforeFill = True
        '
        'frmAssistenz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1251, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAssistenz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Assistenz"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Bew_assistenzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SonstigeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KorrespondenzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bew_assistenzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bew_assistenzTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bew_assistenzTableAdapter
    Friend WithEvents KorrespondenzComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DokumentenmanagementComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProjektmanagementComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VeranstaltungsmanagementComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TermineComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PräsentationenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ReisekostenabrechnungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ReiseplanungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ÜbersetzungenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Korrespondenz_fremdsprachigComboBox As System.Windows.Forms.ComboBox
End Class

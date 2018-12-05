<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalverwaltung
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
        Dim Personal_rekrutierungLabel As System.Windows.Forms.Label
        Dim Personal_bewerbungsgesprächeLabel As System.Windows.Forms.Label
        Dim Personal_assessmentcenterLabel As System.Windows.Forms.Label
        Dim Personal_sachbearbeitungLabel As System.Windows.Forms.Label
        Dim Personal_vertraegeLabel As System.Windows.Forms.Label
        Dim Personal_melde_bescheinigungswesenLabel As System.Windows.Forms.Label
        Dim Personal_bavLabel As System.Windows.Forms.Label
        Dim Personal_tarifvertragLabel As System.Windows.Forms.Label
        Dim Personal_betriebsratLabel As System.Windows.Forms.Label
        Dim Personal_arbeitsrechtLabel As System.Windows.Forms.Label
        Dim Personal_sozversrechtLabel As System.Windows.Forms.Label
        Dim Personal_lohnsteuerLabel As System.Windows.Forms.Label
        Dim Personal_personalentwicklungLabel As System.Windows.Forms.Label
        Dim Personal_ausbildungLabel As System.Windows.Forms.Label
        Dim Personal_zeiterfassungLabel As System.Windows.Forms.Label
        Dim Personal_zeiterfassung_softwareLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Personal_zeiterfassung_softwareTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_personalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Personal_zeiterfassungComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_tarifvertrag_erfahrungComboBox = New System.Windows.Forms.ComboBox()
        Me.btnPersonalverwaltung = New System.Windows.Forms.Button()
        Me.Personal_tarifverträgeListBox = New System.Windows.Forms.ListBox()
        Me.Label289 = New System.Windows.Forms.Label()
        Me.Personal_sonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.Label186 = New System.Windows.Forms.Label()
        Me.Personal_ausbildungComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_personalentwicklungComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_lohnsteuerComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_sozversrechtComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_arbeitsrechtComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_betriebsratComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_bavComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_melde_bescheinigungswesenComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_vertraegeComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_sachbearbeitungComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_assessmentcenterComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_bewerbungsgesprächeComboBox = New System.Windows.Forms.ComboBox()
        Me.Personal_rekrutierungComboBox = New System.Windows.Forms.ComboBox()
        Me.Bewerber_personalTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_personalTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Personal_rekrutierungLabel = New System.Windows.Forms.Label()
        Personal_bewerbungsgesprächeLabel = New System.Windows.Forms.Label()
        Personal_assessmentcenterLabel = New System.Windows.Forms.Label()
        Personal_sachbearbeitungLabel = New System.Windows.Forms.Label()
        Personal_vertraegeLabel = New System.Windows.Forms.Label()
        Personal_melde_bescheinigungswesenLabel = New System.Windows.Forms.Label()
        Personal_bavLabel = New System.Windows.Forms.Label()
        Personal_tarifvertragLabel = New System.Windows.Forms.Label()
        Personal_betriebsratLabel = New System.Windows.Forms.Label()
        Personal_arbeitsrechtLabel = New System.Windows.Forms.Label()
        Personal_sozversrechtLabel = New System.Windows.Forms.Label()
        Personal_lohnsteuerLabel = New System.Windows.Forms.Label()
        Personal_personalentwicklungLabel = New System.Windows.Forms.Label()
        Personal_ausbildungLabel = New System.Windows.Forms.Label()
        Personal_zeiterfassungLabel = New System.Windows.Forms.Label()
        Personal_zeiterfassung_softwareLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Bewerber_personalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Personal_rekrutierungLabel
        '
        Personal_rekrutierungLabel.AutoSize = True
        Personal_rekrutierungLabel.Location = New System.Drawing.Point(6, 29)
        Personal_rekrutierungLabel.Name = "Personal_rekrutierungLabel"
        Personal_rekrutierungLabel.Size = New System.Drawing.Size(130, 16)
        Personal_rekrutierungLabel.TabIndex = 0
        Personal_rekrutierungLabel.Text = "Personalauswahl:"
        '
        'Personal_bewerbungsgesprächeLabel
        '
        Personal_bewerbungsgesprächeLabel.AutoSize = True
        Personal_bewerbungsgesprächeLabel.Location = New System.Drawing.Point(427, 29)
        Personal_bewerbungsgesprächeLabel.Name = "Personal_bewerbungsgesprächeLabel"
        Personal_bewerbungsgesprächeLabel.Size = New System.Drawing.Size(162, 16)
        Personal_bewerbungsgesprächeLabel.TabIndex = 2
        Personal_bewerbungsgesprächeLabel.Text = "Bewerbungsgespräch:"
        '
        'Personal_assessmentcenterLabel
        '
        Personal_assessmentcenterLabel.AutoSize = True
        Personal_assessmentcenterLabel.Location = New System.Drawing.Point(885, 29)
        Personal_assessmentcenterLabel.Name = "Personal_assessmentcenterLabel"
        Personal_assessmentcenterLabel.Size = New System.Drawing.Size(139, 16)
        Personal_assessmentcenterLabel.TabIndex = 4
        Personal_assessmentcenterLabel.Text = "Assessmentcenter:"
        '
        'Personal_sachbearbeitungLabel
        '
        Personal_sachbearbeitungLabel.AutoSize = True
        Personal_sachbearbeitungLabel.Location = New System.Drawing.Point(6, 87)
        Personal_sachbearbeitungLabel.Name = "Personal_sachbearbeitungLabel"
        Personal_sachbearbeitungLabel.Size = New System.Drawing.Size(130, 16)
        Personal_sachbearbeitungLabel.TabIndex = 6
        Personal_sachbearbeitungLabel.Text = "Sachbearbeitung:"
        '
        'Personal_vertraegeLabel
        '
        Personal_vertraegeLabel.AutoSize = True
        Personal_vertraegeLabel.Location = New System.Drawing.Point(410, 87)
        Personal_vertraegeLabel.Name = "Personal_vertraegeLabel"
        Personal_vertraegeLabel.Size = New System.Drawing.Size(181, 16)
        Personal_vertraegeLabel.TabIndex = 8
        Personal_vertraegeLabel.Text = "Verträge, Zeugnisse etc.:"
        '
        'Personal_melde_bescheinigungswesenLabel
        '
        Personal_melde_bescheinigungswesenLabel.AutoSize = True
        Personal_melde_bescheinigungswesenLabel.Location = New System.Drawing.Point(422, 231)
        Personal_melde_bescheinigungswesenLabel.Name = "Personal_melde_bescheinigungswesenLabel"
        Personal_melde_bescheinigungswesenLabel.Size = New System.Drawing.Size(166, 32)
        Personal_melde_bescheinigungswesenLabel.TabIndex = 10
        Personal_melde_bescheinigungswesenLabel.Text = "Melde- und  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bescheinigungswesen:"
        '
        'Personal_bavLabel
        '
        Personal_bavLabel.AutoSize = True
        Personal_bavLabel.Location = New System.Drawing.Point(807, 87)
        Personal_bavLabel.Name = "Personal_bavLabel"
        Personal_bavLabel.Size = New System.Drawing.Size(217, 16)
        Personal_bavLabel.TabIndex = 14
        Personal_bavLabel.Text = "Betriebliche Altersversorgung:"
        '
        'Personal_tarifvertragLabel
        '
        Personal_tarifvertragLabel.AutoSize = True
        Personal_tarifvertragLabel.Location = New System.Drawing.Point(6, 144)
        Personal_tarifvertragLabel.Name = "Personal_tarifvertragLabel"
        Personal_tarifvertragLabel.Size = New System.Drawing.Size(102, 16)
        Personal_tarifvertragLabel.TabIndex = 16
        Personal_tarifvertragLabel.Text = "Tarifverträge:"
        '
        'Personal_betriebsratLabel
        '
        Personal_betriebsratLabel.AutoSize = True
        Personal_betriebsratLabel.Location = New System.Drawing.Point(451, 144)
        Personal_betriebsratLabel.Name = "Personal_betriebsratLabel"
        Personal_betriebsratLabel.Size = New System.Drawing.Size(136, 16)
        Personal_betriebsratLabel.TabIndex = 18
        Personal_betriebsratLabel.Text = "Betriebsratsarbeit:"
        '
        'Personal_arbeitsrechtLabel
        '
        Personal_arbeitsrechtLabel.AutoSize = True
        Personal_arbeitsrechtLabel.Location = New System.Drawing.Point(6, 192)
        Personal_arbeitsrechtLabel.Name = "Personal_arbeitsrechtLabel"
        Personal_arbeitsrechtLabel.Size = New System.Drawing.Size(95, 16)
        Personal_arbeitsrechtLabel.TabIndex = 20
        Personal_arbeitsrechtLabel.Text = "Arbeitsrecht:"
        '
        'Personal_sozversrechtLabel
        '
        Personal_sozversrechtLabel.AutoSize = True
        Personal_sozversrechtLabel.Location = New System.Drawing.Point(404, 192)
        Personal_sozversrechtLabel.Name = "Personal_sozversrechtLabel"
        Personal_sozversrechtLabel.Size = New System.Drawing.Size(186, 16)
        Personal_sozversrechtLabel.TabIndex = 22
        Personal_sozversrechtLabel.Text = "Sozialversicherungsrecht:"
        '
        'Personal_lohnsteuerLabel
        '
        Personal_lohnsteuerLabel.AutoSize = True
        Personal_lohnsteuerLabel.Location = New System.Drawing.Point(902, 192)
        Personal_lohnsteuerLabel.Name = "Personal_lohnsteuerLabel"
        Personal_lohnsteuerLabel.Size = New System.Drawing.Size(122, 16)
        Personal_lohnsteuerLabel.TabIndex = 24
        Personal_lohnsteuerLabel.Text = "Lohnsteuerrecht:"
        '
        'Personal_personalentwicklungLabel
        '
        Personal_personalentwicklungLabel.AutoSize = True
        Personal_personalentwicklungLabel.Location = New System.Drawing.Point(5, 231)
        Personal_personalentwicklungLabel.Name = "Personal_personalentwicklungLabel"
        Personal_personalentwicklungLabel.Size = New System.Drawing.Size(92, 32)
        Personal_personalentwicklungLabel.TabIndex = 26
        Personal_personalentwicklungLabel.Text = "Personal-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entwicklung:"
        '
        'Personal_ausbildungLabel
        '
        Personal_ausbildungLabel.AutoSize = True
        Personal_ausbildungLabel.Location = New System.Drawing.Point(858, 144)
        Personal_ausbildungLabel.Name = "Personal_ausbildungLabel"
        Personal_ausbildungLabel.Size = New System.Drawing.Size(166, 16)
        Personal_ausbildungLabel.TabIndex = 28
        Personal_ausbildungLabel.Text = "Ausbildungsbetreuung:"
        '
        'Personal_zeiterfassungLabel
        '
        Personal_zeiterfassungLabel.AutoSize = True
        Personal_zeiterfassungLabel.Location = New System.Drawing.Point(918, 241)
        Personal_zeiterfassungLabel.Name = "Personal_zeiterfassungLabel"
        Personal_zeiterfassungLabel.Size = New System.Drawing.Size(106, 16)
        Personal_zeiterfassungLabel.TabIndex = 75
        Personal_zeiterfassungLabel.Text = "Zeiterfassung:"
        '
        'Personal_zeiterfassung_softwareLabel
        '
        Personal_zeiterfassung_softwareLabel.AutoSize = True
        Personal_zeiterfassung_softwareLabel.Location = New System.Drawing.Point(852, 283)
        Personal_zeiterfassung_softwareLabel.Name = "Personal_zeiterfassung_softwareLabel"
        Personal_zeiterfassung_softwareLabel.Size = New System.Drawing.Size(172, 16)
        Personal_zeiterfassung_softwareLabel.TabIndex = 76
        Personal_zeiterfassung_softwareLabel.Text = "Zeiterfassungssoftware:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1245, 527)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1234, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte in der Personalverwaltung an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Personal_zeiterfassung_softwareTextBox)
        Me.GroupBox1.Controls.Add(Me.Personal_zeiterfassungComboBox)
        Me.GroupBox1.Controls.Add(Personal_zeiterfassung_softwareLabel)
        Me.GroupBox1.Controls.Add(Personal_zeiterfassungLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_tarifvertrag_erfahrungComboBox)
        Me.GroupBox1.Controls.Add(Me.btnPersonalverwaltung)
        Me.GroupBox1.Controls.Add(Me.Personal_tarifverträgeListBox)
        Me.GroupBox1.Controls.Add(Me.Label289)
        Me.GroupBox1.Controls.Add(Me.Personal_sonstigesTextBox)
        Me.GroupBox1.Controls.Add(Me.Label186)
        Me.GroupBox1.Controls.Add(Personal_ausbildungLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_ausbildungComboBox)
        Me.GroupBox1.Controls.Add(Personal_personalentwicklungLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_personalentwicklungComboBox)
        Me.GroupBox1.Controls.Add(Personal_lohnsteuerLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_lohnsteuerComboBox)
        Me.GroupBox1.Controls.Add(Personal_sozversrechtLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_sozversrechtComboBox)
        Me.GroupBox1.Controls.Add(Personal_arbeitsrechtLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_arbeitsrechtComboBox)
        Me.GroupBox1.Controls.Add(Personal_betriebsratLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_betriebsratComboBox)
        Me.GroupBox1.Controls.Add(Personal_tarifvertragLabel)
        Me.GroupBox1.Controls.Add(Personal_bavLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_bavComboBox)
        Me.GroupBox1.Controls.Add(Personal_melde_bescheinigungswesenLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_melde_bescheinigungswesenComboBox)
        Me.GroupBox1.Controls.Add(Personal_vertraegeLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_vertraegeComboBox)
        Me.GroupBox1.Controls.Add(Personal_sachbearbeitungLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_sachbearbeitungComboBox)
        Me.GroupBox1.Controls.Add(Personal_assessmentcenterLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_assessmentcenterComboBox)
        Me.GroupBox1.Controls.Add(Personal_bewerbungsgesprächeLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_bewerbungsgesprächeComboBox)
        Me.GroupBox1.Controls.Add(Personal_rekrutierungLabel)
        Me.GroupBox1.Controls.Add(Me.Personal_rekrutierungComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1236, 498)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personalverwaltung"
        '
        'Personal_zeiterfassung_softwareTextBox
        '
        Me.Personal_zeiterfassung_softwareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_zeiterfassung_software", True))
        Me.Personal_zeiterfassung_softwareTextBox.Location = New System.Drawing.Point(1030, 280)
        Me.Personal_zeiterfassung_softwareTextBox.Multiline = True
        Me.Personal_zeiterfassung_softwareTextBox.Name = "Personal_zeiterfassung_softwareTextBox"
        Me.Personal_zeiterfassung_softwareTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Personal_zeiterfassung_softwareTextBox.Size = New System.Drawing.Size(174, 59)
        Me.Personal_zeiterfassung_softwareTextBox.TabIndex = 16
        '
        'Bewerber_personalBindingSource
        '
        Me.Bewerber_personalBindingSource.DataMember = "bewerber_personal"
        Me.Bewerber_personalBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Personal_zeiterfassungComboBox
        '
        Me.Personal_zeiterfassungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_zeiterfassung", True))
        Me.Personal_zeiterfassungComboBox.FormattingEnabled = True
        Me.Personal_zeiterfassungComboBox.Location = New System.Drawing.Point(1030, 238)
        Me.Personal_zeiterfassungComboBox.Name = "Personal_zeiterfassungComboBox"
        Me.Personal_zeiterfassungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_zeiterfassungComboBox.TabIndex = 15
        '
        'Personal_tarifvertrag_erfahrungComboBox
        '
        Me.Personal_tarifvertrag_erfahrungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_tarifvertrag", True))
        Me.Personal_tarifvertrag_erfahrungComboBox.FormattingEnabled = True
        Me.Personal_tarifvertrag_erfahrungComboBox.Location = New System.Drawing.Point(152, 141)
        Me.Personal_tarifvertrag_erfahrungComboBox.Name = "Personal_tarifvertrag_erfahrungComboBox"
        Me.Personal_tarifvertrag_erfahrungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_tarifvertrag_erfahrungComboBox.TabIndex = 7
        '
        'btnPersonalverwaltung
        '
        Me.btnPersonalverwaltung.BackColor = System.Drawing.Color.Wheat
        Me.btnPersonalverwaltung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnPersonalverwaltung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonalverwaltung.Location = New System.Drawing.Point(553, 418)
        Me.btnPersonalverwaltung.Name = "btnPersonalverwaltung"
        Me.btnPersonalverwaltung.Size = New System.Drawing.Size(203, 60)
        Me.btnPersonalverwaltung.TabIndex = 75
        Me.btnPersonalverwaltung.Text = "Kenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Personalverwaltung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnPersonalverwaltung.UseVisualStyleBackColor = False
        '
        'Personal_tarifverträgeListBox
        '
        Me.Personal_tarifverträgeListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bewerber_personalBindingSource, "personal_tarifverträge", True))
        Me.Personal_tarifverträgeListBox.Enabled = False
        Me.Personal_tarifverträgeListBox.FormattingEnabled = True
        Me.Personal_tarifverträgeListBox.ItemHeight = 16
        Me.Personal_tarifverträgeListBox.Items.AddRange(New Object() {"Abfallwirtschaft", "Arbeitnehmerüberlassung", "AVR", "Baugewerbe", "Bekleidung", "Bergbau, Steine und Erden, Keramik", "Friseure", "Gaststätten, Beherbergung", "Gebäudereinigung", "Handel", "Holz", "Land- und Forstwirtschaft", "Leder und Schuhe", "Metall- und Elektrohandwerke", "Nahrung und Genuss (Fleischwirtschaft)", "Öffentlicher Dienst (BAT alt)", "Öffentlicher Dienst (TVöD)", "Pflege", "Publizistik", "Straßenverkehr", "Textil", "Wissenschaft"})
        Me.Personal_tarifverträgeListBox.Location = New System.Drawing.Point(936, 369)
        Me.Personal_tarifverträgeListBox.Name = "Personal_tarifverträgeListBox"
        Me.Personal_tarifverträgeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Personal_tarifverträgeListBox.Size = New System.Drawing.Size(280, 100)
        Me.Personal_tarifverträgeListBox.Sorted = True
        Me.Personal_tarifverträgeListBox.TabIndex = 18
        '
        'Label289
        '
        Me.Label289.AutoSize = True
        Me.Label289.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label289.ForeColor = System.Drawing.Color.Black
        Me.Label289.Location = New System.Drawing.Point(665, 366)
        Me.Label289.Name = "Label289"
        Me.Label289.Size = New System.Drawing.Size(253, 32)
        Me.Label289.TabIndex = 73
        Me.Label289.Text = "Mit welchen Tarifverträgen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "haben Sie Erfahrungen gesammelt?"
        '
        'Personal_sonstigesTextBox
        '
        Me.Personal_sonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_sonstiges", True))
        Me.Personal_sonstigesTextBox.Location = New System.Drawing.Point(222, 375)
        Me.Personal_sonstigesTextBox.Multiline = True
        Me.Personal_sonstigesTextBox.Name = "Personal_sonstigesTextBox"
        Me.Personal_sonstigesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Personal_sonstigesTextBox.Size = New System.Drawing.Size(280, 94)
        Me.Personal_sonstigesTextBox.TabIndex = 17
        '
        'Label186
        '
        Me.Label186.AutoSize = True
        Me.Label186.Location = New System.Drawing.Point(6, 375)
        Me.Label186.Name = "Label186"
        Me.Label186.Size = New System.Drawing.Size(210, 80)
        Me.Label186.TabIndex = 30
        Me.Label186.Text = "Welche anderen Tätigkeiten" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "haben Sie sonst noch " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "im Personalwesen ausgeübt?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(J" & _
    "ede Tätigkeit bitte in eine " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zeile schreiben)"
        '
        'Personal_ausbildungComboBox
        '
        Me.Personal_ausbildungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_ausbildung", True))
        Me.Personal_ausbildungComboBox.FormattingEnabled = True
        Me.Personal_ausbildungComboBox.Location = New System.Drawing.Point(1030, 141)
        Me.Personal_ausbildungComboBox.Name = "Personal_ausbildungComboBox"
        Me.Personal_ausbildungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_ausbildungComboBox.TabIndex = 9
        '
        'Personal_personalentwicklungComboBox
        '
        Me.Personal_personalentwicklungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_personalentwicklung", True))
        Me.Personal_personalentwicklungComboBox.FormattingEnabled = True
        Me.Personal_personalentwicklungComboBox.Location = New System.Drawing.Point(152, 238)
        Me.Personal_personalentwicklungComboBox.Name = "Personal_personalentwicklungComboBox"
        Me.Personal_personalentwicklungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_personalentwicklungComboBox.TabIndex = 13
        '
        'Personal_lohnsteuerComboBox
        '
        Me.Personal_lohnsteuerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_lohnsteuer", True))
        Me.Personal_lohnsteuerComboBox.FormattingEnabled = True
        Me.Personal_lohnsteuerComboBox.Location = New System.Drawing.Point(1030, 189)
        Me.Personal_lohnsteuerComboBox.Name = "Personal_lohnsteuerComboBox"
        Me.Personal_lohnsteuerComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_lohnsteuerComboBox.TabIndex = 12
        '
        'Personal_sozversrechtComboBox
        '
        Me.Personal_sozversrechtComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_sozversrecht", True))
        Me.Personal_sozversrechtComboBox.FormattingEnabled = True
        Me.Personal_sozversrechtComboBox.Location = New System.Drawing.Point(596, 189)
        Me.Personal_sozversrechtComboBox.Name = "Personal_sozversrechtComboBox"
        Me.Personal_sozversrechtComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_sozversrechtComboBox.TabIndex = 11
        '
        'Personal_arbeitsrechtComboBox
        '
        Me.Personal_arbeitsrechtComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_arbeitsrecht", True))
        Me.Personal_arbeitsrechtComboBox.FormattingEnabled = True
        Me.Personal_arbeitsrechtComboBox.Location = New System.Drawing.Point(152, 189)
        Me.Personal_arbeitsrechtComboBox.Name = "Personal_arbeitsrechtComboBox"
        Me.Personal_arbeitsrechtComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_arbeitsrechtComboBox.TabIndex = 10
        '
        'Personal_betriebsratComboBox
        '
        Me.Personal_betriebsratComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_betriebsrat", True))
        Me.Personal_betriebsratComboBox.FormattingEnabled = True
        Me.Personal_betriebsratComboBox.Location = New System.Drawing.Point(597, 141)
        Me.Personal_betriebsratComboBox.Name = "Personal_betriebsratComboBox"
        Me.Personal_betriebsratComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_betriebsratComboBox.TabIndex = 8
        '
        'Personal_bavComboBox
        '
        Me.Personal_bavComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_bav", True))
        Me.Personal_bavComboBox.FormattingEnabled = True
        Me.Personal_bavComboBox.Location = New System.Drawing.Point(1030, 84)
        Me.Personal_bavComboBox.Name = "Personal_bavComboBox"
        Me.Personal_bavComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_bavComboBox.TabIndex = 6
        '
        'Personal_melde_bescheinigungswesenComboBox
        '
        Me.Personal_melde_bescheinigungswesenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_melde_bescheinigungswesen", True))
        Me.Personal_melde_bescheinigungswesenComboBox.FormattingEnabled = True
        Me.Personal_melde_bescheinigungswesenComboBox.Location = New System.Drawing.Point(597, 238)
        Me.Personal_melde_bescheinigungswesenComboBox.Name = "Personal_melde_bescheinigungswesenComboBox"
        Me.Personal_melde_bescheinigungswesenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_melde_bescheinigungswesenComboBox.TabIndex = 14
        '
        'Personal_vertraegeComboBox
        '
        Me.Personal_vertraegeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_vertraege", True))
        Me.Personal_vertraegeComboBox.FormattingEnabled = True
        Me.Personal_vertraegeComboBox.Location = New System.Drawing.Point(597, 84)
        Me.Personal_vertraegeComboBox.Name = "Personal_vertraegeComboBox"
        Me.Personal_vertraegeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_vertraegeComboBox.TabIndex = 5
        '
        'Personal_sachbearbeitungComboBox
        '
        Me.Personal_sachbearbeitungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_sachbearbeitung", True))
        Me.Personal_sachbearbeitungComboBox.FormattingEnabled = True
        Me.Personal_sachbearbeitungComboBox.Location = New System.Drawing.Point(152, 84)
        Me.Personal_sachbearbeitungComboBox.Name = "Personal_sachbearbeitungComboBox"
        Me.Personal_sachbearbeitungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_sachbearbeitungComboBox.TabIndex = 4
        '
        'Personal_assessmentcenterComboBox
        '
        Me.Personal_assessmentcenterComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_assessmentcenter", True))
        Me.Personal_assessmentcenterComboBox.FormattingEnabled = True
        Me.Personal_assessmentcenterComboBox.Location = New System.Drawing.Point(1030, 26)
        Me.Personal_assessmentcenterComboBox.Name = "Personal_assessmentcenterComboBox"
        Me.Personal_assessmentcenterComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_assessmentcenterComboBox.TabIndex = 3
        '
        'Personal_bewerbungsgesprächeComboBox
        '
        Me.Personal_bewerbungsgesprächeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_bewerbungsgespräche", True))
        Me.Personal_bewerbungsgesprächeComboBox.FormattingEnabled = True
        Me.Personal_bewerbungsgesprächeComboBox.Location = New System.Drawing.Point(595, 26)
        Me.Personal_bewerbungsgesprächeComboBox.Name = "Personal_bewerbungsgesprächeComboBox"
        Me.Personal_bewerbungsgesprächeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_bewerbungsgesprächeComboBox.TabIndex = 2
        '
        'Personal_rekrutierungComboBox
        '
        Me.Personal_rekrutierungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_personalBindingSource, "personal_rekrutierung", True))
        Me.Personal_rekrutierungComboBox.FormattingEnabled = True
        Me.Personal_rekrutierungComboBox.Location = New System.Drawing.Point(152, 26)
        Me.Personal_rekrutierungComboBox.Name = "Personal_rekrutierungComboBox"
        Me.Personal_rekrutierungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Personal_rekrutierungComboBox.TabIndex = 1
        '
        'Bewerber_personalTableAdapter
        '
        Me.Bewerber_personalTableAdapter.ClearBeforeFill = True
        '
        'frmPersonalverwaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1248, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmPersonalverwaltung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Personalverwaltung"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Bewerber_personalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Personal_rekrutierungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_tarifverträgeListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label289 As System.Windows.Forms.Label
    Friend WithEvents Personal_sonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label186 As System.Windows.Forms.Label
    Friend WithEvents Personal_ausbildungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_personalentwicklungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_lohnsteuerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_sozversrechtComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_arbeitsrechtComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_betriebsratComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_bavComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_melde_bescheinigungswesenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_vertraegeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_sachbearbeitungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_assessmentcenterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Personal_bewerbungsgesprächeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnPersonalverwaltung As System.Windows.Forms.Button
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
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bewerber_personalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_personalTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_personalTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Personal_tarifvertrag_erfahrungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Personal_zeiterfassung_softwareTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Personal_zeiterfassungComboBox As System.Windows.Forms.ComboBox
End Class

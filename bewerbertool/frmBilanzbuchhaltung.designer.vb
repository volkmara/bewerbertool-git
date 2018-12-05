<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBilanzbuchhaltung
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
        Dim Controlling_soxxLabel As System.Windows.Forms.Label
        Dim Controlling_abschluesse_nlgaapLabel As System.Windows.Forms.Label
        Dim Controlling_abschluesse_ukgaapLabel As System.Windows.Forms.Label
        Dim Controlling_finanz_usgaapLabel As System.Windows.Forms.Label
        Dim Controlling_abschluesse_ifrsLabel As System.Windows.Forms.Label
        Dim Bibuha_bilanzbuchhalterLabel As System.Windows.Forms.Label
        Dim Bibuha_erfahrungLabel As System.Windows.Forms.Label
        Dim Bibuha_erfahrungLabel1 As System.Windows.Forms.Label
        Dim Controlling_abschluesse_hgbLabel As System.Windows.Forms.Label
        Dim Bibuha_konzernabschlussLabel As System.Windows.Forms.Label
        Dim Bibuha_sondernbilanzenLabel As System.Windows.Forms.Label
        Dim Bibuha_sondernbilanzen_welcheLabel As System.Windows.Forms.Label
        Dim Bibuha_abschreibungLabel As System.Windows.Forms.Label
        Dim Bibuha_wertberichtigungLabel As System.Windows.Forms.Label
        Dim Bibuha_bewertungLabel As System.Windows.Forms.Label
        Dim Bibuha_intercompanyabstimmungLabel As System.Windows.Forms.Label
        Dim Bibuha_softwareLabel As System.Windows.Forms.Label
        Dim Bibuha_sonstigesLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bibuha_sonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.Bew_bibuhaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bibuha_softwareListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Bibuha_intercompanyabstimmungComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_bewertungComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_wertberichtigungComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_abschreibungComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bibuha_sondernbilanzen_welcheTextBox = New System.Windows.Forms.TextBox()
        Me.Bibuha_sondernbilanzenComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_konzernabschlussComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_soxxComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_nlgaapComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_ukgaapComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_usgaapComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_ifrsComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_hgbComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bibuha_erfahrungComboBox = New System.Windows.Forms.ComboBox()
        Me.Bibuha_woListBox = New System.Windows.Forms.ListBox()
        Me.Bibuha_bilanzbuchhalterComboBox = New System.Windows.Forms.ComboBox()
        Me.Bew_bibuhaTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bew_bibuhaTableAdapter()
        Controlling_soxxLabel = New System.Windows.Forms.Label()
        Controlling_abschluesse_nlgaapLabel = New System.Windows.Forms.Label()
        Controlling_abschluesse_ukgaapLabel = New System.Windows.Forms.Label()
        Controlling_finanz_usgaapLabel = New System.Windows.Forms.Label()
        Controlling_abschluesse_ifrsLabel = New System.Windows.Forms.Label()
        Bibuha_bilanzbuchhalterLabel = New System.Windows.Forms.Label()
        Bibuha_erfahrungLabel = New System.Windows.Forms.Label()
        Bibuha_erfahrungLabel1 = New System.Windows.Forms.Label()
        Controlling_abschluesse_hgbLabel = New System.Windows.Forms.Label()
        Bibuha_konzernabschlussLabel = New System.Windows.Forms.Label()
        Bibuha_sondernbilanzenLabel = New System.Windows.Forms.Label()
        Bibuha_sondernbilanzen_welcheLabel = New System.Windows.Forms.Label()
        Bibuha_abschreibungLabel = New System.Windows.Forms.Label()
        Bibuha_wertberichtigungLabel = New System.Windows.Forms.Label()
        Bibuha_bewertungLabel = New System.Windows.Forms.Label()
        Bibuha_intercompanyabstimmungLabel = New System.Windows.Forms.Label()
        Bibuha_softwareLabel = New System.Windows.Forms.Label()
        Bibuha_sonstigesLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Bew_bibuhaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Controlling_soxxLabel
        '
        Controlling_soxxLabel.AutoSize = True
        Controlling_soxxLabel.Location = New System.Drawing.Point(327, 69)
        Controlling_soxxLabel.Name = "Controlling_soxxLabel"
        Controlling_soxxLabel.Size = New System.Drawing.Size(51, 16)
        Controlling_soxxLabel.TabIndex = 10
        Controlling_soxxLabel.Text = "SOXX:"
        '
        'Controlling_abschluesse_nlgaapLabel
        '
        Controlling_abschluesse_nlgaapLabel.AutoSize = True
        Controlling_abschluesse_nlgaapLabel.Location = New System.Drawing.Point(12, 69)
        Controlling_abschluesse_nlgaapLabel.Name = "Controlling_abschluesse_nlgaapLabel"
        Controlling_abschluesse_nlgaapLabel.Size = New System.Drawing.Size(117, 16)
        Controlling_abschluesse_nlgaapLabel.TabIndex = 8
        Controlling_abschluesse_nlgaapLabel.Text = "Nach NL-GAAP:"
        '
        'Controlling_abschluesse_ukgaapLabel
        '
        Controlling_abschluesse_ukgaapLabel.AutoSize = True
        Controlling_abschluesse_ukgaapLabel.Location = New System.Drawing.Point(962, 28)
        Controlling_abschluesse_ukgaapLabel.Name = "Controlling_abschluesse_ukgaapLabel"
        Controlling_abschluesse_ukgaapLabel.Size = New System.Drawing.Size(118, 16)
        Controlling_abschluesse_ukgaapLabel.TabIndex = 6
        Controlling_abschluesse_ukgaapLabel.Text = "Nach UK-GAAP:"
        '
        'Controlling_finanz_usgaapLabel
        '
        Controlling_finanz_usgaapLabel.AutoSize = True
        Controlling_finanz_usgaapLabel.Location = New System.Drawing.Point(630, 28)
        Controlling_finanz_usgaapLabel.Name = "Controlling_finanz_usgaapLabel"
        Controlling_finanz_usgaapLabel.Size = New System.Drawing.Size(119, 16)
        Controlling_finanz_usgaapLabel.TabIndex = 4
        Controlling_finanz_usgaapLabel.Text = "Nach US-GAAP:"
        '
        'Controlling_abschluesse_ifrsLabel
        '
        Controlling_abschluesse_ifrsLabel.AutoSize = True
        Controlling_abschluesse_ifrsLabel.Location = New System.Drawing.Point(327, 28)
        Controlling_abschluesse_ifrsLabel.Name = "Controlling_abschluesse_ifrsLabel"
        Controlling_abschluesse_ifrsLabel.Size = New System.Drawing.Size(86, 16)
        Controlling_abschluesse_ifrsLabel.TabIndex = 2
        Controlling_abschluesse_ifrsLabel.Text = "Nach IFRS:"
        '
        'Bibuha_bilanzbuchhalterLabel
        '
        Bibuha_bilanzbuchhalterLabel.AutoSize = True
        Bibuha_bilanzbuchhalterLabel.Location = New System.Drawing.Point(11, 29)
        Bibuha_bilanzbuchhalterLabel.Name = "Bibuha_bilanzbuchhalterLabel"
        Bibuha_bilanzbuchhalterLabel.Size = New System.Drawing.Size(227, 48)
        Bibuha_bilanzbuchhalterLabel.TabIndex = 0
        Bibuha_bilanzbuchhalterLabel.Text = "Haben Sie einen Abschluss als " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bilanzbuchhalter/in? Wenn ja," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wo abgelegt?"
        '
        'Bibuha_erfahrungLabel
        '
        Bibuha_erfahrungLabel.AutoSize = True
        Bibuha_erfahrungLabel.Location = New System.Drawing.Point(404, 29)
        Bibuha_erfahrungLabel.Name = "Bibuha_erfahrungLabel"
        Bibuha_erfahrungLabel.Size = New System.Drawing.Size(162, 48)
        Bibuha_erfahrungLabel.TabIndex = 2
        Bibuha_erfahrungLabel.Text = "Wie schätzen Sie Ihre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kenntnisse in der " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bilanzbuchhaltung ein:"
        '
        'Bibuha_erfahrungLabel1
        '
        Bibuha_erfahrungLabel1.AutoSize = True
        Bibuha_erfahrungLabel1.Location = New System.Drawing.Point(809, 29)
        Bibuha_erfahrungLabel1.Name = "Bibuha_erfahrungLabel1"
        Bibuha_erfahrungLabel1.Size = New System.Drawing.Size(259, 48)
        Bibuha_erfahrungLabel1.TabIndex = 4
        Bibuha_erfahrungLabel1.Text = "In welchen Unternehmen haben Sie " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in den letzten fünf Jahren" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in der Bilanzbuchh" & _
    "altung gearbeitet: "
        '
        'Controlling_abschluesse_hgbLabel
        '
        Controlling_abschluesse_hgbLabel.AutoSize = True
        Controlling_abschluesse_hgbLabel.Location = New System.Drawing.Point(11, 28)
        Controlling_abschluesse_hgbLabel.Name = "Controlling_abschluesse_hgbLabel"
        Controlling_abschluesse_hgbLabel.Size = New System.Drawing.Size(84, 16)
        Controlling_abschluesse_hgbLabel.TabIndex = 2
        Controlling_abschluesse_hgbLabel.Text = "Nach HGB:"
        '
        'Bibuha_konzernabschlussLabel
        '
        Bibuha_konzernabschlussLabel.AutoSize = True
        Bibuha_konzernabschlussLabel.Location = New System.Drawing.Point(615, 66)
        Bibuha_konzernabschlussLabel.Name = "Bibuha_konzernabschlussLabel"
        Bibuha_konzernabschlussLabel.Size = New System.Drawing.Size(137, 16)
        Bibuha_konzernabschlussLabel.TabIndex = 12
        Bibuha_konzernabschlussLabel.Text = "Konzernabschluss:"
        '
        'Bibuha_sondernbilanzenLabel
        '
        Bibuha_sondernbilanzenLabel.AutoSize = True
        Bibuha_sondernbilanzenLabel.Location = New System.Drawing.Point(960, 69)
        Bibuha_sondernbilanzenLabel.Name = "Bibuha_sondernbilanzenLabel"
        Bibuha_sondernbilanzenLabel.Size = New System.Drawing.Size(120, 16)
        Bibuha_sondernbilanzenLabel.TabIndex = 14
        Bibuha_sondernbilanzenLabel.Text = "Sonderbilanzen:"
        '
        'Bibuha_sondernbilanzen_welcheLabel
        '
        Bibuha_sondernbilanzen_welcheLabel.AutoSize = True
        Bibuha_sondernbilanzen_welcheLabel.Location = New System.Drawing.Point(12, 115)
        Bibuha_sondernbilanzen_welcheLabel.Name = "Bibuha_sondernbilanzen_welcheLabel"
        Bibuha_sondernbilanzen_welcheLabel.Size = New System.Drawing.Size(176, 16)
        Bibuha_sondernbilanzen_welcheLabel.TabIndex = 16
        Bibuha_sondernbilanzen_welcheLabel.Text = "Welche Sonderbilanzen:"
        '
        'Bibuha_abschreibungLabel
        '
        Bibuha_abschreibungLabel.AutoSize = True
        Bibuha_abschreibungLabel.Location = New System.Drawing.Point(11, 31)
        Bibuha_abschreibungLabel.Name = "Bibuha_abschreibungLabel"
        Bibuha_abschreibungLabel.Size = New System.Drawing.Size(124, 16)
        Bibuha_abschreibungLabel.TabIndex = 0
        Bibuha_abschreibungLabel.Text = "Abschreibungen:"
        '
        'Bibuha_wertberichtigungLabel
        '
        Bibuha_wertberichtigungLabel.AutoSize = True
        Bibuha_wertberichtigungLabel.Location = New System.Drawing.Point(455, 31)
        Bibuha_wertberichtigungLabel.Name = "Bibuha_wertberichtigungLabel"
        Bibuha_wertberichtigungLabel.Size = New System.Drawing.Size(146, 16)
        Bibuha_wertberichtigungLabel.TabIndex = 2
        Bibuha_wertberichtigungLabel.Text = "Wertberichtigungen:"
        '
        'Bibuha_bewertungLabel
        '
        Bibuha_bewertungLabel.AutoSize = True
        Bibuha_bewertungLabel.Location = New System.Drawing.Point(862, 17)
        Bibuha_bewertungLabel.Name = "Bibuha_bewertungLabel"
        Bibuha_bewertungLabel.Size = New System.Drawing.Size(200, 48)
        Bibuha_bewertungLabel.TabIndex = 4
        Bibuha_bewertungLabel.Text = "Bewertung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Anteile, Betriebsvermögen," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inventar, Lagerbestand):"
        '
        'Bibuha_intercompanyabstimmungLabel
        '
        Bibuha_intercompanyabstimmungLabel.AutoSize = True
        Bibuha_intercompanyabstimmungLabel.Location = New System.Drawing.Point(11, 85)
        Bibuha_intercompanyabstimmungLabel.Name = "Bibuha_intercompanyabstimmungLabel"
        Bibuha_intercompanyabstimmungLabel.Size = New System.Drawing.Size(188, 16)
        Bibuha_intercompanyabstimmungLabel.TabIndex = 6
        Bibuha_intercompanyabstimmungLabel.Text = "Intercompanyabstimmung:"
        '
        'Bibuha_softwareLabel
        '
        Bibuha_softwareLabel.AutoSize = True
        Bibuha_softwareLabel.Location = New System.Drawing.Point(11, 33)
        Bibuha_softwareLabel.Name = "Bibuha_softwareLabel"
        Bibuha_softwareLabel.Size = New System.Drawing.Size(182, 48)
        Bibuha_softwareLabel.TabIndex = 0
        Bibuha_softwareLabel.Text = "In den letzten fünf Jahren " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "für Bilanzbuchhaltung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "versendete Software:"
        '
        'Bibuha_sonstigesLabel
        '
        Bibuha_sonstigesLabel.AutoSize = True
        Bibuha_sonstigesLabel.Location = New System.Drawing.Point(383, 39)
        Bibuha_sonstigesLabel.Name = "Bibuha_sonstigesLabel"
        Bibuha_sonstigesLabel.Size = New System.Drawing.Size(81, 16)
        Bibuha_sonstigesLabel.TabIndex = 2
        Bibuha_sonstigesLabel.Text = "Sonstiges:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1291, 676)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1283, 27)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Bitte geben Sie Ihre Kenntnisse in der Bilanzbuchhaltung an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Bibuha_sonstigesLabel)
        Me.GroupBox4.Controls.Add(Me.Bibuha_sonstigesTextBox)
        Me.GroupBox4.Controls.Add(Bibuha_softwareLabel)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Bibuha_softwareListBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 523)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1283, 146)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sonstiges"
        '
        'Bibuha_sonstigesTextBox
        '
        Me.Bibuha_sonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_sonstiges", True))
        Me.Bibuha_sonstigesTextBox.Location = New System.Drawing.Point(487, 39)
        Me.Bibuha_sonstigesTextBox.Multiline = True
        Me.Bibuha_sonstigesTextBox.Name = "Bibuha_sonstigesTextBox"
        Me.Bibuha_sonstigesTextBox.Size = New System.Drawing.Size(305, 91)
        Me.Bibuha_sonstigesTextBox.TabIndex = 3
        '
        'Bew_bibuhaBindingSource
        '
        Me.Bew_bibuhaBindingSource.DataMember = "bew_bibuha"
        Me.Bew_bibuhaBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Wheat
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1021, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 60)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Kenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abschlüsse/Bilanzbuchhaltung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Bibuha_softwareListBox
        '
        Me.Bibuha_softwareListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bew_bibuhaBindingSource, "bibuha_software", True))
        Me.Bibuha_softwareListBox.FormattingEnabled = True
        Me.Bibuha_softwareListBox.ItemHeight = 16
        Me.Bibuha_softwareListBox.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Lexware", "KHK Sage", "AS 400", "Oracle", "andere"})
        Me.Bibuha_softwareListBox.Location = New System.Drawing.Point(199, 39)
        Me.Bibuha_softwareListBox.Name = "Bibuha_softwareListBox"
        Me.Bibuha_softwareListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Bibuha_softwareListBox.Size = New System.Drawing.Size(120, 84)
        Me.Bibuha_softwareListBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.Bibuha_intercompanyabstimmungComboBox)
        Me.GroupBox3.Controls.Add(Bibuha_intercompanyabstimmungLabel)
        Me.GroupBox3.Controls.Add(Bibuha_bewertungLabel)
        Me.GroupBox3.Controls.Add(Me.Bibuha_bewertungComboBox)
        Me.GroupBox3.Controls.Add(Bibuha_wertberichtigungLabel)
        Me.GroupBox3.Controls.Add(Me.Bibuha_wertberichtigungComboBox)
        Me.GroupBox3.Controls.Add(Bibuha_abschreibungLabel)
        Me.GroupBox3.Controls.Add(Me.Bibuha_abschreibungComboBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 392)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1281, 125)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sonstige Bilanzierungsvorgänge:"
        '
        'Bibuha_intercompanyabstimmungComboBox
        '
        Me.Bibuha_intercompanyabstimmungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_intercompanyabstimmung", True))
        Me.Bibuha_intercompanyabstimmungComboBox.FormattingEnabled = True
        Me.Bibuha_intercompanyabstimmungComboBox.Location = New System.Drawing.Point(226, 82)
        Me.Bibuha_intercompanyabstimmungComboBox.Name = "Bibuha_intercompanyabstimmungComboBox"
        Me.Bibuha_intercompanyabstimmungComboBox.Size = New System.Drawing.Size(176, 24)
        Me.Bibuha_intercompanyabstimmungComboBox.TabIndex = 8
        '
        'Bibuha_bewertungComboBox
        '
        Me.Bibuha_bewertungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_bewertung", True))
        Me.Bibuha_bewertungComboBox.FormattingEnabled = True
        Me.Bibuha_bewertungComboBox.Location = New System.Drawing.Point(1082, 28)
        Me.Bibuha_bewertungComboBox.Name = "Bibuha_bewertungComboBox"
        Me.Bibuha_bewertungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_bewertungComboBox.TabIndex = 5
        '
        'Bibuha_wertberichtigungComboBox
        '
        Me.Bibuha_wertberichtigungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_wertberichtigung", True))
        Me.Bibuha_wertberichtigungComboBox.FormattingEnabled = True
        Me.Bibuha_wertberichtigungComboBox.Location = New System.Drawing.Point(617, 28)
        Me.Bibuha_wertberichtigungComboBox.Name = "Bibuha_wertberichtigungComboBox"
        Me.Bibuha_wertberichtigungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_wertberichtigungComboBox.TabIndex = 3
        '
        'Bibuha_abschreibungComboBox
        '
        Me.Bibuha_abschreibungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_abschreibung", True))
        Me.Bibuha_abschreibungComboBox.FormattingEnabled = True
        Me.Bibuha_abschreibungComboBox.Location = New System.Drawing.Point(226, 28)
        Me.Bibuha_abschreibungComboBox.Name = "Bibuha_abschreibungComboBox"
        Me.Bibuha_abschreibungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_abschreibungComboBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Bibuha_sondernbilanzen_welcheLabel)
        Me.GroupBox2.Controls.Add(Me.Bibuha_sondernbilanzen_welcheTextBox)
        Me.GroupBox2.Controls.Add(Bibuha_sondernbilanzenLabel)
        Me.GroupBox2.Controls.Add(Me.Bibuha_sondernbilanzenComboBox)
        Me.GroupBox2.Controls.Add(Bibuha_konzernabschlussLabel)
        Me.GroupBox2.Controls.Add(Me.Bibuha_konzernabschlussComboBox)
        Me.GroupBox2.Controls.Add(Me.Bibuha_soxxComboBox)
        Me.GroupBox2.Controls.Add(Controlling_soxxLabel)
        Me.GroupBox2.Controls.Add(Me.Bibuha_nlgaapComboBox)
        Me.GroupBox2.Controls.Add(Me.Bibuha_ukgaapComboBox)
        Me.GroupBox2.Controls.Add(Me.Bibuha_usgaapComboBox)
        Me.GroupBox2.Controls.Add(Controlling_abschluesse_nlgaapLabel)
        Me.GroupBox2.Controls.Add(Me.Bibuha_ifrsComboBox)
        Me.GroupBox2.Controls.Add(Me.Bibuha_hgbComboBox)
        Me.GroupBox2.Controls.Add(Controlling_abschluesse_hgbLabel)
        Me.GroupBox2.Controls.Add(Controlling_abschluesse_ukgaapLabel)
        Me.GroupBox2.Controls.Add(Controlling_abschluesse_ifrsLabel)
        Me.GroupBox2.Controls.Add(Controlling_finanz_usgaapLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1282, 216)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Abschlüsse und Bilanzen:"
        '
        'Bibuha_sondernbilanzen_welcheTextBox
        '
        Me.Bibuha_sondernbilanzen_welcheTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_sondernbilanzen_welche", True))
        Me.Bibuha_sondernbilanzen_welcheTextBox.Enabled = False
        Me.Bibuha_sondernbilanzen_welcheTextBox.Location = New System.Drawing.Point(192, 115)
        Me.Bibuha_sondernbilanzen_welcheTextBox.Multiline = True
        Me.Bibuha_sondernbilanzen_welcheTextBox.Name = "Bibuha_sondernbilanzen_welcheTextBox"
        Me.Bibuha_sondernbilanzen_welcheTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Bibuha_sondernbilanzen_welcheTextBox.Size = New System.Drawing.Size(294, 82)
        Me.Bibuha_sondernbilanzen_welcheTextBox.TabIndex = 17
        '
        'Bibuha_sondernbilanzenComboBox
        '
        Me.Bibuha_sondernbilanzenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_sondernbilanzen", True))
        Me.Bibuha_sondernbilanzenComboBox.FormattingEnabled = True
        Me.Bibuha_sondernbilanzenComboBox.Location = New System.Drawing.Point(1083, 66)
        Me.Bibuha_sondernbilanzenComboBox.Name = "Bibuha_sondernbilanzenComboBox"
        Me.Bibuha_sondernbilanzenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_sondernbilanzenComboBox.TabIndex = 15
        '
        'Bibuha_konzernabschlussComboBox
        '
        Me.Bibuha_konzernabschlussComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_konzernabschluss", True))
        Me.Bibuha_konzernabschlussComboBox.FormattingEnabled = True
        Me.Bibuha_konzernabschlussComboBox.Location = New System.Drawing.Point(755, 66)
        Me.Bibuha_konzernabschlussComboBox.Name = "Bibuha_konzernabschlussComboBox"
        Me.Bibuha_konzernabschlussComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_konzernabschlussComboBox.TabIndex = 13
        '
        'Bibuha_soxxComboBox
        '
        Me.Bibuha_soxxComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_soxx", True))
        Me.Bibuha_soxxComboBox.FormattingEnabled = True
        Me.Bibuha_soxxComboBox.Location = New System.Drawing.Point(419, 66)
        Me.Bibuha_soxxComboBox.Name = "Bibuha_soxxComboBox"
        Me.Bibuha_soxxComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_soxxComboBox.TabIndex = 12
        '
        'Bibuha_nlgaapComboBox
        '
        Me.Bibuha_nlgaapComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_nlgaap", True))
        Me.Bibuha_nlgaapComboBox.FormattingEnabled = True
        Me.Bibuha_nlgaapComboBox.Location = New System.Drawing.Point(135, 66)
        Me.Bibuha_nlgaapComboBox.Name = "Bibuha_nlgaapComboBox"
        Me.Bibuha_nlgaapComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_nlgaapComboBox.TabIndex = 10
        '
        'Bibuha_ukgaapComboBox
        '
        Me.Bibuha_ukgaapComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_ukgaap", True))
        Me.Bibuha_ukgaapComboBox.FormattingEnabled = True
        Me.Bibuha_ukgaapComboBox.Location = New System.Drawing.Point(1083, 25)
        Me.Bibuha_ukgaapComboBox.Name = "Bibuha_ukgaapComboBox"
        Me.Bibuha_ukgaapComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_ukgaapComboBox.TabIndex = 8
        '
        'Bibuha_usgaapComboBox
        '
        Me.Bibuha_usgaapComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_usgaap", True))
        Me.Bibuha_usgaapComboBox.FormattingEnabled = True
        Me.Bibuha_usgaapComboBox.Location = New System.Drawing.Point(755, 25)
        Me.Bibuha_usgaapComboBox.Name = "Bibuha_usgaapComboBox"
        Me.Bibuha_usgaapComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_usgaapComboBox.TabIndex = 6
        '
        'Bibuha_ifrsComboBox
        '
        Me.Bibuha_ifrsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_ifrs", True))
        Me.Bibuha_ifrsComboBox.FormattingEnabled = True
        Me.Bibuha_ifrsComboBox.Location = New System.Drawing.Point(419, 25)
        Me.Bibuha_ifrsComboBox.Name = "Bibuha_ifrsComboBox"
        Me.Bibuha_ifrsComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_ifrsComboBox.TabIndex = 4
        '
        'Bibuha_hgbComboBox
        '
        Me.Bibuha_hgbComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_hgb", True))
        Me.Bibuha_hgbComboBox.FormattingEnabled = True
        Me.Bibuha_hgbComboBox.Location = New System.Drawing.Point(135, 25)
        Me.Bibuha_hgbComboBox.Name = "Bibuha_hgbComboBox"
        Me.Bibuha_hgbComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_hgbComboBox.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Bibuha_erfahrungComboBox)
        Me.GroupBox1.Controls.Add(Me.Bibuha_woListBox)
        Me.GroupBox1.Controls.Add(Bibuha_erfahrungLabel1)
        Me.GroupBox1.Controls.Add(Bibuha_erfahrungLabel)
        Me.GroupBox1.Controls.Add(Me.Bibuha_bilanzbuchhalterComboBox)
        Me.GroupBox1.Controls.Add(Bibuha_bilanzbuchhalterLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1282, 134)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Erfahrung"
        '
        'Bibuha_erfahrungComboBox
        '
        Me.Bibuha_erfahrungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_erfahrung", True))
        Me.Bibuha_erfahrungComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bibuha_erfahrungComboBox.FormattingEnabled = True
        Me.Bibuha_erfahrungComboBox.Items.AddRange(New Object() {"0 - keine Kenntnisse", "1 - immer angewendet", "2 - häufig", "3 - gelegentlich", "4  - Grundkenntnisse"})
        Me.Bibuha_erfahrungComboBox.Location = New System.Drawing.Point(564, 29)
        Me.Bibuha_erfahrungComboBox.Name = "Bibuha_erfahrungComboBox"
        Me.Bibuha_erfahrungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Bibuha_erfahrungComboBox.TabIndex = 7
        '
        'Bibuha_woListBox
        '
        Me.Bibuha_woListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bew_bibuhaBindingSource, "bibuha_wo", True))
        Me.Bibuha_woListBox.FormattingEnabled = True
        Me.Bibuha_woListBox.ItemHeight = 16
        Me.Bibuha_woListBox.Items.AddRange(New Object() {"Einzelunternehmen", "OHG, KG", "GmbH", "GmbH & Co. KG", "AG, KGaA", "Stiftung", "Öffentlicher Dienst"})
        Me.Bibuha_woListBox.Location = New System.Drawing.Point(1083, 21)
        Me.Bibuha_woListBox.Name = "Bibuha_woListBox"
        Me.Bibuha_woListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Bibuha_woListBox.Size = New System.Drawing.Size(183, 84)
        Me.Bibuha_woListBox.TabIndex = 6
        '
        'Bibuha_bilanzbuchhalterComboBox
        '
        Me.Bibuha_bilanzbuchhalterComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_bibuhaBindingSource, "bibuha_bilanzbuchhalter", True))
        Me.Bibuha_bilanzbuchhalterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Bibuha_bilanzbuchhalterComboBox.FormattingEnabled = True
        Me.Bibuha_bilanzbuchhalterComboBox.Items.AddRange(New Object() {"Nein", "IHK", "Endriss", "Andere"})
        Me.Bibuha_bilanzbuchhalterComboBox.Location = New System.Drawing.Point(239, 29)
        Me.Bibuha_bilanzbuchhalterComboBox.Name = "Bibuha_bilanzbuchhalterComboBox"
        Me.Bibuha_bilanzbuchhalterComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Bibuha_bilanzbuchhalterComboBox.TabIndex = 2
        '
        'Bew_bibuhaTableAdapter
        '
        Me.Bew_bibuhaTableAdapter.ClearBeforeFill = True
        '
        'frmBilanzbuchhaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1297, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmBilanzbuchhaltung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bilanzbuchhaltung"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Bew_bibuhaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Bibuha_bilanzbuchhalterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bibuha_woListBox As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Bibuha_hgbComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bibuha_sondernbilanzen_welcheTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bibuha_sondernbilanzenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bibuha_konzernabschlussComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bibuha_soxxComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bibuha_nlgaapComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bibuha_ukgaapComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bibuha_usgaapComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bibuha_ifrsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Bibuha_bewertungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bibuha_wertberichtigungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Bibuha_abschreibungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Bibuha_sonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bibuha_softwareListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Bibuha_erfahrungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bew_bibuhaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bew_bibuhaTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bew_bibuhaTableAdapter
    Friend WithEvents Bibuha_intercompanyabstimmungComboBox As System.Windows.Forms.ComboBox
End Class

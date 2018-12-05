<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLuG
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
        Dim Lug_abrechnungLabel As System.Windows.Forms.Label
        Dim Bibuha_erfahrungLabel1 As System.Windows.Forms.Label
        Dim Lug_abrechnung_anzahlLabel As System.Windows.Forms.Label
        Dim Lug_abrechnung_tarifvertragLabel As System.Windows.Forms.Label
        Dim Lug_abrechnung_tarifvertrag_welcheLabel As System.Windows.Forms.Label
        Dim Lug_abrechnung_softwareLabel As System.Windows.Forms.Label
        Dim Lug_abrechnung_baulohnLabel As System.Windows.Forms.Label
        Dim Lug_abrechnung_sonstigesLabel As System.Windows.Forms.Label
        Dim Lug_buchhaltungLabel As System.Windows.Forms.Label
        Dim Lug_buchhaltung_woLabel As System.Windows.Forms.Label
        Dim Lug_buchhaltung_anzahlLabel As System.Windows.Forms.Label
        Dim Lug_buchhaltung_softwareLabel As System.Windows.Forms.Label
        Dim Lug_buchhaltung_sonstigesLabel As System.Windows.Forms.Label
        Dim Lug_abrechnung_minijobLabel As System.Windows.Forms.Label
        Dim Lug_abrechnung_provisionLabel As System.Windows.Forms.Label
        Dim Lug_abrechnung_reisekostenLabel As System.Windows.Forms.Label
        Dim Lug_buchhaltung_minijobLabel As System.Windows.Forms.Label
        Dim Lug_buchhaltung_provisionLabel As System.Windows.Forms.Label
        Dim Lug_buchhaltung_reisekostenLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lug_buchhaltung_reisekostenComboBox = New System.Windows.Forms.ComboBox()
        Me.Bew_lugBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Lug_buchhaltung_provisionComboBox = New System.Windows.Forms.ComboBox()
        Me.Lug_buchhaltung_minijobComboBox = New System.Windows.Forms.ComboBox()
        Me.btnLuG = New System.Windows.Forms.Button()
        Me.Lug_buchhaltung_sonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.Lug_buchhaltung_softwareListBox = New System.Windows.Forms.ListBox()
        Me.Lug_buchhaltung_woListBox = New System.Windows.Forms.ListBox()
        Me.Lug_buchhaltungComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lug_abrechnung_reisekostenComboBox = New System.Windows.Forms.ComboBox()
        Me.Lug_abrechnung_provisionComboBox = New System.Windows.Forms.ComboBox()
        Me.Lug_abrechnung_minijobComboBox = New System.Windows.Forms.ComboBox()
        Me.Lug_abrechnung_sonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.Lug_abrechnung_baulohnComboBox = New System.Windows.Forms.ComboBox()
        Me.Lug_abrechnung_softwareListBox = New System.Windows.Forms.ListBox()
        Me.Lug_abrechnung_tarifvertrag_welcheTextBox = New System.Windows.Forms.TextBox()
        Me.Lug_abrechnung_tarifvertragComboBox = New System.Windows.Forms.ComboBox()
        Me.Lug_abrechnung_woListBox = New System.Windows.Forms.ListBox()
        Me.Lug_abrechnungComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lug_abrechnung_anzahlComboBox = New System.Windows.Forms.ComboBox()
        Me.Lug_buchhaltung_anzahlComboBox = New System.Windows.Forms.ComboBox()
        Me.Bew_lugTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bew_lugTableAdapter()
        Lug_abrechnungLabel = New System.Windows.Forms.Label()
        Bibuha_erfahrungLabel1 = New System.Windows.Forms.Label()
        Lug_abrechnung_anzahlLabel = New System.Windows.Forms.Label()
        Lug_abrechnung_tarifvertragLabel = New System.Windows.Forms.Label()
        Lug_abrechnung_tarifvertrag_welcheLabel = New System.Windows.Forms.Label()
        Lug_abrechnung_softwareLabel = New System.Windows.Forms.Label()
        Lug_abrechnung_baulohnLabel = New System.Windows.Forms.Label()
        Lug_abrechnung_sonstigesLabel = New System.Windows.Forms.Label()
        Lug_buchhaltungLabel = New System.Windows.Forms.Label()
        Lug_buchhaltung_woLabel = New System.Windows.Forms.Label()
        Lug_buchhaltung_anzahlLabel = New System.Windows.Forms.Label()
        Lug_buchhaltung_softwareLabel = New System.Windows.Forms.Label()
        Lug_buchhaltung_sonstigesLabel = New System.Windows.Forms.Label()
        Lug_abrechnung_minijobLabel = New System.Windows.Forms.Label()
        Lug_abrechnung_provisionLabel = New System.Windows.Forms.Label()
        Lug_abrechnung_reisekostenLabel = New System.Windows.Forms.Label()
        Lug_buchhaltung_minijobLabel = New System.Windows.Forms.Label()
        Lug_buchhaltung_provisionLabel = New System.Windows.Forms.Label()
        Lug_buchhaltung_reisekostenLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Bew_lugBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lug_abrechnungLabel
        '
        Lug_abrechnungLabel.AutoSize = True
        Lug_abrechnungLabel.Location = New System.Drawing.Point(6, 24)
        Lug_abrechnungLabel.Name = "Lug_abrechnungLabel"
        Lug_abrechnungLabel.Size = New System.Drawing.Size(256, 48)
        Lug_abrechnungLabel.TabIndex = 0
        Lug_abrechnungLabel.Text = "Wie schätzen Sie Ihre Kenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in der Lohn- und Gehaltsabrechnung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ein?"
        '
        'Bibuha_erfahrungLabel1
        '
        Bibuha_erfahrungLabel1.AutoSize = True
        Bibuha_erfahrungLabel1.Location = New System.Drawing.Point(631, 27)
        Bibuha_erfahrungLabel1.Name = "Bibuha_erfahrungLabel1"
        Bibuha_erfahrungLabel1.Size = New System.Drawing.Size(348, 48)
        Bibuha_erfahrungLabel1.TabIndex = 5
        Bibuha_erfahrungLabel1.Text = "In welchen Unternehmen haben Sie in den letzten " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fünf Jahren in der Lohn- und Ge" & _
    "haltsabrechnung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "gearbeitet: "
        '
        'Lug_abrechnung_anzahlLabel
        '
        Lug_abrechnung_anzahlLabel.AutoSize = True
        Lug_abrechnung_anzahlLabel.Location = New System.Drawing.Point(15, 30)
        Lug_abrechnung_anzahlLabel.Name = "Lug_abrechnung_anzahlLabel"
        Lug_abrechnung_anzahlLabel.Size = New System.Drawing.Size(323, 32)
        Lug_abrechnung_anzahlLabel.TabIndex = 5
        Lug_abrechnung_anzahlLabel.Text = "Für wieviele Mitarbeiter/innen haben Sie die " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lohn- und Gehaltsabrechnung vorgen" & _
    "ommen?"
        '
        'Lug_abrechnung_tarifvertragLabel
        '
        Lug_abrechnung_tarifvertragLabel.AutoSize = True
        Lug_abrechnung_tarifvertragLabel.Location = New System.Drawing.Point(6, 94)
        Lug_abrechnung_tarifvertragLabel.Name = "Lug_abrechnung_tarifvertragLabel"
        Lug_abrechnung_tarifvertragLabel.Size = New System.Drawing.Size(226, 32)
        Lug_abrechnung_tarifvertragLabel.TabIndex = 6
        Lug_abrechnung_tarifvertragLabel.Text = "Haben Sie Erfahrung in der " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anwendung von Tarifverträgen?"
        '
        'Lug_abrechnung_tarifvertrag_welcheLabel
        '
        Lug_abrechnung_tarifvertrag_welcheLabel.AutoSize = True
        Lug_abrechnung_tarifvertrag_welcheLabel.Location = New System.Drawing.Point(631, 141)
        Lug_abrechnung_tarifvertrag_welcheLabel.Name = "Lug_abrechnung_tarifvertrag_welcheLabel"
        Lug_abrechnung_tarifvertrag_welcheLabel.Size = New System.Drawing.Size(343, 16)
        Lug_abrechnung_tarifvertrag_welcheLabel.TabIndex = 8
        Lug_abrechnung_tarifvertrag_welcheLabel.Text = "Mit welchen Tarifverträgen haben Sie gearbeitet:"
        '
        'Lug_abrechnung_softwareLabel
        '
        Lug_abrechnung_softwareLabel.AutoSize = True
        Lug_abrechnung_softwareLabel.Location = New System.Drawing.Point(631, 212)
        Lug_abrechnung_softwareLabel.Name = "Lug_abrechnung_softwareLabel"
        Lug_abrechnung_softwareLabel.Size = New System.Drawing.Size(212, 48)
        Lug_abrechnung_softwareLabel.TabIndex = 10
        Lug_abrechnung_softwareLabel.Text = "Welche Abrechnungssoftware" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "haben Sie in den letzten " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fünf Jahren beruflich genu" & _
    "tzt?"
        '
        'Lug_abrechnung_baulohnLabel
        '
        Lug_abrechnung_baulohnLabel.AutoSize = True
        Lug_abrechnung_baulohnLabel.Location = New System.Drawing.Point(6, 146)
        Lug_abrechnung_baulohnLabel.Name = "Lug_abrechnung_baulohnLabel"
        Lug_abrechnung_baulohnLabel.Size = New System.Drawing.Size(204, 32)
        Lug_abrechnung_baulohnLabel.TabIndex = 12
        Lug_abrechnung_baulohnLabel.Text = "Haben Sie Erfahrung in der " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abrechnung von Baulöhnen?"
        '
        'Lug_abrechnung_sonstigesLabel
        '
        Lug_abrechnung_sonstigesLabel.AutoSize = True
        Lug_abrechnung_sonstigesLabel.Location = New System.Drawing.Point(6, 333)
        Lug_abrechnung_sonstigesLabel.Name = "Lug_abrechnung_sonstigesLabel"
        Lug_abrechnung_sonstigesLabel.Size = New System.Drawing.Size(217, 32)
        Lug_abrechnung_sonstigesLabel.TabIndex = 14
        Lug_abrechnung_sonstigesLabel.Text = "Sonstige Kenntnisse in der " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lohn- und Gehaltsabrechnung:"
        '
        'Lug_buchhaltungLabel
        '
        Lug_buchhaltungLabel.AutoSize = True
        Lug_buchhaltungLabel.Location = New System.Drawing.Point(16, 26)
        Lug_buchhaltungLabel.Name = "Lug_buchhaltungLabel"
        Lug_buchhaltungLabel.Size = New System.Drawing.Size(250, 48)
        Lug_buchhaltungLabel.TabIndex = 0
        Lug_buchhaltungLabel.Text = "Wie schätzen Sie Ihre Kenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in der Lohn- und Gehaltbuchhaltung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ein?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lug_buchhaltung_woLabel
        '
        Lug_buchhaltung_woLabel.AutoSize = True
        Lug_buchhaltung_woLabel.Location = New System.Drawing.Point(475, 26)
        Lug_buchhaltung_woLabel.Name = "Lug_buchhaltung_woLabel"
        Lug_buchhaltung_woLabel.Size = New System.Drawing.Size(179, 80)
        Lug_buchhaltung_woLabel.TabIndex = 2
        Lug_buchhaltung_woLabel.Text = "In welchen Unternehmen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "haben Sie in den letzten " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fünf Jahren in der " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lohn- un" & _
    "d Gehalts-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abrechnung gearbeitet: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lug_buchhaltung_anzahlLabel
        '
        Lug_buchhaltung_anzahlLabel.AutoSize = True
        Lug_buchhaltung_anzahlLabel.Location = New System.Drawing.Point(631, 22)
        Lug_buchhaltung_anzahlLabel.Name = "Lug_buchhaltung_anzahlLabel"
        Lug_buchhaltung_anzahlLabel.Size = New System.Drawing.Size(386, 32)
        Lug_buchhaltung_anzahlLabel.TabIndex = 4
        Lug_buchhaltung_anzahlLabel.Text = "Für wieviele Mitarbeiter/innen haben Sie die Lohn- und " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gehaltsbuchhaltung  vorg" & _
    "enommen?:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lug_buchhaltung_softwareLabel
        '
        Lug_buchhaltung_softwareLabel.AutoSize = True
        Lug_buchhaltung_softwareLabel.Location = New System.Drawing.Point(16, 136)
        Lug_buchhaltung_softwareLabel.Name = "Lug_buchhaltung_softwareLabel"
        Lug_buchhaltung_softwareLabel.Size = New System.Drawing.Size(214, 48)
        Lug_buchhaltung_softwareLabel.TabIndex = 6
        Lug_buchhaltung_softwareLabel.Text = "Welche Buchhaltungssoftware" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "haben Sie in den letzten " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fünf Jahren beruflich gen" & _
    "utzt?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lug_buchhaltung_sonstigesLabel
        '
        Lug_buchhaltung_sonstigesLabel.AutoSize = True
        Lug_buchhaltung_sonstigesLabel.Location = New System.Drawing.Point(475, 136)
        Lug_buchhaltung_sonstigesLabel.Name = "Lug_buchhaltung_sonstigesLabel"
        Lug_buchhaltung_sonstigesLabel.Size = New System.Drawing.Size(152, 48)
        Lug_buchhaltung_sonstigesLabel.TabIndex = 8
        Lug_buchhaltung_sonstigesLabel.Text = "Sonstige Kenntnisse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in der Lohn- und " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gehaltsabrechnung:"
        '
        'Lug_abrechnung_minijobLabel
        '
        Lug_abrechnung_minijobLabel.AutoSize = True
        Lug_abrechnung_minijobLabel.Location = New System.Drawing.Point(6, 199)
        Lug_abrechnung_minijobLabel.Name = "Lug_abrechnung_minijobLabel"
        Lug_abrechnung_minijobLabel.Size = New System.Drawing.Size(186, 32)
        Lug_abrechnung_minijobLabel.TabIndex = 16
        Lug_abrechnung_minijobLabel.Text = "Abrechnung geringfügiger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beschäftigung (Minijob):"
        '
        'Lug_abrechnung_provisionLabel
        '
        Lug_abrechnung_provisionLabel.AutoSize = True
        Lug_abrechnung_provisionLabel.Location = New System.Drawing.Point(6, 250)
        Lug_abrechnung_provisionLabel.Name = "Lug_abrechnung_provisionLabel"
        Lug_abrechnung_provisionLabel.Size = New System.Drawing.Size(166, 16)
        Lug_abrechnung_provisionLabel.TabIndex = 18
        Lug_abrechnung_provisionLabel.Text = "Provisionsabrechnung:"
        '
        'Lug_abrechnung_reisekostenLabel
        '
        Lug_abrechnung_reisekostenLabel.AutoSize = True
        Lug_abrechnung_reisekostenLabel.Location = New System.Drawing.Point(6, 294)
        Lug_abrechnung_reisekostenLabel.Name = "Lug_abrechnung_reisekostenLabel"
        Lug_abrechnung_reisekostenLabel.Size = New System.Drawing.Size(180, 16)
        Lug_abrechnung_reisekostenLabel.TabIndex = 20
        Lug_abrechnung_reisekostenLabel.Text = "Reisekostenabrechnung:"
        '
        'Lug_buchhaltung_minijobLabel
        '
        Lug_buchhaltung_minijobLabel.AutoSize = True
        Lug_buchhaltung_minijobLabel.Location = New System.Drawing.Point(16, 269)
        Lug_buchhaltung_minijobLabel.Name = "Lug_buchhaltung_minijobLabel"
        Lug_buchhaltung_minijobLabel.Size = New System.Drawing.Size(183, 32)
        Lug_buchhaltung_minijobLabel.TabIndex = 27
        Lug_buchhaltung_minijobLabel.Text = "Buchhaltung geringfügige" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beschäftigung (Minijob):"
        '
        'Lug_buchhaltung_provisionLabel
        '
        Lug_buchhaltung_provisionLabel.AutoSize = True
        Lug_buchhaltung_provisionLabel.Location = New System.Drawing.Point(16, 316)
        Lug_buchhaltung_provisionLabel.Name = "Lug_buchhaltung_provisionLabel"
        Lug_buchhaltung_provisionLabel.Size = New System.Drawing.Size(168, 16)
        Lug_buchhaltung_provisionLabel.TabIndex = 28
        Lug_buchhaltung_provisionLabel.Text = "Provisionsbuchhaltung:"
        '
        'Lug_buchhaltung_reisekostenLabel
        '
        Lug_buchhaltung_reisekostenLabel.AutoSize = True
        Lug_buchhaltung_reisekostenLabel.Location = New System.Drawing.Point(16, 361)
        Lug_buchhaltung_reisekostenLabel.Name = "Lug_buchhaltung_reisekostenLabel"
        Lug_buchhaltung_reisekostenLabel.Size = New System.Drawing.Size(182, 16)
        Lug_buchhaltung_reisekostenLabel.TabIndex = 29
        Lug_buchhaltung_reisekostenLabel.Text = "Reisekostenbuchhaltung:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 954)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1273, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte in der Lohn- und Gehaltsabrechnung bzw. -buchha" & _
    "ltung an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Lug_buchhaltung_reisekostenLabel)
        Me.GroupBox2.Controls.Add(Me.Lug_buchhaltung_reisekostenComboBox)
        Me.GroupBox2.Controls.Add(Lug_buchhaltung_provisionLabel)
        Me.GroupBox2.Controls.Add(Me.Lug_buchhaltung_provisionComboBox)
        Me.GroupBox2.Controls.Add(Lug_buchhaltung_minijobLabel)
        Me.GroupBox2.Controls.Add(Me.Lug_buchhaltung_minijobComboBox)
        Me.GroupBox2.Controls.Add(Lug_buchhaltung_sonstigesLabel)
        Me.GroupBox2.Controls.Add(Me.btnLuG)
        Me.GroupBox2.Controls.Add(Me.Lug_buchhaltung_sonstigesTextBox)
        Me.GroupBox2.Controls.Add(Lug_buchhaltung_softwareLabel)
        Me.GroupBox2.Controls.Add(Me.Lug_buchhaltung_softwareListBox)
        Me.GroupBox2.Controls.Add(Lug_buchhaltung_woLabel)
        Me.GroupBox2.Controls.Add(Me.Lug_buchhaltung_woListBox)
        Me.GroupBox2.Controls.Add(Lug_buchhaltungLabel)
        Me.GroupBox2.Controls.Add(Me.Lug_buchhaltungComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 600)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1273, 460)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lohn- und Gehaltsbuchhaltung"
        '
        'Lug_buchhaltung_reisekostenComboBox
        '
        Me.Lug_buchhaltung_reisekostenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_buchhaltung_reisekosten", True))
        Me.Lug_buchhaltung_reisekostenComboBox.FormattingEnabled = True
        Me.Lug_buchhaltung_reisekostenComboBox.Location = New System.Drawing.Point(264, 358)
        Me.Lug_buchhaltung_reisekostenComboBox.Name = "Lug_buchhaltung_reisekostenComboBox"
        Me.Lug_buchhaltung_reisekostenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Lug_buchhaltung_reisekostenComboBox.TabIndex = 30
        '
        'Bew_lugBindingSource
        '
        Me.Bew_lugBindingSource.DataMember = "bew_lug"
        Me.Bew_lugBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lug_buchhaltung_provisionComboBox
        '
        Me.Lug_buchhaltung_provisionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_buchhaltung_provision", True))
        Me.Lug_buchhaltung_provisionComboBox.FormattingEnabled = True
        Me.Lug_buchhaltung_provisionComboBox.Location = New System.Drawing.Point(264, 313)
        Me.Lug_buchhaltung_provisionComboBox.Name = "Lug_buchhaltung_provisionComboBox"
        Me.Lug_buchhaltung_provisionComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Lug_buchhaltung_provisionComboBox.TabIndex = 7
        '
        'Lug_buchhaltung_minijobComboBox
        '
        Me.Lug_buchhaltung_minijobComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_buchhaltung_minijob", True))
        Me.Lug_buchhaltung_minijobComboBox.FormattingEnabled = True
        Me.Lug_buchhaltung_minijobComboBox.Location = New System.Drawing.Point(264, 269)
        Me.Lug_buchhaltung_minijobComboBox.Name = "Lug_buchhaltung_minijobComboBox"
        Me.Lug_buchhaltung_minijobComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Lug_buchhaltung_minijobComboBox.TabIndex = 6
        '
        'btnLuG
        '
        Me.btnLuG.BackColor = System.Drawing.Color.Wheat
        Me.btnLuG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnLuG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLuG.Location = New System.Drawing.Point(501, 258)
        Me.btnLuG.Name = "btnLuG"
        Me.btnLuG.Size = New System.Drawing.Size(229, 84)
        Me.btnLuG.TabIndex = 8
        Me.btnLuG.Text = "Kenntnisse Lohn- und Gehalts-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abrechnung/-buchhaltung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnLuG.UseVisualStyleBackColor = False
        '
        'Lug_buchhaltung_sonstigesTextBox
        '
        Me.Lug_buchhaltung_sonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_buchhaltung_sonstiges", True))
        Me.Lug_buchhaltung_sonstigesTextBox.Location = New System.Drawing.Point(676, 133)
        Me.Lug_buchhaltung_sonstigesTextBox.Multiline = True
        Me.Lug_buchhaltung_sonstigesTextBox.Name = "Lug_buchhaltung_sonstigesTextBox"
        Me.Lug_buchhaltung_sonstigesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Lug_buchhaltung_sonstigesTextBox.Size = New System.Drawing.Size(252, 101)
        Me.Lug_buchhaltung_sonstigesTextBox.TabIndex = 5
        '
        'Lug_buchhaltung_softwareListBox
        '
        Me.Lug_buchhaltung_softwareListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bew_lugBindingSource, "lug_buchhaltung_software", True))
        Me.Lug_buchhaltung_softwareListBox.FormattingEnabled = True
        Me.Lug_buchhaltung_softwareListBox.ItemHeight = 16
        Me.Lug_buchhaltung_softwareListBox.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Lexware", "KHK Sage", "Oracle", "andere"})
        Me.Lug_buchhaltung_softwareListBox.Location = New System.Drawing.Point(264, 136)
        Me.Lug_buchhaltung_softwareListBox.Name = "Lug_buchhaltung_softwareListBox"
        Me.Lug_buchhaltung_softwareListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Lug_buchhaltung_softwareListBox.Size = New System.Drawing.Size(168, 84)
        Me.Lug_buchhaltung_softwareListBox.TabIndex = 4
        '
        'Lug_buchhaltung_woListBox
        '
        Me.Lug_buchhaltung_woListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bew_lugBindingSource, "lug_buchhaltung_wo", True))
        Me.Lug_buchhaltung_woListBox.FormattingEnabled = True
        Me.Lug_buchhaltung_woListBox.ItemHeight = 16
        Me.Lug_buchhaltung_woListBox.Items.AddRange(New Object() {"Dienstleistung", "Handwerk", "Industrie", "Öffentlicher Dienst", "Freiberufler"})
        Me.Lug_buchhaltung_woListBox.Location = New System.Drawing.Point(676, 26)
        Me.Lug_buchhaltung_woListBox.Name = "Lug_buchhaltung_woListBox"
        Me.Lug_buchhaltung_woListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Lug_buchhaltung_woListBox.Size = New System.Drawing.Size(188, 84)
        Me.Lug_buchhaltung_woListBox.TabIndex = 2
        '
        'Lug_buchhaltungComboBox
        '
        Me.Lug_buchhaltungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_buchhaltung", True))
        Me.Lug_buchhaltungComboBox.FormattingEnabled = True
        Me.Lug_buchhaltungComboBox.Items.AddRange(New Object() {"0 - keine Kenntnisse", "1 - immer angewendet", "2 - häufig", "3 - gelegentlich", "4 - Grundkenntnisse"})
        Me.Lug_buchhaltungComboBox.Location = New System.Drawing.Point(282, 26)
        Me.Lug_buchhaltungComboBox.Name = "Lug_buchhaltungComboBox"
        Me.Lug_buchhaltungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Lug_buchhaltungComboBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Lug_abrechnung_reisekostenLabel)
        Me.GroupBox1.Controls.Add(Me.Lug_abrechnung_reisekostenComboBox)
        Me.GroupBox1.Controls.Add(Lug_abrechnung_provisionLabel)
        Me.GroupBox1.Controls.Add(Me.Lug_abrechnung_provisionComboBox)
        Me.GroupBox1.Controls.Add(Lug_abrechnung_minijobLabel)
        Me.GroupBox1.Controls.Add(Me.Lug_abrechnung_minijobComboBox)
        Me.GroupBox1.Controls.Add(Lug_abrechnung_sonstigesLabel)
        Me.GroupBox1.Controls.Add(Me.Lug_abrechnung_sonstigesTextBox)
        Me.GroupBox1.Controls.Add(Lug_abrechnung_baulohnLabel)
        Me.GroupBox1.Controls.Add(Me.Lug_abrechnung_baulohnComboBox)
        Me.GroupBox1.Controls.Add(Lug_abrechnung_softwareLabel)
        Me.GroupBox1.Controls.Add(Me.Lug_abrechnung_softwareListBox)
        Me.GroupBox1.Controls.Add(Lug_abrechnung_tarifvertrag_welcheLabel)
        Me.GroupBox1.Controls.Add(Me.Lug_abrechnung_tarifvertrag_welcheTextBox)
        Me.GroupBox1.Controls.Add(Lug_abrechnung_tarifvertragLabel)
        Me.GroupBox1.Controls.Add(Me.Lug_abrechnung_tarifvertragComboBox)
        Me.GroupBox1.Controls.Add(Bibuha_erfahrungLabel1)
        Me.GroupBox1.Controls.Add(Me.Lug_abrechnung_woListBox)
        Me.GroupBox1.Controls.Add(Lug_abrechnungLabel)
        Me.GroupBox1.Controls.Add(Me.Lug_abrechnungComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1273, 471)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lohn- und Gehaltsabrechnung"
        '
        'Lug_abrechnung_reisekostenComboBox
        '
        Me.Lug_abrechnung_reisekostenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_abrechnung_reisekosten", True))
        Me.Lug_abrechnung_reisekostenComboBox.FormattingEnabled = True
        Me.Lug_abrechnung_reisekostenComboBox.Location = New System.Drawing.Point(282, 291)
        Me.Lug_abrechnung_reisekostenComboBox.Name = "Lug_abrechnung_reisekostenComboBox"
        Me.Lug_abrechnung_reisekostenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Lug_abrechnung_reisekostenComboBox.TabIndex = 15
        '
        'Lug_abrechnung_provisionComboBox
        '
        Me.Lug_abrechnung_provisionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_abrechnung_provision", True))
        Me.Lug_abrechnung_provisionComboBox.FormattingEnabled = True
        Me.Lug_abrechnung_provisionComboBox.Location = New System.Drawing.Point(282, 247)
        Me.Lug_abrechnung_provisionComboBox.Name = "Lug_abrechnung_provisionComboBox"
        Me.Lug_abrechnung_provisionComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Lug_abrechnung_provisionComboBox.TabIndex = 13
        '
        'Lug_abrechnung_minijobComboBox
        '
        Me.Lug_abrechnung_minijobComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_abrechnung_minijob", True))
        Me.Lug_abrechnung_minijobComboBox.FormattingEnabled = True
        Me.Lug_abrechnung_minijobComboBox.Location = New System.Drawing.Point(282, 199)
        Me.Lug_abrechnung_minijobComboBox.Name = "Lug_abrechnung_minijobComboBox"
        Me.Lug_abrechnung_minijobComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Lug_abrechnung_minijobComboBox.TabIndex = 11
        '
        'Lug_abrechnung_sonstigesTextBox
        '
        Me.Lug_abrechnung_sonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_abrechnung_sonstiges", True))
        Me.Lug_abrechnung_sonstigesTextBox.Location = New System.Drawing.Point(282, 330)
        Me.Lug_abrechnung_sonstigesTextBox.Multiline = True
        Me.Lug_abrechnung_sonstigesTextBox.Name = "Lug_abrechnung_sonstigesTextBox"
        Me.Lug_abrechnung_sonstigesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Lug_abrechnung_sonstigesTextBox.Size = New System.Drawing.Size(335, 129)
        Me.Lug_abrechnung_sonstigesTextBox.TabIndex = 17
        '
        'Lug_abrechnung_baulohnComboBox
        '
        Me.Lug_abrechnung_baulohnComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_abrechnung_baulohn", True))
        Me.Lug_abrechnung_baulohnComboBox.FormattingEnabled = True
        Me.Lug_abrechnung_baulohnComboBox.Location = New System.Drawing.Point(282, 146)
        Me.Lug_abrechnung_baulohnComboBox.Name = "Lug_abrechnung_baulohnComboBox"
        Me.Lug_abrechnung_baulohnComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Lug_abrechnung_baulohnComboBox.TabIndex = 7
        '
        'Lug_abrechnung_softwareListBox
        '
        Me.Lug_abrechnung_softwareListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bew_lugBindingSource, "lug_abrechnung_software", True))
        Me.Lug_abrechnung_softwareListBox.FormattingEnabled = True
        Me.Lug_abrechnung_softwareListBox.ItemHeight = 16
        Me.Lug_abrechnung_softwareListBox.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Lexware", "KHK Sage", "Oracle", "andere"})
        Me.Lug_abrechnung_softwareListBox.Location = New System.Drawing.Point(1040, 212)
        Me.Lug_abrechnung_softwareListBox.Name = "Lug_abrechnung_softwareListBox"
        Me.Lug_abrechnung_softwareListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Lug_abrechnung_softwareListBox.Size = New System.Drawing.Size(188, 84)
        Me.Lug_abrechnung_softwareListBox.TabIndex = 19
        '
        'Lug_abrechnung_tarifvertrag_welcheTextBox
        '
        Me.Lug_abrechnung_tarifvertrag_welcheTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_abrechnung_tarifvertrag_welche", True))
        Me.Lug_abrechnung_tarifvertrag_welcheTextBox.Location = New System.Drawing.Point(1040, 141)
        Me.Lug_abrechnung_tarifvertrag_welcheTextBox.Multiline = True
        Me.Lug_abrechnung_tarifvertrag_welcheTextBox.Name = "Lug_abrechnung_tarifvertrag_welcheTextBox"
        Me.Lug_abrechnung_tarifvertrag_welcheTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Lug_abrechnung_tarifvertrag_welcheTextBox.Size = New System.Drawing.Size(188, 50)
        Me.Lug_abrechnung_tarifvertrag_welcheTextBox.TabIndex = 5
        '
        'Lug_abrechnung_tarifvertragComboBox
        '
        Me.Lug_abrechnung_tarifvertragComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_abrechnung_tarifvertrag", True))
        Me.Lug_abrechnung_tarifvertragComboBox.FormattingEnabled = True
        Me.Lug_abrechnung_tarifvertragComboBox.Location = New System.Drawing.Point(282, 94)
        Me.Lug_abrechnung_tarifvertragComboBox.Name = "Lug_abrechnung_tarifvertragComboBox"
        Me.Lug_abrechnung_tarifvertragComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Lug_abrechnung_tarifvertragComboBox.TabIndex = 4
        '
        'Lug_abrechnung_woListBox
        '
        Me.Lug_abrechnung_woListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bew_lugBindingSource, "lug_abrechnung_wo", True))
        Me.Lug_abrechnung_woListBox.FormattingEnabled = True
        Me.Lug_abrechnung_woListBox.ItemHeight = 16
        Me.Lug_abrechnung_woListBox.Items.AddRange(New Object() {"Dienstleistung", "Handwerk", "Industrie", "Öffentlicher Dienst", "Freiberufler"})
        Me.Lug_abrechnung_woListBox.Location = New System.Drawing.Point(1040, 27)
        Me.Lug_abrechnung_woListBox.Name = "Lug_abrechnung_woListBox"
        Me.Lug_abrechnung_woListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Lug_abrechnung_woListBox.Size = New System.Drawing.Size(188, 68)
        Me.Lug_abrechnung_woListBox.TabIndex = 2
        '
        'Lug_abrechnungComboBox
        '
        Me.Lug_abrechnungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_abrechnung", True))
        Me.Lug_abrechnungComboBox.FormattingEnabled = True
        Me.Lug_abrechnungComboBox.Location = New System.Drawing.Point(282, 27)
        Me.Lug_abrechnungComboBox.Name = "Lug_abrechnungComboBox"
        Me.Lug_abrechnungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Lug_abrechnungComboBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Lug_abrechnung_anzahlLabel)
        Me.GroupBox3.Controls.Add(Me.Lug_abrechnung_anzahlComboBox)
        Me.GroupBox3.Controls.Add(Lug_buchhaltung_anzahlLabel)
        Me.GroupBox3.Controls.Add(Me.Lug_buchhaltung_anzahlComboBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1273, 85)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Betreute Mitarbeiter/innen"
        '
        'Lug_abrechnung_anzahlComboBox
        '
        Me.Lug_abrechnung_anzahlComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_abrechnung_anzahl", True))
        Me.Lug_abrechnung_anzahlComboBox.FormattingEnabled = True
        Me.Lug_abrechnung_anzahlComboBox.Location = New System.Drawing.Point(377, 27)
        Me.Lug_abrechnung_anzahlComboBox.Name = "Lug_abrechnung_anzahlComboBox"
        Me.Lug_abrechnung_anzahlComboBox.Size = New System.Drawing.Size(213, 24)
        Me.Lug_abrechnung_anzahlComboBox.TabIndex = 1
        '
        'Lug_buchhaltung_anzahlComboBox
        '
        Me.Lug_buchhaltung_anzahlComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_lugBindingSource, "lug_buchhaltung_anzahl", True))
        Me.Lug_buchhaltung_anzahlComboBox.FormattingEnabled = True
        Me.Lug_buchhaltung_anzahlComboBox.Location = New System.Drawing.Point(1040, 27)
        Me.Lug_buchhaltung_anzahlComboBox.Name = "Lug_buchhaltung_anzahlComboBox"
        Me.Lug_buchhaltung_anzahlComboBox.Size = New System.Drawing.Size(213, 24)
        Me.Lug_buchhaltung_anzahlComboBox.TabIndex = 2
        '
        'Bew_lugTableAdapter
        '
        Me.Bew_lugTableAdapter.ClearBeforeFill = True
        '
        'frmLuG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1310, 907)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLuG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lohn und Gehalt"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Bew_lugBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLuG As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lug_abrechnungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_abrechnung_woListBox As System.Windows.Forms.ListBox
    Friend WithEvents Lug_abrechnung_tarifvertrag_welcheTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lug_abrechnung_tarifvertragComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_abrechnung_softwareListBox As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lug_buchhaltung_woListBox As System.Windows.Forms.ListBox
    Friend WithEvents Lug_buchhaltungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_abrechnung_sonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lug_abrechnung_baulohnComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_buchhaltung_sonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lug_buchhaltung_softwareListBox As System.Windows.Forms.ListBox
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
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bew_lugBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bew_lugTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bew_lugTableAdapter
    Friend WithEvents LugsummeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LugdurchschnittDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LuganzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lug_buchhaltung_anzahlComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_abrechnung_anzahlComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_abrechnung_reisekostenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_abrechnung_provisionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_abrechnung_minijobComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_buchhaltung_reisekostenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_buchhaltung_provisionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lug_buchhaltung_minijobComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class

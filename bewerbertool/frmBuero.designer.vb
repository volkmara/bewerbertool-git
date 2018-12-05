<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuero
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
        Dim Buero_korrespondenz_freiLabel As System.Windows.Forms.Label
        Dim Buero_korresponenz_diktatLabel As System.Windows.Forms.Label
        Dim Buero_korresponenz_phonodiktatLabel As System.Windows.Forms.Label
        Dim Buero_korresponenz_stichworteLabel As System.Windows.Forms.Label
        Dim Buero_serienbriefeLabel As System.Windows.Forms.Label
        Dim Buero_dateneingabeLabel As System.Windows.Forms.Label
        Dim Buero_empfangLabel As System.Windows.Forms.Label
        Dim Buero_telefonzentraleLabel As System.Windows.Forms.Label
        Dim Buero_postbearbeitungLabel As System.Windows.Forms.Label
        Dim Buero_ablageLabel As System.Windows.Forms.Label
        Dim Buero_wiedervorlageLabel As System.Windows.Forms.Label
        Dim Buero_termin_fristenLabel As System.Windows.Forms.Label
        Dim Buero_sonstigesLabel As System.Windows.Forms.Label
        Dim Buero_sachbearbeitungLabel As System.Windows.Forms.Label
        Dim Buero_vorbereitende_buchhaltungLabel As System.Windows.Forms.Label
        Dim Buero_rechnungstellungLabel As System.Windows.Forms.Label
        Dim Buero_personalverwaltungLabel As System.Windows.Forms.Label
        Dim Buero_materialverwaltungLabel As System.Windows.Forms.Label
        Dim Buero_sitzungsvorbereitungLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnBuerospeichern = New System.Windows.Forms.Button()
        Me.Buero_personalverwaltungComboBox = New System.Windows.Forms.ComboBox()
        Me.Bewerber_bueroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Buero_sonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.Buero_rechnungstellungComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_vorbereitende_buchhaltungComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_sachbearbeitungComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Buero_sitzungsvorbereitungComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_materialverwaltungComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_postbearbeitungComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_telefonzentraleComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_empfangComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_wiedervorlageComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_ablageComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_termin_fristenComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Buero_serienbriefeComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_korrespondenz_freiComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_korresponenz_diktatComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_korresponenz_phonodiktatComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_korresponenz_stichworteComboBox = New System.Windows.Forms.ComboBox()
        Me.Buero_dateneingabeComboBox = New System.Windows.Forms.ComboBox()
        Me.Bewerber_bueroTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_bueroTableAdapter()
        Buero_korrespondenz_freiLabel = New System.Windows.Forms.Label()
        Buero_korresponenz_diktatLabel = New System.Windows.Forms.Label()
        Buero_korresponenz_phonodiktatLabel = New System.Windows.Forms.Label()
        Buero_korresponenz_stichworteLabel = New System.Windows.Forms.Label()
        Buero_serienbriefeLabel = New System.Windows.Forms.Label()
        Buero_dateneingabeLabel = New System.Windows.Forms.Label()
        Buero_empfangLabel = New System.Windows.Forms.Label()
        Buero_telefonzentraleLabel = New System.Windows.Forms.Label()
        Buero_postbearbeitungLabel = New System.Windows.Forms.Label()
        Buero_ablageLabel = New System.Windows.Forms.Label()
        Buero_wiedervorlageLabel = New System.Windows.Forms.Label()
        Buero_termin_fristenLabel = New System.Windows.Forms.Label()
        Buero_sonstigesLabel = New System.Windows.Forms.Label()
        Buero_sachbearbeitungLabel = New System.Windows.Forms.Label()
        Buero_vorbereitende_buchhaltungLabel = New System.Windows.Forms.Label()
        Buero_rechnungstellungLabel = New System.Windows.Forms.Label()
        Buero_personalverwaltungLabel = New System.Windows.Forms.Label()
        Buero_materialverwaltungLabel = New System.Windows.Forms.Label()
        Buero_sitzungsvorbereitungLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Bewerber_bueroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Buero_korrespondenz_freiLabel
        '
        Buero_korrespondenz_freiLabel.AutoSize = True
        Buero_korrespondenz_freiLabel.Location = New System.Drawing.Point(10, 30)
        Buero_korrespondenz_freiLabel.Name = "Buero_korrespondenz_freiLabel"
        Buero_korrespondenz_freiLabel.Size = New System.Drawing.Size(34, 16)
        Buero_korrespondenz_freiLabel.TabIndex = 22
        Buero_korrespondenz_freiLabel.Text = "frei:"
        '
        'Buero_korresponenz_diktatLabel
        '
        Buero_korresponenz_diktatLabel.AutoSize = True
        Buero_korresponenz_diktatLabel.Location = New System.Drawing.Point(454, 30)
        Buero_korresponenz_diktatLabel.Name = "Buero_korresponenz_diktatLabel"
        Buero_korresponenz_diktatLabel.Size = New System.Drawing.Size(89, 16)
        Buero_korresponenz_diktatLabel.TabIndex = 23
        Buero_korresponenz_diktatLabel.Text = "nach Diktat:"
        '
        'Buero_korresponenz_phonodiktatLabel
        '
        Buero_korresponenz_phonodiktatLabel.AutoSize = True
        Buero_korresponenz_phonodiktatLabel.Location = New System.Drawing.Point(882, 30)
        Buero_korresponenz_phonodiktatLabel.Name = "Buero_korresponenz_phonodiktatLabel"
        Buero_korresponenz_phonodiktatLabel.Size = New System.Drawing.Size(131, 16)
        Buero_korresponenz_phonodiktatLabel.TabIndex = 24
        Buero_korresponenz_phonodiktatLabel.Text = "nach Phonodiktat:"
        '
        'Buero_korresponenz_stichworteLabel
        '
        Buero_korresponenz_stichworteLabel.AutoSize = True
        Buero_korresponenz_stichworteLabel.Location = New System.Drawing.Point(882, 74)
        Buero_korresponenz_stichworteLabel.Name = "Buero_korresponenz_stichworteLabel"
        Buero_korresponenz_stichworteLabel.Size = New System.Drawing.Size(128, 16)
        Buero_korresponenz_stichworteLabel.TabIndex = 25
        Buero_korresponenz_stichworteLabel.Text = "nach Stichworten:"
        '
        'Buero_serienbriefeLabel
        '
        Buero_serienbriefeLabel.AutoSize = True
        Buero_serienbriefeLabel.Location = New System.Drawing.Point(11, 74)
        Buero_serienbriefeLabel.Name = "Buero_serienbriefeLabel"
        Buero_serienbriefeLabel.Size = New System.Drawing.Size(97, 16)
        Buero_serienbriefeLabel.TabIndex = 27
        Buero_serienbriefeLabel.Text = "Serienbriefe:"
        '
        'Buero_dateneingabeLabel
        '
        Buero_dateneingabeLabel.AutoSize = True
        Buero_dateneingabeLabel.Location = New System.Drawing.Point(368, 74)
        Buero_dateneingabeLabel.Name = "Buero_dateneingabeLabel"
        Buero_dateneingabeLabel.Size = New System.Drawing.Size(182, 16)
        Buero_dateneingabeLabel.TabIndex = 28
        Buero_dateneingabeLabel.Text = "Dateneingabe allgemein:"
        '
        'Buero_empfangLabel
        '
        Buero_empfangLabel.AutoSize = True
        Buero_empfangLabel.Location = New System.Drawing.Point(939, 28)
        Buero_empfangLabel.Name = "Buero_empfangLabel"
        Buero_empfangLabel.Size = New System.Drawing.Size(68, 15)
        Buero_empfangLabel.TabIndex = 30
        Buero_empfangLabel.Text = "Empfang:"
        '
        'Buero_telefonzentraleLabel
        '
        Buero_telefonzentraleLabel.AutoSize = True
        Buero_telefonzentraleLabel.Location = New System.Drawing.Point(865, 68)
        Buero_telefonzentraleLabel.Name = "Buero_telefonzentraleLabel"
        Buero_telefonzentraleLabel.Size = New System.Drawing.Size(142, 30)
        Buero_telefonzentraleLabel.TabIndex = 31
        Buero_telefonzentraleLabel.Text = "Telefonzentrale, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Telefonweiterleitung:"
        '
        'Buero_postbearbeitungLabel
        '
        Buero_postbearbeitungLabel.AutoSize = True
        Buero_postbearbeitungLabel.Location = New System.Drawing.Point(398, 68)
        Buero_postbearbeitungLabel.Name = "Buero_postbearbeitungLabel"
        Buero_postbearbeitungLabel.Size = New System.Drawing.Size(142, 30)
        Buero_postbearbeitungLabel.TabIndex = 32
        Buero_postbearbeitungLabel.Text = "Postbearbeitung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Postein-, -ausgang):"
        '
        'Buero_ablageLabel
        '
        Buero_ablageLabel.AutoSize = True
        Buero_ablageLabel.Location = New System.Drawing.Point(10, 28)
        Buero_ablageLabel.Name = "Buero_ablageLabel"
        Buero_ablageLabel.Size = New System.Drawing.Size(55, 15)
        Buero_ablageLabel.TabIndex = 36
        Buero_ablageLabel.Text = "Ablage:"
        '
        'Buero_wiedervorlageLabel
        '
        Buero_wiedervorlageLabel.AutoSize = True
        Buero_wiedervorlageLabel.Location = New System.Drawing.Point(437, 28)
        Buero_wiedervorlageLabel.Name = "Buero_wiedervorlageLabel"
        Buero_wiedervorlageLabel.Size = New System.Drawing.Size(103, 15)
        Buero_wiedervorlageLabel.TabIndex = 37
        Buero_wiedervorlageLabel.Text = "Wiedervorlage:"
        '
        'Buero_termin_fristenLabel
        '
        Buero_termin_fristenLabel.AutoSize = True
        Buero_termin_fristenLabel.Location = New System.Drawing.Point(10, 68)
        Buero_termin_fristenLabel.Name = "Buero_termin_fristenLabel"
        Buero_termin_fristenLabel.Size = New System.Drawing.Size(139, 30)
        Buero_termin_fristenLabel.TabIndex = 37
        Buero_termin_fristenLabel.Text = "Termin- und " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fristenmanagement:"
        '
        'Buero_sonstigesLabel
        '
        Buero_sonstigesLabel.AutoSize = True
        Buero_sonstigesLabel.Location = New System.Drawing.Point(15, 127)
        Buero_sonstigesLabel.Name = "Buero_sonstigesLabel"
        Buero_sonstigesLabel.Size = New System.Drawing.Size(168, 15)
        Buero_sonstigesLabel.TabIndex = 37
        Buero_sonstigesLabel.Text = "Sonstige Bürotätigkeiten:"
        '
        'Buero_sachbearbeitungLabel
        '
        Buero_sachbearbeitungLabel.AutoSize = True
        Buero_sachbearbeitungLabel.Location = New System.Drawing.Point(11, 27)
        Buero_sachbearbeitungLabel.Name = "Buero_sachbearbeitungLabel"
        Buero_sachbearbeitungLabel.Size = New System.Drawing.Size(120, 30)
        Buero_sachbearbeitungLabel.TabIndex = 0
        Buero_sachbearbeitungLabel.Text = "Allgemeine " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sachbearbeitung:"
        '
        'Buero_vorbereitende_buchhaltungLabel
        '
        Buero_vorbereitende_buchhaltungLabel.AutoSize = True
        Buero_vorbereitende_buchhaltungLabel.Location = New System.Drawing.Point(352, 27)
        Buero_vorbereitende_buchhaltungLabel.Name = "Buero_vorbereitende_buchhaltungLabel"
        Buero_vorbereitende_buchhaltungLabel.Size = New System.Drawing.Size(185, 15)
        Buero_vorbereitende_buchhaltungLabel.TabIndex = 2
        Buero_vorbereitende_buchhaltungLabel.Text = "Vorbereitende Buchhaltung:"
        '
        'Buero_rechnungstellungLabel
        '
        Buero_rechnungstellungLabel.AutoSize = True
        Buero_rechnungstellungLabel.Location = New System.Drawing.Point(877, 27)
        Buero_rechnungstellungLabel.Name = "Buero_rechnungstellungLabel"
        Buero_rechnungstellungLabel.Size = New System.Drawing.Size(127, 15)
        Buero_rechnungstellungLabel.TabIndex = 4
        Buero_rechnungstellungLabel.Text = "Rechnungstellung:"
        '
        'Buero_personalverwaltungLabel
        '
        Buero_personalverwaltungLabel.AutoSize = True
        Buero_personalverwaltungLabel.Location = New System.Drawing.Point(12, 79)
        Buero_personalverwaltungLabel.Name = "Buero_personalverwaltungLabel"
        Buero_personalverwaltungLabel.Size = New System.Drawing.Size(137, 15)
        Buero_personalverwaltungLabel.TabIndex = 6
        Buero_personalverwaltungLabel.Text = "Personalverwaltung:"
        '
        'Buero_materialverwaltungLabel
        '
        Buero_materialverwaltungLabel.AutoSize = True
        Buero_materialverwaltungLabel.Location = New System.Drawing.Point(407, 126)
        Buero_materialverwaltungLabel.Name = "Buero_materialverwaltungLabel"
        Buero_materialverwaltungLabel.Size = New System.Drawing.Size(133, 15)
        Buero_materialverwaltungLabel.TabIndex = 40
        Buero_materialverwaltungLabel.Text = "Materialverwaltung:"
        '
        'Buero_sitzungsvorbereitungLabel
        '
        Buero_sitzungsvorbereitungLabel.AutoSize = True
        Buero_sitzungsvorbereitungLabel.Location = New System.Drawing.Point(6, 126)
        Buero_sitzungsvorbereitungLabel.Name = "Buero_sitzungsvorbereitungLabel"
        Buero_sitzungsvorbereitungLabel.Size = New System.Drawing.Size(146, 15)
        Buero_sitzungsvorbereitungLabel.TabIndex = 41
        Buero_sitzungsvorbereitungLabel.Text = "Sitzungsvorbereitung:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1246, 583)
        Me.Panel1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1234, 24)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte bei Bürotätigkeiten an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  "
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Buero_personalverwaltungLabel)
        Me.GroupBox4.Controls.Add(Me.btnBuerospeichern)
        Me.GroupBox4.Controls.Add(Buero_sonstigesLabel)
        Me.GroupBox4.Controls.Add(Me.Buero_personalverwaltungComboBox)
        Me.GroupBox4.Controls.Add(Me.Buero_sonstigesTextBox)
        Me.GroupBox4.Controls.Add(Buero_rechnungstellungLabel)
        Me.GroupBox4.Controls.Add(Me.Buero_rechnungstellungComboBox)
        Me.GroupBox4.Controls.Add(Me.Buero_vorbereitende_buchhaltungComboBox)
        Me.GroupBox4.Controls.Add(Me.Buero_sachbearbeitungComboBox)
        Me.GroupBox4.Controls.Add(Buero_vorbereitende_buchhaltungLabel)
        Me.GroupBox4.Controls.Add(Buero_sachbearbeitungLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 318)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1234, 255)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sachbearbeitung"
        '
        'btnBuerospeichern
        '
        Me.btnBuerospeichern.BackColor = System.Drawing.Color.Wheat
        Me.btnBuerospeichern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnBuerospeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuerospeichern.Location = New System.Drawing.Point(596, 149)
        Me.btnBuerospeichern.Name = "btnBuerospeichern"
        Me.btnBuerospeichern.Size = New System.Drawing.Size(203, 60)
        Me.btnBuerospeichern.TabIndex = 39
        Me.btnBuerospeichern.Text = "Kenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Büro/Sekretariat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnBuerospeichern.UseVisualStyleBackColor = False
        '
        'Buero_personalverwaltungComboBox
        '
        Me.Buero_personalverwaltungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_personalverwaltung", True))
        Me.Buero_personalverwaltungComboBox.FormattingEnabled = True
        Me.Buero_personalverwaltungComboBox.Location = New System.Drawing.Point(152, 76)
        Me.Buero_personalverwaltungComboBox.Name = "Buero_personalverwaltungComboBox"
        Me.Buero_personalverwaltungComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_personalverwaltungComboBox.TabIndex = 4
        '
        'Bewerber_bueroBindingSource
        '
        Me.Bewerber_bueroBindingSource.DataMember = "bewerber_buero"
        Me.Bewerber_bueroBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Buero_sonstigesTextBox
        '
        Me.Buero_sonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_sonstiges", True))
        Me.Buero_sonstigesTextBox.Location = New System.Drawing.Point(231, 124)
        Me.Buero_sonstigesTextBox.Multiline = True
        Me.Buero_sonstigesTextBox.Name = "Buero_sonstigesTextBox"
        Me.Buero_sonstigesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Buero_sonstigesTextBox.Size = New System.Drawing.Size(291, 110)
        Me.Buero_sonstigesTextBox.TabIndex = 5
        '
        'Buero_rechnungstellungComboBox
        '
        Me.Buero_rechnungstellungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_rechnungstellung", True))
        Me.Buero_rechnungstellungComboBox.FormattingEnabled = True
        Me.Buero_rechnungstellungComboBox.Location = New System.Drawing.Point(1027, 24)
        Me.Buero_rechnungstellungComboBox.Name = "Buero_rechnungstellungComboBox"
        Me.Buero_rechnungstellungComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_rechnungstellungComboBox.TabIndex = 3
        '
        'Buero_vorbereitende_buchhaltungComboBox
        '
        Me.Buero_vorbereitende_buchhaltungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_vorbereitende_buchhaltung", True))
        Me.Buero_vorbereitende_buchhaltungComboBox.FormattingEnabled = True
        Me.Buero_vorbereitende_buchhaltungComboBox.Location = New System.Drawing.Point(555, 24)
        Me.Buero_vorbereitende_buchhaltungComboBox.Name = "Buero_vorbereitende_buchhaltungComboBox"
        Me.Buero_vorbereitende_buchhaltungComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_vorbereitende_buchhaltungComboBox.TabIndex = 2
        '
        'Buero_sachbearbeitungComboBox
        '
        Me.Buero_sachbearbeitungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_sachbearbeitung", True))
        Me.Buero_sachbearbeitungComboBox.FormattingEnabled = True
        Me.Buero_sachbearbeitungComboBox.Location = New System.Drawing.Point(152, 24)
        Me.Buero_sachbearbeitungComboBox.Name = "Buero_sachbearbeitungComboBox"
        Me.Buero_sachbearbeitungComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_sachbearbeitungComboBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Buero_sitzungsvorbereitungLabel)
        Me.GroupBox2.Controls.Add(Me.Buero_sitzungsvorbereitungComboBox)
        Me.GroupBox2.Controls.Add(Buero_materialverwaltungLabel)
        Me.GroupBox2.Controls.Add(Me.Buero_materialverwaltungComboBox)
        Me.GroupBox2.Controls.Add(Me.Buero_postbearbeitungComboBox)
        Me.GroupBox2.Controls.Add(Me.Buero_telefonzentraleComboBox)
        Me.GroupBox2.Controls.Add(Me.Buero_empfangComboBox)
        Me.GroupBox2.Controls.Add(Me.Buero_wiedervorlageComboBox)
        Me.GroupBox2.Controls.Add(Buero_wiedervorlageLabel)
        Me.GroupBox2.Controls.Add(Buero_ablageLabel)
        Me.GroupBox2.Controls.Add(Me.Buero_ablageComboBox)
        Me.GroupBox2.Controls.Add(Buero_postbearbeitungLabel)
        Me.GroupBox2.Controls.Add(Buero_empfangLabel)
        Me.GroupBox2.Controls.Add(Buero_telefonzentraleLabel)
        Me.GroupBox2.Controls.Add(Buero_termin_fristenLabel)
        Me.GroupBox2.Controls.Add(Me.Buero_termin_fristenComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1234, 160)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Allgemeine Büroorganisation:"
        '
        'Buero_sitzungsvorbereitungComboBox
        '
        Me.Buero_sitzungsvorbereitungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_sitzungsvorbereitung", True))
        Me.Buero_sitzungsvorbereitungComboBox.FormattingEnabled = True
        Me.Buero_sitzungsvorbereitungComboBox.Location = New System.Drawing.Point(155, 123)
        Me.Buero_sitzungsvorbereitungComboBox.Name = "Buero_sitzungsvorbereitungComboBox"
        Me.Buero_sitzungsvorbereitungComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_sitzungsvorbereitungComboBox.TabIndex = 7
        '
        'Buero_materialverwaltungComboBox
        '
        Me.Buero_materialverwaltungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_materialverwaltung", True))
        Me.Buero_materialverwaltungComboBox.FormattingEnabled = True
        Me.Buero_materialverwaltungComboBox.Location = New System.Drawing.Point(555, 123)
        Me.Buero_materialverwaltungComboBox.Name = "Buero_materialverwaltungComboBox"
        Me.Buero_materialverwaltungComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_materialverwaltungComboBox.TabIndex = 7
        '
        'Buero_postbearbeitungComboBox
        '
        Me.Buero_postbearbeitungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_postbearbeitung", True))
        Me.Buero_postbearbeitungComboBox.FormattingEnabled = True
        Me.Buero_postbearbeitungComboBox.Location = New System.Drawing.Point(555, 75)
        Me.Buero_postbearbeitungComboBox.Name = "Buero_postbearbeitungComboBox"
        Me.Buero_postbearbeitungComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_postbearbeitungComboBox.TabIndex = 5
        '
        'Buero_telefonzentraleComboBox
        '
        Me.Buero_telefonzentraleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_telefonzentrale", True))
        Me.Buero_telefonzentraleComboBox.FormattingEnabled = True
        Me.Buero_telefonzentraleComboBox.Location = New System.Drawing.Point(1030, 75)
        Me.Buero_telefonzentraleComboBox.Name = "Buero_telefonzentraleComboBox"
        Me.Buero_telefonzentraleComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_telefonzentraleComboBox.TabIndex = 6
        '
        'Buero_empfangComboBox
        '
        Me.Buero_empfangComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_empfang", True))
        Me.Buero_empfangComboBox.FormattingEnabled = True
        Me.Buero_empfangComboBox.Location = New System.Drawing.Point(1030, 25)
        Me.Buero_empfangComboBox.Name = "Buero_empfangComboBox"
        Me.Buero_empfangComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_empfangComboBox.TabIndex = 3
        '
        'Buero_wiedervorlageComboBox
        '
        Me.Buero_wiedervorlageComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_wiedervorlage", True))
        Me.Buero_wiedervorlageComboBox.FormattingEnabled = True
        Me.Buero_wiedervorlageComboBox.Location = New System.Drawing.Point(555, 25)
        Me.Buero_wiedervorlageComboBox.Name = "Buero_wiedervorlageComboBox"
        Me.Buero_wiedervorlageComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_wiedervorlageComboBox.TabIndex = 2
        '
        'Buero_ablageComboBox
        '
        Me.Buero_ablageComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_ablage", True))
        Me.Buero_ablageComboBox.FormattingEnabled = True
        Me.Buero_ablageComboBox.Location = New System.Drawing.Point(155, 25)
        Me.Buero_ablageComboBox.Name = "Buero_ablageComboBox"
        Me.Buero_ablageComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_ablageComboBox.TabIndex = 1
        '
        'Buero_termin_fristenComboBox
        '
        Me.Buero_termin_fristenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_termin_fristen", True))
        Me.Buero_termin_fristenComboBox.FormattingEnabled = True
        Me.Buero_termin_fristenComboBox.Location = New System.Drawing.Point(155, 75)
        Me.Buero_termin_fristenComboBox.Name = "Buero_termin_fristenComboBox"
        Me.Buero_termin_fristenComboBox.Size = New System.Drawing.Size(174, 23)
        Me.Buero_termin_fristenComboBox.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Buero_serienbriefeComboBox)
        Me.GroupBox1.Controls.Add(Me.Buero_korrespondenz_freiComboBox)
        Me.GroupBox1.Controls.Add(Buero_korrespondenz_freiLabel)
        Me.GroupBox1.Controls.Add(Buero_korresponenz_diktatLabel)
        Me.GroupBox1.Controls.Add(Me.Buero_korresponenz_diktatComboBox)
        Me.GroupBox1.Controls.Add(Buero_korresponenz_phonodiktatLabel)
        Me.GroupBox1.Controls.Add(Me.Buero_korresponenz_phonodiktatComboBox)
        Me.GroupBox1.Controls.Add(Buero_korresponenz_stichworteLabel)
        Me.GroupBox1.Controls.Add(Me.Buero_korresponenz_stichworteComboBox)
        Me.GroupBox1.Controls.Add(Buero_serienbriefeLabel)
        Me.GroupBox1.Controls.Add(Me.Buero_dateneingabeComboBox)
        Me.GroupBox1.Controls.Add(Buero_dateneingabeLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1234, 119)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Korrespondenz, Dateneingabe:"
        '
        'Buero_serienbriefeComboBox
        '
        Me.Buero_serienbriefeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_serienbriefe", True))
        Me.Buero_serienbriefeComboBox.FormattingEnabled = True
        Me.Buero_serienbriefeComboBox.Location = New System.Drawing.Point(152, 71)
        Me.Buero_serienbriefeComboBox.Name = "Buero_serienbriefeComboBox"
        Me.Buero_serienbriefeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Buero_serienbriefeComboBox.TabIndex = 4
        '
        'Buero_korrespondenz_freiComboBox
        '
        Me.Buero_korrespondenz_freiComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_korrespondenz_frei", True))
        Me.Buero_korrespondenz_freiComboBox.FormattingEnabled = True
        Me.Buero_korrespondenz_freiComboBox.Location = New System.Drawing.Point(152, 27)
        Me.Buero_korrespondenz_freiComboBox.Name = "Buero_korrespondenz_freiComboBox"
        Me.Buero_korrespondenz_freiComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Buero_korrespondenz_freiComboBox.TabIndex = 1
        '
        'Buero_korresponenz_diktatComboBox
        '
        Me.Buero_korresponenz_diktatComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_korresponenz_diktat", True))
        Me.Buero_korresponenz_diktatComboBox.FormattingEnabled = True
        Me.Buero_korresponenz_diktatComboBox.Location = New System.Drawing.Point(555, 27)
        Me.Buero_korresponenz_diktatComboBox.Name = "Buero_korresponenz_diktatComboBox"
        Me.Buero_korresponenz_diktatComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Buero_korresponenz_diktatComboBox.TabIndex = 2
        '
        'Buero_korresponenz_phonodiktatComboBox
        '
        Me.Buero_korresponenz_phonodiktatComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_korresponenz_phonodiktat", True))
        Me.Buero_korresponenz_phonodiktatComboBox.FormattingEnabled = True
        Me.Buero_korresponenz_phonodiktatComboBox.Location = New System.Drawing.Point(1027, 27)
        Me.Buero_korresponenz_phonodiktatComboBox.Name = "Buero_korresponenz_phonodiktatComboBox"
        Me.Buero_korresponenz_phonodiktatComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Buero_korresponenz_phonodiktatComboBox.TabIndex = 3
        '
        'Buero_korresponenz_stichworteComboBox
        '
        Me.Buero_korresponenz_stichworteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_korresponenz_stichworte", True))
        Me.Buero_korresponenz_stichworteComboBox.FormattingEnabled = True
        Me.Buero_korresponenz_stichworteComboBox.Location = New System.Drawing.Point(1027, 71)
        Me.Buero_korresponenz_stichworteComboBox.Name = "Buero_korresponenz_stichworteComboBox"
        Me.Buero_korresponenz_stichworteComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Buero_korresponenz_stichworteComboBox.TabIndex = 6
        '
        'Buero_dateneingabeComboBox
        '
        Me.Buero_dateneingabeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_bueroBindingSource, "buero_dateneingabe", True))
        Me.Buero_dateneingabeComboBox.FormattingEnabled = True
        Me.Buero_dateneingabeComboBox.Location = New System.Drawing.Point(556, 71)
        Me.Buero_dateneingabeComboBox.Name = "Buero_dateneingabeComboBox"
        Me.Buero_dateneingabeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Buero_dateneingabeComboBox.TabIndex = 5
        '
        'Bewerber_bueroTableAdapter
        '
        Me.Bewerber_bueroTableAdapter.ClearBeforeFill = True
        '
        'frmBuero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1249, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmBuero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Büro/Sekretariat"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Bewerber_bueroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Buero_dateneingabeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_korresponenz_stichworteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_korresponenz_phonodiktatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_korresponenz_diktatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuerospeichern As System.Windows.Forms.Button
    Friend WithEvents Buero_sonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Buero_termin_fristenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_empfangComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_wiedervorlageComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_ablageComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_postbearbeitungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_telefonzentraleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Buero_vorbereitende_buchhaltungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_sachbearbeitungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_rechnungstellungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_personalverwaltungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_sitzungsvorbereitungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_materialverwaltungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Buero_korrespondenz_freiComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Buero_serienbriefeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bewerber_bueroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_bueroTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_bueroTableAdapter
End Class

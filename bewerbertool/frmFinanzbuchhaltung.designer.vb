<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinanzbuchhaltung
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
        Dim Fibu_kassenbuch_bankLabel As System.Windows.Forms.Label
        Dim Fibu_kontenabstimmung_oplistenLabel As System.Windows.Forms.Label
        Dim Fibu_zahlungsverkehrLabel As System.Windows.Forms.Label
        Dim Fibu_rechnungspruefungLabel As System.Windows.Forms.Label
        Dim Fibu_mahnwesen_mahnbescheidLabel As System.Windows.Forms.Label
        Dim Fibu_softwareLabel As System.Windows.Forms.Label
        Dim Fibu_debitorenLabel As System.Windows.Forms.Label
        Dim Fibu_kreditorenLabel As System.Windows.Forms.Label
        Dim Fibu_sachkontenLabel As System.Windows.Forms.Label
        Dim Fibu_anlagenLabel As System.Windows.Forms.Label
        Dim Fibu_abschlussLabel As System.Windows.Forms.Label
        Dim Fibu_bwaLabel As System.Windows.Forms.Label
        Dim Fibu_bilanzLabel As System.Windows.Forms.Label
        Dim Fibu_kontieren_selbständigLabel As System.Windows.Forms.Label
        Dim Fibu_dateneingabeLabel As System.Windows.Forms.Label
        Dim Fibu_kontenrahmenLabel As System.Windows.Forms.Label
        Dim Fibu_kassenbuch_papierLabel As System.Windows.Forms.Label
        Dim Fibu_kassenbuch_excelLabel As System.Windows.Forms.Label
        Dim Fibu_kassenbuch_programmLabel As System.Windows.Forms.Label
        Dim Fibu_reisekosten_abrechnungLabel As System.Windows.Forms.Label
        Dim Fibu_reisekosten_buchhaltungLabel As System.Windows.Forms.Label
        Dim Fibu_immobilienLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinanzbuchhaltung))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Fibu_kontenrahmenListBox = New System.Windows.Forms.ListBox()
        Me.Bewerber_fibuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Fibu_immobilienComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_reisekosten_buchhaltungComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_reisekosten_abrechnungComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Fibu_dateneingabeComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_kontieren_selbständigComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_bilanzComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_bwaComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_abschlussComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_anlagenComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_sachkontenComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_kreditorenComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_debitorenComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Fibu_kassenbuch_programmComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_kassenbuch_excelComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_kassenbuch_papierComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_mahnwesen_mahnbescheidComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_rechnungspruefungComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_zahlungsverkehrComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_kontenabstimmung_oplistenComboBox = New System.Windows.Forms.ComboBox()
        Me.Fibu_kassenbuch_bankComboBox = New System.Windows.Forms.ComboBox()
        Me.btnFibu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Fibu_softwareListBox = New System.Windows.Forms.ListBox()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.Fibu_sonstigeTextBox = New System.Windows.Forms.TextBox()
        Me.Fibu_erfahrungListBox = New System.Windows.Forms.ListBox()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.Bewerber_fibuTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_fibuTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Fibu_kassenbuch_bankLabel = New System.Windows.Forms.Label()
        Fibu_kontenabstimmung_oplistenLabel = New System.Windows.Forms.Label()
        Fibu_zahlungsverkehrLabel = New System.Windows.Forms.Label()
        Fibu_rechnungspruefungLabel = New System.Windows.Forms.Label()
        Fibu_mahnwesen_mahnbescheidLabel = New System.Windows.Forms.Label()
        Fibu_softwareLabel = New System.Windows.Forms.Label()
        Fibu_debitorenLabel = New System.Windows.Forms.Label()
        Fibu_kreditorenLabel = New System.Windows.Forms.Label()
        Fibu_sachkontenLabel = New System.Windows.Forms.Label()
        Fibu_anlagenLabel = New System.Windows.Forms.Label()
        Fibu_abschlussLabel = New System.Windows.Forms.Label()
        Fibu_bwaLabel = New System.Windows.Forms.Label()
        Fibu_bilanzLabel = New System.Windows.Forms.Label()
        Fibu_kontieren_selbständigLabel = New System.Windows.Forms.Label()
        Fibu_dateneingabeLabel = New System.Windows.Forms.Label()
        Fibu_kontenrahmenLabel = New System.Windows.Forms.Label()
        Fibu_kassenbuch_papierLabel = New System.Windows.Forms.Label()
        Fibu_kassenbuch_excelLabel = New System.Windows.Forms.Label()
        Fibu_kassenbuch_programmLabel = New System.Windows.Forms.Label()
        Fibu_reisekosten_abrechnungLabel = New System.Windows.Forms.Label()
        Fibu_reisekosten_buchhaltungLabel = New System.Windows.Forms.Label()
        Fibu_immobilienLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Bewerber_fibuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fibu_kassenbuch_bankLabel
        '
        Fibu_kassenbuch_bankLabel.AutoSize = True
        Fibu_kassenbuch_bankLabel.Location = New System.Drawing.Point(6, 33)
        Fibu_kassenbuch_bankLabel.Name = "Fibu_kassenbuch_bankLabel"
        Fibu_kassenbuch_bankLabel.Size = New System.Drawing.Size(139, 16)
        Fibu_kassenbuch_bankLabel.TabIndex = 0
        Fibu_kassenbuch_bankLabel.Text = "Kassenbuch, Bank:"
        '
        'Fibu_kontenabstimmung_oplistenLabel
        '
        Fibu_kontenabstimmung_oplistenLabel.AutoSize = True
        Fibu_kontenabstimmung_oplistenLabel.Location = New System.Drawing.Point(379, 84)
        Fibu_kontenabstimmung_oplistenLabel.Name = "Fibu_kontenabstimmung_oplistenLabel"
        Fibu_kontenabstimmung_oplistenLabel.Size = New System.Drawing.Size(207, 16)
        Fibu_kontenabstimmung_oplistenLabel.TabIndex = 2
        Fibu_kontenabstimmung_oplistenLabel.Text = "Kontenabstimmung, Oplisten:"
        '
        'Fibu_zahlungsverkehrLabel
        '
        Fibu_zahlungsverkehrLabel.AutoSize = True
        Fibu_zahlungsverkehrLabel.Location = New System.Drawing.Point(884, 81)
        Fibu_zahlungsverkehrLabel.Name = "Fibu_zahlungsverkehrLabel"
        Fibu_zahlungsverkehrLabel.Size = New System.Drawing.Size(127, 16)
        Fibu_zahlungsverkehrLabel.TabIndex = 4
        Fibu_zahlungsverkehrLabel.Text = "Zahlungsverkehr:"
        '
        'Fibu_rechnungspruefungLabel
        '
        Fibu_rechnungspruefungLabel.AutoSize = True
        Fibu_rechnungspruefungLabel.Location = New System.Drawing.Point(6, 137)
        Fibu_rechnungspruefungLabel.Name = "Fibu_rechnungspruefungLabel"
        Fibu_rechnungspruefungLabel.Size = New System.Drawing.Size(140, 16)
        Fibu_rechnungspruefungLabel.TabIndex = 6
        Fibu_rechnungspruefungLabel.Text = "Rechnungsprüfung:"
        '
        'Fibu_mahnwesen_mahnbescheidLabel
        '
        Fibu_mahnwesen_mahnbescheidLabel.AutoSize = True
        Fibu_mahnwesen_mahnbescheidLabel.Location = New System.Drawing.Point(386, 137)
        Fibu_mahnwesen_mahnbescheidLabel.Name = "Fibu_mahnwesen_mahnbescheidLabel"
        Fibu_mahnwesen_mahnbescheidLabel.Size = New System.Drawing.Size(202, 16)
        Fibu_mahnwesen_mahnbescheidLabel.TabIndex = 8
        Fibu_mahnwesen_mahnbescheidLabel.Text = "Mahnwesen, Mahnbescheid:"
        '
        'Fibu_softwareLabel
        '
        Fibu_softwareLabel.AutoSize = True
        Fibu_softwareLabel.Location = New System.Drawing.Point(493, 27)
        Fibu_softwareLabel.Name = "Fibu_softwareLabel"
        Fibu_softwareLabel.Size = New System.Drawing.Size(179, 64)
        Fibu_softwareLabel.TabIndex = 4
        Fibu_softwareLabel.Text = "Software, mit der Sie in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "den letzten fünf Jahren " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in der Finanzbuchhaltung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ge" & _
    "arbeitet haben:"
        '
        'Fibu_debitorenLabel
        '
        Fibu_debitorenLabel.AutoSize = True
        Fibu_debitorenLabel.Location = New System.Drawing.Point(503, 128)
        Fibu_debitorenLabel.Name = "Fibu_debitorenLabel"
        Fibu_debitorenLabel.Size = New System.Drawing.Size(80, 16)
        Fibu_debitorenLabel.TabIndex = 0
        Fibu_debitorenLabel.Text = "Debitoren:"
        '
        'Fibu_kreditorenLabel
        '
        Fibu_kreditorenLabel.AutoSize = True
        Fibu_kreditorenLabel.Location = New System.Drawing.Point(7, 128)
        Fibu_kreditorenLabel.Name = "Fibu_kreditorenLabel"
        Fibu_kreditorenLabel.Size = New System.Drawing.Size(83, 16)
        Fibu_kreditorenLabel.TabIndex = 2
        Fibu_kreditorenLabel.Text = "Kreditoren:"
        '
        'Fibu_sachkontenLabel
        '
        Fibu_sachkontenLabel.AutoSize = True
        Fibu_sachkontenLabel.Location = New System.Drawing.Point(934, 128)
        Fibu_sachkontenLabel.Name = "Fibu_sachkontenLabel"
        Fibu_sachkontenLabel.Size = New System.Drawing.Size(93, 16)
        Fibu_sachkontenLabel.TabIndex = 4
        Fibu_sachkontenLabel.Text = "Sachkonten:"
        '
        'Fibu_anlagenLabel
        '
        Fibu_anlagenLabel.AutoSize = True
        Fibu_anlagenLabel.Location = New System.Drawing.Point(7, 181)
        Fibu_anlagenLabel.Name = "Fibu_anlagenLabel"
        Fibu_anlagenLabel.Size = New System.Drawing.Size(152, 16)
        Fibu_anlagenLabel.TabIndex = 6
        Fibu_anlagenLabel.Text = "Anlagenbuchhaltung:"
        '
        'Fibu_abschlussLabel
        '
        Fibu_abschlussLabel.AutoSize = True
        Fibu_abschlussLabel.Location = New System.Drawing.Point(493, 181)
        Fibu_abschlussLabel.Name = "Fibu_abschlussLabel"
        Fibu_abschlussLabel.Size = New System.Drawing.Size(92, 16)
        Fibu_abschlussLabel.TabIndex = 8
        Fibu_abschlussLabel.Text = "Abschlüsse:"
        '
        'Fibu_bwaLabel
        '
        Fibu_bwaLabel.AutoSize = True
        Fibu_bwaLabel.Location = New System.Drawing.Point(7, 230)
        Fibu_bwaLabel.Name = "Fibu_bwaLabel"
        Fibu_bwaLabel.Size = New System.Drawing.Size(46, 16)
        Fibu_bwaLabel.TabIndex = 12
        Fibu_bwaLabel.Text = "BWA:"
        '
        'Fibu_bilanzLabel
        '
        Fibu_bilanzLabel.AutoSize = True
        Fibu_bilanzLabel.Location = New System.Drawing.Point(945, 181)
        Fibu_bilanzLabel.Name = "Fibu_bilanzLabel"
        Fibu_bilanzLabel.Size = New System.Drawing.Size(71, 16)
        Fibu_bilanzLabel.TabIndex = 13
        Fibu_bilanzLabel.Text = "Bilanzen:"
        '
        'Fibu_kontieren_selbständigLabel
        '
        Fibu_kontieren_selbständigLabel.AutoSize = True
        Fibu_kontieren_selbständigLabel.Location = New System.Drawing.Point(7, 29)
        Fibu_kontieren_selbständigLabel.Name = "Fibu_kontieren_selbständigLabel"
        Fibu_kontieren_selbständigLabel.Size = New System.Drawing.Size(112, 32)
        Fibu_kontieren_selbständigLabel.TabIndex = 14
        Fibu_kontieren_selbständigLabel.Text = "Selbständiges " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kontieren:"
        '
        'Fibu_dateneingabeLabel
        '
        Fibu_dateneingabeLabel.AutoSize = True
        Fibu_dateneingabeLabel.Location = New System.Drawing.Point(479, 29)
        Fibu_dateneingabeLabel.Name = "Fibu_dateneingabeLabel"
        Fibu_dateneingabeLabel.Size = New System.Drawing.Size(105, 32)
        Fibu_dateneingabeLabel.TabIndex = 16
        Fibu_dateneingabeLabel.Text = "Eingabe von" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Massendaten:"
        '
        'Fibu_kontenrahmenLabel
        '
        Fibu_kontenrahmenLabel.AutoSize = True
        Fibu_kontenrahmenLabel.Location = New System.Drawing.Point(834, 37)
        Fibu_kontenrahmenLabel.Name = "Fibu_kontenrahmenLabel"
        Fibu_kontenrahmenLabel.Size = New System.Drawing.Size(110, 16)
        Fibu_kontenrahmenLabel.TabIndex = 18
        Fibu_kontenrahmenLabel.Text = "Kontenrahmen:"
        '
        'Fibu_kassenbuch_papierLabel
        '
        Fibu_kassenbuch_papierLabel.AutoSize = True
        Fibu_kassenbuch_papierLabel.Location = New System.Drawing.Point(436, 27)
        Fibu_kassenbuch_papierLabel.Name = "Fibu_kassenbuch_papierLabel"
        Fibu_kassenbuch_papierLabel.Size = New System.Drawing.Size(146, 32)
        Fibu_kassenbuch_papierLabel.TabIndex = 17
        Fibu_kassenbuch_papierLabel.Text = "Kassenbuchführung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in Papier:"
        '
        'Fibu_kassenbuch_excelLabel
        '
        Fibu_kassenbuch_excelLabel.AutoSize = True
        Fibu_kassenbuch_excelLabel.Location = New System.Drawing.Point(884, 27)
        Fibu_kassenbuch_excelLabel.Name = "Fibu_kassenbuch_excelLabel"
        Fibu_kassenbuch_excelLabel.Size = New System.Drawing.Size(142, 32)
        Fibu_kassenbuch_excelLabel.TabIndex = 18
        Fibu_kassenbuch_excelLabel.Text = "Kassenbuchführung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mit Excel:"
        '
        'Fibu_kassenbuch_programmLabel
        '
        Fibu_kassenbuch_programmLabel.AutoSize = True
        Fibu_kassenbuch_programmLabel.Location = New System.Drawing.Point(10, 81)
        Fibu_kassenbuch_programmLabel.Name = "Fibu_kassenbuch_programmLabel"
        Fibu_kassenbuch_programmLabel.Size = New System.Drawing.Size(146, 32)
        Fibu_kassenbuch_programmLabel.TabIndex = 19
        Fibu_kassenbuch_programmLabel.Text = "Kassenbuchführung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mit EDV:"
        '
        'Fibu_reisekosten_abrechnungLabel
        '
        Fibu_reisekosten_abrechnungLabel.AutoSize = True
        Fibu_reisekosten_abrechnungLabel.Location = New System.Drawing.Point(410, 230)
        Fibu_reisekosten_abrechnungLabel.Name = "Fibu_reisekosten_abrechnungLabel"
        Fibu_reisekosten_abrechnungLabel.Size = New System.Drawing.Size(180, 16)
        Fibu_reisekosten_abrechnungLabel.TabIndex = 26
        Fibu_reisekosten_abrechnungLabel.Text = "Reisekostenabrechnung:"
        '
        'Fibu_reisekosten_buchhaltungLabel
        '
        Fibu_reisekosten_buchhaltungLabel.AutoSize = True
        Fibu_reisekosten_buchhaltungLabel.Location = New System.Drawing.Point(845, 230)
        Fibu_reisekosten_buchhaltungLabel.Name = "Fibu_reisekosten_buchhaltungLabel"
        Fibu_reisekosten_buchhaltungLabel.Size = New System.Drawing.Size(182, 16)
        Fibu_reisekosten_buchhaltungLabel.TabIndex = 27
        Fibu_reisekosten_buchhaltungLabel.Text = "Reisekostenbuchhaltung:"
        '
        'Fibu_immobilienLabel
        '
        Fibu_immobilienLabel.AutoSize = True
        Fibu_immobilienLabel.Location = New System.Drawing.Point(11, 277)
        Fibu_immobilienLabel.Name = "Fibu_immobilienLabel"
        Fibu_immobilienLabel.Size = New System.Drawing.Size(95, 32)
        Fibu_immobilienLabel.TabIndex = 28
        Fibu_immobilienLabel.Text = "Immobilien-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "buchhaltung:"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1247, 797)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Fibu_kontenrahmenListBox)
        Me.GroupBox2.Controls.Add(Fibu_immobilienLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_immobilienComboBox)
        Me.GroupBox2.Controls.Add(Fibu_reisekosten_buchhaltungLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_reisekosten_buchhaltungComboBox)
        Me.GroupBox2.Controls.Add(Fibu_reisekosten_abrechnungLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_reisekosten_abrechnungComboBox)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Fibu_kontenrahmenLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_dateneingabeComboBox)
        Me.GroupBox2.Controls.Add(Me.Fibu_kontieren_selbständigComboBox)
        Me.GroupBox2.Controls.Add(Fibu_dateneingabeLabel)
        Me.GroupBox2.Controls.Add(Fibu_kontieren_selbständigLabel)
        Me.GroupBox2.Controls.Add(Fibu_bilanzLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_bilanzComboBox)
        Me.GroupBox2.Controls.Add(Fibu_bwaLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_bwaComboBox)
        Me.GroupBox2.Controls.Add(Fibu_abschlussLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_abschlussComboBox)
        Me.GroupBox2.Controls.Add(Fibu_anlagenLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_anlagenComboBox)
        Me.GroupBox2.Controls.Add(Fibu_sachkontenLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_sachkontenComboBox)
        Me.GroupBox2.Controls.Add(Fibu_kreditorenLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_kreditorenComboBox)
        Me.GroupBox2.Controls.Add(Fibu_debitorenLabel)
        Me.GroupBox2.Controls.Add(Me.Fibu_debitorenComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1238, 342)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Finanzbuchhaltung"
        '
        'Fibu_kontenrahmenListBox
        '
        Me.Fibu_kontenrahmenListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bewerber_fibuBindingSource, "fibu_kontenrahmen", True))
        Me.Fibu_kontenrahmenListBox.FormattingEnabled = True
        Me.Fibu_kontenrahmenListBox.ItemHeight = 16
        Me.Fibu_kontenrahmenListBox.Items.AddRange(New Object() {"SKR 03", "SKR 03 nach IFRS/IAS", "SKR 03 Ärzte", "SKR 03 Bau und Handwerk", "SKR 03 Hotel und Gaststätten", "SKR 03 Zahnärzte", "SKR 03 E-Bilanz Einzelunternehmen", "SKR 03 E-Bilanz Personengesellschaft", "SKR 04", "SKR 04 nach IFRS/IAS", "SKR 04 Ärzte", "SKR 04 Bau und Handwerk", "SKR 04 Hotel und Gaststätten", "SKR 04 Kommunale Unternehmen", "SKR 04 Zahnärzte", "SKR 04 E-Bilanz Einzelunternehmen", "SKR 04 E-Bilanz Kapitalgesellschaft", "SKR 45 E-Bilanz Kapitalgesellschaft", "SKR 45 E-Bilanz Einzelunternehmen", "SKR 45 soziale Einrichtungen nach PBV", "SKR 49 Vereine/Stiftungen/gGmbH", "SKR 51 Kfz-Branche", "SKR 93 Kfz-Betriebe"})
        Me.Fibu_kontenrahmenListBox.Location = New System.Drawing.Point(959, 36)
        Me.Fibu_kontenrahmenListBox.Name = "Fibu_kontenrahmenListBox"
        Me.Fibu_kontenrahmenListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Fibu_kontenrahmenListBox.Size = New System.Drawing.Size(264, 52)
        Me.Fibu_kontenrahmenListBox.TabIndex = 3
        '
        'Bewerber_fibuBindingSource
        '
        Me.Bewerber_fibuBindingSource.DataMember = "bewerber_fibu"
        Me.Bewerber_fibuBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Fibu_immobilienComboBox
        '
        Me.Fibu_immobilienComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_immobilien", True))
        Me.Fibu_immobilienComboBox.FormattingEnabled = True
        Me.Fibu_immobilienComboBox.Location = New System.Drawing.Point(163, 274)
        Me.Fibu_immobilienComboBox.Name = "Fibu_immobilienComboBox"
        Me.Fibu_immobilienComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_immobilienComboBox.TabIndex = 13
        '
        'Fibu_reisekosten_buchhaltungComboBox
        '
        Me.Fibu_reisekosten_buchhaltungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_reisekosten_buchhaltung", True))
        Me.Fibu_reisekosten_buchhaltungComboBox.FormattingEnabled = True
        Me.Fibu_reisekosten_buchhaltungComboBox.Location = New System.Drawing.Point(1033, 227)
        Me.Fibu_reisekosten_buchhaltungComboBox.Name = "Fibu_reisekosten_buchhaltungComboBox"
        Me.Fibu_reisekosten_buchhaltungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_reisekosten_buchhaltungComboBox.TabIndex = 12
        '
        'Fibu_reisekosten_abrechnungComboBox
        '
        Me.Fibu_reisekosten_abrechnungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_reisekosten_abrechnung", True))
        Me.Fibu_reisekosten_abrechnungComboBox.FormattingEnabled = True
        Me.Fibu_reisekosten_abrechnungComboBox.Location = New System.Drawing.Point(600, 227)
        Me.Fibu_reisekosten_abrechnungComboBox.Name = "Fibu_reisekosten_abrechnungComboBox"
        Me.Fibu_reisekosten_abrechnungComboBox.Size = New System.Drawing.Size(173, 24)
        Me.Fibu_reisekosten_abrechnungComboBox.TabIndex = 11
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(837, 55)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 17)
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Doppelklick in das Textfeld zum Eintragen")
        '
        'Fibu_dateneingabeComboBox
        '
        Me.Fibu_dateneingabeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_dateneingabe", True))
        Me.Fibu_dateneingabeComboBox.FormattingEnabled = True
        Me.Fibu_dateneingabeComboBox.Location = New System.Drawing.Point(600, 36)
        Me.Fibu_dateneingabeComboBox.Name = "Fibu_dateneingabeComboBox"
        Me.Fibu_dateneingabeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_dateneingabeComboBox.TabIndex = 2
        '
        'Fibu_kontieren_selbständigComboBox
        '
        Me.Fibu_kontieren_selbständigComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_kontieren_selbständig", True))
        Me.Fibu_kontieren_selbständigComboBox.FormattingEnabled = True
        Me.Fibu_kontieren_selbständigComboBox.Location = New System.Drawing.Point(163, 36)
        Me.Fibu_kontieren_selbständigComboBox.Name = "Fibu_kontieren_selbständigComboBox"
        Me.Fibu_kontieren_selbständigComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_kontieren_selbständigComboBox.TabIndex = 1
        '
        'Fibu_bilanzComboBox
        '
        Me.Fibu_bilanzComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_bilanz", True))
        Me.Fibu_bilanzComboBox.FormattingEnabled = True
        Me.Fibu_bilanzComboBox.Location = New System.Drawing.Point(1033, 178)
        Me.Fibu_bilanzComboBox.Name = "Fibu_bilanzComboBox"
        Me.Fibu_bilanzComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_bilanzComboBox.TabIndex = 9
        '
        'Fibu_bwaComboBox
        '
        Me.Fibu_bwaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_bwa", True))
        Me.Fibu_bwaComboBox.FormattingEnabled = True
        Me.Fibu_bwaComboBox.Location = New System.Drawing.Point(163, 222)
        Me.Fibu_bwaComboBox.Name = "Fibu_bwaComboBox"
        Me.Fibu_bwaComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_bwaComboBox.TabIndex = 10
        '
        'Fibu_abschlussComboBox
        '
        Me.Fibu_abschlussComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_abschluss", True))
        Me.Fibu_abschlussComboBox.FormattingEnabled = True
        Me.Fibu_abschlussComboBox.Location = New System.Drawing.Point(600, 178)
        Me.Fibu_abschlussComboBox.Name = "Fibu_abschlussComboBox"
        Me.Fibu_abschlussComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_abschlussComboBox.TabIndex = 8
        '
        'Fibu_anlagenComboBox
        '
        Me.Fibu_anlagenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_anlagen", True))
        Me.Fibu_anlagenComboBox.FormattingEnabled = True
        Me.Fibu_anlagenComboBox.Location = New System.Drawing.Point(163, 178)
        Me.Fibu_anlagenComboBox.Name = "Fibu_anlagenComboBox"
        Me.Fibu_anlagenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_anlagenComboBox.TabIndex = 7
        '
        'Fibu_sachkontenComboBox
        '
        Me.Fibu_sachkontenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_sachkonten", True))
        Me.Fibu_sachkontenComboBox.FormattingEnabled = True
        Me.Fibu_sachkontenComboBox.Location = New System.Drawing.Point(1033, 125)
        Me.Fibu_sachkontenComboBox.Name = "Fibu_sachkontenComboBox"
        Me.Fibu_sachkontenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_sachkontenComboBox.TabIndex = 6
        '
        'Fibu_kreditorenComboBox
        '
        Me.Fibu_kreditorenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_kreditoren", True))
        Me.Fibu_kreditorenComboBox.FormattingEnabled = True
        Me.Fibu_kreditorenComboBox.Location = New System.Drawing.Point(163, 125)
        Me.Fibu_kreditorenComboBox.Name = "Fibu_kreditorenComboBox"
        Me.Fibu_kreditorenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_kreditorenComboBox.TabIndex = 4
        '
        'Fibu_debitorenComboBox
        '
        Me.Fibu_debitorenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_debitoren", True))
        Me.Fibu_debitorenComboBox.FormattingEnabled = True
        Me.Fibu_debitorenComboBox.Location = New System.Drawing.Point(600, 125)
        Me.Fibu_debitorenComboBox.Name = "Fibu_debitorenComboBox"
        Me.Fibu_debitorenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_debitorenComboBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1236, 26)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte in der Finanzbuchhaltung an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Fibu_kassenbuch_programmLabel)
        Me.GroupBox3.Controls.Add(Me.Fibu_kassenbuch_programmComboBox)
        Me.GroupBox3.Controls.Add(Fibu_kassenbuch_excelLabel)
        Me.GroupBox3.Controls.Add(Me.Fibu_kassenbuch_excelComboBox)
        Me.GroupBox3.Controls.Add(Fibu_kassenbuch_papierLabel)
        Me.GroupBox3.Controls.Add(Me.Fibu_kassenbuch_papierComboBox)
        Me.GroupBox3.Controls.Add(Me.Fibu_mahnwesen_mahnbescheidComboBox)
        Me.GroupBox3.Controls.Add(Me.Fibu_rechnungspruefungComboBox)
        Me.GroupBox3.Controls.Add(Me.Fibu_zahlungsverkehrComboBox)
        Me.GroupBox3.Controls.Add(Me.Fibu_kontenabstimmung_oplistenComboBox)
        Me.GroupBox3.Controls.Add(Me.Fibu_kassenbuch_bankComboBox)
        Me.GroupBox3.Controls.Add(Me.btnFibu)
        Me.GroupBox3.Controls.Add(Fibu_mahnwesen_mahnbescheidLabel)
        Me.GroupBox3.Controls.Add(Fibu_rechnungspruefungLabel)
        Me.GroupBox3.Controls.Add(Fibu_zahlungsverkehrLabel)
        Me.GroupBox3.Controls.Add(Fibu_kontenabstimmung_oplistenLabel)
        Me.GroupBox3.Controls.Add(Fibu_kassenbuch_bankLabel)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 530)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1236, 257)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rechnungswesen, Zahlungsverkehr"
        '
        'Fibu_kassenbuch_programmComboBox
        '
        Me.Fibu_kassenbuch_programmComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_kassenbuch_programm", True))
        Me.Fibu_kassenbuch_programmComboBox.FormattingEnabled = True
        Me.Fibu_kassenbuch_programmComboBox.Location = New System.Drawing.Point(162, 78)
        Me.Fibu_kassenbuch_programmComboBox.Name = "Fibu_kassenbuch_programmComboBox"
        Me.Fibu_kassenbuch_programmComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_kassenbuch_programmComboBox.TabIndex = 4
        '
        'Fibu_kassenbuch_excelComboBox
        '
        Me.Fibu_kassenbuch_excelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_kassenbuch_excel", True))
        Me.Fibu_kassenbuch_excelComboBox.FormattingEnabled = True
        Me.Fibu_kassenbuch_excelComboBox.Location = New System.Drawing.Point(1032, 30)
        Me.Fibu_kassenbuch_excelComboBox.Name = "Fibu_kassenbuch_excelComboBox"
        Me.Fibu_kassenbuch_excelComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_kassenbuch_excelComboBox.TabIndex = 3
        '
        'Fibu_kassenbuch_papierComboBox
        '
        Me.Fibu_kassenbuch_papierComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_kassenbuch_papier", True))
        Me.Fibu_kassenbuch_papierComboBox.FormattingEnabled = True
        Me.Fibu_kassenbuch_papierComboBox.Location = New System.Drawing.Point(601, 30)
        Me.Fibu_kassenbuch_papierComboBox.Name = "Fibu_kassenbuch_papierComboBox"
        Me.Fibu_kassenbuch_papierComboBox.Size = New System.Drawing.Size(172, 24)
        Me.Fibu_kassenbuch_papierComboBox.TabIndex = 2
        '
        'Fibu_mahnwesen_mahnbescheidComboBox
        '
        Me.Fibu_mahnwesen_mahnbescheidComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_mahnwesen_mahnbescheid", True))
        Me.Fibu_mahnwesen_mahnbescheidComboBox.FormattingEnabled = True
        Me.Fibu_mahnwesen_mahnbescheidComboBox.Location = New System.Drawing.Point(601, 134)
        Me.Fibu_mahnwesen_mahnbescheidComboBox.Name = "Fibu_mahnwesen_mahnbescheidComboBox"
        Me.Fibu_mahnwesen_mahnbescheidComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_mahnwesen_mahnbescheidComboBox.TabIndex = 8
        '
        'Fibu_rechnungspruefungComboBox
        '
        Me.Fibu_rechnungspruefungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_rechnungspruefung", True))
        Me.Fibu_rechnungspruefungComboBox.FormattingEnabled = True
        Me.Fibu_rechnungspruefungComboBox.Location = New System.Drawing.Point(162, 134)
        Me.Fibu_rechnungspruefungComboBox.Name = "Fibu_rechnungspruefungComboBox"
        Me.Fibu_rechnungspruefungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_rechnungspruefungComboBox.TabIndex = 7
        '
        'Fibu_zahlungsverkehrComboBox
        '
        Me.Fibu_zahlungsverkehrComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_zahlungsverkehr", True))
        Me.Fibu_zahlungsverkehrComboBox.FormattingEnabled = True
        Me.Fibu_zahlungsverkehrComboBox.Location = New System.Drawing.Point(1032, 78)
        Me.Fibu_zahlungsverkehrComboBox.Name = "Fibu_zahlungsverkehrComboBox"
        Me.Fibu_zahlungsverkehrComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_zahlungsverkehrComboBox.TabIndex = 6
        '
        'Fibu_kontenabstimmung_oplistenComboBox
        '
        Me.Fibu_kontenabstimmung_oplistenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_kontenabstimmung_oplisten", True))
        Me.Fibu_kontenabstimmung_oplistenComboBox.FormattingEnabled = True
        Me.Fibu_kontenabstimmung_oplistenComboBox.Location = New System.Drawing.Point(601, 81)
        Me.Fibu_kontenabstimmung_oplistenComboBox.Name = "Fibu_kontenabstimmung_oplistenComboBox"
        Me.Fibu_kontenabstimmung_oplistenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_kontenabstimmung_oplistenComboBox.TabIndex = 5
        '
        'Fibu_kassenbuch_bankComboBox
        '
        Me.Fibu_kassenbuch_bankComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_kassenbuch_bank", True))
        Me.Fibu_kassenbuch_bankComboBox.FormattingEnabled = True
        Me.Fibu_kassenbuch_bankComboBox.Location = New System.Drawing.Point(162, 30)
        Me.Fibu_kassenbuch_bankComboBox.Name = "Fibu_kassenbuch_bankComboBox"
        Me.Fibu_kassenbuch_bankComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Fibu_kassenbuch_bankComboBox.TabIndex = 1
        '
        'btnFibu
        '
        Me.btnFibu.BackColor = System.Drawing.Color.Wheat
        Me.btnFibu.Location = New System.Drawing.Point(553, 177)
        Me.btnFibu.Name = "btnFibu"
        Me.btnFibu.Size = New System.Drawing.Size(203, 60)
        Me.btnFibu.TabIndex = 17
        Me.btnFibu.Text = "Kenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finanzbuchhaltung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnFibu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Fibu_softwareLabel)
        Me.GroupBox1.Controls.Add(Me.Fibu_softwareListBox)
        Me.GroupBox1.Controls.Add(Me.Label147)
        Me.GroupBox1.Controls.Add(Me.Fibu_sonstigeTextBox)
        Me.GroupBox1.Controls.Add(Me.Fibu_erfahrungListBox)
        Me.GroupBox1.Controls.Add(Me.Label144)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1236, 149)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Fibu_softwareListBox
        '
        Me.Fibu_softwareListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bewerber_fibuBindingSource, "fibu_software", True))
        Me.Fibu_softwareListBox.FormattingEnabled = True
        Me.Fibu_softwareListBox.ItemHeight = 16
        Me.Fibu_softwareListBox.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Lexware", "KHK Sage", "AS 400", "andere"})
        Me.Fibu_softwareListBox.Location = New System.Drawing.Point(686, 27)
        Me.Fibu_softwareListBox.Name = "Fibu_softwareListBox"
        Me.Fibu_softwareListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Fibu_softwareListBox.Size = New System.Drawing.Size(186, 84)
        Me.Fibu_softwareListBox.TabIndex = 2
        '
        'Label147
        '
        Me.Label147.AutoSize = True
        Me.Label147.Location = New System.Drawing.Point(888, 30)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(142, 32)
        Me.Label147.TabIndex = 4
        Me.Label147.Text = "Sonstige Buch-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "haltungstätigkeiten:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Fibu_sonstigeTextBox
        '
        Me.Fibu_sonstigeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_fibuBindingSource, "fibu_sonstige", True))
        Me.Fibu_sonstigeTextBox.Location = New System.Drawing.Point(1049, 27)
        Me.Fibu_sonstigeTextBox.Multiline = True
        Me.Fibu_sonstigeTextBox.Name = "Fibu_sonstigeTextBox"
        Me.Fibu_sonstigeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Fibu_sonstigeTextBox.Size = New System.Drawing.Size(174, 94)
        Me.Fibu_sonstigeTextBox.TabIndex = 3
        '
        'Fibu_erfahrungListBox
        '
        Me.Fibu_erfahrungListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bewerber_fibuBindingSource, "fibu_erfahrung", True))
        Me.Fibu_erfahrungListBox.FormattingEnabled = True
        Me.Fibu_erfahrungListBox.ItemHeight = 16
        Me.Fibu_erfahrungListBox.Items.AddRange(New Object() {"Steuerberater", "Wirtschaftsprüfer", "vereidigter Buchprüfer", "Buchhaltungsabteilung", "selbständiger Buchhalter", "Wohnungsbaugesellschaft"})
        Me.Fibu_erfahrungListBox.Location = New System.Drawing.Point(268, 27)
        Me.Fibu_erfahrungListBox.Name = "Fibu_erfahrungListBox"
        Me.Fibu_erfahrungListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Fibu_erfahrungListBox.Size = New System.Drawing.Size(203, 84)
        Me.Fibu_erfahrungListBox.TabIndex = 1
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.Location = New System.Drawing.Point(6, 27)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(260, 48)
        Me.Label144.TabIndex = 1
        Me.Label144.Text = "Wo haben Sie Ihre buchhalterischen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "oder Ihre Abschlusskenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bereits beruf" & _
    "lich angewendet?"
        '
        'Bewerber_fibuTableAdapter
        '
        Me.Bewerber_fibuTableAdapter.ClearBeforeFill = True
        '
        'frmFinanzbuchhaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1256, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmFinanzbuchhaltung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Finanzbuchhaltung"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Bewerber_fibuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label144 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label147 As System.Windows.Forms.Label
    Friend WithEvents Fibu_sonstigeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fibu_erfahrungListBox As System.Windows.Forms.ListBox
    Friend WithEvents btnFibu As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fibu_softwareListBox As System.Windows.Forms.ListBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Fibu_bwaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_abschlussComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_anlagenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_sachkontenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_kreditorenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_debitorenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_mahnwesen_mahnbescheidComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_rechnungspruefungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_zahlungsverkehrComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_kontenabstimmung_oplistenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_kassenbuch_bankComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_bilanzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bewerber_fibuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_fibuTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_fibuTableAdapter
    Friend WithEvents Fibu_dateneingabeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_kontieren_selbständigComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_immobilienComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_reisekosten_buchhaltungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_reisekosten_abrechnungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Fibu_kassenbuch_programmComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_kassenbuch_excelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_kassenbuch_papierComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Fibu_kontenrahmenListBox As System.Windows.Forms.ListBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSteuerfachangestellte
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
        Dim Steuerfachang_abschluss_wannLabel As System.Windows.Forms.Label
        Dim Steuerfachang_letzte_anstellung_von_bisLabel As System.Windows.Forms.Label
        Dim Steuerfachang_woLabel As System.Windows.Forms.Label
        Dim Steuerfachang_finanzbuchhaltungLabel As System.Windows.Forms.Label
        Dim Steuerfachang_abschlüsseLabel As System.Windows.Forms.Label
        Dim Steuerfachang_lohnabrechnungLabel As System.Windows.Forms.Label
        Dim Steuerfachang_lohnbuchhaltungLabel As System.Windows.Forms.Label
        Dim Steuerfachang_rechnungswesenLabel As System.Windows.Forms.Label
        Dim Steuerfachang_korrespondenzLabel As System.Windows.Forms.Label
        Dim Steuerfachang_rechtsbehelfeLabel As System.Windows.Forms.Label
        Dim Steuerfachang_mandantenbetreuungLabel As System.Windows.Forms.Label
        Dim Steuerfachang_softwareLabel As System.Windows.Forms.Label
        Dim Steuerfachang_sonstigeLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSteuerfachangestellte = New System.Windows.Forms.Button()
        Me.Steuerfachang_sonstigeTextBox = New System.Windows.Forms.TextBox()
        Me.Bew_steuerfachangestellteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Steuerfachang_softwareListBox = New System.Windows.Forms.ListBox()
        Me.Steuerfachang_mandantenbetreuungComboBox = New System.Windows.Forms.ComboBox()
        Me.Steuerfachang_rechtsbehelfeComboBox = New System.Windows.Forms.ComboBox()
        Me.Steuerfachang_korrespondenzComboBox = New System.Windows.Forms.ComboBox()
        Me.Steuerfachang_rechnungswesenComboBox = New System.Windows.Forms.ComboBox()
        Me.Steuerfachang_lohnbuchhaltungComboBox = New System.Windows.Forms.ComboBox()
        Me.Steuerfachang_lohnabrechnungComboBox = New System.Windows.Forms.ComboBox()
        Me.Steuerfachang_abschlüsseComboBox = New System.Windows.Forms.ComboBox()
        Me.Steuerfachang_finanzbuchhaltungComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Steuerfachang_woListBox = New System.Windows.Forms.ListBox()
        Me.Steuerfachang_letzte_anstellung_von_bisTextBox = New System.Windows.Forms.TextBox()
        Me.Steuerfachang_abschluss_wannTextBox = New System.Windows.Forms.TextBox()
        Me.Bew_steuerfachangestellteTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bew_steuerfachangestellteTableAdapter()
        Steuerfachang_abschluss_wannLabel = New System.Windows.Forms.Label()
        Steuerfachang_letzte_anstellung_von_bisLabel = New System.Windows.Forms.Label()
        Steuerfachang_woLabel = New System.Windows.Forms.Label()
        Steuerfachang_finanzbuchhaltungLabel = New System.Windows.Forms.Label()
        Steuerfachang_abschlüsseLabel = New System.Windows.Forms.Label()
        Steuerfachang_lohnabrechnungLabel = New System.Windows.Forms.Label()
        Steuerfachang_lohnbuchhaltungLabel = New System.Windows.Forms.Label()
        Steuerfachang_rechnungswesenLabel = New System.Windows.Forms.Label()
        Steuerfachang_korrespondenzLabel = New System.Windows.Forms.Label()
        Steuerfachang_rechtsbehelfeLabel = New System.Windows.Forms.Label()
        Steuerfachang_mandantenbetreuungLabel = New System.Windows.Forms.Label()
        Steuerfachang_softwareLabel = New System.Windows.Forms.Label()
        Steuerfachang_sonstigeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Bew_steuerfachangestellteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Steuerfachang_abschluss_wannLabel
        '
        Steuerfachang_abschluss_wannLabel.AutoSize = True
        Steuerfachang_abschluss_wannLabel.Location = New System.Drawing.Point(6, 28)
        Steuerfachang_abschluss_wannLabel.Name = "Steuerfachang_abschluss_wannLabel"
        Steuerfachang_abschluss_wannLabel.Size = New System.Drawing.Size(163, 32)
        Steuerfachang_abschluss_wannLabel.TabIndex = 0
        Steuerfachang_abschluss_wannLabel.Text = "Wenn haben Sie Ihren " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abschluß gemacht?"
        '
        'Steuerfachang_letzte_anstellung_von_bisLabel
        '
        Steuerfachang_letzte_anstellung_von_bisLabel.AutoSize = True
        Steuerfachang_letzte_anstellung_von_bisLabel.Location = New System.Drawing.Point(418, 28)
        Steuerfachang_letzte_anstellung_von_bisLabel.Name = "Steuerfachang_letzte_anstellung_von_bisLabel"
        Steuerfachang_letzte_anstellung_von_bisLabel.Size = New System.Drawing.Size(180, 48)
        Steuerfachang_letzte_anstellung_von_bisLabel.TabIndex = 2
        Steuerfachang_letzte_anstellung_von_bisLabel.Text = "Ihre letzte Anstellung als " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Steuerfachangestellte/r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "von - bis:"
        '
        'Steuerfachang_woLabel
        '
        Steuerfachang_woLabel.AutoSize = True
        Steuerfachang_woLabel.Location = New System.Drawing.Point(891, 28)
        Steuerfachang_woLabel.Name = "Steuerfachang_woLabel"
        Steuerfachang_woLabel.Size = New System.Drawing.Size(164, 64)
        Steuerfachang_woLabel.TabIndex = 4
        Steuerfachang_woLabel.Text = "Wo haben Sie als " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Steuerfachangestellte/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "gearbeitet (Mehrfach-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "auswahl möglich" & _
    ")?"
        '
        'Steuerfachang_finanzbuchhaltungLabel
        '
        Steuerfachang_finanzbuchhaltungLabel.AutoSize = True
        Steuerfachang_finanzbuchhaltungLabel.Location = New System.Drawing.Point(6, 27)
        Steuerfachang_finanzbuchhaltungLabel.Name = "Steuerfachang_finanzbuchhaltungLabel"
        Steuerfachang_finanzbuchhaltungLabel.Size = New System.Drawing.Size(140, 16)
        Steuerfachang_finanzbuchhaltungLabel.TabIndex = 0
        Steuerfachang_finanzbuchhaltungLabel.Text = "Finanzbuchhaltung:"
        '
        'Steuerfachang_abschlüsseLabel
        '
        Steuerfachang_abschlüsseLabel.AutoSize = True
        Steuerfachang_abschlüsseLabel.Location = New System.Drawing.Point(544, 27)
        Steuerfachang_abschlüsseLabel.Name = "Steuerfachang_abschlüsseLabel"
        Steuerfachang_abschlüsseLabel.Size = New System.Drawing.Size(92, 16)
        Steuerfachang_abschlüsseLabel.TabIndex = 2
        Steuerfachang_abschlüsseLabel.Text = "Abschlüsse:"
        '
        'Steuerfachang_lohnabrechnungLabel
        '
        Steuerfachang_lohnabrechnungLabel.AutoSize = True
        Steuerfachang_lohnabrechnungLabel.Location = New System.Drawing.Point(905, 27)
        Steuerfachang_lohnabrechnungLabel.Name = "Steuerfachang_lohnabrechnungLabel"
        Steuerfachang_lohnabrechnungLabel.Size = New System.Drawing.Size(126, 16)
        Steuerfachang_lohnabrechnungLabel.TabIndex = 4
        Steuerfachang_lohnabrechnungLabel.Text = "Lohnabrechnung:"
        '
        'Steuerfachang_lohnbuchhaltungLabel
        '
        Steuerfachang_lohnbuchhaltungLabel.AutoSize = True
        Steuerfachang_lohnbuchhaltungLabel.Location = New System.Drawing.Point(6, 85)
        Steuerfachang_lohnbuchhaltungLabel.Name = "Steuerfachang_lohnbuchhaltungLabel"
        Steuerfachang_lohnbuchhaltungLabel.Size = New System.Drawing.Size(128, 16)
        Steuerfachang_lohnbuchhaltungLabel.TabIndex = 6
        Steuerfachang_lohnbuchhaltungLabel.Text = "Lohnbuchhaltung:"
        '
        'Steuerfachang_rechnungswesenLabel
        '
        Steuerfachang_rechnungswesenLabel.AutoSize = True
        Steuerfachang_rechnungswesenLabel.Location = New System.Drawing.Point(501, 85)
        Steuerfachang_rechnungswesenLabel.Name = "Steuerfachang_rechnungswesenLabel"
        Steuerfachang_rechnungswesenLabel.Size = New System.Drawing.Size(133, 16)
        Steuerfachang_rechnungswesenLabel.TabIndex = 8
        Steuerfachang_rechnungswesenLabel.Text = "Rechnungswesen:"
        '
        'Steuerfachang_korrespondenzLabel
        '
        Steuerfachang_korrespondenzLabel.AutoSize = True
        Steuerfachang_korrespondenzLabel.Location = New System.Drawing.Point(905, 85)
        Steuerfachang_korrespondenzLabel.Name = "Steuerfachang_korrespondenzLabel"
        Steuerfachang_korrespondenzLabel.Size = New System.Drawing.Size(116, 16)
        Steuerfachang_korrespondenzLabel.TabIndex = 10
        Steuerfachang_korrespondenzLabel.Text = "Korrespondenz:"
        '
        'Steuerfachang_rechtsbehelfeLabel
        '
        Steuerfachang_rechtsbehelfeLabel.AutoSize = True
        Steuerfachang_rechtsbehelfeLabel.Location = New System.Drawing.Point(510, 138)
        Steuerfachang_rechtsbehelfeLabel.Name = "Steuerfachang_rechtsbehelfeLabel"
        Steuerfachang_rechtsbehelfeLabel.Size = New System.Drawing.Size(112, 16)
        Steuerfachang_rechtsbehelfeLabel.TabIndex = 12
        Steuerfachang_rechtsbehelfeLabel.Text = "Rechtsbehelfe:"
        '
        'Steuerfachang_mandantenbetreuungLabel
        '
        Steuerfachang_mandantenbetreuungLabel.AutoSize = True
        Steuerfachang_mandantenbetreuungLabel.Location = New System.Drawing.Point(6, 138)
        Steuerfachang_mandantenbetreuungLabel.Name = "Steuerfachang_mandantenbetreuungLabel"
        Steuerfachang_mandantenbetreuungLabel.Size = New System.Drawing.Size(157, 16)
        Steuerfachang_mandantenbetreuungLabel.TabIndex = 14
        Steuerfachang_mandantenbetreuungLabel.Text = "Mandantenbetreuung:"
        '
        'Steuerfachang_softwareLabel
        '
        Steuerfachang_softwareLabel.AutoSize = True
        Steuerfachang_softwareLabel.Location = New System.Drawing.Point(6, 185)
        Steuerfachang_softwareLabel.Name = "Steuerfachang_softwareLabel"
        Steuerfachang_softwareLabel.Size = New System.Drawing.Size(170, 48)
        Steuerfachang_softwareLabel.TabIndex = 16
        Steuerfachang_softwareLabel.Text = "Software, mit der Sie in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "den letzten fünf Jahren " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "gearbeitet haben:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Steuerfachang_sonstigeLabel
        '
        Steuerfachang_sonstigeLabel.AutoSize = True
        Steuerfachang_sonstigeLabel.Location = New System.Drawing.Point(473, 185)
        Steuerfachang_sonstigeLabel.Name = "Steuerfachang_sonstigeLabel"
        Steuerfachang_sonstigeLabel.Size = New System.Drawing.Size(232, 32)
        Steuerfachang_sonstigeLabel.TabIndex = 18
        Steuerfachang_sonstigeLabel.Text = "Sonstige berufliche Erfahrungen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "als Steuerfachangestellte/r:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 523)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1247, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte als Steuerfachangestellte/r an." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.btnSteuerfachangestellte)
        Me.GroupBox2.Controls.Add(Steuerfachang_sonstigeLabel)
        Me.GroupBox2.Controls.Add(Me.Steuerfachang_sonstigeTextBox)
        Me.GroupBox2.Controls.Add(Steuerfachang_softwareLabel)
        Me.GroupBox2.Controls.Add(Me.Steuerfachang_softwareListBox)
        Me.GroupBox2.Controls.Add(Steuerfachang_mandantenbetreuungLabel)
        Me.GroupBox2.Controls.Add(Me.Steuerfachang_mandantenbetreuungComboBox)
        Me.GroupBox2.Controls.Add(Steuerfachang_rechtsbehelfeLabel)
        Me.GroupBox2.Controls.Add(Me.Steuerfachang_rechtsbehelfeComboBox)
        Me.GroupBox2.Controls.Add(Steuerfachang_korrespondenzLabel)
        Me.GroupBox2.Controls.Add(Me.Steuerfachang_korrespondenzComboBox)
        Me.GroupBox2.Controls.Add(Steuerfachang_rechnungswesenLabel)
        Me.GroupBox2.Controls.Add(Me.Steuerfachang_rechnungswesenComboBox)
        Me.GroupBox2.Controls.Add(Steuerfachang_lohnbuchhaltungLabel)
        Me.GroupBox2.Controls.Add(Me.Steuerfachang_lohnbuchhaltungComboBox)
        Me.GroupBox2.Controls.Add(Steuerfachang_lohnabrechnungLabel)
        Me.GroupBox2.Controls.Add(Me.Steuerfachang_lohnabrechnungComboBox)
        Me.GroupBox2.Controls.Add(Steuerfachang_abschlüsseLabel)
        Me.GroupBox2.Controls.Add(Me.Steuerfachang_abschlüsseComboBox)
        Me.GroupBox2.Controls.Add(Steuerfachang_finanzbuchhaltungLabel)
        Me.GroupBox2.Controls.Add(Me.Steuerfachang_finanzbuchhaltungComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1246, 344)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Berufliche Tätigkeiten"
        '
        'btnSteuerfachangestellte
        '
        Me.btnSteuerfachangestellte.BackColor = System.Drawing.Color.Wheat
        Me.btnSteuerfachangestellte.Location = New System.Drawing.Point(504, 274)
        Me.btnSteuerfachangestellte.Name = "btnSteuerfachangestellte"
        Me.btnSteuerfachangestellte.Size = New System.Drawing.Size(203, 60)
        Me.btnSteuerfachangestellte.TabIndex = 26
        Me.btnSteuerfachangestellte.Text = "Kenntnisse als " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Steuerfachangestellte/r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnSteuerfachangestellte.UseVisualStyleBackColor = False
        '
        'Steuerfachang_sonstigeTextBox
        '
        Me.Steuerfachang_sonstigeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_sonstige", True))
        Me.Steuerfachang_sonstigeTextBox.Location = New System.Drawing.Point(732, 182)
        Me.Steuerfachang_sonstigeTextBox.Multiline = True
        Me.Steuerfachang_sonstigeTextBox.Name = "Steuerfachang_sonstigeTextBox"
        Me.Steuerfachang_sonstigeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Steuerfachang_sonstigeTextBox.Size = New System.Drawing.Size(301, 109)
        Me.Steuerfachang_sonstigeTextBox.TabIndex = 10
        '
        'Bew_steuerfachangestellteBindingSource
        '
        Me.Bew_steuerfachangestellteBindingSource.DataMember = "bew_steuerfachangestellte"
        Me.Bew_steuerfachangestellteBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Steuerfachang_softwareListBox
        '
        Me.Steuerfachang_softwareListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_software", True))
        Me.Steuerfachang_softwareListBox.FormattingEnabled = True
        Me.Steuerfachang_softwareListBox.ItemHeight = 16
        Me.Steuerfachang_softwareListBox.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Addison Wesley", "Lexware", "KHK Sage", "AS 400", "Oracle", "andere"})
        Me.Steuerfachang_softwareListBox.Location = New System.Drawing.Point(182, 185)
        Me.Steuerfachang_softwareListBox.Name = "Steuerfachang_softwareListBox"
        Me.Steuerfachang_softwareListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Steuerfachang_softwareListBox.Size = New System.Drawing.Size(198, 100)
        Me.Steuerfachang_softwareListBox.TabIndex = 9
        '
        'Steuerfachang_mandantenbetreuungComboBox
        '
        Me.Steuerfachang_mandantenbetreuungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_mandantenbetreuung", True))
        Me.Steuerfachang_mandantenbetreuungComboBox.FormattingEnabled = True
        Me.Steuerfachang_mandantenbetreuungComboBox.Location = New System.Drawing.Point(182, 135)
        Me.Steuerfachang_mandantenbetreuungComboBox.Name = "Steuerfachang_mandantenbetreuungComboBox"
        Me.Steuerfachang_mandantenbetreuungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Steuerfachang_mandantenbetreuungComboBox.TabIndex = 7
        '
        'Steuerfachang_rechtsbehelfeComboBox
        '
        Me.Steuerfachang_rechtsbehelfeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_rechtsbehelfe", True))
        Me.Steuerfachang_rechtsbehelfeComboBox.FormattingEnabled = True
        Me.Steuerfachang_rechtsbehelfeComboBox.Location = New System.Drawing.Point(642, 135)
        Me.Steuerfachang_rechtsbehelfeComboBox.Name = "Steuerfachang_rechtsbehelfeComboBox"
        Me.Steuerfachang_rechtsbehelfeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Steuerfachang_rechtsbehelfeComboBox.TabIndex = 8
        '
        'Steuerfachang_korrespondenzComboBox
        '
        Me.Steuerfachang_korrespondenzComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_korrespondenz", True))
        Me.Steuerfachang_korrespondenzComboBox.FormattingEnabled = True
        Me.Steuerfachang_korrespondenzComboBox.Location = New System.Drawing.Point(1037, 82)
        Me.Steuerfachang_korrespondenzComboBox.Name = "Steuerfachang_korrespondenzComboBox"
        Me.Steuerfachang_korrespondenzComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Steuerfachang_korrespondenzComboBox.TabIndex = 6
        '
        'Steuerfachang_rechnungswesenComboBox
        '
        Me.Steuerfachang_rechnungswesenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_rechnungswesen", True))
        Me.Steuerfachang_rechnungswesenComboBox.FormattingEnabled = True
        Me.Steuerfachang_rechnungswesenComboBox.Location = New System.Drawing.Point(642, 82)
        Me.Steuerfachang_rechnungswesenComboBox.Name = "Steuerfachang_rechnungswesenComboBox"
        Me.Steuerfachang_rechnungswesenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Steuerfachang_rechnungswesenComboBox.TabIndex = 5
        '
        'Steuerfachang_lohnbuchhaltungComboBox
        '
        Me.Steuerfachang_lohnbuchhaltungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_lohnbuchhaltung", True))
        Me.Steuerfachang_lohnbuchhaltungComboBox.FormattingEnabled = True
        Me.Steuerfachang_lohnbuchhaltungComboBox.Location = New System.Drawing.Point(182, 82)
        Me.Steuerfachang_lohnbuchhaltungComboBox.Name = "Steuerfachang_lohnbuchhaltungComboBox"
        Me.Steuerfachang_lohnbuchhaltungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Steuerfachang_lohnbuchhaltungComboBox.TabIndex = 4
        '
        'Steuerfachang_lohnabrechnungComboBox
        '
        Me.Steuerfachang_lohnabrechnungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_lohnabrechnung", True))
        Me.Steuerfachang_lohnabrechnungComboBox.FormattingEnabled = True
        Me.Steuerfachang_lohnabrechnungComboBox.Location = New System.Drawing.Point(1037, 24)
        Me.Steuerfachang_lohnabrechnungComboBox.Name = "Steuerfachang_lohnabrechnungComboBox"
        Me.Steuerfachang_lohnabrechnungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Steuerfachang_lohnabrechnungComboBox.TabIndex = 3
        '
        'Steuerfachang_abschlüsseComboBox
        '
        Me.Steuerfachang_abschlüsseComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_abschlüsse", True))
        Me.Steuerfachang_abschlüsseComboBox.FormattingEnabled = True
        Me.Steuerfachang_abschlüsseComboBox.Location = New System.Drawing.Point(642, 24)
        Me.Steuerfachang_abschlüsseComboBox.Name = "Steuerfachang_abschlüsseComboBox"
        Me.Steuerfachang_abschlüsseComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Steuerfachang_abschlüsseComboBox.TabIndex = 2
        '
        'Steuerfachang_finanzbuchhaltungComboBox
        '
        Me.Steuerfachang_finanzbuchhaltungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_finanzbuchhaltung", True))
        Me.Steuerfachang_finanzbuchhaltungComboBox.FormattingEnabled = True
        Me.Steuerfachang_finanzbuchhaltungComboBox.Location = New System.Drawing.Point(182, 24)
        Me.Steuerfachang_finanzbuchhaltungComboBox.Name = "Steuerfachang_finanzbuchhaltungComboBox"
        Me.Steuerfachang_finanzbuchhaltungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Steuerfachang_finanzbuchhaltungComboBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Steuerfachang_woListBox)
        Me.GroupBox1.Controls.Add(Steuerfachang_woLabel)
        Me.GroupBox1.Controls.Add(Steuerfachang_letzte_anstellung_von_bisLabel)
        Me.GroupBox1.Controls.Add(Me.Steuerfachang_letzte_anstellung_von_bisTextBox)
        Me.GroupBox1.Controls.Add(Steuerfachang_abschluss_wannLabel)
        Me.GroupBox1.Controls.Add(Me.Steuerfachang_abschluss_wannTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1247, 138)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Berufserfahrung"
        '
        'Steuerfachang_woListBox
        '
        Me.Steuerfachang_woListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_wo", True))
        Me.Steuerfachang_woListBox.FormattingEnabled = True
        Me.Steuerfachang_woListBox.ItemHeight = 16
        Me.Steuerfachang_woListBox.Items.AddRange(New Object() {"Steuerberater", "Wirtschaftsprüfer", "vereidigter Buchprüfer", "Buchhaltungsabteilung", "selbständiger Buchhalter"})
        Me.Steuerfachang_woListBox.Location = New System.Drawing.Point(1060, 28)
        Me.Steuerfachang_woListBox.Name = "Steuerfachang_woListBox"
        Me.Steuerfachang_woListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Steuerfachang_woListBox.Size = New System.Drawing.Size(179, 84)
        Me.Steuerfachang_woListBox.TabIndex = 3
        '
        'Steuerfachang_letzte_anstellung_von_bisTextBox
        '
        Me.Steuerfachang_letzte_anstellung_von_bisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_letzte_anstellung_von_bis", True))
        Me.Steuerfachang_letzte_anstellung_von_bisTextBox.Location = New System.Drawing.Point(642, 38)
        Me.Steuerfachang_letzte_anstellung_von_bisTextBox.Name = "Steuerfachang_letzte_anstellung_von_bisTextBox"
        Me.Steuerfachang_letzte_anstellung_von_bisTextBox.Size = New System.Drawing.Size(205, 22)
        Me.Steuerfachang_letzte_anstellung_von_bisTextBox.TabIndex = 2
        '
        'Steuerfachang_abschluss_wannTextBox
        '
        Me.Steuerfachang_abschluss_wannTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bew_steuerfachangestellteBindingSource, "steuerfachang_abschluss_wann", True))
        Me.Steuerfachang_abschluss_wannTextBox.Location = New System.Drawing.Point(175, 38)
        Me.Steuerfachang_abschluss_wannTextBox.Name = "Steuerfachang_abschluss_wannTextBox"
        Me.Steuerfachang_abschluss_wannTextBox.Size = New System.Drawing.Size(211, 22)
        Me.Steuerfachang_abschluss_wannTextBox.TabIndex = 1
        '
        'Bew_steuerfachangestellteTableAdapter
        '
        Me.Bew_steuerfachangestellteTableAdapter.ClearBeforeFill = True
        '
        'frmSteuerfachangestellte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1265, 529)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmSteuerfachangestellte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Steuerfachangestellte"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Bew_steuerfachangestellteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Steuerfachang_letzte_anstellung_von_bisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Steuerfachang_abschluss_wannTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Steuerfachang_woListBox As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Steuerfachang_finanzbuchhaltungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Steuerfachang_softwareListBox As System.Windows.Forms.ListBox
    Friend WithEvents Steuerfachang_mandantenbetreuungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Steuerfachang_rechtsbehelfeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Steuerfachang_korrespondenzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Steuerfachang_rechnungswesenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Steuerfachang_lohnbuchhaltungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Steuerfachang_lohnabrechnungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Steuerfachang_abschlüsseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Steuerfachang_sonstigeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSteuerfachangestellte As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bew_steuerfachangestellteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bew_steuerfachangestellteTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bew_steuerfachangestellteTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRAE
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
        Dim Rae_sonstigesLabel As System.Windows.Forms.Label
        Dim Rae_sonstige_softwareLabel As System.Windows.Forms.Label
        Dim Rae_syndicusLabel As System.Windows.Forms.Label
        Dim Rae_rawinLabel As System.Windows.Forms.Label
        Dim Rae_renostarLabel As System.Windows.Forms.Label
        Dim Rae_lawfirmLabel As System.Windows.Forms.Label
        Dim Rae_advowareLabel As System.Windows.Forms.Label
        Dim Rae_ramicroLabel As System.Windows.Forms.Label
        Dim Rae_annotextLabel As System.Windows.Forms.Label
        Dim Rae_zwangsvollstreckungLabel As System.Windows.Forms.Label
        Dim Rae_schriftsatzLabel As System.Windows.Forms.Label
        Dim Rae_mahnverfahrenLabel As System.Windows.Forms.Label
        Dim Rae_korrespondenzLabel As System.Windows.Forms.Label
        Dim Rae_gerichtskostenLabel As System.Windows.Forms.Label
        Dim Rae_honorarLabel As System.Windows.Forms.Label
        Dim Rae_fristenkontrolleLabel As System.Windows.Forms.Label
        Dim Rae_mandantenbetreuungLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rae_sonstige_softwareTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_raeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Rae_syndicusComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_sonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.Rae_renostarComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_rawinComboBox = New System.Windows.Forms.ComboBox()
        Me.btnRA = New System.Windows.Forms.Button()
        Me.Rae_lawfirmComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_advowareComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_ramicroComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_annotextComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rae_zwangsvollstreckungComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_mahnverfahrenComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_gerichtskostenComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_honorarComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_mandantenbetreuungComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_fristenkontrolleComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_schriftsatzComboBox = New System.Windows.Forms.ComboBox()
        Me.Rae_korrespondenzComboBox = New System.Windows.Forms.ComboBox()
        Me.Bewerber_raeTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_raeTableAdapter()
        Rae_sonstigesLabel = New System.Windows.Forms.Label()
        Rae_sonstige_softwareLabel = New System.Windows.Forms.Label()
        Rae_syndicusLabel = New System.Windows.Forms.Label()
        Rae_rawinLabel = New System.Windows.Forms.Label()
        Rae_renostarLabel = New System.Windows.Forms.Label()
        Rae_lawfirmLabel = New System.Windows.Forms.Label()
        Rae_advowareLabel = New System.Windows.Forms.Label()
        Rae_ramicroLabel = New System.Windows.Forms.Label()
        Rae_annotextLabel = New System.Windows.Forms.Label()
        Rae_zwangsvollstreckungLabel = New System.Windows.Forms.Label()
        Rae_schriftsatzLabel = New System.Windows.Forms.Label()
        Rae_mahnverfahrenLabel = New System.Windows.Forms.Label()
        Rae_korrespondenzLabel = New System.Windows.Forms.Label()
        Rae_gerichtskostenLabel = New System.Windows.Forms.Label()
        Rae_honorarLabel = New System.Windows.Forms.Label()
        Rae_fristenkontrolleLabel = New System.Windows.Forms.Label()
        Rae_mandantenbetreuungLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Bewerber_raeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rae_sonstigesLabel
        '
        Rae_sonstigesLabel.AutoSize = True
        Rae_sonstigesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rae_sonstigesLabel.Location = New System.Drawing.Point(11, 160)
        Rae_sonstigesLabel.Name = "Rae_sonstigesLabel"
        Rae_sonstigesLabel.Size = New System.Drawing.Size(82, 30)
        Rae_sonstigesLabel.TabIndex = 26
        Rae_sonstigesLabel.Text = "Sonstige " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tätigkeiten:"
        '
        'Rae_sonstige_softwareLabel
        '
        Rae_sonstige_softwareLabel.AutoSize = True
        Rae_sonstige_softwareLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rae_sonstige_softwareLabel.Location = New System.Drawing.Point(501, 163)
        Rae_sonstige_softwareLabel.Name = "Rae_sonstige_softwareLabel"
        Rae_sonstige_softwareLabel.Size = New System.Drawing.Size(67, 30)
        Rae_sonstige_softwareLabel.TabIndex = 25
        Rae_sonstige_softwareLabel.Text = "Sonstige " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Software:"
        '
        'Rae_syndicusLabel
        '
        Rae_syndicusLabel.AutoSize = True
        Rae_syndicusLabel.Location = New System.Drawing.Point(11, 123)
        Rae_syndicusLabel.Name = "Rae_syndicusLabel"
        Rae_syndicusLabel.Size = New System.Drawing.Size(75, 16)
        Rae_syndicusLabel.TabIndex = 26
        Rae_syndicusLabel.Text = "Syndicus:"
        '
        'Rae_rawinLabel
        '
        Rae_rawinLabel.AutoSize = True
        Rae_rawinLabel.Location = New System.Drawing.Point(503, 76)
        Rae_rawinLabel.Name = "Rae_rawinLabel"
        Rae_rawinLabel.Size = New System.Drawing.Size(59, 16)
        Rae_rawinLabel.TabIndex = 25
        Rae_rawinLabel.Text = "RAWin:"
        '
        'Rae_renostarLabel
        '
        Rae_renostarLabel.AutoSize = True
        Rae_renostarLabel.Location = New System.Drawing.Point(951, 76)
        Rae_renostarLabel.Name = "Rae_renostarLabel"
        Rae_renostarLabel.Size = New System.Drawing.Size(80, 16)
        Rae_renostarLabel.TabIndex = 25
        Rae_renostarLabel.Text = "ReNoStar:"
        '
        'Rae_lawfirmLabel
        '
        Rae_lawfirmLabel.AutoSize = True
        Rae_lawfirmLabel.Location = New System.Drawing.Point(11, 76)
        Rae_lawfirmLabel.Name = "Rae_lawfirmLabel"
        Rae_lawfirmLabel.Size = New System.Drawing.Size(69, 16)
        Rae_lawfirmLabel.TabIndex = 25
        Rae_lawfirmLabel.Text = "LawFirm:"
        '
        'Rae_advowareLabel
        '
        Rae_advowareLabel.AutoSize = True
        Rae_advowareLabel.Location = New System.Drawing.Point(952, 26)
        Rae_advowareLabel.Name = "Rae_advowareLabel"
        Rae_advowareLabel.Size = New System.Drawing.Size(81, 16)
        Rae_advowareLabel.TabIndex = 25
        Rae_advowareLabel.Text = "Advoware:"
        '
        'Rae_ramicroLabel
        '
        Rae_ramicroLabel.AutoSize = True
        Rae_ramicroLabel.Location = New System.Drawing.Point(503, 26)
        Rae_ramicroLabel.Name = "Rae_ramicroLabel"
        Rae_ramicroLabel.Size = New System.Drawing.Size(71, 16)
        Rae_ramicroLabel.TabIndex = 25
        Rae_ramicroLabel.Text = "RAMicro:"
        '
        'Rae_annotextLabel
        '
        Rae_annotextLabel.AutoSize = True
        Rae_annotextLabel.Location = New System.Drawing.Point(11, 26)
        Rae_annotextLabel.Name = "Rae_annotextLabel"
        Rae_annotextLabel.Size = New System.Drawing.Size(77, 16)
        Rae_annotextLabel.TabIndex = 25
        Rae_annotextLabel.Text = "AnnoText:"
        '
        'Rae_zwangsvollstreckungLabel
        '
        Rae_zwangsvollstreckungLabel.AutoSize = True
        Rae_zwangsvollstreckungLabel.Location = New System.Drawing.Point(429, 121)
        Rae_zwangsvollstreckungLabel.Name = "Rae_zwangsvollstreckungLabel"
        Rae_zwangsvollstreckungLabel.Size = New System.Drawing.Size(157, 16)
        Rae_zwangsvollstreckungLabel.TabIndex = 29
        Rae_zwangsvollstreckungLabel.Text = "Zwangsvollstreckung:"
        '
        'Rae_schriftsatzLabel
        '
        Rae_schriftsatzLabel.AutoSize = True
        Rae_schriftsatzLabel.Location = New System.Drawing.Point(487, 27)
        Rae_schriftsatzLabel.Name = "Rae_schriftsatzLabel"
        Rae_schriftsatzLabel.Size = New System.Drawing.Size(92, 16)
        Rae_schriftsatzLabel.TabIndex = 24
        Rae_schriftsatzLabel.Text = "Schriftsätze:"
        '
        'Rae_mahnverfahrenLabel
        '
        Rae_mahnverfahrenLabel.AutoSize = True
        Rae_mahnverfahrenLabel.Location = New System.Drawing.Point(6, 121)
        Rae_mahnverfahrenLabel.Name = "Rae_mahnverfahrenLabel"
        Rae_mahnverfahrenLabel.Size = New System.Drawing.Size(114, 16)
        Rae_mahnverfahrenLabel.TabIndex = 28
        Rae_mahnverfahrenLabel.Text = "Mahnverfahren:"
        '
        'Rae_korrespondenzLabel
        '
        Rae_korrespondenzLabel.AutoSize = True
        Rae_korrespondenzLabel.Location = New System.Drawing.Point(6, 27)
        Rae_korrespondenzLabel.Name = "Rae_korrespondenzLabel"
        Rae_korrespondenzLabel.Size = New System.Drawing.Size(116, 16)
        Rae_korrespondenzLabel.TabIndex = 24
        Rae_korrespondenzLabel.Text = "Korrespondenz:"
        '
        'Rae_gerichtskostenLabel
        '
        Rae_gerichtskostenLabel.AutoSize = True
        Rae_gerichtskostenLabel.Location = New System.Drawing.Point(918, 75)
        Rae_gerichtskostenLabel.Name = "Rae_gerichtskostenLabel"
        Rae_gerichtskostenLabel.Size = New System.Drawing.Size(115, 16)
        Rae_gerichtskostenLabel.TabIndex = 26
        Rae_gerichtskostenLabel.Text = "Gerichtskosten:"
        '
        'Rae_honorarLabel
        '
        Rae_honorarLabel.AutoSize = True
        Rae_honorarLabel.Location = New System.Drawing.Point(429, 75)
        Rae_honorarLabel.Name = "Rae_honorarLabel"
        Rae_honorarLabel.Size = New System.Drawing.Size(149, 16)
        Rae_honorarLabel.TabIndex = 27
        Rae_honorarLabel.Text = "Honorarberechnung:"
        '
        'Rae_fristenkontrolleLabel
        '
        Rae_fristenkontrolleLabel.AutoSize = True
        Rae_fristenkontrolleLabel.Location = New System.Drawing.Point(913, 27)
        Rae_fristenkontrolleLabel.Name = "Rae_fristenkontrolleLabel"
        Rae_fristenkontrolleLabel.Size = New System.Drawing.Size(119, 16)
        Rae_fristenkontrolleLabel.TabIndex = 24
        Rae_fristenkontrolleLabel.Text = "Fristenkontrolle:"
        '
        'Rae_mandantenbetreuungLabel
        '
        Rae_mandantenbetreuungLabel.AutoSize = True
        Rae_mandantenbetreuungLabel.Location = New System.Drawing.Point(6, 75)
        Rae_mandantenbetreuungLabel.Name = "Rae_mandantenbetreuungLabel"
        Rae_mandantenbetreuungLabel.Size = New System.Drawing.Size(157, 16)
        Rae_mandantenbetreuungLabel.TabIndex = 25
        Rae_mandantenbetreuungLabel.Text = "Mandantenbetreuung:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1258, 518)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1248, 28)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Bitte geben Sie Ihre Tätigkeitsschwerpunkte und Ihre Softwarekenntnisse aus den B" & _
    "ereichen Rechtsanwaltskanzlei und Notariat an." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Rae_sonstige_softwareTextBox)
        Me.GroupBox2.Controls.Add(Me.Rae_syndicusComboBox)
        Me.GroupBox2.Controls.Add(Me.Rae_sonstigesTextBox)
        Me.GroupBox2.Controls.Add(Me.Rae_renostarComboBox)
        Me.GroupBox2.Controls.Add(Me.Rae_rawinComboBox)
        Me.GroupBox2.Controls.Add(Rae_sonstigesLabel)
        Me.GroupBox2.Controls.Add(Rae_sonstige_softwareLabel)
        Me.GroupBox2.Controls.Add(Me.btnRA)
        Me.GroupBox2.Controls.Add(Me.Rae_lawfirmComboBox)
        Me.GroupBox2.Controls.Add(Me.Rae_advowareComboBox)
        Me.GroupBox2.Controls.Add(Me.Rae_ramicroComboBox)
        Me.GroupBox2.Controls.Add(Me.Rae_annotextComboBox1)
        Me.GroupBox2.Controls.Add(Rae_syndicusLabel)
        Me.GroupBox2.Controls.Add(Rae_rawinLabel)
        Me.GroupBox2.Controls.Add(Rae_renostarLabel)
        Me.GroupBox2.Controls.Add(Rae_lawfirmLabel)
        Me.GroupBox2.Controls.Add(Rae_advowareLabel)
        Me.GroupBox2.Controls.Add(Rae_ramicroLabel)
        Me.GroupBox2.Controls.Add(Rae_annotextLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1248, 367)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Anwalts- und Notariatssoftware:"
        '
        'Rae_sonstige_softwareTextBox
        '
        Me.Rae_sonstige_softwareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_sonstige_software", True))
        Me.Rae_sonstige_softwareTextBox.Location = New System.Drawing.Point(591, 165)
        Me.Rae_sonstige_softwareTextBox.Multiline = True
        Me.Rae_sonstige_softwareTextBox.Name = "Rae_sonstige_softwareTextBox"
        Me.Rae_sonstige_softwareTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Rae_sonstige_softwareTextBox.Size = New System.Drawing.Size(291, 152)
        Me.Rae_sonstige_softwareTextBox.TabIndex = 9
        '
        'Bewerber_raeBindingSource
        '
        Me.Bewerber_raeBindingSource.DataMember = "bewerber_rae"
        Me.Bewerber_raeBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rae_syndicusComboBox
        '
        Me.Rae_syndicusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_syndicus", True))
        Me.Rae_syndicusComboBox.FormattingEnabled = True
        Me.Rae_syndicusComboBox.Location = New System.Drawing.Point(175, 120)
        Me.Rae_syndicusComboBox.Name = "Rae_syndicusComboBox"
        Me.Rae_syndicusComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_syndicusComboBox.TabIndex = 7
        '
        'Rae_sonstigesTextBox
        '
        Me.Rae_sonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_sonstiges", True))
        Me.Rae_sonstigesTextBox.Location = New System.Drawing.Point(175, 165)
        Me.Rae_sonstigesTextBox.Multiline = True
        Me.Rae_sonstigesTextBox.Name = "Rae_sonstigesTextBox"
        Me.Rae_sonstigesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Rae_sonstigesTextBox.Size = New System.Drawing.Size(258, 152)
        Me.Rae_sonstigesTextBox.TabIndex = 8
        '
        'Rae_renostarComboBox
        '
        Me.Rae_renostarComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_renostar", True))
        Me.Rae_renostarComboBox.FormattingEnabled = True
        Me.Rae_renostarComboBox.Location = New System.Drawing.Point(1039, 73)
        Me.Rae_renostarComboBox.Name = "Rae_renostarComboBox"
        Me.Rae_renostarComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_renostarComboBox.TabIndex = 6
        '
        'Rae_rawinComboBox
        '
        Me.Rae_rawinComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_rawin", True))
        Me.Rae_rawinComboBox.FormattingEnabled = True
        Me.Rae_rawinComboBox.Location = New System.Drawing.Point(592, 73)
        Me.Rae_rawinComboBox.Name = "Rae_rawinComboBox"
        Me.Rae_rawinComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_rawinComboBox.TabIndex = 5
        '
        'btnRA
        '
        Me.btnRA.BackColor = System.Drawing.Color.Wheat
        Me.btnRA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRA.Location = New System.Drawing.Point(940, 212)
        Me.btnRA.Name = "btnRA"
        Me.btnRA.Size = New System.Drawing.Size(203, 60)
        Me.btnRA.TabIndex = 28
        Me.btnRA.Text = "Kenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rechtsanwaltskanzlei/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Notariat abspeichern" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnRA.UseVisualStyleBackColor = False
        '
        'Rae_lawfirmComboBox
        '
        Me.Rae_lawfirmComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_lawfirm", True))
        Me.Rae_lawfirmComboBox.FormattingEnabled = True
        Me.Rae_lawfirmComboBox.Location = New System.Drawing.Point(175, 73)
        Me.Rae_lawfirmComboBox.Name = "Rae_lawfirmComboBox"
        Me.Rae_lawfirmComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_lawfirmComboBox.TabIndex = 4
        '
        'Rae_advowareComboBox
        '
        Me.Rae_advowareComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_advoware", True))
        Me.Rae_advowareComboBox.FormattingEnabled = True
        Me.Rae_advowareComboBox.Location = New System.Drawing.Point(1038, 23)
        Me.Rae_advowareComboBox.Name = "Rae_advowareComboBox"
        Me.Rae_advowareComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_advowareComboBox.TabIndex = 3
        '
        'Rae_ramicroComboBox
        '
        Me.Rae_ramicroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_ramicro", True))
        Me.Rae_ramicroComboBox.FormattingEnabled = True
        Me.Rae_ramicroComboBox.Location = New System.Drawing.Point(592, 23)
        Me.Rae_ramicroComboBox.Name = "Rae_ramicroComboBox"
        Me.Rae_ramicroComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_ramicroComboBox.TabIndex = 2
        '
        'Rae_annotextComboBox1
        '
        Me.Rae_annotextComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_annotext", True))
        Me.Rae_annotextComboBox1.FormattingEnabled = True
        Me.Rae_annotextComboBox1.Location = New System.Drawing.Point(175, 23)
        Me.Rae_annotextComboBox1.Name = "Rae_annotextComboBox1"
        Me.Rae_annotextComboBox1.Size = New System.Drawing.Size(174, 24)
        Me.Rae_annotextComboBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Rae_zwangsvollstreckungComboBox)
        Me.GroupBox1.Controls.Add(Me.Rae_mahnverfahrenComboBox)
        Me.GroupBox1.Controls.Add(Me.Rae_gerichtskostenComboBox)
        Me.GroupBox1.Controls.Add(Me.Rae_honorarComboBox)
        Me.GroupBox1.Controls.Add(Me.Rae_mandantenbetreuungComboBox)
        Me.GroupBox1.Controls.Add(Me.Rae_fristenkontrolleComboBox)
        Me.GroupBox1.Controls.Add(Me.Rae_schriftsatzComboBox)
        Me.GroupBox1.Controls.Add(Me.Rae_korrespondenzComboBox)
        Me.GroupBox1.Controls.Add(Rae_zwangsvollstreckungLabel)
        Me.GroupBox1.Controls.Add(Rae_schriftsatzLabel)
        Me.GroupBox1.Controls.Add(Rae_mahnverfahrenLabel)
        Me.GroupBox1.Controls.Add(Rae_korrespondenzLabel)
        Me.GroupBox1.Controls.Add(Rae_gerichtskostenLabel)
        Me.GroupBox1.Controls.Add(Rae_honorarLabel)
        Me.GroupBox1.Controls.Add(Rae_fristenkontrolleLabel)
        Me.GroupBox1.Controls.Add(Rae_mandantenbetreuungLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1248, 153)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tätigkeitsschwerpunkte:"
        '
        'Rae_zwangsvollstreckungComboBox
        '
        Me.Rae_zwangsvollstreckungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_zwangsvollstreckung", True))
        Me.Rae_zwangsvollstreckungComboBox.FormattingEnabled = True
        Me.Rae_zwangsvollstreckungComboBox.Location = New System.Drawing.Point(592, 118)
        Me.Rae_zwangsvollstreckungComboBox.Name = "Rae_zwangsvollstreckungComboBox"
        Me.Rae_zwangsvollstreckungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_zwangsvollstreckungComboBox.TabIndex = 8
        '
        'Rae_mahnverfahrenComboBox
        '
        Me.Rae_mahnverfahrenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_mahnverfahren", True))
        Me.Rae_mahnverfahrenComboBox.FormattingEnabled = True
        Me.Rae_mahnverfahrenComboBox.Location = New System.Drawing.Point(175, 118)
        Me.Rae_mahnverfahrenComboBox.Name = "Rae_mahnverfahrenComboBox"
        Me.Rae_mahnverfahrenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_mahnverfahrenComboBox.TabIndex = 7
        '
        'Rae_gerichtskostenComboBox
        '
        Me.Rae_gerichtskostenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_gerichtskosten", True))
        Me.Rae_gerichtskostenComboBox.FormattingEnabled = True
        Me.Rae_gerichtskostenComboBox.Location = New System.Drawing.Point(1039, 72)
        Me.Rae_gerichtskostenComboBox.Name = "Rae_gerichtskostenComboBox"
        Me.Rae_gerichtskostenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_gerichtskostenComboBox.TabIndex = 6
        '
        'Rae_honorarComboBox
        '
        Me.Rae_honorarComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_honorar", True))
        Me.Rae_honorarComboBox.FormattingEnabled = True
        Me.Rae_honorarComboBox.Location = New System.Drawing.Point(592, 72)
        Me.Rae_honorarComboBox.Name = "Rae_honorarComboBox"
        Me.Rae_honorarComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_honorarComboBox.TabIndex = 5
        '
        'Rae_mandantenbetreuungComboBox
        '
        Me.Rae_mandantenbetreuungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_mandantenbetreuung", True))
        Me.Rae_mandantenbetreuungComboBox.FormattingEnabled = True
        Me.Rae_mandantenbetreuungComboBox.Location = New System.Drawing.Point(175, 72)
        Me.Rae_mandantenbetreuungComboBox.Name = "Rae_mandantenbetreuungComboBox"
        Me.Rae_mandantenbetreuungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_mandantenbetreuungComboBox.TabIndex = 4
        '
        'Rae_fristenkontrolleComboBox
        '
        Me.Rae_fristenkontrolleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_fristenkontrolle", True))
        Me.Rae_fristenkontrolleComboBox.FormattingEnabled = True
        Me.Rae_fristenkontrolleComboBox.Location = New System.Drawing.Point(1038, 24)
        Me.Rae_fristenkontrolleComboBox.Name = "Rae_fristenkontrolleComboBox"
        Me.Rae_fristenkontrolleComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_fristenkontrolleComboBox.TabIndex = 3
        '
        'Rae_schriftsatzComboBox
        '
        Me.Rae_schriftsatzComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_schriftsatz", True))
        Me.Rae_schriftsatzComboBox.FormattingEnabled = True
        Me.Rae_schriftsatzComboBox.Location = New System.Drawing.Point(592, 24)
        Me.Rae_schriftsatzComboBox.Name = "Rae_schriftsatzComboBox"
        Me.Rae_schriftsatzComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_schriftsatzComboBox.TabIndex = 2
        '
        'Rae_korrespondenzComboBox
        '
        Me.Rae_korrespondenzComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_raeBindingSource, "rae_korrespondenz", True))
        Me.Rae_korrespondenzComboBox.FormattingEnabled = True
        Me.Rae_korrespondenzComboBox.Location = New System.Drawing.Point(175, 24)
        Me.Rae_korrespondenzComboBox.Name = "Rae_korrespondenzComboBox"
        Me.Rae_korrespondenzComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Rae_korrespondenzComboBox.TabIndex = 1
        '
        'Bewerber_raeTableAdapter
        '
        Me.Bewerber_raeTableAdapter.ClearBeforeFill = True
        '
        'frmRAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1261, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRAE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rechtsanwaltsfachangestellte"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Bewerber_raeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRA As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
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
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rae_lawfirmComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_advowareComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_ramicroComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_annotextComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_zwangsvollstreckungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_mahnverfahrenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_gerichtskostenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_honorarComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_mandantenbetreuungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_fristenkontrolleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_schriftsatzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_korrespondenzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_sonstige_softwareTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rae_sonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rae_syndicusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_renostarComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rae_rawinComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bewerber_raeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_raeTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_raeTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlling
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
        Dim Controlling_kennzahlenLabel As System.Windows.Forms.Label
        Dim Controlling_kostenrechnungLabel As System.Windows.Forms.Label
        Dim Controlling_deckungsbeitragsrechnungLabel As System.Windows.Forms.Label
        Dim Controlling_budgetierungLabel As System.Windows.Forms.Label
        Dim Controlling_cashmanagementLabel As System.Windows.Forms.Label
        Dim Controlling_forecastLabel As System.Windows.Forms.Label
        Dim Controlling_reportingLabel As System.Windows.Forms.Label
        Dim Controlling_report_controlling_systemeLabel As System.Windows.Forms.Label
        Dim Controlling_analysen_statistikLabel As System.Windows.Forms.Label
        Dim Controlling_swotLabel As System.Windows.Forms.Label
        Dim Controlling_abschluesse_hgbLabel As System.Windows.Forms.Label
        Dim Controlling_abschluesse_ifrsLabel As System.Windows.Forms.Label
        Dim Controlling_finanz_usgaapLabel As System.Windows.Forms.Label
        Dim Controlling_abschluesse_ukgaapLabel As System.Windows.Forms.Label
        Dim Controlling_abschluesse_nlgaapLabel As System.Windows.Forms.Label
        Dim Controlling_soxxLabel As System.Windows.Forms.Label
        Dim Controlling_report_controlling_systemeLabel1 As System.Windows.Forms.Label
        Dim Controlling_auswertungenLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnControlling = New System.Windows.Forms.Button()
        Me.Controlling_soxxComboBox = New System.Windows.Forms.ComboBox()
        Me.Bewerber_controllingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Controlling_abschluesse_nlgaapComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_abschluesse_ukgaapComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_finanz_usgaapComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_abschluesse_ifrsComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_abschluesse_hgbComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Controlling_auswertungenComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_swotComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_analysen_statistikComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_report_controlling_systemeComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_reportingComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_forecastComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_cashmanagementComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_budgetierungComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_deckungsbeitragsrechnungComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_kostenrechnungComboBox = New System.Windows.Forms.ComboBox()
        Me.Controlling_kennzahlenComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Controlling_report_controlling_systemeListBox = New System.Windows.Forms.ListBox()
        Me.Controlling_sonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.Label149 = New System.Windows.Forms.Label()
        Me.Label148 = New System.Windows.Forms.Label()
        Me.Controlling_typListBox = New System.Windows.Forms.ListBox()
        Me.Bewerber_controllingTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_controllingTableAdapter()
        Controlling_kennzahlenLabel = New System.Windows.Forms.Label()
        Controlling_kostenrechnungLabel = New System.Windows.Forms.Label()
        Controlling_deckungsbeitragsrechnungLabel = New System.Windows.Forms.Label()
        Controlling_budgetierungLabel = New System.Windows.Forms.Label()
        Controlling_cashmanagementLabel = New System.Windows.Forms.Label()
        Controlling_forecastLabel = New System.Windows.Forms.Label()
        Controlling_reportingLabel = New System.Windows.Forms.Label()
        Controlling_report_controlling_systemeLabel = New System.Windows.Forms.Label()
        Controlling_analysen_statistikLabel = New System.Windows.Forms.Label()
        Controlling_swotLabel = New System.Windows.Forms.Label()
        Controlling_abschluesse_hgbLabel = New System.Windows.Forms.Label()
        Controlling_abschluesse_ifrsLabel = New System.Windows.Forms.Label()
        Controlling_finanz_usgaapLabel = New System.Windows.Forms.Label()
        Controlling_abschluesse_ukgaapLabel = New System.Windows.Forms.Label()
        Controlling_abschluesse_nlgaapLabel = New System.Windows.Forms.Label()
        Controlling_soxxLabel = New System.Windows.Forms.Label()
        Controlling_report_controlling_systemeLabel1 = New System.Windows.Forms.Label()
        Controlling_auswertungenLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Bewerber_controllingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Controlling_kennzahlenLabel
        '
        Controlling_kennzahlenLabel.AutoSize = True
        Controlling_kennzahlenLabel.Location = New System.Drawing.Point(6, 26)
        Controlling_kennzahlenLabel.Name = "Controlling_kennzahlenLabel"
        Controlling_kennzahlenLabel.Size = New System.Drawing.Size(91, 16)
        Controlling_kennzahlenLabel.TabIndex = 0
        Controlling_kennzahlenLabel.Text = "Kennzahlen:"
        '
        'Controlling_kostenrechnungLabel
        '
        Controlling_kostenrechnungLabel.AutoSize = True
        Controlling_kostenrechnungLabel.Location = New System.Drawing.Point(895, 27)
        Controlling_kostenrechnungLabel.Name = "Controlling_kostenrechnungLabel"
        Controlling_kostenrechnungLabel.Size = New System.Drawing.Size(122, 16)
        Controlling_kostenrechnungLabel.TabIndex = 2
        Controlling_kostenrechnungLabel.Text = "Kostenrechnung:"
        '
        'Controlling_deckungsbeitragsrechnungLabel
        '
        Controlling_deckungsbeitragsrechnungLabel.AutoSize = True
        Controlling_deckungsbeitragsrechnungLabel.Location = New System.Drawing.Point(436, 24)
        Controlling_deckungsbeitragsrechnungLabel.Name = "Controlling_deckungsbeitragsrechnungLabel"
        Controlling_deckungsbeitragsrechnungLabel.Size = New System.Drawing.Size(132, 32)
        Controlling_deckungsbeitragsrechnungLabel.TabIndex = 4
        Controlling_deckungsbeitragsrechnungLabel.Text = "Deckungs-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "beitragsrechnung:"
        '
        'Controlling_budgetierungLabel
        '
        Controlling_budgetierungLabel.AutoSize = True
        Controlling_budgetierungLabel.Location = New System.Drawing.Point(6, 76)
        Controlling_budgetierungLabel.Name = "Controlling_budgetierungLabel"
        Controlling_budgetierungLabel.Size = New System.Drawing.Size(138, 32)
        Controlling_budgetierungLabel.TabIndex = 6
        Controlling_budgetierungLabel.Text = "Budget-und" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Liquiditätsplanung:"
        '
        'Controlling_cashmanagementLabel
        '
        Controlling_cashmanagementLabel.AutoSize = True
        Controlling_cashmanagementLabel.Location = New System.Drawing.Point(436, 86)
        Controlling_cashmanagementLabel.Name = "Controlling_cashmanagementLabel"
        Controlling_cashmanagementLabel.Size = New System.Drawing.Size(136, 16)
        Controlling_cashmanagementLabel.TabIndex = 8
        Controlling_cashmanagementLabel.Text = "Cashmanagement:"
        '
        'Controlling_forecastLabel
        '
        Controlling_forecastLabel.AutoSize = True
        Controlling_forecastLabel.Location = New System.Drawing.Point(944, 86)
        Controlling_forecastLabel.Name = "Controlling_forecastLabel"
        Controlling_forecastLabel.Size = New System.Drawing.Size(73, 16)
        Controlling_forecastLabel.TabIndex = 10
        Controlling_forecastLabel.Text = "Forecast:"
        '
        'Controlling_reportingLabel
        '
        Controlling_reportingLabel.AutoSize = True
        Controlling_reportingLabel.Location = New System.Drawing.Point(6, 146)
        Controlling_reportingLabel.Name = "Controlling_reportingLabel"
        Controlling_reportingLabel.Size = New System.Drawing.Size(80, 16)
        Controlling_reportingLabel.TabIndex = 12
        Controlling_reportingLabel.Text = "Reporting:"
        '
        'Controlling_report_controlling_systemeLabel
        '
        Controlling_report_controlling_systemeLabel.AutoSize = True
        Controlling_report_controlling_systemeLabel.Location = New System.Drawing.Point(436, 136)
        Controlling_report_controlling_systemeLabel.Name = "Controlling_report_controlling_systemeLabel"
        Controlling_report_controlling_systemeLabel.Size = New System.Drawing.Size(144, 32)
        Controlling_report_controlling_systemeLabel.TabIndex = 14
        Controlling_report_controlling_systemeLabel.Text = "Reporting- und" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Controllingsysteme:"
        '
        'Controlling_analysen_statistikLabel
        '
        Controlling_analysen_statistikLabel.AutoSize = True
        Controlling_analysen_statistikLabel.Location = New System.Drawing.Point(914, 136)
        Controlling_analysen_statistikLabel.Name = "Controlling_analysen_statistikLabel"
        Controlling_analysen_statistikLabel.Size = New System.Drawing.Size(105, 32)
        Controlling_analysen_statistikLabel.TabIndex = 16
        Controlling_analysen_statistikLabel.Text = "Analysen und " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Statistiken:"
        '
        'Controlling_swotLabel
        '
        Controlling_swotLabel.AutoSize = True
        Controlling_swotLabel.Location = New System.Drawing.Point(6, 191)
        Controlling_swotLabel.Name = "Controlling_swotLabel"
        Controlling_swotLabel.Size = New System.Drawing.Size(57, 16)
        Controlling_swotLabel.TabIndex = 18
        Controlling_swotLabel.Text = "SWOT:"
        '
        'Controlling_abschluesse_hgbLabel
        '
        Controlling_abschluesse_hgbLabel.AutoSize = True
        Controlling_abschluesse_hgbLabel.Location = New System.Drawing.Point(6, 36)
        Controlling_abschluesse_hgbLabel.Name = "Controlling_abschluesse_hgbLabel"
        Controlling_abschluesse_hgbLabel.Size = New System.Drawing.Size(92, 32)
        Controlling_abschluesse_hgbLabel.TabIndex = 0
        Controlling_abschluesse_hgbLabel.Text = "Abschlüsse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nach HGB:"
        '
        'Controlling_abschluesse_ifrsLabel
        '
        Controlling_abschluesse_ifrsLabel.AutoSize = True
        Controlling_abschluesse_ifrsLabel.Location = New System.Drawing.Point(486, 29)
        Controlling_abschluesse_ifrsLabel.Name = "Controlling_abschluesse_ifrsLabel"
        Controlling_abschluesse_ifrsLabel.Size = New System.Drawing.Size(92, 32)
        Controlling_abschluesse_ifrsLabel.TabIndex = 2
        Controlling_abschluesse_ifrsLabel.Text = "Abschlüsse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nach IFRS:"
        '
        'Controlling_finanz_usgaapLabel
        '
        Controlling_finanz_usgaapLabel.AutoSize = True
        Controlling_finanz_usgaapLabel.Location = New System.Drawing.Point(905, 29)
        Controlling_finanz_usgaapLabel.Name = "Controlling_finanz_usgaapLabel"
        Controlling_finanz_usgaapLabel.Size = New System.Drawing.Size(116, 32)
        Controlling_finanz_usgaapLabel.TabIndex = 4
        Controlling_finanz_usgaapLabel.Text = "Abschlüsse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nach US-GAAP:"
        '
        'Controlling_abschluesse_ukgaapLabel
        '
        Controlling_abschluesse_ukgaapLabel.AutoSize = True
        Controlling_abschluesse_ukgaapLabel.Location = New System.Drawing.Point(464, 71)
        Controlling_abschluesse_ukgaapLabel.Name = "Controlling_abschluesse_ukgaapLabel"
        Controlling_abschluesse_ukgaapLabel.Size = New System.Drawing.Size(115, 32)
        Controlling_abschluesse_ukgaapLabel.TabIndex = 6
        Controlling_abschluesse_ukgaapLabel.Text = "Abschlüsse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nach UK-GAAP:"
        '
        'Controlling_abschluesse_nlgaapLabel
        '
        Controlling_abschluesse_nlgaapLabel.AutoSize = True
        Controlling_abschluesse_nlgaapLabel.Location = New System.Drawing.Point(906, 78)
        Controlling_abschluesse_nlgaapLabel.Name = "Controlling_abschluesse_nlgaapLabel"
        Controlling_abschluesse_nlgaapLabel.Size = New System.Drawing.Size(114, 32)
        Controlling_abschluesse_nlgaapLabel.TabIndex = 8
        Controlling_abschluesse_nlgaapLabel.Text = "Abschlüsse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nach NL-GAAP:"
        '
        'Controlling_soxxLabel
        '
        Controlling_soxxLabel.AutoSize = True
        Controlling_soxxLabel.Location = New System.Drawing.Point(6, 78)
        Controlling_soxxLabel.Name = "Controlling_soxxLabel"
        Controlling_soxxLabel.Size = New System.Drawing.Size(92, 32)
        Controlling_soxxLabel.TabIndex = 10
        Controlling_soxxLabel.Text = "Abschlüsse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nach SOXX:"
        '
        'Controlling_report_controlling_systemeLabel1
        '
        Controlling_report_controlling_systemeLabel1.AutoSize = True
        Controlling_report_controlling_systemeLabel1.Location = New System.Drawing.Point(930, 26)
        Controlling_report_controlling_systemeLabel1.Name = "Controlling_report_controlling_systemeLabel1"
        Controlling_report_controlling_systemeLabel1.Size = New System.Drawing.Size(148, 64)
        Controlling_report_controlling_systemeLabel1.TabIndex = 4
        Controlling_report_controlling_systemeLabel1.Text = "Erfahrung mit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Controllingsystemen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Mehrfachauswahl" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "möglich):"
        '
        'Controlling_auswertungenLabel
        '
        Controlling_auswertungenLabel.AutoSize = True
        Controlling_auswertungenLabel.Location = New System.Drawing.Point(436, 191)
        Controlling_auswertungenLabel.Name = "Controlling_auswertungenLabel"
        Controlling_auswertungenLabel.Size = New System.Drawing.Size(108, 16)
        Controlling_auswertungenLabel.TabIndex = 20
        Controlling_auswertungenLabel.Text = "Auswertungen:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1250, 624)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1234, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte im Controlling an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Controlling_soxxLabel)
        Me.GroupBox3.Controls.Add(Me.btnControlling)
        Me.GroupBox3.Controls.Add(Me.Controlling_soxxComboBox)
        Me.GroupBox3.Controls.Add(Controlling_abschluesse_nlgaapLabel)
        Me.GroupBox3.Controls.Add(Me.Controlling_abschluesse_nlgaapComboBox)
        Me.GroupBox3.Controls.Add(Controlling_abschluesse_ukgaapLabel)
        Me.GroupBox3.Controls.Add(Me.Controlling_abschluesse_ukgaapComboBox)
        Me.GroupBox3.Controls.Add(Controlling_finanz_usgaapLabel)
        Me.GroupBox3.Controls.Add(Me.Controlling_finanz_usgaapComboBox)
        Me.GroupBox3.Controls.Add(Controlling_abschluesse_ifrsLabel)
        Me.GroupBox3.Controls.Add(Me.Controlling_abschluesse_ifrsComboBox)
        Me.GroupBox3.Controls.Add(Controlling_abschluesse_hgbLabel)
        Me.GroupBox3.Controls.Add(Me.Controlling_abschluesse_hgbComboBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 419)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1234, 199)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Abschlüsse"
        '
        'btnControlling
        '
        Me.btnControlling.BackColor = System.Drawing.Color.Wheat
        Me.btnControlling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnControlling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControlling.Location = New System.Drawing.Point(515, 121)
        Me.btnControlling.Name = "btnControlling"
        Me.btnControlling.Size = New System.Drawing.Size(203, 60)
        Me.btnControlling.TabIndex = 28
        Me.btnControlling.Text = "Kenntnisse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Controlling" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnControlling.UseVisualStyleBackColor = False
        '
        'Controlling_soxxComboBox
        '
        Me.Controlling_soxxComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_soxx", True))
        Me.Controlling_soxxComboBox.FormattingEnabled = True
        Me.Controlling_soxxComboBox.Location = New System.Drawing.Point(152, 78)
        Me.Controlling_soxxComboBox.Name = "Controlling_soxxComboBox"
        Me.Controlling_soxxComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_soxxComboBox.TabIndex = 7
        '
        'Bewerber_controllingBindingSource
        '
        Me.Bewerber_controllingBindingSource.DataMember = "bewerber_controlling"
        Me.Bewerber_controllingBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Controlling_abschluesse_nlgaapComboBox
        '
        Me.Controlling_abschluesse_nlgaapComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_abschluesse_nlgaap", True))
        Me.Controlling_abschluesse_nlgaapComboBox.FormattingEnabled = True
        Me.Controlling_abschluesse_nlgaapComboBox.Location = New System.Drawing.Point(1030, 78)
        Me.Controlling_abschluesse_nlgaapComboBox.Name = "Controlling_abschluesse_nlgaapComboBox"
        Me.Controlling_abschluesse_nlgaapComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_abschluesse_nlgaapComboBox.TabIndex = 11
        '
        'Controlling_abschluesse_ukgaapComboBox
        '
        Me.Controlling_abschluesse_ukgaapComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_abschluesse_ukgaap", True))
        Me.Controlling_abschluesse_ukgaapComboBox.FormattingEnabled = True
        Me.Controlling_abschluesse_ukgaapComboBox.Location = New System.Drawing.Point(584, 78)
        Me.Controlling_abschluesse_ukgaapComboBox.Name = "Controlling_abschluesse_ukgaapComboBox"
        Me.Controlling_abschluesse_ukgaapComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_abschluesse_ukgaapComboBox.TabIndex = 9
        '
        'Controlling_finanz_usgaapComboBox
        '
        Me.Controlling_finanz_usgaapComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_finanz_usgaap", True))
        Me.Controlling_finanz_usgaapComboBox.FormattingEnabled = True
        Me.Controlling_finanz_usgaapComboBox.Location = New System.Drawing.Point(1030, 36)
        Me.Controlling_finanz_usgaapComboBox.Name = "Controlling_finanz_usgaapComboBox"
        Me.Controlling_finanz_usgaapComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_finanz_usgaapComboBox.TabIndex = 5
        '
        'Controlling_abschluesse_ifrsComboBox
        '
        Me.Controlling_abschluesse_ifrsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_abschluesse_ifrs", True))
        Me.Controlling_abschluesse_ifrsComboBox.FormattingEnabled = True
        Me.Controlling_abschluesse_ifrsComboBox.Location = New System.Drawing.Point(584, 36)
        Me.Controlling_abschluesse_ifrsComboBox.Name = "Controlling_abschluesse_ifrsComboBox"
        Me.Controlling_abschluesse_ifrsComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_abschluesse_ifrsComboBox.TabIndex = 3
        '
        'Controlling_abschluesse_hgbComboBox
        '
        Me.Controlling_abschluesse_hgbComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_abschluesse_hgb", True))
        Me.Controlling_abschluesse_hgbComboBox.FormattingEnabled = True
        Me.Controlling_abschluesse_hgbComboBox.Location = New System.Drawing.Point(152, 36)
        Me.Controlling_abschluesse_hgbComboBox.Name = "Controlling_abschluesse_hgbComboBox"
        Me.Controlling_abschluesse_hgbComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_abschluesse_hgbComboBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Controlling_auswertungenLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_auswertungenComboBox)
        Me.GroupBox2.Controls.Add(Controlling_swotLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_swotComboBox)
        Me.GroupBox2.Controls.Add(Controlling_analysen_statistikLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_analysen_statistikComboBox)
        Me.GroupBox2.Controls.Add(Controlling_report_controlling_systemeLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_report_controlling_systemeComboBox)
        Me.GroupBox2.Controls.Add(Controlling_reportingLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_reportingComboBox)
        Me.GroupBox2.Controls.Add(Controlling_forecastLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_forecastComboBox)
        Me.GroupBox2.Controls.Add(Controlling_cashmanagementLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_cashmanagementComboBox)
        Me.GroupBox2.Controls.Add(Controlling_budgetierungLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_budgetierungComboBox)
        Me.GroupBox2.Controls.Add(Controlling_deckungsbeitragsrechnungLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_deckungsbeitragsrechnungComboBox)
        Me.GroupBox2.Controls.Add(Controlling_kostenrechnungLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_kostenrechnungComboBox)
        Me.GroupBox2.Controls.Add(Controlling_kennzahlenLabel)
        Me.GroupBox2.Controls.Add(Me.Controlling_kennzahlenComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1234, 232)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controlling"
        '
        'Controlling_auswertungenComboBox
        '
        Me.Controlling_auswertungenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_auswertungen", True))
        Me.Controlling_auswertungenComboBox.FormattingEnabled = True
        Me.Controlling_auswertungenComboBox.Location = New System.Drawing.Point(584, 188)
        Me.Controlling_auswertungenComboBox.Name = "Controlling_auswertungenComboBox"
        Me.Controlling_auswertungenComboBox.Size = New System.Drawing.Size(172, 24)
        Me.Controlling_auswertungenComboBox.TabIndex = 21
        '
        'Controlling_swotComboBox
        '
        Me.Controlling_swotComboBox.FormattingEnabled = True
        Me.Controlling_swotComboBox.Location = New System.Drawing.Point(152, 188)
        Me.Controlling_swotComboBox.Name = "Controlling_swotComboBox"
        Me.Controlling_swotComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_swotComboBox.TabIndex = 19
        '
        'Controlling_analysen_statistikComboBox
        '
        Me.Controlling_analysen_statistikComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_analysen_statistik", True))
        Me.Controlling_analysen_statistikComboBox.FormattingEnabled = True
        Me.Controlling_analysen_statistikComboBox.Location = New System.Drawing.Point(1030, 143)
        Me.Controlling_analysen_statistikComboBox.Name = "Controlling_analysen_statistikComboBox"
        Me.Controlling_analysen_statistikComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_analysen_statistikComboBox.TabIndex = 17
        '
        'Controlling_report_controlling_systemeComboBox
        '
        Me.Controlling_report_controlling_systemeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_report_controlling_systeme", True))
        Me.Controlling_report_controlling_systemeComboBox.FormattingEnabled = True
        Me.Controlling_report_controlling_systemeComboBox.Location = New System.Drawing.Point(584, 143)
        Me.Controlling_report_controlling_systemeComboBox.Name = "Controlling_report_controlling_systemeComboBox"
        Me.Controlling_report_controlling_systemeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_report_controlling_systemeComboBox.TabIndex = 15
        '
        'Controlling_reportingComboBox
        '
        Me.Controlling_reportingComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_reporting", True))
        Me.Controlling_reportingComboBox.FormattingEnabled = True
        Me.Controlling_reportingComboBox.Location = New System.Drawing.Point(152, 143)
        Me.Controlling_reportingComboBox.Name = "Controlling_reportingComboBox"
        Me.Controlling_reportingComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_reportingComboBox.TabIndex = 13
        '
        'Controlling_forecastComboBox
        '
        Me.Controlling_forecastComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_forecast", True))
        Me.Controlling_forecastComboBox.FormattingEnabled = True
        Me.Controlling_forecastComboBox.Location = New System.Drawing.Point(1030, 83)
        Me.Controlling_forecastComboBox.Name = "Controlling_forecastComboBox"
        Me.Controlling_forecastComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_forecastComboBox.TabIndex = 11
        '
        'Controlling_cashmanagementComboBox
        '
        Me.Controlling_cashmanagementComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_cashmanagement", True))
        Me.Controlling_cashmanagementComboBox.FormattingEnabled = True
        Me.Controlling_cashmanagementComboBox.Location = New System.Drawing.Point(584, 83)
        Me.Controlling_cashmanagementComboBox.Name = "Controlling_cashmanagementComboBox"
        Me.Controlling_cashmanagementComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_cashmanagementComboBox.TabIndex = 9
        '
        'Controlling_budgetierungComboBox
        '
        Me.Controlling_budgetierungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_budgetierung", True))
        Me.Controlling_budgetierungComboBox.FormattingEnabled = True
        Me.Controlling_budgetierungComboBox.Location = New System.Drawing.Point(152, 83)
        Me.Controlling_budgetierungComboBox.Name = "Controlling_budgetierungComboBox"
        Me.Controlling_budgetierungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_budgetierungComboBox.TabIndex = 7
        '
        'Controlling_deckungsbeitragsrechnungComboBox
        '
        Me.Controlling_deckungsbeitragsrechnungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_deckungsbeitragsrechnung", True))
        Me.Controlling_deckungsbeitragsrechnungComboBox.FormattingEnabled = True
        Me.Controlling_deckungsbeitragsrechnungComboBox.Location = New System.Drawing.Point(584, 24)
        Me.Controlling_deckungsbeitragsrechnungComboBox.Name = "Controlling_deckungsbeitragsrechnungComboBox"
        Me.Controlling_deckungsbeitragsrechnungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_deckungsbeitragsrechnungComboBox.TabIndex = 3
        '
        'Controlling_kostenrechnungComboBox
        '
        Me.Controlling_kostenrechnungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_kostenrechnung", True))
        Me.Controlling_kostenrechnungComboBox.FormattingEnabled = True
        Me.Controlling_kostenrechnungComboBox.Location = New System.Drawing.Point(1030, 24)
        Me.Controlling_kostenrechnungComboBox.Name = "Controlling_kostenrechnungComboBox"
        Me.Controlling_kostenrechnungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_kostenrechnungComboBox.TabIndex = 5
        '
        'Controlling_kennzahlenComboBox
        '
        Me.Controlling_kennzahlenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_kennzahlen", True))
        Me.Controlling_kennzahlenComboBox.FormattingEnabled = True
        Me.Controlling_kennzahlenComboBox.Location = New System.Drawing.Point(152, 24)
        Me.Controlling_kennzahlenComboBox.Name = "Controlling_kennzahlenComboBox"
        Me.Controlling_kennzahlenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Controlling_kennzahlenComboBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Controlling_report_controlling_systemeLabel1)
        Me.GroupBox1.Controls.Add(Me.Controlling_report_controlling_systemeListBox)
        Me.GroupBox1.Controls.Add(Me.Controlling_sonstigesTextBox)
        Me.GroupBox1.Controls.Add(Me.Label149)
        Me.GroupBox1.Controls.Add(Me.Label148)
        Me.GroupBox1.Controls.Add(Me.Controlling_typListBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1234, 152)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'Controlling_report_controlling_systemeListBox
        '
        Me.Controlling_report_controlling_systemeListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bewerber_controllingBindingSource, "controlling_report_controlling_systeme", True))
        Me.Controlling_report_controlling_systemeListBox.FormattingEnabled = True
        Me.Controlling_report_controlling_systemeListBox.ItemHeight = 16
        Me.Controlling_report_controlling_systemeListBox.Items.AddRange(New Object() {"SAP", "DATEV", "Navision", "Lexware", "KHK Sage", "AS 400", "Oracle", "andere"})
        Me.Controlling_report_controlling_systemeListBox.Location = New System.Drawing.Point(1084, 23)
        Me.Controlling_report_controlling_systemeListBox.Name = "Controlling_report_controlling_systemeListBox"
        Me.Controlling_report_controlling_systemeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Controlling_report_controlling_systemeListBox.Size = New System.Drawing.Size(136, 100)
        Me.Controlling_report_controlling_systemeListBox.TabIndex = 3
        '
        'Controlling_sonstigesTextBox
        '
        Me.Controlling_sonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_controllingBindingSource, "controlling_sonstiges", True))
        Me.Controlling_sonstigesTextBox.Location = New System.Drawing.Point(701, 21)
        Me.Controlling_sonstigesTextBox.Multiline = True
        Me.Controlling_sonstigesTextBox.Name = "Controlling_sonstigesTextBox"
        Me.Controlling_sonstigesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Controlling_sonstigesTextBox.Size = New System.Drawing.Size(212, 109)
        Me.Controlling_sonstigesTextBox.TabIndex = 2
        '
        'Label149
        '
        Me.Label149.AutoSize = True
        Me.Label149.Location = New System.Drawing.Point(424, 23)
        Me.Label149.Name = "Label149"
        Me.Label149.Size = New System.Drawing.Size(271, 64)
        Me.Label149.TabIndex = 3
        Me.Label149.Text = "Welche anderen Controllingtätigkeiten" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "haben Sie bisher ausgeübt?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Bitte jede Tä" & _
    "tigkeit in eine neue Zeile" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "schreiben)"
        '
        'Label148
        '
        Me.Label148.AutoSize = True
        Me.Label148.Location = New System.Drawing.Point(6, 17)
        Me.Label148.Name = "Label148"
        Me.Label148.Size = New System.Drawing.Size(227, 64)
        Me.Label148.TabIndex = 2
        Me.Label148.Text = "In welchen Controllingbereichen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "haben Sie schon Erfahrungen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "gesammelt?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Mehrf" & _
    "achnennungen möglich)"
        '
        'Controlling_typListBox
        '
        Me.Controlling_typListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Bewerber_controllingBindingSource, "controlling_typ", True))
        Me.Controlling_typListBox.FormattingEnabled = True
        Me.Controlling_typListBox.ItemHeight = 16
        Me.Controlling_typListBox.Items.AddRange(New Object() {"Finanzcontrolling", "Vertriebscontrolling", "Personalcontrolling", "Projektcontrolling", "Einkaufscontrolling", "Produktionscontrolling"})
        Me.Controlling_typListBox.Location = New System.Drawing.Point(239, 21)
        Me.Controlling_typListBox.Name = "Controlling_typListBox"
        Me.Controlling_typListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Controlling_typListBox.Size = New System.Drawing.Size(170, 100)
        Me.Controlling_typListBox.TabIndex = 1
        '
        'Bewerber_controllingTableAdapter
        '
        Me.Bewerber_controllingTableAdapter.ClearBeforeFill = True
        '
        'frmControlling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1253, 631)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmControlling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Controlling"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Bewerber_controllingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Controlling_finanz_usgaapComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_abschluesse_ifrsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_abschluesse_hgbComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Controlling_swotComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_analysen_statistikComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_report_controlling_systemeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_reportingComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_forecastComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_cashmanagementComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_budgetierungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_deckungsbeitragsrechnungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_kostenrechnungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_kennzahlenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_sonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label149 As System.Windows.Forms.Label
    Friend WithEvents Label148 As System.Windows.Forms.Label
    Friend WithEvents Controlling_typListBox As System.Windows.Forms.ListBox
    Friend WithEvents Controlling_soxxComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_abschluesse_nlgaapComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Controlling_abschluesse_ukgaapComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnControlling As System.Windows.Forms.Button
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
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bewerber_controllingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_controllingTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_controllingTableAdapter
    Friend WithEvents Controlling_report_controlling_systemeListBox As System.Windows.Forms.ListBox
    Friend WithEvents Controlling_auswertungenComboBox As System.Windows.Forms.ComboBox
End Class

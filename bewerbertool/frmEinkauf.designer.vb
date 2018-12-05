<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEinkauf
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
        Dim Einkauf_strategischLabel As System.Windows.Forms.Label
        Dim Einkauf_operativLabel As System.Windows.Forms.Label
        Dim Einkauf_nationalLabel As System.Windows.Forms.Label
        Dim Einkauf_internationalLabel As System.Windows.Forms.Label
        Dim Einkauf_rohstoffeLabel As System.Windows.Forms.Label
        Dim Einkauf_hilfsstoffeLabel As System.Windows.Forms.Label
        Dim Einkauf_fertig_halbfertigwarenLabel As System.Windows.Forms.Label
        Dim Einkauf_angeboteLabel As System.Windows.Forms.Label
        Dim Einkauf_lieferantenverhandlungenLabel As System.Windows.Forms.Label
        Dim Einkauf_wareneingangLabel As System.Windows.Forms.Label
        Dim Einkauf_materialdispositionLabel As System.Windows.Forms.Label
        Dim Einkauf_marktbeobachtungLabel As System.Windows.Forms.Label
        Dim Einkauf_budgetplanungLabel As System.Windows.Forms.Label
        Dim Einkauf_statistikLabel As System.Windows.Forms.Label
        Dim Einkauf_sonstigesLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEinkauf = New System.Windows.Forms.Button()
        Me.Einkauf_sonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_einkaufBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Einkauf_statistikComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_budgetplanungComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_marktbeobachtungComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_materialdispositionComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_wareneingangComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_lieferantenverhandlungenComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_angeboteComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_fertig_halbfertigwarenComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_hilfsstoffeComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_rohstoffeComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Einkauf_internationalComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_nationalComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_operativComboBox = New System.Windows.Forms.ComboBox()
        Me.Einkauf_strategischComboBox = New System.Windows.Forms.ComboBox()
        Me.Bewerber_einkaufTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_einkaufTableAdapter()
        Einkauf_strategischLabel = New System.Windows.Forms.Label()
        Einkauf_operativLabel = New System.Windows.Forms.Label()
        Einkauf_nationalLabel = New System.Windows.Forms.Label()
        Einkauf_internationalLabel = New System.Windows.Forms.Label()
        Einkauf_rohstoffeLabel = New System.Windows.Forms.Label()
        Einkauf_hilfsstoffeLabel = New System.Windows.Forms.Label()
        Einkauf_fertig_halbfertigwarenLabel = New System.Windows.Forms.Label()
        Einkauf_angeboteLabel = New System.Windows.Forms.Label()
        Einkauf_lieferantenverhandlungenLabel = New System.Windows.Forms.Label()
        Einkauf_wareneingangLabel = New System.Windows.Forms.Label()
        Einkauf_materialdispositionLabel = New System.Windows.Forms.Label()
        Einkauf_marktbeobachtungLabel = New System.Windows.Forms.Label()
        Einkauf_budgetplanungLabel = New System.Windows.Forms.Label()
        Einkauf_statistikLabel = New System.Windows.Forms.Label()
        Einkauf_sonstigesLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Bewerber_einkaufBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Einkauf_strategischLabel
        '
        Einkauf_strategischLabel.AutoSize = True
        Einkauf_strategischLabel.Location = New System.Drawing.Point(6, 33)
        Einkauf_strategischLabel.Name = "Einkauf_strategischLabel"
        Einkauf_strategischLabel.Size = New System.Drawing.Size(104, 32)
        Einkauf_strategischLabel.TabIndex = 0
        Einkauf_strategischLabel.Text = "Strategischer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Einkauf:"
        '
        'Einkauf_operativLabel
        '
        Einkauf_operativLabel.AutoSize = True
        Einkauf_operativLabel.Location = New System.Drawing.Point(445, 36)
        Einkauf_operativLabel.Name = "Einkauf_operativLabel"
        Einkauf_operativLabel.Size = New System.Drawing.Size(140, 16)
        Einkauf_operativLabel.TabIndex = 2
        Einkauf_operativLabel.Text = "Operativer Einkauf:"
        '
        'Einkauf_nationalLabel
        '
        Einkauf_nationalLabel.AutoSize = True
        Einkauf_nationalLabel.Location = New System.Drawing.Point(899, 36)
        Einkauf_nationalLabel.Name = "Einkauf_nationalLabel"
        Einkauf_nationalLabel.Size = New System.Drawing.Size(122, 16)
        Einkauf_nationalLabel.TabIndex = 4
        Einkauf_nationalLabel.Text = "Einkauf national:"
        '
        'Einkauf_internationalLabel
        '
        Einkauf_internationalLabel.AutoSize = True
        Einkauf_internationalLabel.Location = New System.Drawing.Point(6, 87)
        Einkauf_internationalLabel.Name = "Einkauf_internationalLabel"
        Einkauf_internationalLabel.Size = New System.Drawing.Size(97, 32)
        Einkauf_internationalLabel.TabIndex = 6
        Einkauf_internationalLabel.Text = "Einkauf " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "international:"
        '
        'Einkauf_rohstoffeLabel
        '
        Einkauf_rohstoffeLabel.AutoSize = True
        Einkauf_rohstoffeLabel.Location = New System.Drawing.Point(6, 35)
        Einkauf_rohstoffeLabel.Name = "Einkauf_rohstoffeLabel"
        Einkauf_rohstoffeLabel.Size = New System.Drawing.Size(78, 16)
        Einkauf_rohstoffeLabel.TabIndex = 0
        Einkauf_rohstoffeLabel.Text = "Rohstoffe:"
        '
        'Einkauf_hilfsstoffeLabel
        '
        Einkauf_hilfsstoffeLabel.AutoSize = True
        Einkauf_hilfsstoffeLabel.Location = New System.Drawing.Point(499, 35)
        Einkauf_hilfsstoffeLabel.Name = "Einkauf_hilfsstoffeLabel"
        Einkauf_hilfsstoffeLabel.Size = New System.Drawing.Size(81, 16)
        Einkauf_hilfsstoffeLabel.TabIndex = 2
        Einkauf_hilfsstoffeLabel.Text = "Hilfsstoffe:"
        '
        'Einkauf_fertig_halbfertigwarenLabel
        '
        Einkauf_fertig_halbfertigwarenLabel.AutoSize = True
        Einkauf_fertig_halbfertigwarenLabel.Location = New System.Drawing.Point(818, 35)
        Einkauf_fertig_halbfertigwarenLabel.Name = "Einkauf_fertig_halbfertigwarenLabel"
        Einkauf_fertig_halbfertigwarenLabel.Size = New System.Drawing.Size(199, 16)
        Einkauf_fertig_halbfertigwarenLabel.TabIndex = 4
        Einkauf_fertig_halbfertigwarenLabel.Text = "Fertig- und Halbfertigwaren:"
        '
        'Einkauf_angeboteLabel
        '
        Einkauf_angeboteLabel.AutoSize = True
        Einkauf_angeboteLabel.Location = New System.Drawing.Point(6, 84)
        Einkauf_angeboteLabel.Name = "Einkauf_angeboteLabel"
        Einkauf_angeboteLabel.Size = New System.Drawing.Size(79, 16)
        Einkauf_angeboteLabel.TabIndex = 6
        Einkauf_angeboteLabel.Text = "Angebote:"
        '
        'Einkauf_lieferantenverhandlungenLabel
        '
        Einkauf_lieferantenverhandlungenLabel.AutoSize = True
        Einkauf_lieferantenverhandlungenLabel.Location = New System.Drawing.Point(395, 84)
        Einkauf_lieferantenverhandlungenLabel.Name = "Einkauf_lieferantenverhandlungenLabel"
        Einkauf_lieferantenverhandlungenLabel.Size = New System.Drawing.Size(191, 16)
        Einkauf_lieferantenverhandlungenLabel.TabIndex = 8
        Einkauf_lieferantenverhandlungenLabel.Text = "Lieferantenverhandlungen:"
        '
        'Einkauf_wareneingangLabel
        '
        Einkauf_wareneingangLabel.AutoSize = True
        Einkauf_wareneingangLabel.Location = New System.Drawing.Point(908, 84)
        Einkauf_wareneingangLabel.Name = "Einkauf_wareneingangLabel"
        Einkauf_wareneingangLabel.Size = New System.Drawing.Size(113, 16)
        Einkauf_wareneingangLabel.TabIndex = 10
        Einkauf_wareneingangLabel.Text = "Wareneingang:"
        '
        'Einkauf_materialdispositionLabel
        '
        Einkauf_materialdispositionLabel.AutoSize = True
        Einkauf_materialdispositionLabel.Location = New System.Drawing.Point(6, 130)
        Einkauf_materialdispositionLabel.Name = "Einkauf_materialdispositionLabel"
        Einkauf_materialdispositionLabel.Size = New System.Drawing.Size(88, 32)
        Einkauf_materialdispositionLabel.TabIndex = 12
        Einkauf_materialdispositionLabel.Text = "Material-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "disposition:"
        '
        'Einkauf_marktbeobachtungLabel
        '
        Einkauf_marktbeobachtungLabel.AutoSize = True
        Einkauf_marktbeobachtungLabel.Location = New System.Drawing.Point(875, 140)
        Einkauf_marktbeobachtungLabel.Name = "Einkauf_marktbeobachtungLabel"
        Einkauf_marktbeobachtungLabel.Size = New System.Drawing.Size(140, 16)
        Einkauf_marktbeobachtungLabel.TabIndex = 14
        Einkauf_marktbeobachtungLabel.Text = "Marktbeobachtung:"
        '
        'Einkauf_budgetplanungLabel
        '
        Einkauf_budgetplanungLabel.AutoSize = True
        Einkauf_budgetplanungLabel.Location = New System.Drawing.Point(466, 140)
        Einkauf_budgetplanungLabel.Name = "Einkauf_budgetplanungLabel"
        Einkauf_budgetplanungLabel.Size = New System.Drawing.Size(116, 16)
        Einkauf_budgetplanungLabel.TabIndex = 16
        Einkauf_budgetplanungLabel.Text = "Budgetplanung:"
        '
        'Einkauf_statistikLabel
        '
        Einkauf_statistikLabel.AutoSize = True
        Einkauf_statistikLabel.Location = New System.Drawing.Point(6, 188)
        Einkauf_statistikLabel.Name = "Einkauf_statistikLabel"
        Einkauf_statistikLabel.Size = New System.Drawing.Size(84, 16)
        Einkauf_statistikLabel.TabIndex = 18
        Einkauf_statistikLabel.Text = "Statistiken:"
        '
        'Einkauf_sonstigesLabel
        '
        Einkauf_sonstigesLabel.AutoSize = True
        Einkauf_sonstigesLabel.Location = New System.Drawing.Point(6, 247)
        Einkauf_sonstigesLabel.Name = "Einkauf_sonstigesLabel"
        Einkauf_sonstigesLabel.Size = New System.Drawing.Size(142, 32)
        Einkauf_sonstigesLabel.TabIndex = 20
        Einkauf_sonstigesLabel.Text = "Sonstige " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Einkaufsaktivitäten:"
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
        Me.Panel1.Size = New System.Drawing.Size(1242, 525)
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
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte im Einkauf an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.btnEinkauf)
        Me.GroupBox2.Controls.Add(Einkauf_sonstigesLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_sonstigesTextBox)
        Me.GroupBox2.Controls.Add(Einkauf_statistikLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_statistikComboBox)
        Me.GroupBox2.Controls.Add(Einkauf_budgetplanungLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_budgetplanungComboBox)
        Me.GroupBox2.Controls.Add(Einkauf_marktbeobachtungLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_marktbeobachtungComboBox)
        Me.GroupBox2.Controls.Add(Einkauf_materialdispositionLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_materialdispositionComboBox)
        Me.GroupBox2.Controls.Add(Einkauf_wareneingangLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_wareneingangComboBox)
        Me.GroupBox2.Controls.Add(Einkauf_lieferantenverhandlungenLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_lieferantenverhandlungenComboBox)
        Me.GroupBox2.Controls.Add(Einkauf_angeboteLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_angeboteComboBox)
        Me.GroupBox2.Controls.Add(Einkauf_fertig_halbfertigwarenLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_fertig_halbfertigwarenComboBox)
        Me.GroupBox2.Controls.Add(Einkauf_hilfsstoffeLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_hilfsstoffeComboBox)
        Me.GroupBox2.Controls.Add(Einkauf_rohstoffeLabel)
        Me.GroupBox2.Controls.Add(Me.Einkauf_rohstoffeComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1236, 357)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Einkaufstätigkeiten"
        '
        'btnEinkauf
        '
        Me.btnEinkauf.BackColor = System.Drawing.Color.Wheat
        Me.btnEinkauf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnEinkauf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEinkauf.Location = New System.Drawing.Point(551, 272)
        Me.btnEinkauf.Name = "btnEinkauf"
        Me.btnEinkauf.Size = New System.Drawing.Size(203, 60)
        Me.btnEinkauf.TabIndex = 22
        Me.btnEinkauf.Text = "Kenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Einkauf" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnEinkauf.UseVisualStyleBackColor = False
        '
        'Einkauf_sonstigesTextBox
        '
        Me.Einkauf_sonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_sonstiges", True))
        Me.Einkauf_sonstigesTextBox.Location = New System.Drawing.Point(152, 247)
        Me.Einkauf_sonstigesTextBox.Multiline = True
        Me.Einkauf_sonstigesTextBox.Name = "Einkauf_sonstigesTextBox"
        Me.Einkauf_sonstigesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Einkauf_sonstigesTextBox.Size = New System.Drawing.Size(298, 93)
        Me.Einkauf_sonstigesTextBox.TabIndex = 11
        '
        'Bewerber_einkaufBindingSource
        '
        Me.Bewerber_einkaufBindingSource.DataMember = "bewerber_einkauf"
        Me.Bewerber_einkaufBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Einkauf_statistikComboBox
        '
        Me.Einkauf_statistikComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_statistik", True))
        Me.Einkauf_statistikComboBox.FormattingEnabled = True
        Me.Einkauf_statistikComboBox.Location = New System.Drawing.Point(152, 185)
        Me.Einkauf_statistikComboBox.Name = "Einkauf_statistikComboBox"
        Me.Einkauf_statistikComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_statistikComboBox.TabIndex = 10
        '
        'Einkauf_budgetplanungComboBox
        '
        Me.Einkauf_budgetplanungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_budgetplanung", True))
        Me.Einkauf_budgetplanungComboBox.FormattingEnabled = True
        Me.Einkauf_budgetplanungComboBox.Location = New System.Drawing.Point(601, 137)
        Me.Einkauf_budgetplanungComboBox.Name = "Einkauf_budgetplanungComboBox"
        Me.Einkauf_budgetplanungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_budgetplanungComboBox.TabIndex = 8
        '
        'Einkauf_marktbeobachtungComboBox
        '
        Me.Einkauf_marktbeobachtungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_marktbeobachtung", True))
        Me.Einkauf_marktbeobachtungComboBox.FormattingEnabled = True
        Me.Einkauf_marktbeobachtungComboBox.Location = New System.Drawing.Point(1030, 137)
        Me.Einkauf_marktbeobachtungComboBox.Name = "Einkauf_marktbeobachtungComboBox"
        Me.Einkauf_marktbeobachtungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_marktbeobachtungComboBox.TabIndex = 9
        '
        'Einkauf_materialdispositionComboBox
        '
        Me.Einkauf_materialdispositionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_materialdisposition", True))
        Me.Einkauf_materialdispositionComboBox.FormattingEnabled = True
        Me.Einkauf_materialdispositionComboBox.Location = New System.Drawing.Point(152, 137)
        Me.Einkauf_materialdispositionComboBox.Name = "Einkauf_materialdispositionComboBox"
        Me.Einkauf_materialdispositionComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_materialdispositionComboBox.TabIndex = 7
        '
        'Einkauf_wareneingangComboBox
        '
        Me.Einkauf_wareneingangComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_wareneingang", True))
        Me.Einkauf_wareneingangComboBox.FormattingEnabled = True
        Me.Einkauf_wareneingangComboBox.Location = New System.Drawing.Point(1030, 81)
        Me.Einkauf_wareneingangComboBox.Name = "Einkauf_wareneingangComboBox"
        Me.Einkauf_wareneingangComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_wareneingangComboBox.TabIndex = 6
        '
        'Einkauf_lieferantenverhandlungenComboBox
        '
        Me.Einkauf_lieferantenverhandlungenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_lieferantenverhandlungen", True))
        Me.Einkauf_lieferantenverhandlungenComboBox.FormattingEnabled = True
        Me.Einkauf_lieferantenverhandlungenComboBox.Location = New System.Drawing.Point(601, 81)
        Me.Einkauf_lieferantenverhandlungenComboBox.Name = "Einkauf_lieferantenverhandlungenComboBox"
        Me.Einkauf_lieferantenverhandlungenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_lieferantenverhandlungenComboBox.TabIndex = 5
        '
        'Einkauf_angeboteComboBox
        '
        Me.Einkauf_angeboteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_angebote", True))
        Me.Einkauf_angeboteComboBox.FormattingEnabled = True
        Me.Einkauf_angeboteComboBox.Location = New System.Drawing.Point(152, 81)
        Me.Einkauf_angeboteComboBox.Name = "Einkauf_angeboteComboBox"
        Me.Einkauf_angeboteComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_angeboteComboBox.TabIndex = 4
        '
        'Einkauf_fertig_halbfertigwarenComboBox
        '
        Me.Einkauf_fertig_halbfertigwarenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_fertig_halbfertigwaren", True))
        Me.Einkauf_fertig_halbfertigwarenComboBox.FormattingEnabled = True
        Me.Einkauf_fertig_halbfertigwarenComboBox.Location = New System.Drawing.Point(1030, 32)
        Me.Einkauf_fertig_halbfertigwarenComboBox.Name = "Einkauf_fertig_halbfertigwarenComboBox"
        Me.Einkauf_fertig_halbfertigwarenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_fertig_halbfertigwarenComboBox.TabIndex = 3
        '
        'Einkauf_hilfsstoffeComboBox
        '
        Me.Einkauf_hilfsstoffeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_hilfsstoffe", True))
        Me.Einkauf_hilfsstoffeComboBox.FormattingEnabled = True
        Me.Einkauf_hilfsstoffeComboBox.Location = New System.Drawing.Point(601, 32)
        Me.Einkauf_hilfsstoffeComboBox.Name = "Einkauf_hilfsstoffeComboBox"
        Me.Einkauf_hilfsstoffeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_hilfsstoffeComboBox.TabIndex = 2
        '
        'Einkauf_rohstoffeComboBox
        '
        Me.Einkauf_rohstoffeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_rohstoffe", True))
        Me.Einkauf_rohstoffeComboBox.FormattingEnabled = True
        Me.Einkauf_rohstoffeComboBox.Location = New System.Drawing.Point(152, 32)
        Me.Einkauf_rohstoffeComboBox.Name = "Einkauf_rohstoffeComboBox"
        Me.Einkauf_rohstoffeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_rohstoffeComboBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Einkauf_internationalLabel)
        Me.GroupBox1.Controls.Add(Me.Einkauf_internationalComboBox)
        Me.GroupBox1.Controls.Add(Einkauf_nationalLabel)
        Me.GroupBox1.Controls.Add(Me.Einkauf_nationalComboBox)
        Me.GroupBox1.Controls.Add(Einkauf_operativLabel)
        Me.GroupBox1.Controls.Add(Me.Einkauf_operativComboBox)
        Me.GroupBox1.Controls.Add(Einkauf_strategischLabel)
        Me.GroupBox1.Controls.Add(Me.Einkauf_strategischComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1234, 130)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Art der Tätigkeit"
        '
        'Einkauf_internationalComboBox
        '
        Me.Einkauf_internationalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_international", True))
        Me.Einkauf_internationalComboBox.FormattingEnabled = True
        Me.Einkauf_internationalComboBox.Location = New System.Drawing.Point(152, 87)
        Me.Einkauf_internationalComboBox.Name = "Einkauf_internationalComboBox"
        Me.Einkauf_internationalComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_internationalComboBox.TabIndex = 4
        '
        'Einkauf_nationalComboBox
        '
        Me.Einkauf_nationalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_national", True))
        Me.Einkauf_nationalComboBox.FormattingEnabled = True
        Me.Einkauf_nationalComboBox.Location = New System.Drawing.Point(1030, 33)
        Me.Einkauf_nationalComboBox.Name = "Einkauf_nationalComboBox"
        Me.Einkauf_nationalComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_nationalComboBox.TabIndex = 3
        '
        'Einkauf_operativComboBox
        '
        Me.Einkauf_operativComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_operativ", True))
        Me.Einkauf_operativComboBox.FormattingEnabled = True
        Me.Einkauf_operativComboBox.Location = New System.Drawing.Point(601, 33)
        Me.Einkauf_operativComboBox.Name = "Einkauf_operativComboBox"
        Me.Einkauf_operativComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_operativComboBox.TabIndex = 2
        '
        'Einkauf_strategischComboBox
        '
        Me.Einkauf_strategischComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_einkaufBindingSource, "einkauf_strategisch", True))
        Me.Einkauf_strategischComboBox.FormattingEnabled = True
        Me.Einkauf_strategischComboBox.Location = New System.Drawing.Point(152, 33)
        Me.Einkauf_strategischComboBox.Name = "Einkauf_strategischComboBox"
        Me.Einkauf_strategischComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Einkauf_strategischComboBox.TabIndex = 1
        '
        'Bewerber_einkaufTableAdapter
        '
        Me.Bewerber_einkaufTableAdapter.ClearBeforeFill = True
        '
        'frmEinkauf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1250, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmEinkauf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Einkauf"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Bewerber_einkaufBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Einkauf_internationalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_nationalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_operativComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_strategischComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnEinkauf As System.Windows.Forms.Button
    Friend WithEvents Einkauf_sonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Einkauf_statistikComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_budgetplanungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_marktbeobachtungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_materialdispositionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_wareneingangComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_lieferantenverhandlungenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_angeboteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_fertig_halbfertigwarenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_hilfsstoffeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Einkauf_rohstoffeComboBox As System.Windows.Forms.ComboBox
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bewerber_einkaufBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_einkaufTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_einkaufTableAdapter
End Class

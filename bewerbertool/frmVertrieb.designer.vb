<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVertrieb
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
        Dim Vertrieb_innendienstLabel As System.Windows.Forms.Label
        Dim Vertrieb_aussendienstLabel As System.Windows.Forms.Label
        Dim Vertrieb_strategischLabel As System.Windows.Forms.Label
        Dim Vertrieb_operativLabel As System.Windows.Forms.Label
        Dim Vertrieb_nationalLabel As System.Windows.Forms.Label
        Dim Vertrieb_kundenservice_persönlichLabel As System.Windows.Forms.Label
        Dim Vertrieb_kundenservice_telefonischLabel As System.Windows.Forms.Label
        Dim Vertrieb_kundenservice_callcenterLabel As System.Windows.Forms.Label
        Dim Vertrieb_auftragsbearbeitungLabel As System.Windows.Forms.Label
        Dim Vertrieb_reklamationsbearbeitungLabel As System.Windows.Forms.Label
        Dim Vertrieb_keyaccountLabel As System.Windows.Forms.Label
        Dim Vertrieb_neukundengewinnungLabel As System.Windows.Forms.Label
        Dim Vertrieb_statistikLabel As System.Windows.Forms.Label
        Dim Vertrieb_sonstigesLabel As System.Windows.Forms.Label
        Dim Vertrieb_europaweitLabel As System.Windows.Forms.Label
        Dim Vertrieb_weltweitLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnVertrieb = New System.Windows.Forms.Button()
        Me.Vertrieb_sonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_vertriebBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Vertrieb_statistikComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_neukundengewinnungComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_keyaccountComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_reklamationsbearbeitungComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_auftragsbearbeitungComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_kundenservice_callcenterComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_kundenservice_telefonischComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_kundenservice_persönlichComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Vertrieb_weltweitComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_europaweitComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_nationalComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_operativComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_strategischComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_aussendienstComboBox = New System.Windows.Forms.ComboBox()
        Me.Vertrieb_innendienstComboBox = New System.Windows.Forms.ComboBox()
        Me.Bewerber_vertriebTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_vertriebTableAdapter()
        Vertrieb_innendienstLabel = New System.Windows.Forms.Label()
        Vertrieb_aussendienstLabel = New System.Windows.Forms.Label()
        Vertrieb_strategischLabel = New System.Windows.Forms.Label()
        Vertrieb_operativLabel = New System.Windows.Forms.Label()
        Vertrieb_nationalLabel = New System.Windows.Forms.Label()
        Vertrieb_kundenservice_persönlichLabel = New System.Windows.Forms.Label()
        Vertrieb_kundenservice_telefonischLabel = New System.Windows.Forms.Label()
        Vertrieb_kundenservice_callcenterLabel = New System.Windows.Forms.Label()
        Vertrieb_auftragsbearbeitungLabel = New System.Windows.Forms.Label()
        Vertrieb_reklamationsbearbeitungLabel = New System.Windows.Forms.Label()
        Vertrieb_keyaccountLabel = New System.Windows.Forms.Label()
        Vertrieb_neukundengewinnungLabel = New System.Windows.Forms.Label()
        Vertrieb_statistikLabel = New System.Windows.Forms.Label()
        Vertrieb_sonstigesLabel = New System.Windows.Forms.Label()
        Vertrieb_europaweitLabel = New System.Windows.Forms.Label()
        Vertrieb_weltweitLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Bewerber_vertriebBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Vertrieb_innendienstLabel
        '
        Vertrieb_innendienstLabel.AutoSize = True
        Vertrieb_innendienstLabel.Location = New System.Drawing.Point(6, 38)
        Vertrieb_innendienstLabel.Name = "Vertrieb_innendienstLabel"
        Vertrieb_innendienstLabel.Size = New System.Drawing.Size(154, 16)
        Vertrieb_innendienstLabel.TabIndex = 0
        Vertrieb_innendienstLabel.Text = "Vertriebsinnendienst:"
        '
        'Vertrieb_aussendienstLabel
        '
        Vertrieb_aussendienstLabel.AutoSize = True
        Vertrieb_aussendienstLabel.Location = New System.Drawing.Point(429, 38)
        Vertrieb_aussendienstLabel.Name = "Vertrieb_aussendienstLabel"
        Vertrieb_aussendienstLabel.Size = New System.Drawing.Size(160, 16)
        Vertrieb_aussendienstLabel.TabIndex = 2
        Vertrieb_aussendienstLabel.Text = "Vertriebsaußendienst:"
        '
        'Vertrieb_strategischLabel
        '
        Vertrieb_strategischLabel.AutoSize = True
        Vertrieb_strategischLabel.Location = New System.Drawing.Point(874, 38)
        Vertrieb_strategischLabel.Name = "Vertrieb_strategischLabel"
        Vertrieb_strategischLabel.Size = New System.Drawing.Size(163, 16)
        Vertrieb_strategischLabel.TabIndex = 4
        Vertrieb_strategischLabel.Text = "Strategischer Vertrieb:"
        '
        'Vertrieb_operativLabel
        '
        Vertrieb_operativLabel.AutoSize = True
        Vertrieb_operativLabel.Location = New System.Drawing.Point(6, 83)
        Vertrieb_operativLabel.Name = "Vertrieb_operativLabel"
        Vertrieb_operativLabel.Size = New System.Drawing.Size(144, 16)
        Vertrieb_operativLabel.TabIndex = 6
        Vertrieb_operativLabel.Text = "Operativer Vertrieb:"
        '
        'Vertrieb_nationalLabel
        '
        Vertrieb_nationalLabel.AutoSize = True
        Vertrieb_nationalLabel.Location = New System.Drawing.Point(459, 83)
        Vertrieb_nationalLabel.Name = "Vertrieb_nationalLabel"
        Vertrieb_nationalLabel.Size = New System.Drawing.Size(126, 16)
        Vertrieb_nationalLabel.TabIndex = 8
        Vertrieb_nationalLabel.Text = "Vertrieb national:"
        '
        'Vertrieb_kundenservice_persönlichLabel
        '
        Vertrieb_kundenservice_persönlichLabel.AutoSize = True
        Vertrieb_kundenservice_persönlichLabel.Location = New System.Drawing.Point(7, 38)
        Vertrieb_kundenservice_persönlichLabel.Name = "Vertrieb_kundenservice_persönlichLabel"
        Vertrieb_kundenservice_persönlichLabel.Size = New System.Drawing.Size(190, 16)
        Vertrieb_kundenservice_persönlichLabel.TabIndex = 0
        Vertrieb_kundenservice_persönlichLabel.Text = "Kundenservice persönlich:"
        '
        'Vertrieb_kundenservice_telefonischLabel
        '
        Vertrieb_kundenservice_telefonischLabel.AutoSize = True
        Vertrieb_kundenservice_telefonischLabel.Location = New System.Drawing.Point(397, 38)
        Vertrieb_kundenservice_telefonischLabel.Name = "Vertrieb_kundenservice_telefonischLabel"
        Vertrieb_kundenservice_telefonischLabel.Size = New System.Drawing.Size(193, 16)
        Vertrieb_kundenservice_telefonischLabel.TabIndex = 2
        Vertrieb_kundenservice_telefonischLabel.Text = "Kundenservice telefonisch:"
        '
        'Vertrieb_kundenservice_callcenterLabel
        '
        Vertrieb_kundenservice_callcenterLabel.AutoSize = True
        Vertrieb_kundenservice_callcenterLabel.Location = New System.Drawing.Point(850, 38)
        Vertrieb_kundenservice_callcenterLabel.Name = "Vertrieb_kundenservice_callcenterLabel"
        Vertrieb_kundenservice_callcenterLabel.Size = New System.Drawing.Size(188, 16)
        Vertrieb_kundenservice_callcenterLabel.TabIndex = 4
        Vertrieb_kundenservice_callcenterLabel.Text = "Kundenservice Callcenter:"
        '
        'Vertrieb_auftragsbearbeitungLabel
        '
        Vertrieb_auftragsbearbeitungLabel.AutoSize = True
        Vertrieb_auftragsbearbeitungLabel.Location = New System.Drawing.Point(9, 82)
        Vertrieb_auftragsbearbeitungLabel.Name = "Vertrieb_auftragsbearbeitungLabel"
        Vertrieb_auftragsbearbeitungLabel.Size = New System.Drawing.Size(152, 16)
        Vertrieb_auftragsbearbeitungLabel.TabIndex = 6
        Vertrieb_auftragsbearbeitungLabel.Text = "Auftragsbearbeitung:"
        '
        'Vertrieb_reklamationsbearbeitungLabel
        '
        Vertrieb_reklamationsbearbeitungLabel.AutoSize = True
        Vertrieb_reklamationsbearbeitungLabel.Location = New System.Drawing.Point(397, 82)
        Vertrieb_reklamationsbearbeitungLabel.Name = "Vertrieb_reklamationsbearbeitungLabel"
        Vertrieb_reklamationsbearbeitungLabel.Size = New System.Drawing.Size(190, 16)
        Vertrieb_reklamationsbearbeitungLabel.TabIndex = 8
        Vertrieb_reklamationsbearbeitungLabel.Text = "Reklamationsbearbeitung:"
        '
        'Vertrieb_keyaccountLabel
        '
        Vertrieb_keyaccountLabel.AutoSize = True
        Vertrieb_keyaccountLabel.Location = New System.Drawing.Point(848, 82)
        Vertrieb_keyaccountLabel.Name = "Vertrieb_keyaccountLabel"
        Vertrieb_keyaccountLabel.Size = New System.Drawing.Size(190, 16)
        Vertrieb_keyaccountLabel.TabIndex = 10
        Vertrieb_keyaccountLabel.Text = "Key Account Management:"
        '
        'Vertrieb_neukundengewinnungLabel
        '
        Vertrieb_neukundengewinnungLabel.AutoSize = True
        Vertrieb_neukundengewinnungLabel.Location = New System.Drawing.Point(9, 130)
        Vertrieb_neukundengewinnungLabel.Name = "Vertrieb_neukundengewinnungLabel"
        Vertrieb_neukundengewinnungLabel.Size = New System.Drawing.Size(163, 16)
        Vertrieb_neukundengewinnungLabel.TabIndex = 12
        Vertrieb_neukundengewinnungLabel.Text = "Neukundengewinnung:"
        '
        'Vertrieb_statistikLabel
        '
        Vertrieb_statistikLabel.AutoSize = True
        Vertrieb_statistikLabel.Location = New System.Drawing.Point(440, 130)
        Vertrieb_statistikLabel.Name = "Vertrieb_statistikLabel"
        Vertrieb_statistikLabel.Size = New System.Drawing.Size(145, 16)
        Vertrieb_statistikLabel.TabIndex = 14
        Vertrieb_statistikLabel.Text = "Vertriebsstatistiken:"
        '
        'Vertrieb_sonstigesLabel
        '
        Vertrieb_sonstigesLabel.AutoSize = True
        Vertrieb_sonstigesLabel.Location = New System.Drawing.Point(9, 177)
        Vertrieb_sonstigesLabel.Name = "Vertrieb_sonstigesLabel"
        Vertrieb_sonstigesLabel.Size = New System.Drawing.Size(151, 32)
        Vertrieb_sonstigesLabel.TabIndex = 16
        Vertrieb_sonstigesLabel.Text = "Sonstige " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vertriebstätigkeiten: "
        '
        'Vertrieb_europaweitLabel
        '
        Vertrieb_europaweitLabel.AutoSize = True
        Vertrieb_europaweitLabel.Location = New System.Drawing.Point(888, 83)
        Vertrieb_europaweitLabel.Name = "Vertrieb_europaweitLabel"
        Vertrieb_europaweitLabel.Size = New System.Drawing.Size(147, 16)
        Vertrieb_europaweitLabel.TabIndex = 10
        Vertrieb_europaweitLabel.Text = "Vertrieb europaweit:"
        '
        'Vertrieb_weltweitLabel
        '
        Vertrieb_weltweitLabel.AutoSize = True
        Vertrieb_weltweitLabel.Location = New System.Drawing.Point(6, 128)
        Vertrieb_weltweitLabel.Name = "Vertrieb_weltweitLabel"
        Vertrieb_weltweitLabel.Size = New System.Drawing.Size(125, 16)
        Vertrieb_weltweitLabel.TabIndex = 12
        Vertrieb_weltweitLabel.Text = "Vertrieb weltweit:"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1243, 563)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1237, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte im Vertrieb an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.btnVertrieb)
        Me.GroupBox2.Controls.Add(Vertrieb_sonstigesLabel)
        Me.GroupBox2.Controls.Add(Me.Vertrieb_sonstigesTextBox)
        Me.GroupBox2.Controls.Add(Vertrieb_statistikLabel)
        Me.GroupBox2.Controls.Add(Me.Vertrieb_statistikComboBox)
        Me.GroupBox2.Controls.Add(Vertrieb_neukundengewinnungLabel)
        Me.GroupBox2.Controls.Add(Me.Vertrieb_neukundengewinnungComboBox)
        Me.GroupBox2.Controls.Add(Vertrieb_keyaccountLabel)
        Me.GroupBox2.Controls.Add(Me.Vertrieb_keyaccountComboBox)
        Me.GroupBox2.Controls.Add(Vertrieb_reklamationsbearbeitungLabel)
        Me.GroupBox2.Controls.Add(Me.Vertrieb_reklamationsbearbeitungComboBox)
        Me.GroupBox2.Controls.Add(Vertrieb_auftragsbearbeitungLabel)
        Me.GroupBox2.Controls.Add(Me.Vertrieb_auftragsbearbeitungComboBox)
        Me.GroupBox2.Controls.Add(Vertrieb_kundenservice_callcenterLabel)
        Me.GroupBox2.Controls.Add(Me.Vertrieb_kundenservice_callcenterComboBox)
        Me.GroupBox2.Controls.Add(Vertrieb_kundenservice_telefonischLabel)
        Me.GroupBox2.Controls.Add(Me.Vertrieb_kundenservice_telefonischComboBox)
        Me.GroupBox2.Controls.Add(Vertrieb_kundenservice_persönlichLabel)
        Me.GroupBox2.Controls.Add(Me.Vertrieb_kundenservice_persönlichComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1237, 369)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vertriebstätigkeiten:"
        '
        'btnVertrieb
        '
        Me.btnVertrieb.BackColor = System.Drawing.Color.Wheat
        Me.btnVertrieb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnVertrieb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVertrieb.Location = New System.Drawing.Point(596, 294)
        Me.btnVertrieb.Name = "btnVertrieb"
        Me.btnVertrieb.Size = New System.Drawing.Size(203, 60)
        Me.btnVertrieb.TabIndex = 18
        Me.btnVertrieb.Text = "Kenntnisse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vertrieb" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnVertrieb.UseVisualStyleBackColor = False
        '
        'Vertrieb_sonstigesTextBox
        '
        Me.Vertrieb_sonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_sonstiges", True))
        Me.Vertrieb_sonstigesTextBox.Location = New System.Drawing.Point(203, 174)
        Me.Vertrieb_sonstigesTextBox.Multiline = True
        Me.Vertrieb_sonstigesTextBox.Name = "Vertrieb_sonstigesTextBox"
        Me.Vertrieb_sonstigesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Vertrieb_sonstigesTextBox.Size = New System.Drawing.Size(352, 111)
        Me.Vertrieb_sonstigesTextBox.TabIndex = 9
        '
        'Bewerber_vertriebBindingSource
        '
        Me.Bewerber_vertriebBindingSource.DataMember = "bewerber_vertrieb"
        Me.Bewerber_vertriebBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vertrieb_statistikComboBox
        '
        Me.Vertrieb_statistikComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_statistik", True))
        Me.Vertrieb_statistikComboBox.FormattingEnabled = True
        Me.Vertrieb_statistikComboBox.Location = New System.Drawing.Point(595, 127)
        Me.Vertrieb_statistikComboBox.Name = "Vertrieb_statistikComboBox"
        Me.Vertrieb_statistikComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_statistikComboBox.TabIndex = 8
        '
        'Vertrieb_neukundengewinnungComboBox
        '
        Me.Vertrieb_neukundengewinnungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_neukundengewinnung", True))
        Me.Vertrieb_neukundengewinnungComboBox.FormattingEnabled = True
        Me.Vertrieb_neukundengewinnungComboBox.Location = New System.Drawing.Point(203, 127)
        Me.Vertrieb_neukundengewinnungComboBox.Name = "Vertrieb_neukundengewinnungComboBox"
        Me.Vertrieb_neukundengewinnungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_neukundengewinnungComboBox.TabIndex = 7
        '
        'Vertrieb_keyaccountComboBox
        '
        Me.Vertrieb_keyaccountComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_keyaccount", True))
        Me.Vertrieb_keyaccountComboBox.FormattingEnabled = True
        Me.Vertrieb_keyaccountComboBox.Location = New System.Drawing.Point(1046, 79)
        Me.Vertrieb_keyaccountComboBox.Name = "Vertrieb_keyaccountComboBox"
        Me.Vertrieb_keyaccountComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_keyaccountComboBox.TabIndex = 6
        '
        'Vertrieb_reklamationsbearbeitungComboBox
        '
        Me.Vertrieb_reklamationsbearbeitungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_reklamationsbearbeitung", True))
        Me.Vertrieb_reklamationsbearbeitungComboBox.FormattingEnabled = True
        Me.Vertrieb_reklamationsbearbeitungComboBox.Location = New System.Drawing.Point(595, 79)
        Me.Vertrieb_reklamationsbearbeitungComboBox.Name = "Vertrieb_reklamationsbearbeitungComboBox"
        Me.Vertrieb_reklamationsbearbeitungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_reklamationsbearbeitungComboBox.TabIndex = 5
        '
        'Vertrieb_auftragsbearbeitungComboBox
        '
        Me.Vertrieb_auftragsbearbeitungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_auftragsbearbeitung", True))
        Me.Vertrieb_auftragsbearbeitungComboBox.FormattingEnabled = True
        Me.Vertrieb_auftragsbearbeitungComboBox.Location = New System.Drawing.Point(203, 79)
        Me.Vertrieb_auftragsbearbeitungComboBox.Name = "Vertrieb_auftragsbearbeitungComboBox"
        Me.Vertrieb_auftragsbearbeitungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_auftragsbearbeitungComboBox.TabIndex = 4
        '
        'Vertrieb_kundenservice_callcenterComboBox
        '
        Me.Vertrieb_kundenservice_callcenterComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_kundenservice_callcenter", True))
        Me.Vertrieb_kundenservice_callcenterComboBox.FormattingEnabled = True
        Me.Vertrieb_kundenservice_callcenterComboBox.Location = New System.Drawing.Point(1046, 35)
        Me.Vertrieb_kundenservice_callcenterComboBox.Name = "Vertrieb_kundenservice_callcenterComboBox"
        Me.Vertrieb_kundenservice_callcenterComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_kundenservice_callcenterComboBox.TabIndex = 3
        '
        'Vertrieb_kundenservice_telefonischComboBox
        '
        Me.Vertrieb_kundenservice_telefonischComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_kundenservice_telefonisch", True))
        Me.Vertrieb_kundenservice_telefonischComboBox.FormattingEnabled = True
        Me.Vertrieb_kundenservice_telefonischComboBox.Location = New System.Drawing.Point(595, 35)
        Me.Vertrieb_kundenservice_telefonischComboBox.Name = "Vertrieb_kundenservice_telefonischComboBox"
        Me.Vertrieb_kundenservice_telefonischComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_kundenservice_telefonischComboBox.TabIndex = 2
        '
        'Vertrieb_kundenservice_persönlichComboBox
        '
        Me.Vertrieb_kundenservice_persönlichComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_kundenservice_persönlich", True))
        Me.Vertrieb_kundenservice_persönlichComboBox.FormattingEnabled = True
        Me.Vertrieb_kundenservice_persönlichComboBox.Location = New System.Drawing.Point(203, 35)
        Me.Vertrieb_kundenservice_persönlichComboBox.Name = "Vertrieb_kundenservice_persönlichComboBox"
        Me.Vertrieb_kundenservice_persönlichComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_kundenservice_persönlichComboBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Vertrieb_weltweitLabel)
        Me.GroupBox1.Controls.Add(Me.Vertrieb_weltweitComboBox)
        Me.GroupBox1.Controls.Add(Vertrieb_europaweitLabel)
        Me.GroupBox1.Controls.Add(Me.Vertrieb_europaweitComboBox)
        Me.GroupBox1.Controls.Add(Vertrieb_nationalLabel)
        Me.GroupBox1.Controls.Add(Me.Vertrieb_nationalComboBox)
        Me.GroupBox1.Controls.Add(Vertrieb_operativLabel)
        Me.GroupBox1.Controls.Add(Me.Vertrieb_operativComboBox)
        Me.GroupBox1.Controls.Add(Vertrieb_strategischLabel)
        Me.GroupBox1.Controls.Add(Me.Vertrieb_strategischComboBox)
        Me.GroupBox1.Controls.Add(Vertrieb_aussendienstLabel)
        Me.GroupBox1.Controls.Add(Me.Vertrieb_aussendienstComboBox)
        Me.GroupBox1.Controls.Add(Vertrieb_innendienstLabel)
        Me.GroupBox1.Controls.Add(Me.Vertrieb_innendienstComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1237, 160)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Art der Tätigkeit"
        '
        'Vertrieb_weltweitComboBox
        '
        Me.Vertrieb_weltweitComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_weltweit", True))
        Me.Vertrieb_weltweitComboBox.FormattingEnabled = True
        Me.Vertrieb_weltweitComboBox.Location = New System.Drawing.Point(203, 125)
        Me.Vertrieb_weltweitComboBox.Name = "Vertrieb_weltweitComboBox"
        Me.Vertrieb_weltweitComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_weltweitComboBox.TabIndex = 7
        '
        'Vertrieb_europaweitComboBox
        '
        Me.Vertrieb_europaweitComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_europaweit", True))
        Me.Vertrieb_europaweitComboBox.FormattingEnabled = True
        Me.Vertrieb_europaweitComboBox.Location = New System.Drawing.Point(1046, 80)
        Me.Vertrieb_europaweitComboBox.Name = "Vertrieb_europaweitComboBox"
        Me.Vertrieb_europaweitComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_europaweitComboBox.TabIndex = 6
        '
        'Vertrieb_nationalComboBox
        '
        Me.Vertrieb_nationalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_national", True))
        Me.Vertrieb_nationalComboBox.FormattingEnabled = True
        Me.Vertrieb_nationalComboBox.Location = New System.Drawing.Point(595, 80)
        Me.Vertrieb_nationalComboBox.Name = "Vertrieb_nationalComboBox"
        Me.Vertrieb_nationalComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_nationalComboBox.TabIndex = 5
        '
        'Vertrieb_operativComboBox
        '
        Me.Vertrieb_operativComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_operativ", True))
        Me.Vertrieb_operativComboBox.FormattingEnabled = True
        Me.Vertrieb_operativComboBox.Location = New System.Drawing.Point(203, 80)
        Me.Vertrieb_operativComboBox.Name = "Vertrieb_operativComboBox"
        Me.Vertrieb_operativComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_operativComboBox.TabIndex = 4
        '
        'Vertrieb_strategischComboBox
        '
        Me.Vertrieb_strategischComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_strategisch", True))
        Me.Vertrieb_strategischComboBox.FormattingEnabled = True
        Me.Vertrieb_strategischComboBox.Location = New System.Drawing.Point(1046, 35)
        Me.Vertrieb_strategischComboBox.Name = "Vertrieb_strategischComboBox"
        Me.Vertrieb_strategischComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_strategischComboBox.TabIndex = 3
        '
        'Vertrieb_aussendienstComboBox
        '
        Me.Vertrieb_aussendienstComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_aussendienst", True))
        Me.Vertrieb_aussendienstComboBox.FormattingEnabled = True
        Me.Vertrieb_aussendienstComboBox.Location = New System.Drawing.Point(595, 35)
        Me.Vertrieb_aussendienstComboBox.Name = "Vertrieb_aussendienstComboBox"
        Me.Vertrieb_aussendienstComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_aussendienstComboBox.TabIndex = 2
        '
        'Vertrieb_innendienstComboBox
        '
        Me.Vertrieb_innendienstComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_vertriebBindingSource, "vertrieb_innendienst", True))
        Me.Vertrieb_innendienstComboBox.FormattingEnabled = True
        Me.Vertrieb_innendienstComboBox.Location = New System.Drawing.Point(203, 35)
        Me.Vertrieb_innendienstComboBox.Name = "Vertrieb_innendienstComboBox"
        Me.Vertrieb_innendienstComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Vertrieb_innendienstComboBox.TabIndex = 1
        '
        'Bewerber_vertriebTableAdapter
        '
        Me.Bewerber_vertriebTableAdapter.ClearBeforeFill = True
        '
        'frmVertrieb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1250, 571)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmVertrieb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vertrieb"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Bewerber_vertriebBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVertrieb As System.Windows.Forms.Button
    Friend WithEvents Vertrieb_sonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vertrieb_statistikComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_neukundengewinnungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_keyaccountComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_reklamationsbearbeitungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_auftragsbearbeitungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_kundenservice_callcenterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_kundenservice_telefonischComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_kundenservice_persönlichComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_nationalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_operativComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_strategischComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_aussendienstComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_innendienstComboBox As System.Windows.Forms.ComboBox
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
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vertrieb_weltweitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vertrieb_europaweitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bewerber_vertriebBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_vertriebTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_vertriebTableAdapter
End Class

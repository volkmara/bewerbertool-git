<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVersandLogistik
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
        Dim Versand_importLabel As System.Windows.Forms.Label
        Dim Versand_exportLabel As System.Windows.Forms.Label
        Dim Versand_lkw_frachtLabel As System.Windows.Forms.Label
        Dim Versand_luftfrachtLabel As System.Windows.Forms.Label
        Dim Versand_seefrachtLabel As System.Windows.Forms.Label
        Dim Versand_zollpapiereLabel As System.Windows.Forms.Label
        Dim Versand_akkreditiveLabel As System.Windows.Forms.Label
        Dim Versand_sonstigesLabel As System.Windows.Forms.Label
        Dim Logistik_warenannahmeLabel As System.Windows.Forms.Label
        Dim Logistik_wareneingangskontrolleLabel As System.Windows.Forms.Label
        Dim Logistik_lagerverwaltungLabel As System.Windows.Forms.Label
        Dim Logistik_warenbestandsueberwachungLabel As System.Windows.Forms.Label
        Dim Logistik_verhandlungenLabel As System.Windows.Forms.Label
        Dim Logistik_staplerscheinLabel As System.Windows.Forms.Label
        Dim Logistik_sonstigeLabel As System.Windows.Forms.Label
        Dim Logistik_lieferueberwachungLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Logistik_staplerscheinCheckBox = New System.Windows.Forms.CheckBox()
        Me.Bewerber_logistikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Logistik_lieferueberwachungComboBox = New System.Windows.Forms.ComboBox()
        Me.btnVersandLogistik = New System.Windows.Forms.Button()
        Me.Logistik_sonstigeTextBox = New System.Windows.Forms.TextBox()
        Me.Logistik_verhandlungenComboBox = New System.Windows.Forms.ComboBox()
        Me.Logistik_warenbestandsueberwachungComboBox = New System.Windows.Forms.ComboBox()
        Me.Logistik_lagerverwaltungComboBox = New System.Windows.Forms.ComboBox()
        Me.Logistik_wareneingangskontrolleComboBox = New System.Windows.Forms.ComboBox()
        Me.Logistik_warenannahmeComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Versand_sonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_versandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Versand_akkreditiveComboBox = New System.Windows.Forms.ComboBox()
        Me.Versand_zollpapiereComboBox = New System.Windows.Forms.ComboBox()
        Me.Versand_seefrachtComboBox = New System.Windows.Forms.ComboBox()
        Me.Versand_luftfrachtComboBox = New System.Windows.Forms.ComboBox()
        Me.Versand_lkw_frachtComboBox = New System.Windows.Forms.ComboBox()
        Me.Versand_exportComboBox = New System.Windows.Forms.ComboBox()
        Me.Versand_importComboBox = New System.Windows.Forms.ComboBox()
        Me.Bewerber_logistikTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_logistikTableAdapter()
        Me.Bewerber_versandTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_versandTableAdapter()
        Versand_importLabel = New System.Windows.Forms.Label()
        Versand_exportLabel = New System.Windows.Forms.Label()
        Versand_lkw_frachtLabel = New System.Windows.Forms.Label()
        Versand_luftfrachtLabel = New System.Windows.Forms.Label()
        Versand_seefrachtLabel = New System.Windows.Forms.Label()
        Versand_zollpapiereLabel = New System.Windows.Forms.Label()
        Versand_akkreditiveLabel = New System.Windows.Forms.Label()
        Versand_sonstigesLabel = New System.Windows.Forms.Label()
        Logistik_warenannahmeLabel = New System.Windows.Forms.Label()
        Logistik_wareneingangskontrolleLabel = New System.Windows.Forms.Label()
        Logistik_lagerverwaltungLabel = New System.Windows.Forms.Label()
        Logistik_warenbestandsueberwachungLabel = New System.Windows.Forms.Label()
        Logistik_verhandlungenLabel = New System.Windows.Forms.Label()
        Logistik_staplerscheinLabel = New System.Windows.Forms.Label()
        Logistik_sonstigeLabel = New System.Windows.Forms.Label()
        Logistik_lieferueberwachungLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Bewerber_logistikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Bewerber_versandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Versand_importLabel
        '
        Versand_importLabel.AutoSize = True
        Versand_importLabel.Location = New System.Drawing.Point(6, 26)
        Versand_importLabel.Name = "Versand_importLabel"
        Versand_importLabel.Size = New System.Drawing.Size(55, 16)
        Versand_importLabel.TabIndex = 0
        Versand_importLabel.Text = "Import:"
        '
        'Versand_exportLabel
        '
        Versand_exportLabel.AutoSize = True
        Versand_exportLabel.Location = New System.Drawing.Point(524, 26)
        Versand_exportLabel.Name = "Versand_exportLabel"
        Versand_exportLabel.Size = New System.Drawing.Size(56, 16)
        Versand_exportLabel.TabIndex = 2
        Versand_exportLabel.Text = "Export:"
        '
        'Versand_lkw_frachtLabel
        '
        Versand_lkw_frachtLabel.AutoSize = True
        Versand_lkw_frachtLabel.Location = New System.Drawing.Point(948, 26)
        Versand_lkw_frachtLabel.Name = "Versand_lkw_frachtLabel"
        Versand_lkw_frachtLabel.Size = New System.Drawing.Size(76, 16)
        Versand_lkw_frachtLabel.TabIndex = 4
        Versand_lkw_frachtLabel.Text = "Lkwfracht:"
        '
        'Versand_luftfrachtLabel
        '
        Versand_luftfrachtLabel.AutoSize = True
        Versand_luftfrachtLabel.Location = New System.Drawing.Point(6, 66)
        Versand_luftfrachtLabel.Name = "Versand_luftfrachtLabel"
        Versand_luftfrachtLabel.Size = New System.Drawing.Size(74, 16)
        Versand_luftfrachtLabel.TabIndex = 6
        Versand_luftfrachtLabel.Text = "Luftfracht:"
        '
        'Versand_seefrachtLabel
        '
        Versand_seefrachtLabel.AutoSize = True
        Versand_seefrachtLabel.Location = New System.Drawing.Point(504, 66)
        Versand_seefrachtLabel.Name = "Versand_seefrachtLabel"
        Versand_seefrachtLabel.Size = New System.Drawing.Size(78, 16)
        Versand_seefrachtLabel.TabIndex = 8
        Versand_seefrachtLabel.Text = "Seefracht:"
        '
        'Versand_zollpapiereLabel
        '
        Versand_zollpapiereLabel.AutoSize = True
        Versand_zollpapiereLabel.Location = New System.Drawing.Point(932, 66)
        Versand_zollpapiereLabel.Name = "Versand_zollpapiereLabel"
        Versand_zollpapiereLabel.Size = New System.Drawing.Size(92, 16)
        Versand_zollpapiereLabel.TabIndex = 10
        Versand_zollpapiereLabel.Text = "Zollpapiere:"
        '
        'Versand_akkreditiveLabel
        '
        Versand_akkreditiveLabel.AutoSize = True
        Versand_akkreditiveLabel.Location = New System.Drawing.Point(6, 105)
        Versand_akkreditiveLabel.Name = "Versand_akkreditiveLabel"
        Versand_akkreditiveLabel.Size = New System.Drawing.Size(90, 16)
        Versand_akkreditiveLabel.TabIndex = 12
        Versand_akkreditiveLabel.Text = "Akkreditive:"
        '
        'Versand_sonstigesLabel
        '
        Versand_sonstigesLabel.AutoSize = True
        Versand_sonstigesLabel.Location = New System.Drawing.Point(6, 141)
        Versand_sonstigesLabel.Name = "Versand_sonstigesLabel"
        Versand_sonstigesLabel.Size = New System.Drawing.Size(207, 16)
        Versand_sonstigesLabel.TabIndex = 14
        Versand_sonstigesLabel.Text = "Sonstige Versandtätigkeiten:"
        '
        'Logistik_warenannahmeLabel
        '
        Logistik_warenannahmeLabel.AutoSize = True
        Logistik_warenannahmeLabel.Location = New System.Drawing.Point(6, 37)
        Logistik_warenannahmeLabel.Name = "Logistik_warenannahmeLabel"
        Logistik_warenannahmeLabel.Size = New System.Drawing.Size(120, 16)
        Logistik_warenannahmeLabel.TabIndex = 0
        Logistik_warenannahmeLabel.Text = "Warenannahme:"
        '
        'Logistik_wareneingangskontrolleLabel
        '
        Logistik_wareneingangskontrolleLabel.AutoSize = True
        Logistik_wareneingangskontrolleLabel.Location = New System.Drawing.Point(395, 93)
        Logistik_wareneingangskontrolleLabel.Name = "Logistik_wareneingangskontrolleLabel"
        Logistik_wareneingangskontrolleLabel.Size = New System.Drawing.Size(181, 16)
        Logistik_wareneingangskontrolleLabel.TabIndex = 2
        Logistik_wareneingangskontrolleLabel.Text = "Wareneingangskontrolle:"
        '
        'Logistik_lagerverwaltungLabel
        '
        Logistik_lagerverwaltungLabel.AutoSize = True
        Logistik_lagerverwaltungLabel.Location = New System.Drawing.Point(450, 37)
        Logistik_lagerverwaltungLabel.Name = "Logistik_lagerverwaltungLabel"
        Logistik_lagerverwaltungLabel.Size = New System.Drawing.Size(126, 16)
        Logistik_lagerverwaltungLabel.TabIndex = 6
        Logistik_lagerverwaltungLabel.Text = "Lagerverwaltung:"
        '
        'Logistik_warenbestandsueberwachungLabel
        '
        Logistik_warenbestandsueberwachungLabel.AutoSize = True
        Logistik_warenbestandsueberwachungLabel.Location = New System.Drawing.Point(812, 93)
        Logistik_warenbestandsueberwachungLabel.Name = "Logistik_warenbestandsueberwachungLabel"
        Logistik_warenbestandsueberwachungLabel.Size = New System.Drawing.Size(212, 16)
        Logistik_warenbestandsueberwachungLabel.TabIndex = 8
        Logistik_warenbestandsueberwachungLabel.Text = "Warenbestandsüberwachung:"
        '
        'Logistik_verhandlungenLabel
        '
        Logistik_verhandlungenLabel.AutoSize = True
        Logistik_verhandlungenLabel.Location = New System.Drawing.Point(10, 93)
        Logistik_verhandlungenLabel.Name = "Logistik_verhandlungenLabel"
        Logistik_verhandlungenLabel.Size = New System.Drawing.Size(116, 16)
        Logistik_verhandlungenLabel.TabIndex = 10
        Logistik_verhandlungenLabel.Text = "Verhandlungen:"
        '
        'Logistik_staplerscheinLabel
        '
        Logistik_staplerscheinLabel.AutoSize = True
        Logistik_staplerscheinLabel.Location = New System.Drawing.Point(10, 141)
        Logistik_staplerscheinLabel.Name = "Logistik_staplerscheinLabel"
        Logistik_staplerscheinLabel.Size = New System.Drawing.Size(107, 16)
        Logistik_staplerscheinLabel.TabIndex = 12
        Logistik_staplerscheinLabel.Text = "Staplerschein:"
        '
        'Logistik_sonstigeLabel
        '
        Logistik_sonstigeLabel.AutoSize = True
        Logistik_sonstigeLabel.Location = New System.Drawing.Point(819, 137)
        Logistik_sonstigeLabel.Name = "Logistik_sonstigeLabel"
        Logistik_sonstigeLabel.Size = New System.Drawing.Size(138, 32)
        Logistik_sonstigeLabel.TabIndex = 14
        Logistik_sonstigeLabel.Text = "Sonstige" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Logistiktätigkeiten:"
        '
        'Logistik_lieferueberwachungLabel
        '
        Logistik_lieferueberwachungLabel.AutoSize = True
        Logistik_lieferueberwachungLabel.Location = New System.Drawing.Point(882, 37)
        Logistik_lieferueberwachungLabel.Name = "Logistik_lieferueberwachungLabel"
        Logistik_lieferueberwachungLabel.Size = New System.Drawing.Size(142, 16)
        Logistik_lieferueberwachungLabel.TabIndex = 18
        Logistik_lieferueberwachungLabel.Text = "Lieferüberwachung:"
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
        Me.Panel1.Size = New System.Drawing.Size(1243, 562)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1234, 22)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte in den Bereichen Versand und Logistik an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Logistik_staplerscheinCheckBox)
        Me.GroupBox2.Controls.Add(Logistik_lieferueberwachungLabel)
        Me.GroupBox2.Controls.Add(Me.Logistik_lieferueberwachungComboBox)
        Me.GroupBox2.Controls.Add(Me.btnVersandLogistik)
        Me.GroupBox2.Controls.Add(Logistik_sonstigeLabel)
        Me.GroupBox2.Controls.Add(Me.Logistik_sonstigeTextBox)
        Me.GroupBox2.Controls.Add(Logistik_staplerscheinLabel)
        Me.GroupBox2.Controls.Add(Logistik_verhandlungenLabel)
        Me.GroupBox2.Controls.Add(Me.Logistik_verhandlungenComboBox)
        Me.GroupBox2.Controls.Add(Logistik_warenbestandsueberwachungLabel)
        Me.GroupBox2.Controls.Add(Me.Logistik_warenbestandsueberwachungComboBox)
        Me.GroupBox2.Controls.Add(Logistik_lagerverwaltungLabel)
        Me.GroupBox2.Controls.Add(Me.Logistik_lagerverwaltungComboBox)
        Me.GroupBox2.Controls.Add(Logistik_wareneingangskontrolleLabel)
        Me.GroupBox2.Controls.Add(Me.Logistik_wareneingangskontrolleComboBox)
        Me.GroupBox2.Controls.Add(Me.Logistik_warenannahmeComboBox)
        Me.GroupBox2.Controls.Add(Logistik_warenannahmeLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1235, 285)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Logistik/Lager"
        '
        'Logistik_staplerscheinCheckBox
        '
        Me.Logistik_staplerscheinCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Bewerber_logistikBindingSource, "logistik_staplerschein", True))
        Me.Logistik_staplerscheinCheckBox.Location = New System.Drawing.Point(152, 137)
        Me.Logistik_staplerscheinCheckBox.Name = "Logistik_staplerscheinCheckBox"
        Me.Logistik_staplerscheinCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Logistik_staplerscheinCheckBox.TabIndex = 13
        Me.Logistik_staplerscheinCheckBox.Text = "Ja"
        Me.Logistik_staplerscheinCheckBox.UseVisualStyleBackColor = True
        '
        'Bewerber_logistikBindingSource
        '
        Me.Bewerber_logistikBindingSource.DataMember = "bewerber_logistik"
        Me.Bewerber_logistikBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Logistik_lieferueberwachungComboBox
        '
        Me.Logistik_lieferueberwachungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_logistikBindingSource, "logistik_lieferueberwachung", True))
        Me.Logistik_lieferueberwachungComboBox.FormattingEnabled = True
        Me.Logistik_lieferueberwachungComboBox.Location = New System.Drawing.Point(1030, 34)
        Me.Logistik_lieferueberwachungComboBox.Name = "Logistik_lieferueberwachungComboBox"
        Me.Logistik_lieferueberwachungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Logistik_lieferueberwachungComboBox.TabIndex = 5
        '
        'btnVersandLogistik
        '
        Me.btnVersandLogistik.BackColor = System.Drawing.Color.Wheat
        Me.btnVersandLogistik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnVersandLogistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVersandLogistik.Location = New System.Drawing.Point(585, 200)
        Me.btnVersandLogistik.Name = "btnVersandLogistik"
        Me.btnVersandLogistik.Size = New System.Drawing.Size(203, 60)
        Me.btnVersandLogistik.TabIndex = 16
        Me.btnVersandLogistik.Text = "Versand/Logistik" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnVersandLogistik.UseVisualStyleBackColor = False
        '
        'Logistik_sonstigeTextBox
        '
        Me.Logistik_sonstigeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_logistikBindingSource, "logistik_sonstige", True))
        Me.Logistik_sonstigeTextBox.Location = New System.Drawing.Point(963, 134)
        Me.Logistik_sonstigeTextBox.Multiline = True
        Me.Logistik_sonstigeTextBox.Name = "Logistik_sonstigeTextBox"
        Me.Logistik_sonstigeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Logistik_sonstigeTextBox.Size = New System.Drawing.Size(241, 126)
        Me.Logistik_sonstigeTextBox.TabIndex = 15
        '
        'Logistik_verhandlungenComboBox
        '
        Me.Logistik_verhandlungenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_logistikBindingSource, "logistik_verhandlungen", True))
        Me.Logistik_verhandlungenComboBox.FormattingEnabled = True
        Me.Logistik_verhandlungenComboBox.Location = New System.Drawing.Point(152, 90)
        Me.Logistik_verhandlungenComboBox.Name = "Logistik_verhandlungenComboBox"
        Me.Logistik_verhandlungenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Logistik_verhandlungenComboBox.TabIndex = 7
        '
        'Logistik_warenbestandsueberwachungComboBox
        '
        Me.Logistik_warenbestandsueberwachungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_logistikBindingSource, "logistik_warenbestandsueberwachung", True))
        Me.Logistik_warenbestandsueberwachungComboBox.FormattingEnabled = True
        Me.Logistik_warenbestandsueberwachungComboBox.Location = New System.Drawing.Point(1030, 90)
        Me.Logistik_warenbestandsueberwachungComboBox.Name = "Logistik_warenbestandsueberwachungComboBox"
        Me.Logistik_warenbestandsueberwachungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Logistik_warenbestandsueberwachungComboBox.TabIndex = 11
        '
        'Logistik_lagerverwaltungComboBox
        '
        Me.Logistik_lagerverwaltungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_logistikBindingSource, "logistik_lagerverwaltung", True))
        Me.Logistik_lagerverwaltungComboBox.FormattingEnabled = True
        Me.Logistik_lagerverwaltungComboBox.Location = New System.Drawing.Point(582, 34)
        Me.Logistik_lagerverwaltungComboBox.Name = "Logistik_lagerverwaltungComboBox"
        Me.Logistik_lagerverwaltungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Logistik_lagerverwaltungComboBox.TabIndex = 3
        '
        'Logistik_wareneingangskontrolleComboBox
        '
        Me.Logistik_wareneingangskontrolleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_logistikBindingSource, "logistik_wareneingangskontrolle", True))
        Me.Logistik_wareneingangskontrolleComboBox.FormattingEnabled = True
        Me.Logistik_wareneingangskontrolleComboBox.Location = New System.Drawing.Point(582, 90)
        Me.Logistik_wareneingangskontrolleComboBox.Name = "Logistik_wareneingangskontrolleComboBox"
        Me.Logistik_wareneingangskontrolleComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Logistik_wareneingangskontrolleComboBox.TabIndex = 9
        '
        'Logistik_warenannahmeComboBox
        '
        Me.Logistik_warenannahmeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_logistikBindingSource, "logistik_warenannahme", True))
        Me.Logistik_warenannahmeComboBox.FormattingEnabled = True
        Me.Logistik_warenannahmeComboBox.Location = New System.Drawing.Point(152, 34)
        Me.Logistik_warenannahmeComboBox.Name = "Logistik_warenannahmeComboBox"
        Me.Logistik_warenannahmeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Logistik_warenannahmeComboBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Versand_sonstigesLabel)
        Me.GroupBox1.Controls.Add(Me.Versand_sonstigesTextBox)
        Me.GroupBox1.Controls.Add(Versand_akkreditiveLabel)
        Me.GroupBox1.Controls.Add(Me.Versand_akkreditiveComboBox)
        Me.GroupBox1.Controls.Add(Versand_zollpapiereLabel)
        Me.GroupBox1.Controls.Add(Me.Versand_zollpapiereComboBox)
        Me.GroupBox1.Controls.Add(Versand_seefrachtLabel)
        Me.GroupBox1.Controls.Add(Me.Versand_seefrachtComboBox)
        Me.GroupBox1.Controls.Add(Versand_luftfrachtLabel)
        Me.GroupBox1.Controls.Add(Me.Versand_luftfrachtComboBox)
        Me.GroupBox1.Controls.Add(Versand_lkw_frachtLabel)
        Me.GroupBox1.Controls.Add(Me.Versand_lkw_frachtComboBox)
        Me.GroupBox1.Controls.Add(Versand_exportLabel)
        Me.GroupBox1.Controls.Add(Me.Versand_exportComboBox)
        Me.GroupBox1.Controls.Add(Me.Versand_importComboBox)
        Me.GroupBox1.Controls.Add(Versand_importLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1234, 241)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Versand"
        '
        'Versand_sonstigesTextBox
        '
        Me.Versand_sonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_versandBindingSource, "versand_sonstiges", True))
        Me.Versand_sonstigesTextBox.Location = New System.Drawing.Point(223, 141)
        Me.Versand_sonstigesTextBox.Multiline = True
        Me.Versand_sonstigesTextBox.Name = "Versand_sonstigesTextBox"
        Me.Versand_sonstigesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Versand_sonstigesTextBox.Size = New System.Drawing.Size(337, 85)
        Me.Versand_sonstigesTextBox.TabIndex = 8
        '
        'Bewerber_versandBindingSource
        '
        Me.Bewerber_versandBindingSource.DataMember = "bewerber_versand"
        Me.Bewerber_versandBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'Versand_akkreditiveComboBox
        '
        Me.Versand_akkreditiveComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_versandBindingSource, "versand_akkreditive", True))
        Me.Versand_akkreditiveComboBox.FormattingEnabled = True
        Me.Versand_akkreditiveComboBox.Location = New System.Drawing.Point(152, 102)
        Me.Versand_akkreditiveComboBox.Name = "Versand_akkreditiveComboBox"
        Me.Versand_akkreditiveComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Versand_akkreditiveComboBox.TabIndex = 7
        '
        'Versand_zollpapiereComboBox
        '
        Me.Versand_zollpapiereComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_versandBindingSource, "versand_zollpapiere", True))
        Me.Versand_zollpapiereComboBox.FormattingEnabled = True
        Me.Versand_zollpapiereComboBox.Location = New System.Drawing.Point(1030, 63)
        Me.Versand_zollpapiereComboBox.Name = "Versand_zollpapiereComboBox"
        Me.Versand_zollpapiereComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Versand_zollpapiereComboBox.TabIndex = 6
        '
        'Versand_seefrachtComboBox
        '
        Me.Versand_seefrachtComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_versandBindingSource, "versand_seefracht", True))
        Me.Versand_seefrachtComboBox.FormattingEnabled = True
        Me.Versand_seefrachtComboBox.Location = New System.Drawing.Point(582, 63)
        Me.Versand_seefrachtComboBox.Name = "Versand_seefrachtComboBox"
        Me.Versand_seefrachtComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Versand_seefrachtComboBox.TabIndex = 5
        '
        'Versand_luftfrachtComboBox
        '
        Me.Versand_luftfrachtComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_versandBindingSource, "versand_luftfracht", True))
        Me.Versand_luftfrachtComboBox.FormattingEnabled = True
        Me.Versand_luftfrachtComboBox.Location = New System.Drawing.Point(152, 63)
        Me.Versand_luftfrachtComboBox.Name = "Versand_luftfrachtComboBox"
        Me.Versand_luftfrachtComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Versand_luftfrachtComboBox.TabIndex = 4
        '
        'Versand_lkw_frachtComboBox
        '
        Me.Versand_lkw_frachtComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_versandBindingSource, "versand_lkw_fracht", True))
        Me.Versand_lkw_frachtComboBox.FormattingEnabled = True
        Me.Versand_lkw_frachtComboBox.Location = New System.Drawing.Point(1030, 23)
        Me.Versand_lkw_frachtComboBox.Name = "Versand_lkw_frachtComboBox"
        Me.Versand_lkw_frachtComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Versand_lkw_frachtComboBox.TabIndex = 3
        '
        'Versand_exportComboBox
        '
        Me.Versand_exportComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_versandBindingSource, "versand_export", True))
        Me.Versand_exportComboBox.FormattingEnabled = True
        Me.Versand_exportComboBox.Location = New System.Drawing.Point(582, 23)
        Me.Versand_exportComboBox.Name = "Versand_exportComboBox"
        Me.Versand_exportComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Versand_exportComboBox.TabIndex = 2
        '
        'Versand_importComboBox
        '
        Me.Versand_importComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_versandBindingSource, "versand_import", True))
        Me.Versand_importComboBox.FormattingEnabled = True
        Me.Versand_importComboBox.Location = New System.Drawing.Point(152, 23)
        Me.Versand_importComboBox.Name = "Versand_importComboBox"
        Me.Versand_importComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Versand_importComboBox.TabIndex = 1
        '
        'Bewerber_logistikTableAdapter
        '
        Me.Bewerber_logistikTableAdapter.ClearBeforeFill = True
        '
        'Bewerber_versandTableAdapter
        '
        Me.Bewerber_versandTableAdapter.ClearBeforeFill = True
        '
        'frmVersandLogistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1251, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmVersandLogistik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Versand und Logistik"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Bewerber_logistikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Bewerber_versandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Versand_akkreditiveComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Versand_zollpapiereComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Versand_seefrachtComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Versand_luftfrachtComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Versand_lkw_frachtComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Versand_exportComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Versand_importComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Versand_sonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Logistik_verhandlungenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Logistik_warenbestandsueberwachungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Logistik_lagerverwaltungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Logistik_wareneingangskontrolleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Logistik_warenannahmeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnVersandLogistik As System.Windows.Forms.Button
    Friend WithEvents Logistik_sonstigeTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bewerber_logistikBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_logistikTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_logistikTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bewerber_versandTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_versandTableAdapter
    Friend WithEvents Bewerber_versandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Logistik_lieferueberwachungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Logistik_staplerscheinCheckBox As System.Windows.Forms.CheckBox
End Class

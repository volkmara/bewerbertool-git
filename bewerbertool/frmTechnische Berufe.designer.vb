<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechnische_Berufe
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
        Dim Technik_maschinenbauLabel As System.Windows.Forms.Label
        Dim Technik_anlagenbauLabel As System.Windows.Forms.Label
        Dim Technik_konstruktionLabel As System.Windows.Forms.Label
        Dim Technik_dokumentationsunterlagenLabel As System.Windows.Forms.Label
        Dim Technik_techn_zeichnungenLabel As System.Windows.Forms.Label
        Dim Technik_stücklistenLabel As System.Windows.Forms.Label
        Dim Technik_projekt_inlandLabel As System.Windows.Forms.Label
        Dim Technik_projekt_auslandLabel As System.Windows.Forms.Label
        Dim Technik_steuerungLabel As System.Windows.Forms.Label
        Dim Technik_cncLabel As System.Windows.Forms.Label
        Dim Technik_cad2dLabel As System.Windows.Forms.Label
        Dim Technik_cad3dLabel As System.Windows.Forms.Label
        Dim Technik_fertigungLabel As System.Windows.Forms.Label
        Dim Technik_bauplanungLabel As System.Windows.Forms.Label
        Dim Technik_brandschutzLabel As System.Windows.Forms.Label
        Dim Technik_sonstigeLabel As System.Windows.Forms.Label
        Dim Technik_3dcadLabel As System.Windows.Forms.Label
        Dim Technik_allplanLabel As System.Windows.Forms.Label
        Dim Technik_arcadLabel As System.Windows.Forms.Label
        Dim Technik_autocad2dLabel As System.Windows.Forms.Label
        Dim Technik_autocad3dLabel As System.Windows.Forms.Label
        Dim Technik_autodeskLabel As System.Windows.Forms.Label
        Dim Technik_intellicadLabel As System.Windows.Forms.Label
        Dim Technik_hicadLabel As System.Windows.Forms.Label
        Dim Technik_inventorLabel As System.Windows.Forms.Label
        Dim Technik_megacadLabel As System.Windows.Forms.Label
        Dim Technik_microstationLabel As System.Windows.Forms.Label
        Dim Technik_solidedgeLabel As System.Windows.Forms.Label
        Dim Technik_solidworksLabel As System.Windows.Forms.Label
        Dim Technik_turbocadLabel As System.Windows.Forms.Label
        Dim Technik_software_sonstigeLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Technik_sonstigeTextBox = New System.Windows.Forms.TextBox()
        Me.Bewerber_technikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.Technik_brandschutzComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_bauplanungComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_fertigungComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_cad3dComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_cad2dComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_cncComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_steuerungComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_projekt_auslandComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_projekt_inlandComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_stücklistenComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_techn_zeichnungenComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_dokumentationsunterlagenComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_konstruktionComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_anlagenbauComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_maschinenbauComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTechnischeBerufeSoftware = New System.Windows.Forms.Button()
        Me.Technik_software_sonstigeTextBox = New System.Windows.Forms.TextBox()
        Me.Technik_turbocadComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_solidworksComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_solidedgeComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_microstationComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_megacadComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_inventorComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_hicadComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_intellicadComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_autodeskComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_autocad3dComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_autocad2dComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_arcadComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_allplanComboBox = New System.Windows.Forms.ComboBox()
        Me.Technik_3dcadComboBox = New System.Windows.Forms.ComboBox()
        Me.Bewerber_technikTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_technikTableAdapter()
        Technik_maschinenbauLabel = New System.Windows.Forms.Label()
        Technik_anlagenbauLabel = New System.Windows.Forms.Label()
        Technik_konstruktionLabel = New System.Windows.Forms.Label()
        Technik_dokumentationsunterlagenLabel = New System.Windows.Forms.Label()
        Technik_techn_zeichnungenLabel = New System.Windows.Forms.Label()
        Technik_stücklistenLabel = New System.Windows.Forms.Label()
        Technik_projekt_inlandLabel = New System.Windows.Forms.Label()
        Technik_projekt_auslandLabel = New System.Windows.Forms.Label()
        Technik_steuerungLabel = New System.Windows.Forms.Label()
        Technik_cncLabel = New System.Windows.Forms.Label()
        Technik_cad2dLabel = New System.Windows.Forms.Label()
        Technik_cad3dLabel = New System.Windows.Forms.Label()
        Technik_fertigungLabel = New System.Windows.Forms.Label()
        Technik_bauplanungLabel = New System.Windows.Forms.Label()
        Technik_brandschutzLabel = New System.Windows.Forms.Label()
        Technik_sonstigeLabel = New System.Windows.Forms.Label()
        Technik_3dcadLabel = New System.Windows.Forms.Label()
        Technik_allplanLabel = New System.Windows.Forms.Label()
        Technik_arcadLabel = New System.Windows.Forms.Label()
        Technik_autocad2dLabel = New System.Windows.Forms.Label()
        Technik_autocad3dLabel = New System.Windows.Forms.Label()
        Technik_autodeskLabel = New System.Windows.Forms.Label()
        Technik_intellicadLabel = New System.Windows.Forms.Label()
        Technik_hicadLabel = New System.Windows.Forms.Label()
        Technik_inventorLabel = New System.Windows.Forms.Label()
        Technik_megacadLabel = New System.Windows.Forms.Label()
        Technik_microstationLabel = New System.Windows.Forms.Label()
        Technik_solidedgeLabel = New System.Windows.Forms.Label()
        Technik_solidworksLabel = New System.Windows.Forms.Label()
        Technik_turbocadLabel = New System.Windows.Forms.Label()
        Technik_software_sonstigeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Bewerber_technikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Technik_maschinenbauLabel
        '
        Technik_maschinenbauLabel.AutoSize = True
        Technik_maschinenbauLabel.Location = New System.Drawing.Point(6, 26)
        Technik_maschinenbauLabel.Name = "Technik_maschinenbauLabel"
        Technik_maschinenbauLabel.Size = New System.Drawing.Size(112, 16)
        Technik_maschinenbauLabel.TabIndex = 0
        Technik_maschinenbauLabel.Text = "Maschinenbau:"
        '
        'Technik_anlagenbauLabel
        '
        Technik_anlagenbauLabel.AutoSize = True
        Technik_anlagenbauLabel.Location = New System.Drawing.Point(477, 26)
        Technik_anlagenbauLabel.Name = "Technik_anlagenbauLabel"
        Technik_anlagenbauLabel.Size = New System.Drawing.Size(95, 16)
        Technik_anlagenbauLabel.TabIndex = 2
        Technik_anlagenbauLabel.Text = "Anlagenbau:"
        '
        'Technik_konstruktionLabel
        '
        Technik_konstruktionLabel.AutoSize = True
        Technik_konstruktionLabel.Location = New System.Drawing.Point(6, 75)
        Technik_konstruktionLabel.Name = "Technik_konstruktionLabel"
        Technik_konstruktionLabel.Size = New System.Drawing.Size(96, 16)
        Technik_konstruktionLabel.TabIndex = 4
        Technik_konstruktionLabel.Text = "Konstruktion:"
        '
        'Technik_dokumentationsunterlagenLabel
        '
        Technik_dokumentationsunterlagenLabel.AutoSize = True
        Technik_dokumentationsunterlagenLabel.Location = New System.Drawing.Point(805, 26)
        Technik_dokumentationsunterlagenLabel.Name = "Technik_dokumentationsunterlagenLabel"
        Technik_dokumentationsunterlagenLabel.Size = New System.Drawing.Size(216, 16)
        Technik_dokumentationsunterlagenLabel.TabIndex = 6
        Technik_dokumentationsunterlagenLabel.Text = "Technische Dokumentationen:"
        '
        'Technik_techn_zeichnungenLabel
        '
        Technik_techn_zeichnungenLabel.AutoSize = True
        Technik_techn_zeichnungenLabel.Location = New System.Drawing.Point(837, 122)
        Technik_techn_zeichnungenLabel.Name = "Technik_techn_zeichnungenLabel"
        Technik_techn_zeichnungenLabel.Size = New System.Drawing.Size(184, 16)
        Technik_techn_zeichnungenLabel.TabIndex = 8
        Technik_techn_zeichnungenLabel.Text = "Technische Zeichnungen:"
        '
        'Technik_stücklistenLabel
        '
        Technik_stücklistenLabel.AutoSize = True
        Technik_stücklistenLabel.Location = New System.Drawing.Point(6, 122)
        Technik_stücklistenLabel.Name = "Technik_stücklistenLabel"
        Technik_stücklistenLabel.Size = New System.Drawing.Size(87, 16)
        Technik_stücklistenLabel.TabIndex = 10
        Technik_stücklistenLabel.Text = "Stücklisten:"
        '
        'Technik_projekt_inlandLabel
        '
        Technik_projekt_inlandLabel.AutoSize = True
        Technik_projekt_inlandLabel.Location = New System.Drawing.Point(395, 75)
        Technik_projekt_inlandLabel.Name = "Technik_projekt_inlandLabel"
        Technik_projekt_inlandLabel.Size = New System.Drawing.Size(180, 16)
        Technik_projekt_inlandLabel.TabIndex = 12
        Technik_projekt_inlandLabel.Text = "Projektbegleitung Inland:"
        '
        'Technik_projekt_auslandLabel
        '
        Technik_projekt_auslandLabel.AutoSize = True
        Technik_projekt_auslandLabel.Location = New System.Drawing.Point(827, 75)
        Technik_projekt_auslandLabel.Name = "Technik_projekt_auslandLabel"
        Technik_projekt_auslandLabel.Size = New System.Drawing.Size(194, 16)
        Technik_projekt_auslandLabel.TabIndex = 14
        Technik_projekt_auslandLabel.Text = "Projektbegleitung Ausland:"
        '
        'Technik_steuerungLabel
        '
        Technik_steuerungLabel.AutoSize = True
        Technik_steuerungLabel.Location = New System.Drawing.Point(371, 122)
        Technik_steuerungLabel.Name = "Technik_steuerungLabel"
        Technik_steuerungLabel.Size = New System.Drawing.Size(201, 16)
        Technik_steuerungLabel.TabIndex = 16
        Technik_steuerungLabel.Text = "Steuerung, Automatisierung:"
        '
        'Technik_cncLabel
        '
        Technik_cncLabel.AutoSize = True
        Technik_cncLabel.Location = New System.Drawing.Point(6, 163)
        Technik_cncLabel.Name = "Technik_cncLabel"
        Technik_cncLabel.Size = New System.Drawing.Size(43, 16)
        Technik_cncLabel.TabIndex = 18
        Technik_cncLabel.Text = "CNC:"
        '
        'Technik_cad2dLabel
        '
        Technik_cad2dLabel.AutoSize = True
        Technik_cad2dLabel.Location = New System.Drawing.Point(508, 163)
        Technik_cad2dLabel.Name = "Technik_cad2dLabel"
        Technik_cad2dLabel.Size = New System.Drawing.Size(66, 16)
        Technik_cad2dLabel.TabIndex = 20
        Technik_cad2dLabel.Text = "CAD 2D:"
        '
        'Technik_cad3dLabel
        '
        Technik_cad3dLabel.AutoSize = True
        Technik_cad3dLabel.Location = New System.Drawing.Point(957, 163)
        Technik_cad3dLabel.Name = "Technik_cad3dLabel"
        Technik_cad3dLabel.Size = New System.Drawing.Size(66, 16)
        Technik_cad3dLabel.TabIndex = 22
        Technik_cad3dLabel.Text = "CAD 3D:"
        '
        'Technik_fertigungLabel
        '
        Technik_fertigungLabel.AutoSize = True
        Technik_fertigungLabel.Location = New System.Drawing.Point(6, 213)
        Technik_fertigungLabel.Name = "Technik_fertigungLabel"
        Technik_fertigungLabel.Size = New System.Drawing.Size(145, 16)
        Technik_fertigungLabel.TabIndex = 24
        Technik_fertigungLabel.Text = "Fertigung, Montage:"
        '
        'Technik_bauplanungLabel
        '
        Technik_bauplanungLabel.AutoSize = True
        Technik_bauplanungLabel.Location = New System.Drawing.Point(374, 213)
        Technik_bauplanungLabel.Name = "Technik_bauplanungLabel"
        Technik_bauplanungLabel.Size = New System.Drawing.Size(198, 16)
        Technik_bauplanungLabel.TabIndex = 26
        Technik_bauplanungLabel.Text = "Bauplanung, Bauzeichnung:"
        '
        'Technik_brandschutzLabel
        '
        Technik_brandschutzLabel.AutoSize = True
        Technik_brandschutzLabel.Location = New System.Drawing.Point(925, 213)
        Technik_brandschutzLabel.Name = "Technik_brandschutzLabel"
        Technik_brandschutzLabel.Size = New System.Drawing.Size(96, 16)
        Technik_brandschutzLabel.TabIndex = 28
        Technik_brandschutzLabel.Text = "Brandschutz:"
        '
        'Technik_sonstigeLabel
        '
        Technik_sonstigeLabel.AutoSize = True
        Technik_sonstigeLabel.Location = New System.Drawing.Point(5, 269)
        Technik_sonstigeLabel.Name = "Technik_sonstigeLabel"
        Technik_sonstigeLabel.Size = New System.Drawing.Size(147, 32)
        Technik_sonstigeLabel.TabIndex = 30
        Technik_sonstigeLabel.Text = "Sonstige technische" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Berufserfahrung:"
        '
        'Technik_3dcadLabel
        '
        Technik_3dcadLabel.AutoSize = True
        Technik_3dcadLabel.Location = New System.Drawing.Point(6, 26)
        Technik_3dcadLabel.Name = "Technik_3dcadLabel"
        Technik_3dcadLabel.Size = New System.Drawing.Size(60, 16)
        Technik_3dcadLabel.TabIndex = 22
        Technik_3dcadLabel.Text = "3dCAD:"
        '
        'Technik_allplanLabel
        '
        Technik_allplanLabel.AutoSize = True
        Technik_allplanLabel.Location = New System.Drawing.Point(512, 26)
        Technik_allplanLabel.Name = "Technik_allplanLabel"
        Technik_allplanLabel.Size = New System.Drawing.Size(60, 16)
        Technik_allplanLabel.TabIndex = 23
        Technik_allplanLabel.Text = "Allplan:"
        '
        'Technik_arcadLabel
        '
        Technik_arcadLabel.AutoSize = True
        Technik_arcadLabel.Location = New System.Drawing.Point(962, 26)
        Technik_arcadLabel.Name = "Technik_arcadLabel"
        Technik_arcadLabel.Size = New System.Drawing.Size(57, 16)
        Technik_arcadLabel.TabIndex = 24
        Technik_arcadLabel.Text = "arCAD:"
        '
        'Technik_autocad2dLabel
        '
        Technik_autocad2dLabel.AutoSize = True
        Technik_autocad2dLabel.Location = New System.Drawing.Point(6, 75)
        Technik_autocad2dLabel.Name = "Technik_autocad2dLabel"
        Technik_autocad2dLabel.Size = New System.Drawing.Size(97, 16)
        Technik_autocad2dLabel.TabIndex = 25
        Technik_autocad2dLabel.Text = "AutoCAD 2D:"
        '
        'Technik_autocad3dLabel
        '
        Technik_autocad3dLabel.AutoSize = True
        Technik_autocad3dLabel.Location = New System.Drawing.Point(477, 75)
        Technik_autocad3dLabel.Name = "Technik_autocad3dLabel"
        Technik_autocad3dLabel.Size = New System.Drawing.Size(97, 16)
        Technik_autocad3dLabel.TabIndex = 26
        Technik_autocad3dLabel.Text = "AutoCAD 3D:"
        '
        'Technik_autodeskLabel
        '
        Technik_autodeskLabel.AutoSize = True
        Technik_autodeskLabel.Location = New System.Drawing.Point(952, 75)
        Technik_autodeskLabel.Name = "Technik_autodeskLabel"
        Technik_autodeskLabel.Size = New System.Drawing.Size(77, 16)
        Technik_autodeskLabel.TabIndex = 27
        Technik_autodeskLabel.Text = "Autodesk:"
        '
        'Technik_intellicadLabel
        '
        Technik_intellicadLabel.AutoSize = True
        Technik_intellicadLabel.Location = New System.Drawing.Point(6, 128)
        Technik_intellicadLabel.Name = "Technik_intellicadLabel"
        Technik_intellicadLabel.Size = New System.Drawing.Size(80, 16)
        Technik_intellicadLabel.TabIndex = 28
        Technik_intellicadLabel.Text = "IntelliCAD:"
        '
        'Technik_hicadLabel
        '
        Technik_hicadLabel.AutoSize = True
        Technik_hicadLabel.Location = New System.Drawing.Point(508, 128)
        Technik_hicadLabel.Name = "Technik_hicadLabel"
        Technik_hicadLabel.Size = New System.Drawing.Size(58, 16)
        Technik_hicadLabel.TabIndex = 29
        Technik_hicadLabel.Text = "HiCAD:"
        '
        'Technik_inventorLabel
        '
        Technik_inventorLabel.AutoSize = True
        Technik_inventorLabel.Location = New System.Drawing.Point(962, 128)
        Technik_inventorLabel.Name = "Technik_inventorLabel"
        Technik_inventorLabel.Size = New System.Drawing.Size(67, 16)
        Technik_inventorLabel.TabIndex = 30
        Technik_inventorLabel.Text = "Inventor:"
        '
        'Technik_megacadLabel
        '
        Technik_megacadLabel.AutoSize = True
        Technik_megacadLabel.Location = New System.Drawing.Point(947, 174)
        Technik_megacadLabel.Name = "Technik_megacadLabel"
        Technik_megacadLabel.Size = New System.Drawing.Size(82, 16)
        Technik_megacadLabel.TabIndex = 31
        Technik_megacadLabel.Text = "MegaCAD:"
        '
        'Technik_microstationLabel
        '
        Technik_microstationLabel.AutoSize = True
        Technik_microstationLabel.Location = New System.Drawing.Point(5, 220)
        Technik_microstationLabel.Name = "Technik_microstationLabel"
        Technik_microstationLabel.Size = New System.Drawing.Size(96, 16)
        Technik_microstationLabel.TabIndex = 32
        Technik_microstationLabel.Text = "Microstation:"
        '
        'Technik_solidedgeLabel
        '
        Technik_solidedgeLabel.AutoSize = True
        Technik_solidedgeLabel.Location = New System.Drawing.Point(488, 220)
        Technik_solidedgeLabel.Name = "Technik_solidedgeLabel"
        Technik_solidedgeLabel.Size = New System.Drawing.Size(84, 16)
        Technik_solidedgeLabel.TabIndex = 33
        Technik_solidedgeLabel.Text = "Solidedge:"
        '
        'Technik_solidworksLabel
        '
        Technik_solidworksLabel.AutoSize = True
        Technik_solidworksLabel.Location = New System.Drawing.Point(6, 174)
        Technik_solidworksLabel.Name = "Technik_solidworksLabel"
        Technik_solidworksLabel.Size = New System.Drawing.Size(88, 16)
        Technik_solidworksLabel.TabIndex = 34
        Technik_solidworksLabel.Text = "Solidworks:"
        '
        'Technik_turbocadLabel
        '
        Technik_turbocadLabel.AutoSize = True
        Technik_turbocadLabel.Location = New System.Drawing.Point(485, 174)
        Technik_turbocadLabel.Name = "Technik_turbocadLabel"
        Technik_turbocadLabel.Size = New System.Drawing.Size(84, 16)
        Technik_turbocadLabel.TabIndex = 35
        Technik_turbocadLabel.Text = "TurboCAD:"
        '
        'Technik_software_sonstigeLabel
        '
        Technik_software_sonstigeLabel.AutoSize = True
        Technik_software_sonstigeLabel.Location = New System.Drawing.Point(6, 265)
        Technik_software_sonstigeLabel.Name = "Technik_software_sonstigeLabel"
        Technik_software_sonstigeLabel.Size = New System.Drawing.Size(86, 64)
        Technik_software_sonstigeLabel.TabIndex = 36
        Technik_software_sonstigeLabel.Text = "Sonstige " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "technische " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Software-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kenntnisse:"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1248, 763)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1238, 24)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte in technischen Berufen und technischer Software" & _
    " an:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Technik_sonstigeLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_sonstigeTextBox)
        Me.GroupBox1.Controls.Add(Technik_brandschutzLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_brandschutzComboBox)
        Me.GroupBox1.Controls.Add(Technik_bauplanungLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_bauplanungComboBox)
        Me.GroupBox1.Controls.Add(Technik_fertigungLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_fertigungComboBox)
        Me.GroupBox1.Controls.Add(Technik_cad3dLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_cad3dComboBox)
        Me.GroupBox1.Controls.Add(Technik_cad2dLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_cad2dComboBox)
        Me.GroupBox1.Controls.Add(Technik_cncLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_cncComboBox)
        Me.GroupBox1.Controls.Add(Technik_steuerungLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_steuerungComboBox)
        Me.GroupBox1.Controls.Add(Technik_projekt_auslandLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_projekt_auslandComboBox)
        Me.GroupBox1.Controls.Add(Technik_projekt_inlandLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_projekt_inlandComboBox)
        Me.GroupBox1.Controls.Add(Technik_stücklistenLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_stücklistenComboBox)
        Me.GroupBox1.Controls.Add(Technik_techn_zeichnungenLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_techn_zeichnungenComboBox)
        Me.GroupBox1.Controls.Add(Technik_dokumentationsunterlagenLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_dokumentationsunterlagenComboBox)
        Me.GroupBox1.Controls.Add(Technik_konstruktionLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_konstruktionComboBox)
        Me.GroupBox1.Controls.Add(Technik_anlagenbauLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_anlagenbauComboBox)
        Me.GroupBox1.Controls.Add(Technik_maschinenbauLabel)
        Me.GroupBox1.Controls.Add(Me.Technik_maschinenbauComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1237, 348)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technische Berufe"
        '
        'Technik_sonstigeTextBox
        '
        Me.Technik_sonstigeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_sonstige", True))
        Me.Technik_sonstigeTextBox.Location = New System.Drawing.Point(170, 266)
        Me.Technik_sonstigeTextBox.Multiline = True
        Me.Technik_sonstigeTextBox.Name = "Technik_sonstigeTextBox"
        Me.Technik_sonstigeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Technik_sonstigeTextBox.Size = New System.Drawing.Size(405, 70)
        Me.Technik_sonstigeTextBox.TabIndex = 16
        '
        'Bewerber_technikBindingSource
        '
        Me.Bewerber_technikBindingSource.DataMember = "bewerber_technik"
        Me.Bewerber_technikBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Technik_brandschutzComboBox
        '
        Me.Technik_brandschutzComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_brandschutz", True))
        Me.Technik_brandschutzComboBox.FormattingEnabled = True
        Me.Technik_brandschutzComboBox.Location = New System.Drawing.Point(1030, 210)
        Me.Technik_brandschutzComboBox.Name = "Technik_brandschutzComboBox"
        Me.Technik_brandschutzComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_brandschutzComboBox.TabIndex = 15
        '
        'Technik_bauplanungComboBox
        '
        Me.Technik_bauplanungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_bauplanung", True))
        Me.Technik_bauplanungComboBox.FormattingEnabled = True
        Me.Technik_bauplanungComboBox.Location = New System.Drawing.Point(585, 210)
        Me.Technik_bauplanungComboBox.Name = "Technik_bauplanungComboBox"
        Me.Technik_bauplanungComboBox.Size = New System.Drawing.Size(171, 24)
        Me.Technik_bauplanungComboBox.TabIndex = 14
        '
        'Technik_fertigungComboBox
        '
        Me.Technik_fertigungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_fertigung", True))
        Me.Technik_fertigungComboBox.FormattingEnabled = True
        Me.Technik_fertigungComboBox.Location = New System.Drawing.Point(170, 210)
        Me.Technik_fertigungComboBox.Name = "Technik_fertigungComboBox"
        Me.Technik_fertigungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_fertigungComboBox.TabIndex = 13
        '
        'Technik_cad3dComboBox
        '
        Me.Technik_cad3dComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_cad3d", True))
        Me.Technik_cad3dComboBox.FormattingEnabled = True
        Me.Technik_cad3dComboBox.Location = New System.Drawing.Point(1030, 160)
        Me.Technik_cad3dComboBox.Name = "Technik_cad3dComboBox"
        Me.Technik_cad3dComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_cad3dComboBox.TabIndex = 12
        '
        'Technik_cad2dComboBox
        '
        Me.Technik_cad2dComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_cad2d", True))
        Me.Technik_cad2dComboBox.FormattingEnabled = True
        Me.Technik_cad2dComboBox.Location = New System.Drawing.Point(585, 160)
        Me.Technik_cad2dComboBox.Name = "Technik_cad2dComboBox"
        Me.Technik_cad2dComboBox.Size = New System.Drawing.Size(171, 24)
        Me.Technik_cad2dComboBox.TabIndex = 11
        '
        'Technik_cncComboBox
        '
        Me.Technik_cncComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_cnc", True))
        Me.Technik_cncComboBox.FormattingEnabled = True
        Me.Technik_cncComboBox.Location = New System.Drawing.Point(170, 160)
        Me.Technik_cncComboBox.Name = "Technik_cncComboBox"
        Me.Technik_cncComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_cncComboBox.TabIndex = 10
        '
        'Technik_steuerungComboBox
        '
        Me.Technik_steuerungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_steuerung", True))
        Me.Technik_steuerungComboBox.FormattingEnabled = True
        Me.Technik_steuerungComboBox.Location = New System.Drawing.Point(585, 119)
        Me.Technik_steuerungComboBox.Name = "Technik_steuerungComboBox"
        Me.Technik_steuerungComboBox.Size = New System.Drawing.Size(171, 24)
        Me.Technik_steuerungComboBox.TabIndex = 8
        '
        'Technik_projekt_auslandComboBox
        '
        Me.Technik_projekt_auslandComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_projekt_ausland", True))
        Me.Technik_projekt_auslandComboBox.FormattingEnabled = True
        Me.Technik_projekt_auslandComboBox.Location = New System.Drawing.Point(1030, 72)
        Me.Technik_projekt_auslandComboBox.Name = "Technik_projekt_auslandComboBox"
        Me.Technik_projekt_auslandComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_projekt_auslandComboBox.TabIndex = 6
        '
        'Technik_projekt_inlandComboBox
        '
        Me.Technik_projekt_inlandComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_projekt_inland", True))
        Me.Technik_projekt_inlandComboBox.FormattingEnabled = True
        Me.Technik_projekt_inlandComboBox.Location = New System.Drawing.Point(585, 72)
        Me.Technik_projekt_inlandComboBox.Name = "Technik_projekt_inlandComboBox"
        Me.Technik_projekt_inlandComboBox.Size = New System.Drawing.Size(171, 24)
        Me.Technik_projekt_inlandComboBox.TabIndex = 5
        '
        'Technik_stücklistenComboBox
        '
        Me.Technik_stücklistenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_stücklisten", True))
        Me.Technik_stücklistenComboBox.FormattingEnabled = True
        Me.Technik_stücklistenComboBox.Location = New System.Drawing.Point(170, 119)
        Me.Technik_stücklistenComboBox.Name = "Technik_stücklistenComboBox"
        Me.Technik_stücklistenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_stücklistenComboBox.TabIndex = 7
        '
        'Technik_techn_zeichnungenComboBox
        '
        Me.Technik_techn_zeichnungenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_techn_zeichnungen", True))
        Me.Technik_techn_zeichnungenComboBox.FormattingEnabled = True
        Me.Technik_techn_zeichnungenComboBox.Location = New System.Drawing.Point(1030, 119)
        Me.Technik_techn_zeichnungenComboBox.Name = "Technik_techn_zeichnungenComboBox"
        Me.Technik_techn_zeichnungenComboBox.Size = New System.Drawing.Size(176, 24)
        Me.Technik_techn_zeichnungenComboBox.TabIndex = 9
        '
        'Technik_dokumentationsunterlagenComboBox
        '
        Me.Technik_dokumentationsunterlagenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_dokumentationsunterlagen", True))
        Me.Technik_dokumentationsunterlagenComboBox.FormattingEnabled = True
        Me.Technik_dokumentationsunterlagenComboBox.Location = New System.Drawing.Point(1030, 20)
        Me.Technik_dokumentationsunterlagenComboBox.Name = "Technik_dokumentationsunterlagenComboBox"
        Me.Technik_dokumentationsunterlagenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_dokumentationsunterlagenComboBox.TabIndex = 3
        '
        'Technik_konstruktionComboBox
        '
        Me.Technik_konstruktionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_konstruktion", True))
        Me.Technik_konstruktionComboBox.FormattingEnabled = True
        Me.Technik_konstruktionComboBox.Location = New System.Drawing.Point(170, 72)
        Me.Technik_konstruktionComboBox.Name = "Technik_konstruktionComboBox"
        Me.Technik_konstruktionComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_konstruktionComboBox.TabIndex = 4
        '
        'Technik_anlagenbauComboBox
        '
        Me.Technik_anlagenbauComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_anlagenbau", True))
        Me.Technik_anlagenbauComboBox.FormattingEnabled = True
        Me.Technik_anlagenbauComboBox.Location = New System.Drawing.Point(582, 23)
        Me.Technik_anlagenbauComboBox.Name = "Technik_anlagenbauComboBox"
        Me.Technik_anlagenbauComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_anlagenbauComboBox.TabIndex = 2
        '
        'Technik_maschinenbauComboBox
        '
        Me.Technik_maschinenbauComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_maschinenbau", True))
        Me.Technik_maschinenbauComboBox.FormattingEnabled = True
        Me.Technik_maschinenbauComboBox.Location = New System.Drawing.Point(170, 23)
        Me.Technik_maschinenbauComboBox.Name = "Technik_maschinenbauComboBox"
        Me.Technik_maschinenbauComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_maschinenbauComboBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.btnTechnischeBerufeSoftware)
        Me.GroupBox2.Controls.Add(Technik_software_sonstigeLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_software_sonstigeTextBox)
        Me.GroupBox2.Controls.Add(Technik_turbocadLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_turbocadComboBox)
        Me.GroupBox2.Controls.Add(Technik_solidworksLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_solidworksComboBox)
        Me.GroupBox2.Controls.Add(Technik_solidedgeLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_solidedgeComboBox)
        Me.GroupBox2.Controls.Add(Technik_microstationLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_microstationComboBox)
        Me.GroupBox2.Controls.Add(Technik_megacadLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_megacadComboBox)
        Me.GroupBox2.Controls.Add(Technik_inventorLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_inventorComboBox)
        Me.GroupBox2.Controls.Add(Technik_hicadLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_hicadComboBox)
        Me.GroupBox2.Controls.Add(Technik_intellicadLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_intellicadComboBox)
        Me.GroupBox2.Controls.Add(Technik_autodeskLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_autodeskComboBox)
        Me.GroupBox2.Controls.Add(Technik_autocad3dLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_autocad3dComboBox)
        Me.GroupBox2.Controls.Add(Technik_autocad2dLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_autocad2dComboBox)
        Me.GroupBox2.Controls.Add(Technik_arcadLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_arcadComboBox)
        Me.GroupBox2.Controls.Add(Technik_allplanLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_allplanComboBox)
        Me.GroupBox2.Controls.Add(Technik_3dcadLabel)
        Me.GroupBox2.Controls.Add(Me.Technik_3dcadComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 383)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1237, 375)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Technische Spezialsoftware"
        '
        'btnTechnischeBerufeSoftware
        '
        Me.btnTechnischeBerufeSoftware.BackColor = System.Drawing.Color.Wheat
        Me.btnTechnischeBerufeSoftware.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnTechnischeBerufeSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTechnischeBerufeSoftware.Location = New System.Drawing.Point(647, 299)
        Me.btnTechnischeBerufeSoftware.Name = "btnTechnischeBerufeSoftware"
        Me.btnTechnischeBerufeSoftware.Size = New System.Drawing.Size(203, 60)
        Me.btnTechnischeBerufeSoftware.TabIndex = 38
        Me.btnTechnischeBerufeSoftware.Text = "Technische Berufe/Software " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kenntnisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnTechnischeBerufeSoftware.UseVisualStyleBackColor = False
        '
        'Technik_software_sonstigeTextBox
        '
        Me.Technik_software_sonstigeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_software_sonstige", True))
        Me.Technik_software_sonstigeTextBox.Location = New System.Drawing.Point(152, 262)
        Me.Technik_software_sonstigeTextBox.Multiline = True
        Me.Technik_software_sonstigeTextBox.Name = "Technik_software_sonstigeTextBox"
        Me.Technik_software_sonstigeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Technik_software_sonstigeTextBox.Size = New System.Drawing.Size(448, 97)
        Me.Technik_software_sonstigeTextBox.TabIndex = 15
        '
        'Technik_turbocadComboBox
        '
        Me.Technik_turbocadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_turbocad", True))
        Me.Technik_turbocadComboBox.FormattingEnabled = True
        Me.Technik_turbocadComboBox.Location = New System.Drawing.Point(582, 171)
        Me.Technik_turbocadComboBox.Name = "Technik_turbocadComboBox"
        Me.Technik_turbocadComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_turbocadComboBox.TabIndex = 11
        '
        'Technik_solidworksComboBox
        '
        Me.Technik_solidworksComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_solidworks", True))
        Me.Technik_solidworksComboBox.FormattingEnabled = True
        Me.Technik_solidworksComboBox.Location = New System.Drawing.Point(152, 171)
        Me.Technik_solidworksComboBox.Name = "Technik_solidworksComboBox"
        Me.Technik_solidworksComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_solidworksComboBox.TabIndex = 10
        '
        'Technik_solidedgeComboBox
        '
        Me.Technik_solidedgeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_solidedge", True))
        Me.Technik_solidedgeComboBox.FormattingEnabled = True
        Me.Technik_solidedgeComboBox.Location = New System.Drawing.Point(582, 217)
        Me.Technik_solidedgeComboBox.Name = "Technik_solidedgeComboBox"
        Me.Technik_solidedgeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_solidedgeComboBox.TabIndex = 14
        '
        'Technik_microstationComboBox
        '
        Me.Technik_microstationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_microstation", True))
        Me.Technik_microstationComboBox.FormattingEnabled = True
        Me.Technik_microstationComboBox.Location = New System.Drawing.Point(152, 217)
        Me.Technik_microstationComboBox.Name = "Technik_microstationComboBox"
        Me.Technik_microstationComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_microstationComboBox.TabIndex = 13
        '
        'Technik_megacadComboBox
        '
        Me.Technik_megacadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_megacad", True))
        Me.Technik_megacadComboBox.FormattingEnabled = True
        Me.Technik_megacadComboBox.Location = New System.Drawing.Point(1030, 171)
        Me.Technik_megacadComboBox.Name = "Technik_megacadComboBox"
        Me.Technik_megacadComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_megacadComboBox.TabIndex = 12
        '
        'Technik_inventorComboBox
        '
        Me.Technik_inventorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_inventor", True))
        Me.Technik_inventorComboBox.FormattingEnabled = True
        Me.Technik_inventorComboBox.Location = New System.Drawing.Point(1030, 125)
        Me.Technik_inventorComboBox.Name = "Technik_inventorComboBox"
        Me.Technik_inventorComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_inventorComboBox.TabIndex = 9
        '
        'Technik_hicadComboBox
        '
        Me.Technik_hicadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_hicad", True))
        Me.Technik_hicadComboBox.FormattingEnabled = True
        Me.Technik_hicadComboBox.Location = New System.Drawing.Point(582, 125)
        Me.Technik_hicadComboBox.Name = "Technik_hicadComboBox"
        Me.Technik_hicadComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_hicadComboBox.TabIndex = 8
        '
        'Technik_intellicadComboBox
        '
        Me.Technik_intellicadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_intellicad", True))
        Me.Technik_intellicadComboBox.FormattingEnabled = True
        Me.Technik_intellicadComboBox.Location = New System.Drawing.Point(152, 125)
        Me.Technik_intellicadComboBox.Name = "Technik_intellicadComboBox"
        Me.Technik_intellicadComboBox.Size = New System.Drawing.Size(173, 24)
        Me.Technik_intellicadComboBox.TabIndex = 7
        '
        'Technik_autodeskComboBox
        '
        Me.Technik_autodeskComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_autodesk", True))
        Me.Technik_autodeskComboBox.FormattingEnabled = True
        Me.Technik_autodeskComboBox.Location = New System.Drawing.Point(1030, 72)
        Me.Technik_autodeskComboBox.Name = "Technik_autodeskComboBox"
        Me.Technik_autodeskComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_autodeskComboBox.TabIndex = 6
        '
        'Technik_autocad3dComboBox
        '
        Me.Technik_autocad3dComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_autocad3d", True))
        Me.Technik_autocad3dComboBox.FormattingEnabled = True
        Me.Technik_autocad3dComboBox.Location = New System.Drawing.Point(582, 72)
        Me.Technik_autocad3dComboBox.Name = "Technik_autocad3dComboBox"
        Me.Technik_autocad3dComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_autocad3dComboBox.TabIndex = 5
        '
        'Technik_autocad2dComboBox
        '
        Me.Technik_autocad2dComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_autocad2d", True))
        Me.Technik_autocad2dComboBox.FormattingEnabled = True
        Me.Technik_autocad2dComboBox.Location = New System.Drawing.Point(151, 72)
        Me.Technik_autocad2dComboBox.Name = "Technik_autocad2dComboBox"
        Me.Technik_autocad2dComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_autocad2dComboBox.TabIndex = 4
        '
        'Technik_arcadComboBox
        '
        Me.Technik_arcadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_arcad", True))
        Me.Technik_arcadComboBox.FormattingEnabled = True
        Me.Technik_arcadComboBox.Location = New System.Drawing.Point(1030, 23)
        Me.Technik_arcadComboBox.Name = "Technik_arcadComboBox"
        Me.Technik_arcadComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_arcadComboBox.TabIndex = 3
        '
        'Technik_allplanComboBox
        '
        Me.Technik_allplanComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_allplan", True))
        Me.Technik_allplanComboBox.FormattingEnabled = True
        Me.Technik_allplanComboBox.Location = New System.Drawing.Point(582, 23)
        Me.Technik_allplanComboBox.Name = "Technik_allplanComboBox"
        Me.Technik_allplanComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_allplanComboBox.TabIndex = 2
        '
        'Technik_3dcadComboBox
        '
        Me.Technik_3dcadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bewerber_technikBindingSource, "technik_3dcad", True))
        Me.Technik_3dcadComboBox.FormattingEnabled = True
        Me.Technik_3dcadComboBox.Location = New System.Drawing.Point(151, 23)
        Me.Technik_3dcadComboBox.Name = "Technik_3dcadComboBox"
        Me.Technik_3dcadComboBox.Size = New System.Drawing.Size(174, 24)
        Me.Technik_3dcadComboBox.TabIndex = 1
        '
        'Bewerber_technikTableAdapter
        '
        Me.Bewerber_technikTableAdapter.ClearBeforeFill = True
        '
        'frmTechnische_Berufe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1254, 773)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmTechnische_Berufe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Technische Berufe und technische Software"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Bewerber_technikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Technik_cad3dComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_cad2dComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_cncComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_steuerungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_projekt_auslandComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_projekt_inlandComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_stücklistenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_techn_zeichnungenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_dokumentationsunterlagenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_konstruktionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_anlagenbauComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_maschinenbauComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Technik_sonstigeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Technik_brandschutzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_bauplanungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_fertigungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_inventorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_hicadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_intellicadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_autodeskComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_autocad3dComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_autocad2dComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_arcadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_allplanComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_3dcadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnTechnischeBerufeSoftware As System.Windows.Forms.Button
    Friend WithEvents Technik_software_sonstigeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Technik_turbocadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_solidworksComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_solidedgeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_microstationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Technik_megacadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents Bewerber_technikBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bewerber_technikTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_technikTableAdapter
End Class

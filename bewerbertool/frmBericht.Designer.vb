<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBericht
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource12 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource13 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource14 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource15 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource16 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource17 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource18 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource19 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource20 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource21 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource22 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource23 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.bewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.bew_bewerberdatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_ausbildungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_berufserfahrungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_sprachenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_edvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_bueroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bew_assistenzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_raeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_fibuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bew_bibuhaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_controllingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bew_lugBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bew_steuerfachangestellteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_vertriebBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_einkaufBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_versandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_logistikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_marketing_designBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_personalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_technikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bewerber_itBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gewerblichBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bewTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewTableAdapter()
        Me.bew_bewerberdatenTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bew_bewerberdatenTableAdapter()
        Me.bewerber_ausbildungTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_ausbildungTableAdapter()
        Me.bewerber_berufserfahrungTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_berufserfahrungTableAdapter()
        Me.bewerber_sprachenTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_sprachenTableAdapter()
        Me.bewerber_edvTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_edvTableAdapter()
        Me.bewerber_bueroTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_bueroTableAdapter()
        Me.bew_assistenzTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bew_assistenzTableAdapter()
        Me.bewerber_raeTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_raeTableAdapter()
        Me.bewerber_fibuTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_fibuTableAdapter()
        Me.bew_bibuhaTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bew_bibuhaTableAdapter()
        Me.bewerber_controllingTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_controllingTableAdapter()
        Me.bew_lugTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bew_lugTableAdapter()
        Me.bew_steuerfachangestellteTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bew_steuerfachangestellteTableAdapter()
        Me.bewerber_vertriebTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_vertriebTableAdapter()
        Me.bewerber_einkaufTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_einkaufTableAdapter()
        Me.bewerber_versandTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_versandTableAdapter()
        Me.bewerber_logistikTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_logistikTableAdapter()
        Me.bewerber_marketing_designTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_marketing_designTableAdapter()
        Me.bewerber_personalTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_personalTableAdapter()
        Me.bewerber_technikTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_technikTableAdapter()
        Me.bewerber_itTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.bewerber_itTableAdapter()
        Me.gewerblichTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.gewerblichTableAdapter()
        CType(Me.bewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bew_bewerberdatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_ausbildungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_berufserfahrungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_sprachenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_edvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_bueroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bew_assistenzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_raeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_fibuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bew_bibuhaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_controllingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bew_lugBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bew_steuerfachangestellteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_vertriebBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_einkaufBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_versandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_logistikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_marketing_designBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_personalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_technikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bewerber_itBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gewerblichBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bewBindingSource
        '
        Me.bewBindingSource.DataMember = "bew"
        Me.bewBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerberneuDataSet
        '
        Me.bewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.bewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bew_bewerberdatenBindingSource
        '
        Me.bew_bewerberdatenBindingSource.DataMember = "bew_bewerberdaten"
        Me.bew_bewerberdatenBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_ausbildungBindingSource
        '
        Me.bewerber_ausbildungBindingSource.DataMember = "bewerber_ausbildung"
        Me.bewerber_ausbildungBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_berufserfahrungBindingSource
        '
        Me.bewerber_berufserfahrungBindingSource.DataMember = "bewerber_berufserfahrung"
        Me.bewerber_berufserfahrungBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_sprachenBindingSource
        '
        Me.bewerber_sprachenBindingSource.DataMember = "bewerber_sprachen"
        Me.bewerber_sprachenBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_edvBindingSource
        '
        Me.bewerber_edvBindingSource.DataMember = "bewerber_edv"
        Me.bewerber_edvBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_bueroBindingSource
        '
        Me.bewerber_bueroBindingSource.DataMember = "bewerber_buero"
        Me.bewerber_bueroBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bew_assistenzBindingSource
        '
        Me.bew_assistenzBindingSource.DataMember = "bew_assistenz"
        Me.bew_assistenzBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_raeBindingSource
        '
        Me.bewerber_raeBindingSource.DataMember = "bewerber_rae"
        Me.bewerber_raeBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_fibuBindingSource
        '
        Me.bewerber_fibuBindingSource.DataMember = "bewerber_fibu"
        Me.bewerber_fibuBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bew_bibuhaBindingSource
        '
        Me.bew_bibuhaBindingSource.DataMember = "bew_bibuha"
        Me.bew_bibuhaBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_controllingBindingSource
        '
        Me.bewerber_controllingBindingSource.DataMember = "bewerber_controlling"
        Me.bewerber_controllingBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bew_lugBindingSource
        '
        Me.bew_lugBindingSource.DataMember = "bew_lug"
        Me.bew_lugBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bew_steuerfachangestellteBindingSource
        '
        Me.bew_steuerfachangestellteBindingSource.DataMember = "bew_steuerfachangestellte"
        Me.bew_steuerfachangestellteBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_vertriebBindingSource
        '
        Me.bewerber_vertriebBindingSource.DataMember = "bewerber_vertrieb"
        Me.bewerber_vertriebBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_einkaufBindingSource
        '
        Me.bewerber_einkaufBindingSource.DataMember = "bewerber_einkauf"
        Me.bewerber_einkaufBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_versandBindingSource
        '
        Me.bewerber_versandBindingSource.DataMember = "bewerber_versand"
        Me.bewerber_versandBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_logistikBindingSource
        '
        Me.bewerber_logistikBindingSource.DataMember = "bewerber_logistik"
        Me.bewerber_logistikBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_marketing_designBindingSource
        '
        Me.bewerber_marketing_designBindingSource.DataMember = "bewerber_marketing_design"
        Me.bewerber_marketing_designBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_personalBindingSource
        '
        Me.bewerber_personalBindingSource.DataMember = "bewerber_personal"
        Me.bewerber_personalBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_technikBindingSource
        '
        Me.bewerber_technikBindingSource.DataMember = "bewerber_technik"
        Me.bewerber_technikBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'bewerber_itBindingSource
        '
        Me.bewerber_itBindingSource.DataMember = "bewerber_it"
        Me.bewerber_itBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'gewerblichBindingSource
        '
        Me.gewerblichBindingSource.DataMember = "gewerblich"
        Me.gewerblichBindingSource.DataSource = Me.bewerberneuDataSet
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "bew"
        ReportDataSource1.Value = Me.bewBindingSource
        ReportDataSource2.Name = "bewerberdaten"
        ReportDataSource2.Value = Me.bew_bewerberdatenBindingSource
        ReportDataSource3.Name = "ausbildung"
        ReportDataSource3.Value = Me.bewerber_ausbildungBindingSource
        ReportDataSource4.Name = "berufserfahrung"
        ReportDataSource4.Value = Me.bewerber_berufserfahrungBindingSource
        ReportDataSource5.Name = "sprachen"
        ReportDataSource5.Value = Me.bewerber_sprachenBindingSource
        ReportDataSource6.Name = "edv"
        ReportDataSource6.Value = Me.bewerber_edvBindingSource
        ReportDataSource7.Name = "büro"
        ReportDataSource7.Value = Me.bewerber_bueroBindingSource
        ReportDataSource8.Name = "assistenz"
        ReportDataSource8.Value = Me.bew_assistenzBindingSource
        ReportDataSource9.Name = "rae"
        ReportDataSource9.Value = Me.bewerber_raeBindingSource
        ReportDataSource10.Name = "FiBu"
        ReportDataSource10.Value = Me.bewerber_fibuBindingSource
        ReportDataSource11.Name = "bibuha"
        ReportDataSource11.Value = Me.bew_bibuhaBindingSource
        ReportDataSource12.Name = "controlling"
        ReportDataSource12.Value = Me.bewerber_controllingBindingSource
        ReportDataSource13.Name = "lug"
        ReportDataSource13.Value = Me.bew_lugBindingSource
        ReportDataSource14.Name = "steuerfachangestellte"
        ReportDataSource14.Value = Me.bew_steuerfachangestellteBindingSource
        ReportDataSource15.Name = "vertrieb"
        ReportDataSource15.Value = Me.bewerber_vertriebBindingSource
        ReportDataSource16.Name = "einkauf"
        ReportDataSource16.Value = Me.bewerber_einkaufBindingSource
        ReportDataSource17.Name = "versand"
        ReportDataSource17.Value = Me.bewerber_versandBindingSource
        ReportDataSource18.Name = "logistik"
        ReportDataSource18.Value = Me.bewerber_logistikBindingSource
        ReportDataSource19.Name = "marketing"
        ReportDataSource19.Value = Me.bewerber_marketing_designBindingSource
        ReportDataSource20.Name = "personal"
        ReportDataSource20.Value = Me.bewerber_personalBindingSource
        ReportDataSource21.Name = "technik"
        ReportDataSource21.Value = Me.bewerber_technikBindingSource
        ReportDataSource22.Name = "it"
        ReportDataSource22.Value = Me.bewerber_itBindingSource
        ReportDataSource23.Name = "gewerblich"
        ReportDataSource23.Value = Me.gewerblichBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource12)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource13)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource14)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource15)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource16)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource17)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource18)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource19)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource20)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource21)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource22)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource23)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "bewerbertool.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(760, 509)
        Me.ReportViewer1.TabIndex = 0
        '
        'bewTableAdapter
        '
        Me.bewTableAdapter.ClearBeforeFill = True
        '
        'bew_bewerberdatenTableAdapter
        '
        Me.bew_bewerberdatenTableAdapter.ClearBeforeFill = True
        '
        'bewerber_ausbildungTableAdapter
        '
        Me.bewerber_ausbildungTableAdapter.ClearBeforeFill = True
        '
        'bewerber_berufserfahrungTableAdapter
        '
        Me.bewerber_berufserfahrungTableAdapter.ClearBeforeFill = True
        '
        'bewerber_sprachenTableAdapter
        '
        Me.bewerber_sprachenTableAdapter.ClearBeforeFill = True
        '
        'bewerber_edvTableAdapter
        '
        Me.bewerber_edvTableAdapter.ClearBeforeFill = True
        '
        'bewerber_bueroTableAdapter
        '
        Me.bewerber_bueroTableAdapter.ClearBeforeFill = True
        '
        'bew_assistenzTableAdapter
        '
        Me.bew_assistenzTableAdapter.ClearBeforeFill = True
        '
        'bewerber_raeTableAdapter
        '
        Me.bewerber_raeTableAdapter.ClearBeforeFill = True
        '
        'bewerber_fibuTableAdapter
        '
        Me.bewerber_fibuTableAdapter.ClearBeforeFill = True
        '
        'bew_bibuhaTableAdapter
        '
        Me.bew_bibuhaTableAdapter.ClearBeforeFill = True
        '
        'bewerber_controllingTableAdapter
        '
        Me.bewerber_controllingTableAdapter.ClearBeforeFill = True
        '
        'bew_lugTableAdapter
        '
        Me.bew_lugTableAdapter.ClearBeforeFill = True
        '
        'bew_steuerfachangestellteTableAdapter
        '
        Me.bew_steuerfachangestellteTableAdapter.ClearBeforeFill = True
        '
        'bewerber_vertriebTableAdapter
        '
        Me.bewerber_vertriebTableAdapter.ClearBeforeFill = True
        '
        'bewerber_einkaufTableAdapter
        '
        Me.bewerber_einkaufTableAdapter.ClearBeforeFill = True
        '
        'bewerber_versandTableAdapter
        '
        Me.bewerber_versandTableAdapter.ClearBeforeFill = True
        '
        'bewerber_logistikTableAdapter
        '
        Me.bewerber_logistikTableAdapter.ClearBeforeFill = True
        '
        'bewerber_marketing_designTableAdapter
        '
        Me.bewerber_marketing_designTableAdapter.ClearBeforeFill = True
        '
        'bewerber_personalTableAdapter
        '
        Me.bewerber_personalTableAdapter.ClearBeforeFill = True
        '
        'bewerber_technikTableAdapter
        '
        Me.bewerber_technikTableAdapter.ClearBeforeFill = True
        '
        'bewerber_itTableAdapter
        '
        Me.bewerber_itTableAdapter.ClearBeforeFill = True
        '
        'gewerblichTableAdapter
        '
        Me.gewerblichTableAdapter.ClearBeforeFill = True
        '
        'frmBericht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 534)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmBericht"
        Me.Text = "Bericht"
        CType(Me.bewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bew_bewerberdatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_ausbildungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_berufserfahrungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_sprachenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_edvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_bueroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bew_assistenzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_raeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_fibuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bew_bibuhaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_controllingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bew_lugBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bew_steuerfachangestellteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_vertriebBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_einkaufBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_versandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_logistikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_marketing_designBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_personalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_technikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bewerber_itBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gewerblichBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents bewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents bewTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewTableAdapter
    Friend WithEvents bew_bewerberdatenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bew_bewerberdatenTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bew_bewerberdatenTableAdapter
    Friend WithEvents bewerber_ausbildungBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_ausbildungTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_ausbildungTableAdapter
    Friend WithEvents bewerber_berufserfahrungBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_berufserfahrungTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_berufserfahrungTableAdapter
    Friend WithEvents bewerber_sprachenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_sprachenTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_sprachenTableAdapter
    Friend WithEvents bewerber_edvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_edvTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_edvTableAdapter
    Friend WithEvents bewerber_bueroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_bueroTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_bueroTableAdapter
    Friend WithEvents bew_assistenzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bew_assistenzTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bew_assistenzTableAdapter
    Friend WithEvents bewerber_raeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_raeTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_raeTableAdapter
    Friend WithEvents bewerber_fibuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_fibuTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_fibuTableAdapter
    Friend WithEvents bew_bibuhaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bew_bibuhaTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bew_bibuhaTableAdapter
    Friend WithEvents bewerber_controllingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_controllingTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_controllingTableAdapter
    Friend WithEvents bew_lugBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bew_lugTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bew_lugTableAdapter
    Friend WithEvents bew_steuerfachangestellteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bew_steuerfachangestellteTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bew_steuerfachangestellteTableAdapter
    Friend WithEvents bewerber_vertriebBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_vertriebTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_vertriebTableAdapter
    Friend WithEvents bewerber_einkaufBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_einkaufTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_einkaufTableAdapter
    Friend WithEvents bewerber_versandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_logistikBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_versandTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_versandTableAdapter
    Friend WithEvents bewerber_logistikTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_logistikTableAdapter
    Friend WithEvents bewerber_marketing_designBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_marketing_designTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_marketing_designTableAdapter
    Friend WithEvents bewerber_personalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_personalTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_personalTableAdapter
    Friend WithEvents bewerber_technikBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_technikTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_technikTableAdapter
    Friend WithEvents bewerber_itBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bewerber_itTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.bewerber_itTableAdapter
    Friend WithEvents gewerblichBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gewerblichTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.gewerblichTableAdapter
End Class

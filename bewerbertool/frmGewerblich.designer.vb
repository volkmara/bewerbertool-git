<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGewerblich
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
        Dim PostverteilungLabel As System.Windows.Forms.Label
        Dim FahrdienstLabel As System.Windows.Forms.Label
        Dim UmzugLabel As System.Windows.Forms.Label
        Dim HausmeistertätigkeitLabel As System.Windows.Forms.Label
        Dim WinterdienstLabel As System.Windows.Forms.Label
        Dim AussenanlagenLabel As System.Windows.Forms.Label
        Dim SonstigesLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGewerblich = New System.Windows.Forms.Button()
        Me.SonstigesTextBox = New System.Windows.Forms.TextBox()
        Me.GewerblichBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BewerberneuDataSet = New bewerbertool.bewerberneuDataSet()
        Me.AussenanlagenComboBox = New System.Windows.Forms.ComboBox()
        Me.WinterdienstComboBox = New System.Windows.Forms.ComboBox()
        Me.HausmeistertätigkeitComboBox = New System.Windows.Forms.ComboBox()
        Me.UmzugComboBox = New System.Windows.Forms.ComboBox()
        Me.FahrdienstComboBox = New System.Windows.Forms.ComboBox()
        Me.PostverteilungComboBox = New System.Windows.Forms.ComboBox()
        Me.GewerblichTableAdapter = New bewerbertool.bewerberneuDataSetTableAdapters.gewerblichTableAdapter()
        PostverteilungLabel = New System.Windows.Forms.Label()
        FahrdienstLabel = New System.Windows.Forms.Label()
        UmzugLabel = New System.Windows.Forms.Label()
        HausmeistertätigkeitLabel = New System.Windows.Forms.Label()
        WinterdienstLabel = New System.Windows.Forms.Label()
        AussenanlagenLabel = New System.Windows.Forms.Label()
        SonstigesLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GewerblichBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PostverteilungLabel
        '
        PostverteilungLabel.AutoSize = True
        PostverteilungLabel.Location = New System.Drawing.Point(13, 31)
        PostverteilungLabel.Name = "PostverteilungLabel"
        PostverteilungLabel.Size = New System.Drawing.Size(111, 16)
        PostverteilungLabel.TabIndex = 0
        PostverteilungLabel.Text = "Postverteilung:"
        '
        'FahrdienstLabel
        '
        FahrdienstLabel.AutoSize = True
        FahrdienstLabel.Location = New System.Drawing.Point(497, 31)
        FahrdienstLabel.Name = "FahrdienstLabel"
        FahrdienstLabel.Size = New System.Drawing.Size(85, 16)
        FahrdienstLabel.TabIndex = 2
        FahrdienstLabel.Text = "Fahrdienst:"
        '
        'UmzugLabel
        '
        UmzugLabel.AutoSize = True
        UmzugLabel.Location = New System.Drawing.Point(956, 31)
        UmzugLabel.Name = "UmzugLabel"
        UmzugLabel.Size = New System.Drawing.Size(59, 16)
        UmzugLabel.TabIndex = 4
        UmzugLabel.Text = "Umzug:"
        '
        'HausmeistertätigkeitLabel
        '
        HausmeistertätigkeitLabel.AutoSize = True
        HausmeistertätigkeitLabel.Location = New System.Drawing.Point(13, 86)
        HausmeistertätigkeitLabel.Name = "HausmeistertätigkeitLabel"
        HausmeistertätigkeitLabel.Size = New System.Drawing.Size(154, 16)
        HausmeistertätigkeitLabel.TabIndex = 6
        HausmeistertätigkeitLabel.Text = "Hausmeistertätigkeit:"
        '
        'WinterdienstLabel
        '
        WinterdienstLabel.AutoSize = True
        WinterdienstLabel.Location = New System.Drawing.Point(485, 86)
        WinterdienstLabel.Name = "WinterdienstLabel"
        WinterdienstLabel.Size = New System.Drawing.Size(98, 16)
        WinterdienstLabel.TabIndex = 8
        WinterdienstLabel.Text = "Winterdienst:"
        '
        'AussenanlagenLabel
        '
        AussenanlagenLabel.AutoSize = True
        AussenanlagenLabel.Location = New System.Drawing.Point(903, 86)
        AussenanlagenLabel.Name = "AussenanlagenLabel"
        AussenanlagenLabel.Size = New System.Drawing.Size(119, 16)
        AussenanlagenLabel.TabIndex = 10
        AussenanlagenLabel.Text = "Aussenanlagen:"
        '
        'SonstigesLabel
        '
        SonstigesLabel.AutoSize = True
        SonstigesLabel.Location = New System.Drawing.Point(14, 139)
        SonstigesLabel.Name = "SonstigesLabel"
        SonstigesLabel.Size = New System.Drawing.Size(155, 16)
        SonstigesLabel.TabIndex = 12
        SonstigesLabel.Text = "Sonstige Tätigkeiten:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 315)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1246, 27)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Bitte geben Sie Ihre Schwerpunkte bei gewerblichen Tätigkeiten an." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.btnGewerblich)
        Me.GroupBox1.Controls.Add(SonstigesLabel)
        Me.GroupBox1.Controls.Add(Me.SonstigesTextBox)
        Me.GroupBox1.Controls.Add(AussenanlagenLabel)
        Me.GroupBox1.Controls.Add(Me.AussenanlagenComboBox)
        Me.GroupBox1.Controls.Add(WinterdienstLabel)
        Me.GroupBox1.Controls.Add(Me.WinterdienstComboBox)
        Me.GroupBox1.Controls.Add(HausmeistertätigkeitLabel)
        Me.GroupBox1.Controls.Add(Me.HausmeistertätigkeitComboBox)
        Me.GroupBox1.Controls.Add(UmzugLabel)
        Me.GroupBox1.Controls.Add(Me.UmzugComboBox)
        Me.GroupBox1.Controls.Add(FahrdienstLabel)
        Me.GroupBox1.Controls.Add(Me.FahrdienstComboBox)
        Me.GroupBox1.Controls.Add(PostverteilungLabel)
        Me.GroupBox1.Controls.Add(Me.PostverteilungComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1247, 279)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Berufliche Tätigkeiten"
        '
        'btnGewerblich
        '
        Me.btnGewerblich.BackColor = System.Drawing.Color.Wheat
        Me.btnGewerblich.Location = New System.Drawing.Point(589, 202)
        Me.btnGewerblich.Name = "btnGewerblich"
        Me.btnGewerblich.Size = New System.Drawing.Size(203, 60)
        Me.btnGewerblich.TabIndex = 27
        Me.btnGewerblich.Text = "Kenntnisse  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "gewerbliche Tätigkeiten" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abspeichern"
        Me.btnGewerblich.UseVisualStyleBackColor = False
        '
        'SonstigesTextBox
        '
        Me.SonstigesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GewerblichBindingSource, "sonstiges", True))
        Me.SonstigesTextBox.Location = New System.Drawing.Point(173, 139)
        Me.SonstigesTextBox.Multiline = True
        Me.SonstigesTextBox.Name = "SonstigesTextBox"
        Me.SonstigesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SonstigesTextBox.Size = New System.Drawing.Size(309, 132)
        Me.SonstigesTextBox.TabIndex = 7
        '
        'GewerblichBindingSource
        '
        Me.GewerblichBindingSource.DataMember = "gewerblich"
        Me.GewerblichBindingSource.DataSource = Me.BewerberneuDataSet
        '
        'BewerberneuDataSet
        '
        Me.BewerberneuDataSet.DataSetName = "bewerberneuDataSet"
        Me.BewerberneuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AussenanlagenComboBox
        '
        Me.AussenanlagenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GewerblichBindingSource, "aussenanlagen", True))
        Me.AussenanlagenComboBox.FormattingEnabled = True
        Me.AussenanlagenComboBox.Location = New System.Drawing.Point(1030, 83)
        Me.AussenanlagenComboBox.Name = "AussenanlagenComboBox"
        Me.AussenanlagenComboBox.Size = New System.Drawing.Size(174, 24)
        Me.AussenanlagenComboBox.TabIndex = 6
        '
        'WinterdienstComboBox
        '
        Me.WinterdienstComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GewerblichBindingSource, "winterdienst", True))
        Me.WinterdienstComboBox.FormattingEnabled = True
        Me.WinterdienstComboBox.Location = New System.Drawing.Point(607, 83)
        Me.WinterdienstComboBox.Name = "WinterdienstComboBox"
        Me.WinterdienstComboBox.Size = New System.Drawing.Size(174, 24)
        Me.WinterdienstComboBox.TabIndex = 5
        '
        'HausmeistertätigkeitComboBox
        '
        Me.HausmeistertätigkeitComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GewerblichBindingSource, "hausmeistertätigkeit", True))
        Me.HausmeistertätigkeitComboBox.FormattingEnabled = True
        Me.HausmeistertätigkeitComboBox.Location = New System.Drawing.Point(173, 83)
        Me.HausmeistertätigkeitComboBox.Name = "HausmeistertätigkeitComboBox"
        Me.HausmeistertätigkeitComboBox.Size = New System.Drawing.Size(174, 24)
        Me.HausmeistertätigkeitComboBox.TabIndex = 4
        '
        'UmzugComboBox
        '
        Me.UmzugComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GewerblichBindingSource, "umzug", True))
        Me.UmzugComboBox.FormattingEnabled = True
        Me.UmzugComboBox.Location = New System.Drawing.Point(1030, 28)
        Me.UmzugComboBox.Name = "UmzugComboBox"
        Me.UmzugComboBox.Size = New System.Drawing.Size(174, 24)
        Me.UmzugComboBox.TabIndex = 3
        '
        'FahrdienstComboBox
        '
        Me.FahrdienstComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GewerblichBindingSource, "fahrdienst", True))
        Me.FahrdienstComboBox.FormattingEnabled = True
        Me.FahrdienstComboBox.Location = New System.Drawing.Point(607, 28)
        Me.FahrdienstComboBox.Name = "FahrdienstComboBox"
        Me.FahrdienstComboBox.Size = New System.Drawing.Size(174, 24)
        Me.FahrdienstComboBox.TabIndex = 2
        '
        'PostverteilungComboBox
        '
        Me.PostverteilungComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GewerblichBindingSource, "postverteilung", True))
        Me.PostverteilungComboBox.FormattingEnabled = True
        Me.PostverteilungComboBox.Location = New System.Drawing.Point(173, 28)
        Me.PostverteilungComboBox.Name = "PostverteilungComboBox"
        Me.PostverteilungComboBox.Size = New System.Drawing.Size(174, 24)
        Me.PostverteilungComboBox.TabIndex = 1
        '
        'GewerblichTableAdapter
        '
        Me.GewerblichTableAdapter.ClearBeforeFill = True
        '
        'frmGewerblich
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1259, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGewerblich"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gewerbliche Tätigkeiten"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GewerblichBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BewerberneuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SonstigesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AussenanlagenComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WinterdienstComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HausmeistertätigkeitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UmzugComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FahrdienstComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PostverteilungComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnGewerblich As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BewerberneuDataSet As bewerbertool.bewerberneuDataSet
    Friend WithEvents GewerblichBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GewerblichTableAdapter As bewerbertool.bewerberneuDataSetTableAdapters.gewerblichTableAdapter
End Class

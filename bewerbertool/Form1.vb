Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports bewerbertool.bewerberneuDataSet
Imports System.Security.Permissions
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports Microsoft.Reporting.WinForms.ReportViewer
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports System.Media
Imports System.Text


Public Class Form1

    Public fuehrerschein As String = String.Empty
    Public arbeitsart As String = String.Empty
    Public arbeitsort As String = String.Empty
    Public pkwoepnv As String = String.Empty
    Public suchmaschine As String = String.Empty
    Public zeitung As String = String.Empty
    Public jobboerse As String = String.Empty
    Public medien_andere As String = String.Empty
    Public pflichtfeldliste As String = String.Empty
    Public letztebeschäftigung As String = String.Empty
    Public beendigungsgrund As String = String.Empty

    'auf Tabpage Ausbildung, Studium etc.
    Public studium_abschluss As String = String.Empty
    ' auf Tabpage edv
    Public sapmodule As String = String.Empty
    ' Für Tabpage Berufliche Kenntnisse
    Public nachname As String = String.Empty
    Public anrede As String = String.Empty

    Public edvausgabe As String = String.Empty
    Public sprachenausgabe As String = String.Empty

    Public festnetz As String = String.Empty
    Public mobil As String = String.Empty
    Public kontaktdaten As String = String.Empty

    Public alter As Integer

    Public sw As Stopwatch = Stopwatch.StartNew
    Public elapsedtime As String = String.Empty

    Dim m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)

    Dim filename As String = String.Empty

    ' Variablen Datenschutz
    ' Public speicherung As String = String.Empty
    'Public speicherungindb As String = String.Empty
    'Public speicherungverarbeitungnachjob As String = String.Empty
    'Public verarbeitung As String = String.Empty
    'Public weitergabe_ulas As String = String.Empty
    'Public homepage As String = String.Empty
    'Public links As String = String.Empty
    'Public rundschreiben As String = String.Empty
    'Public auskunft As String = String.Empty
    'Public loeschung As String = String.Empty

    ' Verzeichnis ulas, bewerberbogen etc.
    Public verzeichnis As String = String.Empty
    Public refnr As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Call begruessung()
        Me.BewTableAdapter.Fill(Me.BewerberneuDataSet.bew)
        Me.Bewerber_sprachenTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_sprachen)
        Me.Bewerber_edvTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_edv)
        Me.Bewerber_berufserfahrungTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_berufserfahrung)
        Me.Bewerber_ausbildungTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_ausbildung)
        Me.Bew_bewerberdatenTableAdapter.Fill(Me.BewerberneuDataSet.bew_bewerberdaten)
        Me.UlasTableAdapter.Fill(Me.BewerberneuDataSet.ulas)
        Me.dsgvTableAdapter.Fill(Me.BewerberneuDataSet.dsgv)

        Call ComboboxSelectbeiStart()
        Call Mausraddeaktivieren()

        PictureBox6.Focus()
        Me.BewBindingSource.AddNew()
        Me.Bew_bewerberdatenBindingSource.AddNew()
        Me.Bewerber_ausbildungBindingSource.AddNew()
        Me.Bewerber_berufserfahrungBindingSource.AddNew()
        Me.Bewerber_sprachenBindingSource.AddNew()
        Me.Bewerber_edvBindingSource.AddNew()
        TabControl1.SelectedTab = TabPage1
        AnredeComboBox1.Select()
        Call Statusbar()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        '   GeburtstagDateTimePicker.Value = Date.Now
        cmbMdE.SelectedIndex = 0
        Call comboboxselectindexsprachen()
        Call comboboxindexselectedv()
        sw.Start() ' Stoppuhr starten

        ' Verzeichnis ulas definieren
        If connectionString.Contains("127.0.0.1") Then
            verzeichnis = CStr("e:\heyduck\ulas\")
        Else
            verzeichnis = CStr("x:\ulas\")
        End If
    End Sub

    Private Sub Laden()
        If Me.TabControl1.SelectedTab Is TabPage1 Then
            PictureBox6.Focus()
        ElseIf Me.TabControl1.SelectedTab Is TabPage2 Then
            '  Me.Bewerber_ausbildungBindingSource.AddNew()
            ' Me.Bewerber_berufserfahrungBindingSource.AddNew()
            PictureBox6.Focus()
            '  SchulabschlussComboBox.SelectedIndex = 0
        ElseIf Me.TabControl1.SelectedTab Is TabPage3 Then
            'Me.Bewerber_sprachenBindingSource.AddNew()
            'Me.Bewerber_edvBindingSource.AddNew()
            PictureBox6.Focus()
        End If
    End Sub
    ' Beim Wechsel der Tabpage wird der Code für die ausgewählte Tabpage in Datenladen() ausgeführt und in das DGV geladen

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Call Laden()
    End Sub

    ' Tabcontrolreiter ändern
    Private Sub TabControl_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem

        Dim tabContas As TabControl = DirectCast(sender, TabControl)
        Dim sTexto As String = tabContas.TabPages(e.Index).Text
        Dim g As Graphics = e.Graphics
        Dim fonte As Font = tabContas.Font
        Dim format = New System.Drawing.StringFormat
        'CHANGES HERE...
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center
        Dim pincel As New SolidBrush(Color.Black)
        'RENEMED VARIEBLE HERE...
        Dim retangulo As RectangleF = RectangleF.op_Implicit(tabContas.GetTabRect(e.Index))
        If tabContas.SelectedIndex = e.Index Then
            fonte = New Font(fonte, FontStyle.Bold)
            pincel = New SolidBrush(Color.Red)
            'CHANGED BACKGROUN COLOR HERE...
            g.FillRectangle(Brushes.White, retangulo)
        End If
        g.DrawString(sTexto, fonte, pincel, retangulo, format)
    End Sub

    ' Auswahl Comboboxen beim Programmstart, Statusbar und Farbe der Buttons
    Private Sub ComboboxSelectbeiStart()
        Me.RundschreibenComboBox.SelectedIndex = 0
        Me.VerfuegbarkeitComboBox.SelectedIndex = 0
        Me.KuendigungsfristComboBox.SelectedIndex = 0
        Me.Vz_tzComboBox.SelectedIndex = 0
        Me.Teilzeit_stundenComboBox.SelectedIndex = 0
        Me.Teilzeit_wannComboBox.SelectedIndex = 0
        Me.Fahrzeit_maxComboBox.SelectedIndex = 0
        Me.UmzugComboBox.SelectedIndex = 0
        Me.SchulabschlussComboBox.SelectedIndex = 0
        Me.FuehrungsverantwortungComboBox.SelectedIndex = 0
        Me.PersonalverantwortungComboBox.SelectedIndex = 0
        Me.StaatsangehörigkeitComboBox.SelectedIndex = 0
    End Sub

    ' comboBoxen fill und Indexselect global
    Private Sub comboboxselectindexsprachen()
        For Each cmb21 In GroupBox21.Controls.OfType(Of ComboBox)()
            cmb21.DropDownStyle = ComboBoxStyle.DropDownList
            cmb21.Items.Clear()
            cmb21.Items.Add("0: keine Kenntnisse")
            cmb21.Items.Add("1: verhandlungssichere Sprachkenntnisse")
            cmb21.Items.Add("2: sehr gute berufliche Kenntnisse")
            cmb21.Items.Add("3: gute berufliche Kenntnisse")
            cmb21.Items.Add("4: Grund-/Schulkenntnisse")
            cmb21.SelectedIndex = 0
        Next
    End Sub
    Private Sub comboboxindexselectedv()
        For Each cmb22 In GroupBox22.Controls.OfType(Of ComboBox)()
            cmb22.DropDownStyle = ComboBoxStyle.DropDownList
            cmb22.Items.Clear()
            cmb22.Items.Add("0: nicht angewendet")
            cmb22.Items.Add("1: in den letzten Jahren regelmäßig")
            cmb22.Items.Add("2: in den letzten Jahren häufig")
            cmb22.Items.Add("3: in den letzten Jahren gelegentlich")
            cmb22.Items.Add("4: in den letzten Jahren selten")
            cmb22.SelectedIndex = 0
        Next
    End Sub
    Private Sub comboboxselectindexGroupbox2()
        Dim cbs2 = GroupBox2.Controls.OfType(Of ComboBox)()
        For Each cb In cbs2
            cb.SelectedIndex = 0
        Next
    End Sub

    Private Sub Statusbar()
        ToolStripProgressBar1.Maximum = 60
        ToolStripProgressBar1.Minimum = 10
        ToolStripProgressBar1.Value += 1
    End Sub

    ' Listboxen auslesen
    Private Sub FuehrerscheinListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArbeitsortListBox.SelectedIndexChanged, Pkw_oepnvListBox.SelectedIndexChanged, SuchmaschineListBox.SelectedIndexChanged, ZeitungListBox.SelectedIndexChanged, JobboerseListBox.SelectedIndexChanged, Medien_andereListBox.SelectedIndexChanged, Studium_abschlussListBox.SelectedIndexChanged, Sap_moduleListBox.SelectedIndexChanged, Za_vmListBox.SelectedIndexChanged

        fuehrerschein = String.Empty
        For i As Integer = 0 To FuehrerscheinListBox1.SelectedItems.Count - 1
            fuehrerschein &= FuehrerscheinListBox1.SelectedItems.Item(i).ToString & vbCrLf
        Next

        arbeitsart = String.Empty
        For h As Integer = 0 To Za_vmListBox.SelectedItems.Count - 1
            arbeitsart &= Za_vmListBox.SelectedItems.Item(h).ToString & vbCrLf
        Next

        arbeitsort = String.Empty
        For j As Integer = 0 To ArbeitsortListBox.SelectedItems.Count - 1
            arbeitsort &= ArbeitsortListBox.SelectedItems.Item(j).ToString & vbCrLf
        Next

        pkwoepnv = String.Empty
        For k As Integer = 0 To Pkw_oepnvListBox.SelectedItems.Count - 1
            pkwoepnv &= Pkw_oepnvListBox.SelectedItems.Item(k).ToString & vbCrLf
        Next

        suchmaschine = String.Empty
        For p As Integer = 0 To SuchmaschineListBox.SelectedItems.Count - 1
            suchmaschine &= SuchmaschineListBox.SelectedItems.Item(p).ToString & vbCrLf
        Next

        zeitung = String.Empty
        For q As Integer = 0 To ZeitungListBox.SelectedItems.Count - 1
            zeitung &= ZeitungListBox.SelectedItems.Item(q).ToString & vbCrLf
        Next

        jobboerse = String.Empty
        For r As Integer = 0 To JobboerseListBox.SelectedItems.Count - 1
            jobboerse &= JobboerseListBox.SelectedItems.Item(r).ToString & vbCrLf
        Next

        medien_andere = String.Empty
        For u As Integer = 0 To Medien_andereListBox.SelectedItems.Count - 1
            medien_andere &= Medien_andereListBox.SelectedItems.Item(u).ToString & vbCrLf
        Next

        studium_abschluss = String.Empty
        For v As Integer = 0 To Studium_abschlussListBox.SelectedItems.Count - 1
            studium_abschluss &= Studium_abschlussListBox.SelectedItems.Item(v).ToString & vbCrLf
        Next

        sapmodule = String.Empty
        For z As Integer = 0 To Sap_moduleListBox.SelectedItems.Count - 1
            sapmodule &= Sap_moduleListBox.SelectedItems(z).ToString & vbCrLf
        Next

    End Sub
    ' Textvorgaben in Geburtstag und letzte und längste Beschäftigung löschen

    Private Sub txtGeburtstag_Enter(sender As Object, e As EventArgs) Handles txtGeburtstag.Enter, txtletzteanstellungvon.Enter
        Select Case True
            Case sender Is txtGeburtstag
                txtGeburtstag.Text = String.Empty
            Case sender Is txtletzteanstellungbis
                txtletzteanstellungbis.Text = String.Empty
            Case sender Is txtletzteanstellungvon
                txtletzteanstellungvon.Text = String.Empty
        End Select
    End Sub

    ' Anfangsbuchstabe groß
    Private Sub VornameTextBox1_Leave(sender As Object, e As EventArgs) Handles VornameTextBox1.Leave, NameTextBox1.Leave, OrtTextBox.Leave, OrtsteilTextBox.Leave, Letzte_beschaeftigungTextBox.Leave, BrancheTextBox.Leave
        Select Case True
            Case sender Is VornameTextBox1
                If VornameTextBox1.Text <> "" Then
                    VornameTextBox1.Text = VornameTextBox1.Text(0).ToString.ToUpper & VornameTextBox1.Text.Substring(1)
                End If
            Case sender Is NameTextBox1
                If NameTextBox1.Text <> "" Then
                    NameTextBox1.Text = NameTextBox1.Text(0).ToString.ToUpper & NameTextBox1.Text.Substring(1)
                End If
            Case sender Is StrasseTextBox
                If StrasseTextBox.Text <> "" Then
                    StrasseTextBox.Text = StrasseTextBox.Text(0).ToString.ToUpper & StrasseTextBox.Text.Substring(1)
                End If
            Case sender Is OrtTextBox
                If OrtTextBox.Text <> "" Then
                    OrtTextBox.Text = OrtTextBox.Text(0).ToString.ToUpper & OrtTextBox.Text.Substring(1)
                End If
            Case sender Is OrtsteilTextBox
                If OrtsteilTextBox.Text <> "" Then
                    OrtsteilTextBox.Text = OrtsteilTextBox.Text(0).ToString.ToUpper & OrtsteilTextBox.Text.Substring(1)
                End If
            Case sender Is Letzte_beschaeftigungTextBox
                If Letzte_beschaeftigungTextBox.Text <> "" Then
                    Letzte_beschaeftigungTextBox.Text = Letzte_beschaeftigungTextBox.Text(0).ToString.ToUpper & Letzte_beschaeftigungTextBox.Text.Substring(1)
                End If
            Case sender Is BrancheTextBox
                If BrancheTextBox.Text <> "" Then
                    BrancheTextBox.Text = BrancheTextBox.Text(0).ToString.ToUpper & BrancheTextBox.Text.Substring(1)
                End If
        End Select
    End Sub

    ' Pflichtfelder und Validierungen
    Private Sub AnredeComboBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AnredeComboBox1.Validating, VornameTextBox1.Validating, NameTextBox1.Validating, PlzTextBox.Validating, EmailTextBox.Validating, Letzte_beschaeftigungTextBox.Validating, JobwunschTextBox.Validating, VerfuegbarkeitComboBox.Validating, ArbeitsortListBox.Validating, Pkw_oepnvListBox.Validating, UmzugComboBox.Validating, Gehaltswunsch_monatTextBox1.Validating, Gehaltswunsch_jahrTextBox.Validating, MonatsgehaltTextBox.Validating, JahresgehaltTextBox.Validating, KinderTextBox1.Validating, telRufnummerTextBox.Validating, telvorwahlTextbox.Validating, mobilrufnummerTextBox.Validating, mobilvorwahlTextBox.Validating, Za_vmListBox.Validating, txtGeburtstag.Validating, txtletzteanstellungbis.Validating, txtletzteanstellungvon.Validating, MdETextBox.Validating, FamilienstandComboBox.Validating, StaatsangehörigkeitComboBox.Validating, OrtTextBox.Validating, BeendigungsgrundComboBox.Validating
        Select Case True
            Case sender Is AnredeComboBox1
                If AnredeComboBox1.Text = String.Empty Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte wählen Sie Ihre Anrede aus")
                    ToolTip2.Show("Bitte wählen Sie eine Anrede aus.", CType(sender, Control), 1500)
                    e.Cancel = True
                End If
            Case sender Is VornameTextBox1
                If VornameTextBox1.Text = "" Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie Ihren Vornamen an")
                    ToolTip2.Show("Bitte geben Sie Ihren Vornamen an.", CType(sender, Control), 1500)
                End If
            Case sender Is NameTextBox1
                If NameTextBox1.Text = "" Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie Ihren Nachnamen an")
                    ToolTip2.Show("Bitte geben Sie Ihren Nachnamen ein.", CType(sender, Control), 1500)
                    e.Cancel = True
                End If
            Case sender Is FamilienstandComboBox
                If FamilienstandComboBox.Text = String.Empty Then
                    ToolTip2.Show("Bitte geben Sie Ihren Familienstand ein", CType(sender, Control), 1500)
                End If
            Case sender Is KinderTextBox1
                Dim suchtext As String = CStr(KinderTextBox1.Text)
                Dim pattern As String = CStr("[0-9]")
                If KinderTextBox1.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie die Anzahl Ihrer Kinder an.", CType(sender, Control), 1500)
                ElseIf Not Regex.IsMatch(suchtext, pattern) Then
                    ToolTip2.Show("Bitte geben Sie nur Ziffern an.", CType(sender, Control), 1500)
                End If
            Case sender Is StaatsangehörigkeitComboBox
                If StaatsangehörigkeitComboBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie Ihre Staatsangehörigkeit an.", CType(sender, Control), 1500)
                End If
            Case sender Is StrasseTextBox
                If StrasseTextBox.Text = "" Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie Ihre Anschrift vollständig an")
                    ToolTip2.Show("Bitte geben Sie einen Straßennamen an", CType(sender, Control), 1500)
                End If
            Case sender Is PlzTextBox
                If Not IsNumeric(PlzTextBox.Text) Then
                    ToolTip2.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                ElseIf PlzTextBox.TextLength <= 4 Then
                    ToolTip2.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                ElseIf PlzTextBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie eine Postleitzahl mit fünf Ziffern ein.", CType(sender, Control), 1500)
                End If
            Case sender Is OrtTextBox
                Dim suchtext As String = CStr(OrtTextBox.Text)
                Dim pattern As String = CStr("[a-z]")

                If OrtTextBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie Ihren Wohnort ein.", CType(sender, Control), 1500)
                ElseIf Not Regex.IsMatch(suchtext, pattern, RegexOptions.IgnoreCase) Then
                    ToolTip2.Show("Bitte geben Sie nur Buchstaben ein. ", CType(sender, Control), 1500)
                End If
            Case sender Is EmailTextBox
                If EmailTextBox.Text.Trim = "" Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie Ihre Emailadresse an")
                    ToolTip2.Show("Bitte geben Sie eine Emailadresse ein. ", CType(sender, Control), 1500)
                    e.Cancel = True
                ElseIf Not ValidateEMail(EmailTextBox.Text) Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie eine korrekte Emailadresse an")
                    ToolTip2.Show("Bitte geben Sie eine korrekte Emailadresse ein. ", CType(sender, Control), 1500)
                    e.Cancel = True
                End If
            Case sender Is txtGeburtstag
                '   If Not ValidateGeburtstag(txtGeburtstag.Text) AndAlso  Then
                '  ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie Ihren Geburtstag im Format tt.mm.yyyy ein")
                ' ToolTip2.Show("Bitte geben Sie Ihren Geburtstag im Format tt.mm.yyyy ein", CType(sender, Control), 1500)
                'e.Cancel = True
                'End If

                Dim suchtext As String = CStr(txtGeburtstag.Text)
                Dim pattern As String = "((?:(?:[0-2]?\d{1})|(?:[3][01]{1}))[-:\/.](?:[0]?[1-9]|[1][012])[-:\/.](?:(?:[1]{1}\d{1}\d{1}\d{1})|(?:[2]{1}\d{3})))(?![\d])"
                Dim pattern1 As String = "[a-z]"
                If Regex.IsMatch(suchtext, pattern1) OrElse Not Regex.IsMatch(suchtext, pattern) Then
                    ' MsgBox("passt")
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie Ihren Geburtstag im Format tt.mm.yyyy ein")
                    ToolTip2.Show("Bitte geben Sie Ihren Geburtstag im Format tt.mm.yyyy ein", CType(sender, Control), 1500)
                    e.Cancel = True
                End If


                'Case sender Is Tel_festnetzTextBox
                '   If Tel_festnetzTextBox.Text = "" AndAlso Tel_mobilTextBox.Text = "" Then
                'ToolTip2.Show("Bitte geben Sie entweder Ihre Festnetz- oder Ihre Handynummer ein.", CType(sender, Control), 3000)
                'End If
                'Case sender Is Tel_mobilTextBox
                '   If Tel_mobilTextBox.Text = "" AndAlso Tel_festnetzTextBox.Text = "" Then
                'ToolTip2.Show("Bitte geben Sie entweder Ihre Handy- oder Ihre Festnetznummer ein.", CType(sender, Control), 3000)
                'End If
            Case sender Is telRufnummerTextBox
                If telRufnummerTextBox.Text = "" AndAlso mobilrufnummerTextBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie entweder Ihre Festnetz- oder Ihre Handynummer ein.", CType(sender, Control), 1500)
                End If
            Case sender Is telvorwahlTextbox
                If telvorwahlTextbox.Text = "" AndAlso mobilvorwahlTextBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie entweder Ihre Handy- oder Ihre Festnetznummer ein.", CType(sender, Control), 1500)
                End If
            Case sender Is Letzte_beschaeftigungTextBox
                If Letzte_beschaeftigungTextBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie Ihre letzte Beschäftigung an", CType(sender, Control), 1500)
                End If
            Case sender Is JobwunschTextBox
                If JobwunschTextBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie Ihren Beschäftigungswunsch an.", CType(sender, Control), 1500)
                End If
            Case sender Is Za_vmListBox
                If Za_vmListBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie an, wie Sie arbeiten möchten.", CType(sender, Control), 1500)
                End If
            Case sender Is VerfuegbarkeitComboBox
                If VerfuegbarkeitComboBox.Text = "-" Then
                    ToolTip2.Show("Bitte geben Sie an, wann Sie für eine neue Beschäftigung zur Verfügung stehen", CType(sender, Control), 1500)
                End If
            Case sender Is ArbeitsortListBox
                If ArbeitsortListBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie an, wo Sie arbeiten möchten.", CType(sender, Control), 1500)
                End If
            Case sender Is Pkw_oepnvListBox
                If Pkw_oepnvListBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie an, wie Sie zum Arbeitsplatz gelangen.", CType(sender, Control), 1500)
                End If
            Case sender Is UmzugComboBox
                If UmzugComboBox.Text = "" Then
                    ToolTip2.Show("Würden Sie umziehen?", CType(sender, Control), 1500)
                End If
            Case sender Is Gehaltswunsch_monatTextBox1
                If Not IsNumeric(Gehaltswunsch_monatTextBox1.Text) Then
                    ToolTip2.Show("Bitte geben Sie nur Ziffern ein", CType(sender, Control), 1500)
                ElseIf Gehaltswunsch_monatTextBox1.Text = "" AndAlso Gehaltswunsch_jahrTextBox.Text = String.Empty Then
                    ToolTip2.Show("Bitte geben Sie Ihr monatliches Wunschgehalt oder Ihr Wunschjahresgehalt an", CType(sender, Control), 1500)
                End If
            Case sender Is Gehaltswunsch_jahrTextBox
                If Not IsNumeric(Gehaltswunsch_jahrTextBox.Text) Then
                    ToolTip2.Show("Bitte geben Sie nur Ziffern ein", CType(sender, Control), 1500)
                End If
            Case sender Is MonatsgehaltTextBox
                If Not IsNumeric(MonatsgehaltTextBox.Text) Then
                    ToolTip2.Show("Bitte geben Sie nur Ziffern ein", CType(sender, Control), 1500)
                ElseIf MonatsgehaltTextBox.Text = "" AndAlso JahresgehaltTextBox.Text = "" Then
                    ToolTip2.Show("Bitte geben Sie Ihr letztes Bruttomonats- oder Bruttojahresgehalt an", CType(sender, Control), 1500)
                End If
            Case sender Is JahresgehaltTextBox
                If Not IsNumeric(JahresgehaltTextBox.Text) Then
                    ToolTip2.Show("Bitte geben Sie nur Ziffern ein", CType(sender, Control), 1500)
                End If
            Case sender Is txtletzteanstellungvon
                Dim suchtext As String = CStr(txtletzteanstellungvon.Text)
                Dim pattern As String = CStr("[0-9]{2}/[0-9]{4}")
                If Regex.IsMatch(suchtext, pattern) Then
                    Exit Sub
                Else
                    'ErrorProvider1.SetError(CType(sender, Control), "Bitte tragen Sie den Beginn Ihrer letzten Beschäftigung so ein: mm/jjjj")
                    ToolTip1.Show("Bitte tragen Sie den Beginn Ihrer letzten Beschäftigung so ein: mm/jjjj", CType(sender, Control), 1500)
                End If
            Case sender Is txtletzteanstellungbis
                Dim suchtext As String = CStr(txtletzteanstellungbis.Text)
                Dim pattern As String = CStr("[0-9]{2}/[0-9]{4}")
                If Regex.IsMatch(suchtext, pattern) Then
                    Exit Sub
                Else
                    'ErrorProvider1.SetError(CType(sender, Control), "Bitte tragen Sie das Ende Ihrer letzten Beschäftigung so ein: mm/jjjj")
                    ToolTip1.Show("Bitte tragen Sie das Ende Ihrer letzten Beschäftigung so ein: mm/jjjj", CType(sender, Control), 1500)
                End If
            Case sender Is MdETextBox
                If Not IsNumeric(Me.MdETextBox.Text) Then
                    ErrorProvider1.SetError(CType(sender, Control), "Bitte geben Sie Ziffern ein.")
                    ToolTip2.Show("Bitte geben Sie Ziffern ein", CType(sender, Control), 1500)
                End If
            Case sender Is BeendigungsgrundComboBox
                If BeendigungsgrundComboBox.Text = String.Empty Then
                    ToolTip2.Show("Wie bzw. durch wen wurde Ihre letzte Beschäftigung beendet?", CType(sender, Control), 1500)
                End If
        End Select
    End Sub

    Private Sub Vz_tzComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Vz_tzComboBox.SelectedIndexChanged, VerfuegbarkeitComboBox.SelectedIndexChanged, FuehrungsverantwortungComboBox.SelectedIndexChanged, PersonalverantwortungComboBox.SelectedIndexChanged, SapComboBox.SelectedIndexChanged
        Select Case True
            Case sender Is Vz_tzComboBox
                If Vz_tzComboBox.SelectedIndex = 2 OrElse Vz_tzComboBox.SelectedIndex = 3 OrElse Vz_tzComboBox.SelectedIndex = 4 Then
                    Teilzeit_stundenComboBox.Enabled = True
                    Teilzeit_wannComboBox.Enabled = True
                    lblTeilzeitStunden.Enabled = True
                    lblWann.Enabled = True
                ElseIf Vz_tzComboBox.Text = "Vollzeit" Then
                    Teilzeit_stundenComboBox.Enabled = False
                    Teilzeit_wannComboBox.Enabled = False
                    lblTeilzeitStunden.Enabled = False
                    lblWann.Enabled = False
                End If
            Case sender Is VerfuegbarkeitComboBox
                If VerfuegbarkeitComboBox.SelectedIndex = 3 Then
                    lblKuendigungsfrist.Enabled = True
                    lblKuendigungsfrist.Visible = True
                    KuendigungsfristComboBox.Enabled = True
                    KuendigungsfristComboBox.Visible = True
                    lblAbsprache.Visible = False
                    AbspracheCombobox.Visible = False
                ElseIf VerfuegbarkeitComboBox.SelectedIndex = 2 Then
                    lblKuendigungsfrist.Enabled = False
                    lblKuendigungsfrist.Visible = False
                    KuendigungsfristComboBox.Enabled = False
                    KuendigungsfristComboBox.Visible = False
                    lblAbsprache.Visible = True
                    AbspracheCombobox.Visible = True
                ElseIf VerfuegbarkeitComboBox.SelectedIndex = 0 OrElse VerfuegbarkeitComboBox.SelectedIndex = 1 Then
                    lblKuendigungsfrist.Enabled = False
                    lblKuendigungsfrist.Visible = False
                    KuendigungsfristComboBox.Enabled = False
                    KuendigungsfristComboBox.Visible = False
                    lblAbsprache.Visible = False
                    AbspracheCombobox.Visible = False
                End If
            Case sender Is FuehrungsverantwortungComboBox
                If FuehrungsverantwortungComboBox.SelectedIndex = 1 Then
                    Fuehrungsverantwortung_dauerTextBox.Enabled = True
                    '  ElseIf FuehrungsverantwortungComboBox.SelectedIndex = 0 OrElse FuehrungsverantwortungComboBox.SelectedIndex = 2 Then
                    '     Fuehrungsverantwortung_dauerTextBox.Enabled = True
                Else
                    Fuehrungsverantwortung_dauerTextBox.Enabled = False
                End If
            Case sender Is PersonalverantwortungComboBox
                If PersonalverantwortungComboBox.SelectedIndex = 1 Then
                    Personalverantwortung_anzahlTextBox.Enabled = True
                Else
                    Personalverantwortung_anzahlTextBox.Enabled = False
                End If
            Case sender Is SapComboBox
                If SapComboBox.SelectedIndex = 0 Then
                    Sap_moduleListBox.Enabled = False
                ElseIf SapComboBox.SelectedIndex <> 0 Then
                    Sap_moduleListBox.Enabled = True
                End If
            Case sender Is VorstrafenComboBox
                If VorstrafenComboBox.SelectedIndex = 2 Then
                    Vorstrafen_welcheTextBox.Enabled = True
                ElseIf VorstrafenComboBox.SelectedIndex <> 2 Then
                    Vorstrafen_welcheTextBox.Enabled = False
                End If
            Case sender Is KrankheitenComboBox
                If KrankheitenComboBox.SelectedIndex = 2 Then
                    Krankheiten_welcheTextBox.Enabled = True
                ElseIf KrankheitenComboBox.SelectedIndex <> 2 Then
                    Krankheiten_welcheTextBox.Enabled = False
                End If
            Case sender Is cmbMdE
                If cmbMdE.SelectedIndex = 1 Then
                    MdETextBox.Enabled = True
                Else
                    MdETextBox.Enabled = False
                    MdETextBox.Text = String.Empty
                End If
        End Select
    End Sub

    ' Function zur Validierung einer Emailadresse
    Private Function ValidateEMail(ByVal pstrEMail As String) As Boolean
        Dim EmailRegex As System.Text.RegularExpressions.Regex _
         = New System.Text.RegularExpressions.Regex("[\w-]+@([\w-]+\.)+[\w-]+")

        Dim M As System.Text.RegularExpressions.Match = EmailRegex.Match(pstrEMail)
        Return M.Success
    End Function

    ' Function zur Validierung des Geburtstags
    Private Function ValidateGeburtstag(ByRef pattern As String) As Boolean
        Dim geburtstagRegex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("((?:(?:[0-2]?\d{1})|(?:[3][01]{1}))[-:\/.](?:[0]?[1-9]|[1][012])[-:\/.](?:(?:[1]{1}\d{1}\d{1}\d{1})|(?:[2]{1}\d{3})))(?![\d])")
        Dim M As System.Text.RegularExpressions.Match = geburtstagRegex.Match(pattern)
        Return M.Success
    End Function

    ' Startbildschirm
    ' Private Sub begruessung()
    'Dim frmbegruessung As New frmBegruessung
    '   frmbegruessung.ShowDialog()
    'End Sub

    ' Kinder, Staatsangehörigkeit, Aufenthaltstitel, Arbeitserlaubnis
    Private Sub KinderTextBox1_TextChanged(sender As Object, e As EventArgs) Handles KinderTextBox1.TextChanged, StaatsangehörigkeitComboBox.TextChanged, AufenhaltstitelComboBox.TextChanged, ArbeitserlaubnisComboBox.TextChanged
        If KinderTextBox1.Text <> "" Then
            Me.Kinder_betreuungComboBox.Enabled = True
        ElseIf KinderTextBox1.Text Is String.Empty Then
            Me.Kinder_betreuungComboBox.Enabled = False
        End If

        If StaatsangehörigkeitComboBox.SelectedIndex = 0 Then
            Me.AufenhaltstitelComboBox.Enabled = False
            Me.ArbeitserlaubnisComboBox.Enabled = False
        Else
            Me.AufenhaltstitelComboBox.Enabled = True
            Me.ArbeitserlaubnisComboBox.Enabled = True
        End If
    End Sub

    ' Beendigungsgrund
    Private Sub BeendigungsgrundComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BeendigungsgrundComboBox.SelectedIndexChanged
        If BeendigungsgrundComboBox.SelectedIndex = CInt(6) Then
            Beendigungsgrund_auswahlTextBox.Enabled = False
        Else
            Beendigungsgrund_auswahlTextBox.Enabled = True
        End If
    End Sub

    ' Telefonnummern zusammensetzen
    Private Sub Telefonnummer()
        If telRufnummerTextBox.Text <> "" AndAlso telvorwahlTextbox.Text <> "" Then
            festnetz = CStr(telvorwahlTextbox.Text & "" & telRufnummerTextBox.Text)
        End If

        If mobilvorwahlTextBox.Text <> "" AndAlso mobilrufnummerTextBox.Text <> "" Then
            mobil = CStr(mobilvorwahlTextBox.Text & "" & mobilrufnummerTextBox.Text)
        End If

        kontaktdaten = CStr(CStr(festnetz) & vbCrLf & CStr(mobil) & vbCrLf & CStr(EmailTextBox.Text) & vbCrLf)
    End Sub

    ' Altersberechnung: Geburtstag auslesen und Alter jahrgenau berechnen
    Private Sub Altersberechnung()
        'alter = CInt((Now.Subtract(GeburtstagDateTimePicker.Value).Days / 365))
        Dim geburtstag As Date = Date.Parse(txtGeburtstag.Text)
        alter = CInt((Now.Subtract(geburtstag).Days / 365))
    End Sub

    ' ===================================================================== Wechsel von Tab zu Tab ======================================================================================

    ' Tabpage 1 - "Ihre persönlichen Daten" ================================== Beginn
    Private Sub btnPersDaten_Click(sender As Object, e As EventArgs) Handles btnPersDaten.Click
        'Validierung vorm Speichern
        Call Pflichtfelder()
        If pflichtfeldliste <> String.Empty Then

            MessageBox.Show("Haben Sie vergessen, diese Felder auszufüllen? " & vbCrLf & vbCrLf & pflichtfeldliste & vbCrLf & vbCrLf & "Nicht schlimm, das kann ja mal passieren. Bitte ergänzen Sie einfach Ihre Angaben. " & vbCrLf & vbCrLf & "Vielen Dank", "Pflichtfelder bitte ausfüllen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            arbeitsart = arbeitsart.Replace("Zeitarbeit", "ZA").Replace("Vermittlung", "VM").Replace("Zeitarbeit mit Übernahmeoption", "ZA/ÜN")

            Call Telefonnummer()
            Call Altersberechnung()

            TabControl1.SelectedTab = TabPage2
            '   Me.Panel2.Enabled = False
            '  Me.Panel3.Enabled = True
            ToolStripProgressBar1.PerformStep()
            ToolStripStatusLabel2.Text = "Ausbildung, Berufserfahrung"
        End If
    End Sub

    ' ============================================ Pflichtfelder vor Speichern ===========================================

    Private Sub Pflichtfelder()

        Dim pflichtfeld As New List(Of String)()

        If NameTextBox1.Text = String.Empty Then
            pflichtfeld.Add("Nachname")
            NameTextBox1.BackColor = Color.Yellow
        End If

        If VornameTextBox1.Text = String.Empty Then
            pflichtfeld.Add("Vorname")
            VornameTextBox1.BackColor = Color.Yellow
        End If

        If StaatsangehörigkeitComboBox.SelectedIndex = CInt(0) Then
            pflichtfeld.Add("Staatsangehörigkeit")
            StaatsangehörigkeitComboBox.BackColor = Color.Yellow
        End If

        If FamilienstandComboBox.Text = String.Empty Then
            pflichtfeld.Add("Familienstand")
            FamilienstandComboBox.BackColor = Color.Yellow
        End If

        If AnredeComboBox1.Text = String.Empty Then
            pflichtfeld.Add("Anrede")
            AnredeComboBox1.BackColor = Color.Yellow
        End If

        If PlzTextBox.Text = String.Empty Then
            pflichtfeld.Add("PLZ")
            PlzTextBox.BackColor = Color.Yellow
        End If

        If OrtTextBox.Text = String.Empty Then
            pflichtfeld.Add("Wohnort")
            OrtTextBox.BackColor = Color.Yellow
        End If

        If Letzte_beschaeftigungTextBox.Text = String.Empty Then
            pflichtfeld.Add("Letzte Beschäftigung")
            Letzte_beschaeftigungTextBox.BackColor = Color.Yellow
        End If

        If JobwunschTextBox.Text = String.Empty Then
            pflichtfeld.Add("Jobwunsch")
            JobwunschTextBox.BackColor = Color.Yellow
        End If

        If Vz_tzComboBox.Text = String.Empty Then
            pflichtfeld.Add("Vollzeit/Teilzeit")
            Vz_tzComboBox.BackColor = Color.Yellow
        End If

        If VerfuegbarkeitComboBox.Text = String.Empty Then
            pflichtfeld.Add("Wann können Sie eine neue Stelle antreten")
            VerfuegbarkeitComboBox.BackColor = Color.Yellow
        End If

        If ArbeitsortListBox.Text = String.Empty Then
            pflichtfeld.Add("Arbeitsort")
            ArbeitsortListBox.BackColor = Color.Yellow
        End If

        If StrasseTextBox.Text = String.Empty Then
            pflichtfeld.Add("Strasse")
            StrasseTextBox.BackColor = Color.Yellow
        End If

        Dim suchtext As String = CStr(txtGeburtstag.Text)
        Dim pattern As String = "((?:(?:[0-2]?\d{1})|(?:[3][01]{1}))[-:\/.](?:[0]?[1-9]|[1][012])[-:\/.](?:(?:[1]{1}\d{1}\d{1}\d{1})|(?:[2]{1}\d{3})))(?![\d])"
        Dim pattern1 As String = "[a-z]"
        If Regex.IsMatch(suchtext, pattern1) OrElse Not Regex.IsMatch(suchtext, pattern) OrElse txtGeburtstag.Text = CStr("01.01.1970") OrElse txtGeburtstag.Text.Contains("z.B. 01.01.1970") Then
            pflichtfeld.Add("Geburtstag")
            txtGeburtstag.BackColor = Color.Yellow
        End If
        If BeendigungsgrundComboBox.Text = String.Empty Then
            pflichtfeld.Add("Beendigungsgrund")
            BeendigungsgrundComboBox.BackColor = Color.Yellow
        End If

        If SuchmaschineListBox.SelectedIndex < 0 OrElse JobboerseListBox.SelectedIndex < 0 OrElse Medien_andereListBox.SelectedIndex < 0 Then
            pflichtfeld.Add("Suchmaschine oder Jobbörse oder andere Medien")
            SuchmaschineListBox.BackColor = Color.Yellow
            JobboerseListBox.BackColor = Color.Yellow
            Medien_andereListBox.BackColor = Color.Yellow
        End If

        pflichtfeldliste = String.Join(vbCrLf, pflichtfeld)
    End Sub

    ' ================================================= Pflichtfelder vor Speichern Ende =================================

    ' Tabpage 1 - "Ihre persönlichen Daten" ================================== Ende


    ' Tabpage "Ausbildung, Berufserfahrung ==================================== Beginn

    Private Sub btnSchuleBeruf_Click(sender As Object, e As EventArgs) Handles btnSchuleBeruf.Click

        TabControl1.SelectedTab = TabPage3
        '   Me.Panel3.Enabled = False
        '  Me.Panel4.Enabled = True
        ToolStripProgressBar1.PerformStep()
        ToolStripStatusLabel2.Text = "Fremdsprachen, allg. EDV-Kenntnisse"

    End Sub

    ' Tabpage 1 - "Ausbildung, Berufserfahrung" ================================== Ende

    ' Tabpage "Fremdsprachen, allgemeine EDV-Kenntnisse ============================ Beginn

    ' Sprachen anpassen für Bewerberpool
    Private Sub Sprachendaten()

        Dim sprachen As List(Of String) = New List(Of String)

        If CInt(EnglischComboBox.SelectedIndex) <> 0 Then
            '  sprachen.Add("Englisch: " & EnglischComboBox.Text & vbCrLf)
            sprachen.Add("E" & CInt(Me.EnglischComboBox.SelectedIndex).ToString & vbCrLf)
        End If

        If CInt(FranzoesischComboBox.SelectedIndex) <> 0 Then
            'sprachen.Add("Fr.: " & FranzoesischComboBox.Text & vbCrLf)
            sprachen.Add("F" & CInt(Me.FranzoesischComboBox.SelectedIndex).ToString & vbCrLf)
        End If

        If CInt(SpanischComboBox.SelectedIndex) <> 0 Then
            'sprachen.Add("Spanisch: " & SpanischComboBox.Text & vbCrLf)
            sprachen.Add("S" & CInt(Me.SpanischComboBox.SelectedIndex).ToString & vbCrLf)
        End If

        If CInt(ItalienischComboBox.SelectedIndex) <> 0 Then
            'sprachen.Add("Italienisch: " & ItalienischComboBox.Text & vbCrLf)
            sprachen.Add("I" & CInt(Me.ItalienischComboBox.SelectedIndex).ToString & vbCrLf)
        End If

        If CInt(RussischComboBox.SelectedIndex) <> 0 Then
            'sprachen.Add("Russisch: " & RussischComboBox.Text & vbCrLf)
            sprachen.Add("R" & CInt(Me.RussischComboBox.SelectedIndex).ToString & vbCrLf)
        End If

        If CInt(TuerkischComboBox.SelectedIndex) <> 0 Then
            'sprachen.Add("Türkisch: " & TuerkischComboBox.Text & vbCrLf)
            sprachen.Add("T" & CInt(Me.TuerkischComboBox.SelectedIndex).ToString & vbCrLf)
        End If

        If CInt(NiederlaendischComboBox.SelectedIndex) <> 0 Then
            'sprachen.Add("Niederländisch: " & NiederlaendischComboBox.Text & vbCrLf)
            sprachen.Add("NL" & CInt(Me.NiederlaendischComboBox.SelectedIndex).ToString & vbCrLf)
        End If

        For Each s As String In sprachen
            sprachenausgabe &= s
        Next

    End Sub

    ' EDV-Daten anpassen für Bewerberpool
    Private Sub Edvdaten()
        'Edvdaten
        Dim edv As List(Of String) = New List(Of String)

        If CInt(WordComboBox.SelectedIndex) <> 0 Then
            edv.Add("Word" & vbCrLf)
        End If

        If CInt(ExcelComboBox.SelectedIndex) <> 0 Then
            edv.Add("Excel" & vbCrLf)
        End If

        If CInt(PowerpointComboBox.SelectedIndex) <> 0 Then
            edv.Add("PowerPoint" & vbCrLf)
        End If

        If CInt(OutlookComboBox.SelectedIndex) <> 0 Then
            edv.Add("Outlook" & vbCrLf)
        End If

        If CInt(AccessComboBox.SelectedIndex) <> 0 Then
            edv.Add("Access" & vbCrLf)
        End If

        If CInt(ProjectComboBox.SelectedIndex) <> 0 Then
            edv.Add("Project" & vbCrLf)
        End If

        If CInt(ThunderbirdComboBox.SelectedIndex) <> 0 Then
            edv.Add("Thunderbird" & vbCrLf)
        End If

        If CInt(Lotus_notesComboBox.SelectedIndex) <> 0 Then
            edv.Add("Lotus Notes" & vbCrLf)
        End If

        If CInt(As400ComboBox.SelectedIndex) <> 0 Then
            edv.Add("AS400" & vbCrLf)
        End If

        If CInt(KhksageComboBox.SelectedIndex) <> 0 Then
            edv.Add("KHKSage" & vbCrLf)
        End If

        If CInt(SapComboBox.SelectedIndex) <> 0 Then
            edv.Add("SAP" & vbCrLf)
        End If

        If CInt(DatevComboBox.SelectedIndex) <> 0 Then
            edv.Add("Datev" & vbCrLf)
        End If

        If CInt(DatevComboBox.SelectedIndex) <> 0 Then
            edv.Add("DatevPro" & vbCrLf)
        End If

        If CInt(Microsoft_dynamicsComboBox.SelectedIndex) <> 0 Then
            edv.Add("Dynamics" & vbCrLf)
        End If

        If CInt(Microsoft_navisionComboBox.SelectedIndex) <> 0 Then
            edv.Add("Navision" & vbCrLf)
        End If

        If CInt(LexwareComboBox.SelectedIndex) <> 0 Then
            edv.Add("Lexware" & vbCrLf)
        End If

        If CInt(OracleComboBox.SelectedIndex) <> 0 Then
            edv.Add("Oracle" & vbCrLf)
        End If

        For Each s As String In edv
            edvausgabe &= s
        Next
    End Sub

    ' Tabpage - "Fremdsprachen, allgemeine EDV-Kenntnisse" ================================== Ende

    ' ============================================================================ Ende Tabpages =======================================================================================

    ' ============================================================================ Speichern und Ausdruck Beginn ============================================================================
    Private Sub Speichern()
        Call bewspeichern()

        Call Getbewid() ' Muss nach der bewspeichern-Methode ausgeführt werden
        refnr = CInt(bewid)
        Call bewerberdatenspeichern()
        Call ausbildungspeichern()
        Call berufserfahrungspeichern()
        Call sprachenspeichern()
        Call edvspeichern()

        Call inallentabellen.eintragen() ' neuen Datensatz mit aktueller bewid in allen Tabellen anlegen, sofern noch nicht geschehen

        ToolStripProgressBar1.PerformStep()
        ToolStripStatusLabel2.Text = "Geschafft"

        Call zeitstoppen() ' Zeit für Ausfüllen 

        ' Abschließende DB-Einträge

        Me.BewTableAdapter.Fill(Me.BewerberneuDataSet.bew)
        Me.BewBindingSource.Filter = "id_bew = " & bewid & ""
        Dim rwlast = DirectCast(DirectCast(BewBindingSource.Current, DataRowView).Row, bewRow)
        rwlast.status = CStr("ausgefüllt")
        rwlast.stand = CStr("aktuell")
        rwlast.zeit_bewerberbogen = CStr(elapsedtime) ' gestoppte Zeit
        rwlast.sprachkenntnisse = CStr(sprachenausgabe)
        rwlast.edvkenntnisse = CStr(edvausgabe)
        rwlast.englisch = CInt(EnglischComboBox.SelectedIndex)
        rwlast.franzoesisch = CInt(FranzoesischComboBox.SelectedIndex)
        rwlast.italienisch = CInt(ItalienischComboBox.SelectedIndex)
        rwlast.spanisch = CInt(SpanischComboBox.SelectedIndex)
        rwlast.tuerkisch = CInt(TuerkischComboBox.SelectedIndex)
        rwlast.russisch = CInt(RussischComboBox.SelectedIndex)
        rwlast.niederlaendisch = CInt(NiederlaendischComboBox.SelectedIndex)
        rwlast.deutsch = CInt(DeutschComboBox.SelectedIndex)
        rwlast.refnr = CInt(refnr)
        Me.Validate()
        Me.BewBindingSource.EndEdit()
        Me.BewTableAdapter.Update(Me.BewerberneuDataSet.bew)
    End Sub

    ' ============================================================ Speichern Methoden ===============================================
    ' Speichern in Tabelle bew
    Private Sub bewspeichern()

        Dim kuendigung As String = CStr(KuendigungsfristComboBox.Text)
        Dim absprache As String = CStr(AbspracheCombobox.Text)
        Dim kuendigung_absprache As String = String.Empty
        If Not kuendigung = String.Empty Then
            kuendigung_absprache = CStr(kuendigung)
        ElseIf Not absprache = String.Empty Then
            kuendigung_absprache = CStr(absprache)
        End If

        arbeitsort = arbeitsort.Replace("Rhein-Sieg-Kreis", "RSK").Replace("Bonn (nur links-rheinisch)", "BN LR").Replace("Bonn (nur rechts-rheinisch)", "BN RR").Replace("Bonn", "BN").Replace("Köln (nur links-rheinisch)", "K LR").Replace("Köln (nur rechts-rheinisch)", "K RR").Replace("Köln", "K").Replace("Waldbröl", "WBröl").Replace("Bergisches Land", "BergL").Replace("Leverkusen", "LEV").Replace("Düsseldorf", "D").Replace("Ruhrgebiet", "Ruhr").Replace("Rheinland-Pfalz", "RLP").Replace("Gummersbach", "GM").Replace("Euskirchen", "EU").Replace("Aachen", "AC").Replace("Neuss", "NE").Replace("Wesseling", "WES").Replace("Bergisch Gladbach", "BGL").Replace("Altenkirchen", "AK").Replace("Nordrhein-Westfalen", "NRW")

        ' Ausbildungsberuf, Studiumfach, Studiumabschluss zusammenfassen
        Dim ausbildungsberuf As New List(Of String)()
        ausbildungsberuf.Add((Me.AusbildungsberufTextBox.Text))
        ausbildungsberuf.Add(Me.studium_abschluss)
        ausbildungsberuf.Add(Me.StudienfaecherTextBox.Text)
        Dim ausbildungsberufneu As String = String.Join(vbNewLine, ausbildungsberuf)

        ' Tätigkeiten
        Dim tätigkeiten As New List(Of String)()
        tätigkeiten.Add(Me.Beruf_positionTextBox.Text)
        tätigkeiten.Add(Me.Beruf_schwerpunkttaetigkeitTextBox.Text)
        Dim tätigkeitenneu As String = String.Join(vbNewLine, tätigkeiten)

        Dim rwcat = DirectCast(DirectCast(BewBindingSource.Current, DataRowView).Row, bewRow)

        rwcat.alter = CInt(alter)
        rwcat.arbeitsort = CStr(arbeitsort)
        rwcat.tel_festnetz = CStr(festnetz)
        rwcat.tel_mobil = CStr(mobil)
        rwcat.kontaktdaten = CStr(kontaktdaten)
        rwcat.tätigkeiten = CStr(tätigkeitenneu)
        rwcat.sprachkenntnisse = CStr(sprachenausgabe)
        rwcat.edvkenntnisse = CStr(edvausgabe)
        rwcat.kuendigungsfrist = CStr(kuendigung_absprache)
        rwcat.Vermittlung = CStr(arbeitsart)
        rwcat.ausbildungsberuf = CStr(ausbildungsberufneu)
        rwcat.refnr = CInt(bewid)
        rwcat.status = CStr("angelegt")
        rwcat.erstkontakt = Date.Now

        Me.Validate()
        Me.BewBindingSource.EndEdit()
        Me.BewTableAdapter.Update(Me.BewerberneuDataSet.bew)
    End Sub

    ' Speichern in Tabelle bewerberdaten
    Private Sub bewerberdatenspeichern()
        Dim plz As Integer = CInt(Me.PlzTextBox.Text)

        letztebeschäftigung = CStr(txtletzteanstellungvon.Text & " - " & txtletzteanstellungbis.Text)

        Dim rwbewerberdaten = DirectCast(DirectCast(Bew_bewerberdatenBindingSource.Current, DataRowView).Row, bew_bewerberdatenRow)
        rwbewerberdaten.id_bew = CInt(bewid)
        rwbewerberdaten.geburtstag = CStr(txtGeburtstag.Text)
        rwbewerberdaten.pkw_oepnv = CStr(pkwoepnv)
        rwbewerberdaten.fuehrerschein = CStr(fuehrerschein)
        rwbewerberdaten.suchmaschine = CStr(suchmaschine)
        rwbewerberdaten.zeitung = CStr(zeitung)
        rwbewerberdaten.jobboerse = CStr(jobboerse)
        rwbewerberdaten.medien_andere = CStr(medien_andere)
        rwbewerberdaten.vorstrafen = CStr(VorstrafenComboBox.Text)
        rwbewerberdaten.vorstrafen_welche = CStr(Vorstrafen_welcheTextBox.Text)
        rwbewerberdaten.MdE = CStr(MdETextBox.Text)
        rwbewerberdaten.krankheiten = CStr(KrankheitenComboBox.Text)
        rwbewerberdaten.krankheiten_welche = CStr(Krankheiten_welcheTextBox.Text)
        rwbewerberdaten.schulden = CStr(SchuldenComboBox.Text)
        rwbewerberdaten.letzte_anstellung_von_bis = CStr(letztebeschäftigung)

        Me.Validate()
        Me.Bew_bewerberdatenBindingSource.EndEdit()
        Me.Bew_bewerberdatenTableAdapter.Update(Me.BewerberneuDataSet.bew_bewerberdaten)
    End Sub

    ' Speichern in Tabelle ausbildung
    Private Sub ausbildungspeichern()
        Dim rwberufsausbildung = DirectCast(DirectCast(Bewerber_ausbildungBindingSource.Current, DataRowView).Row, bewerber_ausbildungRow)
        rwberufsausbildung.id_bew = CInt(bewid)
        rwberufsausbildung.studium_abschluss = CStr(studium_abschluss)

        Me.Validate()
        Me.Bewerber_ausbildungBindingSource.EndEdit()
        Me.Bewerber_ausbildungTableAdapter.Update(Me.BewerberneuDataSet.bewerber_ausbildung)
    End Sub

    ' Speichern in Tabelle berufserfahrung
    Private Sub berufserfahrungspeichern()
        Dim rwberufserfahrung = DirectCast(DirectCast(Bewerber_berufserfahrungBindingSource.Current, DataRowView).Row, bewerber_berufserfahrungRow)
        rwberufserfahrung.id_bew = CInt(bewid)

        Me.Validate()
        Me.Bewerber_berufserfahrungBindingSource.EndEdit()
        Me.Bewerber_berufserfahrungTableAdapter.Update(Me.BewerberneuDataSet.bewerber_berufserfahrung)
    End Sub

    ' Speichern in tabelle sprachen
    Private Sub sprachenspeichern()
        Dim rwsprachen = DirectCast(DirectCast(Bewerber_sprachenBindingSource.Current, DataRowView).Row, bewerber_sprachenRow)
        rwsprachen.id_bew = CInt(bewid)

        Me.Validate()
        Me.Bewerber_sprachenBindingSource.EndEdit()
        Me.Bewerber_sprachenTableAdapter.Update(Me.BewerberneuDataSet.bewerber_sprachen)
    End Sub

    ' Speichern in Tabelle edv
    Private Sub edvspeichern()

        Dim rwedv = DirectCast(DirectCast(Bewerber_edvBindingSource.Current, DataRowView).Row, bewerber_edvRow)
        rwedv.id_bew = CInt(bewid)
        rwedv.sap_module = CStr(sapmodule)

        Me.Validate()
        Me.Bewerber_edvBindingSource.EndEdit()
        Me.Bewerber_edvTableAdapter.Update(Me.BewerberneuDataSet.bewerber_edv)
    End Sub

    ' ========================================= Email an Interviewer, wenn fertig ==================================================
    Private Sub emailaninterviewer()
        Dim email As New Mail

        Dim betreff As String = String.Concat(AnredeComboBox1.Text, " ", VornameTextBox1.Text, " ", NameTextBox1.Text, " hat den Bewerberbogen ausgefüllt")
        Dim bodytext As String = String.Concat(AnredeComboBox1.Text, " ", VornameTextBox1.Text, " ", NameTextBox1.Text, " hat den Bewerberbogen vollständig ausgefüllt, Ausdruck kann beim Drucker abgeholt werden")

        email.receiver = "volkmar.adler@heyduck-zeitarbeit.de, kontakt@heyduck-personalservice.de, ericdevilder@heyduck-personalservice.de, assistenz@heyduck-personalservice.de"
        email.subject = CStr(betreff)
        email.body = CStr(bodytext)
        email.send()
    End Sub

    ' ========================================= zeit stoppen =======================================
    Private Sub zeitstoppen()
        sw.Stop()
        Dim ts As TimeSpan = sw.Elapsed
        elapsedtime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds)
        ' MessageBox.Show("Zeit zum Ausfüllen (Minuten:Sekunden):" & vbNewLine & vbNewLine & elapsedtime, "Zeit zum Ausfüllen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    '===================================================== Methoden für Ausdruck des Bewerberbogens und der Datenschutzerklärung ========================================

    ' Bindingsources für Ausdruck neu laden, so dass nur noch die gerade eingetragenen Daten drin sind, Bewerberbogen ausdrucken und speichern

    Private Sub DatenfuerAusdruckladen()
        Me.BewTableAdapter.FillByParam1(Me.BewerberneuDataSet.bew, CInt(bewid))
        Me.Bew_bewerberdatenTableAdapter.FillByParam1(Me.BewerberneuDataSet.bew_bewerberdaten, CInt(bewid))
        Me.Bewerber_ausbildungTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_ausbildung, CInt(bewid))
        Me.Bewerber_berufserfahrungTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_berufserfahrung, CInt(bewid))
        Me.Bewerber_sprachenTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_sprachen, CInt(bewid))
        Me.Bewerber_edvTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_edv, CInt(bewid))
        Me.Bewerber_bueroTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_buero, CInt(bewid))
        Me.Bew_assistenzTableAdapter.FillByParam1(Me.BewerberneuDataSet.bew_assistenz, CInt(bewid))
        Me.Bewerber_raeTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_rae, CInt(bewid))
        Me.Bewerber_fibuTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_fibu, CInt(bewid))
        Me.Bew_bibuhaTableAdapter.FillByParam1(Me.BewerberneuDataSet.bew_bibuha, CInt(bewid))
        Me.Bewerber_controllingTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_controlling, CInt(bewid))
        Me.Bew_lugTableAdapter.FillByParam1(Me.BewerberneuDataSet.bew_lug, CInt(bewid))
        Me.Bew_steuerfachangestellteTableAdapter.FillByParam1(Me.BewerberneuDataSet.bew_steuerfachangestellte, CInt(bewid))
        Me.Bewerber_vertriebTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_vertrieb, CInt(bewid))
        Me.Bewerber_einkaufTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_einkauf, CInt(bewid))
        Me.Bewerber_versandTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_versand, CInt(bewid))
        Me.Bewerber_logistikTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_logistik, CInt(bewid))
        Me.Bewerber_marketing_designTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_marketing_design, CInt(bewid))
        Me.Bewerber_personalTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_personal, CInt(bewid))
        Me.Bewerber_technikTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_technik, CInt(bewid))
        Me.Bewerber_itTableAdapter.FillByParam1(Me.BewerberneuDataSet.bewerber_it, CInt(bewid))
        Me.GewerblichTableAdapter.FillByParam1(Me.BewerberneuDataSet.gewerblich, CInt(bewid))
        Me.dsgvTableAdapter.Fill(Me.BewerberneuDataSet.dsgv)
    End Sub

    Private Sub AusdruckBewerberbogen()
        Call Getbewid()
        Call DatenfuerAusdruckladen() ' Bindingsources neu laden, so dass nur noch die gerade eingegebenen Daten drin sind
        Dim rep As New LocalReport
        With rep
            ' .ReportPath = "X:\bewerbertool\Report7.rdlc"
            .ReportPath = "X:\bewerbertool\Report13.rdlc"
            '.ReportPath = "e:\heyduck\bewerbertool\bewerbertool\bewerbertool\bewerbertool\Report7.rdlc"
            '.ReportPath = "e:\heyduck\bewerbertool\bewerbertool\bewerbertool\bewerbertool\Report13.rdlc"
            .DataSources.Add(New ReportDataSource("bew", BewBindingSource))
            .DataSources.Add(New ReportDataSource("bewerberdaten", Bew_bewerberdatenBindingSource))
            .DataSources.Add(New ReportDataSource("ausbildung", Bewerber_ausbildungBindingSource))
            .DataSources.Add(New ReportDataSource("berufserfahrung", Bewerber_berufserfahrungBindingSource))
            .DataSources.Add(New ReportDataSource("sprachen", Bewerber_sprachenBindingSource))
            .DataSources.Add(New ReportDataSource("edv", Bewerber_edvBindingSource))
            .DataSources.Add(New ReportDataSource("büro", Bewerber_bueroBindingSource))
            .DataSources.Add(New ReportDataSource("assistenz", Bew_assistenzBindingSource))
            .DataSources.Add(New ReportDataSource("rae", Bewerber_raeBindingSource))
            .DataSources.Add(New ReportDataSource("FiBu", Bewerber_fibuBindingSource))
            .DataSources.Add(New ReportDataSource("bibuha", Bew_bibuhaBindingSource))
            .DataSources.Add(New ReportDataSource("controlling", Bewerber_controllingBindingSource))
            .DataSources.Add(New ReportDataSource("lug", Bew_lugBindingSource))
            .DataSources.Add(New ReportDataSource("steuerfachangestellte", Bew_steuerfachangestellteBindingSource))
            .DataSources.Add(New ReportDataSource("vertrieb", Bewerber_vertriebBindingSource))
            .DataSources.Add(New ReportDataSource("einkauf", Bewerber_einkaufBindingSource))
            .DataSources.Add(New ReportDataSource("versand", Bewerber_versandBindingSource))
            .DataSources.Add(New ReportDataSource("logistik", Bewerber_logistikBindingSource))
            .DataSources.Add(New ReportDataSource("marketing", Bewerber_marketing_designBindingSource))
            .DataSources.Add(New ReportDataSource("personal", Bewerber_personalBindingSource))
            .DataSources.Add(New ReportDataSource("technik", Bewerber_technikBindingSource))
            .DataSources.Add(New ReportDataSource("it", Bewerber_itBindingSource))
            .DataSources.Add(New ReportDataSource("gewerblich", GewerblichBindingSource))
            .DataSources.Add(New ReportDataSource("dsgv", dsgvBindingSource))
        End With

        ' Speichern
        'Dim bewerberbogenverzeichnis As String = String.Concat(verzeichnis, NameTextBox1.Text, ", ", VornameTextBox1.Text, "\", "Bewerberbogen_Bewerber\")
        Dim bewerberbogenverzeichnis As String = String.Concat(verzeichnis, refnr, "\", "Bewerberbogen_Bewerber")

        If Not IO.Directory.Exists(bewerberbogenverzeichnis) Then
            IO.Directory.CreateDirectory(bewerberbogenverzeichnis)
        End If

        filename = String.Concat(bewerberbogenverzeichnis, "\", "Bewerberbogen.pdf")

        Try
            Dim pdfContent As Byte() = rep.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Dim pdfFile As New System.IO.FileStream(filename, System.IO.FileMode.Create)
            pdfFile.Write(pdfContent, 0, pdfContent.Length)
            pdfFile.Close()
            ' MessageBox.Show("Datei erfolgreich gespeichert")
        Catch ex As Exception
            Exit Sub
            'MessageBox.Show("Fehler beim Speichern: " & ex.Message)
        End Try

        ' Ausdrucken
        Try
            Dim prt = DirectPrinting.getInstance
            prt.DirectPrint(rep)
        Catch ex As Exception
            Exit Sub
            ' MessageBox.Show("Fehler beim Drucken: " & ex.Message)
        End Try
    End Sub

    ' Ausdruck Datenschutzerklärung Heyduck

    Private Sub DruckenDatenschutzHeyduck()
        Me.BewTableAdapter.FillByParam1(Me.BewerberneuDataSet.bew, CInt(bewid))
        Me.dsgvTableAdapter.Fill(Me.BewerberneuDataSet.dsgv)

        Dim repdatenschutzheyduck As New LocalReport
        With repdatenschutzheyduck
            .ReportPath = "X:\bewerbertool\Report12.rdlc"
            ' .ReportPath = "E:\heyduck\bewerbertool\bewerbertool\bewerbertool\bewerbertool\Report12.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", BewBindingSource))
            .DataSources.Add(New ReportDataSource("DataSet3", dsgvBindingSource))
        End With

        ' Ausdrucken
        Try
            Dim prt = DirectPrinting.getInstance
            prt.DirectPrint(repdatenschutzheyduck)
        Catch ex As Exception
            Exit Sub
            MessageBox.Show("Fehler beim Drucken: " & ex.Message)
        End Try
    End Sub

    ' Ausdruck Datenschutzerklärung Bewerber
    Private Sub DruckenDatenschutzBewerber()
        Me.BewTableAdapter.FillByParam1(Me.BewerberneuDataSet.bew, CInt(bewid))
        Me.dsgvTableAdapter.Fill(Me.BewerberneuDataSet.dsgv)

        Dim repDatenschutzBewerber As New LocalReport
        With repDatenschutzBewerber
            .ReportPath = "X:\bewerbertool\Report11.rdlc"
            ' .ReportPath = "e:\heyduck\bewerbertool\Report11.rdlc"
            ' .ReportPath = "E:\heyduck\bewerbertool\bewerbertool\bewerbertool\bewerbertool\Report11.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", BewBindingSource))
            .DataSources.Add(New ReportDataSource("DataSet3", dsgvBindingSource))
        End With

        ' Ausdrucken
        Try
            Dim prt = DirectPrinting.getInstance
            prt.DirectPrint(repDatenschutzBewerber)

        Catch ex As Exception
            Exit Sub
            MessageBox.Show("Fehler beim Drucken: " & ex.Message)
        End Try
    End Sub

    ' Mausrad in Checkboxen deaktiviern
    Private Sub Mausraddeaktivieren()
        For Each Control In GroupBox21.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox22.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox1.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox12.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox15.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox7.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox8.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next
    End Sub

    Private Sub Ignore_MouseWheel(sender As Object, e As MouseEventArgs)
        DirectCast(e, HandledMouseEventArgs).Handled = True
    End Sub
    ' 
    ' Speichern und Beenden
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SapComboBox.SelectedIndex <> 0 AndAlso Sap_moduleListBox.Text = String.Empty Then
            Dim text As String = String.Concat("Bitte tragen Sie die SAP-Module, mit denen Sie gearbeitet haben, im Feld ""SAP-Module"" ein", vbNewLine, vbNewLine, "Eine Übersicht der AP-Module finden Sie, wenn Sie auf das Fragezeichen beim Feld ""SAP-Module"" klicken.")
            MessageBox.Show(text, "Bitte tragen Sie SAP-Module ein", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Dim nachricht As String = String.Concat("Wenn Sie sicher sind, dass Ihre Angaben vollständig sind, klicken Sie bitte auf ""Ja"".", vbNewLine, vbNewLine, "Wenn Sie noch etwas ändern möchten, klicken Sie bitte ""Nein"" und nehmen Sie Änderungen vor. Dann klicken Sie bitte wieder auf den Button ""Fertig"".")

        Dim result As DialogResult = MessageBox.Show(nachricht, "Alles richtig?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

        If result = DialogResult.Yes Then
            Call Sprachendaten() ' angepasste Daten für Bewerberpool
            Call Edvdaten() ' angepasste Daten für Bewerberpool
            Call Speichern()

            Using frm = New frmauswahlberuf(Me) ' Berufsauswahl öffnen
                Dim result1 = frm.ShowDialog(Me)
            End Using

            Call berufsfenster() ' Fenster für Berufe öffnen sich

            Button1.Enabled = False
            btnSprachenEdvzurueck.Enabled = False
            Dim schlusstext As String = String.Concat("Bitte warten Sie, bis das Programm Ihre Daten ausgedruckt hat und sich selbst beendet.", vbNewLine, vbNewLine, "Weitere Eingaben oder Korrekturen Ihrer Eingaben sind nicht mehr möglich.")
            MessageBox.Show(schlusstext, "Danke für Ihre Geduld und Ihre Mitarbeit", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Bewerberbogen und Datenschutzerklärungen ausdrucken
            Call AusdruckBewerberbogen() ' aktuellen Bewerberbogen drucken
            Call DruckenDatenschutzHeyduck() ' Exemplar Datenschutzerklärung für Heyduck drucken
            Call DruckenDatenschutzBewerber() ' Exemplar Datenschutzerklärung für Bewerber drucken
            Call emailaninterviewer()

            Dim rwende = DirectCast(DirectCast(BewBindingSource.Current, DataRowView).Row, bewRow)
            rwende.status = CStr("ausgedruckt")
            Me.Validate()
            Me.BewBindingSource.EndEdit()
            Me.BewTableAdapter.Update(Me.BewerberneuDataSet.bew)

            ' Speicheort Bewerberbogen ausgefüllt durch Bewerber eintragen
            Me.UlasTableAdapter.Fill(Me.BewerberneuDataSet.ulas)
            Me.UlasBindingSource.Filter = "id_bew = " & bewid & ""
            Dim rwulas = DirectCast(DirectCast(UlasBindingSource.Current, DataRowView).Row, ulasRow)
            rwulas.bewerberbogen_bewerber = CStr(filename)
            Me.Validate()
            Me.UlasBindingSource.EndEdit()
            Me.UlasTableAdapter.Update(Me.BewerberneuDataSet.ulas)

            ' Call datuminerstkontakt() ' Trägt datum ein

            Using frm = New frmEnde(Me) ' Schlussform öffnen
                Dim result2 = frm.ShowDialog(Me)
            End Using

            Me.Close()

        ElseIf result = DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub berufsfenster()
        If frmauswahlberuf.buerobool Then
            Using frm = New frmBuero(Me)
                Dim result = frm.ShowDialog(Me)
            End Using
        End If
        If frmauswahlberuf.assistenzbool Then
            Using frm = New frmAssistenz(Me)
                Dim result = frm.ShowDialog(Me)
            End Using
        End If
        If frmauswahlberuf.raebool Then
            Using frm = New frmRAE(Me)
                Dim result = frm.ShowDialog(Me)
            End Using
        End If
        If frmauswahlberuf.fibubool Then
            Using frm = New frmFinanzbuchhaltung(Me)
                Dim result = frm.ShowDialog(Me)
            End Using
        End If
        If frmauswahlberuf.bibuhabool Then
            Using frm = New frmBilanzbuchhaltung(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.controllingbool Then
            Using frm = New frmControlling(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.lugbool Then
            Using frm = New frmLuG(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.steuerfachangestelltebool Then
            Using frm = New frmSteuerfachangestellte(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.vertriebbool Then
            Using frm = New frmVertrieb(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.einkaufbool Then
            Using frm = New frmEinkauf(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.versandbool Then
            Using frm = New frmVersandLogistik(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.mudbool Then
            Using frm = New frmMarketingDesign(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.personalverwaltungbool Then
            Using frm = New frmPersonalverwaltung(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.technikbool Then
            Using frm = New frmTechnische_Berufe(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.itbool Then
            Using frm = New frmIT(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If frmauswahlberuf.gewerblichbool Then
            Using frm = New frmGewerblich(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub btnSchuleBerufzurueck_Click(sender As Object, e As EventArgs) Handles btnSchuleBerufzurueck.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btnSprachenEdvzurueck_Click(sender As Object, e As EventArgs) Handles btnSprachenEdvzurueck.Click
        TabControl1.SelectedTab = TabPage2
    End Sub
End Class
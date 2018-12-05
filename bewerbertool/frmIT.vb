Imports bewerbertool.bewerberneuDataSet
Public Class frmIT
    Public summe_IT As Integer = CInt(0)
    Public summe_desktop As Integer = CInt(0)
    Public summe_server As Integer = CInt(0)
    Public summe_programmierung As Integer = CInt(0)
    Public summe_programmiersprache As Integer = CInt(0)
    Public summe_datenbank As Integer = CInt(0)
    Public cmbanzahl_IT As Integer = CInt(0)
    Public cmbanzahl_desktop As Integer = CInt(0)
    Public cmbanzahl_server As Integer = CInt(0)
    Public cmbanzahl_programmierung As Integer = CInt(0)
    Public cmbanzahl_programmiersprache As Integer = CInt(0)
    Public cmbanzahl_datenbank As Integer = CInt(0)
    Private _form1 As Form1
    Private _frmauswahlberuf As frmauswahlberuf

    Sub New(form1 As Form1)
        ' TODO: Complete member initialization 
        _form1 = form1
        InitializeComponent()
    End Sub

    Sub New(frmauswahlberuf As frmauswahlberuf)
        ' TODO: Complete member initialization 
        _frmauswahlberuf = frmauswahlberuf
        InitializeComponent()
    End Sub

    Private Sub frnIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bewerber_it". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bewerber_itTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_it)

        Me.Bewerber_itBindingSource.Filter = "id_bew = " & bewid & ""
        Call ComboboxFillSelect()
        Call Mausraddeaktivieren()
        It_strategische_planungComboBox.Select()
    End Sub
    Private Sub ComboboxFillSelect()
        For Each cmb1 In GroupBox1.Controls.OfType(Of ComboBox)()
            cmb1.Items.Add("0 - keine Kenntnisse")
            cmb1.Items.Add("1 - immer angewendet")
            cmb1.Items.Add("2 - häufig")
            cmb1.Items.Add("3 - gelegentlich")
            cmb1.Items.Add("4 - Grundkenntnisse")
            cmb1.DropDownStyle = ComboBoxStyle.DropDownList
        Next

        For Each cmb2 In GroupBox2.Controls.OfType(Of ComboBox)()
            cmb2.Items.Add("0 - keine Kenntnisse")
            cmb2.Items.Add("1 - immer angewendet")
            cmb2.Items.Add("2 - häufig")
            cmb2.Items.Add("3 - gelegentlich")
            cmb2.Items.Add("4 - Grundkenntnisse")
            cmb2.DropDownStyle = ComboBoxStyle.DropDownList
        Next

        For Each cmb3 In GroupBox3.Controls.OfType(Of ComboBox)()
            cmb3.Items.Add("0 - keine Kenntnisse")
            cmb3.Items.Add("1 - immer angewendet")
            cmb3.Items.Add("2 - häufig")
            cmb3.Items.Add("3 - gelegentlich")
            cmb3.Items.Add("4 - Grundkenntnisse")
            cmb3.DropDownStyle = ComboBoxStyle.DropDownList
        Next

        For Each cmb4 In GroupBox4.Controls.OfType(Of ComboBox)()
            cmb4.Items.Add("0 - keine Kenntnisse")
            cmb4.Items.Add("1 - immer angewendet")
            cmb4.Items.Add("2 - häufig")
            cmb4.Items.Add("3 - gelegentlich")
            cmb4.Items.Add("4 - Grundkenntnisse")
            cmb4.DropDownStyle = ComboBoxStyle.DropDownList
        Next

        For Each cmb5 In GroupBox5.Controls.OfType(Of ComboBox)()
            cmb5.Items.Add("0 - keine Kenntnisse")
            cmb5.Items.Add("1 - immer angewendet")
            cmb5.Items.Add("2 - häufig")
            cmb5.Items.Add("3 - gelegentlich")
            cmb5.Items.Add("4 - Grundkenntnisse")
            cmb5.DropDownStyle = ComboBoxStyle.DropDownList
        Next

        For Each cmb6 In GroupBox6.Controls.OfType(Of ComboBox)()
            cmb6.Items.Add("0 - keine Kenntnisse")
            cmb6.Items.Add("1 - immer angewendet")
            cmb6.Items.Add("2 - häufig")
            cmb6.Items.Add("3 - gelegentlich")
            cmb6.Items.Add("4 - Grundkenntnisse")
            cmb6.DropDownStyle = ComboBoxStyle.DropDownList
        Next

        Dim cb1 = GroupBox1.Controls.OfType(Of ComboBox)()
        For Each cb In cb1
            cb.SelectedIndex = 0
            cb.Width = 185
        Next

        Dim cb2 = GroupBox2.Controls.OfType(Of ComboBox)()
        For Each cb In cb2
            cb.SelectedIndex = 0
            cb.Width = 185
        Next

        Dim cb3 = GroupBox3.Controls.OfType(Of ComboBox)()
        For Each cb In cb3
            cb.SelectedIndex = 0
            cb.Width = 185
        Next

        Dim cb4 = GroupBox4.Controls.OfType(Of ComboBox)()
        For Each cb In cb4
            cb.SelectedIndex = 0
            cb.Width = 185
        Next

        Dim cb5 = GroupBox5.Controls.OfType(Of ComboBox)()
        For Each cb In cb5
            cb.SelectedIndex = 0
            cb.Width = 185
        Next

        Dim cb6 = GroupBox6.Controls.OfType(Of ComboBox)()
        For Each cb In cb6
            cb.SelectedIndex = 0
            cb.Width = 185
        Next
    End Sub

    Private Sub ComboboxAddieren()
        Dim list_IT As New List(Of Integer)
        For Each cmb1 In GroupBox1.Controls.OfType(Of ComboBox)()
            list_IT.Add(CInt(cmb1.SelectedIndex))
            summe_IT = list_IT.Sum()
        Next

        Dim list_desktop As New List(Of Integer)
        For Each cmb2 In GroupBox2.Controls.OfType(Of ComboBox)()
            list_desktop.Add(CInt(cmb2.SelectedIndex))
            summe_desktop = list_desktop.Sum()
        Next

        Dim list_server As New List(Of Integer)
        For Each cmb3 In GroupBox3.Controls.OfType(Of ComboBox)()
            list_server.Add(CInt(cmb3.SelectedIndex))
            summe_server = list_server.Sum()
        Next

        Dim list_programmierung As New List(Of Integer)
        For Each cmb4 In GroupBox4.Controls.OfType(Of ComboBox)()
            list_programmierung.Add(CInt(cmb4.SelectedIndex))
            summe_programmierung = list_programmierung.Sum()
        Next

        Dim list_programmiersprache As New List(Of Integer)
        For Each cmb5 In GroupBox5.Controls.OfType(Of ComboBox)()
            list_programmiersprache.Add(CInt(cmb5.SelectedIndex))
            summe_programmiersprache = list_programmiersprache.Sum()
        Next

        Dim list_datenbank As New List(Of Integer)
        For Each cmb6 In GroupBox6.Controls.OfType(Of ComboBox)()
            list_datenbank.Add(CInt(cmb6.SelectedIndex))
            summe_datenbank = list_datenbank.Sum()
        Next

        ' For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_IT = cmbanzahl_IT + 1
        'End If
        'Next

        'For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_desktop = cmbanzahl_desktop + 1
        'End If
        'Next

        'For Each cmb In GroupBox3.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_server = cmbanzahl_server + 1
        'End If
        'Next

        'For Each cmb In GroupBox4.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_programmierung = cmbanzahl_programmierung + 1
        'End If
        'Next

        'For Each cmb In GroupBox5.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_programmiersprache = cmbanzahl_programmiersprache + 1
        'End If
        'Next

        'For Each cmb In GroupBox6.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_datenbank = cmbanzahl_datenbank + 1
        'End If
        'Next

        For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
            cmbanzahl_IT = cmbanzahl_IT + 1
        Next

        For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
            cmbanzahl_desktop = cmbanzahl_desktop + 1
        Next

        For Each cmb In GroupBox3.Controls.OfType(Of ComboBox)()
            cmbanzahl_server = cmbanzahl_server + 1
        Next

        For Each cmb In GroupBox4.Controls.OfType(Of ComboBox)()
            cmbanzahl_programmierung = cmbanzahl_programmierung + 1
        Next

        For Each cmb In GroupBox5.Controls.OfType(Of ComboBox)()
            cmbanzahl_programmiersprache = cmbanzahl_programmiersprache + 1
        Next

        For Each cmb In GroupBox6.Controls.OfType(Of ComboBox)()
            cmbanzahl_datenbank = cmbanzahl_datenbank + 1
        Next
    End Sub
    Private Sub btnIT_Click(sender As Object, e As EventArgs) Handles btnIT.Click
        Call ComboboxAddieren()
        ' Call Getbewid()
        Dim quotient_IT As Single = CSng(CSng(summe_IT / cmbanzahl_IT))
        Dim quotient_desktop As Single = CSng(CSng(summe_desktop / cmbanzahl_desktop))
        Dim quotient_server As Single = CSng(CSng(summe_server / cmbanzahl_server))
        Dim quotient_programmierung As Single = CSng(CSng(summe_programmierung / cmbanzahl_programmierung))
        Dim quotient_programmiersprache As Single = CSng(CSng(summe_programmiersprache / cmbanzahl_programmiersprache))
        Dim quotient_datenbank As Single = CSng(CSng(summe_datenbank / cmbanzahl_datenbank))
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwit = DirectCast(DirectCast(Me.Bewerber_itBindingSource.Current, DataRowView).Row, bewerber_itRow)
            'rwit.id_bew = CInt(bewid)

            rwit.it_anzahl_desktop = CShort(cmbanzahl_desktop)
            rwit.it_anzahl_server = CShort(cmbanzahl_server)
            rwit.it_anzahl_datenbank = CShort(cmbanzahl_datenbank)
            rwit.it_anzahl_it = CShort(cmbanzahl_IT)
            rwit.it_anzahl_programmierung = CShort(cmbanzahl_programmierung)
            rwit.it_anzahl_programmiersprache = CShort(cmbanzahl_programmiersprache)

            rwit.it_desktop_summe = CShort(summe_desktop)
            rwit.it_server_summe = CShort(summe_server)
            rwit.it_datenbank_summe = CShort(summe_datenbank)
            rwit.it_summe = CShort(summe_IT)
            rwit.it_programmierung_summe = CShort(summe_programmierung)
            rwit.it_programmiersprache_summe = CShort(summe_programmiersprache)

            rwit.it_desktop_durchschnitt = CStr(quotient_desktop)
            rwit.it_server_durchschnitt = CStr(quotient_server)
            rwit.it_durchschnitt = CStr(quotient_IT)
            rwit.it_datenbank_durchschnitt = CStr(quotient_datenbank)
            rwit.it_programmierung_durchschnitt = CStr(quotient_programmierung)
            rwit.it_programmiersprache_durchschnitt = CStr(quotient_programmiersprache)

            Me.Validate()
            Me.Bewerber_itBindingSource.EndEdit()
            Me.Bewerber_itTableAdapter.Update(Me.BewerberneuDataSet.bewerber_it)
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Mausraddeaktivieren()

        For Each Control In GroupBox1.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox2.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox3.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox4.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox5.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

        For Each Control In GroupBox6.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

    End Sub

    Private Sub Ignore_MouseWheel(sender As Object, e As MouseEventArgs)
        DirectCast(e, HandledMouseEventArgs).Handled = True
    End Sub
End Class
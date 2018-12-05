Imports bewerbertool.bewerberneuDataSet
Public Class frmLuG
    Public unternehmen_abrechnung As String = String.Empty
    Public lugsoftware_abrechnung As String = String.Empty
    Public unternehmen_buchhaltung As String = String.Empty
    Public lugsoftware_buchhaltung As String = String.Empty
    ' Public lugabrechnung_anzahl As String = String.Empty
    'Public lugbuchhaltung_anzahl As String = String.Empty
    Public summe_abrechnung As Integer = CInt(0)
    Public summe_buchhaltung As Integer = CInt(0)
    Public cmbanzahl_abrechnung As Integer = CInt(0)
    Public cmbanzahl_buchhaltung As Integer = CInt(0)
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

    Private Sub frmLuG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bew_lug". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bew_lugTableAdapter.Fill(Me.BewerberneuDataSet.bew_lug)
        Me.Bew_lugBindingSource.Filter = "id_bew = " & bewid & ""
        Call ComboboxFillSelect()
        Call Mausraddeaktivieren()
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
            cmb3.Items.Add("0 bis 10")
            cmb3.Items.Add("10 bis 50")
            cmb3.Items.Add("50 bis 100")
            cmb3.Items.Add("100 bis 200")
            cmb3.Items.Add("200 bis 300")
            cmb3.Items.Add("300 bis 400")
            cmb3.Items.Add("400 bis 500")
            cmb3.Items.Add("500 bis 1000")
            cmb3.Items.Add("mehr als 1.000")
            cmb3.DropDownStyle = ComboBoxStyle.DropDownList
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

    End Sub

    Private Sub ComboboxAddieren()
        Dim list As New List(Of Integer)
        For Each cmb1 In GroupBox1.Controls.OfType(Of ComboBox)()
            list.Add(CInt(cmb1.SelectedIndex))
            summe_abrechnung = list.Sum()
        Next

        For Each cmb2 In GroupBox2.Controls.OfType(Of ComboBox)()
            list.Add(CInt(cmb2.SelectedIndex))
            summe_buchhaltung = list.Sum()
        Next

        ' For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_abrechnung = cmbanzahl_abrechnung + 1
        'End If
        'Next

        'For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_buchhaltung = cmbanzahl_buchhaltung + 1
        'End If
        'Next

        For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
            cmbanzahl_abrechnung = cmbanzahl_abrechnung + 1
        Next

        For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
            cmbanzahl_buchhaltung = cmbanzahl_buchhaltung + 1
        Next
    End Sub

    Private Sub Lug_abrechnung_woListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lug_abrechnung_woListBox.SelectedIndexChanged, Lug_abrechnung_softwareListBox.SelectedIndexChanged, Lug_buchhaltung_woListBox.SelectedIndexChanged, Lug_buchhaltung_softwareListBox.SelectedIndexChanged

        unternehmen_abrechnung = String.Empty
        For i As Integer = 0 To Lug_abrechnung_woListBox.SelectedItems.Count - 1
            unternehmen_abrechnung &= Lug_abrechnung_woListBox.SelectedItems.Item(i).ToString & vbCrLf
        Next

        lugsoftware_abrechnung = String.Empty
        For h As Integer = 0 To Lug_abrechnung_softwareListBox.SelectedItems.Count - 1
            lugsoftware_abrechnung &= Lug_abrechnung_softwareListBox.SelectedItems.Item(h).ToString & vbCrLf
        Next

        unternehmen_buchhaltung = String.Empty
        For j As Integer = 0 To Lug_buchhaltung_woListBox.SelectedItems.Count - 1
            unternehmen_buchhaltung &= Lug_buchhaltung_woListBox.SelectedItems.Item(j).ToString & vbCrLf
        Next

        lugsoftware_buchhaltung = String.Empty
        For k As Integer = 0 To Lug_buchhaltung_softwareListBox.SelectedItems.Count - 1
            lugsoftware_buchhaltung &= Lug_buchhaltung_softwareListBox.SelectedItems.Item(k).ToString & vbCrLf
        Next

        'lugabrechnung_anzahl = String.Empty
        'For l As Integer = 0 To Lug_abrechnung_anzahlListBox.SelectedItems.Count - 1
        'lugabrechnung_anzahl &= Lug_abrechnung_anzahlListBox.SelectedItems.Item(l).ToString & vbCrLf
        'Next

        'lugbuchhaltung_anzahl = String.Empty
        'For m As Integer = 0 To Lug_buchhaltung_anzahlListBox.SelectedItems.Count - 1
        ' lugbuchhaltung_anzahl &= Lug_buchhaltung_anzahlListBox.SelectedItems.Item(m).ToString & vbCrLf
        ' Next
    End Sub
    Private Sub btnLuG_Click(sender As Object, e As EventArgs) Handles btnLuG.Click
        Call ComboboxAddieren()
        '  Call Getbewid()
        Dim quotient_abrechnung As Single = CSng(CSng(summe_abrechnung / cmbanzahl_abrechnung))
        Dim quotient_buchhaltung As Single = CSng(CSng(summe_buchhaltung / cmbanzahl_buchhaltung))
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwlug = DirectCast(DirectCast(Me.Bew_lugBindingSource.Current, DataRowView).Row, bew_lugRow)
            '   rwlug.id_bew = CInt(bewid)
            rwlug.lug_abrechnung_wo = CStr(unternehmen_abrechnung)
            rwlug.lug_buchhaltung_wo = CStr(unternehmen_buchhaltung)
            'rwlug.lug_abrechnung_anzahl = CStr(lugabrechnung_anzahl)
            'rwlug.lug_buchhaltung_anzahl = CStr(lugbuchhaltung_anzahl)
            rwlug.lug_abrechnung_software = CStr(lugsoftware_abrechnung)
            rwlug.lug_buchhaltung_software = CStr(lugsoftware_buchhaltung)
            rwlug.lug_anzahl_abrechnung = CShort(cmbanzahl_abrechnung)
            rwlug.lug_anzahl_buchhaltung = CShort(cmbanzahl_buchhaltung)
            rwlug.lug_summe_abrechnung = CShort(summe_abrechnung)
            rwlug.lug_summe_buchhaltung = CShort(summe_buchhaltung)
            rwlug.lug_durchschnitt_abrechnung = CStr(quotient_abrechnung)
            rwlug.lug_durchschnitt_buchhaltung = CStr(quotient_buchhaltung)

            Me.Validate()
            Me.Bew_lugBindingSource.EndEdit()
            Me.Bew_lugTableAdapter.Update(Me.BewerberneuDataSet.bew_lug)
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

    End Sub

    Private Sub Ignore_MouseWheel(sender As Object, e As MouseEventArgs)
        DirectCast(e, HandledMouseEventArgs).Handled = True
    End Sub
End Class
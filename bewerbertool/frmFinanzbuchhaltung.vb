Imports bewerbertool.bewerberneuDataSet
Public Class frmFinanzbuchhaltung
    Public fibuerfahrung As String = String.Empty
    Public fibusoftware As String = String.Empty
    Public kontenrahmen As String = String.Empty
    Public summe As Integer = CInt(0)
    Public cmbanzahl As Integer = CInt(0)
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

    Private Sub frmFinanzbuchhaltung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bewerber_fibu". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bewerber_fibuTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_fibu)
        Me.Bewerber_fibuBindingSource.Filter = "id_bew = " & bewid & ""
        Call ComboboxFillSelect()
        Call Mausraddeaktivieren()
        Fibu_erfahrungListBox.Select()
    End Sub

    Private Sub ComboboxFillSelect()
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

    Private Sub Fibu_erfahrungListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Fibu_erfahrungListBox.SelectedIndexChanged, Fibu_softwareListBox.SelectedIndexChanged, Fibu_kontenrahmenListBox.SelectedIndexChanged
        fibuerfahrung = String.Empty
        For i As Integer = 0 To Fibu_erfahrungListBox.SelectedItems.Count - 1
            fibuerfahrung &= Fibu_erfahrungListBox.SelectedItems.Item(i).ToString & vbCrLf
        Next

        fibusoftware = String.Empty
        For h As Integer = 0 To Fibu_softwareListBox.SelectedItems.Count - 1
            fibusoftware &= Fibu_softwareListBox.SelectedItems.Item(h).ToString & vbCrLf
        Next

        kontenrahmen = String.Empty
        For g As Integer = 0 To Fibu_kontenrahmenListBox.SelectedItems.Count - 1
            kontenrahmen &= Fibu_kontenrahmenListBox.SelectedItems.Item(g).ToString & vbCrLf
        Next
    End Sub

    Private Sub ComboboxAddieren()
        Dim list As New List(Of Integer)
        For Each cmb2 In GroupBox2.Controls.OfType(Of ComboBox)()
            list.Add(CInt(cmb2.SelectedIndex))
            summe = list.Sum()
        Next

        For Each cmb3 In GroupBox3.Controls.OfType(Of ComboBox)()
            list.Add(CInt(cmb3.SelectedIndex))
            summe = list.Sum()
        Next

        ' Dim anzahl1 As Integer = CInt(0)
        'For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'anzahl1 = anzahl1 + 1
        'End If
        'Next

        'Dim anzahl2 As Integer = CInt(0)
        'For Each cmb In GroupBox3.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'anzahl2 = anzahl2 + 1
        'End If
        'Next

        Dim anzahl1 As Integer = CInt(0)
        For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
            anzahl1 = anzahl1 + 1
        Next

        Dim anzahl2 As Integer = CInt(0)
        For Each cmb In GroupBox3.Controls.OfType(Of ComboBox)()
            anzahl2 = anzahl2 + 1
        Next

        cmbanzahl = anzahl1 + anzahl2
    End Sub
    Private Sub btnFibu_Click(sender As Object, e As EventArgs) Handles btnFibu.Click
        Call ComboboxAddieren()
        'Call Getbewid()
        Dim quotient As Single = CSng(CSng(summe / cmbanzahl).ToString)
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwfibu = DirectCast(DirectCast(Me.Bewerber_fibuBindingSource.Current, DataRowView).Row, bewerber_fibuRow)
            'rwfibu.id_bew = CInt(bewid)
            rwfibu.fibu_erfahrung = CStr(fibuerfahrung)
            rwfibu.fibu_software = CStr(fibusoftware)
            rwfibu.fibu_kontenrahmen = CStr(kontenrahmen)
            rwfibu.fibu_anzahl = CShort(cmbanzahl)
            rwfibu.fibu_summe = CShort(summe)
            rwfibu.fibu_durchschnitt = CStr(quotient)

            Me.Validate()
            Me.Bewerber_fibuBindingSource.EndEdit()
            Me.Bewerber_fibuTableAdapter.Update(Me.BewerberneuDataSet.bewerber_fibu)
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Mausraddeaktivieren()

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
Imports bewerbertool.bewerberneuDataSet
Public Class frmTechnische_Berufe
    Public summe_berufe As Integer = CInt(0)
    Public summe_technische_software As Integer = CInt(0)
    Public cmbanzahl As Integer = CInt(0)
    Public cmbanzahl_software As Integer = CInt(0)
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

    Private Sub frmTechnische_Berufe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bewerber_technik". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bewerber_technikTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_technik)
        Me.Bewerber_technikBindingSource.Filter = "id_bew = " & bewid & ""
        Call ComboboxFillSelect()
        Call Mausraddeaktivieren()
        Technik_maschinenbauComboBox.Select()
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
    End Sub

    Private Sub ComboboxAddieren()
        Dim list_berufe As New List(Of Integer)
        For Each cmb1 In GroupBox1.Controls.OfType(Of ComboBox)()
            list_berufe.Add(CInt(cmb1.SelectedIndex))
            summe_berufe = list_berufe.Sum()
        Next

        Dim list_technische_software As New List(Of Integer)
        For Each cmb2 In GroupBox2.Controls.OfType(Of ComboBox)()
            list_technische_software.Add(CInt(cmb2.SelectedIndex))
            summe_technische_software = list_technische_software.Sum()
        Next

        'For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl = cmbanzahl + 1
        'End If
        'Next

        For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
            cmbanzahl = cmbanzahl + 1
        Next

        For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
            cmbanzahl_software = cmbanzahl_software + 1
        Next
    End Sub
    Private Sub btnTechnischeBerufeSoftware_Click(sender As Object, e As EventArgs) Handles btnTechnischeBerufeSoftware.Click
        Call ComboboxAddieren()
        ' Call Getbewid()
        Dim quotient_berufe As Single = CSng(CSng(summe_berufe / cmbanzahl))
        Dim quotient_technische_software As Single = CSng(CSng(summe_technische_software / cmbanzahl_software))
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwtechnik = DirectCast(DirectCast(Me.Bewerber_technikBindingSource.Current, DataRowView).Row, bewerber_technikRow)
            '    rwtechnik.id_bew = CInt(bewid)
            rwtechnik.technik_anzahl = CShort(cmbanzahl)
            rwtechnik.technik_anzahl_software = CShort(cmbanzahl_software)
            rwtechnik.technik_summe = CShort(summe_berufe)
            rwtechnik.technik_software_summe = CShort(summe_technische_software)
            rwtechnik.technik_durchschnitt = CStr(quotient_berufe)
            rwtechnik.technik_software_durchschnitt = CStr(quotient_technische_software)

            Me.Validate()
            Me.Bewerber_technikBindingSource.EndEdit()
            Me.Bewerber_technikTableAdapter.Update(Me.BewerberneuDataSet.bewerber_technik)
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

    End Sub

    Private Sub Ignore_MouseWheel(sender As Object, e As MouseEventArgs)
        DirectCast(e, HandledMouseEventArgs).Handled = True
    End Sub
End Class
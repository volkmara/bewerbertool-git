Imports bewerbertool.bewerberneuDataSet
Public Class frmPersonalverwaltung
    Public tarifvertraege As String = String.Empty
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

    Private Sub frmPersonalverwaltung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bewerber_personal". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bewerber_personalTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_personal)
        Me.Bewerber_personalBindingSource.Filter = "id_bew = " & bewid & ""
        Call ComboboxFillSelect()
        Call Mausraddeaktivieren()
        Personal_rekrutierungComboBox.Select()
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

        Dim cb1 = GroupBox1.Controls.OfType(Of ComboBox)()
        For Each cb In cb1
            cb.SelectedIndex = 0
            cb.Width = 185
        Next
    End Sub

    Private Sub ComboboxAddieren()
        Dim list As New List(Of Integer)
        For Each cmb1 In GroupBox1.Controls.OfType(Of ComboBox)()
            list.Add(CInt(cmb1.SelectedIndex))
            summe = list.Sum()
        Next

        'For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl = cmbanzahl + 1
        'End If
        'Next

        For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
            cmbanzahl = cmbanzahl + 1
        Next
    End Sub
    Private Sub Personal_tarifverträgeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Personal_tarifverträgeListBox.SelectedIndexChanged
        tarifvertraege = String.Empty
        For i As Integer = 0 To Me.Personal_tarifverträgeListBox.SelectedItems.Count - 1
            tarifvertraege &= Personal_tarifverträgeListBox.SelectedItems.Item(i).ToString & vbCrLf
        Next
    End Sub

    Private Sub btnPersonalverwaltung_Click(sender As Object, e As EventArgs) Handles btnPersonalverwaltung.Click
        Call ComboboxAddieren()
        ' Call Getbewid()
        Dim quotient As Single = CSng(CSng(summe / cmbanzahl))
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwpersonal = DirectCast(DirectCast(Me.Bewerber_personalBindingSource.Current, DataRowView).Row, bewerber_personalRow)
            '    rwpersonal.id_bew = CInt(bewid)
            rwpersonal.personal_tarifverträge = CStr(tarifvertraege)
            rwpersonal.personal_anzahl = CShort(cmbanzahl)
            rwpersonal.personal_summe = CShort(summe)
            rwpersonal.personal_durchschnitt = CStr(quotient)

            Me.Validate()
            Me.Bewerber_personalBindingSource.EndEdit()
            Me.Bewerber_personalTableAdapter.Update(Me.BewerberneuDataSet.bewerber_personal)
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Personal_tarifvertrag_erfahrungComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Personal_tarifvertrag_erfahrungComboBox.SelectedIndexChanged
        If CInt(Personal_tarifvertrag_erfahrungComboBox.SelectedIndex) <> 0 Then
            Me.Personal_tarifverträgeListBox.Enabled = True
        End If
    End Sub

    Private Sub Mausraddeaktivieren()

        For Each Control In GroupBox1.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

    End Sub

    Private Sub Ignore_MouseWheel(sender As Object, e As MouseEventArgs)
        DirectCast(e, HandledMouseEventArgs).Handled = True
    End Sub
End Class
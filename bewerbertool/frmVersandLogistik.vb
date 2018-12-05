Imports bewerbertool.bewerberneuDataSet
Public Class frmVersandLogistik
    Public summe_versand As Integer = CInt(0)
    Public summe_logistik As Integer = CInt(0)
    Public cmbanzahl_versand As Integer = CInt(0)
    Public cmbanzahl_logistik As Integer = CInt(0)
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

    Private Sub frmVersandLogistik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bewerber_versand". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bewerber_versandTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_versand)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bewerber_logistik". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bewerber_logistikTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_logistik)

        Me.Bewerber_versandBindingSource.Filter = "id_bew = " & bewid & ""
        Me.Bewerber_logistikBindingSource.Filter = "id_bew = " & bewid & ""
        Call ComboboxFillSelect()
        Call Mausraddeaktivieren()
        Versand_importComboBox.Select()
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
        Dim list_versand As New List(Of Integer)
        For Each cmb1 In GroupBox1.Controls.OfType(Of ComboBox)()
            list_versand.Add(CInt(cmb1.SelectedIndex))
            summe_versand = list_versand.Sum()
        Next

        Dim list_logistik As New List(Of Integer)
        For Each cmb2 In GroupBox2.Controls.OfType(Of ComboBox)()
            list_logistik.Add(CInt(cmb2.SelectedIndex))
            summe_logistik = list_logistik.Sum()
        Next


        '  For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_versand = cmbanzahl_versand + 1
        'End If
        'Next

        'For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_logistik = cmbanzahl_logistik + 1
        'End If
        'Next

        For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
            cmbanzahl_versand = cmbanzahl_versand + 1
        Next

        For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
            cmbanzahl_logistik = cmbanzahl_logistik + 1
        Next
    End Sub
    Private Sub btnVersandLogistik_Click(sender As Object, e As EventArgs) Handles btnVersandLogistik.Click
        Call ComboboxAddieren()
        ' Call Getbewid()
        Dim quotient_versand As Single = CSng(CSng(summe_versand / cmbanzahl_versand))
        Dim quotient_logistik As Single = CSng(CSng(summe_logistik / cmbanzahl_logistik))
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwlogistik = DirectCast(DirectCast(Me.Bewerber_logistikBindingSource.Current, DataRowView).Row, bewerber_logistikRow)
            '    rwlogistik.id_bew = CInt(bewid)
            rwlogistik.logistik_anzahl = CShort(cmbanzahl_logistik)
            rwlogistik.logistik_summe = CShort(summe_logistik)
            rwlogistik.logistik_durchschnitt = CStr(quotient_logistik)

            Dim rwversand = DirectCast(DirectCast(Me.Bewerber_versandBindingSource.Current, DataRowView).Row, bewerber_versandRow)
            '   rwversand.id_bew = CInt(bewid)
            rwversand.versand_anzahl = CShort(cmbanzahl_versand)
            rwversand.versand_summe = CShort(summe_versand)
            rwversand.versand_durchschnitt = CStr(quotient_versand)

            Me.Validate()
            Me.Bewerber_versandBindingSource.EndEdit()
            Me.Bewerber_logistikBindingSource.EndEdit()
            Me.Bewerber_versandTableAdapter.Update(Me.BewerberneuDataSet.bewerber_versand)
            Me.Bewerber_logistikTableAdapter.Update(Me.BewerberneuDataSet.bewerber_logistik)
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
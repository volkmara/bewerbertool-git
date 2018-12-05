Imports bewerbertool.bewerberneuDataSet
Public Class frmBuero
    Public summe As Integer = CInt(0)
    Public cmbanzahl As Integer = CInt(0)
    Private _form1 As Form1
    Private _frmauswahlberuf As frmauswahlberuf

    Sub New(form1 As Form1)
        '  TODO: Complete member initialization 
        _form1 = form1
        InitializeComponent()
    End Sub

    Sub New(frmauswahlberuf As frmauswahlberuf)
        ' TODO: Complete member initialization 
        _frmauswahlberuf = frmauswahlberuf
        InitializeComponent()
    End Sub


    Private Sub frmBuero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bewerber_buero". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bewerber_bueroTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_buero)
        Buero_korrespondenz_freiComboBox.Select() ' setzt den Focus auf die erste Combobox, damit die Textbox nicht selektiert ist
        Me.Bewerber_bueroBindingSource.Filter = "id_bew = " & bewid & ""
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

        For Each cmb4 In GroupBox4.Controls.OfType(Of ComboBox)()
            cmb4.Items.Add("0 - keine Kenntnisse")
            cmb4.Items.Add("1 - immer angewendet")
            cmb4.Items.Add("2 - häufig")
            cmb4.Items.Add("3 - gelegentlich")
            cmb4.Items.Add("4 - Grundkenntnisse")
            cmb4.DropDownStyle = ComboBoxStyle.DropDownList
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

        Dim cb4 = GroupBox4.Controls.OfType(Of ComboBox)()
        For Each cb In cb4
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

        For Each cmb2 In GroupBox2.Controls.OfType(Of ComboBox)()
            list.Add(CInt(cmb2.SelectedIndex))
            summe = list.Sum()
        Next

        For Each cmb4 In GroupBox4.Controls.OfType(Of ComboBox)()
            list.Add(CInt(cmb4.SelectedIndex))
            summe = list.Sum()
        Next

        'Dim anzahl1 As Integer = CInt(0)
        'For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'anzahl1 = anzahl1 + 1
        'End If
        'Next

        'Dim anzahl2 As Integer = CInt(0)
        'For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'anzahl2 = anzahl2 + 1
        'End If
        'Next

        'Dim anzahl3 As Integer = CInt(0)
        'For Each cmb In GroupBox4.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'anzahl3 = anzahl3 + 1
        'End If
        'Next

        Dim anzahl1 As Integer = CInt(0)
        For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
            anzahl1 = anzahl1 + 1
        Next

        Dim anzahl2 As Integer = CInt(0)
        For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
            anzahl2 = anzahl2 + 1
        Next

        Dim anzahl3 As Integer = CInt(0)
        For Each cmb In GroupBox4.Controls.OfType(Of ComboBox)()
            anzahl3 = anzahl3 + 1
        Next

        cmbanzahl = anzahl1 + anzahl2 + anzahl3
    End Sub

    Private Sub btnBuerospeichern_Click(sender As Object, e As EventArgs) Handles btnBuerospeichern.Click
        'Call Getbewid()
        Call ComboboxAddieren()
        Dim quotient As Single = CSng(CSng(summe / cmbanzahl).ToString)
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwbuero = DirectCast(DirectCast(Me.Bewerber_bueroBindingSource.Current, DataRowView).Row, bewerber_bueroRow)
            '   rwbuero.id_bew = CInt(bewid)
            rwbuero.buero_anzahl = CShort(cmbanzahl)
            rwbuero.buero_summe = CShort(summe)
            rwbuero.buero_durchschnitt = CStr(quotient)

            Me.Validate()
            Me.Bewerber_bueroBindingSource.EndEdit()
            Me.Bewerber_bueroTableAdapter.Update(Me.BewerberneuDataSet.bewerber_buero)
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

        For Each Control In GroupBox4.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

    End Sub

    Private Sub Ignore_MouseWheel(sender As Object, e As MouseEventArgs)
        DirectCast(e, HandledMouseEventArgs).Handled = True
    End Sub
End Class
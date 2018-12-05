Imports bewerbertool.bewerberneuDataSet
Public Class frmVertrieb
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

    Private Sub frmVertrieb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bewerber_vertrieb". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bewerber_vertriebTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_vertrieb)
        Me.Bewerber_vertriebBindingSource.Filter = "id_bew = " & bewid & ""
        Call ComboboxFillSelect()
        Call Mausraddeaktivieren()
        Me.Vertrieb_innendienstComboBox.Select()
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
        Dim list As New List(Of Integer)
        For Each cmb1 In GroupBox1.Controls.OfType(Of ComboBox)()
            list.Add(CInt(cmb1.SelectedIndex))
            summe = list.Sum()
        Next

        For Each cmb2 In GroupBox2.Controls.OfType(Of ComboBox)()
            list.Add(CInt(cmb2.SelectedIndex))
            summe = list.Sum()
        Next

        ' Dim anzahl1 As Integer = CInt(0)
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

        Dim anzahl1 As Integer = CInt(0)
        For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
                anzahl1 = anzahl1 + 1
        Next

        Dim anzahl2 As Integer = CInt(0)
        For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
            anzahl2 = anzahl2 + 1
        Next

        cmbanzahl = anzahl1 + anzahl2
    End Sub
    Private Sub btnVertrieb_Click(sender As Object, e As EventArgs) Handles btnVertrieb.Click
        Call ComboboxAddieren()
        ' Call Getbewid()
        Dim quotient As Single = CSng(CSng(summe / cmbanzahl))
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwvertrieb = DirectCast(DirectCast(Me.Bewerber_vertriebBindingSource.Current, DataRowView).Row, bewerber_vertriebRow)
            '    rwvertrieb.id_bew = CInt(bewid)
            rwvertrieb.vertrieb_anzahl = CShort(cmbanzahl)
            rwvertrieb.vertrieb_summe = CShort(summe)
            rwvertrieb.vertrieb_durchschnitt = CStr(quotient)

            Me.Validate()
            Me.Bewerber_vertriebBindingSource.EndEdit()
            Me.Bewerber_vertriebTableAdapter.Update(Me.BewerberneuDataSet.bewerber_vertrieb)
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
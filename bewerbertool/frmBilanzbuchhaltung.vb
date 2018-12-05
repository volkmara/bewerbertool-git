Imports bewerbertool.bewerberneuDataSet
Public Class frmBilanzbuchhaltung
    Public summe As Integer = CInt(0)
    Public unternehmen As String = String.Empty
    Public bibuhasoftware As String = String.Empty
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

    Private Sub frmBilanzbuchhaltung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bew_bibuha". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bew_bibuhaTableAdapter.Fill(Me.BewerberneuDataSet.bew_bibuha)
        Me.Bew_bibuhaBindingSource.Filter = "id_bew = " & bewid & ""
        Call ComboboxFillSelect()
        Call Mausraddeaktivieren()
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

    Private Sub Bibuha_woListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Bibuha_woListBox.SelectedIndexChanged, Bibuha_softwareListBox.SelectedIndexChanged

        unternehmen = String.Empty
        For i As Integer = 0 To Bibuha_woListBox.SelectedItems.Count - 1
            unternehmen &= Bibuha_woListBox.SelectedItems.Item(i).ToString & vbCrLf
        Next

        bibuhasoftware = String.Empty
        For i As Integer = 0 To Bibuha_softwareListBox.SelectedItems.Count - 1
            bibuhasoftware &= Bibuha_softwareListBox.SelectedItems.Item(i).ToString & vbCrLf
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

        'Dim anzahl1 As Integer = CInt(0)
        'For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'anzahl1 = anzahl1 + 1
        'End If
        'Next

        Dim anzahl1 As Integer = CInt(0)
        For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
            anzahl1 = anzahl1 + 1
        Next

        'Dim anzahl2 As Integer = CInt(0)
        'For Each cmb In GroupBox3.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'anzahl2 = anzahl2 + 1
        'End If
        'Next

        Dim anzahl2 As Integer = CInt(0)
        For Each cmb In GroupBox3.Controls.OfType(Of ComboBox)()
            anzahl2 = anzahl2 + 1
        Next

        cmbanzahl = anzahl1 + anzahl2
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ComboboxAddieren()
        ' Call Getbewid()
        Dim quotient As Single = CSng(CSng(summe / cmbanzahl))
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then

            Dim rwbibuha = DirectCast(DirectCast(Me.Bew_bibuhaBindingSource.Current, DataRowView).Row, bew_bibuhaRow)
            ' rwbibuha.id_bew = CInt(bewid)
            rwbibuha.bibuha_wo = CStr(unternehmen)
            rwbibuha.bibuha_software = CStr(bibuhasoftware)
            rwbibuha.bibuha_summe = CShort(summe)
            rwbibuha.bibuha_anzahl = CShort(cmbanzahl)
            rwbibuha.bibuha_durchschnitt = CStr(quotient)

            Me.Validate()
            Me.Bew_bibuhaBindingSource.EndEdit()
            Me.Bew_bibuhaTableAdapter.Update(Me.BewerberneuDataSet.bew_bibuha)
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Bibuha_sondernbilanzenComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Bibuha_sondernbilanzenComboBox.SelectedIndexChanged
        If Bibuha_sondernbilanzenComboBox.SelectedIndex <> 0 Then
            Me.Bibuha_sondernbilanzen_welcheTextBox.Enabled = True
        End If
    End Sub


    ' Mausrad in Checkboxen deaktiviern
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
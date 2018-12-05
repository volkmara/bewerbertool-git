Imports bewerbertool.bewerberneuDataSet
Public Class frmSteuerfachangestellte

    Public steuerfachang_software As String = String.Empty
    Public steuerfachang_wo As String = String.Empty
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

    Private Sub frmSteuerfachangestellte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bew_steuerfachangestellte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bew_steuerfachangestellteTableAdapter.Fill(Me.BewerberneuDataSet.bew_steuerfachangestellte)
        Me.Bew_steuerfachangestellteBindingSource.Filter = "id_bew = " & bewid & ""
        Call Mausraddeaktivieren()
        Call ComboboxFillSelect()
        Me.Steuerfachang_sonstigeTextBox.Text = "Bitte ausfüllen:" & vbNewLine & "1." & vbNewLine & "2." & vbNewLine & "3."
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

        Dim cb2 = GroupBox2.Controls.OfType(Of ComboBox)()
        For Each cb In cb2
            cb.SelectedIndex = 0
            cb.Width = 185
        Next
    End Sub

    Private Sub ComboboxAddieren()
        Dim list As New List(Of Integer)
        For Each cmb2 In GroupBox2.Controls.OfType(Of ComboBox)()
            list.Add(CInt(cmb2.SelectedIndex))
            summe = list.Sum()
        Next

        'For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl = cmbanzahl + 1
        'End If
        'Next

        For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
            cmbanzahl = cmbanzahl + 1
        Next
    End Sub

    Private Sub Steuerfachang_softwareListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Steuerfachang_softwareListBox.SelectedIndexChanged, Steuerfachang_woListBox.SelectedIndexChanged
        steuerfachang_software = String.Empty
        For i As Integer = 0 To Steuerfachang_softwareListBox.SelectedItems.Count - 1
            steuerfachang_software &= Steuerfachang_softwareListBox.SelectedItems.Item(i).ToString & vbCrLf
        Next

        steuerfachang_wo = String.Empty
        For j As Integer = 0 To Steuerfachang_woListBox.SelectedItems.Count - 1
            steuerfachang_wo &= Steuerfachang_woListBox.SelectedItems.Item(j).ToString & vbCrLf
        Next
    End Sub

    Private Sub Steuerfachang_sonstigeTextBox_GotFocus(sender As Object, e As EventArgs) Handles Steuerfachang_sonstigeTextBox.GotFocus
        Me.Steuerfachang_sonstigeTextBox.Text = String.Empty
    End Sub

    Private Sub btnSteuerfachangestellte_Click(sender As Object, e As EventArgs) Handles btnSteuerfachangestellte.Click
        Call ComboboxAddieren()
        ' Call Getbewid()
        Dim quotient As Single = CSng(CSng(summe / cmbanzahl))
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwsteuerfachangestellte = DirectCast(DirectCast(Me.Bew_steuerfachangestellteBindingSource.Current, DataRowView).Row, bew_steuerfachangestellteRow)
            '    rwsteuerfachangestellte.id_bew = CInt(bewid)
            rwsteuerfachangestellte.steuerfachang_wo = CStr(steuerfachang_wo)
            rwsteuerfachangestellte.steuerfachang_software = CStr(steuerfachang_software)
            rwsteuerfachangestellte.steuerfachang_anzahl = CShort(cmbanzahl)
            rwsteuerfachangestellte.steuerfachang_summe = CShort(summe)
            rwsteuerfachangestellte.steuerfachang_durchschnitt = CStr(quotient)

            Me.Validate()
            Me.Bew_steuerfachangestellteBindingSource.EndEdit()
            Me.Bew_steuerfachangestellteTableAdapter.Update(Me.BewerberneuDataSet.bew_steuerfachangestellte)
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Mausraddeaktivieren()

        For Each Control In GroupBox2.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next

    End Sub

    Private Sub Ignore_MouseWheel(sender As Object, e As MouseEventArgs)
        DirectCast(e, HandledMouseEventArgs).Handled = True
    End Sub
End Class
Imports bewerbertool.bewerberneuDataSet
Public Class frmGewerblich

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

    Private Sub frmGewerblich_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.gewerblich". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.GewerblichTableAdapter.Fill(Me.BewerberneuDataSet.gewerblich)
        Me.GewerblichBindingSource.Filter = "id_bew = " & bewid & ""
        Call Mausraddeaktivieren()
        Call ComboboxFillSelect()
    End Sub
    Private Sub ComboboxFillSelect()
        For Each cmb2 In GroupBox1.Controls.OfType(Of ComboBox)()
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
    Private Sub btnGewerblich_Click(sender As Object, e As EventArgs) Handles btnGewerblich.Click
        Call ComboboxAddieren()
        'Call Getbewid()
        Dim quotient As Single = CSng(CSng(summe / cmbanzahl).ToString)
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwgewerblich = DirectCast(DirectCast(Me.GewerblichBindingSource.Current, DataRowView).Row, gewerblichRow)
            'rwgewerblich.id_bew = CInt(bewid)
            rwgewerblich.anzahl = CShort(cmbanzahl)
            rwgewerblich.summe = CShort(summe)
            rwgewerblich.durchschnitt = CStr(quotient)

            Me.Validate()
            Me.GewerblichBindingSource.EndEdit()
            Me.GewerblichTableAdapter.Update(Me.BewerberneuDataSet.gewerblich)
            Me.Close()
        Else
            Exit Sub
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
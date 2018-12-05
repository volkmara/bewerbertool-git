Imports bewerbertool.bewerberneuDataSet
Public Class frmMarketingDesign
    Public summe_design As Integer = CInt(0)
    Public summe_marketing As Integer = CInt(0)
    Public cmbanzahl_marketing As Integer = CInt(0)
    Public cmbanzahl_design As Integer = CInt(0)
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

    Private Sub frmMarketingDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "BewerberneuDataSet.bewerber_marketing_design". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Bewerber_marketing_designTableAdapter.Fill(Me.BewerberneuDataSet.bewerber_marketing_design)

        Me.Bewerber_marketing_designBindingSource.Filter = "id_bew = " & bewid & ""
        ComboboxFillSelect()
        Call Mausraddeaktivieren()
        M_d_printComboBox.Select()
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
        Dim list_marketing As New List(Of Integer)
        For Each cmb1 In GroupBox1.Controls.OfType(Of ComboBox)()
            list_marketing.Add(CInt(cmb1.SelectedIndex))
            summe_marketing = list_marketing.Sum()
        Next

        Dim list_design As New List(Of Integer)
        For Each cmb2 In GroupBox2.Controls.OfType(Of ComboBox)()
            list_design.Add(CInt(cmb2.SelectedIndex))
            summe_design = list_design.Sum()
        Next

        ' For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_marketing = cmbanzahl_marketing + 1
        'End If
        'Next

        'For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
        'If CInt(cmb.SelectedIndex) > 0 Then
        'cmbanzahl_design = cmbanzahl_design + 1
        'End If

        For Each cmb In GroupBox1.Controls.OfType(Of ComboBox)()
            cmbanzahl_marketing = cmbanzahl_marketing + 1
        Next

        For Each cmb In GroupBox2.Controls.OfType(Of ComboBox)()
            cmbanzahl_design = cmbanzahl_design + 1
        Next
    End Sub
    Private Sub btnGrafiksoftwareCMS_Click(sender As Object, e As EventArgs) Handles btnGrafiksoftwareCMS.Click
        Call ComboboxAddieren()
        ' Call Getbewid()
        Dim quotient_marketing As Single = CSng(CSng(summe_marketing / cmbanzahl_marketing))
        Dim quotient_design As Single = CSng(CSng(summe_design / cmbanzahl_design))
        MessageBox.Show(Message, Caption, Buttons, Mboxicon)
        If CBool(System.Windows.Forms.DialogResult.Yes) Then
            Dim rwmarkdes = DirectCast(DirectCast(Me.Bewerber_marketing_designBindingSource.Current, DataRowView).Row, bewerber_marketing_designRow)
            ' rwmarkdes.id_bew = CInt(bewid)
            rwmarkdes.m_d_anzahl_marketing = CShort(cmbanzahl_marketing)
            rwmarkdes.m_d_anzahl_design = CShort(cmbanzahl_marketing)
            rwmarkdes.m_d_marketing_summe = CShort(summe_marketing)
            rwmarkdes.m_d_design_summe = CShort(summe_design)
            rwmarkdes.m_d_marketing_durchschnitt = CStr(quotient_marketing)
            rwmarkdes.m_d_design_durchschnitt = CStr(quotient_design)

            Me.Validate()
            Me.Bewerber_marketing_designBindingSource.EndEdit()
            Me.Bewerber_marketing_designTableAdapter.Update(Me.BewerberneuDataSet.bewerber_marketing_design)
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

        For Each Control In GroupBox4.Controls.OfType(Of ComboBox)()
            AddHandler Control.MouseWheel, AddressOf Ignore_MouseWheel
        Next
    End Sub

    Private Sub Ignore_MouseWheel(sender As Object, e As MouseEventArgs)
        DirectCast(e, HandledMouseEventArgs).Handled = True
    End Sub
End Class
Imports MySql.Data.MySqlClient
Imports bewerbertool.bewerberneuDataSet
Public Class inallentabellen

    Public Shared Sub eintragen()
        Call Getbewid()

        If Not Form1.BewerberneuDataSet.bew_assistenz.Any(Function(rw) rw.id_bew = bewid) Then
            Dim assistenz = DirectCast(DirectCast(Form1.Bew_assistenzBindingSource.AddNew, DataRowView).Row, bew_assistenzRow)
            assistenz.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bew_assistenzBindingSource.EndEdit()
            Form1.Bew_assistenzTableAdapter.Update(Form1.BewerberneuDataSet.bew_assistenz)
        End If

        If Not Form1.BewerberneuDataSet.bew_bibuha.Any(Function(rw) rw.id_bew = bewid) Then
            Dim bibuha = DirectCast(DirectCast(Form1.Bew_bibuhaBindingSource.AddNew, DataRowView).Row, bew_bibuhaRow)
            bibuha.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bew_bibuhaBindingSource.EndEdit()
            Form1.Bew_bibuhaTableAdapter.Update(Form1.BewerberneuDataSet.bew_bibuha)
        End If

        If Not Form1.BewerberneuDataSet.bew_lug.Any(Function(rw) rw.id_bew = bewid) Then
            Dim lug = DirectCast(DirectCast(Form1.Bew_lugBindingSource.AddNew, DataRowView).Row, bew_lugRow)
            lug.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bew_lugBindingSource.EndEdit()
            Form1.Bew_lugTableAdapter.Update(Form1.BewerberneuDataSet.bew_lug)
        End If

        If Not Form1.BewerberneuDataSet.bew_steuerfachangestellte.Any(Function(rw) rw.id_bew = bewid) Then
            Dim steuerfachang = DirectCast(DirectCast(Form1.Bew_steuerfachangestellteBindingSource.AddNew, DataRowView).Row, bew_steuerfachangestellteRow)
            steuerfachang.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bew_steuerfachangestellteBindingSource.EndEdit()
            Form1.Bew_steuerfachangestellteTableAdapter.Update(Form1.BewerberneuDataSet.bew_steuerfachangestellte)
        End If

        If Not Form1.BewerberneuDataSet.bewerber_buero.Any(Function(rw) rw.id_bew = bewid) Then
            Dim buero = DirectCast(DirectCast(Form1.Bewerber_bueroBindingSource.AddNew, DataRowView).Row, bewerber_bueroRow)
            buero.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_bueroBindingSource.EndEdit()
            Form1.Bewerber_bueroTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_buero)
        End If

        If Not Form1.BewerberneuDataSet.bewerber_controlling.Any(Function(rw) rw.id_bew = bewid) Then
            Dim controlling = DirectCast(DirectCast(Form1.Bewerber_controllingBindingSource.AddNew, DataRowView).Row, bewerber_controllingRow)
            controlling.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_controllingBindingSource.EndEdit()
            Form1.Bewerber_controllingTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_controlling)
        End If

        If Not Form1.BewerberneuDataSet.bewerber_einkauf.Any(Function(rw) rw.id_bew = bewid) Then
            Dim einkauf = DirectCast(DirectCast(Form1.Bewerber_einkaufBindingSource.AddNew, DataRowView).Row, bewerber_einkaufRow)
            einkauf.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_einkaufBindingSource.EndEdit()
            Form1.Bewerber_einkaufTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_einkauf)
        End If

        If Not Form1.BewerberneuDataSet.bewerber_fibu.Any(Function(rw) rw.id_bew = bewid) Then
            Dim fibu = DirectCast(DirectCast(Form1.Bewerber_fibuBindingSource.AddNew, DataRowView).Row, bewerber_fibuRow)
            fibu.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_fibuBindingSource.EndEdit()
            Form1.Bewerber_fibuTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_fibu)
        End If

        If Not Form1.BewerberneuDataSet.bewerber_it.Any(Function(rw) rw.id_bew = bewid) Then
            Dim it = DirectCast(DirectCast(Form1.Bewerber_itBindingSource.AddNew, DataRowView).Row, bewerber_itRow)
            it.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_itBindingSource.EndEdit()
            Form1.Bewerber_itTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_it)
        End If

        Dim logistik = DirectCast(DirectCast(Form1.Bewerber_logistikBindingSource.AddNew, DataRowView).Row, bewerber_logistikRow)
        logistik.id_bew = CInt(bewid)
        Form1.Validate()
        Form1.Bewerber_logistikBindingSource.EndEdit()
        Form1.Bewerber_logistikTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_logistik)

        If Not Form1.BewerberneuDataSet.bewerber_marketing_design.Any(Function(rw) rw.id_bew = bewid) Then
            Dim mud = DirectCast(DirectCast(Form1.Bewerber_marketing_designBindingSource.AddNew, DataRowView).Row, bewerber_marketing_designRow)
            mud.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_marketing_designBindingSource.EndEdit()
            Form1.Bewerber_marketing_designTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_marketing_design)
        End If

        If Not Form1.BewerberneuDataSet.bewerber_personal.Any(Function(rw) rw.id_bew = bewid) Then
            Dim personal = DirectCast(DirectCast(Form1.Bewerber_personalBindingSource.AddNew, DataRowView).Row, bewerber_personalRow)
            personal.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_personalBindingSource.EndEdit()
            Form1.Bewerber_personalTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_personal)
        End If

        If Not Form1.BewerberneuDataSet.bewerber_rae.Any(Function(rw) rw.id_bew = bewid) Then
            Dim rae = DirectCast(DirectCast(Form1.Bewerber_raeBindingSource.AddNew, DataRowView).Row, bewerber_raeRow)
            rae.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_raeBindingSource.EndEdit()
            Form1.Bewerber_raeTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_rae)
        End If

        If Not Form1.BewerberneuDataSet.bewerber_technik.Any(Function(rw) rw.id_bew = bewid) Then
            Dim technik = DirectCast(DirectCast(Form1.Bewerber_technikBindingSource.AddNew, DataRowView).Row, bewerber_technikRow)
            technik.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_technikBindingSource.EndEdit()
            Form1.Bewerber_technikTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_technik)
        End If

        If Not Form1.BewerberneuDataSet.bewerber_versand.Any(Function(rw) rw.id_bew = bewid) Then
            Dim versand = DirectCast(DirectCast(Form1.Bewerber_versandBindingSource.AddNew, DataRowView).Row, bewerber_versandRow)
            versand.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_versandBindingSource.EndEdit()
            Form1.Bewerber_versandTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_versand)
        End If

        If Not Form1.BewerberneuDataSet.bewerber_vertrieb.Any(Function(rw) rw.id_bew = bewid) Then
            Dim vertrieb = DirectCast(DirectCast(Form1.Bewerber_vertriebBindingSource.AddNew, DataRowView).Row, bewerber_vertriebRow)
            vertrieb.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.Bewerber_vertriebBindingSource.EndEdit()
            Form1.Bewerber_vertriebTableAdapter.Update(Form1.BewerberneuDataSet.bewerber_vertrieb)
        End If

        If Not Form1.BewerberneuDataSet.gewerblich.Any(Function(rw) rw.id_bew = bewid) Then
            Dim gewerblich = DirectCast(DirectCast(Form1.GewerblichBindingSource.AddNew, DataRowView).Row, gewerblichRow)
            gewerblich.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.GewerblichBindingSource.EndEdit()
            Form1.GewerblichTableAdapter.Update(Form1.BewerberneuDataSet.gewerblich)
        End If

        If Not Form1.BewerberneuDataSet.ulas.Any(Function(rw) rw.id_bew = bewid) Then
            Dim ulas = DirectCast(DirectCast(Form1.UlasBindingSource.AddNew, DataRowView).Row, ulasRow)
            ulas.id_bew = CInt(bewid)
            Form1.Validate()
            Form1.UlasBindingSource.EndEdit()
            Form1.UlasTableAdapter.Update(Form1.BewerberneuDataSet.ulas)
        End If
    End Sub
End Class

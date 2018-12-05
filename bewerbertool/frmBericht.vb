Public Class frmBericht

    Private Sub Bericht_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.gewerblich". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.gewerblichTableAdapter.Fill(Me.bewerberneuDataSet.gewerblich)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_it". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_itTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_it)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_technik". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_technikTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_technik)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_personal". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_personalTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_personal)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_marketing_design". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_marketing_designTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_marketing_design)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_versand". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_versandTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_versand)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_logistik". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_logistikTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_logistik)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_einkauf". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_einkaufTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_einkauf)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_vertrieb". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_vertriebTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_vertrieb)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bew_steuerfachangestellte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bew_steuerfachangestellteTableAdapter.Fill(Me.bewerberneuDataSet.bew_steuerfachangestellte)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bew_lug". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bew_lugTableAdapter.Fill(Me.bewerberneuDataSet.bew_lug)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_controlling". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_controllingTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_controlling)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bew_bibuha". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bew_bibuhaTableAdapter.Fill(Me.bewerberneuDataSet.bew_bibuha)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_fibu". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_fibuTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_fibu)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_rae". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_raeTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_rae)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bew_assistenz". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bew_assistenzTableAdapter.Fill(Me.bewerberneuDataSet.bew_assistenz)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_buero". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_bueroTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_buero)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_edv". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_edvTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_edv)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_sprachen". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_sprachenTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_sprachen)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_berufserfahrung". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_berufserfahrungTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_berufserfahrung)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bewerber_ausbildung". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewerber_ausbildungTableAdapter.Fill(Me.bewerberneuDataSet.bewerber_ausbildung)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bew_bewerberdaten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bew_bewerberdatenTableAdapter.Fill(Me.bewerberneuDataSet.bew_bewerberdaten)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "bewerberneuDataSet.bew". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.bewTableAdapter.Fill(Me.bewerberneuDataSet.bew)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
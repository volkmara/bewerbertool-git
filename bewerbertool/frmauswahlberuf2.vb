Public Class frmauswahlberuf2

    Private _form1 As Form1

    Sub New(form1 As Form1)
        _form1 = form1
        InitializeComponent()
    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Public Shared Property buerobool2 As Boolean = False
    Public Shared Property assistenzbool2 As Boolean = False
    Public Shared Property raebool2 As Boolean = False
    Public Shared Property fibubool2 As Boolean = False
    Public Shared Property bibuhabool2 As Boolean = False
    Public Shared Property controllingbool2 As Boolean = False
    Public Shared Property lugbool2 As Boolean = False
    Public Shared Property vertriebbool2 As Boolean = False
    Public Shared Property einkaufbool2 As Boolean = False
    Public Shared Property versandbool2 As Boolean = False
    Public Shared Property mudbool2 As Boolean = False
    Public Shared Property personalverwaltungbool2 As Boolean = False
    Public Shared Property technikbool2 As Boolean = False
    Public Shared Property itbool2 As Boolean = False
    Public Shared Property steuerfachangestelltebool2 As Boolean = False
    Public Shared Property gewerblichbool2 As Boolean = False

    Private Sub btnschliessen_Click(sender As Object, e As EventArgs) Handles btnschliessen.Click
        Call Me.berufswahl()
        Me.Close()
    End Sub

    Private Sub berufswahl()

        If Me.rbtnBueroJa.Checked Then
            buerobool2 = True
        End If

        If Me.rbtnAssistenzJa.Checked Then
            assistenzbool2 = True
        End If

        If Me.rbtnRaeJa.Checked Then
            raebool2 = True
        End If

        If Me.rbtnFibuhaJa.Checked Then
            fibubool2 = True
        End If

        If Me.rbtnBibuhaJa.Checked Then
            bibuhabool2 = True
        End If

        If Me.rbtnControllingJa.Checked Then
            controllingbool2 = True
        End If

        If Me.rbtnSteuerfachangJa.Checked Then
            steuerfachangestelltebool2 = True
        End If

        If Me.rbtnLuGJa.Checked Then
            lugbool2 = True
        End If

        If Me.rbtnVertriebJa.Checked Then
            vertriebbool2 = True
        End If

        If Me.rbtnEinkaufJa.Checked Then
            einkaufbool2 = True
        End If

        If rbtnVersandJa.Checked Then
            versandbool2 = True
        End If

        If rbtnMarketingJa.Checked Then
            mudbool2 = True
        End If

        If rbtnPersonalJa.Checked Then
            personalverwaltungbool2 = True
        End If

        If Me.rbtnTechnikJa.Checked Then
            technikbool2 = True
        End If

        If Me.rbtnITJa.Checked Then
            itbool2 = True
        End If

        If Me.rbtnGewerblichJa.Checked Then
            gewerblichbool2 = True
        End If
    End Sub

    Private Sub frmauswahlberuf_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        rbtnBueroJa.Checked = False
        If frmauswahlberuf.buerobool Then
            GroupBox1.Visible = False
        End If
        If frmauswahlberuf.assistenzbool Then
            GroupBox2.Visible = False
        End If
        If frmauswahlberuf.raebool Then
            GroupBox3.Visible = False
        End If
        If frmauswahlberuf.fibubool Then
            GroupBox4.Visible = False
        End If
        If frmauswahlberuf.bibuhabool Then
            GroupBox5.Visible = False
        End If
        If frmauswahlberuf.controllingbool Then
            GroupBox6.Visible = False
        End If
        If frmauswahlberuf.steuerfachangestelltebool Then
            GroupBox7.Visible = False
        End If
        If frmauswahlberuf.lugbool Then
            GroupBox8.Visible = False
        End If
        If frmauswahlberuf.vertriebbool Then
            GroupBox9.Visible = False
        End If
        If frmauswahlberuf.einkaufbool Then
            GroupBox11.Visible = False
        End If
        If frmauswahlberuf.versandbool Then
            GroupBox12.Visible = False
        End If
        If frmauswahlberuf.mudbool Then
            GroupBox10.Visible = False
        End If
        If frmauswahlberuf.personalverwaltungbool Then
            GroupBox13.Visible = False
        End If
        If frmauswahlberuf.technikbool Then
            GroupBox14.Visible = False
        End If
        If frmauswahlberuf.itbool Then
            GroupBox15.Visible = False
        End If
        If frmauswahlberuf.gewerblichbool Then
            GroupBox16.Visible = False
        End If
    End Sub
End Class
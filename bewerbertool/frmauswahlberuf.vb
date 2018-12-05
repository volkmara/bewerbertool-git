Public Class frmauswahlberuf

    Private _form1 As Form1
    Private _frmauswahlberuf As frmauswahlberuf

    Sub New(form1 As Form1)
        _form1 = form1
        InitializeComponent()
    End Sub

    ' Sub New()
    '    InitializeComponent()
    'End Sub

    Sub New(frmauswahlberuf As frmauswahlberuf)
        ' TODO: Complete member initialization 
        _frmauswahlberuf = frmauswahlberuf
        InitializeComponent()
    End Sub

    Public Shared Property buerobool As Boolean = False
    Public Shared Property assistenzbool As Boolean = False
    Public Shared Property raebool As Boolean = False
    Public Shared Property fibubool As Boolean = False
    Public Shared Property bibuhabool As Boolean = False
    Public Shared Property controllingbool As Boolean = False
    Public Shared Property lugbool As Boolean = False
    Public Shared Property vertriebbool As Boolean = False
    Public Shared Property einkaufbool As Boolean = False
    Public Shared Property versandbool As Boolean = False
    Public Shared Property mudbool As Boolean = False
    Public Shared Property personalverwaltungbool As Boolean = False
    Public Shared Property technikbool As Boolean = False
    Public Shared Property itbool As Boolean = False
    Public Shared Property steuerfachangestelltebool As Boolean = False
    Public Shared Property gewerblichbool As Boolean = False

    Public counter As Integer = CInt(0)

    Private Sub btnweiter_Click(sender As Object, e As EventArgs) Handles btnweiter.Click
        Call chkwahl()
        Call chkcount()
        Dim result As DialogResult = MessageBox.Show("Haben Sie Ihre Auswahl abgeschlossen?", "Berufsfelder auswählen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        ElseIf result = DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub chkwahl()
        If chkBuero.Checked Then
            buerobool = True
        End If
        If chkAssistenz.Checked Then
            assistenzbool = True
        End If
        If chKRae.Checked Then
            raebool = True
        End If
        If chkFibu.Checked Then
            fibubool = True
        End If
        If chkBibuha.Checked Then
            bibuhabool = True
        End If
        If chkControlling.Checked Then
            controllingbool = True
        End If
        If chkLuG.Checked Then
            lugbool = True
        End If
        If chkSteuerfachang.Checked Then
            steuerfachangestelltebool = True
        End If
        If chkVertrieb.Checked Then
            vertriebbool = True
        End If
        If chkEinkauf.Checked Then
            einkaufbool = True
        End If
        If chkVersand.Checked Then
            versandbool = True
        End If
        If chkMuD.Checked Then
            mudbool = True
        End If
        If chkPersonal.Checked Then
            personalverwaltungbool = True
        End If
        If chkTechnik.Checked Then
            technikbool = True
        End If
        If chkIT.Checked Then
            itbool = True
        End If
        If chkGewerblich.Checked Then
            gewerblichbool = True
        End If
    End Sub


    ' Berufsfenster öffnen sich
    Private Sub berufsfenster()
        If buerobool Then
            Using frm = New frmBuero(Me)
                Dim result = frm.ShowDialog(Me)
            End Using
        End If
        If assistenzbool Then
            Using frm = New frmAssistenz(Me)
                Dim result = frm.ShowDialog(Me)
            End Using
        End If
        If raebool Then
            Using frm = New frmRAE(Me)
                Dim result = frm.ShowDialog(Me)
            End Using
        End If
        If fibubool Then
            Using frm = New frmFinanzbuchhaltung(Me)
                Dim result = frm.ShowDialog(Me)
            End Using
        End If
        If bibuhabool Then
            Using frm = New frmBilanzbuchhaltung(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If controllingbool Then
            Using frm = New frmControlling(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If lugbool Then
            Using frm = New frmLuG(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If steuerfachangestelltebool Then
            Using frm = New frmSteuerfachangestellte(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If vertriebbool Then
            Using frm = New frmVertrieb(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If einkaufbool Then
            Using frm = New frmEinkauf(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If versandbool Then
            Using frm = New frmVersandLogistik(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If mudbool Then
            Using frm = New frmMarketingDesign(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If personalverwaltungbool Then
            Using frm = New frmPersonalverwaltung(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If technikbool Then
            Using frm = New frmTechnische_Berufe(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If itbool Then
            Using frm = New frmIT(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
        If gewerblichbool Then
            Using frm = New frmGewerblich(Me)
                Dim result = frm.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub chkcount()
        'Checkboxen werden einer list of t hinzugefügt und gezählt. Wenn counter <> 0, geht es weiter und Berufsfelder werden geöffnet, wenn counter = 0, wird abgefragt, ob Berufsfelder vergessen wurden.
        Dim check As New List(Of CheckBox)
        For Each cb As CheckBox In Me.Panel1.Controls.OfType(Of CheckBox)()
            If DirectCast(cb, CheckBox).Checked Then
                check.Add(cb)
            Else
                check.Remove(cb)
            End If
        Next
        counter = check.Count
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
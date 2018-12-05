Public Class frmEnde
    'Private Sub Ende_Load(sender As Object, e As EventArgs) Handles Me.Load

    ' Anzeige der Grafik in Abhängigkeit vom Connectionstring
    'If connectionString.Contains("uid=root") Then
    'WebBrowser1.Navigate("e:\heyduck\bewerberduck\bilder\feuerwerk048.gif")
    'ElseIf connectionString.Contains("uid=adler") Then
    'WebBrowser1.Navigate("x:\bewerberduck\bilder\feuerwerk048.gif")
    'End If

    'WebBrowser1.Navigate("e:\heyduck\bewerberduck\bilder\feuerwerk048.gif")
    'WebBrowser1.Navigate("x:\bewerberduck\bilder\feuerwerk048.gif")

    ' End Sub

    Private _form1 As Form1

    Sub New(form1 As Form1)
        ' TODO: Complete member initialization 
        _form1 = form1
        InitializeComponent()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
End Class
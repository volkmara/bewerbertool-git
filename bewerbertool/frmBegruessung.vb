Public Class frmBegruessung

    Private Sub frmBegruessung_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.RichTextBox1.LoadFile("begruessung.rtf")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub
End Class
Imports MySql.Data.MySqlClient

Module Module1
    Public bewid As Integer = CInt(1)

    'Variablen für MySql-Verbindung

    'Public connectionString As String = "Server=127.0.0.1; uid=root; pwd=heyduck1!; Convert Zero Datetime=True;database=bewerberneu;"
    Public connectionString As String = "Server=SERVER2012; uid=Adler; pwd=zgA7K$z!; Convert Zero Datetime=True; database=bewerberneu;"
    'Public connectionString As String = "Server=192.168.192.14; uid=vmwareuser; pwd=schmar139; database=bewerberneu;"

    'Messagebox konfigurieren
    Public Message As String = "Bitte überprüfen Sie Ihre Eingaben." & vbNewLine & "Wenn alles korrekt ist, drücken Sie bitte auf Ja, ansonsten bitte auf Nein und korrigieren Sie Ihre Eingaben."
    Public Caption As String = "Eingaben speichern"
    Public Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Public Mboxicon As MessageBoxIcon = MessageBoxIcon.Question
    'Public Result As DialogResult = MessageBox.Show(Message, Caption, Buttons, Mboxicon)

    Public Sub Getbewid()
        Dim query As String = ("SELECT MAX(id_bew) From bewerberneu.bew")
        Dim cnn As New MySqlConnection(connectionString)

        Using connection As New MySqlConnection(connectionString)
            Try
                cnn.Open()
                Dim command As New MySqlCommand(query, cnn)
                bewid = CInt(command.ExecuteScalar())
                cnn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Public Sub datuminerstkontakt()
        Call Getbewid()
        Dim updatesql As String = "update bewerberneu.bew set erstkontakt = @zeit where id_bew = @bewid"
        Using conn As New MySqlConnection(connectionString)
            Dim cmd As New MySqlCommand(updatesql, conn)
            With cmd
                .Parameters.AddWithValue("@zeit", Date.Now)
                .Parameters.AddWithValue("@bewid", CInt(bewid))
            End With
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Public Save As Boolean

End Module

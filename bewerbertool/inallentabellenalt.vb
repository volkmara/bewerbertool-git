Imports MySql.Data.MySqlClient
Public Class inallentabellen
    Public test As Boolean

    Public Shared Sub eintragen()
        Call Getbewid()

        ' SQL-Strings
        Dim sql_assistenz As String = "INSERT INTO bewerberneu.bew_assistenz (id_bew) VALUES (@idbew);"
        Dim sql_bibuha As String = "INSERT INTO bewerberneu.bew_bibuha (id_bew) VALUES (@idbew);"
        Dim sql_lug As String = "INSERT INTO bewerberneu.bew_lug (id_bew) VALUES (@idbew);"
        Dim sql_steuerfachangestellte As String = "INSERT INTO bewerberneu.bew_steuerfachangestellte (id_bew) VALUES (@idbew);"
        Dim sql_buero As String = "INSERT INTO bewerberneu.bewerber_buero (id_bew) VALUES (@idbew);"
        Dim sql_controlling As String = "INSERT INTO bewerberneu.bewerber_controlling (id_bew) VALUES (@idbew);"
        Dim sql_einkauf As String = "INSERT INTO bewerberneu.bewerber_einkauf (id_bew) VALUES (@idbew);"
        Dim sql_fibu As String = "INSERT INTO bewerberneu.bewerber_fibu (id_bew) VALUES (@idbew);"
        Dim sql_it As String = "INSERT INTO bewerberneu.bewerber_it (id_bew) VALUES (@idbew);"
        Dim sql_logistik As String = "INSERT INTO bewerberneu.bewerber_logistik (id_bew) VALUES (@idbew);"
        Dim sql_marketing_design As String = "INSERT INTO bewerberneu.bewerber_marketing_design (id_bew) VALUES (@idbew);"
        Dim sql_personal As String = "INSERT INTO bewerberneu.bewerber_personal (id_bew) VALUES (@idbew);"
        Dim sql_rae As String = "INSERT INTO bewerberneu.bewerber_rae (id_bew) VALUES (@idbew);"
        Dim sql_technik As String = "INSERT INTO bewerberneu.bewerber_technik (id_bew) VALUES (@idbew);"
        Dim sql_versand As String = "INSERT INTO bewerberneu.bewerber_versand (id_bew) VALUES (@idbew);"
        Dim sql_vertrieb As String = "INSERT INTO bewerberneu.bewerber_vertrieb (id_bew) VALUES (@idbew);"
        Dim sql_gewerblich As String = "INSERT INTO bewerberneu.gewerblich (id_bew) VALUES (@idbew);"
        Dim sql_ulas As String = "INSERT INTO bewerberneu.ulas (id_bew) VALUES (@idbew);"

        Using conn As New MySqlConnection(connectionString)

            'COMMAND-Strings
            Dim comm_assistenz As New MySqlCommand(sql_assistenz, conn)
            Dim comm_bibuha As New MySqlCommand(sql_bibuha, conn)
            Dim comm_lug As New MySqlCommand(sql_lug, conn)
            Dim comm_steuerfachangestellte As New MySqlCommand(sql_steuerfachangestellte, conn)
            Dim comm_buero As New MySqlCommand(sql_buero, conn)
            Dim comm_controlling As New MySqlCommand(sql_controlling, conn)
            Dim comm_einkauf As New MySqlCommand(sql_einkauf, conn)
            Dim comm_fibu As New MySqlCommand(sql_fibu, conn)
            Dim comm_it As New MySqlCommand(sql_it, conn)
            Dim comm_logistik As New MySqlCommand(sql_logistik, conn)
            Dim comm_marketing_design As New MySqlCommand(sql_marketing_design, conn)
            Dim comm_personal As New MySqlCommand(sql_personal, conn)
            Dim comm_rae As New MySqlCommand(sql_rae, conn)
            Dim comm_technik As New MySqlCommand(sql_technik, conn)
            Dim comm_versand As New MySqlCommand(sql_versand, conn)
            Dim comm_vertrieb As New MySqlCommand(sql_vertrieb, conn)
            Dim comm_gewerblich As New MySqlCommand(sql_gewerblich, conn)
            Dim comm_ulas As New MySqlCommand(sql_ulas, conn)

            ' Parameter-Strings
            comm_assistenz.Parameters.AddWithValue("@idbew", bewid)
            comm_bibuha.Parameters.AddWithValue("@idbew", bewid)
            comm_lug.Parameters.AddWithValue("@idbew", bewid)
            comm_steuerfachangestellte.Parameters.AddWithValue("@idbew", bewid)
            comm_buero.Parameters.AddWithValue("@idbew", bewid)
            comm_controlling.Parameters.AddWithValue("@idbew", bewid)
            comm_einkauf.Parameters.AddWithValue("@idbew", bewid)
            comm_fibu.Parameters.AddWithValue("@idbew", bewid)
            comm_it.Parameters.AddWithValue("@idbew", bewid)
            comm_logistik.Parameters.AddWithValue("@idbew", bewid)
            comm_marketing_design.Parameters.AddWithValue("@idbew", bewid)
            comm_personal.Parameters.AddWithValue("@idbew", bewid)
            comm_rae.Parameters.AddWithValue("@idbew", bewid)
            comm_technik.Parameters.AddWithValue("@idbew", bewid)
            comm_versand.Parameters.AddWithValue("@idbew", bewid)
            comm_vertrieb.Parameters.AddWithValue("@idbew", bewid)
            comm_gewerblich.Parameters.AddWithValue("@idbew", bewid)
            comm_ulas.Parameters.AddWithValue("@idbew", bewid)
            Try
                conn.Open()
                If Not inassistenz(bewid) Then
                    comm_assistenz.ExecuteNonQuery()
                End If
                If Not inbibuha(bewid) Then
                    comm_bibuha.ExecuteNonQuery()
                End If
                If Not inlug(bewid) Then
                    comm_lug.ExecuteNonQuery()
                End If
                If Not insteuerfachang(bewid) Then
                    comm_steuerfachangestellte.ExecuteNonQuery()
                End If
                If Not inbuero(bewid) Then
                    comm_buero.ExecuteNonQuery()
                End If
                If Not incontrolling(bewid) Then
                    comm_controlling.ExecuteNonQuery()
                End If
                If Not ineinkauf(bewid) Then
                    comm_einkauf.ExecuteNonQuery()
                End If
                If Not infibu(bewid) Then
                    comm_fibu.ExecuteNonQuery()
                End If
                If Not init(bewid) Then
                    comm_it.ExecuteNonQuery()
                End If
                If Not inlogistik(bewid) Then
                    comm_logistik.ExecuteNonQuery()
                End If
                If Not inmud(bewid) Then
                    comm_marketing_design.ExecuteNonQuery()
                End If
                If Not inpersonal(bewid) Then
                    comm_personal.ExecuteNonQuery()
                End If
                If Not inrae(bewid) Then
                    comm_rae.ExecuteNonQuery()
                End If
                If Not intechnik(bewid) Then
                    comm_technik.ExecuteNonQuery()
                End If
                If Not inversand(bewid) Then
                    comm_versand.ExecuteNonQuery()
                End If
                If Not invertrieb(bewid) Then
                    comm_vertrieb.ExecuteNonQuery()
                End If
                If Not ingewerblich(bewid) Then
                    comm_gewerblich.ExecuteNonQuery()
                End If
                If Not inulas(bewid) Then
                    comm_ulas.ExecuteNonQuery()
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    ' Abfragen, ob bewid in Tabelle existiert
    Public Shared Function inassistenz(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bew_assistenz.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inbibuha(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bew_bibuha.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inlug(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bew_lug.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function insteuerfachang(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bew_steuerfachangestellte.Any(Function(rw) rw.id_bew = test)
    End Function
    Public Shared Function inbuero(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_buero.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function incontrolling(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_controlling.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function ineinkauf(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_einkauf.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function infibu(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_fibu.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function init(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_it.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inlogistik(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_logistik.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inmud(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_marketing_design.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inpersonal(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_personal.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inrae(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_buero.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function intechnik(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_technik.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inversand(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_versand.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function invertrieb(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.bewerber_vertrieb.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function ingewerblich(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.gewerblich.Any(Function(rw) rw.id_bew = test)
    End Function

    Public Shared Function inulas(ByVal test As Integer) As Boolean
        Return Form1.BewerberneuDataSet.ulas.Any(Function(rw) rw.id_bew = test)
    End Function

End Class

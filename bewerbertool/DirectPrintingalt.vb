﻿Imports System.IO
Imports System.Text
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports System.Media

Public NotInheritable Class DirectPrinting
    Implements IDisposable

    Private Shared ReadOnly _instance As New Lazy(Of DirectPrinting)(Function() New DirectPrinting(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property getInstance() As DirectPrinting
        Get
            Return _instance.Value
        End Get
    End Property

    Private myResponse As String = "Ready..."
    Private myReport As New LocalReport()
    Private myFile As FileInfo
    Private myFileExtension As String
    Private myExtensions As New Dictionary(Of String, String) From {{".pdf", "PDF"}, {".xls", "Excel"}, {".doc", "Word"}, {".jpg", "Image"}, {".bmp", "Image"}}
    'Private myExtensions As New Dictionary(Of String, String) From {{".pdf", "PDF"}}
    Private myStreams As IList(Of Stream)
    Private myCurrentPage As Integer

    Public Sub Dispose() Implements IDisposable.Dispose
        If myStreams IsNot Nothing Then
            For Each stream As Stream In myStreams : stream.Close() : Next
            myStreams = Nothing
        End If
    End Sub

    Public Function DirectPrint(Report As LocalReport, Optional Save As Boolean = False) As String
        ' If Save Then
        'myReport = Report
        'Dim fi = SaveTo()
        'If fi Is Nothing Then Return String.Empty
        'myFileExtension = fi.Extension
        'If Not myExtensions.ContainsKey(myFileExtension) Then
        'SystemSounds.Hand.Play()
        'Return String.Concat("File-Error! : Die Dateiextension '", myFileExtension, "' wird nicht unterstützt...")
        'End If
        'myFile = New FileInfo(fi.FullName)
        'myReport.Refresh()
        '  Using Printer As New DirectPrinting()
        'If myExtensions.Item(myFileExtension) = "Image" Then Export() Else saveReport() 'PDF, Word, Excel
        'Return myResponse
        'End Using
        'End If
        Using Printer As New DirectPrinting()
            myReport = Report
            myFile = Nothing
            myReport.Refresh()
            If Export() Then printReport()
            Return myResponse
        End Using
    End Function

    '  Private Function SaveTo() As FileInfo
    '     Using dlg As New SaveFileDialog
    'dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    '        If connectionString.Contains("127.0.0.1") Then
    '           dlg.InitialDirectory = "e:\heyduck\Stellenanzeigen extern\"
    '      Else
    '         dlg.InitialDirectory = "x:\Stellenanzeigen extern\"
    '    End If
    '   dlg.AddExtension = True
    '  dlg.FileName = myReport.DisplayName
    ' dlg.CheckPathExists = True
    'dlg.Filter = "PDF File (*.pdf)|*.pdf|Excel (*.xls)|*.xls|Word (*.doc)|*.doc|Image JPG (*.jpg)|*.jpg|Image BMP (*.bmp)|*.bmp"
    ' dlg.Filter = "PDF File (*.pdf)|*.pdf"
    'If dlg.ShowDialog() = DialogResult.OK Then Return New FileInfo(dlg.FileName) Else Return Nothing
    'Return New FileInfo(dlg.FileName)
    'End Using
    'End Function

    'den Bericht als EMF (Enhanced Metafile-Datei) exportieren
    Private Function Export() As Boolean
        Dim deviceInfo As String = "<DeviceInfo><OutputFormat>EMF</OutputFormat></DeviceInfo>"
        Dim Warnings As Warning() = Nothing
        myStreams = New List(Of Stream)()
        Try
            myReport.Render("Image", deviceInfo, AddressOf getStream, Warnings)
        Catch ex As MissingReportSourceException
            myResponse = String.Concat("Report-Error! : ", ex.Message)
        Catch ex As LocalProcessingException
            myResponse = String.Concat("Report-Error! : ", ex.InnerException)
        Catch ex As Exception 'sonstiger Fehler
            myResponse = String.Concat("Report-Error! : ", ex.Message)
        End Try
        If myStreams.Count = 0 Then ' Fehler beim Rendern des Berichtes
            SystemSounds.Hand.Play()
            Return False
        End If
        Dim Counter = 0
        For Each e In myStreams
            e.Position = 0
            If Not myFile Is Nothing Then saveReport(Counter, StreamToBytes(e)) : Counter += 1 ' Imageseiten werden gespeichert (.jpg, .bmp)
        Next
        Return True
    End Function

    Private Function StreamToBytes(myStream As Stream) As Byte()
        Using myStream
            Using ms As New MemoryStream()
                myStream.CopyTo(ms)
                Return ms.ToArray()
            End Using
        End Using
    End Function

    Private Sub saveReport(Optional Counter As Integer = 0, Optional Picture As Byte() = Nothing)
        Dim myPath = String.Empty
        If Counter = 0 AndAlso myExtensions.Item(myFileExtension) <> "Image" Then
            myPath = myFile.FullName
        Else
            myPath = String.Concat(myFile.DirectoryName, "\"c, String.Concat(myFile.Name.Replace(myFile.Extension, String.Empty), " (", Counter, ")"c, myFile.Extension))
        End If
        Using fs = New FileStream(myPath, FileMode.Create)
            Dim Bytes() As Byte = {}
            If Picture Is Nothing Then
                Try
                    Bytes = myReport.Render(myExtensions.Item(myFileExtension)) 'Format angeben
                Catch ex As MissingReportSourceException
                    myResponse = String.Concat("Report-Error! : ", ex.Message)
                Catch ex As LocalProcessingException
                    myResponse = String.Concat("Report-Error! : ", ex.InnerException.Message)
                Catch ex As Exception 'sonstiger Fehler
                    myResponse = String.Concat("Report-Error! : ", ex.Message)
                End Try
            Else
                Bytes = Picture
            End If
            If Bytes.Length = 0 Then ' Fehler beim Rendern des Berichtes
                SystemSounds.Hand.Play()
                fs.Close()
                IO.File.Delete(myPath) ' Datei der Länge 0 wieder löschen
            Else
                fs.Write(Bytes, 0, Bytes.Length)
                fs.Flush()
            End If
        End Using
    End Sub

    'Report Renderer bereitstellen, um für jede Seite des Berichtes ein Bild zu speichern
    Private Function getStream(Name As String, Ext As String, Enc As Encoding, Mime As String, Seek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        myStreams.Add(stream)
        Return stream
    End Function

    Private Sub printReport()
        If myStreams Is Nothing OrElse myStreams.Count = 0 Then
            SystemSounds.Hand.Play()
            myResponse = "Print-Error! : Es gibt nichts zu drucken..."
        End If
        Dim pDoc As New PrintDocument()
        Dim rps As ReportPageSettings = myReport.GetDefaultPageSettings() ' PageSettings übergeben
        pDoc.DefaultPageSettings.Landscape = rps.IsLandscape ' Längs- oder Querformat
        pDoc.DefaultPageSettings.PaperSize = rps.PaperSize ' A4-Format etc.
        pDoc.DefaultPageSettings.Margins = rps.Margins ' Ränder
        pDoc.PrintController = New StandardPrintController ' PopUp-Fenster beim Drucken unterdrücken
        If Not pDoc.PrinterSettings.IsValid Then
            SystemSounds.Hand.Play()
            myResponse = "Print-Error! : Der Standard-Drucker konnte nicht gefunden werden..."
        Else
            AddHandler pDoc.PrintPage, AddressOf printPage
            myCurrentPage = 0
            Try
                pDoc.Print()
            Catch ex As Exception
                SystemSounds.Hand.Play()
                myResponse = String.Concat("Print-Error! : ", ex.Message)
            End Try
        End If
    End Sub

    'Handler für PrintPageEvents
    Private Sub printPage(sender As Object, e As PrintPageEventArgs)
        Dim mf As New Metafile(myStreams(myCurrentPage))
        Dim Rect As New Rectangle(e.PageBounds.Left - CInt(e.PageSettings.HardMarginX), _
                                          e.PageBounds.Top - CInt(e.PageSettings.HardMarginY), _
                                          e.PageBounds.Width, _
                                          e.PageBounds.Height) 'rechteckigen Bereich mit Randeinstellungen einstellen
        e.Graphics.FillRectangle(Brushes.White, Rect) 'einen weißen Hintergrund für den Bericht zeichnen
        e.Graphics.DrawImage(mf, Rect) 'den Inhalt des Berichts zeichnen
        myCurrentPage += 1 'die nächste Seite vorbereiten und Berichtsende sicherstellen
        e.HasMorePages = (myCurrentPage < myStreams.Count)
    End Sub

    Public Function PrintIntoFile(Report As LocalReport, Directory As DirectoryInfo, Filename As String, Extension As String) As String

        'Dim myExtensions As New Dictionary(Of String, String) From {{"PDF", ".pdf"}, {"Excel", ".xls"}, {"Word", ".doc"}}
        ' Dim myExtensions As New Dictionary(Of String, String) From {{"PDF", ".pdf"}}
        Dim myFile As FileInfo
        Dim myResponse As String = "Ready..."
        Extension = CStr(".pdf")
        If Directory Is Nothing OrElse String.IsNullOrWhiteSpace(Filename) Then Return String.Concat("Argument-Error! : ", "invalid Directoy or Filename...")
        If Not myExtensions.ContainsKey(Extension) Then Return String.Concat("Argument-Error! : ", "invalid File-Extension...")
        ' myFile = New FileInfo(Path.Combine(Directory.Name, String.Concat(Filename, myExtensions.Item(Extension))))
        myFile = New FileInfo(Path.Combine(Directory.Name, String.Concat(Filename, Extension)))
        Report.Refresh()

        Try
            Using fs = New FileStream(myFile.FullName, FileMode.Create)
                Dim Bytes() As Byte = {}
                Bytes = Report.Render(Extension)
                If Bytes.Length > 0 Then
                    fs.Write(Bytes, 0, Bytes.Length)
                    fs.Flush()
                End If
            End Using
        Catch ex As MissingReportSourceException

            myResponse = String.Concat("Report-Error! : ", ex.Message)
            IO.File.Delete(myFile.FullName)
        Catch ex As LocalProcessingException
            myResponse = String.Concat("Report-Error! : ", ex.InnerException.Message)
            IO.File.Delete(myFile.FullName)
        Catch ex As IOException
            myResponse = String.Concat("IO-Error! : ", ex.Message)
        Catch ex As Exception 'sonstiger Fehler
            myResponse = String.Concat("Unknown-Error! : ", ex.Message)
        End Try
        Return myResponse
    End Function
End Class
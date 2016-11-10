Public Class Form1
    Dim Web As New System.Net.WebClient
    Dim EnteredSerial As String = ""
    Dim Serials As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkserial()
    End Sub

    Sub checkserial()
1:      EnteredSerial = InputBox("Bitte geben Sie hier Ihren Serial Key ein!", "Serialkey")
        If EnteredSerial = "" Then GoTo 1

        Serials = Web.DownloadString("https://github.com/DavHil/Serialkey-Abfrage/blob/master/Serialkey-Abfrage/Serialkey-Abfrage/Serials.txt")
        If Not Serials.Contains(EnteredSerial) Then
            MsgBox("Fehlgeschlagen")
            Application.Exit()
        Else
            MsgBox("Der Key war gültig")
        End If
    End Sub
End Class


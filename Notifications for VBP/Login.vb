Public Class Login
    Private WithEvents InvokeBrowser As New WebBrowser
    Private norem As Boolean = False
    Private loggingin As Boolean = False
    Public Property [Username] As String = ""
    Public Property [Password] As String = ""
    Sub New(ByVal Username As String, ByVal Password As String)
        Me.Username = Username
        Me.Password = Password
    End Sub
    Public Sub Refresh()
        norem = True
        InvokeBrowser.Navigate("https://www.vb-paradise.de/index.php/login")
    End Sub
    Private Function notLoggedIn() As Boolean
        Return Not InvokeBrowser.DocumentText.Contains("<p class=""error"">Der Zutritt zu dieser Seite ist Ihnen leider verwehrt. Sie besitzen nicht die notwendigen Zugriffsrechte, um diese Seite aufrufen zu können.</p>")
    End Function
    Private Sub InvokeBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles InvokeBrowser.DocumentCompleted
        If notLoggedIn() Then
            If norem Then
                InvokeBrowser.Document.GetElementById("username").SetAttribute("value", Me.Username)
                InvokeBrowser.Document.GetElementById("password").SetAttribute("value", Me.Password)
                InvokeBrowser.Document.Forms(1).InvokeMember("submit")
                loggingin = True
                norem = False
            ElseIf loggingin Then
                OnLoggingIn()
            End If
        Else
            MessageBox.Show("Sie sind bereits angemeldet")
        End If
    End Sub

    Private Sub OnLoggingIn()
        If InvokeBrowser.DocumentText.ToLower.Contains("<p class=""error"">Ihre Angaben sind ungültig. Bitte überprüfen Sie die markierten Eingabefelder.</p>".ToLower) Then
            MessageBox.Show("Angaben ungültig")
        Else
            MessageBox.Show("Angemeldet")
        End If
        loggingin = False
    End Sub
End Class

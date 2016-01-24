Public Class Form1
    Dim LastMessages As New List(Of VBPMessage)
    Dim Login1 As New Login("", "")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SystemInformation.WorkingArea.Width = Screen.PrimaryScreen.Bounds.Width Then
            If SystemInformation.WorkingArea.Y = 0 Then
                Me.Location = New Point(SystemInformation.WorkingArea.Width - Me.Width, SystemInformation.WorkingArea.Height - Me.Height)
            Else
                Me.Location = New Point(SystemInformation.WorkingArea.Width - Me.Width, SystemInformation.WorkingArea.Y)
            End If
        Else
            If SystemInformation.WorkingArea.X = 0 Then
                Me.Location = New Point(SystemInformation.WorkingArea.Width - Me.Width, SystemInformation.WorkingArea.Height - Me.Height)
            Else
                Me.Location = New Point(SystemInformation.WorkingArea.X, SystemInformation.WorkingArea.Height - Me.Height)
            End If
        End If
        WebBrowser1.Navigate("https://www.vb-paradise.de/index.php/NotificationList/")
        Timer1.Interval = My.Settings.Updateinterval * 60000
        NumericUpDown1.Value = My.Settings.Updateinterval
        Timer1.Start()
        Me.Focus()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        With e.Graphics
            Using P As New Pen(Color.FromArgb(52, 152, 219), 3)
                .DrawRectangle(P, New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
            End Using
        End With
    End Sub

    Private Sub MenuButton1_Click(sender As Object, e As EventArgs) Handles MenuButton1.Click
        If Panel3.Visible Then
            Panel3.Visible = False
        Else
            Panel3.Visible = True
            Panel3.BringToFront()
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.DocumentText.Contains("Anmelden oder registrieren") Then
            MessageBox.Show("Sie müssen sich zuerst anmelden")
        Else
            NfvbpBtn1.Quantity = CInt(WebBrowser1.Document.GetElementById("userNotifications").GetAttribute("data-count"))
            NfvbpBtn3.Quantity = CInt(WebBrowser1.Document.GetElementById("unreadConversations").GetAttribute("data-count"))
            Dim AllMessagas As New List(Of VBPMessage)
            For Each HTMLE1 As HtmlElement In WebBrowser1.Document.GetElementsByTagName("ul")
                If HTMLE1.GetAttribute("className") = "containerList" Then
                    For Each HTMLE2 As HtmlElement In HTMLE1.GetElementsByTagName("li")
                        If HTMLE2.GetAttribute("className") = "jsNotificationItem" Then
                            Dim VBPM As New VBPMessage
                            VBPM.ThreadLink = HTMLE2.GetAttribute("data-link")
                            For Each HTMLE3 As HtmlElement In HTMLE2.GetElementsByTagName("div")
                                For Each HTMLE4 As HtmlElement In HTMLE3.GetElementsByTagName("a")
                                    If HTMLE4.GetAttribute("className") = "userLink" Then
                                        Dim U As New VBPUser
                                        U.UserName = HTMLE4.InnerText
                                        U.ProfileLink = HTMLE4.GetAttribute("href")
                                        VBPM.User = U
                                    End If
                                Next
                                For Each HTMLE5 As HtmlElement In HTMLE3.GetElementsByTagName("time")
                                    If HTMLE5.GetAttribute("className") = "datetime" Then
                                        VBPM.Date = HTMLE5.InnerText
                                    End If
                                Next
                                For Each HTMLE6 As HtmlElement In HTMLE3.GetElementsByTagName("p")
                                    VBPM.Title = HTMLE6.InnerText
                                Next

                            Next
                            AllMessagas.Add(VBPM)
                        End If
                    Next
                End If
            Next
            Panel2.Controls.Clear()
            Dim Message As String = ""
            For Each M As VBPMessage In AllMessagas
                Dim NFVBPMessageControl1 As New NFVBPMessageControl With {.Message = M}
                Panel2.Controls.Add(NFVBPMessageControl1)
                NFVBPMessageControl1.Height = 70
                If LastMessages IsNot Nothing Then
                    Dim Contains As Boolean = False
                    For Each LastM In LastMessages
                        If LastM.ThreadLink = M.ThreadLink Then
                            Contains = True
                        End If
                    Next
                    If Contains = False Then
                        Message &= M.User.UserName & vbNewLine & M.Title & vbNewLine
                    End If
                End If
            Next
            LastMessages = AllMessagas
            If Message <> "" Then
                NotifyIcon1.ShowBalloonTip(10000, "Notifications for VBP", Message, ToolTipIcon.None)
            End If
        End If

    End Sub

    Private Sub NfvbpBtn1_Click(sender As Object, e As EventArgs) Handles NfvbpBtn1.Click
        Try
            Process.Start("https://www.vb-paradise.de/index.php/NotificationList/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NfvbpBtn3_Click(sender As Object, e As EventArgs) Handles NfvbpBtn3.Click
        Try
            Process.Start("https://www.vb-paradise.de/index.php/ConversationList/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        WebBrowser1.Navigate("https://www.vb-paradise.de/index.php/NotificationList/")
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If Timer1.Enabled = True Then
            My.Settings.Updateinterval = NumericUpDown1.Value
            My.Settings.Save()
            Timer1.Interval = My.Settings.Updateinterval * 60000
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Process.Start("https://www.vb-paradise.de/index.php/User/22536-KingTimon")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Process.Start("https://www.vb-paradise.de/index.php/User/18995-ManuelSoftware/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            Process.Start("https://www.vb-paradise.de")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NfvbpBtn5_Click(sender As Object, e As EventArgs) Handles NfvbpBtn5.Click
        End
    End Sub

    Private Sub NfvbpBtn4_Click(sender As Object, e As EventArgs) Handles NfvbpBtn4.Click
        Me.Hide()
    End Sub

    Private Sub NfvbpBtn2_Click(sender As Object, e As EventArgs) Handles NfvbpBtn2.Click
        WebBrowser1.Navigate("https://www.vb-paradise.de/index.php/NotificationList/")
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If Me.Visible = True Then
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            NotifyIcon1.ShowBalloonTip(10000, "Notifications for VBP", "Die Anwendung wurde in den Tray minimiert", ToolTipIcon.Info)
        Else
            Panel3.Visible = False
            Me.BringToFront()
        End If
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        If Me.Visible = True Then
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login1.Username = txt_username.Text
        Login1.Password = txt_pwd.Text
        Login1.Refresh()
    End Sub
End Class

Public Class VBPMessage
    Public Property [Title] As String = ""
    Public Property [User] As VBPUser = New VBPUser
    Public Property [Date] As String = ""
    Public Property [ThreadLink] As String = ""
End Class
Public Class VBPUser
    Public Property [UserName] As String = ""
    Public Property [ProfileLink] As String = ""
End Class
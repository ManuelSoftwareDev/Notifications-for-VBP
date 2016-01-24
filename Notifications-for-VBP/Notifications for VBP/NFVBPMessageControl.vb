Public Class NFVBPMessageControl
    Inherits Control
    Public Property [Message] As VBPMessage

    Sub New()
        Me.Height = 70
        Me.Dock = DockStyle.Top
        Me.BackColor = Color.FromArgb(52, 152, 219)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        With e.Graphics
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            Using SB As New SolidBrush(Me.BackColor)
                Using SF As New StringFormat
                    SF.LineAlignment = StringAlignment.Center
                    SF.Alignment = StringAlignment.Near
                    If IsHover Then
                        SB.Color = Color.FromArgb(41, 128, 185)
                    End If
                    .FillRectangle(SB, Me.ClientRectangle)
                    Using F As New Font("Segoe UI", 10, FontStyle.Bold)
                        SF.Alignment = StringAlignment.Near
                        .DrawString(Message.User.UserName, F, Brushes.White, New Rectangle(5, 5, Me.Width - 10, 15), SF)
                        SF.Alignment = StringAlignment.Far
                        .DrawString(Message.Date, F, Brushes.White, New Rectangle(5, 5, Me.Width - 10, 15), SF)
                    End Using
                    Using F As New Font("Segoe UI", 10)
                        SF.Alignment = StringAlignment.Near
                        .DrawString(Message.Title, F, Brushes.White, New Rectangle(5, 20, Me.Width - 10, Me.Height - 25), SF)
                    End Using
                End Using
            End Using
        End With
    End Sub
    Dim IsHover As Boolean = False
    Private Sub NFVBPMessageControl_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        IsHover = False
        Me.Invalidate()
    End Sub

    Private Sub NFVBPMessageControl_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If IsHover = False Then
            IsHover = True
            Me.Invalidate()
        End If
    End Sub

    Private Sub NFVBPMessageControl_Click(sender As Object, e As EventArgs) Handles Me.Click
        If Message IsNot Nothing Then
            Try
                Process.Start(Message.ThreadLink)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class

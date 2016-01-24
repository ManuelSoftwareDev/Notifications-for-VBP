Public Class MenuButton
    Inherits Control
    Sub New()
        Me.Dock = DockStyle.Right
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        With e.Graphics
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            Using SB As New SolidBrush(Me.BackColor)
                If IsHover Then
                    SB.Color = Color.FromArgb(41, 128, 185)
                End If
                .FillRectangle(SB, Me.ClientRectangle)
                .FillRectangle(Brushes.White, New Rectangle(10, 10, Me.Width - 20, 6))
                .FillRectangle(Brushes.White, New Rectangle(10, CInt(Me.Height / 2 - 3), Me.Width - 20, 6))
                .FillRectangle(Brushes.White, New Rectangle(10, Me.Height - 16, Me.Width - 20, 6))
            End Using
        End With
    End Sub

    Private Sub ToolbarItem_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        IsHover = False
        Me.Invalidate()
    End Sub

    Private Sub ToolbarItem_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If IsHover = False Then
            IsHover = True
            Me.Invalidate()
        End If
    End Sub

    Dim IsHover As Boolean = False
End Class

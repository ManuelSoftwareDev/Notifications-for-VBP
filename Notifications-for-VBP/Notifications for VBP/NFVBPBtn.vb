Public Class NFVBPBtn
    Inherits Control
    Public Property [Image] As Image = Nothing
    Dim QuantityValue As Integer = 0
    Dim CS As ClickState = 0
    Public Property [Quantity] As Integer
        Get
            Return QuantityValue
        End Get
        Set(value As Integer)
            QuantityValue = value
            Me.Invalidate()
        End Set
    End Property
    Sub New()
        Me.Size = New Size(80, 80)
        Me.BackColor = Color.FromArgb(52, 152, 219)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        With e.Graphics
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            Using SB As New SolidBrush(Me.Parent.BackColor)
                Using SF As New StringFormat
                    SF.LineAlignment = StringAlignment.Center
                    SF.Alignment = StringAlignment.Center
                    .FillRectangle(SB, -1, -1, Me.Width + 1, Me.Height + 1)
                    If CS = ClickState.Left Then
                        Using GP As New Drawing2D.GraphicsPath
                            GP.AddLine(0, 10, 0, Me.Height - 10)
                            GP.AddLine(Me.Width, Me.Height, Me.Width, 0)
                            GP.CloseFigure()
                            SB.Color = Color.FromArgb(41, 128, 185)
                            .FillPath(SB, GP)
                        End Using
                    ElseIf CS = ClickState.Right
                        Using GP As New Drawing2D.GraphicsPath
                            GP.AddLine(0, 0, 0, Me.Height)
                            GP.AddLine(Me.Width, Me.Height - 10, Me.Width, 10)
                            GP.CloseFigure()
                            SB.Color = Color.FromArgb(41, 128, 185)
                            .FillPath(SB, GP)
                        End Using
                    ElseIf IsHover
                        SB.Color = Color.FromArgb(41, 128, 185)
                        .FillRectangle(SB, Me.ClientRectangle)
                    Else
                        SB.Color = Color.FromArgb(52, 152, 219)
                        .FillRectangle(SB, Me.ClientRectangle)
                    End If
                    If Image IsNot Nothing Then
                        .DrawImage(Image, 20, 10, Me.Width - 40, Me.Height - 40)
                    Else
                        Using F As New Font("Segoe UI", 30)
                            .DrawString(QuantityValue.ToString, F, Brushes.White, New Rectangle(20, 10, Me.Width - 40, Me.Height - 40), SF)
                        End Using
                    End If
                    .DrawString(Me.Text, Me.Font, Brushes.White, New Rectangle(0, 50, Me.Width, 30), SF)
                End Using
            End Using
        End With
    End Sub
    Dim IsHover As Boolean = False
    Private Sub NFVBPBtn_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        IsHover = False
        Me.Invalidate()
    End Sub

    Private Sub NFVBPBtn_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If IsHover = False Then
            IsHover = True
            Me.Invalidate()
        End If
    End Sub

    Private Sub NFVBPBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.X < Me.Width / 2 Then
            CS = ClickState.Left
        Else
            CS = ClickState.Right
        End If
        Me.Invalidate()
    End Sub

    Private Sub NFVBPBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        CS = ClickState.None
        Me.Invalidate()
    End Sub

    Enum ClickState As Integer
        None = 0
        Left = 1
        Right = 2
    End Enum
End Class

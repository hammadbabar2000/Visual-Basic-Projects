Public Class Form1
    Private Sub Tmrpicboxleft_Tick(sender As Object, e As EventArgs) Handles Tmrpicboxlright1.Tick
        PictureBox1.Left = PictureBox1.Left - 10
        If PictureBox1.Right < 0 Then
            PictureBox1.Left = Me.Width
            PictureBox1.Top = Rnd(10) * Me.Height
        End If

    End Sub

    Private Sub tmrboxright2_Tick(sender As Object, e As EventArgs) Handles tmrboxleft2.Tick
        PictureBox2.Left = PictureBox2.Left - 10
        If PictureBox2.Right < 0 Then
            PictureBox2.Left = Me.Width
            PictureBox2.Top = Rnd(10) * Me.Height
        End If
    End Sub
    Private Sub tmrboxup_Tick(sender As Object, e As EventArgs) Handles tmrboxup.Tick
        PictureBox3.Top = PictureBox3.Top - 10
        If PictureBox3.Top < 0 Then
            PictureBox3.Top = Me.Width
            PictureBox3.Left = Rnd(10) * Me.Height
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                tmrleft.Enabled = True
            Case Keys.Right
                tmrright.Enabled = True
            Case Keys.Up
                tmrup.Enabled = True
            Case Keys.Down
                tmrdown.Enabled = True
        End Select

    End Sub

    Private Sub tmrleft_Tick(sender As Object, e As EventArgs) Handles tmrleft.Tick
        PictureBox4.Left = PictureBox4.Left - 10

    End Sub

    Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
        PictureBox4.Left = PictureBox4.Left + 10
    End Sub

    Private Sub tmrup_Tick(sender As Object, e As EventArgs) Handles tmrup.Tick
        PictureBox4.Top = PictureBox4.Top - 10
    End Sub

    Private Sub tmrdown_Tick(sender As Object, e As EventArgs) Handles tmrdown.Tick
        PictureBox4.Top = PictureBox4.Top + 10
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        tmrdown.Enabled = False
        tmrup.Enabled = False
        tmrleft.Enabled = False
        tmrright.Enabled = False
    End Sub
    Public Sub collision(a, b)
        If a.Left >= b.Left - a.Width And a.Left <= b.Left + b.Width Then
            If a.Top < b.Top + b.Height And a.Top > b.Top - a.Height Then
                End
            End If
        End If
    End Sub
    Public Sub collision2(c, d)
        If c.Left >= d.Left - c.Width And c.Left <= d.Left + d.Width Then
            If c.Top < d.Top + d.Height And c.Top > d.Top - c.Height Then
                End
            End If
        End If
    End Sub
    Public Sub collision3(e, f)
        If e.Left >= f.Left - e.Width And e.Left <= f.Left + f.Width Then
            If e.Top < f.Top + f.Height And e.Top > f.Top - e.Height Then
                End
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call collision(PictureBox4, PictureBox1)
        Call collision2(PictureBox4, PictureBox2)
        Call collision3(PictureBox4, PictureBox3)
    End Sub
End Class

Public Class Form1
    Dim ballSpeed As Double = 0
    Dim goUp As Boolean = False
    Dim goDown As Boolean = False
    Dim points As Integer = 0
    Dim playerSpeed As Double = 4
    Dim gameStart As Boolean = False
    Dim lives As Integer = 5
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim playerY = player.Location.Y
        If goUp = True AndAlso playerY - playerSpeed >= 0 Then
            player.Location = New Point(15, playerY - playerSpeed)
        End If
        If goDown = True AndAlso playerY + playerSpeed <= 260 Then
            player.Location = New Point(15, playerY + playerSpeed)
        End If
        Dim ballX = ball.Location.X
        Dim ballY = ball.Location.Y
        If player.Bounds.IntersectsWith(ball.Bounds) Then
            points += 1
            Label8.Text = "goal saved!"
            Label8.ForeColor = Color.Green
            Randomize()
            ball.Location = New Point(515, Rnd() * 335)
            Label9.Text = points
            Label9.ForeColor = Color.Green
        ElseIf ballX < 10 Then
            points -= 1
            lives -= 1
            liveshearts.Size = New Size(liveshearts.Size.Width - 13, 16)
            Label8.Text = "goal missed!"
            Label8.ForeColor = Color.Red
            Label9.Text = points
            Label9.ForeColor = Color.Red
            Randomize()
            ball.Location = New Point(515, Rnd() * 335)
        Else
            ball.Location = New Point(ballX - ballSpeed, ballY)
        End If
        If lives <= 0 Then
            Timer1.Stop()
            Label12.Visible = True
            Label14.Visible = True
            liveshearts.Visible = False
            Label10.Visible = True
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If gameStart = True Then
            If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
                goUp = True
            ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
                goDown = True
            End If
        End If
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If gameStart = True Then
            If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
                goUp = False
            ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.down Then
                goDown = False
            End If
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ballSpeed = 4
        playerSpeed = 3
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ballSpeed = 6
        playerSpeed = 5
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ballSpeed = 8
        playerSpeed = 6
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        ballSpeed = 10
        playerSpeed = 7
    End Sub
    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Green
    End Sub
    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.White
    End Sub
    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Orange
    End Sub
    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.White
    End Sub
    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.Red
    End Sub
    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.White
    End Sub
    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.Purple
    End Sub
    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.White
    End Sub
    Private Sub Label3_MouseClick(sender As Object, e As MouseEventArgs) Handles Label6.MouseClick, Label5.MouseClick, Label4.MouseClick, Label3.MouseClick
        points = 0
        w.Visible = False
        s.Visible = False
        gameStart = True
        Label2.Enabled = False
        Label3.Enabled = False
        Label4.Enabled = False
        Label5.Enabled = False
        Label6.Enabled = False
        Label11.Visible = True
        liveshearts.Visible = True
        Label13.Visible = True
    End Sub
    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Application.Restart()
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
    End Sub
End Class
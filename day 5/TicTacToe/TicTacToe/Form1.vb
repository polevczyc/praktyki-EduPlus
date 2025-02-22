Public Class Form1
    Dim playerNumber As Integer = -1
    Dim Win = False

    Private Sub CheckWin()
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            Button1.ForeColor = Color.Green
            Button2.ForeColor = Color.Green
            Button3.ForeColor = Color.Green
            Label100.Text = "Player1 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            Button4.ForeColor = Color.Green
            Button5.ForeColor = Color.Green
            Button6.ForeColor = Color.Green
            Label100.Text = "Player1 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            Button7.ForeColor = Color.Green
            Button8.ForeColor = Color.Green
            Button9.ForeColor = Color.Green
            Label100.Text = "Player1 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            Button1.ForeColor = Color.Green
            Button4.ForeColor = Color.Green
            Button7.ForeColor = Color.Green
            Label100.Text = "Player1 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            Button2.ForeColor = Color.Green
            Button5.ForeColor = Color.Green
            Button8.ForeColor = Color.Green
            Label100.Text = "Player1 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            Button3.ForeColor = Color.Green
            Button6.ForeColor = Color.Green
            Button9.ForeColor = Color.Green
            Label100.Text = "Player1 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button1.Text = "X" AndAlso Button5.Text = "X" AndAlso Button9.Text = "X" Then
            Button1.ForeColor = Color.Green
            Button5.ForeColor = Color.Green
            Button9.ForeColor = Color.Green
            Label100.Text = "Player1 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button3.Text = "X" AndAlso Button5.Text = "X" AndAlso Button7.Text = "X" Then
            Button3.ForeColor = Color.Green
            Button5.ForeColor = Color.Green
            Button7.ForeColor = Color.Green
            Label100.Text = "Player1 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button1.Text = "O" AndAlso Button2.Text = "O" AndAlso Button3.Text = "O" Then
            Button1.ForeColor = Color.Green
            Button2.ForeColor = Color.Green
            Button3.ForeColor = Color.Green
            Label100.Text = "Player2 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button4.Text = "O" AndAlso Button5.Text = "O" AndAlso Button6.Text = "O" Then
            Button4.ForeColor = Color.Green
            Button5.ForeColor = Color.Green
            Button6.ForeColor = Color.Green
            Label100.Text = "Player2 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button7.Text = "O" AndAlso Button8.Text = "O" AndAlso Button9.Text = "O" Then
            Button7.ForeColor = Color.Green
            Button8.ForeColor = Color.Green
            Button9.ForeColor = Color.Green
            Label100.Text = "Player2 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button1.Text = "O" AndAlso Button4.Text = "O" AndAlso Button7.Text = "O" Then
            Button1.ForeColor = Color.Green
            Button4.ForeColor = Color.Green
            Button7.ForeColor = Color.Green
            Label100.Text = "Player2 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button2.Text = "O" AndAlso Button5.Text = "O" AndAlso Button8.Text = "O" Then
            Button2.ForeColor = Color.Green
            Button5.ForeColor = Color.Green
            Button8.ForeColor = Color.Green
            Label100.Text = "Player2 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button3.Text = "O" AndAlso Button6.Text = "O" AndAlso Button9.Text = "O" Then
            Button3.ForeColor = Color.Green
            Button6.ForeColor = Color.Green
            Button9.ForeColor = Color.Green
            Label100.Text = "Player2 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button1.Text = "O" AndAlso Button5.Text = "O" AndAlso Button9.Text = "O" Then
            Button1.ForeColor = Color.Green
            Button5.ForeColor = Color.Green
            Button9.ForeColor = Color.Green
            Label100.Text = "Player2 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        ElseIf Button3.Text = "O" AndAlso Button5.Text = "O" AndAlso Button7.Text = "O" Then
            Button3.ForeColor = Color.Green
            Button5.ForeColor = Color.Green
            Button7.ForeColor = Color.Green
            Label100.Text = "Player2 wins!"
            Label100.ForeColor = Color.Green
            MsgBox("Game finished!")
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        playerNumber += 1
        If playerNumber Mod 2 = 0 Then
            sender.text = "X"
            Label100.Text = "Player2 move"
        Else
            sender.text = "O"
            Label100.Text = "Player1 move"
        End If
        CheckWin()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label100.Text = "Player1 move"
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
End Class

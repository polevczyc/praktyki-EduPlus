Public Class Form1

    Dim win = False

    Private Sub Form1_MouserEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Dim x = Int(800 * Rnd())
        Dim y = Int(600 * Rnd())

        If win = False Then
            MyBase.Location = New Point(x, y)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Hide()
        Label1.Visible = True
        win = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
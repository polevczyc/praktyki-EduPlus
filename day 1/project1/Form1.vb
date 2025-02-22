Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Hello World!"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.BackColor = Color.Green
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = TextBox1.Text
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Label8.Text = "You are a male."
        Else Label8.Text = "You are female."
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label10.Text = "My city - Gdynia - lies on the north of Poland."
        PictureBox1.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Yellow
        Button4.BackColor = Color.Brown
        Button5.BackColor = Color.Aqua
        TextBox1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Form2 = New Form()
        Form2.Show()
        Form2.Text = "Secon Form"
    End Sub

End Class

Public Class Form1

    Private Sub openButton_Click(sender As Object, e As EventArgs) Handles openButton.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            Using b As IO.StreamReader = IO.File.OpenText(OpenFileDialog1.FileName)
                TextBox2.Text = b.ReadToEnd
            End Using
        End If
    End Sub

    Private Sub saveButtonClick(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim writer As System.IO.StreamWriter
        writer = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\kubak\Desktop\" & TextBox3.Text & ".txt", True)
        writer.Write(TextBox4.Text)
        writer.Close()
        Label13.Visible = True
        If TextBox3.Text = "" Then
            Label13.Text = "File name can't be empty!"
        Else
            Label13.Text = "File saved on Desktop."
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numberOfFiles As Integer = Int(TextBox5.Text)
        For i As Integer = 1 To numberOfFiles
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\kubak\Desktop\" & "spam" & i & ".txt", True)
            file.WriteLine(TextBox6.Text)
            file.Close()
        Next
        If numberOfFiles = 1 Then
            Label11.Text = "Spamming successful. " & numberOfFiles & " file saved."
        ElseIf numberOfFiles = 0 Then
            Label11.Text = "Spamming unsuccessful. " & numberOfFiles & " files saved."
        Else
            Label11.Text = "Spamming successful. " & numberOfFiles & " files saved."
        End If
        Label11.Visible = True
        Button1.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox6.Text = "Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. Your PC is being spammed. "
        Else
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox4.Text = TextBox2.Text
        Else
            TextBox4.Text = ""
        End If
    End Sub

End Class

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub checkLetters()
        Dim a, c, e As String

        a = Label2.Text
        c = TextBox1.Text
        e = a.IndexOf(c.ToUpper) + 1

        If c = "" Then
            MessageBox.Show("Input cannot find")
        Else
            If e = "0" Then
                MessageBox.Show("Input cannot find")
            Else
                MessageBox.Show("First occurs in position " & a.IndexOf(c.ToUpper) + 1)
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click REM find position
        checkLetters()
    End Sub
End Class
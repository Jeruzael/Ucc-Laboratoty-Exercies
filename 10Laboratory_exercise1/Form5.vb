Public Class Form5
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Visible = False
        Timer1.Start()

        For i = 0 To 1000
            ProgressBar1.Value = i
            Label2.Text = 1 + i
        Next
        Timer1.Stop()
        If ProgressBar1.Value = 1000 Then

            Form4.Show()
            Me.Close()
        End If
    End Sub
End Class
Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub chkCode()
        Dim a, b, c, d, e As String
        a = TextBox1.Text

        REM MessageBox.Show(a.Chars(1))

        If TextBox1.Text = "" Then
            MessageBox.Show("Please input some code!")

        ElseIf a.Length > 4 Then
            MessageBox.Show("4 Characters only")

        Else
            b = a.Chars(0)
            c = a.Chars(1)
            d = a.Chars(2)
            e = a.Chars(3)

            Select Case b
                Case "P"
                    Label2.Text = "Part Time"
                Case "p"
                    Label2.Text = "Part Time"
                Case "F"
                    Label2.Text = "Fulltime"
                Case "f"
                    Label2.Text = "Fulltime"
                Case Else
                    MessageBox.Show("P OR F only")
            End Select


            Label3.Text = c.ToUpper() & d.ToUpper()

            Select Case e
                Case "1"
                    Label4.Text = "New Cars"
                Case "2"
                    Label4.Text = "Used Cars"
                Case Else
                    MessageBox.Show("1 or 2 ONLY")
            End Select
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chkCode()
    End Sub
End Class
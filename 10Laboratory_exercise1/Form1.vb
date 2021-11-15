Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub chkConn()
        Dim query As String
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;uid=root;password=asd098qwe9ijmjy6;database=student_record"

        Try
            conn.Open()
            MessageBox.Show("Connected")
            Form4.Show()
            Me.Hide()
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("connection Failed")
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click REM databse lab11 ex 2
        REM chkConn()
        Form4.Show()
        Me.Hide()
    End Sub
End Class

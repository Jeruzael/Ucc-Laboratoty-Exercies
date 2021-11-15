Imports MySql.Data.MySqlClient
Imports System.Data.DataTable

Public Class Form4
    Dim Conn As New MySqlConnection
    Dim Cmd As New MySqlCommand
    Dim dataAdapter As New MySqlDataAdapter

    Private Sub ConnectionTesting()
        Dim query As String
        Conn = New MySqlConnection
        Conn.ConnectionString = "server=localhost;uid=root;password=asd098qwe9ijmjy6;database=student_record"

        Try
            Conn.Open()
            MessageBox.Show("Connected successfully")
            Me.StudentfileTableAdapter.Fill(Me.Student_recordDataSet.studentfile)
            Conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("You are not connected to database server!")
        End Try
    End Sub

    Private Sub QueryBuilder(ByRef a As String)
        Dim query, b As String

        Conn = New MySqlConnection
        Conn.ConnectionString = "server=localhost;uid=root;password=asd098qwe9ijmjy6;database=student_record"
        query = a

        Try
            Conn.Open()
            Cmd = New MySqlCommand(query, Conn)
            b = Cmd.ExecuteNonQuery()
            MessageBox.Show(b)
            Conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & " contact Jeruzael dumale for assistance")
        End Try
    End Sub

    Private Sub ClearText()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub

    Private Sub addRec()
        QueryBuilder("INSERT INTO studentFile(studentname,address,contactPerson,phone,mobile) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')")
        ClearText()
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub delRec()
        QueryBuilder("DELETE FROM studentFile WHERE id=" & TextBox6.Text)
        ClearText()
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub editRec()
        QueryBuilder("UPDATE studentFile SET " & ComboBox1.Text & "='" & TextBox7.Text & "' WHERE id=" & TextBox8.Text)
        ClearText()
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub newDataset(ByRef b As String)
        Dim dataSet As New DataSet
        Dim query As String

        Conn = New MySqlConnection
        Conn.ConnectionString = "server=localhost;uid=root;password=asd098qwe9ijmjy6;database=student_record"
        query = "SELECT * FROM studentFile WHERE studentname LIKE '" & b & "%'"
        dataAdapter = New MySqlDataAdapter(query, Conn)

        Try
            Conn.Open()
            dataAdapter.Fill(dataSet, "StudentFile")
            DataGridView1.DataSource = dataSet.Tables(0)
            'MessageBox.Show("success")
            Conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & " contact Jeruzael dumale for assistance")
        End Try


    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub EToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_recordDataSet.studentfile' table. You can move, or remove it, as needed.
        'Me.StudentfileTableAdapter.Fill(Me.Student_recordDataSet.studentfile)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.StudentfileTableAdapter.FillBy(Me.Student_recordDataSet.studentfile)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click REM add btn
        addRec()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click REM delete btn
        Panel4.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click REM input id number
        delRec()
        Panel4.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click REM edit btn
        Panel6.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click REM change
        editRec()
        Panel6.Visible = False

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click REM Delete hide btn
        Panel4.Visible = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click REM edit hide btn
        Panel6.Visible = False
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged REM find name
        newDataset(TextBox9.Text)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)  REM test btn


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click REM update data
        ConnectionTesting()

    End Sub
End Class
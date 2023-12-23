Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Form2
    Dim connection As New SqlConnection("Server = KHEMARINT\SQLEXPRESS; Database = TestDB; Integrated Security = true")
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim cmd As New SqlCommand("SELECT * FROM UserLogin WHERE Username = @Username AND Password = @Password", connection)

        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

        connection.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            MessageBox.Show("Login successful!")
            ' Create an instance of Form1 and show it
            Dim form1 As New Form1()
            form1.Show()
            ' Hide the login form
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.")
        End If

        connection.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnGoRegister.Click
        Dim registerForm As New Form4

        registerForm.Show()
        Me.Hide()
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form4
    Dim connection As New SqlConnection("Server = KHEMARINT\SQLEXPRESS; Database = TestDB; Integrated Security = true")


    Private Sub btnGoLogin_Click(sender As Object, e As EventArgs) Handles btnGoLogin.Click
        Dim loginForm As New Form2

        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim usernamePattern As String = "^[a-zA-Z]+$"
        If Not Regex.IsMatch(txtUsername.Text, usernamePattern) Then
            MessageBox.Show("Invalid username. Please use only letters.")
            Return
        End If

        ' Validate the email
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@gmail\.com$"
        If Not Regex.IsMatch(txtEmail.Text, emailPattern) Then
            MessageBox.Show("Invalid email address.")
            Return
        End If

        ' Check if a gender has been selected
        If Not RdoMale.Checked And Not RdoFemale.Checked Then
            MessageBox.Show("Please select a gender.")
            Return
        End If

        ' Check if the username, password, and email fields are not empty
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtEmail.Text = "" Then
            MessageBox.Show("Please enter all required information.")
            Return
        End If
        Try
            ' Create a command to insert the user data into your database
            Dim command As New SqlCommand("INSERT INTO UserLogin ( Username, Password, UserEmail, Gender) VALUES (@Username, @Password, @UserEmail, @Gender)", connection)

            ' Add the user data as parameters to the command
            command.Parameters.AddWithValue("@Username", txtUsername.Text)
            command.Parameters.AddWithValue("@Password", txtPassword.Text)
            command.Parameters.AddWithValue("@UserEmail", txtEmail.Text)
            If RdoMale.Checked Then
                command.Parameters.AddWithValue("@Gender", "M")
            Else
                command.Parameters.AddWithValue("@Gender", "F")
            End If

            ' Open the connection and execute the command
            connection.Open()
            command.ExecuteNonQuery()

            ' Clear the form fields
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtEmail.Text = ""
            RdoMale.Checked = False
            RdoFemale.Checked = False

            MessageBox.Show("Registration successful!")
        Catch ex As Exception
            ' Show the exception message
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' Close the connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
End Class

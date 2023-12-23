Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class Form1

    Dim connection As New SqlConnection("Server = KHEMARINT\SQLEXPRESS; Database = TestDB; Integrated Security = true")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New SqlCommand("SELECT id, name, description, the_image FROM Table_Images;", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False


        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn

        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(3)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If

        If PictureBox1.Image IsNot Nothing Then
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        End If
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1.CurrentRow IsNot Nothing Then
            If Not IsDBNull(DataGridView1.CurrentRow.Cells(0).Value) Then
                TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
            Else
                TextBoxID.Text = ""
            End If

            If Not IsDBNull(DataGridView1.CurrentRow.Cells(1).Value) Then
                TextBoxName.Text = DataGridView1.CurrentRow.Cells(1).Value
            Else
                TextBoxName.Text = ""
            End If

            If Not IsDBNull(DataGridView1.CurrentRow.Cells(2).Value) Then
                TextBoxDesc.Text = DataGridView1.CurrentRow.Cells(2).Value
            Else
                TextBoxDesc.Text = ""
            End If

            If Not IsDBNull(DataGridView1.CurrentRow.Cells(3).Value) Then
                Dim img() As Byte
                img = DataGridView1.CurrentRow.Cells(3).Value
                Dim ms As New MemoryStream(img)
                PictureBox1.Image = Image.FromStream(ms)
            Else
                PictureBox1.Image = Nothing
            End If
        End If
    End Sub

    Public Sub ExecuteMyQuery(MyCommand As SqlCommand, MyMessage As String)
        connection.Open()

        If MyCommand.ExecuteNonQuery = 1 Then
            MessageBox.Show(MyMessage)
        Else
            MessageBox.Show("Query Not Executed")
        End If

        connection.Close()

    End Sub

    Public Sub RefreshData()
        Dim command As New SqlCommand("SELECT id, name, description, the_image FROM Table_Images;", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If String.IsNullOrEmpty(TextBoxName.Text) OrElse String.IsNullOrEmpty(TextBoxDesc.Text) Then
            MessageBox.Show("Name and Description fields cannot be empty.")
            Return
        End If

        Dim img() As Byte
        If Not IsNothing(PictureBox1.Image) Then
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            img = ms.ToArray()
        End If

        Dim insertQuery As String
        If Not IsNothing(img) Then
            insertQuery = "INSERT INTO Table_Images (name, description, the_image) VALUES (@name, @desc, @img)"
        Else
            insertQuery = "INSERT INTO Table_Images (name, description) VALUES (@name, @desc)"
        End If

        Dim command As New SqlCommand(insertQuery, connection)
        command.Parameters.AddWithValue("@name", TextBoxName.Text)
        command.Parameters.AddWithValue("@desc", TextBoxDesc.Text)
        If Not IsNothing(img) Then
            command.Parameters.Add("@img", SqlDbType.Image).Value = img
        End If

        ExecuteMyQuery(command, "Data Inserted")
        RefreshData()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim img() As Byte
            If Not IsNothing(PictureBox1.Image) Then
                Dim ms As New MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                img = ms.ToArray()
            End If

            Dim updateQuery As String
            If Not IsNothing(img) Then
                updateQuery = "UPDATE Table_Images SET name = @name, description = @desc, the_image = @img WHERE id = @id"
            Else
                updateQuery = "UPDATE Table_Images SET name = @name, description = @desc WHERE id = @id"
            End If

            Dim command As New SqlCommand(updateQuery, connection)
            command.Parameters.AddWithValue("@name", TextBoxName.Text)
            command.Parameters.AddWithValue("@desc", TextBoxDesc.Text)
            command.Parameters.AddWithValue("@id", TextBoxID.Text)
            If Not IsNothing(img) Then
                command.Parameters.Add("@img", SqlDbType.Image).Value = img
            End If

            ExecuteMyQuery(command, "Data Updated")
            RefreshData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not String.IsNullOrEmpty(TextBoxID.Text) AndAlso IsNumeric(TextBoxID.Text) Then
            Dim deleteQuery As String = "DELETE FROM Table_Images WHERE id = " & TextBoxID.Text
            Dim command As New SqlCommand(deleteQuery, connection)
            ExecuteMyQuery(command, "Image deleted")
            RefreshData()
        Else
            MessageBox.Show("Please select a valid record to delete.")
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim command As New SqlCommand("SELECT * FROM table_images WHERE id LIKE '%" & TextBoxSearch.Text & "%' OR name LIKE '%" & TextBoxSearch.Text & "%' OR description LIKE '%" & TextBoxSearch.Text & "%'", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim command As New SqlCommand("SELECT id, name, description, the_image FROM Table_Images WHERE id = @id", connection)
            command.Parameters.Add("@id", SqlDbType.Int).Value = TextBoxID.Text

            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then
                MessageBox.Show("No data found")
            Else
                TextBoxID.Text = table.Rows(0)(0).ToString()
                TextBoxName.Text = table.Rows(0)(1).ToString()
                TextBoxDesc.Text = table.Rows(0)(2).ToString()

                If Not IsDBNull(table.Rows(0)(3)) Then
                    Dim img() As Byte
                    img = table.Rows(0)(3)
                    Dim ms As New MemoryStream(img)
                    PictureBox1.Image = Image.FromStream(ms)
                Else
                    PictureBox1.Image = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBoxID.Text = ""
        TextBoxName.Text = ""
        TextBoxDesc.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Dim command As New SqlCommand("SELECT COUNT(*) FROM Table_Images", connection)
        connection.Open()
        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
        connection.Close()
        MessageBox.Show("Total Items: " & count)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Show the login form and close the main form
        Dim loginForm As New Form2
        loginForm.Show()
        Me.Close()
    End Sub
End Class

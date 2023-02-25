Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports Bunifu

Public Class ManageProduct
    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Hide()
        settings.Show()
    End Sub
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Dim Id As String = BunifuTextBox1.Text
        Dim name As String = BunifuTextBox2.Text
        Dim qty As String = BunifuTextBox3.Text
        Dim category As String = BunifuTextBox4.Text
        Dim price As String = BunifuTextBox5.Text
        Dim query As String = "INSERT INTO [dbo].[exterior] VALUES (@Id,@name,@quantity,@price,@category,@image)"
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Car_modif;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("connection timeout")
        End Try


        Try
            Dim image As Image = PictureBox1.Image
            Dim filesize As New UInt32
            Dim ms As New System.IO.MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim picture() As Byte = ms.GetBuffer
            filesize = ms.Length()
            ms.Close()
            If Id = Nothing Or name = Nothing Or qty = Nothing Or price = Nothing Or category = Nothing Then
                MessageBox.Show("Fill The Details")
            Else
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@quantity", qty)
                cmd.Parameters.AddWithValue("@category", category)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@image", picture)

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("sucess")
                Catch ex As Exception
                    MessageBox.Show("id already")
                End Try

                con.Close()
            End If

        Catch ex As NullReferenceException
            MessageBox.Show("fill details")
        End Try
    End Sub

    Private Sub BunifuButton27_Click(sender As Object, e As EventArgs) Handles BunifuButton27.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    '=================================================================Retrieve===============================================================================================
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Dim Id As String = BunifuTextBox1.Text
        Dim name As String = BunifuTextBox2.Text
        Dim qty As String = BunifuTextBox3.Text
        Dim price As String = BunifuTextBox5.Text
        Dim category As String = BunifuTextBox4.Text
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Car_modif;Integrated Security=True")

        Dim command As New SqlCommand("SELECT [Id],[name],[quantity],[price],[category],[image] FROM [dbo].[exterior] WHERE Id = @Id", con)

        command.Parameters.AddWithValue("@Id", Id)
        command.Parameters.AddWithValue("@name", name)
        command.Parameters.AddWithValue("@quantity", qty)
        command.Parameters.AddWithValue("@category", category)
        command.Parameters.AddWithValue("@price", price)
        Dim reader As SqlDataReader
        con.Open()
        reader = command.ExecuteReader
        If reader.Read() Then
            Dim data As Byte() = reader("Image")
            Dim ms As New MemoryStream(data)
            PictureBox1.Image = Image.FromStream(ms)
            BunifuTextBox2.Text = reader("name").ToString()
            BunifuTextBox3.Text = reader("quantity").ToString()
            BunifuTextBox5.Text = reader("price").ToString()
            BunifuTextBox4.Text = reader("category").ToString()

        Else
            MessageBox.Show("Id Invalid")

        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        '===================================================CLEARING_1=========================================================================
        BunifuTextBox1.Clear()
        BunifuTextBox2.Clear()
        BunifuTextBox3.Clear()
        BunifuTextBox4.Clear()
        BunifuTextBox5.Clear()
        PictureBox1.Image = Nothing
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click

        Try
            '=======================================================UPADTE_1===============================================================================
            Dim image As Image = PictureBox1.Image
            Dim filesize As New UInt32
            Dim ms As New System.IO.MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim picture() As Byte = ms.GetBuffer
            filesize = ms.Length()
            Dim Id As String = BunifuTextBox1.Text
            Dim name As String = BunifuTextBox2.Text
            Dim qty As String = BunifuTextBox3.Text
            Dim price As String = BunifuTextBox5.Text
            Dim category As String = BunifuTextBox4.Text
            Dim query As String = "UPDATE exterior SET name=@name,quantity=@quantity,price=@price,category=@category,image=@image WHERE Id=@Id"
            Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Car_modif;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand(query, con)

            If Id = Nothing Then
                MessageBox.Show("Enter Product Id ")
            Else
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@quantity", SqlDbType.VarChar).Value = qty
                cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = category
                cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = price
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id
                cmd.Parameters.Add("@image", SqlDbType.Image).Value = picture

                con.Open()

                If cmd.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("values updated")
                Else
                    MessageBox.Show("Not Updated")
                End If
                con.Close()
            End If

        Catch ex As NullReferenceException
            MessageBox.Show(" Enter ID and Image  ")
        End Try

    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Try
            '===============================================================DELETE_1=============================================================================
            Dim image As Image = PictureBox1.Image
            Dim filesize As New UInt32
            Dim ms As New System.IO.MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim picture() As Byte = ms.GetBuffer
            filesize = ms.Length()

            Dim Id As String = BunifuTextBox1.Text
            Dim name As String = BunifuTextBox2.Text
            Dim qty As String = BunifuTextBox3.Text
            Dim price As String = BunifuTextBox5.Text
            Dim category As String = BunifuTextBox4.Text
            Dim query As String = "DELETE FROM exterior WHERE Id=@Id"
            Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Car_modif;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand(query, con)
            con.Open()
            If Id = Nothing Then
                MessageBox.Show("Enter Product Id ")
            Else
                cmd.Parameters.Add("@image", SqlDbType.Image).Value = picture
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@quantity", SqlDbType.VarChar).Value = qty
                cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = category
                cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = price
                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Product Deleted")
                Catch ex As Exception
                    MessageBox.Show("Connection Timedout")
                End Try

            End If
        Catch ex As NullReferenceException
            MessageBox.Show(" Enter Product ID AND IMAGE ")
        End Try
        BunifuTextBox1.Clear()
        BunifuTextBox2.Clear()
        BunifuTextBox3.Clear()
        BunifuTextBox4.Clear()
        BunifuTextBox5.Clear()
        PictureBox1.Image = Nothing
    End Sub
End Class



Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class test1
    Public Sub New(pic As Image, name As String)
        InitializeComponent()
        PictureBox1.Image = pic
        BunifuLabel2.Text = name
        Dim price = BunifuLabel1.Text
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Car_modif;Integrated Security=True")
        Dim command As New SqlCommand("SELECT [price] FROM [dbo].[exterior] WHERE name = @name", con)
        command.Parameters.AddWithValue("@name", name)
        Dim reader As SqlDataReader
        con.Open()
        reader = command.ExecuteReader
        If reader.Read() Then
            BunifuLabel1.Text = reader("price").ToString()
        Else
            MessageBox.Show("incorrect")
        End If
    End Sub
End Class
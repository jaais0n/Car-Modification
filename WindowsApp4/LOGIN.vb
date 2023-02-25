Imports Bunifu
Imports System.Data
Imports System.Data.SqlClient

Public Class LOGIN
    Public Declare Auto Function HideCaret Lib "user32" (ByVal hwnd As IntPtr) As Boolean
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click

        Dim username As String = BunifuTextBox1.Text
        Dim password As String = BunifuTextBox2.Text
        Dim query As String = "SELECT * FROM REGISTRATION where username=@username and password=@password"


        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Car_modif;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = BunifuTextBox1.Text
        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = BunifuTextBox2.Text
        con.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader

        If BunifuTextBox1.Text = "admin" And BunifuTextBox2.Text = "admin" Then
            Me.Hide()
            MessageBox.Show("Admin Authenticated")
            ManageProduct.Show()
            Exit Sub
        End If
        If (reader.Read()) Then
            BunifuTextBox2.BorderColorIdle = Color.Lime
            BunifuTextBox1.BorderColorIdle = Color.Lime
            MessageBox.Show(" Login Successful ")
            Me.Hide()
            HOMEPAGE.Show()

        Else
            BunifuTextBox2.BorderColorIdle = Color.Red
            BunifuTextBox1.BorderColorIdle = Color.Red
            MessageBox.Show("Invalid Credentials")

        End If
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        REGISTER.Show()
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Hide()
        REGISTER.Show()
    End Sub

    Private Sub GunaSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaSwitch1.CheckedChanged
        If GunaSwitch1.Checked = True Then
            BunifuTextBox2.UseSystemPasswordChar = False
        Else
            BunifuTextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BunifuTextBox2_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox2.TextChanged
        If GunaSwitch1.Checked = True Then
            BunifuTextBox2.UseSystemPasswordChar = False
        Else
            BunifuTextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click

    End Sub

    Private Sub BunifuTextBox1_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox1.TextChanged

    End Sub
End Class
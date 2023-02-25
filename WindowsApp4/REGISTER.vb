Imports Bunifu
Imports System.Data
Imports System.Data.SqlClient

Public Class REGISTER

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim username As String = BunifuTextBox2.Text
        Dim password As String = BunifuTextBox1.Text
        Dim first_name As String = BunifuTextBox3.Text
        Dim last_name As String = BunifuTextBox4.Text
        Dim email As String = BunifuTextBox5.Text
        Dim phone_number As Integer = BunifuTextBox6.Text


        Dim query As String = "INSERT INTO REGISTRATION values (@first_name,@last_name,@email,@phone_number,@username,@password)"
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Car_modif;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        con.Open()
        If BunifuTextBox1.Text = "admin" And BunifuTextBox2.Text = "admin" Then
            BunifuTextBox2.BorderColorIdle = Color.Lime
            BunifuTextBox1.BorderColorIdle = Color.Lime
            HOMEPAGE.Show()
            Me.Hide()
            Exit Sub
        End If
        If BunifuTextBox1.Text = Nothing Or BunifuTextBox2.Text = Nothing Then
            BunifuTextBox1.BorderColorIdle = Color.Red
            BunifuTextBox2.BorderColorIdle = Color.Red

            MessageBox.Show("Fill Details")
            cmd.Parameters.Clear()
            con.Close()
        Else
            If BunifuTextBox1.Text = BunifuTextBox7.Text Then
                cmd.Parameters.AddWithValue("@first_name", first_name)
                cmd.Parameters.AddWithValue("@last_name", last_name)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@phone_number", phone_number)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Try
                    cmd.ExecuteNonQuery()
                    BunifuTextBox2.BorderColorIdle = Color.Lime
                    BunifuTextBox1.BorderColorIdle = Color.Lime
                    MessageBox.Show("Registration sucess")

                Catch ex As Exception
                    BunifuTextBox2.BorderColorIdle = Color.Red
                    MessageBox.Show(ex.Message)
                    con.Close()
                End Try
            Else
                MsgBox("Password does not match")
            End If
        End If



    End Sub
    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        Me.Hide()
        LOGIN.Show()
    End Sub
    Private Sub GunaControlBox2_Click(sender As Object, e As EventArgs) Handles GunaControlBox2.Click
        Application.Exit()
    End Sub

    Private Sub GunaSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaSwitch1.CheckedChanged
        If GunaSwitch1.Checked = True Then
            BunifuTextBox1.UseSystemPasswordChar = False
        Else
            BunifuTextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub GunaSwitch2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaSwitch2.CheckedChanged
        If GunaSwitch2.Checked = True Then
            BunifuTextBox7.UseSystemPasswordChar = False
        Else
            BunifuTextBox7.UseSystemPasswordChar = True
        End If
    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class HOMEPAGE
    Public Class CurvedButton
        Inherits Button


        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim gp As New Drawing2D.GraphicsPath
            gp.AddArc(0, 0, Height, Height, 90, 180)
            gp.AddLine(Height, 0, Width - Height, 0)
            gp.AddArc(Width - Height, 0, Height, Height, -90, 180)
            gp.AddLine(Width, Height, Width, Height)
            gp.AddLine(Width, Height, 0, Height)
            gp.CloseAllFigures()
            Me.Region = New Region(gp)
            MyBase.OnPaint(e)
        End Sub
    End Class
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.Visible = False
        EXTERIOR.PerformClick()
        Panel2.Hide()
    End Sub

    Private Sub Price_Click(sender As Object, e As EventArgs)
        Dim button = DirectCast(sender, Bunifu.UI.WinForms.BunifuButton.BunifuButton)
        Dim picBox = DirectCast(button.Parent, PictureBox)
        Dim pic = picBox.BackgroundImage
        Dim name = picBox.Controls.OfType(Of Label)().FirstOrDefault()?.Text

        Dim newForm As New test1(pic, name)
        newForm.Show()
    End Sub

    Private Sub GunaControlBox2_Click(sender As Object, e As EventArgs) Handles GunaControlBox2.Click
        Application.Exit()
    End Sub


    Private Sub EXTERIOR_Click(sender As Object, e As EventArgs) Handles EXTERIOR.Click
        FlowLayoutPanel1.Visible = True
        Dim user As String
        user = LOGIN.BunifuTextBox1.Text
        BunifuLabel1.Text = "Hi," & user

        Dim conn As New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Car_modif;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT [name], [image] FROM [dbo].[exterior] ", conn)
        Dim dr As SqlDataReader
        conn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            Dim len As Long = dr.GetBytes(1, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(1, 0, array, 0, CInt(len))
            Dim Pic = New PictureBox
            Pic.Size = New Size(330, 350)
            Pic.BackgroundImageLayout = ImageLayout.Stretch

            Dim la = New Label
            la.ForeColor = Color.Black
            la.BackColor = Color.Gray
            la.Dock = DockStyle.Bottom
            la.Font = New Font("bizmo", 13)
            la.TextAlign = ContentAlignment.MiddleCenter

            Dim price As New Bunifu.UI.WinForms.BunifuButton.BunifuButton

            price.TextAlign = ContentAlignment.MiddleCenter
            price.Dock = DockStyle.Bottom
            price.ForeColor = Color.White
            price.IdleFillColor = Color.Black
            price.IdleBorderColor = Color.Black
            price.BringToFront()
            price.onHoverState.FillColor = Color.Gray
            price.Font = New Font("galyon-bold", 20)
            price.Height = 50
            price.Text = "Buy Now"
            price.Margin = New Padding(10)


            AddHandler price.Click, AddressOf Price_Click


            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            Pic.BackgroundImage = bitmap
            la.Text = dr.Item("name").ToString
            Pic.Controls.Add(la)
            Pic.Controls.Add(price)
            Pic.Margin = New Padding(35, 20, 20, 20)

            FlowLayoutPanel1.Controls.Add(Pic)
        End While


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel2.Show()
    End Sub

    Private Sub BunifuTextBox1_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox1.TextChanged
        If BunifuTextBox1.Text = "" Then
            FlowLayoutPanel1.Controls.Clear()
            EXTERIOR.PerformClick()
        Else

            Dim conn As New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Car_modif;Integrated Security=True")
            Dim cmd As New SqlCommand("SELECT [name], [image] FROM [dbo].[exterior] where [name]=@name", conn)
            cmd.Parameters.AddWithValue("@name", BunifuTextBox1.Text)
            Dim dr As SqlDataReader
            conn.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                FlowLayoutPanel1.Controls.Clear()

                While dr.Read
                    Dim len As Long = dr.GetBytes(1, 0, Nothing, 0, 0)
                    Dim array(CInt(len)) As Byte
                    dr.GetBytes(1, 0, array, 0, CInt(len))
                    Dim Pic = New PictureBox
                    Pic.Size = New Size(330, 350)
                    Pic.BackgroundImageLayout = ImageLayout.Stretch

                    Dim la = New Label
                    la.ForeColor = Color.Black
                    la.BackColor = Color.Gray
                    la.Dock = DockStyle.Bottom
                    la.Font = New Font("bizmo", 13)
                    la.TextAlign = ContentAlignment.MiddleCenter

                    Dim price As New Bunifu.UI.WinForms.BunifuButton.BunifuButton

                    price.TextAlign = ContentAlignment.MiddleCenter
                    price.Dock = DockStyle.Bottom
                    price.ForeColor = Color.White
                    price.IdleFillColor = Color.Black
                    price.IdleBorderColor = Color.Black
                    price.BringToFront()
                    price.onHoverState.FillColor = Color.Gray
                    price.Font = New Font("galyon-bold", 20)
                    price.Height = 50
                    price.Text = "Buy Now"
                    price.Margin = New Padding(10)


                    AddHandler price.Click, AddressOf Price_Click


                    Dim ms As New System.IO.MemoryStream(array)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    Pic.BackgroundImage = bitmap
                    la.Text = dr.Item("name").ToString
                    Pic.Controls.Add(la)
                    Pic.Controls.Add(price)
                    Pic.Margin = New Padding(35, 20, 20, 20)

                    FlowLayoutPanel1.Controls.Add(Pic)
                End While
            End If
        End If
    End Sub
End Class
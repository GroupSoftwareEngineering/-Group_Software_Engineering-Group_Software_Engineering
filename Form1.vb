Public Class Form1
    Dim greyIcon As New System.Drawing.Bitmap(My.Resources.grey)
    Dim redIcon As New System.Drawing.Bitmap(My.Resources.red)
    Dim greenIcon As New System.Drawing.Bitmap(My.Resources.green)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = greyIcon

                AddHandler c.Click, AddressOf pictureBox7_Click

            End If
        Next

        Dim strSql As String
        strSql = "SELECT SeatID, SeatRow, IsBooked FROM dbo.Seat"
    End Sub

    Private Sub pictureBox7_Click(sender As Object, e As EventArgs) Handles pictureBox7.Click
        Static cout As Integer = 0
        If CType(sender, PictureBox).Image Is greyIcon Then
            CType(sender, PictureBox).Image = greenIcon
            cout += 1
            TextBox2.Text = cout.ToString("")
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            CType(sender, PictureBox).Image = greyIcon
            cout -= 1
            TextBox2.Text = cout.ToString("")
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Form2.Show()
    End Sub

End Class

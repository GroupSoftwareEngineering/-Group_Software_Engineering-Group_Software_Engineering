Imports WindowsApp1.Class1
Public Class Form2
    Dim greyIcon As New System.Drawing.Bitmap(My.Resources.grey)
    Dim redIcon As New System.Drawing.Bitmap(My.Resources.red)
    Dim greenIcon As New System.Drawing.Bitmap(My.Resources.green)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = greenIcon
            End If
        Next
    End Sub

    Private Sub pictureBox48_Click(sender As Object, e As EventArgs) Handles pictureBox7.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label7.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label7.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label7.Text
            SeatRow = label27.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub
    Private Sub pictureBox49_Click(sender As Object, e As EventArgs) Handles pictureBox49.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label6.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label6.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label6.Text
            SeatRow = label27.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub
    Private Sub pictureBox47_Click(sender As Object, e As EventArgs) Handles pictureBox47.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label8.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label8.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label8.Text
            SeatRow = label27.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub
    Private Sub pictureBox46_Click(sender As Object, e As EventArgs) Handles pictureBox46.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label9.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label9.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label9.Text
            SeatRow = label27.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub
    Private Sub pictureBox45_Click(sender As Object, e As EventArgs) Handles pictureBox45.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label10.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label10.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label10.Text
            SeatRow = label27.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox44_Click(sender As Object, e As EventArgs) Handles pictureBox44.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label11.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label11.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label11.Text
            SeatRow = label27.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox43_Click(sender As Object, e As EventArgs) Handles pictureBox43.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label12.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
        SeatID = label12.Text
            SeatRow = label27.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label12.Text
            SeatRow = label27.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub
    Private Sub pictureBox42_Click(sender As Object, e As EventArgs) Handles pictureBox42.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label6.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
        SeatID = label6.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label6.Text
            SeatRow = label28.Text
            IsBooked = "Booked"
            Edit.Show()
        End If

    End Sub

    Private Sub pictureBox41_Click(sender As Object, e As EventArgs) Handles pictureBox41.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label7.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label7.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label7.Text
            SeatRow = label28.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox40_Click(sender As Object, e As EventArgs) Handles pictureBox40.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label8.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label8.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label8.Text
            SeatRow = label28.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox39_Click(sender As Object, e As EventArgs) Handles pictureBox39.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label9.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label9.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label9.Text
            SeatRow = label28.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox38_Click(sender As Object, e As EventArgs) Handles pictureBox38.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label10.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label10.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label10.Text
            SeatRow = label28.Text
            IsBooked = "Booked"
            Edit.Show()
        End If

    End Sub

    Private Sub pictureBox37_Click(sender As Object, e As EventArgs) Handles pictureBox37.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label11.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label11.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label11.Text
            SeatRow = label28.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox36_Click(sender As Object, e As EventArgs) Handles pictureBox36.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label12.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label12.Text
            SeatRow = label28.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label12.Text
            SeatRow = label28.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Add.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Edit.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Delete.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        MsgBox("Save the proggress?")
    End Sub

    Private Sub pictureBox56_Click(sender As Object, e As EventArgs) Handles pictureBox56.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label19.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label19.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label19.Text
            SeatRow = label26.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox55_Click(sender As Object, e As EventArgs) Handles pictureBox55.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label18.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label18.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label18.Text
            SeatRow = label26.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox54_Click(sender As Object, e As EventArgs) Handles pictureBox54.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label17.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label17.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label17.Text
            SeatRow = label26.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox53_Click(sender As Object, e As EventArgs) Handles pictureBox53.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label16.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label16.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label16.Text
            SeatRow = label26.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox52_Click(sender As Object, e As EventArgs) Handles pictureBox52.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label15.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label15.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label15.Text
            SeatRow = label26.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox51_Click(sender As Object, e As EventArgs) Handles pictureBox51.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label14.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label14.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label14.Text
            SeatRow = label26.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox50_Click(sender As Object, e As EventArgs) Handles pictureBox50.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label13.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label13.Text
            SeatRow = label26.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label13.Text
            SeatRow = label26.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox63_Click(sender As Object, e As EventArgs) Handles pictureBox63.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label19.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label19.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label19.Text
            SeatRow = label25.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox62_Click(sender As Object, e As EventArgs) Handles pictureBox62.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label18.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label18.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label18.Text
            SeatRow = label25.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox61_Click(sender As Object, e As EventArgs) Handles pictureBox61.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label17.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label17.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label17.Text
            SeatRow = label25.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox60_Click(sender As Object, e As EventArgs) Handles pictureBox60.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label16.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label16.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label16.Text
            SeatRow = label25.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox59_Click(sender As Object, e As EventArgs) Handles pictureBox59.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label15.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label15.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label15.Text
            SeatRow = label25.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox58_Click(sender As Object, e As EventArgs) Handles pictureBox58.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label14.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label14.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label14.Text
            SeatRow = label25.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub

    Private Sub pictureBox57_Click(sender As Object, e As EventArgs) Handles pictureBox57.Click
        If CType(sender, PictureBox).Image Is greyIcon Then
            SeatID = label13.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Add.Show()
        ElseIf CType(sender, PictureBox).Image Is greenIcon Then
            SeatID = label13.Text
            SeatRow = label25.Text
            IsBooked = "available"
            Edit.Show()
        ElseIf CType(sender, PictureBox).Image Is redIcon Then
            SeatID = label13.Text
            SeatRow = label25.Text
            IsBooked = "Booked"
            Edit.Show()
        End If
    End Sub
End Class

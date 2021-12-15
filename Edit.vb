Imports WindowsApp1.Class1
Public Class Edit
    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBox1.Text = SeatID
        textBox2.Text = SeatRow
        textBox3.Text = IsBooked
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close the Progress", "Exit", MessageBoxButtons.YesNo)
        If dialog = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
Public Class Add
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close the Progress", "Exit", MessageBoxButtons.YesNo)
        If dialog = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

    End Sub
End Class
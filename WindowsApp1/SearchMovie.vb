Public Class SearchMovie
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtMovie.Text = "007" Or txtMovie.Text = "No Time To Die" Then
            Payment.Show()
            Me.Hide()

        Else
            btnOk.Visible = True
            lblNo.Visible = True
            btnSearch.Enabled = False
            txtMovie.Enabled = False

        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        lblNo.Visible = False
        btnOk.Visible = False
        btnSearch.Enabled = True
        txtMovie.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
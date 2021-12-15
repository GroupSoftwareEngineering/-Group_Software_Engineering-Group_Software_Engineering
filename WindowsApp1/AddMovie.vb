Imports System.Data.SqlClient
Public Class AddMovie
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmd As New SqlCommand
        db_connect()

        If (txtName.Text = "" Or txtID.Text = "" Or txtGenre.Text = "") Then
            MsgBox("Fill in all data")
        Else
            Try
                cmd = connection.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Insert into Movie values('" + txtID.Text + "','" + txtName.Text + "','" + txtGenre.Text + "')"
                cmd.ExecuteNonQuery()

                MsgBox("User Created...")

                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            Finally
                connection.Close()
            End Try
        End If
    End Sub

End Class
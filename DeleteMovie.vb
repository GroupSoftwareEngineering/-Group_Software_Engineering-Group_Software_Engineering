Imports System.Data.SqlClient
Public Class DeleteMovie
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim cmd As New SqlCommand
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        db_connect()
        cmd = connection.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Delete from Movie where MovieID='" + txtID.Text + "'"
        cmd.ExecuteNonQuery()

        MsgBox("User Deleted...")
        'formDatabase.LBOutput.Items.Add("Admin Delete 1 User Data..")
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Try
            db_connect()
            Dim query As String
            query = "select * from Movie where MovieID='" & txtID.Text & "'"
            cmd = New SqlCommand(query, connection)
            reader = cmd.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count += 1
            End While

            If count = 1 Then
                lblStatus.Text = "User Found..."
                lblConfirm.Text = "Click Here to Continue"
            Else
                lblStatus.Text = "User Not Found..." & vbCrLf & "Try With Other Keywords"
            End If
            connection.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub
End Class


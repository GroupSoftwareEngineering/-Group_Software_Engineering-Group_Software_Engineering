Imports System.Data.SqlClient
Public Class PayManagement
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim reader As SqlDataReader
        Dim cmd As New SqlCommand
        Try
            db_connect()
            Dim query As String
            query = "select * from Payment where PaymentID='" & txtID.Text & "'"
            cmd = New SqlCommand(query, connection)
            reader = cmd.ExecuteReader

            reader.Read()
            If reader.HasRows Then
                'GBData.Enabled = True
                'panelUser.Enabled = False
                lblDate.Text = reader("PaymentDate").ToString
                lblTime.Text = reader("PaymentTime").ToString
                lblTotal.Text = "Rp" + reader("PaymentTotal").ToString
                lblStatus.Text = reader("PaymentStatus").ToString
                If lblStatus.Text = 1 Then
                    lblStatus.Text = "Successful"
                Else
                    lblStatus.Text = "Unsuccessful"
                End If
            Else
                MsgBox("Invalid Username!")
                lblDate.Text = "None"
                lblTime.Text = "None"
                lblStatus.Text = "None"
                lblTotal.Text = "None"
            End If
            connection.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub
End Class
Imports System.Data.SqlClient
Public Class Form4
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If usernameExist(txtUsername.Text) Then
            Call db_connect()
            Dim idid = txtUsername.Text
            Dim command As String = "DELETE from Customer WHERE CustID = @uid"
            cmd = New SqlCommand(command, connection)

            cmd.Parameters.AddWithValue("@uid", idid)

            cmd.ExecuteNonQuery()
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                MsgBox("Operation Cancelled")

            Else
                txtUsername.Text = ""

            End If
        Else
            MessageBox.Show("There are no Username like the one you provide, Choose Another One", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Public Function usernameExist(ByVal username As String) As Boolean

        Call db_connect()
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter()
        Dim command As String = "SELECT * FROM Customer WHERE CustID = @username"
        cmd = New SqlCommand(command, connection)

        cmd.Parameters.AddWithValue("@username", txtUsername.Text)


        adapter.SelectCommand = cmd
        adapter.Fill(table)

        ' if the username exist return true
        If table.Rows.Count > 0 Then

            Return True

            ' if not return false  
        Else

            Return False

        End If

    End Function
End Class
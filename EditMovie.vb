Imports System.Data.SqlClient
Public Class EditMovie
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim reader As SqlDataReader
        Dim cmd As New SqlCommand
        Try
            db_connect()
            Dim query As String
            query = "select * from Movie where MovieID='" & txtID.Text & "'"
            cmd = New SqlCommand(query, connection)
            reader = cmd.ExecuteReader

            reader.Read()
            If reader.HasRows Then
                GBData.Enabled = True
                panelUser.Enabled = False
                lblID.Text = reader("MovieID").ToString
                txtName.Text = reader("MovieTitle").ToString
                txtGenre.Text = reader("MovieGenre").ToString
            Else
                MsgBox("Invalid Username!")
            End If
            connection.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        db_connect()
        Dim cmd As New SqlCommand

        If (txtName.Text = "" Or txtID.Text = "" Or txtGenre.Text = "") Then
            MsgBox("Fill in all data")
        Else
            panelUser.Enabled = True
            cmd = connection.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Update Movie Set [MovieTitle]= '" & txtName.Text & "', [MovieGenre]= '" & txtGenre.Text & "'where MovieID= '" & txtID.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Edit Data Successful!")
            'formDatabase.LBOutput.Items.Add("Admin Edit 1 User Data..")
            Me.Close()
        End If

    End Sub

End Class
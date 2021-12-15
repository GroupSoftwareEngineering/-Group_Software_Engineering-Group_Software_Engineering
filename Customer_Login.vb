Imports WindowsApp1.Class1
Imports System.Data.SqlClient
Public Class Customer_Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "" And txtPassword.Text = "") Then
            MsgBox("Fill in all data")
        ElseIf (txtUsername.Text = "") Then
            MsgBox("Fill in the username")
        ElseIf (txtPassword.Text = "") Then
            MsgBox("Fill in the password")
        Else
            Try
                Call db_connect()
                Dim command As String = "SELECT * FROM Customer WHERE CustID = @username and CustPassword = @password"
                cmd = New SqlCommand(command, connection)

                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                dataread = cmd.ExecuteReader
                If dataread.HasRows Then
                    Me.Hide()

                Else
                    dataread.Close()
                    MessageBox.Show("Login Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtUsername.Focus()
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Customer_Registration.Show()
    End Sub

    Private Sub Customer_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
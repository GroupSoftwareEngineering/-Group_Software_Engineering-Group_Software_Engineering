Imports System.Data.SqlClient
Public Class Edit_Customers
    Private Sub btnRegister_Click(sender As Object, e As EventArgs)
        If (txtUsername.Text = "" And txtName.Text = "" And txtEmail.Text = "" And txtPassowrd.Text = "" And txtPhone.Text = "") Then
            MsgBox("Input Can't be Empty")
        ElseIf (txtUsername.Text = "" Or txtName.Text = "" Or txtEmail.Text = "" Or txtPassowrd.Text = "" Or txtPhone.Text = "") Then
            MsgBox("Please Fill the Empty Field")
        ElseIf (txtUsername.Text <> "" And txtName.Text <> "" And txtEmail.Text <> "" And txtPassowrd.Text <> "" And txtPhone.Text <> "") Then
            If usernameExist(txtUsername.Text) Then

                Call db_connect()
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter()
                Dim command As String = "UPDATE Customer SET(CustID, CustName, CustPhone,CustEmail,CustPassword) VALUES (@usn, @name, @phone,@email,@pass)"
                cmd = New SqlCommand(command, connection)

                cmd.Parameters.AddWithValue("@usn", txtUsername.Text)
                cmd.Parameters.AddWithValue("@name", txtUsername.Text)
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@pass", txtPassowrd.Text)
            End If

            If cmd.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Registration Completed Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsername.Text = ""
                txtPhone.Text = ""
                txtEmail.Text = ""
                txtPassowrd.Text = ""
                txtName.Text = ""

                Customer_Login.Show()

            Else

                MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
            MessageBox.Show("There are no Username like the one you provide, Choose Another One", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        End If
    End Sub

    Public Function usernameExist(ByVal username As String) As Boolean

        Call db_connect()
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter()
        Dim command As String = "SELECT * FROM Customer WHERE CustName = @username"
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
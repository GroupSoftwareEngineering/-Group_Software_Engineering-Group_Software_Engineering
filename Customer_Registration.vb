Imports WindowsApp1.Class1
Imports System.Data.SqlClient
Public Class Customer_Registration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If (txtUsername.Text = "" And txtName.Text = "" And txtConfirmPassword.Text = "" And txtEmail.Text = "" And txtPassowrd.Text = "" And txtPhone.Text = "") Then
            MsgBox("Input Can't be Empty")
        ElseIf (txtUsername.Text = "" Or txtName.Text = "" Or txtConfirmPassword.Text = "" Or txtEmail.Text = "" Or txtPassowrd.Text = "" Or txtPhone.Text = "") Then
            MsgBox("Please Fill the Empty Field")
        ElseIf (txtUsername.Text <> "" And txtName.Text <> "" And txtConfirmPassword.Text <> "" And txtEmail.Text <> "" And txtPassowrd.Text <> "" And txtPhone.Text <> "") And (txtPassowrd.Text = txtConfirmPassword.Text) Then
            If usernameExist(txtUsername.Text) Then
                MessageBox.Show("This Username Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                Call db_connect()
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter()
                Dim command As String = "INSERT INTO Customer(CustID, CustName, CustPhone,CustEmail,CustPassword) VALUES (@usn,@name, @phone,@email,@pass)"
                cmd = New SqlCommand(command, connection)

                cmd.Parameters.AddWithValue("@usn", txtUsername.Text)
                cmd.Parameters.AddWithValue("@name", txtName.Text)
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
                txtConfirmPassword.Text = ""
                Customer_Login.Show()

            Else

                MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Customer_Login.Show()
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

    Private Sub Customer_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Imports System.Data.SqlClient
Public Class MovieManagement
    Private Sub MovieManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CIS_dbDataSet.Movie' table. You can move, or remove it, as needed.
        Me.MovieTableAdapter.Fill(Me.CIS_dbDataSet.Movie)

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddMovie.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditMovie.Show()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        DeleteMovie.Show()
    End Sub

    Public Sub disp_data()
        db_connect()
        Dim cmd As New SqlCommand
        cmd = connection.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Movie"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim adt As New SqlDataAdapter(cmd)
        adt.Fill(dt)
        DGVData.DataSource = dt
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        disp_data()

    End Sub

End Class
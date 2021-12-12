Imports System.Data.SqlClient
Module ModuleConnect
    Public connection As SqlConnection
    Sub db_connect()
        Try
            connection = New SqlConnection("Server=localhost;Database=CIS_db;Integrated Security=True;MultipleActiveResultSets=true")
            connection.Open()
        Catch ex As Exception
            MsgBox("Can't connect to database, " _
                   + "Please Check your Connection")
        End Try
    End Sub
End Module

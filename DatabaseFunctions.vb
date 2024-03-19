Imports MySql.Data.MySqlClient

Public Class DatabaseFunctions
    Inherits DatabaseConnection

    Public Overrides Function AuthenticateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"
        Dim count As Integer = 0

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            count = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        ' If count is greater than 0, username and password match
        Return count > 0
    End Function
End Class

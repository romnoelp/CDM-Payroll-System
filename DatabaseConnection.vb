Imports MySql.Data.MySqlClient

Public MustInherit Class DatabaseConnection
    Protected conn As MySqlConnection
    Protected connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="

    Public Sub New()
        conn = New MySqlConnection(connectionString)
    End Sub

    Public MustOverride Function AuthenticateUser(username As String, password As String) As Boolean
End Class
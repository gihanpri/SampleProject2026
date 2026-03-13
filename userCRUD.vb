Imports MySql.Data.MySqlClient

Module userCRUD
    Public Sub AddUser(username As String, password As String, role As String)
        Using conn As MySqlConnection = GetConnection()
            'conn.Open()
            Dim query As String = "INSERT INTO users (username,password,role) VALUES (@username,@password,@role)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@role", role)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetUserForLogin(username As String, password As String) As DataTable

        Dim table As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            'conn.Open()

            Dim query As String =
                "SELECT userID, username, role " &
                "FROM users " &
                "WHERE username = @username AND password = @password"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using

        Return table

    End Function

    Public Function LoadClients() As DataTable 'Returns a value thats why not sub, but function
        Dim table As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            'conn.Open()
            Dim query As String = "SELECT * FROM users"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using

        Return table
    End Function

    Public Sub DeleteUser(id As Integer)
        Using conn As MySqlConnection = GetConnection()
            'conn.Open()
            Dim query As String = "DELETE FROM users WHERE userID = @userID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateClient(id As Integer, uname As String, pwd As String, role As String)
        Using conn As MySqlConnection = GetConnection()
            'conn.Open()
            Dim query As String = "UPDATE users SET username = @username, password = @password, role = @role WHERE userID = @userID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", id)
                cmd.Parameters.AddWithValue("@username", uname)
                cmd.Parameters.AddWithValue("@password", pwd)
                cmd.Parameters.AddWithValue("@role", role)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module

Imports MySql.Data.MySqlClient
Module CustomerCRUD
    Public Sub AddCustomer1(cname As String, caddress As String, cage As Integer, cgender As String, ccontact As Integer, cemail As String)
        Using conn As MySqlConnection = GetConnection()
            'conn.Open()
            Dim query As String = "INSERT INTO customers (cname,caddress,cage,cgender,ccontact,cemail) VALUES (@cname,@caddress,@cage,@cgender,@ccontact,@cemail)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cname", cname)
                cmd.Parameters.AddWithValue("@caddress", caddress)
                cmd.Parameters.AddWithValue("@cage", cage)
                cmd.Parameters.AddWithValue("@cgender", cgender)
                cmd.Parameters.AddWithValue("@ccontact", ccontact)
                cmd.Parameters.AddWithValue("@cemail", cemail)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


End Module

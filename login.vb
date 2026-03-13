Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Create variables for input from the user
        Dim uname As String = txtUserName.Text.Trim()
        Dim pw As String = txtPassword.Text.Trim()

        'Check username or password is empty
        If uname = "" OrElse pw = "" Then
            MessageBox.Show("Please enter username and password.")
            Exit Sub
        End If

        Dim dt As DataTable = userCRUD.GetUserForLogin(uname, pw)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Invalid username or password.")
            Exit Sub
        End If

        'Get role
        Dim role As String = dt.Rows(0)("role").ToString().ToLower()

        MessageBox.Show("Login Successful. Welcome" + role)
        Me.Hide()

        Select Case role

            Case "admin"
                Dim f As New FrmAdmin()
                f.Show()

            Case "user"
                Dim f As New FrmUser()
                f.Show()

            Case Else
                MessageBox.Show("Unknown role.")
                Me.Show()
                Exit Sub

        End Select

    End Sub
End Class
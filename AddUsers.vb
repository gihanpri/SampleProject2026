Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class AddUsers
    Private clientsTable As DataTable   'global to this form
    Private UserID As Integer

    Private Sub AddUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Staff")
        cmbRole.Items.Add("User")

        LoadClientDataToGrid()

    End Sub

    Private Sub LoadClientDataToGrid()
        clientsTable = LoadClients()
        DataGridView1.DataSource = clientsTable 'here DataGridView1 should be in the form. Name it as you like, the default name is DataGridView1

        DataGridView1.Columns("userID").Visible = False
        DataGridView1.Columns("username").HeaderText = "User Name"
        DataGridView1.Columns("password").HeaderText = "Password"
        DataGridView1.Columns("role").HeaderText = "User Type"

        'Add Select button column if not already added
        If Not DataGridView1.Columns.Contains("btnSelect") Then

            Dim btn As New DataGridViewButtonColumn()
            btn.HeaderText = "Action"
            btn.Text = "Select"
            btn.UseColumnTextForButtonValue = True
            btn.Name = "btnSelect"

            DataGridView1.Columns.Add(btn)

        End If
    End Sub


    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        Dim uname As String = txtAddUserName.Text
        Dim password As String = txtAddPassword.Text
        Dim retypepass As String = txtRetypePass.Text
        Dim role As String = cmbRole.SelectedItem.ToString()


        If uname.Trim() = "" OrElse password.Trim() = "" OrElse retypepass.Trim() = "" Then
            MessageBox.Show("Please fill all the fields ")
            Exit Sub

        ElseIf role = "" Then
            MessageBox.Show("Please Select a role.")
            Exit Sub

        ElseIf password <> retypepass Then
            MessageBox.Show("Passwords do not match!")
            Exit Sub

        Else
            AddUser(uname, password, role)
            MessageBox.Show("Client Added Successfully!")

            txtAddUserName.Text = ""
            txtAddPassword.Text = ""
            txtRetypePass.Text = ""
            cmbRole.Text = ""
        End If

        LoadClientDataToGrid()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged, txtSearch.TextChanged

        If clientsTable Is Nothing Then Exit Sub

        Dim dv As New DataView(clientsTable)

        dv.RowFilter = $"username LIKE '%{txtSearch.Text}%'"

        DataGridView1.DataSource = dv

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Make sure a real row was clicked
        If e.RowIndex < 0 Then Exit Sub

        'Check if the Select button column was clicked
        If DataGridView1.Columns(e.ColumnIndex).Name = "btnSelect" Then

            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            UserID = row.Cells("userID").Value.ToString()
            txtAddUserName.Text = row.Cells("username").Value.ToString()
            txtAddPassword.Text = row.Cells("password").Value.ToString()
            txtRetypePass.Text = row.Cells("password").Value.ToString()
            cmbRole.Text = row.Cells("role").Value.ToString()

        End If

        btnAddUser.Enabled = False

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim uname As String = txtAddUserName.Text
        Dim password As String = txtAddPassword.Text
        Dim retypepass As String = txtRetypePass.Text
        Dim role As String = cmbRole.SelectedItem.ToString()


        If uname.Trim() = "" OrElse password.Trim() = "" OrElse retypepass.Trim() = "" Then
            MessageBox.Show("Please fill all the fields ")
            Exit Sub

        ElseIf role = "" Then
            MessageBox.Show("Please Select a role.")
            Exit Sub

        ElseIf password <> retypepass Then
            MessageBox.Show("Passwords do not match!")
            Exit Sub

        Else
            UpdateClient(UserID, uname, password, role)
            MessageBox.Show("Client Updated Successfully!")


            txtAddUserName.Text = ""
            txtAddPassword.Text = ""
            txtRetypePass.Text = ""
            cmbRole.Text = ""
        End If
        btnAddUser.Enabled = True

        LoadClientDataToGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim uname As String = txtAddUserName.Text
        Dim password As String = txtAddPassword.Text
        Dim retypepass As String = txtRetypePass.Text
        Dim role As String = cmbRole.SelectedItem.ToString()



        DeleteUser(UserID)
        MessageBox.Show("Client Deleted Successfully!")


        txtAddUserName.Text = ""
            txtAddPassword.Text = ""
            txtRetypePass.Text = ""
            cmbRole.Text = ""


        LoadClientDataToGrid()
    End Sub
End Class
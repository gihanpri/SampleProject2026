Public Class FrmAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New AddUsers()
        f.Show()
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientDataToGrid()
    End Sub

    Private Sub LoadClientDataToGrid()
        Dim clientsTable As DataTable = LoadClients()
        DataGridView1.DataSource = clientsTable 'here DataGridView1 should be in the form. Name it as you like, the default name is DataGridView1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to delete.")
            Exit Sub
        End If

        ' Get Primary Key ID (Integer)
        Dim id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("userID").Value)

        ' Confirm delete
        If MessageBox.Show("Are you sure you want to delete this record?",
                           "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then

            DeleteUser(id)

        End If
        LoadClientDataToGrid()
    End Sub
End Class
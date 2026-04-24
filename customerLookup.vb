Imports Microsoft.VisualBasic.ApplicationServices

Public Class customerLookup
    Private customerTable As DataTable   'global to this form
    Private orderfrm As New order
    Private Sub customerLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerDataToGrid()
    End Sub

    Private Sub LoadCustomerDataToGrid()
        customerTable = LoadCustomers()
        DataGridView1.DataSource = customerTable 'here DataGridView1 should be in the form. Name it as you like, the default name is DataGridView1

        DataGridView1.Columns("cid").Visible = False
        DataGridView1.Columns("cname").HeaderText = "Customer Name"
        DataGridView1.Columns("caddress").Visible = False
        DataGridView1.Columns("cage").Visible = False
        DataGridView1.Columns("cgender").Visible = False
        DataGridView1.Columns("ccontact").HeaderText = "Phone"
        DataGridView1.Columns("cemail").HeaderText = "Email"

        ''Add Select button column if not already added
        If Not DataGridView1.Columns.Contains("btnselect") Then

            Dim btn As New DataGridViewButtonColumn()
            btn.HeaderText = "action"
            btn.Text = "select"
            btn.UseColumnTextForButtonValue = True
            btn.Name = "btselect"

            DataGridView1.Columns.Add(btn)

        End If
    End Sub

    Private Sub txtCustomerSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerSearch.TextChanged
        If customerTable Is Nothing Then Exit Sub

        Dim dv As New DataView(customerTable)

        dv.RowFilter = $"cname LIKE '%{txtCustomerSearch.Text}%'"

        DataGridView1.DataSource = dv
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Make sure a real row was clicked
        If e.RowIndex < 0 Then Exit Sub

        'Check if the Select button column was clicked
        'If DataGridView1.Columns(e.ColumnIndex).Name = "btSelect" Then

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        orderfrm.CustomerID = row.Cells("cid").Value
        'MessageBox.Show(row.Cells("cid").Value)
        orderfrm.CustomerName = row.Cells("cname").Value.ToString()

        orderfrm.updateCustomer()
        Me.Close()

        'End If
    End Sub
End Class
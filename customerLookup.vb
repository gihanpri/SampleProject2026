Public Class customerLookup
    Private customerTable As DataTable   'global to this form
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
        'If Not DataGridView1.Columns.Contains("btnSelect") Then

        '    Dim btn As New DataGridViewButtonColumn()
        '    btn.HeaderText = "Action"
        '    btn.Text = "Select"
        '    btn.UseColumnTextForButtonValue = True
        '    btn.Name = "btnSelect"

        '    DataGridView1.Columns.Add(btn)

        'End If
    End Sub
End Class
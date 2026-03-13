Public Class FrmCustomerCRUD
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim cname As String = txtCname.Text
        Dim caddress As String = txtAddress.Text
        Dim cage As Integer = Val(txtAge.Text)
        Dim cgender As String = cmbCgender.Text
        Dim ccontact As Integer = Val(txtCcontact.Text)
        Dim cemail As String = txtCemail.Text


        If cname.Trim() = "" OrElse caddress.Trim() = "" OrElse cemail.Trim() = "" Then
            MessageBox.Show("Please fill all the fields ")
            Exit Sub

        Else
            AddCustomer1(cname, caddress, cage, cgender, ccontact, cemail)
            MessageBox.Show("Customer Added Successfully!")

            txtCname.Clear()
            txtAddress.Clear()
            txtAge.Clear()
            cmbCgender.Items.Clear()
            txtCcontact.Clear()
            txtCemail.Clear()

        End If
    End Sub
End Class
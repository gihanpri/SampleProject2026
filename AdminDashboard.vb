Public Class AdminDashboard
    Private Sub btnAdminUserManagement_Click(sender As Object, e As EventArgs) Handles btnAdminUserManagement.Click
        Dim userManagement As New AddUsers()
        userManagement.Show()
    End Sub

    Private Sub btnAdminCusMgt_Click(sender As Object, e As EventArgs) Handles btnAdminCusMgt.Click
        Dim customerManagement As New FrmCustomerCRUD()
        customerManagement.Show()
    End Sub

    Private Sub btnAdminOrder_Click(sender As Object, e As EventArgs) Handles btnAdminOrder.Click
        Dim NewOrder As New order()
        NewOrder.Show()
    End Sub
End Class
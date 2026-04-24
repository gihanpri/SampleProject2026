Public Class order
    Public Property CustomerID As Integer
    Public Property CustomerName As String

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AddCustomer As New customerLookup()
        AddCustomer.Show()
    End Sub

    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub updateCustomer()

        lblCusID.Text = CustomerID
        MessageBox.Show(CustomerID)
        txtOrderCustomer.Text = CustomerName
        MessageBox.Show(CustomerName)

    End Sub
End Class
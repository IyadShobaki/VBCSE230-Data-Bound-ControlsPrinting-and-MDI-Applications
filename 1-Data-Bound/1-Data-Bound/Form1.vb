Public Class Form1
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsNorthwind)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNorthwind.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.DsNorthwind.Orders)
        'TODO: This line of code loads data into the 'DsNorthwind.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.DsNorthwind.Orders)
        'TODO: This line of code loads data into the 'DsNorthwind.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.DsNorthwind.Customers)

        TextBox1.DataBindings.Add("Text", CustomersBindingSource, "Companyname")


        Dim bsCustomers As New BindingSource(DsNorthwind, "Customers")
        DataGridView1.DataSource = bsCustomers


        DataGridView2.DataSource = DsNorthwind
        DataGridView2.DataMember = "Customers"
    End Sub
End Class

Public Class Form1
    Private bsProducts As BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductsTableAdapter1.Fill(DsNorthwind1.Products)
        bsProducts = New BindingSource(DsNorthwind1, "Products")
        txtProductID.DataBindings.Add("Text", bsProducts, "ProductID")
        txtProductName.DataBindings.Add("Text", bsProducts, "Productname")

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        bsProducts.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        bsProducts.MoveNext()

    End Sub
End Class

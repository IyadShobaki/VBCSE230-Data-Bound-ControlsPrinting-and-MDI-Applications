Public Class Form1
    Private Sub btnBind_Click(sender As Object, e As EventArgs) Handles btnBind.Click
        ProductsTableAdapter1.Fill(DsNorthwind1.Products)
        Dim bsProducts As New BindingSource(DsNorthwind1, "Products")
        DataGridView1.DataSource = bsProducts

        BindingNavigator1.BindingSource = bsProducts
    End Sub

    Private Sub btnGetValue_Click(sender As Object, e As EventArgs) Handles btnGetValue.Click
        Dim currentcellvalue As String
        currentcellvalue = DataGridView1.CurrentCell.Value.ToString()
        MessageBox.Show(currentcellvalue)

    End Sub

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        e.Graphics.FillRectangle(Brushes.Bisque, e.CellBounds)
        If Not (e.Value Is Nothing) Then
            e.Graphics.DrawString(e.Value.ToString, e.CellStyle.Font, Brushes.Red, e.CellBounds.X, e.CellBounds.Y)
        End If
        e.Handled = True
    End Sub
End Class

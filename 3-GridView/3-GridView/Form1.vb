Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim productNameColumn As New DataGridViewTextBoxColumn
        productNameColumn.Name = "Productname"
        productNameColumn.HeaderText = "Product name"
        productNameColumn.ValueType = System.Type.GetType("System.string")
        DataGridView1.Columns.Add(productNameColumn)

    End Sub

    Private Sub btnAddCol_Click(sender As Object, e As EventArgs) Handles btnAddCol.Click
        DataGridView1.Columns.Add("ProdDesc", "Product Description")
        DataGridView1.Columns(2).Width = 300
    End Sub

    Private Sub btnRemoveCol_Click(sender As Object, e As EventArgs) Handles btnRemoveCol.Click
        DataGridView1.Columns.Remove("ProductID")
    End Sub

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click
        Dim item As New DataGridViewRow
        item.CreateCells(DataGridView1)
        With item
            .Cells(0).Value = TextBox1.Text
            .Cells(1).Value = TextBox2.Text
            .Cells(2).Value = TextBox3.Text
        End With
        DataGridView1.Rows.Add(item)
        Label1.Text = DataGridView1.Rows.Count
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        DataGridView1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        DataGridView1.Rows(0).ReadOnly = True
        DataGridView1.Columns(0).ReadOnly = True

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        DataGridView1.Columns(2).Visible = False

    End Sub

    Private Sub btnAddButtons_Click(sender As Object, e As EventArgs) Handles btnAddButtons.Click
        Dim columnButton As New DataGridViewButtonColumn
        columnButton.Text = "Edit"
        columnButton.HeaderText = "Edit"
        columnButton.UseColumnTextForButtonValue = True

        columnButton.FlatStyle = FlatStyle.Popup
        columnButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        columnButton.DefaultCellStyle.ForeColor = Color.Maroon
        columnButton.Width = 40
        DataGridView1.Columns.Add(columnButton)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "Edit" Then
            MsgBox("Button : " & e.RowIndex & " Cilcked!")
        End If
        'Dim CellStyle As New DataGridViewCellStyle()
        'CellStyle.BackColor = Color.Red
        'DataGridView1.RowsDefaultCellStyle = CellStyle
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Red
        '    If e.RowIndex > -1 Then
        '        DataGridView1.Rows(e.RowIndex).Selected = True
        '    End If
        'Next
        For Each row As DataGridViewRow In DataGridView1.Rows
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Red

        Next
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Yellow

        'Next
    End Sub
End Class

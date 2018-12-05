<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddCol = New System.Windows.Forms.Button()
        Me.btnRemoveCol = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnAddRow = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.btnAddButtons = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(941, 302)
        Me.DataGridView1.TabIndex = 0
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "ProductID"
        Me.ProductID.Name = "ProductID"
        '
        'btnAddCol
        '
        Me.btnAddCol.Location = New System.Drawing.Point(12, 320)
        Me.btnAddCol.Name = "btnAddCol"
        Me.btnAddCol.Size = New System.Drawing.Size(165, 55)
        Me.btnAddCol.TabIndex = 1
        Me.btnAddCol.Text = "Add Column"
        Me.btnAddCol.UseVisualStyleBackColor = True
        '
        'btnRemoveCol
        '
        Me.btnRemoveCol.Location = New System.Drawing.Point(12, 383)
        Me.btnRemoveCol.Name = "btnRemoveCol"
        Me.btnRemoveCol.Size = New System.Drawing.Size(166, 55)
        Me.btnRemoveCol.TabIndex = 2
        Me.btnRemoveCol.Text = "Remove Column"
        Me.btnRemoveCol.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(232, 336)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 22)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(422, 336)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(172, 22)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(600, 336)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(172, 22)
        Me.TextBox3.TabIndex = 5
        '
        'btnAddRow
        '
        Me.btnAddRow.Location = New System.Drawing.Point(232, 364)
        Me.btnAddRow.Name = "btnAddRow"
        Me.btnAddRow.Size = New System.Drawing.Size(127, 43)
        Me.btnAddRow.TabIndex = 6
        Me.btnAddRow.Text = "Add Row"
        Me.btnAddRow.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(365, 364)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(128, 43)
        Me.btnSort.TabIndex = 7
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(632, 364)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(128, 43)
        Me.btnHide.TabIndex = 9
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnLock
        '
        Me.btnLock.Location = New System.Drawing.Point(499, 364)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(127, 43)
        Me.btnLock.TabIndex = 8
        Me.btnLock.Text = "Lock"
        Me.btnLock.UseVisualStyleBackColor = True
        '
        'btnAddButtons
        '
        Me.btnAddButtons.Location = New System.Drawing.Point(806, 326)
        Me.btnAddButtons.Name = "btnAddButtons"
        Me.btnAddButtons.Size = New System.Drawing.Size(128, 43)
        Me.btnAddButtons.TabIndex = 10
        Me.btnAddButtons.Text = "Add Buttons"
        Me.btnAddButtons.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(709, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 464)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddButtons)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnLock)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnAddRow)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnRemoveCol)
        Me.Controls.Add(Me.btnAddCol)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents btnAddCol As Button
    Friend WithEvents btnRemoveCol As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnAddRow As Button
    Friend WithEvents btnSort As Button
    Friend WithEvents btnHide As Button
    Friend WithEvents btnLock As Button
    Friend WithEvents btnAddButtons As Button
    Friend WithEvents Label1 As Label
End Class


Public Class viewplan_adf
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Dim setprod As New setplan_ADF
        setprod.lineLocation = "ADF"
        setprod.dateplan = Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd")
        setprod.shiftplan = If(Guna2RadioButton1.Checked = True, 1, 0)

        setprod.ShowDialog()
        setprod.BringToFront()
    End Sub

    Private Sub viewplan_scanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DateTimePicker1.Value = Date.Now
        Dim columnExists As Boolean = False
        For Each column As DataGridViewColumn In datagrid1.Columns
            If column.Name = "ActionImage" Then
                columnExists = True
                Exit For
            End If
        Next
        If Not columnExists Then
            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.Name = "ActionImage"
            imgColumn.HeaderText = "Action"
            imgColumn.Image = My.Resources.editBtn ' Replace with your actual resource

            datagrid1.Columns.Insert(0, imgColumn) ' Insert at the first column
            datagrid1.Columns(0).Width = 50
        End If
    End Sub


    Public Sub reloadplan()
        reload("SELECT id, location,line,partcode,plan,duration AS 'Duration(Hrs)',cycletime 
            FROM prod_plan 
            WHERE datein='" & Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' 
            AND shift='" & If(Guna2RadioButton1.Checked = True, 1, 0) & "' 
            AND location ='ADF'", datagrid1)

        ' Ensure ActionImage column is present after reload
        If Not datagrid1.Columns.Contains("ActionImage") Then
            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.Name = "ActionImage"
            imgColumn.HeaderText = "Action"
            imgColumn.Image = My.Resources.editBtn
            datagrid1.Columns.Insert(0, imgColumn)
            datagrid1.Columns(0).Width = 50
        End If

        ' Hide/Show column based on date
        If Guna2DateTimePicker1.Value < Date.Now.Date Then
            datagrid1.Columns("ActionImage").Visible = False
        Else
            datagrid1.Columns("ActionImage").Visible = True
        End If
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged, Guna2RadioButton1.CheckedChanged, Guna2RadioButton2.CheckedChanged
        reloadplan()
    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick
        ' Prevent errors if user clicks header or outside valid cells
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        ' Check if ActionImage column is clicked
        If datagrid1.Columns(e.ColumnIndex).Name = "ActionImage" Then
            ' Example: Get ID or any value from the selected row
            Dim id As String = datagrid1.Rows(e.RowIndex).Cells("id").Value.ToString()


            Dim editplan As New edit_plan
            editplan.loadset(id, "ADF")
            editplan.ShowDialog()
            editplan.BringToFront()
        End If
    End Sub
End Class
Public Class viewplan_scanner
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Dim setprod As New setplan
        setprod.lineLocation = "SCANNER"
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
        reload("SELECT id, location,line,partcode,plan,duration AS 'Duration(Hrs)',cycletime FROM prod_plan WHERE datein='" & Guna2DateTimePicker1.Value.ToString("yyy-MM-dd") & "' AND shift='" & If(Guna2RadioButton1.Checked = True, 1, 0) & "' AND location ='SCANNER'", datagrid1)
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged, Guna2RadioButton1.CheckedChanged, Guna2RadioButton2.CheckedChanged
        reloadplan()
    End Sub
End Class
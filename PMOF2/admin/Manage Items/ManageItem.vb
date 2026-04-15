Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class ManageItem

    Sub loaddata()

        '✅ Prevent null SelectedItem
        If Guna2ComboBox1.SelectedItem Is Nothing Then
            datagrid1.DataSource = Nothing
            Exit Sub
        End If

        Dim location As String = Guna2ComboBox1.SelectedItem.ToString()
        Dim search As String = If(txtSearch.Text, "").Trim()

        Dim query As String = "SELECT id, partcode, partname, model, modelcode, remarks, qty AS SPQ 
                          FROM assy_masterlist 
                          WHERE location = @location 
                          AND (partcode LIKE @search OR partname LIKE @search) 
                          ORDER BY id DESC"

        Using conn As New MySqlConnection(dbConnection.ConnectionString)
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@location", location)
                cmd.Parameters.AddWithValue("@search", "%" & search & "%")

                Dim dt As New DataTable()
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                datagrid1.DataSource = dt
            End Using
            conn.Close()
        End Using

        ' Hide ID safely
        If datagrid1.Columns.Contains("id") Then
            datagrid1.Columns("id").Visible = False
        End If

        ' Add Edit column if not exists
        If Not datagrid1.Columns.Contains("Edit") Then
            Dim editButton As New DataGridViewImageColumn()
            editButton.Name = "Edit"
            editButton.HeaderText = ""
            editButton.Image = My.Resources.editBtn
            editButton.Width = 30
            datagrid1.Columns.Add(editButton)
        End If

        ' Add Delete column if not exists
        If Not datagrid1.Columns.Contains("Delete") Then
            Dim deleteButton As New DataGridViewImageColumn()
            deleteButton.Name = "Delete"
            deleteButton.HeaderText = ""
            deleteButton.Image = My.Resources.trash
            deleteButton.Width = 30
            datagrid1.Columns.Add(deleteButton)
        End If

        ' ✅ Force them to always be last
        datagrid1.Columns("Edit").DisplayIndex = datagrid1.Columns.Count - 2
        datagrid1.Columns("Delete").DisplayIndex = datagrid1.Columns.Count - 1

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        loaddata()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loaddata()
    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        'Prevent error when clicking header
        If e.RowIndex < 0 Then Exit Sub

        'IF DELETE BUTTON CLICKED
        If datagrid1.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim id As String = datagrid1.Rows(e.RowIndex).Cells("id").Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                DeleteItem(id)
                loaddata()

            End If

            Exit Sub
        End If
    End Sub


    Private Shared Sub DeleteItem(id As String)
        If String.IsNullOrEmpty(id) Then
            MessageBox.Show("Invalid record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim deleteQuery As String = "DELETE FROM assy_masterlist WHERE id=@id"

        Using conn As New MySqlConnection(dbConnection.ConnectionString)
            conn.Open()

            Using cmd As New MySqlCommand(deleteQuery, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using

        MessageBox.Show("Record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        AddItem.ShowDialog()
        AddItem.BringToFront()
    End Sub

    Private Sub ManageItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
End Class
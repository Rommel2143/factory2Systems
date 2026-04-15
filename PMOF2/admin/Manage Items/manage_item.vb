Imports MySql.Data.MySqlClient
Public Class manage_item
    Dim selectedpart As String
    Private Sub manage_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Sub loaddata()
        reload("SELECT id, `partcode` , `partname`, `model`,modelcode,qty AS 'SPQ' FROM `assy_masterlist` ORDER BY id DESC", datagrid1)
        datagrid1.Columns("id").Visible = False
        'Add delete column
        If Not datagrid1.Columns.Contains("Delete") Then
            Dim deleteButton As New DataGridViewImageColumn()
            deleteButton.Name = "Delete"
            deleteButton.HeaderText = ""
            deleteButton.Image = My.Resources.trash
            datagrid1.Columns.Add(deleteButton)
        End If
    End Sub
    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_plan.TextChanged


    End Sub

    Private Sub txt_plan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_plan.KeyPress, txt_boxitem.KeyPress
        ' Allow only numbers and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Block the input
        End If

    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_partcode.Text = "" OrElse txt_partname.Text = "" OrElse txt_model.Text = "" OrElse txt_modelcode.Text = "" OrElse txt_plan.Text = "" OrElse txt_boxitem.Text = "" OrElse cmb_located.SelectedIndex = -1 Then
                MessageBox.Show("Please fill all fields.")
                Exit Sub
            End If

            Dim query As String = "INSERT INTO `assy_masterlist`(`partcode`, `partname`, `model`, `modelcode`, `planset`, `qty`,location) VALUES ('" & txt_partcode.Text & "','" & txt_partname.Text & "','" & txt_model.Text & "','" & txt_modelcode.Text & "','" & txt_plan.Text & "','" & txt_boxitem.Text & "','" & cmb_located.Text & "')"
            con.Close()
            con.Open()

            Dim insert As New MySqlCommand(query, con)
            insert.ExecuteNonQuery()

            loaddata()
            Show_Error("Partcode Saved!", 0)
            clear()

        Catch ex As Exception
            Show_Error(ex.Message, 0)
        End Try
    End Sub

    Private Sub clear()
        txt_partcode.Text = ""
        txt_partname.Text = ""
        txt_model.Text = ""
        txt_modelcode.Text = ""
        txt_plan.Text = ""
        txt_boxitem.Text = ""
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick


    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            Dim query As String = "UPDATE `assy_masterlist` " &
                              "SET partcode=@partcode,`partname` = @partname, `model` = @model, `modelcode` = @modelcode, `planset` = @planset, `cycleset` = 0, `qty` = @qty " &
                              "WHERE `partcode` = '" & selectedpart & "'"

            con.Close()
            con.Open()

            Dim updateCmd As New MySqlCommand(query, con)
            With updateCmd.Parameters
                .AddWithValue("@partcode", txt_partcode.Text)
                .AddWithValue("@partname", txt_partname.Text)
                .AddWithValue("@model", txt_model.Text)
                .AddWithValue("@modelcode", txt_modelcode.Text)
                .AddWithValue("@planset", txt_plan.Text)
                .AddWithValue("@qty", txt_boxitem.Text)
            End With

            Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                show_error("Partcode Updated!", 0)
            Else
                show_error("No record found with the given Partcode!", 1)
            End If
            clear()
        Catch ex As Exception
            show_error(ex.Message, 0)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick

        'Prevent error when clicking header
        If e.RowIndex < 0 Then Exit Sub

        'IF DELETE BUTTON CLICKED
        If datagrid1.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim partcode As String = datagrid1.Rows(e.RowIndex).Cells("partcode").Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                Dim deleteQuery As String = "DELETE FROM assy_masterlist WHERE partcode=@partcode"

                con.Close()
                con.Open()

                Dim cmd As New MySqlCommand(deleteQuery, con)
                cmd.Parameters.AddWithValue("@partcode", partcode)
                cmd.ExecuteNonQuery()

                con.Close()

                MessageBox.Show("Record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Reload your datagrid
                loaddata() ' <-- your reload method here

            End If

            Exit Sub
        End If


        'NORMAL ROW CLICK (FOR EDIT / VIEW)
        Dim query As String = "SELECT * FROM assy_masterlist WHERE partcode = @partcode"

        con.Close()
        con.Open()

        Dim selectpart As New MySqlCommand(query, con)
        selectpart.Parameters.AddWithValue("@partcode",
        datagrid1.Rows(e.RowIndex).Cells("partcode").Value.ToString())

        dr = selectpart.ExecuteReader

        If dr.Read = True Then
            selectedpart = dr.GetString("partcode")
            txt_partcode.Text = dr.GetString("partcode")
            txt_partname.Text = dr.GetString("partname")
            txt_model.Text = dr.GetString("model")
            txt_modelcode.Text = dr.GetString("modelcode")
            txt_plan.Text = dr.GetInt32("planset")
            txt_boxitem.Text = dr.GetInt32("qty")
            btn_update.Enabled = True
        End If

        dr.Close()
        con.Close()

    End Sub
End Class
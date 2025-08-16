Imports MySql.Data.MySqlClient
Public Class manage_item
    Dim selectedpart As String
    Private Sub manage_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT `partcode` , `partname`, `model`,qty AS 'SPQ' FROM `assy_masterlist`", datagrid1)
    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_plan.TextChanged


    End Sub

    Private Sub txt_plan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_plan.KeyPress, txt_boxitem.KeyPress, txt_cycletime.KeyPress
        ' Allow only numbers and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Block the input
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try


            Dim query As String = "INSERT INTO `assy_masterlist`(`partcode`, `partname`, `model`, `modelcode`, `planset`, `cycleset`, `qty`) VALUES ('" & txt_partcode.Text & "','" & txt_partname.Text & "','" & txt_model.Text & "','" & txt_modelcode.Text & "','" & txt_plan.Text & "','" & txt_cycletime.Text & "','" & txt_boxitem.Text & "')"
            con.Close()
            con.Open()

            Dim insert As New MySqlCommand(query, con)
            insert.ExecuteNonQuery()
            Me.Close()
            show_error("Partcode Saved!", 0)
        Catch ex As Exception
            show_error(ex.Message, 0)
        End Try
    End Sub



    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick


    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            Dim query As String = "UPDATE `assy_masterlist` " &
                              "SET partcode=@partcode,`partname` = @partname, `model` = @model, `modelcode` = @modelcode, `planset` = @planset, `cycleset` = @cycleset, `qty` = @qty " &
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
                .AddWithValue("@cycleset", txt_cycletime.Text)
                .AddWithValue("@qty", txt_boxitem.Text)
            End With

            Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                show_error("Partcode Updated!", 0)
            Else
                show_error("No record found with the given Partcode!", 1)
            End If

        Catch ex As Exception
            show_error(ex.Message, 0)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        Dim query As String = "SELECT * FROM assy_masterlist WHERE partcode ='" & datagrid1.Rows(e.RowIndex).Cells("partcode").Value.ToString() & "'"
        con.Close()
        con.Open()
        Dim selectpart As New MySqlCommand(query, con)
        dr = selectpart.ExecuteReader
        If dr.Read = True Then
            selectedpart = datagrid1.Rows(e.RowIndex).Cells("partcode").Value.ToString()
            txt_partcode.Text = dr.GetString("partcode")
            txt_partname.Text = dr.GetString("partname")
            txt_model.Text = dr.GetString("model")
            txt_modelcode.Text = dr.GetString("modelcode")
            txt_plan.Text = dr.GetInt32("planset")
            txt_cycletime.Text = dr.GetInt32("cycleset")
            txt_boxitem.Text = dr.GetInt32("qty")
            btn_update.Enabled = True
        End If

    End Sub
End Class
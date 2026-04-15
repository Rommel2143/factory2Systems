Imports MySql.Data.MySqlClient
Public Class AddItem
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not ValidateInput() Then Exit Sub

        Dim Item As New Item With {
            .PartCode = txt_partcode.Text.Trim(),
            .PartName = txt_partname.Text.Trim(),
            .Model = txt_model.Text.Trim(),
            .ModelCode = txt_modelcode.Text.Trim(),
            .PlanSet = numPlan.Value,
            .Qty = numSPQ.Value,
            .Location = cmb_located.Text.Trim()
        }

        CreateItem(Item)


    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txt_partcode.Text) Then
            MessageBox.Show("Part Code is required.")
            txt_partcode.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txt_partname.Text) Then
            MessageBox.Show("Part Name is required.")
            txt_partname.Focus()
            Return False
        End If

        If numPlan.Value <= 0 Then
            MessageBox.Show("Plan Set must be greater than 0.")
            numPlan.Focus()
            Return False
        End If

        If numSPQ.Value <= 0 Then
            MessageBox.Show("Quantity must be greater than 0.")
            numSPQ.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(cmb_located.Text) Then
            MessageBox.Show("Location is required.")
            cmb_located.Focus()
            Return False
        End If

        Return True
    End Function
    Sub CreateItem(Item As Item)
        Try
            Using conn As New MySqlConnection(dbConnection.ConnectionString)
                con.Open()
                Dim query As String = "INSERT INTO `assy_masterlist`(`partcode`, `partname`, `model`, `modelcode`, `planset`, `qty`,location) VALUES 
            ('" & Item.PartCode & "','" & Item.PartName & "','" & Item.Model & "','" & Item.ModelCode & "','" & Item.PlanSet & "','" & Item.Qty & "','" & Item.Location & "')"
                Dim insert As New MySqlCommand(query, con)
                insert.ExecuteNonQuery()
                MessageBox.Show("Partcode Saved!")
                con.Close()
                Me.Close()
            End Using
        Catch ex As Exception
            Show_Error(ex.Message, 0)
        End Try
    End Sub


End Class
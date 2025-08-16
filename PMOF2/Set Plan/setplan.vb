Imports MySql.Data.MySqlClient
Public Class setplan
    Public lineLocation As String
    Public dateplan As String
    Public shiftplan As Boolean
    Private Sub cmb_partcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_partcode.SelectedIndexChanged
        Dim query As String = "SELECT * FROM assy_masterlist WHERE CONCAT(partcode,' | ', partname)= '" & cmb_partcode.Text & "'"
        con.Close()
        con.Open()

        Using cmd As New MySqlCommand(query, con)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                lbl_model.Text = dr("model")
                lbl_plan.Text = dr("planset")
                lbl_spq.Text = dr("qty")
                lbl_code.Text = dr("modelcode")
            End If
        End Using
    End Sub

    Private Sub cmb_partcode_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_partcode.MouseClick
        cmb_display("SELECT CONCAT(partcode,' | ', partname) FROM `assy_masterlist` GROUP BY partcode", cmb_partcode)
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click

    End Sub

    Private Sub setplan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_display("SELECT line FROM prod_PCline GROUP BY line", cmb_line)
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Try



            If cmb_partcode.Text = "" OrElse cmb_line.Text = "" OrElse txt_plan.Text = "" OrElse txt_hour.Text = "" Then
                MessageBox.Show("Please Input Required Fields.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            '        Dim queryduplicate As String = "SELECT id FROM prod_plan 
            'WHERE location=@location 
            'AND line=@line 
            'AND partcode=@partcode 
            'AND datein=@datein 
            'AND shift=@shift"

            '        Using cmd As New MySqlCommand(queryduplicate, con)
            '            cmd.Parameters.AddWithValue("@location", lineLocation)
            '            cmd.Parameters.AddWithValue("@line", cmb_line.Text)
            '            cmd.Parameters.AddWithValue("@partcode", cmb_partcode.Text.Split("|"c)(0).Trim)
            '            cmd.Parameters.AddWithValue("@datein", dateplan)
            '            cmd.Parameters.AddWithValue("@shift", shiftplan)
            '            con.Close()
            '            con.Open()
            '            dr = cmd.ExecuteReader()
            '            If dr.HasRows Then
            '                MessageBox.Show("You already set plan for this partcode.", "Duplicate")
            '                Exit Sub
            '            End If
            '        End Using




            Dim query As String =
        "INSERT INTO `prod_plan`(`id`, `location`, `line`, `partcode`, `plan`, `duration`, `cycletime`, `datein`, `shift`, `target_output`,user) " &
        "VALUES (NULL,'" & lineLocation & "','" & cmb_line.Text & "','" & cmb_partcode.Text.Split("|"c)(0).Trim & "'," & txt_plan.Text & "," & txt_hour.Text & "," & lbl_cycle.Text & ",'" & dateplan & "'," & shiftplan & ",0,'" & user_IDNumber & "')"
            Using cmd As New MySqlCommand(query, con)
                con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                viewplan_scanner.reloadplan()
                Me.Close()

            End Using

        Catch ex As Exception
            Show_Error(ex.Message)
        End Try
    End Sub

    Private Sub txt_hour_TextChanged(sender As Object, e As EventArgs) Handles txt_hour.TextChanged, txt_plan.TextChanged
        If txt_plan.Text = "" OrElse txt_hour.Text = "" Then
        Else
            lbl_cycle.Text = ((Convert.ToDecimal(txt_hour.Text) * 3600) / Convert.ToDecimal(txt_plan.Text)).ToString("N0")
        End If
    End Sub

    Private Sub txt_hour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_hour.KeyPress
        AllowInput(sender, e, HandleInputs.InputType.Decimals)
    End Sub

    Private Sub txt_plan_TextChanged(sender As Object, e As EventArgs) Handles txt_plan.TextChanged

    End Sub

    Private Sub txt_plan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_plan.KeyPress
        AllowInput(sender, e, HandleInputs.InputType.Digits)
    End Sub
End Class
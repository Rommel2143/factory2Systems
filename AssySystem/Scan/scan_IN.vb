Imports MySql.Data.MySqlClient
Public Class scan_IN
    Dim targetTimer As Integer = 0
    Private Sub cmb_partcode_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub scan_IN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
        lbl_line.Text = user_PClocation.ToUpper & "-LINE " & user_PCline.ToUpper
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim setPart As New set_partcode
        setPart.lineLocation = lbl_line.Text
        setPart.dateplan = dtpicker1.Value.ToString("yyyy-MM-dd")
        setPart.shiftplan = If(Guna2RadioButton1.Checked = True, 1, 0)
        setPart.ShowDialog()
        setPart.BringToFront()
    End Sub


    Public Sub loadItem(itemId As Integer)
        Dim query As String = "SELECT pp.id, pp.location, pp.line, pp.partcode, pp.plan, pp.duration, 
                              pp.cycletime, pp.datein, pp.shift, pp.user,pp.target_output, am.partname,am.model,am.modelcode,am.qty
                       FROM prod_plan pp
                       JOIN assy_masterlist am ON am.partcode = pp.partcode
                       WHERE pp.id=@id"

        Using cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@id", itemId)

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()

                    lbl_partcode.Text = dr("partcode").ToString
                    lbl_partname.Text = dr("partname").ToString
                    lbl_model.Text = dr("model").ToString
                    lbl_modelcode.Text = dr("modelcode").ToString
                    lbl_hours.Text = dr("duration").ToString & " hours"
                    lbl_cycleplan.Text = dr("cycletime").ToString & " sec."
                    lbl_plan.Text = dr("plan").ToString & " pcs."
                    lbl_output.Text = dr("target_output").ToString

                    targetTimer = dr("cycletime").ToString
                    lbl_spq.Text = dr("qty").ToString & " pcs/box"
                    lbl_targettime.Text = targetTimer

                    panel_scan.Enabled = True
                End While
            End Using
            con.Close()
        End Using

    End Sub
End Class
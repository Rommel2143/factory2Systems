Imports MySql.Data.MySqlClient
Public Class scan_IN
    Dim qctimer As Integer = 0
    Dim targetcycletime As Integer = 0
    Dim countdowntimer As Integer = 0
    Public setID As Integer
    Dim SPQ As Integer
    Private Sub cmb_partcode_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub scan_IN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
        lbl_line.Text = user_PClocation.ToUpper & "-LINE " & user_PCline.ToUpper
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_select.Click
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
                    targetcycletime = dr.GetInt32("cycletime")
                    lbl_spq.Text = dr("qty").ToString & " pcs/box"
                    lbl_output.Text = dr("target_output").ToString
                    lbl_targettime.Text = targetcycletime
                    countdowntimer = targetcycletime
                    setID = itemId
                    panel_scan.Enabled = True
                    SPQ = dr("qty").ToString
                    lbl_qctimer.Text = "0"
                End While

            End Using
            con.Close()
            updateactual()
            updateboxitem()
        End Using

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If Timer1.Enabled Then
            ' Currently running, so stop
            Timer1.Stop()
            txt_barcode.Enabled = False
            Guna2Button2.Text = "START"
            Guna2Button2.FillColor = Color.ForestGreen
            Guna2Button2.Image = My.Resources.play
            Guna2GroupBox1.Focus()
            panel_select.Enabled = True
            txt_barcode.Enabled = False
            panel_select.Focus()
        Else
            ' Currently stopped, so start
            Timer1.Start()
            txt_barcode.Enabled = True
            txt_barcode.Focus()
            Guna2Button2.Text = " STOP"
            Guna2Button2.FillColor = Color.Crimson
            Guna2Button2.Image = My.Resources.pause
            panel_select.Enabled = False
            txt_barcode.Enabled = True
            txt_barcode.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        qctimer += 1
        lbl_qctimer.Text = qctimer.ToString("00")

        If countdowntimer = 0 Then
            countdowntimer = targetcycletime
            updatetarget()
            lbl_targettime.Text = countdowntimer
        Else
            countdowntimer -= 1
            lbl_targettime.Text = countdowntimer
        End If



    End Sub
    Sub updateboxitem()


        Dim query As String = "SELECT COUNT(id) AS count FROM prod_scanner
                  WHERE planID=" & setID & " AND fgQR=''"

        con.Close()
        con.Open()
        Dim selectdata As New MySqlCommand(query, con)
        dr = selectdata.ExecuteReader
        If dr.Read = True Then
            lbl_box.Text = dr.GetInt32("count").ToString

        End If

        If Convert.ToInt32(lbl_box.Text) >= SPQ Then
            scanFG.ShowDialog()
            scanFG.BringToFront()

        End If
    End Sub

    Sub updateactual()

        reload("SELECT barcode,clock,TIME_FORMAT(datestamp, '%H:%i:%s') AS Time FROM prod_scanner  WHERE planID=" & setID & " ORDER BY id DESC", datagrid1)


        Dim query As String = "SELECT COUNT(id) AS count, SUM(clock)/(COUNT(id)) as total FROM prod_scanner
                  WHERE planID=" & setID & ""

        con.Close()
        con.Open()
        Dim selectdata As New MySqlCommand(query, con)
        dr = selectdata.ExecuteReader
        If dr.Read = True Then
            ' Handle NULL safely
            If Not IsDBNull(dr("count")) Then
                lbl_actual.Text = dr("count").ToString()
            Else
                lbl_actual.Text = "0"
            End If

            If Not IsDBNull(dr("total")) Then
                lbl_cycle.Text = Convert.ToDecimal(dr("total")).ToString("N0") & " sec."
            Else
                lbl_cycle.Text = "0 sec."
            End If
        End If


    End Sub



    Private Sub updatetarget()
        Try
            ' SQL query to update the target output
            Dim query As String = "UPDATE `prod_plan` SET `target_output` = `target_output` + 1 WHERE id = @planid"

            con.Close()
            con.Open()

            ' Create and parameterize the SQL command
            Dim updatedata As New MySqlCommand(query, con)
            updatedata.Parameters.AddWithValue("@planid", setID)

            ' Execute the query
            updatedata.ExecuteNonQuery()
            lbl_output.Text = Convert.ToInt32(lbl_output.Text) + 1
        Catch ex As Exception
            ' Log or display the error for debugging
            MessageBox.Show("An error occurred while updating the target: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is always closed
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged

    End Sub

    Private Sub txt_barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                If txt_barcode.Text.Length >= 3 AndAlso txt_barcode.Text.Substring(0, 3) = lbl_modelcode.Text Then

                    Dim query As String = "INSERT INTO `prod_scanner`(planID,`barcode`, `partcode`, clock,pc) VALUES (" & setID & ",'" & txt_barcode.Text & "','" & lbl_partcode.Text & "'," & lbl_qctimer.Text & ",'" & user_PC & "')"
                    con.Close()
                    con.Open()
                    Dim insertdata As New MySqlCommand(query, con)
                    insertdata.ExecuteNonQuery()
                    updateactual()
                    updateboxitem()
                    qctimer = 0
                Else
                    Dim warn As New warning
                    warn.ShowDialog()
                    warn.BringToFront()

                End If
                txt_barcode.Clear()
                txt_barcode.Focus()

            Catch ex As MySqlException When ex.Number = 1062
                Dim warn As New warning
                warn.display("Duplicate Barcode Detected!")
                warn.ShowDialog()
                warn.BringToFront()
            Catch ex As Exception
                ' General error handling
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton1.CheckedChanged
        If Guna2RadioButton1.Checked Then
            Guna2RadioButton1.Font = New Font("Segoe UI", 25, FontStyle.Bold)
            Guna2RadioButton2.Font = New Font("Segoe UI", 18, FontStyle.Regular)
        End If
    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton2.CheckedChanged
        If Guna2RadioButton2.Checked Then
            Guna2RadioButton2.Font = New Font("Segoe UI", 25, FontStyle.Bold)
            Guna2RadioButton1.Font = New Font("Segoe UI", 18, FontStyle.Regular)
        End If
    End Sub
End Class
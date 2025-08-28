Imports MySql.Data.MySqlClient
Public Class edit_plan
    Dim setID As Integer
    Public Sub loadset(id As Integer)
        setID = id
        Dim query As String = "SELECT CONCAT(am.partname,' - ', pp.partcode) AS item,am.model,pp.`id`, pp.`location`, pp.`line`, pp.`partcode`, pp.`plan`, pp.`duration`, pp.`cycletime`, pp.`datein`, pp.`shift`, pp.`user`, pp.`target_output` FROM `prod_plan` pp
JOIN assy_masterlist am ON am.partcode=pp.partcode                                   
WHERE pp.id = " & setID & ""
        con.Close()
        con.Open()
        Using cmd As New MySqlCommand(query, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lbl_line.Text = "LINE " & dr("line")
                lbl_partcode.Text = dr("item")
                txt_plan.Text = dr("plan")
                txt_hour.Text = dr("duration")
                lbl_model.Text = dr("model")
            End If

        End Using
    End Sub
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Try

            Dim query As String = "UPDATE prod_plan SET plan=" & txt_plan.Text & ", duration=" & txt_hour.Text & ",cycletime=" & lbl_cycle.Text & " WHERE id=" & setID & ""
            con.Close()
        con.Open()
            Using cmd As New MySqlCommand(query, con)
                cmd.ExecuteNonQuery()
            End Using

            viewplan_scanner.reloadplan()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Dim queryselect As String = "SELECT `id` FROM `prod_scanner` WHERE planID=" & setID & " "
            con.Close()
            con.Open()
            Using cmd As New MySqlCommand(queryselect, con)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MessageBox.Show("This plan already has scanned serial in production", "Unable to delete")
                    Exit Sub
                End If


            End Using


            ' Ask user confirmation
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this plan?",
                                                         "Confirm Delete",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Delete from prod_plan
                Dim query As String = "DELETE FROM prod_plan WHERE id=" & setID & ""
                con.Close()
                con.Open()
                Using cmd As New MySqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                End Using

                viewplan_scanner.reloadplan()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txt_hour_TextChanged(sender As Object, e As EventArgs) Handles txt_hour.TextChanged, txt_plan.TextChanged
        If txt_plan.Text = "" OrElse txt_hour.Text = "" Then
        Else
            lbl_cycle.Text = ((Convert.ToDecimal(txt_hour.Text) * 3600) / Convert.ToDecimal(txt_plan.Text)).ToString("N0")
        End If
    End Sub
    Private Sub edit_plan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
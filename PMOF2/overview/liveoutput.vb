Imports MySql.Data.MySqlClient

Public Class liveoutput


    Private Sub liveoutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loadLIVE(liveID  As Integer)
        Try



            Dim query As String = "
        SELECT pp.id,
               pp.plan,
               pp.line,
               pp.cycletime,
               pp.target_output,
               COUNT(ps.id) AS actual_output,
               am.model,
               COALESCE(SUM(ps.clock) / NULLIF(COUNT(ps.id),0), 0) AS actualcycle
        FROM prod_plan pp
        LEFT JOIN prod_scanner ps ON pp.ID = ps.planID
        LEFT JOIN assy_masterlist am ON am.partcode = pp.partcode
        WHERE pp.id = " & liveID & "
        GROUP BY pp.id, pp.plan, pp.line, pp.cycletime, pp.target_output, am.model
    "

            Using cmd As New MySqlCommand(query, con)
                con.Close()
                con.Open()
                dr = cmd.ExecuteReader

                If dr.Read() Then
                    lbl_model.Text = dr("model").ToString()
                    lbl_plan.Text = dr("plan").ToString()
                    lbl_CTtarget.Text = dr("cycletime").ToString()
                    lbl_output.Text = dr("target_output").ToString()
                    lbl_actual.Text = dr("actual_output").ToString()
                    lbl_cycle.Text = Convert.ToInt32(dr("actualcycle")).ToString("N0")
                End If

                ' Safely handle when actual or plan = 0
                Dim plan As Integer = If(String.IsNullOrEmpty(lbl_plan.Text), 0, Convert.ToInt32(lbl_plan.Text))
                Dim actual As Integer = If(String.IsNullOrEmpty(lbl_actual.Text), 0, Convert.ToInt32(lbl_actual.Text))

                radial.Maximum = If(plan > 0, plan, 1) ' Avoid 0 max
                radial.Value = actual
                If plan > 0 Then
                    lbl_percent.Text = ((actual / plan) * 100).ToString("N0") & "%"
                Else
                    lbl_percent.Text = "0%"
                End If
            End Using
            Timer1.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Timer1.Stop()
        End Try
    End Sub


End Class

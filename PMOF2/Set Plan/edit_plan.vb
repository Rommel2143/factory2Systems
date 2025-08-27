Imports MySql.Data.MySqlClient
Public Class edit_plan
    Dim setID As Integer
    Public Sub loadset(id As Integer)
        setID = id
        Dim query As String = "SELECT CONCAT(am.partname,' - ', pp.partcode) AS item,pp.`id`, pp.`location`, pp.`line`, pp.`partcode`, pp.`plan`, pp.`duration`, pp.`cycletime`, pp.`datein`, pp.`shift`, pp.`user`, pp.`target_output` FROM `prod_plan` pp
JOIN assy_masterlist am ON am.partcode=pp.partcode                                   
WHERE pp.id = " & setID & ""
        con.Close()
        con.Open()
        Using cmd As New MySqlCommand(query, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lbl_line.Text = "LINE " & dr("line")
                lbl_partcode.Text = dr("item")

            End If

        End Using
    End Sub
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

    End Sub
End Class
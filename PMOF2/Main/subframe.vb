Public Class subframe

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        display_inMain(Login)

        Me.Close()
    End Sub


    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        add_user.Show()
        add_user.BringToFront()
    End Sub



    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        change_password.ShowDialog()
        change_password.BringToFront()
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        display_inSub(New manage_users)
    End Sub

    Private Sub ChaneInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        display_inSub(New update_name)
    End Sub


    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        btn_user.Text = "Hello, " & user_UserName
        btn_administrator.Visible = isAccess("admin")

        If btn_profile.ContextMenuStrip IsNot Nothing Then
            btn_profile.ContextMenuStrip.Show(btn_profile, 0, btn_profile.Height)

        End If
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        If btn_menu.ContextMenuStrip IsNot Nothing Then
            btn_menu.ContextMenuStrip.Show(btn_menu, 0, btn_menu.Height)

        End If
    End Sub


    Private Sub SetPlanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetPlanToolStripMenuItem.Click

    End Sub

    Private Sub OverviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverviewToolStripMenuItem.Click
        display_inSub(overview)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        display_inSub(manage_item)
    End Sub

    Private Sub ADFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADFToolStripMenuItem.Click
        display_inSub(viewplan_adf)
    End Sub

    Private Sub SCANNERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SCANNERToolStripMenuItem.Click
        display_inSub(viewplan_scanner)
    End Sub

    Private Sub AddQAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddQAToolStripMenuItem.Click
        addQC.Show()
        addQC.BringToFront()
    End Sub
End Class
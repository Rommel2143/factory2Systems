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


    Public Sub display_inSub(newForm As Form)
        With newForm
            .TopLevel = False
            .AutoScroll = True
            .AutoScrollMargin = New Size(50, 50)
            .FormBorderStyle = FormBorderStyle.None
            '' Optional: clear previous content
            'subframe.Panel1.Controls.Clear()

            ' Add if not already present
            If Not Panel1.Controls.Contains(newForm) Then
                Panel1.Controls.Add(newForm)
            End If
            lbl_FormName.Text = .Text
            .BringToFront()
            .Show()
        End With
    End Sub

    Public Sub display_inSub(newForm As Form, column As String)
        If isAccess(column) Then
        Else
            Show_Error("Access Denied.")
            Exit Sub
        End If

        With newForm
            .TopLevel = False
            .AutoScroll = True
            .AutoScrollMargin = New Size(50, 50)

            .FormBorderStyle = FormBorderStyle.None
            Panel1.Controls.Clear()

            If Not Panel1.Controls.Contains(newForm) Then
                Panel1.Controls.Add(newForm)
            End If
            lbl_FormName.Text = .Text
            .BringToFront()
            .Show()
        End With
    End Sub




    Private Sub SetPlanToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OverviewToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        display_inSub(manage_item)
    End Sub

    Private Sub ADFToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SCANNERToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddQAToolStripMenuItem_Click(sender As Object, e As EventArgs)
        addQC.Show()
        addQC.BringToFront()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        display_inSub(viewplan_scanner)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        display_inSub(overview)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        display_inSub(viewplan_adf)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ManageLeadersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageLeadersToolStripMenuItem.Click

        ManageLeader.Show()
        ManageLeader.BringToFront()

    End Sub
End Class
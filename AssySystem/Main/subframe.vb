Public Class subframe


    Private Sub SetLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetLineToolStripMenuItem.Click
        change_line.Show()
        change_line.BringToFront()
    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click

        If btn_profile.ContextMenuStrip IsNot Nothing Then
            btn_profile.ContextMenuStrip.Show(btn_profile, 0, btn_profile.Height)
        End If
    End Sub

    Private Sub subframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_inSub(scan_IN)
    End Sub
End Class
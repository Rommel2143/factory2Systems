Public Class EditLeader
    Dim _Leader As Leader
    Sub New(_LeaderObject As Leader)
        InitializeComponent()
        _Leader = _LeaderObject
        txtIDno.Text = _Leader.IDNo
        txtFirstname.Text = _Leader.Firstname
        txtLastname.Text = _Leader.Lastname
        txtPosition.Text = _Leader.Position
        PanelPassword.Visible = False
        Me.Width = 370
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If PanelPassword.Visible Then
            PanelPassword.Visible = False
            Me.Width = 370
        Else
            PanelPassword.Visible = True
            Me.Width = 790
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        _Leader.DeleteLeader()
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        _Leader.IDNo = txtIDno.Text
        _Leader.Firstname = txtFirstname.Text
        _Leader.Lastname = txtLastname.Text
        _Leader.Position = txtPosition.Text
        _Leader.UpdateLeader()
        Me.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If CryptoModule.EncryptPassword(txtCurrent.Text) <> _Leader.Password Then
            MessageBox.Show("Current password is incorrect.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        _Leader.ChangePassword(txtConfirm.Text)
    End Sub
End Class
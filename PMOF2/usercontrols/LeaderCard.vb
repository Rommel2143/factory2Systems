Public Class LeaderCard
    Dim _Leader As Leader
    Sub New(_LeaderObject As Leader)
        InitializeComponent()
        _Leader = _LeaderObject
        lblFullname.Text = _Leader.Firstname & " " & _Leader.Lastname
        lblPosition.Text = _Leader.Position
        lblIDNo.Text = _Leader.IDNo

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Using edit As New EditLeader(_Leader)
            edit.ShowDialog()
        End Using
        ManageLeader.LoadCard()
    End Sub
End Class

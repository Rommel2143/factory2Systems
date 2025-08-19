Public Class warning
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
    Public Sub display(text As String)
        lbl_error.Text = text
    End Sub
    Private Sub warning_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
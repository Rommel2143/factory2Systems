Imports Guna.UI2.WinForms
Imports System.Threading
Public Class Mainframe

    Private Sub Mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load all data, initialize UI elements, etc.
        display_inMain(subframe)
    End Sub

    Private Sub Mainframe_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' After the form is fully displayed, then check and show change_line
        If getPCline() = 0 Then
            change_line.Guna2ControlBox1.Hide()
            change_line.BringToFront()
            change_line.ShowDialog()

        End If
    End Sub






End Class

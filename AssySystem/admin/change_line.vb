Imports MySql.Data.MySqlClient
Public Class change_line
    Dim countdown As Integer = 3
    Private Sub change_line_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_location.Text = user_PClocation
        num_line.Value = user_PCline
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Dim query As String = "INSERT INTO `prod_pcline` (`id`, `pcname`,location, `line`) VALUES (NULL,'" & user_PC & "','" & cmb_location.Text & "','" & num_line.Value & "')"
            con.Close()
            con.Open()
            Dim insert As New MySqlCommand(query, con)
            insert.ExecuteNonQuery()
            Timer1.Start()

        Catch ex As MySqlException When ex.Number = 1062
            Dim query As String = "UPDATE `prod_pcline` SET location='" & cmb_location.Text & "', `line`='" & num_line.Value & "'"
            con.Close()
            con.Open()
            Dim update As New MySqlCommand(query, con)
            update.ExecuteNonQuery()
            Timer1.Start()

        Catch ex As Exception
            Show_Error(ex.Message, 0)
        End Try

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Display the error message with the current countdown value
        Show_Error("Device Line has Changed! Application will exit in (" & countdown & ")", 0)

        ' Decrement the countdown
        countdown -= 1

        ' Check if countdown has reached 0
        If countdown < 0 Then
            ' Stop the timer to avoid further ticks
            Timer1.Stop()

            ' Exit the application
            Application.Exit()
        End If
    End Sub
End Class
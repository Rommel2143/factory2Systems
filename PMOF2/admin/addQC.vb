Imports MySql.Data.MySqlClient

Public Class addQC
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Try

            con.Close()
            con.Open()
            Dim query As String = "INSERT INTO trc_users.prod_qc (`id`, `IDno`, `Firstname`, `Lastname`, `password`, `admin`,position) VALUES (NULL,'" & txt_id.Text & "','" & txt_fname.Text & "','" & txt_lname.Text & "','8TUIs5Kns6c3+XEbV2pTFQ==','0','" & txtPosition.Text & "')"

            Dim insert As New MySqlCommand(query, con)


            insert.ExecuteNonQuery()


        Catch ex As MySqlException When ex.Number = 1062
            Show_Error("Duplicate entry detected", SOUND_DUPLICATE)

        Catch ex As Exception
            Show_Error($"Error on saving: {ex.Message}", SOUND_ERROR)

        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        txt_id.Clear()
        txt_fname.Clear()
        txt_lname.Clear()

        MessageBox.Show("User Registered.")
        Me.Close()
    End Sub

End Class
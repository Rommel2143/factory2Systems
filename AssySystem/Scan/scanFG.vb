Imports MySql.Data.MySqlClient
Public Class scanFG
    Private Sub txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged
        Dim query As String = "UPDATE `prod_scanner` SET fgQR='" & txt_barcode.Text & "' WHERE planID=" & scan_IN.setID & ""
    End Sub

    Private Sub txt_barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            If checkQR(txt_barcode.Text.Trim) = scan_IN.lbl_partcode.Text Then

                Dim query As String = "UPDATE `prod_scanner` SET fgQR='" & txt_barcode.Text & "' WHERE planID=" & scan_IN.setID & " AND fgQR=''"
                Using cmd As New MySqlCommand(query, con)
                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    txt_barcode.Clear()
                    scan_IN.lbl_box.Text = "0"
                    Me.Close()
                End Using

            Else
                warning.ShowDialog()
                warning.BringToFront()
                txt_barcode.Clear()
                txt_barcode.Focus()
            End If

        End If
    End Sub
End Class
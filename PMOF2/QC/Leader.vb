Imports MySql.Data.MySqlClient

Public Class Leader
    Public Property ID As Integer
    Public Property IDNo As String
    Public Property Firstname As String
    Public Property Lastname As String
    Public Property Position As String
    Public Property Password As String


    Public Sub DeleteLeader()
        Dim query As String = "DELETE FROM trc_users.prod_qc WHERE ID = @ID"
        Using connection As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", Me.ID)
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Leader information deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
    End Sub


    Public Sub UpdateLeader()
        Dim query As String = "UPDATE trc_users.prod_qc SET IDNo = @IDNo, Firstname = @Firstname, Lastname = @Lastname, Position = @Position WHERE ID = @ID"
        Using connection As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@IDNo", Me.IDNo)
                command.Parameters.AddWithValue("@Firstname", Me.Firstname)
                command.Parameters.AddWithValue("@Lastname", Me.Lastname)
                command.Parameters.AddWithValue("@Position", Me.Position)
                command.Parameters.AddWithValue("@ID", Me.ID)
                connection.Open()
                command.ExecuteNonQuery()

                MessageBox.Show("Leader information updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
    End Sub

    Public Function ChangePassword(newPassword As String) As Boolean
        Dim query As String = "UPDATE trc_users.prod_qc SET Password = @Password WHERE ID = @ID"
        Using connection As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Password", CryptoModule.EncryptPassword(newPassword))
                command.Parameters.AddWithValue("@ID", Me.ID)
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Password changed successfully.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    MessageBox.Show("Failed to change password.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End Using
        End Using
    End Function

End Class

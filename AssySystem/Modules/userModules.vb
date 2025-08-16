Imports MySql.Data.MySqlClient

Module userModules

    Public user_ID As Integer
    Public user_IDNumber As String
    Public user_UserName As String
    Public user_Password As String
    Public user_LastName As String
    Public user_PC As String = Environment.MachineName
    Public user_PCline As String = getPCline()
    Public user_PClocation As String = getPClocation()

    Public userTable As String = "trc_users.prod_qc"
    'SELECT `id`(primary), `IDno`(vachar,unique), `Firstname`(varchar), `Lastname`(varchar), `password`(varchar), `admin`(boolean) FROM `app_user`

    Public Function isLogin(IDno As String, pass As String) As Boolean


        Try
            Dim query As String = "SELECT `id`, `IDno`, `Firstname`, `Lastname`, `password` FROM " & userTable & " WHERE IDno = @IDno AND password = @password"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@IDno", IDno)
                cmd.Parameters.AddWithValue("@password", pass)
                con.Close()
                con.Open()
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    user_ID = dr.GetInt32("ID")
                    user_IDNumber = dr.GetString("IDno")
                    user_UserName = dr.GetString("Firstname")
                    user_LastName = dr.GetString("Lastname")
                    user_Password = dr.GetString("password")

                    Return 1
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function isAccess(column As String) As Boolean
        Try

            Dim query As String = "SELECT " & column & ",admin FROM " & userTable & " WHERE IDno = @IDno"


            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@IDno", user_IDNumber)

                con.Close()
                con.Open()
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    If dr.GetBoolean(1) = True Then
                        Return 1
                    Else
                        Return dr.GetBoolean(0)
                    End If

                Else
                        Return 0
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Something went wrong. Please try again later.")
            Return 0
        End Try
    End Function

    Public Function getPCline() As String
        Dim query As String = "SELECT line FROM prod_pcline WHERE pcname='" & Environment.MachineName & "'"
        con.Close()
        con.Open()
        Dim selectpc As New MySqlCommand(query, con)
        dr = selectpc.ExecuteReader
        If dr.Read = True Then
            Return dr("line")
        Else
            Return 0
        End If
    End Function

    Public Function getPClocation() As String
        Dim query As String = "SELECT location FROM prod_pcline WHERE pcname='" & Environment.MachineName & "'"
        con.Close()
        con.Open()
        Dim selectpc As New MySqlCommand(query, con)
        dr = selectpc.ExecuteReader
        If dr.Read = True Then
            Return dr("location")
        Else
            Return ""
        End If
    End Function

    Public Sub LogoutUser()
        user_ID = Nothing
        user_IDNumber = Nothing
        user_UserName = Nothing
        user_Password = Nothing
        user_LastName = Nothing
        user_PC = Nothing
    End Sub


End Module

Imports System.Reflection
Imports DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
Imports MySql.Data.MySqlClient

Public Class ManageLeader
    Private LeaderList As New List(Of Leader)
    Private Sub ManageLeader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCard()
    End Sub

    Sub LoadCard()

        LeaderList.Clear()

        Dim query As String = "SELECT `id`, `IDno`, `Firstname`, `Lastname`, `position`, password 
                           FROM trc_users.prod_qc 
                           ORDER BY firstname ASC"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    FlowLayoutPanel1.Controls.Clear()

                    If reader.HasRows Then
                        While reader.Read()

                            Dim leader As New Leader With {
                            .ID = reader.GetInt32("id"),
                            .IDNo = reader.GetString("IDno"),
                            .Firstname = reader.GetString("Firstname"),
                            .Lastname = reader.GetString("Lastname"),
                            .Position = reader.GetString("position"),
                            .Password = reader.GetString("password")
                        }

                            LeaderList.Add(leader)

                        End While
                    End If
                End Using
            End Using
        End Using

        ' Display all
        DisplayLeaders(LeaderList)

    End Sub
    Private Sub DisplayLeaders(leaders As List(Of Leader))

        FlowLayoutPanel1.Controls.Clear()

        For Each leader In leaders
            Dim card As New LeaderCard(leader)
            FlowLayoutPanel1.Controls.Add(card)
        Next

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Using addqc As New addQC
            addqc.ShowDialog()
            addqc.BringToFront()
        End Using
        LoadCard()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        LoadCard()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Dim keyword As String = Guna2TextBox1.Text.Trim().ToLower()

        If keyword = "" Then
            DisplayLeaders(LeaderList)
            Exit Sub
        End If

        Dim filtered = LeaderList.Where(Function(x) _
                            x.Firstname.ToLower().Contains(keyword) Or
                            x.Lastname.ToLower().Contains(keyword) Or
                            x.IDNo.ToLower().Contains(keyword) Or
                            x.Position.ToLower().Contains(keyword)
                        ).ToList()

        DisplayLeaders(filtered)
    End Sub
End Class
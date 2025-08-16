Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class set_partcode
    Public lineLocation As String
    Public dateplan As String
    Public shiftplan As Boolean
    Private Sub set_partcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT pp.id, pp.location, pp.line, pp.partcode, pp.plan, pp.duration, 
                              pp.cycletime, pp.datein, pp.shift, pp.user,
                              CONCAT(pp.partcode,'   -   ',am.partname) AS item
                       FROM prod_plan pp
                       JOIN assy_masterlist am ON am.partcode = pp.partcode
                       WHERE CONCAT(pp.location,'-LINE ',pp.line) = @lineLocation
                       AND pp.datein = @dateplan
                       AND pp.shift = @shiftplan"

        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@lineLocation", lineLocation)
            cmd.Parameters.AddWithValue("@dateplan", dateplan)
            cmd.Parameters.AddWithValue("@shiftplan", shiftplan)

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    fgCard(dr("item").ToString(),
                           dr("plan").ToString(),
                           dr("duration").ToString(),
                           dr("cycletime").ToString(),
                           dr("id").ToString())
                End While
            End Using
            con.Close()
        End Using



    End Sub

    Private Sub fgCard(item As String, plan As String, duration As String, cycletime As String, id As String)
        ' Create a new panel (card container)
        Dim cardPanel As New Guna2Panel()
        With cardPanel
            .Width = FlowLayoutPanel1.Width - 20
            .Height = 100
            .FillColor = Color.White
            .Margin = New Padding(8)
            .BorderThickness = 1
            .BorderRadius = 12
            .BorderColor = Color.Silver
            .ShadowDecoration.Enabled = True
            .ShadowDecoration.Depth = 4
        End With

        ' Item (Title)
        Dim lblItem As New Label()
        With lblItem
            .AutoSize = True
            .Font = New Font("Segoe UI", 13, FontStyle.Bold)
            .ForeColor = Color.MidnightBlue
            .Text = item
            .Location = New Point(15, 10)
            .BackColor = Color.Transparent
        End With

        ' Plan
        Dim lblPlan As New Label()
        With lblPlan
            .AutoSize = True
            .Font = New Font("Segoe UI", 11, FontStyle.Regular)
            .ForeColor = Color.DimGray
            .Text = "Plan: " & plan
            .Location = New Point(20, 45)
            .BackColor = Color.Transparent
        End With

        ' Duration
        Dim lblDuration As New Label()
        With lblDuration
            .AutoSize = True
            .Font = New Font("Segoe UI", 11, FontStyle.Regular)
            .ForeColor = Color.DimGray
            .Text = "Duration: " & duration & " hrs"
            .Location = New Point(20, 70)
            .BackColor = Color.Transparent
        End With

        ' Cycle Time
        Dim lblCycle As New Label()
        With lblCycle
            .AutoSize = True
            .Font = New Font("Segoe UI", 11, FontStyle.Regular)
            .ForeColor = Color.DimGray
            .Text = "Cycle Time: " & cycletime & " sec"
            .Location = New Point(cardPanel.Width \ 2, 70)
            .BackColor = Color.Transparent
        End With

        ' Action Button (docked right)
        Dim btnAction As New Guna2Button()
        With btnAction
            .Width = 80
            .Dock = DockStyle.Right
            .FillColor = Color.FromArgb(39, 174, 96)
            .ForeColor = Color.White
            .BorderRadius = 8
            .CustomizableEdges.TopLeft = False
            .CustomizableEdges.BottomLeft = False
            .Image = My.Resources.forward2
            .ImageSize = New Size(64, 64)
            .Tag = id   ' store pp.id in the Tag property
        End With
        AddHandler btnAction.Click, AddressOf btnAction_Click

        ' Add controls into card
        cardPanel.Controls.Add(lblItem)
        cardPanel.Controls.Add(lblPlan)
        cardPanel.Controls.Add(lblDuration)
        cardPanel.Controls.Add(lblCycle)
        cardPanel.Controls.Add(btnAction)

        ' Add card into FlowLayoutPanel
        FlowLayoutPanel1.Controls.Add(cardPanel)
    End Sub

    ' Button Click Handler
    Private Sub btnAction_Click(sender As Object, e As EventArgs)
        Dim btn As Guna2Button = CType(sender, Guna2Button)
        scan_IN.loadItem(btn.Tag.ToString())
        Me.Close()
    End Sub



End Class
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class overview





    Private Sub fgCard(line As String, partcodemodel As String, duration As String, cycletime As String, id As String)
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        ' Create a new panel (card container)
        Dim cardPanel As New Guna2Panel()
        With cardPanel
            ' Example: 1/6 of screen width, 1/8 of screen height
            .Width = (screenWidth - 100) / 6.3
            .Height = screenHeight / 10.3
            .FillColor = Color.White
            .Margin = New Padding(2)
            .BorderThickness = 1
            .BorderRadius = 12
            .BorderColor = Color.Silver
            .ShadowDecoration.Enabled = True
            .ShadowDecoration.Depth = 4
        End With


        ' Item (Title)
        Dim linetittle As New Label()
        With linetittle
            .AutoSize = True
            .Font = New Font("Segoe UI", 13, FontStyle.Bold)
            .ForeColor = Color.MidnightBlue
            .Text = line
            .Location = New Point(15, 10)
            .BackColor = Color.Transparent
        End With

        ' Item (Title)
        Dim model As New Label()
        With model
            .AutoSize = True
            .Font = New Font("Segoe UI", 13, FontStyle.Bold)
            .ForeColor = Color.MidnightBlue
            .Text = partcodemodel
            .Location = New Point(20, 10)
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

        ' Action Button (upper right corner)
        Dim btnAction As New Guna2Button()
        With btnAction
            .Size = New Size(40, 40)   ' fixed size (adjust as needed)
            .Location = New Point(cardPanel.Width - .Width - 10, 10) ' 10px margin from right/top
            .FillColor = Color.FromArgb(39, 174, 96)
            .ForeColor = Color.White
            .BorderRadius = 8
            .Image = My.Resources.eye
            .ImageSize = New Size(24, 24)
            .Tag = id   ' store pp.id in the Tag property
            .Anchor = AnchorStyles.Top Or AnchorStyles.Right
        End With
        AddHandler btnAction.Click, AddressOf btnAction_Click

        ' Add controls into card
        cardPanel.Controls.Add(linetittle)
        cardPanel.Controls.Add(model)
        cardPanel.Controls.Add(lblCycle)
        cardPanel.Controls.Add(btnAction)

        ' Add card into FlowLayoutPanel
        FlowLayoutPanel1.Controls.Add(cardPanel)
    End Sub

    ' Button Click Handler
    Private Sub btnAction_Click(sender As Object, e As EventArgs)
        Dim btn As Guna2Button = CType(sender, Guna2Button)
        MessageBox.Show(btn.Tag.ToString())
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Dim query As String = "SELECT pp.line,pp.cycletime,pp.target_output,COUNT(ps.id),am.model,SUM(ps.clock)/COUNT(ps.id) AS actualcycle FROM prod_scanner ps
                                JOIN prod_plan pp ON pp.ID= ps.planID
                                JOIN assy_masterlist am ON am.partcode=ps.partcode
                                WHERE DATE(datestamp)='" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND shift = " & If(Guna2RadioButton1.Checked = True, 1, 0) & "
GROUP BY planID "
        Using cmd As New MySqlCommand(query, con)
            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            While dr.Read = True
                Dim tittle As String = "LINE " & dr("line")
                Dim model As String
                fgCard(tittle, model, dr("actualcycle").ToString, "", "")
            End While
        End Using
    End Sub
End Class
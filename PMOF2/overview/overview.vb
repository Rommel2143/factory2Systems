Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class overview





    Private Sub fgCard(line As String, partcodemodel As String, plan As String, Target As String, actual As String, id As String)
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        ' Create a new panel (card container)
        Dim cardPanel As New Guna2GradientPanel()
        With cardPanel
            ' Example: 1/6 of screen width, 1/8 of screen height
            .Width = (screenWidth - 100) / 6.3
            .Height = screenHeight / 10.3
            .FillColor = Color.White
            If Convert.ToInt32(actual) >= Convert.ToInt32(plan) Then

                .FillColor2 = Color.LightGreen
            Else

                .FillColor2 = Color.LightGray
            End If
            .GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
            .Margin = New Padding(2)
            .BorderThickness = 2
            .BorderRadius = 20
            .BorderColor = Color.White
            .ShadowDecoration.Enabled = True
            .ShadowDecoration.Depth = 10
            .ShadowDecoration.BorderRadius = 23
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

        Dim plantittle As New Label()
        With plantittle
            .AutoSize = True
            .Font = New Font("Segoe UI", 10)
            .ForeColor = Color.MidnightBlue
            .Text = "Plan: " & plan
            .Location = New Point(cardPanel.Width - (cardPanel.Width * 0.5), 10)
            .BackColor = Color.Transparent
        End With



        ' Item (Title)
        Dim model As New Label()
        With model
            .AutoSize = True
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ForeColor = Color.MidnightBlue
            .Text = partcodemodel
            .Location = New Point(15, 30)
            .BackColor = Color.Transparent
        End With

        'targerlbl
        Dim targetlabel As New Label()
        With targetlabel
            .AutoSize = True
            .Font = New Font("Segoe UI", 10)
            .ForeColor = Color.Black
            .Text = "Target"
            .Location = New Point(cardPanel.Width / 4, 50)
            .BackColor = Color.Transparent
        End With
        ' target
        Dim lblTarget As New Label()
        With lblTarget
            .AutoSize = True
            .Font = New Font("Segoe UI", 25, FontStyle.Bold)
            .ForeColor = Color.Black
            .Text = Target
            .Location = New Point(cardPanel.Width / 4, 60)
            .BackColor = Color.Transparent

        End With

        Dim seperator As New Guna2VSeparator
        With seperator
            .Location = New Point(cardPanel.Width / 2, 60)
        End With


        'actuallbl
        Dim actuallbl As New Label()
        With actuallbl
            .AutoSize = True
            .Font = New Font("Segoe UI", 10)
            .ForeColor = Color.Black
            .Text = "Actual"
            .Location = New Point((cardPanel.Width / 2) + 30, 50)
            .BackColor = Color.Transparent
        End With

        'actual
        Dim lblactual As New Label()
        With lblactual
            .AutoSize = True
            .Font = New Font("Segoe UI", 25, FontStyle.Bold)
            .ForeColor = Color.Black
            .Text = actual
            .Location = New Point((cardPanel.Width / 2) + 30, 60)
            .BackColor = Color.Transparent
        End With

        ' Action Button (upper right corner)
        Dim btnAction As New Guna2Button()
        With btnAction
            .Size = New Size(40, 40)   ' fixed size (adjust as needed)
            .Location = New Point(cardPanel.Width - .Width - 10, 10) ' 10px margin from right/top
            .FillColor = Color.FromArgb(39, 174, 96)
            .ForeColor = Color.White
            .BorderRadius = 10
            .Image = My.Resources.eye
            .ImageSize = New Size(24, 24)
            .Tag = id   ' store pp.id in the Tag property
            .Anchor = AnchorStyles.Top Or AnchorStyles.Right
            .BringToFront()
        End With
        AddHandler btnAction.MouseEnter, AddressOf btnAction_MouseEnter
        AddHandler btnAction.MouseLeave, AddressOf btnAction_MouseLeave

        ' Add controls into card
        cardPanel.Controls.Add(linetittle)
        cardPanel.Controls.Add(model)
        cardPanel.Controls.Add(plantittle)
        cardPanel.Controls.Add(targetlabel)
        cardPanel.Controls.Add(lblTarget)
        cardPanel.Controls.Add(actuallbl)
        cardPanel.Controls.Add(seperator)
        cardPanel.Controls.Add(lblactual)
        cardPanel.Controls.Add(btnAction)

        ' Add card into FlowLayoutPanel
        FlowLayoutPanel1.Controls.Add(cardPanel)
    End Sub

    Private Sub btnAction_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Guna2Button = CType(sender, Guna2Button)

        ' Load data
        liveoutput.loadLIVE(Convert.ToInt32(btn.Tag))

        ' Position liveoutput relative to the mouse
        Dim mousePos As Point = Cursor.Position
        liveoutput.StartPosition = FormStartPosition.Manual
        liveoutput.Location = New Point(mousePos.X, mousePos.Y + 5) ' +5 so it shows just below the pointer

        ' Show the form
        liveoutput.Show()
        liveoutput.BringToFront()
    End Sub

    Private Sub btnAction_MouseLeave(sender As Object, e As EventArgs)
        If liveoutput.Visible Then
            liveoutput.Close() ' or .Hide() if you want to keep the instance alive
        End If
    End Sub


    Private Sub btn_select_Click(sender As Object, e As EventArgs)
        loadOUTPUT()
    End Sub

    Private Sub loadOUTPUT()
        Try
            Dim query As String = "SELECT pp.id,
               pp.plan,
               pp.line,
               pp.cycletime,
               pp.target_output,
               COUNT(ps.id) AS actual_output,
               am.model,
               COALESCE(SUM(ps.clock) / NULLIF(COUNT(ps.id),0), 0) AS actualcycle
        FROM prod_plan pp
        LEFT JOIN prod_scanner ps ON pp.ID = ps.planID
        LEFT JOIN assy_masterlist am ON am.partcode = pp.partcode
        WHERE pp.datein='" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' 
          AND pp.shift = " & If(Guna2RadioButton1.Checked = True, 1, 0) & "
        GROUP BY pp.id, pp.plan, pp.line, pp.cycletime, pp.target_output, am.model
        HAVING COUNT(ps.id) > 0
         ORDER BY CAST(pp.line AS UNSIGNED) ASC"


            '            Dim query As String = "SELECT pp.id,pp.plan,pp.line,pp.cycletime,pp.target_output,COUNT(ps.id) AS actual_output,am.model,SUM(ps.clock)/COUNT(ps.id) AS actualcycle FROM  prod_plan pp
            '                                JOIN prod_scanner ps ON pp.ID= ps.planID
            '                                JOIN assy_masterlist am ON am.partcode=pp.partcode
            '                                WHERE DATE(datestamp)='" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND shift = " & If(Guna2RadioButton1.Checked = True, 1, 0) & "
            'GROUP BY planID "
            Using cmd As New MySqlCommand(query, con)
                con.Close()
                con.Open()
                dr = cmd.ExecuteReader
                FlowLayoutPanel1.Controls.Clear()

                While dr.Read = True
                    Dim tittle As String = "LINE " & dr("line")
                    Dim model As String = dr("model")
                    Dim plan As String = dr("plan")
                    Dim id As String = dr("id")
                    Dim target As String = dr("target_output")
                    Dim actual As String = dr("actual_output")
                    fgCard(tittle, model, plan, target, actual, id)
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub dtpicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker1.ValueChanged, Guna2RadioButton1.CheckedChanged, Guna2RadioButton2.CheckedChanged
        loadOUTPUT()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadOUTPUT()

        ' Reset progress when refresh happens
        Guna2CircleProgressBar1.Value = 60
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Increment progress until it reaches max
        If Guna2CircleProgressBar1.Value > 0 Then
            Guna2CircleProgressBar1.Value -= 1
        End If
    End Sub


End Class
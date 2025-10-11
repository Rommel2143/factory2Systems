Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class overview
    Dim viewing As Boolean = 0
    ' Call this once on form load to create the header
    Private Sub CreateHeader()
        Dim headerPanel As New Panel()
        With headerPanel
            .Height = 40
            .Width = FlowLayoutPanel1.Width - 20
            .BackColor = Color.FromArgb(230, 230, 230) ' light gray
            .Margin = New Padding(0, 0, 0, 2)
        End With

        ' Helper for header labels
        Dim makeHeader = Function(txt As String, x As Integer, w As Integer) As Label
                             Dim lbl As New Label()
                             With lbl
                                 .Text = txt
                                 .AutoSize = False
                                 .Width = w
                                 .Height = headerPanel.Height
                                 .Location = New Point(x, 0)
                                 .TextAlign = ContentAlignment.MiddleCenter
                                 .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                                 .ForeColor = Color.MidnightBlue
                                 .BackColor = Color.Transparent
                             End With
                             Return lbl
                         End Function

        ' Column widths (same as fgCard)
        Dim colLine As Integer = 100
        Dim colModel As Integer = 200
        Dim colPlan As Integer = 80
        Dim colTarget As Integer = 80
        Dim colActual As Integer = 80
        Dim colProgress As Integer = 200

        ' Add headers
        headerPanel.Controls.Add(makeHeader("Line", 5, colLine))
        headerPanel.Controls.Add(makeHeader("Model", 5 + colLine, colModel))
        headerPanel.Controls.Add(makeHeader("Plan", 5 + colLine + colModel, colPlan))
        headerPanel.Controls.Add(makeHeader("Target", 5 + colLine + colModel + colPlan, colTarget))
        headerPanel.Controls.Add(makeHeader("Actual", 5 + colLine + colModel + colPlan + colTarget, colActual))
        headerPanel.Controls.Add(makeHeader("Progress", 5 + colLine + colModel + colPlan + colTarget + colActual, colProgress))

        ' Add header to FlowLayoutPanel
        FlowLayoutPanel1.Controls.Add(headerPanel)
    End Sub


    ' Call this for each data row
    Private Sub fgDetails(line As String, partcodemodel As String, plan As String, Target As String, actual As String, id As String)
        Dim rowPanel As New Panel()
        With rowPanel
            .Height = 40
            .Width = FlowLayoutPanel1.Width - 20
            .BackColor = Color.FromArgb(245, 247, 250) ' soft modern gray
            .Margin = New Padding(0, 0, 0, 5)
        End With

        ' Label helper
        Dim makeLabel = Function(txt As String, x As Integer, w As Integer, bold As Boolean, center As Boolean) As Label
                            Dim lbl As New Label()
                            With lbl
                                .Text = txt
                                .AutoSize = False
                                .Width = w
                                .Height = rowPanel.Height
                                .Location = New Point(x, 0)
                                .TextAlign = If(center, ContentAlignment.MiddleCenter, ContentAlignment.MiddleLeft)
                                .Font = New Font("Segoe UI", 10, If(bold, FontStyle.Bold, FontStyle.Regular))
                                .ForeColor = Color.Black
                                .BackColor = Color.Transparent
                                .Padding = New Padding(5, 0, 5, 0)
                            End With
                            Return lbl
                        End Function

        ' Separator helper
        Dim makeSeparator = Function(x As Integer) As Panel
                                Dim sep As New Panel()
                                With sep
                                    .Width = 1
                                    .Height = rowPanel.Height - 10
                                    .BackColor = Color.LightGray
                                    .Location = New Point(x, 5)
                                End With
                                Return sep
                            End Function

        ' Column widths
        Dim colLine As Integer = 100
        Dim colModel As Integer = 200
        Dim colPlan As Integer = 80
        Dim colTarget As Integer = 80
        Dim colActual As Integer = 80
        Dim colProgress As Integer = 200

        ' Labels + Separators
        rowPanel.Controls.Add(makeLabel(line, 5, colLine, True, True))
        rowPanel.Controls.Add(makeSeparator(5 + colLine))

        rowPanel.Controls.Add(makeLabel(partcodemodel, 5 + colLine + 1, colModel, False, False))
        rowPanel.Controls.Add(makeSeparator(5 + colLine + colModel + 1))

        rowPanel.Controls.Add(makeLabel(plan, 5 + colLine + colModel + 2, colPlan, False, True))
        rowPanel.Controls.Add(makeSeparator(5 + colLine + colModel + colPlan + 2))

        rowPanel.Controls.Add(makeLabel(Target, 5 + colLine + colModel + colPlan + 3, colTarget, False, True))
        rowPanel.Controls.Add(makeSeparator(5 + colLine + colModel + colPlan + colTarget + 3))

        ' Actual
        Dim lblActual = makeLabel(actual, 5 + colLine + colModel + colPlan + colTarget + 4, colActual, True, True)
        lblActual.ForeColor = If(CInt(actual) >= CInt(plan), Color.SeaGreen, Color.IndianRed)
        rowPanel.Controls.Add(lblActual)
        rowPanel.Controls.Add(makeSeparator(5 + colLine + colModel + colPlan + colTarget + colActual + 4))

        ' Progress bar
        Dim progress As New Guna.UI2.WinForms.Guna2ProgressBar()
        With progress
            .Width = colProgress - 10
            .Height = 20
            .Location = New Point(5 + colLine + colModel + colPlan + colTarget + colActual + 6, (rowPanel.Height - .Height) \ 2)
            .Maximum = CInt(plan)
            .Value = Math.Min(CInt(actual), CInt(plan))
            .BorderRadius = 8
            .FillColor = Color.LightGray
            .ProgressColor = If(CInt(actual) >= CInt(plan), Color.SeaGreen, Color.OrangeRed)
            .ProgressColor2 = Color.DodgerBlue
            .GradientMode = Drawing2D.LinearGradientMode.Horizontal
        End With
        rowPanel.Controls.Add(progress)

        FlowLayoutPanel1.Controls.Add(rowPanel)
    End Sub




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
        loadOUTPUT()     ' for FlowLayoutPanel1 (SCANNER)
        loadOUTPUTADF()  ' for FlowLayoutPanel2 (ADF)

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

                While dr.Read()
                    Dim tittle As String = "LINE " & dr("line").ToString()
                    Dim model As String = dr("model").ToString()
                    Dim plan As String = dr("plan").ToString()
                    Dim id As String = dr("id").ToString()
                    Dim target As String = dr("target_output").ToString()
                    Dim actual As String = dr("actual_output").ToString()

                    If viewing Then
                        ' Card view, no header
                        fgCard(tittle, model, plan, target, actual, id)
                        btn_view.Image = My.Resources.details
                    Else
                        ' Details view, show header once
                        If FlowLayoutPanel1.Controls.Count = 0 Then
                            CreateHeader()
                        End If
                        fgDetails(tittle, model, plan, target, actual, id)
                        btn_view.Image = My.Resources.grid
                    End If
                End While

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub loadOUTPUTADF()
        Try
            Dim query As String = "
            SELECT pp.id,
                   pp.plan,
                   pp.line,
                   pp.cycletime,
                   pp.target_output,
                   COUNT(ps.id) AS actual_output,
                   am.model,
                   COALESCE(SUM(ps.clock) / NULLIF(COUNT(ps.id),0), 0) AS actualcycle
            FROM prod_plan pp
            LEFT JOIN prod_adf ps ON pp.ID = ps.planID
            LEFT JOIN assy_masterlist am ON am.partcode = pp.partcode
            WHERE pp.datein = @datein
              AND pp.shift = @shift
            GROUP BY pp.id, pp.plan, pp.line, pp.cycletime, pp.target_output, am.model
            HAVING COUNT(ps.id) > 0
            ORDER BY CAST(pp.line AS UNSIGNED) ASC"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@datein", dtpicker1.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@shift", If(Guna2RadioButton1.Checked, 1, 0))

                con.Close()
                con.Open()
                dr = cmd.ExecuteReader()
                FlowLayoutPanel2.Controls.Clear()

                While dr.Read()
                    Dim tittle As String = "LINE " & dr("line").ToString()
                    Dim model As String = dr("model").ToString()
                    Dim plan As String = dr("plan").ToString()
                    Dim id As String = dr("id").ToString()
                    Dim target As String = dr("target_output").ToString()
                    Dim actual As String = dr("actual_output").ToString()

                    If viewing Then
                        ' Card view (for ADF)
                        Dim cardPanel = fgCardClone(tittle, model, plan, target, actual, id)
                        FlowLayoutPanel2.Controls.Add(cardPanel)
                        btn_view.Image = My.Resources.details
                    Else
                        ' Table view (for ADF)
                        If FlowLayoutPanel2.Controls.Count = 0 Then
                            FlowLayoutPanel2.Controls.Add(CreateHeaderClone())
                        End If
                        Dim rowPanel = fgDetailsClone(tittle, model, plan, target, actual, id)
                        FlowLayoutPanel2.Controls.Add(rowPanel)
                        btn_view.Image = My.Resources.grid
                    End If
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' --- Clone of CreateHeader but returns Panel ---
    Private Function CreateHeaderClone() As Panel
        Dim headerPanel As New Panel()
        With headerPanel
            .Height = 40
            .Width = FlowLayoutPanel2.Width - 20
            .BackColor = Color.FromArgb(230, 230, 230)
            .Margin = New Padding(0, 0, 0, 2)
        End With

        Dim makeHeader = Function(txt As String, x As Integer, w As Integer) As Label
                             Dim lbl As New Label()
                             With lbl
                                 .Text = txt
                                 .AutoSize = False
                                 .Width = w
                                 .Height = headerPanel.Height
                                 .Location = New Point(x, 0)
                                 .TextAlign = ContentAlignment.MiddleCenter
                                 .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                                 .ForeColor = Color.MidnightBlue
                                 .BackColor = Color.Transparent
                             End With
                             Return lbl
                         End Function

        Dim colLine As Integer = 100
        Dim colModel As Integer = 200
        Dim colPlan As Integer = 80
        Dim colTarget As Integer = 80
        Dim colActual As Integer = 80
        Dim colProgress As Integer = 200

        headerPanel.Controls.Add(makeHeader("Line", 5, colLine))
        headerPanel.Controls.Add(makeHeader("Model", 5 + colLine, colModel))
        headerPanel.Controls.Add(makeHeader("Plan", 5 + colLine + colModel, colPlan))
        headerPanel.Controls.Add(makeHeader("Target", 5 + colLine + colModel + colPlan, colTarget))
        headerPanel.Controls.Add(makeHeader("Actual", 5 + colLine + colModel + colPlan + colTarget, colActual))
        headerPanel.Controls.Add(makeHeader("Progress", 5 + colLine + colModel + colPlan + colTarget + colActual, colProgress))

        Return headerPanel
    End Function


    ' --- Clone of fgDetails but returns Panel ---
    Private Function fgDetailsClone(line As String, partcodemodel As String, plan As String, Target As String, actual As String, id As String) As Panel
        Dim rowPanel As New Panel()
        With rowPanel
            .Height = 40
            .Width = FlowLayoutPanel2.Width - 20
            .BackColor = Color.FromArgb(245, 247, 250)
            .Margin = New Padding(0, 0, 0, 5)
        End With

        Dim makeLabel = Function(txt As String, x As Integer, w As Integer, bold As Boolean, center As Boolean) As Label
                            Dim lbl As New Label()
                            With lbl
                                .Text = txt
                                .AutoSize = False
                                .Width = w
                                .Height = rowPanel.Height
                                .Location = New Point(x, 0)
                                .TextAlign = If(center, ContentAlignment.MiddleCenter, ContentAlignment.MiddleLeft)
                                .Font = New Font("Segoe UI", 10, If(bold, FontStyle.Bold, FontStyle.Regular))
                                .ForeColor = Color.Black
                                .BackColor = Color.Transparent
                                .Padding = New Padding(5, 0, 5, 0)
                            End With
                            Return lbl
                        End Function

        Dim colLine As Integer = 100
        Dim colModel As Integer = 200
        Dim colPlan As Integer = 80
        Dim colTarget As Integer = 80
        Dim colActual As Integer = 80
        Dim colProgress As Integer = 200

        rowPanel.Controls.Add(makeLabel(line, 5, colLine, True, True))
        rowPanel.Controls.Add(makeLabel(partcodemodel, 5 + colLine + 1, colModel, False, False))
        rowPanel.Controls.Add(makeLabel(plan, 5 + colLine + colModel + 2, colPlan, False, True))
        rowPanel.Controls.Add(makeLabel(Target, 5 + colLine + colModel + colPlan + 3, colTarget, False, True))

        Dim lblActual = makeLabel(actual, 5 + colLine + colModel + colPlan + colTarget + 4, colActual, True, True)
        lblActual.ForeColor = If(CInt(actual) >= CInt(plan), Color.SeaGreen, Color.IndianRed)
        rowPanel.Controls.Add(lblActual)

        Dim progress As New Guna2ProgressBar()
        With progress
            .Width = colProgress - 10
            .Height = 20
            .Location = New Point(5 + colLine + colModel + colPlan + colTarget + colActual + 6, (rowPanel.Height - .Height) \ 2)
            .Maximum = CInt(plan)
            .Value = Math.Min(CInt(actual), CInt(plan))
            .BorderRadius = 8
            .FillColor = Color.LightGray
            .ProgressColor = If(CInt(actual) >= CInt(plan), Color.SeaGreen, Color.OrangeRed)
            .ProgressColor2 = Color.DodgerBlue
            .GradientMode = Drawing2D.LinearGradientMode.Horizontal
        End With
        rowPanel.Controls.Add(progress)

        Return rowPanel
    End Function


    ' --- Clone of fgCard but returns Panel ---
    Private Function fgCardClone(line As String, partcodemodel As String, plan As String, Target As String, actual As String, id As String) As Guna2GradientPanel
        Dim cardPanel As New Guna2GradientPanel()
        With cardPanel
            .Width = (Screen.PrimaryScreen.Bounds.Width - 100) / 6.3
            .Height = Screen.PrimaryScreen.Bounds.Height / 10.3
            .FillColor = Color.White
            .FillColor2 = If(CInt(actual) >= CInt(plan), Color.LightGreen, Color.LightGray)
            .GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
            .Margin = New Padding(2)
            .BorderThickness = 2
            .BorderRadius = 20
            .BorderColor = Color.White
            .ShadowDecoration.Enabled = True
            .ShadowDecoration.Depth = 10
            .ShadowDecoration.BorderRadius = 23
        End With

        ' (same inner content as fgCard, no need to rewrite everything)
        ' You can reuse your existing fgCard’s control setup here if needed.

        Return cardPanel
    End Function


    Private Sub overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub dtpicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker1.ValueChanged, Guna2RadioButton1.CheckedChanged, Guna2RadioButton2.CheckedChanged
        loadOUTPUT()     ' for FlowLayoutPanel1 (SCANNER)
        loadOUTPUTADF()  ' for FlowLayoutPanel2 (ADF)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadOUTPUT()     ' for FlowLayoutPanel1 (SCANNER)
        loadOUTPUTADF()  ' for FlowLayoutPanel2 (ADF)

        ' Reset progress when refresh happens
        Guna2CircleProgressBar1.Value = 60
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Increment progress until it reaches max
        If Guna2CircleProgressBar1.Value > 0 Then
            Guna2CircleProgressBar1.Value -= 1
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        viewing = Not viewing
        loadOUTPUT()     ' for FlowLayoutPanel1 (SCANNER)
        loadOUTPUTADF()  ' for FlowLayoutPanel2 (ADF)

    End Sub

End Class
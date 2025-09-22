<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(overview))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2VSeparator2 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.btn_view = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2VSeparator2)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_view)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2CircleProgressBar1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2GradientPanel1.Controls.Add(Me.dtpicker1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1259, 63)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2CircleProgressBar1
        '
        Me.Guna2CircleProgressBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2CircleProgressBar1.FillThickness = 10
        Me.Guna2CircleProgressBar1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2CircleProgressBar1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Guna2CircleProgressBar1.Location = New System.Drawing.Point(1196, 0)
        Me.Guna2CircleProgressBar1.Maximum = 60
        Me.Guna2CircleProgressBar1.Minimum = 0
        Me.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.ProgressThickness = 10
        Me.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar1.ShowText = True
        Me.Guna2CircleProgressBar1.Size = New System.Drawing.Size(63, 63)
        Me.Guna2CircleProgressBar1.TabIndex = 37
        Me.Guna2CircleProgressBar1.Text = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value
        Me.Guna2CircleProgressBar1.Value = 60
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel4.BorderRadius = 8
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.Guna2VSeparator1)
        Me.Guna2Panel4.Controls.Add(Me.Guna2RadioButton2)
        Me.Guna2Panel4.Controls.Add(Me.Guna2RadioButton1)
        Me.Guna2Panel4.Location = New System.Drawing.Point(468, 6)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(239, 51)
        Me.Guna2Panel4.TabIndex = 36
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(114, 5)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 41)
        Me.Guna2VSeparator1.TabIndex = 29
        '
        'Guna2RadioButton2
        '
        Me.Guna2RadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2RadioButton2.AutoSize = True
        Me.Guna2RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.Guna2RadioButton2.Location = New System.Drawing.Point(145, 5)
        Me.Guna2RadioButton2.Name = "Guna2RadioButton2"
        Me.Guna2RadioButton2.Size = New System.Drawing.Size(71, 41)
        Me.Guna2RadioButton2.TabIndex = 28
        Me.Guna2RadioButton2.Text = "NS"
        Me.Guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton2.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UseVisualStyleBackColor = False
        '
        'Guna2RadioButton1
        '
        Me.Guna2RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2RadioButton1.AutoSize = True
        Me.Guna2RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.Checked = True
        Me.Guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.BorderThickness = 3
        Me.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2RadioButton1.Location = New System.Drawing.Point(22, 5)
        Me.Guna2RadioButton1.Name = "Guna2RadioButton1"
        Me.Guna2RadioButton1.Size = New System.Drawing.Size(69, 41)
        Me.Guna2RadioButton1.TabIndex = 27
        Me.Guna2RadioButton1.TabStop = True
        Me.Guna2RadioButton1.Text = "DS"
        Me.Guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton1.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UseVisualStyleBackColor = False
        '
        'dtpicker1
        '
        Me.dtpicker1.BackColor = System.Drawing.Color.Transparent
        Me.dtpicker1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtpicker1.BorderRadius = 8
        Me.dtpicker1.BorderThickness = 1
        Me.dtpicker1.Checked = True
        Me.dtpicker1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.dtpicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker1.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.dtpicker1.Location = New System.Drawing.Point(12, 6)
        Me.dtpicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(428, 51)
        Me.dtpicker1.TabIndex = 34
        Me.dtpicker1.Value = New Date(2025, 8, 13, 9, 22, 27, 105)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 63)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1259, 612)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Guna2VSeparator2
        '
        Me.Guna2VSeparator2.Location = New System.Drawing.Point(744, 8)
        Me.Guna2VSeparator2.Name = "Guna2VSeparator2"
        Me.Guna2VSeparator2.Size = New System.Drawing.Size(10, 47)
        Me.Guna2VSeparator2.TabIndex = 39
        '
        'btn_view
        '
        Me.btn_view.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_view.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_view.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_view.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_view.FillColor = System.Drawing.Color.Transparent
        Me.btn_view.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_view.ForeColor = System.Drawing.Color.White
        Me.btn_view.Image = CType(resources.GetObject("btn_view.Image"), System.Drawing.Image)
        Me.btn_view.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_view.Location = New System.Drawing.Point(772, 11)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(40, 40)
        Me.btn_view.TabIndex = 38
        '
        'overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 675)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "overview"
        Me.Text = "Overview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btn_view As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2VSeparator2 As Guna.UI2.WinForms.Guna2VSeparator
End Class

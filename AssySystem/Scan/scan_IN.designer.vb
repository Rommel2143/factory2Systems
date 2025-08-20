<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scan_IN
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scan_IN))
        Me.lbl_plan = New System.Windows.Forms.Label()
        Me.lbl_actual = New System.Windows.Forms.Label()
        Me.lbl_qctimer = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cycle = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_output = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_modelcode = New System.Windows.Forms.Label()
        Me.lbl_line = New System.Windows.Forms.Label()
        Me.lbl_targettime = New System.Windows.Forms.Label()
        Me.panel_scan = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_box = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_cycleplan = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_spq = New System.Windows.Forms.Label()
        Me.lbl_partname = New System.Windows.Forms.Label()
        Me.lbl_partcode = New System.Windows.Forms.Label()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox5 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.panel_select = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2GroupBox7 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lbl_hours = New System.Windows.Forms.Label()
        Me.btn_select = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_barcode = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.panel_scan.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.Guna2GroupBox5.SuspendLayout()
        Me.panel_select.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_plan
        '
        Me.lbl_plan.AutoSize = True
        Me.lbl_plan.BackColor = System.Drawing.Color.Transparent
        Me.lbl_plan.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plan.ForeColor = System.Drawing.Color.Black
        Me.lbl_plan.Location = New System.Drawing.Point(16, 45)
        Me.lbl_plan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_plan.Name = "lbl_plan"
        Me.lbl_plan.Size = New System.Drawing.Size(56, 45)
        Me.lbl_plan.TabIndex = 15
        Me.lbl_plan.Text = "00"
        '
        'lbl_actual
        '
        Me.lbl_actual.AutoSize = True
        Me.lbl_actual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_actual.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_actual.ForeColor = System.Drawing.Color.Black
        Me.lbl_actual.Location = New System.Drawing.Point(21, 79)
        Me.lbl_actual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_actual.Name = "lbl_actual"
        Me.lbl_actual.Size = New System.Drawing.Size(56, 45)
        Me.lbl_actual.TabIndex = 17
        Me.lbl_actual.Text = "00"
        '
        'lbl_qctimer
        '
        Me.lbl_qctimer.AutoSize = True
        Me.lbl_qctimer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_qctimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qctimer.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbl_qctimer.Location = New System.Drawing.Point(20, 43)
        Me.lbl_qctimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_qctimer.Name = "lbl_qctimer"
        Me.lbl_qctimer.Size = New System.Drawing.Size(106, 73)
        Me.lbl_qctimer.TabIndex = 19
        Me.lbl_qctimer.Text = "00"
        Me.lbl_qctimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(28, 16)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "QC Timer"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagrid1.ColumnHeadersHeight = 28
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle7
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(26, 82)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.Size = New System.Drawing.Size(285, 454)
        Me.datagrid1.TabIndex = 20
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid1.ThemeStyle.HeaderStyle.Height = 28
        Me.datagrid1.ThemeStyle.ReadOnly = False
        Me.datagrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.BackColor = System.Drawing.Color.Transparent
        Me.lbl_model.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_model.ForeColor = System.Drawing.Color.Black
        Me.lbl_model.Location = New System.Drawing.Point(19, 153)
        Me.lbl_model.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(48, 25)
        Me.lbl_model.TabIndex = 22
        Me.lbl_model.Text = "N/A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(20, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Model"
        '
        'lbl_cycle
        '
        Me.lbl_cycle.AutoSize = True
        Me.lbl_cycle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cycle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cycle.ForeColor = System.Drawing.Color.Black
        Me.lbl_cycle.Location = New System.Drawing.Point(21, 166)
        Me.lbl_cycle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cycle.Name = "lbl_cycle"
        Me.lbl_cycle.Size = New System.Drawing.Size(65, 45)
        Me.lbl_cycle.TabIndex = 24
        Me.lbl_cycle.Text = "0.0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(19, 54)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 21)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Expected Output"
        '
        'lbl_output
        '
        Me.lbl_output.AutoSize = True
        Me.lbl_output.BackColor = System.Drawing.Color.Transparent
        Me.lbl_output.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_output.ForeColor = System.Drawing.Color.Black
        Me.lbl_output.Location = New System.Drawing.Point(19, 79)
        Me.lbl_output.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_output.Name = "lbl_output"
        Me.lbl_output.Size = New System.Drawing.Size(38, 45)
        Me.lbl_output.TabIndex = 24
        Me.lbl_output.Text = "0"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.BorderThickness = 5
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.Controls.Add(Me.lbl_qctimer)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Black
        Me.Guna2Panel1.Location = New System.Drawing.Point(333, 266)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(146, 132)
        Me.Guna2Panel1.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(214, 132)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 21)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "MCode"
        '
        'lbl_modelcode
        '
        Me.lbl_modelcode.AutoSize = True
        Me.lbl_modelcode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_modelcode.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modelcode.ForeColor = System.Drawing.Color.Black
        Me.lbl_modelcode.Location = New System.Drawing.Point(213, 153)
        Me.lbl_modelcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_modelcode.Name = "lbl_modelcode"
        Me.lbl_modelcode.Size = New System.Drawing.Size(48, 25)
        Me.lbl_modelcode.TabIndex = 29
        Me.lbl_modelcode.Text = "N/A"
        '
        'lbl_line
        '
        Me.lbl_line.AutoSize = True
        Me.lbl_line.BackColor = System.Drawing.Color.Transparent
        Me.lbl_line.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_line.ForeColor = System.Drawing.Color.Black
        Me.lbl_line.Location = New System.Drawing.Point(19, 41)
        Me.lbl_line.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_line.Name = "lbl_line"
        Me.lbl_line.Size = New System.Drawing.Size(79, 45)
        Me.lbl_line.TabIndex = 30
        Me.lbl_line.Text = "N/A"
        '
        'lbl_targettime
        '
        Me.lbl_targettime.AutoSize = True
        Me.lbl_targettime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_targettime.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_targettime.ForeColor = System.Drawing.Color.Black
        Me.lbl_targettime.Location = New System.Drawing.Point(20, 41)
        Me.lbl_targettime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_targettime.Name = "lbl_targettime"
        Me.lbl_targettime.Size = New System.Drawing.Size(106, 73)
        Me.lbl_targettime.TabIndex = 26
        Me.lbl_targettime.Text = "00"
        '
        'panel_scan
        '
        Me.panel_scan.BackColor = System.Drawing.Color.Transparent
        Me.panel_scan.BorderColor = System.Drawing.Color.Gray
        Me.panel_scan.BorderRadius = 8
        Me.panel_scan.BorderThickness = 1
        Me.panel_scan.Controls.Add(Me.Guna2Panel3)
        Me.panel_scan.Controls.Add(Me.Guna2Panel2)
        Me.panel_scan.Controls.Add(Me.Label14)
        Me.panel_scan.Controls.Add(Me.Guna2Button2)
        Me.panel_scan.Controls.Add(Me.txt_barcode)
        Me.panel_scan.Controls.Add(Me.datagrid1)
        Me.panel_scan.Controls.Add(Me.Guna2Panel1)
        Me.panel_scan.Enabled = False
        Me.panel_scan.FillColor = System.Drawing.Color.White
        Me.panel_scan.Location = New System.Drawing.Point(503, 132)
        Me.panel_scan.Name = "panel_scan"
        Me.panel_scan.ShadowDecoration.BorderRadius = 10
        Me.panel_scan.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.panel_scan.ShadowDecoration.Enabled = True
        Me.panel_scan.Size = New System.Drawing.Size(514, 659)
        Me.panel_scan.TabIndex = 33
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel3.BorderRadius = 15
        Me.Guna2Panel3.BorderThickness = 5
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Controls.Add(Me.lbl_box)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(333, 25)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(146, 226)
        Me.Guna2Panel3.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Items in Box"
        '
        'lbl_box
        '
        Me.lbl_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_box.AutoSize = True
        Me.lbl_box.BackColor = System.Drawing.Color.Transparent
        Me.lbl_box.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_box.ForeColor = System.Drawing.Color.White
        Me.lbl_box.Location = New System.Drawing.Point(18, 49)
        Me.lbl_box.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_box.Name = "lbl_box"
        Me.lbl_box.Size = New System.Drawing.Size(110, 128)
        Me.lbl_box.TabIndex = 26
        Me.lbl_box.Text = "0"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.BorderThickness = 5
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.lbl_targettime)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel2.Location = New System.Drawing.Point(333, 404)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(146, 132)
        Me.Guna2Panel2.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Target Timer"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(35, 611)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(444, 34)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "** REMINDER : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click 'Pause' whenever there's downtime or when you're about to t" &
    "ake a break."
        '
        'lbl_cycleplan
        '
        Me.lbl_cycleplan.AutoSize = True
        Me.lbl_cycleplan.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cycleplan.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cycleplan.ForeColor = System.Drawing.Color.Black
        Me.lbl_cycleplan.Location = New System.Drawing.Point(19, 166)
        Me.lbl_cycleplan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cycleplan.Name = "lbl_cycleplan"
        Me.lbl_cycleplan.Size = New System.Drawing.Size(38, 45)
        Me.lbl_cycleplan.TabIndex = 24
        Me.lbl_cycleplan.Text = "0"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox1.BorderRadius = 8
        Me.Guna2GroupBox1.Controls.Add(Me.lbl_line)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 132)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 10
        Me.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(451, 100)
        Me.Guna2GroupBox1.TabIndex = 34
        Me.Guna2GroupBox1.Text = "PRODUCTION LINE"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox2.BorderRadius = 8
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.lbl_spq)
        Me.Guna2GroupBox2.Controls.Add(Me.lbl_partname)
        Me.Guna2GroupBox2.Controls.Add(Me.lbl_partcode)
        Me.Guna2GroupBox2.Controls.Add(Me.Label11)
        Me.Guna2GroupBox2.Controls.Add(Me.Label3)
        Me.Guna2GroupBox2.Controls.Add(Me.lbl_modelcode)
        Me.Guna2GroupBox2.Controls.Add(Me.lbl_model)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(12, 240)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.BorderRadius = 10
        Me.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GroupBox2.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(451, 202)
        Me.Guna2GroupBox2.TabIndex = 35
        Me.Guna2GroupBox2.Text = "ITEM / MODEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(346, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 21)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "SPQ"
        '
        'lbl_spq
        '
        Me.lbl_spq.AutoSize = True
        Me.lbl_spq.BackColor = System.Drawing.Color.Transparent
        Me.lbl_spq.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_spq.ForeColor = System.Drawing.Color.Black
        Me.lbl_spq.Location = New System.Drawing.Point(345, 153)
        Me.lbl_spq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_spq.Name = "lbl_spq"
        Me.lbl_spq.Size = New System.Drawing.Size(48, 25)
        Me.lbl_spq.TabIndex = 36
        Me.lbl_spq.Text = "N/A"
        '
        'lbl_partname
        '
        Me.lbl_partname.AutoSize = True
        Me.lbl_partname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_partname.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partname.ForeColor = System.Drawing.Color.Black
        Me.lbl_partname.Location = New System.Drawing.Point(19, 51)
        Me.lbl_partname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_partname.Name = "lbl_partname"
        Me.lbl_partname.Size = New System.Drawing.Size(62, 32)
        Me.lbl_partname.TabIndex = 34
        Me.lbl_partname.Text = "N/A"
        '
        'lbl_partcode
        '
        Me.lbl_partcode.AutoSize = True
        Me.lbl_partcode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_partcode.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partcode.ForeColor = System.Drawing.Color.Black
        Me.lbl_partcode.Location = New System.Drawing.Point(19, 83)
        Me.lbl_partcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_partcode.Name = "lbl_partcode"
        Me.lbl_partcode.Size = New System.Drawing.Size(62, 32)
        Me.lbl_partcode.TabIndex = 33
        Me.lbl_partcode.Text = "N/A"
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox3.BorderRadius = 8
        Me.Guna2GroupBox3.Controls.Add(Me.Label4)
        Me.Guna2GroupBox3.Controls.Add(Me.Label10)
        Me.Guna2GroupBox3.Controls.Add(Me.lbl_cycleplan)
        Me.Guna2GroupBox3.Controls.Add(Me.lbl_output)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(12, 554)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.BorderRadius = 10
        Me.Guna2GroupBox3.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GroupBox3.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(221, 237)
        Me.Guna2GroupBox3.TabIndex = 35
        Me.Guna2GroupBox3.Text = "TARGET"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(19, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Expected Cycle Time"
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox4.BorderRadius = 8
        Me.Guna2GroupBox4.Controls.Add(Me.Label13)
        Me.Guna2GroupBox4.Controls.Add(Me.lbl_cycle)
        Me.Guna2GroupBox4.Controls.Add(Me.lbl_actual)
        Me.Guna2GroupBox4.Controls.Add(Me.Label15)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(242, 554)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.ShadowDecoration.BorderRadius = 10
        Me.Guna2GroupBox4.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GroupBox4.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(221, 237)
        Me.Guna2GroupBox4.TabIndex = 36
        Me.Guna2GroupBox4.Text = "ACTUAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(24, 145)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 21)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Actual Cycle Time"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(24, 54)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 21)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Actual Output"
        '
        'Guna2GroupBox5
        '
        Me.Guna2GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox5.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox5.BorderRadius = 8
        Me.Guna2GroupBox5.Controls.Add(Me.lbl_plan)
        Me.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GroupBox5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox5.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox5.Location = New System.Drawing.Point(12, 448)
        Me.Guna2GroupBox5.Name = "Guna2GroupBox5"
        Me.Guna2GroupBox5.ShadowDecoration.BorderRadius = 10
        Me.Guna2GroupBox5.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GroupBox5.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox5.Size = New System.Drawing.Size(221, 100)
        Me.Guna2GroupBox5.TabIndex = 35
        Me.Guna2GroupBox5.Text = "OUTPUT PLAN"
        '
        'panel_select
        '
        Me.panel_select.BackColor = System.Drawing.Color.Transparent
        Me.panel_select.BorderColor = System.Drawing.Color.Gray
        Me.panel_select.BorderRadius = 8
        Me.panel_select.Controls.Add(Me.Guna2Panel4)
        Me.panel_select.Controls.Add(Me.dtpicker1)
        Me.panel_select.Controls.Add(Me.btn_select)
        Me.panel_select.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.panel_select.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_select.ForeColor = System.Drawing.Color.White
        Me.panel_select.Location = New System.Drawing.Point(12, 12)
        Me.panel_select.Name = "panel_select"
        Me.panel_select.ShadowDecoration.BorderRadius = 10
        Me.panel_select.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.panel_select.ShadowDecoration.Enabled = True
        Me.panel_select.Size = New System.Drawing.Size(1005, 114)
        Me.panel_select.TabIndex = 35
        Me.panel_select.Text = "DATE & SHIFT"
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
        Me.Guna2Panel4.Location = New System.Drawing.Point(479, 50)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(239, 51)
        Me.Guna2Panel4.TabIndex = 33
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
        Me.Guna2RadioButton2.Location = New System.Drawing.Point(144, 3)
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
        Me.Guna2RadioButton1.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2RadioButton1.Location = New System.Drawing.Point(21, 1)
        Me.Guna2RadioButton1.Name = "Guna2RadioButton1"
        Me.Guna2RadioButton1.Size = New System.Drawing.Size(81, 49)
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
        Me.dtpicker1.Location = New System.Drawing.Point(23, 50)
        Me.dtpicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(428, 51)
        Me.dtpicker1.TabIndex = 32
        Me.dtpicker1.Value = New Date(2025, 8, 13, 9, 22, 27, 105)
        '
        'Guna2GroupBox7
        '
        Me.Guna2GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox7.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox7.BorderRadius = 8
        Me.Guna2GroupBox7.Controls.Add(Me.lbl_hours)
        Me.Guna2GroupBox7.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GroupBox7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox7.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox7.Location = New System.Drawing.Point(242, 448)
        Me.Guna2GroupBox7.Name = "Guna2GroupBox7"
        Me.Guna2GroupBox7.ShadowDecoration.BorderRadius = 10
        Me.Guna2GroupBox7.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GroupBox7.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox7.Size = New System.Drawing.Size(221, 100)
        Me.Guna2GroupBox7.TabIndex = 36
        Me.Guna2GroupBox7.Text = "DURATION"
        '
        'lbl_hours
        '
        Me.lbl_hours.AutoSize = True
        Me.lbl_hours.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hours.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hours.ForeColor = System.Drawing.Color.Black
        Me.lbl_hours.Location = New System.Drawing.Point(16, 45)
        Me.lbl_hours.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_hours.Name = "lbl_hours"
        Me.lbl_hours.Size = New System.Drawing.Size(56, 45)
        Me.lbl_hours.TabIndex = 15
        Me.lbl_hours.Text = "00"
        '
        'btn_select
        '
        Me.btn_select.AutoRoundedCorners = True
        Me.btn_select.BackColor = System.Drawing.Color.Transparent
        Me.btn_select.BorderRadius = 24
        Me.btn_select.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_select.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_select.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_select.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_select.FillColor = System.Drawing.Color.ForestGreen
        Me.btn_select.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.btn_select.ForeColor = System.Drawing.Color.White
        Me.btn_select.Image = CType(resources.GetObject("btn_select.Image"), System.Drawing.Image)
        Me.btn_select.ImageOffset = New System.Drawing.Point(-2, 0)
        Me.btn_select.ImageSize = New System.Drawing.Size(38, 38)
        Me.btn_select.Location = New System.Drawing.Point(824, 50)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_select.Size = New System.Drawing.Size(146, 51)
        Me.btn_select.TabIndex = 32
        Me.btn_select.Text = "Select FG"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 24
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.ForestGreen
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageOffset = New System.Drawing.Point(-10, 0)
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Button2.Location = New System.Drawing.Point(71, 549)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(195, 50)
        Me.Guna2Button2.TabIndex = 29
        Me.Guna2Button2.Text = "START"
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(-2, -3)
        Me.Guna2Button2.UseTransparentBackground = True
        '
        'txt_barcode
        '
        Me.txt_barcode.BackColor = System.Drawing.Color.White
        Me.txt_barcode.BorderColor = System.Drawing.Color.ForestGreen
        Me.txt_barcode.BorderRadius = 10
        Me.txt_barcode.BorderThickness = 3
        Me.txt_barcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_barcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_barcode.DefaultText = ""
        Me.txt_barcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_barcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_barcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_barcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_barcode.Enabled = False
        Me.txt_barcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_barcode.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_barcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_barcode.IconLeft = CType(resources.GetObject("txt_barcode.IconLeft"), System.Drawing.Image)
        Me.txt_barcode.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txt_barcode.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txt_barcode.Location = New System.Drawing.Point(26, 25)
        Me.txt_barcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_barcode.PlaceholderText = "Scan FG Barcode..."
        Me.txt_barcode.SelectedText = ""
        Me.txt_barcode.Size = New System.Drawing.Size(285, 50)
        Me.txt_barcode.TabIndex = 9
        '
        'scan_IN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1215, 801)
        Me.Controls.Add(Me.Guna2GroupBox7)
        Me.Controls.Add(Me.panel_select)
        Me.Controls.Add(Me.Guna2GroupBox5)
        Me.Controls.Add(Me.Guna2GroupBox4)
        Me.Controls.Add(Me.panel_scan)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "scan_IN"
        Me.Text = "SCAN ITEM BARCODE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.panel_scan.ResumeLayout(False)
        Me.panel_scan.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        Me.Guna2GroupBox5.ResumeLayout(False)
        Me.Guna2GroupBox5.PerformLayout()
        Me.panel_select.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2GroupBox7.ResumeLayout(False)
        Me.Guna2GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_barcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_plan As Label
    Friend WithEvents lbl_actual As Label
    Friend WithEvents lbl_qctimer As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lbl_model As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_cycle As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_output As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_targettime As Label
    Friend WithEvents panel_scan As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_modelcode As Label
    Friend WithEvents lbl_line As Label
    Friend WithEvents lbl_cycleplan As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox5 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_box As Label
    Friend WithEvents btn_select As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_partname As Label
    Friend WithEvents lbl_partcode As Label
    Friend WithEvents panel_select As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2GroupBox7 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lbl_hours As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_spq As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
End Class

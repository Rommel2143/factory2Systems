<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItem
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_modelcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_model = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_partname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_partcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_located = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.numSPQ = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.numPlan = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.numSPQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 319)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Box Qty (SPQ)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(383, 319)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Suggested Plan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(383, 236)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Model Code"
        '
        'txt_modelcode
        '
        Me.txt_modelcode.BackColor = System.Drawing.Color.Transparent
        Me.txt_modelcode.BorderColor = System.Drawing.Color.Silver
        Me.txt_modelcode.BorderRadius = 5
        Me.txt_modelcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_modelcode.DefaultText = ""
        Me.txt_modelcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_modelcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_modelcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_modelcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_modelcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_modelcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_modelcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_modelcode.Location = New System.Drawing.Point(386, 256)
        Me.txt_modelcode.Name = "txt_modelcode"
        Me.txt_modelcode.PlaceholderText = "..."
        Me.txt_modelcode.SelectedText = ""
        Me.txt_modelcode.Size = New System.Drawing.Size(234, 38)
        Me.txt_modelcode.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 236)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Model"
        '
        'txt_model
        '
        Me.txt_model.BackColor = System.Drawing.Color.Transparent
        Me.txt_model.BorderColor = System.Drawing.Color.Silver
        Me.txt_model.BorderRadius = 5
        Me.txt_model.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_model.DefaultText = ""
        Me.txt_model.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_model.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_model.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_model.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_model.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_model.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_model.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_model.Location = New System.Drawing.Point(38, 256)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.PlaceholderText = "..."
        Me.txt_model.SelectedText = ""
        Me.txt_model.Size = New System.Drawing.Size(342, 38)
        Me.txt_model.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 161)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Partname"
        '
        'txt_partname
        '
        Me.txt_partname.BackColor = System.Drawing.Color.Transparent
        Me.txt_partname.BorderColor = System.Drawing.Color.Silver
        Me.txt_partname.BorderRadius = 5
        Me.txt_partname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_partname.DefaultText = ""
        Me.txt_partname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_partname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_partname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_partname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_partname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_partname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_partname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_partname.Location = New System.Drawing.Point(283, 181)
        Me.txt_partname.Name = "txt_partname"
        Me.txt_partname.PlaceholderText = "..."
        Me.txt_partname.SelectedText = ""
        Me.txt_partname.Size = New System.Drawing.Size(337, 38)
        Me.txt_partname.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 161)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Partcode"
        '
        'txt_partcode
        '
        Me.txt_partcode.BackColor = System.Drawing.Color.Transparent
        Me.txt_partcode.BorderColor = System.Drawing.Color.Silver
        Me.txt_partcode.BorderRadius = 5
        Me.txt_partcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_partcode.DefaultText = ""
        Me.txt_partcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_partcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_partcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_partcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_partcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_partcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_partcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_partcode.Location = New System.Drawing.Point(38, 181)
        Me.txt_partcode.Name = "txt_partcode"
        Me.txt_partcode.PlaceholderText = "..."
        Me.txt_partcode.SelectedText = ""
        Me.txt_partcode.Size = New System.Drawing.Size(239, 38)
        Me.txt_partcode.TabIndex = 24
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.BorderRadius = 3
        Me.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_save.FillColor = System.Drawing.Color.ForestGreen
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(86, 447)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(222, 38)
        Me.btn_save.TabIndex = 30
        Me.btn_save.Text = "Save"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Location"
        '
        'cmb_located
        '
        Me.cmb_located.BackColor = System.Drawing.Color.Transparent
        Me.cmb_located.BorderRadius = 5
        Me.cmb_located.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_located.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_located.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_located.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_located.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_located.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_located.ItemHeight = 30
        Me.cmb_located.Items.AddRange(New Object() {"SCANNER", "ADF"})
        Me.cmb_located.Location = New System.Drawing.Point(36, 98)
        Me.cmb_located.Name = "cmb_located"
        Me.cmb_located.Size = New System.Drawing.Size(241, 36)
        Me.cmb_located.TabIndex = 37
        '
        'numSPQ
        '
        Me.numSPQ.BackColor = System.Drawing.Color.Transparent
        Me.numSPQ.BorderRadius = 5
        Me.numSPQ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numSPQ.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSPQ.Location = New System.Drawing.Point(38, 341)
        Me.numSPQ.Name = "numSPQ"
        Me.numSPQ.Size = New System.Drawing.Size(173, 43)
        Me.numSPQ.TabIndex = 39
        '
        'numPlan
        '
        Me.numPlan.BackColor = System.Drawing.Color.Transparent
        Me.numPlan.BorderRadius = 5
        Me.numPlan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numPlan.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPlan.Location = New System.Drawing.Point(386, 341)
        Me.numPlan.Name = "numPlan"
        Me.numPlan.Size = New System.Drawing.Size(162, 43)
        Me.numPlan.TabIndex = 40
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2Button1.BorderRadius = 3
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Gray
        Me.Guna2Button1.Location = New System.Drawing.Point(355, 447)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(222, 38)
        Me.Guna2Button1.TabIndex = 41
        Me.Guna2Button1.Text = "Cancel"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 30)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Add new item"
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 522)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.numPlan)
        Me.Controls.Add(Me.numSPQ)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_located)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_modelcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_partname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_partcode)
        Me.Controls.Add(Me.btn_save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddItem"
        Me.Text = "AddItem"
        CType(Me.numSPQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_modelcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_model As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_partname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_partcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_located As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents numSPQ As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents numPlan As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label8 As Label
End Class

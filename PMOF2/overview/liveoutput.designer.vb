<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class liveoutput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(liveoutput))
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_cycle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_actual = New System.Windows.Forms.Label()
        Me.lbl_target = New System.Windows.Forms.Label()
        Me.lbl_output = New System.Windows.Forms.Label()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_CTtarget = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_CTtarget = New System.Windows.Forms.Label()
        Me.radial = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_percent = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_plan = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_CTtarget.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox3)
        Me.Guna2Panel2.Controls.Add(Me.lbl_cycle)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.MistyRose
        Me.Guna2Panel2.Location = New System.Drawing.Point(209, 164)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(89, 33)
        Me.Guna2Panel2.TabIndex = 32
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(32, 33)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 30
        Me.Guna2PictureBox3.TabStop = False
        '
        'lbl_cycle
        '
        Me.lbl_cycle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_cycle.AutoSize = True
        Me.lbl_cycle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cycle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cycle.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_cycle.Location = New System.Drawing.Point(45, 6)
        Me.lbl_cycle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cycle.Name = "lbl_cycle"
        Me.lbl_cycle.Size = New System.Drawing.Size(37, 21)
        Me.lbl_cycle.TabIndex = 28
        Me.lbl_cycle.Text = "000"
        Me.lbl_cycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(16, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ACTUAL"
        '
        'lbl_actual
        '
        Me.lbl_actual.AutoSize = True
        Me.lbl_actual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_actual.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_actual.ForeColor = System.Drawing.Color.Black
        Me.lbl_actual.Location = New System.Drawing.Point(13, 158)
        Me.lbl_actual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_actual.Name = "lbl_actual"
        Me.lbl_actual.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.lbl_actual.Size = New System.Drawing.Size(81, 57)
        Me.lbl_actual.TabIndex = 17
        Me.lbl_actual.Text = "0000"
        '
        'lbl_target
        '
        Me.lbl_target.AutoSize = True
        Me.lbl_target.BackColor = System.Drawing.Color.Transparent
        Me.lbl_target.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_target.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_target.Location = New System.Drawing.Point(16, 82)
        Me.lbl_target.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_target.Name = "lbl_target"
        Me.lbl_target.Size = New System.Drawing.Size(64, 21)
        Me.lbl_target.TabIndex = 23
        Me.lbl_target.Text = "TARGET"
        '
        'lbl_output
        '
        Me.lbl_output.AutoSize = True
        Me.lbl_output.BackColor = System.Drawing.Color.Transparent
        Me.lbl_output.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_output.ForeColor = System.Drawing.Color.Black
        Me.lbl_output.Location = New System.Drawing.Point(10, 82)
        Me.lbl_output.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_output.Name = "lbl_output"
        Me.lbl_output.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.lbl_output.Size = New System.Drawing.Size(81, 57)
        Me.lbl_output.TabIndex = 24
        Me.lbl_output.Text = "0000"
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.BackColor = System.Drawing.Color.Transparent
        Me.lbl_model.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_model.ForeColor = System.Drawing.Color.White
        Me.lbl_model.Location = New System.Drawing.Point(16, 9)
        Me.lbl_model.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_model.MaximumSize = New System.Drawing.Size(182, 0)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(41, 21)
        Me.lbl_model.TabIndex = 22
        Me.lbl_model.Text = "N/A"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'panel_CTtarget
        '
        Me.panel_CTtarget.BorderRadius = 10
        Me.panel_CTtarget.Controls.Add(Me.Guna2PictureBox1)
        Me.panel_CTtarget.Controls.Add(Me.lbl_CTtarget)
        Me.panel_CTtarget.FillColor = System.Drawing.Color.MistyRose
        Me.panel_CTtarget.Location = New System.Drawing.Point(206, 82)
        Me.panel_CTtarget.Name = "panel_CTtarget"
        Me.panel_CTtarget.Size = New System.Drawing.Size(89, 33)
        Me.panel_CTtarget.TabIndex = 31
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(32, 33)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 30
        Me.Guna2PictureBox1.TabStop = False
        '
        'lbl_CTtarget
        '
        Me.lbl_CTtarget.AutoSize = True
        Me.lbl_CTtarget.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CTtarget.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CTtarget.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_CTtarget.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_CTtarget.Location = New System.Drawing.Point(45, 6)
        Me.lbl_CTtarget.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CTtarget.Name = "lbl_CTtarget"
        Me.lbl_CTtarget.Size = New System.Drawing.Size(37, 21)
        Me.lbl_CTtarget.TabIndex = 29
        Me.lbl_CTtarget.Text = "000"
        Me.lbl_CTtarget.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'radial
        '
        Me.radial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radial.Location = New System.Drawing.Point(27, 243)
        Me.radial.Name = "radial"
        Me.radial.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition
        Me.radial.ProgressColor = System.Drawing.Color.Crimson
        Me.radial.ProgressColor2 = System.Drawing.Color.GreenYellow
        Me.radial.ShowText = True
        Me.radial.Size = New System.Drawing.Size(251, 21)
        Me.radial.TabIndex = 27
        Me.radial.Text = "Guna2ProgressBar1"
        Me.radial.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value
        Me.radial.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.radial.Value = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(70, 267)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "LINE PROGRESS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_percent
        '
        Me.lbl_percent.AutoSize = True
        Me.lbl_percent.BackColor = System.Drawing.Color.Transparent
        Me.lbl_percent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_percent.ForeColor = System.Drawing.Color.Black
        Me.lbl_percent.Location = New System.Drawing.Point(202, 267)
        Me.lbl_percent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_percent.Name = "lbl_percent"
        Me.lbl_percent.Size = New System.Drawing.Size(32, 21)
        Me.lbl_percent.TabIndex = 24
        Me.lbl_percent.Text = "0%"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 30
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(229, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 21)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "PLAN"
        '
        'lbl_plan
        '
        Me.lbl_plan.AutoSize = True
        Me.lbl_plan.BackColor = System.Drawing.Color.Transparent
        Me.lbl_plan.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plan.ForeColor = System.Drawing.Color.White
        Me.lbl_plan.Location = New System.Drawing.Point(226, 30)
        Me.lbl_plan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_plan.MaximumSize = New System.Drawing.Size(557, 0)
        Me.lbl_plan.Name = "lbl_plan"
        Me.lbl_plan.Size = New System.Drawing.Size(62, 32)
        Me.lbl_plan.TabIndex = 34
        Me.lbl_plan.Text = "N/A"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_plan)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_model)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(304, 76)
        Me.Guna2GradientPanel1.TabIndex = 35
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(12, 142)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(281, 10)
        Me.Guna2Separator1.TabIndex = 36
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(12, 218)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(281, 10)
        Me.Guna2Separator2.TabIndex = 37
        '
        'liveoutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(304, 313)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.radial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.lbl_percent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panel_CTtarget)
        Me.Controls.Add(Me.lbl_actual)
        Me.Controls.Add(Me.lbl_target)
        Me.Controls.Add(Me.lbl_output)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(304, 313)
        Me.Name = "liveoutput"
        Me.Text = "monitoring"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_CTtarget.ResumeLayout(False)
        Me.panel_CTtarget.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_actual As Label
    Friend WithEvents lbl_target As Label
    Friend WithEvents lbl_output As Label
    Friend WithEvents lbl_model As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_percent As Label
    Friend WithEvents lbl_cycle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panel_CTtarget As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_CTtarget As Label
    Friend WithEvents radial As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lbl_plan As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
End Class

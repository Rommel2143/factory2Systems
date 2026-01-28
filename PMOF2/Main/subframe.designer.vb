<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subframe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subframe))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnmenu_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetPlanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCANNERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.profile_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_user = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_administrator = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_FormName = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btn_profile = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btn_menu = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.AddQAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnmenu_strip.SuspendLayout()
        Me.profile_menu.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(17, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1151, 592)
        Me.Panel1.TabIndex = 7
        '
        'btnmenu_strip
        '
        Me.btnmenu_strip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetPlanToolStripMenuItem, Me.OverviewToolStripMenuItem})
        Me.btnmenu_strip.Name = "ContextMenuStrip1"
        Me.btnmenu_strip.Size = New System.Drawing.Size(191, 56)
        '
        'SetPlanToolStripMenuItem
        '
        Me.SetPlanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SCANNERToolStripMenuItem, Me.ADFToolStripMenuItem})
        Me.SetPlanToolStripMenuItem.Name = "SetPlanToolStripMenuItem"
        Me.SetPlanToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.SetPlanToolStripMenuItem.Text = "Production Plan"
        '
        'SCANNERToolStripMenuItem
        '
        Me.SCANNERToolStripMenuItem.Name = "SCANNERToolStripMenuItem"
        Me.SCANNERToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.SCANNERToolStripMenuItem.Text = "SCANNER"
        '
        'ADFToolStripMenuItem
        '
        Me.ADFToolStripMenuItem.Name = "ADFToolStripMenuItem"
        Me.ADFToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.ADFToolStripMenuItem.Text = "ADF"
        '
        'OverviewToolStripMenuItem
        '
        Me.OverviewToolStripMenuItem.Name = "OverviewToolStripMenuItem"
        Me.OverviewToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.OverviewToolStripMenuItem.Text = "Overview"
        '
        'profile_menu
        '
        Me.profile_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_user, Me.ToolStripSeparator1, Me.ToolStripMenuItem1, Me.btn_administrator, Me.LogoutToolStripMenuItem})
        Me.profile_menu.Name = "ContextMenuStrip1"
        Me.profile_menu.Size = New System.Drawing.Size(189, 152)
        '
        'btn_user
        '
        Me.btn_user.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem})
        Me.btn_user.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_user.ForeColor = System.Drawing.Color.Black
        Me.btn_user.Image = CType(resources.GetObject("btn_user.Image"), System.Drawing.Image)
        Me.btn_user.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(188, 30)
        Me.btn_user.Text = "User"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 30)
        Me.ToolStripMenuItem1.Text = "Add Item"
        '
        'btn_administrator
        '
        Me.btn_administrator.BackColor = System.Drawing.Color.MistyRose
        Me.btn_administrator.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ManageUsersToolStripMenuItem, Me.AddQAToolStripMenuItem})
        Me.btn_administrator.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_administrator.ForeColor = System.Drawing.Color.DimGray
        Me.btn_administrator.Image = CType(resources.GetObject("btn_administrator.Image"), System.Drawing.Image)
        Me.btn_administrator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_administrator.Name = "btn_administrator"
        Me.btn_administrator.Size = New System.Drawing.Size(188, 30)
        Me.btn_administrator.Text = "Administrator"
        Me.btn_administrator.Visible = False
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'lbl_FormName
        '
        Me.lbl_FormName.AutoSize = True
        Me.lbl_FormName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FormName.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FormName.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_FormName.Location = New System.Drawing.Point(116, 12)
        Me.lbl_FormName.Name = "lbl_FormName"
        Me.lbl_FormName.Size = New System.Drawing.Size(118, 30)
        Me.lbl_FormName.TabIndex = 9
        Me.lbl_FormName.Text = "Dashboard"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(17, 602)
        Me.Guna2Panel2.TabIndex = 9
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 655)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1168, 20)
        Me.Guna2Panel3.TabIndex = 10
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_FormName)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_profile)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_menu)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2GradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.Control
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1168, 53)
        Me.Guna2GradientPanel1.TabIndex = 12
        '
        'btn_profile
        '
        Me.btn_profile.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_profile.BackColor = System.Drawing.Color.Transparent
        Me.btn_profile.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_profile.ContextMenuStrip = Me.profile_menu
        Me.btn_profile.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btn_profile.HoverState.ImageSize = New System.Drawing.Size(33, 33)
        Me.btn_profile.Image = CType(resources.GetObject("btn_profile.Image"), System.Drawing.Image)
        Me.btn_profile.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_profile.ImageRotate = 0!
        Me.btn_profile.ImageSize = New System.Drawing.Size(32, 32)
        Me.btn_profile.Location = New System.Drawing.Point(1121, 10)
        Me.btn_profile.Name = "btn_profile"
        Me.btn_profile.PressedState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btn_profile.PressedState.ImageSize = New System.Drawing.Size(31, 31)
        Me.btn_profile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_profile.Size = New System.Drawing.Size(35, 32)
        Me.btn_profile.TabIndex = 4
        Me.btn_profile.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(17, 8)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(50, 34)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 11
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_menu.ContextMenuStrip = Me.btnmenu_strip
        Me.btn_menu.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.btn_menu.HoverState.ImageSize = New System.Drawing.Size(33, 33)
        Me.btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), System.Drawing.Image)
        Me.btn_menu.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_menu.ImageRotate = 0!
        Me.btn_menu.ImageSize = New System.Drawing.Size(32, 32)
        Me.btn_menu.Location = New System.Drawing.Point(75, 10)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.PressedState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.btn_menu.PressedState.ImageSize = New System.Drawing.Size(31, 31)
        Me.btn_menu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_menu.Size = New System.Drawing.Size(35, 32)
        Me.btn_menu.TabIndex = 5
        Me.btn_menu.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(17, 53)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1151, 10)
        Me.Guna2Panel1.TabIndex = 13
        '
        'AddQAToolStripMenuItem
        '
        Me.AddQAToolStripMenuItem.Name = "AddQAToolStripMenuItem"
        Me.AddQAToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AddQAToolStripMenuItem.Text = "Add QA"
        '
        'subframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 675)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "subframe"
        Me.Text = "subframe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.btnmenu_strip.ResumeLayout(False)
        Me.profile_menu.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents profile_menu As ContextMenuStrip
    Friend WithEvents btn_administrator As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnmenu_strip As ContextMenuStrip
    Friend WithEvents btn_user As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_FormName As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btn_menu As Guna.UI2.WinForms.Guna2ImageButton
    Private WithEvents btn_profile As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SetPlanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SCANNERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddQAToolStripMenuItem As ToolStripMenuItem
End Class

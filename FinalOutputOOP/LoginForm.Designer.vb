<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlLogin = New FlowLayoutPanel()
        pnlSpacer1 = New Panel()
        btnClose = New Guna.UI2.WinForms.Guna2ControlBox()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        txtPassdword = New Guna.UI2.WinForms.Guna2TextBox()
        btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        btnCreateAccount = New Guna.UI2.WinForms.Guna2Button()
        Panel1 = New Panel()
        lblForgot = New Label()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        pnlLogin.SuspendLayout()
        pnlSpacer1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.Transparent
        pnlLogin.Controls.Add(pnlSpacer1)
        pnlLogin.Controls.Add(txtUsername)
        pnlLogin.Controls.Add(txtPassdword)
        pnlLogin.Controls.Add(btnLogin)
        pnlLogin.Controls.Add(btnCreateAccount)
        pnlLogin.Controls.Add(Panel1)
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.FlowDirection = FlowDirection.TopDown
        pnlLogin.Location = New Point(0, 0)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Padding = New Padding(10)
        pnlLogin.Size = New Size(522, 600)
        pnlLogin.TabIndex = 3
        ' 
        ' pnlSpacer1
        ' 
        pnlSpacer1.Controls.Add(btnClose)
        pnlSpacer1.Location = New Point(10, 10)
        pnlSpacer1.Margin = New Padding(0, 0, 0, 25)
        pnlSpacer1.Name = "pnlSpacer1"
        pnlSpacer1.Size = New Size(503, 45)
        pnlSpacer1.TabIndex = 3
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Animated = True
        btnClose.BorderRadius = 15
        btnClose.CustomClick = True
        btnClose.CustomizableEdges = CustomizableEdges19
        btnClose.FillColor = Color.Transparent
        btnClose.HoverState.FillColor = Color.IndianRed
        btnClose.HoverState.IconColor = Color.Black
        btnClose.IconColor = Color.Black
        btnClose.Location = New Point(467, 0)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        btnClose.Size = New Size(36, 36)
        btnClose.TabIndex = 5
        btnClose.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Animated = True
        txtUsername.AutoRoundedCorners = True
        txtUsername.BorderRadius = 24
        txtUsername.CustomizableEdges = CustomizableEdges11
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(207), CByte(121), CByte(29))
        txtUsername.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.Black
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Location = New Point(10, 80)
        txtUsername.Margin = New Padding(0, 0, 0, 15)
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = ChrW(0)
        txtUsername.PlaceholderForeColor = Color.DimGray
        txtUsername.PlaceholderText = "Username"
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txtUsername.Size = New Size(503, 50)
        txtUsername.TabIndex = 1
        txtUsername.TextOffset = New Point(10, 0)
        ' 
        ' txtPassdword
        ' 
        txtPassdword.Animated = True
        txtPassdword.AutoRoundedCorners = True
        txtPassdword.BorderRadius = 24
        txtPassdword.CustomizableEdges = CustomizableEdges13
        txtPassdword.DefaultText = ""
        txtPassdword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPassdword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPassdword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassdword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassdword.FocusedState.BorderColor = Color.FromArgb(CByte(207), CByte(121), CByte(29))
        txtPassdword.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassdword.ForeColor = Color.Black
        txtPassdword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassdword.IconRight = My.Resources.Resources.eye_open_1_5x
        txtPassdword.IconRightOffset = New Point(10, 0)
        txtPassdword.Location = New Point(10, 145)
        txtPassdword.Margin = New Padding(0, 0, 0, 15)
        txtPassdword.Name = "txtPassdword"
        txtPassdword.PasswordChar = "*"c
        txtPassdword.PlaceholderForeColor = Color.DimGray
        txtPassdword.PlaceholderText = "Password"
        txtPassdword.SelectedText = ""
        txtPassdword.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        txtPassdword.Size = New Size(503, 50)
        txtPassdword.TabIndex = 2
        txtPassdword.TextOffset = New Point(10, 0)
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.Animated = True
        btnLogin.AutoRoundedCorners = True
        btnLogin.BorderRadius = 27
        btnLogin.CustomizableEdges = CustomizableEdges15
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.FromArgb(CByte(207), CByte(121), CByte(29))
        btnLogin.FillColor2 = Color.FromArgb(CByte(255), CByte(164), CByte(67))
        btnLogin.FocusedColor = Color.Transparent
        btnLogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        btnLogin.HoverState.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        btnLogin.Location = New Point(160, 210)
        btnLogin.Margin = New Padding(0, 0, 0, 25)
        btnLogin.Name = "btnLogin"
        btnLogin.PressedColor = Color.FromArgb(CByte(207), CByte(121), CByte(29))
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btnLogin.Size = New Size(202, 56)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Anchor = AnchorStyles.None
        btnCreateAccount.Animated = True
        btnCreateAccount.AutoRoundedCorners = True
        btnCreateAccount.BorderRadius = 27
        btnCreateAccount.BorderThickness = 2
        btnCreateAccount.CustomBorderColor = Color.Transparent
        btnCreateAccount.CustomizableEdges = CustomizableEdges17
        btnCreateAccount.DisabledState.BorderColor = Color.DarkGray
        btnCreateAccount.DisabledState.CustomBorderColor = Color.DarkGray
        btnCreateAccount.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCreateAccount.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCreateAccount.FillColor = Color.Transparent
        btnCreateAccount.Font = New Font("Segoe UI", 13.8F)
        btnCreateAccount.ForeColor = Color.Black
        btnCreateAccount.HoverState.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        btnCreateAccount.Location = New Point(160, 291)
        btnCreateAccount.Margin = New Padding(0, 0, 0, 25)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.PressedColor = Color.FromArgb(CByte(207), CByte(121), CByte(29))
        btnCreateAccount.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnCreateAccount.Size = New Size(202, 56)
        btnCreateAccount.TabIndex = 3
        btnCreateAccount.Text = "Register"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblForgot)
        Panel1.Location = New Point(10, 372)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(503, 195)
        Panel1.TabIndex = 5
        ' 
        ' lblForgot
        ' 
        lblForgot.Anchor = AnchorStyles.None
        lblForgot.ForeColor = Color.FromArgb(CByte(207), CByte(121), CByte(29))
        lblForgot.Location = New Point(178, 93)
        lblForgot.Name = "lblForgot"
        lblForgot.Size = New Size(125, 27)
        lblForgot.TabIndex = 0
        lblForgot.Text = "Forgot Password?"
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.HasFormShadow = False
        Guna2BorderlessForm1.ResizeForm = False
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(522, 600)
        Controls.Add(pnlLogin)
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(502, 0)
        Name = "LoginForm"
        Text = "LoginForm"
        pnlLogin.ResumeLayout(False)
        pnlSpacer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLogin As FlowLayoutPanel
    Friend WithEvents pnlSpacer1 As Panel
    Friend WithEvents lblForgot As Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassdword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnCreateAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Panel1 As Panel
End Class

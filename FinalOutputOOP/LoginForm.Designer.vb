<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        pnlLogin = New FlowLayoutPanel()
        pnlSpacer1 = New Panel()
        btnClose = New Button()
        txtUsername = New TextBox()
        txtPassdword = New TextBox()
        btnLogin = New Button()
        pnlForgotPassword = New TableLayoutPanel()
        lblForgot = New Label()
        pnlDivider = New Panel()
        btnCreateAccount = New Button()
        pnlLogin.SuspendLayout()
        pnlSpacer1.SuspendLayout()
        pnlForgotPassword.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.FromArgb(CByte(237), CByte(237), CByte(237))
        pnlLogin.Controls.Add(pnlSpacer1)
        pnlLogin.Controls.Add(txtUsername)
        pnlLogin.Controls.Add(txtPassdword)
        pnlLogin.Controls.Add(btnLogin)
        pnlLogin.Controls.Add(pnlForgotPassword)
        pnlLogin.Controls.Add(pnlDivider)
        pnlLogin.Controls.Add(btnCreateAccount)
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.FlowDirection = FlowDirection.TopDown
        pnlLogin.Location = New Point(0, 0)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Padding = New Padding(10)
        pnlLogin.Size = New Size(400, 580)
        pnlLogin.TabIndex = 3
        ' 
        ' pnlSpacer1
        ' 
        pnlSpacer1.Controls.Add(btnClose)
        pnlSpacer1.Location = New Point(13, 13)
        pnlSpacer1.Name = "pnlSpacer1"
        pnlSpacer1.Size = New Size(380, 95)
        pnlSpacer1.TabIndex = 3
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.BackgroundImage = My.Resources.Resources.xmark_4x
        btnClose.BackgroundImageLayout = ImageLayout.Zoom
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Location = New Point(327, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(50, 50)
        btnClose.TabIndex = 0
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(25, 126)
        txtUsername.Margin = New Padding(15)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(365, 47)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassdword
        ' 
        txtPassdword.Anchor = AnchorStyles.None
        txtPassdword.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassdword.Location = New Point(25, 203)
        txtPassdword.Margin = New Padding(15)
        txtPassdword.Name = "txtPassdword"
        txtPassdword.PasswordChar = "*"c
        txtPassdword.PlaceholderText = "Password"
        txtPassdword.Size = New Size(365, 47)
        txtPassdword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.BackColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(25, 280)
        btnLogin.Margin = New Padding(15)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(365, 60)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' pnlForgotPassword
        ' 
        pnlForgotPassword.ColumnCount = 1
        pnlForgotPassword.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        pnlForgotPassword.Controls.Add(lblForgot, 0, 0)
        pnlForgotPassword.Location = New Point(25, 355)
        pnlForgotPassword.Margin = New Padding(15, 0, 15, 15)
        pnlForgotPassword.Name = "pnlForgotPassword"
        pnlForgotPassword.RowCount = 1
        pnlForgotPassword.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        pnlForgotPassword.Size = New Size(365, 24)
        pnlForgotPassword.TabIndex = 4
        ' 
        ' lblForgot
        ' 
        lblForgot.Anchor = AnchorStyles.None
        lblForgot.AutoSize = True
        lblForgot.ForeColor = Color.RoyalBlue
        lblForgot.Location = New Point(120, 2)
        lblForgot.Name = "lblForgot"
        lblForgot.Size = New Size(125, 20)
        lblForgot.TabIndex = 0
        lblForgot.Text = "Forgot Password?"
        ' 
        ' pnlDivider
        ' 
        pnlDivider.Anchor = AnchorStyles.None
        pnlDivider.BackColor = Color.Black
        pnlDivider.Location = New Point(25, 397)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(365, 1)
        pnlDivider.TabIndex = 6
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Anchor = AnchorStyles.None
        btnCreateAccount.BackColor = Color.FromArgb(CByte(127), CByte(156), CByte(150))
        btnCreateAccount.FlatAppearance.BorderSize = 0
        btnCreateAccount.FlatStyle = FlatStyle.Flat
        btnCreateAccount.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateAccount.Location = New Point(81, 416)
        btnCreateAccount.Margin = New Padding(15)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(253, 60)
        btnCreateAccount.TabIndex = 5
        btnCreateAccount.Text = "Create New Account"
        btnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 580)
        Controls.Add(pnlLogin)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        Text = "LoginForm"
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        pnlSpacer1.ResumeLayout(False)
        pnlForgotPassword.ResumeLayout(False)
        pnlForgotPassword.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLogin As FlowLayoutPanel
    Friend WithEvents pnlSpacer1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassdword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents pnlForgotPassword As TableLayoutPanel
    Friend WithEvents lblForgot As Label
    Friend WithEvents pnlDivider As Panel
    Friend WithEvents btnCreateAccount As Button
End Class

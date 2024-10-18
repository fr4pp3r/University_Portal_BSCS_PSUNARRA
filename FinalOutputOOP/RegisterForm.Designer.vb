<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        pnlSpacer1 = New Panel()
        btnClose = New Button()
        txtName = New TextBox()
        txtSurname = New TextBox()
        txtUsername = New TextBox()
        txtCorpEmail = New TextBox()
        txtPassword = New TextBox()
        btnShowPass = New Button()
        txtConfirmPass = New TextBox()
        btnShowConPass = New Button()
        btnRegister = New Button()
        pnlDivider = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnReturnToLogin = New Button()
        FlowLayoutPanel1.SuspendLayout()
        pnlSpacer1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(pnlSpacer1)
        FlowLayoutPanel1.Controls.Add(txtName)
        FlowLayoutPanel1.Controls.Add(txtSurname)
        FlowLayoutPanel1.Controls.Add(txtUsername)
        FlowLayoutPanel1.Controls.Add(txtCorpEmail)
        FlowLayoutPanel1.Controls.Add(txtPassword)
        FlowLayoutPanel1.Controls.Add(btnShowPass)
        FlowLayoutPanel1.Controls.Add(txtConfirmPass)
        FlowLayoutPanel1.Controls.Add(btnShowConPass)
        FlowLayoutPanel1.Controls.Add(btnRegister)
        FlowLayoutPanel1.Controls.Add(pnlDivider)
        FlowLayoutPanel1.Controls.Add(TableLayoutPanel1)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(10)
        FlowLayoutPanel1.Size = New Size(400, 580)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' pnlSpacer1
        ' 
        pnlSpacer1.Controls.Add(btnClose)
        pnlSpacer1.Location = New Point(13, 13)
        pnlSpacer1.Name = "pnlSpacer1"
        pnlSpacer1.Size = New Size(380, 93)
        pnlSpacer1.TabIndex = 4
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.BackgroundImage = My.Resources.Resources.xmark_4x
        btnClose.BackgroundImageLayout = ImageLayout.Zoom
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Location = New Point(3, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(50, 50)
        btnClose.TabIndex = 10
        btnClose.TabStop = False
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.None
        txtName.Font = New Font("Segoe UI", 10.2F)
        txtName.Location = New Point(10, 109)
        txtName.Margin = New Padding(0, 0, 15, 20)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(182, 30)
        txtName.TabIndex = 0
        ' 
        ' txtSurname
        ' 
        txtSurname.Anchor = AnchorStyles.None
        txtSurname.Font = New Font("Segoe UI", 10.2F)
        txtSurname.Location = New Point(207, 109)
        txtSurname.Margin = New Padding(0, 0, 0, 20)
        txtSurname.Name = "txtSurname"
        txtSurname.PlaceholderText = "Surname"
        txtSurname.Size = New Size(182, 30)
        txtSurname.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.None
        txtUsername.Font = New Font("Segoe UI", 10.2F)
        txtUsername.Location = New Point(10, 159)
        txtUsername.Margin = New Padding(0, 0, 0, 20)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(380, 30)
        txtUsername.TabIndex = 3
        ' 
        ' txtCorpEmail
        ' 
        txtCorpEmail.Anchor = AnchorStyles.None
        txtCorpEmail.Font = New Font("Segoe UI", 10.2F)
        txtCorpEmail.Location = New Point(10, 209)
        txtCorpEmail.Margin = New Padding(0, 0, 0, 20)
        txtCorpEmail.Name = "txtCorpEmail"
        txtCorpEmail.PlaceholderText = "Corporate Email"
        txtCorpEmail.Size = New Size(380, 30)
        txtCorpEmail.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.Font = New Font("Segoe UI", 10.2F)
        txtPassword.Location = New Point(10, 259)
        txtPassword.Margin = New Padding(0, 0, 0, 20)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(350, 30)
        txtPassword.TabIndex = 5
        ' 
        ' btnShowPass
        ' 
        btnShowPass.BackgroundImage = My.Resources.Resources.eye_open_1_5x
        btnShowPass.BackgroundImageLayout = ImageLayout.Zoom
        btnShowPass.FlatAppearance.BorderSize = 0
        btnShowPass.FlatStyle = FlatStyle.Flat
        btnShowPass.Location = New Point(360, 259)
        btnShowPass.Margin = New Padding(0, 0, 0, 15)
        btnShowPass.Name = "btnShowPass"
        btnShowPass.Size = New Size(30, 30)
        btnShowPass.TabIndex = 10
        btnShowPass.TabStop = False
        btnShowPass.UseVisualStyleBackColor = True
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.Anchor = AnchorStyles.None
        txtConfirmPass.Font = New Font("Segoe UI", 10.2F)
        txtConfirmPass.Location = New Point(10, 309)
        txtConfirmPass.Margin = New Padding(0, 0, 0, 20)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.PasswordChar = "*"c
        txtConfirmPass.PlaceholderText = "Confirm Password"
        txtConfirmPass.Size = New Size(350, 30)
        txtConfirmPass.TabIndex = 6
        ' 
        ' btnShowConPass
        ' 
        btnShowConPass.BackColor = Color.FromArgb(CByte(237), CByte(237), CByte(237))
        btnShowConPass.BackgroundImage = My.Resources.Resources.eye_open_1_5x
        btnShowConPass.BackgroundImageLayout = ImageLayout.Zoom
        btnShowConPass.FlatAppearance.BorderSize = 0
        btnShowConPass.FlatStyle = FlatStyle.Flat
        btnShowConPass.Location = New Point(360, 309)
        btnShowConPass.Margin = New Padding(0, 0, 0, 15)
        btnShowConPass.Name = "btnShowConPass"
        btnShowConPass.Size = New Size(30, 30)
        btnShowConPass.TabIndex = 11
        btnShowConPass.TabStop = False
        btnShowConPass.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.None
        btnRegister.BackColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(10, 359)
        btnRegister.Margin = New Padding(0, 0, 0, 15)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(380, 60)
        btnRegister.TabIndex = 7
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' pnlDivider
        ' 
        pnlDivider.Anchor = AnchorStyles.None
        pnlDivider.BackColor = Color.Black
        pnlDivider.Location = New Point(13, 437)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(380, 1)
        pnlDivider.TabIndex = 14
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(btnReturnToLogin, 0, 0)
        TableLayoutPanel1.Location = New Point(13, 444)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(380, 88)
        TableLayoutPanel1.TabIndex = 15
        ' 
        ' btnReturnToLogin
        ' 
        btnReturnToLogin.Anchor = AnchorStyles.Top
        btnReturnToLogin.BackColor = Color.FromArgb(CByte(127), CByte(156), CByte(150))
        btnReturnToLogin.FlatAppearance.BorderSize = 0
        btnReturnToLogin.FlatStyle = FlatStyle.Flat
        btnReturnToLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturnToLogin.Location = New Point(63, 15)
        btnReturnToLogin.Margin = New Padding(15)
        btnReturnToLogin.Name = "btnReturnToLogin"
        btnReturnToLogin.Size = New Size(253, 58)
        btnReturnToLogin.TabIndex = 8
        btnReturnToLogin.Text = "Return to Login"
        btnReturnToLogin.UseVisualStyleBackColor = False
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(237), CByte(237))
        ClientSize = New Size(400, 580)
        Controls.Add(FlowLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegisterForm"
        Text = "RegisterForm"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        pnlSpacer1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents pnlSpacer1 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtCorpEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnShowPass As Button
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents btnShowConPass As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents pnlDivider As Panel
    Friend WithEvents btnReturnToLogin As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnClose As Button
End Class

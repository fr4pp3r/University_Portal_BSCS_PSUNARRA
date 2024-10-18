<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApplicationForm
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
        pnlLogin = New Panel()
        pnlMovable = New Panel()
        Label1 = New Label()
        lblSubname1 = New Label()
        lblName = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        pnlLogin.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.Transparent
        pnlLogin.Controls.Add(pnlMovable)
        pnlLogin.Controls.Add(Label1)
        pnlLogin.Controls.Add(lblSubname1)
        pnlLogin.Controls.Add(lblName)
        pnlLogin.Controls.Add(PictureBox2)
        pnlLogin.Controls.Add(PictureBox1)
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.Location = New Point(10, 10)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(1004, 580)
        pnlLogin.TabIndex = 1
        ' 
        ' pnlMovable
        ' 
        pnlMovable.BackColor = Color.FromArgb(CByte(237), CByte(237), CByte(237))
        pnlMovable.Location = New Point(502, 0)
        pnlMovable.Name = "pnlMovable"
        pnlMovable.Size = New Size(502, 580)
        pnlMovable.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        Label1.Location = New Point(633, 201)
        Label1.Name = "Label1"
        Label1.Size = New Size(371, 202)
        Label1.TabIndex = 6
        Label1.Text = "Ready to start your wonderful college LIFE?"
        ' 
        ' lblSubname1
        ' 
        lblSubname1.BackColor = Color.Transparent
        lblSubname1.Location = New Point(71, 281)
        lblSubname1.Name = "lblSubname1"
        lblSubname1.Size = New Size(358, 73)
        lblSubname1.TabIndex = 2
        lblSubname1.Text = "Connect with teachers and fellow students around your campus!"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        lblName.Location = New Point(58, 210)
        lblName.Name = "lblName"
        lblName.Size = New Size(371, 81)
        lblName.TabIndex = 0
        lblName.Text = "SchoolBook"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.schoolbooklogo
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(49, 26)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(388, 212)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Schoolbg
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(0, 347)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(501, 278)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 5
        ' 
        ' ApplicationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(206), CByte(185))
        ClientSize = New Size(1024, 600)
        Controls.Add(pnlLogin)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "ApplicationForm"
        Padding = New Padding(10)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents lblSubname1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlMovable As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FreebookForm
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
        lblSubname1 = New Label()
        lblSubname2 = New Label()
        lblName = New Label()
        Timer1 = New Timer(components)
        pnlLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLogin
        ' 
        pnlLogin.Controls.Add(pnlMovable)
        pnlLogin.Controls.Add(lblSubname1)
        pnlLogin.Controls.Add(lblSubname2)
        pnlLogin.Controls.Add(lblName)
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.Location = New Point(10, 10)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(1004, 580)
        pnlLogin.TabIndex = 1
        ' 
        ' pnlMovable
        ' 
        pnlMovable.BackColor = Color.FromArgb(CByte(237), CByte(237), CByte(237))
        pnlMovable.Location = New Point(604, 0)
        pnlMovable.Name = "pnlMovable"
        pnlMovable.Size = New Size(400, 580)
        pnlMovable.TabIndex = 3
        ' 
        ' lblSubname1
        ' 
        lblSubname1.AutoSize = True
        lblSubname1.Location = New Point(62, 265)
        lblSubname1.Name = "lblSubname1"
        lblSubname1.Size = New Size(240, 20)
        lblSubname1.TabIndex = 2
        lblSubname1.Text = "Connect with friends and the world"
        ' 
        ' lblSubname2
        ' 
        lblSubname2.AutoSize = True
        lblSubname2.Location = New Point(62, 285)
        lblSubname2.Name = "lblSubname2"
        lblSubname2.Size = New Size(174, 20)
        lblSubname2.TabIndex = 1
        lblSubname2.Text = "around you on Freebook."
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        lblName.Location = New Point(49, 194)
        lblName.Name = "lblName"
        lblName.Size = New Size(291, 81)
        lblName.TabIndex = 0
        lblName.Text = "freebook"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' FreebookForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(206), CByte(185))
        ClientSize = New Size(1024, 600)
        Controls.Add(pnlLogin)
        FormBorderStyle = FormBorderStyle.None
        Name = "FreebookForm"
        Padding = New Padding(10)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblSubname2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblSubname1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlMovable As Panel

End Class

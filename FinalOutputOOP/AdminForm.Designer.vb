<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(189, 206, 185)
        PictureBox1.BackgroundImage = My.Resources.Resources._463026965_122187437492182671_3265398024533083630_n
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Dock = DockStyle.Bottom
        PictureBox1.Location = New Point(0, 65)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1024, 511)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(563, 62)
        Label1.TabIndex = 1
        Label1.Text = "Welcome to admin page"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.xmark_4x
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Dock = DockStyle.Right
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(959, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(65, 65)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(189, 206, 185)
        ClientSize = New Size(1024, 576)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class

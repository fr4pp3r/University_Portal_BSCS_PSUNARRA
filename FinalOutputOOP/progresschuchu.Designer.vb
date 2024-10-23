<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class progresschuchu
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Timer1 = New Timer(components)
        Guna2ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' Guna2ProgressBar1
        ' 
        Guna2ProgressBar1.CustomizableEdges = CustomizableEdges1
        Guna2ProgressBar1.Location = New Point(12, 12)
        Guna2ProgressBar1.Name = "Guna2ProgressBar1"
        Guna2ProgressBar1.ProgressColor = Color.FromArgb(CByte(148), CByte(87), CByte(23))
        Guna2ProgressBar1.ProgressColor2 = Color.FromArgb(CByte(148), CByte(87), CByte(23))
        Guna2ProgressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ProgressBar1.Size = New Size(616, 29)
        Guna2ProgressBar1.TabIndex = 0
        Guna2ProgressBar1.Text = "Guna2ProgressBar1"
        Guna2ProgressBar1.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        ' 
        ' progresschuchu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 53)
        Controls.Add(Guna2ProgressBar1)
        Name = "progresschuchu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Loading Admin Panel..."
        ResumeLayout(False)
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPortal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserPortal))
        pnlTitleBar = New Panel()
        pnlTitleBarCenter = New TableLayoutPanel()
        txtPortalName = New Label()
        pnlTitleBarControls = New Panel()
        btnMin = New Button()
        btnMax = New Button()
        btnClose = New Button()
        pnlTitleBarLogo = New Panel()
        btnToggleSideBar = New Button()
        pnlSideBar = New Panel()
        btnLogout = New Button()
        btnNotifications = New Button()
        btnCalendar = New Button()
        btnClasses = New Button()
        btnInfo = New Button()
        Panel1 = New Panel()
        lblFullnameIndicator = New Label()
        lblFullname = New Label()
        lblEmail = New Label()
        lblEmailIndicator = New Label()
        lblBio = New Label()
        Timer1 = New Timer(components)
        Panel2 = New Panel()
        pnlTitleBar.SuspendLayout()
        pnlTitleBarCenter.SuspendLayout()
        pnlTitleBarControls.SuspendLayout()
        pnlTitleBarLogo.SuspendLayout()
        pnlSideBar.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTitleBar
        ' 
        pnlTitleBar.Controls.Add(pnlTitleBarCenter)
        pnlTitleBar.Controls.Add(pnlTitleBarControls)
        pnlTitleBar.Controls.Add(pnlTitleBarLogo)
        pnlTitleBar.Dock = DockStyle.Top
        pnlTitleBar.Location = New Point(0, 0)
        pnlTitleBar.Name = "pnlTitleBar"
        pnlTitleBar.Size = New Size(1024, 50)
        pnlTitleBar.TabIndex = 0
        ' 
        ' pnlTitleBarCenter
        ' 
        pnlTitleBarCenter.BackColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        pnlTitleBarCenter.ColumnCount = 1
        pnlTitleBarCenter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        pnlTitleBarCenter.Controls.Add(txtPortalName, 0, 0)
        pnlTitleBarCenter.Dock = DockStyle.Fill
        pnlTitleBarCenter.Location = New Point(174, 0)
        pnlTitleBarCenter.Name = "pnlTitleBarCenter"
        pnlTitleBarCenter.RowCount = 1
        pnlTitleBarCenter.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        pnlTitleBarCenter.Size = New Size(695, 50)
        pnlTitleBarCenter.TabIndex = 2
        ' 
        ' txtPortalName
        ' 
        txtPortalName.Anchor = AnchorStyles.None
        txtPortalName.AutoSize = True
        txtPortalName.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPortalName.ForeColor = Color.White
        txtPortalName.Location = New Point(245, 2)
        txtPortalName.Name = "txtPortalName"
        txtPortalName.Size = New Size(205, 46)
        txtPortalName.TabIndex = 0
        txtPortalName.Text = "Student Info"
        txtPortalName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlTitleBarControls
        ' 
        pnlTitleBarControls.BackColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        pnlTitleBarControls.Controls.Add(btnMin)
        pnlTitleBarControls.Controls.Add(btnMax)
        pnlTitleBarControls.Controls.Add(btnClose)
        pnlTitleBarControls.Dock = DockStyle.Right
        pnlTitleBarControls.Location = New Point(869, 0)
        pnlTitleBarControls.Name = "pnlTitleBarControls"
        pnlTitleBarControls.Size = New Size(155, 50)
        pnlTitleBarControls.TabIndex = 1
        ' 
        ' btnMin
        ' 
        btnMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMin.BackColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        btnMin.BackgroundImage = My.Resources.Resources.minus_2x
        btnMin.BackgroundImageLayout = ImageLayout.Zoom
        btnMin.FlatAppearance.BorderSize = 0
        btnMin.FlatStyle = FlatStyle.Flat
        btnMin.Location = New Point(37, 0)
        btnMin.Margin = New Padding(0, 0, 5, 0)
        btnMin.Name = "btnMin"
        btnMin.Size = New Size(36, 36)
        btnMin.TabIndex = 2
        btnMin.UseVisualStyleBackColor = False
        ' 
        ' btnMax
        ' 
        btnMax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMax.BackgroundImage = My.Resources.Resources.aspect_ratio_square_2_2x
        btnMax.BackgroundImageLayout = ImageLayout.Zoom
        btnMax.FlatAppearance.BorderSize = 0
        btnMax.FlatStyle = FlatStyle.Flat
        btnMax.Location = New Point(78, 0)
        btnMax.Margin = New Padding(0, 0, 5, 0)
        btnMax.Name = "btnMax"
        btnMax.Size = New Size(36, 36)
        btnMax.TabIndex = 1
        btnMax.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackgroundImage = My.Resources.Resources.xmark_2x
        btnClose.BackgroundImageLayout = ImageLayout.Zoom
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Location = New Point(119, 0)
        btnClose.Margin = New Padding(0, 0, 5, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(36, 36)
        btnClose.TabIndex = 0
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' pnlTitleBarLogo
        ' 
        pnlTitleBarLogo.BackColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        pnlTitleBarLogo.Controls.Add(btnToggleSideBar)
        pnlTitleBarLogo.Dock = DockStyle.Left
        pnlTitleBarLogo.Location = New Point(0, 0)
        pnlTitleBarLogo.Name = "pnlTitleBarLogo"
        pnlTitleBarLogo.Size = New Size(174, 50)
        pnlTitleBarLogo.TabIndex = 0
        ' 
        ' btnToggleSideBar
        ' 
        btnToggleSideBar.BackgroundImage = My.Resources.Resources.menu_8
        btnToggleSideBar.BackgroundImageLayout = ImageLayout.Zoom
        btnToggleSideBar.FlatAppearance.BorderSize = 0
        btnToggleSideBar.FlatStyle = FlatStyle.Flat
        btnToggleSideBar.Location = New Point(0, 0)
        btnToggleSideBar.Name = "btnToggleSideBar"
        btnToggleSideBar.Size = New Size(50, 50)
        btnToggleSideBar.TabIndex = 0
        btnToggleSideBar.UseVisualStyleBackColor = True
        ' 
        ' pnlSideBar
        ' 
        pnlSideBar.BackColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        pnlSideBar.Controls.Add(btnLogout)
        pnlSideBar.Controls.Add(btnNotifications)
        pnlSideBar.Controls.Add(btnCalendar)
        pnlSideBar.Controls.Add(btnClasses)
        pnlSideBar.Controls.Add(btnInfo)
        pnlSideBar.Dock = DockStyle.Left
        pnlSideBar.Location = New Point(0, 50)
        pnlSideBar.Margin = New Padding(10)
        pnlSideBar.Name = "pnlSideBar"
        pnlSideBar.Size = New Size(174, 718)
        pnlSideBar.TabIndex = 1
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.White
        btnLogout.Image = My.Resources.Resources.arrow_door_out_3_2x
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 668)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(174, 50)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnNotifications
        ' 
        btnNotifications.Dock = DockStyle.Top
        btnNotifications.FlatAppearance.BorderSize = 0
        btnNotifications.FlatStyle = FlatStyle.Flat
        btnNotifications.ForeColor = Color.White
        btnNotifications.Image = My.Resources.Resources.bell_2x
        btnNotifications.ImageAlign = ContentAlignment.MiddleLeft
        btnNotifications.Location = New Point(0, 150)
        btnNotifications.Name = "btnNotifications"
        btnNotifications.Size = New Size(174, 50)
        btnNotifications.TabIndex = 3
        btnNotifications.Text = "Notifications"
        btnNotifications.TextAlign = ContentAlignment.MiddleLeft
        btnNotifications.TextImageRelation = TextImageRelation.ImageBeforeText
        btnNotifications.UseVisualStyleBackColor = True
        ' 
        ' btnCalendar
        ' 
        btnCalendar.Dock = DockStyle.Top
        btnCalendar.FlatAppearance.BorderSize = 0
        btnCalendar.FlatStyle = FlatStyle.Flat
        btnCalendar.ForeColor = Color.White
        btnCalendar.Image = My.Resources.Resources.calendar_days_2x
        btnCalendar.ImageAlign = ContentAlignment.MiddleLeft
        btnCalendar.Location = New Point(0, 100)
        btnCalendar.Name = "btnCalendar"
        btnCalendar.Size = New Size(174, 50)
        btnCalendar.TabIndex = 2
        btnCalendar.Text = "Calendar"
        btnCalendar.TextAlign = ContentAlignment.MiddleLeft
        btnCalendar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCalendar.UseVisualStyleBackColor = True
        ' 
        ' btnClasses
        ' 
        btnClasses.Dock = DockStyle.Top
        btnClasses.FlatAppearance.BorderSize = 0
        btnClasses.FlatStyle = FlatStyle.Flat
        btnClasses.ForeColor = Color.White
        btnClasses.Image = My.Resources.Resources.book_bookmark_2x
        btnClasses.ImageAlign = ContentAlignment.MiddleLeft
        btnClasses.Location = New Point(0, 50)
        btnClasses.Name = "btnClasses"
        btnClasses.Size = New Size(174, 50)
        btnClasses.TabIndex = 1
        btnClasses.Text = "Classes"
        btnClasses.TextAlign = ContentAlignment.MiddleLeft
        btnClasses.TextImageRelation = TextImageRelation.ImageBeforeText
        btnClasses.UseVisualStyleBackColor = True
        ' 
        ' btnInfo
        ' 
        btnInfo.BackColor = Color.FromArgb(CByte(20), CByte(82), CByte(80))
        btnInfo.Dock = DockStyle.Top
        btnInfo.FlatAppearance.BorderSize = 0
        btnInfo.FlatStyle = FlatStyle.Flat
        btnInfo.ForeColor = Color.White
        btnInfo.Image = My.Resources.Resources.user_2x1
        btnInfo.ImageAlign = ContentAlignment.MiddleLeft
        btnInfo.Location = New Point(0, 0)
        btnInfo.Name = "btnInfo"
        btnInfo.Size = New Size(174, 50)
        btnInfo.TabIndex = 0
        btnInfo.Text = "Student Info"
        btnInfo.TextAlign = ContentAlignment.MiddleLeft
        btnInfo.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInfo.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.user_15x
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(275, 275)
        Panel1.TabIndex = 2
        ' 
        ' lblFullnameIndicator
        ' 
        lblFullnameIndicator.AutoSize = True
        lblFullnameIndicator.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullnameIndicator.Location = New Point(284, 58)
        lblFullnameIndicator.Name = "lblFullnameIndicator"
        lblFullnameIndicator.Size = New Size(95, 28)
        lblFullnameIndicator.TabIndex = 3
        lblFullnameIndicator.Text = "Fullname:"
        ' 
        ' lblFullname
        ' 
        lblFullname.AutoSize = True
        lblFullname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullname.Location = New Point(284, 86)
        lblFullname.Name = "lblFullname"
        lblFullname.Size = New Size(69, 28)
        lblFullname.TabIndex = 4
        lblFullname.Text = "Label2"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(284, 170)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(69, 28)
        lblEmail.TabIndex = 6
        lblEmail.Text = "Label3"
        ' 
        ' lblEmailIndicator
        ' 
        lblEmailIndicator.AutoSize = True
        lblEmailIndicator.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmailIndicator.Location = New Point(284, 142)
        lblEmailIndicator.Name = "lblEmailIndicator"
        lblEmailIndicator.Size = New Size(59, 28)
        lblEmailIndicator.TabIndex = 5
        lblEmailIndicator.Text = "Email"
        ' 
        ' lblBio
        ' 
        lblBio.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblBio.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBio.Location = New Point(13, 294)
        lblBio.Name = "lblBio"
        lblBio.Size = New Size(825, 415)
        lblBio.TabIndex = 7
        lblBio.Text = resources.GetString("lblBio.Text")
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblBio)
        Panel2.Controls.Add(lblEmail)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(lblEmailIndicator)
        Panel2.Controls.Add(lblFullnameIndicator)
        Panel2.Controls.Add(lblFullname)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(174, 50)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(850, 718)
        Panel2.TabIndex = 8
        ' 
        ' UserPortal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(237), CByte(237))
        ClientSize = New Size(1024, 768)
        Controls.Add(Panel2)
        Controls.Add(pnlSideBar)
        Controls.Add(pnlTitleBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "UserPortal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserPortal"
        pnlTitleBar.ResumeLayout(False)
        pnlTitleBarCenter.ResumeLayout(False)
        pnlTitleBarCenter.PerformLayout()
        pnlTitleBarControls.ResumeLayout(False)
        pnlTitleBarLogo.ResumeLayout(False)
        pnlSideBar.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents pnlTitleBarControls As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlTitleBarLogo As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents pnlTitleBarCenter As TableLayoutPanel
    Friend WithEvents txtPortalName As Label
    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnNotifications As Button
    Friend WithEvents btnCalendar As Button
    Friend WithEvents btnClasses As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFullnameIndicator As Label
    Friend WithEvents lblFullname As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblEmailIndicator As Label
    Friend WithEvents lblBio As Label
    Friend WithEvents btnToggleSideBar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
End Class

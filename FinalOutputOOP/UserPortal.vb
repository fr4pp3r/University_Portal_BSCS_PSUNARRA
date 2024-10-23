Public Class UserPortal
    Dim SidebarState = False


    Dim startX As Integer
    Dim targetX As Integer
    Dim timeElapsed As Double = 0
    Dim duration As Double = 0.2 ' Duration in seconds
    Dim totalDistance As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment elapsed time by the timer interval in seconds
        timeElapsed += Timer1.Interval / 1000.0

        ' Calculate the current position using the easing function
        Dim progress = Math.Min(timeElapsed / duration, 1) ' Normalize time (0 to 1)
        Dim easedProgress = EaseInOutSine(progress) ' Apply easing function
        Dim newX = startX + CInt(totalDistance * easedProgress)

        ' Move the panel
        pnlSideBar.Width = newX

        ' Stop the timer when animation completes
        If timeElapsed >= duration Then
            Timer1.Stop()

            If SidebarState = True Then

            End If
        End If
    End Sub

    Private Function EaseInOutSine(t As Double) As Double
        Return -(Math.Cos(Math.PI * t) - 1) / 2
    End Function

    Private Sub MovePanel(target As Integer)
        startX = pnlSideBar.Width
        targetX = target
        totalDistance = targetX - startX
        timeElapsed = 0
        Timer1.Start()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ApplicationForm.Show()
        Close()
    End Sub


    Private Sub btnToggleSidebar_Click(sender As Object, e As EventArgs) Handles btnToggleSidebar.Click
        If SidebarState = True Then
            MovePanel(50)
            SidebarState = False
        Else
            MovePanel(150)
            SidebarState = True
        End If
    End Sub

    Private Sub UserPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFullname.Text = ApplicationForm.activeUser.Name + " " + ApplicationForm.activeUser.Surname
        lblEmail.Text = ApplicationForm.activeUser.Email
    End Sub

    Private Sub btnBio_Click(sender As Object, e As EventArgs) Handles btnBio.Click
        Guna2TabControl1.SelectedTab = tbBio
    End Sub

    Private Sub btnClasses_Click(sender As Object, e As EventArgs) Handles btnClasses.Click
        Guna2TabControl1.SelectedTab = tbClasses
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnNotifications_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click
        Guna2TabControl1.SelectedTab = tbNotifications
    End Sub

    Private Sub pnlSideBar_MouseEnter(sender As Object, e As EventArgs) Handles pnlSideBar.MouseEnter, btnBio.MouseEnter, btnClasses.MouseEnter, btnNotifications.MouseEnter, btnLogout.MouseEnter
        MovePanel(150)
        SidebarState = True
    End Sub

    Private Sub pnlSideBar_MouseLeave(sender As Object, e As EventArgs) Handles pnlSideBar.MouseLeave, btnBio.MouseLeave, btnClasses.MouseLeave, btnNotifications.MouseLeave, btnLogout.MouseLeave
        MovePanel(50)
        SidebarState = False
    End Sub
End Class
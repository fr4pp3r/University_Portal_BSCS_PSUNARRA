Public Class UserPortal
    Dim SidebarState = True


    Dim startX As Integer
    Dim targetX As Integer
    Dim timeElapsed As Double = 0
    Dim duration As Double = 0.2 ' Duration in seconds
    Dim totalDistance As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment elapsed time by the timer interval in seconds
        timeElapsed += Timer1.Interval / 1000.0

        ' Calculate the current position using the easing function
        Dim progress As Double = Math.Min(timeElapsed / duration, 1) ' Normalize time (0 to 1)
        Dim easedProgress As Double = EaseInOutSine(progress) ' Apply easing function
        Dim newX As Integer = startX + CInt(totalDistance * easedProgress)

        ' Move the panel
        pnlSideBar.Width = newX

        ' Stop the timer when animation completes
        If timeElapsed >= duration Then
            Timer1.Stop()
            If SidebarState = True Then
                btnInfo.Text = "Student Info"
                btnClasses.Text = "Classes"
                btnCalendar.Text = "Calendar"
                btnNotifications.Text = "Notifications"
                btnLogout.Text = "Logout"
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

    Public Sub populateForm(userInfo As UserClass)
        lblFullname.Text = userInfo.Name + " " + userInfo.Surname
        lblEmail.Text = userInfo.Email
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ApplicationForm.Show()
        Me.Close()
    End Sub

    Private Sub btnToggleSideBar_Click(sender As Object, e As EventArgs) Handles btnToggleSideBar.Click
        If SidebarState = True Then
            MovePanel(50)
            btnInfo.Text = ""
            btnClasses.Text = ""
            btnCalendar.Text = ""
            btnNotifications.Text = ""
            btnLogout.Text = ""
            SidebarState = False
        Else
            MovePanel(174)
            SidebarState = True
        End If
    End Sub
End Class
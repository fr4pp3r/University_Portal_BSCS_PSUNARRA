﻿Public Class FreebookForm
    Dim Users As New Dictionary(Of String, UserClass)
    Dim username As String
    Dim password As String
    Dim userInfo As UserClass

    Public activatedForm As Form

    'For the ease in function
    Dim startX As Integer
    Dim targetX As Integer
    Dim timeElapsed As Double = 0
    Dim duration As Double = 1.0 ' Duration in seconds


    Dim totalDistance As Integer
    Dim panelToMove As Panel

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Users.Add("admin", New UserClass("nathanielbetita83@gmail.com", "Nathaniel", "Betita", "admin", "admin"))
        Users.Add("asd", New UserClass("asd", "asd", "asd", "asd", "asd"))
        OpenForm(LoginForm)
    End Sub

    Public Sub OpenForm(Form As Form)
        Form.TopLevel = False
        Form.FormBorderStyle = FormBorderStyle.None
        Form.Dock = DockStyle.Fill
        pnlMovable.Controls.Add(Form)
        pnlMovable.Tag = Form
        Form.BringToFront()
        Form.Show()
    End Sub

    Public Sub CloseLoginForm()
        pnlMovable.Controls.Remove(LoginForm)
        pnlMovable.Tag = Nothing
        LoginForm.Close()
    End Sub

    Public Sub CloseRegisterForm()
        pnlMovable.Controls.Remove(RegisterForm)
        pnlMovable.Tag = Nothing
        RegisterForm.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment elapsed time by the timer interval in seconds
        timeElapsed += Timer1.Interval / 1000.0

        ' Calculate the current position using the easing function
        Dim progress As Double = Math.Min(timeElapsed / duration, 1) ' Normalize time (0 to 1)
        Dim easedProgress As Double = EaseInOutSine(progress) ' Apply easing function
        Dim newX As Integer = startX + CInt(totalDistance * easedProgress)

        ' Move the panel
        panelToMove.Location = New Point(newX, panelToMove.Location.Y)

        ' Stop the timer when animation completes
        If timeElapsed >= duration Then
            Timer1.Stop()
            panelToMove = Nothing
            OpenForm(activatedForm)
        End If
    End Sub

    Private Function EaseInOutSine(t As Double) As Double
        Return -(Math.Cos(Math.PI * t) - 1) / 2
    End Function

    Private Sub MovePanel(panel As Panel, target As Integer)
        panelToMove = panel
        startX = panel.Location.X
        targetX = target
        totalDistance = targetX - startX
        timeElapsed = 0
        Timer1.Start()
    End Sub

    Public Sub Login(username As String, password As String)
        If username = "" Then
            MessageBox.Show("Input Username")

        Else
            If Users.TryGetValue(username, userInfo) Then
                If userInfo.Password = password Then
                    If userInfo.Username.ToLower = "admin" Then
                        AdminForm.Show()
                        Me.Close()
                    Else
                        UserPortal.Show()
                        UserPortal.populateForm(userInfo)
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Username or Password is incorrect")
                End If
            Else
                MessageBox.Show("User does not exist, click register NOW!")
            End If
        End If

    End Sub

    Public Sub Register(Email As String, Name As String, Surname As String, Username As String, Password As String)
        Dim tempUser As UserClass
        tempUser = New UserClass(Email, Name, Surname, Username, Password)
        Users.Add(tempUser.Username, tempUser)
        MessageBox.Show("Account succesfully Created! Returning to login page")
    End Sub

    Public Sub movePaneltoLeft()
        MovePanel(pnlMovable, 0)
    End Sub

    Public Sub movePaneltoRight()
        MovePanel(pnlMovable, 604)
    End Sub

    Public Function ToTitleCase(Text As String) As String
        Dim temparray() As Char
        temparray = Text.ToCharArray()
        temparray(0) = UCase(temparray(0))
        Text = New String(temparray)
        Return Text
    End Function

End Class

Public Class UserClass
    Public Property Email As String
    Public Property Name As String
    Public Property Surname As String
    Public Property Username As String
    Public Property Password As String

    Public Sub New(Email As String, Name As String, Surname As String, Username As String, Password As String)
        Me.Email = Email.ToLower()
        Me.Name = FreebookForm.ToTitleCase(Name)
        Me.Surname = FreebookForm.ToTitleCase(Surname)
        Me.Username = Username.ToLower()
        Me.Password = Password
    End Sub
End Class
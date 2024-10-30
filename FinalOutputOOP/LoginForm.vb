Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class LoginForm
    Dim username As String
    Dim password As String
    Dim xBound = 378
    Dim yBound = 178
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        lblForgot.Location = New Point(178, 93)
        username = txtUsername.Text.ToLower
    End Sub

    Private Sub txtPassdword_TextChanged(sender As Object, e As EventArgs) Handles txtPassdword.TextChanged
        password = txtPassdword.Text
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ApplicationForm.Login(username, password)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        'If ApplicationForm.pnlMovable.Location.X = 502 Then
        ApplicationForm.movePaneltoLeft()
        ApplicationForm.CloseLoginForm()
        ApplicationForm.activatedForm = RegisterForm
        'End If

    End Sub

    Private Sub lblForgot_Click(sender As Object, e As EventArgs) Handles lblForgot.Click
        Dim verification = InputBox("Please type ""Gwapo si Natnat"" (case sensitive)", "Verification")
        If verification = "Gwapo si Natnat" Then
            ApplicationForm.ForgotPassword(username)
        End If
    End Sub

    Private Sub txtPassdword_IconRightClick(sender As Object, e As EventArgs) Handles txtPassdword.IconRightClick
        If txtPassdword.PasswordChar = "*" Then
            txtPassdword.PasswordChar = ""
        Else
            txtPassdword.PasswordChar = "*"
        End If
    End Sub

    Private Sub lblForgot_MouseEnter(sender As Object, e As EventArgs) Handles lblForgot.MouseEnter
        If txtUsername.Text = "" Then
            lblForgot.Location = New Point(Int(378 * Rnd()), Int(178 * Rnd()))
        End If
    End Sub
End Class
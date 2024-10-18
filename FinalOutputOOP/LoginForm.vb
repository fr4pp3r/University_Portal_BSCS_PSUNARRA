Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class LoginForm
    Dim username As String
    Dim password As String
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        username = txtUsername.Text.ToLower
    End Sub

    Private Sub txtPassdword_TextChanged(sender As Object, e As EventArgs) Handles txtPassdword.TextChanged
        password = txtPassdword.Text
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        FreebookForm.Login(username, password)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If FreebookForm.pnlMovable.Location.X = 604 Then
            FreebookForm.movePaneltoLeft()
            FreebookForm.CloseLoginForm()
            FreebookForm.activatedForm = RegisterForm
        End If

    End Sub

    Private Sub lblForgot_Click(sender As Object, e As EventArgs) Handles lblForgot.Click
        MessageBox.Show("Contact the Administrator")
    End Sub
End Class
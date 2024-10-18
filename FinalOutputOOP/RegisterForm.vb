Public Class RegisterForm
    Private Sub btnReturnToLogin_Click(sender As Object, e As EventArgs) Handles btnReturnToLogin.Click
        If FreebookForm.pnlMovable.Location.X = 0 Then
            FreebookForm.movePaneltoRight()
            FreebookForm.CloseRegisterForm()
            FreebookForm.activatedForm = LoginForm
        End If
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtName.Text IsNot "" And txtSurname.Text IsNot "" And txtUsername.Text IsNot "" And txtCorpEmail.Text IsNot "" And txtPassword.Text IsNot "" And txtConfirmPass.Text IsNot "" Then
            If txtPassword.Text.Equals(txtConfirmPass.Text) Then
                FreebookForm.Register(txtCorpEmail.Text, txtName.Text, txtSurname.Text, txtUsername.Text, txtPassword.Text)
                btnReturnToLogin_Click(sender, e)
            Else
                MessageBox.Show("Password is not The same")
            End If
        Else
            MessageBox.Show("Fill all the fields!")
        End If
    End Sub

    Private Sub btnShowConPass_Click(sender As Object, e As EventArgs) Handles btnShowConPass.Click
        If txtConfirmPass.PasswordChar = "*" Then
            txtConfirmPass.PasswordChar = ""
        Else
            txtConfirmPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
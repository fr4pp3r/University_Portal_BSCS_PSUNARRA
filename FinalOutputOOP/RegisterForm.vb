Public Class RegisterForm
    Dim userRole As String = "Student"
    Private Sub btnReturnToLogin_Click(sender As Object, e As EventArgs) Handles btnReturnToLogin.Click
        'If ApplicationForm.pnlMovable.Location.X = 0 Then
        ApplicationForm.movePaneltoRight()
        ApplicationForm.CloseRegisterForm()
        ApplicationForm.activatedForm = LoginForm
        'End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtName.Text IsNot "" And txtSurname.Text IsNot "" And txtUsername.Text IsNot "" And txtCorpEmail.Text IsNot "" And txtPassword.Text IsNot "" And txtConfirmPass.Text IsNot "" Then
            If txtPassword.Text.Equals(txtConfirmPass.Text) Then
                Dim account = ApplicationForm.Register(txtCorpEmail.Text, txtName.Text, txtSurname.Text, txtUsername.Text, txtPassword.Text)
                If account = 1 Then
                    Dim dialog = MessageBox.Show("Account succesfully Created! Returning to login page?", "", MessageBoxButtons.YesNo)
                    If dialog = DialogResult.Yes Then
                        btnReturnToLogin_Click(sender, e)
                    End If
                End If

            Else
                MessageBox.Show("Password is not The same")
            End If
        Else
            MessageBox.Show("Fill all the fields!")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub txtPassword_IconRightClick(sender As Object, e As EventArgs) Handles txtPassword.IconRightClick
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtConfirmPass_IconRightClick(sender As Object, e As EventArgs) Handles txtConfirmPass.IconRightClick
        If txtConfirmPass.PasswordChar = "*" Then
            txtConfirmPass.PasswordChar = ""
        Else
            txtConfirmPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub rbtnFaculty_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFaculty.CheckedChanged
        userRole = "Faculty"
    End Sub

    Private Sub rbtnInstructor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnInstructor.CheckedChanged
        userRole = "Instructor"
    End Sub

    Private Sub rbtnStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnStudent.CheckedChanged
        userRole = "Student"
    End Sub
End Class
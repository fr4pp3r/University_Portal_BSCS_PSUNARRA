Imports System.Text.RegularExpressions

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

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim password As String
        Dim criteria = 0
        If txtPassword.Text = "" Then
            lblPassStrengthIndicator.Visible = False
            pnlStrengthIndicator.Visible = False
        Else
            lblPassStrengthIndicator.Visible = True
            pnlStrengthIndicator.Visible = True
            password = txtPassword.Text
            If Len(password) > 7 Then
                criteria += 1
            End If
            If HasUppercaseChar(password) Then
                criteria += 1
            End If
            If HasLowercaseChar(password) Then
                criteria += 1
            End If
            If HasDigit(password) Then
                criteria += 1
            End If
            If HasSpecifiedSpecialChar(password) Then
                criteria += 1
            End If

            If criteria = 1 Then
                pnlStrengthIndicator.Width = 20
                pnlStrengthIndicator.BackColor = Color.FromName("Maroon")
            ElseIf criteria = 2 Then
                pnlStrengthIndicator.Width = 133
                pnlStrengthIndicator.BackColor = Color.FromName("Red")
            ElseIf criteria = 3 Or criteria = 4 Then
                pnlStrengthIndicator.Width = 266
                pnlStrengthIndicator.BackColor = Color.FromName("Gold")
            ElseIf criteria = 5 Then
                pnlStrengthIndicator.Width = 400
                pnlStrengthIndicator.BackColor = Color.FromName("LimeGreen")
            Else

            End If
        End If

    End Sub

    Private Function HasUppercaseChar(input As String) As Boolean
        Return input.Any(Function(c) Char.IsUpper(c))
    End Function

    Private Function HasLowercaseChar(input As String) As Boolean
        Return input.Any(Function(c) Char.IsLower(c))
    End Function

    Function HasDigit(input As String) As Boolean
        Return input.Any(Function(c) Char.IsDigit(c))
    End Function

    Function HasSpecifiedSpecialChar(input As String) As Boolean
        Dim specialChars As String = "!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~"
        Return input.Any(Function(c) specialChars.Contains(c))
    End Function
End Class
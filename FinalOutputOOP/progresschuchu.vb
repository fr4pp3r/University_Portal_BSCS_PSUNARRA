Public Class progresschuchu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim result As DialogResult
        ProgressBar1.Increment(1)

        If ProgressBar1.Value = 50 Then
            Timer1.Stop()
            result = MessageBox.Show("Are you sure?", "There is no going back...", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Application.Exit()
            Else
                Timer1.Start()
            End If
        End If

        If ProgressBar1.Value = 100 Then
            AdminForm.Show()
            Timer1.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub progresschuchu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
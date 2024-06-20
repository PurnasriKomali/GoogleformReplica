Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPubliccreatesubmissionform.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub
End Class

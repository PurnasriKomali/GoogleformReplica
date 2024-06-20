Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private submissionStopwatch As New Stopwatch()

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If submissionStopwatch.IsRunning Then
            submissionStopwatch.Stop()
            btnStopwatch.Text = "Resume"
        Else
            submissionStopwatch.Start()
            btnStopwatch.Text = "Pause"
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        txtStopwatch.Text = submissionStopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Dictionary(Of String, String) From {
            {"name", txtName.Text},
            {"email", txtEmail.Text},
            {"phone", txtPhone.Text},
            {"github_link", txtGithub.Text},
            {"stopwatch_time", submissionStopwatch.Elapsed.ToString("hh\:mm\:ss")}
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Using client As New HttpClient()
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Await client.PostAsync("http://localhost:3000/submit", content)
        End Using

        MessageBox.Show("Submission Successful!")
        Me.Close()
    End Sub

    Private Sub txtStopwatch_TextChanged(sender As Object, e As EventArgs) Handles txtStopwatch.TextChanged

    End Sub
End Class

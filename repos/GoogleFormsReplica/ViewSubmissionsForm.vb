Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set KeyPreview to True to handle key events at the form level
        Me.KeyPreview = True
        ' Load the initial submission data
        LoadInitialSubmission()
    End Sub

    Private Async Function LoadSubmission() As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={currentIndex}")
            If response.IsSuccessStatusCode Then
                Dim submission As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(Await response.Content.ReadAsStringAsync())
                txtName.Text = submission("name")
                txtEmail.Text = submission("email")
                txtPhone.Text = submission("phone")
                txtGithub.Text = submission("github_link")
                txtStopwatch.Text = submission("stopwatch_time")
            End If
        End Using
    End Function

    Private Async Sub LoadInitialSubmission()
        ' Load the submission at currentIndex = 0
        Await LoadSubmission()
    End Sub

    Private Async Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission()
        End If
    End Sub

    Private Async Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await LoadSubmission()
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Alt AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class

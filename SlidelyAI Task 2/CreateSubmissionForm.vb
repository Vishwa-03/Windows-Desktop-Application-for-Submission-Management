Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Ensure all fields are filled
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtPhone.Text) OrElse
           String.IsNullOrWhiteSpace(txtGithubLink.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Create the submission object
        Dim submission As New Submission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = txtStopwatchTime.Text
        }

        ' Debug log the submission object
        Console.WriteLine("Submission: " & JsonConvert.SerializeObject(submission))

        Try
            Dim client As New HttpClient()
            Dim json = JsonConvert.SerializeObject(New With {
                .name = submission.name,
                .email = submission.email,
                .phone = submission.phone,
                .github_link = submission.github_link,
                .stopwatch_time = submission.stopwatch_time
            })

            ' Debug log the JSON payload
            Console.WriteLine("JSON Payload: " & json)

            Dim content = New StringContent(json, Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
                ClearForm()
            Else
                Dim errorResponse = Await response.Content.ReadAsStringAsync()
                MessageBox.Show($"Submission failed. Status Code: {response.StatusCode}, Response: {errorResponse}")
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

    Private Sub ClearForm()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGithubLink.Text = ""
        txtStopwatchTime.Text = "00:00:00"
        stopwatch.Reset()
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatch.IsRunning Then
            txtStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Timer1.Start()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class

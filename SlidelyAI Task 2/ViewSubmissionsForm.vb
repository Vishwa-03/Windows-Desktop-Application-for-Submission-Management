Imports System.Net.Http
Imports System.Text.Json
Imports System.Threading.Tasks
Imports System.Text

Public Class ViewSubmissionsForm
    Private currentSubmissionIndex As Integer = 0
    Private submissions As List(Of Submission)
    Private isEditing As Boolean = False

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            submissions = Await FetchSubmissionsAsync()
            If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                DisplaySubmission()
            Else
                MessageBox.Show("No submissions found.")
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

    Private Async Function FetchSubmissionsAsync() As Task(Of List(Of Submission))
        Try
            Dim client As New HttpClient()
            Dim response = Await client.GetAsync("http://localhost:3000/read_all")
            response.EnsureSuccessStatusCode()
            Dim jsonResponse = Await response.Content.ReadAsStringAsync()
            Dim options As New JsonSerializerOptions With {
                .PropertyNameCaseInsensitive = True
            }
            Return JsonSerializer.Deserialize(Of List(Of Submission))(jsonResponse, options)
        Catch ex As Exception
            Throw New Exception($"An error occurred while fetching submissions: {ex.Message}")
        End Try
    End Function

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As Submission = submissions(currentSubmissionIndex)
            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGithubLink.Text = submission.github_link
            txtStopwatchTime.Text = submission.stopwatch_time
        End If
        btnPrevious.Enabled = currentSubmissionIndex > 0
        btnNext.Enabled = currentSubmissionIndex < submissions.Count - 1

        ' Make text boxes read-only by default
        SetReadOnlyFields(True)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentSubmissionIndex > 0 Then
            currentSubmissionIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentSubmissionIndex < submissions.Count - 1 Then
            currentSubmissionIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim client As New HttpClient()
                Dim response = Await client.DeleteAsync($"http://localhost:3000/delete/{submissions(currentSubmissionIndex).Id}")

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted successfully.")
                    submissions.RemoveAt(currentSubmissionIndex)
                    If currentSubmissionIndex >= submissions.Count Then
                        currentSubmissionIndex -= 1
                    End If
                    DisplaySubmission()
                Else
                    MessageBox.Show("Failed to delete submission.")
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If isEditing Then
            ' Save changes
            SaveSubmission()
        Else
            ' Enable editing
            SetReadOnlyFields(False)
            btnEdit.Text = "Save"
            isEditing = True
        End If
    End Sub

    Private Async Sub SaveSubmission()
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
            .Id = submissions(currentSubmissionIndex).Id,
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = txtStopwatchTime.Text
        }

        Try
            Dim client As New HttpClient()
            Dim json = JsonSerializer.Serialize(submission)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")
            Dim response = Await client.PutAsync($"http://localhost:3000/edit/{submission.Id}", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully.")
                submissions(currentSubmissionIndex) = submission
                DisplaySubmission()
                btnEdit.Text = "Edit"
                isEditing = False
                SetReadOnlyFields(True)
            Else
                MessageBox.Show("Failed to update submission.")
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

    Private Sub SetReadOnlyFields(isReadOnly As Boolean)
        txtName.ReadOnly = isReadOnly
        txtEmail.ReadOnly = isReadOnly
        txtPhone.ReadOnly = isReadOnly
        txtGithubLink.ReadOnly = isReadOnly
        txtStopwatchTime.ReadOnly = isReadOnly
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = InputBox("Enter email to search:", "Search Submission")

        If Not String.IsNullOrWhiteSpace(email) Then
            Try
                Dim client As New HttpClient()
                Dim response = Await client.GetAsync($"http://localhost:3000/search?email={email}")

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse = Await response.Content.ReadAsStringAsync()
                    Dim options As New JsonSerializerOptions With {
                        .PropertyNameCaseInsensitive = True
                    }
                    Dim searchResults As List(Of Submission) = JsonSerializer.Deserialize(Of List(Of Submission))(jsonResponse, options)

                    If searchResults IsNot Nothing AndAlso searchResults.Count > 0 Then
                        submissions = searchResults
                        currentSubmissionIndex = 0
                        DisplaySubmission()
                    Else
                        MessageBox.Show("No submissions found for the given email.")
                    End If
                Else
                    MessageBox.Show("Failed to search submissions.")
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            btnEdit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.F Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub pnlContainer_Paint(sender As Object, e As PaintEventArgs) Handles pnlContainer.Paint

    End Sub

    Private Sub lblStopwatchTime_Click(sender As Object, e As EventArgs) Handles lblStopwatchTime.Click

    End Sub

    Private Sub txtStopwatchTime_Click(sender As Object, e As EventArgs) Handles txtStopwatchTime.Click

    End Sub
End Class



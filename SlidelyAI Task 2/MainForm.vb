Public Class MainForm
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ShowViewSubmissionsForm()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        ShowCreateSubmissionForm()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable key preview to handle key events at the form level
        Me.KeyPreview = True
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ShowViewSubmissionsForm()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ShowCreateSubmissionForm()
        End If
    End Sub

    Private Sub ShowViewSubmissionsForm()
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub ShowCreateSubmissionForm()
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub
End Class

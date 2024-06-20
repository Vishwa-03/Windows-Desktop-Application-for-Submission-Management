<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblName = New MetroFramework.Controls.MetroLabel()
        Me.lblEmail = New MetroFramework.Controls.MetroLabel()
        Me.lblPhone = New MetroFramework.Controls.MetroLabel()
        Me.lblGithubLink = New MetroFramework.Controls.MetroLabel()
        Me.lblStopwatchTime = New MetroFramework.Controls.MetroLabel()
        Me.btnPrevious = New MetroFramework.Controls.MetroButton()
        Me.btnNext = New MetroFramework.Controls.MetroButton()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.txtPhone = New MetroFramework.Controls.MetroTextBox()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtStopwatchTime = New MetroFramework.Controls.MetroTextBox()
        Me.txtGithubLink = New MetroFramework.Controls.MetroTextBox()
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.pnlContainer = New MetroFramework.Controls.MetroPanel()
        Me.lblHeader = New MetroFramework.Controls.MetroLabel()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblName.Location = New System.Drawing.Point(31, 66)
        Me.lblName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblEmail.Location = New System.Drawing.Point(31, 129)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 20)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblPhone.Location = New System.Drawing.Point(31, 187)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(50, 20)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone"
        '
        'lblGithubLink
        '
        Me.lblGithubLink.AutoSize = True
        Me.lblGithubLink.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblGithubLink.Location = New System.Drawing.Point(23, 245)
        Me.lblGithubLink.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblGithubLink.Name = "lblGithubLink"
        Me.lblGithubLink.Size = New System.Drawing.Size(83, 20)
        Me.lblGithubLink.TabIndex = 3
        Me.lblGithubLink.Text = "Github Link"
        '
        'lblStopwatchTime
        '
        Me.lblStopwatchTime.AutoSize = True
        Me.lblStopwatchTime.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblStopwatchTime.Location = New System.Drawing.Point(23, 313)
        Me.lblStopwatchTime.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.Size = New System.Drawing.Size(116, 20)
        Me.lblStopwatchTime.TabIndex = 4
        Me.lblStopwatchTime.Text = "Stopwatch Time"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnPrevious.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnPrevious.Location = New System.Drawing.Point(23, 401)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(189, 40)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "Previous (CTRL + P)"
        Me.btnPrevious.UseCustomBackColor = True
        Me.btnPrevious.UseSelectable = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnNext.CausesValidation = False
        Me.btnNext.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnNext.Location = New System.Drawing.Point(262, 401)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(171, 40)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next (CTRL + N)"
        Me.btnNext.UseCustomBackColor = True
        Me.btnNext.UseSelectable = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.txtName.CustomButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(159, 58)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ReadOnly = True
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(255, 30)
        Me.txtName.TabIndex = 7
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtName.UseCustomBackColor = True
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtPhone.CustomButton.Image = Nothing
        Me.txtPhone.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.txtPhone.CustomButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPhone.CustomButton.Name = ""
        Me.txtPhone.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhone.CustomButton.TabIndex = 1
        Me.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhone.CustomButton.UseSelectable = True
        Me.txtPhone.CustomButton.Visible = False
        Me.txtPhone.Lines = New String(-1) {}
        Me.txtPhone.Location = New System.Drawing.Point(159, 187)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPhone.MaxLength = 32767
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.SelectionLength = 0
        Me.txtPhone.SelectionStart = 0
        Me.txtPhone.ShortcutsEnabled = True
        Me.txtPhone.Size = New System.Drawing.Size(255, 30)
        Me.txtPhone.TabIndex = 8
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPhone.UseCustomBackColor = True
        Me.txtPhone.UseSelectable = True
        Me.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.txtEmail.CustomButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(159, 129)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(255, 30)
        Me.txtEmail.TabIndex = 9
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEmail.UseCustomBackColor = True
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStopwatchTime
        '
        Me.txtStopwatchTime.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtStopwatchTime.CustomButton.Image = Nothing
        Me.txtStopwatchTime.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.txtStopwatchTime.CustomButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtStopwatchTime.CustomButton.Name = ""
        Me.txtStopwatchTime.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtStopwatchTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStopwatchTime.CustomButton.TabIndex = 1
        Me.txtStopwatchTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStopwatchTime.CustomButton.UseSelectable = True
        Me.txtStopwatchTime.CustomButton.Visible = False
        Me.txtStopwatchTime.Lines = New String(-1) {}
        Me.txtStopwatchTime.Location = New System.Drawing.Point(159, 313)
        Me.txtStopwatchTime.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtStopwatchTime.MaxLength = 32767
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStopwatchTime.ReadOnly = True
        Me.txtStopwatchTime.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStopwatchTime.SelectedText = ""
        Me.txtStopwatchTime.SelectionLength = 0
        Me.txtStopwatchTime.SelectionStart = 0
        Me.txtStopwatchTime.ShortcutsEnabled = True
        Me.txtStopwatchTime.Size = New System.Drawing.Size(255, 30)
        Me.txtStopwatchTime.TabIndex = 10
        Me.txtStopwatchTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtStopwatchTime.UseCustomBackColor = True
        Me.txtStopwatchTime.UseSelectable = True
        Me.txtStopwatchTime.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStopwatchTime.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtGithubLink
        '
        Me.txtGithubLink.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtGithubLink.CustomButton.Image = Nothing
        Me.txtGithubLink.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.txtGithubLink.CustomButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtGithubLink.CustomButton.Name = ""
        Me.txtGithubLink.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtGithubLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGithubLink.CustomButton.TabIndex = 1
        Me.txtGithubLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGithubLink.CustomButton.UseSelectable = True
        Me.txtGithubLink.CustomButton.Visible = False
        Me.txtGithubLink.Lines = New String(-1) {}
        Me.txtGithubLink.Location = New System.Drawing.Point(159, 245)
        Me.txtGithubLink.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtGithubLink.MaxLength = 32767
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGithubLink.ReadOnly = True
        Me.txtGithubLink.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGithubLink.SelectedText = ""
        Me.txtGithubLink.SelectionLength = 0
        Me.txtGithubLink.SelectionStart = 0
        Me.txtGithubLink.ShortcutsEnabled = True
        Me.txtGithubLink.Size = New System.Drawing.Size(255, 30)
        Me.txtGithubLink.TabIndex = 11
        Me.txtGithubLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGithubLink.UseCustomBackColor = True
        Me.txtGithubLink.UseSelectable = True
        Me.txtGithubLink.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGithubLink.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(506, 177)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 40)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseCustomBackColor = True
        Me.btnDelete.UseCustomForeColor = True
        Me.btnDelete.UseSelectable = True
        Me.btnDelete.UseStyleColors = True
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(506, 245)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(114, 40)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseCustomBackColor = True
        Me.btnEdit.UseSelectable = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(506, 313)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 41)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseCustomBackColor = True
        Me.btnSearch.UseSelectable = True
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.White
        Me.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContainer.Controls.Add(Me.lblHeader)
        Me.pnlContainer.Controls.Add(Me.btnSearch)
        Me.pnlContainer.Controls.Add(Me.btnEdit)
        Me.pnlContainer.Controls.Add(Me.btnDelete)
        Me.pnlContainer.Controls.Add(Me.txtGithubLink)
        Me.pnlContainer.Controls.Add(Me.txtStopwatchTime)
        Me.pnlContainer.Controls.Add(Me.txtEmail)
        Me.pnlContainer.Controls.Add(Me.txtPhone)
        Me.pnlContainer.Controls.Add(Me.txtName)
        Me.pnlContainer.Controls.Add(Me.btnNext)
        Me.pnlContainer.Controls.Add(Me.btnPrevious)
        Me.pnlContainer.Controls.Add(Me.lblStopwatchTime)
        Me.pnlContainer.Controls.Add(Me.lblGithubLink)
        Me.pnlContainer.Controls.Add(Me.lblPhone)
        Me.pnlContainer.Controls.Add(Me.lblEmail)
        Me.pnlContainer.Controls.Add(Me.lblName)
        Me.pnlContainer.HorizontalScrollbarBarColor = True
        Me.pnlContainer.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlContainer.HorizontalScrollbarSize = 13
        Me.pnlContainer.Location = New System.Drawing.Point(29, 88)
        Me.pnlContainer.Margin = New System.Windows.Forms.Padding(9)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(692, 503)
        Me.pnlContainer.TabIndex = 15
        Me.pnlContainer.UseCustomBackColor = True
        Me.pnlContainer.UseCustomForeColor = True
        Me.pnlContainer.UseStyleColors = True
        Me.pnlContainer.VerticalScrollbarBarColor = True
        Me.pnlContainer.VerticalScrollbarHighlightOnWheel = False
        Me.pnlContainer.VerticalScrollbarSize = 15
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblHeader.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblHeader.Location = New System.Drawing.Point(31, 13)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(162, 25)
        Me.lblHeader.TabIndex = 15
        Me.lblHeader.Text = "Submission Details"
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(761, 642)
        Me.Controls.Add(Me.pnlContainer)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "ViewSubmissionsForm"
        Me.Padding = New System.Windows.Forms.Padding(31, 79, 31, 27)
        Me.Text = "John Doe, Slidely Task 2 - View Submissions"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEmail As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPhone As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblGithubLink As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblStopwatchTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnPrevious As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNext As MetroFramework.Controls.MetroButton
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStopwatchTime As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGithubLink As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlContainer As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblHeader As MetroFramework.Controls.MetroLabel
End Class

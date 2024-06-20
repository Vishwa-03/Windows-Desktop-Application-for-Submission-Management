<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.btnToggleStopwatch = New MetroFramework.Controls.MetroButton()
        Me.btnSubmit = New MetroFramework.Controls.MetroButton()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtPhone = New MetroFramework.Controls.MetroTextBox()
        Me.txtGithubLink = New MetroFramework.Controls.MetroTextBox()
        Me.txtStopwatchTime = New MetroFramework.Controls.MetroTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label1.Location = New System.Drawing.Point(107, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label2.Location = New System.Drawing.Point(107, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label3.Location = New System.Drawing.Point(107, 222)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label4.Location = New System.Drawing.Point(107, 283)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Github Link"
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(107, 340)
        Me.btnToggleStopwatch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(270, 28)
        Me.btnToggleStopwatch.TabIndex = 5
        Me.btnToggleStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        Me.btnToggleStopwatch.UseCustomBackColor = True
        Me.btnToggleStopwatch.UseSelectable = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSubmit.Location = New System.Drawing.Point(148, 415)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(414, 47)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit (CTRL + S)"
        Me.btnSubmit.UseCustomBackColor = True
        Me.btnSubmit.UseSelectable = False
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(285, 2)
        Me.txtName.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(386, 98)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.MaxLength = 32767
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(240, 28)
        Me.txtName.TabIndex = 7
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(285, 2)
        Me.txtEmail.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(386, 160)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(240, 28)
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhone
        '
        '
        '
        '
        Me.txtPhone.CustomButton.Image = Nothing
        Me.txtPhone.CustomButton.Location = New System.Drawing.Point(285, 2)
        Me.txtPhone.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhone.CustomButton.Name = ""
        Me.txtPhone.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhone.CustomButton.TabIndex = 1
        Me.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhone.CustomButton.UseSelectable = True
        Me.txtPhone.CustomButton.Visible = False
        Me.txtPhone.Lines = New String(-1) {}
        Me.txtPhone.Location = New System.Drawing.Point(386, 222)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhone.MaxLength = 32767
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.SelectionLength = 0
        Me.txtPhone.SelectionStart = 0
        Me.txtPhone.ShortcutsEnabled = True
        Me.txtPhone.Size = New System.Drawing.Size(240, 28)
        Me.txtPhone.TabIndex = 9
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPhone.UseSelectable = True
        Me.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtGithubLink
        '
        '
        '
        '
        Me.txtGithubLink.CustomButton.Image = Nothing
        Me.txtGithubLink.CustomButton.Location = New System.Drawing.Point(285, 2)
        Me.txtGithubLink.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGithubLink.CustomButton.Name = ""
        Me.txtGithubLink.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtGithubLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGithubLink.CustomButton.TabIndex = 1
        Me.txtGithubLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGithubLink.CustomButton.UseSelectable = True
        Me.txtGithubLink.CustomButton.Visible = False
        Me.txtGithubLink.Lines = New String(-1) {}
        Me.txtGithubLink.Location = New System.Drawing.Point(386, 283)
        Me.txtGithubLink.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGithubLink.MaxLength = 32767
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGithubLink.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGithubLink.SelectedText = ""
        Me.txtGithubLink.SelectionLength = 0
        Me.txtGithubLink.SelectionStart = 0
        Me.txtGithubLink.ShortcutsEnabled = True
        Me.txtGithubLink.Size = New System.Drawing.Size(240, 28)
        Me.txtGithubLink.TabIndex = 10
        Me.txtGithubLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGithubLink.UseSelectable = True
        Me.txtGithubLink.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGithubLink.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStopwatchTime
        '
        Me.txtStopwatchTime.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtStopwatchTime.CustomButton.Image = Nothing
        Me.txtStopwatchTime.CustomButton.Location = New System.Drawing.Point(285, 2)
        Me.txtStopwatchTime.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStopwatchTime.CustomButton.Name = ""
        Me.txtStopwatchTime.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtStopwatchTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStopwatchTime.CustomButton.TabIndex = 1
        Me.txtStopwatchTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStopwatchTime.CustomButton.UseSelectable = True
        Me.txtStopwatchTime.CustomButton.Visible = False
        Me.txtStopwatchTime.Lines = New String(-1) {}
        Me.txtStopwatchTime.Location = New System.Drawing.Point(434, 340)
        Me.txtStopwatchTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStopwatchTime.MaxLength = 32767
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStopwatchTime.ReadOnly = True
        Me.txtStopwatchTime.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStopwatchTime.SelectedText = ""
        Me.txtStopwatchTime.SelectionLength = 0
        Me.txtStopwatchTime.SelectionStart = 0
        Me.txtStopwatchTime.ShortcutsEnabled = True
        Me.txtStopwatchTime.Size = New System.Drawing.Size(192, 28)
        Me.txtStopwatchTime.TabIndex = 11
        Me.txtStopwatchTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtStopwatchTime.UseCustomBackColor = True
        Me.txtStopwatchTime.UseSelectable = True
        Me.txtStopwatchTime.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStopwatchTime.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 529)
        Me.Controls.Add(Me.txtStopwatchTime)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateSubmissionForm"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "John Doe, Slidely Task 2 - Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnToggleStopwatch As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSubmit As MetroFramework.Controls.MetroButton
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGithubLink As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStopwatchTime As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Timer1 As Timer
End Class

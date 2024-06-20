<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.btnViewSubmissions = New MetroFramework.Controls.MetroButton()
        Me.btnCreateSubmission = New MetroFramework.Controls.MetroButton()
        Me.pnlContainer = New MetroFramework.Controls.MetroPanel()
        Me.lblHeader = New MetroFramework.Controls.MetroLabel()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnViewSubmissions.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnViewSubmissions.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnViewSubmissions.Location = New System.Drawing.Point(57, 92)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(437, 44)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "View Submissions (CTRL + V)"
        Me.btnViewSubmissions.UseCustomBackColor = True
        Me.btnViewSubmissions.UseSelectable = False


        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCreateSubmission.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnCreateSubmission.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnCreateSubmission.Location = New System.Drawing.Point(57, 162)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(437, 50)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "Create New Submission (CTRL + N)"
        Me.btnCreateSubmission.UseCustomBackColor = True
        Me.btnCreateSubmission.UseSelectable = False
        '
        'pnlContainer
        '
        Me.pnlContainer.Controls.Add(Me.lblHeader)
        Me.pnlContainer.Controls.Add(Me.btnViewSubmissions)
        Me.pnlContainer.Controls.Add(Me.btnCreateSubmission)
        Me.pnlContainer.HorizontalScrollbarBarColor = True
        Me.pnlContainer.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlContainer.HorizontalScrollbarSize = 10
        Me.pnlContainer.Location = New System.Drawing.Point(20, 60)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(551, 245)
        Me.pnlContainer.TabIndex = 2
        Me.pnlContainer.VerticalScrollbarBarColor = True
        Me.pnlContainer.VerticalScrollbarHighlightOnWheel = False
        Me.pnlContainer.VerticalScrollbarSize = 10
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblHeader.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblHeader.Location = New System.Drawing.Point(20, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(87, 25)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "John Doe"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 332)
        Me.Controls.Add(Me.pnlContainer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Slidely Task 2- Slidely Form App"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewSubmissions As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCreateSubmission As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlContainer As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblHeader As MetroFramework.Controls.MetroLabel
End Class

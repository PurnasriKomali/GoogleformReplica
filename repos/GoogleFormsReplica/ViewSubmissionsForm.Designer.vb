<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

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
        Me.lblName = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.Label()
        Me.Github = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(157, 72)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(157, 117)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(41, 16)
        Me.Email.TabIndex = 1
        Me.Email.Text = "Email"
        '
        'Phone
        '
        Me.Phone.AutoSize = True
        Me.Phone.Location = New System.Drawing.Point(157, 157)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(46, 16)
        Me.Phone.TabIndex = 2
        Me.Phone.Text = "Phone"
        '
        'Github
        '
        Me.Github.AutoSize = True
        Me.Github.Location = New System.Drawing.Point(160, 198)
        Me.Github.Name = "Github"
        Me.Github.Size = New System.Drawing.Size(72, 16)
        Me.Github.TabIndex = 3
        Me.Github.Text = "Github Link"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(160, 231)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(100, 16)
        Me.lblStopwatch.TabIndex = 4
        Me.lblStopwatch.Text = "Stopwatch Time"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrevious.Location = New System.Drawing.Point(139, 302)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(196, 31)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Location = New System.Drawing.Point(358, 302)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(196, 31)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(310, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(254, 22)
        Me.txtName.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(310, 117)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(254, 22)
        Me.txtEmail.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(310, 157)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(254, 22)
        Me.txtPhone.TabIndex = 9
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(310, 198)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(254, 22)
        Me.txtGithub.TabIndex = 10
        '
        'txtStopwatch
        '
        Me.txtStopwatch.Location = New System.Drawing.Point(310, 231)
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.Size = New System.Drawing.Size(254, 22)
        Me.txtStopwatch.TabIndex = 11
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.Github)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.lblName)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents Email As Label
    Friend WithEvents Phone As Label
    Friend WithEvents Github As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtStopwatch As TextBox

End Class

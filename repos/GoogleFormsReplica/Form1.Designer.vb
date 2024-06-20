<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPubliccreatesubmissionform = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPubliccreatesubmissionform
        '
        Me.btnPubliccreatesubmissionform.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPubliccreatesubmissionform.Location = New System.Drawing.Point(120, 252)
        Me.btnPubliccreatesubmissionform.Name = "btnPubliccreatesubmissionform"
        Me.btnPubliccreatesubmissionform.Size = New System.Drawing.Size(438, 42)
        Me.btnPubliccreatesubmissionform.TabIndex = 0
        Me.btnPubliccreatesubmissionform.Text = "&View_Submission"
        Me.btnPubliccreatesubmissionform.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(120, 343)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(438, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Create_&New_Submissions"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPubliccreatesubmissionform)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPubliccreatesubmissionform As Button
    Friend WithEvents Button2 As Button
End Class

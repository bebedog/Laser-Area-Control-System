<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeVariables
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbTimeOut = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbRefreshRate = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(12, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 23)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Timeout (ms):"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTimeOut
        '
        Me.tbTimeOut.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbTimeOut.Location = New System.Drawing.Point(140, 12)
        Me.tbTimeOut.Name = "tbTimeOut"
        Me.tbTimeOut.Size = New System.Drawing.Size(84, 29)
        Me.tbTimeOut.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Status refresh rate (ms): "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbRefreshRate
        '
        Me.tbRefreshRate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbRefreshRate.Location = New System.Drawing.Point(140, 63)
        Me.tbRefreshRate.Name = "tbRefreshRate"
        Me.tbRefreshRate.Size = New System.Drawing.Size(84, 29)
        Me.tbRefreshRate.TabIndex = 13
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnApply.Location = New System.Drawing.Point(12, 112)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(92, 35)
        Me.btnApply.TabIndex = 14
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCancel.Location = New System.Drawing.Point(146, 112)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 35)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TimeVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 159)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.tbRefreshRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbTimeOut)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TimeVariables"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents tbTimeOut As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbRefreshRate As TextBox
    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
End Class

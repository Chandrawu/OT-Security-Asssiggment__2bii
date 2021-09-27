<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Lbl_LineA = New System.Windows.Forms.Label()
        Me.Lbl_PathlineA = New System.Windows.Forms.Label()
        Me.Lbl_StatusLineA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_LineA
        '
        Me.Lbl_LineA.AutoSize = True
        Me.Lbl_LineA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LineA.Location = New System.Drawing.Point(55, 46)
        Me.Lbl_LineA.Name = "Lbl_LineA"
        Me.Lbl_LineA.Size = New System.Drawing.Size(65, 24)
        Me.Lbl_LineA.TabIndex = 1
        Me.Lbl_LineA.Text = "Server"
        '
        'Lbl_PathlineA
        '
        Me.Lbl_PathlineA.AutoSize = True
        Me.Lbl_PathlineA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PathlineA.Location = New System.Drawing.Point(126, 46)
        Me.Lbl_PathlineA.Name = "Lbl_PathlineA"
        Me.Lbl_PathlineA.Size = New System.Drawing.Size(66, 24)
        Me.Lbl_PathlineA.TabIndex = 2
        Me.Lbl_PathlineA.Text = "Label2"
        '
        'Lbl_StatusLineA
        '
        Me.Lbl_StatusLineA.AutoSize = True
        Me.Lbl_StatusLineA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_StatusLineA.Location = New System.Drawing.Point(397, 46)
        Me.Lbl_StatusLineA.Name = "Lbl_StatusLineA"
        Me.Lbl_StatusLineA.Size = New System.Drawing.Size(38, 24)
        Me.Lbl_StatusLineA.TabIndex = 3
        Me.Lbl_StatusLineA.Text = "NG"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 135)
        Me.Controls.Add(Me.Lbl_StatusLineA)
        Me.Controls.Add(Me.Lbl_PathlineA)
        Me.Controls.Add(Me.Lbl_LineA)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_LineA As Label
    Friend WithEvents Lbl_PathlineA As Label
    Friend WithEvents Lbl_StatusLineA As Label
End Class

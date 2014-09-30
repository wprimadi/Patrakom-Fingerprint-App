<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoader
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.SuspendLayout()
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ProgressPanel1.AppearanceCaption.Options.UseFont = True
        Me.ProgressPanel1.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ProgressPanel1.AppearanceDescription.Options.UseFont = True
        Me.ProgressPanel1.Location = New System.Drawing.Point(12, 12)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(267, 66)
        Me.ProgressPanel1.TabIndex = 0
        Me.ProgressPanel1.Text = "ProgressPanel1"
        '
        'frmLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 91)
        Me.Controls.Add(Me.ProgressPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoader"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
End Class

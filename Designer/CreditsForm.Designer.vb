<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcredits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcredits))
        Me.txtCredits = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCredits
        '
        Me.txtCredits.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtCredits.Location = New System.Drawing.Point(-4, -1)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.ReadOnly = True
        Me.txtCredits.Size = New System.Drawing.Size(490, 505)
        Me.txtCredits.TabIndex = 0
        Me.txtCredits.Text = resources.GetString("txtCredits.Text")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(399, 452)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmcredits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 506)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCredits)
        Me.KeyPreview = True
        Me.Name = "frmcredits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bread Quest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCredits As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

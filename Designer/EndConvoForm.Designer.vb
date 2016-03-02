<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmendconvo
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
        Me.lbl_convo = New System.Windows.Forms.Label()
        Me.btn_continue2 = New System.Windows.Forms.Button()
        Me.lbl_lady = New System.Windows.Forms.Label()
        Me.lbl_player = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.picbx_lady = New System.Windows.Forms.PictureBox()
        Me.picbx_user = New System.Windows.Forms.PictureBox()
        Me.picbx_ladytalk = New System.Windows.Forms.PictureBox()
        Me.picbx_talk = New System.Windows.Forms.PictureBox()
        CType(Me.picbx_lady, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbx_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbx_ladytalk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbx_talk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_convo
        '
        Me.lbl_convo.BackColor = System.Drawing.Color.White
        Me.lbl_convo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_convo.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_convo.Location = New System.Drawing.Point(202, 231)
        Me.lbl_convo.Name = "lbl_convo"
        Me.lbl_convo.Size = New System.Drawing.Size(296, 134)
        Me.lbl_convo.TabIndex = 33
        Me.lbl_convo.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_continue2
        '
        Me.btn_continue2.Location = New System.Drawing.Point(484, 438)
        Me.btn_continue2.Name = "btn_continue2"
        Me.btn_continue2.Size = New System.Drawing.Size(178, 45)
        Me.btn_continue2.TabIndex = 32
        Me.btn_continue2.Text = "Continue"
        Me.btn_continue2.UseVisualStyleBackColor = True
        '
        'lbl_lady
        '
        Me.lbl_lady.AutoSize = True
        Me.lbl_lady.Location = New System.Drawing.Point(599, 193)
        Me.lbl_lady.Name = "lbl_lady"
        Me.lbl_lady.Size = New System.Drawing.Size(35, 13)
        Me.lbl_lady.TabIndex = 31
        Me.lbl_lady.Text = "Witch"
        '
        'lbl_player
        '
        Me.lbl_player.AutoSize = True
        Me.lbl_player.Location = New System.Drawing.Point(9, 193)
        Me.lbl_player.Name = "lbl_player"
        Me.lbl_player.Size = New System.Drawing.Size(32, 13)
        Me.lbl_player.TabIndex = 30
        Me.lbl_player.Text = "Pane"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_title.Location = New System.Drawing.Point(28, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(747, 80)
        Me.lbl_title.TabIndex = 27
        Me.lbl_title.Text = "Pane goes into the toaster. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The toaster then starts the process by putting pane" & _
            " inside, then a blue wave formed after a minute. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pane then springs out of the " & _
            "toaster, but human again." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picbx_lady
        '
        Me.picbx_lady.Image = Global.breadQuestReal.My.Resources.Resources.witchnstuffnewttrans
        Me.picbx_lady.Location = New System.Drawing.Point(504, 209)
        Me.picbx_lady.Name = "picbx_lady"
        Me.picbx_lady.Size = New System.Drawing.Size(160, 156)
        Me.picbx_lady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbx_lady.TabIndex = 29
        Me.picbx_lady.TabStop = False
        '
        'picbx_user
        '
        Me.picbx_user.Image = Global.breadQuestReal.My.Resources.Resources.breadboynoback
        Me.picbx_user.Location = New System.Drawing.Point(-40, 179)
        Me.picbx_user.Name = "picbx_user"
        Me.picbx_user.Size = New System.Drawing.Size(287, 200)
        Me.picbx_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbx_user.TabIndex = 40
        Me.picbx_user.TabStop = False
        '
        'picbx_ladytalk
        '
        Me.picbx_ladytalk.Image = Global.breadQuestReal.My.Resources.Resources.witchangrytalk2cropped
        Me.picbx_ladytalk.Location = New System.Drawing.Point(504, 209)
        Me.picbx_ladytalk.Name = "picbx_ladytalk"
        Me.picbx_ladytalk.Size = New System.Drawing.Size(169, 156)
        Me.picbx_ladytalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbx_ladytalk.TabIndex = 41
        Me.picbx_ladytalk.TabStop = False
        Me.picbx_ladytalk.Visible = False
        '
        'picbx_talk
        '
        Me.picbx_talk.Image = Global.breadQuestReal.My.Resources.Resources.breadboytalk
        Me.picbx_talk.Location = New System.Drawing.Point(-40, 179)
        Me.picbx_talk.Name = "picbx_talk"
        Me.picbx_talk.Size = New System.Drawing.Size(287, 200)
        Me.picbx_talk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbx_talk.TabIndex = 42
        Me.picbx_talk.TabStop = False
        Me.picbx_talk.Visible = False
        '
        'frmendconvo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(674, 495)
        Me.Controls.Add(Me.lbl_player)
        Me.Controls.Add(Me.lbl_convo)
        Me.Controls.Add(Me.picbx_talk)
        Me.Controls.Add(Me.picbx_ladytalk)
        Me.Controls.Add(Me.btn_continue2)
        Me.Controls.Add(Me.lbl_lady)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.picbx_user)
        Me.Controls.Add(Me.picbx_lady)
        Me.Name = "frmendconvo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bread Quest"
        CType(Me.picbx_lady, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbx_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbx_ladytalk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbx_talk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_clicks As System.Windows.Forms.Label
    Friend WithEvents lbl_convo As System.Windows.Forms.Label
    Friend WithEvents btn_continue2 As System.Windows.Forms.Button
    Friend WithEvents lbl_lady As System.Windows.Forms.Label
    Friend WithEvents lbl_player As System.Windows.Forms.Label
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents picbx_lady As System.Windows.Forms.PictureBox
    Friend WithEvents picbx_user As System.Windows.Forms.PictureBox
    Friend WithEvents picbx_ladytalk As System.Windows.Forms.PictureBox
    Friend WithEvents picbx_talk As System.Windows.Forms.PictureBox

End Class

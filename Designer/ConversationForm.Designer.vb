<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconvo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconvo))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_player = New System.Windows.Forms.Label()
        Me.lbl_lady = New System.Windows.Forms.Label()
        Me.btn_continue2 = New System.Windows.Forms.Button()
        Me.lbl_convo = New System.Windows.Forms.Label()
        Me.lbl_clicks = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl_123 = New System.Windows.Forms.Label()
        Me.lbl_classchose = New System.Windows.Forms.Label()
        Me.pic_breadtalk = New System.Windows.Forms.PictureBox()
        Me.pic_bread = New System.Windows.Forms.PictureBox()
        Me.picbx_user = New System.Windows.Forms.PictureBox()
        Me.picbx_talk = New System.Windows.Forms.PictureBox()
        Me.picbx_ladytalk = New System.Windows.Forms.PictureBox()
        Me.picbx_lady = New System.Windows.Forms.PictureBox()
        Me.picbxangrytalk = New System.Windows.Forms.PictureBox()
        CType(Me.pic_breadtalk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_bread, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbx_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbx_talk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbx_ladytalk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbx_lady, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbxangrytalk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_title.Location = New System.Drawing.Point(-6, 21)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(685, 108)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = resources.GetString("lbl_title.Text")
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_player
        '
        Me.lbl_player.AutoSize = True
        Me.lbl_player.Location = New System.Drawing.Point(9, 193)
        Me.lbl_player.Name = "lbl_player"
        Me.lbl_player.Size = New System.Drawing.Size(32, 13)
        Me.lbl_player.TabIndex = 3
        Me.lbl_player.Text = "Pane"
        Me.lbl_player.Visible = False
        '
        'lbl_lady
        '
        Me.lbl_lady.AutoSize = True
        Me.lbl_lady.Location = New System.Drawing.Point(581, 193)
        Me.lbl_lady.Name = "lbl_lady"
        Me.lbl_lady.Size = New System.Drawing.Size(45, 13)
        Me.lbl_lady.TabIndex = 4
        Me.lbl_lady.Text = "Old lady"
        Me.lbl_lady.Visible = False
        '
        'btn_continue2
        '
        Me.btn_continue2.Location = New System.Drawing.Point(466, 438)
        Me.btn_continue2.Name = "btn_continue2"
        Me.btn_continue2.Size = New System.Drawing.Size(178, 45)
        Me.btn_continue2.TabIndex = 10
        Me.btn_continue2.Text = "Continue"
        Me.btn_continue2.UseVisualStyleBackColor = True
        '
        'lbl_convo
        '
        Me.lbl_convo.BackColor = System.Drawing.Color.White
        Me.lbl_convo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_convo.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_convo.Location = New System.Drawing.Point(202, 234)
        Me.lbl_convo.Name = "lbl_convo"
        Me.lbl_convo.Size = New System.Drawing.Size(296, 134)
        Me.lbl_convo.TabIndex = 11
        Me.lbl_convo.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_clicks
        '
        Me.lbl_clicks.AutoSize = True
        Me.lbl_clicks.Location = New System.Drawing.Point(9, 443)
        Me.lbl_clicks.Name = "lbl_clicks"
        Me.lbl_clicks.Size = New System.Drawing.Size(44, 13)
        Me.lbl_clicks.TabIndex = 12
        Me.lbl_clicks.Text = "Clicks 1"
        Me.lbl_clicks.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(219, 407)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(13, 13)
        Me.lbl1.TabIndex = 17
        Me.lbl1.Text = "1"
        Me.lbl1.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(219, 438)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(13, 13)
        Me.lbl2.TabIndex = 18
        Me.lbl2.Text = "2"
        Me.lbl2.Visible = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(219, 470)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(13, 13)
        Me.lbl3.TabIndex = 19
        Me.lbl3.Text = "3"
        Me.lbl3.Visible = False
        '
        'lbl_123
        '
        Me.lbl_123.AutoSize = True
        Me.lbl_123.Location = New System.Drawing.Point(219, 379)
        Me.lbl_123.Name = "lbl_123"
        Me.lbl_123.Size = New System.Drawing.Size(223, 13)
        Me.lbl_123.TabIndex = 16
        Me.lbl_123.Text = "Click the button that corresponds with the text"
        Me.lbl_123.Visible = False
        '
        'lbl_classchose
        '
        Me.lbl_classchose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_classchose.Location = New System.Drawing.Point(189, 336)
        Me.lbl_classchose.Name = "lbl_classchose"
        Me.lbl_classchose.Size = New System.Drawing.Size(309, 43)
        Me.lbl_classchose.TabIndex = 23
        '
        'pic_breadtalk
        '
        Me.pic_breadtalk.Image = Global.breadQuestReal.My.Resources.Resources.breadplainnew___Copy
        Me.pic_breadtalk.Location = New System.Drawing.Point(12, 211)
        Me.pic_breadtalk.Name = "pic_breadtalk"
        Me.pic_breadtalk.Size = New System.Drawing.Size(130, 157)
        Me.pic_breadtalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_breadtalk.TabIndex = 28
        Me.pic_breadtalk.TabStop = False
        Me.pic_breadtalk.Visible = False
        '
        'pic_bread
        '
        Me.pic_bread.Image = Global.breadQuestReal.My.Resources.Resources.breadplainnew
        Me.pic_bread.Location = New System.Drawing.Point(12, 209)
        Me.pic_bread.Name = "pic_bread"
        Me.pic_bread.Size = New System.Drawing.Size(130, 159)
        Me.pic_bread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_bread.TabIndex = 27
        Me.pic_bread.TabStop = False
        Me.pic_bread.Visible = False
        '
        'picbx_user
        '
        Me.picbx_user.Image = Global.breadQuestReal.My.Resources.Resources.breadboynoback
        Me.picbx_user.Location = New System.Drawing.Point(-29, 180)
        Me.picbx_user.Name = "picbx_user"
        Me.picbx_user.Size = New System.Drawing.Size(225, 199)
        Me.picbx_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbx_user.TabIndex = 1
        Me.picbx_user.TabStop = False
        Me.picbx_user.Visible = False
        '
        'picbx_talk
        '
        Me.picbx_talk.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picbx_talk.Image = Global.breadQuestReal.My.Resources.Resources.breadboytalk
        Me.picbx_talk.Location = New System.Drawing.Point(-29, 180)
        Me.picbx_talk.Name = "picbx_talk"
        Me.picbx_talk.Size = New System.Drawing.Size(225, 199)
        Me.picbx_talk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbx_talk.TabIndex = 24
        Me.picbx_talk.TabStop = False
        Me.picbx_talk.Visible = False
        '
        'picbx_ladytalk
        '
        Me.picbx_ladytalk.Image = Global.breadQuestReal.My.Resources.Resources.witchtalk
        Me.picbx_ladytalk.Location = New System.Drawing.Point(466, 180)
        Me.picbx_ladytalk.Name = "picbx_ladytalk"
        Me.picbx_ladytalk.Size = New System.Drawing.Size(275, 225)
        Me.picbx_ladytalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbx_ladytalk.TabIndex = 26
        Me.picbx_ladytalk.TabStop = False
        Me.picbx_ladytalk.Visible = False
        '
        'picbx_lady
        '
        Me.picbx_lady.Image = Global.breadQuestReal.My.Resources.Resources.witchnstuffnewttrans
        Me.picbx_lady.Location = New System.Drawing.Point(519, 209)
        Me.picbx_lady.Name = "picbx_lady"
        Me.picbx_lady.Size = New System.Drawing.Size(144, 159)
        Me.picbx_lady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbx_lady.TabIndex = 2
        Me.picbx_lady.TabStop = False
        Me.picbx_lady.Visible = False
        '
        'picbxangrytalk
        '
        Me.picbxangrytalk.Image = Global.breadQuestReal.My.Resources.Resources.witchangrytalk2cropped
        Me.picbxangrytalk.Location = New System.Drawing.Point(519, 209)
        Me.picbxangrytalk.Name = "picbxangrytalk"
        Me.picbxangrytalk.Size = New System.Drawing.Size(155, 159)
        Me.picbxangrytalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbxangrytalk.TabIndex = 25
        Me.picbxangrytalk.TabStop = False
        Me.picbxangrytalk.Visible = False
        '
        'frmconvo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(674, 495)
        Me.Controls.Add(Me.pic_breadtalk)
        Me.Controls.Add(Me.pic_bread)
        Me.Controls.Add(Me.lbl_classchose)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl_123)
        Me.Controls.Add(Me.lbl_clicks)
        Me.Controls.Add(Me.lbl_convo)
        Me.Controls.Add(Me.btn_continue2)
        Me.Controls.Add(Me.lbl_lady)
        Me.Controls.Add(Me.lbl_player)
        Me.Controls.Add(Me.picbx_user)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.picbx_talk)
        Me.Controls.Add(Me.picbx_ladytalk)
        Me.Controls.Add(Me.picbx_lady)
        Me.Controls.Add(Me.picbxangrytalk)
        Me.Name = "frmconvo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bread Quest"
        CType(Me.pic_breadtalk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_bread, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbx_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbx_talk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbx_ladytalk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbx_lady, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbxangrytalk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents picbx_user As System.Windows.Forms.PictureBox
    Friend WithEvents picbx_lady As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_player As System.Windows.Forms.Label
    Friend WithEvents lbl_lady As System.Windows.Forms.Label
    Friend WithEvents btn_continue2 As System.Windows.Forms.Button
    Friend WithEvents lbl_convo As System.Windows.Forms.Label
    Friend WithEvents lbl_clicks As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl_123 As System.Windows.Forms.Label
    Friend WithEvents lbl_classchose As System.Windows.Forms.Label
    Friend WithEvents picbx_talk As System.Windows.Forms.PictureBox
    Friend WithEvents picbxangrytalk As System.Windows.Forms.PictureBox
    Friend WithEvents picbx_ladytalk As System.Windows.Forms.PictureBox
    Friend WithEvents pic_bread As System.Windows.Forms.PictureBox
    Friend WithEvents pic_breadtalk As System.Windows.Forms.PictureBox

End Class

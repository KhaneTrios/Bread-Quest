<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmainmenu
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
        Me.components = New System.ComponentModel.Container()
        Me.btnbattle = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.btncredits = New System.Windows.Forms.Button()
        Me.btnstory = New System.Windows.Forms.Button()
        Me.btncontinue = New System.Windows.Forms.Button()
        Me.btnnewgame = New System.Windows.Forms.Button()
        Me.lblversion = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnbattle
        '
        Me.btnbattle.BackColor = System.Drawing.Color.Transparent
        Me.btnbattle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbattle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbattle.Location = New System.Drawing.Point(342, 86)
        Me.btnbattle.Name = "btnbattle"
        Me.btnbattle.Size = New System.Drawing.Size(128, 27)
        Me.btnbattle.TabIndex = 10
        Me.btnbattle.Text = "Battle"
        Me.ToolTip1.SetToolTip(Me.btnbattle, "Random quick battle.")
        Me.btnbattle.UseVisualStyleBackColor = False
        '
        'btnquit
        '
        Me.btnquit.BackColor = System.Drawing.Color.Transparent
        Me.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnquit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquit.Location = New System.Drawing.Point(392, 122)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(128, 26)
        Me.btnquit.TabIndex = 13
        Me.btnquit.Text = "Quit"
        Me.ToolTip1.SetToolTip(Me.btnquit, "Quit the game.")
        Me.btnquit.UseVisualStyleBackColor = False
        '
        'btncredits
        '
        Me.btncredits.BackColor = System.Drawing.Color.Transparent
        Me.btncredits.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncredits.Location = New System.Drawing.Point(237, 122)
        Me.btncredits.Name = "btncredits"
        Me.btncredits.Size = New System.Drawing.Size(128, 26)
        Me.btncredits.TabIndex = 12
        Me.btncredits.Text = "Credits"
        Me.ToolTip1.SetToolTip(Me.btncredits, "Who made the game.")
        Me.btncredits.UseVisualStyleBackColor = False
        '
        'btnstory
        '
        Me.btnstory.BackColor = System.Drawing.Color.Transparent
        Me.btnstory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstory.Location = New System.Drawing.Point(83, 123)
        Me.btnstory.Name = "btnstory"
        Me.btnstory.Size = New System.Drawing.Size(129, 26)
        Me.btnstory.TabIndex = 11
        Me.btnstory.Text = "Story"
        Me.ToolTip1.SetToolTip(Me.btnstory, "Read the story.")
        Me.btnstory.UseVisualStyleBackColor = False
        '
        'btncontinue
        '
        Me.btncontinue.BackColor = System.Drawing.Color.Transparent
        Me.btncontinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncontinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontinue.Location = New System.Drawing.Point(188, 86)
        Me.btncontinue.Name = "btncontinue"
        Me.btncontinue.Size = New System.Drawing.Size(129, 27)
        Me.btncontinue.TabIndex = 9
        Me.btncontinue.Text = "Continue"
        Me.ToolTip1.SetToolTip(Me.btncontinue, "Loads a save from a previous play session.")
        Me.btncontinue.UseVisualStyleBackColor = False
        '
        'btnnewgame
        '
        Me.btnnewgame.BackColor = System.Drawing.Color.Transparent
        Me.btnnewgame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnewgame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewgame.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnewgame.Location = New System.Drawing.Point(34, 86)
        Me.btnnewgame.Name = "btnnewgame"
        Me.btnnewgame.Size = New System.Drawing.Size(129, 27)
        Me.btnnewgame.TabIndex = 8
        Me.btnnewgame.Text = "New Game"
        Me.ToolTip1.SetToolTip(Me.btnnewgame, "Begins a new game.")
        Me.btnnewgame.UseVisualStyleBackColor = False
        '
        'lblversion
        '
        Me.lblversion.AutoSize = True
        Me.lblversion.BackColor = System.Drawing.Color.Transparent
        Me.lblversion.Location = New System.Drawing.Point(458, 407)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(42, 13)
        Me.lblversion.TabIndex = 14
        Me.lblversion.Text = "Version"
        '
        'ToolTip1
        '
        '
        'frmmainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.breadQuestReal.My.Resources.Resources.Main_Menu3
        Me.ClientSize = New System.Drawing.Size(526, 429)
        Me.Controls.Add(Me.lblversion)
        Me.Controls.Add(Me.btnbattle)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btncredits)
        Me.Controls.Add(Me.btnstory)
        Me.Controls.Add(Me.btncontinue)
        Me.Controls.Add(Me.btnnewgame)
        Me.Name = "frmmainmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bread Quest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbattle As System.Windows.Forms.Button
    Friend WithEvents btnquit As System.Windows.Forms.Button
    Friend WithEvents btncredits As System.Windows.Forms.Button
    Friend WithEvents btnstory As System.Windows.Forms.Button
    Friend WithEvents btncontinue As System.Windows.Forms.Button
    Friend WithEvents btnnewgame As System.Windows.Forms.Button
    Friend WithEvents lblversion As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class

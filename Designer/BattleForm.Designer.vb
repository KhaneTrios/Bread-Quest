<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbattle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbattle))
        Me.lblenemyhit = New System.Windows.Forms.Label()
        Me.lblcommess = New System.Windows.Forms.Label()
        Me.lblenemyname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.barenergy = New System.Windows.Forms.ProgressBar()
        Me.barhealth = New System.Windows.Forms.ProgressBar()
        Me.grpinv = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnenergypot = New System.Windows.Forms.Button()
        Me.btnretreat = New System.Windows.Forms.Button()
        Me.btnhealthpot = New System.Windows.Forms.Button()
        Me.barenemyhealth = New System.Windows.Forms.ProgressBar()
        Me.grpattack = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnslice = New System.Windows.Forms.Button()
        Me.btnstab = New System.Windows.Forms.Button()
        Me.btnspell4 = New System.Windows.Forms.Button()
        Me.btnspell3 = New System.Windows.Forms.Button()
        Me.btnblock = New System.Windows.Forms.Button()
        Me.btnspell1 = New System.Windows.Forms.Button()
        Me.btnspell2 = New System.Windows.Forms.Button()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblenemyhealth = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblmyhealth = New System.Windows.Forms.Label()
        Me.lblmyenergy = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picwar = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btncontinue = New System.Windows.Forms.Button()
        Me.lblplayername = New System.Windows.Forms.Label()
        Me.lblblock = New System.Windows.Forms.Label()
        Me.lblEDAM = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbllvl = New System.Windows.Forms.Label()
        Me.lbllvlxp = New System.Windows.Forms.Label()
        Me.barxp = New System.Windows.Forms.ProgressBar()
        Me.picwariron = New System.Windows.Forms.PictureBox()
        Me.picrat = New System.Windows.Forms.PictureBox()
        Me.picflea = New System.Windows.Forms.PictureBox()
        Me.grpinv.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.grpattack.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picwar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picwariron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picflea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblenemyhit
        '
        Me.lblenemyhit.AutoSize = True
        Me.lblenemyhit.Location = New System.Drawing.Point(264, 48)
        Me.lblenemyhit.Name = "lblenemyhit"
        Me.lblenemyhit.Size = New System.Drawing.Size(60, 13)
        Me.lblenemyhit.TabIndex = 0
        Me.lblenemyhit.Text = "Enemy Hits"
        '
        'lblcommess
        '
        Me.lblcommess.AutoSize = True
        Me.lblcommess.Location = New System.Drawing.Point(163, 148)
        Me.lblcommess.Name = "lblcommess"
        Me.lblcommess.Size = New System.Drawing.Size(94, 13)
        Me.lblcommess.TabIndex = 0
        Me.lblcommess.Text = "Combat Messages"
        Me.lblcommess.Visible = False
        '
        'lblenemyname
        '
        Me.lblenemyname.AutoSize = True
        Me.lblenemyname.Location = New System.Drawing.Point(382, 4)
        Me.lblenemyname.Name = "lblenemyname"
        Me.lblenemyname.Size = New System.Drawing.Size(70, 13)
        Me.lblenemyname.TabIndex = 0
        Me.lblenemyname.Text = "Enemy Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Energy"
        Me.ToolTip1.SetToolTip(Me.Label2, "Energy is used by spells, abilities, and block")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Health"
        Me.ToolTip1.SetToolTip(Me.Label1, "Health is how much more damage you can take before dying")
        '
        'barenergy
        '
        Me.barenergy.Location = New System.Drawing.Point(296, 303)
        Me.barenergy.Name = "barenergy"
        Me.barenergy.Size = New System.Drawing.Size(169, 17)
        Me.barenergy.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barenergy.TabIndex = 0
        Me.barenergy.Tag = "Your energy"
        '
        'barhealth
        '
        Me.barhealth.Location = New System.Drawing.Point(115, 303)
        Me.barhealth.Name = "barhealth"
        Me.barhealth.Size = New System.Drawing.Size(169, 17)
        Me.barhealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barhealth.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.barhealth, "Your health")
        '
        'grpinv
        '
        Me.grpinv.Controls.Add(Me.Panel2)
        Me.grpinv.Location = New System.Drawing.Point(318, 334)
        Me.grpinv.Name = "grpinv"
        Me.grpinv.Size = New System.Drawing.Size(178, 97)
        Me.grpinv.TabIndex = 0
        Me.grpinv.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnenergypot)
        Me.Panel2.Controls.Add(Me.btnretreat)
        Me.Panel2.Controls.Add(Me.btnhealthpot)
        Me.Panel2.Location = New System.Drawing.Point(9, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(163, 66)
        Me.Panel2.TabIndex = 0
        '
        'btnenergypot
        '
        Me.btnenergypot.Location = New System.Drawing.Point(3, 33)
        Me.btnenergypot.Name = "btnenergypot"
        Me.btnenergypot.Size = New System.Drawing.Size(98, 22)
        Me.btnenergypot.TabIndex = 28
        Me.btnenergypot.Text = "Energy Potion"
        Me.btnenergypot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnenergypot, "Regains 10 energy per potion")
        Me.btnenergypot.UseVisualStyleBackColor = True
        '
        'btnretreat
        '
        Me.btnretreat.Location = New System.Drawing.Point(107, 19)
        Me.btnretreat.Name = "btnretreat"
        Me.btnretreat.Size = New System.Drawing.Size(52, 22)
        Me.btnretreat.TabIndex = 29
        Me.btnretreat.Text = "Retreat"
        Me.ToolTip1.SetToolTip(Me.btnretreat, "Retreat from battle")
        Me.btnretreat.UseVisualStyleBackColor = True
        '
        'btnhealthpot
        '
        Me.btnhealthpot.Location = New System.Drawing.Point(3, 3)
        Me.btnhealthpot.Name = "btnhealthpot"
        Me.btnhealthpot.Size = New System.Drawing.Size(98, 22)
        Me.btnhealthpot.TabIndex = 27
        Me.btnhealthpot.Text = "Health Potion"
        Me.btnhealthpot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnhealthpot, "Heals 10 health per potion")
        Me.btnhealthpot.UseVisualStyleBackColor = True
        '
        'barenemyhealth
        '
        Me.barenemyhealth.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.barenemyhealth.Location = New System.Drawing.Point(236, 4)
        Me.barenemyhealth.Name = "barenemyhealth"
        Me.barenemyhealth.Size = New System.Drawing.Size(134, 13)
        Me.barenemyhealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barenemyhealth.TabIndex = 0
        '
        'grpattack
        '
        Me.grpattack.Controls.Add(Me.Panel1)
        Me.grpattack.Enabled = False
        Me.grpattack.Location = New System.Drawing.Point(4, 334)
        Me.grpattack.Name = "grpattack"
        Me.grpattack.Size = New System.Drawing.Size(317, 97)
        Me.grpattack.TabIndex = 0
        Me.grpattack.TabStop = False
        Me.grpattack.Text = "Battle"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnslice)
        Me.Panel1.Controls.Add(Me.btnstab)
        Me.Panel1.Controls.Add(Me.btnspell4)
        Me.Panel1.Controls.Add(Me.btnspell3)
        Me.Panel1.Controls.Add(Me.btnblock)
        Me.Panel1.Controls.Add(Me.btnspell1)
        Me.Panel1.Controls.Add(Me.btnspell2)
        Me.Panel1.Location = New System.Drawing.Point(6, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 66)
        Me.Panel1.TabIndex = 0
        '
        'btnslice
        '
        Me.btnslice.Location = New System.Drawing.Point(12, 34)
        Me.btnslice.Name = "btnslice"
        Me.btnslice.Size = New System.Drawing.Size(59, 24)
        Me.btnslice.TabIndex = 21
        Me.btnslice.Text = "Slice"
        Me.ToolTip1.SetToolTip(Me.btnslice, "Deals 0-20 Damage")
        Me.btnslice.UseVisualStyleBackColor = True
        '
        'btnstab
        '
        Me.btnstab.Location = New System.Drawing.Point(12, 4)
        Me.btnstab.Name = "btnstab"
        Me.btnstab.Size = New System.Drawing.Size(59, 24)
        Me.btnstab.TabIndex = 20
        Me.btnstab.Text = "Stab"
        Me.ToolTip1.SetToolTip(Me.btnstab, "Deals 0-10 damage")
        Me.btnstab.UseVisualStyleBackColor = True
        '
        'btnspell4
        '
        Me.btnspell4.Location = New System.Drawing.Point(223, 32)
        Me.btnspell4.Name = "btnspell4"
        Me.btnspell4.Size = New System.Drawing.Size(58, 23)
        Me.btnspell4.TabIndex = 26
        Me.btnspell4.UseVisualStyleBackColor = True
        '
        'btnspell3
        '
        Me.btnspell3.Location = New System.Drawing.Point(156, 32)
        Me.btnspell3.Name = "btnspell3"
        Me.btnspell3.Size = New System.Drawing.Size(61, 23)
        Me.btnspell3.TabIndex = 24
        Me.btnspell3.UseVisualStyleBackColor = True
        '
        'btnblock
        '
        Me.btnblock.Location = New System.Drawing.Point(77, 19)
        Me.btnblock.Name = "btnblock"
        Me.btnblock.Size = New System.Drawing.Size(59, 23)
        Me.btnblock.TabIndex = 22
        Me.btnblock.Text = "Block"
        Me.ToolTip1.SetToolTip(Me.btnblock, "Blocks next enemy hit (Costs 20 energy)")
        Me.btnblock.UseVisualStyleBackColor = True
        '
        'btnspell1
        '
        Me.btnspell1.Location = New System.Drawing.Point(156, 3)
        Me.btnspell1.Name = "btnspell1"
        Me.btnspell1.Size = New System.Drawing.Size(61, 24)
        Me.btnspell1.TabIndex = 23
        Me.btnspell1.UseVisualStyleBackColor = True
        '
        'btnspell2
        '
        Me.btnspell2.Location = New System.Drawing.Point(223, 3)
        Me.btnspell2.Name = "btnspell2"
        Me.btnspell2.Size = New System.Drawing.Size(59, 25)
        Me.btnspell2.TabIndex = 25
        Me.btnspell2.UseVisualStyleBackColor = True
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Location = New System.Drawing.Point(117, 235)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(57, 13)
        Me.lblHP.TabIndex = 0
        Me.lblHP.Text = "Player Hits"
        '
        'lblenemyhealth
        '
        Me.lblenemyhealth.AutoSize = True
        Me.lblenemyhealth.Location = New System.Drawing.Point(203, 4)
        Me.lblenemyhealth.Name = "lblenemyhealth"
        Me.lblenemyhealth.Size = New System.Drawing.Size(25, 13)
        Me.lblenemyhealth.TabIndex = 0
        Me.lblenemyhealth.Text = "100"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblmyhealth
        '
        Me.lblmyhealth.AutoSize = True
        Me.lblmyhealth.Location = New System.Drawing.Point(202, 287)
        Me.lblmyhealth.Name = "lblmyhealth"
        Me.lblmyhealth.Size = New System.Drawing.Size(25, 13)
        Me.lblmyhealth.TabIndex = 0
        Me.lblmyhealth.Text = "100"
        Me.ToolTip1.SetToolTip(Me.lblmyhealth, "Your specific amount of health")
        '
        'lblmyenergy
        '
        Me.lblmyenergy.AutoSize = True
        Me.lblmyenergy.Location = New System.Drawing.Point(371, 287)
        Me.lblmyenergy.Name = "lblmyenergy"
        Me.lblmyenergy.Size = New System.Drawing.Size(25, 13)
        Me.lblmyenergy.TabIndex = 0
        Me.lblmyenergy.Text = "100"
        Me.ToolTip1.SetToolTip(Me.lblmyenergy, "Your specific amount of energy")
        '
        'ToolTip1
        '
        '
        'picwar
        '
        Me.picwar.Image = Global.breadQuestReal.My.Resources.Resources.breadplainnew
        Me.picwar.Location = New System.Drawing.Point(4, 213)
        Me.picwar.Name = "picwar"
        Me.picwar.Size = New System.Drawing.Size(107, 118)
        Me.picwar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picwar.TabIndex = 28
        Me.picwar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picwar, "Your character")
        '
        'btncontinue
        '
        Me.btncontinue.Location = New System.Drawing.Point(179, 164)
        Me.btncontinue.Name = "btncontinue"
        Me.btncontinue.Size = New System.Drawing.Size(113, 30)
        Me.btncontinue.TabIndex = 0
        Me.btncontinue.Text = "Continue"
        Me.btncontinue.UseVisualStyleBackColor = True
        Me.btncontinue.Visible = False
        '
        'lblplayername
        '
        Me.lblplayername.AutoSize = True
        Me.lblplayername.Location = New System.Drawing.Point(7, 194)
        Me.lblplayername.Name = "lblplayername"
        Me.lblplayername.Size = New System.Drawing.Size(32, 13)
        Me.lblplayername.TabIndex = 0
        Me.lblplayername.Text = "Pane"
        '
        'lblblock
        '
        Me.lblblock.AutoSize = True
        Me.lblblock.Location = New System.Drawing.Point(117, 253)
        Me.lblblock.Name = "lblblock"
        Me.lblblock.Size = New System.Drawing.Size(66, 13)
        Me.lblblock.TabIndex = 0
        Me.lblblock.Text = "Player Block"
        '
        'lblEDAM
        '
        Me.lblEDAM.AutoSize = True
        Me.lblEDAM.Location = New System.Drawing.Point(176, 48)
        Me.lblEDAM.Name = "lblEDAM"
        Me.lblEDAM.Size = New System.Drawing.Size(63, 13)
        Me.lblEDAM.TabIndex = 0
        Me.lblEDAM.Text = "Raw EDAM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Level"
        '
        'lbllvl
        '
        Me.lbllvl.AutoSize = True
        Me.lbllvl.Location = New System.Drawing.Point(152, 213)
        Me.lbllvl.Name = "lbllvl"
        Me.lbllvl.Size = New System.Drawing.Size(13, 13)
        Me.lbllvl.TabIndex = 0
        Me.lbllvl.Text = "1"
        '
        'lbllvlxp
        '
        Me.lbllvlxp.AutoSize = True
        Me.lbllvlxp.Location = New System.Drawing.Point(117, 194)
        Me.lbllvlxp.Name = "lbllvlxp"
        Me.lbllvlxp.Size = New System.Drawing.Size(13, 13)
        Me.lbllvlxp.TabIndex = 0
        Me.lbllvlxp.Text = "0"
        '
        'barxp
        '
        Me.barxp.Location = New System.Drawing.Point(116, 324)
        Me.barxp.Name = "barxp"
        Me.barxp.Size = New System.Drawing.Size(349, 10)
        Me.barxp.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barxp.TabIndex = 0
        '
        'picwariron
        '
        Me.picwariron.Image = CType(resources.GetObject("picwariron.Image"), System.Drawing.Image)
        Me.picwariron.Location = New System.Drawing.Point(4, 244)
        Me.picwariron.Name = "picwariron"
        Me.picwariron.Size = New System.Drawing.Size(89, 87)
        Me.picwariron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picwariron.TabIndex = 29
        Me.picwariron.TabStop = False
        '
        'picrat
        '
        Me.picrat.Image = Global.breadQuestReal.My.Resources.Resources.plaguerattrans
        Me.picrat.Location = New System.Drawing.Point(343, -9)
        Me.picrat.Name = "picrat"
        Me.picrat.Size = New System.Drawing.Size(163, 126)
        Me.picrat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picrat.TabIndex = 30
        Me.picrat.TabStop = False
        Me.picrat.Visible = False
        '
        'picflea
        '
        Me.picflea.Image = Global.breadQuestReal.My.Resources.Resources.plaguedflea2trans
        Me.picflea.Location = New System.Drawing.Point(330, 20)
        Me.picflea.Name = "picflea"
        Me.picflea.Size = New System.Drawing.Size(176, 124)
        Me.picflea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picflea.TabIndex = 31
        Me.picflea.TabStop = False
        Me.picflea.Visible = False
        '
        'frmbattle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 433)
        Me.Controls.Add(Me.barxp)
        Me.Controls.Add(Me.lbllvlxp)
        Me.Controls.Add(Me.lbllvl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblplayername)
        Me.Controls.Add(Me.lblEDAM)
        Me.Controls.Add(Me.lblblock)
        Me.Controls.Add(Me.btncontinue)
        Me.Controls.Add(Me.lblmyenergy)
        Me.Controls.Add(Me.lblmyhealth)
        Me.Controls.Add(Me.lblenemyhealth)
        Me.Controls.Add(Me.lblHP)
        Me.Controls.Add(Me.lblenemyhit)
        Me.Controls.Add(Me.lblcommess)
        Me.Controls.Add(Me.lblenemyname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barenergy)
        Me.Controls.Add(Me.barhealth)
        Me.Controls.Add(Me.grpinv)
        Me.Controls.Add(Me.barenemyhealth)
        Me.Controls.Add(Me.grpattack)
        Me.Controls.Add(Me.picwar)
        Me.Controls.Add(Me.picwariron)
        Me.Controls.Add(Me.picflea)
        Me.Controls.Add(Me.picrat)
        Me.Name = "frmbattle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bread Quest"
        Me.grpinv.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.grpattack.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.picwar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picwariron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picflea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblenemyhit As System.Windows.Forms.Label
    Friend WithEvents lblcommess As System.Windows.Forms.Label
    Friend WithEvents lblenemyname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents barenergy As System.Windows.Forms.ProgressBar
    Friend WithEvents barhealth As System.Windows.Forms.ProgressBar
    Friend WithEvents grpinv As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnenergypot As System.Windows.Forms.Button
    Friend WithEvents btnretreat As System.Windows.Forms.Button
    Friend WithEvents btnhealthpot As System.Windows.Forms.Button
    Friend WithEvents barenemyhealth As System.Windows.Forms.ProgressBar
    Friend WithEvents grpattack As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnspell1 As System.Windows.Forms.Button
    Friend WithEvents btnblock As System.Windows.Forms.Button
    Friend WithEvents btnspell2 As System.Windows.Forms.Button
    Friend WithEvents btnslice As System.Windows.Forms.Button
    Friend WithEvents btnstab As System.Windows.Forms.Button
    Friend WithEvents lblHP As System.Windows.Forms.Label
    Friend WithEvents lblenemyhealth As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblmyhealth As System.Windows.Forms.Label
    Friend WithEvents lblmyenergy As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnspell4 As System.Windows.Forms.Button
    Friend WithEvents btnspell3 As System.Windows.Forms.Button
    Friend WithEvents picwar As System.Windows.Forms.PictureBox
    Friend WithEvents picwariron As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btncontinue As System.Windows.Forms.Button
    Friend WithEvents lblplayername As System.Windows.Forms.Label
    Friend WithEvents lblblock As System.Windows.Forms.Label
    Friend WithEvents lblEDAM As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbllvl As System.Windows.Forms.Label
    Friend WithEvents lbllvlxp As System.Windows.Forms.Label
    Friend WithEvents barxp As System.Windows.Forms.ProgressBar
    Friend WithEvents picrat As System.Windows.Forms.PictureBox
    Friend WithEvents picflea As System.Windows.Forms.PictureBox
End Class

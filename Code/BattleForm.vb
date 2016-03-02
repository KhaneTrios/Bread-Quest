Public Class frmbattle

    Private Sub frmbattle_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        If Variables.PlayerStats.PlayerXp <= "14" Then
            Variables.PlayerStats.PlayerLvl = "1"
        ElseIf Variables.PlayerStats.PlayerXp <= "24" Then
            Variables.PlayerStats.PlayerLvl = "2"
        ElseIf Variables.PlayerStats.PlayerXp <= "34" Then
            Variables.PlayerStats.PlayerLvl = "3"
        ElseIf Variables.PlayerStats.PlayerXp <= "44" Then
            Variables.PlayerStats.PlayerLvl = "4"
        ElseIf Variables.PlayerStats.PlayerXp <= "54" Then
            Variables.PlayerStats.PlayerLvl = "5"
        ElseIf Variables.PlayerStats.PlayerXp <= "69" Then
            Variables.PlayerStats.PlayerLvl = "6"
        ElseIf Variables.PlayerStats.PlayerXp <= "79" Then
            Variables.PlayerStats.PlayerLvl = "7"
        ElseIf Variables.PlayerStats.PlayerXp <= "94" Then
            Variables.PlayerStats.PlayerLvl = "8"
        ElseIf Variables.PlayerStats.PlayerXp <= "104" Then
            Variables.PlayerStats.PlayerLvl = "9"
        ElseIf Variables.PlayerStats.PlayerXp >= "150" Then
            Variables.PlayerStats.PlayerLvl = "10"
        End If

        lbllvlxp.Text = Variables.PlayerStats.PlayerXp
        lbllvl.Text = Variables.PlayerStats.PlayerLvl


        If Variables.PlayerStats.PlayerCla = "Warrior" Then
            Variables.PlayerStats.PlayerCla = "Warrior" : btnspell1.Text = "Stun"
            If Variables.PlayerStats.PlayerCla = "Warrior" And Variables.PlayerStats.PlayerLvl >= 1 Then
                btnspell1.Text = "Stun" : ToolTip1.SetToolTip(_btnspell1, "Enemy does not attack for one turn (Costs 35 Energy)") : btnspell2.Text = ""
            End If
        End If

        If Variables.PlayerStats.PlayerLvl = "5" Then
            Variables.PlayerStats.PlayerCla = "Warrior" : btnspell3.Text = "Bash" : btnspell3.Text = "Stun" : Variables.PlayerStats.PlayerLvl = "5"
            If Variables.PlayerStats.PlayerCla = "Warrior" And Variables.PlayerStats.PlayerLvl = 5 Then
                btnspell3.Text = "Bash" : ToolTip1.SetToolTip(_btnspell3, "Guaranteed 15 damage (costs 40 energy)")
            End If
        End If


        grpattack.Enabled = True

    'Startup bars'
        barenemyhealth.Value = 100
        barenemyhealth.ForeColor = Color.Red

        barhealth.Value = 100
        barhealth.ForeColor = Color.Red

        barenergy.Value = 100
        barenergy.ForeColor = Color.Blue


        barxp.ForeColor = Color.Yellow

        barxp.ForeColor = Color.Yellow

        If Variables.PlayerStats.PlayerXp = "0" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "1" Then barxp.Value = 5
        If Variables.PlayerStats.PlayerXp = "2" Then barxp.Value = 10
        If Variables.PlayerStats.PlayerXp = "3" Then barxp.Value = 15
        If Variables.PlayerStats.PlayerXp = "4" Then barxp.Value = 20
        If Variables.PlayerStats.PlayerXp = "5" Then barxp.Value = 30
        If Variables.PlayerStats.PlayerXp = "6" Then barxp.Value = 40
        If Variables.PlayerStats.PlayerXp = "7" Then barxp.Value = 50
        If Variables.PlayerStats.PlayerXp = "8" Then barxp.Value = 55
        If Variables.PlayerStats.PlayerXp = "9" Then barxp.Value = 60
        If Variables.PlayerStats.PlayerXp = "10" Then barxp.Value = 65
        If Variables.PlayerStats.PlayerXp = "11" Then barxp.Value = 70
        If Variables.PlayerStats.PlayerXp = "12" Then barxp.Value = 80
        If Variables.PlayerStats.PlayerXp = "13" Then barxp.Value = 90
        If Variables.PlayerStats.PlayerXp = "14" Then barxp.Value = 100
        If Variables.PlayerStats.PlayerXp = "15" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "16" Then barxp.Value = 10
        If Variables.PlayerStats.PlayerXp = "17" Then barxp.Value = 20
        If Variables.PlayerStats.PlayerXp = "18" Then barxp.Value = 30
        If Variables.PlayerStats.PlayerXp = "19" Then barxp.Value = 40
        If Variables.PlayerStats.PlayerXp = "20" Then barxp.Value = 50
        If Variables.PlayerStats.PlayerXp = "21" Then barxp.Value = 60
        If Variables.PlayerStats.PlayerXp = "22" Then barxp.Value = 70
        If Variables.PlayerStats.PlayerXp = "23" Then barxp.Value = 90
        If Variables.PlayerStats.PlayerXp = "24" Then barxp.Value = 100
        If Variables.PlayerStats.PlayerXp = "25" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "26" Then barxp.Value = 10
        If Variables.PlayerStats.PlayerXp = "27" Then barxp.Value = 20
        If Variables.PlayerStats.PlayerXp = "28" Then barxp.Value = 30
        If Variables.PlayerStats.PlayerXp = "29" Then barxp.Value = 40
        If Variables.PlayerStats.PlayerXp = "30" Then barxp.Value = 50
        If Variables.PlayerStats.PlayerXp = "31" Then barxp.Value = 60
        If Variables.PlayerStats.PlayerXp = "32" Then barxp.Value = 70
        If Variables.PlayerStats.PlayerXp = "33" Then barxp.Value = 90
        If Variables.PlayerStats.PlayerXp = "34" Then barxp.Value = 100
        If Variables.PlayerStats.PlayerXp = "35" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "36" Then barxp.Value = 10
        If Variables.PlayerStats.PlayerXp = "37" Then barxp.Value = 20
        If Variables.PlayerStats.PlayerXp = "38" Then barxp.Value = 30
        If Variables.PlayerStats.PlayerXp = "39" Then barxp.Value = 40
        If Variables.PlayerStats.PlayerXp = "40" Then barxp.Value = 50
        If Variables.PlayerStats.PlayerXp = "41" Then barxp.Value = 60
        If Variables.PlayerStats.PlayerXp = "42" Then barxp.Value = 70
        If Variables.PlayerStats.PlayerXp = "43" Then barxp.Value = 90
        If Variables.PlayerStats.PlayerXp = "44" Then barxp.Value = 100
        If Variables.PlayerStats.PlayerXp = "45" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "46" Then barxp.Value = 10
        If Variables.PlayerStats.PlayerXp = "47" Then barxp.Value = 20
        If Variables.PlayerStats.PlayerXp = "48" Then barxp.Value = 30
        If Variables.PlayerStats.PlayerXp = "49" Then barxp.Value = 40
        If Variables.PlayerStats.PlayerXp = "50" Then barxp.Value = 50
        If Variables.PlayerStats.PlayerXp = "51" Then barxp.Value = 60
        If Variables.PlayerStats.PlayerXp = "52" Then barxp.Value = 70
        If Variables.PlayerStats.PlayerXp = "52" Then barxp.Value = 80
        If Variables.PlayerStats.PlayerXp = "53" Then barxp.Value = 90
        If Variables.PlayerStats.PlayerXp = "54" Then barxp.Value = 100
        If Variables.PlayerStats.PlayerXp = "55" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "56" Then barxp.Value = 10
        If Variables.PlayerStats.PlayerXp = "57" Then barxp.Value = 20
        If Variables.PlayerStats.PlayerXp = "58" Then barxp.Value = 30
        If Variables.PlayerStats.PlayerXp = "59" Then barxp.Value = 40
        If Variables.PlayerStats.PlayerXp = "60" Then barxp.Value = 50
        If Variables.PlayerStats.PlayerXp = "61" Then barxp.Value = 60
        If Variables.PlayerStats.PlayerXp = "62" Then barxp.Value = 65
        If Variables.PlayerStats.PlayerXp = "63" Then barxp.Value = 70
        If Variables.PlayerStats.PlayerXp = "64" Then barxp.Value = 75
        If Variables.PlayerStats.PlayerXp = "65" Then barxp.Value = 80
        If Variables.PlayerStats.PlayerXp = "66" Then barxp.Value = 85
        If Variables.PlayerStats.PlayerXp = "67" Then barxp.Value = 90
        If Variables.PlayerStats.PlayerXp = "68" Then barxp.Value = 95
        If Variables.PlayerStats.PlayerXp = "69" Then barxp.Value = 100
        If Variables.PlayerStats.PlayerXp = "70" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "71" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "72" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "73" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "74" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "75" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "76" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "77" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "78" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "79" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "80" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "81" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "82" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "83" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "84" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "85" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "86" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "87" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "88" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "89" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "90" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "91" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "92" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "93" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "94" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "95" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "96" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "97" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "98" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "98" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "100" Then barxp.Value = 100
        If Variables.PlayerStats.PlayerXp = "101" Then barxp.Value = 5
        If Variables.PlayerStats.PlayerXp = "102" Then barxp.Value = 10
        If Variables.PlayerStats.PlayerXp = "103" Then barxp.Value = 15
        If Variables.PlayerStats.PlayerXp = "104" Then barxp.Value = 20
        If Variables.PlayerStats.PlayerXp = "105" Then barxp.Value = 30
        If Variables.PlayerStats.PlayerXp = "106" Then barxp.Value = 40
        If Variables.PlayerStats.PlayerXp = "107" Then barxp.Value = 50
        If Variables.PlayerStats.PlayerXp = "108" Then barxp.Value = 55
        If Variables.PlayerStats.PlayerXp = "109" Then barxp.Value = 60
        If Variables.PlayerStats.PlayerXp = "110" Then barxp.Value = 65
        If Variables.PlayerStats.PlayerXp = "111" Then barxp.Value = 70
        If Variables.PlayerStats.PlayerXp = "112" Then barxp.Value = 80
        If Variables.PlayerStats.PlayerXp = "113" Then barxp.Value = 80
        If Variables.PlayerStats.PlayerXp = "114" Then barxp.Value = 100
        If Variables.PlayerStats.PlayerXp = "115" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "116" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "117" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "118" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "119" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "120" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "121" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "122" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "123" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "124" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "125" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "126" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "127" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "128" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "129" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "130" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "131" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "132" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "133" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "134" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "135" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "136" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "137" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "138" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "139" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "140" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "141" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "142" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "143" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "144" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "145" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "146" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "147" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "148" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "149" Then barxp.Value = 0
        If Variables.PlayerStats.PlayerXp = "150" Then barxp.Value = 100

        'Potions
        btnhealthpot.Text = "Health Potion (" & Variables.healthpotions & ")"
        btnenergypot.Text = "Energy Potion (" & Variables.energypotions & ")"


    'Startup names
        If Variables.EnemyGenerating.EnemyNo = 1 Then
            Variables.EnemyGenerating.EnemyNa = "Plagued Flea" : picflea.Visible = True
        ElseIf Variables.EnemyGenerating.EnemyNo = 2 Then
            Variables.EnemyGenerating.EnemyNa = "Plagued Rat" : picrat.Visible = True
        ElseIf Variables.EnemyGenerating.EnemyNo = 3 Then
            Variables.EnemyGenerating.EnemyNa = "Plagued Knight"
        End If

        lblenemyname.Text = Variables.EnemyGenerating.EnemyNa

    'Startup music
        My.Computer.Audio.Play("E:\breadQuestReal\breadQuestReal\Resources\Carnage.wav", AudioPlayMode.Background)

    End Sub


    Private Sub barenemyhealth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barenemyhealth.MouseClick
        barenemyhealth.Maximum = 100
        barenemyhealth.Minimum = 0

        barenemyhealth.ForeColor = Color.Red

        If barenemyhealth.Value <= 0 Then barenemyhealth.Enabled = False

    End Sub
    Private Sub btnstab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstab.Click
        'Stab Attack

        grpattack.Enabled = False
        grpinv.Enabled = False

        'Randomly generate amount of hitpoints dealt from attack
        Randomize() ' Initializes the random-number generator, otherwise each time you run your

        'program, the sequence of numbers will be the same

        'Hitpoint range of attack
        Variables.PlayerCombat.Hitpoints = ((10 * Rnd()) + 0) '// Generate random value between the range you set

        'Player's Hitpoint addition
        lblHP.Text = Val(Variables.PlayerCombat.Hitpoints)
        My.Application.DoEvents()
        lblenemyhealth.Text = Val(lblenemyhealth.Text) - Val(Variables.PlayerCombat.Hitpoints)
        If Val(lblenemyhealth.Text) <= 0 Then
            barenemyhealth.Enabled = False
            lblenemyhealth.Text = "0"
            My.Application.DoEvents()
        End If



        'Enemy health bar
        barenemyhealth.Value = Val(lblenemyhealth.Text)
        My.Application.DoEvents()
        If Val(lblenemyhealth.Text) <= 0 Then
            lblenemyhealth.Enabled = False
        ElseIf Val(lblenemyhealth.Text) <= 0 Then
            barenemyhealth.Value = 0
            My.Application.DoEvents()
        End If


        'Combat messages
        If Variables.PlayerCombat.Hitpoints = 0 Then
            lblcommess.Visible = True : lblcommess.Text = "You missed!"
        ElseIf lblenemyhealth.Text = "0" Then
            lblcommess.Visible = True : lblcommess.Text = "You defeated, " & Variables.EnemyGenerating.EnemyNa & "!"
        ElseIf lblenemyhit.Text = "0" Then
            lblcommess.Visible = True : grpattack.Enabled = False : grpinv.Enabled = False : lblcommess.Text = "" & Variables.EnemyGenerating.EnemyNa & " missed!"
        Else : lblcommess.Visible = False
        End If



        If lblenemyhealth.Text = "0" Then
            grpattack.Enabled = False : grpinv.Enabled = False : btncontinue.Visible = True
        End If

        'delay
        System.Threading.Thread.Sleep(1000)

        'Enemy's hitpoint addition
        If Variables.PlayerCombat.Stunactive = "Yes" Then
            Variables.EnemyCombat.EDAM = 0 : Variables.PlayerCombat.Stunactive = "No"
        End If
        If Variables.EnemyGenerating.EnemyNo = 1 Then
            Variables.EnemyCombat.EDAM = ((10 * Rnd()) + 0)
            My.Application.DoEvents()
            lblenemyhit.Text = Val(Variables.EnemyCombat.EDAM)
            lblmyhealth.Text = Val(lblmyhealth.Text) - Val(Variables.EnemyCombat.EDAM)
        ElseIf Variables.EnemyGenerating.EnemyNo = 2 Then
            Variables.EnemyCombat.EDAM = ((20 * Rnd()) + 0)
            My.Application.DoEvents()
            lblenemyhit.Text = Val(Variables.EnemyCombat.EDAM)
            lblmyhealth.Text = Val(lblmyhealth.Text) - Val(Variables.EnemyCombat.EDAM)
        ElseIf Variables.EnemyGenerating.EnemyNo = 3 Then
            Variables.EnemyCombat.EDAM = ((30 * Rnd()) + 0)
            My.Application.DoEvents()
            lblenemyhit.Text = Val(Variables.EnemyCombat.EDAM)
            lblmyhealth.Text = Val(lblmyhealth.Text) - Val(Variables.EnemyCombat.EDAM)
        End If
        If Val(lblmyhealth.Text) <= 0 Then
            barhealth.Enabled = False
            lblmyhealth.Text = "0"
            My.Application.DoEvents()
        End If



        'Player's health bar
        barhealth.Value = Val(lblmyhealth.Text)
        My.Application.DoEvents()
        If Val(lblmyhealth.Text) <= 0 Then
            lblmyhealth.Enabled = False
        ElseIf Val(lblmyhealth.Text) <= 0 Then
            barhealth.Value = 0
            My.Application.DoEvents()
        End If



        If lblmyhealth.Text <= 0 Then
            Select Case MsgBox("You have died.", MsgBoxStyle.OkOnly, "You have lost")
                Case MsgBoxResult.Ok
                    frmmainmenu.Show()
                    Me.Close()
            End Select
        End If



        grpattack.Enabled = True
        grpinv.Enabled = True

    End Sub

    Private Sub btnslice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnslice.Click
        'Slice attack
        grpattack.Enabled = False
        grpinv.Enabled = False


        'Randomly generate amount of hitpoints dealt from attack
        Randomize() ' Initializes the random-number generator, otherwise each time you run your

        'program, the sequence of numbers will be the same

        Variables.PlayerCombat.Hitpoints = ((20 * Rnd()) + 0) '// Generate random value between the range you set

        'Player's Hitpoint addition
        lblHP.Text = Val(Variables.PlayerCombat.Hitpoints)
        My.Application.DoEvents()
        lblenemyhealth.Text = Val(lblenemyhealth.Text) - Val(Variables.PlayerCombat.Hitpoints)
        If Val(lblenemyhealth.Text) <= 0 Then
            barenemyhealth.Enabled = False
            lblenemyhealth.Text = "0"
            My.Application.DoEvents()
        End If



        'Enemy health bar
        barenemyhealth.Value = Val(lblenemyhealth.Text)
        My.Application.DoEvents()
        If Val(lblenemyhealth.Text) <= 0 Then
            lblenemyhealth.Enabled = False
        ElseIf Val(lblenemyhealth.Text) <= 0 Then
            barenemyhealth.Value = 0
            My.Application.DoEvents()
        End If


        'Combat messages
        If Variables.PlayerCombat.Hitpoints = 0 Then
            lblcommess.Visible = True : lblcommess.Text = "You missed!"
        ElseIf lblenemyhealth.Text = "0" Then
            lblcommess.Visible = True : grpattack.Enabled = False : grpinv.Enabled = False : lblcommess.Text = "You defeated, " & Variables.EnemyGenerating.EnemyNa & "!"
        ElseIf lblenemyhit.Text = "0" Then
            lblcommess.Visible = True : lblcommess.Text = "" & Variables.EnemyGenerating.EnemyNa & " missed!"
        Else : lblcommess.Visible = False
        End If



        If lblenemyhealth.Text = "0" Then
            grpattack.Enabled = False : grpinv.Enabled = False : btncontinue.Visible = True
        End If

        'delay
        System.Threading.Thread.Sleep(1000)

        'Enemy's hitpoint addition
        If Variables.PlayerCombat.Stunactive = "Yes" Then
            Variables.EnemyCombat.EDAM = 0 : Variables.PlayerCombat.Stunactive = "No"
        End If
        If Variables.EnemyGenerating.EnemyNo = 1 Then
            Variables.EnemyCombat.EDAM = ((10 * Rnd()) + 0)
            My.Application.DoEvents()
            lblenemyhit.Text = Val(Variables.EnemyCombat.EDAM)
            lblmyhealth.Text = Val(lblmyhealth.Text) - Val(Variables.EnemyCombat.EDAM)
        ElseIf Variables.EnemyGenerating.EnemyNo = 2 Then
            Variables.EnemyCombat.EDAM = ((20 * Rnd()) + 0)
            My.Application.DoEvents()
            lblenemyhit.Text = Val(Variables.EnemyCombat.EDAM)
            lblmyhealth.Text = Val(lblmyhealth.Text) - Val(Variables.EnemyCombat.EDAM)
        ElseIf Variables.EnemyGenerating.EnemyNo = 3 Then
            Variables.EnemyCombat.EDAM = ((30 * Rnd()) + 0)
            My.Application.DoEvents()
            lblenemyhit.Text = Val(Variables.EnemyCombat.EDAM)
            lblmyhealth.Text = Val(lblmyhealth.Text) - Val(Variables.EnemyCombat.EDAM)
        End If
        If Val(lblmyhealth.Text) <= 0 Then
            barhealth.Enabled = False
            lblmyhealth.Text = "0"
            My.Application.DoEvents()
        End If


        'Player's health bar
        barhealth.Value = Val(lblmyhealth.Text)
        My.Application.DoEvents()
        If Val(lblmyhealth.Text) <= 0 Then
            lblmyhealth.Enabled = False
        ElseIf Val(lblmyhealth.Text) <= 0 Then
            barhealth.Value = 0
            My.Application.DoEvents()
        End If



        If lblmyhealth.Text <= 0 Then
            Select Case MsgBox("You have died.", MsgBoxStyle.OkOnly, "You have lost")
                Case MsgBoxResult.Ok
                    frmmainmenu.Show()
                    Me.Close()
            End Select
        End If



        grpattack.Enabled = True
        grpinv.Enabled = True

    End Sub

    Private Sub btnretreat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnretreat.Click
        'Retreat confirmation prompt
        Select Case MsgBox("Are you sure you want to retreat?", MsgBoxStyle.YesNo, "Retreat?")
            Case MsgBoxResult.Yes
                Me.Close()
            Case MsgBoxResult.No

        End Select

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcommess.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub lblenemyname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblenemyname.Click

    End Sub

    Private Sub barenemyhealth_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barenemyhealth.Click

    End Sub

    Private Sub btncontinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncontinue.Click
        'End of battle continue button

        Randomize()
        If Variables.EnemyGenerating.EnemyNo = 1 Then
            Variables.Xp = ((10 * Rnd()) + 5) : Variables.healthpotions = ((10 * Rnd()) + 0) : Variables.energypotions = ((10 * Rnd()) + 0)
        ElseIf Variables.EnemyGenerating.EnemyNo = 2 Then
            Variables.Xp = ((15 * Rnd()) + 10) : Variables.healthpotions = ((20 * Rnd()) + 0) : Variables.energypotions = ((20 * Rnd()) + 0)
        ElseIf Variables.EnemyGenerating.EnemyNo = 3 Then
            Variables.Xp = ((20 * Rnd()) + 15) : Variables.healthpotions = ((30 * Rnd()) + 0) : Variables.energypotions = ((30 * Rnd()) + 0)
        ElseIf Variables.EnemyGenerating.EnemyNo = 4 Then
            Variables.Xp = 45 : Variables.healthpotions = ((40 * Rnd()) + 0) : Variables.energypotions = ((40 * Rnd()) + 0)
        End If


        If Variables.healthpotions <= 5 And Variables.healthpotions >= 0 Then
            Variables.healthpotions = 0
        ElseIf Variables.healthpotions <= 10 And Variables.healthpotions > 5 Then
            Variables.healthpotions = 1
        ElseIf Variables.healthpotions <= 15 And Variables.healthpotions > 10 Then
            Variables.healthpotions = 0
        ElseIf Variables.healthpotions <= 20 And Variables.healthpotions > 15 Then
            Variables.healthpotions = 2
        ElseIf Variables.healthpotions <= 25 And Variables.healthpotions > 20 Then
            Variables.healthpotions = 0
        ElseIf Variables.healthpotions <= 30 And Variables.healthpotions > 25 Then
            Variables.healthpotions = 3
        ElseIf Variables.healthpotions <= 35 And Variables.healthpotions > 30 Then
            Variables.healthpotions = 0
        ElseIf Variables.healthpotions <= 40 And Variables.healthpotions > 35 Then
            Variables.healthpotions = 4
        End If

        If Variables.energypotions <= 5 And Variables.energypotions >= 0 Then
            Variables.energypotions = 0
        ElseIf Variables.energypotions <= 10 And Variables.energypotions > 5 Then
            Variables.energypotions = 1
        ElseIf Variables.energypotions <= 15 And Variables.energypotions > 10 Then
            Variables.energypotions = 0
        ElseIf Variables.energypotions <= 20 And Variables.energypotions > 15 Then
            Variables.energypotions = 2
        ElseIf Variables.energypotions <= 25 And Variables.energypotions > 20 Then
            Variables.energypotions = 0
        ElseIf Variables.energypotions <= 30 And Variables.energypotions > 25 Then
            Variables.energypotions = 3
        ElseIf Variables.energypotions <= 35 And Variables.energypotions > 30 Then
            Variables.energypotions = 0
        ElseIf Variables.energypotions <= 40 And Variables.energypotions > 35 Then
            Variables.energypotions = 4
        End If


        Variables.PlayerStats.PlayerXp = Variables.Xp + Variables.PlayerStats.PlayerXp

        My.Application.DoEvents()

        Select Case MsgBox("You gained " & Variables.Xp & " Experience. You gained " & Variables.healthpotions & " health potion(s). You gained " & Variables.energypotions & " energy potion(s).", MsgBoxStyle.OkOnly, "You Won!")
            Case MsgBoxResult.Ok
                frmmove.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub btnblock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnblock.Click
        'Block move
        grpattack.Enabled = False
        grpinv.Enabled = False


        lblcommess.Visible = True : lblcommess.Text = "Block!"
        My.Application.DoEvents()


        'Player's health bar
        barenergy.Value = Val(lblmyenergy.Text)
        My.Application.DoEvents()
        lblmyenergy.Text = Val(lblmyenergy.Text) - Val(20)
        If Val(lblmyenergy.Text) <= 0 Then
            lblmyenergy.Enabled = False
        ElseIf Val(lblmyenergy.Text) <= 0 Then
            barenergy.Value = 0
            My.Application.DoEvents()
        End If

        If lblmyenergy.Text <= 0 Then
            MsgBox("Not enough energy to use block.", MsgBoxStyle.OkOnly, "Not Enough Energy")
        End If

        

        If lblenemyhealth.Text = "0" Then
            grpattack.Enabled = False : grpinv.Enabled = False : btncontinue.Visible = True
        End If


        'delay
        System.Threading.Thread.Sleep(1000)

        'Enemy's hitpoint addition
        Variables.EnemyCombat.EDAM = 0
        lblenemyhit.Text = 0
        My.Application.DoEvents()


        'Player's health bar
        barhealth.Value = lblmyhealth.Text
        If Val(lblmyhealth.Text) >= 100 Then
            barhealth.Value = 100
        ElseIf Val(lblmyhealth.Text) <= 0 Then
            lblmyhealth.Enabled = False
        ElseIf Val(lblmyhealth.Text) <= 0 Then
            barhealth.Value = 0
            My.Application.DoEvents()
        End If

        'No Negative Health
        If Val(lblmyhealth.Text) <= 0 Then
            barhealth.Enabled = False
            lblmyhealth.Text = "0"
            My.Application.DoEvents()
        End If


        If lblmyhealth.Text <= 0 Then
            Select Case MsgBox("You have died.", MsgBoxStyle.OkOnly, "You have lost")
                Case MsgBoxResult.Ok
                    frmmainmenu.Show()
                    Me.Close()
            End Select
        End If


        grpattack.Enabled = True
        grpinv.Enabled = True

    End Sub

    Private Sub btnhealthpot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhealthpot.Click
        'Health Potion

        Variables.healthpotions = Variables.healthpotions - Val(1)

        btnhealthpot.Text = "Health Potion (" & Variables.healthpotions & ")"

        My.Application.DoEvents()

        System.Threading.Thread.Sleep(1000)

        If Variables.healthpotions = 0 Then
            MsgBox("You have no health potions.", MsgBoxStyle.OkOnly, "No Health Potions")
        ElseIf lblmyhealth.Text = Val(lblmyhealth.Text) + Val(10) Then
        End If

        lblmyhealth.Text = Val(lblmyhealth.Text) + Val(10)

        'Health bar
        If Val(lblmyhealth.Text) >= 100 Then
            lblmyhealth.Text = 100 : MsgBox("You already have full health.", MsgBoxStyle.OkOnly, "Health full")
        End If

        barhealth.Value = Val(lblmyhealth.Text)


    End Sub

    Private Sub btnenergypot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenergypot.Click
        'Energy Potion
        Variables.energypotions = Variables.energypotions - Val(1)

        btnenergypot.Text = "Energy Potion (" & Variables.energypotions & ")"

        My.Application.DoEvents()

        System.Threading.Thread.Sleep(1000)

        If Variables.energypotions = 0 Then
            MsgBox("You have no energy potions.", MsgBoxStyle.OkOnly, "No Energy Potions")
        ElseIf lblmyenergy.Text = Val(lblmyenergy.Text) + Val(10) Then
        End If


        'Energy bar
        If Val(lblmyenergy.Text) >= 100 Then
            lblmyenergy.Text = 100 : MsgBox("You already have full energy.", MsgBoxStyle.OkOnly, "Energy full")
        End If

        barenergy.Value = Val(lblmyenergy.Text)

    End Sub

    Private Sub btnspell1_Click(sender As System.Object, e As System.EventArgs) Handles btnspell1.Click
        'Warrior Stun
        If btnspell1.Text = "Stun" Then
            Variables.PlayerCombat.Stunactive = "Yes"
            'Energy bar

            barenergy.Value = lblmyenergy.Text
            lblmyenergy.Text = Val(lblmyenergy.Text) - Val(30)
            If lblmyenergy.Text <= 0 Then
                lblmyenergy.Text = "0" : MsgBox("Not enough energy to use Stun", MsgBoxStyle.OkOnly, "Not enough energy.") : Variables.PlayerCombat.Stunactive = "No"
                barenergy.Value = lblmyenergy.Text
            End If

            'Enemy's hitpoint addition
            Variables.EnemyCombat.EDAM = 0
            lblenemyhit.Text = 0
            lblcommess.Visible = True
            lblcommess.Text = "" & Variables.EnemyGenerating.EnemyNa & " is stunned."

        End If

    End Sub

    Private Sub btnspell4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnspell4.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnspell3_Click(sender As System.Object, e As System.EventArgs) Handles btnspell3.Click
        'Warrior Bash
        If btnspell3.Text = "Bash" Then

            'Energy bar
            barenergy.Value = lblmyenergy.Text
            lblmyenergy.Text = Val(lblmyenergy.Text) - Val(30)
            If lblmyenergy.Text <= 0 Then
                lblmyenergy.Text = "0" : MsgBox("Not enough energy to use Bash", MsgBoxStyle.OkOnly, "Not enough energy.") : Variables.PlayerCombat.Stunactive = "No"

            End If



            If lblenemyhealth.Text = "0" Then
                grpattack.Enabled = False : grpinv.Enabled = False : btncontinue.Visible = True
            End If

            Variables.PlayerCombat.Hitpoints = 15

            'Player's Hitpoint addition
            lblHP.Text = Val(Variables.PlayerCombat.Hitpoints)
            My.Application.DoEvents()
            lblenemyhealth.Text = Val(lblenemyhealth.Text) - Val(Variables.PlayerCombat.Hitpoints)
            If Val(lblenemyhealth.Text) <= 0 Then
                barenemyhealth.Enabled = False
                lblenemyhealth.Text = "0"
                My.Application.DoEvents()
            End If

            System.Threading.Thread.Sleep(1000)

            'Enemy's hitpoint addition
            If Variables.PlayerCombat.Stunactive = "Yes" Then
                Variables.EnemyCombat.EDAM = 0 : Variables.PlayerCombat.Stunactive = "No"
            Else : Variables.EnemyCombat.EDAM = ((10 * Rnd()) + 0)
                My.Application.DoEvents()
                lblenemyhit.Text = Val(Variables.EnemyCombat.EDAM)
                lblmyhealth.Text = Val(lblmyhealth.Text) - Val(Variables.EnemyCombat.EDAM)
            End If
            If Val(lblmyhealth.Text) <= 0 Then
                barhealth.Enabled = False
                lblmyhealth.Text = "0"
                My.Application.DoEvents()
            End If
        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barxp.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles picflea.Click

    End Sub

    Private Sub barhealth_Click(sender As System.Object, e As System.EventArgs) Handles barhealth.Click

    End Sub
End Class
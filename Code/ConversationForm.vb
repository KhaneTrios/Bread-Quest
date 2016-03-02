Public Class frmconvo
    Dim PlayerClass As String
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_title.Click
    End Sub
    Private Sub picbx_lady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picbx_user.Click
    End Sub
    Private Sub btn_continue2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_continue2.Click
        lbl_convo.Visible = True
        If lbl_clicks.Text = "Clicks 1" Then
            picbx_user.Visible = False : picbx_talk.Visible = True : picbx_lady.Visible = True : lbl_player.Visible = True : lbl_lady.Visible = True
            lbl_convo.Text = "Can you spare me some food you hag?" : lbl_clicks.Text = "Clicks 2"
            lbl_title.Visible = False
        ElseIf lbl_clicks.Text = "Clicks 2" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = False : picbxangrytalk.Visible = True
            lbl_convo.Text = "You little disrespectful punk, your lucky I will even offer anything at this point!" : lbl_clicks.Text = "Clicks 3"
        ElseIf lbl_clicks.Text = "Clicks 3" Then
            picbx_user.Visible = False : picbx_talk.Visible = True : picbx_lady.Visible = True : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "Yea, so are you going to give me something or not?" : lbl_clicks.Text = "Clicks 4"
        ElseIf lbl_clicks.Text = "Clicks 4" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = False : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = True
            lbl_convo.Text = "Well, I have bread." : lbl_clicks.Text = "Clicks 5"
        ElseIf lbl_clicks.Text = "Clicks 5" Then
            picbx_user.Visible = False : picbx_talk.Visible = True : picbx_lady.Visible = True : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "Wow, that is all you can do. I hate bread! Bread is for the birds you crazy lady!" : lbl_clicks.Text = "Clicks 6"
        ElseIf lbl_clicks.Text = "Clicks 6" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = False : picbxangrytalk.Visible = True : picbx_ladytalk.Visible = False
            lbl_convo.Text = "You pathetic boy, its bread or nothing! I have white, italian, or rye. Take your pick." : lbl_clicks.Text = "Clicks 7"
            lbl_123.Visible = False
            lbl1.Visible = True : lbl1.Text = "White"
            lbl2.Visible = True : lbl2.Text = "Italian"
            lbl3.Visible = True : lbl3.Text = "Rye"
            btn_continue2.Visible = False
            lbl_classchose.Visible = True : lbl_classchose.Text = "Choose your bread... and choose wisely."
        ElseIf lbl_clicks.Text = "Clicks 7" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = True : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = False
            lbl_title.Text = "You take your slice and as your walking away, you throw it to the ground. The lady replys, Beggars can't " + ControlChars.NewLine + "be choosers, fool. Then she pulls out a something that looks like a wand, but very old." + ControlChars.NewLine + "Then she waves it and in seconds a wave of blue swirls around you as youturn into the bread, but soggy." : lbl_clicks.Text = "Clicks 8"
            lbl_classchose.Visible = False
            lbl_title.Visible = True
            lbl_convo.Visible = False
        ElseIf lbl_clicks.Text = "Clicks 8" Then
            lbl_title.Visible = False
            picbx_user.Visible = False : picbx_talk.Visible = False : picbx_lady.Visible = True : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "What's going on?" : lbl_clicks.Text = "Clicks 9"
        ElseIf lbl_clicks.Text = "Clicks 9" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = False : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = True : pic_bread.Visible = True
            lbl_convo.Text = "I have cast a curse on you and you will turn soggy at a contstant rate until you make it to the toaster in a dungeon in Rome, before you become completely soggy." : lbl_clicks.Text = "Clicks 10"
        ElseIf lbl_clicks.Text = "Clicks 10" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = True : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = False : pic_breadtalk.Visible = True : pic_bread.Visible = False
            lbl_convo.Text = "Why would you do this you crazy psycho!" : lbl_clicks.Text = "Clicks 11"
        ElseIf lbl_clicks.Text = "Clicks 11" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = False : picbxangrytalk.Visible = True : picbx_ladytalk.Visible = False : pic_bread.Visible = True
            lbl_convo.Text = "You fool, try and beg me, then throw it away. Do you know who I am." : lbl_clicks.Text = "Clicks 12"
            lbl_123.Visible = True
            lbl1.Visible = True : lbl1.Text = "No."
            lbl2.Visible = True : lbl2.Text = "Yes? (lie)"
            lbl3.Visible = True : lbl3.Text = "Like I care!"
            btn_continue2.Visible = False
        ElseIf lbl_clicks.Text = "Clicks 12" Then
            lbl_lady.Text = "Witch of Arezzo"
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = True : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = False : pic_bread.Visible = False : pic_breadtalk.Visible = True
            lbl_convo.Text = "What am I to do now?" : lbl_clicks.Text = "Clicks 13"
        ElseIf lbl_clicks.Text = "Clicks 13" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = False : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = True
            lbl_convo.Text = "Like I said fool, you will go on a quest to the toaster in Rome, which is the only source of cure for you. If you do not reach the toaster in time, you will become completely soggy and deteriorate! HAHAHA!" : lbl_clicks.Text = "Clicks 14"
        ElseIf lbl_clicks.Text = "Clicks 14" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = True : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = False : pic_bread.Visible = False : pic_breadtalk.Visible = True
            lbl_convo.Text = "What am I going to be encountering?" : lbl_clicks.Text = "Clicks 15"
        ElseIf lbl_clicks.Text = "Clicks 15" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = False : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = True : pic_bread.Visible = True
            lbl_convo.Text = "You will have to fight your way through the plaque!" : lbl_clicks.Text = "Clicks 16"
        ElseIf lbl_clicks.Text = "Clicks 16" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = True : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = False : pic_bread.Visible = False : pic_breadtalk.Visible = True
            lbl_convo.Text = "I am not a fighter, how am I supposed to survive and make it through the plaque?" : lbl_clicks.Text = "Clicks 17"
        ElseIf lbl_clicks.Text = "Clicks 17" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = False : picbxangrytalk.Visible = False : picbx_ladytalk.Visible = True : pic_bread.Visible = True
            lbl_convo.Text = "You will fend for yourself. You seem to have survived well as a peasant, I'm sure you can survive this" : lbl_clicks.Text = "Clicks 18"
        ElseIf lbl_clicks.Text = "Clicks 18" Then
            picbx_user.Visible = True : picbx_talk.Visible = False : picbx_lady.Visible = False : picbxangrytalk.Visible = True : picbx_ladytalk.Visible = False
            lbl_convo.Text = "Now get out of my sight before I turn you completely soggy here and now!" : lbl_clicks.Text = "Clicks 19"
            lbl_title.Text = "THE JOURNEY BEGINS NOW!"
            lbl_title.Visible = True
        ElseIf lbl_clicks.Text = "Clicks 19" Then
            frmmove.Show()
            Me.Close()

        End If
    End Sub

    Private Sub frmconvo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbl_clicks_Click(sender As System.Object, e As System.EventArgs) Handles lbl_clicks.Click

    End Sub

    Private Sub lbl1_Click_1(sender As System.Object, e As System.EventArgs) Handles lbl1.Click
        If lbl1.Text = "White" Then
            Variables.PlayerStats.PlayerCla = "Warrior"
            lbl_classchose.Text = "You chose the path of the " & Variables.PlayerStats.PlayerCla & "."
            lbl_convo.Visible = False
            lbl1.Visible = False
            lbl2.Visible = False
            lbl3.Visible = False
            lbl_123.Visible = False
            btn_continue2.Visible = True

        ElseIf lbl1.Text = "No." Then
            lbl_convo.Text = "I am the witch of Arezzo! So how dare you come upon me with such disrespect and attitude!"
            lbl1.Visible = False
            lbl2.Visible = False
            lbl3.Visible = False
            lbl_123.Visible = False
            btn_continue2.Visible = True
        End If
    End Sub

    Private Sub lbl2_Click(sender As System.Object, e As System.EventArgs) Handles lbl2.Click
        If lbl2.Text = "Italian" Then
            Variables.PlayerStats.PlayerCla = "Archer"
            lbl_classchose.Text = "You chose the path of the " & Variables.PlayerStats.PlayerCla & "."
            lbl_convo.Visible = False
            lbl1.Visible = False
            lbl2.Visible = False
            lbl3.Visible = False
            lbl_123.Visible = False
            btn_continue2.Visible = True


        ElseIf lbl2.Text = "Yes? (lie)" Then
            lbl_convo.Text = "You dare lie to me. I should lynch you where you stand. I am the witch of Arezzo!"
            lbl1.Visible = False
            lbl2.Visible = False
            lbl3.Visible = False
            lbl_123.Visible = False
            btn_continue2.Visible = True
        End If

    End Sub

    Private Sub lbl3_Click(sender As System.Object, e As System.EventArgs) Handles lbl3.Click
        If lbl3.Text = "Rye" Then
            Variables.PlayerStats.PlayerCla = "Mage"
            lbl_classchose.Text = "You chose the path of the " & Variables.PlayerStats.PlayerCla & "."
            lbl_convo.Visible = False
            lbl1.Visible = False
            lbl2.Visible = False
            lbl3.Visible = False
            lbl_123.Visible = False
            btn_continue2.Visible = True


        ElseIf lbl3.Text = "Like I care!" Then
            lbl_convo.Text = "I am the witch of Arezzo. Soon enough you will care!"
            lbl1.Visible = False
            lbl2.Visible = False
            lbl3.Visible = False
            lbl_123.Visible = False
            btn_continue2.Visible = True
        End If

    End Sub

    Private Sub lbl_convo_Click(sender As System.Object, e As System.EventArgs) Handles lbl_convo.Click

    End Sub

    Private Sub btnstart_Click(sender As System.Object, e As System.EventArgs)
    End Sub
    Private Sub Label1_Click_2(sender As System.Object, e As System.EventArgs) Handles lbl_classchose.Click

    End Sub

    Private Sub picbx_lady_Click_1(sender As System.Object, e As System.EventArgs) Handles picbx_lady.Click

    End Sub
End Class

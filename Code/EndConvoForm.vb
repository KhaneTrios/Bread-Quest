Public Class frmendconvo

    Private Sub lbl_title_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_title.Click

    End Sub


    Private Sub picbx_lady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picbx_lady.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbl_convo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_convo.Click
    End Sub

    Private Sub btn_continue2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_continue2.Click
        lbl_convo.Visible = True
        If lbl_clicks.Text = "Clicks 1" Then
            lbl_title.Visible = False : picbx_talk.Visible = True : picbx_user.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "What are you doing here?" : lbl_clicks.Text = "Clicks 2"
        ElseIf lbl_clicks.Text = "Clicks 2" Then
            picbx_talk.Visible = False : picbx_user.Visible = True : picbx_ladytalk.Visible = True
            lbl_convo.Text = "Haha, you think you won you pathetic boy?" : lbl_clicks.Text = "Clicks 3"
        ElseIf lbl_clicks.Text = "Clicks 3" Then
            picbx_talk.Visible = True : picbx_user.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "What are you talking about, I am human again and defeated the plaque?" : lbl_clicks.Text = "Clicks 4"
        ElseIf lbl_clicks.Text = "Clicks 4" Then
            picbx_talk.Visible = False : picbx_user.Visible = True : picbx_ladytalk.Visible = True
            lbl_convo.Text = "Yes, that you did, but you also led me to the toaster, and defeated the plaque that was guarding it. This now means I can now harness the dark powers that it encompasses." : lbl_clicks.Text = "Clicks 5"
        ElseIf lbl_clicks.Text = "Clicks 5" Then
            picbx_talk.Visible = True : picbx_user.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "Yea, what are you getting at." : lbl_clicks.Text = "Clicks 6"
        ElseIf lbl_clicks.Text = "Clicks 6" Then
            picbx_talk.Visible = True : picbx_user.Visible = False : picbx_ladytalk.Visible = True
            lbl_convo.Text = "This now means I can now harness the dark powers that it encompasses and take over the world because the toaster is the source and control of all the plaque!" : lbl_clicks.Text = "Clicks 7"
        ElseIf lbl_clicks.Text = "Clicks 7" Then
            picbx_talk.Visible = False : picbx_user.Visible = True : picbx_ladytalk.Visible = False
            lbl_convo.Text = "............." : lbl_clicks.Text = "Clicks 8"
        ElseIf lbl_clicks.Text = "Clicks 8" Then
            picbx_talk.Visible = False : picbx_user.Visible = True : picbx_ladytalk.Visible = True
            lbl_convo.Text = "And now there is no one can stop me because the only one who could was you, but you now dont have your abilities." : lbl_clicks.Text = "Clicks 9"
        ElseIf lbl_clicks.Text = "Clicks 9" Then
            picbx_talk.Visible = True : picbx_user.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "Well doesn't this mean I win?" : lbl_clicks.Text = "Clicks 10"
        ElseIf lbl_clicks.Text = "Clicks 10" Then
            picbx_talk.Visible = True : picbx_user.Visible = False : picbx_ladytalk.Visible = True
            lbl_convo.Text = "Hahaha, in what world would this mean you win?" : lbl_clicks.Text = "Clicks 11"
        ElseIf lbl_clicks.Text = "Clicks 11" Then
            picbx_talk.Visible = True : picbx_user.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "Didn't you say that the plaque is made and controlled through the toaster? Well I went through the toaster to become human again, meaning it a part of me. Therefore I can control the plaque as if im the leader." : lbl_clicks.Text = "Clicks 12"
        ElseIf lbl_clicks.Text = "Clicks 12" Then
            picbx_talk.Visible = False : picbx_user.Visible = True : picbx_ladytalk.Visible = False
            lbl_convo.Text = "............." : lbl_clicks.Text = "Clicks 13"
        ElseIf lbl_clicks.Text = "Clicks 13" Then
            picbx_talk.Visible = True : picbx_user.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "Speechless are you! Looks like the tables have turned!" : lbl_clicks.Text = "Clicks 14"
        ElseIf lbl_clicks.Text = "Clicks 14" Then
            picbx_talk.Visible = False : picbx_user.Visible = True : picbx_ladytalk.Visible = True
            lbl_convo.Text = "You think you have un-done me, I'm going to kill you here in this dungeon and take your powers!" : lbl_clicks.Text = "Clicks 15"
        ElseIf lbl_clicks.Text = "Clicks 15" Then
            picbx_talk.Visible = True : picbx_user.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "I would love to see you try. I'm even stronger now with my new power and because of my plaque army." : lbl_clicks.Text = "Clicks 16"
        ElseIf lbl_clicks.Text = "Clicks 16" Then
            picbx_talk.Visible = False : picbx_user.Visible = True : picbx_ladytalk.Visible = False
            lbl_convo.Visible = False
            lbl_title.Visible = True
            lbl_title.Text = "The plaque minions come and stand by Pane's side." : lbl_clicks.Text = "Clicks 17"
        ElseIf lbl_clicks.Text = "Clicks 17" Then
            picbx_talk.Visible = False : picbx_user.Visible = True : picbx_ladytalk.Visible = True
            lbl_title.Visible = False
            lbl_convo.Visible = True
            lbl_convo.Text = "Lets end this now you fool!" : lbl_clicks.Text = "Clicks 18"
        ElseIf lbl_clicks.Text = "Clicks 18" Then
            picbx_talk.Visible = True : picbx_user.Visible = False : picbx_ladytalk.Visible = False
            lbl_convo.Text = "As you wish haha!" : lbl_clicks.Text = "Clicks 19"
        ElseIf lbl_clicks.Text = "Clicks 19" Then
            Me.Close()
        End If
    End Sub
End Class

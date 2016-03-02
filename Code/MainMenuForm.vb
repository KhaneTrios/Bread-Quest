Public Class frmmainmenu
    Private Sub frmmainmenu_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("E:\breadQuestReal\breadQuestReal\Resources\Trance.wav", AudioPlayMode.Background)
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnnewgame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewgame.Click
        frmconvo.Show()
        Me.Close()
    End Sub
    Private Sub btnnewgame_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewgame.MouseHover



    End Sub
    Private Sub btncontinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncontinue.Click

    End Sub
    Private Sub btnstory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstory.Click

    End Sub
    Private Sub btncredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncredits.Click
        frmcredits.Show()
        Me.Close()
    End Sub
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquit.Click
        End
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbattle.Click
        My.Computer.Audio.Stop()
        frmbattle.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolTip1_Popup(sender As System.Object, e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub


    Sub wha5t() Handles MyBase.FormClosing
        Try
            Dim outFile As IO.StreamWriter = IO.File.CreateText("level")
            outFile.Write(Variables.PlayerStats.LVL.ToString)
            outFile.Close()
        Catch ex As Exception
            MsgBox("saving level failed" + ControlChars.NewLine + ex.ToString)
        End Try
    End Sub

    Private Sub btnmove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmmove.Show()
        Me.Close()
    End Sub

    Private Sub btnconvo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmconvo.Show()
        Me.Close()
    End Sub
End Class
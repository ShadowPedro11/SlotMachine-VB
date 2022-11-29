Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Form2.Show()
        Close()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.loja, AudioPlayMode.BackgroundLoop)
        Label6.Text = Form2.Label6.Text
        Label7.Text = Form2.Label7.Text
        Label11.Text = Form2.Label11.Text
        Label9.Text = Form2.Label9.Text

        If Label9.Text = 0 Then

            Button3.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
        End If
        If Label9.Text < 40 Then

            Button3.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
        End If
        If Label9.Text < 100 Then

            Button4.Enabled = False
        End If
        If Label9.Text < 80 Then

            Button3.Enabled = False
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Label9.Text = Label9.Text - 40
        Label11.Text = Label11.Text + 3
        If Label9.Text = 0 Then

            Button3.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
        End If
        If Label9.Text < 40 Then

            Button3.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
        End If
        If Label9.Text < 100 Then

            Button4.Enabled = False
        End If
        If Label9.Text < 80 Then

            Button3.Enabled = False
            Button4.Enabled = False
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Label9.Text = Label9.Text - 80
        Label11.Text = Label11.Text + 6
        If Label9.Text = 0 Then

            Button3.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
        End If
        If Label9.Text < 40 Then

            Button3.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
        End If
        If Label9.Text < 100 Then

            Button4.Enabled = False
        End If
        If Label9.Text < 80 Then

            Button3.Enabled = False
            Button4.Enabled = False
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Label9.Text = Label9.Text - 100
        Label11.Text = Label11.Text + 8
        If Label9.Text = 0 Then

            Button3.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
        End If
        If Label9.Text < 40 Then

            Button3.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
        End If
        If Label9.Text < 100 Then

            Button4.Enabled = False
        End If
        If Label9.Text < 80 Then

            Button3.Enabled = False
            Button4.Enabled = False
        End If
        
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub
End Class
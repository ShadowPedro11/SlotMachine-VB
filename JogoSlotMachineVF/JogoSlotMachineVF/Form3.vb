Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Dim int As String
        int = MsgBox(" Deseja voltar ao menu do jogo? ",
        vbOKCancel, "Sair")
        If int = vbOK Then
            Close()
            Form2.Show()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Stop()
        Dim int As String
        int = MsgBox(" Deseja voltar ao menu principal? ",
        vbOKCancel, "Sair")
        If int = vbOK Then
            Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.voz, AudioPlayMode.Background)
    End Sub

   
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
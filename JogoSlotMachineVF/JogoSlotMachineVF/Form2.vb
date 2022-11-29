Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label6.Text = Label6.Text + 1
        Label11.Text = Label11.Text - 1

        My.Computer.Audio.Play(My.Resources.coin, AudioPlayMode.Background)
        Randomize()
        Dim a, b, c As Integer
        a = (Int(8 * Rnd() + 1))
        b = Int(8 * Rnd() + 1)
        c = Int(8 * Rnd() + 1)
        Label1.Text = a
        Label2.Text = b
        Label3.Text = c
        
        If Label1.Text = Label2.Text And Label2.Text = Label3.Text Then


            Label1.BackColor = Color.Gold
            Label2.BackColor = Color.Gold
            Label3.BackColor = Color.Gold
            MsgBox("Ganhaste um Joker", vbOKOnly, )

            Form5.Show()
            My.Computer.Audio.Play(My.Resources.win, AudioPlayMode.Background)

            Label7.Text = Label7.Text + 1
            Label9.Text = Label9.Text + 1000
        End If
        If Label1.Text <> Label2.Text Or Label2.Text <> Label3.Text Or Label1.Text <> Label3.Text Then

            Label1.BackColor = Color.White
            Label2.BackColor = Color.White
            Label3.BackColor = Color.White

        End If
        If Label11.Text = 0 Then
            MsgBox("Não tens fichas")
            Button1.Enabled = False
        End If
        If Label11.Text > 0 Then
            Button1.Enabled = True
        End If
        If Label9.Text > 20 Then
            Button4.Enabled = True
        End If

        If Button1.Enabled = False And Button4.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.lose, AudioPlayMode.Background)
            MsgBox("Não tens dinheiro nem fichas, perdeste o jogo!!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mensagem As String
        mensagem = MsgBox("Tem a certeza que deseja abandonar o SlotMachine?",
        vbOKCancel, "Sair")
        If mensagem = vbOK Then
            End

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.money, AudioPlayMode.Background)
        Label11.Text = Label11.Text + 1
        Label9.Text = Label9.Text - 20
        If Label9.Text = 0 Then
            MsgBox("Não tens mais dinheiro")
            Button4.Enabled = False
        End If
        If Label11.Text > 0 Then
            Button1.Enabled = True
        End If
        If Label9.Text > 20 Then
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim intruções As String
        intruções = MsgBox(" Carregar no botão Ok para aceder às instruções ",
        vbOKOnly, )
        Form3.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form4.Show()
        Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label6.Text = Form4.Label6.Text
        Label7.Text = Form4.Label7.Text
        Label11.Text = Form4.Label11.Text
        Label9.Text = Form4.Label9.Text
        If Label11.Text = 0 Then
            MsgBox("Não tens fichas")
            Button1.Enabled = False
        End If
        If Label11.Text > 0 Then
            Button1.Enabled = True
        End If
        If Label9.Text > 20 Then
            Button4.Enabled = True
        End If

        If Button1.Enabled = False And Button4.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.lose, AudioPlayMode.Background)
            MsgBox("Não tens dinheiro nem fichas, perdeste o jogo!!")
        End If
        
        If Label9.Text = 0 Then
            Button4.Enabled = False
        End If
       
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub
End Class
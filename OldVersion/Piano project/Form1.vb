Public Class Form1

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        If rbConsole.Checked = True Then
            Console.Beep(200, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.C, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.C_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbConsole.CheckedChanged

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCq.Click
        If rbConsole.Checked = True Then
            Console.Beep(250, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.C_s, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.Cq_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click
        If rbConsole.Checked = True Then
            Console.Beep(300, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.D, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.D_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        If rbConsole.Checked = True Then
            Console.Beep(400, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.E, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.E_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click
        If rbConsole.Checked = True Then
            Console.Beep(450, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.F, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.F_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        If rbConsole.Checked = True Then
            Console.Beep(550, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.G, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.G_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        If rbConsole.Checked = True Then
            Console.Beep(650, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.A, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.A_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
        If rbConsole.Checked = True Then
            Console.Beep(750, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.B, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.B_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC1.Click
        If rbConsole.Checked = True Then
            Console.Beep(800, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.C1, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.C1_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnD1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD1.Click
        If rbConsole.Checked = True Then
            Console.Beep(900, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.D1, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.D1_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE1.Click
        If rbConsole.Checked = True Then
            Console.Beep(1000, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.E1, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.E1_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF1.Click
        If rbConsole.Checked = True Then
            Console.Beep(1050, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.F1, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.F1_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDq.Click
        If rbConsole.Checked = True Then
            Console.Beep(350, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.D_s, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.Dq_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnFq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFq.Click
        If rbConsole.Checked = True Then
            Console.Beep(500, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.F_s, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.Fq_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnGq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGq.Click
        If rbConsole.Checked = True Then
            Console.Beep(600, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.G_s, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.Gq_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnBb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBb.Click
        If rbConsole.Checked = True Then
            Console.Beep(700, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.Bb, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.Bb_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnCq1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCq1.Click
        If rbConsole.Checked = True Then
            Console.Beep(850, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.C_s1, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.Cq1_Drum, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnDq1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDq1.Click
        If rbConsole.Checked = True Then
            Console.Beep(950, 500)
        End If
        If rbMusic.Checked = True Then
            My.Computer.Audio.Play(My.Resources.D_s1, AudioPlayMode.Background)
        End If
        If rbSteelDrum.Checked = True Then
            My.Computer.Audio.Play(My.Resources.Dq1_Drum, AudioPlayMode.Background)
        End If
    End Sub
End Class

Public Class Malônecheur
    Dim processus As New Process

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Jeu1.Click
        processus.StartInfo.FileName = "F:\gamejams\utop2017\gameOne.exe"
        processus.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Jeu2.Click
        processus.StartInfo.FileName = "F:\gamejams\utop2017\gameTwo.exe"
        processus.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Jeu3.Click
        processus.StartInfo.FileName = "F:\gamejams\utop2017\gameThree.exe"
        processus.Start()
    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        End
    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply

    End Sub
End Class

Public Class Home


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Ce programme vas vous aider a savoir des commande de base et plus de Linux, Windows Server et CCNA." & vbNewLine & "Vous Pouvez l'utiliser facilement en cliquant sur un module puis appuyez sur Lancer")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Linux1.Checked Then
            Linux.Show()
            Me.Hide()
        End If
        If Reseau1.Checked Then
            Réseau.Show()
            Me.Hide()
        End If
        If Windows1.Checked Then
            Windows.Show()
            Me.Hide
        End If
    End Sub

    Private Sub Reseau1_CheckedChanged(sender As Object, e As EventArgs) Handles Reseau1.CheckedChanged

    End Sub
End Class

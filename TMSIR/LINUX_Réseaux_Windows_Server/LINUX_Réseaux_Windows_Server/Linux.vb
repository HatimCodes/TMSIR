Public Class Linux

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Ici vous pouvez trouver toute les commande de base de Linux")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Réseau.Show()
        Me.Hide()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Windows.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Text = "pwd (affiche le chemin absolu du répertoire courant)"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox1.Text = "ls (list, affiche les répertoires et les fichiers du répertoire actif)" & vbNewLine & "ls (affiche seulement les noms)" & vbNewLine & "ls toto* (affiche les fichiers commençant par toto)" & vbNewLine & "ls -l (affiche le format long : types + droits + Nbre de liens + ....)"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TextBox1.Text = "cd (change directory)" & vbNewLine & "cp chemin (vers le répertoire dont le chemin absolu est donné)" & vbNewLine & "cd .. (répertoire parent)" & vbNewLine & "cd ~ (répertoire de base)" & vbNewLine & "cd - (répertoire précedent)" & vbNewLine & "cd / (répertoire racine)"

        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox1.Text = "cp (copie)" & vbNewLine & "cp rapport*.txt sauvegarde" & vbNewLine & "cp * dossier (copie"
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked Then
            TextBox1.Text = "rmdir (effacer un répertoire)" & vbNewLine & "rmdir dossier (supprime un répertoire vide)"
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked Then
            TextBox1.Text = "rm (remove, éfface!!!)" & vbNewLine & "rm -R (enlèvement récursif!!!)" & vbNewLine & "rm fichier" & vbNewLine & "rm -i fichier (interactivement, avec demande de confirmation)" & vbNewLine & "rm -f fichier (avec force, sans demande de confirmation)" & vbNewLine & "rm -r fichier (avec récursivité, avec les sous répertoires)" & vbNewLine & "rm -rf dossier (supprime le répertoire et tou son contenu, sans confirmation)"
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked Then
            TextBox1.Text = "vi (l'éditeur en mode texte universel)"
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked Then
            TextBox1.Text = "grep (recherche les occurences de mots à l'intérieur de fichier)" & vbNewLine & "grep motif fichier" & vbNewLine & "grep -i motif fichier (sans tenir compte de la casse)" & vbNewLine & "grep -c motif fichier (en comptant les occurences)" & vbNewLine & "grep -v motif fichier (inverse la recherche, en excluant le 'motif')" & vbNewLine & "grep expression /répertoire/fichier" & vbNewLine & "grep [aFm]in /répertoire/fichier" & vbNewLine & "grep '\$' *.txt"

        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        If RadioButton20.Checked Then
            TextBox1.Text = "emacs (l'éditeur GNU Emacs multi fonction pour l'édition, les mails, les news,"
        End If
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        If RadioButton19.Checked Then
            TextBox1.Text = "xemacs (l'éditeur GNU Emacs sous X)"
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox1.Text = "mv (move, renomme et déplace un fichier)" & vbNewLine & "mv source destination" & vbNewLine & "mv * dossier (déplace tous les fichiers du répertoire actif vers le répertoire dossier)"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            TextBox1.Text = "mkdir (créer un répertoire)"
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            TextBox2.Text = "Méthode 1 : Editer le fichier /etc/hostname directement" & vbNewLine & "Cette méthode nécessite un redémarrage par la suit." & vbNewLine & "-Editer le fichier /etc/hostname" & vbNewLine & " # vi /etc/hostname" & vbNewLine & "-Modifier la valeur du hostname contenue dans ce fichier par « SrvCentOS.ofppt.ma »" & vbNewLine & "-Enregistrer et quitter" & vbNewLine & " :wq" & vbNewLine & "-Redémarrer le système pour que ce changement soit pris en compte" & vbNewLine & " # reboot" & vbNewLine & "-Vérifier" & vbNewLine & " # hostname"
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked Then
            TextBox2.Text = "Méthode 2 : Utiliser l'utilitaire hostnamectl" & vbNewLine & "Cette méthode ne nécessite aucun redémarrage par la suit." & vbNewLine & "-Vérifiez le nom d'hôte actuel." & vbNewLine & " # hostnamectl status" & vbNewLine & "-Changer le nom d’hôte actuel par « Serveur.ismotica.ma »" & vbNewLine & " # hostnamectl set-hostname Serveur.ismotica.ma" & vbNewLine & "-Vérifiez de nouveau le nom d'hôte actuel." & vbNewLine & " # hostnamectl status"
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked Then
            MessageBox.Show("Les méthodes 3 et 4 nécessitent que le service NetworkManager soit démarré. Sinon vous aurez l’erreur suivant :" & vbNewLine & "NetworkManager n'est pas en cours d'exécution.")
            TextBox2.Text = "Méthode 3 : Utiliser l'outil de ligne de commande NetworkManager: nmcli" & vbNewLine & "-Vérifiez le nom d'hôte actuel." & vbNewLine & " # nmcli general hostname" & vbNewLine & "-Changer le nom d’hôte actuel par « SRV-CentOS »" & vbNewLine & " # nmcli general hostname SRV-CentOS" & vbNewLine & "-Redémarrer le service systemd-hostnamed pour que les modifications prennent effet:" & vbNewLine & " # service systemd-hostnamed restart" & vbNewLine & "-Vérifiez de nouveau le nom d'hôte actuel." & vbNewLine & " # hostname"
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked Then
            MessageBox.Show("Les méthodes 3 et 4 nécessitent que le service NetworkManager soit démarré. Sinon vous aurez l’erreur suivant :" & vbNewLine & "NetworkManager n'est pas en cours d'exécution.")
            TextBox2.Text = "Méthode 4 : Utiliser l'outil d'interface utilisateur de texte NetworkManager: nmtui" & vbNewLine & "-Lancer l’outil nmtui." & vbNewLine & " # nmtui" & vbNewLine & "-Sélectionnez l'option pour 'définir le nom d'hôte du système' ( en anglais 'set the hostname' et appuyez sur Entrée" & vbNewLine & "-Changer le nom d’hôte actuel par « SRV-TMSIR201 », puis cliquer sur ok" & vbNewLine & "-Confirmer le changement de nom d'hôte" & vbNewLine & "-Redémarrer le service systemd-hostnamed pour que les modifications prennent effet:" & vbNewLine & "# service systemd-hostnamed restart" & vbNewLine & "-Vérifiez de nouveau le nom d'hôte actuel." & vbNewLine & " # hostname"
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked Then
            TextBox3.Text = "RPM Package Manager (Red Hat Package Manager), ou plus simplement RPM, est un système de gestion de paquets de logiciels utilisé sur certaines distributions GNU/Linux."
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked Then
            TextBox3.Text = "Installer ou mettre à jour un paquet:" & vbNewLine & "rpm -uvh nom_paquet_xxx.rpm" & vbNewLine & "" & vbNewLine & "Installer un paquet :" & vbNewLine & "rpm -ivh nom_paquet_xxx.rpm" & vbNewLine & "" & vbNewLine & "Désinstaller un paquet :" & vbNewLine & "rpm -e *  (sans '.rpm')" & vbNewLine & "" & vbNewLine & "Rechercher si le paquet truc est installé :" & vbNewLine & "rpm -q truc  (nom complet, sans '.rpm')" & vbNewLine & "" & vbNewLine & "Liste de tous les paquets installés :" & vbNewLine & "rpm -qa" & vbNewLine & "" & vbNewLine & "Recherche dans tous les paquets installés si gcc est présent :" & vbNewLine & "rpm -qa | grep gcc"
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked Then
            TextBox4.Text = "Yum, pour Yellowdog Updater Modified, est un gestionnaire de paquets pour des distributions Linux telles que Fedora, CentOS et Red Hat Enterprise Linux, créé par Yellow Dog Linux. Il permet de gérer l'installation et la mise à jour des logiciels installés sur une distribution."
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked Then
            TextBox4.Text = "mettre à jour tout le système en utilisant:" & vbNewLine & "yum update" & vbNewLine & "" & vbNewLine & "rechercher un paquetage particulier:" & vbNewLine & "yum list <nom du paquet>" & vbNewLine & "" & vbNewLine & "Pour installer un paquet:" & vbNewLine & "yum install <nom du paquet>" & vbNewLine & "" & vbNewLine & "Pour supprimer un paquet:" & vbNewLine & "yum remove <nom du paquet>" & vbNewLine & "" & vbNewLine & "Pour la mise à jour du système :" & vbNewLine & "yum upgrade" & vbNewLine & "" & vbNewLine & "Lister l'historique yum" & vbNewLine & "yum history"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("-Vérifier l’état d’un service" & vbNewLine & "-Lancer un service au démarrage" & vbNewLine & "-Démarrer un service" & vbNewLine & "-Redémarrer un service" & vbNewLine & "-Arrêter un service", "Les objectifs")
    End Sub

    Private Sub statu1_CheckedChanged(sender As Object, e As EventArgs) Handles statu1.CheckedChanged
        If statu1.Checked Then
            TextBox5.Text = "status"
        End If
    End Sub

    Private Sub démarer_CheckedChanged(sender As Object, e As EventArgs) Handles démarer.CheckedChanged
        If démarer.Checked Then
            TextBox5.Text = "start"
        End If
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        If RadioButton21.Checked Then
            TextBox5.Text = "stop"
        End If
    End Sub

    Private Sub redeme_CheckedChanged(sender As Object, e As EventArgs) Handles redeme.CheckedChanged
        If redeme.Checked Then
            TextBox5.Text = "restart"
        End If
    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged
        If RadioButton22.Checked Then
            TextBox5.Text = "reload"
        End If
    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        If RadioButton23.Checked Then
            TextBox5.Text = "enable"
        End If
    End Sub
End Class
Public Class Réseau
    Dim claaaa As String = "A"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Ici vous pouvez trouver toute les commandes de base de Cisco et plus.")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Attribuer le mot de passe à l’accès par telnet :
        MessageBox.Show("Router(config)# line vty 0 4" & vbNewLine & "Router(config-line)# password ‘mot de passe’" & vbNewLine & "Router(config-line)# login" & vbNewLine & "Router(config-line)# exit")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles binair.Click

    End Sub
    'afficher les info
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        AcceptButton = Button32
        Dim bin11 As Integer = Integer.Parse(ip1.Text)
        Dim bin22 As Integer = Integer.Parse(ip2.Text)
        Dim bin33 As Integer = Integer.Parse(ip3.Text)
        Dim bin44 As Integer = Integer.Parse(ip4.Text)
        If ip1.Text = "" Or ip2.Text = "" Or ip3.Text = "" Or ip4.Text = "" Then
            ip1.Focus()
            MessageBox.Show("l'adresse ip que vous avez entré est invalide")
        End If
        'Class A
        If ip1.Text <= 127 And ip1.Text <> 0 And ip2.Text <= 255 And ip3.Text <= 255 And ip4.Text <= 255 Then
            cidr.Text = "/8"
            classin.Text = "A"
            masquein.Text = "255.0.0.0"
            generique.Text = "0.255.255.255"
            bin1.Text = Convert.ToString(bin11, 2)
            bin2.Text = Convert.ToString(bin22, 2)
            bin3.Text = Convert.ToString(bin33, 2)
            bin4.Text = Convert.ToString(bin44, 2)
            If ip1.Text = 10 And ip2.Text <= 255 And ip3.Text <= 255 And ip4.Text <= 255 Then
                TextBox2.Text = "Privée"
            Else : TextBox2.Text = "Publique"
            End If
            'Class B
        ElseIf ip1.Text <= 191 And ip1.Text <> 0 And ip2.Text <= 255 And ip3.Text <= 255 And ip4.Text <= 255 Then
            cidr.Text = "/16"
            classin.Text = "B"
            masquein.Text = "255.255.0.0"
            generique.Text = "0.0.255.255"
            bin1.Text = Convert.ToString(bin11, 2)
            bin2.Text = Convert.ToString(bin22, 2)
            bin3.Text = Convert.ToString(bin33, 2)
            bin4.Text = Convert.ToString(bin44, 2)
            If ip1.Text = 172 And ip2.Text >= 16 And ip2.Text <= 31 And ip3.Text <= 255 And ip4.Text <= 255 Then
                TextBox2.Text = "Privée"
            Else : TextBox2.Text = "Publique"
            End If
            'Class C
        ElseIf ip1.Text <= 223 And ip1.Text <> 0 And ip2.Text <= 255 And ip3.Text <= 255 And ip4.Text <= 255 Then
            cidr.Text = "/24"
            classin.Text = "C"
            masquein.Text = "255.255.255.0"
            generique.Text = "0.0.0.255"
            bin1.Text = Convert.ToString(bin11, 2)
            bin2.Text = Convert.ToString(bin22, 2)
            bin3.Text = Convert.ToString(bin33, 2)
            bin4.Text = Convert.ToString(bin44, 2)
            If ip1.Text = 192 And ip2.Text = 168 And ip3.Text <= 255 And ip4.Text <= 255 Then
                TextBox2.Text = "Privée"
            Else : TextBox2.Text = "Publique"
            End If
            'Class D
        ElseIf ip1.Text <= 239 And ip1.Text <> 0 And ip2.Text <= 255 And ip3.Text <= 255 And ip4.Text <= 255 Then
            cidr.Text = "non défini"
            classin.Text = "D"
            masquein.Text = "non défini"
            generique.Text = "non défini"
            bin1.Text = Convert.ToString(bin11, 2)
            bin2.Text = Convert.ToString(bin22, 2)
            bin3.Text = Convert.ToString(bin33, 2)
            bin4.Text = Convert.ToString(bin44, 2)
            'Class E
        ElseIf ip1.Text <= 255 And ip1.Text <> 0 And ip2.Text <= 255 And ip3.Text <= 255 And ip4.Text <= 255 Then
            cidr.Text = "non défini"
            classin.Text = "E"
            masquein.Text = "non défini"
            generique.Text = "non défini"
            bin1.Text = Convert.ToString(bin11, 2)
            bin2.Text = Convert.ToString(bin22, 2)
            bin3.Text = Convert.ToString(bin33, 2)
            bin4.Text = Convert.ToString(bin44, 2)
        ElseIf ip1.Text > 255 And ip1.Text < 0 And ip2.Text > 255 And ip3.Text > 255 And ip4.Text > 255 Then
        Else : MessageBox.Show("l'adresse ip que vous avez entré est invalide")
        End If



        'Type
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Passer à la mode privilégié :
        MessageBox.Show("Router> enable")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Passer à la mode de configuration globale :
        MessageBox.Show("Router# configure terminal")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Renommer les noms d’hôtes :
        MessageBox.Show("Router(config)# hostname ‘Nouveau Nom’")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Configurer l’interface FastEthernet
        MessageBox.Show("Router(config)# interface FastEthernet ‘numéro’" & vbNewLine & "Router(config-if)# ip address ‘@’ ‘masque de sous réseau’ " & vbNewLine & "Router(config-if)# no shutdown" & vbNewLine & "Router(config-if)# exit")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Configurer l’interface Serial : 
        MessageBox.Show("Router(config)# interface serial ‘numéro’" & vbNewLine & "Router(config-if)# ip address ‘@’ ‘masque de sous réseau’ " & vbNewLine & "Router(config-if)# clock rate ‘nombre’" & vbNewLine & "Router(config-if)# no shutdown" & vbNewLine & "Router(config-if)# exit")

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Attribuer le mot de passe à l’accès par terminal :
        MessageBox.Show("Router(config)# line console 0" & vbNewLine & "Router(config-line)# password ‘mot de passe’" & vbNewLine & "Router(config-line)# login" & vbNewLine & "Router(config-line)# exit")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Attribuer le mot de passe par mode privilégié (non crypté) :
        MessageBox.Show("Router(config)# Enable password ‘mot de passe’")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Attribuer le mot de passe par mode privilégié (crypté) :
        MessageBox.Show("Router(config)# Enable secret ‘mot de passe’")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'Configurer la connexion synchrone :
        MessageBox.Show("Router(config)# line vty 0 4" & vbNewLine & "Router(config-line)#logging synchronous" & vbNewLine & "Router(config-line)# exit" & vbNewLine & "Router(config)# line console 0" & vbNewLine & "Router(config-line)# logging synchronous" & vbNewLine & "Router(config-line)# exit")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Désactiver la recherche DNS
        MessageBox.Show("Router(config)# no ip domain-lookup")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Attribuer au routeur la bannière :
        MessageBox.Show("Router(config)# banner motd # ‘le message’ #")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        'Définition R Statiqur
        MessageBox.Show("Pour le routage statique, les tables sont remplies manuellement. Il est utilisé sur des petits réseaux ou sur des réseaux d'extrémité.")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'route par défaut
        MessageBox.Show("La passerelle par défaut dans l'exemple suivant est : 192.168.3.1" & vbNewLine & vbNewLine & "               R4(config)#ip route 0.0.0.0 0.0.0.0 192.168.3.1")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        'supp R par défaut
        MessageBox.Show("R4(config)#no ip route 0.0.0.0 0.0.0.0 192.168.3.1")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'Configuration d'une route statique
        MessageBox.Show("Dans la commande suivante, le réseau à atteindre est le réseau 192.168.2.0/24 et l'interface utilisée pour joindre le réseau est ethernet 1/0." & vbNewLine & "R4(config)#ip route 192.168.2.0 255.255.255.0 ethernet 1/0" & vbNewLine & vbNewLine & "On peut aussi utiliser l'adresse IP du prochain routeur." & vbNewLine & "R4(config)#ip route 192.168.2.0 255.255.255.0 10.0.0.2")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        'Suppression de la route statique
        MessageBox.Show("R4(config)#no ip route 192.168.2.0 255.255.255.0 ethernet 1/0")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'Affichage de la table de routage
        MessageBox.Show("R4#show ip route")
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        ip1.Text = ""
        ip2.Text = ""
        ip3.Text = ""
        ip4.Text = ""
        bin1.Text = ""
        bin2.Text = ""
        bin3.Text = ""
        bin4.Text = ""
        classin.Text = ""
        masquein.Text = ""
        cidr.Text = ""
        generique.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Linux.Show()
        Me.Hide()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Windows.Show()
        Me.Hide()
    End Sub

    Private Sub TabPage7_Click(sender As Object, e As EventArgs) Handles TabPage7.Click

    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        MessageBox.Show("Switch> enable")
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        MessageBox.Show("Switch# configure terminal")
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        MessageBox.Show("Switch(config)# hostname ‘Nouveau Nom’")

    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        MessageBox.Show("Switch(config)# vlan ‘numéro’" & vbNewLine & "Switch(config-vlan)# name ‘nom’" & vbNewLine & "Switch(config-vlan)# exit")
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        MessageBox.Show("Switch(config)# interface vlan ‘numéro’" & vbNewLine & "Switch(config-if)# ip address ‘@IP’ ‘masque’" & vbNewLine & "Switch(config-if)# no shutdown" & vbNewLine & "Switch(config-if)# exit")
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        MessageBox.Show("Switch(config)# interface fastethernet ‘numéro" & vbNewLine & "Switch(config-if)# switchport access vlan ‘numéro’" & vbNewLine & "Switch(config-if)# exit")
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        MessageBox.Show("Switch(config)# interface fastethernet ‘numéro’" & vbNewLine & "Switch(config-if)# switchport mode trunk" & vbNewLine & "Switch(config-if)# exit")

    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        MessageBox.Show("Switch# show vlan brief")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        MessageBox.Show("le routage dynamique permet d’avoir une plus grande flexibilité pour l’administrateur réseau, en cas de panne d’un lien, le calcul pour trouver un lien de secours se fera automatiquement entre les routeurs mais sa mise en œuvre est un peu plus complexe.")
    End Sub
    'RIP
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        MessageBox.Show("(Routing Information Protocol) est un protocole de routage à vecteur de distance.")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        MessageBox.Show("Classless, Broadcast pour les mises à jours, et utilise le préfixe dans les mises à jours")
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        MessageBox.Show(" Classfull, Multicast pour les mises à jours, utilise le préfixe et le masque dans les mises à jours, et supporte VLSM.")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        MessageBox.Show("Router(config)# router rip" & vbNewLine & "Router(config-router)# version ‘1/2’" & vbNewLine & "Router(config-router)# network ‘@ de réseau voisin 1’" & vbNewLine & "Router(config-router)# network ‘@ de réseau voisin n’" & vbNewLine & "Router(config-router)# exit")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        MessageBox.Show("Router(config-router)#no network ‘@ de réseau voisin 1’ :Pour supprimer une seule @ réseau" & vbNewLine & "R1(config)#no router rip  :Cette commande efface toutes les configurations RIP existantes")
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        MessageBox.Show("router# show ip route")
    End Sub
    'EIGRP
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If RadioButton1.Checked Then
            MessageBox.Show("Router(config)# router eigrp 1" & vbNewLine & "Router(config-router)# network ‘@ de réseau voisin 1’ ‘masque générique’" & vbNewLine & "Router(config-router)# network ‘@ de réseau voisin n’ ‘masque générique’" & vbNewLine & "Router(config-router)# exit")
        End If
        If RadioButton2.Checked Then
            MessageBox.Show("Router(config-router)#no network ‘@ de réseau voisin 1’ ‘masque générique’ :Pour supprimer une seule @ réseau" & vbNewLine & "R1(config)#no router eigrp :Cette commande efface toutes les configurations EIGRP existantes")
        End If
        If RadioButton3.Checked Then
            MessageBox.Show("router# show ip route")
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        MessageBox.Show("(Enhanced Interior Gateway Routing Protocol), protocole propriétaire Cisco, est une version améliorée d’IGRP qui utilise la même technologie à vecteur de distance. Les améliorations portent principalement sur :" & vbNewLine & "• Les propriétés de convergence " & vbNewLine & "• L’efficacité des opérations du protocole")
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        MessageBox.Show("(Open Shortest Path First) est un protocole de routage à état de lien crée en 1988 par l’IETF. C’est à l’heure actuelle l’IGP (Interior Gateway Protocol) le plus répandu. OSPF est un protocole libre." & vbNewLine & "Principales caractéristiques d’OSPF : " & vbNewLine & "• Emission des mises à jour déclenchées par modification(s) topologique(s)." & vbNewLine & "• Connaissance exacte et complète de la topologie du réseau." & vbNewLine & "• Chaque nœud connaît l’existence de ses voisins adjacents." & vbNewLine & "• Envoi des mises à jour topologiques via une adresse multicast et non broadcast." & vbNewLine & "• Utilisation moindre de la bande passante . " & vbNewLine & "• Protocole de routage classless supportant le VLSM.")

    End Sub
    'OSPF
    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If RadioButton6.Checked Then
            MessageBox.Show("Router(config)# router ospf 1" & vbNewLine & "Router(config-router)# network ‘@ de réseau voisin 1’ ‘masque générique’ area 0" & vbNewLine & "Router(config-router)# network ‘@ de réseau voisin n’ ‘masque générique’ area 0" & vbNewLine & "Router(config-router)# exit")
        End If
        If RadioButton5.Checked Then
            MessageBox.Show("Router(config-router)#no network ‘@ de réseau voisin 1’ ‘masque générique’ area 0 :Pour supprimer une seule @ réseau" & vbNewLine & "R1(config)#no router ospf :Cette commande efface toutes les configurations OSPF existantes")
        End If
        If RadioButton4.Checked Then
            MessageBox.Show("router# show ip route")
        End If
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        If RadioButton7.Checked Then
            TextBox1.Text = "ACL standard (numérotée):" & vbNewLine & "NB : les numéros de l'ACL standard sont : 1→99 et 1300→1999" & vbNewLine & " " & vbNewLine & "1-Configurer une instruction pour une ACL standard :" & vbNewLine & "  Router(config)# access-list {numéro} {permit | deny} {préfixe} [masque générique]" & vbNewLine & "" & vbNewLine & "2-Appliquer l'ACL sur l'interface :" & vbNewLine & "Router(config)# interface ‘fastethernet/serial’ ‘numéro’" & vbNewLine & "Router(config-if)# ip access-group ‘1-99’ ‘in/out’" & vbNewLine & "Router(config-if)# exit"
        End If
        If RadioButton8.Checked Then
            TextBox1.Text = "ACL étendue (numérotée):" & vbNewLine & "NB : NB : les numéros de l'ACL standard sont : 100→199 et 2000→2699" & vbNewLine & " " & vbNewLine & "1-Configurer une instruction pour une ACL Etendue :" & vbNewLine & "Router# access-list {numéro} {permit | deny} {protocole} {préfixe source} {masque source} {préfixe destination} {masque destination} [{opérateur} {opérande}] [established]" & vbNewLine & " " & vbNewLine & "2-Appliquer l'ACL sur l'interface :" & vbNewLine & "Router(config)# interface ‘fastethernet/serial’ ‘numéro" & vbNewLine & "Router(config-if)# ip access-group ‘100-199’ ‘in/out’" & vbNewLine & "Router(config-if)# exit" & vbNewLine & "" & vbNewLine & "►Opérande = nom ou numéro de port du protocole" & vbNewLine & "►Opérateur = (eq=égale), (neq=inégale), (lt=inférieur), (mt=supérieur)"
        End If
        If RadioButton9.Checked Then
            TextBox1.Text = "ACL nommée (peut être de type standard ou étendue):" & vbNewLine & "" & vbNewLine & "1-Configurer une instruction de l'ACL nommée :" & vbNewLine & "Router(config)# ip access-list ‘standard/extended’ ‘1-99/100-199’" & vbNewLine & "" & vbNewLine & "Si on a une ACL standard :" & vbNewLine & "Router(config-std-nacl)# {permit | deny} {préfixe} [masque générique]" & vbNewLine & "" & vbNewLine & "Si on a une ACL etendue :" & vbNewLine & "Router(config-ext-nacl)# {permit | deny} {protocole} {préfixe source} {masque source} {préfixe destination} {masque destination} [{opérateur} {opérande}] [established]" & vbNewLine & "" & vbNewLine & "2-Appliquer l'ACL sur l'interface :" & vbNewLine & "Router(config)# Router(config)# interface ‘fastethernet/serial’ ‘numéro’" & vbNewLine & "Router(config-if)# ip access-group ‘1-99’ ‘in/out’ " & vbNewLine & "Router(config-if)# exit"
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        MessageBox.Show("Une ACL (Access Control List) permet d’autoriser ou d’interdire des paquets, que ce soit en entrée ou en sortie. Elle est identifiable par son numéro ou son nom.")
    End Sub
    'Only numbers and back_button ip1
    Private Sub ip1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ip1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub ip1_TextChanged(sender As Object, e As EventArgs) Handles ip1.TextChanged

    End Sub
    'Only numbers and back_button ip2
    Private Sub ip2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ip2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ip2_TextChanged(sender As Object, e As EventArgs) Handles ip2.TextChanged

    End Sub
    'Only numbers and back_button ip3
    Private Sub ip3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ip3.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ip3_TextChanged(sender As Object, e As EventArgs) Handles ip3.TextChanged

    End Sub
    'Only numbers and back_button ip4
    Private Sub ip4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ip4.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ip4_TextChanged(sender As Object, e As EventArgs) Handles ip4.TextChanged

    End Sub
End Class
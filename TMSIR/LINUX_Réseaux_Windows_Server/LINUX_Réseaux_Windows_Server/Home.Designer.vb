<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Windows1 = New System.Windows.Forms.RadioButton()
        Me.Reseau1 = New System.Windows.Forms.RadioButton()
        Me.Linux1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(621, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(403, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Veuillez sélectionner un de ces modules :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Windows1)
        Me.GroupBox1.Controls.Add(Me.Reseau1)
        Me.GroupBox1.Controls.Add(Me.Linux1)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 141)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Windows1
        '
        Me.Windows1.AutoSize = True
        Me.Windows1.Location = New System.Drawing.Point(66, 91)
        Me.Windows1.Name = "Windows1"
        Me.Windows1.Size = New System.Drawing.Size(103, 17)
        Me.Windows1.TabIndex = 2
        Me.Windows1.TabStop = True
        Me.Windows1.Text = "Windows Server"
        Me.Windows1.UseVisualStyleBackColor = True
        '
        'Reseau1
        '
        Me.Reseau1.AutoSize = True
        Me.Reseau1.Location = New System.Drawing.Point(66, 55)
        Me.Reseau1.Name = "Reseau1"
        Me.Reseau1.Size = New System.Drawing.Size(67, 17)
        Me.Reseau1.TabIndex = 1
        Me.Reseau1.TabStop = True
        Me.Reseau1.Text = "Réseaux"
        Me.Reseau1.UseVisualStyleBackColor = True
        '
        'Linux1
        '
        Me.Linux1.AutoSize = True
        Me.Linux1.Location = New System.Drawing.Point(66, 19)
        Me.Linux1.Name = "Linux1"
        Me.Linux1.Size = New System.Drawing.Size(50, 17)
        Me.Linux1.TabIndex = 0
        Me.Linux1.TabStop = True
        Me.Linux1.Text = "Linux"
        Me.Linux1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(247, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 52)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Lancer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LINUX_Réseaux_Windows_Server.My.Resources.Resources.testpic
        Me.PictureBox1.Location = New System.Drawing.Point(180, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(326, 84)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 372)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "TMSIR HELPER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Windows1 As System.Windows.Forms.RadioButton
    Friend WithEvents Reseau1 As System.Windows.Forms.RadioButton
    Friend WithEvents Linux1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

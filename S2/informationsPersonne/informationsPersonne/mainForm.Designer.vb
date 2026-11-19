<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cbmOrigine = New System.Windows.Forms.ComboBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.txtDateDeNaissance = New System.Windows.Forms.TextBox()
        Me.lblDateDeNaissance = New System.Windows.Forms.Label()
        Me.lblOrigine = New System.Windows.Forms.Label()
        Me.btnEnvoyer = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(23, 39)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(91, 20)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "Votre nom :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(237, 41)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(235, 20)
        Me.txtNom.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(27, 253)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Effacer"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'cbmOrigine
        '
        Me.cbmOrigine.FormattingEnabled = True
        Me.cbmOrigine.Location = New System.Drawing.Point(237, 183)
        Me.cbmOrigine.Name = "cbmOrigine"
        Me.cbmOrigine.Size = New System.Drawing.Size(121, 21)
        Me.cbmOrigine.TabIndex = 3
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(237, 90)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(235, 20)
        Me.txtPrenom.TabIndex = 5
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenom.Location = New System.Drawing.Point(23, 88)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(118, 20)
        Me.lblPrenom.TabIndex = 4
        Me.lblPrenom.Text = "Votre prénom : "
        '
        'txtDateDeNaissance
        '
        Me.txtDateDeNaissance.Location = New System.Drawing.Point(237, 143)
        Me.txtDateDeNaissance.Name = "txtDateDeNaissance"
        Me.txtDateDeNaissance.Size = New System.Drawing.Size(121, 20)
        Me.txtDateDeNaissance.TabIndex = 7
        '
        'lblDateDeNaissance
        '
        Me.lblDateDeNaissance.AutoSize = True
        Me.lblDateDeNaissance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateDeNaissance.Location = New System.Drawing.Point(23, 141)
        Me.lblDateDeNaissance.Name = "lblDateDeNaissance"
        Me.lblDateDeNaissance.Size = New System.Drawing.Size(194, 20)
        Me.lblDateDeNaissance.TabIndex = 6
        Me.lblDateDeNaissance.Text = "Votre date de naissance : "
        '
        'lblOrigine
        '
        Me.lblOrigine.AutoSize = True
        Me.lblOrigine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigine.Location = New System.Drawing.Point(23, 181)
        Me.lblOrigine.Name = "lblOrigine"
        Me.lblOrigine.Size = New System.Drawing.Size(111, 20)
        Me.lblOrigine.TabIndex = 8
        Me.lblOrigine.Text = "Votre origine : "
        '
        'btnEnvoyer
        '
        Me.btnEnvoyer.Location = New System.Drawing.Point(120, 253)
        Me.btnEnvoyer.Name = "btnEnvoyer"
        Me.btnEnvoyer.Size = New System.Drawing.Size(75, 34)
        Me.btnEnvoyer.TabIndex = 9
        Me.btnEnvoyer.Text = "Envoyer"
        Me.btnEnvoyer.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(397, 253)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 34)
        Me.btnQuitter.TabIndex = 10
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 311)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnEnvoyer)
        Me.Controls.Add(Me.lblOrigine)
        Me.Controls.Add(Me.txtDateDeNaissance)
        Me.Controls.Add(Me.lblDateDeNaissance)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.cbmOrigine)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblNom)
        Me.Name = "mainForm"
        Me.Text = "Informations de la personne"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNom As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents cbmOrigine As ComboBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents lblPrenom As Label
    Friend WithEvents txtDateDeNaissance As TextBox
    Friend WithEvents lblDateDeNaissance As Label
    Friend WithEvents lblOrigine As Label
    Friend WithEvents btnEnvoyer As Button
    Friend WithEvents btnQuitter As Button
End Class

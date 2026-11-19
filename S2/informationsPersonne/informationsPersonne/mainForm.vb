Imports System.Runtime.CompilerServices

Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btnEnvoyer.Enabled = False
        btnReset.Enabled = False

        cbmOrigine.Items.Add("Américaine")
        cbmOrigine.Items.Add("Européen")
        cbmOrigine.Items.Add("Africaine")
        cbmOrigine.Items.Add("Asiatique")
        cbmOrigine.Items.Add("Océanienne")

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtDateDeNaissance.Text = ""
        txtNom.Text = ""
        txtPrenom.Text = ""
        cbmOrigine.SelectedItem = ""
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        gererActivationControles()
    End Sub

    Private Sub txtPrenom_TextChanged(sender As Object, e As EventArgs) Handles txtPrenom.TextChanged
        gererActivationControles()
    End Sub

    Private Sub txtDateDeNaissance_TextChanged(sender As Object, e As EventArgs) Handles txtDateDeNaissance.TextChanged
        gererActivationControles()
    End Sub
    Private Sub cbmOrigine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmOrigine.SelectedIndexChanged
        gererActivationControles()
    End Sub

    Private Sub btnEnvoyer_Click(sender As Object, e As EventArgs) Handles btnEnvoyer.Click
        MessageBox.Show($"Vous vous appelez {txtPrenom.Text} {txtNom.Text}, vous etes né en {txtDateDeNaissance.Text} et vous etes d'origine {cbmOrigine.SelectedItem}")
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
    End Sub

    Private Sub gererActivationControles()
        If txtDateDeNaissance.Text <> "" And txtPrenom.Text <> "" And txtNom.Text <> "" And CStr(cbmOrigine.SelectedValue) <> "" Then
            btnReset.Enabled = False
        Else
            btnReset.Enabled = True
        End If
    End Sub


End Class

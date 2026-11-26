Imports System.Runtime.CompilerServices

Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEnvoyer.Enabled = False
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
        cbmOrigine.SelectedIndex = -1
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
        Dim btnAActiver As Boolean = txtNom.Text.Trim() <> "" OrElse txtPrenom.Text.Trim() <>
            "" OrElse txtDateDeNaissance.Text.Trim() <> "" OrElse cbmOrigine.SelectedIndex <> -1

        btnReset.Enabled = btnAActiver

        Dim btnEnvoyerActiver As Boolean = txtNom.Text.Trim() <> "" AndAlso txtPrenom.Text.Trim() <>
            "" AndAlso txtDateDeNaissance.Text.Trim() <> "" AndAlso cbmOrigine.SelectedIndex <> -1 AndAlso gererAnneeNaissanceValide()
        btnEnvoyer.Enabled = btnEnvoyerActiver

    End Sub

    Private Function gererAnneeNaissanceValide() As Boolean
        If Integer.TryParse(txtDateDeNaissance.Text, New Integer()) AndAlso (Year(Now) - CInt(txtDateDeNaissance.Text) < 150 And Year(Now) - CInt(txtDateDeNaissance.Text) > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class

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
        cbmOrigine.SelectedItem = ""
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        If txtNom.Text <> "" Then
            btnReset.Enabled = True
        Else
            btnReset.Enabled = False
        End If
    End Sub

    Private Sub txtPrenom_TextChanged(sender As Object, e As EventArgs) Handles txtPrenom.TextChanged
        If txtPrenom.Text <> "" Then
            btnReset.Enabled = True
        Else
            btnReset.Enabled = False
        End If
    End Sub

    Private Sub txtDateDeNaissance_TextChanged(sender As Object, e As EventArgs) Handles txtDateDeNaissance.TextChanged
        If txtDateDeNaissance.Text <> "" Then
            btnReset.Enabled = True
        Else
            btnReset.Enabled = False
        End If
    End Sub
End Class

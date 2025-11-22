Public Class Form1
    Private Sub LnlQuantite_Click(sender As Object, e As EventArgs) Handles LnlQuantite.Click

    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        Dim A As article
        If validerArticle(A) Then
            ajouterArticle(A)
            init()
            MessageBox.Show("article ajout avec succes ")
        End If
    End Sub
    Private Function validerArticle(ByRef A As article) As Boolean
        Dim code, qte As Integer
        Dim prix As Double
        Dim valide As Boolean = True
        ErrorProvider1.Clear()
        If Not Integer.TryParse(TxtCode.Text, code) Then
            ErrorProvider1.SetError(TxtCode, "Le code doit etre un nombre ")
            valide = False
        Else
            A.code = code
        End If
        If String.IsNullOrEmpty(TxtDesignation.Text) Then
            ErrorProvider1.SetError(TxtDesignation, "la designation est fausse")
            valide = False
        Else
            A.designation = TxtDesignation.Text.Trim()
        End If
        If Not Double.TryParse(TxtPrix.Text, prix) OrElse prix <= 0 Then
            ErrorProvider1.SetError(TxtPrix, "le prix doit etre un nombre ")
            valide = False
        Else
            A.prix = prix
        End If
        If Not Integer.TryParse(TxtQuant.Text, qte) OrElse qte <= 0 Then
            ErrorProvider1.SetError(TxtQuant, "la quantite doit etre un entier ")
            valide = False
        Else
            A.qte = qte
        End If
        Return valide
    End Function
    Private Function init()
        TxtCode.Clear()
        TxtDesignation.Clear()
        TxtPrix.Clear()
        TxtQuant.Clear()
        TxtCode.Focus()
    End Function

    Private Sub BtnCalcul_Click(sender As Object, e As EventArgs) Handles BtnCalcul.Click
        Dim valeurTotale As Double = Articles.calculerValeurTotale()
        Dim articleCher As Articles.article = Articles.trouverArticlePlusCher()
        If Articles.listeArticle.Count > 0 Then
            MessageBox.Show("Valeur totale du stock : " & valeurTotale.ToString("N2") & " DT", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Article le plus cher :" & vbCrLf &
                            "Code : " & articleCher.code & vbCrLf &
                            "Désignation : " & articleCher.designation & vbCrLf &
                            "Prix : " & articleCher.prix.ToString("N2") & " DT" & vbCrLf &
                            "Quantité : " & articleCher.qte,
                            "Article le plus cher", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aucun article n'a été ajouté.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        TxtCode.Clear()
        TxtDesignation.Clear()
        TxtPrix.Clear()
        TxtQuant.Clear()
    End Sub
End Class

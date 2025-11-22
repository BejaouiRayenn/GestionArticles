Imports System.DirectoryServices.ActiveDirectory

Module Articles
    Public Structure article
        Dim code As Integer
        Dim qte As Integer
        Dim designation As String
        Dim prix As Double
    End Structure
    Public listeArticle As New List(Of article)
    Public Sub ajouterArticle(A As article)
        Dim x As Integer = existe(A)
        If x >= 0 Then
            Dim temp As article = listeArticle(x)
            temp.qte += A.qte
            temp.prix = A.prix
            listeArticle(x) = temp

        Else
            listeArticle.Add(A)
        End If
    End Sub
    Private Function existe(A As article) As Integer
        Dim p As Integer = -1
        For i As Integer = 0 To listeArticle.Count - 1
            If listeArticle(i).code = A.code Then
                p = i
            End If
        Next
        Return p
    End Function
    Public Function calculerValeurTotale() As Double
        Dim somme As Double = 0
        For Each l As article In listeArticle
            somme += l.qte * l.prix
        Next
        Return somme
    End Function
    Public Function trouverArticlePlusCher() As article
        If listeArticle.Count = 0 Then
            Return New article()
        End If
        Dim articleCher As article = listeArticle(0)
        For Each l As article In listeArticle
            If l.prix > articleCher.prix Then
                articleCher = l
            End If
        Next
        Return articleCher
    End Function






End Module

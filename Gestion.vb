Imports System.DirectoryServices.ActiveDirectory
Imports System.Reflection.Metadata.Ecma335

Module Gestion
    Public Structure Articles

        Dim code As Integer
        Dim qte As Integer
        Dim designation As String
        Dim prix As Double

    End Structure
    Public listearticle As New List(Of Article)
    Public Sub ajouterarticlee(A As Article)
        Dim x As Integer = existe(A)
        If (x >= 0 And x < listearticle.Count()) Then
            A.qte = listearticle(x).qte + A.qte
            listearticle(x) = A
            A.prix = listearticle(x).prix
        Else
            listearticle.Add(A)
        End If

    End Sub
    Function existe(A As Article)
        Dim verif As Integer = -1
        Dim pos As Integer = 0
        Dim D As Article
        For i As Integer = 0 To listearticle.Count()
            If D.code = A.code Then
                verif = 1
                pos = i
            End If
        Next
        Return pos
    End Function
    Function calculer()
        Dim somme As Double = 0
        Dim sommel As Double = 0
        For Each l As Article In listearticle
            sommel = l.qte * l.prix
            somme += sommel
        Next
        Return somme
    End Function
    Function clear()
        Dim c As Article = listearticle(0)
        If listearticle.Count = 0 Then

        End If
        For Each l In listearticle
            If l.prix > c.prix Then
                c = l
                Return (" l'element le plus cher est " & c.code & "de prix" & c.code)

            End If
        Next

    End Function


End Module

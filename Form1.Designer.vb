<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        LblCode = New Label()
        LblDesignation = New Label()
        LblPrix = New Label()
        LnlQuantite = New Label()
        TxtCode = New TextBox()
        TxtDesignation = New TextBox()
        TxtPrix = New TextBox()
        TxtQuant = New TextBox()
        BtnAjouter = New Button()
        BtnCalcul = New Button()
        BtnAnnuler = New Button()
        LblArticle = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblCode
        ' 
        LblCode.AutoSize = True
        LblCode.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblCode.Location = New Point(103, 98)
        LblCode.Name = "LblCode"
        LblCode.Size = New Size(44, 20)
        LblCode.TabIndex = 0
        LblCode.Text = "Code"
        ' 
        ' LblDesignation
        ' 
        LblDesignation.AutoSize = True
        LblDesignation.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblDesignation.Location = New Point(103, 144)
        LblDesignation.Name = "LblDesignation"
        LblDesignation.Size = New Size(93, 20)
        LblDesignation.TabIndex = 1
        LblDesignation.Text = "Designation"
        ' 
        ' LblPrix
        ' 
        LblPrix.AutoSize = True
        LblPrix.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblPrix.Location = New Point(103, 201)
        LblPrix.Name = "LblPrix"
        LblPrix.Size = New Size(36, 20)
        LblPrix.TabIndex = 2
        LblPrix.Text = "Prix"
        ' 
        ' LnlQuantite
        ' 
        LnlQuantite.AutoSize = True
        LnlQuantite.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LnlQuantite.Location = New Point(103, 252)
        LnlQuantite.Name = "LnlQuantite"
        LnlQuantite.Size = New Size(70, 20)
        LnlQuantite.TabIndex = 3
        LnlQuantite.Text = "Quantité"
        ' 
        ' TxtCode
        ' 
        TxtCode.Location = New Point(237, 91)
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(125, 27)
        TxtCode.TabIndex = 4
        ' 
        ' TxtDesignation
        ' 
        TxtDesignation.Location = New Point(237, 144)
        TxtDesignation.Name = "TxtDesignation"
        TxtDesignation.Size = New Size(125, 27)
        TxtDesignation.TabIndex = 5
        ' 
        ' TxtPrix
        ' 
        TxtPrix.Location = New Point(237, 198)
        TxtPrix.Name = "TxtPrix"
        TxtPrix.Size = New Size(125, 27)
        TxtPrix.TabIndex = 6
        ' 
        ' TxtQuant
        ' 
        TxtQuant.Location = New Point(237, 245)
        TxtQuant.Name = "TxtQuant"
        TxtQuant.Size = New Size(125, 27)
        TxtQuant.TabIndex = 7
        ' 
        ' BtnAjouter
        ' 
        BtnAjouter.BackColor = Color.Red
        BtnAjouter.Font = New Font("Segoe UI", 15F)
        BtnAjouter.Location = New Point(472, 89)
        BtnAjouter.Name = "BtnAjouter"
        BtnAjouter.Size = New Size(163, 49)
        BtnAjouter.TabIndex = 8
        BtnAjouter.Text = "Ajouter"
        BtnAjouter.UseVisualStyleBackColor = False
        ' 
        ' BtnCalcul
        ' 
        BtnCalcul.BackColor = Color.Red
        BtnCalcul.Font = New Font("Segoe UI", 15F)
        BtnCalcul.Location = New Point(472, 161)
        BtnCalcul.Name = "BtnCalcul"
        BtnCalcul.Size = New Size(163, 47)
        BtnCalcul.TabIndex = 9
        BtnCalcul.Text = "Calcul Total"
        BtnCalcul.UseVisualStyleBackColor = False
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.BackColor = Color.Red
        BtnAnnuler.Font = New Font("Segoe UI", 15F)
        BtnAnnuler.Location = New Point(472, 236)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(163, 43)
        BtnAnnuler.TabIndex = 10
        BtnAnnuler.Text = "Annuler"
        BtnAnnuler.UseVisualStyleBackColor = False
        ' 
        ' LblArticle
        ' 
        LblArticle.AutoSize = True
        LblArticle.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Italic)
        LblArticle.ForeColor = Color.Red
        LblArticle.Location = New Point(252, 22)
        LblArticle.Name = "LblArticle"
        LblArticle.Size = New Size(308, 46)
        LblArticle.TabIndex = 11
        LblArticle.Text = "Ajouter un article "
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Capture_d_écran_2025_11_22_210546
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(884, 450)
        Controls.Add(LblArticle)
        Controls.Add(BtnAnnuler)
        Controls.Add(BtnCalcul)
        Controls.Add(BtnAjouter)
        Controls.Add(TxtQuant)
        Controls.Add(TxtPrix)
        Controls.Add(TxtDesignation)
        Controls.Add(TxtCode)
        Controls.Add(LnlQuantite)
        Controls.Add(LblPrix)
        Controls.Add(LblDesignation)
        Controls.Add(LblCode)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblCode As Label
    Friend WithEvents LblDesignation As Label
    Friend WithEvents LblPrix As Label
    Friend WithEvents LnlQuantite As Label
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents TxtDesignation As TextBox
    Friend WithEvents TxtPrix As TextBox
    Friend WithEvents TxtQuant As TextBox
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents BtnCalcul As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents LblArticle As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class

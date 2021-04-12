<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Me.labCartellaBackup = New System.Windows.Forms.Label()
        Me.tbCartellaBackup = New System.Windows.Forms.TextBox()
        Me.gbContenutoBackup = New System.Windows.Forms.GroupBox()
        Me.chkSelezionaTutto = New System.Windows.Forms.CheckBox()
        Me.chkReport = New System.Windows.Forms.CheckBox()
        Me.chkLotti = New System.Windows.Forms.CheckBox()
        Me.chkRicette = New System.Windows.Forms.CheckBox()
        Me.chkImpostazioni = New System.Windows.Forms.CheckBox()
        Me.btnUscita = New System.Windows.Forms.Button()
        Me.btnSfoglia = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.fbdSelezioneCartella = New System.Windows.Forms.FolderBrowserDialog()
        Me.gbContenutoBackup.SuspendLayout()
        Me.SuspendLayout()
        '
        'labCartellaBackup
        '
        Me.labCartellaBackup.AutoSize = True
        Me.labCartellaBackup.Location = New System.Drawing.Point(14, 17)
        Me.labCartellaBackup.Margin = New System.Windows.Forms.Padding(5)
        Me.labCartellaBackup.Name = "labCartellaBackup"
        Me.labCartellaBackup.Size = New System.Drawing.Size(134, 18)
        Me.labCartellaBackup.TabIndex = 0
        Me.labCartellaBackup.Text = "Cartella di backup"
        '
        'tbCartellaBackup
        '
        Me.tbCartellaBackup.Location = New System.Drawing.Point(158, 14)
        Me.tbCartellaBackup.Margin = New System.Windows.Forms.Padding(5)
        Me.tbCartellaBackup.Name = "tbCartellaBackup"
        Me.tbCartellaBackup.Size = New System.Drawing.Size(400, 26)
        Me.tbCartellaBackup.TabIndex = 1
        '
        'gbContenutoBackup
        '
        Me.gbContenutoBackup.Controls.Add(Me.chkSelezionaTutto)
        Me.gbContenutoBackup.Controls.Add(Me.chkReport)
        Me.gbContenutoBackup.Controls.Add(Me.chkLotti)
        Me.gbContenutoBackup.Controls.Add(Me.chkRicette)
        Me.gbContenutoBackup.Controls.Add(Me.chkImpostazioni)
        Me.gbContenutoBackup.Location = New System.Drawing.Point(14, 50)
        Me.gbContenutoBackup.Margin = New System.Windows.Forms.Padding(5)
        Me.gbContenutoBackup.Name = "gbContenutoBackup"
        Me.gbContenutoBackup.Padding = New System.Windows.Forms.Padding(5)
        Me.gbContenutoBackup.Size = New System.Drawing.Size(200, 190)
        Me.gbContenutoBackup.TabIndex = 7
        Me.gbContenutoBackup.TabStop = False
        Me.gbContenutoBackup.Text = "Contenuto del backup"
        '
        'chkSelezionaTutto
        '
        Me.chkSelezionaTutto.AutoSize = True
        Me.chkSelezionaTutto.Location = New System.Drawing.Point(10, 29)
        Me.chkSelezionaTutto.Margin = New System.Windows.Forms.Padding(5)
        Me.chkSelezionaTutto.Name = "chkSelezionaTutto"
        Me.chkSelezionaTutto.Size = New System.Drawing.Size(96, 17)
        Me.chkSelezionaTutto.TabIndex = 11
        Me.chkSelezionaTutto.Text = "Seleziona tutto"
        Me.chkSelezionaTutto.UseVisualStyleBackColor = True
        '
        'chkReport
        '
        Me.chkReport.AutoSize = True
        Me.chkReport.Location = New System.Drawing.Point(10, 157)
        Me.chkReport.Margin = New System.Windows.Forms.Padding(5)
        Me.chkReport.Name = "chkReport"
        Me.chkReport.Size = New System.Drawing.Size(58, 17)
        Me.chkReport.TabIndex = 10
        Me.chkReport.Text = "Report"
        Me.chkReport.UseVisualStyleBackColor = True
        '
        'chkLotti
        '
        Me.chkLotti.AutoSize = True
        Me.chkLotti.Location = New System.Drawing.Point(10, 125)
        Me.chkLotti.Margin = New System.Windows.Forms.Padding(5)
        Me.chkLotti.Name = "chkLotti"
        Me.chkLotti.Size = New System.Drawing.Size(46, 17)
        Me.chkLotti.TabIndex = 9
        Me.chkLotti.Text = "Lotti"
        Me.chkLotti.UseVisualStyleBackColor = True
        '
        'chkRicette
        '
        Me.chkRicette.AutoSize = True
        Me.chkRicette.Location = New System.Drawing.Point(10, 93)
        Me.chkRicette.Margin = New System.Windows.Forms.Padding(5)
        Me.chkRicette.Name = "chkRicette"
        Me.chkRicette.Size = New System.Drawing.Size(60, 17)
        Me.chkRicette.TabIndex = 8
        Me.chkRicette.Text = "Ricette"
        Me.chkRicette.UseVisualStyleBackColor = True
        '
        'chkImpostazioni
        '
        Me.chkImpostazioni.AutoSize = True
        Me.chkImpostazioni.Location = New System.Drawing.Point(10, 61)
        Me.chkImpostazioni.Margin = New System.Windows.Forms.Padding(5)
        Me.chkImpostazioni.Name = "chkImpostazioni"
        Me.chkImpostazioni.Size = New System.Drawing.Size(84, 17)
        Me.chkImpostazioni.TabIndex = 7
        Me.chkImpostazioni.Text = "Impostazioni"
        Me.chkImpostazioni.UseVisualStyleBackColor = True
        '
        'btnUscita
        '
        Me.btnUscita.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUscita.Image = CType(resources.GetObject("btnUscita.Image"), System.Drawing.Image)
        Me.btnUscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUscita.Location = New System.Drawing.Point(568, 140)
        Me.btnUscita.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUscita.Name = "btnUscita"
        Me.btnUscita.Size = New System.Drawing.Size(90, 100)
        Me.btnUscita.TabIndex = 9
        Me.btnUscita.Text = "Uscita"
        Me.btnUscita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUscita.UseVisualStyleBackColor = True
        '
        'btnSfoglia
        '
        Me.btnSfoglia.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSfoglia.Image = CType(resources.GetObject("btnSfoglia.Image"), System.Drawing.Image)
        Me.btnSfoglia.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSfoglia.Location = New System.Drawing.Point(568, 14)
        Me.btnSfoglia.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSfoglia.Name = "btnSfoglia"
        Me.btnSfoglia.Size = New System.Drawing.Size(90, 100)
        Me.btnSfoglia.TabIndex = 10
        Me.btnSfoglia.Text = "Sfoglia"
        Me.btnSfoglia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSfoglia.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackup.Location = New System.Drawing.Point(468, 140)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(90, 100)
        Me.btnBackup.TabIndex = 11
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 254)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnSfoglia)
        Me.Controls.Add(Me.btnUscita)
        Me.Controls.Add(Me.gbContenutoBackup)
        Me.Controls.Add(Me.tbCartellaBackup)
        Me.Controls.Add(Me.labCartellaBackup)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup"
        Me.gbContenutoBackup.ResumeLayout(False)
        Me.gbContenutoBackup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labCartellaBackup As System.Windows.Forms.Label
    Friend WithEvents tbCartellaBackup As System.Windows.Forms.TextBox
    Friend WithEvents gbContenutoBackup As System.Windows.Forms.GroupBox
    Friend WithEvents chkSelezionaTutto As System.Windows.Forms.CheckBox
    Friend WithEvents chkReport As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotti As System.Windows.Forms.CheckBox
    Friend WithEvents chkRicette As System.Windows.Forms.CheckBox
    Friend WithEvents chkImpostazioni As System.Windows.Forms.CheckBox
    Friend WithEvents btnUscita As System.Windows.Forms.Button
    Friend WithEvents btnSfoglia As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents fbdSelezioneCartella As System.Windows.Forms.FolderBrowserDialog
End Class

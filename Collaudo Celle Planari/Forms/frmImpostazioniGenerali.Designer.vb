<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpostazioniGenerali
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpostazioniGenerali))
        Me.btnAnnullaModifiche = New System.Windows.Forms.Button()
        Me.btnSalvaModifiche = New System.Windows.Forms.Button()
        Me.btnUscita = New System.Windows.Forms.Button()
        Me.chkAbilitazioneCicliMaster = New System.Windows.Forms.CheckBox()
        Me.labCartellaBackup = New System.Windows.Forms.Label()
        Me.fbdSelezioneCartella = New System.Windows.Forms.FolderBrowserDialog()
        Me.tbCartellaBackup = New System.Windows.Forms.TextBox()
        Me.btnSfogliaBackup = New System.Windows.Forms.Button()
        Me.btnModifica = New System.Windows.Forms.Button()
        Me.chkAbilitazioneInterruzioneCiclo = New System.Windows.Forms.CheckBox()
        Me.labDescFlussoAriaTaratura = New System.Windows.Forms.Label()
        Me.labDescFlussoAzotoTaratura = New System.Windows.Forms.Label()
        Me.tbFlussoAriaTaratura = New System.Windows.Forms.TextBox()
        Me.tbFlussoAzotoTaratura = New System.Windows.Forms.TextBox()
        Me.labUdmFlussoAriaTaratura = New System.Windows.Forms.Label()
        Me.labUdmFlussoAzotoTaratura = New System.Windows.Forms.Label()
        Me.labCartellaBackupLotti = New System.Windows.Forms.Label()
        Me.tbCartellaBackupLotti = New System.Windows.Forms.TextBox()
        Me.btnSfogliaBackupLotti = New System.Windows.Forms.Button()
        Me.labCartellaBackupRicette = New System.Windows.Forms.Label()
        Me.tbCartellaBackupRicette = New System.Windows.Forms.TextBox()
        Me.btnSfogliaBackupRicette = New System.Windows.Forms.Button()
        Me.labCartellaBackupTarature = New System.Windows.Forms.Label()
        Me.tbCartellaBackupTarature = New System.Windows.Forms.TextBox()
        Me.btnSfogliaBackupTarature = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAnnullaModifiche
        '
        Me.btnAnnullaModifiche.Image = CType(resources.GetObject("btnAnnullaModifiche.Image"), System.Drawing.Image)
        Me.btnAnnullaModifiche.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnnullaModifiche.Location = New System.Drawing.Point(700, 105)
        Me.btnAnnullaModifiche.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAnnullaModifiche.Name = "btnAnnullaModifiche"
        Me.btnAnnullaModifiche.Size = New System.Drawing.Size(100, 80)
        Me.btnAnnullaModifiche.TabIndex = 6
        Me.btnAnnullaModifiche.Text = "Annulla modifiche"
        Me.btnAnnullaModifiche.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnnullaModifiche.UseVisualStyleBackColor = True
        '
        'btnSalvaModifiche
        '
        Me.btnSalvaModifiche.Image = CType(resources.GetObject("btnSalvaModifiche.Image"), System.Drawing.Image)
        Me.btnSalvaModifiche.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvaModifiche.Location = New System.Drawing.Point(700, 195)
        Me.btnSalvaModifiche.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalvaModifiche.Name = "btnSalvaModifiche"
        Me.btnSalvaModifiche.Size = New System.Drawing.Size(100, 80)
        Me.btnSalvaModifiche.TabIndex = 7
        Me.btnSalvaModifiche.Text = "Salva modifiche"
        Me.btnSalvaModifiche.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvaModifiche.UseVisualStyleBackColor = True
        '
        'btnUscita
        '
        Me.btnUscita.Image = CType(resources.GetObject("btnUscita.Image"), System.Drawing.Image)
        Me.btnUscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUscita.Location = New System.Drawing.Point(700, 285)
        Me.btnUscita.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUscita.Name = "btnUscita"
        Me.btnUscita.Size = New System.Drawing.Size(100, 80)
        Me.btnUscita.TabIndex = 8
        Me.btnUscita.Text = "Uscita"
        Me.btnUscita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUscita.UseVisualStyleBackColor = True
        '
        'chkAbilitazioneCicliMaster
        '
        Me.chkAbilitazioneCicliMaster.AutoSize = True
        Me.chkAbilitazioneCicliMaster.Location = New System.Drawing.Point(14, 15)
        Me.chkAbilitazioneCicliMaster.Margin = New System.Windows.Forms.Padding(5)
        Me.chkAbilitazioneCicliMaster.Name = "chkAbilitazioneCicliMaster"
        Me.chkAbilitazioneCicliMaster.Size = New System.Drawing.Size(191, 22)
        Me.chkAbilitazioneCicliMaster.TabIndex = 0
        Me.chkAbilitazioneCicliMaster.Text = "Abilitazione cicli master"
        Me.chkAbilitazioneCicliMaster.UseVisualStyleBackColor = True
        '
        'labCartellaBackup
        '
        Me.labCartellaBackup.AutoSize = True
        Me.labCartellaBackup.Location = New System.Drawing.Point(14, 165)
        Me.labCartellaBackup.Margin = New System.Windows.Forms.Padding(5)
        Me.labCartellaBackup.Name = "labCartellaBackup"
        Me.labCartellaBackup.Size = New System.Drawing.Size(180, 18)
        Me.labCartellaBackup.TabIndex = 2
        Me.labCartellaBackup.Text = "Cartella backup software"
        '
        'tbCartellaBackup
        '
        Me.tbCartellaBackup.Location = New System.Drawing.Point(213, 160)
        Me.tbCartellaBackup.Margin = New System.Windows.Forms.Padding(5)
        Me.tbCartellaBackup.Name = "tbCartellaBackup"
        Me.tbCartellaBackup.Size = New System.Drawing.Size(367, 26)
        Me.tbCartellaBackup.TabIndex = 3
        '
        'btnSfogliaBackup
        '
        Me.btnSfogliaBackup.Location = New System.Drawing.Point(590, 160)
        Me.btnSfogliaBackup.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSfogliaBackup.Name = "btnSfogliaBackup"
        Me.btnSfogliaBackup.Size = New System.Drawing.Size(100, 26)
        Me.btnSfogliaBackup.TabIndex = 4
        Me.btnSfogliaBackup.Text = "Sfoglia"
        Me.btnSfogliaBackup.UseVisualStyleBackColor = True
        '
        'btnModifica
        '
        Me.btnModifica.Image = CType(resources.GetObject("btnModifica.Image"), System.Drawing.Image)
        Me.btnModifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModifica.Location = New System.Drawing.Point(700, 15)
        Me.btnModifica.Margin = New System.Windows.Forms.Padding(5)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(100, 80)
        Me.btnModifica.TabIndex = 5
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'chkAbilitazioneInterruzioneCiclo
        '
        Me.chkAbilitazioneInterruzioneCiclo.AutoSize = True
        Me.chkAbilitazioneInterruzioneCiclo.Location = New System.Drawing.Point(14, 50)
        Me.chkAbilitazioneInterruzioneCiclo.Margin = New System.Windows.Forms.Padding(5)
        Me.chkAbilitazioneInterruzioneCiclo.Name = "chkAbilitazioneInterruzioneCiclo"
        Me.chkAbilitazioneInterruzioneCiclo.Size = New System.Drawing.Size(335, 22)
        Me.chkAbilitazioneInterruzioneCiclo.TabIndex = 1
        Me.chkAbilitazioneInterruzioneCiclo.Text = "Abilitazione interruzione ciclo al primo scarto"
        Me.chkAbilitazioneInterruzioneCiclo.UseVisualStyleBackColor = True
        '
        'labDescFlussoAriaTaratura
        '
        Me.labDescFlussoAriaTaratura.AutoSize = True
        Me.labDescFlussoAriaTaratura.Location = New System.Drawing.Point(14, 90)
        Me.labDescFlussoAriaTaratura.Name = "labDescFlussoAriaTaratura"
        Me.labDescFlussoAriaTaratura.Size = New System.Drawing.Size(173, 18)
        Me.labDescFlussoAriaTaratura.TabIndex = 9
        Me.labDescFlussoAriaTaratura.Text = "Flusso Aria per Taratura"
        '
        'labDescFlussoAzotoTaratura
        '
        Me.labDescFlussoAzotoTaratura.AutoSize = True
        Me.labDescFlussoAzotoTaratura.Location = New System.Drawing.Point(14, 125)
        Me.labDescFlussoAzotoTaratura.Name = "labDescFlussoAzotoTaratura"
        Me.labDescFlussoAzotoTaratura.Size = New System.Drawing.Size(184, 18)
        Me.labDescFlussoAzotoTaratura.TabIndex = 9
        Me.labDescFlussoAzotoTaratura.Text = "Flusso Azoto per Taratura"
        '
        'tbFlussoAriaTaratura
        '
        Me.tbFlussoAriaTaratura.Location = New System.Drawing.Point(213, 87)
        Me.tbFlussoAriaTaratura.Name = "tbFlussoAriaTaratura"
        Me.tbFlussoAriaTaratura.Size = New System.Drawing.Size(100, 26)
        Me.tbFlussoAriaTaratura.TabIndex = 10
        '
        'tbFlussoAzotoTaratura
        '
        Me.tbFlussoAzotoTaratura.Location = New System.Drawing.Point(213, 122)
        Me.tbFlussoAzotoTaratura.Name = "tbFlussoAzotoTaratura"
        Me.tbFlussoAzotoTaratura.Size = New System.Drawing.Size(100, 26)
        Me.tbFlussoAzotoTaratura.TabIndex = 10
        '
        'labUdmFlussoAriaTaratura
        '
        Me.labUdmFlussoAriaTaratura.AutoSize = True
        Me.labUdmFlussoAriaTaratura.Location = New System.Drawing.Point(330, 90)
        Me.labUdmFlussoAriaTaratura.Name = "labUdmFlussoAriaTaratura"
        Me.labUdmFlussoAriaTaratura.Size = New System.Drawing.Size(72, 18)
        Me.labUdmFlussoAriaTaratura.TabIndex = 9
        Me.labUdmFlussoAriaTaratura.Text = "Nl/minuto"
        '
        'labUdmFlussoAzotoTaratura
        '
        Me.labUdmFlussoAzotoTaratura.AutoSize = True
        Me.labUdmFlussoAzotoTaratura.Location = New System.Drawing.Point(330, 125)
        Me.labUdmFlussoAzotoTaratura.Name = "labUdmFlussoAzotoTaratura"
        Me.labUdmFlussoAzotoTaratura.Size = New System.Drawing.Size(72, 18)
        Me.labUdmFlussoAzotoTaratura.TabIndex = 9
        Me.labUdmFlussoAzotoTaratura.Text = "Nl/minuto"
        '
        'labCartellaBackupLotti
        '
        Me.labCartellaBackupLotti.AutoSize = True
        Me.labCartellaBackupLotti.Location = New System.Drawing.Point(14, 200)
        Me.labCartellaBackupLotti.Margin = New System.Windows.Forms.Padding(5)
        Me.labCartellaBackupLotti.Name = "labCartellaBackupLotti"
        Me.labCartellaBackupLotti.Size = New System.Drawing.Size(134, 18)
        Me.labCartellaBackupLotti.TabIndex = 2
        Me.labCartellaBackupLotti.Text = "Backup report lotti"
        '
        'tbCartellaBackupLotti
        '
        Me.tbCartellaBackupLotti.Location = New System.Drawing.Point(213, 195)
        Me.tbCartellaBackupLotti.Margin = New System.Windows.Forms.Padding(5)
        Me.tbCartellaBackupLotti.Name = "tbCartellaBackupLotti"
        Me.tbCartellaBackupLotti.Size = New System.Drawing.Size(367, 26)
        Me.tbCartellaBackupLotti.TabIndex = 3
        '
        'btnSfogliaBackupLotti
        '
        Me.btnSfogliaBackupLotti.Location = New System.Drawing.Point(590, 195)
        Me.btnSfogliaBackupLotti.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSfogliaBackupLotti.Name = "btnSfogliaBackupLotti"
        Me.btnSfogliaBackupLotti.Size = New System.Drawing.Size(100, 26)
        Me.btnSfogliaBackupLotti.TabIndex = 4
        Me.btnSfogliaBackupLotti.Text = "Sfoglia"
        Me.btnSfogliaBackupLotti.UseVisualStyleBackColor = True
        '
        'labCartellaBackupRicette
        '
        Me.labCartellaBackupRicette.AutoSize = True
        Me.labCartellaBackupRicette.Location = New System.Drawing.Point(14, 235)
        Me.labCartellaBackupRicette.Margin = New System.Windows.Forms.Padding(5)
        Me.labCartellaBackupRicette.Name = "labCartellaBackupRicette"
        Me.labCartellaBackupRicette.Size = New System.Drawing.Size(153, 18)
        Me.labCartellaBackupRicette.TabIndex = 2
        Me.labCartellaBackupRicette.Text = "Backup report ricette"
        '
        'tbCartellaBackupRicette
        '
        Me.tbCartellaBackupRicette.Location = New System.Drawing.Point(213, 230)
        Me.tbCartellaBackupRicette.Margin = New System.Windows.Forms.Padding(5)
        Me.tbCartellaBackupRicette.Name = "tbCartellaBackupRicette"
        Me.tbCartellaBackupRicette.Size = New System.Drawing.Size(367, 26)
        Me.tbCartellaBackupRicette.TabIndex = 3
        '
        'btnSfogliaBackupRicette
        '
        Me.btnSfogliaBackupRicette.Location = New System.Drawing.Point(590, 230)
        Me.btnSfogliaBackupRicette.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSfogliaBackupRicette.Name = "btnSfogliaBackupRicette"
        Me.btnSfogliaBackupRicette.Size = New System.Drawing.Size(100, 26)
        Me.btnSfogliaBackupRicette.TabIndex = 4
        Me.btnSfogliaBackupRicette.Text = "Sfoglia"
        Me.btnSfogliaBackupRicette.UseVisualStyleBackColor = True
        '
        'labCartellaBackupTarature
        '
        Me.labCartellaBackupTarature.AutoSize = True
        Me.labCartellaBackupTarature.Location = New System.Drawing.Point(14, 270)
        Me.labCartellaBackupTarature.Margin = New System.Windows.Forms.Padding(5)
        Me.labCartellaBackupTarature.Name = "labCartellaBackupTarature"
        Me.labCartellaBackupTarature.Size = New System.Drawing.Size(163, 18)
        Me.labCartellaBackupTarature.TabIndex = 2
        Me.labCartellaBackupTarature.Text = "Backup report tarature"
        '
        'tbCartellaBackupTarature
        '
        Me.tbCartellaBackupTarature.Location = New System.Drawing.Point(213, 265)
        Me.tbCartellaBackupTarature.Margin = New System.Windows.Forms.Padding(5)
        Me.tbCartellaBackupTarature.Name = "tbCartellaBackupTarature"
        Me.tbCartellaBackupTarature.Size = New System.Drawing.Size(367, 26)
        Me.tbCartellaBackupTarature.TabIndex = 3
        '
        'btnSfogliaBackupTarature
        '
        Me.btnSfogliaBackupTarature.Location = New System.Drawing.Point(590, 265)
        Me.btnSfogliaBackupTarature.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSfogliaBackupTarature.Name = "btnSfogliaBackupTarature"
        Me.btnSfogliaBackupTarature.Size = New System.Drawing.Size(100, 26)
        Me.btnSfogliaBackupTarature.TabIndex = 4
        Me.btnSfogliaBackupTarature.Text = "Sfoglia"
        Me.btnSfogliaBackupTarature.UseVisualStyleBackColor = True
        '
        'frmImpostazioniGenerali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 381)
        Me.Controls.Add(Me.tbFlussoAzotoTaratura)
        Me.Controls.Add(Me.tbFlussoAriaTaratura)
        Me.Controls.Add(Me.labDescFlussoAzotoTaratura)
        Me.Controls.Add(Me.labUdmFlussoAzotoTaratura)
        Me.Controls.Add(Me.labUdmFlussoAriaTaratura)
        Me.Controls.Add(Me.labDescFlussoAriaTaratura)
        Me.Controls.Add(Me.chkAbilitazioneInterruzioneCiclo)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.btnSfogliaBackupTarature)
        Me.Controls.Add(Me.btnSfogliaBackupRicette)
        Me.Controls.Add(Me.btnSfogliaBackupLotti)
        Me.Controls.Add(Me.btnSfogliaBackup)
        Me.Controls.Add(Me.tbCartellaBackupTarature)
        Me.Controls.Add(Me.labCartellaBackupTarature)
        Me.Controls.Add(Me.tbCartellaBackupRicette)
        Me.Controls.Add(Me.labCartellaBackupRicette)
        Me.Controls.Add(Me.tbCartellaBackupLotti)
        Me.Controls.Add(Me.labCartellaBackupLotti)
        Me.Controls.Add(Me.tbCartellaBackup)
        Me.Controls.Add(Me.labCartellaBackup)
        Me.Controls.Add(Me.chkAbilitazioneCicliMaster)
        Me.Controls.Add(Me.btnUscita)
        Me.Controls.Add(Me.btnAnnullaModifiche)
        Me.Controls.Add(Me.btnSalvaModifiche)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpostazioniGenerali"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impostazioni generali"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAnnullaModifiche As System.Windows.Forms.Button
    Friend WithEvents btnSalvaModifiche As System.Windows.Forms.Button
    Friend WithEvents btnUscita As System.Windows.Forms.Button
    Friend WithEvents chkAbilitazioneCicliMaster As System.Windows.Forms.CheckBox
    Friend WithEvents labCartellaBackup As System.Windows.Forms.Label
    Friend WithEvents fbdSelezioneCartella As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tbCartellaBackup As System.Windows.Forms.TextBox
    Friend WithEvents btnSfogliaBackup As System.Windows.Forms.Button
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents chkAbilitazioneInterruzioneCiclo As System.Windows.Forms.CheckBox
    Friend WithEvents labDescFlussoAriaTaratura As Label
    Friend WithEvents labDescFlussoAzotoTaratura As Label
    Friend WithEvents tbFlussoAriaTaratura As TextBox
    Friend WithEvents tbFlussoAzotoTaratura As TextBox
    Friend WithEvents labUdmFlussoAriaTaratura As Label
    Friend WithEvents labUdmFlussoAzotoTaratura As Label
    Friend WithEvents labCartellaBackupLotti As Label
    Friend WithEvents tbCartellaBackupLotti As TextBox
    Friend WithEvents btnSfogliaBackupLotti As Button
    Friend WithEvents labCartellaBackupRicette As Label
    Friend WithEvents tbCartellaBackupRicette As TextBox
    Friend WithEvents btnSfogliaBackupRicette As Button
    Friend WithEvents labCartellaBackupTarature As Label
    Friend WithEvents tbCartellaBackupTarature As TextBox
    Friend WithEvents btnSfogliaBackupTarature As Button
End Class

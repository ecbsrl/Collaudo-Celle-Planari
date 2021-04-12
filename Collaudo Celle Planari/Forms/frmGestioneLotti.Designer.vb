<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestioneLotti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestioneLotti))
        Me.gbGestioneLotti = New System.Windows.Forms.GroupBox()
        Me.labLottoAttivo = New System.Windows.Forms.Label()
        Me.labDescrLottoAttivo = New System.Windows.Forms.Label()
        Me.lbLotti = New System.Windows.Forms.ListBox()
        Me.btnCancellaLotto = New System.Windows.Forms.Button()
        Me.btnVisualizzaLotto = New System.Windows.Forms.Button()
        Me.btnCreaLotto = New System.Windows.Forms.Button()
        Me.btnRicercaLotto = New System.Windows.Forms.Button()
        Me.gbParametriLotto = New System.Windows.Forms.GroupBox()
        Me.btnModificaLotto = New System.Windows.Forms.Button()
        Me.btnAnnullaModifiche = New System.Windows.Forms.Button()
        Me.tbNumeroOrdine = New System.Windows.Forms.TextBox()
        Me.tbNote = New System.Windows.Forms.TextBox()
        Me.labDescrNote = New System.Windows.Forms.Label()
        Me.cbRicetta = New System.Windows.Forms.ComboBox()
        Me.labDescrRicetta = New System.Windows.Forms.Label()
        Me.labDataOraCreazione = New System.Windows.Forms.Label()
        Me.labDescrDataOraCreazione = New System.Windows.Forms.Label()
        Me.labDescrNumeroOrdine = New System.Windows.Forms.Label()
        Me.btnNascondiLotto = New System.Windows.Forms.Button()
        Me.btnSalvaModifiche = New System.Windows.Forms.Button()
        Me.btnAttivaLotto = New System.Windows.Forms.Button()
        Me.pdPrintDialog = New System.Windows.Forms.PrintDialog()
        Me.pdPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.btnUscita = New System.Windows.Forms.Button()
        Me.gbGestioneLotti.SuspendLayout()
        Me.gbParametriLotto.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbGestioneLotti
        '
        Me.gbGestioneLotti.Controls.Add(Me.labLottoAttivo)
        Me.gbGestioneLotti.Controls.Add(Me.labDescrLottoAttivo)
        Me.gbGestioneLotti.Controls.Add(Me.lbLotti)
        Me.gbGestioneLotti.Controls.Add(Me.btnCancellaLotto)
        Me.gbGestioneLotti.Controls.Add(Me.btnVisualizzaLotto)
        Me.gbGestioneLotti.Controls.Add(Me.btnCreaLotto)
        Me.gbGestioneLotti.Controls.Add(Me.btnRicercaLotto)
        Me.gbGestioneLotti.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGestioneLotti.Location = New System.Drawing.Point(14, 12)
        Me.gbGestioneLotti.Margin = New System.Windows.Forms.Padding(5)
        Me.gbGestioneLotti.Name = "gbGestioneLotti"
        Me.gbGestioneLotti.Padding = New System.Windows.Forms.Padding(5)
        Me.gbGestioneLotti.Size = New System.Drawing.Size(295, 716)
        Me.gbGestioneLotti.TabIndex = 0
        Me.gbGestioneLotti.TabStop = False
        Me.gbGestioneLotti.Text = "Gestione lotti"
        '
        'labLottoAttivo
        '
        Me.labLottoAttivo.BackColor = System.Drawing.Color.White
        Me.labLottoAttivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labLottoAttivo.Location = New System.Drawing.Point(10, 680)
        Me.labLottoAttivo.Margin = New System.Windows.Forms.Padding(5)
        Me.labLottoAttivo.Name = "labLottoAttivo"
        Me.labLottoAttivo.Size = New System.Drawing.Size(271, 26)
        Me.labLottoAttivo.TabIndex = 7
        Me.labLottoAttivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrLottoAttivo
        '
        Me.labDescrLottoAttivo.Location = New System.Drawing.Point(10, 646)
        Me.labDescrLottoAttivo.Margin = New System.Windows.Forms.Padding(3)
        Me.labDescrLottoAttivo.Name = "labDescrLottoAttivo"
        Me.labDescrLottoAttivo.Size = New System.Drawing.Size(271, 26)
        Me.labDescrLottoAttivo.TabIndex = 6
        Me.labDescrLottoAttivo.Text = "Lotto attivo"
        Me.labDescrLottoAttivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbLotti
        '
        Me.lbLotti.FormattingEnabled = True
        Me.lbLotti.ItemHeight = 18
        Me.lbLotti.Location = New System.Drawing.Point(120, 29)
        Me.lbLotti.Margin = New System.Windows.Forms.Padding(5)
        Me.lbLotti.Name = "lbLotti"
        Me.lbLotti.Size = New System.Drawing.Size(161, 598)
        Me.lbLotti.TabIndex = 5
        '
        'btnCancellaLotto
        '
        Me.btnCancellaLotto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancellaLotto.Image = CType(resources.GetObject("btnCancellaLotto.Image"), System.Drawing.Image)
        Me.btnCancellaLotto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancellaLotto.Location = New System.Drawing.Point(10, 169)
        Me.btnCancellaLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancellaLotto.Name = "btnCancellaLotto"
        Me.btnCancellaLotto.Size = New System.Drawing.Size(100, 60)
        Me.btnCancellaLotto.TabIndex = 2
        Me.btnCancellaLotto.Text = "Cancella"
        Me.btnCancellaLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancellaLotto.UseVisualStyleBackColor = True
        '
        'btnVisualizzaLotto
        '
        Me.btnVisualizzaLotto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizzaLotto.Image = CType(resources.GetObject("btnVisualizzaLotto.Image"), System.Drawing.Image)
        Me.btnVisualizzaLotto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVisualizzaLotto.Location = New System.Drawing.Point(10, 239)
        Me.btnVisualizzaLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnVisualizzaLotto.Name = "btnVisualizzaLotto"
        Me.btnVisualizzaLotto.Size = New System.Drawing.Size(100, 60)
        Me.btnVisualizzaLotto.TabIndex = 3
        Me.btnVisualizzaLotto.Text = "Visualizza"
        Me.btnVisualizzaLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVisualizzaLotto.UseVisualStyleBackColor = True
        '
        'btnCreaLotto
        '
        Me.btnCreaLotto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreaLotto.Image = CType(resources.GetObject("btnCreaLotto.Image"), System.Drawing.Image)
        Me.btnCreaLotto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCreaLotto.Location = New System.Drawing.Point(10, 99)
        Me.btnCreaLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCreaLotto.Name = "btnCreaLotto"
        Me.btnCreaLotto.Size = New System.Drawing.Size(100, 60)
        Me.btnCreaLotto.TabIndex = 1
        Me.btnCreaLotto.Text = "Crea"
        Me.btnCreaLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCreaLotto.UseVisualStyleBackColor = True
        '
        'btnRicercaLotto
        '
        Me.btnRicercaLotto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRicercaLotto.Image = CType(resources.GetObject("btnRicercaLotto.Image"), System.Drawing.Image)
        Me.btnRicercaLotto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRicercaLotto.Location = New System.Drawing.Point(10, 29)
        Me.btnRicercaLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRicercaLotto.Name = "btnRicercaLotto"
        Me.btnRicercaLotto.Size = New System.Drawing.Size(100, 60)
        Me.btnRicercaLotto.TabIndex = 0
        Me.btnRicercaLotto.Text = "Ricerca"
        Me.btnRicercaLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRicercaLotto.UseVisualStyleBackColor = True
        '
        'gbParametriLotto
        '
        Me.gbParametriLotto.Controls.Add(Me.btnModificaLotto)
        Me.gbParametriLotto.Controls.Add(Me.btnAnnullaModifiche)
        Me.gbParametriLotto.Controls.Add(Me.tbNumeroOrdine)
        Me.gbParametriLotto.Controls.Add(Me.tbNote)
        Me.gbParametriLotto.Controls.Add(Me.labDescrNote)
        Me.gbParametriLotto.Controls.Add(Me.cbRicetta)
        Me.gbParametriLotto.Controls.Add(Me.labDescrRicetta)
        Me.gbParametriLotto.Controls.Add(Me.labDataOraCreazione)
        Me.gbParametriLotto.Controls.Add(Me.labDescrDataOraCreazione)
        Me.gbParametriLotto.Controls.Add(Me.labDescrNumeroOrdine)
        Me.gbParametriLotto.Controls.Add(Me.btnNascondiLotto)
        Me.gbParametriLotto.Controls.Add(Me.btnSalvaModifiche)
        Me.gbParametriLotto.Controls.Add(Me.btnAttivaLotto)
        Me.gbParametriLotto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbParametriLotto.Location = New System.Drawing.Point(319, 12)
        Me.gbParametriLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.gbParametriLotto.Name = "gbParametriLotto"
        Me.gbParametriLotto.Padding = New System.Windows.Forms.Padding(5)
        Me.gbParametriLotto.Size = New System.Drawing.Size(685, 646)
        Me.gbParametriLotto.TabIndex = 1
        Me.gbParametriLotto.TabStop = False
        Me.gbParametriLotto.Text = "Parametri lotto"
        Me.gbParametriLotto.Visible = False
        '
        'btnModificaLotto
        '
        Me.btnModificaLotto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaLotto.Image = CType(resources.GetObject("btnModificaLotto.Image"), System.Drawing.Image)
        Me.btnModificaLotto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificaLotto.Location = New System.Drawing.Point(10, 170)
        Me.btnModificaLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnModificaLotto.Name = "btnModificaLotto"
        Me.btnModificaLotto.Size = New System.Drawing.Size(100, 60)
        Me.btnModificaLotto.TabIndex = 3
        Me.btnModificaLotto.Text = "Modifica"
        Me.btnModificaLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificaLotto.UseVisualStyleBackColor = True
        '
        'btnAnnullaModifiche
        '
        Me.btnAnnullaModifiche.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnullaModifiche.Image = CType(resources.GetObject("btnAnnullaModifiche.Image"), System.Drawing.Image)
        Me.btnAnnullaModifiche.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnnullaModifiche.Location = New System.Drawing.Point(10, 240)
        Me.btnAnnullaModifiche.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAnnullaModifiche.Name = "btnAnnullaModifiche"
        Me.btnAnnullaModifiche.Size = New System.Drawing.Size(100, 80)
        Me.btnAnnullaModifiche.TabIndex = 4
        Me.btnAnnullaModifiche.Text = "Annulla modifiche"
        Me.btnAnnullaModifiche.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnnullaModifiche.UseVisualStyleBackColor = True
        '
        'tbNumeroOrdine
        '
        Me.tbNumeroOrdine.Location = New System.Drawing.Point(340, 86)
        Me.tbNumeroOrdine.Margin = New System.Windows.Forms.Padding(5)
        Me.tbNumeroOrdine.MaxLength = 30
        Me.tbNumeroOrdine.Name = "tbNumeroOrdine"
        Me.tbNumeroOrdine.Size = New System.Drawing.Size(250, 26)
        Me.tbNumeroOrdine.TabIndex = 9
        '
        'tbNote
        '
        Me.tbNote.Location = New System.Drawing.Point(153, 194)
        Me.tbNote.Margin = New System.Windows.Forms.Padding(5)
        Me.tbNote.MaxLength = 200
        Me.tbNote.Multiline = True
        Me.tbNote.Name = "tbNote"
        Me.tbNote.Size = New System.Drawing.Size(522, 285)
        Me.tbNote.TabIndex = 13
        '
        'labDescrNote
        '
        Me.labDescrNote.Location = New System.Drawing.Point(153, 158)
        Me.labDescrNote.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrNote.Name = "labDescrNote"
        Me.labDescrNote.Size = New System.Drawing.Size(522, 26)
        Me.labDescrNote.TabIndex = 12
        Me.labDescrNote.Text = "Note"
        Me.labDescrNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbRicetta
        '
        Me.cbRicetta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRicetta.FormattingEnabled = True
        Me.cbRicetta.Location = New System.Drawing.Point(340, 122)
        Me.cbRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.cbRicetta.Name = "cbRicetta"
        Me.cbRicetta.Size = New System.Drawing.Size(250, 26)
        Me.cbRicetta.TabIndex = 11
        '
        'labDescrRicetta
        '
        Me.labDescrRicetta.Location = New System.Drawing.Point(150, 122)
        Me.labDescrRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrRicetta.Name = "labDescrRicetta"
        Me.labDescrRicetta.Size = New System.Drawing.Size(130, 26)
        Me.labDescrRicetta.TabIndex = 10
        Me.labDescrRicetta.Text = "Ricetta associata"
        Me.labDescrRicetta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDataOraCreazione
        '
        Me.labDataOraCreazione.BackColor = System.Drawing.Color.White
        Me.labDataOraCreazione.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDataOraCreazione.Location = New System.Drawing.Point(340, 50)
        Me.labDataOraCreazione.Margin = New System.Windows.Forms.Padding(5)
        Me.labDataOraCreazione.Name = "labDataOraCreazione"
        Me.labDataOraCreazione.Size = New System.Drawing.Size(250, 26)
        Me.labDataOraCreazione.TabIndex = 7
        Me.labDataOraCreazione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrDataOraCreazione
        '
        Me.labDescrDataOraCreazione.Location = New System.Drawing.Point(150, 50)
        Me.labDescrDataOraCreazione.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrDataOraCreazione.Name = "labDescrDataOraCreazione"
        Me.labDescrDataOraCreazione.Size = New System.Drawing.Size(180, 26)
        Me.labDescrDataOraCreazione.TabIndex = 6
        Me.labDescrDataOraCreazione.Text = "Data di creazione"
        Me.labDescrDataOraCreazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDescrNumeroOrdine
        '
        Me.labDescrNumeroOrdine.Location = New System.Drawing.Point(150, 86)
        Me.labDescrNumeroOrdine.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrNumeroOrdine.Name = "labDescrNumeroOrdine"
        Me.labDescrNumeroOrdine.Size = New System.Drawing.Size(130, 26)
        Me.labDescrNumeroOrdine.TabIndex = 8
        Me.labDescrNumeroOrdine.Text = "Numero d'ordine"
        Me.labDescrNumeroOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNascondiLotto
        '
        Me.btnNascondiLotto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNascondiLotto.Image = CType(resources.GetObject("btnNascondiLotto.Image"), System.Drawing.Image)
        Me.btnNascondiLotto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNascondiLotto.Location = New System.Drawing.Point(10, 100)
        Me.btnNascondiLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNascondiLotto.Name = "btnNascondiLotto"
        Me.btnNascondiLotto.Size = New System.Drawing.Size(100, 60)
        Me.btnNascondiLotto.TabIndex = 2
        Me.btnNascondiLotto.Text = "Nascondi"
        Me.btnNascondiLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNascondiLotto.UseVisualStyleBackColor = True
        '
        'btnSalvaModifiche
        '
        Me.btnSalvaModifiche.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvaModifiche.Image = CType(resources.GetObject("btnSalvaModifiche.Image"), System.Drawing.Image)
        Me.btnSalvaModifiche.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvaModifiche.Location = New System.Drawing.Point(10, 330)
        Me.btnSalvaModifiche.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalvaModifiche.Name = "btnSalvaModifiche"
        Me.btnSalvaModifiche.Size = New System.Drawing.Size(100, 80)
        Me.btnSalvaModifiche.TabIndex = 5
        Me.btnSalvaModifiche.Text = "Salva modifiche"
        Me.btnSalvaModifiche.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvaModifiche.UseVisualStyleBackColor = True
        '
        'btnAttivaLotto
        '
        Me.btnAttivaLotto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttivaLotto.Image = CType(resources.GetObject("btnAttivaLotto.Image"), System.Drawing.Image)
        Me.btnAttivaLotto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAttivaLotto.Location = New System.Drawing.Point(10, 30)
        Me.btnAttivaLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAttivaLotto.Name = "btnAttivaLotto"
        Me.btnAttivaLotto.Size = New System.Drawing.Size(100, 60)
        Me.btnAttivaLotto.TabIndex = 0
        Me.btnAttivaLotto.Text = "Attiva"
        Me.btnAttivaLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAttivaLotto.UseVisualStyleBackColor = True
        '
        'pdPrintDialog
        '
        Me.pdPrintDialog.UseEXDialog = True
        '
        'pdPrintDocument
        '
        '
        'btnUscita
        '
        Me.btnUscita.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUscita.Image = CType(resources.GetObject("btnUscita.Image"), System.Drawing.Image)
        Me.btnUscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUscita.Location = New System.Drawing.Point(904, 668)
        Me.btnUscita.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUscita.Name = "btnUscita"
        Me.btnUscita.Size = New System.Drawing.Size(100, 60)
        Me.btnUscita.TabIndex = 2
        Me.btnUscita.Text = "Uscita"
        Me.btnUscita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUscita.UseVisualStyleBackColor = True
        '
        'frmGestioneLotti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 740)
        Me.Controls.Add(Me.btnUscita)
        Me.Controls.Add(Me.gbParametriLotto)
        Me.Controls.Add(Me.gbGestioneLotti)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGestioneLotti"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione lotti"
        Me.gbGestioneLotti.ResumeLayout(False)
        Me.gbParametriLotto.ResumeLayout(False)
        Me.gbParametriLotto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbGestioneLotti As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancellaLotto As System.Windows.Forms.Button
    Friend WithEvents btnVisualizzaLotto As System.Windows.Forms.Button
    Friend WithEvents btnCreaLotto As System.Windows.Forms.Button
    Friend WithEvents btnRicercaLotto As System.Windows.Forms.Button
    Friend WithEvents gbParametriLotto As System.Windows.Forms.GroupBox
    Friend WithEvents btnNascondiLotto As System.Windows.Forms.Button
    Friend WithEvents btnSalvaModifiche As System.Windows.Forms.Button
    Friend WithEvents btnAttivaLotto As System.Windows.Forms.Button
    Friend WithEvents lbLotti As System.Windows.Forms.ListBox
    Friend WithEvents tbNote As System.Windows.Forms.TextBox
    Friend WithEvents labDescrNote As System.Windows.Forms.Label
    Friend WithEvents cbRicetta As System.Windows.Forms.ComboBox
    Friend WithEvents labDescrRicetta As System.Windows.Forms.Label
    Friend WithEvents labDataOraCreazione As System.Windows.Forms.Label
    Friend WithEvents labDescrDataOraCreazione As System.Windows.Forms.Label
    Friend WithEvents labDescrNumeroOrdine As System.Windows.Forms.Label
    Friend WithEvents tbNumeroOrdine As System.Windows.Forms.TextBox
    Friend WithEvents btnAnnullaModifiche As System.Windows.Forms.Button
    Friend WithEvents labLottoAttivo As System.Windows.Forms.Label
    Friend WithEvents labDescrLottoAttivo As System.Windows.Forms.Label
    Friend WithEvents btnModificaLotto As System.Windows.Forms.Button
    Friend WithEvents pdPrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents pdPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnUscita As System.Windows.Forms.Button
End Class

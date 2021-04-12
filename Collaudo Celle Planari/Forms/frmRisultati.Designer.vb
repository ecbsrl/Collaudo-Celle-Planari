<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRisultati
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRisultati))
        Me.gbGestioneLotti = New System.Windows.Forms.GroupBox()
        Me.lbLotti = New System.Windows.Forms.ListBox()
        Me.btnVisualizzaLotto = New System.Windows.Forms.Button()
        Me.btnRicercaLotto = New System.Windows.Forms.Button()
        Me.btnUscita = New System.Windows.Forms.Button()
        Me.tcLotto = New System.Windows.Forms.TabControl()
        Me.tpParametriLotto = New System.Windows.Forms.TabPage()
        Me.tbNote = New System.Windows.Forms.TextBox()
        Me.labNomeRicetta = New System.Windows.Forms.Label()
        Me.labNumeroOrdine = New System.Windows.Forms.Label()
        Me.labDataCreazione = New System.Windows.Forms.Label()
        Me.labDescrNote = New System.Windows.Forms.Label()
        Me.labDescrNomeRicetta = New System.Windows.Forms.Label()
        Me.labDescrNumeroOrdine = New System.Windows.Forms.Label()
        Me.labDescrDataCreazione = New System.Windows.Forms.Label()
        Me.tpAnalisiRisultatiLotto = New System.Windows.Forms.TabPage()
        Me.gbReport = New System.Windows.Forms.GroupBox()
        Me.chkIncludiValoriMisurati = New System.Windows.Forms.CheckBox()
        Me.btnReportCompleto = New System.Windows.Forms.Button()
        Me.btnReportScartiRipassati = New System.Windows.Forms.Button()
        Me.btnReportScartiNonRipassati = New System.Windows.Forms.Button()
        Me.btnReportBuoni = New System.Windows.Forms.Button()
        Me.gbContatori = New System.Windows.Forms.GroupBox()
        Me.labDescrPercentualeScarti = New System.Windows.Forms.Label()
        Me.labPercentualeScarti = New System.Windows.Forms.Label()
        Me.labPercentualeBuoni = New System.Windows.Forms.Label()
        Me.labDescrPercentualeBuoni = New System.Windows.Forms.Label()
        Me.labTotaleCollaudati = New System.Windows.Forms.Label()
        Me.labTotaleScarti = New System.Windows.Forms.Label()
        Me.labTotaleBuoni = New System.Windows.Forms.Label()
        Me.labDescrTotaleScarti = New System.Windows.Forms.Label()
        Me.labDescrTotaleBuoni = New System.Windows.Forms.Label()
        Me.labDescrTotaleCollaudati = New System.Windows.Forms.Label()
        Me.btnChiudiLotto = New System.Windows.Forms.Button()
        Me.gbGestioneLotti.SuspendLayout()
        Me.tcLotto.SuspendLayout()
        Me.tpParametriLotto.SuspendLayout()
        Me.tpAnalisiRisultatiLotto.SuspendLayout()
        Me.gbReport.SuspendLayout()
        Me.gbContatori.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbGestioneLotti
        '
        Me.gbGestioneLotti.Controls.Add(Me.lbLotti)
        Me.gbGestioneLotti.Controls.Add(Me.btnVisualizzaLotto)
        Me.gbGestioneLotti.Controls.Add(Me.btnRicercaLotto)
        Me.gbGestioneLotti.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGestioneLotti.Location = New System.Drawing.Point(14, 14)
        Me.gbGestioneLotti.Margin = New System.Windows.Forms.Padding(5)
        Me.gbGestioneLotti.Name = "gbGestioneLotti"
        Me.gbGestioneLotti.Padding = New System.Windows.Forms.Padding(5)
        Me.gbGestioneLotti.Size = New System.Drawing.Size(295, 716)
        Me.gbGestioneLotti.TabIndex = 0
        Me.gbGestioneLotti.TabStop = False
        Me.gbGestioneLotti.Text = "Gestione lotti"
        '
        'lbLotti
        '
        Me.lbLotti.FormattingEnabled = True
        Me.lbLotti.ItemHeight = 18
        Me.lbLotti.Location = New System.Drawing.Point(120, 29)
        Me.lbLotti.Margin = New System.Windows.Forms.Padding(5)
        Me.lbLotti.Name = "lbLotti"
        Me.lbLotti.Size = New System.Drawing.Size(161, 670)
        Me.lbLotti.TabIndex = 2
        '
        'btnVisualizzaLotto
        '
        Me.btnVisualizzaLotto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizzaLotto.Image = CType(resources.GetObject("btnVisualizzaLotto.Image"), System.Drawing.Image)
        Me.btnVisualizzaLotto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVisualizzaLotto.Location = New System.Drawing.Point(10, 99)
        Me.btnVisualizzaLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnVisualizzaLotto.Name = "btnVisualizzaLotto"
        Me.btnVisualizzaLotto.Size = New System.Drawing.Size(100, 60)
        Me.btnVisualizzaLotto.TabIndex = 1
        Me.btnVisualizzaLotto.Text = "Visualizza"
        Me.btnVisualizzaLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVisualizzaLotto.UseVisualStyleBackColor = True
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
        'btnUscita
        '
        Me.btnUscita.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUscita.Image = CType(resources.GetObject("btnUscita.Image"), System.Drawing.Image)
        Me.btnUscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUscita.Location = New System.Drawing.Point(904, 670)
        Me.btnUscita.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUscita.Name = "btnUscita"
        Me.btnUscita.Size = New System.Drawing.Size(100, 60)
        Me.btnUscita.TabIndex = 3
        Me.btnUscita.Text = "Uscita"
        Me.btnUscita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUscita.UseVisualStyleBackColor = True
        '
        'tcLotto
        '
        Me.tcLotto.Controls.Add(Me.tpParametriLotto)
        Me.tcLotto.Controls.Add(Me.tpAnalisiRisultatiLotto)
        Me.tcLotto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcLotto.Location = New System.Drawing.Point(319, 14)
        Me.tcLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.tcLotto.Name = "tcLotto"
        Me.tcLotto.SelectedIndex = 0
        Me.tcLotto.Size = New System.Drawing.Size(685, 646)
        Me.tcLotto.TabIndex = 1
        '
        'tpParametriLotto
        '
        Me.tpParametriLotto.BackColor = System.Drawing.SystemColors.Control
        Me.tpParametriLotto.Controls.Add(Me.tbNote)
        Me.tpParametriLotto.Controls.Add(Me.labNomeRicetta)
        Me.tpParametriLotto.Controls.Add(Me.labNumeroOrdine)
        Me.tpParametriLotto.Controls.Add(Me.labDataCreazione)
        Me.tpParametriLotto.Controls.Add(Me.labDescrNote)
        Me.tpParametriLotto.Controls.Add(Me.labDescrNomeRicetta)
        Me.tpParametriLotto.Controls.Add(Me.labDescrNumeroOrdine)
        Me.tpParametriLotto.Controls.Add(Me.labDescrDataCreazione)
        Me.tpParametriLotto.Location = New System.Drawing.Point(4, 27)
        Me.tpParametriLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.tpParametriLotto.Name = "tpParametriLotto"
        Me.tpParametriLotto.Padding = New System.Windows.Forms.Padding(5)
        Me.tpParametriLotto.Size = New System.Drawing.Size(677, 615)
        Me.tpParametriLotto.TabIndex = 0
        Me.tpParametriLotto.Text = "Parametri lotto"
        '
        'tbNote
        '
        Me.tbNote.BackColor = System.Drawing.Color.White
        Me.tbNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNote.Location = New System.Drawing.Point(170, 119)
        Me.tbNote.Margin = New System.Windows.Forms.Padding(5)
        Me.tbNote.Multiline = True
        Me.tbNote.Name = "tbNote"
        Me.tbNote.ReadOnly = True
        Me.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbNote.Size = New System.Drawing.Size(497, 200)
        Me.tbNote.TabIndex = 7
        '
        'labNomeRicetta
        '
        Me.labNomeRicetta.BackColor = System.Drawing.Color.White
        Me.labNomeRicetta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labNomeRicetta.Location = New System.Drawing.Point(170, 82)
        Me.labNomeRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.labNomeRicetta.Name = "labNomeRicetta"
        Me.labNomeRicetta.Size = New System.Drawing.Size(300, 26)
        Me.labNomeRicetta.TabIndex = 5
        Me.labNomeRicetta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labNumeroOrdine
        '
        Me.labNumeroOrdine.BackColor = System.Drawing.Color.White
        Me.labNumeroOrdine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labNumeroOrdine.Location = New System.Drawing.Point(170, 46)
        Me.labNumeroOrdine.Margin = New System.Windows.Forms.Padding(5)
        Me.labNumeroOrdine.Name = "labNumeroOrdine"
        Me.labNumeroOrdine.Size = New System.Drawing.Size(300, 26)
        Me.labNumeroOrdine.TabIndex = 3
        Me.labNumeroOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDataCreazione
        '
        Me.labDataCreazione.BackColor = System.Drawing.Color.White
        Me.labDataCreazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labDataCreazione.Location = New System.Drawing.Point(170, 10)
        Me.labDataCreazione.Margin = New System.Windows.Forms.Padding(5)
        Me.labDataCreazione.Name = "labDataCreazione"
        Me.labDataCreazione.Size = New System.Drawing.Size(300, 26)
        Me.labDataCreazione.TabIndex = 1
        Me.labDataCreazione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrNote
        '
        Me.labDescrNote.AutoSize = True
        Me.labDescrNote.Location = New System.Drawing.Point(10, 121)
        Me.labDescrNote.Name = "labDescrNote"
        Me.labDescrNote.Size = New System.Drawing.Size(41, 18)
        Me.labDescrNote.TabIndex = 6
        Me.labDescrNote.Text = "Note"
        '
        'labDescrNomeRicetta
        '
        Me.labDescrNomeRicetta.AutoSize = True
        Me.labDescrNomeRicetta.Location = New System.Drawing.Point(10, 86)
        Me.labDescrNomeRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrNomeRicetta.Name = "labDescrNomeRicetta"
        Me.labDescrNomeRicetta.Size = New System.Drawing.Size(134, 18)
        Me.labDescrNomeRicetta.TabIndex = 4
        Me.labDescrNomeRicetta.Text = "Nome della ricetta"
        '
        'labDescrNumeroOrdine
        '
        Me.labDescrNumeroOrdine.AutoSize = True
        Me.labDescrNumeroOrdine.Location = New System.Drawing.Point(10, 50)
        Me.labDescrNumeroOrdine.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrNumeroOrdine.Name = "labDescrNumeroOrdine"
        Me.labDescrNumeroOrdine.Size = New System.Drawing.Size(123, 18)
        Me.labDescrNumeroOrdine.TabIndex = 2
        Me.labDescrNumeroOrdine.Text = "Numero d'ordine"
        '
        'labDescrDataCreazione
        '
        Me.labDescrDataCreazione.AutoSize = True
        Me.labDescrDataCreazione.Location = New System.Drawing.Point(10, 14)
        Me.labDescrDataCreazione.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrDataCreazione.Name = "labDescrDataCreazione"
        Me.labDescrDataCreazione.Size = New System.Drawing.Size(131, 18)
        Me.labDescrDataCreazione.TabIndex = 0
        Me.labDescrDataCreazione.Text = "Data di creazione"
        '
        'tpAnalisiRisultatiLotto
        '
        Me.tpAnalisiRisultatiLotto.BackColor = System.Drawing.SystemColors.Control
        Me.tpAnalisiRisultatiLotto.Controls.Add(Me.gbReport)
        Me.tpAnalisiRisultatiLotto.Controls.Add(Me.gbContatori)
        Me.tpAnalisiRisultatiLotto.Location = New System.Drawing.Point(4, 27)
        Me.tpAnalisiRisultatiLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.tpAnalisiRisultatiLotto.Name = "tpAnalisiRisultatiLotto"
        Me.tpAnalisiRisultatiLotto.Padding = New System.Windows.Forms.Padding(5)
        Me.tpAnalisiRisultatiLotto.Size = New System.Drawing.Size(677, 615)
        Me.tpAnalisiRisultatiLotto.TabIndex = 1
        Me.tpAnalisiRisultatiLotto.Text = "Analisi risultati lotto"
        '
        'gbReport
        '
        Me.gbReport.Controls.Add(Me.chkIncludiValoriMisurati)
        Me.gbReport.Controls.Add(Me.btnReportCompleto)
        Me.gbReport.Controls.Add(Me.btnReportScartiRipassati)
        Me.gbReport.Controls.Add(Me.btnReportScartiNonRipassati)
        Me.gbReport.Controls.Add(Me.btnReportBuoni)
        Me.gbReport.Location = New System.Drawing.Point(10, 160)
        Me.gbReport.Margin = New System.Windows.Forms.Padding(5)
        Me.gbReport.Name = "gbReport"
        Me.gbReport.Padding = New System.Windows.Forms.Padding(5)
        Me.gbReport.Size = New System.Drawing.Size(657, 155)
        Me.gbReport.TabIndex = 1
        Me.gbReport.TabStop = False
        Me.gbReport.Text = "Parametri generazione report"
        '
        'chkIncludiValoriMisurati
        '
        Me.chkIncludiValoriMisurati.AutoSize = True
        Me.chkIncludiValoriMisurati.Checked = True
        Me.chkIncludiValoriMisurati.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludiValoriMisurati.Location = New System.Drawing.Point(10, 119)
        Me.chkIncludiValoriMisurati.Margin = New System.Windows.Forms.Padding(5)
        Me.chkIncludiValoriMisurati.Name = "chkIncludiValoriMisurati"
        Me.chkIncludiValoriMisurati.Size = New System.Drawing.Size(170, 22)
        Me.chkIncludiValoriMisurati.TabIndex = 4
        Me.chkIncludiValoriMisurati.Text = "Includi valori misurati"
        Me.chkIncludiValoriMisurati.UseVisualStyleBackColor = True
        '
        'btnReportCompleto
        '
        Me.btnReportCompleto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportCompleto.Image = CType(resources.GetObject("btnReportCompleto.Image"), System.Drawing.Image)
        Me.btnReportCompleto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReportCompleto.Location = New System.Drawing.Point(340, 29)
        Me.btnReportCompleto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReportCompleto.Name = "btnReportCompleto"
        Me.btnReportCompleto.Size = New System.Drawing.Size(100, 80)
        Me.btnReportCompleto.TabIndex = 3
        Me.btnReportCompleto.Text = "Report completo"
        Me.btnReportCompleto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReportCompleto.UseVisualStyleBackColor = True
        '
        'btnReportScartiRipassati
        '
        Me.btnReportScartiRipassati.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportScartiRipassati.Image = CType(resources.GetObject("btnReportScartiRipassati.Image"), System.Drawing.Image)
        Me.btnReportScartiRipassati.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReportScartiRipassati.Location = New System.Drawing.Point(230, 29)
        Me.btnReportScartiRipassati.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReportScartiRipassati.Name = "btnReportScartiRipassati"
        Me.btnReportScartiRipassati.Size = New System.Drawing.Size(100, 80)
        Me.btnReportScartiRipassati.TabIndex = 2
        Me.btnReportScartiRipassati.Text = "Report scarti ripassati"
        Me.btnReportScartiRipassati.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReportScartiRipassati.UseVisualStyleBackColor = True
        '
        'btnReportScartiNonRipassati
        '
        Me.btnReportScartiNonRipassati.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportScartiNonRipassati.Image = CType(resources.GetObject("btnReportScartiNonRipassati.Image"), System.Drawing.Image)
        Me.btnReportScartiNonRipassati.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReportScartiNonRipassati.Location = New System.Drawing.Point(120, 29)
        Me.btnReportScartiNonRipassati.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReportScartiNonRipassati.Name = "btnReportScartiNonRipassati"
        Me.btnReportScartiNonRipassati.Size = New System.Drawing.Size(100, 80)
        Me.btnReportScartiNonRipassati.TabIndex = 1
        Me.btnReportScartiNonRipassati.Text = "Report scarti non ripassati"
        Me.btnReportScartiNonRipassati.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReportScartiNonRipassati.UseVisualStyleBackColor = True
        '
        'btnReportBuoni
        '
        Me.btnReportBuoni.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportBuoni.Image = CType(resources.GetObject("btnReportBuoni.Image"), System.Drawing.Image)
        Me.btnReportBuoni.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReportBuoni.Location = New System.Drawing.Point(10, 29)
        Me.btnReportBuoni.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReportBuoni.Name = "btnReportBuoni"
        Me.btnReportBuoni.Size = New System.Drawing.Size(100, 80)
        Me.btnReportBuoni.TabIndex = 0
        Me.btnReportBuoni.Text = "Report buoni"
        Me.btnReportBuoni.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReportBuoni.UseVisualStyleBackColor = True
        '
        'gbContatori
        '
        Me.gbContatori.Controls.Add(Me.labDescrPercentualeScarti)
        Me.gbContatori.Controls.Add(Me.labPercentualeScarti)
        Me.gbContatori.Controls.Add(Me.labPercentualeBuoni)
        Me.gbContatori.Controls.Add(Me.labDescrPercentualeBuoni)
        Me.gbContatori.Controls.Add(Me.labTotaleCollaudati)
        Me.gbContatori.Controls.Add(Me.labTotaleScarti)
        Me.gbContatori.Controls.Add(Me.labTotaleBuoni)
        Me.gbContatori.Controls.Add(Me.labDescrTotaleScarti)
        Me.gbContatori.Controls.Add(Me.labDescrTotaleBuoni)
        Me.gbContatori.Controls.Add(Me.labDescrTotaleCollaudati)
        Me.gbContatori.Location = New System.Drawing.Point(10, 10)
        Me.gbContatori.Margin = New System.Windows.Forms.Padding(5)
        Me.gbContatori.Name = "gbContatori"
        Me.gbContatori.Padding = New System.Windows.Forms.Padding(5)
        Me.gbContatori.Size = New System.Drawing.Size(657, 140)
        Me.gbContatori.TabIndex = 0
        Me.gbContatori.TabStop = False
        Me.gbContatori.Text = "Contatori"
        '
        'labDescrPercentualeScarti
        '
        Me.labDescrPercentualeScarti.AutoSize = True
        Me.labDescrPercentualeScarti.Location = New System.Drawing.Point(400, 105)
        Me.labDescrPercentualeScarti.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrPercentualeScarti.Name = "labDescrPercentualeScarti"
        Me.labDescrPercentualeScarti.Size = New System.Drawing.Size(132, 18)
        Me.labDescrPercentualeScarti.TabIndex = 8
        Me.labDescrPercentualeScarti.Text = "% pezzi SCARTO"
        '
        'labPercentualeScarti
        '
        Me.labPercentualeScarti.BackColor = System.Drawing.Color.White
        Me.labPercentualeScarti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labPercentualeScarti.Location = New System.Drawing.Point(547, 101)
        Me.labPercentualeScarti.Margin = New System.Windows.Forms.Padding(5)
        Me.labPercentualeScarti.Name = "labPercentualeScarti"
        Me.labPercentualeScarti.Size = New System.Drawing.Size(100, 26)
        Me.labPercentualeScarti.TabIndex = 9
        Me.labPercentualeScarti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPercentualeBuoni
        '
        Me.labPercentualeBuoni.BackColor = System.Drawing.Color.White
        Me.labPercentualeBuoni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labPercentualeBuoni.Location = New System.Drawing.Point(547, 65)
        Me.labPercentualeBuoni.Margin = New System.Windows.Forms.Padding(5)
        Me.labPercentualeBuoni.Name = "labPercentualeBuoni"
        Me.labPercentualeBuoni.Size = New System.Drawing.Size(100, 26)
        Me.labPercentualeBuoni.TabIndex = 5
        Me.labPercentualeBuoni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrPercentualeBuoni
        '
        Me.labDescrPercentualeBuoni.AutoSize = True
        Me.labDescrPercentualeBuoni.Location = New System.Drawing.Point(400, 69)
        Me.labDescrPercentualeBuoni.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrPercentualeBuoni.Name = "labDescrPercentualeBuoni"
        Me.labDescrPercentualeBuoni.Size = New System.Drawing.Size(114, 18)
        Me.labDescrPercentualeBuoni.TabIndex = 4
        Me.labDescrPercentualeBuoni.Text = "% pezzi BUONI"
        '
        'labTotaleCollaudati
        '
        Me.labTotaleCollaudati.BackColor = System.Drawing.Color.White
        Me.labTotaleCollaudati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labTotaleCollaudati.Location = New System.Drawing.Point(220, 29)
        Me.labTotaleCollaudati.Margin = New System.Windows.Forms.Padding(5)
        Me.labTotaleCollaudati.Name = "labTotaleCollaudati"
        Me.labTotaleCollaudati.Size = New System.Drawing.Size(100, 26)
        Me.labTotaleCollaudati.TabIndex = 1
        Me.labTotaleCollaudati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labTotaleScarti
        '
        Me.labTotaleScarti.BackColor = System.Drawing.Color.White
        Me.labTotaleScarti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labTotaleScarti.Location = New System.Drawing.Point(220, 101)
        Me.labTotaleScarti.Margin = New System.Windows.Forms.Padding(5)
        Me.labTotaleScarti.Name = "labTotaleScarti"
        Me.labTotaleScarti.Size = New System.Drawing.Size(100, 26)
        Me.labTotaleScarti.TabIndex = 7
        Me.labTotaleScarti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labTotaleBuoni
        '
        Me.labTotaleBuoni.BackColor = System.Drawing.Color.White
        Me.labTotaleBuoni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labTotaleBuoni.Location = New System.Drawing.Point(220, 65)
        Me.labTotaleBuoni.Margin = New System.Windows.Forms.Padding(5)
        Me.labTotaleBuoni.Name = "labTotaleBuoni"
        Me.labTotaleBuoni.Size = New System.Drawing.Size(100, 26)
        Me.labTotaleBuoni.TabIndex = 3
        Me.labTotaleBuoni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrTotaleScarti
        '
        Me.labDescrTotaleScarti.AutoSize = True
        Me.labDescrTotaleScarti.Location = New System.Drawing.Point(10, 105)
        Me.labDescrTotaleScarti.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrTotaleScarti.Name = "labDescrTotaleScarti"
        Me.labDescrTotaleScarti.Size = New System.Drawing.Size(159, 18)
        Me.labDescrTotaleScarti.TabIndex = 6
        Me.labDescrTotaleScarti.Text = "Totale pezzi SCARTO"
        '
        'labDescrTotaleBuoni
        '
        Me.labDescrTotaleBuoni.AutoSize = True
        Me.labDescrTotaleBuoni.Location = New System.Drawing.Point(10, 69)
        Me.labDescrTotaleBuoni.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrTotaleBuoni.Name = "labDescrTotaleBuoni"
        Me.labDescrTotaleBuoni.Size = New System.Drawing.Size(141, 18)
        Me.labDescrTotaleBuoni.TabIndex = 2
        Me.labDescrTotaleBuoni.Text = "Totale pezzi BUONI"
        '
        'labDescrTotaleCollaudati
        '
        Me.labDescrTotaleCollaudati.AutoSize = True
        Me.labDescrTotaleCollaudati.Location = New System.Drawing.Point(10, 33)
        Me.labDescrTotaleCollaudati.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrTotaleCollaudati.Name = "labDescrTotaleCollaudati"
        Me.labDescrTotaleCollaudati.Size = New System.Drawing.Size(191, 18)
        Me.labDescrTotaleCollaudati.TabIndex = 0
        Me.labDescrTotaleCollaudati.Text = "Totale pezzi COLLAUDATI"
        '
        'btnChiudiLotto
        '
        Me.btnChiudiLotto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChiudiLotto.Image = CType(resources.GetObject("btnChiudiLotto.Image"), System.Drawing.Image)
        Me.btnChiudiLotto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChiudiLotto.Location = New System.Drawing.Point(319, 666)
        Me.btnChiudiLotto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnChiudiLotto.Name = "btnChiudiLotto"
        Me.btnChiudiLotto.Size = New System.Drawing.Size(100, 60)
        Me.btnChiudiLotto.TabIndex = 2
        Me.btnChiudiLotto.Text = "Chiudi lotto"
        Me.btnChiudiLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnChiudiLotto.UseVisualStyleBackColor = True
        '
        'frmRisultati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 740)
        Me.Controls.Add(Me.btnChiudiLotto)
        Me.Controls.Add(Me.tcLotto)
        Me.Controls.Add(Me.btnUscita)
        Me.Controls.Add(Me.gbGestioneLotti)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRisultati"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Risultati"
        Me.gbGestioneLotti.ResumeLayout(False)
        Me.tcLotto.ResumeLayout(False)
        Me.tpParametriLotto.ResumeLayout(False)
        Me.tpParametriLotto.PerformLayout()
        Me.tpAnalisiRisultatiLotto.ResumeLayout(False)
        Me.gbReport.ResumeLayout(False)
        Me.gbReport.PerformLayout()
        Me.gbContatori.ResumeLayout(False)
        Me.gbContatori.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbGestioneLotti As System.Windows.Forms.GroupBox
    Friend WithEvents lbLotti As System.Windows.Forms.ListBox
    Friend WithEvents btnVisualizzaLotto As System.Windows.Forms.Button
    Friend WithEvents btnRicercaLotto As System.Windows.Forms.Button
    Friend WithEvents btnUscita As System.Windows.Forms.Button
    Friend WithEvents tcLotto As System.Windows.Forms.TabControl
    Friend WithEvents tpParametriLotto As System.Windows.Forms.TabPage
    Friend WithEvents labDataCreazione As System.Windows.Forms.Label
    Friend WithEvents labDescrNote As System.Windows.Forms.Label
    Friend WithEvents labDescrNomeRicetta As System.Windows.Forms.Label
    Friend WithEvents labDescrNumeroOrdine As System.Windows.Forms.Label
    Friend WithEvents labDescrDataCreazione As System.Windows.Forms.Label
    Friend WithEvents tpAnalisiRisultatiLotto As System.Windows.Forms.TabPage
    Friend WithEvents tbNote As System.Windows.Forms.TextBox
    Friend WithEvents labNomeRicetta As System.Windows.Forms.Label
    Friend WithEvents labNumeroOrdine As System.Windows.Forms.Label
    Friend WithEvents gbReport As System.Windows.Forms.GroupBox
    Friend WithEvents gbContatori As System.Windows.Forms.GroupBox
    Friend WithEvents labDescrPercentualeScarti As System.Windows.Forms.Label
    Friend WithEvents labPercentualeScarti As System.Windows.Forms.Label
    Friend WithEvents labPercentualeBuoni As System.Windows.Forms.Label
    Friend WithEvents labDescrPercentualeBuoni As System.Windows.Forms.Label
    Friend WithEvents labTotaleCollaudati As System.Windows.Forms.Label
    Friend WithEvents labTotaleScarti As System.Windows.Forms.Label
    Friend WithEvents labTotaleBuoni As System.Windows.Forms.Label
    Friend WithEvents labDescrTotaleScarti As System.Windows.Forms.Label
    Friend WithEvents labDescrTotaleBuoni As System.Windows.Forms.Label
    Friend WithEvents labDescrTotaleCollaudati As System.Windows.Forms.Label
    Friend WithEvents btnReportCompleto As System.Windows.Forms.Button
    Friend WithEvents btnReportScartiRipassati As System.Windows.Forms.Button
    Friend WithEvents btnReportScartiNonRipassati As System.Windows.Forms.Button
    Friend WithEvents btnReportBuoni As System.Windows.Forms.Button
    Friend WithEvents btnChiudiLotto As System.Windows.Forms.Button
    Friend WithEvents chkIncludiValoriMisurati As System.Windows.Forms.CheckBox
End Class

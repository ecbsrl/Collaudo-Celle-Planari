<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestioneRicette
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestioneRicette))
        Me.gbGestioneRicette = New System.Windows.Forms.GroupBox()
        Me.lbListaRicette = New System.Windows.Forms.ListBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnVisualizzaRicetta = New System.Windows.Forms.Button()
        Me.btnCancella = New System.Windows.Forms.Button()
        Me.btnCopiaRicetta = New System.Windows.Forms.Button()
        Me.btnNuovaRicetta = New System.Windows.Forms.Button()
        Me.btnRicerca = New System.Windows.Forms.Button()
        Me.tcParametriRicetta = New System.Windows.Forms.TabControl()
        Me.tpParametriRicetta1 = New System.Windows.Forms.TabPage()
        Me.gbParametriGenerali = New System.Windows.Forms.GroupBox()
        Me.cbTipologia = New System.Windows.Forms.ComboBox()
        Me.cbNomeRicettaMaster = New System.Windows.Forms.ComboBox()
        Me.labCodiceAttrezzatura = New System.Windows.Forms.Label()
        Me.labDescrCodiceAttrezzatura = New System.Windows.Forms.Label()
        Me.labDescrTipologia = New System.Windows.Forms.Label()
        Me.labDescrRicettaMaster = New System.Windows.Forms.Label()
        Me.labIndiceRevisione = New System.Windows.Forms.Label()
        Me.labDescrIndiceRevisione = New System.Windows.Forms.Label()
        Me.labDataOraModifica = New System.Windows.Forms.Label()
        Me.labDescrDataOraModifica = New System.Windows.Forms.Label()
        Me.labDataOraCreazione = New System.Windows.Forms.Label()
        Me.labDescrDataOraCreazione = New System.Windows.Forms.Label()
        Me.tpParametriRicetta2 = New System.Windows.Forms.TabPage()
        Me.gbRiscaldamentoRaffreddamento = New System.Windows.Forms.GroupBox()
        Me.labUDMTempoRiscaldamento = New System.Windows.Forms.Label()
        Me.labTempoRiscaldamento = New System.Windows.Forms.Label()
        Me.labDescrTempoRiscaldamento = New System.Windows.Forms.Label()
        Me.labDescrTempoRaffreddamento = New System.Windows.Forms.Label()
        Me.labTempoRaffreddamento = New System.Windows.Forms.Label()
        Me.labUDMTempoRaffreddamento = New System.Windows.Forms.Label()
        Me.gbIheater = New System.Windows.Forms.GroupBox()
        Me.labCorrenteRiscaldatoreMax = New System.Windows.Forms.Label()
        Me.chkCorrenteRiscaldatore = New System.Windows.Forms.CheckBox()
        Me.labUDMCorrenteRiscaldatore = New System.Windows.Forms.Label()
        Me.labCorrenteRiscaldatoreMin = New System.Windows.Forms.Label()
        Me.gbIsolamento = New System.Windows.Forms.GroupBox()
        Me.chkResistenzaIsolamento = New System.Windows.Forms.CheckBox()
        Me.labUDMResistenzaIsolamento = New System.Windows.Forms.Label()
        Me.labResistenzaIsolamentoMin = New System.Windows.Forms.Label()
        Me.gbRheater = New System.Windows.Forms.GroupBox()
        Me.chkRheater = New System.Windows.Forms.CheckBox()
        Me.labRheaterMax = New System.Windows.Forms.Label()
        Me.labUDMRheater = New System.Windows.Forms.Label()
        Me.labRheaterMin = New System.Windows.Forms.Label()
        Me.gbVal = New System.Windows.Forms.GroupBox()
        Me.labDescrVal = New System.Windows.Forms.Label()
        Me.labValMin = New System.Windows.Forms.Label()
        Me.labValMax = New System.Windows.Forms.Label()
        Me.labUDMVal = New System.Windows.Forms.Label()
        Me.tpParametriRicetta3 = New System.Windows.Forms.TabPage()
        Me.gbMisureLSU = New System.Windows.Forms.GroupBox()
        Me.labResistenzaCalibrazioneMin = New System.Windows.Forms.Label()
        Me.labTempOperativaMax = New System.Windows.Forms.Label()
        Me.labUdmTargetO2 = New System.Windows.Forms.Label()
        Me.labTargetO2 = New System.Windows.Forms.Label()
        Me.labDescrTargetO2 = New System.Windows.Forms.Label()
        Me.labDescrFlussoN2 = New System.Windows.Forms.Label()
        Me.chkResistenzaCalibrazione = New System.Windows.Forms.CheckBox()
        Me.labUDMResistenzaCalibrazione = New System.Windows.Forms.Label()
        Me.labResistenzaCalibrazioneMax = New System.Windows.Forms.Label()
        Me.chkO2 = New System.Windows.Forms.CheckBox()
        Me.labUDMTempOperativa = New System.Windows.Forms.Label()
        Me.labTempOperativaMin = New System.Windows.Forms.Label()
        Me.chkTemperaturaOperativa = New System.Windows.Forms.CheckBox()
        Me.labO2Max = New System.Windows.Forms.Label()
        Me.labUDMO2 = New System.Windows.Forms.Label()
        Me.labO2Min = New System.Windows.Forms.Label()
        Me.labUDMFlussoN2 = New System.Windows.Forms.Label()
        Me.labFlussoN2 = New System.Windows.Forms.Label()
        Me.labUDMFlussoAria = New System.Windows.Forms.Label()
        Me.labFlussoAria = New System.Windows.Forms.Label()
        Me.labDescrFlussoAria = New System.Windows.Forms.Label()
        Me.gbMisureZFAS = New System.Windows.Forms.GroupBox()
        Me.chkZfasIpTb = New System.Windows.Forms.CheckBox()
        Me.labUdmZfasIpTb = New System.Windows.Forms.Label()
        Me.chkZfasIpEtas = New System.Windows.Forms.CheckBox()
        Me.labZfasIpTbMin = New System.Windows.Forms.Label()
        Me.labUdmZfasIpEtas = New System.Windows.Forms.Label()
        Me.labZfasIpTbMax = New System.Windows.Forms.Label()
        Me.labZfasIpEtasMin = New System.Windows.Forms.Label()
        Me.labZfasIpEtasMax = New System.Windows.Forms.Label()
        Me.gbMisureADV = New System.Windows.Forms.GroupBox()
        Me.chkAdvLambda = New System.Windows.Forms.CheckBox()
        Me.labUdmAdvLambda = New System.Windows.Forms.Label()
        Me.chkAdvIp = New System.Windows.Forms.CheckBox()
        Me.labAdvLambdaMin = New System.Windows.Forms.Label()
        Me.labUdmAdvIp = New System.Windows.Forms.Label()
        Me.labAdvLambdaMax = New System.Windows.Forms.Label()
        Me.labAdvIpMin = New System.Windows.Forms.Label()
        Me.labAdvIpMax = New System.Windows.Forms.Label()
        Me.btnSalvaRicetta = New System.Windows.Forms.Button()
        Me.btnChiudiRicetta = New System.Windows.Forms.Button()
        Me.btnCaricaRicetta = New System.Windows.Forms.Button()
        Me.btnModificaRicetta = New System.Windows.Forms.Button()
        Me.pdPrintDialog = New System.Windows.Forms.PrintDialog()
        Me.pdPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.btnUscita = New System.Windows.Forms.Button()
        Me.gbGestioneRicette.SuspendLayout()
        Me.tcParametriRicetta.SuspendLayout()
        Me.tpParametriRicetta1.SuspendLayout()
        Me.gbParametriGenerali.SuspendLayout()
        Me.tpParametriRicetta2.SuspendLayout()
        Me.gbRiscaldamentoRaffreddamento.SuspendLayout()
        Me.gbIheater.SuspendLayout()
        Me.gbIsolamento.SuspendLayout()
        Me.gbRheater.SuspendLayout()
        Me.gbVal.SuspendLayout()
        Me.tpParametriRicetta3.SuspendLayout()
        Me.gbMisureLSU.SuspendLayout()
        Me.gbMisureZFAS.SuspendLayout()
        Me.gbMisureADV.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbGestioneRicette
        '
        Me.gbGestioneRicette.Controls.Add(Me.lbListaRicette)
        Me.gbGestioneRicette.Controls.Add(Me.btnReport)
        Me.gbGestioneRicette.Controls.Add(Me.btnVisualizzaRicetta)
        Me.gbGestioneRicette.Controls.Add(Me.btnCancella)
        Me.gbGestioneRicette.Controls.Add(Me.btnCopiaRicetta)
        Me.gbGestioneRicette.Controls.Add(Me.btnNuovaRicetta)
        Me.gbGestioneRicette.Controls.Add(Me.btnRicerca)
        Me.gbGestioneRicette.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGestioneRicette.Location = New System.Drawing.Point(10, 10)
        Me.gbGestioneRicette.Margin = New System.Windows.Forms.Padding(5)
        Me.gbGestioneRicette.Name = "gbGestioneRicette"
        Me.gbGestioneRicette.Padding = New System.Windows.Forms.Padding(5)
        Me.gbGestioneRicette.Size = New System.Drawing.Size(301, 570)
        Me.gbGestioneRicette.TabIndex = 0
        Me.gbGestioneRicette.TabStop = False
        Me.gbGestioneRicette.Text = "Gestione ricette"
        '
        'lbListaRicette
        '
        Me.lbListaRicette.FormattingEnabled = True
        Me.lbListaRicette.ItemHeight = 18
        Me.lbListaRicette.Location = New System.Drawing.Point(124, 29)
        Me.lbListaRicette.Margin = New System.Windows.Forms.Padding(5)
        Me.lbListaRicette.Name = "lbListaRicette"
        Me.lbListaRicette.Size = New System.Drawing.Size(158, 526)
        Me.lbListaRicette.TabIndex = 6
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReport.Location = New System.Drawing.Point(10, 379)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(100, 60)
        Me.btnReport.TabIndex = 5
        Me.btnReport.Text = "Report"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnVisualizzaRicetta
        '
        Me.btnVisualizzaRicetta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizzaRicetta.Image = CType(resources.GetObject("btnVisualizzaRicetta.Image"), System.Drawing.Image)
        Me.btnVisualizzaRicetta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVisualizzaRicetta.Location = New System.Drawing.Point(10, 309)
        Me.btnVisualizzaRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnVisualizzaRicetta.Name = "btnVisualizzaRicetta"
        Me.btnVisualizzaRicetta.Size = New System.Drawing.Size(100, 60)
        Me.btnVisualizzaRicetta.TabIndex = 4
        Me.btnVisualizzaRicetta.Text = "Visualizza"
        Me.btnVisualizzaRicetta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVisualizzaRicetta.UseVisualStyleBackColor = True
        '
        'btnCancella
        '
        Me.btnCancella.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancella.Image = CType(resources.GetObject("btnCancella.Image"), System.Drawing.Image)
        Me.btnCancella.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancella.Location = New System.Drawing.Point(10, 239)
        Me.btnCancella.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancella.Name = "btnCancella"
        Me.btnCancella.Size = New System.Drawing.Size(100, 60)
        Me.btnCancella.TabIndex = 3
        Me.btnCancella.Text = "Cancella"
        Me.btnCancella.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancella.UseVisualStyleBackColor = True
        '
        'btnCopiaRicetta
        '
        Me.btnCopiaRicetta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopiaRicetta.Image = CType(resources.GetObject("btnCopiaRicetta.Image"), System.Drawing.Image)
        Me.btnCopiaRicetta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCopiaRicetta.Location = New System.Drawing.Point(10, 169)
        Me.btnCopiaRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCopiaRicetta.Name = "btnCopiaRicetta"
        Me.btnCopiaRicetta.Size = New System.Drawing.Size(100, 60)
        Me.btnCopiaRicetta.TabIndex = 2
        Me.btnCopiaRicetta.Text = "Copia"
        Me.btnCopiaRicetta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCopiaRicetta.UseVisualStyleBackColor = True
        '
        'btnNuovaRicetta
        '
        Me.btnNuovaRicetta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuovaRicetta.Image = CType(resources.GetObject("btnNuovaRicetta.Image"), System.Drawing.Image)
        Me.btnNuovaRicetta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuovaRicetta.Location = New System.Drawing.Point(10, 99)
        Me.btnNuovaRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNuovaRicetta.Name = "btnNuovaRicetta"
        Me.btnNuovaRicetta.Size = New System.Drawing.Size(100, 60)
        Me.btnNuovaRicetta.TabIndex = 1
        Me.btnNuovaRicetta.Text = "Nuova"
        Me.btnNuovaRicetta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuovaRicetta.UseVisualStyleBackColor = True
        '
        'btnRicerca
        '
        Me.btnRicerca.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRicerca.Image = CType(resources.GetObject("btnRicerca.Image"), System.Drawing.Image)
        Me.btnRicerca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRicerca.Location = New System.Drawing.Point(10, 29)
        Me.btnRicerca.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRicerca.Name = "btnRicerca"
        Me.btnRicerca.Size = New System.Drawing.Size(100, 60)
        Me.btnRicerca.TabIndex = 0
        Me.btnRicerca.Text = "Ricerca"
        Me.btnRicerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRicerca.UseVisualStyleBackColor = True
        '
        'tcParametriRicetta
        '
        Me.tcParametriRicetta.Controls.Add(Me.tpParametriRicetta1)
        Me.tcParametriRicetta.Controls.Add(Me.tpParametriRicetta2)
        Me.tcParametriRicetta.Controls.Add(Me.tpParametriRicetta3)
        Me.tcParametriRicetta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcParametriRicetta.Location = New System.Drawing.Point(430, 10)
        Me.tcParametriRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.tcParametriRicetta.Name = "tcParametriRicetta"
        Me.tcParametriRicetta.SelectedIndex = 0
        Me.tcParametriRicetta.Size = New System.Drawing.Size(540, 570)
        Me.tcParametriRicetta.TabIndex = 5
        Me.tcParametriRicetta.Visible = False
        '
        'tpParametriRicetta1
        '
        Me.tpParametriRicetta1.BackColor = System.Drawing.SystemColors.Control
        Me.tpParametriRicetta1.Controls.Add(Me.gbParametriGenerali)
        Me.tpParametriRicetta1.Location = New System.Drawing.Point(4, 27)
        Me.tpParametriRicetta1.Margin = New System.Windows.Forms.Padding(5)
        Me.tpParametriRicetta1.Name = "tpParametriRicetta1"
        Me.tpParametriRicetta1.Padding = New System.Windows.Forms.Padding(5)
        Me.tpParametriRicetta1.Size = New System.Drawing.Size(532, 539)
        Me.tpParametriRicetta1.TabIndex = 0
        Me.tpParametriRicetta1.Text = "Parametri generali"
        '
        'gbParametriGenerali
        '
        Me.gbParametriGenerali.Controls.Add(Me.cbTipologia)
        Me.gbParametriGenerali.Controls.Add(Me.cbNomeRicettaMaster)
        Me.gbParametriGenerali.Controls.Add(Me.labCodiceAttrezzatura)
        Me.gbParametriGenerali.Controls.Add(Me.labDescrCodiceAttrezzatura)
        Me.gbParametriGenerali.Controls.Add(Me.labDescrTipologia)
        Me.gbParametriGenerali.Controls.Add(Me.labDescrRicettaMaster)
        Me.gbParametriGenerali.Controls.Add(Me.labIndiceRevisione)
        Me.gbParametriGenerali.Controls.Add(Me.labDescrIndiceRevisione)
        Me.gbParametriGenerali.Controls.Add(Me.labDataOraModifica)
        Me.gbParametriGenerali.Controls.Add(Me.labDescrDataOraModifica)
        Me.gbParametriGenerali.Controls.Add(Me.labDataOraCreazione)
        Me.gbParametriGenerali.Controls.Add(Me.labDescrDataOraCreazione)
        Me.gbParametriGenerali.Location = New System.Drawing.Point(8, 8)
        Me.gbParametriGenerali.Name = "gbParametriGenerali"
        Me.gbParametriGenerali.Size = New System.Drawing.Size(515, 265)
        Me.gbParametriGenerali.TabIndex = 0
        Me.gbParametriGenerali.TabStop = False
        Me.gbParametriGenerali.Text = "Parametri generali"
        '
        'cbTipologia
        '
        Me.cbTipologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipologia.FormattingEnabled = True
        Me.cbTipologia.Items.AddRange(New Object() {"LSU 4.9", "ADV", "ZFAS-U2"})
        Me.cbTipologia.Location = New System.Drawing.Point(250, 145)
        Me.cbTipologia.Name = "cbTipologia"
        Me.cbTipologia.Size = New System.Drawing.Size(250, 26)
        Me.cbTipologia.TabIndex = 7
        '
        'cbNomeRicettaMaster
        '
        Me.cbNomeRicettaMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNomeRicettaMaster.FormattingEnabled = True
        Me.cbNomeRicettaMaster.Location = New System.Drawing.Point(250, 185)
        Me.cbNomeRicettaMaster.Name = "cbNomeRicettaMaster"
        Me.cbNomeRicettaMaster.Size = New System.Drawing.Size(250, 26)
        Me.cbNomeRicettaMaster.TabIndex = 9
        '
        'labCodiceAttrezzatura
        '
        Me.labCodiceAttrezzatura.BackColor = System.Drawing.Color.White
        Me.labCodiceAttrezzatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labCodiceAttrezzatura.Location = New System.Drawing.Point(250, 225)
        Me.labCodiceAttrezzatura.Margin = New System.Windows.Forms.Padding(5)
        Me.labCodiceAttrezzatura.Name = "labCodiceAttrezzatura"
        Me.labCodiceAttrezzatura.Size = New System.Drawing.Size(250, 26)
        Me.labCodiceAttrezzatura.TabIndex = 11
        Me.labCodiceAttrezzatura.Text = "???"
        Me.labCodiceAttrezzatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrCodiceAttrezzatura
        '
        Me.labDescrCodiceAttrezzatura.AutoSize = True
        Me.labDescrCodiceAttrezzatura.Location = New System.Drawing.Point(10, 230)
        Me.labDescrCodiceAttrezzatura.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrCodiceAttrezzatura.Name = "labDescrCodiceAttrezzatura"
        Me.labDescrCodiceAttrezzatura.Size = New System.Drawing.Size(143, 18)
        Me.labDescrCodiceAttrezzatura.TabIndex = 10
        Me.labDescrCodiceAttrezzatura.Text = "Codice attrezzatura"
        Me.labDescrCodiceAttrezzatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDescrTipologia
        '
        Me.labDescrTipologia.AutoSize = True
        Me.labDescrTipologia.Location = New System.Drawing.Point(10, 150)
        Me.labDescrTipologia.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrTipologia.Name = "labDescrTipologia"
        Me.labDescrTipologia.Size = New System.Drawing.Size(112, 18)
        Me.labDescrTipologia.TabIndex = 6
        Me.labDescrTipologia.Text = "Tipologia Cella"
        Me.labDescrTipologia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDescrRicettaMaster
        '
        Me.labDescrRicettaMaster.AutoSize = True
        Me.labDescrRicettaMaster.Location = New System.Drawing.Point(10, 190)
        Me.labDescrRicettaMaster.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrRicettaMaster.Name = "labDescrRicettaMaster"
        Me.labDescrRicettaMaster.Size = New System.Drawing.Size(212, 18)
        Me.labDescrRicettaMaster.TabIndex = 8
        Me.labDescrRicettaMaster.Text = "Nome ricetta per ciclo master"
        Me.labDescrRicettaMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labIndiceRevisione
        '
        Me.labIndiceRevisione.BackColor = System.Drawing.Color.White
        Me.labIndiceRevisione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labIndiceRevisione.Location = New System.Drawing.Point(250, 105)
        Me.labIndiceRevisione.Margin = New System.Windows.Forms.Padding(5)
        Me.labIndiceRevisione.Name = "labIndiceRevisione"
        Me.labIndiceRevisione.Size = New System.Drawing.Size(250, 26)
        Me.labIndiceRevisione.TabIndex = 5
        Me.labIndiceRevisione.Text = "???"
        Me.labIndiceRevisione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrIndiceRevisione
        '
        Me.labDescrIndiceRevisione.AutoSize = True
        Me.labDescrIndiceRevisione.Location = New System.Drawing.Point(10, 110)
        Me.labDescrIndiceRevisione.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrIndiceRevisione.Name = "labDescrIndiceRevisione"
        Me.labDescrIndiceRevisione.Size = New System.Drawing.Size(133, 18)
        Me.labDescrIndiceRevisione.TabIndex = 4
        Me.labDescrIndiceRevisione.Text = "Indice di revisione"
        Me.labDescrIndiceRevisione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDataOraModifica
        '
        Me.labDataOraModifica.BackColor = System.Drawing.Color.White
        Me.labDataOraModifica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labDataOraModifica.Location = New System.Drawing.Point(250, 65)
        Me.labDataOraModifica.Margin = New System.Windows.Forms.Padding(5)
        Me.labDataOraModifica.Name = "labDataOraModifica"
        Me.labDataOraModifica.Size = New System.Drawing.Size(250, 26)
        Me.labDataOraModifica.TabIndex = 3
        Me.labDataOraModifica.Text = "???"
        Me.labDataOraModifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrDataOraModifica
        '
        Me.labDescrDataOraModifica.AutoSize = True
        Me.labDescrDataOraModifica.Location = New System.Drawing.Point(10, 70)
        Me.labDescrDataOraModifica.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrDataOraModifica.Name = "labDescrDataOraModifica"
        Me.labDescrDataOraModifica.Size = New System.Drawing.Size(218, 18)
        Me.labDescrDataOraModifica.TabIndex = 2
        Me.labDescrDataOraModifica.Text = "Data e ora dell'ultima modifica"
        Me.labDescrDataOraModifica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDataOraCreazione
        '
        Me.labDataOraCreazione.BackColor = System.Drawing.Color.White
        Me.labDataOraCreazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labDataOraCreazione.Location = New System.Drawing.Point(250, 25)
        Me.labDataOraCreazione.Margin = New System.Windows.Forms.Padding(5)
        Me.labDataOraCreazione.Name = "labDataOraCreazione"
        Me.labDataOraCreazione.Size = New System.Drawing.Size(250, 26)
        Me.labDataOraCreazione.TabIndex = 1
        Me.labDataOraCreazione.Text = "???"
        Me.labDataOraCreazione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrDataOraCreazione
        '
        Me.labDescrDataOraCreazione.AutoSize = True
        Me.labDescrDataOraCreazione.Location = New System.Drawing.Point(10, 30)
        Me.labDescrDataOraCreazione.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrDataOraCreazione.Name = "labDescrDataOraCreazione"
        Me.labDescrDataOraCreazione.Size = New System.Drawing.Size(171, 18)
        Me.labDescrDataOraCreazione.TabIndex = 0
        Me.labDescrDataOraCreazione.Text = "Data e ora di creazione"
        Me.labDescrDataOraCreazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpParametriRicetta2
        '
        Me.tpParametriRicetta2.BackColor = System.Drawing.SystemColors.Control
        Me.tpParametriRicetta2.Controls.Add(Me.gbRiscaldamentoRaffreddamento)
        Me.tpParametriRicetta2.Controls.Add(Me.gbIheater)
        Me.tpParametriRicetta2.Controls.Add(Me.gbIsolamento)
        Me.tpParametriRicetta2.Controls.Add(Me.gbRheater)
        Me.tpParametriRicetta2.Controls.Add(Me.gbVal)
        Me.tpParametriRicetta2.Location = New System.Drawing.Point(4, 27)
        Me.tpParametriRicetta2.Margin = New System.Windows.Forms.Padding(5)
        Me.tpParametriRicetta2.Name = "tpParametriRicetta2"
        Me.tpParametriRicetta2.Padding = New System.Windows.Forms.Padding(5)
        Me.tpParametriRicetta2.Size = New System.Drawing.Size(532, 539)
        Me.tpParametriRicetta2.TabIndex = 1
        Me.tpParametriRicetta2.Text = "Parametri collaudo 1"
        '
        'gbRiscaldamentoRaffreddamento
        '
        Me.gbRiscaldamentoRaffreddamento.Controls.Add(Me.labUDMTempoRiscaldamento)
        Me.gbRiscaldamentoRaffreddamento.Controls.Add(Me.labTempoRiscaldamento)
        Me.gbRiscaldamentoRaffreddamento.Controls.Add(Me.labDescrTempoRiscaldamento)
        Me.gbRiscaldamentoRaffreddamento.Controls.Add(Me.labDescrTempoRaffreddamento)
        Me.gbRiscaldamentoRaffreddamento.Controls.Add(Me.labTempoRaffreddamento)
        Me.gbRiscaldamentoRaffreddamento.Controls.Add(Me.labUDMTempoRaffreddamento)
        Me.gbRiscaldamentoRaffreddamento.Location = New System.Drawing.Point(8, 132)
        Me.gbRiscaldamentoRaffreddamento.Name = "gbRiscaldamentoRaffreddamento"
        Me.gbRiscaldamentoRaffreddamento.Size = New System.Drawing.Size(516, 93)
        Me.gbRiscaldamentoRaffreddamento.TabIndex = 2
        Me.gbRiscaldamentoRaffreddamento.TabStop = False
        Me.gbRiscaldamentoRaffreddamento.Text = "Riscaldamento/Raffreddamento"
        '
        'labUDMTempoRiscaldamento
        '
        Me.labUDMTempoRiscaldamento.Location = New System.Drawing.Point(456, 23)
        Me.labUDMTempoRiscaldamento.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMTempoRiscaldamento.Name = "labUDMTempoRiscaldamento"
        Me.labUDMTempoRiscaldamento.Size = New System.Drawing.Size(55, 26)
        Me.labUDMTempoRiscaldamento.TabIndex = 2
        Me.labUDMTempoRiscaldamento.Text = "?"
        Me.labUDMTempoRiscaldamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTempoRiscaldamento
        '
        Me.labTempoRiscaldamento.BackColor = System.Drawing.Color.White
        Me.labTempoRiscaldamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labTempoRiscaldamento.Location = New System.Drawing.Point(392, 23)
        Me.labTempoRiscaldamento.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.labTempoRiscaldamento.Name = "labTempoRiscaldamento"
        Me.labTempoRiscaldamento.Size = New System.Drawing.Size(60, 26)
        Me.labTempoRiscaldamento.TabIndex = 1
        Me.labTempoRiscaldamento.Text = "???"
        Me.labTempoRiscaldamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrTempoRiscaldamento
        '
        Me.labDescrTempoRiscaldamento.AutoSize = True
        Me.labDescrTempoRiscaldamento.Location = New System.Drawing.Point(6, 27)
        Me.labDescrTempoRiscaldamento.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrTempoRiscaldamento.Name = "labDescrTempoRiscaldamento"
        Me.labDescrTempoRiscaldamento.Size = New System.Drawing.Size(180, 18)
        Me.labDescrTempoRiscaldamento.TabIndex = 0
        Me.labDescrTempoRiscaldamento.Text = "Tempo di Riscaldamento"
        '
        'labDescrTempoRaffreddamento
        '
        Me.labDescrTempoRaffreddamento.AutoSize = True
        Me.labDescrTempoRaffreddamento.Location = New System.Drawing.Point(5, 61)
        Me.labDescrTempoRaffreddamento.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrTempoRaffreddamento.Name = "labDescrTempoRaffreddamento"
        Me.labDescrTempoRaffreddamento.Size = New System.Drawing.Size(188, 18)
        Me.labDescrTempoRaffreddamento.TabIndex = 3
        Me.labDescrTempoRaffreddamento.Text = "Tempo di Raffreddamento"
        '
        'labTempoRaffreddamento
        '
        Me.labTempoRaffreddamento.BackColor = System.Drawing.Color.White
        Me.labTempoRaffreddamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labTempoRaffreddamento.Location = New System.Drawing.Point(391, 56)
        Me.labTempoRaffreddamento.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labTempoRaffreddamento.Name = "labTempoRaffreddamento"
        Me.labTempoRaffreddamento.Size = New System.Drawing.Size(60, 26)
        Me.labTempoRaffreddamento.TabIndex = 4
        Me.labTempoRaffreddamento.Text = "???"
        Me.labTempoRaffreddamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labUDMTempoRaffreddamento
        '
        Me.labUDMTempoRaffreddamento.Location = New System.Drawing.Point(455, 56)
        Me.labUDMTempoRaffreddamento.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMTempoRaffreddamento.Name = "labUDMTempoRaffreddamento"
        Me.labUDMTempoRaffreddamento.Size = New System.Drawing.Size(55, 26)
        Me.labUDMTempoRaffreddamento.TabIndex = 5
        Me.labUDMTempoRaffreddamento.Text = "?"
        Me.labUDMTempoRaffreddamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbIheater
        '
        Me.gbIheater.Controls.Add(Me.labCorrenteRiscaldatoreMax)
        Me.gbIheater.Controls.Add(Me.chkCorrenteRiscaldatore)
        Me.gbIheater.Controls.Add(Me.labUDMCorrenteRiscaldatore)
        Me.gbIheater.Controls.Add(Me.labCorrenteRiscaldatoreMin)
        Me.gbIheater.Location = New System.Drawing.Point(8, 229)
        Me.gbIheater.Name = "gbIheater"
        Me.gbIheater.Size = New System.Drawing.Size(516, 58)
        Me.gbIheater.TabIndex = 3
        Me.gbIheater.TabStop = False
        Me.gbIheater.Text = "Misura Corrente Riscaldatore"
        '
        'labCorrenteRiscaldatoreMax
        '
        Me.labCorrenteRiscaldatoreMax.BackColor = System.Drawing.Color.White
        Me.labCorrenteRiscaldatoreMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labCorrenteRiscaldatoreMax.Location = New System.Drawing.Point(394, 23)
        Me.labCorrenteRiscaldatoreMax.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labCorrenteRiscaldatoreMax.Name = "labCorrenteRiscaldatoreMax"
        Me.labCorrenteRiscaldatoreMax.Size = New System.Drawing.Size(60, 26)
        Me.labCorrenteRiscaldatoreMax.TabIndex = 2
        Me.labCorrenteRiscaldatoreMax.Text = "???"
        Me.labCorrenteRiscaldatoreMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkCorrenteRiscaldatore
        '
        Me.chkCorrenteRiscaldatore.Location = New System.Drawing.Point(8, 27)
        Me.chkCorrenteRiscaldatore.Margin = New System.Windows.Forms.Padding(5)
        Me.chkCorrenteRiscaldatore.Name = "chkCorrenteRiscaldatore"
        Me.chkCorrenteRiscaldatore.Size = New System.Drawing.Size(253, 24)
        Me.chkCorrenteRiscaldatore.TabIndex = 0
        Me.chkCorrenteRiscaldatore.Text = "Ih (min/max)"
        Me.chkCorrenteRiscaldatore.UseVisualStyleBackColor = True
        '
        'labUDMCorrenteRiscaldatore
        '
        Me.labUDMCorrenteRiscaldatore.Location = New System.Drawing.Point(458, 23)
        Me.labUDMCorrenteRiscaldatore.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMCorrenteRiscaldatore.Name = "labUDMCorrenteRiscaldatore"
        Me.labUDMCorrenteRiscaldatore.Size = New System.Drawing.Size(55, 26)
        Me.labUDMCorrenteRiscaldatore.TabIndex = 3
        Me.labUDMCorrenteRiscaldatore.Text = "?"
        Me.labUDMCorrenteRiscaldatore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labCorrenteRiscaldatoreMin
        '
        Me.labCorrenteRiscaldatoreMin.BackColor = System.Drawing.Color.White
        Me.labCorrenteRiscaldatoreMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labCorrenteRiscaldatoreMin.Location = New System.Drawing.Point(326, 23)
        Me.labCorrenteRiscaldatoreMin.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labCorrenteRiscaldatoreMin.Name = "labCorrenteRiscaldatoreMin"
        Me.labCorrenteRiscaldatoreMin.Size = New System.Drawing.Size(60, 26)
        Me.labCorrenteRiscaldatoreMin.TabIndex = 1
        Me.labCorrenteRiscaldatoreMin.Text = "???"
        Me.labCorrenteRiscaldatoreMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbIsolamento
        '
        Me.gbIsolamento.Controls.Add(Me.chkResistenzaIsolamento)
        Me.gbIsolamento.Controls.Add(Me.labUDMResistenzaIsolamento)
        Me.gbIsolamento.Controls.Add(Me.labResistenzaIsolamentoMin)
        Me.gbIsolamento.Location = New System.Drawing.Point(8, 291)
        Me.gbIsolamento.Name = "gbIsolamento"
        Me.gbIsolamento.Size = New System.Drawing.Size(516, 58)
        Me.gbIsolamento.TabIndex = 4
        Me.gbIsolamento.TabStop = False
        Me.gbIsolamento.Text = "Misura Isolamento Riscaldatore"
        '
        'chkResistenzaIsolamento
        '
        Me.chkResistenzaIsolamento.Location = New System.Drawing.Point(8, 28)
        Me.chkResistenzaIsolamento.Margin = New System.Windows.Forms.Padding(5)
        Me.chkResistenzaIsolamento.Name = "chkResistenzaIsolamento"
        Me.chkResistenzaIsolamento.Size = New System.Drawing.Size(251, 24)
        Me.chkResistenzaIsolamento.TabIndex = 0
        Me.chkResistenzaIsolamento.Text = "Ri-h (min)"
        Me.chkResistenzaIsolamento.UseVisualStyleBackColor = True
        '
        'labUDMResistenzaIsolamento
        '
        Me.labUDMResistenzaIsolamento.Location = New System.Drawing.Point(458, 26)
        Me.labUDMResistenzaIsolamento.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMResistenzaIsolamento.Name = "labUDMResistenzaIsolamento"
        Me.labUDMResistenzaIsolamento.Size = New System.Drawing.Size(55, 26)
        Me.labUDMResistenzaIsolamento.TabIndex = 2
        Me.labUDMResistenzaIsolamento.Text = "?"
        Me.labUDMResistenzaIsolamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labResistenzaIsolamentoMin
        '
        Me.labResistenzaIsolamentoMin.BackColor = System.Drawing.Color.White
        Me.labResistenzaIsolamentoMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labResistenzaIsolamentoMin.Location = New System.Drawing.Point(394, 26)
        Me.labResistenzaIsolamentoMin.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labResistenzaIsolamentoMin.Name = "labResistenzaIsolamentoMin"
        Me.labResistenzaIsolamentoMin.Size = New System.Drawing.Size(60, 26)
        Me.labResistenzaIsolamentoMin.TabIndex = 1
        Me.labResistenzaIsolamentoMin.Text = "???"
        Me.labResistenzaIsolamentoMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbRheater
        '
        Me.gbRheater.Controls.Add(Me.chkRheater)
        Me.gbRheater.Controls.Add(Me.labRheaterMax)
        Me.gbRheater.Controls.Add(Me.labUDMRheater)
        Me.gbRheater.Controls.Add(Me.labRheaterMin)
        Me.gbRheater.Location = New System.Drawing.Point(8, 70)
        Me.gbRheater.Name = "gbRheater"
        Me.gbRheater.Size = New System.Drawing.Size(516, 58)
        Me.gbRheater.TabIndex = 1
        Me.gbRheater.TabStop = False
        Me.gbRheater.Text = "Misura Resistenza Riscaldatore"
        '
        'chkRheater
        '
        Me.chkRheater.Location = New System.Drawing.Point(8, 27)
        Me.chkRheater.Margin = New System.Windows.Forms.Padding(5)
        Me.chkRheater.Name = "chkRheater"
        Me.chkRheater.Size = New System.Drawing.Size(239, 24)
        Me.chkRheater.TabIndex = 0
        Me.chkRheater.Text = "Rh (min/max)"
        Me.chkRheater.UseVisualStyleBackColor = True
        '
        'labRheaterMax
        '
        Me.labRheaterMax.BackColor = System.Drawing.Color.White
        Me.labRheaterMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labRheaterMax.Location = New System.Drawing.Point(394, 23)
        Me.labRheaterMax.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.labRheaterMax.Name = "labRheaterMax"
        Me.labRheaterMax.Size = New System.Drawing.Size(60, 26)
        Me.labRheaterMax.TabIndex = 2
        Me.labRheaterMax.Text = "???"
        Me.labRheaterMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labUDMRheater
        '
        Me.labUDMRheater.Location = New System.Drawing.Point(458, 23)
        Me.labUDMRheater.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMRheater.Name = "labUDMRheater"
        Me.labUDMRheater.Size = New System.Drawing.Size(55, 26)
        Me.labUDMRheater.TabIndex = 3
        Me.labUDMRheater.Text = "?"
        Me.labUDMRheater.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRheaterMin
        '
        Me.labRheaterMin.BackColor = System.Drawing.Color.White
        Me.labRheaterMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labRheaterMin.Location = New System.Drawing.Point(326, 23)
        Me.labRheaterMin.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labRheaterMin.Name = "labRheaterMin"
        Me.labRheaterMin.Size = New System.Drawing.Size(60, 26)
        Me.labRheaterMin.TabIndex = 1
        Me.labRheaterMin.Text = "???"
        Me.labRheaterMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbVal
        '
        Me.gbVal.Controls.Add(Me.labDescrVal)
        Me.gbVal.Controls.Add(Me.labValMin)
        Me.gbVal.Controls.Add(Me.labValMax)
        Me.gbVal.Controls.Add(Me.labUDMVal)
        Me.gbVal.Location = New System.Drawing.Point(8, 8)
        Me.gbVal.Name = "gbVal"
        Me.gbVal.Size = New System.Drawing.Size(516, 58)
        Me.gbVal.TabIndex = 0
        Me.gbVal.TabStop = False
        Me.gbVal.Text = "Misura Tensione Alimentazione"
        '
        'labDescrVal
        '
        Me.labDescrVal.AutoSize = True
        Me.labDescrVal.Location = New System.Drawing.Point(8, 27)
        Me.labDescrVal.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrVal.Name = "labDescrVal"
        Me.labDescrVal.Size = New System.Drawing.Size(119, 18)
        Me.labDescrVal.TabIndex = 0
        Me.labDescrVal.Text = "Valim (min/max)"
        '
        'labValMin
        '
        Me.labValMin.BackColor = System.Drawing.Color.White
        Me.labValMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labValMin.Location = New System.Drawing.Point(326, 23)
        Me.labValMin.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labValMin.Name = "labValMin"
        Me.labValMin.Size = New System.Drawing.Size(60, 26)
        Me.labValMin.TabIndex = 1
        Me.labValMin.Text = "???"
        Me.labValMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labValMax
        '
        Me.labValMax.BackColor = System.Drawing.Color.White
        Me.labValMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labValMax.Location = New System.Drawing.Point(394, 23)
        Me.labValMax.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labValMax.Name = "labValMax"
        Me.labValMax.Size = New System.Drawing.Size(60, 26)
        Me.labValMax.TabIndex = 2
        Me.labValMax.Text = "???"
        Me.labValMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labUDMVal
        '
        Me.labUDMVal.Location = New System.Drawing.Point(458, 23)
        Me.labUDMVal.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMVal.Name = "labUDMVal"
        Me.labUDMVal.Size = New System.Drawing.Size(55, 26)
        Me.labUDMVal.TabIndex = 3
        Me.labUDMVal.Text = "?"
        Me.labUDMVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpParametriRicetta3
        '
        Me.tpParametriRicetta3.BackColor = System.Drawing.SystemColors.Control
        Me.tpParametriRicetta3.Controls.Add(Me.gbMisureLSU)
        Me.tpParametriRicetta3.Controls.Add(Me.gbMisureZFAS)
        Me.tpParametriRicetta3.Controls.Add(Me.gbMisureADV)
        Me.tpParametriRicetta3.Location = New System.Drawing.Point(4, 27)
        Me.tpParametriRicetta3.Name = "tpParametriRicetta3"
        Me.tpParametriRicetta3.Padding = New System.Windows.Forms.Padding(3)
        Me.tpParametriRicetta3.Size = New System.Drawing.Size(532, 539)
        Me.tpParametriRicetta3.TabIndex = 2
        Me.tpParametriRicetta3.Text = "Parametri collaudo 2"
        '
        'gbMisureLSU
        '
        Me.gbMisureLSU.Controls.Add(Me.labResistenzaCalibrazioneMin)
        Me.gbMisureLSU.Controls.Add(Me.labTempOperativaMax)
        Me.gbMisureLSU.Controls.Add(Me.labUdmTargetO2)
        Me.gbMisureLSU.Controls.Add(Me.labTargetO2)
        Me.gbMisureLSU.Controls.Add(Me.labDescrTargetO2)
        Me.gbMisureLSU.Controls.Add(Me.labDescrFlussoN2)
        Me.gbMisureLSU.Controls.Add(Me.chkResistenzaCalibrazione)
        Me.gbMisureLSU.Controls.Add(Me.labUDMResistenzaCalibrazione)
        Me.gbMisureLSU.Controls.Add(Me.labResistenzaCalibrazioneMax)
        Me.gbMisureLSU.Controls.Add(Me.chkO2)
        Me.gbMisureLSU.Controls.Add(Me.labUDMTempOperativa)
        Me.gbMisureLSU.Controls.Add(Me.labTempOperativaMin)
        Me.gbMisureLSU.Controls.Add(Me.chkTemperaturaOperativa)
        Me.gbMisureLSU.Controls.Add(Me.labO2Max)
        Me.gbMisureLSU.Controls.Add(Me.labUDMO2)
        Me.gbMisureLSU.Controls.Add(Me.labO2Min)
        Me.gbMisureLSU.Controls.Add(Me.labUDMFlussoN2)
        Me.gbMisureLSU.Controls.Add(Me.labFlussoN2)
        Me.gbMisureLSU.Controls.Add(Me.labUDMFlussoAria)
        Me.gbMisureLSU.Controls.Add(Me.labFlussoAria)
        Me.gbMisureLSU.Controls.Add(Me.labDescrFlussoAria)
        Me.gbMisureLSU.Location = New System.Drawing.Point(10, 9)
        Me.gbMisureLSU.Name = "gbMisureLSU"
        Me.gbMisureLSU.Size = New System.Drawing.Size(516, 240)
        Me.gbMisureLSU.TabIndex = 0
        Me.gbMisureLSU.TabStop = False
        Me.gbMisureLSU.Text = "Misure LSU 4.9"
        '
        'labResistenzaCalibrazioneMin
        '
        Me.labResistenzaCalibrazioneMin.BackColor = System.Drawing.Color.White
        Me.labResistenzaCalibrazioneMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labResistenzaCalibrazioneMin.Location = New System.Drawing.Point(326, 198)
        Me.labResistenzaCalibrazioneMin.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labResistenzaCalibrazioneMin.Name = "labResistenzaCalibrazioneMin"
        Me.labResistenzaCalibrazioneMin.Size = New System.Drawing.Size(60, 26)
        Me.labResistenzaCalibrazioneMin.TabIndex = 18
        Me.labResistenzaCalibrazioneMin.Text = "???"
        Me.labResistenzaCalibrazioneMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labTempOperativaMax
        '
        Me.labTempOperativaMax.BackColor = System.Drawing.Color.White
        Me.labTempOperativaMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labTempOperativaMax.Location = New System.Drawing.Point(394, 128)
        Me.labTempOperativaMax.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labTempOperativaMax.Name = "labTempOperativaMax"
        Me.labTempOperativaMax.Size = New System.Drawing.Size(60, 26)
        Me.labTempOperativaMax.TabIndex = 11
        Me.labTempOperativaMax.Text = "???"
        Me.labTempOperativaMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labUdmTargetO2
        '
        Me.labUdmTargetO2.Location = New System.Drawing.Point(458, 92)
        Me.labUdmTargetO2.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUdmTargetO2.Name = "labUdmTargetO2"
        Me.labUdmTargetO2.Size = New System.Drawing.Size(55, 26)
        Me.labUdmTargetO2.TabIndex = 8
        Me.labUdmTargetO2.Text = "?"
        Me.labUdmTargetO2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTargetO2
        '
        Me.labTargetO2.BackColor = System.Drawing.Color.White
        Me.labTargetO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labTargetO2.Location = New System.Drawing.Point(394, 92)
        Me.labTargetO2.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.labTargetO2.Name = "labTargetO2"
        Me.labTargetO2.Size = New System.Drawing.Size(60, 26)
        Me.labTargetO2.TabIndex = 7
        Me.labTargetO2.Text = "???"
        Me.labTargetO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrTargetO2
        '
        Me.labDescrTargetO2.AutoSize = True
        Me.labDescrTargetO2.Location = New System.Drawing.Point(8, 96)
        Me.labDescrTargetO2.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrTargetO2.Name = "labDescrTargetO2"
        Me.labDescrTargetO2.Size = New System.Drawing.Size(76, 18)
        Me.labDescrTargetO2.TabIndex = 6
        Me.labDescrTargetO2.Text = "Target O2"
        '
        'labDescrFlussoN2
        '
        Me.labDescrFlussoN2.AutoSize = True
        Me.labDescrFlussoN2.Location = New System.Drawing.Point(8, 62)
        Me.labDescrFlussoN2.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrFlussoN2.Name = "labDescrFlussoN2"
        Me.labDescrFlussoN2.Size = New System.Drawing.Size(222, 18)
        Me.labDescrFlussoN2.TabIndex = 3
        Me.labDescrFlussoN2.Text = "Flusso N2 Erogato (NL/minuto)"
        '
        'chkResistenzaCalibrazione
        '
        Me.chkResistenzaCalibrazione.Location = New System.Drawing.Point(8, 200)
        Me.chkResistenzaCalibrazione.Margin = New System.Windows.Forms.Padding(5)
        Me.chkResistenzaCalibrazione.Name = "chkResistenzaCalibrazione"
        Me.chkResistenzaCalibrazione.Size = New System.Drawing.Size(286, 24)
        Me.chkResistenzaCalibrazione.TabIndex = 17
        Me.chkResistenzaCalibrazione.Text = "Rcal(I) (min/max)"
        Me.chkResistenzaCalibrazione.UseVisualStyleBackColor = True
        '
        'labUDMResistenzaCalibrazione
        '
        Me.labUDMResistenzaCalibrazione.Location = New System.Drawing.Point(458, 198)
        Me.labUDMResistenzaCalibrazione.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMResistenzaCalibrazione.Name = "labUDMResistenzaCalibrazione"
        Me.labUDMResistenzaCalibrazione.Size = New System.Drawing.Size(55, 26)
        Me.labUDMResistenzaCalibrazione.TabIndex = 20
        Me.labUDMResistenzaCalibrazione.Text = "?"
        Me.labUDMResistenzaCalibrazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labResistenzaCalibrazioneMax
        '
        Me.labResistenzaCalibrazioneMax.BackColor = System.Drawing.Color.White
        Me.labResistenzaCalibrazioneMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labResistenzaCalibrazioneMax.Location = New System.Drawing.Point(394, 198)
        Me.labResistenzaCalibrazioneMax.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labResistenzaCalibrazioneMax.Name = "labResistenzaCalibrazioneMax"
        Me.labResistenzaCalibrazioneMax.Size = New System.Drawing.Size(60, 26)
        Me.labResistenzaCalibrazioneMax.TabIndex = 19
        Me.labResistenzaCalibrazioneMax.Text = "???"
        Me.labResistenzaCalibrazioneMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkO2
        '
        Me.chkO2.Location = New System.Drawing.Point(8, 165)
        Me.chkO2.Margin = New System.Windows.Forms.Padding(5)
        Me.chkO2.Name = "chkO2"
        Me.chkO2.Size = New System.Drawing.Size(163, 24)
        Me.chkO2.TabIndex = 13
        Me.chkO2.Text = "O2% (min/max)"
        Me.chkO2.UseVisualStyleBackColor = True
        '
        'labUDMTempOperativa
        '
        Me.labUDMTempOperativa.Location = New System.Drawing.Point(458, 128)
        Me.labUDMTempOperativa.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMTempOperativa.Name = "labUDMTempOperativa"
        Me.labUDMTempOperativa.Size = New System.Drawing.Size(55, 26)
        Me.labUDMTempOperativa.TabIndex = 12
        Me.labUDMTempOperativa.Text = "?"
        Me.labUDMTempOperativa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTempOperativaMin
        '
        Me.labTempOperativaMin.BackColor = System.Drawing.Color.White
        Me.labTempOperativaMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labTempOperativaMin.Location = New System.Drawing.Point(326, 128)
        Me.labTempOperativaMin.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labTempOperativaMin.Name = "labTempOperativaMin"
        Me.labTempOperativaMin.Size = New System.Drawing.Size(60, 26)
        Me.labTempOperativaMin.TabIndex = 10
        Me.labTempOperativaMin.Text = "???"
        Me.labTempOperativaMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkTemperaturaOperativa
        '
        Me.chkTemperaturaOperativa.Location = New System.Drawing.Point(8, 130)
        Me.chkTemperaturaOperativa.Margin = New System.Windows.Forms.Padding(5)
        Me.chkTemperaturaOperativa.Name = "chkTemperaturaOperativa"
        Me.chkTemperaturaOperativa.Size = New System.Drawing.Size(272, 24)
        Me.chkTemperaturaOperativa.TabIndex = 9
        Me.chkTemperaturaOperativa.Text = "Temperatura Operativa (min/max)"
        Me.chkTemperaturaOperativa.UseVisualStyleBackColor = True
        '
        'labO2Max
        '
        Me.labO2Max.BackColor = System.Drawing.Color.White
        Me.labO2Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labO2Max.Location = New System.Drawing.Point(394, 163)
        Me.labO2Max.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.labO2Max.Name = "labO2Max"
        Me.labO2Max.Size = New System.Drawing.Size(60, 26)
        Me.labO2Max.TabIndex = 15
        Me.labO2Max.Text = "???"
        Me.labO2Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labUDMO2
        '
        Me.labUDMO2.Location = New System.Drawing.Point(458, 163)
        Me.labUDMO2.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMO2.Name = "labUDMO2"
        Me.labUDMO2.Size = New System.Drawing.Size(55, 26)
        Me.labUDMO2.TabIndex = 16
        Me.labUDMO2.Text = "?"
        Me.labUDMO2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labO2Min
        '
        Me.labO2Min.BackColor = System.Drawing.Color.White
        Me.labO2Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labO2Min.Location = New System.Drawing.Point(326, 163)
        Me.labO2Min.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labO2Min.Name = "labO2Min"
        Me.labO2Min.Size = New System.Drawing.Size(60, 26)
        Me.labO2Min.TabIndex = 14
        Me.labO2Min.Text = "???"
        Me.labO2Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labUDMFlussoN2
        '
        Me.labUDMFlussoN2.Location = New System.Drawing.Point(458, 58)
        Me.labUDMFlussoN2.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMFlussoN2.Name = "labUDMFlussoN2"
        Me.labUDMFlussoN2.Size = New System.Drawing.Size(55, 26)
        Me.labUDMFlussoN2.TabIndex = 5
        Me.labUDMFlussoN2.Text = "?"
        Me.labUDMFlussoN2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labFlussoN2
        '
        Me.labFlussoN2.BackColor = System.Drawing.Color.White
        Me.labFlussoN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labFlussoN2.Location = New System.Drawing.Point(394, 58)
        Me.labFlussoN2.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.labFlussoN2.Name = "labFlussoN2"
        Me.labFlussoN2.Size = New System.Drawing.Size(60, 26)
        Me.labFlussoN2.TabIndex = 4
        Me.labFlussoN2.Text = "???"
        Me.labFlussoN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labUDMFlussoAria
        '
        Me.labUDMFlussoAria.Location = New System.Drawing.Point(458, 24)
        Me.labUDMFlussoAria.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUDMFlussoAria.Name = "labUDMFlussoAria"
        Me.labUDMFlussoAria.Size = New System.Drawing.Size(55, 26)
        Me.labUDMFlussoAria.TabIndex = 2
        Me.labUDMFlussoAria.Text = "?"
        Me.labUDMFlussoAria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labFlussoAria
        '
        Me.labFlussoAria.BackColor = System.Drawing.Color.White
        Me.labFlussoAria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labFlussoAria.Location = New System.Drawing.Point(394, 24)
        Me.labFlussoAria.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labFlussoAria.Name = "labFlussoAria"
        Me.labFlussoAria.Size = New System.Drawing.Size(60, 26)
        Me.labFlussoAria.TabIndex = 1
        Me.labFlussoAria.Text = "???"
        Me.labFlussoAria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrFlussoAria
        '
        Me.labDescrFlussoAria.AutoSize = True
        Me.labDescrFlussoAria.Location = New System.Drawing.Point(8, 28)
        Me.labDescrFlussoAria.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrFlussoAria.Name = "labDescrFlussoAria"
        Me.labDescrFlussoAria.Size = New System.Drawing.Size(230, 18)
        Me.labDescrFlussoAria.TabIndex = 0
        Me.labDescrFlussoAria.Text = "Flusso Aria Erogato (NL/minuto)"
        '
        'gbMisureZFAS
        '
        Me.gbMisureZFAS.Controls.Add(Me.chkZfasIpTb)
        Me.gbMisureZFAS.Controls.Add(Me.labUdmZfasIpTb)
        Me.gbMisureZFAS.Controls.Add(Me.chkZfasIpEtas)
        Me.gbMisureZFAS.Controls.Add(Me.labZfasIpTbMin)
        Me.gbMisureZFAS.Controls.Add(Me.labUdmZfasIpEtas)
        Me.gbMisureZFAS.Controls.Add(Me.labZfasIpTbMax)
        Me.gbMisureZFAS.Controls.Add(Me.labZfasIpEtasMin)
        Me.gbMisureZFAS.Controls.Add(Me.labZfasIpEtasMax)
        Me.gbMisureZFAS.Location = New System.Drawing.Point(10, 361)
        Me.gbMisureZFAS.Name = "gbMisureZFAS"
        Me.gbMisureZFAS.Size = New System.Drawing.Size(516, 100)
        Me.gbMisureZFAS.TabIndex = 2
        Me.gbMisureZFAS.TabStop = False
        Me.gbMisureZFAS.Text = "Misure ZFAS-U2"
        '
        'chkZfasIpTb
        '
        Me.chkZfasIpTb.Location = New System.Drawing.Point(8, 62)
        Me.chkZfasIpTb.Margin = New System.Windows.Forms.Padding(5)
        Me.chkZfasIpTb.Name = "chkZfasIpTb"
        Me.chkZfasIpTb.Size = New System.Drawing.Size(251, 24)
        Me.chkZfasIpTb.TabIndex = 4
        Me.chkZfasIpTb.Text = "IP_TB (min/max)"
        Me.chkZfasIpTb.UseVisualStyleBackColor = True
        '
        'labUdmZfasIpTb
        '
        Me.labUdmZfasIpTb.Location = New System.Drawing.Point(458, 60)
        Me.labUdmZfasIpTb.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUdmZfasIpTb.Name = "labUdmZfasIpTb"
        Me.labUdmZfasIpTb.Size = New System.Drawing.Size(55, 26)
        Me.labUdmZfasIpTb.TabIndex = 7
        Me.labUdmZfasIpTb.Text = "?"
        Me.labUdmZfasIpTb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkZfasIpEtas
        '
        Me.chkZfasIpEtas.Location = New System.Drawing.Point(8, 28)
        Me.chkZfasIpEtas.Margin = New System.Windows.Forms.Padding(5)
        Me.chkZfasIpEtas.Name = "chkZfasIpEtas"
        Me.chkZfasIpEtas.Size = New System.Drawing.Size(251, 24)
        Me.chkZfasIpEtas.TabIndex = 0
        Me.chkZfasIpEtas.Text = "Ip_ETAS (min/max)"
        Me.chkZfasIpEtas.UseVisualStyleBackColor = True
        '
        'labZfasIpTbMin
        '
        Me.labZfasIpTbMin.BackColor = System.Drawing.Color.White
        Me.labZfasIpTbMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labZfasIpTbMin.Location = New System.Drawing.Point(326, 60)
        Me.labZfasIpTbMin.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labZfasIpTbMin.Name = "labZfasIpTbMin"
        Me.labZfasIpTbMin.Size = New System.Drawing.Size(60, 26)
        Me.labZfasIpTbMin.TabIndex = 5
        Me.labZfasIpTbMin.Text = "???"
        Me.labZfasIpTbMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labUdmZfasIpEtas
        '
        Me.labUdmZfasIpEtas.Location = New System.Drawing.Point(458, 26)
        Me.labUdmZfasIpEtas.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUdmZfasIpEtas.Name = "labUdmZfasIpEtas"
        Me.labUdmZfasIpEtas.Size = New System.Drawing.Size(55, 26)
        Me.labUdmZfasIpEtas.TabIndex = 3
        Me.labUdmZfasIpEtas.Text = "?"
        Me.labUdmZfasIpEtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labZfasIpTbMax
        '
        Me.labZfasIpTbMax.BackColor = System.Drawing.Color.White
        Me.labZfasIpTbMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labZfasIpTbMax.Location = New System.Drawing.Point(394, 60)
        Me.labZfasIpTbMax.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labZfasIpTbMax.Name = "labZfasIpTbMax"
        Me.labZfasIpTbMax.Size = New System.Drawing.Size(60, 26)
        Me.labZfasIpTbMax.TabIndex = 6
        Me.labZfasIpTbMax.Text = "???"
        Me.labZfasIpTbMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labZfasIpEtasMin
        '
        Me.labZfasIpEtasMin.BackColor = System.Drawing.Color.White
        Me.labZfasIpEtasMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labZfasIpEtasMin.Location = New System.Drawing.Point(326, 26)
        Me.labZfasIpEtasMin.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labZfasIpEtasMin.Name = "labZfasIpEtasMin"
        Me.labZfasIpEtasMin.Size = New System.Drawing.Size(60, 26)
        Me.labZfasIpEtasMin.TabIndex = 1
        Me.labZfasIpEtasMin.Text = "???"
        Me.labZfasIpEtasMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labZfasIpEtasMax
        '
        Me.labZfasIpEtasMax.BackColor = System.Drawing.Color.White
        Me.labZfasIpEtasMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labZfasIpEtasMax.Location = New System.Drawing.Point(394, 26)
        Me.labZfasIpEtasMax.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labZfasIpEtasMax.Name = "labZfasIpEtasMax"
        Me.labZfasIpEtasMax.Size = New System.Drawing.Size(60, 26)
        Me.labZfasIpEtasMax.TabIndex = 2
        Me.labZfasIpEtasMax.Text = "???"
        Me.labZfasIpEtasMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbMisureADV
        '
        Me.gbMisureADV.Controls.Add(Me.chkAdvLambda)
        Me.gbMisureADV.Controls.Add(Me.labUdmAdvLambda)
        Me.gbMisureADV.Controls.Add(Me.chkAdvIp)
        Me.gbMisureADV.Controls.Add(Me.labAdvLambdaMin)
        Me.gbMisureADV.Controls.Add(Me.labUdmAdvIp)
        Me.gbMisureADV.Controls.Add(Me.labAdvLambdaMax)
        Me.gbMisureADV.Controls.Add(Me.labAdvIpMin)
        Me.gbMisureADV.Controls.Add(Me.labAdvIpMax)
        Me.gbMisureADV.Location = New System.Drawing.Point(10, 255)
        Me.gbMisureADV.Name = "gbMisureADV"
        Me.gbMisureADV.Size = New System.Drawing.Size(516, 100)
        Me.gbMisureADV.TabIndex = 1
        Me.gbMisureADV.TabStop = False
        Me.gbMisureADV.Text = "Misure ADV"
        '
        'chkAdvLambda
        '
        Me.chkAdvLambda.Location = New System.Drawing.Point(8, 62)
        Me.chkAdvLambda.Margin = New System.Windows.Forms.Padding(5)
        Me.chkAdvLambda.Name = "chkAdvLambda"
        Me.chkAdvLambda.Size = New System.Drawing.Size(251, 24)
        Me.chkAdvLambda.TabIndex = 5
        Me.chkAdvLambda.Text = "λ (min/max)"
        Me.chkAdvLambda.UseVisualStyleBackColor = True
        '
        'labUdmAdvLambda
        '
        Me.labUdmAdvLambda.Location = New System.Drawing.Point(458, 60)
        Me.labUdmAdvLambda.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUdmAdvLambda.Name = "labUdmAdvLambda"
        Me.labUdmAdvLambda.Size = New System.Drawing.Size(55, 26)
        Me.labUdmAdvLambda.TabIndex = 0
        Me.labUdmAdvLambda.Text = "?"
        Me.labUdmAdvLambda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkAdvIp
        '
        Me.chkAdvIp.Location = New System.Drawing.Point(8, 28)
        Me.chkAdvIp.Margin = New System.Windows.Forms.Padding(5)
        Me.chkAdvIp.Name = "chkAdvIp"
        Me.chkAdvIp.Size = New System.Drawing.Size(251, 24)
        Me.chkAdvIp.TabIndex = 0
        Me.chkAdvIp.Text = "Ip (min/max)"
        Me.chkAdvIp.UseVisualStyleBackColor = True
        '
        'labAdvLambdaMin
        '
        Me.labAdvLambdaMin.BackColor = System.Drawing.Color.White
        Me.labAdvLambdaMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labAdvLambdaMin.Location = New System.Drawing.Point(326, 60)
        Me.labAdvLambdaMin.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labAdvLambdaMin.Name = "labAdvLambdaMin"
        Me.labAdvLambdaMin.Size = New System.Drawing.Size(60, 26)
        Me.labAdvLambdaMin.TabIndex = 6
        Me.labAdvLambdaMin.Text = "???"
        Me.labAdvLambdaMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labUdmAdvIp
        '
        Me.labUdmAdvIp.Location = New System.Drawing.Point(458, 26)
        Me.labUdmAdvIp.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.labUdmAdvIp.Name = "labUdmAdvIp"
        Me.labUdmAdvIp.Size = New System.Drawing.Size(55, 26)
        Me.labUdmAdvIp.TabIndex = 3
        Me.labUdmAdvIp.Text = "?"
        Me.labUdmAdvIp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labAdvLambdaMax
        '
        Me.labAdvLambdaMax.BackColor = System.Drawing.Color.White
        Me.labAdvLambdaMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labAdvLambdaMax.Location = New System.Drawing.Point(394, 60)
        Me.labAdvLambdaMax.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labAdvLambdaMax.Name = "labAdvLambdaMax"
        Me.labAdvLambdaMax.Size = New System.Drawing.Size(60, 26)
        Me.labAdvLambdaMax.TabIndex = 7
        Me.labAdvLambdaMax.Text = "???"
        Me.labAdvLambdaMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labAdvIpMin
        '
        Me.labAdvIpMin.BackColor = System.Drawing.Color.White
        Me.labAdvIpMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labAdvIpMin.Location = New System.Drawing.Point(326, 26)
        Me.labAdvIpMin.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labAdvIpMin.Name = "labAdvIpMin"
        Me.labAdvIpMin.Size = New System.Drawing.Size(60, 26)
        Me.labAdvIpMin.TabIndex = 1
        Me.labAdvIpMin.Text = "???"
        Me.labAdvIpMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labAdvIpMax
        '
        Me.labAdvIpMax.BackColor = System.Drawing.Color.White
        Me.labAdvIpMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labAdvIpMax.Location = New System.Drawing.Point(394, 26)
        Me.labAdvIpMax.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.labAdvIpMax.Name = "labAdvIpMax"
        Me.labAdvIpMax.Size = New System.Drawing.Size(60, 26)
        Me.labAdvIpMax.TabIndex = 2
        Me.labAdvIpMax.Text = "???"
        Me.labAdvIpMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalvaRicetta
        '
        Me.btnSalvaRicetta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvaRicetta.Image = CType(resources.GetObject("btnSalvaRicetta.Image"), System.Drawing.Image)
        Me.btnSalvaRicetta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvaRicetta.Location = New System.Drawing.Point(321, 268)
        Me.btnSalvaRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalvaRicetta.Name = "btnSalvaRicetta"
        Me.btnSalvaRicetta.Size = New System.Drawing.Size(100, 80)
        Me.btnSalvaRicetta.TabIndex = 4
        Me.btnSalvaRicetta.Text = "Salva modifiche"
        Me.btnSalvaRicetta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvaRicetta.UseVisualStyleBackColor = True
        Me.btnSalvaRicetta.Visible = False
        '
        'btnChiudiRicetta
        '
        Me.btnChiudiRicetta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChiudiRicetta.Image = CType(resources.GetObject("btnChiudiRicetta.Image"), System.Drawing.Image)
        Me.btnChiudiRicetta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChiudiRicetta.Location = New System.Drawing.Point(321, 38)
        Me.btnChiudiRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnChiudiRicetta.Name = "btnChiudiRicetta"
        Me.btnChiudiRicetta.Size = New System.Drawing.Size(100, 60)
        Me.btnChiudiRicetta.TabIndex = 1
        Me.btnChiudiRicetta.Text = "Chiudi"
        Me.btnChiudiRicetta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnChiudiRicetta.UseVisualStyleBackColor = True
        Me.btnChiudiRicetta.Visible = False
        '
        'btnCaricaRicetta
        '
        Me.btnCaricaRicetta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaricaRicetta.Image = CType(resources.GetObject("btnCaricaRicetta.Image"), System.Drawing.Image)
        Me.btnCaricaRicetta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCaricaRicetta.Location = New System.Drawing.Point(321, 178)
        Me.btnCaricaRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCaricaRicetta.Name = "btnCaricaRicetta"
        Me.btnCaricaRicetta.Size = New System.Drawing.Size(100, 80)
        Me.btnCaricaRicetta.TabIndex = 3
        Me.btnCaricaRicetta.Text = "Annulla modifiche"
        Me.btnCaricaRicetta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCaricaRicetta.UseVisualStyleBackColor = True
        Me.btnCaricaRicetta.Visible = False
        '
        'btnModificaRicetta
        '
        Me.btnModificaRicetta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaRicetta.Image = CType(resources.GetObject("btnModificaRicetta.Image"), System.Drawing.Image)
        Me.btnModificaRicetta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificaRicetta.Location = New System.Drawing.Point(321, 108)
        Me.btnModificaRicetta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnModificaRicetta.Name = "btnModificaRicetta"
        Me.btnModificaRicetta.Size = New System.Drawing.Size(100, 60)
        Me.btnModificaRicetta.TabIndex = 2
        Me.btnModificaRicetta.Text = "Modifica"
        Me.btnModificaRicetta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificaRicetta.UseVisualStyleBackColor = True
        Me.btnModificaRicetta.Visible = False
        '
        'pdPrintDialog
        '
        Me.pdPrintDialog.UseEXDialog = True
        '
        'btnUscita
        '
        Me.btnUscita.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUscita.Image = CType(resources.GetObject("btnUscita.Image"), System.Drawing.Image)
        Me.btnUscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUscita.Location = New System.Drawing.Point(868, 590)
        Me.btnUscita.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUscita.Name = "btnUscita"
        Me.btnUscita.Size = New System.Drawing.Size(100, 60)
        Me.btnUscita.TabIndex = 6
        Me.btnUscita.Text = "Uscita"
        Me.btnUscita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUscita.UseVisualStyleBackColor = True
        '
        'frmGestioneRicette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 661)
        Me.Controls.Add(Me.btnUscita)
        Me.Controls.Add(Me.btnModificaRicetta)
        Me.Controls.Add(Me.btnCaricaRicetta)
        Me.Controls.Add(Me.btnChiudiRicetta)
        Me.Controls.Add(Me.btnSalvaRicetta)
        Me.Controls.Add(Me.tcParametriRicetta)
        Me.Controls.Add(Me.gbGestioneRicette)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGestioneRicette"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione ricette"
        Me.gbGestioneRicette.ResumeLayout(False)
        Me.tcParametriRicetta.ResumeLayout(False)
        Me.tpParametriRicetta1.ResumeLayout(False)
        Me.gbParametriGenerali.ResumeLayout(False)
        Me.gbParametriGenerali.PerformLayout()
        Me.tpParametriRicetta2.ResumeLayout(False)
        Me.gbRiscaldamentoRaffreddamento.ResumeLayout(False)
        Me.gbRiscaldamentoRaffreddamento.PerformLayout()
        Me.gbIheater.ResumeLayout(False)
        Me.gbIsolamento.ResumeLayout(False)
        Me.gbRheater.ResumeLayout(False)
        Me.gbVal.ResumeLayout(False)
        Me.gbVal.PerformLayout()
        Me.tpParametriRicetta3.ResumeLayout(False)
        Me.gbMisureLSU.ResumeLayout(False)
        Me.gbMisureLSU.PerformLayout()
        Me.gbMisureZFAS.ResumeLayout(False)
        Me.gbMisureADV.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbGestioneRicette As System.Windows.Forms.GroupBox
    Friend WithEvents tcParametriRicetta As System.Windows.Forms.TabControl
    Friend WithEvents tpParametriRicetta1 As System.Windows.Forms.TabPage
    Friend WithEvents tpParametriRicetta2 As System.Windows.Forms.TabPage
    Friend WithEvents gbParametriGenerali As System.Windows.Forms.GroupBox
    Friend WithEvents labIndiceRevisione As System.Windows.Forms.Label
    Friend WithEvents labDescrIndiceRevisione As System.Windows.Forms.Label
    Friend WithEvents labDataOraModifica As System.Windows.Forms.Label
    Friend WithEvents labDescrDataOraModifica As System.Windows.Forms.Label
    Friend WithEvents labDataOraCreazione As System.Windows.Forms.Label
    Friend WithEvents labDescrDataOraCreazione As System.Windows.Forms.Label
    Friend WithEvents labCodiceAttrezzatura As System.Windows.Forms.Label
    Friend WithEvents labDescrCodiceAttrezzatura As System.Windows.Forms.Label
    Friend WithEvents labDescrRicettaMaster As System.Windows.Forms.Label
    Friend WithEvents lbListaRicette As System.Windows.Forms.ListBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnVisualizzaRicetta As System.Windows.Forms.Button
    Friend WithEvents btnCancella As System.Windows.Forms.Button
    Friend WithEvents btnCopiaRicetta As System.Windows.Forms.Button
    Friend WithEvents btnNuovaRicetta As System.Windows.Forms.Button
    Friend WithEvents btnRicerca As System.Windows.Forms.Button
    Friend WithEvents btnSalvaRicetta As System.Windows.Forms.Button
    Friend WithEvents btnChiudiRicetta As System.Windows.Forms.Button
    Friend WithEvents btnCaricaRicetta As System.Windows.Forms.Button
    Friend WithEvents cbNomeRicettaMaster As System.Windows.Forms.ComboBox
    Friend WithEvents btnModificaRicetta As System.Windows.Forms.Button
    Friend WithEvents pdPrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents pdPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnUscita As System.Windows.Forms.Button
    Friend WithEvents labRheaterMax As System.Windows.Forms.Label
    Friend WithEvents chkRheater As System.Windows.Forms.CheckBox
    Friend WithEvents labValMin As System.Windows.Forms.Label
    Friend WithEvents labDescrVal As System.Windows.Forms.Label
    Friend WithEvents labUDMRheater As System.Windows.Forms.Label
    Friend WithEvents labValMax As System.Windows.Forms.Label
    Friend WithEvents labUDMVal As System.Windows.Forms.Label
    Friend WithEvents labRheaterMin As System.Windows.Forms.Label
    Friend WithEvents chkResistenzaIsolamento As CheckBox
    Friend WithEvents labUDMResistenzaIsolamento As Label
    Friend WithEvents labResistenzaIsolamentoMin As Label
    Friend WithEvents labUDMTempoRaffreddamento As Label
    Friend WithEvents labTempoRaffreddamento As Label
    Friend WithEvents labDescrTempoRaffreddamento As Label
    Friend WithEvents gbVal As GroupBox
    Friend WithEvents gbRheater As GroupBox
    Friend WithEvents gbIsolamento As GroupBox
    Friend WithEvents tpParametriRicetta3 As TabPage
    Friend WithEvents gbMisureADV As GroupBox
    Friend WithEvents chkAdvIp As CheckBox
    Friend WithEvents labUdmAdvIp As Label
    Friend WithEvents labAdvIpMax As Label
    Friend WithEvents chkAdvLambda As CheckBox
    Friend WithEvents labUdmAdvLambda As Label
    Friend WithEvents labAdvLambdaMin As Label
    Friend WithEvents labAdvLambdaMax As Label
    Friend WithEvents labAdvIpMin As Label
    Friend WithEvents gbMisureLSU As GroupBox
    Friend WithEvents labResistenzaCalibrazioneMin As Label
    Friend WithEvents labTempOperativaMax As Label
    Friend WithEvents labUdmTargetO2 As Label
    Friend WithEvents labTargetO2 As Label
    Friend WithEvents labDescrTargetO2 As Label
    Friend WithEvents labDescrFlussoN2 As Label
    Friend WithEvents chkResistenzaCalibrazione As CheckBox
    Friend WithEvents labUDMResistenzaCalibrazione As Label
    Friend WithEvents labResistenzaCalibrazioneMax As Label
    Friend WithEvents chkO2 As CheckBox
    Friend WithEvents labUDMTempOperativa As Label
    Friend WithEvents labTempOperativaMin As Label
    Friend WithEvents chkTemperaturaOperativa As CheckBox
    Friend WithEvents labO2Max As Label
    Friend WithEvents labUDMO2 As Label
    Friend WithEvents labO2Min As Label
    Friend WithEvents labUDMFlussoN2 As Label
    Friend WithEvents labFlussoN2 As Label
    Friend WithEvents labUDMFlussoAria As Label
    Friend WithEvents labFlussoAria As Label
    Friend WithEvents labDescrFlussoAria As Label
    Friend WithEvents gbIheater As GroupBox
    Friend WithEvents labCorrenteRiscaldatoreMax As Label
    Friend WithEvents chkCorrenteRiscaldatore As CheckBox
    Friend WithEvents labUDMCorrenteRiscaldatore As Label
    Friend WithEvents labCorrenteRiscaldatoreMin As Label
    Friend WithEvents gbMisureZFAS As GroupBox
    Friend WithEvents chkZfasIpTb As CheckBox
    Friend WithEvents labUdmZfasIpTb As Label
    Friend WithEvents chkZfasIpEtas As CheckBox
    Friend WithEvents labZfasIpTbMin As Label
    Friend WithEvents labUdmZfasIpEtas As Label
    Friend WithEvents labZfasIpTbMax As Label
    Friend WithEvents labZfasIpEtasMin As Label
    Friend WithEvents labZfasIpEtasMax As Label
    Friend WithEvents cbTipologia As ComboBox
    Friend WithEvents labDescrTipologia As Label
    Friend WithEvents gbRiscaldamentoRaffreddamento As GroupBox
    Friend WithEvents labUDMTempoRiscaldamento As Label
    Friend WithEvents labTempoRiscaldamento As Label
    Friend WithEvents labDescrTempoRiscaldamento As Label
End Class

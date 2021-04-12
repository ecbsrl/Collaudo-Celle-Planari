<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollaudo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollaudo))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnCicloMaster = New System.Windows.Forms.Button()
        Me.btnRipassoScarti = New System.Windows.Forms.Button()
        Me.gbStatoMacchina = New System.Windows.Forms.GroupBox()
        Me.labFase = New System.Windows.Forms.Label()
        Me.tmrMonitor = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCiclo = New System.Windows.Forms.Timer(Me.components)
        Me.labTotalePezzi = New System.Windows.Forms.Label()
        Me.labTotaleScarti = New System.Windows.Forms.Label()
        Me.labTotaleBuoni = New System.Windows.Forms.Label()
        Me.labPercentualeBuoni = New System.Windows.Forms.Label()
        Me.labPercentualeScarti = New System.Windows.Forms.Label()
        Me.labBuoniLotto = New System.Windows.Forms.Label()
        Me.labPezziLotto = New System.Windows.Forms.Label()
        Me.labScartiLotto = New System.Windows.Forms.Label()
        Me.labPercentualeBuoniLotto = New System.Windows.Forms.Label()
        Me.labPercentualeScartiLotto = New System.Windows.Forms.Label()
        Me.labDescrContatoriLotto = New System.Windows.Forms.Label()
        Me.labDescrContatoriSessione = New System.Windows.Forms.Label()
        Me.labBuoniSessione = New System.Windows.Forms.Label()
        Me.labPezziSessione = New System.Windows.Forms.Label()
        Me.labScartiSessione = New System.Windows.Forms.Label()
        Me.labPercentualeBuoniSessione = New System.Windows.Forms.Label()
        Me.labPercentualeScartiSessione = New System.Windows.Forms.Label()
        Me.gbContatori = New System.Windows.Forms.GroupBox()
        Me.labDescrNomeLotto = New System.Windows.Forms.Label()
        Me.labDescrNumeroOrdine = New System.Windows.Forms.Label()
        Me.labDescrDataOraCreazione = New System.Windows.Forms.Label()
        Me.labDescrNomeRicetta = New System.Windows.Forms.Label()
        Me.labDescrNomeRicettaMaster = New System.Windows.Forms.Label()
        Me.labDataOraCreazione = New System.Windows.Forms.Label()
        Me.labNomeLotto = New System.Windows.Forms.Label()
        Me.labNumeroOrdine = New System.Windows.Forms.Label()
        Me.labNomeRicetta = New System.Windows.Forms.Label()
        Me.labNomeRicettaMaster = New System.Windows.Forms.Label()
        Me.labDescrCodiceAttrezzatura = New System.Windows.Forms.Label()
        Me.labCodiceAttrezzatura = New System.Windows.Forms.Label()
        Me.gbInformazioni = New System.Windows.Forms.GroupBox()
        Me.labEsito = New System.Windows.Forms.Label()
        Me.dgvRisultati = New System.Windows.Forms.DataGridView()
        Me.chrtGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnCicloManuale = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chrtGrafico2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ssBarraStato = New System.Windows.Forms.StatusStrip()
        Me.btnRisultati = New System.Windows.Forms.Button()
        Me.gbStatoMacchina.SuspendLayout()
        Me.gbContatori.SuspendLayout()
        Me.gbInformazioni.SuspendLayout()
        CType(Me.dgvRisultati, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtGrafico2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCicloMaster
        '
        Me.btnCicloMaster.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCicloMaster.Image = CType(resources.GetObject("btnCicloMaster.Image"), System.Drawing.Image)
        Me.btnCicloMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCicloMaster.Location = New System.Drawing.Point(10, 874)
        Me.btnCicloMaster.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCicloMaster.Name = "btnCicloMaster"
        Me.btnCicloMaster.Size = New System.Drawing.Size(90, 90)
        Me.btnCicloMaster.TabIndex = 5
        Me.btnCicloMaster.Text = "Ciclo master"
        Me.btnCicloMaster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCicloMaster.UseVisualStyleBackColor = True
        '
        'btnRipassoScarti
        '
        Me.btnRipassoScarti.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRipassoScarti.Image = CType(resources.GetObject("btnRipassoScarti.Image"), System.Drawing.Image)
        Me.btnRipassoScarti.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRipassoScarti.Location = New System.Drawing.Point(110, 874)
        Me.btnRipassoScarti.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRipassoScarti.Name = "btnRipassoScarti"
        Me.btnRipassoScarti.Size = New System.Drawing.Size(90, 90)
        Me.btnRipassoScarti.TabIndex = 6
        Me.btnRipassoScarti.Text = "Ripasso scarti"
        Me.btnRipassoScarti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRipassoScarti.UseVisualStyleBackColor = True
        '
        'gbStatoMacchina
        '
        Me.gbStatoMacchina.Controls.Add(Me.labFase)
        Me.gbStatoMacchina.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStatoMacchina.Location = New System.Drawing.Point(410, 867)
        Me.gbStatoMacchina.Margin = New System.Windows.Forms.Padding(5)
        Me.gbStatoMacchina.Name = "gbStatoMacchina"
        Me.gbStatoMacchina.Padding = New System.Windows.Forms.Padding(5)
        Me.gbStatoMacchina.Size = New System.Drawing.Size(740, 97)
        Me.gbStatoMacchina.TabIndex = 8
        Me.gbStatoMacchina.TabStop = False
        Me.gbStatoMacchina.Text = "Stato della macchina"
        '
        'labFase
        '
        Me.labFase.BackColor = System.Drawing.Color.White
        Me.labFase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFase.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labFase.Location = New System.Drawing.Point(10, 21)
        Me.labFase.Margin = New System.Windows.Forms.Padding(5)
        Me.labFase.Name = "labFase"
        Me.labFase.Size = New System.Drawing.Size(720, 62)
        Me.labFase.TabIndex = 0
        Me.labFase.Text = "???"
        Me.labFase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrMonitor
        '
        Me.tmrMonitor.Interval = 250
        '
        'tmrCiclo
        '
        Me.tmrCiclo.Interval = 250
        '
        'labTotalePezzi
        '
        Me.labTotalePezzi.Location = New System.Drawing.Point(8, 47)
        Me.labTotalePezzi.Margin = New System.Windows.Forms.Padding(3)
        Me.labTotalePezzi.Name = "labTotalePezzi"
        Me.labTotalePezzi.Size = New System.Drawing.Size(110, 20)
        Me.labTotalePezzi.TabIndex = 2
        Me.labTotalePezzi.Text = "Pezzi collaudati"
        Me.labTotalePezzi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTotaleScarti
        '
        Me.labTotaleScarti.Location = New System.Drawing.Point(8, 99)
        Me.labTotaleScarti.Margin = New System.Windows.Forms.Padding(3)
        Me.labTotaleScarti.Name = "labTotaleScarti"
        Me.labTotaleScarti.Size = New System.Drawing.Size(110, 20)
        Me.labTotaleScarti.TabIndex = 8
        Me.labTotaleScarti.Text = "Pezzi scarto"
        Me.labTotaleScarti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTotaleBuoni
        '
        Me.labTotaleBuoni.Location = New System.Drawing.Point(8, 73)
        Me.labTotaleBuoni.Margin = New System.Windows.Forms.Padding(3)
        Me.labTotaleBuoni.Name = "labTotaleBuoni"
        Me.labTotaleBuoni.Size = New System.Drawing.Size(110, 20)
        Me.labTotaleBuoni.TabIndex = 5
        Me.labTotaleBuoni.Text = "Pezzi buoni"
        Me.labTotaleBuoni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPercentualeBuoni
        '
        Me.labPercentualeBuoni.Location = New System.Drawing.Point(8, 126)
        Me.labPercentualeBuoni.Margin = New System.Windows.Forms.Padding(3)
        Me.labPercentualeBuoni.Name = "labPercentualeBuoni"
        Me.labPercentualeBuoni.Size = New System.Drawing.Size(110, 20)
        Me.labPercentualeBuoni.TabIndex = 11
        Me.labPercentualeBuoni.Text = "% pezzi buoni"
        Me.labPercentualeBuoni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPercentualeScarti
        '
        Me.labPercentualeScarti.Location = New System.Drawing.Point(8, 151)
        Me.labPercentualeScarti.Margin = New System.Windows.Forms.Padding(3)
        Me.labPercentualeScarti.Name = "labPercentualeScarti"
        Me.labPercentualeScarti.Size = New System.Drawing.Size(110, 20)
        Me.labPercentualeScarti.TabIndex = 14
        Me.labPercentualeScarti.Text = "% pezzi scarto"
        Me.labPercentualeScarti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labBuoniLotto
        '
        Me.labBuoniLotto.BackColor = System.Drawing.Color.Lime
        Me.labBuoniLotto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labBuoniLotto.Location = New System.Drawing.Point(150, 73)
        Me.labBuoniLotto.Margin = New System.Windows.Forms.Padding(3)
        Me.labBuoniLotto.Name = "labBuoniLotto"
        Me.labBuoniLotto.Size = New System.Drawing.Size(100, 20)
        Me.labBuoniLotto.TabIndex = 6
        Me.labBuoniLotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPezziLotto
        '
        Me.labPezziLotto.BackColor = System.Drawing.Color.White
        Me.labPezziLotto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPezziLotto.Location = New System.Drawing.Point(150, 47)
        Me.labPezziLotto.Margin = New System.Windows.Forms.Padding(3)
        Me.labPezziLotto.Name = "labPezziLotto"
        Me.labPezziLotto.Size = New System.Drawing.Size(100, 20)
        Me.labPezziLotto.TabIndex = 3
        Me.labPezziLotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labScartiLotto
        '
        Me.labScartiLotto.BackColor = System.Drawing.Color.Red
        Me.labScartiLotto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labScartiLotto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labScartiLotto.Location = New System.Drawing.Point(150, 99)
        Me.labScartiLotto.Margin = New System.Windows.Forms.Padding(3)
        Me.labScartiLotto.Name = "labScartiLotto"
        Me.labScartiLotto.Size = New System.Drawing.Size(100, 20)
        Me.labScartiLotto.TabIndex = 9
        Me.labScartiLotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPercentualeBuoniLotto
        '
        Me.labPercentualeBuoniLotto.BackColor = System.Drawing.Color.Lime
        Me.labPercentualeBuoniLotto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPercentualeBuoniLotto.Location = New System.Drawing.Point(150, 125)
        Me.labPercentualeBuoniLotto.Margin = New System.Windows.Forms.Padding(3)
        Me.labPercentualeBuoniLotto.Name = "labPercentualeBuoniLotto"
        Me.labPercentualeBuoniLotto.Size = New System.Drawing.Size(100, 20)
        Me.labPercentualeBuoniLotto.TabIndex = 12
        Me.labPercentualeBuoniLotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPercentualeScartiLotto
        '
        Me.labPercentualeScartiLotto.BackColor = System.Drawing.Color.Red
        Me.labPercentualeScartiLotto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPercentualeScartiLotto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labPercentualeScartiLotto.Location = New System.Drawing.Point(150, 151)
        Me.labPercentualeScartiLotto.Margin = New System.Windows.Forms.Padding(3)
        Me.labPercentualeScartiLotto.Name = "labPercentualeScartiLotto"
        Me.labPercentualeScartiLotto.Size = New System.Drawing.Size(100, 20)
        Me.labPercentualeScartiLotto.TabIndex = 15
        Me.labPercentualeScartiLotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrContatoriLotto
        '
        Me.labDescrContatoriLotto.Location = New System.Drawing.Point(150, 21)
        Me.labDescrContatoriLotto.Margin = New System.Windows.Forms.Padding(3)
        Me.labDescrContatoriLotto.Name = "labDescrContatoriLotto"
        Me.labDescrContatoriLotto.Size = New System.Drawing.Size(100, 20)
        Me.labDescrContatoriLotto.TabIndex = 0
        Me.labDescrContatoriLotto.Text = "Lotto"
        Me.labDescrContatoriLotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrContatoriSessione
        '
        Me.labDescrContatoriSessione.Location = New System.Drawing.Point(280, 21)
        Me.labDescrContatoriSessione.Margin = New System.Windows.Forms.Padding(3)
        Me.labDescrContatoriSessione.Name = "labDescrContatoriSessione"
        Me.labDescrContatoriSessione.Size = New System.Drawing.Size(100, 20)
        Me.labDescrContatoriSessione.TabIndex = 1
        Me.labDescrContatoriSessione.Text = "Sessione"
        Me.labDescrContatoriSessione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labBuoniSessione
        '
        Me.labBuoniSessione.BackColor = System.Drawing.Color.Lime
        Me.labBuoniSessione.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labBuoniSessione.Location = New System.Drawing.Point(280, 74)
        Me.labBuoniSessione.Margin = New System.Windows.Forms.Padding(3)
        Me.labBuoniSessione.Name = "labBuoniSessione"
        Me.labBuoniSessione.Size = New System.Drawing.Size(100, 20)
        Me.labBuoniSessione.TabIndex = 7
        Me.labBuoniSessione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPezziSessione
        '
        Me.labPezziSessione.BackColor = System.Drawing.Color.White
        Me.labPezziSessione.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPezziSessione.Location = New System.Drawing.Point(280, 47)
        Me.labPezziSessione.Margin = New System.Windows.Forms.Padding(3)
        Me.labPezziSessione.Name = "labPezziSessione"
        Me.labPezziSessione.Size = New System.Drawing.Size(100, 20)
        Me.labPezziSessione.TabIndex = 4
        Me.labPezziSessione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labScartiSessione
        '
        Me.labScartiSessione.BackColor = System.Drawing.Color.Red
        Me.labScartiSessione.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labScartiSessione.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labScartiSessione.Location = New System.Drawing.Point(280, 100)
        Me.labScartiSessione.Margin = New System.Windows.Forms.Padding(3)
        Me.labScartiSessione.Name = "labScartiSessione"
        Me.labScartiSessione.Size = New System.Drawing.Size(100, 20)
        Me.labScartiSessione.TabIndex = 10
        Me.labScartiSessione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPercentualeBuoniSessione
        '
        Me.labPercentualeBuoniSessione.BackColor = System.Drawing.Color.Lime
        Me.labPercentualeBuoniSessione.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPercentualeBuoniSessione.Location = New System.Drawing.Point(280, 126)
        Me.labPercentualeBuoniSessione.Margin = New System.Windows.Forms.Padding(3)
        Me.labPercentualeBuoniSessione.Name = "labPercentualeBuoniSessione"
        Me.labPercentualeBuoniSessione.Size = New System.Drawing.Size(100, 20)
        Me.labPercentualeBuoniSessione.TabIndex = 13
        Me.labPercentualeBuoniSessione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPercentualeScartiSessione
        '
        Me.labPercentualeScartiSessione.BackColor = System.Drawing.Color.Red
        Me.labPercentualeScartiSessione.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPercentualeScartiSessione.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labPercentualeScartiSessione.Location = New System.Drawing.Point(280, 152)
        Me.labPercentualeScartiSessione.Margin = New System.Windows.Forms.Padding(3)
        Me.labPercentualeScartiSessione.Name = "labPercentualeScartiSessione"
        Me.labPercentualeScartiSessione.Size = New System.Drawing.Size(100, 20)
        Me.labPercentualeScartiSessione.TabIndex = 16
        Me.labPercentualeScartiSessione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbContatori
        '
        Me.gbContatori.Controls.Add(Me.labPercentualeScartiSessione)
        Me.gbContatori.Controls.Add(Me.labPercentualeBuoniSessione)
        Me.gbContatori.Controls.Add(Me.labScartiSessione)
        Me.gbContatori.Controls.Add(Me.labPezziSessione)
        Me.gbContatori.Controls.Add(Me.labBuoniSessione)
        Me.gbContatori.Controls.Add(Me.labDescrContatoriSessione)
        Me.gbContatori.Controls.Add(Me.labDescrContatoriLotto)
        Me.gbContatori.Controls.Add(Me.labPercentualeScartiLotto)
        Me.gbContatori.Controls.Add(Me.labPercentualeBuoniLotto)
        Me.gbContatori.Controls.Add(Me.labScartiLotto)
        Me.gbContatori.Controls.Add(Me.labPezziLotto)
        Me.gbContatori.Controls.Add(Me.labBuoniLotto)
        Me.gbContatori.Controls.Add(Me.labPercentualeScarti)
        Me.gbContatori.Controls.Add(Me.labPercentualeBuoni)
        Me.gbContatori.Controls.Add(Me.labTotaleBuoni)
        Me.gbContatori.Controls.Add(Me.labTotaleScarti)
        Me.gbContatori.Controls.Add(Me.labTotalePezzi)
        Me.gbContatori.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbContatori.Location = New System.Drawing.Point(860, 642)
        Me.gbContatori.Margin = New System.Windows.Forms.Padding(5)
        Me.gbContatori.Name = "gbContatori"
        Me.gbContatori.Size = New System.Drawing.Size(395, 184)
        Me.gbContatori.TabIndex = 4
        Me.gbContatori.TabStop = False
        Me.gbContatori.Text = "Contatori"
        '
        'labDescrNomeLotto
        '
        Me.labDescrNomeLotto.Location = New System.Drawing.Point(10, 21)
        Me.labDescrNomeLotto.Margin = New System.Windows.Forms.Padding(3)
        Me.labDescrNomeLotto.Name = "labDescrNomeLotto"
        Me.labDescrNomeLotto.Size = New System.Drawing.Size(180, 20)
        Me.labDescrNomeLotto.TabIndex = 0
        Me.labDescrNomeLotto.Text = "Nome lotto"
        Me.labDescrNomeLotto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDescrNumeroOrdine
        '
        Me.labDescrNumeroOrdine.Location = New System.Drawing.Point(10, 72)
        Me.labDescrNumeroOrdine.Margin = New System.Windows.Forms.Padding(3)
        Me.labDescrNumeroOrdine.Name = "labDescrNumeroOrdine"
        Me.labDescrNumeroOrdine.Size = New System.Drawing.Size(180, 20)
        Me.labDescrNumeroOrdine.TabIndex = 4
        Me.labDescrNumeroOrdine.Text = "Numero d'ordine"
        Me.labDescrNumeroOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDescrDataOraCreazione
        '
        Me.labDescrDataOraCreazione.Location = New System.Drawing.Point(10, 47)
        Me.labDescrDataOraCreazione.Margin = New System.Windows.Forms.Padding(3)
        Me.labDescrDataOraCreazione.Name = "labDescrDataOraCreazione"
        Me.labDescrDataOraCreazione.Size = New System.Drawing.Size(180, 20)
        Me.labDescrDataOraCreazione.TabIndex = 2
        Me.labDescrDataOraCreazione.Text = "Data e ora di creazione"
        Me.labDescrDataOraCreazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDescrNomeRicetta
        '
        Me.labDescrNomeRicetta.Location = New System.Drawing.Point(10, 98)
        Me.labDescrNomeRicetta.Margin = New System.Windows.Forms.Padding(3)
        Me.labDescrNomeRicetta.Name = "labDescrNomeRicetta"
        Me.labDescrNomeRicetta.Size = New System.Drawing.Size(180, 20)
        Me.labDescrNomeRicetta.TabIndex = 6
        Me.labDescrNomeRicetta.Text = "Nome ricetta"
        Me.labDescrNomeRicetta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDescrNomeRicettaMaster
        '
        Me.labDescrNomeRicettaMaster.Location = New System.Drawing.Point(10, 124)
        Me.labDescrNomeRicettaMaster.Margin = New System.Windows.Forms.Padding(3)
        Me.labDescrNomeRicettaMaster.Name = "labDescrNomeRicettaMaster"
        Me.labDescrNomeRicettaMaster.Size = New System.Drawing.Size(180, 20)
        Me.labDescrNomeRicettaMaster.TabIndex = 8
        Me.labDescrNomeRicettaMaster.Text = "Nome ricetta master"
        Me.labDescrNomeRicettaMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDataOraCreazione
        '
        Me.labDataOraCreazione.BackColor = System.Drawing.Color.White
        Me.labDataOraCreazione.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDataOraCreazione.Location = New System.Drawing.Point(175, 46)
        Me.labDataOraCreazione.Margin = New System.Windows.Forms.Padding(3)
        Me.labDataOraCreazione.Name = "labDataOraCreazione"
        Me.labDataOraCreazione.Size = New System.Drawing.Size(210, 20)
        Me.labDataOraCreazione.TabIndex = 3
        Me.labDataOraCreazione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labNomeLotto
        '
        Me.labNomeLotto.BackColor = System.Drawing.Color.White
        Me.labNomeLotto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNomeLotto.Location = New System.Drawing.Point(175, 21)
        Me.labNomeLotto.Margin = New System.Windows.Forms.Padding(3)
        Me.labNomeLotto.Name = "labNomeLotto"
        Me.labNomeLotto.Size = New System.Drawing.Size(210, 20)
        Me.labNomeLotto.TabIndex = 1
        Me.labNomeLotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labNumeroOrdine
        '
        Me.labNumeroOrdine.BackColor = System.Drawing.Color.White
        Me.labNumeroOrdine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroOrdine.Location = New System.Drawing.Point(175, 72)
        Me.labNumeroOrdine.Margin = New System.Windows.Forms.Padding(3)
        Me.labNumeroOrdine.Name = "labNumeroOrdine"
        Me.labNumeroOrdine.Size = New System.Drawing.Size(210, 20)
        Me.labNumeroOrdine.TabIndex = 5
        Me.labNumeroOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labNomeRicetta
        '
        Me.labNomeRicetta.BackColor = System.Drawing.Color.White
        Me.labNomeRicetta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNomeRicetta.Location = New System.Drawing.Point(175, 98)
        Me.labNomeRicetta.Margin = New System.Windows.Forms.Padding(3)
        Me.labNomeRicetta.Name = "labNomeRicetta"
        Me.labNomeRicetta.Size = New System.Drawing.Size(210, 20)
        Me.labNomeRicetta.TabIndex = 7
        Me.labNomeRicetta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labNomeRicettaMaster
        '
        Me.labNomeRicettaMaster.BackColor = System.Drawing.Color.White
        Me.labNomeRicettaMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNomeRicettaMaster.Location = New System.Drawing.Point(175, 124)
        Me.labNomeRicettaMaster.Margin = New System.Windows.Forms.Padding(3)
        Me.labNomeRicettaMaster.Name = "labNomeRicettaMaster"
        Me.labNomeRicettaMaster.Size = New System.Drawing.Size(210, 20)
        Me.labNomeRicettaMaster.TabIndex = 9
        Me.labNomeRicettaMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDescrCodiceAttrezzatura
        '
        Me.labDescrCodiceAttrezzatura.Location = New System.Drawing.Point(10, 150)
        Me.labDescrCodiceAttrezzatura.Margin = New System.Windows.Forms.Padding(3)
        Me.labDescrCodiceAttrezzatura.Name = "labDescrCodiceAttrezzatura"
        Me.labDescrCodiceAttrezzatura.Size = New System.Drawing.Size(180, 20)
        Me.labDescrCodiceAttrezzatura.TabIndex = 10
        Me.labDescrCodiceAttrezzatura.Text = "Codice attrezzatura"
        Me.labDescrCodiceAttrezzatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labCodiceAttrezzatura
        '
        Me.labCodiceAttrezzatura.BackColor = System.Drawing.Color.White
        Me.labCodiceAttrezzatura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCodiceAttrezzatura.Location = New System.Drawing.Point(175, 150)
        Me.labCodiceAttrezzatura.Margin = New System.Windows.Forms.Padding(3)
        Me.labCodiceAttrezzatura.Name = "labCodiceAttrezzatura"
        Me.labCodiceAttrezzatura.Size = New System.Drawing.Size(210, 20)
        Me.labCodiceAttrezzatura.TabIndex = 11
        Me.labCodiceAttrezzatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbInformazioni
        '
        Me.gbInformazioni.Controls.Add(Me.labCodiceAttrezzatura)
        Me.gbInformazioni.Controls.Add(Me.labDescrCodiceAttrezzatura)
        Me.gbInformazioni.Controls.Add(Me.labNomeRicettaMaster)
        Me.gbInformazioni.Controls.Add(Me.labNomeRicetta)
        Me.gbInformazioni.Controls.Add(Me.labNumeroOrdine)
        Me.gbInformazioni.Controls.Add(Me.labNomeLotto)
        Me.gbInformazioni.Controls.Add(Me.labDataOraCreazione)
        Me.gbInformazioni.Controls.Add(Me.labDescrNomeRicettaMaster)
        Me.gbInformazioni.Controls.Add(Me.labDescrNomeRicetta)
        Me.gbInformazioni.Controls.Add(Me.labDescrDataOraCreazione)
        Me.gbInformazioni.Controls.Add(Me.labDescrNumeroOrdine)
        Me.gbInformazioni.Controls.Add(Me.labDescrNomeLotto)
        Me.gbInformazioni.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformazioni.Location = New System.Drawing.Point(10, 642)
        Me.gbInformazioni.Margin = New System.Windows.Forms.Padding(5)
        Me.gbInformazioni.Name = "gbInformazioni"
        Me.gbInformazioni.Size = New System.Drawing.Size(400, 184)
        Me.gbInformazioni.TabIndex = 2
        Me.gbInformazioni.TabStop = False
        Me.gbInformazioni.Text = "Informazioni"
        '
        'labEsito
        '
        Me.labEsito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEsito.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEsito.Location = New System.Drawing.Point(416, 649)
        Me.labEsito.Name = "labEsito"
        Me.labEsito.Size = New System.Drawing.Size(436, 176)
        Me.labEsito.TabIndex = 3
        Me.labEsito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvRisultati
        '
        Me.dgvRisultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRisultati.Location = New System.Drawing.Point(10, 35)
        Me.dgvRisultati.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvRisultati.Name = "dgvRisultati"
        Me.dgvRisultati.Size = New System.Drawing.Size(620, 565)
        Me.dgvRisultati.TabIndex = 0
        '
        'chrtGrafico
        '
        Me.chrtGrafico.BorderlineColor = System.Drawing.Color.Black
        Me.chrtGrafico.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.Name = "ChartArea1"
        Me.chrtGrafico.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtGrafico.Legends.Add(Legend1)
        Me.chrtGrafico.Location = New System.Drawing.Point(821, 35)
        Me.chrtGrafico.Margin = New System.Windows.Forms.Padding(5)
        Me.chrtGrafico.Name = "chrtGrafico"
        Me.chrtGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chrtGrafico.Series.Add(Series1)
        Me.chrtGrafico.Size = New System.Drawing.Size(434, 270)
        Me.chrtGrafico.TabIndex = 1
        Me.chrtGrafico.Text = "Chart1"
        '
        'btnCicloManuale
        '
        Me.btnCicloManuale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCicloManuale.Image = CType(resources.GetObject("btnCicloManuale.Image"), System.Drawing.Image)
        Me.btnCicloManuale.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCicloManuale.Location = New System.Drawing.Point(210, 874)
        Me.btnCicloManuale.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCicloManuale.Name = "btnCicloManuale"
        Me.btnCicloManuale.Size = New System.Drawing.Size(90, 90)
        Me.btnCicloManuale.TabIndex = 7
        Me.btnCicloManuale.Text = "Ciclo manuale"
        Me.btnCicloManuale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCicloManuale.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(1160, 874)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 90)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Uscita"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(715, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Grafico Lotto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(684, 454)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Grafico Sessione"
        '
        'chrtGrafico2
        '
        Me.chrtGrafico2.BorderlineColor = System.Drawing.Color.Black
        Me.chrtGrafico2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.Name = "ChartArea1"
        Me.chrtGrafico2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chrtGrafico2.Legends.Add(Legend2)
        Me.chrtGrafico2.Location = New System.Drawing.Point(821, 330)
        Me.chrtGrafico2.Margin = New System.Windows.Forms.Padding(5)
        Me.chrtGrafico2.Name = "chrtGrafico2"
        Me.chrtGrafico2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chrtGrafico2.Series.Add(Series2)
        Me.chrtGrafico2.Size = New System.Drawing.Size(434, 270)
        Me.chrtGrafico2.TabIndex = 1
        Me.chrtGrafico2.Text = "Chart1"
        '
        'ssBarraStato
        '
        Me.ssBarraStato.AutoSize = False
        Me.ssBarraStato.BackColor = System.Drawing.Color.White
        Me.ssBarraStato.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssBarraStato.Location = New System.Drawing.Point(0, 980)
        Me.ssBarraStato.Margin = New System.Windows.Forms.Padding(5)
        Me.ssBarraStato.Name = "ssBarraStato"
        Me.ssBarraStato.Size = New System.Drawing.Size(1264, 26)
        Me.ssBarraStato.TabIndex = 11
        Me.ssBarraStato.Text = "StatusStrip1"
        '
        'btnRisultati
        '
        Me.btnRisultati.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRisultati.Image = CType(resources.GetObject("btnRisultati.Image"), System.Drawing.Image)
        Me.btnRisultati.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRisultati.Location = New System.Drawing.Point(310, 874)
        Me.btnRisultati.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRisultati.Name = "btnRisultati"
        Me.btnRisultati.Size = New System.Drawing.Size(90, 90)
        Me.btnRisultati.TabIndex = 12
        Me.btnRisultati.Text = "Risultati"
        Me.btnRisultati.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRisultati.UseVisualStyleBackColor = True
        '
        'frmCollaudo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 1006)
        Me.Controls.Add(Me.btnRisultati)
        Me.Controls.Add(Me.ssBarraStato)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCicloManuale)
        Me.Controls.Add(Me.chrtGrafico2)
        Me.Controls.Add(Me.chrtGrafico)
        Me.Controls.Add(Me.gbInformazioni)
        Me.Controls.Add(Me.dgvRisultati)
        Me.Controls.Add(Me.labEsito)
        Me.Controls.Add(Me.gbContatori)
        Me.Controls.Add(Me.gbStatoMacchina)
        Me.Controls.Add(Me.btnRipassoScarti)
        Me.Controls.Add(Me.btnCicloMaster)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCollaudo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collaudo"
        Me.gbStatoMacchina.ResumeLayout(False)
        Me.gbContatori.ResumeLayout(False)
        Me.gbInformazioni.ResumeLayout(False)
        CType(Me.dgvRisultati, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtGrafico2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCicloMaster As System.Windows.Forms.Button
    Friend WithEvents btnRipassoScarti As System.Windows.Forms.Button
    Friend WithEvents gbStatoMacchina As System.Windows.Forms.GroupBox
    Friend WithEvents labFase As System.Windows.Forms.Label
    Friend WithEvents tmrMonitor As System.Windows.Forms.Timer
    Friend WithEvents tmrCiclo As System.Windows.Forms.Timer
    Friend WithEvents labTotalePezzi As System.Windows.Forms.Label
    Friend WithEvents labTotaleScarti As System.Windows.Forms.Label
    Friend WithEvents labTotaleBuoni As System.Windows.Forms.Label
    Friend WithEvents labPercentualeBuoni As System.Windows.Forms.Label
    Friend WithEvents labPercentualeScarti As System.Windows.Forms.Label
    Friend WithEvents labBuoniLotto As System.Windows.Forms.Label
    Friend WithEvents labPezziLotto As System.Windows.Forms.Label
    Friend WithEvents labScartiLotto As System.Windows.Forms.Label
    Friend WithEvents labPercentualeBuoniLotto As System.Windows.Forms.Label
    Friend WithEvents labPercentualeScartiLotto As System.Windows.Forms.Label
    Friend WithEvents labDescrContatoriLotto As System.Windows.Forms.Label
    Friend WithEvents labDescrContatoriSessione As System.Windows.Forms.Label
    Friend WithEvents labBuoniSessione As System.Windows.Forms.Label
    Friend WithEvents labPezziSessione As System.Windows.Forms.Label
    Friend WithEvents labScartiSessione As System.Windows.Forms.Label
    Friend WithEvents labPercentualeBuoniSessione As System.Windows.Forms.Label
    Friend WithEvents labPercentualeScartiSessione As System.Windows.Forms.Label
    Friend WithEvents gbContatori As System.Windows.Forms.GroupBox
    Friend WithEvents labDescrNomeLotto As System.Windows.Forms.Label
    Friend WithEvents labDescrNumeroOrdine As System.Windows.Forms.Label
    Friend WithEvents labDescrDataOraCreazione As System.Windows.Forms.Label
    Friend WithEvents labDescrNomeRicetta As System.Windows.Forms.Label
    Friend WithEvents labDescrNomeRicettaMaster As System.Windows.Forms.Label
    Friend WithEvents labDataOraCreazione As System.Windows.Forms.Label
    Friend WithEvents labNomeLotto As System.Windows.Forms.Label
    Friend WithEvents labNumeroOrdine As System.Windows.Forms.Label
    Friend WithEvents labNomeRicetta As System.Windows.Forms.Label
    Friend WithEvents labNomeRicettaMaster As System.Windows.Forms.Label
    Friend WithEvents labDescrCodiceAttrezzatura As System.Windows.Forms.Label
    Friend WithEvents labCodiceAttrezzatura As System.Windows.Forms.Label
    Friend WithEvents gbInformazioni As System.Windows.Forms.GroupBox
    Friend WithEvents labEsito As System.Windows.Forms.Label
    Friend WithEvents dgvRisultati As System.Windows.Forms.DataGridView
    Friend WithEvents chrtGrafico As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnCicloManuale As System.Windows.Forms.Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chrtGrafico2 As DataVisualization.Charting.Chart
    Friend WithEvents ssBarraStato As StatusStrip
    Friend WithEvents btnRisultati As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipale))
        Me.tmrBarraStato = New System.Windows.Forms.Timer(Me.components)
        Me.btnRicette = New System.Windows.Forms.Button()
        Me.btnLotti = New System.Windows.Forms.Button()
        Me.btnCollaudo = New System.Windows.Forms.Button()
        Me.btnRisultati = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnDesktop = New System.Windows.Forms.Button()
        Me.btnUscita = New System.Windows.Forms.Button()
        Me.btnArrestoPC = New System.Windows.Forms.Button()
        Me.msMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ImpostazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostazioniGeneraliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostazioniAvanzateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaPassword1LivelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaPassword2LivelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvanzateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitorHardwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaratureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaraturaMisuraValToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaraturaMisuraRheaterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaraturaMisuraO2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaraturaMisuraN2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificaTaraturaO2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificaTaraturaCorrenteRiscaldatoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaraturaMisuraIsolamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTaraturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AggiornamentoDataTaraturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CicliTotaliMacchinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbSfondo = New System.Windows.Forms.PictureBox()
        Me.ssBarraStato = New System.Windows.Forms.StatusStrip()
        Me.btnArchivio = New System.Windows.Forms.Button()
        Me.btnF7 = New System.Windows.Forms.Button()
        Me.labF1 = New System.Windows.Forms.Label()
        Me.labF2 = New System.Windows.Forms.Label()
        Me.labF3 = New System.Windows.Forms.Label()
        Me.labF4 = New System.Windows.Forms.Label()
        Me.labF5 = New System.Windows.Forms.Label()
        Me.labF6 = New System.Windows.Forms.Label()
        Me.labF7 = New System.Windows.Forms.Label()
        Me.labF8 = New System.Windows.Forms.Label()
        Me.labF9 = New System.Windows.Forms.Label()
        Me.labF10 = New System.Windows.Forms.Label()
        Me.labF11 = New System.Windows.Forms.Label()
        Me.btnF8 = New System.Windows.Forms.Button()
        Me.labF12 = New System.Windows.Forms.Label()
        Me.btnF9 = New System.Windows.Forms.Button()
        Me.BackgroundBackup = New System.ComponentModel.BackgroundWorker()
        Me.msMenuStrip.SuspendLayout()
        CType(Me.pbSfondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrBarraStato
        '
        '
        'btnRicette
        '
        Me.btnRicette.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRicette.Image = CType(resources.GetObject("btnRicette.Image"), System.Drawing.Image)
        Me.btnRicette.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRicette.Location = New System.Drawing.Point(21, 845)
        Me.btnRicette.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRicette.Name = "btnRicette"
        Me.btnRicette.Size = New System.Drawing.Size(100, 100)
        Me.btnRicette.TabIndex = 12
        Me.btnRicette.Text = "Ricette"
        Me.btnRicette.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRicette.UseVisualStyleBackColor = True
        '
        'btnLotti
        '
        Me.btnLotti.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLotti.Image = CType(resources.GetObject("btnLotti.Image"), System.Drawing.Image)
        Me.btnLotti.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLotti.Location = New System.Drawing.Point(125, 845)
        Me.btnLotti.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLotti.Name = "btnLotti"
        Me.btnLotti.Size = New System.Drawing.Size(100, 100)
        Me.btnLotti.TabIndex = 13
        Me.btnLotti.Text = "Lotti"
        Me.btnLotti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLotti.UseVisualStyleBackColor = True
        '
        'btnCollaudo
        '
        Me.btnCollaudo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollaudo.Image = CType(resources.GetObject("btnCollaudo.Image"), System.Drawing.Image)
        Me.btnCollaudo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCollaudo.Location = New System.Drawing.Point(229, 845)
        Me.btnCollaudo.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCollaudo.Name = "btnCollaudo"
        Me.btnCollaudo.Size = New System.Drawing.Size(100, 100)
        Me.btnCollaudo.TabIndex = 14
        Me.btnCollaudo.Text = "Collaudo"
        Me.btnCollaudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCollaudo.UseVisualStyleBackColor = True
        '
        'btnRisultati
        '
        Me.btnRisultati.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRisultati.Image = CType(resources.GetObject("btnRisultati.Image"), System.Drawing.Image)
        Me.btnRisultati.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRisultati.Location = New System.Drawing.Point(333, 845)
        Me.btnRisultati.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRisultati.Name = "btnRisultati"
        Me.btnRisultati.Size = New System.Drawing.Size(100, 100)
        Me.btnRisultati.TabIndex = 15
        Me.btnRisultati.Text = "Risultati"
        Me.btnRisultati.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRisultati.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackup.Location = New System.Drawing.Point(437, 845)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(100, 100)
        Me.btnBackup.TabIndex = 16
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnDesktop
        '
        Me.btnDesktop.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesktop.Image = CType(resources.GetObject("btnDesktop.Image"), System.Drawing.Image)
        Me.btnDesktop.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDesktop.Location = New System.Drawing.Point(957, 845)
        Me.btnDesktop.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDesktop.Name = "btnDesktop"
        Me.btnDesktop.Size = New System.Drawing.Size(100, 100)
        Me.btnDesktop.TabIndex = 21
        Me.btnDesktop.Text = "Desktop"
        Me.btnDesktop.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDesktop.UseVisualStyleBackColor = True
        '
        'btnUscita
        '
        Me.btnUscita.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUscita.Image = CType(resources.GetObject("btnUscita.Image"), System.Drawing.Image)
        Me.btnUscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUscita.Location = New System.Drawing.Point(1061, 845)
        Me.btnUscita.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUscita.Name = "btnUscita"
        Me.btnUscita.Size = New System.Drawing.Size(100, 100)
        Me.btnUscita.TabIndex = 22
        Me.btnUscita.Text = "Uscita"
        Me.btnUscita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUscita.UseVisualStyleBackColor = True
        '
        'btnArrestoPC
        '
        Me.btnArrestoPC.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArrestoPC.Image = CType(resources.GetObject("btnArrestoPC.Image"), System.Drawing.Image)
        Me.btnArrestoPC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnArrestoPC.Location = New System.Drawing.Point(1165, 845)
        Me.btnArrestoPC.Margin = New System.Windows.Forms.Padding(5)
        Me.btnArrestoPC.Name = "btnArrestoPC"
        Me.btnArrestoPC.Size = New System.Drawing.Size(100, 100)
        Me.btnArrestoPC.TabIndex = 23
        Me.btnArrestoPC.Text = "Arresto PC"
        Me.btnArrestoPC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnArrestoPC.UseVisualStyleBackColor = True
        '
        'msMenuStrip
        '
        Me.msMenuStrip.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msMenuStrip.GripMargin = New System.Windows.Forms.Padding(2)
        Me.msMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpostazioniToolStripMenuItem, Me.GestionePasswordToolStripMenuItem, Me.AvanzateToolStripMenuItem, Me.TaratureToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.msMenuStrip.Location = New System.Drawing.Point(5, 5)
        Me.msMenuStrip.Name = "msMenuStrip"
        Me.msMenuStrip.Size = New System.Drawing.Size(1254, 24)
        Me.msMenuStrip.TabIndex = 10
        Me.msMenuStrip.Text = "MenuStrip"
        '
        'ImpostazioniToolStripMenuItem
        '
        Me.ImpostazioniToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpostazioniGeneraliToolStripMenuItem, Me.ImpostazioniAvanzateToolStripMenuItem})
        Me.ImpostazioniToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpostazioniToolStripMenuItem.Name = "ImpostazioniToolStripMenuItem"
        Me.ImpostazioniToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ImpostazioniToolStripMenuItem.Text = "&Impostazioni"
        '
        'ImpostazioniGeneraliToolStripMenuItem
        '
        Me.ImpostazioniGeneraliToolStripMenuItem.Name = "ImpostazioniGeneraliToolStripMenuItem"
        Me.ImpostazioniGeneraliToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ImpostazioniGeneraliToolStripMenuItem.Text = "Impostazioni generali"
        '
        'ImpostazioniAvanzateToolStripMenuItem
        '
        Me.ImpostazioniAvanzateToolStripMenuItem.Name = "ImpostazioniAvanzateToolStripMenuItem"
        Me.ImpostazioniAvanzateToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ImpostazioniAvanzateToolStripMenuItem.Text = "Impostazioni avanzate"
        '
        'GestionePasswordToolStripMenuItem
        '
        Me.GestionePasswordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ModificaPassword1LivelloToolStripMenuItem, Me.ModificaPassword2LivelloToolStripMenuItem})
        Me.GestionePasswordToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionePasswordToolStripMenuItem.Name = "GestionePasswordToolStripMenuItem"
        Me.GestionePasswordToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.GestionePasswordToolStripMenuItem.Text = "Gestione password"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.LoginToolStripMenuItem.Text = "Log&in"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.LogoutToolStripMenuItem.Text = "Log&out"
        '
        'ModificaPassword1LivelloToolStripMenuItem
        '
        Me.ModificaPassword1LivelloToolStripMenuItem.Name = "ModificaPassword1LivelloToolStripMenuItem"
        Me.ModificaPassword1LivelloToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ModificaPassword1LivelloToolStripMenuItem.Text = "Modifica password &1° livello"
        '
        'ModificaPassword2LivelloToolStripMenuItem
        '
        Me.ModificaPassword2LivelloToolStripMenuItem.Name = "ModificaPassword2LivelloToolStripMenuItem"
        Me.ModificaPassword2LivelloToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ModificaPassword2LivelloToolStripMenuItem.Text = "Modifica password &2° livello"
        '
        'AvanzateToolStripMenuItem
        '
        Me.AvanzateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonitorHardwareToolStripMenuItem})
        Me.AvanzateToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvanzateToolStripMenuItem.Name = "AvanzateToolStripMenuItem"
        Me.AvanzateToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.AvanzateToolStripMenuItem.Text = "Diagnostica"
        '
        'MonitorHardwareToolStripMenuItem
        '
        Me.MonitorHardwareToolStripMenuItem.Name = "MonitorHardwareToolStripMenuItem"
        Me.MonitorHardwareToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MonitorHardwareToolStripMenuItem.Text = "Monitor hardware"
        '
        'TaratureToolStripMenuItem
        '
        Me.TaratureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaraturaMisuraValToolStripMenuItem, Me.TaraturaMisuraRheaterToolStripMenuItem, Me.TaraturaMisuraO2ToolStripMenuItem, Me.TaraturaMisuraN2ToolStripMenuItem, Me.VerificaTaraturaO2ToolStripMenuItem, Me.VerificaTaraturaCorrenteRiscaldatoreToolStripMenuItem, Me.TaraturaMisuraIsolamentoToolStripMenuItem, Me.DataTaraturaToolStripMenuItem, Me.AggiornamentoDataTaraturaToolStripMenuItem})
        Me.TaratureToolStripMenuItem.Name = "TaratureToolStripMenuItem"
        Me.TaratureToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TaratureToolStripMenuItem.Text = "Tarature"
        '
        'TaraturaMisuraValToolStripMenuItem
        '
        Me.TaraturaMisuraValToolStripMenuItem.Name = "TaraturaMisuraValToolStripMenuItem"
        Me.TaraturaMisuraValToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.TaraturaMisuraValToolStripMenuItem.Text = "Verifica Taratura Tensione Alimentazione"
        '
        'TaraturaMisuraRheaterToolStripMenuItem
        '
        Me.TaraturaMisuraRheaterToolStripMenuItem.Name = "TaraturaMisuraRheaterToolStripMenuItem"
        Me.TaraturaMisuraRheaterToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.TaraturaMisuraRheaterToolStripMenuItem.Text = "Verifica Taratura Resistenza Riscaldatore"
        '
        'TaraturaMisuraO2ToolStripMenuItem
        '
        Me.TaraturaMisuraO2ToolStripMenuItem.Name = "TaraturaMisuraO2ToolStripMenuItem"
        Me.TaraturaMisuraO2ToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.TaraturaMisuraO2ToolStripMenuItem.Text = "Verifica Taratura Flusso Aria"
        '
        'TaraturaMisuraN2ToolStripMenuItem
        '
        Me.TaraturaMisuraN2ToolStripMenuItem.Name = "TaraturaMisuraN2ToolStripMenuItem"
        Me.TaraturaMisuraN2ToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.TaraturaMisuraN2ToolStripMenuItem.Text = "Verifica Taratura Flusso Azoto"
        '
        'VerificaTaraturaO2ToolStripMenuItem
        '
        Me.VerificaTaraturaO2ToolStripMenuItem.Name = "VerificaTaraturaO2ToolStripMenuItem"
        Me.VerificaTaraturaO2ToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.VerificaTaraturaO2ToolStripMenuItem.Text = "Verifica Taratura O2%"
        '
        'VerificaTaraturaCorrenteRiscaldatoreToolStripMenuItem
        '
        Me.VerificaTaraturaCorrenteRiscaldatoreToolStripMenuItem.Name = "VerificaTaraturaCorrenteRiscaldatoreToolStripMenuItem"
        Me.VerificaTaraturaCorrenteRiscaldatoreToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.VerificaTaraturaCorrenteRiscaldatoreToolStripMenuItem.Text = "Verifica Taratura Corrente Riscaldatore"
        '
        'TaraturaMisuraIsolamentoToolStripMenuItem
        '
        Me.TaraturaMisuraIsolamentoToolStripMenuItem.Name = "TaraturaMisuraIsolamentoToolStripMenuItem"
        Me.TaraturaMisuraIsolamentoToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.TaraturaMisuraIsolamentoToolStripMenuItem.Text = "Verifica Taratura Resistenza Isolamento"
        '
        'DataTaraturaToolStripMenuItem
        '
        Me.DataTaraturaToolStripMenuItem.Name = "DataTaraturaToolStripMenuItem"
        Me.DataTaraturaToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.DataTaraturaToolStripMenuItem.Text = "Data taratura"
        '
        'AggiornamentoDataTaraturaToolStripMenuItem
        '
        Me.AggiornamentoDataTaraturaToolStripMenuItem.Name = "AggiornamentoDataTaraturaToolStripMenuItem"
        Me.AggiornamentoDataTaraturaToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.AggiornamentoDataTaraturaToolStripMenuItem.Text = "Aggiornamento data taratura"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.CicliTotaliMacchinaToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CicliTotaliMacchinaToolStripMenuItem
        '
        Me.CicliTotaliMacchinaToolStripMenuItem.Name = "CicliTotaliMacchinaToolStripMenuItem"
        Me.CicliTotaliMacchinaToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CicliTotaliMacchinaToolStripMenuItem.Text = "Cicli Totali Macchina"
        '
        'pbSfondo
        '
        Me.pbSfondo.Image = CType(resources.GetObject("pbSfondo.Image"), System.Drawing.Image)
        Me.pbSfondo.Location = New System.Drawing.Point(5, 84)
        Me.pbSfondo.Margin = New System.Windows.Forms.Padding(5)
        Me.pbSfondo.Name = "pbSfondo"
        Me.pbSfondo.Size = New System.Drawing.Size(1254, 661)
        Me.pbSfondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSfondo.TabIndex = 11
        Me.pbSfondo.TabStop = False
        '
        'ssBarraStato
        '
        Me.ssBarraStato.AutoSize = False
        Me.ssBarraStato.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssBarraStato.Location = New System.Drawing.Point(5, 850)
        Me.ssBarraStato.Margin = New System.Windows.Forms.Padding(5)
        Me.ssBarraStato.Name = "ssBarraStato"
        Me.ssBarraStato.Size = New System.Drawing.Size(1254, 26)
        Me.ssBarraStato.TabIndex = 24
        Me.ssBarraStato.Text = "StatusStrip1"
        '
        'btnArchivio
        '
        Me.btnArchivio.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchivio.Image = CType(resources.GetObject("btnArchivio.Image"), System.Drawing.Image)
        Me.btnArchivio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnArchivio.Location = New System.Drawing.Point(541, 845)
        Me.btnArchivio.Margin = New System.Windows.Forms.Padding(5)
        Me.btnArchivio.Name = "btnArchivio"
        Me.btnArchivio.Size = New System.Drawing.Size(100, 100)
        Me.btnArchivio.TabIndex = 17
        Me.btnArchivio.Text = "Archivio"
        Me.btnArchivio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnArchivio.UseVisualStyleBackColor = True
        '
        'btnF7
        '
        Me.btnF7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF7.Location = New System.Drawing.Point(645, 845)
        Me.btnF7.Margin = New System.Windows.Forms.Padding(5)
        Me.btnF7.Name = "btnF7"
        Me.btnF7.Size = New System.Drawing.Size(100, 100)
        Me.btnF7.TabIndex = 18
        Me.btnF7.UseVisualStyleBackColor = True
        '
        'labF1
        '
        Me.labF1.BackColor = System.Drawing.Color.White
        Me.labF1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF1.Location = New System.Drawing.Point(21, 810)
        Me.labF1.Name = "labF1"
        Me.labF1.Size = New System.Drawing.Size(100, 26)
        Me.labF1.TabIndex = 0
        Me.labF1.Text = "F1"
        Me.labF1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labF2
        '
        Me.labF2.BackColor = System.Drawing.Color.White
        Me.labF2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF2.Location = New System.Drawing.Point(125, 810)
        Me.labF2.Name = "labF2"
        Me.labF2.Size = New System.Drawing.Size(100, 26)
        Me.labF2.TabIndex = 1
        Me.labF2.Text = "F2"
        Me.labF2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labF3
        '
        Me.labF3.BackColor = System.Drawing.Color.White
        Me.labF3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF3.Location = New System.Drawing.Point(229, 810)
        Me.labF3.Name = "labF3"
        Me.labF3.Size = New System.Drawing.Size(100, 26)
        Me.labF3.TabIndex = 2
        Me.labF3.Text = "F3"
        Me.labF3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labF4
        '
        Me.labF4.BackColor = System.Drawing.Color.White
        Me.labF4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF4.Location = New System.Drawing.Point(333, 810)
        Me.labF4.Name = "labF4"
        Me.labF4.Size = New System.Drawing.Size(100, 26)
        Me.labF4.TabIndex = 3
        Me.labF4.Text = "F4"
        Me.labF4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labF5
        '
        Me.labF5.BackColor = System.Drawing.Color.White
        Me.labF5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF5.Location = New System.Drawing.Point(437, 810)
        Me.labF5.Name = "labF5"
        Me.labF5.Size = New System.Drawing.Size(100, 26)
        Me.labF5.TabIndex = 4
        Me.labF5.Text = "F5"
        Me.labF5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labF6
        '
        Me.labF6.BackColor = System.Drawing.Color.White
        Me.labF6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF6.Location = New System.Drawing.Point(541, 810)
        Me.labF6.Name = "labF6"
        Me.labF6.Size = New System.Drawing.Size(100, 26)
        Me.labF6.TabIndex = 5
        Me.labF6.Text = "F6"
        Me.labF6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labF7
        '
        Me.labF7.BackColor = System.Drawing.Color.White
        Me.labF7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF7.Location = New System.Drawing.Point(645, 810)
        Me.labF7.Name = "labF7"
        Me.labF7.Size = New System.Drawing.Size(100, 26)
        Me.labF7.TabIndex = 6
        Me.labF7.Text = "F7"
        Me.labF7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labF8
        '
        Me.labF8.BackColor = System.Drawing.Color.White
        Me.labF8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF8.Location = New System.Drawing.Point(749, 810)
        Me.labF8.Name = "labF8"
        Me.labF8.Size = New System.Drawing.Size(100, 26)
        Me.labF8.TabIndex = 7
        Me.labF8.Text = "F8"
        Me.labF8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labF9
        '
        Me.labF9.BackColor = System.Drawing.Color.White
        Me.labF9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF9.Location = New System.Drawing.Point(853, 810)
        Me.labF9.Name = "labF9"
        Me.labF9.Size = New System.Drawing.Size(100, 26)
        Me.labF9.TabIndex = 8
        Me.labF9.Text = "F9"
        Me.labF9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labF10
        '
        Me.labF10.BackColor = System.Drawing.Color.White
        Me.labF10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF10.Location = New System.Drawing.Point(957, 810)
        Me.labF10.Name = "labF10"
        Me.labF10.Size = New System.Drawing.Size(100, 26)
        Me.labF10.TabIndex = 9
        Me.labF10.Text = "F10"
        Me.labF10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labF11
        '
        Me.labF11.BackColor = System.Drawing.Color.White
        Me.labF11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF11.Location = New System.Drawing.Point(1061, 810)
        Me.labF11.Name = "labF11"
        Me.labF11.Size = New System.Drawing.Size(100, 26)
        Me.labF11.TabIndex = 10
        Me.labF11.Text = "F11"
        Me.labF11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF8
        '
        Me.btnF8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF8.Location = New System.Drawing.Point(749, 845)
        Me.btnF8.Margin = New System.Windows.Forms.Padding(5)
        Me.btnF8.Name = "btnF8"
        Me.btnF8.Size = New System.Drawing.Size(100, 100)
        Me.btnF8.TabIndex = 19
        Me.btnF8.UseVisualStyleBackColor = True
        '
        'labF12
        '
        Me.labF12.BackColor = System.Drawing.Color.White
        Me.labF12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labF12.Location = New System.Drawing.Point(1165, 810)
        Me.labF12.Name = "labF12"
        Me.labF12.Size = New System.Drawing.Size(100, 26)
        Me.labF12.TabIndex = 11
        Me.labF12.Text = "F12"
        Me.labF12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF9
        '
        Me.btnF9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF9.Location = New System.Drawing.Point(853, 845)
        Me.btnF9.Margin = New System.Windows.Forms.Padding(5)
        Me.btnF9.Name = "btnF9"
        Me.btnF9.Size = New System.Drawing.Size(100, 100)
        Me.btnF9.TabIndex = 20
        Me.btnF9.UseVisualStyleBackColor = True
        '
        'BackgroundBackup
        '
        '
        'frmPrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 881)
        Me.Controls.Add(Me.labF12)
        Me.Controls.Add(Me.btnF9)
        Me.Controls.Add(Me.labF11)
        Me.Controls.Add(Me.btnF8)
        Me.Controls.Add(Me.labF10)
        Me.Controls.Add(Me.labF9)
        Me.Controls.Add(Me.labF8)
        Me.Controls.Add(Me.labF7)
        Me.Controls.Add(Me.labF6)
        Me.Controls.Add(Me.labF5)
        Me.Controls.Add(Me.labF4)
        Me.Controls.Add(Me.labF3)
        Me.Controls.Add(Me.labF2)
        Me.Controls.Add(Me.labF1)
        Me.Controls.Add(Me.btnF7)
        Me.Controls.Add(Me.btnArchivio)
        Me.Controls.Add(Me.ssBarraStato)
        Me.Controls.Add(Me.msMenuStrip)
        Me.Controls.Add(Me.btnArrestoPC)
        Me.Controls.Add(Me.btnUscita)
        Me.Controls.Add(Me.btnDesktop)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnRisultati)
        Me.Controls.Add(Me.btnCollaudo)
        Me.Controls.Add(Me.btnLotti)
        Me.Controls.Add(Me.btnRicette)
        Me.Controls.Add(Me.pbSfondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.msMenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipale"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E.C.B. S.r.l. - Collaudo Celle Planari per Sonde WB"
        Me.msMenuStrip.ResumeLayout(False)
        Me.msMenuStrip.PerformLayout()
        CType(Me.pbSfondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrBarraStato As System.Windows.Forms.Timer
    Friend WithEvents btnRicette As System.Windows.Forms.Button
    Friend WithEvents btnLotti As System.Windows.Forms.Button
    Friend WithEvents btnCollaudo As System.Windows.Forms.Button
    Friend WithEvents btnRisultati As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnDesktop As System.Windows.Forms.Button
    Friend WithEvents btnUscita As System.Windows.Forms.Button
    Friend WithEvents btnArrestoPC As System.Windows.Forms.Button
    Friend WithEvents msMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ImpostazioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpostazioniGeneraliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpostazioniAvanzateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificaPassword1LivelloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificaPassword2LivelloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvanzateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitorHardwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbSfondo As System.Windows.Forms.PictureBox
    Friend WithEvents ssBarraStato As System.Windows.Forms.StatusStrip
    Friend WithEvents btnArchivio As System.Windows.Forms.Button
    Friend WithEvents btnF7 As System.Windows.Forms.Button
    Friend WithEvents labF1 As System.Windows.Forms.Label
    Friend WithEvents labF2 As System.Windows.Forms.Label
    Friend WithEvents labF3 As System.Windows.Forms.Label
    Friend WithEvents labF4 As System.Windows.Forms.Label
    Friend WithEvents labF5 As System.Windows.Forms.Label
    Friend WithEvents labF6 As System.Windows.Forms.Label
    Friend WithEvents labF7 As System.Windows.Forms.Label
    Friend WithEvents labF8 As System.Windows.Forms.Label
    Friend WithEvents labF9 As System.Windows.Forms.Label
    Friend WithEvents labF10 As System.Windows.Forms.Label
    Friend WithEvents TaratureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaraturaMisuraRheaterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataTaraturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AggiornamentoDataTaraturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents labF11 As System.Windows.Forms.Label
    Friend WithEvents btnF8 As System.Windows.Forms.Button
    Friend WithEvents labF12 As System.Windows.Forms.Label
    Friend WithEvents btnF9 As System.Windows.Forms.Button
    Friend WithEvents TaraturaMisuraValToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaraturaMisuraO2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaraturaMisuraIsolamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaraturaMisuraN2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificaTaraturaCorrenteRiscaldatoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificaTaraturaO2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CicliTotaliMacchinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundBackup As System.ComponentModel.BackgroundWorker
End Class

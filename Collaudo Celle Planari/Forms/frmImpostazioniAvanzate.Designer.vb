<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpostazioniAvanzate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpostazioniAvanzate))
        Me.btnModifica = New System.Windows.Forms.Button()
        Me.btnUscita = New System.Windows.Forms.Button()
        Me.btnAnnullaModifiche = New System.Windows.Forms.Button()
        Me.btnSalvaModifiche = New System.Windows.Forms.Button()
        Me.labOffset1 = New System.Windows.Forms.Label()
        Me.labMoltiplicatore1 = New System.Windows.Forms.Label()
        Me.tbOffsetMassFlowControllerAria = New System.Windows.Forms.TextBox()
        Me.tbMoltiplicatoreMassFlowControllerAria = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gbMassFlowControllerAria = New System.Windows.Forms.GroupBox()
        Me.gbMassFlowControllerAzoto = New System.Windows.Forms.GroupBox()
        Me.tbOffsetMassFlowControllerAzoto = New System.Windows.Forms.TextBox()
        Me.labOffset2 = New System.Windows.Forms.Label()
        Me.tbMoltiplicatoreMassFlowControllerAzoto = New System.Windows.Forms.TextBox()
        Me.labMoltiplicatore2 = New System.Windows.Forms.Label()
        Me.gbValim = New System.Windows.Forms.GroupBox()
        Me.tbOffsetValim = New System.Windows.Forms.TextBox()
        Me.labOffset3 = New System.Windows.Forms.Label()
        Me.tbMoltiplicatoreValim = New System.Windows.Forms.TextBox()
        Me.labMoltiplicatore3 = New System.Windows.Forms.Label()
        Me.gbResistenza = New System.Windows.Forms.GroupBox()
        Me.tbOffsetResistenza = New System.Windows.Forms.TextBox()
        Me.labOffset4 = New System.Windows.Forms.Label()
        Me.tbMoltiplicatoreResistenza = New System.Windows.Forms.TextBox()
        Me.labMoltiplicatore4 = New System.Windows.Forms.Label()
        Me.gbCorrente = New System.Windows.Forms.GroupBox()
        Me.tbOffsetCorrente = New System.Windows.Forms.TextBox()
        Me.labOffset5 = New System.Windows.Forms.Label()
        Me.tbMoltiplicatoreCorrente = New System.Windows.Forms.TextBox()
        Me.labMoltiplicatore5 = New System.Windows.Forms.Label()
        Me.gbLsuO2 = New System.Windows.Forms.GroupBox()
        Me.tbOffsetLsuO2 = New System.Windows.Forms.TextBox()
        Me.labOffset6 = New System.Windows.Forms.Label()
        Me.tbMoltiplicatoreLsuO2 = New System.Windows.Forms.TextBox()
        Me.labMoltiplicatore6 = New System.Windows.Forms.Label()
        Me.gbAdvLambda = New System.Windows.Forms.GroupBox()
        Me.tbOffsetAdvLambda = New System.Windows.Forms.TextBox()
        Me.labOffset7 = New System.Windows.Forms.Label()
        Me.tbMoltiplicatoreAdvLambda = New System.Windows.Forms.TextBox()
        Me.labMoltiplicatore7 = New System.Windows.Forms.Label()
        Me.gbAdvCorrentePumping = New System.Windows.Forms.GroupBox()
        Me.tbOffsetAdvCorrentePumping = New System.Windows.Forms.TextBox()
        Me.labOffset8 = New System.Windows.Forms.Label()
        Me.tbMoltiplicatoreAdvCorrentePumping = New System.Windows.Forms.TextBox()
        Me.labMoltiplicatore8 = New System.Windows.Forms.Label()
        Me.gbZfasCorrentePumpingEtas = New System.Windows.Forms.GroupBox()
        Me.tbOffsetZfasCorrentePumpingEtas = New System.Windows.Forms.TextBox()
        Me.labOffset9 = New System.Windows.Forms.Label()
        Me.tbMoltiplicatoreZfasCorrentePumpingEtas = New System.Windows.Forms.TextBox()
        Me.labMoltiplicatore9 = New System.Windows.Forms.Label()
        Me.gbZfasCorrentePumpingTB = New System.Windows.Forms.GroupBox()
        Me.tbOffsetZfasCorrentePumpingTB = New System.Windows.Forms.TextBox()
        Me.labOffset10 = New System.Windows.Forms.Label()
        Me.tbMoltiplicatoreZfasCorrentePumpingTB = New System.Windows.Forms.TextBox()
        Me.labMoltiplicatore10 = New System.Windows.Forms.Label()
        Me.gbMassFlowControllerAria.SuspendLayout()
        Me.gbMassFlowControllerAzoto.SuspendLayout()
        Me.gbValim.SuspendLayout()
        Me.gbResistenza.SuspendLayout()
        Me.gbCorrente.SuspendLayout()
        Me.gbLsuO2.SuspendLayout()
        Me.gbAdvLambda.SuspendLayout()
        Me.gbAdvCorrentePumping.SuspendLayout()
        Me.gbZfasCorrentePumpingEtas.SuspendLayout()
        Me.gbZfasCorrentePumpingTB.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModifica
        '
        Me.btnModifica.Image = CType(resources.GetObject("btnModifica.Image"), System.Drawing.Image)
        Me.btnModifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModifica.Location = New System.Drawing.Point(615, 23)
        Me.btnModifica.Margin = New System.Windows.Forms.Padding(5)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(100, 80)
        Me.btnModifica.TabIndex = 10
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'btnUscita
        '
        Me.btnUscita.Image = CType(resources.GetObject("btnUscita.Image"), System.Drawing.Image)
        Me.btnUscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUscita.Location = New System.Drawing.Point(615, 293)
        Me.btnUscita.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUscita.Name = "btnUscita"
        Me.btnUscita.Size = New System.Drawing.Size(100, 80)
        Me.btnUscita.TabIndex = 13
        Me.btnUscita.Text = "Uscita"
        Me.btnUscita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUscita.UseVisualStyleBackColor = True
        '
        'btnAnnullaModifiche
        '
        Me.btnAnnullaModifiche.Image = CType(resources.GetObject("btnAnnullaModifiche.Image"), System.Drawing.Image)
        Me.btnAnnullaModifiche.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnnullaModifiche.Location = New System.Drawing.Point(615, 113)
        Me.btnAnnullaModifiche.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAnnullaModifiche.Name = "btnAnnullaModifiche"
        Me.btnAnnullaModifiche.Size = New System.Drawing.Size(100, 80)
        Me.btnAnnullaModifiche.TabIndex = 11
        Me.btnAnnullaModifiche.Text = "Annulla modifiche"
        Me.btnAnnullaModifiche.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnnullaModifiche.UseVisualStyleBackColor = True
        '
        'btnSalvaModifiche
        '
        Me.btnSalvaModifiche.Image = CType(resources.GetObject("btnSalvaModifiche.Image"), System.Drawing.Image)
        Me.btnSalvaModifiche.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvaModifiche.Location = New System.Drawing.Point(615, 203)
        Me.btnSalvaModifiche.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalvaModifiche.Name = "btnSalvaModifiche"
        Me.btnSalvaModifiche.Size = New System.Drawing.Size(100, 80)
        Me.btnSalvaModifiche.TabIndex = 12
        Me.btnSalvaModifiche.Text = "Salva modifiche"
        Me.btnSalvaModifiche.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvaModifiche.UseVisualStyleBackColor = True
        '
        'labOffset1
        '
        Me.labOffset1.AutoSize = True
        Me.labOffset1.Location = New System.Drawing.Point(15, 30)
        Me.labOffset1.Margin = New System.Windows.Forms.Padding(5)
        Me.labOffset1.Name = "labOffset1"
        Me.labOffset1.Size = New System.Drawing.Size(132, 18)
        Me.labOffset1.TabIndex = 0
        Me.labOffset1.Text = "Offset - NL/minuto"
        '
        'labMoltiplicatore1
        '
        Me.labMoltiplicatore1.AutoSize = True
        Me.labMoltiplicatore1.Location = New System.Drawing.Point(15, 60)
        Me.labMoltiplicatore1.Margin = New System.Windows.Forms.Padding(5)
        Me.labMoltiplicatore1.Name = "labMoltiplicatore1"
        Me.labMoltiplicatore1.Size = New System.Drawing.Size(101, 18)
        Me.labMoltiplicatore1.TabIndex = 2
        Me.labMoltiplicatore1.Text = "Moltiplicatore"
        '
        'tbOffsetMassFlowControllerAria
        '
        Me.tbOffsetMassFlowControllerAria.Location = New System.Drawing.Point(200, 25)
        Me.tbOffsetMassFlowControllerAria.Margin = New System.Windows.Forms.Padding(5)
        Me.tbOffsetMassFlowControllerAria.Name = "tbOffsetMassFlowControllerAria"
        Me.tbOffsetMassFlowControllerAria.Size = New System.Drawing.Size(70, 26)
        Me.tbOffsetMassFlowControllerAria.TabIndex = 1
        Me.tbOffsetMassFlowControllerAria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbMoltiplicatoreMassFlowControllerAria
        '
        Me.tbMoltiplicatoreMassFlowControllerAria.Location = New System.Drawing.Point(200, 55)
        Me.tbMoltiplicatoreMassFlowControllerAria.Margin = New System.Windows.Forms.Padding(5)
        Me.tbMoltiplicatoreMassFlowControllerAria.Name = "tbMoltiplicatoreMassFlowControllerAria"
        Me.tbMoltiplicatoreMassFlowControllerAria.Size = New System.Drawing.Size(70, 26)
        Me.tbMoltiplicatoreMassFlowControllerAria.TabIndex = 3
        Me.tbMoltiplicatoreMassFlowControllerAria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(280, 50)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(70, 20)
        Me.TextBox1.TabIndex = 34
        '
        'gbMassFlowControllerAria
        '
        Me.gbMassFlowControllerAria.Controls.Add(Me.tbOffsetMassFlowControllerAria)
        Me.gbMassFlowControllerAria.Controls.Add(Me.labOffset1)
        Me.gbMassFlowControllerAria.Controls.Add(Me.tbMoltiplicatoreMassFlowControllerAria)
        Me.gbMassFlowControllerAria.Controls.Add(Me.labMoltiplicatore1)
        Me.gbMassFlowControllerAria.Location = New System.Drawing.Point(15, 15)
        Me.gbMassFlowControllerAria.Name = "gbMassFlowControllerAria"
        Me.gbMassFlowControllerAria.Size = New System.Drawing.Size(285, 100)
        Me.gbMassFlowControllerAria.TabIndex = 0
        Me.gbMassFlowControllerAria.TabStop = False
        Me.gbMassFlowControllerAria.Text = "Mass Flow Controller Aria"
        '
        'gbMassFlowControllerAzoto
        '
        Me.gbMassFlowControllerAzoto.Controls.Add(Me.tbOffsetMassFlowControllerAzoto)
        Me.gbMassFlowControllerAzoto.Controls.Add(Me.labOffset2)
        Me.gbMassFlowControllerAzoto.Controls.Add(Me.tbMoltiplicatoreMassFlowControllerAzoto)
        Me.gbMassFlowControllerAzoto.Controls.Add(Me.labMoltiplicatore2)
        Me.gbMassFlowControllerAzoto.Location = New System.Drawing.Point(15, 130)
        Me.gbMassFlowControllerAzoto.Name = "gbMassFlowControllerAzoto"
        Me.gbMassFlowControllerAzoto.Size = New System.Drawing.Size(285, 100)
        Me.gbMassFlowControllerAzoto.TabIndex = 1
        Me.gbMassFlowControllerAzoto.TabStop = False
        Me.gbMassFlowControllerAzoto.Text = "Mass Flow Controller Azoto"
        '
        'tbOffsetMassFlowControllerAzoto
        '
        Me.tbOffsetMassFlowControllerAzoto.Location = New System.Drawing.Point(200, 25)
        Me.tbOffsetMassFlowControllerAzoto.Margin = New System.Windows.Forms.Padding(5)
        Me.tbOffsetMassFlowControllerAzoto.Name = "tbOffsetMassFlowControllerAzoto"
        Me.tbOffsetMassFlowControllerAzoto.Size = New System.Drawing.Size(70, 26)
        Me.tbOffsetMassFlowControllerAzoto.TabIndex = 1
        Me.tbOffsetMassFlowControllerAzoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labOffset2
        '
        Me.labOffset2.AutoSize = True
        Me.labOffset2.Location = New System.Drawing.Point(15, 30)
        Me.labOffset2.Margin = New System.Windows.Forms.Padding(5)
        Me.labOffset2.Name = "labOffset2"
        Me.labOffset2.Size = New System.Drawing.Size(132, 18)
        Me.labOffset2.TabIndex = 0
        Me.labOffset2.Text = "Offset - NL/minuto"
        '
        'tbMoltiplicatoreMassFlowControllerAzoto
        '
        Me.tbMoltiplicatoreMassFlowControllerAzoto.Location = New System.Drawing.Point(200, 55)
        Me.tbMoltiplicatoreMassFlowControllerAzoto.Margin = New System.Windows.Forms.Padding(5)
        Me.tbMoltiplicatoreMassFlowControllerAzoto.Name = "tbMoltiplicatoreMassFlowControllerAzoto"
        Me.tbMoltiplicatoreMassFlowControllerAzoto.Size = New System.Drawing.Size(70, 26)
        Me.tbMoltiplicatoreMassFlowControllerAzoto.TabIndex = 3
        Me.tbMoltiplicatoreMassFlowControllerAzoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labMoltiplicatore2
        '
        Me.labMoltiplicatore2.AutoSize = True
        Me.labMoltiplicatore2.Location = New System.Drawing.Point(15, 60)
        Me.labMoltiplicatore2.Margin = New System.Windows.Forms.Padding(5)
        Me.labMoltiplicatore2.Name = "labMoltiplicatore2"
        Me.labMoltiplicatore2.Size = New System.Drawing.Size(101, 18)
        Me.labMoltiplicatore2.TabIndex = 2
        Me.labMoltiplicatore2.Text = "Moltiplicatore"
        '
        'gbValim
        '
        Me.gbValim.Controls.Add(Me.tbOffsetValim)
        Me.gbValim.Controls.Add(Me.labOffset3)
        Me.gbValim.Controls.Add(Me.tbMoltiplicatoreValim)
        Me.gbValim.Controls.Add(Me.labMoltiplicatore3)
        Me.gbValim.Location = New System.Drawing.Point(15, 245)
        Me.gbValim.Name = "gbValim"
        Me.gbValim.Size = New System.Drawing.Size(285, 100)
        Me.gbValim.TabIndex = 2
        Me.gbValim.TabStop = False
        Me.gbValim.Text = "Misurazione Tensione"
        '
        'tbOffsetValim
        '
        Me.tbOffsetValim.Location = New System.Drawing.Point(200, 25)
        Me.tbOffsetValim.Margin = New System.Windows.Forms.Padding(5)
        Me.tbOffsetValim.Name = "tbOffsetValim"
        Me.tbOffsetValim.Size = New System.Drawing.Size(70, 26)
        Me.tbOffsetValim.TabIndex = 1
        Me.tbOffsetValim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labOffset3
        '
        Me.labOffset3.AutoSize = True
        Me.labOffset3.Location = New System.Drawing.Point(15, 30)
        Me.labOffset3.Margin = New System.Windows.Forms.Padding(5)
        Me.labOffset3.Name = "labOffset3"
        Me.labOffset3.Size = New System.Drawing.Size(72, 18)
        Me.labOffset3.TabIndex = 0
        Me.labOffset3.Text = "Offset / V"
        '
        'tbMoltiplicatoreValim
        '
        Me.tbMoltiplicatoreValim.Location = New System.Drawing.Point(200, 55)
        Me.tbMoltiplicatoreValim.Margin = New System.Windows.Forms.Padding(5)
        Me.tbMoltiplicatoreValim.Name = "tbMoltiplicatoreValim"
        Me.tbMoltiplicatoreValim.Size = New System.Drawing.Size(70, 26)
        Me.tbMoltiplicatoreValim.TabIndex = 3
        Me.tbMoltiplicatoreValim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labMoltiplicatore3
        '
        Me.labMoltiplicatore3.AutoSize = True
        Me.labMoltiplicatore3.Location = New System.Drawing.Point(15, 60)
        Me.labMoltiplicatore3.Margin = New System.Windows.Forms.Padding(5)
        Me.labMoltiplicatore3.Name = "labMoltiplicatore3"
        Me.labMoltiplicatore3.Size = New System.Drawing.Size(101, 18)
        Me.labMoltiplicatore3.TabIndex = 2
        Me.labMoltiplicatore3.Text = "Moltiplicatore"
        '
        'gbResistenza
        '
        Me.gbResistenza.Controls.Add(Me.tbOffsetResistenza)
        Me.gbResistenza.Controls.Add(Me.labOffset4)
        Me.gbResistenza.Controls.Add(Me.tbMoltiplicatoreResistenza)
        Me.gbResistenza.Controls.Add(Me.labMoltiplicatore4)
        Me.gbResistenza.Location = New System.Drawing.Point(15, 360)
        Me.gbResistenza.Name = "gbResistenza"
        Me.gbResistenza.Size = New System.Drawing.Size(285, 100)
        Me.gbResistenza.TabIndex = 3
        Me.gbResistenza.TabStop = False
        Me.gbResistenza.Text = "Misurazione Resistenza"
        '
        'tbOffsetResistenza
        '
        Me.tbOffsetResistenza.Location = New System.Drawing.Point(200, 25)
        Me.tbOffsetResistenza.Margin = New System.Windows.Forms.Padding(5)
        Me.tbOffsetResistenza.Name = "tbOffsetResistenza"
        Me.tbOffsetResistenza.Size = New System.Drawing.Size(70, 26)
        Me.tbOffsetResistenza.TabIndex = 1
        Me.tbOffsetResistenza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labOffset4
        '
        Me.labOffset4.AutoSize = True
        Me.labOffset4.Location = New System.Drawing.Point(15, 30)
        Me.labOffset4.Margin = New System.Windows.Forms.Padding(5)
        Me.labOffset4.Name = "labOffset4"
        Me.labOffset4.Size = New System.Drawing.Size(94, 18)
        Me.labOffset4.TabIndex = 0
        Me.labOffset4.Text = "Offset / Ohm"
        '
        'tbMoltiplicatoreResistenza
        '
        Me.tbMoltiplicatoreResistenza.Location = New System.Drawing.Point(200, 55)
        Me.tbMoltiplicatoreResistenza.Margin = New System.Windows.Forms.Padding(5)
        Me.tbMoltiplicatoreResistenza.Name = "tbMoltiplicatoreResistenza"
        Me.tbMoltiplicatoreResistenza.Size = New System.Drawing.Size(70, 26)
        Me.tbMoltiplicatoreResistenza.TabIndex = 3
        Me.tbMoltiplicatoreResistenza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labMoltiplicatore4
        '
        Me.labMoltiplicatore4.AutoSize = True
        Me.labMoltiplicatore4.Location = New System.Drawing.Point(15, 60)
        Me.labMoltiplicatore4.Margin = New System.Windows.Forms.Padding(5)
        Me.labMoltiplicatore4.Name = "labMoltiplicatore4"
        Me.labMoltiplicatore4.Size = New System.Drawing.Size(101, 18)
        Me.labMoltiplicatore4.TabIndex = 2
        Me.labMoltiplicatore4.Text = "Moltiplicatore"
        '
        'gbCorrente
        '
        Me.gbCorrente.Controls.Add(Me.tbOffsetCorrente)
        Me.gbCorrente.Controls.Add(Me.labOffset5)
        Me.gbCorrente.Controls.Add(Me.tbMoltiplicatoreCorrente)
        Me.gbCorrente.Controls.Add(Me.labMoltiplicatore5)
        Me.gbCorrente.Location = New System.Drawing.Point(15, 475)
        Me.gbCorrente.Name = "gbCorrente"
        Me.gbCorrente.Size = New System.Drawing.Size(285, 100)
        Me.gbCorrente.TabIndex = 4
        Me.gbCorrente.TabStop = False
        Me.gbCorrente.Text = "Misurazione Corrente"
        '
        'tbOffsetCorrente
        '
        Me.tbOffsetCorrente.Location = New System.Drawing.Point(200, 25)
        Me.tbOffsetCorrente.Margin = New System.Windows.Forms.Padding(5)
        Me.tbOffsetCorrente.Name = "tbOffsetCorrente"
        Me.tbOffsetCorrente.Size = New System.Drawing.Size(70, 26)
        Me.tbOffsetCorrente.TabIndex = 1
        Me.tbOffsetCorrente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labOffset5
        '
        Me.labOffset5.AutoSize = True
        Me.labOffset5.Location = New System.Drawing.Point(15, 30)
        Me.labOffset5.Margin = New System.Windows.Forms.Padding(5)
        Me.labOffset5.Name = "labOffset5"
        Me.labOffset5.Size = New System.Drawing.Size(85, 18)
        Me.labOffset5.TabIndex = 0
        Me.labOffset5.Text = "Offset / mA"
        '
        'tbMoltiplicatoreCorrente
        '
        Me.tbMoltiplicatoreCorrente.Location = New System.Drawing.Point(200, 55)
        Me.tbMoltiplicatoreCorrente.Margin = New System.Windows.Forms.Padding(5)
        Me.tbMoltiplicatoreCorrente.Name = "tbMoltiplicatoreCorrente"
        Me.tbMoltiplicatoreCorrente.Size = New System.Drawing.Size(70, 26)
        Me.tbMoltiplicatoreCorrente.TabIndex = 3
        Me.tbMoltiplicatoreCorrente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labMoltiplicatore5
        '
        Me.labMoltiplicatore5.AutoSize = True
        Me.labMoltiplicatore5.Location = New System.Drawing.Point(15, 60)
        Me.labMoltiplicatore5.Margin = New System.Windows.Forms.Padding(5)
        Me.labMoltiplicatore5.Name = "labMoltiplicatore5"
        Me.labMoltiplicatore5.Size = New System.Drawing.Size(101, 18)
        Me.labMoltiplicatore5.TabIndex = 2
        Me.labMoltiplicatore5.Text = "Moltiplicatore"
        '
        'gbLsuO2
        '
        Me.gbLsuO2.Controls.Add(Me.tbOffsetLsuO2)
        Me.gbLsuO2.Controls.Add(Me.labOffset6)
        Me.gbLsuO2.Controls.Add(Me.tbMoltiplicatoreLsuO2)
        Me.gbLsuO2.Controls.Add(Me.labMoltiplicatore6)
        Me.gbLsuO2.Location = New System.Drawing.Point(315, 15)
        Me.gbLsuO2.Name = "gbLsuO2"
        Me.gbLsuO2.Size = New System.Drawing.Size(285, 100)
        Me.gbLsuO2.TabIndex = 5
        Me.gbLsuO2.TabStop = False
        Me.gbLsuO2.Text = "LSU 4.9 - Percentuale Ossigeno"
        '
        'tbOffsetLsuO2
        '
        Me.tbOffsetLsuO2.Location = New System.Drawing.Point(200, 25)
        Me.tbOffsetLsuO2.Margin = New System.Windows.Forms.Padding(5)
        Me.tbOffsetLsuO2.Name = "tbOffsetLsuO2"
        Me.tbOffsetLsuO2.Size = New System.Drawing.Size(70, 26)
        Me.tbOffsetLsuO2.TabIndex = 1
        Me.tbOffsetLsuO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labOffset6
        '
        Me.labOffset6.AutoSize = True
        Me.labOffset6.Location = New System.Drawing.Point(15, 30)
        Me.labOffset6.Margin = New System.Windows.Forms.Padding(5)
        Me.labOffset6.Name = "labOffset6"
        Me.labOffset6.Size = New System.Drawing.Size(132, 18)
        Me.labOffset6.TabIndex = 0
        Me.labOffset6.Text = "Offset - NL/minuto"
        '
        'tbMoltiplicatoreLsuO2
        '
        Me.tbMoltiplicatoreLsuO2.Location = New System.Drawing.Point(200, 55)
        Me.tbMoltiplicatoreLsuO2.Margin = New System.Windows.Forms.Padding(5)
        Me.tbMoltiplicatoreLsuO2.Name = "tbMoltiplicatoreLsuO2"
        Me.tbMoltiplicatoreLsuO2.Size = New System.Drawing.Size(70, 26)
        Me.tbMoltiplicatoreLsuO2.TabIndex = 3
        Me.tbMoltiplicatoreLsuO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labMoltiplicatore6
        '
        Me.labMoltiplicatore6.AutoSize = True
        Me.labMoltiplicatore6.Location = New System.Drawing.Point(15, 60)
        Me.labMoltiplicatore6.Margin = New System.Windows.Forms.Padding(5)
        Me.labMoltiplicatore6.Name = "labMoltiplicatore6"
        Me.labMoltiplicatore6.Size = New System.Drawing.Size(101, 18)
        Me.labMoltiplicatore6.TabIndex = 2
        Me.labMoltiplicatore6.Text = "Moltiplicatore"
        '
        'gbAdvLambda
        '
        Me.gbAdvLambda.Controls.Add(Me.tbOffsetAdvLambda)
        Me.gbAdvLambda.Controls.Add(Me.labOffset7)
        Me.gbAdvLambda.Controls.Add(Me.tbMoltiplicatoreAdvLambda)
        Me.gbAdvLambda.Controls.Add(Me.labMoltiplicatore7)
        Me.gbAdvLambda.Location = New System.Drawing.Point(315, 130)
        Me.gbAdvLambda.Name = "gbAdvLambda"
        Me.gbAdvLambda.Size = New System.Drawing.Size(285, 100)
        Me.gbAdvLambda.TabIndex = 6
        Me.gbAdvLambda.TabStop = False
        Me.gbAdvLambda.Text = "ADV - Lambda"
        '
        'tbOffsetAdvLambda
        '
        Me.tbOffsetAdvLambda.Location = New System.Drawing.Point(200, 25)
        Me.tbOffsetAdvLambda.Margin = New System.Windows.Forms.Padding(5)
        Me.tbOffsetAdvLambda.Name = "tbOffsetAdvLambda"
        Me.tbOffsetAdvLambda.Size = New System.Drawing.Size(70, 26)
        Me.tbOffsetAdvLambda.TabIndex = 1
        Me.tbOffsetAdvLambda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labOffset7
        '
        Me.labOffset7.AutoSize = True
        Me.labOffset7.Location = New System.Drawing.Point(15, 30)
        Me.labOffset7.Margin = New System.Windows.Forms.Padding(5)
        Me.labOffset7.Name = "labOffset7"
        Me.labOffset7.Size = New System.Drawing.Size(49, 18)
        Me.labOffset7.TabIndex = 0
        Me.labOffset7.Text = "Offset"
        '
        'tbMoltiplicatoreAdvLambda
        '
        Me.tbMoltiplicatoreAdvLambda.Location = New System.Drawing.Point(200, 55)
        Me.tbMoltiplicatoreAdvLambda.Margin = New System.Windows.Forms.Padding(5)
        Me.tbMoltiplicatoreAdvLambda.Name = "tbMoltiplicatoreAdvLambda"
        Me.tbMoltiplicatoreAdvLambda.Size = New System.Drawing.Size(70, 26)
        Me.tbMoltiplicatoreAdvLambda.TabIndex = 3
        Me.tbMoltiplicatoreAdvLambda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labMoltiplicatore7
        '
        Me.labMoltiplicatore7.AutoSize = True
        Me.labMoltiplicatore7.Location = New System.Drawing.Point(15, 60)
        Me.labMoltiplicatore7.Margin = New System.Windows.Forms.Padding(5)
        Me.labMoltiplicatore7.Name = "labMoltiplicatore7"
        Me.labMoltiplicatore7.Size = New System.Drawing.Size(101, 18)
        Me.labMoltiplicatore7.TabIndex = 2
        Me.labMoltiplicatore7.Text = "Moltiplicatore"
        '
        'gbAdvCorrentePumping
        '
        Me.gbAdvCorrentePumping.Controls.Add(Me.tbOffsetAdvCorrentePumping)
        Me.gbAdvCorrentePumping.Controls.Add(Me.labOffset8)
        Me.gbAdvCorrentePumping.Controls.Add(Me.tbMoltiplicatoreAdvCorrentePumping)
        Me.gbAdvCorrentePumping.Controls.Add(Me.labMoltiplicatore8)
        Me.gbAdvCorrentePumping.Location = New System.Drawing.Point(315, 245)
        Me.gbAdvCorrentePumping.Name = "gbAdvCorrentePumping"
        Me.gbAdvCorrentePumping.Size = New System.Drawing.Size(285, 100)
        Me.gbAdvCorrentePumping.TabIndex = 7
        Me.gbAdvCorrentePumping.TabStop = False
        Me.gbAdvCorrentePumping.Text = "ADV - Corrente Pumping"
        '
        'tbOffsetAdvCorrentePumping
        '
        Me.tbOffsetAdvCorrentePumping.Location = New System.Drawing.Point(200, 25)
        Me.tbOffsetAdvCorrentePumping.Margin = New System.Windows.Forms.Padding(5)
        Me.tbOffsetAdvCorrentePumping.Name = "tbOffsetAdvCorrentePumping"
        Me.tbOffsetAdvCorrentePumping.Size = New System.Drawing.Size(70, 26)
        Me.tbOffsetAdvCorrentePumping.TabIndex = 1
        Me.tbOffsetAdvCorrentePumping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labOffset8
        '
        Me.labOffset8.AutoSize = True
        Me.labOffset8.Location = New System.Drawing.Point(15, 30)
        Me.labOffset8.Margin = New System.Windows.Forms.Padding(5)
        Me.labOffset8.Name = "labOffset8"
        Me.labOffset8.Size = New System.Drawing.Size(85, 18)
        Me.labOffset8.TabIndex = 0
        Me.labOffset8.Text = "Offset / mA"
        '
        'tbMoltiplicatoreAdvCorrentePumping
        '
        Me.tbMoltiplicatoreAdvCorrentePumping.Location = New System.Drawing.Point(200, 55)
        Me.tbMoltiplicatoreAdvCorrentePumping.Margin = New System.Windows.Forms.Padding(5)
        Me.tbMoltiplicatoreAdvCorrentePumping.Name = "tbMoltiplicatoreAdvCorrentePumping"
        Me.tbMoltiplicatoreAdvCorrentePumping.Size = New System.Drawing.Size(70, 26)
        Me.tbMoltiplicatoreAdvCorrentePumping.TabIndex = 3
        Me.tbMoltiplicatoreAdvCorrentePumping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labMoltiplicatore8
        '
        Me.labMoltiplicatore8.AutoSize = True
        Me.labMoltiplicatore8.Location = New System.Drawing.Point(15, 60)
        Me.labMoltiplicatore8.Margin = New System.Windows.Forms.Padding(5)
        Me.labMoltiplicatore8.Name = "labMoltiplicatore8"
        Me.labMoltiplicatore8.Size = New System.Drawing.Size(101, 18)
        Me.labMoltiplicatore8.TabIndex = 2
        Me.labMoltiplicatore8.Text = "Moltiplicatore"
        '
        'gbZfasCorrentePumpingEtas
        '
        Me.gbZfasCorrentePumpingEtas.Controls.Add(Me.tbOffsetZfasCorrentePumpingEtas)
        Me.gbZfasCorrentePumpingEtas.Controls.Add(Me.labOffset9)
        Me.gbZfasCorrentePumpingEtas.Controls.Add(Me.tbMoltiplicatoreZfasCorrentePumpingEtas)
        Me.gbZfasCorrentePumpingEtas.Controls.Add(Me.labMoltiplicatore9)
        Me.gbZfasCorrentePumpingEtas.Location = New System.Drawing.Point(315, 360)
        Me.gbZfasCorrentePumpingEtas.Name = "gbZfasCorrentePumpingEtas"
        Me.gbZfasCorrentePumpingEtas.Size = New System.Drawing.Size(285, 100)
        Me.gbZfasCorrentePumpingEtas.TabIndex = 8
        Me.gbZfasCorrentePumpingEtas.TabStop = False
        Me.gbZfasCorrentePumpingEtas.Text = "ZFAS-U2 - Corrente Pumping Etas"
        '
        'tbOffsetZfasCorrentePumpingEtas
        '
        Me.tbOffsetZfasCorrentePumpingEtas.Location = New System.Drawing.Point(200, 25)
        Me.tbOffsetZfasCorrentePumpingEtas.Margin = New System.Windows.Forms.Padding(5)
        Me.tbOffsetZfasCorrentePumpingEtas.Name = "tbOffsetZfasCorrentePumpingEtas"
        Me.tbOffsetZfasCorrentePumpingEtas.Size = New System.Drawing.Size(70, 26)
        Me.tbOffsetZfasCorrentePumpingEtas.TabIndex = 1
        Me.tbOffsetZfasCorrentePumpingEtas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labOffset9
        '
        Me.labOffset9.AutoSize = True
        Me.labOffset9.Location = New System.Drawing.Point(15, 30)
        Me.labOffset9.Margin = New System.Windows.Forms.Padding(5)
        Me.labOffset9.Name = "labOffset9"
        Me.labOffset9.Size = New System.Drawing.Size(85, 18)
        Me.labOffset9.TabIndex = 0
        Me.labOffset9.Text = "Offset / mA"
        '
        'tbMoltiplicatoreZfasCorrentePumpingEtas
        '
        Me.tbMoltiplicatoreZfasCorrentePumpingEtas.Location = New System.Drawing.Point(200, 55)
        Me.tbMoltiplicatoreZfasCorrentePumpingEtas.Margin = New System.Windows.Forms.Padding(5)
        Me.tbMoltiplicatoreZfasCorrentePumpingEtas.Name = "tbMoltiplicatoreZfasCorrentePumpingEtas"
        Me.tbMoltiplicatoreZfasCorrentePumpingEtas.Size = New System.Drawing.Size(70, 26)
        Me.tbMoltiplicatoreZfasCorrentePumpingEtas.TabIndex = 3
        Me.tbMoltiplicatoreZfasCorrentePumpingEtas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labMoltiplicatore9
        '
        Me.labMoltiplicatore9.AutoSize = True
        Me.labMoltiplicatore9.Location = New System.Drawing.Point(15, 60)
        Me.labMoltiplicatore9.Margin = New System.Windows.Forms.Padding(5)
        Me.labMoltiplicatore9.Name = "labMoltiplicatore9"
        Me.labMoltiplicatore9.Size = New System.Drawing.Size(101, 18)
        Me.labMoltiplicatore9.TabIndex = 2
        Me.labMoltiplicatore9.Text = "Moltiplicatore"
        '
        'gbZfasCorrentePumpingTB
        '
        Me.gbZfasCorrentePumpingTB.Controls.Add(Me.tbOffsetZfasCorrentePumpingTB)
        Me.gbZfasCorrentePumpingTB.Controls.Add(Me.labOffset10)
        Me.gbZfasCorrentePumpingTB.Controls.Add(Me.tbMoltiplicatoreZfasCorrentePumpingTB)
        Me.gbZfasCorrentePumpingTB.Controls.Add(Me.labMoltiplicatore10)
        Me.gbZfasCorrentePumpingTB.Location = New System.Drawing.Point(315, 475)
        Me.gbZfasCorrentePumpingTB.Name = "gbZfasCorrentePumpingTB"
        Me.gbZfasCorrentePumpingTB.Size = New System.Drawing.Size(285, 100)
        Me.gbZfasCorrentePumpingTB.TabIndex = 9
        Me.gbZfasCorrentePumpingTB.TabStop = False
        Me.gbZfasCorrentePumpingTB.Text = "ZFAS-U2 - Corrente Pumping TB"
        '
        'tbOffsetZfasCorrentePumpingTB
        '
        Me.tbOffsetZfasCorrentePumpingTB.Location = New System.Drawing.Point(200, 25)
        Me.tbOffsetZfasCorrentePumpingTB.Margin = New System.Windows.Forms.Padding(5)
        Me.tbOffsetZfasCorrentePumpingTB.Name = "tbOffsetZfasCorrentePumpingTB"
        Me.tbOffsetZfasCorrentePumpingTB.Size = New System.Drawing.Size(70, 26)
        Me.tbOffsetZfasCorrentePumpingTB.TabIndex = 1
        Me.tbOffsetZfasCorrentePumpingTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labOffset10
        '
        Me.labOffset10.AutoSize = True
        Me.labOffset10.Location = New System.Drawing.Point(15, 30)
        Me.labOffset10.Margin = New System.Windows.Forms.Padding(5)
        Me.labOffset10.Name = "labOffset10"
        Me.labOffset10.Size = New System.Drawing.Size(85, 18)
        Me.labOffset10.TabIndex = 0
        Me.labOffset10.Text = "Offset / mA"
        '
        'tbMoltiplicatoreZfasCorrentePumpingTB
        '
        Me.tbMoltiplicatoreZfasCorrentePumpingTB.Location = New System.Drawing.Point(200, 55)
        Me.tbMoltiplicatoreZfasCorrentePumpingTB.Margin = New System.Windows.Forms.Padding(5)
        Me.tbMoltiplicatoreZfasCorrentePumpingTB.Name = "tbMoltiplicatoreZfasCorrentePumpingTB"
        Me.tbMoltiplicatoreZfasCorrentePumpingTB.Size = New System.Drawing.Size(70, 26)
        Me.tbMoltiplicatoreZfasCorrentePumpingTB.TabIndex = 3
        Me.tbMoltiplicatoreZfasCorrentePumpingTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labMoltiplicatore10
        '
        Me.labMoltiplicatore10.AutoSize = True
        Me.labMoltiplicatore10.Location = New System.Drawing.Point(15, 60)
        Me.labMoltiplicatore10.Margin = New System.Windows.Forms.Padding(5)
        Me.labMoltiplicatore10.Name = "labMoltiplicatore10"
        Me.labMoltiplicatore10.Size = New System.Drawing.Size(101, 18)
        Me.labMoltiplicatore10.TabIndex = 2
        Me.labMoltiplicatore10.Text = "Moltiplicatore"
        '
        'frmImpostazioniAvanzate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 591)
        Me.Controls.Add(Me.gbCorrente)
        Me.Controls.Add(Me.gbZfasCorrentePumpingTB)
        Me.Controls.Add(Me.gbZfasCorrentePumpingEtas)
        Me.Controls.Add(Me.gbResistenza)
        Me.Controls.Add(Me.gbAdvCorrentePumping)
        Me.Controls.Add(Me.gbValim)
        Me.Controls.Add(Me.gbAdvLambda)
        Me.Controls.Add(Me.gbMassFlowControllerAzoto)
        Me.Controls.Add(Me.gbLsuO2)
        Me.Controls.Add(Me.gbMassFlowControllerAria)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.btnUscita)
        Me.Controls.Add(Me.btnAnnullaModifiche)
        Me.Controls.Add(Me.btnSalvaModifiche)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpostazioniAvanzate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impostazioni avanzate"
        Me.gbMassFlowControllerAria.ResumeLayout(False)
        Me.gbMassFlowControllerAria.PerformLayout()
        Me.gbMassFlowControllerAzoto.ResumeLayout(False)
        Me.gbMassFlowControllerAzoto.PerformLayout()
        Me.gbValim.ResumeLayout(False)
        Me.gbValim.PerformLayout()
        Me.gbResistenza.ResumeLayout(False)
        Me.gbResistenza.PerformLayout()
        Me.gbCorrente.ResumeLayout(False)
        Me.gbCorrente.PerformLayout()
        Me.gbLsuO2.ResumeLayout(False)
        Me.gbLsuO2.PerformLayout()
        Me.gbAdvLambda.ResumeLayout(False)
        Me.gbAdvLambda.PerformLayout()
        Me.gbAdvCorrentePumping.ResumeLayout(False)
        Me.gbAdvCorrentePumping.PerformLayout()
        Me.gbZfasCorrentePumpingEtas.ResumeLayout(False)
        Me.gbZfasCorrentePumpingEtas.PerformLayout()
        Me.gbZfasCorrentePumpingTB.ResumeLayout(False)
        Me.gbZfasCorrentePumpingTB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents btnUscita As System.Windows.Forms.Button
    Friend WithEvents btnAnnullaModifiche As System.Windows.Forms.Button
    Friend WithEvents btnSalvaModifiche As System.Windows.Forms.Button
    Friend WithEvents labOffset1 As System.Windows.Forms.Label
    Friend WithEvents labMoltiplicatore1 As System.Windows.Forms.Label
    Friend WithEvents tbOffsetMassFlowControllerAria As System.Windows.Forms.TextBox
    Friend WithEvents tbMoltiplicatoreMassFlowControllerAria As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents gbMassFlowControllerAria As System.Windows.Forms.GroupBox
    Friend WithEvents gbMassFlowControllerAzoto As System.Windows.Forms.GroupBox
    Friend WithEvents tbOffsetMassFlowControllerAzoto As System.Windows.Forms.TextBox
    Friend WithEvents labOffset2 As System.Windows.Forms.Label
    Friend WithEvents tbMoltiplicatoreMassFlowControllerAzoto As System.Windows.Forms.TextBox
    Friend WithEvents labMoltiplicatore2 As System.Windows.Forms.Label
    Friend WithEvents gbValim As System.Windows.Forms.GroupBox
    Friend WithEvents tbOffsetValim As System.Windows.Forms.TextBox
    Friend WithEvents labOffset3 As System.Windows.Forms.Label
    Friend WithEvents tbMoltiplicatoreValim As System.Windows.Forms.TextBox
    Friend WithEvents labMoltiplicatore3 As System.Windows.Forms.Label
    Friend WithEvents gbResistenza As System.Windows.Forms.GroupBox
    Friend WithEvents tbOffsetResistenza As System.Windows.Forms.TextBox
    Friend WithEvents labOffset4 As System.Windows.Forms.Label
    Friend WithEvents tbMoltiplicatoreResistenza As System.Windows.Forms.TextBox
    Friend WithEvents labMoltiplicatore4 As System.Windows.Forms.Label
    Friend WithEvents gbCorrente As System.Windows.Forms.GroupBox
    Friend WithEvents tbOffsetCorrente As System.Windows.Forms.TextBox
    Friend WithEvents labOffset5 As System.Windows.Forms.Label
    Friend WithEvents tbMoltiplicatoreCorrente As System.Windows.Forms.TextBox
    Friend WithEvents labMoltiplicatore5 As System.Windows.Forms.Label
    Friend WithEvents gbLsuO2 As GroupBox
    Friend WithEvents tbOffsetLsuO2 As TextBox
    Friend WithEvents labOffset6 As Label
    Friend WithEvents tbMoltiplicatoreLsuO2 As TextBox
    Friend WithEvents labMoltiplicatore6 As Label
    Friend WithEvents gbAdvLambda As GroupBox
    Friend WithEvents tbOffsetAdvLambda As TextBox
    Friend WithEvents labOffset7 As Label
    Friend WithEvents tbMoltiplicatoreAdvLambda As TextBox
    Friend WithEvents labMoltiplicatore7 As Label
    Friend WithEvents gbAdvCorrentePumping As GroupBox
    Friend WithEvents tbOffsetAdvCorrentePumping As TextBox
    Friend WithEvents labOffset8 As Label
    Friend WithEvents tbMoltiplicatoreAdvCorrentePumping As TextBox
    Friend WithEvents labMoltiplicatore8 As Label
    Friend WithEvents gbZfasCorrentePumpingEtas As GroupBox
    Friend WithEvents tbOffsetZfasCorrentePumpingEtas As TextBox
    Friend WithEvents labOffset9 As Label
    Friend WithEvents tbMoltiplicatoreZfasCorrentePumpingEtas As TextBox
    Friend WithEvents labMoltiplicatore9 As Label
    Friend WithEvents gbZfasCorrentePumpingTB As GroupBox
    Friend WithEvents tbOffsetZfasCorrentePumpingTB As TextBox
    Friend WithEvents labOffset10 As Label
    Friend WithEvents tbMoltiplicatoreZfasCorrentePumpingTB As TextBox
    Friend WithEvents labMoltiplicatore10 As Label
End Class

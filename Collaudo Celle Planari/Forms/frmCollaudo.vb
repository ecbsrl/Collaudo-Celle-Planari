Option Explicit On
Option Strict On

Public Class frmCollaudo
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _abilitazioneCiclo As Boolean
    Private _blink As Boolean



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Sub VisualizzaContatori()
        ' Visualizza i contatori di lotto
        labPezziLotto.Text = mGestoreCollaudo.Lotto.NumeroPezzi.ToString
        labBuoniLotto.Text = mGestoreCollaudo.Lotto.NumeroBuoni.ToString
        labScartiLotto.Text = mGestoreCollaudo.Lotto.NumeroScarti.ToString
        If (mGestoreCollaudo.Lotto.NumeroPezzi <> 0) Then
            labPercentualeBuoniLotto.Text = Math.Round(mGestoreCollaudo.Lotto.NumeroBuoni / mGestoreCollaudo.Lotto.NumeroPezzi * 100, 1).ToString
            labPercentualeScartiLotto.Text = Math.Round(mGestoreCollaudo.Lotto.NumeroScarti / mGestoreCollaudo.Lotto.NumeroPezzi * 100, 1).ToString
        Else
            labPercentualeBuoniLotto.Text = ""
            labPercentualeScartiLotto.Text = ""
        End If
        ' Visualizza i contatori di sessione
        labPezziSessione.Text = mGestoreCollaudo.NumeroPezzi.ToString
        labBuoniSessione.Text = mGestoreCollaudo.NumeroBuoni.ToString
        labScartiSessione.Text = mGestoreCollaudo.NumeroScarti.ToString
        If (mGestoreCollaudo.NumeroPezzi <> 0) Then
            labPercentualeBuoniSessione.Text = Math.Round(mGestoreCollaudo.NumeroBuoni / mGestoreCollaudo.NumeroPezzi * 100, 1).ToString
            labPercentualeScartiSessione.Text = Math.Round(mGestoreCollaudo.NumeroScarti / mGestoreCollaudo.NumeroPezzi * 100, 1).ToString
        Else
            labPercentualeBuoniSessione.Text = ""
            labPercentualeScartiSessione.Text = ""
        End If
    End Sub



    Public Sub VisualizzaGrafico()
        ' Reference to the chart
        With chrtGrafico
            ' Suspend the layout
            .SuspendLayout()
            ' Clear serie
            .Series.Clear()
            ' Aggiungo la serie
            .Series.Add("")
            .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
            .Series(0).IsVisibleInLegend = True
            .Series(0).BorderWidth = 1
            .Series(0).BorderColor = Color.Black
            .Series(0).Points.AddXY("BUONI", mGestoreCollaudo.Lotto.NumeroBuoni)
            .Series(0).Points(0).Color = Color.LawnGreen
            .Series(0).Points.AddXY("SCARTI", mGestoreCollaudo.Lotto.NumeroScarti)
            .Series(0).Points(1).Color = Color.Red
            .Series(0)("PieLabelStyle") = "Disabled"
            ' Resume the layout
            .ResumeLayout()
        End With

        With chrtGrafico2
            ' Suspend the layout
            .SuspendLayout()
            ' Clear the series
            .Series.Clear()
            ' Aggiungo la serie
            .Series.Add("")
            .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
            .Series(0).IsVisibleInLegend = True
            .Series(0).BorderWidth = 1
            .Series(0).BorderColor = Color.Black
            .Series(0).Points.AddXY("BUONI", mGestoreCollaudo.NumeroBuoni)
            .Series(0).Points(0).Color = Color.LawnGreen
            .Series(0).Points.AddXY("SCARTI", mGestoreCollaudo.NumeroScarti)
            .Series(0).Points(1).Color = Color.Red
            .Series(0)("PieLabelStyle") = "Disabled"
            ' Resume the layout
            .ResumeLayout()
        End With
    End Sub



    Public Sub VisualizzaRisultati()
        ' Visualizza l'esito complessivo grande
        If (mGestoreCollaudo.Risultati.Esito = cRisultati.eEsito.PezzoNonCollaudato) Then
            labEsito.Visible = False
        ElseIf (mGestoreCollaudo.Risultati.Esito = cRisultati.eEsito.ProvaInCorso) Then
            labEsito.Visible = True
            labEsito.Text = "PROVA IN CORSO..."
            labEsito.BackColor = Color.Yellow
        ElseIf (mGestoreCollaudo.Risultati.Esito = cRisultati.eEsito.Buono) Then
            labEsito.Visible = True
            labEsito.Text = "BUONO"
            labEsito.BackColor = Color.LawnGreen
        Else
            labEsito.Visible = True
            labEsito.Text = "SCARTO"
            labEsito.BackColor = Color.Red
        End If
        ' Riferimento alla tabella
        With dgvRisultati
            ' Disabilita il refresh
            .SuspendLayout()
            ' Visualizza i valori (in base alla cella in collaudo
            Select Case mGestoreCollaudo.Lotto.Ricetta.TipologiaSonda.ValoreStringa
                Case "LSU-4-9   "
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.Val, dgvRisultati, 0)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.Rheater, dgvRisultati, 1)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.Lsu_TemperaturaOperativa, dgvRisultati, 2)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.Lsu_O2, dgvRisultati, 3)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.Lsu_ResistenzaCalibrazione, dgvRisultati, 4)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.CorrenteRiscaldatore, dgvRisultati, 5)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.ResistenzaIsolamento, dgvRisultati, 6)

                Case "ADV"
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.Val, dgvRisultati, 0)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.Rheater, dgvRisultati, 1)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.ADVlambda, dgvRisultati, 2)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.ADVIp, dgvRisultati, 3)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.CorrenteRiscaldatore, dgvRisultati, 4)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.ResistenzaIsolamento, dgvRisultati, 5)

                Case Else
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.Val, dgvRisultati, 0)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.Rheater, dgvRisultati, 1)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.ZfasIpEtas, dgvRisultati, 2)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.ZfasIpTB, dgvRisultati, 3)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.CorrenteRiscaldatore, dgvRisultati, 4)
                    VisualizzaValoreRisultato(mGestoreCollaudo.Risultati.ResistenzaIsolamento, dgvRisultati, 5)

            End Select

            ' Riabilitazione del refresh
            .ResumeLayout(True)
        End With
        ' Visualizza il grafico
        VisualizzaGrafico()
    End Sub



    Private Sub VisualizzaValoreRisultato(ByVal valore As cValoreRisultato, _
                                          ByRef tabella As DataGridView, _
                                          ByVal riga As Integer)
        ' Riferimento alla tabella
        With tabella
            ' Visualizza i limiti minimo e massimo
            If (valore.Esito = cValoreRisultato.eEsito.NonProvato Or _
                valore.Esito = cValoreRisultato.eEsito.Disabilitato) Then
                .Item(2, riga).Value = ""
                .Item(4, riga).Value = ""
            ElseIf (valore.Esito = cValoreRisultato.eEsito.Sconosciuto Or _
                    valore.Esito = cValoreRisultato.eEsito.Ok Or _
                    valore.Esito = cValoreRisultato.eEsito.Ko) Then
                .Item(2, riga).Value = valore.MinimoStringa & " " & valore.UnitàDiMisura
                If (CDbl(valore.MassimoStringa) > 999998) Then
                    .Item(4, riga).Value = "∞" & " " & valore.UnitàDiMisura
                Else
                    .Item(4, riga).Value = valore.MassimoStringa & " " & valore.UnitàDiMisura
                End If
                .Item(4, riga).Value = valore.MassimoStringa & " " & valore.UnitàDiMisura
            End If
            ' Visualizza il valore
            If (valore.Esito = cValoreRisultato.eEsito.NonProvato) Then
                .Item(3, riga).Value = valore.ValoreStringa & " " & valore.UnitàDiMisura
                .Item(3, riga).Style.BackColor = Color.White
            ElseIf (valore.Esito = cValoreRisultato.eEsito.Disabilitato) Then
                .Item(3, riga).Value = "---"
                .Item(3, riga).Style.BackColor = Color.LightGray
            ElseIf (valore.Esito = cValoreRisultato.eEsito.Sconosciuto) Then
                .Item(3, riga).Value = "???"
                .Item(3, riga).Style.BackColor = Color.Yellow
            ElseIf (valore.Esito = cValoreRisultato.eEsito.Ok) Then
                .Item(3, riga).Value = valore.ValoreStringa & " " & valore.UnitàDiMisura
                .Item(3, riga).Style.BackColor = Color.LawnGreen
            ElseIf (mGestoreCollaudo.Fase = eFase.LSU4_9_MisuraO2 And (riga = 2 Or riga = 3 Or riga = 4)) Then
                'Se la misura è relativa a temperatura e O2% evidenzio in giallo il valore anche se errato finché non finisce di riscaldare
                .Item(3, riga).Value = valore.ValoreStringa & " " & valore.UnitàDiMisura
                .Item(3, riga).Style.BackColor = Color.Yellow
            Else
                .Item(3, riga).Value = valore.ValoreStringa & " " & valore.UnitàDiMisura
                .Item(3, riga).Style.BackColor = Color.Red
            End If
        End With
    End Sub



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Sub btnCicloManuale_Click(sender As System.Object, e As System.EventArgs) Handles btnCicloManuale.Click
        ' Abilita o disabilita il ciclo manuale
        mGestoreCollaudo.CicloManuale = Not (mGestoreCollaudo.CicloManuale)
    End Sub



    Private Sub btnCicloMaster_Click(sender As System.Object, e As System.EventArgs) Handles btnCicloMaster.Click
        ' Abilita o disabilita il ciclo master
        mGestoreCollaudo.CicloMaster = Not (mGestoreCollaudo.CicloMaster)
    End Sub



    Private Sub btnRipassoScarti_Click(sender As System.Object, e As System.EventArgs) Handles btnRipassoScarti.Click
        ' Abilita o disabilita il ciclo master
        mGestoreCollaudo.RipassoScarti = Not (mGestoreCollaudo.RipassoScarti)
    End Sub



    Private Sub btnUscita_Click(sender As System.Object, e As System.EventArgs)
        ' Chiude la finestra
        Me.Close()
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Chiusura della finestra
        Me.Close()
    End Sub



    Private Sub btnRisultati_Click(sender As Object, e As EventArgs) Handles btnRisultati.Click
        frmRisultati.ShowDialog()
    End Sub



    Private Sub dgvRisultati_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Cancella la selezione di celle
        dgvRisultati.ClearSelection()
    End Sub



    Private Sub frmCollaudo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Se il ciclo non è in corso
        If Not (mGestoreCollaudo.CicloInCorso) Then
            ' Chiude la sessione
            mGestoreCollaudo.ChiudiSessione()
            ' Disabilita il ciclo
            _abilitazioneCiclo = False
            ' Disabilita il timer di monitoraggio
            tmrMonitor.Enabled = False
            tmrCiclo.Enabled = False
        Else    ' Altrimenti
            e.Cancel = True
        End If
    End Sub



    Private Sub frmCollaudo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Apre la finestra a tutto schermo
        Me.WindowState = FormWindowState.Maximized
        ' Inizializza la tabella dei risultati
        InizializzaTabellaRisultati()
        ' Visualizza le informazioni sul lotto
        labNomeLotto.Text = mGestoreCollaudo.Lotto.Nome
        labDataOraCreazione.Text = mGestoreCollaudo.Lotto.DataCreazione
        labNumeroOrdine.Text = mGestoreCollaudo.Lotto.NumeroOrdine
        labNomeRicetta.Text = mGestoreCollaudo.Lotto.NomeRicetta
        labNomeRicettaMaster.Text = mGestoreCollaudo.Lotto.Ricetta.NomeRicettaMaster.Valore.ToString
        labCodiceAttrezzatura.Text = mGestoreCollaudo.Lotto.Ricetta.CodiceAttrezzatura.Valore.ToString
        ' Apre la sessione
        mGestoreCollaudo.ApriSessione()
        ' Visualizza i contatori
        VisualizzaContatori()
        ' Visualizza i risultati
        VisualizzaRisultati()
        ' Configura ed abilita il timer di monitoraggio
        tmrMonitor.Interval = 250
        tmrMonitor.Enabled = True
        ' Configura ed abilita il timer di ciclo
        tmrCiclo.Interval = 10
        tmrCiclo.Enabled = True
        ' Visualizza il grafico
        VisualizzaGrafico()
        ' Inizializza la barra di stato
        mBarraStato.Inizializza(ssBarraStato)
    End Sub



    Private Sub InizializzaTabellaRisultati()
        ' Riferimento alla tabella
        With dgvRisultati
            ' Disabilita il refresh
            .SuspendLayout()
            ' Configura il numero di righe e colonne
            .RowCount = 28
            .ColumnCount = 5
            ' Configura le righe
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False
            For i = 0 To .RowCount - 1
                .Rows(i).Height = 30
                .Item(0, i).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Item(1, i).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Item(2, i).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Item(3, i).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Item(4, i).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next
            ' Configura le colonne
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .ColumnHeadersVisible = True
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10)
            .ColumnHeadersHeight = 20
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(0).Width = CInt(0.15 * .Width)
            .Columns(1).Width = CInt(0.4 * .Width)
            .Columns(2).Width = CInt(0.15 * .Width)
            .Columns(3).Width = CInt(0.15 * .Width)
            .Columns(4).Width = CInt(0.15 * .Width)
            .Columns(0).Name = "Simbolo"
            .Columns(1).Name = "Descrizione"
            .Columns(2).Name = "Minimo"
            .Columns(3).Name = "Valore"
            .Columns(4).Name = "Massimo"
            .ScrollBars = ScrollBars.None
            ' Configura le celle
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Font = New Font("Arial", 10)
            ' Configura la modalità di modifica
            .EditMode = DataGridViewEditMode.EditProgrammatically
            ' Disabilita le selezioni multiple
            .MultiSelect = False
            ' Visualizza le descrizioni (in base alla cella in collaudo
            Select Case mGestoreCollaudo.Lotto.Ricetta.TipologiaSonda.ValoreStringa
                Case "LSU-4-9   "
                    ' Stampa il simbolo dei valori
                    .Item(0, 0).Value = mGestoreCollaudo.Risultati.Val.Simbolo
                    .Item(0, 1).Value = mGestoreCollaudo.Risultati.Rheater.Simbolo
                    .Item(0, 2).Value = mGestoreCollaudo.Risultati.Lsu_TemperaturaOperativa.Simbolo
                    .Item(0, 3).Value = mGestoreCollaudo.Risultati.Lsu_O2.Simbolo
                    .Item(0, 4).Value = mGestoreCollaudo.Risultati.CorrenteRiscaldatore.Simbolo
                    .Item(0, 5).Value = mGestoreCollaudo.Risultati.Lsu_ResistenzaCalibrazione.Simbolo
                    .Item(0, 6).Value = mGestoreCollaudo.Risultati.ResistenzaIsolamento.Simbolo
                    ' Stampa la descrizione dei valori
                    .Item(1, 0).Value = mGestoreCollaudo.Risultati.Val.Descrizione
                    .Item(1, 1).Value = mGestoreCollaudo.Risultati.Rheater.Descrizione
                    .Item(1, 2).Value = mGestoreCollaudo.Risultati.Lsu_TemperaturaOperativa.Descrizione
                    .Item(1, 3).Value = mGestoreCollaudo.Risultati.Lsu_O2.Descrizione
                    .Item(1, 4).Value = mGestoreCollaudo.Risultati.CorrenteRiscaldatore.Descrizione
                    .Item(1, 5).Value = mGestoreCollaudo.Risultati.Lsu_ResistenzaCalibrazione.Descrizione
                    .Item(1, 6).Value = mGestoreCollaudo.Risultati.ResistenzaIsolamento.Descrizione

                Case "ADV"
                    .Item(0, 0).Value = mGestoreCollaudo.Risultati.Val.Simbolo
                    .Item(0, 1).Value = mGestoreCollaudo.Risultati.Rheater.Simbolo
                    .Item(0, 2).Value = mGestoreCollaudo.Risultati.ADVlambda.Simbolo
                    .Item(0, 3).Value = mGestoreCollaudo.Risultati.ADVIp.Simbolo
                    .Item(0, 4).Value = mGestoreCollaudo.Risultati.CorrenteRiscaldatore.Simbolo
                    .Item(0, 5).Value = mGestoreCollaudo.Risultati.ResistenzaIsolamento.Simbolo
                    ' Stampa la descrizione dei valori
                    .Item(1, 0).Value = mGestoreCollaudo.Risultati.Val.Descrizione
                    .Item(1, 1).Value = mGestoreCollaudo.Risultati.Rheater.Descrizione
                    .Item(1, 2).Value = mGestoreCollaudo.Risultati.ADVlambda.Descrizione
                    .Item(1, 3).Value = mGestoreCollaudo.Risultati.ADVIp.Descrizione
                    .Item(1, 4).Value = mGestoreCollaudo.Risultati.CorrenteRiscaldatore.Descrizione
                    .Item(1, 5).Value = mGestoreCollaudo.Risultati.ResistenzaIsolamento.Descrizione

                Case Else
                    .Item(0, 0).Value = mGestoreCollaudo.Risultati.Val.Simbolo
                    .Item(0, 1).Value = mGestoreCollaudo.Risultati.Rheater.Simbolo
                    .Item(0, 2).Value = mGestoreCollaudo.Risultati.ZfasIpEtas.Simbolo
                    .Item(0, 3).Value = mGestoreCollaudo.Risultati.ZfasIpTB.Simbolo
                    .Item(0, 4).Value = mGestoreCollaudo.Risultati.CorrenteRiscaldatore.Simbolo
                    .Item(0, 5).Value = mGestoreCollaudo.Risultati.ResistenzaIsolamento.Simbolo
                    ' Stampa la descrizione dei valori
                    .Item(1, 0).Value = mGestoreCollaudo.Risultati.Val.Descrizione
                    .Item(1, 1).Value = mGestoreCollaudo.Risultati.Rheater.Descrizione
                    .Item(1, 2).Value = mGestoreCollaudo.Risultati.ZfasIpEtas.Descrizione
                    .Item(1, 3).Value = mGestoreCollaudo.Risultati.ZfasIpTB.Descrizione
                    .Item(1, 4).Value = mGestoreCollaudo.Risultati.CorrenteRiscaldatore.Descrizione
                    .Item(1, 5).Value = mGestoreCollaudo.Risultati.ResistenzaIsolamento.Descrizione

            End Select
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ' Enable the refresh
            .ResumeLayout(True)
        End With
    End Sub



    Private Sub tmrMonitor_Tick(sender As System.Object, e As System.EventArgs) Handles tmrMonitor.Tick
        Static t0Blink As Date

        ' Disabilita il timer
        tmrMonitor.Enabled = False
        ' Evidenzia il pulsante ciclo master
        If (mGestoreCollaudo.CicloMaster And _blink) Then
            btnCicloMaster.BackColor = Color.Yellow
        Else
            btnCicloMaster.BackColor = SystemColors.ButtonFace
            btnCicloMaster.UseVisualStyleBackColor = True
        End If
        ' Evidenzia il pulsante ripasso scarti
        If (mGestoreCollaudo.RipassoScarti And _blink) Then
            btnRipassoScarti.BackColor = Color.Yellow
        Else
            btnRipassoScarti.BackColor = SystemColors.ButtonFace
            btnRipassoScarti.UseVisualStyleBackColor = True
        End If
        ' Evidenzia il pulsante ciclo manuale
        If (mGestoreCollaudo.CicloManuale And _blink) Then
            btnCicloManuale.BackColor = Color.Yellow
        Else
            btnCicloManuale.BackColor = SystemColors.ButtonFace
            btnCicloManuale.UseVisualStyleBackColor = True
        End If
        ' Visualizza la fase corrente
        labFase.Text = mGestoreCollaudo.DescrizioneFase
        ' Genera il flag di lampeggio
        If ((Date.Now - t0Blink).TotalSeconds > 0.5) Then
            _blink = Not (_blink)
            t0Blink = Date.Now
        End If
        ' Riabilita il timer
        tmrMonitor.Enabled = True
        ' Aggiorna la barra di stato
        mBarraStato.Aggiorna(ssBarraStato)
    End Sub



    Private Sub frmCollaudo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ' Se il flag di abilitazione ciclo non è attivo
        If Not (_abilitazioneCiclo) Then
            ' Setta il flag di abilitazione ciclo
            _abilitazioneCiclo = True
            ' Richiede la verifica del codice della attrezzatura
            MsgBox("Verificare il codice della attrezzatura: " & CStr(mGestoreCollaudo.Lotto.Ricetta.CodiceAttrezzatura.Valore), _
                   CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                   "Informazione")
            While (_abilitazioneCiclo)
                mGestoreCollaudo.Ciclo()
                Application.DoEvents()
            End While
        End If
    End Sub



    Private Sub tmrCiclo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCiclo.Tick
        ' Disabilita il timer
        tmrCiclo.Enabled = False
        ' Esegue il ciclo
        mGestoreCollaudo.Ciclo()
        ' Riabilita il timer
        tmrCiclo.Enabled = _abilitazioneCiclo
    End Sub
End Class
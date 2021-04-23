Option Explicit On

Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class frmRisultati
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _lotto As New cLotto



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Sub btnChiudiLotto_Click(sender As System.Object, e As System.EventArgs) Handles btnChiudiLotto.Click
        ' Abilita i controlli di gestione dei lotti
        gbGestioneLotti.Enabled = True
        ' Nasconde i parametri del lotto
        tcLotto.Visible = False
        btnChiudiLotto.Visible = False
    End Sub



    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportBuoni.Click, _
                                                                                                    btnReportScartiNonRipassati.Click, _
                                                                                                    btnReportScartiRipassati.Click, _
                                                                                                    btnReportCompleto.Click
        Dim app As Excel.Application
        Dim campo() As String
        Dim data As Date
        Dim errore As Boolean
        Dim flag As Boolean
        Dim linea As String
        Dim nomeFile As String
        Dim percorsoCompleto As String
        Dim ricetta As New cRicetta
        Dim riga As Integer
        Dim risultati As New cRisultati
        Dim sr As StreamReader
        Dim workbook As Excel.Workbook
        Dim worksheet As Excel.Worksheet

        ' Cursore a clessidra
        Me.Cursor = Cursors.WaitCursor
        ' Imposta il nome del lotto
        nomeFile = mGlobale.PercorsoReportLotti & "\MA01946 - Report lotto " & lbLotti.SelectedItem & " " & Format(Date.Now, "yyyyMMdd_HHmmss") & ".xls"
        percorsoCompleto = Path.GetFullPath(nomeFile)
        Try
            ' Crea il report copiando il modello (scelta modello a seconda del tipo di cella collaudato)
            data = Date.Now
            File.Copy(mGlobale.PercorsoModelliReport & "\MA01946 - Report lotto " & _lotto.Ricetta.TipologiaSonda.ValoreStringa & ".xls", nomeFile, True)
            ' Apre il foglio di calcolo
            app = New Excel.Application
            workbook = app.Workbooks.Open(percorsoCompleto)
            worksheet = workbook.Worksheets("Foglio1")
            ' Scrive la data
            worksheet.Cells(worksheet.Range("O2").Row, worksheet.Range("O2").Column).Value = Format(Date.Now, "dd/MM/yyyy")
            ' Scrive il nome del file
            worksheet.Cells(worksheet.Range("O3").Row, worksheet.Range("O3").Column).Value = lbLotti.SelectedItem & "_" & Format(Date.Now, "yyyyMMdd_HHmmss")
            ' Scrive le informazioni sul lotto
            worksheet.Cells(worksheet.Range("C5").Row, worksheet.Range("C5").Column).Value = _lotto.Nome
            worksheet.Cells(worksheet.Range("D5").Row, worksheet.Range("D5").Column).Value = _lotto.DataCreazione
            worksheet.Cells(worksheet.Range("E5").Row, worksheet.Range("E5").Column).Value = _lotto.NumeroOrdine
            worksheet.Cells(worksheet.Range("F5").Row, worksheet.Range("F5").Column).Value = _lotto.NomeRicetta
            worksheet.Cells(worksheet.Range("G5").Row, worksheet.Range("G5").Column).Value = _lotto.Ricetta.IndiceRevisione.Valore
            worksheet.Cells(worksheet.Range("H5").Row, worksheet.Range("H5").Column).value = _lotto.Ricetta.Lsu_Flusso_Aria_Erogato.ValoreStringa
            worksheet.Cells(worksheet.Range("I5").Row, worksheet.Range("I5").Column).value = _lotto.Ricetta.Lsu_Flusso_N2_Erogato.ValoreStringa
            worksheet.Cells(worksheet.Range("J5").Row, worksheet.Range("J5").Column).value = _lotto.Ricetta.Tempo_Riscaldamento.ValoreStringa
            worksheet.Cells(worksheet.Range("K5").Row, worksheet.Range("K5").Column).value = _lotto.Ricetta.Lsu_Target_O2.ValoreStringa
            ' Scrive le statistiche sul lotto
            worksheet.Cells(worksheet.Range("C7").Row, worksheet.Range("C7").Column).Value = _lotto.NumeroBuoniNonRipassati
            worksheet.Cells(worksheet.Range("D7").Row, worksheet.Range("D7").Column).Value = _lotto.NumeroScartiNonRipassati
            worksheet.Cells(worksheet.Range("E7").Row, worksheet.Range("E7").Column).Value = _lotto.NumeroPezziNonRipassati
            worksheet.Cells(worksheet.Range("F7").Row, worksheet.Range("F7").Column).Value = _lotto.NumeroBuoniRipassati
            worksheet.Cells(worksheet.Range("G7").Row, worksheet.Range("G7").Column).Value = _lotto.NumeroScartiRipassati
            worksheet.Cells(worksheet.Range("H7").Row, worksheet.Range("H7").Column).Value = _lotto.NumeroPezziRipassati
            worksheet.Cells(worksheet.Range("I7").Row, worksheet.Range("I7").Column).Value = _lotto.NumeroBuoni
            worksheet.Cells(worksheet.Range("J7").Row, worksheet.Range("J7").Column).Value = _lotto.NumeroScarti
            worksheet.Cells(worksheet.Range("K7").Row, worksheet.Range("K7").Column).Value = _lotto.NumeroPezzi
            If (_lotto.NumeroPezzi > 0) Then
                worksheet.Cells(worksheet.Range("L7").Row, worksheet.Range("L7").Column).Value = Math.Round(_lotto.NumeroBuoni / _lotto.NumeroPezzi * 100, 1)
                worksheet.Cells(worksheet.Range("M7").Row, worksheet.Range("M7").Column).Value = Math.Round(_lotto.NumeroScarti / _lotto.NumeroPezzi * 100, 1)
            End If
            ' Scrive i parametri della ricetta
            worksheet.Cells(worksheet.Range("C11").Row, worksheet.Range("C11").Column).Value = (_lotto.Ricetta.Val_Min.Valore + _lotto.Ricetta.Val_Max.Valore) / 2
            worksheet.Cells(worksheet.Range("C12").Row, worksheet.Range("C12").Column).Value = _lotto.Ricetta.Val_Max.Valore - _lotto.Ricetta.Val_Min.Valore
            worksheet.Cells(worksheet.Range("C13").Row, worksheet.Range("C13").Column).Value = _lotto.Ricetta.Val_Min.Valore
            worksheet.Cells(worksheet.Range("C14").Row, worksheet.Range("C14").Column).Value = _lotto.Ricetta.Val_Max.Valore
            If (_lotto.Ricetta.Rheater_Abilitazione.Valore) Then
                worksheet.Cells(worksheet.Range("D11").Row, worksheet.Range("D11").Column).Value = (_lotto.Ricetta.Rheater_Min.Valore + _lotto.Ricetta.Rheater_Max.Valore) / 2
                worksheet.Cells(worksheet.Range("D12").Row, worksheet.Range("D12").Column).Value = _lotto.Ricetta.Rheater_Max.Valore - _lotto.Ricetta.Rheater_Min.Valore
                worksheet.Cells(worksheet.Range("D13").Row, worksheet.Range("D13").Column).Value = _lotto.Ricetta.Rheater_Min.Valore
                worksheet.Cells(worksheet.Range("D14").Row, worksheet.Range("D14").Column).Value = _lotto.Ricetta.Rheater_Max.Valore
            End If
            ' Inserisco i parametri per le LSU 4.9
            If (_lotto.Ricetta.TipologiaSonda.ValoreStringa = "LSU 4.9") Then
                If (_lotto.Ricetta.Lsu_Temperatura_Operativa_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("E11").Row, worksheet.Range("E11").Column).Value = (_lotto.Ricetta.Lsu_Temperatura_Operativa_Min.Valore + _lotto.Ricetta.Lsu_Temperatura_Operativa_Max.Valore) / 2
                    worksheet.Cells(worksheet.Range("E12").Row, worksheet.Range("E12").Column).Value = _lotto.Ricetta.Lsu_Temperatura_Operativa_Max.Valore - _lotto.Ricetta.Lsu_Temperatura_Operativa_Min.Valore
                    worksheet.Cells(worksheet.Range("E13").Row, worksheet.Range("E13").Column).Value = _lotto.Ricetta.Lsu_Temperatura_Operativa_Min.Valore
                    worksheet.Cells(worksheet.Range("E14").Row, worksheet.Range("E14").Column).Value = _lotto.Ricetta.Lsu_Temperatura_Operativa_Max.Valore
                End If
                If (_lotto.Ricetta.Lsu_O2_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("F11").Row, worksheet.Range("F11").Column).Value = (_lotto.Ricetta.Lsu_O2_Min.Valore + _lotto.Ricetta.Lsu_O2_Max.Valore) / 2
                    worksheet.Cells(worksheet.Range("F12").Row, worksheet.Range("F12").Column).Value = _lotto.Ricetta.Lsu_O2_Max.Valore - _lotto.Ricetta.Lsu_O2_Min.Valore
                    worksheet.Cells(worksheet.Range("F13").Row, worksheet.Range("F13").Column).Value = _lotto.Ricetta.Lsu_O2_Min.Valore
                    worksheet.Cells(worksheet.Range("F14").Row, worksheet.Range("F14").Column).Value = _lotto.Ricetta.Lsu_O2_Max.Valore
                End If
                If (_lotto.Ricetta.Lsu_Resistenza_Calibrazione_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("G11").Row, worksheet.Range("G11").Column).Value = (_lotto.Ricetta.Lsu_Resistenza_Calibrazione_Min.Valore + _lotto.Ricetta.Lsu_Resistenza_Calibrazione_Max.Valore) / 2
                    worksheet.Cells(worksheet.Range("G12").Row, worksheet.Range("G12").Column).Value = _lotto.Ricetta.Lsu_Resistenza_Calibrazione_Max.Valore - _lotto.Ricetta.Lsu_Resistenza_Calibrazione_Min.Valore
                    worksheet.Cells(worksheet.Range("G13").Row, worksheet.Range("G13").Column).Value = _lotto.Ricetta.Lsu_Resistenza_Calibrazione_Min.Valore
                    worksheet.Cells(worksheet.Range("G14").Row, worksheet.Range("G14").Column).Value = _lotto.Ricetta.Lsu_Resistenza_Calibrazione_Max.Valore
                End If
                If (_lotto.Ricetta.Corrente_Riscaldatore_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("H11").Row, worksheet.Range("H11").Column).Value = (_lotto.Ricetta.Corrente_Riscaldatore_Min.Valore + _lotto.Ricetta.Corrente_Riscaldatore_Max.Valore) / 2
                    worksheet.Cells(worksheet.Range("H12").Row, worksheet.Range("H12").Column).Value = _lotto.Ricetta.Corrente_Riscaldatore_Max.Valore - _lotto.Ricetta.Corrente_Riscaldatore_Min.Valore
                    worksheet.Cells(worksheet.Range("H13").Row, worksheet.Range("H13").Column).Value = _lotto.Ricetta.Corrente_Riscaldatore_Min.Valore
                    worksheet.Cells(worksheet.Range("H14").Row, worksheet.Range("H14").Column).Value = _lotto.Ricetta.Corrente_Riscaldatore_Max.Valore
                End If
                If (_lotto.Ricetta.Resistenza_Isolamento_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("I13").Row, worksheet.Range("I13").Column).Value = _lotto.Ricetta.Resistenza_Isolamento_Min.Valore
                End If
            ElseIf (_lotto.Ricetta.TipologiaSonda.ValoreStringa = "ADV") Then
                If (_lotto.Ricetta.Adv_Lambda_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("E11").Row, worksheet.Range("E11").Column).Value = (_lotto.Ricetta.Adv_Lambda_Min.Valore + _lotto.Ricetta.Adv_Lambda_Max.Valore) / 2
                    worksheet.Cells(worksheet.Range("E12").Row, worksheet.Range("E12").Column).Value = _lotto.Ricetta.Adv_Lambda_Max.Valore - _lotto.Ricetta.Adv_Lambda_Min.Valore
                    worksheet.Cells(worksheet.Range("E13").Row, worksheet.Range("E13").Column).Value = _lotto.Ricetta.Adv_Lambda_Min.Valore
                    worksheet.Cells(worksheet.Range("E14").Row, worksheet.Range("E14").Column).Value = _lotto.Ricetta.Adv_Lambda_Max.Valore
                End If
                If (_lotto.Ricetta.Adv_Ip_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("F11").Row, worksheet.Range("F11").Column).Value = (_lotto.Ricetta.Adv_Ip_Min.Valore + _lotto.Ricetta.Adv_Ip_Max.Valore) / 2
                    worksheet.Cells(worksheet.Range("F12").Row, worksheet.Range("F12").Column).Value = _lotto.Ricetta.Adv_Ip_Max.Valore - _lotto.Ricetta.Adv_Ip_Min.Valore
                    worksheet.Cells(worksheet.Range("F13").Row, worksheet.Range("F13").Column).Value = _lotto.Ricetta.Adv_Ip_Min.Valore
                    worksheet.Cells(worksheet.Range("F14").Row, worksheet.Range("F14").Column).Value = _lotto.Ricetta.Adv_Ip_Max.Valore
                End If
                If (_lotto.Ricetta.Corrente_Riscaldatore_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("G11").Row, worksheet.Range("G11").Column).Value = (_lotto.Ricetta.Corrente_Riscaldatore_Min.Valore + _lotto.Ricetta.Corrente_Riscaldatore_Max.Valore) / 2
                    worksheet.Cells(worksheet.Range("G12").Row, worksheet.Range("G12").Column).Value = _lotto.Ricetta.Corrente_Riscaldatore_Max.Valore - _lotto.Ricetta.Corrente_Riscaldatore_Min.Valore
                    worksheet.Cells(worksheet.Range("G13").Row, worksheet.Range("G13").Column).Value = _lotto.Ricetta.Corrente_Riscaldatore_Min.Valore
                    worksheet.Cells(worksheet.Range("G14").Row, worksheet.Range("G14").Column).Value = _lotto.Ricetta.Corrente_Riscaldatore_Max.Valore
                End If
                If (_lotto.Ricetta.Resistenza_Isolamento_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("H13").Row, worksheet.Range("H13").Column).Value = _lotto.Ricetta.Resistenza_Isolamento_Min.Valore
                End If
            Else
                If (_lotto.Ricetta.Zfas_IpEtas_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("E11").Row, worksheet.Range("E11").Column).Value = (_lotto.Ricetta.Zfas_IpEtas_Min.Valore + _lotto.Ricetta.Zfas_IpEtas_Max.Valore) / 2
                    worksheet.Cells(worksheet.Range("E12").Row, worksheet.Range("E12").Column).Value = _lotto.Ricetta.Zfas_IpEtas_Max.Valore - _lotto.Ricetta.Zfas_IpEtas_Min.Valore
                    worksheet.Cells(worksheet.Range("E13").Row, worksheet.Range("E13").Column).Value = _lotto.Ricetta.Zfas_IpEtas_Min.Valore
                    worksheet.Cells(worksheet.Range("E14").Row, worksheet.Range("E14").Column).Value = _lotto.Ricetta.Zfas_IpEtas_Max.Valore
                End If
                If (_lotto.Ricetta.Zfas_IpTB_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("F11").Row, worksheet.Range("F11").Column).Value = (_lotto.Ricetta.Zfas_IpTB_Min.Valore + _lotto.Ricetta.Zfas_IpTB_Max.Valore) / 2
                    worksheet.Cells(worksheet.Range("F12").Row, worksheet.Range("F12").Column).Value = _lotto.Ricetta.Zfas_IpTB_Max.Valore - _lotto.Ricetta.Zfas_IpTB_Min.Valore
                    worksheet.Cells(worksheet.Range("F13").Row, worksheet.Range("F13").Column).Value = _lotto.Ricetta.Zfas_IpTB_Min.Valore
                    worksheet.Cells(worksheet.Range("F14").Row, worksheet.Range("F14").Column).Value = _lotto.Ricetta.Zfas_IpTB_Max.Valore
                End If
                If (_lotto.Ricetta.Corrente_Riscaldatore_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("G11").Row, worksheet.Range("G11").Column).Value = (_lotto.Ricetta.Corrente_Riscaldatore_Min.Valore + _lotto.Ricetta.Corrente_Riscaldatore_Max.Valore) / 2
                    worksheet.Cells(worksheet.Range("G12").Row, worksheet.Range("G12").Column).Value = _lotto.Ricetta.Corrente_Riscaldatore_Max.Valore - _lotto.Ricetta.Corrente_Riscaldatore_Min.Valore
                    worksheet.Cells(worksheet.Range("G13").Row, worksheet.Range("G13").Column).Value = _lotto.Ricetta.Corrente_Riscaldatore_Min.Valore
                    worksheet.Cells(worksheet.Range("G14").Row, worksheet.Range("G14").Column).Value = _lotto.Ricetta.Corrente_Riscaldatore_Max.Valore
                End If
                If (_lotto.Ricetta.Resistenza_Isolamento_Abilitazione.Valore) Then
                    worksheet.Cells(worksheet.Range("H13").Row, worksheet.Range("H13").Column).Value = _lotto.Ricetta.Resistenza_Isolamento_Min.Valore
                End If
            End If

            ' Apre il file dei risultati del lotto
            sr = New StreamReader(mGlobale.PercorsoLotti & "\" & _lotto.Nome & "\Risultati.txt")
            ' Finché non è raggiunta la fine del file
            linea = sr.ReadLine
            While Not (sr.EndOfStream)
                ' Legge una riga
                linea = sr.ReadLine
                ' Separa i campi
                campo = Split(linea, vbTab)
                ' Recupera i singoli valori dei risultati
                risultati.DataCollaudo.ValoreStringa = campo(0)
                risultati.OraCollaudo.ValoreStringa = campo(1)
                risultati.Esito = campo(2)
                risultati.PezzoRipassato.ValoreStringa = campo(3)
                risultati.Val.ValoreStringa = campo(4)
                risultati.Rheater.ValoreStringa = campo(5)
                risultati.CorrenteRiscaldatore.Valore = campo(6)
                risultati.ResistenzaIsolamento.Valore = campo(7)
                ' LSU 4.9
                risultati.Lsu_TemperaturaOperativa.Valore = campo(8)
                risultati.Lsu_O2.Valore = campo(9)
                risultati.Lsu_ResistenzaCalibrazione.Valore = campo(10)
                ' ADV
                risultati.ADVIp.Valore = campo(11)
                risultati.ADVlambda.Valore = campo(12)
                ' ZFAS-U2
                risultati.ZfasIpEtas.Valore = campo(13)
                risultati.ZfasIpTB.Valore = campo(14)
                ' Stabilisce se i risultati devono essere inseriti nel report
                flag = (sender Is btnReportCompleto) Or
                       (sender Is btnReportBuoni And risultati.Esito = cRisultati.eEsito.Buono) Or
                       (sender Is btnReportScartiNonRipassati And Not risultati.PezzoRipassato.Valore And Not risultati.Esito = cRisultati.eEsito.Buono) Or
                       (sender Is btnReportScartiRipassati And risultati.PezzoRipassato.Valore)
                ' Inserisce i risultati nel report
                If (flag) Then
                    worksheet.Cells(15 + riga, 1).Value = risultati.DataCollaudo.Valore
                    worksheet.Cells(15 + riga, 2).Value = risultati.OraCollaudo.Valore
                    worksheet.Cells(15 + riga, 3).Value = risultati.Val.Valore
                    If (_lotto.Ricetta.Rheater_Abilitazione.Valore And risultati.Rheater.Valore <> 0) Then
                        worksheet.Cells(15 + riga, 4).Value = risultati.Rheater.Valore
                    End If
                    ' LSU 4.9
                    If (_lotto.Ricetta.TipologiaSonda.ValoreStringa = "LSU 4.9") Then
                        If (_lotto.Ricetta.Lsu_Temperatura_Operativa_Abilitazione.Valore And risultati.Lsu_TemperaturaOperativa.Valore <> 0) Then
                            worksheet.Cells(15 + riga, 5).Value = risultati.Lsu_TemperaturaOperativa.Valore
                        End If
                        If (_lotto.Ricetta.Lsu_O2_Abilitazione.Valore And risultati.Lsu_O2.Valore <> 0) Then
                            worksheet.Cells(15 + riga, 6).Value = risultati.Lsu_O2.Valore
                        End If
                        If (_lotto.Ricetta.Lsu_Resistenza_Calibrazione_Abilitazione.Valore And risultati.Lsu_ResistenzaCalibrazione.Valore <> 0) Then
                            worksheet.Cells(15 + riga, 7).Value = risultati.Lsu_ResistenzaCalibrazione.Valore
                        End If
                        If (_lotto.Ricetta.Corrente_Riscaldatore_Abilitazione.Valore And risultati.CorrenteRiscaldatore.Valore <> 0) Then
                            worksheet.Cells(15 + riga, 8).Value = risultati.CorrenteRiscaldatore.Valore
                        End If
                        If (_lotto.Ricetta.Resistenza_Isolamento_Abilitazione.Valore And risultati.ResistenzaIsolamento.Valore <> 0) Then
                            worksheet.Cells(15 + riga, 9).Value = risultati.ResistenzaIsolamento.Valore
                        End If
                    ElseIf (_lotto.Ricetta.TipologiaSonda.ValoreStringa = "ADV") Then
                        If (_lotto.Ricetta.Adv_Lambda_Abilitazione.Valore) Then
                            worksheet.Cells(15 + riga, 5).Value = risultati.ADVlambda.Valore
                        End If
                        If (_lotto.Ricetta.Adv_Ip_Abilitazione.Valore) Then
                            worksheet.Cells(15 + riga, 6).Value = risultati.ADVIp.Valore
                        End If
                        If (_lotto.Ricetta.Corrente_Riscaldatore_Abilitazione.Valore And risultati.CorrenteRiscaldatore.Valore <> 0) Then
                            worksheet.Cells(15 + riga, 7).Value = risultati.CorrenteRiscaldatore.Valore
                        End If
                        If (_lotto.Ricetta.Resistenza_Isolamento_Abilitazione.Valore And risultati.ResistenzaIsolamento.Valore <> 0) Then
                            worksheet.Cells(15 + riga, 8).Value = risultati.ResistenzaIsolamento.Valore
                        End If
                    Else
                        If (_lotto.Ricetta.Zfas_IpEtas_Abilitazione.Valore) Then
                            worksheet.Cells(15 + riga, 5).Value = risultati.ZfasIpEtas.Valore
                        End If
                        If (_lotto.Ricetta.Zfas_IpTB_Abilitazione.Valore) Then
                            worksheet.Cells(15 + riga, 6).Value = risultati.ZfasIpTB.Valore
                        End If
                        If (_lotto.Ricetta.Corrente_Riscaldatore_Abilitazione.Valore And risultati.CorrenteRiscaldatore.Valore <> 0) Then
                            worksheet.Cells(15 + riga, 7).Value = risultati.CorrenteRiscaldatore.Valore
                        End If
                        If (_lotto.Ricetta.Resistenza_Isolamento_Abilitazione.Valore And risultati.ResistenzaIsolamento.Valore <> 0) Then
                            worksheet.Cells(15 + riga, 8).Value = risultati.ResistenzaIsolamento.Valore
                        End If
                    End If
                    worksheet.Cells(15 + riga, 14).Value = IIf(risultati.PezzoRipassato.Valore, "SI", "NO")
                    worksheet.Cells(15 + riga, 15).Value = EsitoFACET(risultati.Esito)
                    worksheet.Rows(16 + riga).Insert()
                    riga = riga + 1
                End If
            End While
            ' Cancella le ultime due righe bianche
            worksheet.Cells(15 + riga, 1).EntireRow.Delete()
            worksheet.Cells(15 + riga, 1).EntireRow.Delete()
            sr.Close()
            sr = Nothing
            ' Salva e chiude il foglio di calcolo
            workbook.Save()
            workbook.Close()
            worksheet = Nothing
            workbook = Nothing
            app.Quit()
            app = Nothing
            ' Se è stata creata una cartella di backup per i report del lotto
            If (mImpostazioniGenerali.CartellaBackupLotti <> "") Then
                ' Copia il report appena creato nella cartella di backup
                File.Copy(percorsoCompleto, mImpostazioniGenerali.CartellaBackupLotti & "\" & percorsoCompleto.Substring(mGlobale.PercorsoReportLotti.Length), True)
            End If

        Catch ex As Exception
            ' Setta il flag d'errore
            errore = True
        End Try
        ' Cursore normale
        Me.Cursor = Cursors.Default
        ' Se non si sono verificati errori
        If Not (errore) Then
            ' Visualizza un messaggio di conferma
            MsgBox("Report generato con successo.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
            ' Apre il report in Excel
            Shell(mGlobale.PercorsoExcel & " """ & percorsoCompleto & """", AppWinStyle.MaximizedFocus, True)
        Else    ' Altrimenti, se si sono verificati errori
            ' Visualizza un messaggio di errore
            MsgBox("Errore nella generazione del report.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
    End Sub



    Private Function EsitoFACET(ByVal esito As cRisultati.eEsito) As String
        Select Case esito
            Case cRisultati.eEsito.Buono
                EsitoFACET = "BUONO"
            Case cRisultati.eEsito.ScartoVal
                EsitoFACET = "Scarto Val"
            Case cRisultati.eEsito.ScartoRheater
                EsitoFACET = "Scarto Rh"
            Case cRisultati.eEsito.Lsu_ScartoTemperaturaOperativa
                EsitoFACET = "Scarto Temperatura"
            Case cRisultati.eEsito.Lsu_ScartoO2
                EsitoFACET = "Scarto O2"
            Case cRisultati.eEsito.ScartoCorrenteRiscaldatore
                EsitoFACET = "Scarto Ih"
            Case cRisultati.eEsito.Lsu_ScartoResistenzaCalibrazione
                EsitoFACET = "Scarto Rcal"
            Case cRisultati.eEsito.ScartoResistenzaIsolamento
                EsitoFACET = "Scarto Ri-h"
            Case cRisultati.eEsito.Adv_ScartoIp
                EsitoFACET = "Scarto ADV Ip"
            Case cRisultati.eEsito.Adv_ScartoLambda
                EsitoFACET = "Scarto ADV Lambda"
            Case cRisultati.eEsito.Zfas_ScartoIpEtas
                EsitoFACET = "Scarto Ip Etas"
            Case cRisultati.eEsito.Zfas_ScartoIpTB
                EsitoFACET = "Scarto Ip TB"
            Case Else
                EsitoFACET = "???"
        End Select
    End Function



    Private Sub btnRicercaLotto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRicercaLotto.Click
        ' Configura e visualizza la finesta d'inserimento stringa
        frmInserimentoStringa.Descrizione = "Inserire il nome del lotto"
        frmInserimentoStringa.LunghezzaMassima = 10
        frmInserimentoStringa.Valore = ""
        frmInserimentoStringa.ShowDialog()
        ' Se il valore è confermato
        If (frmInserimentoStringa.ValoreConfermato) Then
            ' Converte il valore in maiuscolo
            frmInserimentoStringa.Valore = frmInserimentoStringa.Valore.ToUpper
            ' Se il valore è presente nella lista
            If (lbLotti.Items.IndexOf(frmInserimentoStringa.Valore) <> -1) Then
                ' Seleziona il valore
                lbLotti.SelectedItem = frmInserimentoStringa.Valore
            Else    ' Altrimenti, se il valore non è presente nella lista
                ' Visualizza un messaggio d'errore
                MsgBox(String.Format("Impossibile trovare la ricetta ""{0}"".", frmInserimentoStringa.Valore), CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
        End If
    End Sub



    Private Sub btnUscita_Click(sender As System.Object, e As System.EventArgs) Handles btnUscita.Click
        ' Chiude il form
        Me.Close()
    End Sub



    Private Sub btnVisualizzaLotto_Click(sender As System.Object, e As System.EventArgs) Handles btnVisualizzaLotto.Click
        ' Se è selezionato un lotto
        If (lbLotti.SelectedItem IsNot Nothing) Then
            ' Carica il lotto selezionato
            If (_lotto.Carica(lbLotti.SelectedItem.ToString)) Then
                MsgBox(String.Format("Errore nel caricamento del lotto ""{0}"".", lbLotti.SelectedItem), CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Disabilita i controlli di gestione dei lotti
            gbGestioneLotti.Enabled = False
            ' Visualizza i parametri del lotto
            tcLotto.Visible = True
            btnChiudiLotto.Visible = True
            ' Visualizza i dati del lotto
            VisualizzaDatiLotto()
        End If
    End Sub



    Private Sub chkAbilitazioneProva_Click(sender As Object, e As System.EventArgs)
        ' Ri-visualizza i dati del lotto per annullare la modifica
        VisualizzaDatiLotto()
    End Sub



    Private Sub frmRisultati_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim nomeLotto() As String = {}

        ' Legge la lista dei lotti
        If Not (cLotto.LeggiLista(nomeLotto)) Then
            lbLotti.Items.Clear()
            For i = 0 To nomeLotto.Length - 1
                lbLotti.Items.Add(nomeLotto(i))
            Next
        Else
            MsgBox("Errore nella lettura della lista dei lotti.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Abilita i controlli di gestione dei lotti
        gbGestioneLotti.Enabled = True
        ' Nasconde i parametri del lotto
        tcLotto.Visible = False
        btnChiudiLotto.Visible = False
    End Sub



    Private Sub lbLotti_DoubleClick(sender As Object, e As System.EventArgs) Handles lbLotti.DoubleClick
        ' Simula la pressione del pulsante visualizza lotto
        btnVisualizzaLotto.PerformClick()
    End Sub



    Private Sub VisualizzaDatiLotto()
        ' Visualizza i dati del lotto
        labDataCreazione.Text = _lotto.DataCreazione
        labNumeroOrdine.Text = _lotto.NumeroOrdine
        labNomeRicetta.Text = _lotto.NomeRicetta
        tbNote.Text = _lotto.Note
        labTotaleCollaudati.Text = _lotto.NumeroPezzi.ToString
        labTotaleBuoni.Text = _lotto.NumeroBuoni.ToString
        labTotaleScarti.Text = _lotto.NumeroScarti.ToString
        If (_lotto.NumeroPezzi > 0) Then
            labPercentualeBuoni.Text = (_lotto.NumeroBuoni / _lotto.NumeroPezzi * 100).ToString("0.0")
            labPercentualeScarti.Text = (_lotto.NumeroScarti / _lotto.NumeroPezzi * 100).ToString("0.0")
        Else
            labPercentualeBuoni.Text = ""
            labPercentualeScarti.Text = ""
        End If
    End Sub
End Class
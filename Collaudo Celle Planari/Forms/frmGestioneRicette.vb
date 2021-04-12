Option Explicit On

Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic.Strings
Imports System.IO

Public Class frmGestioneRicette
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _nomeRicetta As String
    Private _pagina As Integer
    Private _ricetta As New cRicetta
    Private _ricettaModificata As Boolean



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Sub AbilitaControlli()
        ' Abilita i controlli per la modifica della ricetta
        btnModificaRicetta.Enabled = False
        btnCaricaRicetta.Enabled = True
        btnSalvaRicetta.Enabled = True
        tcParametriRicetta.TabPages(0).Enabled = True
        gbVal.Enabled = True
        gbRheater.Enabled = True
        gbRiscaldamentoRaffreddamento.Enabled = True
        gbIheater.Enabled = True
        gbIsolamento.Enabled = True
        ' Abilito le groupbox specifiche a seconda del modello selezionato
        gbMisureLSU.Enabled = cbTipologia.SelectedIndex = 0
        gbMisureADV.Enabled = cbTipologia.SelectedIndex = 1
        gbMisureZFAS.Enabled = cbTipologia.SelectedIndex = 2
    End Sub



    Private Sub AggiornaListeRicette()
        Dim elencoRicette As String() = {}
        Dim ricettaLocale As New cRicetta

        ' Legge la lista delle ricette
        If (cRicetta.LeggiLista(elencoRicette)) Then
            MsgBox("Errore nella lettura della lista delle ricette.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
        Else
            ' Svuota le liste delle ricette
            lbListaRicette.Items.Clear()
            cbNomeRicettaMaster.Items.Clear()
            ' Costruisce la lista delle ricette
            For Each nome In elencoRicette
                If Not (ricettaLocale.Carica(nome)) Then
                    lbListaRicette.Items.Add(nome & "_" & ricettaLocale.IndiceRevisione.Valore)
                    cbNomeRicettaMaster.Items.Add(nome)
                    cbNomeRicettaMaster.SelectedItem = _ricetta.NomeRicettaMaster.ValoreStringa
                Else
                    MsgBox("Errore nel caricamento della ricetta """ & nome & """", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
                End If
            Next
        End If
    End Sub



    Private Sub btnCancella_Click(sender As System.Object, e As System.EventArgs) Handles btnCancella.Click
        Dim nomeRicetta As String

        ' Se è selezionata una ricetta
        If (lbListaRicette.SelectedItem IsNot Nothing) Then
            nomeRicetta = lbListaRicette.SelectedItem.ToString
            nomeRicetta = Microsoft.VisualBasic.Left(nomeRicetta, nomeRicetta.Length - 2)
            ' Se il livello della password è maggiore di 0
            If (mGestorePassword.Login(0) > 0) Then
                ' Se l'utente conferma l'operazione
                If (MsgBox(String.Format("Cancellare definitivamente la ricetta ""{0}""?", nomeRicetta), vbQuestion + MsgBoxStyle.YesNo, "Domanda") = MsgBoxResult.Yes) Then
                    ' Cancella la ricetta selezionata
                    If Not (cRicetta.Cancella(nomeRicetta)) Then
                        ' Aggiorna le liste delle ricette
                        AggiornaListeRicette()
                    Else
                        MsgBox(String.Format("Errore nella cancellazione della ricetta ""{0}"".", nomeRicetta), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
                    End If
                End If
            End If
        End If
    End Sub



    Private Sub btnCaricaRicetta_Click(sender As System.Object, e As System.EventArgs) Handles btnCaricaRicetta.Click
        ' Se l'utente conferma l'operazione
        If (_ricettaModificata AndAlso MsgBox("Annullare le modifiche apportate alla ricetta?", vbQuestion + MsgBoxStyle.YesNo, "Domanda") = MsgBoxResult.Yes) Then
            ' Se nel caricamento della ricetta non si verificano errori
            If Not (_ricetta.Carica(_nomeRicetta)) Then
                ' Visualizza la ricetta
                VisualizzaRicetta()
                ' Resetta il flag di ricetta modificata
                _ricettaModificata = False
            Else    ' Altrimenti, se nel caricamento della ricetta si verificano errori
                ' Visualizza un messaggio d'errore
                MsgBox(String.Format("Errore nel caricamento della ricetta ""{0}"".", _nomeRicetta), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
            End If
        End If
    End Sub



    Private Sub btnChiudiRicetta_Click(sender As System.Object, e As System.EventArgs) Handles btnChiudiRicetta.Click
        ' Gestisce una ricetta modificata
        GestisciRicettaModificata()
        ' Se la ricetta non è stata modificata
        If Not (_ricettaModificata) Then
            ' Abilita i controlli di gestione delle ricette
            gbGestioneRicette.Enabled = True
            ' Rende invisibili i controlli di gestione dei parametri
            btnChiudiRicetta.Visible = False
            btnModificaRicetta.Visible = False
            btnCaricaRicetta.Visible = False
            btnSalvaRicetta.Visible = False
            tcParametriRicetta.Visible = False
        End If
    End Sub



    Private Sub btnCopiaRicetta_Click(sender As System.Object, e As System.EventArgs) Handles btnCopiaRicetta.Click
        Dim _nomeRicettaSorgente As String

        ' Se il livello della password è maggiore di 0
        If (mGestorePassword.Login(0) > 0) Then
            ' Se è selezionata una ricetta
            If (lbListaRicette.SelectedItem IsNot Nothing) Then
                ' Memorizza il nome della ricetta sorgente
                _nomeRicettaSorgente = lbListaRicette.SelectedItem.ToString
                _nomeRicettaSorgente = Microsoft.VisualBasic.Left(_nomeRicettaSorgente, _nomeRicettaSorgente.Length - 2)
                ' Crea la nuova ricetta
                If (CreaNuovaRicetta() <> "") Then
                    ' Carica i valori della ricetta sorgente
                    If (_ricetta.Carica(_nomeRicettaSorgente)) Then
                        MsgBox(String.Format("Errore nel caricamento della ricetta ""{0}"".", _nomeRicettaSorgente), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
                    End If
                    ' Imposta la data e l'ora di creazione e modifica
                    _ricetta.DataOraCreazione.Valore = Format(Date.Now, "dd/MM/yyyy, HH:mm:ss")
                    _ricetta.DataOraModifica.Valore = _ricetta.DataOraCreazione.Valore
                    ' Salva la ricetta
                    If (_ricetta.Salva(_nomeRicetta)) Then
                        MsgBox(String.Format("Errore nel salvataggio della ricetta ""{0}"".", _nomeRicetta), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
                    End If
                    ' Seleziona la nuova ricetta
                    lbListaRicette.SelectedItem = _nomeRicetta
                    ' Visualizza la ricetta
                    btnVisualizzaRicetta.PerformClick()
                End If
            End If
        End If
    End Sub



    Private Sub btnModificaRicetta_Click(sender As System.Object, e As System.EventArgs) Handles btnModificaRicetta.Click
        ' Se l'utente inserisce la password
        If (mGestorePassword.Login(0) > 0) Then
            ' Abilita i controlli per la modifica della ricetta
            AbilitaControlli()
        End If
    End Sub



    Private Sub btnNuovaRicetta_Click(sender As System.Object, e As System.EventArgs) Handles btnNuovaRicetta.Click
        ' Se il livello della password è maggiore di 0
        If (mGestorePassword.Login(0) > 0) Then
            ' Crea e visualizza la nuova ricetta
            If (CreaNuovaRicetta() <> "") Then
                ' Seleziona la nuova ricetta
                lbListaRicette.SelectedIndex = lbListaRicette.FindString(_nomeRicetta)
                ' Visualizza la ricetta
                btnVisualizzaRicetta.PerformClick()
            End If
        End If
    End Sub



    Private Sub btnReport_Click(sender As System.Object, e As System.EventArgs) Handles btnReport.Click
        Dim app As Excel.Application
        Dim errore As Boolean
        Dim i As Integer
        Dim nomeFile As String
        Dim percorsoCompleto As String
        Dim ricetta As New cRicetta
        Dim workbook As Excel.Workbook
        Dim worksheet As Excel.Worksheet

        ' Se il livello della password è maggiore di 0
        If (mGestorePassword.Login(0) > 0) Then
            ' Se la lista delle ricette non è vuota
            If (lbListaRicette.Items.Count > 0) Then
                nomeFile = mGlobale.PercorsoReportRicette & "\MA01946 - Report ricette " & Format(Date.Now, "yyyyMMdd_HHmmss") & ".xls"
                percorsoCompleto = Path.GetFullPath(nomeFile)
                Try
                    ' Crea il report copiando il modello
                    File.Copy(mGlobale.PercorsoModelliReport & "\MA01946 - Report ricette.xls", nomeFile)
                    ' Apre il foglio di calcolo
                    app = New Excel.Application
                    workbook = app.Workbooks.Open(percorsoCompleto)
                    worksheet = workbook.Worksheets("Foglio1")
                    ' Scrive la data
                    worksheet.Cells(worksheet.Range("AG3").Row, worksheet.Range("AG3").Column).Value = Format(Date.Now, "dd/MM/yyyy")
                    ' Per tutte le ricette
                    For i = 0 To lbListaRicette.Items.Count - 1
                        ' Carica la ricetta
                        errore = ricetta.Carica(Microsoft.VisualBasic.Left(lbListaRicette.Items(i).ToString, lbListaRicette.Items(i).ToString.Length - 2))
                        If Not (errore) Then
                            ' Scrive i parametri della ricetta nel foglio di calcolo
                            worksheet.Rows(13 + i).Insert()
                            worksheet.Cells(12 + i, 1).Value = lbListaRicette.Items(i)
                            worksheet.Cells(12 + i, 2).Value = ricetta.IndiceRevisione.ValoreStringa
                            worksheet.Cells(12 + i, 3).Value = ricetta.DataOraCreazione.ValoreStringa
                            worksheet.Cells(12 + i, 4).Value = ricetta.DataOraModifica.ValoreStringa
                            worksheet.Cells(12 + i, 5).value = ricetta.TipologiaSonda.ValoreStringa
                            worksheet.Cells(12 + i, 6).Value = ricetta.NomeRicettaMaster.ValoreStringa
                            worksheet.Cells(12 + i, 7).Value = ricetta.CodiceAttrezzatura.ValoreStringa
                            ' Parametri comuni a tutte le sonde
                            worksheet.Cells(12 + i, 8).Value = ricetta.Val_Min.ValoreStringa
                            worksheet.Cells(12 + i, 9).Value = ricetta.Val_Max.ValoreStringa
                            '
                            worksheet.Cells(12 + i, 10).Value = IIf(ricetta.Rheater_Abilitazione.Valore, "SI'", "NO")
                            worksheet.Cells(12 + i, 11).Value = ricetta.Rheater_Min.ValoreStringa
                            worksheet.Cells(12 + i, 12).Value = ricetta.Rheater_Max.ValoreStringa
                            '
                            worksheet.Cells(12 + i, 13).Value = ricetta.Lsu_Flusso_Aria_Erogato.ValoreStringa
                            worksheet.Cells(12 + i, 14).Value = ricetta.Lsu_Flusso_N2_Erogato.ValoreStringa
                            '
                            worksheet.Cells(12 + i, 15).Value = ricetta.Tempo_Riscaldamento.ValoreStringa
                            worksheet.Cells(12 + i, 16).Value = ricetta.Tempo_Raffreddamento.ValoreStringa
                            '
                            worksheet.Cells(12 + i, 17).Value = IIf(ricetta.Corrente_Riscaldatore_Abilitazione.Valore, "SI'", "NO")
                            worksheet.Cells(12 + i, 18).Value = ricetta.Corrente_Riscaldatore_Min.ValoreStringa
                            worksheet.Cells(12 + i, 19).Value = ricetta.Corrente_Riscaldatore_Max.ValoreStringa
                            '
                            worksheet.Cells(12 + i, 20).Value = IIf(ricetta.Resistenza_Isolamento_Abilitazione.Valore, "SI'", "NO")
                            worksheet.Cells(12 + i, 21).Value = ricetta.Resistenza_Isolamento_Min.ValoreStringa
                            ' Parametri LSU 4.9
                            worksheet.Cells(12 + i, 22).Value = IIf(ricetta.Lsu_Temperatura_Operativa_Abilitazione.Valore, "SI'", "NO")
                            worksheet.Cells(12 + i, 23).Value = ricetta.Lsu_Temperatura_Operativa_Min.ValoreStringa
                            worksheet.Cells(12 + i, 24).Value = ricetta.Lsu_Temperatura_Operativa_Max.ValoreStringa
                            worksheet.Cells(12 + i, 25).Value = IIf(ricetta.Lsu_O2_Abilitazione.Valore, "SI'", "NO")
                            worksheet.Cells(12 + i, 26).Value = ricetta.Lsu_Target_O2.ValoreStringa
                            worksheet.Cells(12 + i, 27).Value = ricetta.Lsu_O2_Min.ValoreStringa
                            worksheet.Cells(12 + i, 28).Value = ricetta.Lsu_O2_Max.ValoreStringa
                            worksheet.Cells(12 + i, 29).Value = IIf(ricetta.Lsu_Resistenza_Calibrazione_Abilitazione.Valore, "SI'", "NO")
                            worksheet.Cells(12 + i, 30).Value = ricetta.Lsu_Resistenza_Calibrazione_Min.ValoreStringa
                            worksheet.Cells(12 + i, 31).Value = ricetta.Lsu_Resistenza_Calibrazione_Max.ValoreStringa
                            ' Parametri ADV
                            worksheet.Cells(12 + i, 32).Value = IIf(ricetta.Adv_Lambda_Abilitazione.Valore, "SI'", "NO")
                            worksheet.Cells(12 + i, 33).Value = ricetta.Adv_Lambda_Min.ValoreStringa
                            worksheet.Cells(12 + i, 34).Value = ricetta.Adv_Lambda_Max.ValoreStringa
                            worksheet.Cells(12 + i, 35).Value = IIf(ricetta.Adv_Ip_Abilitazione.Valore, "SI'", "NO")
                            worksheet.Cells(12 + i, 36).Value = ricetta.Adv_Ip_Min.ValoreStringa
                            worksheet.Cells(12 + i, 37).Value = ricetta.Adv_Ip_Max.ValoreStringa
                            ' Parametri ZFAS-U2
                            worksheet.Cells(12 + i, 38).Value = IIf(ricetta.Zfas_IpEtas_Abilitazione.Valore, "SI'", "NO")
                            worksheet.Cells(12 + i, 39).Value = ricetta.Zfas_IpEtas_Min.ValoreStringa
                            worksheet.Cells(12 + i, 40).Value = ricetta.Zfas_IpEtas_Max.ValoreStringa
                            worksheet.Cells(12 + i, 41).Value = IIf(ricetta.Zfas_IpTB_Abilitazione.Valore, "SI'", "NO")
                            worksheet.Cells(12 + i, 42).Value = ricetta.Zfas_IpTB_Min.ValoreStringa
                            worksheet.Cells(12 + i, 43).Value = ricetta.Zfas_IpTB_Max.ValoreStringa
                        End If
                        ' Se si sono verificati errori
                        If (errore) Then
                            ' Esce dal ciclo for
                            Exit For
                        End If
                    Next
                    ' Cancella le ultime due righe bianche
                    worksheet.Cells(12 + i, 1).EntireRow.Delete()
                    worksheet.Cells(12 + i, 1).EntireRow.Delete()
                    ' Salva e chiude il foglio di calcolo
                    workbook.Save()
                    workbook.Close()
                    worksheet = Nothing
                    workbook = Nothing
                    app.Quit()
                    app = Nothing
                    ' Se è stata creata una cartella di backup per i report delle ricette
                    If (mImpostazioniGenerali.CartellaBackupRicette <> "") Then
                        ' Copia il report appena creato nella cartella di backup
                        File.Copy(percorsoCompleto, mImpostazioniGenerali.CartellaBackupRicette & "\" & percorsoCompleto.Substring(mGlobale.PercorsoReportRicette.Length), True)
                    End If

                Catch ex As Exception
                    ' Setta il flag d'errore
                    errore = True
                End Try

                ' Se non si sono verificati errori
                If Not (errore) Then
                    ' Visualizza un messaggio di conferma
                    MsgBox("Report ricette generato con successo.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informazione")
                    ' Apre il report in Excel
                    Shell(mGlobale.PercorsoExcel & " """ & percorsoCompleto & """", AppWinStyle.MaximizedFocus, True)
                Else    ' Altrimenti, se si sono verificati errori
                    ' Visualizza un messaggio di errore
                    MsgBox("Errore nella generazione del report ricette.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "errore")
                End If
            End If
        End If
    End Sub



    Private Sub btnRicerca_Click(sender As System.Object, e As System.EventArgs) Handles btnRicerca.Click
        ' Configura e visualizza la finesta d'inserimento stringa
        frmInserimentoStringa.Descrizione = "Inserire il nome della ricetta"
        frmInserimentoStringa.LunghezzaMassima = 10
        frmInserimentoStringa.Valore = ""
        frmInserimentoStringa.ShowDialog()
        ' Se il valore è confermato
        If (frmInserimentoStringa.ValoreConfermato) Then
            ' Converte il valore in maiuscolo
            frmInserimentoStringa.Valore = frmInserimentoStringa.Valore.ToUpper
            ' Se il valore è presente nella lista
            If (lbListaRicette.FindString(frmInserimentoStringa.Valore) <> -1) Then
                ' Seleziona il valore
                lbListaRicette.SelectedIndex = lbListaRicette.FindString(frmInserimentoStringa.Valore)
            Else    ' Altrimenti, se il valore non è presente nella lista
                ' Visualizza un messaggio d'errore
                MsgBox(String.Format("Impossibile trovare la ricetta ""{0}"".", frmInserimentoStringa.Valore), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
            End If
        End If
    End Sub



    Private Sub btnSalvaRicetta_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvaRicetta.Click
        Dim parametriOk As Boolean

        ' Verifica i parametri
        parametriOk = True
        If (_ricetta.NomeRicettaMaster.Valore = "") Then
            MsgBox("La ricetta master selezionata non è valida.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            parametriOk = False
        End If
        ' Se i parametri sono ok
        If (parametriOk) Then
            ' Aggiorna la data e l'ora di modifica
            _ricetta.DataOraModifica.Valore = Format(Date.Now, "dd/MM/yyyy, HH:mm:ss")
            ' Se nel salvataggio della ricetta non si verificano errori
            If Not (_ricetta.Salva(_nomeRicetta)) Then
                ' Visualizza un messaggio di conferma
                MsgBox("Salvataggio effettuato con successo.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informazione")
                ' Resetta il flag di ricetta modificata
                _ricettaModificata = False
                ' Aggiorna la lista delle ricette
                AggiornaListeRicette()
            Else    ' Altrimenti, se nel salvataggio della ricetta si verificano errori
                ' Visualizza un messaggio d'errore
                MsgBox(String.Format("Errore nel salvataggio della ricetta ""{0}"".", _nomeRicetta), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
            End If
        End If
    End Sub



    Private Sub btnUscita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUscita.Click
        ' Chiude la finestra
        Me.Close()
    End Sub



    Private Sub btnVisualizzaRicetta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizzaRicetta.Click
        ' Se il nome della ricetta non è vuoto
        If (lbListaRicette.SelectedItem IsNot Nothing) Then
            ' Memorizza il nome della ricetta
            _nomeRicetta = lbListaRicette.SelectedItem.ToString
            _nomeRicetta = Microsoft.VisualBasic.Left(_nomeRicetta, _nomeRicetta.Length - 2)
            ' Disabilita i controlli di gestione delle ricette
            gbGestioneRicette.Enabled = False
            ' Rende visibili i controlli di gestione dei parametri
            btnChiudiRicetta.Visible = True
            btnModificaRicetta.Visible = True
            btnCaricaRicetta.Visible = True
            btnSalvaRicetta.Visible = True
            tcParametriRicetta.Visible = True
            ' Carica la ricetta
            If (_ricetta.Carica(_nomeRicetta)) Then
                MsgBox(String.Format("Errore nel caricamento della ricetta ""{0}"".", _nomeRicetta), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
            End If
            ' Visualizza la ricetta
            VisualizzaRicetta()
            ' Se il livello della password è maggiore di 0
            If (mGestorePassword.Livello > 0) Then
                ' Abilita i controlli per la modifica della ricetta
                AbilitaControlli()
            Else    ' Altrimenti, se il livello della password è 0
                ' Disabilita i controlli per la modifica della ricetta
                DisabilitaControlli()
            End If
        End If
    End Sub



    Private Sub cbNomeRicettaMaster_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cbNomeRicettaMaster.SelectionChangeCommitted
        ' Se il valore è stato modificato
        If (_ricetta.NomeRicettaMaster.Valore <> cbNomeRicettaMaster.SelectedItem.ToString) Then
            ' Aggiorna il valore della ricetta
            _ricetta.NomeRicettaMaster.Valore = cbNomeRicettaMaster.SelectedItem.ToString
            ' Visualizza la ricetta
            VisualizzaRicetta()
            ' Imposta il flag di ricetta modificata
            _ricettaModificata = True
        End If
    End Sub



    Private Sub cbTipologia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbTipologia.SelectionChangeCommitted
        ' Aggiorna il valore della ricetta
        _ricetta.TipologiaSonda.Valore = cbTipologia.SelectedItem
        ' Visualizza la ricetta
        VisualizzaRicetta()
        ' Imposta il flag di ricetta modificata
        _ricettaModificata = True
        ' Abilito le groupbox specifiche a seconda del modello selezionato
        gbMisureLSU.Enabled = cbTipologia.SelectedIndex = 0
        gbMisureADV.Enabled = cbTipologia.SelectedIndex = 1
        gbMisureZFAS.Enabled = cbTipologia.SelectedIndex = 2
    End Sub



    Private Sub chkValoreBoolean(sender As Object, e As System.EventArgs) Handles chkRheater.Click,
                                                                                  chkTemperaturaOperativa.Click,
                                                                                  chkO2.Click,
                                                                                  chkCorrenteRiscaldatore.Click,
                                                                                  chkResistenzaCalibrazione.Click,
                                                                                  chkResistenzaIsolamento.Click,
                                                                                  chkAdvLambda.Click,
                                                                                  chkAdvIp.Click,
                                                                                  chkZfasIpEtas.Click,
                                                                                  chkZfasIpTb.Click
        Dim checkBox As CheckBox
        Dim valoreRicetta As cValoreRicetta

        ' Determina il valore della ricetta sottoposto a modifica
        checkBox = CType(sender, CheckBox)
        If (checkBox Is chkRheater) Then
            valoreRicetta = _ricetta.Rheater_Abilitazione
        ElseIf (checkBox Is chkTemperaturaOperativa) Then
            valoreRicetta = _ricetta.Lsu_Temperatura_Operativa_Abilitazione
        ElseIf (checkBox Is chkO2) Then
            valoreRicetta = _ricetta.Lsu_O2_Abilitazione
        ElseIf (checkBox Is chkCorrenteRiscaldatore) Then
            valoreRicetta = _ricetta.Corrente_Riscaldatore_Abilitazione
        ElseIf (checkBox Is chkResistenzaCalibrazione) Then
            valoreRicetta = _ricetta.Lsu_Resistenza_Calibrazione_Abilitazione
        ElseIf (checkBox Is chkResistenzaIsolamento) Then
            valoreRicetta = _ricetta.Resistenza_Isolamento_Abilitazione
        ElseIf (checkBox Is chkAdvIp) Then
            valoreRicetta = _ricetta.Adv_Ip_Abilitazione
        ElseIf (checkBox Is chkAdvLambda) Then
            valoreRicetta = _ricetta.Adv_Lambda_Abilitazione
        ElseIf (checkBox Is chkZfasIpEtas) Then
            valoreRicetta = _ricetta.Zfas_IpEtas_Abilitazione
        ElseIf (checkBox Is chkZfasIpTb) Then
            valoreRicetta = _ricetta.Zfas_IpTB_Abilitazione
        Else
            valoreRicetta = Nothing
        End If
        ' Se il valore è valido
        If (valoreRicetta IsNot Nothing) Then
            ' Modifica il valore
            valoreRicetta.Valore = checkBox.Checked
            ' Visualizza la ricetta
            VisualizzaRicetta()
            ' Setta il flag di ricetta modificata
            _ricettaModificata = True
        End If
    End Sub



    Private Function CreaNuovaRicetta() As String
        ' Configura e visualizza la finestra d'inserimento stringa
        frmInserimentoStringa.Descrizione = "Inserire il nome della nuova ricetta"
        frmInserimentoStringa.LunghezzaMassima = 10
        frmInserimentoStringa.Valore = ""
        frmInserimentoStringa.ShowDialog()
        ' Se l'utente ha confermato l'operazione
        If (frmInserimentoStringa.ValoreConfermato) Then
            ' Converte il valore in maiuscolo
            frmInserimentoStringa.Valore = frmInserimentoStringa.Valore.ToUpper
            ' Se la ricetta non esiste ancora
            If Not (cRicetta.Esiste(frmInserimentoStringa.Valore)) Then
                ' Memorizza il nome della ricetta
                _nomeRicetta = frmInserimentoStringa.Valore
                ' Inizializza la ricetta
                _ricetta.Inizializza()
                ' Imposta la data e l'ora di creazione e modifica
                _ricetta.DataOraCreazione.Valore = Format(Date.Now, "dd/MM/yyyy, HH:mm:ss")
                _ricetta.DataOraModifica.Valore = _ricetta.DataOraCreazione.Valore
                ' Salva la ricetta
                If Not (_ricetta.Salva(_nomeRicetta)) Then
                    ' Aggiorna le liste delle ricette
                    AggiornaListeRicette()
                Else
                    MsgBox(String.Format("Errore nel salvataggio della ricetta ""{0}"".", _nomeRicetta), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
                    _nomeRicetta = ""
                End If
            Else    ' Altrimenti, se la ricetta esiste già
                ' Visualizza un messaggio d'errore
                MsgBox(String.Format("La ricetta ""{0}"" esiste già.", frmInserimentoStringa.Valore), CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                _nomeRicetta = ""
            End If
        Else
            _nomeRicetta = ""
        End If
        ' Restituisce il nome della nuova ricetta
        CreaNuovaRicetta = _nomeRicetta
    End Function



    Private Sub DisabilitaControlli()
        ' Disabilita i controlli per la modifica della ricetta
        btnModificaRicetta.Enabled = True
        btnCaricaRicetta.Enabled = False
        btnSalvaRicetta.Enabled = False
        tcParametriRicetta.TabPages(0).Enabled = False
        gbVal.Enabled = False
        gbRheater.Enabled = False
        gbRiscaldamentoRaffreddamento.Enabled = False
        gbIheater.Enabled = False
        gbIsolamento.Enabled = False
        gbMisureLSU.Enabled = False
        gbMisureADV.Enabled = False
        gbMisureZFAS.Enabled = False
    End Sub



    Private Sub GestisciRicettaModificata()
        Dim scelta = New MsgBoxResult

        ' Se la ricetta corrente è stata modificata
        If (_ricettaModificata) Then
            ' Chiede all'utente se vuole salvare le modifiche
            scelta = MsgBox("La ricetta corrente è stata modificata: salvare le modifiche?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, MsgBoxStyle), "Domanda")
            ' Se l'utente vuole salvare le modifiche
            If (scelta = MsgBoxResult.Yes) Then
                ' Simula la pressione del pulsante salva ricetta
                btnSalvaRicetta.PerformClick()
            ElseIf (scelta = MsgBoxResult.No) Then  ' Altrimenti, se l'utente non vuole salvare le modifiche
                ' Resetta il flag di ricetta modificata
                _ricettaModificata = False
            End If
        End If
    End Sub



    Private Sub frmGestioneRicette_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Gestisce un'eventuale ricetta modificata
        GestisciRicettaModificata()
        ' Se il flag di ricetta modficata non è attivo
        If Not (_ricettaModificata) Then
            ' Ricarica il lotto
            If (mGestoreCollaudo.Lotto.Nome <> "") Then
                mGestoreCollaudo.CaricaLotto(mGestoreCollaudo.Lotto.Nome)
            End If
            ' Effettua il logout
            mGestorePassword.Logout()
        Else    ' Altrimenti, se il flag di ricetta modficata è attivo
            ' Cancella la richiesta di chiusura
            e.Cancel = True
        End If
    End Sub



    Private Sub frmRicette_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Inizializza la finestra
        InizializzaFinestra()
        ' Abilita i controlli di gestione delle ricette
        gbGestioneRicette.Enabled = True
        ' Rende invisibili i controlli di gestione dei parametri
        btnChiudiRicetta.Visible = False
        btnModificaRicetta.Visible = False
        btnCaricaRicetta.Visible = False
        btnSalvaRicetta.Visible = False
        tcParametriRicetta.Visible = False
        ' Popola la combobox della tipologia di sonde
        cbTipologia.Items.Clear()
        cbTipologia.Items.Add("LSU-4-9")
        cbTipologia.Items.Add("LSU-ADV")
        cbTipologia.Items.Add("ZFAS-U2")
        ' Resetta il flag di ricetta modificata
        _ricettaModificata = False
    End Sub



    Private Sub InizializzaFinestra()
        ' Aggiorna la lista delle ricette
        AggiornaListeRicette()
        ' Visualizza le unità di misura dei valori
        labUDMVal.Text = _ricetta.Val_Min.UnitàDiMisura
        labUDMRheater.Text = _ricetta.Rheater_Min.UnitàDiMisura
        labUDMFlussoAria.Text = _ricetta.Lsu_Flusso_Aria_Erogato.UnitàDiMisura
        labUDMFlussoN2.Text = _ricetta.Lsu_Flusso_N2_Erogato.UnitàDiMisura
        labUdmTargetO2.Text = _ricetta.Lsu_Target_O2.UnitàDiMisura
        labUDMTempoRiscaldamento.Text = _ricetta.Tempo_Riscaldamento.UnitàDiMisura
        labUDMTempOperativa.Text = _ricetta.Lsu_Temperatura_Operativa_Min.UnitàDiMisura
        labUDMO2.Text = _ricetta.Lsu_O2_Min.UnitàDiMisura
        labUDMCorrenteRiscaldatore.Text = _ricetta.Corrente_Riscaldatore_Min.UnitàDiMisura
        labUDMResistenzaCalibrazione.Text = _ricetta.Lsu_Resistenza_Calibrazione_Min.UnitàDiMisura
        labUDMResistenzaIsolamento.Text = _ricetta.Resistenza_Isolamento_Min.UnitàDiMisura
        labUDMTempoRaffreddamento.Text = _ricetta.Tempo_Raffreddamento.UnitàDiMisura

        ' Se il livello della password è maggiore di 0
        If (mGestorePassword.Livello > 0) Then
            ' Abilita i controlli per la modifica della ricetta
            AbilitaControlli()
        Else    ' Altrimenti, se il livello della password è 0
            ' Disabilita i controlli per la modifica della ricetta
            DisabilitaControlli()
        End If
    End Sub



    Private Sub labValoreNumero_Click(sender As System.Object, e As System.EventArgs) Handles labValMin.Click,
                                                                                                labValMax.Click,
                                                                                                labRheaterMin.Click,
                                                                                                labRheaterMax.Click,
                                                                                                labResistenzaIsolamentoMin.Click,
                                                                                                labTempoRaffreddamento.Click,
                                                                                                labTempoRiscaldamento.Click,
                                                                                                labTempOperativaMin.Click,
                                                                                                labTempOperativaMax.Click,
                                                                                                labTargetO2.Click,
                                                                                                labResistenzaCalibrazioneMin.Click,
                                                                                                labResistenzaCalibrazioneMax.Click,
                                                                                                labO2Min.Click,
                                                                                                labO2Max.Click,
                                                                                                labFlussoN2.Click,
                                                                                                labFlussoAria.Click,
                                                                                                labZfasIpTbMin.Click,
                                                                                                labAdvIpMin.Click,
                                                                                                labAdvLambdaMin.Click,
                                                                                                labAdvIpMax.Click,
                                                                                                labAdvLambdaMax.Click,
                                                                                                labZfasIpEtasMax.Click,
                                                                                                labZfasIpEtasMin.Click,
                                                                                                labZfasIpTbMax.Click,
                                                                                                labCorrenteRiscaldatoreMin.Click,
                                                                                                labCorrenteRiscaldatoreMax.Click
        Dim etichetta As Label
        Dim valoreIniziale As Double
        Dim valoreRicetta As cValoreRicetta

        ' Determina il valore della ricetta sottoposto a modifica
        etichetta = CType(sender, Label)
        If (etichetta Is labValMin) Then
            valoreRicetta = _ricetta.Val_Min
        ElseIf (etichetta Is labValMax) Then
            valoreRicetta = _ricetta.Val_Max
        ElseIf (etichetta Is labRheaterMin) Then
            valoreRicetta = _ricetta.Rheater_Min
        ElseIf (etichetta Is labRheaterMax) Then
            valoreRicetta = _ricetta.Rheater_Max
        ElseIf (etichetta Is labFlussoAria) Then
            valoreRicetta = _ricetta.Lsu_Flusso_Aria_Erogato
        ElseIf (etichetta Is labFlussoN2) Then
            valoreRicetta = _ricetta.Lsu_Flusso_N2_Erogato
        ElseIf (etichetta Is labTargetO2) Then
            valoreRicetta = _ricetta.Lsu_Target_O2
        ElseIf (etichetta Is labTempoRiscaldamento) Then
            valoreRicetta = _ricetta.Tempo_Riscaldamento
        ElseIf (etichetta Is labTempOperativaMin) Then
            valoreRicetta = _ricetta.Lsu_Temperatura_Operativa_Min
        ElseIf (etichetta Is labTempOperativaMax) Then
            valoreRicetta = _ricetta.Lsu_Temperatura_Operativa_Max
        ElseIf (etichetta Is labO2Min) Then
            valoreRicetta = _ricetta.Lsu_O2_Min
        ElseIf (etichetta Is labO2Max) Then
            valoreRicetta = _ricetta.Lsu_O2_Max
        ElseIf (etichetta Is labCorrenteRiscaldatoreMin) Then
            valoreRicetta = _ricetta.Corrente_Riscaldatore_Min
        ElseIf (etichetta Is labCorrenteRiscaldatoreMax) Then
            valoreRicetta = _ricetta.Corrente_Riscaldatore_Max
        ElseIf (etichetta Is labResistenzaCalibrazioneMin) Then
            valoreRicetta = _ricetta.Lsu_Resistenza_Calibrazione_Min
        ElseIf (etichetta Is labResistenzaCalibrazioneMax) Then
            valoreRicetta = _ricetta.Lsu_Resistenza_Calibrazione_Max
        ElseIf (etichetta Is labResistenzaIsolamentoMin) Then
            valoreRicetta = _ricetta.Resistenza_Isolamento_Min
        ElseIf (etichetta Is labTempoRaffreddamento) Then
            valoreRicetta = _ricetta.Tempo_Raffreddamento
        ElseIf (etichetta Is labAdvIpMin) Then
            valoreRicetta = _ricetta.Adv_Ip_Min
        ElseIf (etichetta Is labAdvIpMax) Then
            valoreRicetta = _ricetta.Adv_Ip_Max
        ElseIf (etichetta Is labAdvLambdaMin) Then
            valoreRicetta = _ricetta.Adv_Lambda_Min
        ElseIf (etichetta Is labAdvLambdaMax) Then
            valoreRicetta = _ricetta.Adv_Lambda_Max
        ElseIf (etichetta Is labZfasIpEtasMin) Then
            valoreRicetta = _ricetta.Zfas_IpEtas_Min
        ElseIf (etichetta Is labZfasIpEtasMax) Then
            valoreRicetta = _ricetta.Zfas_IpEtas_Max
        ElseIf (etichetta Is labZfasIptbMin) Then
            valoreRicetta = _ricetta.Zfas_IpTB_Min
        ElseIf (etichetta Is labZfasIptbMax) Then
            valoreRicetta = _ricetta.Zfas_IpTB_Max
        Else
            valoreRicetta = Nothing
        End If
        ' Se il valore è valido
        If (valoreRicetta IsNot Nothing) Then
            ' Configura e visualizza la finestra d'inserimento numero
            valoreIniziale = valoreRicetta.Valore
            frmInserimentoNumero.Descrizione = valoreRicetta.Descrizione & " / " & valoreRicetta.UnitàDiMisura
            frmInserimentoNumero.Decimali = valoreRicetta.NumeroDecimali
            frmInserimentoNumero.Minimo = valoreRicetta.ValoreMinimo
            frmInserimentoNumero.Massimo = valoreRicetta.ValoreMassimo
            frmInserimentoNumero.Valore = valoreRicetta.Valore
            frmInserimentoNumero.ShowDialog()
            ' Se il valore è confermato
            If (frmInserimentoNumero.ValoreConfermato) Then
                ' Se il valore è stato modificato
                If (frmInserimentoNumero.Valore <> valoreIniziale) Then
                    ' Aggiorna il valore della ricetta
                    valoreRicetta.Valore = frmInserimentoNumero.Valore
                    ' Visualizza la ricetta
                    VisualizzaRicetta()
                    ' Setta il flag di ricetta modificata
                    _ricettaModificata = True
                End If
            End If
        End If
    End Sub



    Private Sub labValoreStringa_Click(sender As System.Object, e As System.EventArgs) Handles labIndiceRevisione.Click,
                                                                                               labCodiceAttrezzatura.Click
        Dim etichetta As Label
        Dim valoreIniziale As String
        Dim valoreRicetta As cValoreRicetta
        Dim valoreValido As Boolean

        ' Determina il valore della ricetta sottoposto a modifica
        etichetta = CType(sender, Label)
        If (etichetta Is labIndiceRevisione) Then
            valoreRicetta = _ricetta.IndiceRevisione
        ElseIf (etichetta Is labCodiceAttrezzatura) Then
            valoreRicetta = _ricetta.CodiceAttrezzatura
        Else
            valoreRicetta = Nothing
        End If
        ' Se il valore è valido
        If (valoreRicetta IsNot Nothing) Then
            ' Configura e visualizza la finestra d'inserimento stringa
            valoreIniziale = valoreRicetta.Valore
            frmInserimentoStringa.Descrizione = valoreRicetta.Descrizione
            frmInserimentoStringa.LunghezzaMassima = valoreRicetta.LunghezzaMassima
            frmInserimentoStringa.Valore = valoreRicetta.Valore
            frmInserimentoStringa.ShowDialog()
            ' Se il valore è confermato
            If (frmInserimentoStringa.ValoreConfermato) Then
                ' Se il valore è stato modificato
                If (frmInserimentoStringa.Valore <> valoreIniziale) Then
                    ' Verifica il valore
                    valoreValido = True
                    If (etichetta Is labIndiceRevisione) Then
                        frmInserimentoStringa.Valore = frmInserimentoStringa.Valore.ToUpper
                        If (frmInserimentoStringa.Valore.Length <> 1 Or
                            frmInserimentoStringa.Valore < "A" Or
                            frmInserimentoStringa.Valore > "Z") Then
                            MsgBox("L'indice di revisione deve essere una lettera compresa tra ""A"" e ""Z""", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
                            valoreValido = False
                        End If
                    End If
                    ' Se il valore è valido
                    If (valoreValido) Then
                        ' Aggiorna il valore della ricetta
                        valoreRicetta.Valore = frmInserimentoStringa.Valore
                        ' Visualizza la ricetta
                        VisualizzaRicetta()
                        ' Setta il flag di ricetta modificata
                        _ricettaModificata = True
                    End If
                End If
            End If
        End If
    End Sub



    Private Sub lbListaRicette_DoubleClick(sender As Object, e As System.EventArgs) Handles lbListaRicette.DoubleClick
        ' Simula la pressione del pulsante visualizza ricetta
        btnVisualizzaRicetta.PerformClick()
    End Sub



    Private Sub VisualizzaRicetta()
        ' Visualizza i valori della ricetta
        labDataOraCreazione.Text = _ricetta.DataOraCreazione.ValoreStringa
        labDataOraModifica.Text = _ricetta.DataOraModifica.ValoreStringa
        labIndiceRevisione.Text = _ricetta.IndiceRevisione.ValoreStringa
        cbNomeRicettaMaster.SelectedItem = _ricetta.NomeRicettaMaster.ValoreStringa
        labCodiceAttrezzatura.Text = _ricetta.CodiceAttrezzatura.ValoreStringa
        cbTipologia.SelectedItem = _ricetta.TipologiaSonda.ValoreStringa
        labValMin.Text = _ricetta.Val_Min.ValoreStringa
        labValMax.Text = _ricetta.Val_Max.ValoreStringa
        chkRheater.Checked = _ricetta.Rheater_Abilitazione.Valore
        labRheaterMin.Text = _ricetta.Rheater_Min.ValoreStringa
        labRheaterMax.Text = _ricetta.Rheater_Max.ValoreStringa
        labFlussoAria.Text = _ricetta.Lsu_Flusso_Aria_Erogato.ValoreStringa
        labFlussoN2.Text = _ricetta.Lsu_Flusso_N2_Erogato.ValoreStringa
        labTargetO2.Text = _ricetta.Lsu_Target_O2.ValoreStringa
        labTempoRiscaldamento.Text = _ricetta.Tempo_Riscaldamento.ValoreStringa
        chkTemperaturaOperativa.Checked = _ricetta.Lsu_Temperatura_Operativa_Abilitazione.Valore
        labTempOperativaMin.Text = _ricetta.Lsu_Temperatura_Operativa_Min.ValoreStringa
        labTempOperativaMax.Text = _ricetta.Lsu_Temperatura_Operativa_Max.ValoreStringa
        chkO2.Checked = _ricetta.Lsu_O2_Abilitazione.Valore
        labO2Min.Text = _ricetta.Lsu_O2_Min.ValoreStringa
        labO2Max.Text = _ricetta.Lsu_O2_Max.ValoreStringa
        chkCorrenteRiscaldatore.Checked = _ricetta.Corrente_Riscaldatore_Abilitazione.Valore
        labCorrenteRiscaldatoreMin.Text = _ricetta.Corrente_Riscaldatore_Min.ValoreStringa
        labCorrenteRiscaldatoreMax.Text = _ricetta.Corrente_Riscaldatore_Max.ValoreStringa
        chkResistenzaCalibrazione.Checked = _ricetta.Lsu_Resistenza_Calibrazione_Abilitazione.Valore
        labResistenzaCalibrazioneMin.Text = _ricetta.Lsu_Resistenza_Calibrazione_Min.ValoreStringa
        labResistenzaCalibrazioneMax.Text = _ricetta.Lsu_Resistenza_Calibrazione_Max.ValoreStringa
        chkResistenzaIsolamento.Checked = _ricetta.Resistenza_Isolamento_Abilitazione.Valore
        labResistenzaIsolamentoMin.Text = _ricetta.Resistenza_Isolamento_Min.ValoreStringa
        labTempoRaffreddamento.Text = _ricetta.Tempo_Raffreddamento.ValoreStringa
        chkAdvIp.Checked = _ricetta.Adv_Ip_Abilitazione.Valore
        labAdvIpMin.Text = _ricetta.Adv_Ip_Min.ValoreStringa
        labAdvIpMax.Text = _ricetta.Adv_Ip_Max.ValoreStringa
        chkAdvLambda.Checked = _ricetta.Adv_Lambda_Abilitazione.Valore
        labAdvLambdaMin.Text = _ricetta.Adv_Lambda_Min.ValoreStringa
        labAdvLambdaMax.Text = _ricetta.Adv_Lambda_Max.ValoreStringa
        chkZfasIpEtas.Checked = _ricetta.Zfas_IpEtas_Abilitazione.Valore
        labZfasIpEtasMin.Text = _ricetta.Zfas_IpEtas_Min.ValoreStringa
        labZfasIpEtasMax.Text = _ricetta.Zfas_IpEtas_Max.ValoreStringa
        chkZfasIpTb.Checked = _ricetta.Zfas_IpTB_Abilitazione.Valore
        labZfasIpTbMin.Text = _ricetta.Zfas_IpTB_Min.ValoreStringa
        labZfasIpTbMax.Text = _ricetta.Zfas_IpTB_Max.ValoreStringa
    End Sub
End Class
Option Explicit On
Option Strict On

Imports System.IO

Module mGestoreCollaudo
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    ' Enumerazione fase
    Public Enum eFase
        AttesaPressioneAriaOK = 0
        AttesaPressioneAria2OK = 1
        AttesaPressioneAzotoOK = 2
        AttesaSgancioEmergenza = 3
        AttesaInserimentoAusiliari = 4
        AttesaPressioneReset = 5
        AttesaInserimentoPezzo = 6
        AttesaAvvioCiclo = 7
        InizializzazioneCollaudo = 8
        ChiusuraCampana = 9
        ChiusuraPinza = 10
        MisuraTensioneAlimentazione = 11
        MisuraResistenzaRiscaldatore = 12
        ' Misura specifica per LSU 4.8
        LSU4_9_MisuraO2 = 20
        ' Misura specifica per ADV
        ADV_MisuraLambda = 30
        ADV_MisuraCorrente = 31
        ' Misura specifica per ZFAS
        ZFAS_MisuraCorrenteEtas = 40
        ZFAS_MisuraCorrenteTB = 41
        ' Valori nuovamente comuni
        MisuraIsolamentoRiscaldatore = 50
        RaffreddamentoPezzo = 51
        RaffreddamentoSicurezzaPezzo = 52
        ValutazioneEsitoCollaudo = 53
        ScritturaRisultati = 54
        ScaricoPezzoBuono = 55
        ScaricoPezzoScarto = 56
        ResetFineCiclo = 57
    End Enum



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Costanti private
    Private Const _durataSuonoCicalino_s = 1
    Private Const _periodoLetturaIngressi_ms = 25
    Private Const _periodoScritturaUscite_ms = 25

    ' Variabili private
    Private _blink As Boolean
    Private _cicloManuale As Boolean
    Private _cicloMaster As Boolean
    Private _cicloMasterObbligatorio As Boolean
    Private _cicloInterrottoScarto As Boolean
    Private _resetPremuto As Boolean
    Private _fase As eFase
    Private _lotto As New cLotto
    Private _numeroBuoniNonRipassati As Integer
    Private _numeroBuoniRipassati As Integer
    Private _numeroScartiNonRipassati As Integer
    Private _numeroScartiRipassati As Integer
    Private _posizione0 As Double
    Private _ricetta As cRicetta
    Private _ripassoScarti As Boolean
    Private _risultati As New cRisultati
    Private _sottofase As Integer
    Private _t0Cicalino As Date
    Private _t0Display As Date



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public ReadOnly Property Blink As Boolean
        Get
            Blink = _blink
        End Get
    End Property



    Public ReadOnly Property CicloInCorso As Boolean
        Get
            CicloInCorso = (_fase >= eFase.InizializzazioneCollaudo And _fase <= eFase.ResetFineCiclo)
        End Get
    End Property



    Public Property CicloManuale As Boolean
        Get
            CicloManuale = _cicloManuale
        End Get
        Set(ByVal value As Boolean)
            _cicloManuale = value
         End Set
    End Property



    Public Property CicloMaster As Boolean
        Get
            CicloMaster = _cicloMaster
        End Get
        Set(ByVal value As Boolean)
            If (Not (CicloInCorso) And Not (_cicloMasterObbligatorio)) Then
                _cicloMaster = value
            End If
        End Set
    End Property



    Public ReadOnly Property DescrizioneFase As String
        Get
            DescrizioneFase = CInt(_fase).ToString & "." & _sottofase.ToString & " - "
            Select Case _fase
                Case eFase.AttesaPressioneAriaOK
                    DescrizioneFase = DescrizioneFase & "Attesa Pressione Aria Sufficiente"
                Case eFase.AttesaPressioneAria2OK
                    DescrizioneFase = DescrizioneFase & "Attesa Inserimento Ausiliari"
                Case eFase.AttesaPressioneAzotoOK
                    DescrizioneFase = DescrizioneFase & "Attesa Pressione Azoto Sufficiente"
                Case eFase.AttesaSgancioEmergenza
                    DescrizioneFase = DescrizioneFase & "Attesa Sgancio Pulsante Emergenza"
                Case eFase.AttesaInserimentoAusiliari
                    DescrizioneFase = DescrizioneFase & "Attesa Inserimento Ausiliari"
                Case eFase.AttesaPressioneReset
                    DescrizioneFase = DescrizioneFase & "Attesa Pressione Pulsante Reset"
                Case eFase.AttesaInserimentoPezzo
                    DescrizioneFase = DescrizioneFase & "Attesa Inserimento Pezzo"
                Case eFase.AttesaAvvioCiclo
                    DescrizioneFase = DescrizioneFase & "Attesa Avvio Ciclo"
                Case eFase.InizializzazioneCollaudo
                    DescrizioneFase = DescrizioneFase & "Inizializzazione Collaudo"
                Case eFase.ChiusuraCampana
                    DescrizioneFase = DescrizioneFase & "Chiusura Campana"
                Case eFase.ChiusuraPinza
                    DescrizioneFase = DescrizioneFase & "Chiusura Pinza"
                Case eFase.MisuraTensioneAlimentazione
                    DescrizioneFase = DescrizioneFase & "Misura Tensione Alimentazione"
                Case eFase.MisuraResistenzaRiscaldatore
                    DescrizioneFase = DescrizioneFase & "Misura Corrente Riscaldatore"
                Case eFase.LSU4_9_MisuraO2
                    DescrizioneFase = DescrizioneFase & "Misura O2%"
                    If _sottofase = 0 Then
                        DescrizioneFase = DescrizioneFase & " - Collego Relè"
                    ElseIf _sottofase = 1 Then
                        DescrizioneFase = DescrizioneFase & " - Riscaldamento Sonda - " & (CInt(_ricetta.Tempo_Riscaldamento.Valore) - (Date.Now - _t0Display).TotalSeconds).ToString("0")
                    ElseIf _sottofase = 2 Then
                        DescrizioneFase = DescrizioneFase & " - Misurazione O2%"
                    ElseIf _sottofase = 3 Then
                        DescrizioneFase = DescrizioneFase & " - Misurazione Corrente Riscaldatore"
                    ElseIf _sottofase = 4 Then
                        DescrizioneFase = DescrizioneFase & " - Verifica Risultati"
                    ElseIf _sottofase = 5 Then
                        DescrizioneFase = DescrizioneFase & " - Attesa Passo"
                    ElseIf _sottofase = 6 Then
                        DescrizioneFase = DescrizioneFase & " - Cambio Fase"
                    End If
                Case eFase.ADV_MisuraLambda
                    DescrizioneFase = DescrizioneFase & "ADV - Misura Lambda"
                Case eFase.ADV_MisuraCorrente
                    DescrizioneFase = DescrizioneFase & "ADV - Misura Corrente"
                Case eFase.ZFAS_MisuraCorrenteEtas
                    DescrizioneFase = DescrizioneFase & "ZFAS - Misura Corrente Etas"
                Case eFase.ZFAS_MisuraCorrenteTB
                    DescrizioneFase = DescrizioneFase & "ZFAS - Misura Corrente TB"
                Case eFase.MisuraIsolamentoRiscaldatore
                    DescrizioneFase = DescrizioneFase & "Misura Isolamento Riscaldatore/Cella"
                Case eFase.RaffreddamentoPezzo
                    DescrizioneFase = DescrizioneFase & "Attesa Raffreddamento Pezzo - " & (CInt(_ricetta.Tempo_Raffreddamento.Valore) - (Date.Now - _t0Display).TotalSeconds).ToString("0")
                Case eFase.RaffreddamentoSicurezzaPezzo
                    DescrizioneFase = DescrizioneFase & "Attesa Raffreddamento di Sicurezza Pezzo"
                Case eFase.ValutazioneEsitoCollaudo
                    DescrizioneFase = DescrizioneFase & "Valutazione Esito Collaudo"
                Case eFase.ScritturaRisultati
                    DescrizioneFase = DescrizioneFase & "Scrittura risultati"
                Case eFase.ScaricoPezzoBuono
                    If (_sottofase = 0) Then
                        DescrizioneFase = DescrizioneFase & "Apertura Campana"
                    ElseIf (_sottofase = 1) Then
                        DescrizioneFase = DescrizioneFase & "Apertura Pinza"
                    ElseIf (_sottofase = 2) Then
                        DescrizioneFase = DescrizioneFase & "Attesa Scarico Pezzo Buono"
                    ElseIf (_sottofase = 3) Then
                        DescrizioneFase = DescrizioneFase & "Spegnimento lampade e aggiornamento contatori"
                    End If
                Case eFase.ScaricoPezzoScarto
                    If (_sottofase = 0) Then
                        DescrizioneFase = DescrizioneFase & "Apertura Campana"
                    ElseIf (_sottofase = 1) Then
                        DescrizioneFase = DescrizioneFase & "Attesa Pulsante Scarto"
                    ElseIf (_sottofase = 2) Then
                        DescrizioneFase = DescrizioneFase & "Attesa Rimozione Scarto"
                    ElseIf (_sottofase = 3) Then
                        DescrizioneFase = DescrizioneFase & "Attesa Scarico Scarto"
                    ElseIf (_sottofase = 4) Then
                        DescrizioneFase = DescrizioneFase & "Spegnimento lampade e aggiornamento contatori"
                    End If
                Case eFase.ResetFineCiclo
                    DescrizioneFase = DescrizioneFase & "Reset di fine ciclo"
                Case Else
                    DescrizioneFase = DescrizioneFase & "???"
            End Select
        End Get
    End Property



    Public ReadOnly Property Fase As eFase
        Get
            Fase = _fase
        End Get
    End Property



    Public ReadOnly Property Lotto As cLotto
        Get
            Lotto = _lotto
        End Get
    End Property



    Public ReadOnly Property NumeroBuoni As Integer
        Get
            NumeroBuoni = _numeroBuoniNonRipassati + _numeroBuoniRipassati
        End Get
    End Property



    Public Property NumeroBuoniNonRipassati As Integer
        Get
            NumeroBuoniNonRipassati = _numeroBuoniNonRipassati
        End Get
        Set(value As Integer)
            _numeroBuoniNonRipassati = value
        End Set
    End Property



    Public Property NumeroBuoniRipassati As Integer
        Get
            NumeroBuoniRipassati = _numeroBuoniRipassati
        End Get
        Set(value As Integer)
            _numeroBuoniRipassati = value
        End Set
    End Property



    Public ReadOnly Property NumeroPezzi As Integer
        Get
            NumeroPezzi = NumeroBuoni + NumeroScarti
        End Get
    End Property



    Public ReadOnly Property NumeroPezziNonRipassati As Integer
        Get
            NumeroPezziNonRipassati = _numeroBuoniNonRipassati + _numeroScartiNonRipassati
        End Get
    End Property



    Public ReadOnly Property NumeroPezziRipassati As Integer
        Get
            NumeroPezziRipassati = _numeroBuoniRipassati + _numeroScartiRipassati
        End Get
    End Property



    Public ReadOnly Property NumeroScarti As Integer
        Get
            NumeroScarti = _numeroScartiNonRipassati + _numeroScartiRipassati
        End Get
    End Property



    Public Property NumeroScartiRipassati As Integer
        Get
            NumeroScartiRipassati = _numeroScartiRipassati
        End Get
        Set(value As Integer)
            _numeroScartiRipassati = value
        End Set
    End Property



    Public Property NumeroScartiNonRipassati As Integer
        Get
            NumeroScartiNonRipassati = _numeroScartiNonRipassati
        End Get
        Set(value As Integer)
            _numeroScartiNonRipassati = value
        End Set
    End Property



    Public Property RipassoScarti As Boolean
        Get
            RipassoScarti = _ripassoScarti
        End Get
        Set(value As Boolean)
            _ripassoScarti = value And Not (CicloInCorso) And Not (CicloMaster) And (mGestoreCollaudo.Lotto.NumeroScarti > 0)
        End Set
    End Property



    Public ReadOnly Property Risultati As cRisultati
        Get
            Risultati = _risultati
        End Get
    End Property



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function ApriSessione() As Boolean
        Dim errore As Boolean

        ' Azzera i contatori di sessione
        _numeroBuoniNonRipassati = 0
        _numeroBuoniRipassati = 0
        _numeroScartiNonRipassati = 0
        _numeroScartiRipassati = 0
        ' Inizializza i risultati
        _risultati.inizializza()
        ' Passa alla fase di attesa pressione aria OK
        _fase = eFase.AttesaPressioneAriaOK
        ' Imposta i flag di ciclo master e ciclo master obbligatorio
        _cicloMaster = mImpostazioniGenerali.AbilitazioneCicliMaster
        _cicloMasterObbligatorio = _cicloMaster
        ' Imposta il flag di interruzione ciclo al primo scarto
        _cicloInterrottoScarto = mImpostazioniGenerali.AbilitazioneCicloInterrottoSuScarto
        ' Inizializza il flag di ripasso scarti
        _ripassoScarti = False
        ' Restituisce il flag d'errore
        ApriSessione = errore
        ' Imposta il tasto reset su non premuto
        _resetPremuto = False
    End Function



    Public Function Arresta() As Boolean
        ' Restituisce False
        Arresta = False
    End Function



    Public Function Avvia() As Boolean
        Dim errore As Boolean
        Dim nomeLotto As String

        ' Carica il nome del lotto utilizzato
        nomeLotto = ""
        errore = CaricaNomeLottoUtilizzato(nomeLotto)
        If (errore) Then
            MsgBox("Errore nel caricamento del nome del lotto utilizzato.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Carica il lotto utilizzato
        If (nomeLotto <> "") Then
            CaricaLotto(nomeLotto)
        End If
        ' Restituisce il flag d'errore
        Avvia = errore
    End Function



    Public Function CaricaLotto(ByVal nomeLotto As String) As Boolean
        Dim errore As Boolean
        Dim ricetta As New cRicetta

        ' Carica il lotto
        errore = _lotto.Carica(nomeLotto)
        If (errore) Then
            MsgBox(String.Format("Errore nel caricamento del lotto ""{0}"".", nomeLotto), CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Verifica che la ricetta non sia stata cancellata
        If Not (errore) Then
            errore = Not (cRicetta.Esiste(_lotto.NomeRicetta))
            If (errore) Then
                MsgBox(String.Format("La ricetta ""{0}"" è stata cancellata: impossibile utilizzare il lotto ""{1}"".", _lotto.NomeRicetta, _lotto.Nome), _
                       CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                       "Errore")
            End If
        End If
        ' Carica l'ultima revisione della ricetta
        If Not (errore) Then
            errore = ricetta.Carica(_lotto.NomeRicetta)
            If (errore) Then
                MsgBox(String.Format("Errore nel caricamento dell'ultima revisione della ricetta ""{0}"": impossibile utilizzare il lotto ""{1}"".", _lotto.NomeRicetta, _lotto.Nome), _
                       CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                       "Errore")
            End If
        End If
        ' Confronta la ricetta del lotto con l'ultima revisione
        If Not (errore) Then
            errore = Not (cRicetta.SonoUguali(_lotto.Ricetta, ricetta))
            If (errore) Then
                MsgBox(String.Format("La ricetta ""{0}"" è stata modificata: impossibile utilizzare il lotto ""{1}"".", _lotto.NomeRicetta, _lotto.Nome), _
                       CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                       "Errore")
            End If
        End If
        ' Verifica che la ricetta master non sia stata cancellata
        If Not (errore) Then
            errore = Not (cRicetta.Esiste(CStr(_lotto.Ricetta.NomeRicettaMaster.Valore)))
            If (errore) Then
                MsgBox(String.Format("La ricetta master ""{0}"" è stata cancellata: impossibile utilizzare il lotto ""{1}"".", _lotto.Ricetta.NomeRicettaMaster.Valore, _lotto.Nome), _
                       CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                       "Errore")
            End If
        End If
        ' Carica l'ultima revisione della ricetta master
        If Not (errore) Then
            errore = ricetta.Carica(CStr(_lotto.Ricetta.NomeRicettaMaster.Valore))
            If (errore) Then
                MsgBox(String.Format("Errore nel caricamento dell'ultima revisione della ricetta master ""{0}"": impossibile utilizzare il lotto ""{1}"".", _lotto.Ricetta.NomeRicettaMaster.Valore, _lotto.Nome), _
                       CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                       "Errore")
            End If
        End If
        ' Confronta la ricetta master del lotto con l'ultima revisione
        If Not (errore) Then
            errore = Not (cRicetta.SonoUguali(_lotto.RicettaMaster, ricetta))
            If (errore) Then
                ' Se è stata modificata la ricetta master, copio le modifiche nella ricetta master del lotto
                Try
                    My.Computer.FileSystem.CopyFile(mGlobale.PercorsoRicette & "\" & Lotto.Ricetta.NomeRicettaMaster.ValoreStringa & ".txt", mGlobale.PercorsoLotti & "\" & nomeLotto & "\" & "Ricetta master.txt", True)
                Catch ex As Exception
                    MsgBox("Errore nell'aggiornamento della ricetta master del lotto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End Try
                _lotto.Carica()
                errore = False
            End If
        End If
        ' Se si sono verificati errori
        If (errore) Then
            ' Cancella il nome del lotto
            _lotto.Nome = ""
        End If
        ' Salva il nome lotto utilizzato
        If (SalvaNomeLottoUtilizzato(_lotto.Nome)) Then
            MsgBox("Errore nel salvataggio del nome del lotto utilizzato.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Restituisce il flag d'errore
        CaricaLotto = errore
    End Function



    Public Function CaricaNomeLottoUtilizzato(ByRef nomeLotto As String) As Boolean
        Dim file As StreamReader = Nothing

        Try
            ' Apre il file
            file = New StreamReader(PercorsoFileLottoUtilizzato)
            ' Legge il nome del lotto precedentemente utilizzato
            nomeLotto = file.ReadLine
            ' Restituisce False
            CaricaNomeLottoUtilizzato = False

        Catch ex As Exception
            ' Restituisce True
            CaricaNomeLottoUtilizzato = True

        Finally
            ' Chiude il file
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try
    End Function



    Public Function ChiudiSessione() As Boolean
        Dim errore As Boolean

        ' Disabilito tutte le uscite dell'I/O Remoto
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U04_OnRaffreddamento) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U05) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U07_LedVerdiAvvio) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U10_LampBuono) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U11_LampScarto) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U12_Cicalino) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U16_RelèConnCellaLD) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U17_RelèRiscaldatoreLD) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U20_RelèConnDirettaLD) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U21_RelèVoltmetroLD) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U22_RelèConnCellaNTK) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U23_RelèConnCellaPinIpNTK) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U24_RelèRiscaldatoreNTK) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U25_RelèConnDirettaNTK) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U26_RelèAmperometroPinIpNTK) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento) = False
        If mGlobale.IOremoto.Scrivi Then
            MsgBox("Errore nella scrittura dell'I/O Remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            errore = True
        End If

        ' Restituisce il flag d'errore
        ChiudiSessione = errore
    End Function



    Public Function SalvaNomeLottoUtilizzato(ByVal nomeLotto As String) As Boolean
        Dim file As StreamWriter = Nothing

        Try
            file = New StreamWriter(PercorsoFileLottoUtilizzato)
            file.WriteLine(nomeLotto)
            SalvaNomeLottoUtilizzato = False

        Catch ex As Exception
            SalvaNomeLottoUtilizzato = True

        Finally
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try

    End Function



    Public Sub Ciclo()
        Static t0Blink As Date
        Static t0LetturaIngressi As Date
        Static t0ScritturaUscite As Date

        ' Genera il flag di lampeggio
        If ((Date.Now - t0Blink).TotalMilliseconds > 500) Then
            _blink = Not (_blink)
            t0Blink = Date.Now
        End If
        ' Legge lo stato degli ingressi
        If ((Date.Now - t0LetturaIngressi).TotalMilliseconds > _periodoLetturaIngressi_ms) Then
            If (mGlobale.IOremoto.Leggi) Then
                MsgBox("Errore nella lettura dell'I/O remoto", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            t0LetturaIngressi = Date.Now
        End If
        ' Se manca il consenso dai pressostati Aria e/o Azoto
        If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I00_PressostatoAria1) = False Then
            If _fase > eFase.AttesaAvvioCiclo Then
                _fase = eFase.ResetFineCiclo
                _sottofase = 0
            Else
                _fase = eFase.AttesaPressioneAriaOK
                _sottofase = 0
            End If
        ElseIf mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I01_PressostatoAria2) = False And mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I06_Emergenza) = False Then
            ' Nascondo il messaggio di "prova in corso"
            _risultati.Inizializza()
            frmCollaudo.VisualizzaRisultati()
            If _fase > eFase.AttesaAvvioCiclo Then
                _fase = eFase.ResetFineCiclo
                _sottofase = 0
            Else
                _fase = eFase.AttesaPressioneAria2OK
                _sottofase = 0
            End If
        ElseIf mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I02_PressostatoAzoto) = False Then
            If _fase > eFase.AttesaAvvioCiclo Then
                _fase = eFase.ResetFineCiclo
                _sottofase = 0
            Else
                _fase = eFase.AttesaPressioneAzotoOK
                _sottofase = 0
            End If
        Else
            ' Se il pulsante di emergenza è premuto
            If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I06_Emergenza) = True Then
                ' Imposta il tasto reset su non premuto e toglie pressione alla campana
                _resetPremuto = False
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = False
                If _fase > eFase.AttesaAvvioCiclo Then
                    _fase = eFase.ResetFineCiclo
                    _sottofase = 0
                Else
                    _fase = eFase.AttesaSgancioEmergenza
                    _sottofase = 0
                End If
            Else
                ' Se gli ausiliari non sono inseriti
                If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I07_Ausiliari) = False Then
                    If _fase > eFase.AttesaAvvioCiclo Then
                        _fase = eFase.ResetFineCiclo
                        _sottofase = 0
                    Else
                        _fase = eFase.AttesaInserimentoAusiliari
                        _sottofase = 0
                    End If
                Else
                    If _fase = eFase.AttesaInserimentoAusiliari Then
                        _fase = eFase.AttesaPressioneReset
                        _sottofase = 0
                    End If
                End If
                ' Se all'apertura della finestra di collaudo non è stato premuto il pulsante reset
                If _resetPremuto = False Then
                    If _fase > eFase.AttesaAvvioCiclo Then
                        _fase = eFase.ResetFineCiclo
                        _sottofase = 0
                    Else
                        _fase = eFase.AttesaPressioneReset
                    End If
                Else
                    If _fase = eFase.AttesaPressioneReset Then
                        _fase = eFase.AttesaAvvioCiclo
                        _sottofase = 0
                    End If
                End If
                ' Se il pezzo non è presente
                If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I27_SensorePresPz) = False Then
                    If _fase = eFase.AttesaAvvioCiclo Then
                        _fase = eFase.AttesaInserimentoPezzo
                        _sottofase = 0
                    End If
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U07_LedVerdiAvvio) = False
                Else
                    If _fase = eFase.AttesaInserimentoPezzo Then
                        _fase = eFase.AttesaAvvioCiclo
                        _sottofase = 0
                    End If
                End If
                '
            End If
        End If
        ' Gestisce le fasi
        Select Case _fase
            Case eFase.AttesaPressioneAriaOK
                FaseAttesaPressioneAriaOK()
            Case eFase.AttesaPressioneAria2OK
                FaseAttesaPressioneAria2OK()
            Case eFase.AttesaPressioneAzotoOK
                FaseAttesaPressioneAzotoOK()
            Case eFase.AttesaSgancioEmergenza
                FaseAttesaSgancioEmergenza()
            Case eFase.AttesaInserimentoAusiliari
                FaseAttesaInserimentoAusiliari()
            Case eFase.AttesaPressioneReset
                FaseAttesaPressioneReset()
            Case eFase.AttesaInserimentoPezzo
                FaseAttesaInserimentoPezzo()
            Case eFase.AttesaAvvioCiclo
                FaseAttesaAvvioCiclo()
            Case eFase.InizializzazioneCollaudo
                FaseInizializzazioneCollaudo()
            Case eFase.ChiusuraCampana
                FaseChiusuraCampana()
            Case eFase.ChiusuraPinza
                FaseChiusuraPinza()
            Case eFase.MisuraTensioneAlimentazione
                FaseMisuraTensioneAlimentazione()
            Case eFase.MisuraResistenzaRiscaldatore
                If CBool(_ricetta.Rheater_Abilitazione.Valore) = True Then
                    FaseMisuraResistenzaRiscaldatore()
                Else
                    ' Select case basato su quale cella è in collaudo
                    Select Case _ricetta.TipologiaSonda.ValoreStringa
                        Case "LSU 4.9"
                            _fase = eFase.LSU4_9_MisuraO2
                        Case "ADV"
                            _fase = eFase.ADV_MisuraLambda
                        Case Else
                            _fase = eFase.ZFAS_MisuraCorrenteEtas
                    End Select
                End If
            Case eFase.LSU4_9_MisuraO2
                If CBool(_ricetta.Lsu_O2_Abilitazione.Valore) = True Then
                    FaseLSU4_9_MisuraO2()
                Else
                    _fase = eFase.MisuraIsolamentoRiscaldatore
                End If
            Case eFase.ADV_MisuraLambda
                If CBool(_ricetta.Adv_Lambda_Abilitazione.Valore) = True Then
                    FaseAdvMisuraLambda()
                Else
                    _fase = eFase.ADV_MisuraCorrente
                End If
            Case eFase.ADV_MisuraCorrente
                If CBool(_ricetta.Adv_Ip_Abilitazione.Valore) = True Then
                    FaseAdvMisuraIP()
                Else
                    _fase = eFase.MisuraIsolamentoRiscaldatore
                End If
            Case eFase.ZFAS_MisuraCorrenteEtas
                If CBool(_ricetta.Zfas_IpEtas_Abilitazione.Valore) = True Then
                    FaseZfasMisuraIpEtas()
                Else
                    _fase = eFase.ZFAS_MisuraCorrenteTB
                End If
            Case eFase.ZFAS_MisuraCorrenteTB
                If CBool(_ricetta.Zfas_IpTB_Abilitazione.Valore) = True Then
                    FaseZfasMisuraIpTB()
                Else
                    _fase = eFase.MisuraIsolamentoRiscaldatore
                End If
            Case eFase.MisuraIsolamentoRiscaldatore
                If CBool(_ricetta.Resistenza_Isolamento_Abilitazione.Valore) = True Then
                    FaseMisuraIsolamento()
                Else
                    _fase = eFase.ValutazioneEsitoCollaudo
                End If
            Case eFase.RaffreddamentoPezzo
                FaseRaffreddamentoPezzo()
            Case eFase.RaffreddamentoSicurezzaPezzo
                FaseRaffreddamentoSicurezzaPezzo()
            Case eFase.ValutazioneEsitoCollaudo
                FaseValutazioneEsitoCollaudo()
            Case eFase.ScritturaRisultati
                FaseScritturaRisultati()
            Case eFase.ScaricoPezzoBuono
                FaseScaricoPezzoBuono()
            Case eFase.ScaricoPezzoScarto
                FaseScaricoPezzoScarto()
            Case eFase.ResetFineCiclo
                FaseResetFineCiclo()
        End Select
        ' Scrive lo stato delle uscite
        If ((Date.Now - t0ScritturaUscite).TotalMilliseconds > _periodoScritturaUscite_ms) Then
            If (mGlobale.IOremoto.Scrivi) Then
                MsgBox("Errore nella scrittura dell'I/O remoto", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            t0ScritturaUscite = Date.Now
        End If
    End Sub



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Sub FaseAttesaPressioneAriaOK()
        ' Se la pressione dell'aria 1 è sufficiente
        If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I00_PressostatoAria1) = True Then
            ' Passa alla fase successiva
            _fase = eFase.AttesaPressioneAria2OK
            _sottofase = 0
        End If
    End Sub



    Private Sub FaseAttesaPressioneAria2OK()
        ' Se la pressione dell'aria 2 è sufficiente
        If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I01_PressostatoAria2) = True Then
            ' Passa alla fase successiva
            _fase = eFase.AttesaPressioneAzotoOK
            _sottofase = 0
        End If
    End Sub



    Private Sub FaseAttesaPressioneAzotoOK()
        ' Se la pressione dell'azoto è sufficiente
        If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I02_PressostatoAzoto) = True Then
            ' Passa alla fase successiva
            _fase = eFase.AttesaSgancioEmergenza
            _sottofase = 0
        End If
    End Sub



    Private Sub FaseAttesaSgancioEmergenza()
        ' Se non è premuto il pulsante emergenza
        If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I06_Emergenza) = False Then
            ' Passa alla fase successiva
            _fase = eFase.AttesaInserimentoAusiliari
            _sottofase = 0
        End If
    End Sub



    Private Sub FaseAttesaInserimentoAusiliari()
        ' Se gli ausiliari sono inseriti
        If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I07_Ausiliari) = True Then
            ' Passa alla fase successiva
            _fase = eFase.AttesaPressioneReset
            _sottofase = 0
        End If
    End Sub



    Private Sub FaseAttesaPressioneReset()
        ' Se viene premuto il tasto reset
        If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I12_BtnReset) = True Then
            ' Abilito il flag per passare allo stato successivo
            _resetPremuto = True
        End If
        ' Se il flag è stato alzato o era già alto in precedenza
        If _resetPremuto = True Then
            ' Se la campana è chiusa e il pezzo è ancora inserito provvedo ad effettuare un raffreddamento di 30 secondi per sicurezza
            If (mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I24_FcCampanaBassa) = True And mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I27_SensorePresPz) = True) Then
                _fase = eFase.RaffreddamentoSicurezzaPezzo
            Else
                _fase = eFase.AttesaInserimentoPezzo
            End If
            _sottofase = 0
        End If
    End Sub



    Private Sub FaseAttesaInserimentoPezzo()
        ' Sollevo la campana e apro la pinza per consentire l'inserimento del pezzo
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = True
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = True
        ' Se è stato inserito un pezzo
        If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I27_SensorePresPz) = True Then
            ' Passa alla fase successiva
            _fase = eFase.AttesaAvvioCiclo
            _sottofase = 0
        End If
    End Sub



    Private Sub FaseAttesaAvvioCiclo()
        Dim avvioCiclo As Boolean
        Static tmrRitardoAvvioCiclo As New cTimer
        ' Sollevo la campana e apro la pinza casomai il pezzo fosse rimasto dentro
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = True
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = True
        ' Lampeggio verde pulsante di avvio ciclo
        If _blink Then
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U07_LedVerdiAvvio) = True
        Else
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U07_LedVerdiAvvio) = False
        End If
        ' Flag di avvio ciclo
        avvioCiclo = mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I10_BtnAvvioCiclo)
        ' Pilota il timer di ritardo avvio ciclo
        tmrRitardoAvvioCiclo.Pilota(avvioCiclo, 0.2)
        ' Se il timer di ritardo avvio ciclo è attivo
        If (tmrRitardoAvvioCiclo.Stato) Then
            ' Spegnimento pulsante di avvio ciclo
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U07_LedVerdiAvvio) = False
            ' Passa alla fase successiva
            _fase = eFase.InizializzazioneCollaudo
            _sottofase = 0
        End If
    End Sub



    Private Sub FaseInizializzazioneCollaudo()
        ' Imposta il riferimento alla _ricetta da utilizzare
        If (_cicloMaster) Then
            _ricetta = _lotto.RicettaMaster
        Else
            _ricetta = _lotto.Ricetta
        End If
        ' Cancella i risultati
        _risultati.Esito = cRisultati.eEsito.ProvaInCorso
        '
        _risultati.DataCollaudo.Valore = Format(Date.Now, "dd/MM/yyyy")
        _risultati.DataCollaudo.Esito = cValoreRisultato.eEsito.NonProvato
        '
        _risultati.OraCollaudo.Valore = Format(Date.Now, "HH:mm:ss")
        _risultati.OraCollaudo.Esito = cValoreRisultato.eEsito.NonProvato
        '
        _risultati.PezzoRipassato.Valore = _ripassoScarti
        _risultati.PezzoRipassato.Esito = cValoreRisultato.eEsito.NonProvato
        '
        _risultati.Val.Minimo = CSng(_ricetta.Val_Min.Valore)
        _risultati.Val.Massimo = CSng(_ricetta.Val_Max.Valore)
        _risultati.Val.Valore = 0
        _risultati.Val.Esito = cValoreRisultato.eEsito.Sconosciuto
        '
        _risultati.Rheater.Minimo = CSng(_ricetta.Rheater_Min.Valore)
        _risultati.Rheater.Massimo = CSng(_ricetta.Rheater_Max.Valore)
        _risultati.Rheater.Valore = 0
        If CBool(_ricetta.Rheater_Abilitazione.Valore) = True Then
            _risultati.Rheater.Esito = cValoreRisultato.eEsito.Sconosciuto
        Else
            _risultati.Rheater.Esito = cValoreRisultato.eEsito.Disabilitato
        End If
        '
        _risultati.Lsu_TemperaturaOperativa.Minimo = CSng(_ricetta.Lsu_Temperatura_Operativa_Min.Valore)
        _risultati.Lsu_TemperaturaOperativa.Massimo = CSng(_ricetta.Lsu_Temperatura_Operativa_Max.Valore)
        _risultati.Lsu_TemperaturaOperativa.Valore = 0
        If CBool(_ricetta.Lsu_Temperatura_Operativa_Abilitazione.Valore) = True Then
            _risultati.Lsu_TemperaturaOperativa.Esito = cValoreRisultato.eEsito.Sconosciuto
        Else
            _risultati.Lsu_TemperaturaOperativa.Esito = cValoreRisultato.eEsito.Disabilitato
        End If
        ''
        _risultati.Lsu_O2.Minimo = CSng(_ricetta.Lsu_O2_Min.Valore)
        _risultati.Lsu_O2.Massimo = CSng(_ricetta.Lsu_O2_Max.Valore)
        _risultati.Lsu_O2.Valore = 0
        If CBool(_ricetta.Lsu_O2_Abilitazione.Valore) = True Then
            _risultati.Lsu_O2.Esito = cValoreRisultato.eEsito.Sconosciuto
        Else
            _risultati.Lsu_O2.Esito = cValoreRisultato.eEsito.Disabilitato
        End If
        '
        _risultati.CorrenteRiscaldatore.Minimo = CSng(_ricetta.Corrente_Riscaldatore_Min.Valore)
        _risultati.CorrenteRiscaldatore.Massimo = CSng(_ricetta.Corrente_Riscaldatore_Max.Valore)
        _risultati.CorrenteRiscaldatore.Valore = 0
        If CBool(_ricetta.Corrente_Riscaldatore_Abilitazione.Valore) = True Then
            _risultati.CorrenteRiscaldatore.Esito = cValoreRisultato.eEsito.Sconosciuto
        Else
            _risultati.CorrenteRiscaldatore.Esito = cValoreRisultato.eEsito.Disabilitato
        End If
        '
        _risultati.Lsu_ResistenzaCalibrazione.Minimo = CSng(_ricetta.Lsu_Resistenza_Calibrazione_Min.Valore)
        _risultati.Lsu_ResistenzaCalibrazione.Massimo = CSng(_ricetta.Lsu_Resistenza_Calibrazione_Max.Valore)
        _risultati.Lsu_ResistenzaCalibrazione.Valore = 0
        If CBool(_ricetta.Lsu_Resistenza_Calibrazione_Abilitazione.Valore) = True Then
            _risultati.Lsu_ResistenzaCalibrazione.Esito = cValoreRisultato.eEsito.Sconosciuto
        Else
            _risultati.Lsu_ResistenzaCalibrazione.Esito = cValoreRisultato.eEsito.Disabilitato
        End If
        '
        _risultati.ResistenzaIsolamento.Minimo = CSng(_ricetta.Resistenza_Isolamento_Min.Valore)
        _risultati.ResistenzaIsolamento.Massimo = 99999
        _risultati.ResistenzaIsolamento.Valore = 0
        If CBool(_ricetta.Resistenza_Isolamento_Abilitazione.Valore) = True Then
            _risultati.ResistenzaIsolamento.Esito = cValoreRisultato.eEsito.Sconosciuto
        Else
            _risultati.ResistenzaIsolamento.Esito = cValoreRisultato.eEsito.Disabilitato
        End If
        '
        ' Visualizza i risultati
        frmCollaudo.VisualizzaRisultati()
        ' Campionamento posizione zero
        ' Lascio andare la campana e libero la pinza
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = False
        ' Passa alla fase successiva
        _fase = eFase.ChiusuraCampana
        _sottofase = 0
    End Sub



    Private Sub FaseChiusuraCampana()
        ' Attendo che venga raggiunto il sensore di chiusura per sigillare la campana
        If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I24_FcCampanaBassa) Then
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = True
            ' Passo alla fase successiva
            _fase = eFase.ChiusuraPinza
            _sottofase = 0
        End If
    End Sub



    Private Sub FaseChiusuraPinza()
        ' Chiudo la pinza per iniziare le misurazioni
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = True
        ' Attendo che il sensore mi comunichi l'avvenuta chiusura
        If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I26_FcPinzaChiusa) Then
            ' Passo alla fase successiva
            _fase = eFase.MisuraTensioneAlimentazione
            _sottofase = 0
        End If
    End Sub



    Private Sub FaseMisuraTensioneAlimentazione()
        Static t0 As Date
        Dim _tensione As Double

        ' Gestisce le sottofasi
        Select Case _sottofase
            Case 0  ' Collego il relè
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS) = True
                ' Memorizza il tempo
                t0 = Date.Now
                ' Passa alla sottofase 1
                _sottofase = 1

            Case 1  ' Attendo 200ms ed effettuo la misurazione
                If ((Date.Now - t0).TotalMilliseconds > 200) Then
                    If (mGestioneSetpointMisure.MisuraTensione(_tensione)) Then
                        MsgBox("Errore nella lettura della tensione dal multimetro.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    End If
                    ' Verifico che non sia in over range la misura
                    If _tensione < 0 Then
                        _tensione = 0
                    ElseIf _tensione > 9999 Then
                        _tensione = 9999
                    End If
                    ' Memorizzo il valore misurato
                    _risultati.Val.Valore = _tensione
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 2
                    _sottofase = 2
                End If

            Case 2  ' Attendo 50ms e valuto le misure
                If ((Date.Now - t0).TotalMilliseconds > 50) Then
                    ' Verifico il valore misurato
                    _risultati.Val.Prova()
                    ' Scollego il relè
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS) = False
                    ' Visualizza i risultati
                    frmCollaudo.VisualizzaRisultati()
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 4
                    _sottofase = 3
                End If

            Case 3 ' Attesa passo
                If mGestoreCollaudo.CicloManuale Then
                    ' Lampeggio rosso pulsante di avvio ciclo
                    If _blink Then
                        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = True
                    Else
                        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
                    End If
                    ' Se è premuto l'avvio ciclo
                    If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I10_BtnAvvioCiclo) Then
                        ' Passa al cambio fase
                        _sottofase = 4
                    End If
                Else
                    ' Passa al cambio fase
                    _sottofase = 4
                End If

            Case 4 ' Cambio fase
                ' Spegnimento pulsante di avvio ciclo
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
                ' Passa al test successivo o interrompi il collaudo se il valore non è congruo
                If (_risultati.Val.Esito = cValoreRisultato.eEsito.Ko And _cicloInterrottoScarto = True) Then
                    _fase = eFase.ValutazioneEsitoCollaudo
                Else
                    _fase = eFase.MisuraResistenzaRiscaldatore
                End If
                _sottofase = 0
        End Select
    End Sub



    Private Sub FaseMisuraResistenzaRiscaldatore()
        Static t0 As Date
        Dim _resistenza As Double

        ' Gestisce le sottofasi
        Select Case _sottofase
            Case 0  ' Collego il relè
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore) = True
                ' Memorizza il tempo
                t0 = Date.Now
                ' Passa alla sottofase 1
                _sottofase = 1

            Case 1  ' Attendo 200ms ed effettuo la misurazione
                If ((Date.Now - t0).TotalMilliseconds > 500) Then
                    If (mGestioneSetpointMisure.MisuraResistenza(_resistenza)) Then
                        MsgBox("Errore nella lettura della resistenza dal multimetro.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    End If
                    ' Verifico che non sia in over range la misura
                    If _resistenza < 0 Then
                        _resistenza = 0
                    ElseIf _resistenza > 9999 Then
                        _resistenza = 9999
                    End If
                    ' Memorizzo il valore misurato
                    _risultati.Rheater.Valore = _resistenza
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 2
                    _sottofase = 2
                End If

            Case 2  ' Attendo 50ms e valuto le misure
                If ((Date.Now - t0).TotalMilliseconds > 50) Then
                    ' Verifico il valore misurato
                    _risultati.Rheater.Prova()
                    ' Scollego il relè
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore) = False
                    ' Visualizza i risultati
                    frmCollaudo.VisualizzaRisultati()
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 4
                    _sottofase = 3
                End If

            Case 3 ' Attesa passo
                If mGestoreCollaudo.CicloManuale Then
                    ' Lampeggio rosso pulsante di avvio ciclo
                    If _blink Then
                        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = True
                    Else
                        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
                    End If
                    ' Se è premuto l'avvio ciclo
                    If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I10_BtnAvvioCiclo) Then
                        ' Passa al cambio fase
                        _sottofase = 4
                    End If
                Else
                    ' Passa al cambio fase
                    _sottofase = 4
                End If

            Case 4 ' Cambio fase
                ' Spegnimento pulsante di avvio ciclo
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
                ' Passa al test successivo o interrompi il collaudo se il valore non è congruo
                If (_risultati.Rheater.Esito = cValoreRisultato.eEsito.Ko And _cicloInterrottoScarto = True) Then
                    _fase = eFase.ValutazioneEsitoCollaudo
                Else
                    ' Verifica quale tipologia di sonda è stata collaudata
                    Select Case _ricetta.TipologiaSonda.ValoreStringa
                        Case "LSU 4.9"
                            _fase = eFase.LSU4_9_MisuraO2
                        Case "ADV"
                            _fase = eFase.ADV_MisuraLambda
                        Case Else
                            _fase = eFase.ZFAS_MisuraCorrenteEtas
                    End Select

                    ' Memorizzo il tempo per visualizzare il countdown sul display
                    _t0Display = Date.Now
                End If
                _sottofase = 0
        End Select
    End Sub



    Private Sub FaseLSU4_9_MisuraO2()
        Static t0 As Date
        Static t1 As Date
        Dim media As Double
        Dim _portataO2 As Single
        Dim _portataN2 As Single
        Dim _corrente As Double

        ' Gestisce le sottofasi
        Select Case _sottofase
            Case 0  ' Collego il relè
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = True
                ' Preparo la miscela di ossigeno ed azoto
                _portataO2 = CSng(_ricetta.Lsu_Flusso_Aria_Erogato.Valore) * (100 / System.Convert.ToSingle(mGlobale.Mass_Flow_Controller_O2.FondoScala))
                If mGestioneSetpointMisure.SetPortataMFC_O2(_portataO2) Then
                    MsgBox("Errore nella scrittura del valore nel Mass Flow Controller O2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                End If
                _portataN2 = CSng(_ricetta.Lsu_Flusso_N2_Erogato.Valore) * (100 / System.Convert.ToSingle(mGlobale.Mass_Flow_Controller_N2.FondoScala))
                If mGestioneSetpointMisure.SetPortataMFC_N2(_portataN2) Then
                    MsgBox("Errore nella scrittura del valore nel Mass Flow Controller N2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                End If
                ' Memorizza il tempo
                t0 = Date.Now
                ' Memorizza il tempo per aggiornare la temperatura
                t1 = Date.Now
                ' Passa alla sottofase 1
                _sottofase = 1

            Case 1  ' Attendo n secondi per mandare in temperatura la sonda
                If ((Date.Now - t0).TotalSeconds > CDbl(_ricetta.Tempo_Riscaldamento.Valore)) Then
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 2
                    _sottofase = 2
                End If
                ' Ogni secondo mostro la temperatura per mostrarne l'avvicinamento alla soglia operativa
                If ((Date.Now - t1).TotalSeconds > 1) Then
                    t1 = Date.Now
                    If (mGlobale.Lambda.AvviaMisurazione) Then
                        MsgBox("Errore nella lettura della sonda lambda.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    Else
                        _risultati.Lsu_TemperaturaOperativa.Valore = mGlobale.Lambda.Temperatura
                        _risultati.Lsu_O2.Valore = mGlobale.Lambda.O2
                        mGlobale.Lambda.ArrestaMisurazione()
                        If (mGestioneSetpointMisure.MisuraCorrente(10, _corrente)) Then
                            MsgBox("Errore nella lettura della corrente dal multimetro.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                        Else
                            ' Verifico che non sia in over range la misura
                            If _corrente < 0 Then
                                _corrente = 0
                            ElseIf _corrente > 9999 Then
                                _corrente = 9999
                            End If
                            _risultati.CorrenteRiscaldatore.Valore = _corrente * 1000
                        End If
                        If CBool(_ricetta.Lsu_Temperatura_Operativa_Abilitazione.Valore) Then
                            _risultati.Lsu_TemperaturaOperativa.Prova()
                        End If
                        If CBool(_ricetta.Lsu_O2_Abilitazione.Valore) Then
                            _risultati.Lsu_O2.Prova()
                        End If
                        If CBool(_ricetta.Corrente_Riscaldatore_Abilitazione.Valore) Then
                            _risultati.CorrenteRiscaldatore.Prova()
                        End If
                    End If
                    ' Arresto la misurazione della sonda
                    If (mGlobale.Lambda.ArrestaMisurazione) Then
                        MsgBox("Errore nell'arresto della lettura della sonda lambda.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    End If
                    ' Visualizzo i risultati ottenuti
                    frmCollaudo.VisualizzaRisultati()
                End If

            Case 2  ' Attendo 1 secondo per effettuare la misurazione dei valori della sonda
                If ((Date.Now - t0).TotalSeconds > 1) Then
                    ' MODIFICA AGGIUNTA PER MEDIA ARITMETICA MISURA O2%
                    For i = 0 To 9
                        mGlobale.Lambda.AvviaMisurazione()
                        media += mGlobale.Lambda.O2
                        mGlobale.Lambda.ArrestaMisurazione()
                        t0 = Date.Now
                        Do
                        Loop Until ((Date.Now - t0).TotalSeconds >= 0.5)
                    Next
                    ' FINE MODIFICA AGGIUNTA PER MEDIA ARITMETICA MISURA O2%
                    If (mGlobale.Lambda.AvviaMisurazione) Then
                        MsgBox("Errore nella lettura della sonda lambda.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    Else
                        _risultati.Lsu_TemperaturaOperativa.Valore = mGlobale.Lambda.Temperatura
                        '_risultati.O2.Valore = mGlobale.Lambda.O2
                        _risultati.Lsu_O2.Valore = media / 10
                        mGlobale.Lambda.ArrestaMisurazione()
                    End If
                    ' Arresto la misurazione della sonda
                    If (mGlobale.Lambda.ArrestaMisurazione) Then
                        MsgBox("Errore nell'arresto della lettura della sonda lambda.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    End If
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 3
                    _sottofase = 3
                End If

            Case 3  ' Misuro la corrente del riscaldatore a regime
                If ((Date.Now - t0).TotalMilliseconds > 50) Then
                    If (mGestioneSetpointMisure.MisuraCorrente(10, _corrente)) Then
                        MsgBox("Errore nella lettura della corrente dal multimetro.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    Else
                        ' Verifico che non sia in over range la misura
                        If _corrente < 0 Then
                            _corrente = 0
                        ElseIf _corrente > 9999 Then
                            _corrente = 9999
                        End If
                        _risultati.CorrenteRiscaldatore.Valore = _corrente * 1000
                    End If
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 4
                    _sottofase = 4
                End If

            Case 4  ' Controllo i risultati ottenuti dalle misurazioni
                Dim ipNom As Double
                Dim ipMis As Double
                If ((Date.Now - t0).TotalMilliseconds > 50) Then
                    ' Calcolo la resistenza di calibrazione (sostituito O2 minimo con Target O2%)
                    ipNom = 0.0007 * (CDbl(_ricetta.Lsu_Target_O2.Valore) * CDbl(_ricetta.Lsu_Target_O2.Valore)) + 0.1084 * CDbl(_ricetta.Lsu_Target_O2.Valore) - 0.0097
                    ipMis = 0.0007 * (CDbl(_risultati.Lsu_O2.Valore) * CDbl(_risultati.Lsu_O2.Valore)) + 0.1084 * CDbl(_risultati.Lsu_O2.Valore) - 0.0097
                    _risultati.Lsu_ResistenzaCalibrazione.Valore = CSng((ipNom * 61.9) / (ipMis + (ipMis / 4.847) - ipNom))
                    ' Verifico i valori ottenuti
                    If CBool(_ricetta.Lsu_Resistenza_Calibrazione_Abilitazione.Valore) Then
                        _risultati.Lsu_ResistenzaCalibrazione.Prova()
                    End If
                    If CBool(_ricetta.Lsu_Temperatura_Operativa_Abilitazione.Valore) Then
                        _risultati.Lsu_TemperaturaOperativa.Prova()
                    End If
                    If CBool(_ricetta.Lsu_O2_Abilitazione.Valore) Then
                        _risultati.Lsu_O2.Prova()
                    End If
                    If CBool(_ricetta.Corrente_Riscaldatore_Abilitazione.Valore) Then
                        _risultati.CorrenteRiscaldatore.Prova()
                    End If
                    ' Scollego il relè
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = False
                    ' Arresto i flussi di Ossigeno e Azoto
                    If mGlobale.Mass_Flow_Controller_O2.SetPortata(0) Then
                        MsgBox("Errore nella scrittura del valore nel Mass Flow Controller O2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    End If
                    If mGlobale.Mass_Flow_Controller_N2.SetPortata(0) Then
                        MsgBox("Errore nella scrittura del valore nel Mass Flow Controller N2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    End If
                    ' Visualizzo i risultati ottenuti
                    frmCollaudo.VisualizzaRisultati()
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 5
                    _sottofase = 5
                End If

            Case 5  ' Attesa Passo
                If mGestoreCollaudo.CicloManuale Then
                    ' Lampeggio rosso pulsante di avvio ciclo
                    If _blink Then
                        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = True
                    Else
                        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
                    End If
                    ' Se è premuto l'avvio ciclo
                    If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I10_BtnAvvioCiclo) Then
                        ' Passa al cambio fase
                        _sottofase = 6
                    End If
                Else
                    ' Passa al cambio fase
                    _sottofase = 6
                End If

            Case 6  ' Cambio Fase
                ' Spegnimento pulsante di avvio ciclo
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
                ' Passa al test successivo
                _fase = eFase.MisuraIsolamentoRiscaldatore
                _sottofase = 0
        End Select
    End Sub



    Private Sub FaseAdvMisuraLambda()

    End Sub



    Private Sub FaseAdvMisuraIP()

    End Sub



    Private Sub FaseZfasMisuraIpEtas()

    End Sub



    Private Sub FaseZfasMisuraIpTB()

    End Sub



    Private Sub FaseMisuraIsolamento()
        Static t0 As Date
        Dim _corrente As Double

        ' Gestisce le sottofasi
        Select Case _sottofase
            Case 0 ' Collego il relè
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento) = True
                ' Memorizza il tempo
                t0 = Date.Now
                ' Passa alla sottofase 1
                _sottofase = 1

            Case 1  ' Passato 1s effettuo la misurazione
                If ((Date.Now - t0).TotalSeconds > 1.5) Then
                    'For i = 0 To 4
                    If (mGestioneSetpointMisure.MisuraCorrente(0.0001, _corrente)) Then
                        MsgBox("Errore nella lettura della corrente dal multimetro.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    End If
                    'Next
                    ' Verifico che non sia in over range la misura
                    If _corrente < 0 Then
                        _corrente = 0
                    ElseIf _corrente > 9999 Then
                        _corrente = 9999
                    End If
                    _risultati.ResistenzaIsolamento.Valore = (CSng(_risultati.Val.Valore) / CDec(_corrente)) / 1000000
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 2
                    _sottofase = 2
                End If

            Case 2  ' Dopo 50ms verifico i valori ottenuti
                If ((Date.Now - t0).TotalMilliseconds > 50) Then
                    _risultati.ResistenzaIsolamento.Prova()
                    ' Scollego il relè
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento) = False
                    ' Visualizzo i valori ottenuti
                    frmCollaudo.VisualizzaRisultati()
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 3
                    _sottofase = 3
                End If

            Case 3 ' Attesa passo
                If mGestoreCollaudo.CicloManuale Then
                    ' Lampeggio rosso pulsante di avvio ciclo
                    If _blink Then
                        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = True
                    Else
                        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
                    End If
                    ' Se è premuto l'avvio ciclo
                    If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I10_BtnAvvioCiclo) Then
                        ' Passa al cambio fase
                        _sottofase = 4
                    End If
                Else
                    ' Passa al cambio fase
                    _sottofase = 4
                End If

            Case 4 ' Cambio fase
                ' Spegnimento pulsante di avvio ciclo
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
                ' Memorizzo il tempo per visualizzare il countdown sul display
                _t0Display = Date.Now
                ' Passa al test successivo
                _fase = eFase.RaffreddamentoPezzo
                _sottofase = 0
        End Select
    End Sub



    Private Sub FaseRaffreddamentoPezzo()
        Static t0 As Date

        Select Case _sottofase
            Case 0 ' Avvio il raffreddamento
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U04_OnRaffreddamento) = True
                ' Memorizzo il tempo
                t0 = Date.Now
                ' Passo alla sottofase successiva
                _sottofase = 1
            Case 1 ' Raggiunto il tempo di raffreddamento richiesto interrompo il flusso d'aria
                If (Date.Now - t0).TotalSeconds > CDbl(_ricetta.Tempo_Raffreddamento.Valore) Then
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U04_OnRaffreddamento) = False
                    ' Passo alla sottofase successiva
                    _sottofase = 2
                End If
            Case 2 ' Attesa passo
                If mGestoreCollaudo.CicloManuale Then
                    ' Lampeggio rosso pulsante di avvio ciclo
                    If _blink Then
                        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = True
                    Else
                        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
                    End If
                    ' Se è premuto l'avvio ciclo
                    If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I10_BtnAvvioCiclo) Then
                        ' Passa al cambio fase
                        _sottofase = 3
                    End If
                Else
                    ' Passa al cambio fase
                    _sottofase = 3
                End If

            Case 3 ' Cambio fase
                ' Spegnimento pulsante di avvio ciclo
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
                ' Passa al test successivo
                _fase = eFase.ValutazioneEsitoCollaudo
                _sottofase = 0
        End Select
    End Sub



    Private Sub FaseRaffreddamentoSicurezzaPezzo()
        Static t0 As Date

        Select Case _sottofase
            Case 0 ' Chiudo la campana e raffreddo il pezzo
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U04_OnRaffreddamento) = True
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = True
                ' Memorizzo il tempo
                t0 = Date.Now
                ' Passo alla sottofase successiva
                _sottofase = 1
            Case 1 ' Passato il tempo necessario apro la pinza e la campana per estrarre il pezzo
                If (Date.Now - t0).TotalSeconds > 30 Then
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U04_OnRaffreddamento) = False
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = False
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = True
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = True
                    ' Passo alla sottofase successiva
                    _sottofase = 2
                End If

            Case 2 ' Torno alla fase di attesa pressione pulsante reset se viene tolto il pezzo dal posaggio
                If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I27_SensorePresPz) = False Then
                    _fase = eFase.AttesaPressioneReset
                    _sottofase = 0
                End If
        End Select
    End Sub



    Private Sub FaseValutazioneEsitoCollaudo()
        ' Set esito complessivo collaudo
        If _risultati.Val.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.ScartoVal
        ElseIf _risultati.Rheater.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.ScartoRheater
        ElseIf _risultati.Lsu_TemperaturaOperativa.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.Lsu_ScartoTemperaturaOperativa
        ElseIf _risultati.Lsu_O2.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.Lsu_ScartoO2
        ElseIf _risultati.CorrenteRiscaldatore.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.ScartoCorrenteRiscaldatore
        ElseIf _risultati.Lsu_ResistenzaCalibrazione.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.Lsu_ScartoResistenzaCalibrazione
        ElseIf _risultati.ResistenzaIsolamento.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.ScartoResistenzaIsolamento
        ElseIf _risultati.ADVlambda.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.Adv_ScartoLambda
        ElseIf _risultati.ADVIp.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.Adv_ScartoIp
        ElseIf _risultati.ZfasIpEtas.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.Zfas_ScartoIpEtas
        ElseIf _risultati.ZfasIpTB.Esito = cValoreRisultato.eEsito.Ko Then
            _risultati.Esito = cRisultati.eEsito.Zfas_ScartoIpTB
        Else
            _risultati.Esito = cRisultati.eEsito.Buono
        End If
        ' Passa alla fase successiva
        _fase = eFase.ScritturaRisultati
        _sottofase = 0
    End Sub



    Private Sub FaseScritturaRisultati()
        Dim nomeFileRisultati As String
        Dim nomeFileRicetta As String

        ' Se l'esito è buono
        If (_risultati.Esito = cRisultati.eEsito.Buono) Then
            ' Imposta l'esito a buono
            _risultati.Esito = cRisultati.eEsito.Buono
            ' Accende la lampada buono
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U10_LampBuono) = True
            ' Passa alla fase ScaricoPezzoBuono
            _fase = eFase.ScaricoPezzoBuono
            _sottofase = 0
        Else
            ' Accende la lampada scarto
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U11_LampScarto) = True
            ' Accende il cicalino
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U12_Cicalino) = True
            _t0Cicalino = Date.Now
            ' Passa alla fase ScaricoPezzoScarto
            _fase = eFase.ScaricoPezzoScarto
            _sottofase = 0
        End If
        ' Visualizza i risultati
        frmCollaudo.VisualizzaRisultati()
        ' Aggiorna il contatore generale di ciclo vita della macchina
        mImpostazioniGenerali.CicliTotaliStazione = mImpostazioniGenerali.CicliTotaliStazione + 1
        ' Salva il contatore nel file impostazioni.txt
        If (mImpostazioniGenerali.Salva(mGlobale.NomeFileImpostazioniGenerali)) Then
            MsgBox("Errore nel salvataggio delle impostazioni generali.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Salva i risultati
        If Not (_cicloMaster) Then
            If (_lotto.SalvaRisultati(_risultati)) Then
                MsgBox("Errore nel salvataggio dei risultati", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
        Else
            nomeFileRicetta = CStr(_lotto.Ricetta.NomeRicettaMaster.Valore)
            nomeFileRisultati = CStr(_lotto.Ricetta.NomeRicettaMaster.Valore) & "_" & CStr(_lotto.RicettaMaster.IndiceRevisione.Valore)
            ' Nel caso di pezzo master salva i risultati in un apposito file
            If (_lotto.SalvaRisultatiMaster(nomeFileRicetta, nomeFileRisultati, _risultati)) Then
                MsgBox("Errore nel salvataggio dei risultati del master", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
        End If
    End Sub



    Private Sub FaseScaricoPezzoBuono()
        Dim e As Boolean
        Static t0 As Date

        ' Resetta il flag d'errore
        e = False
        ' Gestisce le sottofasi
        Select Case _sottofase
            Case 0  ' Apro pinza e campana
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = False
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = False
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = True
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = True
                ' Passo alla sottofase 1
                _sottofase = 1

            Case 1  ' Se la pinza è aperta tolgo pressione 
                If (mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I25_FcPinzaAperta) = True) Then
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = False
                    ' Memorizzo il tempo
                    t0 = Date.Now
                    ' Passo alla sottofase 2
                    _sottofase = 2
                End If

            Case 2  ' Attesa 1 secondo per scarico pezzo
                If ((Date.Now - t0).TotalSeconds > 1 And mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I27_SensorePresPz) = False) Then
                    ' Passa alla sottofase 3
                    _sottofase = 3
                End If

            Case 3  ' Chiusura valvole di scarico, spegnimento lampade e aggiornamento contatori
                ' Spegne la lampada buono
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U10_LampBuono) = False
                ' Incrementa i contatori
                If Not (_cicloMaster) Then
                    If Not (_ripassoScarti) Then
                        _lotto.NumeroBuoniNonRipassati += 1
                        _numeroBuoniNonRipassati += 1
                    Else
                        _lotto.NumeroBuoniRipassati += 1
                        _lotto.NumeroScartiNonRipassati -= 1
                        _numeroBuoniRipassati += 1
                        If (_numeroScartiNonRipassati > 0) Then
                            _numeroScartiNonRipassati -= 1
                        End If
                    End If
                    e = e Or _lotto.SalvaContatori
                    frmCollaudo.VisualizzaContatori()
                    ' Visualizza i risultati
                    frmCollaudo.VisualizzaRisultati()
                End If
                ' Resetta i flag di ciclo master e ciclo master obbligatorio
                _cicloMaster = False
                _cicloMasterObbligatorio = False
                ' Reset automatico flag di ripasso scarti
                _ripassoScarti = _ripassoScarti And Not (mGestoreCollaudo.Lotto.NumeroScarti = 0)
                ' Passa alla fase successiva
                _fase = eFase.ResetFineCiclo
                _sottofase = 0
        End Select

        ' Gestione errori di runtime
        If (e) Then
            MsgBox("Errore di runtime nella fase ScaricoPezzoBuono", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
    End Sub



    Private Sub FaseScaricoPezzoScarto()
        Dim e As Boolean
        Static t0 As Date

        ' Resetta il flag d'errore
        e = False
        ' Gestisce le sottofasi
        Select Case _sottofase
            Case 0  ' Apro la pinza
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = False
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = True
                ' Passo alla sottofase 1
                _sottofase = 1

            Case 1  ' Attesa ripristino scarto
                ' Se l'utente preme il pulsante scarto
                If (mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I11_BtnScarto)) Then
                    ' Disattiva il cicalino
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U12_Cicalino) = False
                    ' Tolgo pressione alla pinza e sollevo la campana
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = False
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = False
                    mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = True
                    ' Memorizza il tempo
                    t0 = Date.Now
                    ' Passa alla sottofase 2
                    _sottofase = 2
                End If

            Case 2  ' Attesa rimozione pezzo
                ' Se è trascorso 1s e il pezzo non è più presente nella campana
                If (mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I27_SensorePresPz) = False And (Date.Now - t0).TotalSeconds > 1) Then
                    ' Passa alla sottofase 3
                    _sottofase = 3
                End If

            Case 3 ' Attesa scarico pezzo
                ' Se il pezzo viene correttamente inserito nel box degli scarti (o ignoro il passaggio in caso di pezzo master)
                If mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I17_SensorePresScarto) = True Or _cicloMaster Then
                    ' Passa alla fase successiva
                    _sottofase = 4
                End If

            Case 4  ' Chiusura valvole di scarico, spegnimento lampade e aggiornamento contatori
                ' Spegne la lampada scarto
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U11_LampScarto) = False
                ' Incrementa i contatori
                If Not (_cicloMaster) Then
                    If Not (_ripassoScarti) Then
                        _lotto.NumeroScartiNonRipassati += 1
                        _numeroScartiNonRipassati += 1
                    Else
                        _lotto.NumeroScartiRipassati += 1
                        _lotto.NumeroScartiNonRipassati -= 1
                        _numeroScartiRipassati += 1
                        _numeroScartiNonRipassati -= 1
                    End If
                    e = e Or _lotto.SalvaContatori
                    frmCollaudo.VisualizzaContatori()
                    ' Visualizza i risultati
                    frmCollaudo.VisualizzaRisultati()
                End If
                ' Passa alla fase successiva
                _fase = eFase.ResetFineCiclo
                _sottofase = 0
        End Select
        ' Disattiva il cicalino
        If ((Date.Now - _t0Cicalino).TotalSeconds > _durataSuonoCicalino_s) Then
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U12_Cicalino) = False
        End If

        ' Gestione errori di runtime
        If (e) Then
            MsgBox("Errore di runtime nella fase ScaricoPezzoScarto", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
    End Sub



    Private Sub FaseResetFineCiclo()

        ' Reset del regolatore ossigeno e azoto
        If mGlobale.Mass_Flow_Controller_O2.SetPortata(0) Then
            MsgBox("Errore nella lettura del Mass Flow Controller O2.", CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        If mGlobale.Mass_Flow_Controller_N2.SetPortata(0) Then
            MsgBox("Errore nella lettura del Mass Flow Controller N2.", CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Reset di tutte le uscite della scheda di I/O
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U04_OnRaffreddamento) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U05) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U07_LedVerdiAvvio) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U10_LampBuono) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U11_LampScarto) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U12_Cicalino) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U16_RelèConnCellaLD) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U17_RelèRiscaldatoreLD) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U20_RelèConnDirettaLD) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U21_RelèVoltmetroLD) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U22_RelèConnCellaNTK) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U23_RelèConnCellaPinIpNTK) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U24_RelèRiscaldatoreNTK) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U25_RelèConnDirettaNTK) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U26_RelèAmperometroPinIpNTK) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento) = False
        ' Imposta il tasto reset su non premuto se è stata premuta l'emergenza
        If (mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I06_Emergenza)) Then
            _resetPremuto = False
        End If
        ' Passa alla fase AttesaAvvioCiclo
        _fase = eFase.AttesaPressioneAriaOK
        _sottofase = 0
    End Sub
End Module
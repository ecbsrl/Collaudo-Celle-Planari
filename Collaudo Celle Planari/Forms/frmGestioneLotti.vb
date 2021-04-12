Option Explicit On
Option Strict On

Public Class frmGestioneLotti
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _lotto As New cLotto
    Private _lottoModificato As Boolean
    Private _nuovoLotto As Boolean
    Private _pagina As Integer
    Private _stampaElencoLotti As Boolean
    Private _stampaLotto As Boolean



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Sub btnAnnullaModifiche_Click(sender As System.Object, e As System.EventArgs) Handles btnAnnullaModifiche.Click
        ' Se l'utente conferma l'operazione
        If (MsgBox("Annullare tutte le modifiche apportate al lotto?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Domanda") = MsgBoxResult.Yes) Then
            ' Resetta il flag di lotto modificato
            _lottoModificato = False
            ' Visualizza il lotto
            VisualizzaLotto()
        End If
    End Sub



    Private Sub btnAttivaLotto_Click(sender As System.Object, e As System.EventArgs) Handles btnAttivaLotto.Click
        Dim nomeLottoPrecedente As String
        Dim scelta As New MsgBoxResult

        ' Se il lotto è stato modificato
        If (_lottoModificato) Then
            ' Chiede all'utente se salvare le modifiche
            scelta = MsgBox("Il lotto è stato modificato: salvare le modifiche?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, MsgBoxStyle), "Domanda")
            ' Se l'utente vuole salvare le modifiche
            If (scelta = MsgBoxResult.Yes) Then
                ' Simula la pressione del tasto salva modifiche
                btnSalvaModifiche.PerformClick()
            ElseIf (scelta = MsgBoxResult.No) Then  ' Altrimenti, se l'utente non vuole salvare le modifiche
                ' Resetta il flag di lotto modificato
                _lottoModificato = False
            End If
        End If
        ' Se il lotto non è stato modificato
        If Not (_lottoModificato) Then
            ' Memorizza il nome del lotto precedente
            nomeLottoPrecedente = mGestoreCollaudo.Lotto.Nome
            ' Se nel caricamento del nuovo lotto non si verificano errori
            If Not (mGestoreCollaudo.CaricaLotto(_lotto.Nome)) Then
                ' Visualizza un messaggio d'informazione
                MsgBox(String.Format("Lotto ""{0}"" attivato con successo.", _lotto.Nome), _
                       CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                       "Informazione")
            ElseIf (nomeLottoPrecedente <> "") Then     ' Altrimenti, se il nome del lotto precedente non è vuoto
                ' Ricarica il lotto precedente
                mGestoreCollaudo.CaricaLotto(nomeLottoPrecedente)
            End If
            ' Visualizza il lotto attivo
            labLottoAttivo.Text = mGestoreCollaudo.Lotto.Nome
            End If
    End Sub



    Private Sub btnCancellaLotto_Click(sender As System.Object, e As System.EventArgs) Handles btnCancellaLotto.Click
        ' Se il livello della password è maggiore di 0
        If (mGestorePassword.Login(0) > 0) Then
            ' Se è selezionato un lotto
            If (lbLotti.SelectedItem IsNot Nothing) Then
                ' Carica i contatori del lotto
                _lotto.Nome = lbLotti.SelectedItem.ToString
                If (_lotto.CaricaContatori) Then
                    MsgBox("Errore nel caricamento dei contatori del lotto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                ElseIf (_lotto.NumeroPezzi = 0) Then     ' Se non sono stati prodotti pezzi con il lotto
                    ' Se l'utente conferma l'operazione
                    If (MsgBox(String.Format("Cancellare definitivamente il lotto ""{0}""?", lbLotti.SelectedItem.ToString), CType(vbQuestion + MsgBoxStyle.YesNo, MsgBoxStyle), "Domanda") = MsgBoxResult.Yes) Then
                        ' Cancella il lotto
                        If (_lotto.Cancella()) Then
                            MsgBox(String.Format("Errore nella cancellazione del lotto ""{0}"".", lbLotti.SelectedItem.ToString), CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                        End If
                        ' Ricarica la lista dei lotti
                        CaricaListaLotti()
                    End If
                Else    ' Altrimenti, se sono stati prodotti pezzi con il lotto
                    MsgBox("Impossibile cancellare il lotto perché è già stato utilizzato per produrre.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
            End If
        End If
    End Sub



    Private Sub btnCreaLotto_Click(sender As System.Object, e As System.EventArgs) Handles btnCreaLotto.Click
        ' Configura e visualizza la finestra d'inserimento stringa
        frmInserimentoStringa.Descrizione = "Inserire il nome del nuovo lotto"
        frmInserimentoStringa.LunghezzaMassima = 20
        frmInserimentoStringa.Valore = ""
        frmInserimentoStringa.ShowDialog()
        ' Se l'utente ha confermato l'operazione
        If (frmInserimentoStringa.ValoreConfermato) Then
            ' Converte il nome del lotto in maiuscolo
            frmInserimentoStringa.Valore = frmInserimentoStringa.Valore.ToUpper()
            ' Se il lotto non esiste ancora
            If Not (cLotto.Esiste(frmInserimentoStringa.Valore)) Then
                ' Inizializza il lotto
                _lotto.Inizializza()
                _lotto.Nome = frmInserimentoStringa.Valore
                _lotto.DataCreazione = Format(Date.Now, "dd/MM/yyyy")
                ' Salva il lotto
                If (_lotto.Salva()) Then
                    MsgBox(String.Format("Errore nel salvataggio del lotto ""{0}"".", _lotto.Nome), CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
                ' Ricarica la lista dei lotti
                CaricaListaLotti()
                ' Seleziona il lotto corrente
                lbLotti.SelectedItem = _lotto.Nome
                ' Disabilita i controlli di gestione dei lotti
                gbGestioneLotti.Enabled = False
                ' Visualizza i controlli di modifica dei parametri del lotto
                gbParametriLotto.Visible = True
                ' Setta il flag di nuovo lotto
                _nuovoLotto = True
                ' Visualizza il lotto
                VisualizzaLotto()
            Else    ' Altrimenti, se il lotto esiste già
                ' Visualizza un messaggio d'errore
                MsgBox(String.Format("Il lotto ""{0}"" esiste già.", frmInserimentoStringa.Valore), CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
        End If
    End Sub



    Private Sub btnModificaRicetta_Click(sender As System.Object, e As System.EventArgs) Handles btnModificaLotto.Click
        ' Se l'utente effettua il login
        If (mGestorePassword.Login(0) > 0) Then
            ' Visualizza il lotto
            VisualizzaLotto()
        End If
    End Sub



    Private Sub btnNascondiLotto_Click(sender As System.Object, e As System.EventArgs) Handles btnNascondiLotto.Click
        Dim scelta As New MsgBoxResult

        ' Se il lotto è stato modificato
        If (_lottoModificato) Then
            ' Chiede all'utente se salvare le modifiche
            scelta = MsgBox("Il lotto è stato modificato: salvare le modifiche?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, MsgBoxStyle), "Domanda")
            ' Se l'utente vuole salvare le modifiche
            If (scelta = MsgBoxResult.Yes) Then
                ' Simula la pressione del tasto salva modifiche
                btnSalvaModifiche.PerformClick()
            ElseIf (scelta = MsgBoxResult.No) Then  ' Altrimenti, se l'utente non vuole salvare le modifiche
                ' Resetta il flag di lotto modificato
                _lottoModificato = False
            End If
        End If
        ' Se il lotto non è stato modificato
        If Not (_lottoModificato) Then
            ' Abilita i controlli di gestione dei lotti
            gbGestioneLotti.Enabled = True
            ' Nasconde i controlli di modifica dei parametri del lotto
            gbParametriLotto.Visible = False
        End If
    End Sub



    Private Sub btnRicercaLotto_Click(sender As System.Object, e As System.EventArgs) Handles btnRicercaLotto.Click
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



    Private Sub btnSalvaModifiche_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvaModifiche.Click
        Dim errore As Boolean
        Dim nomeLotto As String
        Dim parametriOk As Boolean

        ' Verifica i parametri inseriti
        parametriOk = True
        If (cbRicetta.SelectedItem Is Nothing) Then
            MsgBox("La ricetta selezionata non è valida.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            parametriOk = False
        End If
        If (parametriOk AndAlso cRicetta.Esiste(cbRicetta.SelectedItem.ToString) = False) Then
            MsgBox("La ricetta selezionata non è esiste.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            parametriOk = False
        End If
        ' Se i parametri sono ok
        If (parametriOk) Then
            ' Aggiorna i parametri del lotto
            _lotto.NumeroOrdine = tbNumeroOrdine.Text
            _lotto.NomeRicetta = cbRicetta.SelectedItem.ToString
            _lotto.Note = tbNote.Text
            ' Carica la ricetta
            errore = False
            If (_lotto.Ricetta.Carica(_lotto.NomeRicetta)) Then
                MsgBox("Errore nel caricamento della ricetta.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                errore = True
            End If
            ' Carica la ricetta master
            If (_lotto.RicettaMaster.Carica(CStr(_lotto.Ricetta.NomeRicettaMaster.Valore))) Then
                MsgBox("Errore nel caricamento della ricetta master.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                errore = True
            End If
            ' Memorizza il nome iniziale del lotto
            nomeLotto = _lotto.Nome
            ' Aggiorna il nome del lotto
            _lotto.Nome = _lotto.Nome & "_" & _lotto.NomeRicetta & "_" & _lotto.Ricetta.IndiceRevisione.ValoreStringa
            ' Salva il lotto
            If (_lotto.Salva) Then
                MsgBox("Errore nel salvataggio del lotto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                errore = True
            End If
            ' Se non si sono verificati errori
            If Not (errore) Then
                ' Cancella il lotto
                _lotto.Cancella(nomeLotto)
                ' Ricarica la lista dei lotti
                CaricaListaLotti()
                ' Resetta il flag di lotto modificato
                _lottoModificato = False
                ' Resetta il flag di nuovo lotto
                _nuovoLotto = False
                ' Visualizza il lotto
                VisualizzaLotto()
            End If
        End If
    End Sub



    Private Sub btnUscita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUscita.Click
        ' Chiude la finestra
        Me.Close()
    End Sub



    Private Sub btnVisualizzaLotto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizzaLotto.Click
        ' Se è selezionato un lotto
        If (lbLotti.SelectedItem IsNot Nothing) Then
            ' Carica il lotto selezionato
            If (_lotto.Carica(lbLotti.SelectedItem.ToString)) Then
                MsgBox(String.Format("Errore nel caricamento del lotto ""{0}"".", lbLotti.SelectedItem), CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Disabilita i controlli di gestione dei lotti
            gbGestioneLotti.Enabled = False
            ' Visualizza i controlli di modifica dei parametri del lotto
            gbParametriLotto.Visible = True
            ' Resetta il flag di lotto modificato
            _lottoModificato = False
            ' Visualizza il lotto
            VisualizzaLotto()
        End If
    End Sub



    Private Sub CaricaListaLotti()
        Dim i As Integer
        Dim nomeLotto() As String = {}

        ' Carica la lista dei lotti
        cLotto.LeggiLista(nomeLotto)
        ' Visualizza la lista dei lotti
        lbLotti.Items.Clear()
        For i = 0 To nomeLotto.Length - 1
            lbLotti.Items.Add(nomeLotto(i))
        Next
    End Sub



    Private Sub CaricaListaRicette()
        Dim i As Integer
        Dim nomeRicetta() As String = {}

        ' Carica la lista dei Ricette
        cRicetta.LeggiLista(nomeRicetta)
        ' Visualizza la lista dei Ricette
        cbRicetta.Items.Clear()
        For i = 0 To nomeRicetta.Length - 1
            cbRicetta.Items.Add(nomeRicetta(i))
        Next
    End Sub



    Private Sub cbRicetta_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cbRicetta.SelectionChangeCommitted
        ' Aggiorna il flag di lotto modificato
        _lottoModificato = _lottoModificato Or (cbRicetta.SelectedText <> _lotto.NomeRicetta)
    End Sub



    Private Sub frmGestioneLotti_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Effettua il logout
        mGestorePassword.Logout()
    End Sub



    Private Sub frmGestioneLotti_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Carica la lista di lotti
        CaricaListaLotti()
        ' Carica la lista delle ricette
        CaricaListaRicette()
        ' Visualizza il lotto attivo
        labLottoAttivo.Text = mGestoreCollaudo.Lotto.Nome
        ' Abilita i controlli di gestione dei lotti
        gbGestioneLotti.Enabled = True
        ' Nasconde i controlli di modifica dei parametri del lotto
        gbParametriLotto.Visible = False
    End Sub



    Private Sub lbLotti_DoubleClick(sender As Object, e As System.EventArgs) Handles lbLotti.DoubleClick
        ' Simula la pressione del pulsante visualizza lotto
        btnVisualizzaLotto.PerformClick()
    End Sub



    Private Sub tbNote_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNote.Validating
        ' Aggiorna il flag di lotto modificato
        _lottoModificato = _lottoModificato Or (tbNote.Text <> _lotto.Note)
    End Sub



    Private Sub tbNumeroOrdine_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNumeroOrdine.Validating
        ' Aggiorna il flag di lotto modificato
        _lottoModificato = _lottoModificato Or (tbNumeroOrdine.Text <> _lotto.NumeroOrdine)
    End Sub



    Private Sub VisualizzaLotto()
        Dim _lottoModificabile As Boolean

        ' Visualizza i parametri del lotto
        gbParametriLotto.Text = "Parametri lotto " & _lotto.Nome
        labDataOraCreazione.Text = _lotto.DataCreazione
        tbNumeroOrdine.Text = _lotto.NumeroOrdine
        cbRicetta.SelectedItem = _lotto.NomeRicetta
        tbNote.Text = _lotto.Note
        ' Abilita o disabilita la modifica dei valori
        _lottoModificabile = _nuovoLotto    '(_lotto.NumeroPezzi = 0)
        tbNumeroOrdine.Enabled = _lottoModificabile
        cbRicetta.Enabled = _lottoModificabile
        tbNote.Enabled = _lottoModificabile
        ' Visualizza o nasconde i pulsanti
        btnAttivaLotto.Visible = Not (_nuovoLotto)
        btnNascondiLotto.Visible = Not (_nuovoLotto)
        btnModificaLotto.Visible = _lottoModificabile And Not _nuovoLotto And (mGestorePassword.Livello = 0)
        btnAnnullaModifiche.Visible = _lottoModificabile And Not _nuovoLotto And (mGestorePassword.Livello > 0)
        btnSalvaModifiche.Visible = _lottoModificabile
    End Sub
End Class
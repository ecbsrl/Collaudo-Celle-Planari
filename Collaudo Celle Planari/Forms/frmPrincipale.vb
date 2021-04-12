Option Explicit On
Option Strict On

Imports System.Runtime.InteropServices

Public Class frmPrincipale
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
#Const SVILUPPO_OFFLINE = True


    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Dim arrestoPC As Boolean



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Visualizza la finestra di about
        MsgBox(mGlobale.DescrizioneMacchina & vbCrLf & vbCrLf & "Versione Software - " & mGlobale.VersioneSoftware, CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
    End Sub



    Private Sub AggiornamentoDataTaraturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AggiornamentoDataTaraturaToolStripMenuItem.Click
        Dim data As Date

        ' Se il livello della password è superiore a 2
        If (mGestorePassword.Login(2) >= 2) Then
            ' Configura e visualizza la finestra d'inserimento stringa
            frmInserimentoStringa.Descrizione = "Inserire la nuova data di taratura"
            frmInserimentoStringa.LunghezzaMassima = 10
            frmInserimentoStringa.Valore = Format(Date.Now, "dd/MM/yyyy")
            frmInserimentoStringa.ShowDialog()
            ' Se l'utente ha confermato l'operazione
            If (frmInserimentoStringa.ValoreConfermato) Then
                ' Aggiorna la data di taratura
                If (Date.TryParse(frmInserimentoStringa.Valore, data)) Then
                    mTaratura.DataTaratura = CDate(data)
                    If Not (mTaratura.SalvaDataTaratura()) Then
                        MsgBox("Data di taratura aggiornata con successo", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
                    Else
                        MsgBox("Errore nel salvataggio della data di taratura", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                    End If
                Else
                    MsgBox("Il valore inserito non è interpretabile come data", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
            End If
        End If
    End Sub



    Private Sub btnArchivio_Click(sender As Object, e As EventArgs) Handles btnArchivio.Click
        ' Avvio la finestra di explorer
        Process.Start("explorer.exe", "C:\Collaudo Celle Planari\Archivio\Report")
    End Sub



    Private Sub btnArrestoPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArrestoPC.Click
        ' Se l'utente conferma l'operazione
        If (MsgBox("Arrestare il PC?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Domanda") = MsgBoxResult.Yes) Then
            ' Setta il flag di arresto PC
            arrestoPC = True
            ' Arresta il PC
            Shell("shutdown -s -t 0")
        End If
    End Sub



    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        ' Visualizza la finestra di backup
        frmBackup.ShowDialog()
    End Sub



    Private Sub btnCollaudo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollaudo.Click
        ' Se c'è un lotto attivo
        If (mGestoreCollaudo.Lotto.Nome <> "") Then
            ' Disabilita il timer della barra di stato
            tmrBarraStato.Enabled = False
            ' Visualizza la finestra di collaudo
            frmCollaudo.ShowDialog()
            ' Abilita il timer della barra di stato
            tmrBarraStato.Enabled = True
        Else    ' Altrimenti, se non c'è un lotto attivo
            ' Visualizza un messaggio d'errore
            MsgBox("Nessun lotto selezionato, impossibile passare in modalità di collaudo.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
    End Sub



    Private Sub btnDesktop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesktop.Click
        ' Riduce l'applicazione ad icona
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub btnLotti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLotti.Click
        ' Disabilita il timer della barra di stato
        tmrBarraStato.Enabled = False
        ' Visualizza la finestra di gestione dei lotti
        frmGestioneLotti.ShowDialog()
        ' Abilita il timer della barra di stato
        tmrBarraStato.Enabled = True
    End Sub



    Private Sub btnRicette_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRicette.Click
        ' Disabilita il timer della barra di stato
        tmrBarraStato.Enabled = False
        ' Visualizza la finestra di gestione delle ricette
        frmGestioneRicette.ShowDialog()
        ' Abilita il timer della barra di stato
        tmrBarraStato.Enabled = True
    End Sub



    Private Sub btnRisultati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRisultati.Click
        ' Visualizza la finestra risultati
        frmRisultati.ShowDialog()
    End Sub



    Private Sub btnUscita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUscita.Click
        ' Chiude la finestra
        Me.Close()
    End Sub



    Private Sub CicliTotaliMacchinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CicliTotaliMacchinaToolStripMenuItem.Click
        ' Visualizza il numero totale di cicli compiuti dalla macchina
        MsgBox("Totale cicli macchina: " & mImpostazioniGenerali.CicliTotaliStazione.ToString, CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
    End Sub



    Private Sub DataTaraturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataTaraturaToolStripMenuItem.Click
        ' Visualizza la data dell'ultima taratura
        MsgBox("Data di taratura: " & Format(mTaratura.DataTaratura, "dd/MM/yyyy"), CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
    End Sub



    Private Sub frmPrincipale_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ' Se l'utente conferma
        If (arrestoPC OrElse MsgBox("Chiudere il programma?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Domanda") = MsgBoxResult.Yes) Then
            ' Disabilita il timer della barra di stato
            tmrBarraStato.Enabled = False
            ' Arresta il gestore di collaudo
            If (mGestoreCollaudo.Arresta()) Then
                MsgBox("Errore nell'arresto del gestore di collaudo.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If

#If SVILUPPO_OFFLINE = False Then
            ' Disconnete l'I/O Remoto
            If mGlobale.IOremoto.Disconnetti() Then
                MsgBox("Errore nella disconnessione dall'I/O Remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Disconnette il multimetro
            If mGlobale.Multimetro.Disconnetti() Then
                MsgBox("Errore nella disconnessione dal multimetro.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Disconnette il trasduttore di portata di Ossigeno
            If mGlobale.Mass_Flow_Controller_O2.Disconnetti() Then
                MsgBox("Errore nella disconnessione dal trasduttore di portata O2.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Disconnette il trasfuttore di portata di Azoto
            If mGlobale.Mass_Flow_Controller_N2.Disconnetti() Then
                MsgBox("Errore nella disconnessione dal trasduttore di portata N2.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Disconnette il lambda meter
            If mGlobale.Lambda.Disconnetti() Then
                MsgBox("Errore nella disconnessione dal misuratore Lambda.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
#End If

        Else    ' Altrimenti, se l'utente non conferma
            ' Cancella la richiesta di chiusura
            e.Cancel = True
        End If
    End Sub



    Private Sub frmPrincipale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' Se è stato premuto il tasto F1
        If (e.KeyCode = Keys.F1) Then
            ' Simula la pressione del tasto gestione ricette
            btnRicette.PerformClick()
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F2) Then   ' Altrimenti, se è stato premuto il tasto F2
            ' Simula la pressione del tasto gestione lotti
            btnLotti.PerformClick()
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F3) Then   ' Altrimenti, se è stato premuto il tasto F3
            ' Simula la pressione del tasto collaudo
            btnCollaudo.PerformClick()
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F4) Then   ' Altrimenti, se è stato premuto il tasto F4
            ' Simula la pressione del tasto risultati
            btnRisultati.PerformClick()
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F5) Then   ' Altrimenti, se è stato premuto il tasto F5
            ' Simula la pressione del tasto backup
            btnBackup.PerformClick()
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F6) Then   ' Altrimenti, se è stato premuto il tasto F6
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F7) Then   ' Altrimenti, se è stato premuto il tasto F7
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F8) Then   ' Altrimenti, se è stato premuto il tasto F8
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F9) Then   ' Altrimenti, se è stato premuto il tasto F9
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F10) Then   ' Altrimenti, se è stato premuto il tasto F10
            ' Simula la pressione del tasto Desktop
            btnDesktop.PerformClick()
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F11) Then   ' Altrimenti, se è stato premuto il tasto F11
            ' Simula la pressione del tasto Uscita
            btnUscita.PerformClick()
            e.Handled = True
        ElseIf (e.KeyCode = Keys.F12) Then   ' Altrimenti, se è stato premuto il tasto F12
            ' Simula la pressione del tasto arresto PC
            btnArrestoPC.PerformClick()
            e.Handled = True
        End If
    End Sub



    Private Sub frmPrincipale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Visualizza la versione software
        Me.Text = Me.Text & " - " & mGlobale.VersioneSoftware
        ' Massimizza la finestra
        Me.WindowState = FormWindowState.Maximized
        ' Carica le impostazioni generali
        If (mImpostazioniGenerali.Carica(mGlobale.NomeFileImpostazioniGenerali)) Then
            MsgBox("Errore nel caricamento delle impostazioni generali.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Carica le impostazioni avanzate
        If (mImpostazioniAvanzate.Carica(mGlobale.NomeFileImpostazioniAvanzate)) Then
            MsgBox("Errore nel caricamento delle impostazioni avanzate.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Carica il file delle password
        If (mGestorePassword.CaricaFile(mGlobale.NomeFilePassword)) Then
            MsgBox("Errore nel caricamento da file delle password.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Carica la data dell'ultima taratura
        If (mTaratura.CaricaDataTaratura) Then
            MsgBox("Errore nel caricamento della data di taratura.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        ElseIf ((Date.Now - mTaratura.DataTaratura).TotalDays > mTaratura.IntervalloTaratura) Then
            MsgBox("ATTENZIONE: intervallo di taratura scaduto.", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If

#If SVILUPPO_OFFLINE = False Then
        ' Connette l'I/O Remoto
        If mGlobale.IOremoto.Connetti Then
            MsgBox("Errore nella connessione all'I/O Remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Connette il multimetro
        If mGlobale.Multimetro.Connetti(Indirizzo_IP_Multimetro, Numero_Porta_Multimetro) Then
            MsgBox("Errore nella connessione al Multimetro.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Connette il trasduttore di portata di Ossigeno
        If mGlobale.Mass_Flow_Controller_O2.Connetti(mGlobale.Porta_Trasduttore_Portata_O2, mGlobale.Indirizzo_Trasduttore_Portata, mGlobale.ID_Trasduttore_Portata_O2) Then
            MsgBox("Errore nella connessione al trasduttore di portata di Ossigeno.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Connette il trasduttore di portata di Azoto
        If mGlobale.Mass_Flow_Controller_N2.Connetti(mGlobale.Porta_Trasduttore_Portata_N2, mGlobale.Indirizzo_Trasduttore_Portata, mGlobale.ID_Trasduttore_Portata_N2) Then
            MsgBox("Errore nella connessione al trasduttore di portata di Azoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Connette il Lambda Meter
        If mGlobale.Lambda.Connetti(Porta_Lambda, Baudrate_Lambda) Then
            MsgBox("Errore nella connessione al misuratore Lambda.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
#End If
        ' Avvia in background la copia di backup
        BackgroundBackup.RunWorkerAsync()
        ' Avvia il gestore di collaudo
        If (mGestoreCollaudo.Avvia()) Then
            MsgBox("Errore nell'avvio del gestore di collaudo.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Inizializza la barra di stato
        mBarraStato.Inizializza(ssBarraStato)
        ' Abilita il timer della barra di stato
        tmrBarraStato.Interval = 500
        tmrBarraStato.Enabled = True
    End Sub



    Private Sub ImpostazioniAvanzateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImpostazioniAvanzateToolStripMenuItem.Click
        ' Disabilita il timer della barra di stato
        tmrBarraStato.Enabled = False
        ' Visualizza la finestra delle impostazioni avanzate
        frmImpostazioniAvanzate.ShowDialog()
        ' Abilita il timer della barra di stato
        tmrBarraStato.Enabled = True
    End Sub



    Private Sub ImpostazioniGeneraliToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImpostazioniGeneraliToolStripMenuItem.Click
        ' Disabilita il timer della barra di stato
        tmrBarraStato.Enabled = False
        ' Visualizza la finestra delle impostazioni generali
        frmImpostazioniGenerali.ShowDialog()
        ' Abilita il timer della barra di stato
        tmrBarraStato.Enabled = True
    End Sub



    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        ' Effettua il login
        If (mGestorePassword.Livello = 0) Then
            mGestorePassword.Login(0)
        End If
    End Sub



    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        ' Effettua il logout
        If (mGestorePassword.Livello > 0) Then
            mGestorePassword.Logout()
        End If
    End Sub



    Private Sub ModificaPassword1LivelloToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificaPassword1LivelloToolStripMenuItem.Click
        ' Se il livello attuale della password è 1
        If (mGestorePassword.Livello = 1) Then
            ' Configura e visualizza la finestra d'inserimento password
            frmInserimentoPassword.Descrizione = "Inserire la nuova password di 1° livello"
            frmInserimentoPassword.Password = ""
            frmInserimentoPassword.ShowDialog()
            ' Se l'utente conferma l'operazione
            If (frmInserimentoPassword.PasswordConfermata) Then
                ' Imposta la nuova password
                mGestorePassword.ImpostaPassword(frmInserimentoPassword.Password)
                ' Salva la nuova password
                If Not (mGestorePassword.SalvaFile(mGlobale.NomeFilePassword)) Then
                    MsgBox("Password modificata con successo.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
                Else
                    MsgBox("Errore nel salvataggio delle password.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
            End If
        End If
    End Sub



    Private Sub ModificaPassword2LivelloToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificaPassword2LivelloToolStripMenuItem.Click
        ' Se il livello attuale della password è 2
        If (mGestorePassword.Livello = 2) Then
            ' Configura e visualizza la finestra d'inserimento password
            frmInserimentoPassword.Descrizione = "Inserire la nuova password di 2° livello"
            frmInserimentoPassword.Password = ""
            frmInserimentoPassword.ShowDialog()
            ' Se l'utente conferma l'operazione
            If (frmInserimentoPassword.PasswordConfermata) Then
                ' Imposta la nuova password
                mGestorePassword.ImpostaPassword(frmInserimentoPassword.Password)
                ' Salva la nuova password
                If Not (mGestorePassword.SalvaFile(mGlobale.NomeFilePassword)) Then
                    MsgBox("Password modificata con successo.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
                Else
                    MsgBox("Errore nel salvataggio delle password.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
            End If
        End If
    End Sub



    Private Sub MonitorHardwareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonitorHardwareToolStripMenuItem.Click
        ' Disabilita il timer della barra di stato
        tmrBarraStato.Enabled = False
        ' Visualizza la finestra di diagnostica
        frmDiagnostica.ShowDialog()
        ' Abilita il timer della barra di stato
        tmrBarraStato.Enabled = True
    End Sub



    Private Sub TaraturaMisuraPortataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TaraturaMisuraO2ToolStripMenuItem.Click
        ' Se il livello della password è maggiore o uguale a 2
        If (mGestorePassword.Login(2) >= 2) Then
            ' Attivo il relè per la misura della tensione di alimentazione
            'mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.DiscesaCampana) = True
            If mGlobale.IOremoto.Scrivi Then
                MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Visualizza la finestra di taratura 
            frmTaratura._TrasduttoreInTaratura = 3
            frmTaratura.ShowDialog()
            ' Disattivo il relè per la misura della tensione di alimentazione
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = False
            If mGlobale.IOremoto.Scrivi Then
                MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
        End If
    End Sub



    Private Sub TaraturaMisuraN2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaraturaMisuraN2ToolStripMenuItem.Click
        ' Se il livello della password è maggiore o uguale a 2
        If (mGestorePassword.Login(2) >= 2) Then
            ' Attivo il relè per la misura della tensione di alimentazione
            'mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.DiscesaCampana) = True
            If mGlobale.IOremoto.Scrivi Then
                MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Visualizza la finestra di taratura 
            frmTaratura._TrasduttoreInTaratura = 4
            frmTaratura.ShowDialog()
            ' Disattivo il relè per la misura della tensione di alimentazione
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = False
            If mGlobale.IOremoto.Scrivi Then
                MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
        End If
    End Sub



    Private Sub TaraturaMisuraPosizioneToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TaraturaMisuraIsolamentoToolStripMenuItem.Click
        ' Se il livello della password è maggiore o uguale a 2
        If (mGestorePassword.Login(2) >= 2) Then
            ' Attivo il relè per la misura della tensione di alimentazione
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento) = True
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = True
            If mGlobale.IOremoto.Scrivi Then
                MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Visualizza la finestra di taratura 
            frmTaratura._TrasduttoreInTaratura = 5
            frmTaratura.ShowDialog()
            ' Attivo il relè per la misura della tensione di alimentazione
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento) = False
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = False
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = False
            If mGlobale.IOremoto.Scrivi Then
                MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
        End If
    End Sub



    Private Sub TaraturaMisuraPressioneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaraturaMisuraRheaterToolStripMenuItem.Click
        ' Se il livello della password è maggiore o uguale a 2
        If (mGestorePassword.Login(2) >= 2) Then
            ' Attivo il relè per la misura della tensione di alimentazione
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore) = True
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = True
            If mGlobale.IOremoto.Scrivi Then
                MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Visualizza la finestra di taratura 
            frmTaratura._TrasduttoreInTaratura = 2
            frmTaratura.ShowDialog()
            ' Attivo il relè per la misura della tensione di alimentazione
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore) = False
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = False
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = False
            If mGlobale.IOremoto.Scrivi Then
                MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
        End If
    End Sub



    Private Sub TaraturaMisuraVuotoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TaraturaMisuraValToolStripMenuItem.Click
        ' Se il livello della password è maggiore o uguale a 2
        If (mGestorePassword.Login(2) >= 2) Then
            ' Visualizza la finestra di taratura  
            frmTaratura._TrasduttoreInTaratura = 1
            frmTaratura.ShowDialog()
        End If
    End Sub



    Private Sub VerificaTaraturaCorrenteRiscaldatoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificaTaraturaCorrenteRiscaldatoreToolStripMenuItem.Click
        ' Se il livello della password è maggiore o uguale a 2
        If (mGestorePassword.Login(2) >= 2) Then
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = True
            If mGlobale.IOremoto.Scrivi Then
                MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Visualizza la finestra di taratura  
            frmTaratura._TrasduttoreInTaratura = 6
            frmTaratura.ShowDialog()
            mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = False
            If mGlobale.IOremoto.Scrivi Then
                MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
        End If
    End Sub



    Private Sub VerificaTaraturaO2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificaTaraturaO2ToolStripMenuItem.Click
        ' Se il livello della password è maggiore o uguale a 2
        If (mGestorePassword.Login(2) >= 2) Then
            ' Visualizza la finestra di taratura  
            frmTaratura._TrasduttoreInTaratura = 7
            frmTaratura.ShowDialog()
        End If
    End Sub



    Private Sub tmrBarraStato_Tick(sender As System.Object, e As System.EventArgs) Handles tmrBarraStato.Tick
        ' Abilita/disabilita le voci dei menu
        LoginToolStripMenuItem.Enabled = (mGestorePassword.Livello = 0)
        LogoutToolStripMenuItem.Enabled = (mGestorePassword.Livello > 0)
        ModificaPassword1LivelloToolStripMenuItem.Enabled = (mGestorePassword.Livello = 1)
        ModificaPassword2LivelloToolStripMenuItem.Enabled = (mGestorePassword.Livello = 2)
        ' Aggiorna la barra di stato
        mBarraStato.Aggiorna(ssBarraStato)
    End Sub



    Private Sub BackgroundBackup_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundBackup.DoWork
        ' Verifica se è stata creata una cartella di backup per il software
        If (mImpostazioniGenerali.CartellaBackup <> "") Then
            ' Copio l'intero contenuto della cartella del software nella cartella di backup
            Try
                My.Computer.FileSystem.CopyDirectory(mGlobale.BasePath, mImpostazioniGenerali.CartellaBackup, True)
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
    End Sub
End Class
Option Explicit On
Option Strict On

Public Class frmImpostazioniGenerali
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _valoriModificati As Boolean



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
        ' Abilita i controlli
        chkAbilitazioneCicliMaster.Enabled = True
        chkAbilitazioneInterruzioneCiclo.Enabled = True
        labCartellaBackup.Enabled = True
        tbCartellaBackup.Enabled = True
        labCartellaBackupLotti.Enabled = True
        tbCartellaBackupLotti.Enabled = True
        labCartellaBackupRicette.Enabled = True
        tbCartellaBackupRicette.Enabled = True
        labCartellaBackupTarature.Enabled = True
        tbCartellaBackupTarature.Enabled = True
        labDescFlussoAriaTaratura.Enabled = True
        labDescFlussoAzotoTaratura.Enabled = True
        tbFlussoAriaTaratura.Enabled = True
        tbFlussoAzotoTaratura.Enabled = True
        labUdmFlussoAriaTaratura.Enabled = True
        labUdmFlussoAzotoTaratura.Enabled = True
        btnSfogliaBackup.Enabled = True
        btnSfogliaBackupLotti.Enabled = True
        btnSfogliaBackupRicette.Enabled = True
        btnSfogliaBackupTarature.Enabled = True
        btnModifica.Enabled = False
        btnAnnullaModifiche.Enabled = True
        btnSalvaModifiche.Enabled = True
    End Sub



    Private Sub btnAnnullaModifiche_Click(sender As System.Object, e As System.EventArgs) Handles btnAnnullaModifiche.Click
        ' Se l'utente conferma l'operazione
        If (MsgBox("Annullare tutte le modifiche?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Domanda") = MsgBoxResult.Yes) Then
            ' Carica le impostazioni generali
            If (mImpostazioniGenerali.Carica(mGlobale.NomeFileImpostazioniGenerali)) Then
                MsgBox("Errore nel caricamento delle impostazioni generali.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Visualizza i valori
            VisualizzaValori()
            ' Resetta il flag di valori modificati
            _valoriModificati = False
        End If
    End Sub



    Private Sub btnModifica_Click(sender As System.Object, e As System.EventArgs) Handles btnModifica.Click
        ' Se l'utente effettua il login
        If (mGestorePassword.Login(0) > 0) Then
            ' Abilita i controlli
            AbilitaControlli()
        End If
    End Sub



    Private Sub btnSalvaModifiche_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvaModifiche.Click
        ' Salva le impostazioni generali
        If Not (mImpostazioniGenerali.Salva(mGlobale.NomeFileImpostazioniGenerali)) Then
            MsgBox("Salvataggio effettuato con successo.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
            _valoriModificati = False
        Else
            MsgBox("Errore nel salvataggio delle impostazioni generali.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
    End Sub



    Private Sub btnSfoglia_Click(sender As System.Object, e As System.EventArgs) Handles btnSfogliaBackup.Click,
                                                                                         btnSfogliaBackupTarature.Click,
                                                                                         btnSfogliaBackupRicette.Click,
                                                                                         btnSfogliaBackupLotti.Click
        Dim oggettoChiamante As Button

        ' Determina la textbox validata
        oggettoChiamante = CType(sender, Button)

        ' Se l'utente ha confermato l'operazione
        If fbdSelezioneCartella.ShowDialog() = DialogResult.OK Then
            ' Aggiorna la cartella di backup a seconda del backup selezionato
            If oggettoChiamante Is btnSfogliaBackup Then
                mImpostazioniGenerali.CartellaBackup = fbdSelezioneCartella.SelectedPath
            ElseIf oggettoChiamante Is btnSfogliaBackupLotti Then
                mImpostazioniGenerali.CartellaBackupLotti = fbdSelezioneCartella.SelectedPath
            ElseIf oggettoChiamante Is btnSfogliaBackupRicette Then
                mImpostazioniGenerali.CartellaBackupRicette = fbdSelezioneCartella.SelectedPath
            ElseIf oggettoChiamante Is btnSfogliaBackupTarature Then
                mImpostazioniGenerali.CartellaBackupTarature = fbdSelezioneCartella.SelectedPath
            End If
            ' Visualizza i valori
            VisualizzaValori()
            ' Setta il flag di valori modificati
            _valoriModificati = True
        End If
    End Sub



    Private Sub btnUscita_Click(sender As System.Object, e As System.EventArgs) Handles btnUscita.Click
        ' Gestisce eventuali valori modificati
        GestisciValoriModificati()
        ' Se non ci sono valori modificati
        If Not (_valoriModificati) Then
            ' Chiude la finestra
            Me.Close()
        End If
    End Sub



    Private Sub chkAbilitazioneCicliMaster_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAbilitazioneCicliMaster.CheckedChanged
        ' Aggiorna l'abilitazione dei cicli master
        mImpostazioniGenerali.AbilitazioneCicliMaster = chkAbilitazioneCicliMaster.Checked
        ' Visualizza i valori
        VisualizzaValori()
        ' Setta il flag di valori modificati
        _valoriModificati = True
    End Sub



    Private Sub chkAbilitazioneInterruzioneCiclo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAbilitazioneInterruzioneCiclo.CheckedChanged
        ' Aggiorna l'abilitazione dei cicli master
        mImpostazioniGenerali.AbilitazioneCicloInterrottoSuScarto = chkAbilitazioneInterruzioneCiclo.Checked
        ' Visualizza i valori
        VisualizzaValori()
        ' Setta il flag di valori modificati
        _valoriModificati = True
    End Sub



    Private Sub DisabilitaControlli()
        ' Disabilita i controlli
        chkAbilitazioneCicliMaster.Enabled = False
        chkAbilitazioneInterruzioneCiclo.Enabled = False
        labCartellaBackup.Enabled = False
        tbCartellaBackup.Enabled = False
        labCartellaBackupLotti.Enabled = False
        tbCartellaBackupLotti.Enabled = False
        labCartellaBackupRicette.Enabled = False
        tbCartellaBackupRicette.Enabled = False
        labCartellaBackupTarature.Enabled = False
        tbCartellaBackupTarature.Enabled = False
        labDescFlussoAriaTaratura.Enabled = False
        labDescFlussoAzotoTaratura.Enabled = False
        tbFlussoAriaTaratura.Enabled = False
        tbFlussoAzotoTaratura.Enabled = False
        labUdmFlussoAriaTaratura.Enabled = False
        labUdmFlussoAzotoTaratura.Enabled = False
        btnSfogliaBackup.Enabled = False
        btnSfogliaBackupLotti.Enabled = False
        btnSfogliaBackupRicette.Enabled = False
        btnSfogliaBackupTarature.Enabled = False
        btnModifica.Enabled = True
        btnAnnullaModifiche.Enabled = False
        btnSalvaModifiche.Enabled = False
    End Sub



    Private Sub frmImpostazioniGenerali_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Effettua il logout
        mGestorePassword.Logout()
    End Sub



    Private Sub frmImpostazioniGenerali_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Se il livello d'accesso è 0
        If (mGestorePassword.Livello = 0) Then
            ' Disabilita i controlli
            DisabilitaControlli()
        Else    ' Altrimenti, se il lvello d'accesso è maggiore di 0
            ' Abilita i controlli
            AbilitaControlli()
        End If
        ' Visualizza i valori
        VisualizzaValori()
        ' Resetta il flag di valori modificati
        _valoriModificati = False
    End Sub



    Private Sub GestisciValoriModificati()
        Dim scelta As MsgBoxResult

        ' Se sono stati modificati dei valori
        If (_valoriModificati) Then
            ' Chiede all'utente se salvare le modifiche
            scelta = MsgBox("I valori sono stati modificati: salvare le modifiche?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, MsgBoxStyle), "Domanda")
            ' Se l'utente vuole salvare le modifiche
            If (scelta = MsgBoxResult.Yes) Then
                ' Simula la pressione del pulsante salva modifiche
                btnSalvaModifiche.PerformClick()
                ' Resetta il flag di valori modificati
                _valoriModificati = False
            ElseIf (scelta = MsgBoxResult.No) Then  ' Altrimenti, se l'utente non vuole salvare le modifiche
                ' Resetta il flag di valori modificati
                _valoriModificati = False
            End If
        End If
    End Sub



    Private Sub tbCartellaBackup_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbCartellaBackup.Validating,
                                                                                                                  tbCartellaBackupTarature.Validating,
                                                                                                                  tbCartellaBackupRicette.Validating,
                                                                                                                  tbCartellaBackupLotti.Validating
        Dim oggettoChiamante As TextBox

        ' Determina la textbox validata
        oggettoChiamante = CType(sender, TextBox)

        ' Aggiorna la cartella di backup relativa alla textbox validata
        If oggettoChiamante Is tbCartellaBackup Then
            mImpostazioniGenerali.CartellaBackup = tbCartellaBackup.Text
        ElseIf oggettoChiamante Is tbCartellaBackupLotti Then
            mImpostazioniGenerali.CartellaBackupLotti = tbCartellaBackupLotti.Text
        ElseIf oggettoChiamante Is tbCartellaBackupRicette Then
            mImpostazioniGenerali.CartellaBackupRicette = tbCartellaBackupRicette.Text
        ElseIf oggettoChiamante Is tbCartellaBackupTarature Then
            mImpostazioniGenerali.CartellaBackupTarature = tbCartellaBackupTarature.Text
        End If
        ' Visualizza i valori
        VisualizzaValori()
        ' Setta il flag di valori modificati
        _valoriModificati = True
    End Sub



    Private Sub tbFlussoAriaTaratura_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbFlussoAriaTaratura.Validating
        Dim value As Single

        If (Single.TryParse(tbFlussoAriaTaratura.Text, value)) Then
            If (value < 0) Then
                value = 0
            End If
            If (value > 2) Then
                value = 2
            End If
            tbFlussoAriaTaratura.Text = value.ToString
            ' Aggiorna il valore di flusso aria nelle impostazioni generali
            mImpostazioniGenerali.FlussoAriaTaratura = value
            ' Visualizza i valori
            VisualizzaValori()
        Else
            MsgBox("Errore: il valore inserito non è valido", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            tbFlussoAriaTaratura.Focus()
            tbFlussoAriaTaratura.SelectAll()
        End If
    End Sub



    Private Sub tbFlussoAzotoTaratura_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbFlussoAzotoTaratura.Validating
        Dim value As Single

        If (Single.TryParse(tbFlussoAzotoTaratura.Text, value)) Then
            If (value < 0) Then
                value = 0
            End If
            If (value > 2) Then
                value = 2
            End If
            tbFlussoAzotoTaratura.Text = value.ToString
            ' Aggiorna il valore di flusso azoto nelle impostazioni generali
            mImpostazioniGenerali.FlussoAzotoTaratura = value
            ' Visualizza i valori
            VisualizzaValori()
        Else
            MsgBox("Errore: il valore inserito non è valido", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            tbFlussoAzotoTaratura.Focus()
            tbFlussoAzotoTaratura.SelectAll()
        End If
    End Sub



    Private Sub VisualizzaValori()
        ' Visualizza i valori
        chkAbilitazioneCicliMaster.Checked = mImpostazioniGenerali.AbilitazioneCicliMaster
        chkAbilitazioneInterruzioneCiclo.Checked = mImpostazioniGenerali.AbilitazioneCicloInterrottoSuScarto
        tbCartellaBackup.Text = mImpostazioniGenerali.CartellaBackup
        tbCartellaBackupLotti.Text = mImpostazioniGenerali.CartellaBackupLotti
        tbCartellaBackupRicette.Text = mImpostazioniGenerali.CartellaBackupRicette
        tbCartellaBackupTarature.Text = mImpostazioniGenerali.CartellaBackupTarature
        tbFlussoAriaTaratura.Text = mImpostazioniGenerali.FlussoAriaTaratura.ToString("0.000")
        tbFlussoAzotoTaratura.Text = mImpostazioniGenerali.FlussoAzotoTaratura.ToString("0.000")
    End Sub
End Class
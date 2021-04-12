Option Explicit On
Option Strict On

Public Class frmImpostazioniAvanzate
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
        gbMassFlowControllerAria.Enabled = True
        gbMassFlowControllerAzoto.Enabled = True
        gbValim.Enabled = True
        gbResistenza.Enabled = True
        gbCorrente.Enabled = True
        gbLsuO2.Enabled = True
        gbAdvLambda.Enabled = True
        gbAdvCorrentePumping.Enabled = True
        gbZfasCorrentePumpingEtas.Enabled = True
        gbZfasCorrentePumpingTB.Enabled = True
        btnModifica.Enabled = False
        btnAnnullaModifiche.Enabled = True
        btnSalvaModifiche.Enabled = True
    End Sub



    Private Sub btnAnnullaModifiche_Click(sender As System.Object, e As System.EventArgs) Handles btnAnnullaModifiche.Click
        ' Se l'utente conferma l'operazione
        If (MsgBox("Annullare tutte le modifiche?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Domanda") = MsgBoxResult.Yes) Then
            ' Carica le impostazioni avanzate
            If (mImpostazioniAvanzate.Carica(mGlobale.NomeFileImpostazioniAvanzate)) Then
                MsgBox("Errore nel caricamento delle impostazioni avanzate.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            ' Visualizza i valori
            VisualizzaValori()
            ' Resetta il flag di valori modificati
            _valoriModificati = False
        End If
    End Sub



    Private Sub btnModifica_Click(sender As System.Object, e As System.EventArgs) Handles btnModifica.Click
        ' Se l'utente effettua il login
        If (mGestorePassword.Login(2) = 2) Then
            ' Abilita i controlli
            AbilitaControlli()
        End If
    End Sub



    Private Sub btnSalvaModifiche_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvaModifiche.Click
        ' Salva le impostazioni avanzate
        If Not (mImpostazioniAvanzate.Salva(mGlobale.NomeFileImpostazioniAvanzate)) Then
            MsgBox("Salvataggio effettuato con successo.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
            _valoriModificati = False
        Else
            MsgBox("Errore nel salvataggio delle impostazioni avanzate.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
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



    Private Sub DisabilitaControlli()
        ' Disabilita i controlli
        gbMassFlowControllerAria.Enabled = False
        gbMassFlowControllerAzoto.Enabled = False
        gbValim.Enabled = False
        gbResistenza.Enabled = False
        gbCorrente.Enabled = False
        gbLsuO2.Enabled = False
        gbAdvLambda.Enabled = False
        gbAdvCorrentePumping.Enabled = False
        gbZfasCorrentePumpingEtas.Enabled = False
        gbZfasCorrentePumpingTB.Enabled = False
        btnModifica.Enabled = True
        btnAnnullaModifiche.Enabled = False
        btnSalvaModifiche.Enabled = False
    End Sub



    Private Sub frmImpostazioniAvanzate_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Effettua il logout
        mGestorePassword.Logout()
    End Sub



    Private Sub frmImpostazioniAvanzate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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



    Private Sub tbMoltiplicatore_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbMoltiplicatoreAdvCorrentePumping.Validating,
                                                                                                                  tbMoltiplicatoreAdvLambda.Validating,
                                                                                                                  tbMoltiplicatoreCorrente.Validating,
                                                                                                                  tbMoltiplicatoreLsuO2.Validating,
                                                                                                                  tbMoltiplicatoreMassFlowControllerAria.Validating,
                                                                                                                  tbMoltiplicatoreMassFlowControllerAzoto.Validating,
                                                                                                                  tbMoltiplicatoreResistenza.Validating,
                                                                                                                  tbMoltiplicatoreValim.Validating,
                                                                                                                  tbMoltiplicatoreZfasCorrentePumpingEtas.Validating,
                                                                                                                  tbMoltiplicatoreZfasCorrentePumpingTB.Validating

        Dim oggettoChiamante As TextBox = CType(sender, TextBox)
        Dim valore As Single

        ' Se il valore è interpretabile come numero
        If (Single.TryParse(oggettoChiamante.Text, valore)) Then
            ' Verifico per quale valore è stata richiesta la modifica
            If oggettoChiamante Is tbMoltiplicatoreAdvCorrentePumping Then
                mImpostazioniAvanzate.MoltiplicatoreAdvCorrentePumping = valore
            ElseIf oggettoChiamante Is tbMoltiplicatoreAdvLambda Then
                mImpostazioniAvanzate.MoltiplicatoreAdvLambda = valore
            ElseIf oggettoChiamante Is tbMoltiplicatoreCorrente Then
                mImpostazioniAvanzate.MoltiplicatoreMisuraCorrente = valore
            ElseIf oggettoChiamante Is tbMoltiplicatoreLsuO2 Then
                mImpostazioniAvanzate.MoltiplicatoreLsuO2 = valore
            ElseIf oggettoChiamante Is tbMoltiplicatoreMassFlowControllerAria Then
                mImpostazioniAvanzate.MoltiplicatoreMFC_O2 = valore
            ElseIf oggettoChiamante Is tbMoltiplicatoreMassFlowControllerAzoto Then
                mImpostazioniAvanzate.MoltiplicatoreMFC_N2 = valore
            ElseIf oggettoChiamante Is tbMoltiplicatoreResistenza Then
                mImpostazioniAvanzate.MoltiplicatoreMisuraResistenza = valore
            ElseIf oggettoChiamante Is tbMoltiplicatoreValim Then
                mImpostazioniAvanzate.MoltiplicatoreMisuraTensione = valore
            ElseIf oggettoChiamante Is tbMoltiplicatoreZfasCorrentePumpingEtas Then
                mImpostazioniAvanzate.MoltiplicatoreZfasCorrentePumpingEtas = valore
            ElseIf oggettoChiamante Is tbMoltiplicatoreZfasCorrentePumpingTB Then
                mImpostazioniAvanzate.MoltiplicatoreZfasCorrentePumpingTb = valore
            End If
            ' Visualizza i valori
            VisualizzaValori()
            ' Imposta il flag di valori modificati
            _valoriModificati = True
        Else
            ' Visualizza un messaggio d'errore
            MsgBox("Il valore inserito non è valido.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            ' Seleziona il valore da correggere
            oggettoChiamante.Focus()
            oggettoChiamante.SelectAll()
        End If
    End Sub



    Private Sub tbOffset_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbOffsetAdvCorrentePumping.Validating,
                                                                                                          tbOffsetAdvLambda.Validating,
                                                                                                          tbOffsetCorrente.Validating,
                                                                                                          tbOffsetLsuO2.Validating,
                                                                                                          tbOffsetMassFlowControllerAria.Validating,
                                                                                                          tbOffsetMassFlowControllerAzoto.Validating,
                                                                                                          tbOffsetResistenza.Validating,
                                                                                                          tbOffsetValim.Validating,
                                                                                                          tbOffsetZfasCorrentePumpingEtas.Validating,
                                                                                                          tbOffsetZfasCorrentePumpingTB.Validating

        Dim oggettoChiamante As TextBox = CType(sender, TextBox)
        Dim valore As Single

        ' Se il valore è interpretabile come numero
        If (Single.TryParse(oggettoChiamante.Text, valore)) Then
            ' Verifico per quale valore è stata richiesta la modifica
            If oggettoChiamante Is tbOffsetAdvCorrentePumping Then
                mImpostazioniAvanzate.OffsetAdvCorrentePumping = valore
            ElseIf oggettoChiamante Is tbOffsetAdvLambda Then
                mImpostazioniAvanzate.OffsetAdvLambda = valore
            ElseIf oggettoChiamante Is tbOffsetCorrente Then
                mImpostazioniAvanzate.OffsetMisuraCorrente = valore
            ElseIf oggettoChiamante Is tbOffsetLsuO2 Then
                mImpostazioniAvanzate.OffsetLsuO2 = valore
            ElseIf oggettoChiamante Is tbOffsetMassFlowControllerAria Then
                mImpostazioniAvanzate.OffsetMFC_O2 = valore
            ElseIf oggettoChiamante Is tbOffsetMassFlowControllerAzoto Then
                mImpostazioniAvanzate.OffsetMFC_N2 = valore
            ElseIf oggettoChiamante Is tbOffsetResistenza Then
                mImpostazioniAvanzate.OffsetMisuraResistenza = valore
            ElseIf oggettoChiamante Is tbOffsetValim Then
                mImpostazioniAvanzate.OffsetMisuraTensione = valore
            ElseIf oggettoChiamante Is tbOffsetZfasCorrentePumpingEtas Then
                mImpostazioniAvanzate.OffsetZfasCorrentePumpingEtas = valore
            ElseIf oggettoChiamante Is tbOffsetZfasCorrentePumpingTB Then
                mImpostazioniAvanzate.OffsetZfasCorrentePumpingTb = valore
            End If
            ' Visualizza i valori
            VisualizzaValori()
            ' Imposta il flag di valori modificati
            _valoriModificati = True
        Else
            ' Visualizza un messaggio d'errore
            MsgBox("Il valore inserito non è valido.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            ' Seleziona il valore da correggere
            oggettoChiamante.Focus()
            oggettoChiamante.SelectAll()
        End If
    End Sub



    Private Sub VisualizzaValori()
        ' Visualizza i valori
        tbOffsetMassFlowControllerAria.Text = mImpostazioniAvanzate.OffsetMFC_O2.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliOffsetMFC_O2))
        tbMoltiplicatoreMassFlowControllerAria.Text = mImpostazioniAvanzate.MoltiplicatoreMFC_O2.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliMoltiplicatoreMFC_O2))
        tbOffsetMassFlowControllerAzoto.Text = mImpostazioniAvanzate.OffsetMFC_N2.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliOffsetMFC_N2))
        tbMoltiplicatoreMassFlowControllerAzoto.Text = mImpostazioniAvanzate.MoltiplicatoreMFC_N2.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliMoltiplicatoreMFC_N2))
        tbOffsetValim.Text = mImpostazioniAvanzate.OffsetMisuraTensione.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliOffsetMisuraTensione))
        tbMoltiplicatoreValim.Text = mImpostazioniAvanzate.MoltiplicatoreMisuraTensione.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliMoltiplicatoreMisuraTensione))
        tbOffsetResistenza.Text = mImpostazioniAvanzate.OffsetMisuraResistenza.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliOffsetMisuraResistenza))
        tbMoltiplicatoreResistenza.Text = mImpostazioniAvanzate.MoltiplicatoreMisuraResistenza.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliMoltiplicatoreMisuraResistenza))
        tbOffsetCorrente.Text = mImpostazioniAvanzate.OffsetMisuraCorrente.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliOffsetMisuraCorrente))
        tbMoltiplicatoreCorrente.Text = mImpostazioniAvanzate.MoltiplicatoreMisuraCorrente.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliMoltiplicatoreMisuraCorrente))
        tbOffsetLsuO2.Text = mImpostazioniAvanzate.OffsetLsuO2.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliOffsetLsuO2))
        tbMoltiplicatoreLsuO2.Text = mImpostazioniAvanzate.MoltiplicatoreLsuO2.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliMoltiplicatoreLsuO2))
        tbOffsetAdvLambda.Text = mImpostazioniAvanzate.OffsetAdvLambda.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliOffsetAdvLambda))
        tbMoltiplicatoreAdvLambda.Text = mImpostazioniAvanzate.MoltiplicatoreAdvLambda.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliMoltiplicatoreAdvLambda))
        tbOffsetAdvCorrentePumping.Text = mImpostazioniAvanzate.OffsetAdvCorrentePumping.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliOffsetAdvCorrentePumping))
        tbMoltiplicatoreAdvCorrentePumping.Text = mImpostazioniAvanzate.MoltiplicatoreAdvCorrentePumping.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliMoltiplicatoreAdvCorrentePumping))
        tbOffsetZfasCorrentePumpingEtas.Text = mImpostazioniAvanzate.OffsetZfasCorrentePumpingEtas.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliOffsetZfasCorrentePumpingEtas))
        tbMoltiplicatoreZfasCorrentePumpingEtas.Text = mImpostazioniAvanzate.MoltiplicatoreZfasCorrentePumpingEtas.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliMoltiplicatoreZfasCorrentePumpingEtas))
        tbOffsetZfasCorrentePumpingTB.Text = mImpostazioniAvanzate.OffsetZfasCorrentePumpingTb.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliOffsetZfasCorrentePumpingTb))
        tbMoltiplicatoreZfasCorrentePumpingTB.Text = mImpostazioniAvanzate.MoltiplicatoreZfasCorrentePumpingTb.ToString(mUtilità.FormatoStringa(mImpostazioniAvanzate.DecimaliMoltiplicatoreZfasCorrentePumpingTb))
    End Sub
End Class
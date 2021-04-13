Option Explicit On
Option Strict On

Public Class frmDiagnostica
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                          Costruttore e distruttore                           |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Sub btnUscita_Click(sender As System.Object, e As System.EventArgs) Handles btnUscita.Click
        ' Chiusura della finestra
        Me.Close()
    End Sub



    Private Sub frmDiagnostica_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Disabilita il timer di monitoraggio
        tmrMonitor.Enabled = False
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
        ' Disabilito le checkbox del secondo pannello
        cbAbilitazione13V.Checked = False
        cbAbilitazioneIsolamento.Checked = False
        cbAbilitazioneO2.Checked = False
        cbAbilitazioneRiscaldatore.Checked = False
        ' Scrive le uscite dell'I/O Remoto
        If (mGlobale.IOremoto.Scrivi) Then
            MsgBox("Errore nella scrittura delle uscite dell'I/O Remoto.", CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Fermo i due MFC
        If mGlobale.Mass_Flow_Controller_O2.SetPortata(0) Then
            MsgBox("Errore nella scrittura del valore nel Mass Flow Controller O2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
        End If
        If mGlobale.Mass_Flow_Controller_N2.SetPortata(0) Then
            MsgBox("Errore nella scrittura del valore nel Mass Flow Controller N2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
        End If
    End Sub



    Private Sub frmDiagnostica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim i As Byte
        tbIO.Enabled = True
        tbMisurazioni.Enabled = False
        ' Visualizza la descrizione degli ingressi
        labIngressoDigitale0.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I00_PressostatoAria1)
        labIngressoDigitale1.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I01_PressostatoAria2)
        labIngressoDigitale2.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I02_PressostatoAzoto)
        labIngressoDigitale3.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I03)
        labIngressoDigitale4.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I04)
        labIngressoDigitale5.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I05)
        labIngressoDigitale6.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I06_Emergenza)
        labIngressoDigitale7.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I07_Ausiliari)
        labIngressoDigitale8.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I10_BtnAvvioCiclo)
        labIngressoDigitale9.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I11_BtnScarto)
        labIngressoDigitale10.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I12_BtnReset)
        labIngressoDigitale11.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I13)
        labIngressoDigitale12.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I14)
        labIngressoDigitale13.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I15)
        labIngressoDigitale14.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I16)
        labIngressoDigitale15.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I17_SensorePresScarto)
        labIngressoDigitale16.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I20_CodPiastra1)
        labIngressoDigitale17.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I21_CodPiastra2)
        labIngressoDigitale18.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I22_CodPiastra4)
        labIngressoDigitale19.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I23_FcCampanaAlta)
        labIngressoDigitale20.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I24_FcCampanaBassa)
        labIngressoDigitale21.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I25_FcPinzaAperta)
        labIngressoDigitale22.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I26_FcPinzaChiusa)
        labIngressoDigitale23.Text = mGlobale.IOremoto.DescrizioneIngresso(cIORemoto.eIngresso.I27_SensorePresPz)
        ' Visualizza la descrizione delle uscite
        labUscitaDigitale0.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U00_DiscesaCampana)
        labUscitaDigitale1.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U01_SalitaCampana)
        labUscitaDigitale2.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U02_ChiusuraPinza)
        labUscitaDigitale3.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U03_AperturaPinza)
        labUscitaDigitale4.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U04_OnRaffreddamento)
        labUscitaDigitale5.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U05)
        labUscitaDigitale6.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U06_LedRossiAvvio)
        labUscitaDigitale7.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U07_LedVerdiAvvio)
        labUscitaDigitale8.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U10_LampBuono)
        labUscitaDigitale9.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U11_LampScarto)
        labUscitaDigitale10.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U12_Cicalino)
        labUscitaDigitale11.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U13_RelèMis13VS)
        labUscitaDigitale12.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore)
        labUscitaDigitale13.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U15_RelèMisuraO2)
        labUscitaDigitale14.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U16_RelèConnCellaLD)
        labUscitaDigitale15.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U17_RelèRiscaldatoreLD)
        labUscitaDigitale16.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U20_RelèConnDirettaLD)
        labUscitaDigitale17.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U21_RelèVoltmetroLD)
        labUscitaDigitale18.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U22_RelèConnCellaNTK)
        labUscitaDigitale19.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U23_RelèConnCellaPinIpNTK)
        labUscitaDigitale20.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U24_RelèRiscaldatoreNTK)
        labUscitaDigitale21.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U25_RelèConnDirettaNTK)
        labUscitaDigitale22.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U26_RelèAmperometroPinIpNTK)
        labUscitaDigitale23.Text = mGlobale.IOremoto.DescrizioneUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento)

        ' Imposto a 0 i valori di ossigeno ed azoto
        tbN2.Text = "0"
        tbO2.Text = "0"
        ' Configura ed abilita il timer di monitoraggio
        tmrMonitor.Interval = 100
        tmrMonitor.Enabled = True
    End Sub


    Private Sub pbUscitaDigitale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbUscitaDigitale0.Click,
                                                                                                            pbUscitaDigitale1.Click,
                                                                                                            pbUscitaDigitale2.Click,
                                                                                                            pbUscitaDigitale3.Click,
                                                                                                            pbUscitaDigitale4.Click,
                                                                                                            pbUscitaDigitale5.Click,
                                                                                                            pbUscitaDigitale6.Click,
                                                                                                            pbUscitaDigitale7.Click,
                                                                                                            pbUscitaDigitale8.Click,
                                                                                                            pbUscitaDigitale9.Click,
                                                                                                            pbUscitaDigitale10.Click,
                                                                                                            pbUscitaDigitale11.Click,
                                                                                                            pbUscitaDigitale12.Click,
                                                                                                            pbUscitaDigitale13.Click,
                                                                                                            pbUscitaDigitale14.Click,
                                                                                                            pbUscitaDigitale15.Click,
                                                                                                            pbUscitaDigitale16.Click,
                                                                                                            pbUscitaDigitale17.Click,
                                                                                                            pbUscitaDigitale18.Click,
                                                                                                            pbUscitaDigitale19.Click,
                                                                                                            pbUscitaDigitale20.Click,
                                                                                                            pbUscitaDigitale21.Click,
                                                                                                            pbUscitaDigitale22.Click,
                                                                                                            pbUscitaDigitale23.Click

        'Dim indice As mGestoreDIO.eUscita
        Dim oggettoChiamante As PictureBox

        ' Se il livello della password è uguale a 2
        If (mGestorePassword.Login(2) = 2) Then
            ' Determina l'indice dell'uscita
            oggettoChiamante = CType(sender, PictureBox)
            If (oggettoChiamante Is pbUscitaDigitale0) Then
                'indice = CType(0, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana)
            ElseIf (oggettoChiamante Is pbUscitaDigitale1) Then
                'indice = CType(1, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana)
            ElseIf (oggettoChiamante Is pbUscitaDigitale2) Then
                'indice = CType(2, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza)
            ElseIf (oggettoChiamante Is pbUscitaDigitale3) Then
                'indice = CType(3, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza)
            ElseIf (oggettoChiamante Is pbUscitaDigitale4) Then
                'indice = CType(4, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U04_OnRaffreddamento) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U04_OnRaffreddamento)
            ElseIf (oggettoChiamante Is pbUscitaDigitale8) Then
                'indice = CType(8, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio)
            ElseIf (oggettoChiamante Is pbUscitaDigitale9) Then
                'indice = CType(9, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U07_LedVerdiAvvio) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U07_LedVerdiAvvio)
            ElseIf (oggettoChiamante Is pbUscitaDigitale10) Then
                'indice = CType(10, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U10_LampBuono) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U10_LampBuono)
            ElseIf (oggettoChiamante Is pbUscitaDigitale11) Then
                'indice = CType(11, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U11_LampScarto) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U11_LampScarto)
            ElseIf (oggettoChiamante Is pbUscitaDigitale12) Then
                'indice = CType(12, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U12_Cicalino) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U12_Cicalino)
            ElseIf (oggettoChiamante Is pbUscitaDigitale16) Then
                'indice = CType(13, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS)
            ElseIf (oggettoChiamante Is pbUscitaDigitale17) Then
                'indice = CType(14, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore)
            ElseIf (oggettoChiamante Is pbUscitaDigitale18) Then
                'indice = CType(14, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2)
            ElseIf (oggettoChiamante Is pbUscitaDigitale19) Then
                'indice = CType(15, mGestoreDIO.eUscita)
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento) = Not mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento)
            End If
            ' Scrive lo stato dell'uscita
            If (mGlobale.IOremoto.Scrivi) Then
                MsgBox("Errore nella scrittura delle uscite dell'I/O Remoto.", CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
        End If
    End Sub

    Private Sub tbO2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbO2.Validating
        Dim value As Single

        If (Single.TryParse(tbO2.Text, value)) Then
            If (value < 0) Then
                value = 0
            End If
            If (value > 2) Then
                value = 2
            End If
            tbO2.Text = value.ToString
        Else
            MsgBox("Errore: il valore inserito non è valido", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            tbO2.Focus()
            tbO2.SelectAll()
        End If
    End Sub

    Private Sub tbN2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbN2.Validating
        Dim value As Single

        If (Single.TryParse(tbN2.Text, value)) Then
            If (value < 0) Then
                value = 0
            End If
            If (value > 2) Then
                value = 2
            End If
            tbN2.Text = value.ToString
        Else
            MsgBox("Errore: il valore inserito non è valido", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            tbN2.Focus()
            tbN2.SelectAll()
        End If
    End Sub

    Private Sub tbMisurazioni_Enter(sender As Object, e As EventArgs) Handles tbMisurazioni.Enter
        tbIO.Enabled = False
        tbMisurazioni.Enabled = True
    End Sub

    Private Sub tbIO_Enter(sender As Object, e As EventArgs) Handles tbIO.Enter
        tbIO.Enabled = True
        tbMisurazioni.Enabled = False
    End Sub

    Private Sub btnViewLog_Click(sender As Object, e As EventArgs) Handles btnViewLog.Click
        If mGlobale.Lambda.LeggiErrore Then
            MsgBox("Errore nella lettura del log del Lambda", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        For i = 0 To 6
            If (mGlobale.Lambda.CodiceErrore(i) <> "OK") Then
                lblErrorLog.Text = lblErrorLog.Text & mGlobale.Lambda.CodiceErrore(i) & vbCrLf
            End If
        Next
    End Sub

    Private Sub btnCleanLog_Click(sender As Object, e As EventArgs) Handles btnCleanLog.Click
        lblErrorLog.Text = ""
    End Sub

    Private Sub tbN2_Validated(sender As Object, e As EventArgs) Handles tbN2.Validated
        Dim portata As Single
        ' Leggo il valore della text box N2
        If Single.TryParse(tbN2.Text, portata) Then

        End If
    End Sub

    Private Sub tbO2_Validated(sender As Object, e As EventArgs) Handles tbO2.Validated
        Dim portata As Single
        ' Leggo il valore della text box O2
        If Single.TryParse(tbO2.Text, portata) Then

        End If
    End Sub

    Private Sub btnAvviaErogazione_Click(sender As Object, e As EventArgs) Handles btnAvviaErogazione.Click
        Dim portataO2 As Single
        Dim portataN2 As Single

        portataO2 = CSng(tbO2.Text)
        portataN2 = CSng(tbN2.Text)

        ' Converto il valore da litri in percentuale per l'aria
        portataO2 = portatao2 * (100 / System.Convert.ToSingle(mGlobale.Mass_Flow_Controller_O2.FondoScala))
        ' Trasmetto il valore ottenuto al MFC
        If mGlobale.Mass_Flow_Controller_O2.SetPortata(portataO2) Then
            MsgBox("Errore nella scrittura del valore nel Mass Flow Controller O2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
        End If

        ' Converto il valore da litri in percentuale per l'azoto
        portataN2 = portataN2 * (100 / System.Convert.ToSingle(mGlobale.Mass_Flow_Controller_N2.FondoScala))
        ' Trasmetto il valore ottenuto al MFC
        If mGlobale.Mass_Flow_Controller_N2.SetPortata(portataN2) Then
            MsgBox("Errore nella scrittura del valore nel Mass Flow Controller N2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
        End If
    End Sub

    Private Sub btnArrestaErogazione_Click(sender As Object, e As EventArgs) Handles btnArrestaErogazione.Click
        ' Trasmetto il valore ottenuto al MFC aria
        If mGlobale.Mass_Flow_Controller_O2.SetPortata(0) Then
            MsgBox("Errore nella scrittura del valore nel Mass Flow Controller O2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
        End If

        ' Trasmetto il valore ottenuto al MFC
        If mGlobale.Mass_Flow_Controller_N2.SetPortata(0) Then
            MsgBox("Errore nella scrittura del valore nel Mass Flow Controller N2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
        End If
    End Sub

    Private Sub tbMisurazioni_Leave(sender As Object, e As EventArgs) Handles tbMisurazioni.Leave
        ' Disattivo tutti i valori che ho utilizzato durante la fase di misurazione
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento) = False
        mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = False
        ' Disattivo tutte le checkbox di questa pagina
        cbAbilitazione13V.Checked = False
        cbAbilitazioneIsolamento.Checked = False
        cbAbilitazioneO2.Checked = False
        cbAbilitazioneRiscaldatore.Checked = False
        ' Cancello i valori nelle celle Aria e Azoto e fermo l'emissione di gas
        tbO2.Text = "0"
        tbN2.Text = "0"
        If mGlobale.Mass_Flow_Controller_O2.SetPortata(0) Then
            MsgBox("Errore nella scrittura del valore nel Mass Flow Controller O2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
        End If
        If mGlobale.Mass_Flow_Controller_N2.SetPortata(0) Then
            MsgBox("Errore nella scrittura del valore nel Mass Flow Controller N2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
        End If
    End Sub

    Private Sub tmrMonitor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMonitor.Tick
#If SVILUPPO_OFFLINE = False Then
        Dim dblValore As Double
        Dim dblLetturaO2 As Double
        Dim dblLetturaN2 As Double
        Static b As Boolean
        Static t0 As Date

        ' Disabilita il timer
        tmrMonitor.Enabled = False
        ' Legge lo stato degli ingressi
        'If (mGestoreDIO.LeggiIngressi) Then
        '    MsgBox("Errore nella lettura dello stato degli ingressi digitali.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
        'End If
        If (mGlobale.IOremoto.Leggi) Then
            MsgBox("Errore nella lettura degli ingressi dell'I/O Remoto.", CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Se sono sul tab degli I/O digitali ignoro le scelte del tab misurazioni
        If tbIO.Enabled = True Then
            ' Visualizza lo stato degli ingressi
            pbIngressoDigitale0.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I00_PressostatoAria1), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale1.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I01_PressostatoAria2), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale2.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I02_PressostatoAzoto), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale3.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I03), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale4.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I04), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale5.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I05), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale6.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I06_Emergenza), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale7.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I07_Ausiliari), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale8.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I10_BtnAvvioCiclo), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale9.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I11_BtnScarto), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale10.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I12_BtnReset), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale11.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I13), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale12.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I14), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale13.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I15), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale14.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I16), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale15.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I17_SensorePresScarto), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale16.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I20_CodPiastra1), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale17.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I21_CodPiastra2), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale18.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I22_CodPiastra4), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale19.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I23_FcCampanaAlta), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale20.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I24_FcCampanaBassa), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale21.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I25_FcPinzaAperta), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale22.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I26_FcPinzaChiusa), Color.Yellow, Me.BackColor), Color)
            pbIngressoDigitale23.BackColor = CType(IIf(mGlobale.IOremoto.StatoIngresso(cIORemoto.eIngresso.I27_SensorePresPz), Color.Yellow, Me.BackColor), Color)
            ' Visualizza lo stato delle uscite
            pbUscitaDigitale0.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U00_DiscesaCampana), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale1.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U01_SalitaCampana), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale2.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale3.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale4.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U04_OnRaffreddamento), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale5.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U05), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale6.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U06_LedRossiAvvio), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale7.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U07_LedVerdiAvvio), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale8.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U10_LampBuono), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale9.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U11_LampScarto), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale10.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U12_Cicalino), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale11.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale12.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale13.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale14.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U16_RelèConnCellaLD), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale15.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U17_RelèRiscaldatoreLD), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale16.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U20_RelèConnDirettaLD), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale17.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U21_RelèVoltmetroLD), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale18.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U22_RelèConnCellaNTK), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale19.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U23_RelèConnCellaPinIpNTK), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale20.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U24_RelèRiscaldatoreNTK), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale21.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U25_RelèConnDirettaNTK), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale22.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U26_RelèAmperometroPinIpNTK), Color.Yellow, Me.BackColor), Color)
            pbUscitaDigitale23.BackColor = CType(IIf(mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento), Color.Yellow, Me.BackColor), Color)
        End If

        ' Se siamo sul tab delle misurazioni ignoro il test I/O e verifico solo le misurazioni attivate
        If tbMisurazioni.Enabled = True Then
            ' Controllo quali groupbox sono abilitati o meno
            gbTensioneAlimentazione.Enabled = Not (cbAbilitazioneIsolamento.Checked Or cbAbilitazioneO2.Checked Or cbAbilitazioneRiscaldatore.Checked)
            gbResistenzaRiscaldatore.Enabled = Not (cbAbilitazione13V.Checked Or cbAbilitazioneO2.Checked Or cbAbilitazioneIsolamento.Checked)
            gbMisuraO2.Enabled = Not (cbAbilitazioneRiscaldatore.Checked Or cbAbilitazione13V.Checked Or cbAbilitazioneIsolamento.Checked)
            gbMisuraIsolamnento.Enabled = Not (cbAbilitazione13V.Checked Or cbAbilitazioneO2.Checked Or cbAbilitazioneRiscaldatore.Checked)

            ' Aggiorno le letture di Azoto e Ossigeno
            If mGlobale.Mass_Flow_Controller_O2.LeggiMisuraNl(dblLetturaO2) Then
                MsgBox("Errore nella lettura del Mass Flow Controller O2.", CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            lblO2NL.Text = dblLetturaO2.ToString("0.000")
            If mGlobale.Mass_Flow_Controller_N2.LeggiMisuraNl(dblLetturaN2) Then
                MsgBox("Errore nella lettura del Mass Flow Controller N2.", CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            End If
            lblN2NL.Text = dblLetturaN2.ToString("0.000")
            ' Aggiorno le percentuali di immissione dei due gas (se almeno uno dei due valori è diverso da zero)
            If (dblLetturaN2 <> 0 Or dblLetturaO2 <> 0) Then
                lblO2Percentuale.Text = ((dblLetturaO2 * 100) / (dblLetturaO2 + dblLetturaN2)).ToString("0.000")
                lblN2Percentuale.Text = ((dblLetturaN2 * 100) / (dblLetturaN2 + dblLetturaO2)).ToString("0.000")
            End If
            'Verifico abilitazione checkbox
            If (cbAbilitazione13V.Checked) Then
                ' Attivo il relè 2.0
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS) = True
                ' Effettuo la misurazione della tensioe con il multimetro o avviso in caso di errore
                If (mGlobale.Multimetro.MisuraTensioneDC(dblValore)) Then
                    MsgBox("Errore nella lettura della tensione dal multimetro.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                Else
                    If (dblValore > 5) Then
                        lblTensione13V.Text = dblValore.ToString("0.000")
                    End If
                End If
            Else
                ' Cancello il valore dalla label
                lblTensione13V.Text = ""
                ' Disattivo il relè 2.0
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS) = False
            End If

            ' Verifico abilitazione checkbox
            If (cbAbilitazioneRiscaldatore.Checked) Then
                ' Attivo il relè 2.1
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore) = True
                If Not (b) Then
                    b = True
                    t0 = Date.Now
                End If
                ' Effettuo misurazione della resistenza con il multimetro o avviso in caso di errore
                If ((Date.Now - t0).TotalMilliseconds >= 200) Then
                    If (mGlobale.Multimetro.MisuraResistenza4Fili(dblValore)) Then
                        MsgBox("Errore nella lettura della resistenza dal multimetro.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    Else
                        If (dblValore < 100) Then
                            lblResRiscaldatore.Text = dblValore.ToString("0.000")
                        Else
                            lblResRiscaldatore.Text = "99,999"
                        End If
                    End If
                End If
            Else
                ' Cancello il valore dalla label
                lblResRiscaldatore.Text = ""
                ' Disattivo il relè 2.1
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U14_RelèMisRiscaldatore) = False
                b = False
            End If

            ' Verifico abilitazione checkbox
            If (cbAbilitazioneO2.Checked) Then
                ' Attivo il relè 2.2
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = True
                ' Effettuo misurazione della corrente
                If (mGlobale.Multimetro.MisuraCorrenteDC(10, dblValore)) Then
                    MsgBox("Errore nella lettura della corrente dal multimetro.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                Else
                    lblCorrRiscaldatore.Text = dblValore.ToString("0.000")
                End If
                ' Effettuo misurazioni del Lambda Meter
                If (mGlobale.Lambda.AvviaMisurazione) Then
                    MsgBox("Errore nella lettura della corrente dal lambda meter.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                Else
                    lblLambda.Text = mGlobale.Lambda.ValoreLambda.ToString("0.000")
                    lblTempRiscaldatore.Text = mGlobale.Lambda.Temperatura.ToString("0.0")
                    lblO2.Text = mGlobale.Lambda.O2.ToString("0.000")
                    mGlobale.Lambda.ArrestaMisurazione()
                End If
            Else
                ' Cancello i valori dalle label
                lblCorrRiscaldatore.Text = ""
                lblLambda.Text = ""
                lblTempRiscaldatore.Text = ""
                lblO2.Text = ""
                ' Disattivo il relè 2.2
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = False
            End If

            ' Verifico abilitazione checkbox
            If (cbAbilitazioneIsolamento.Checked) Then
                ' Attivo il relè 2.3
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento) = True
                ' Effettuo misurazione della corrente
                If (mGlobale.Multimetro.MisuraCorrenteDC(0.1, dblValore)) Then
                    MsgBox("Errore nella lettura della corrente dal multimetro.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                Else
                    lblCorrDispersa.Text = dblValore.ToString("0.000")
                End If
            Else
                ' Cancello il valore dalla label
                lblCorrDispersa.Text = ""
                ' Disattivo il relè 2.3
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U27_RelèMisuraIsolamento) = False
            End If
        ElseIf tbMisurazioni2.Enabled Then
            ' Controllo quali groupbox sono abilitati o meno
            gbAdvCorrenteRiscaldatore.Enabled = Not (cbAdvAbilitazioneLambda.Checked Or cbZfasAbilitationeIp.Checked Or cbZfasAbilitazioneCorrenteRiscaldatore.Checked)
            gbAdvLambda.Enabled = Not (cbAdvAbilitazioneCorrenteRiscaldatore.Checked Or cbZfasAbilitationeIp.Checked Or cbZfasAbilitazioneCorrenteRiscaldatore.Checked)
            gbZfasCorrenteRiscaldatore.Enabled = Not (cbAdvAbilitazioneCorrenteRiscaldatore.Checked Or cbAdvAbilitazioneLambda.Checked Or cbZfasAbilitationeIp.Checked)
            gbZfasIp.Enabled = Not (cbAdvAbilitazioneCorrenteRiscaldatore.Checked Or cbAdvAbilitazioneLambda.Checked Or cbZfasAbilitazioneCorrenteRiscaldatore.Checked)
        End If
        ' Scrive lo stato dell'uscita
        If (mGlobale.IOremoto.Scrivi) Then
            MsgBox("Errore nella scrittura delle uscite dell'I/O Remoto.", CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Enable the timer
        tmrMonitor.Enabled = True
#End If
    End Sub
End Class
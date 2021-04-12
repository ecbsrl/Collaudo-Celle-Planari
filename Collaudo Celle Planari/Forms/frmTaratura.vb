Option Explicit On

Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class frmTaratura
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    Public _TrasduttoreInTaratura As Byte


    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    Private _misura(9) As Double
    Private _o2Counter As Integer


    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Sub btnUscita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUscita.Click
        ' Effettua il logout
        mGestorePassword.Logout()
        ' Chiude la finestra
        Me.Close()
    End Sub



    Private Sub btnMisura_Click(sender As System.Object, e As System.EventArgs) Handles btnMisura.Click
        Dim i As Byte
        Dim portata As Single
        Dim t0 As Date

        ' Cursore a clessidra
        Me.Cursor = Cursors.WaitCursor
        ' Cancella tutte le misure visualizzate
        labMisura1.Text = ""
        labMisura2.Text = ""
        labMisura3.Text = ""
        labMisura4.Text = ""
        labMisura5.Text = ""
        labMisura6.Text = ""
        labMisura7.Text = ""
        labMisura8.Text = ""
        labMisura9.Text = ""
        labMisura10.Text = ""
        Me.Refresh()
        ' Leggo gli ingressi dall'i/o remoto
        If mGlobale.IOremoto.Leggi Then
            MsgBox("Errore nella lettura degli ingressi dall'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Esegue il ciclo di misura
        Select Case _TrasduttoreInTaratura

            Case 1 ' Val
                ' Attivo il relè per la misura della tensione di alimentazione
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS) = True
                If mGlobale.IOremoto.Scrivi Then
                    MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
                ' Attendo 0.1 secondi prima di procedere con le misurazioni
                t0 = Date.Now
                Do
                Loop Until ((Date.Now) - t0).TotalSeconds > 0.1
                ' Campiono la tensione 10 volte
                For i = 0 To 9
                    mGestioneSetpointMisure.MisuraTensione(_misura(i))
                    t0 = Date.Now
                    Do
                    Loop Until ((Date.Now - t0).TotalSeconds >= 0.1)
                Next
                ' Disattivo il relè una volta terminate le misure da campionare
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U13_RelèMis13VS) = False
                If mGlobale.IOremoto.Scrivi Then
                    MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If

            Case 2 'Rheater
                ' Chiudo la pinza per poter effettuare la misurazione
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = False
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = True
                If mGlobale.IOremoto.Scrivi Then
                    MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
                ' Attendo 0.1 secondi prima di procedere con le misurazioni
                t0 = Date.Now
                Do
                Loop Until ((Date.Now) - t0).TotalSeconds > 0.5
                ' Campiono la resistenza 10 volte
                For i = 0 To 9
                    mGestioneSetpointMisure.MisuraResistenza(_misura(i))
                    t0 = Date.Now
                    Do
                    Loop Until ((Date.Now - t0).TotalSeconds >= 0.1)
                Next
                ' Disattivo il relè una volta terminate le misure da campionare
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = False
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = True
                If mGlobale.IOremoto.Scrivi Then
                    MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If

            Case 3 'Mass Flow Controller O2
                If mGlobale.Mass_Flow_Controller_O2.SetPortata(50) Then
                    MsgBox("Errore nell'impostazione del flusso del Mass Flow Controller O2.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
                t0 = Date.Now
                Do
                Loop Until ((Date.Now - t0).TotalSeconds >= 10)
                For i = 0 To 9
                    mGlobale.Mass_Flow_Controller_O2.LeggiMisuraNl(_misura(i))
                    t0 = Date.Now
                    Do
                    Loop Until ((Date.Now - t0).TotalSeconds >= 0.1)
                Next
                If mGlobale.Mass_Flow_Controller_O2.SetPortata(0) Then
                    MsgBox("Errore nell'impostazione del flusso del Mass Flow Controller O2.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If

            Case 4 'Mass Flow Controller N2
                If mGlobale.Mass_Flow_Controller_N2.SetPortata(50) Then
                    MsgBox("Errore nell'impostazione del flusso del Mass Flow Controller N2.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
                t0 = Date.Now
                Do
                Loop Until ((Date.Now - t0).TotalSeconds >= 10)
                For i = 0 To 9
                    mGlobale.Mass_Flow_Controller_N2.LeggiMisuraNl(_misura(i))
                    t0 = Date.Now
                    Do
                    Loop Until ((Date.Now - t0).TotalSeconds >= 0.1)
                Next
                If mGlobale.Mass_Flow_Controller_N2.SetPortata(0) Then
                    MsgBox("Errore nell'impostazione del flusso del Mass Flow Controller N2.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If

            Case 5
                ' Chiudo la pinza per poter effettuare la misurazione
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = False
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = True
                If mGlobale.IOremoto.Scrivi Then
                    MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
                ' Attendo 0.2 secondi prima di procedere con le misurazioni
                t0 = Date.Now
                Do
                Loop Until ((Date.Now) - t0).TotalSeconds > 1
                ' Campiono la corrente 10 volte
                For i = 0 To 9
                    mGestioneSetpointMisure.MisuraCorrente(0.00001, _misura(i))
                    _misura(i) = (13.5 / CDec(_misura(i))) / 1000000
                    t0 = Date.Now
                    Do
                    Loop Until ((Date.Now - t0).TotalSeconds >= 0.1)
                Next
                ' Disattivo il relè una volta terminate le misure da campionare
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = False
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = True
                If mGlobale.IOremoto.Scrivi Then
                    MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If

            Case 6
                ' Chiudo la pinza per poter effettuare la misurazione
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = False
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = True
                ' Attivo il relè
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = True
                If mGlobale.IOremoto.Scrivi Then
                    MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
                ' Attendo 0.2 secondi prima di procedere con le misurazioni
                t0 = Date.Now
                Do
                Loop Until ((Date.Now) - t0).TotalSeconds > 0.5
                ' Campiono la corrente 10 volte
                For i = 0 To 9
                    mGestioneSetpointMisure.MisuraCorrente(10, _misura(i))
                    _misura(i) = _misura(i) * 1000
                    t0 = Date.Now
                    Do
                    Loop Until ((Date.Now - t0).TotalSeconds >= 0.1)
                Next
                ' Disattivo il relè una volta terminate le misure da campionare
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U02_ChiusuraPinza) = False
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U03_AperturaPinza) = True
                ' Attivo il relè
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = False
                If mGlobale.IOremoto.Scrivi Then
                    MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If

            Case 7 'Misura O2%
                ' Attivo il relè
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = True
                If mGlobale.IOremoto.Scrivi Then
                    MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
                ' Emetto la miscela di Aria ed Azoto
                portata = mImpostazioniGenerali.FlussoAriaTaratura * (100 / System.Convert.ToSingle(mGlobale.Mass_Flow_Controller_O2.FondoScala))
                If mGestioneSetpointMisure.SetPortataMFC_O2(portata) Then
                    MsgBox("Errore nella scrittura del valore nel Mass Flow Controller O2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                End If
                portata = mImpostazioniGenerali.FlussoAzotoTaratura * (100 / System.Convert.ToSingle(mGlobale.Mass_Flow_Controller_N2.FondoScala))
                If mGestioneSetpointMisure.SetPortataMFC_N2(portata) Then
                    MsgBox("Errore nella scrittura del valore nel Mass Flow Controller N2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                End If
                ' Attendo 60 secondi prima di effettuare i 10 campionamenti
                t0 = Date.Now
                Do
                Loop Until ((Date.Now) - t0).TotalSeconds > 60

                ' Campiono la percentuale di ossigeno 10 volte
                For i = 0 To 9
                    ' Avvio la misurazione del lambda meter
                    If mGlobale.Lambda.AvviaMisurazione Then
                        MsgBox("Errore nell'avvio della misurazione dal lambda meter.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    End If
                    _misura(i) = mGlobale.Lambda.O2
                    Application.DoEvents()
                    t0 = Date.Now
                    Do
                    Loop Until ((Date.Now - t0).TotalSeconds >= 0.5)
                    ' Arresto la misurazione del lambda meter
                    If mGlobale.Lambda.ArrestaMisurazione Then
                        MsgBox("Errore nell'arresto della misurazione dal lambda meter.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                    End If
                Next

                ' Disattivo il relè
                mGlobale.IOremoto.StatoUscita(cIORemoto.eUscita.U15_RelèMisuraO2) = False
                If mGlobale.IOremoto.Scrivi Then
                    MsgBox("Errore nella scrittura delle uscite verso l'I/O remoto.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                End If
                ' Spengo i flussi di aria e azoto
                If mGestioneSetpointMisure.SetPortataMFC_O2(0) Then
                    MsgBox("Errore nella scrittura del valore nel Mass Flow Controller O2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                End If
                If mGestioneSetpointMisure.SetPortataMFC_N2(0) Then
                    MsgBox("Errore nella scrittura del valore nel Mass Flow Controller N2.", CType(vbCritical + vbOKOnly, MsgBoxStyle), "Errore")
                End If
        End Select
        Select Case _TrasduttoreInTaratura
            Case 1
                labMisura1.Text = _misura(0).ToString("0.000") & " V"
                labMisura2.Text = _misura(1).ToString("0.000") & " V"
                labMisura3.Text = _misura(2).ToString("0.000") & " V"
                labMisura4.Text = _misura(3).ToString("0.000") & " V"
                labMisura5.Text = _misura(4).ToString("0.000") & " V"
                labMisura6.Text = _misura(5).ToString("0.000") & " V"
                labMisura7.Text = _misura(6).ToString("0.000") & " V"
                labMisura8.Text = _misura(7).ToString("0.000") & " V"
                labMisura9.Text = _misura(8).ToString("0.000") & " V"
                labMisura10.Text = _misura(9).ToString("0.000") & " V"
            Case 2
                labMisura1.Text = _misura(0).ToString("0.000") & " Ω"
                labMisura2.Text = _misura(1).ToString("0.000") & " Ω"
                labMisura3.Text = _misura(2).ToString("0.000") & " Ω"
                labMisura4.Text = _misura(3).ToString("0.000") & " Ω"
                labMisura5.Text = _misura(4).ToString("0.000") & " Ω"
                labMisura6.Text = _misura(5).ToString("0.000") & " Ω"
                labMisura7.Text = _misura(6).ToString("0.000") & " Ω"
                labMisura8.Text = _misura(7).ToString("0.000") & " Ω"
                labMisura9.Text = _misura(8).ToString("0.000") & " Ω"
                labMisura10.Text = _misura(9).ToString("0.000") & " Ω"
            Case 3
                labMisura1.Text = _misura(0).ToString("0.000") & " l/min"
                labMisura2.Text = _misura(1).ToString("0.000") & " l/min"
                labMisura3.Text = _misura(2).ToString("0.000") & " l/min"
                labMisura4.Text = _misura(3).ToString("0.000") & " l/min"
                labMisura5.Text = _misura(4).ToString("0.000") & " l/min"
                labMisura6.Text = _misura(5).ToString("0.000") & " l/min"
                labMisura7.Text = _misura(6).ToString("0.000") & " l/min"
                labMisura8.Text = _misura(7).ToString("0.000") & " l/min"
                labMisura9.Text = _misura(8).ToString("0.000") & " l/min"
                labMisura10.Text = _misura(9).ToString("0.000") & " l/min"
            Case 4
                labMisura1.Text = _misura(0).ToString("0.000") & " l/min"
                labMisura2.Text = _misura(1).ToString("0.000") & " l/min"
                labMisura3.Text = _misura(2).ToString("0.000") & " l/min"
                labMisura4.Text = _misura(3).ToString("0.000") & " l/min"
                labMisura5.Text = _misura(4).ToString("0.000") & " l/min"
                labMisura6.Text = _misura(5).ToString("0.000") & " l/min"
                labMisura7.Text = _misura(6).ToString("0.000") & " l/min"
                labMisura8.Text = _misura(7).ToString("0.000") & " l/min"
                labMisura9.Text = _misura(8).ToString("0.000") & " l/min"
                labMisura10.Text = _misura(9).ToString("0.000") & " l/min"
            Case 5
                labMisura1.Text = _misura(0).ToString("0.000") & " MΩ"
                labMisura2.Text = _misura(1).ToString("0.000") & " MΩ"
                labMisura3.Text = _misura(2).ToString("0.000") & " MΩ"
                labMisura4.Text = _misura(3).ToString("0.000") & " MΩ"
                labMisura5.Text = _misura(4).ToString("0.000") & " MΩ"
                labMisura6.Text = _misura(5).ToString("0.000") & " MΩ"
                labMisura7.Text = _misura(6).ToString("0.000") & " MΩ"
                labMisura8.Text = _misura(7).ToString("0.000") & " MΩ"
                labMisura9.Text = _misura(8).ToString("0.000") & " MΩ"
                labMisura10.Text = _misura(9).ToString("0.000") & " MΩ"
            Case 6
                labMisura1.Text = _misura(0).ToString("0") & " mA"
                labMisura2.Text = _misura(1).ToString("0") & " mA"
                labMisura3.Text = _misura(2).ToString("0") & " mA"
                labMisura4.Text = _misura(3).ToString("0") & " mA"
                labMisura5.Text = _misura(4).ToString("0") & " mA"
                labMisura6.Text = _misura(5).ToString("0") & " mA"
                labMisura7.Text = _misura(6).ToString("0") & " mA"
                labMisura8.Text = _misura(7).ToString("0") & " mA"
                labMisura9.Text = _misura(8).ToString("0") & " mA"
                labMisura10.Text = _misura(9).ToString("0") & " mA"
            Case 7
                labMisura1.Text = _misura(0).ToString("0.00") & " %"
                labMisura2.Text = _misura(1).ToString("0.00") & " %"
                labMisura3.Text = _misura(2).ToString("0.00") & " %"
                labMisura4.Text = _misura(3).ToString("0.00") & " %"
                labMisura5.Text = _misura(4).ToString("0.00") & " %"
                labMisura6.Text = _misura(5).ToString("0.00") & " %"
                labMisura7.Text = _misura(6).ToString("0.00") & " %"
                labMisura8.Text = _misura(7).ToString("0.00") & " %"
                labMisura9.Text = _misura(8).ToString("0.00") & " %"
                labMisura10.Text = _misura(9).ToString("0.00") & " %"
        End Select
        ' Cursore normale
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim app As Excel.Application
        Dim data As Date
        Dim errore As Boolean
        Dim nomeFile As String
        Dim percorsoCompleto As String
        Dim ricetta As New cRicetta
        Dim risultati As New cRisultati
        Dim workbook As Excel.Workbook
        Dim worksheet As Excel.Worksheet
        Dim indirizzocella As String

        ' Cursore a clessidra
        Me.Cursor = Cursors.WaitCursor
        ' Imposta il nome del lotto
        nomeFile = mGlobale.PercorsoReportTarature
        Select Case _TrasduttoreInTaratura
            Case 1
                nomeFile = nomeFile & "\MA01946 - Report Taratura Misurazione Val "
            Case 2
                nomeFile = nomeFile & "\MA01946 - Report Taratura Misurazione Resistenza Riscaldatore "
            Case 3
                nomeFile = nomeFile & "\MA01946 - Report Taratura Trasduttore Portata Aria"
            Case 4
                nomeFile = nomeFile & "\MA01946 - Report Taratura Trasduttore Portata Azoto"
            Case 5
                nomeFile = nomeFile & "\MA01946 - Report Taratura Misurazione Resistenza Isolamento "
            Case 6
                nomeFile = nomeFile & "\MA01946 - Report Taratura Misurazione Corrente Riscaldatore "
            Case 7
                nomeFile = nomeFile & "\MA01946 - Report Taratura Misurazione O2% "
        End Select
        nomeFile = nomeFile & Format(Date.Now, "yyyyMMdd_hhmmss") & ".xls"
        percorsoCompleto = Path.GetFullPath(nomeFile)
        Try
            ' Crea il report copiando il modello
            data = Date.Now

            If _TrasduttoreInTaratura = 7 Then
                ' Apre il file con i valori aggiuntivi per la taratura O2% comprendenti i flussi di aria e azoto erogati
                File.Copy(mGlobale.PercorsoModelliReport & "\MA01946 - Report Taratura O2.xls", nomeFile, True)
            ElseIf _TrasduttoreInTaratura <> 1 And _TrasduttoreInTaratura <> 3 And _TrasduttoreInTaratura <> 4 Then
                ' Apre il file standard solo se NON si tratta delle misurazioni Val O2 e Azoto
                File.Copy(mGlobale.PercorsoModelliReport & "\MA01946 - Report taratura.xls", nomeFile, True)
            Else
                ' Apre il file NO BIAS
                File.Copy(mGlobale.PercorsoModelliReport & "\MA01946 - Report taratura No Bias.xls", nomeFile, True)
            End If
            ' Apre il foglio di calcolo
            app = New Excel.Application
            workbook = app.Workbooks.Open(percorsoCompleto)
            worksheet = workbook.Worksheets("Foglio1")
            worksheet.Cells(worksheet.Range("D11").Row, worksheet.Range("D11").Column).Value = tbDataTaratura.Text
            worksheet.Cells(worksheet.Range("D13").Row, worksheet.Range("D13").Column).Value = tbOperatore.Text
            worksheet.Cells(worksheet.Range("D15").Row, worksheet.Range("D15").Column).Value = tbStrumentoCampione.Text
            Select Case _TrasduttoreInTaratura
                Case 1
                    worksheet.Cells(worksheet.Range("D17").Row, worksheet.Range("D17").Column).Value = "Misurazione Val"
                    worksheet.Cells(worksheet.Range("D20").Row, worksheet.Range("D20").Column).Value = 100
                    worksheet.Cells(worksheet.Range("D22").Row, worksheet.Range("D22").Column).Value = 0.001
                    worksheet.Cells(worksheet.Range("I20").Row, worksheet.Range("I20").Column).Value = "V"
                Case 2
                    worksheet.Cells(worksheet.Range("D17").Row, worksheet.Range("D17").Column).Value = "Misurazione Resistenza Riscaldatore"
                    worksheet.Cells(worksheet.Range("D20").Row, worksheet.Range("D20").Column).Value = 100
                    worksheet.Cells(worksheet.Range("D22").Row, worksheet.Range("D22").Column).Value = 0.001
                    worksheet.Cells(worksheet.Range("I20").Row, worksheet.Range("I20").Column).Value = "Ω"
                Case 3
                    worksheet.Cells(worksheet.Range("D17").Row, worksheet.Range("D17").Column).Value = "Trasduttore di portata Aria"
                    worksheet.Cells(worksheet.Range("D20").Row, worksheet.Range("D20").Column).Value = 2
                    worksheet.Cells(worksheet.Range("D22").Row, worksheet.Range("D22").Column).Value = 0.001
                    worksheet.Cells(worksheet.Range("I20").Row, worksheet.Range("I20").Column).Value = "l/min"
                Case 4
                    worksheet.Cells(worksheet.Range("D17").Row, worksheet.Range("D17").Column).Value = "Trasduttore di portata Azoto"
                    worksheet.Cells(worksheet.Range("D20").Row, worksheet.Range("D20").Column).Value = 2
                    worksheet.Cells(worksheet.Range("D22").Row, worksheet.Range("D22").Column).Value = 0.001
                    worksheet.Cells(worksheet.Range("I20").Row, worksheet.Range("I20").Column).Value = "l/min"
                Case 5
                    worksheet.Cells(worksheet.Range("D17").Row, worksheet.Range("D17").Column).Value = "Misurazione Resistenza Isolamento"
                    worksheet.Cells(worksheet.Range("D20").Row, worksheet.Range("D20").Column).Value = 100
                    worksheet.Cells(worksheet.Range("D22").Row, worksheet.Range("D22").Column).Value = 0.001
                    worksheet.Cells(worksheet.Range("I20").Row, worksheet.Range("I20").Column).Value = "MΩ"
                Case 6
                    worksheet.Cells(worksheet.Range("D17").Row, worksheet.Range("D17").Column).Value = "Misurazione Corrente Riscaldatore"
                    worksheet.Cells(worksheet.Range("D20").Row, worksheet.Range("D20").Column).Value = 9999
                    worksheet.Cells(worksheet.Range("D22").Row, worksheet.Range("D22").Column).Value = 1
                    worksheet.Cells(worksheet.Range("I20").Row, worksheet.Range("I20").Column).Value = "mA"
                Case 7
                    worksheet.Cells(worksheet.Range("D17").Row, worksheet.Range("D17").Column).Value = "Misurazione O2%"
                    worksheet.Cells(worksheet.Range("D20").Row, worksheet.Range("D20").Column).Value = 100
                    worksheet.Cells(worksheet.Range("D22").Row, worksheet.Range("D22").Column).Value = 0.01
                    worksheet.Cells(worksheet.Range("I13").Row, worksheet.Range("I13").Column).Value = "l/min"
                    worksheet.Cells(worksheet.Range("I15").Row, worksheet.Range("I15").Column).Value = mImpostazioniGenerali.FlussoAriaTaratura.ToString("0.000")
                    worksheet.Cells(worksheet.Range("I17").Row, worksheet.Range("I17").Column).Value = mImpostazioniGenerali.FlussoAzotoTaratura.ToString("0.000")
                    worksheet.Cells(worksheet.Range("I20").Row, worksheet.Range("I20").Column).Value = "%"
            End Select
            worksheet.Cells(worksheet.Range("I22").Row, worksheet.Range("I22").Column).Value = Math.Round(CDbl(tbValoreMaster.Text), 3)
            worksheet.Cells(worksheet.Range("I24").Row, worksheet.Range("I24").Column).Value = Math.Round(CDbl(tbTolleranzaAccettata.Text), 3)
            For i = 0 To 9
                indirizzocella = String.Format("C{0}", 32 + i)
                worksheet.Cells(worksheet.Range(indirizzocella).Row, worksheet.Range(indirizzocella).Column).Value = _misura(i)
            Next
            ' Salva e chiude il foglio di calcolo
            workbook.Save()
            workbook.Close()
            worksheet = Nothing
            workbook = Nothing
            app.Quit()
            app = Nothing
            ' Se è stata creata una cartella di backup per i report del lotto
            If (mImpostazioniGenerali.CartellaBackupTarature <> "") Then
                ' Copia il report appena creato nella cartella di backup
                File.Copy(percorsoCompleto, mImpostazioniGenerali.CartellaBackupTarature & "\" & percorsoCompleto.Substring(mGlobale.PercorsoReportTarature.Length), True)
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



    Private Sub frmTaratura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Inizializza la informazioni di taratura
        tbDataTaratura.Text = Format(Date.Now, "dd/MM/yyyy")
        tbOperatore.Text = ""
        tbStrumentoCampione.Text = ""
        ' Inizializza i parametri di taratura
        tbValoreMaster.Text = "0"
        tbTolleranzaAccettata.Text = "0"
        ' Inizializza le unità di misura 
        Select Case _TrasduttoreInTaratura
            Case 1
                labUDM1.Text = "V"
                labUDM2.Text = "V"
            Case 2
                labUDM1.Text = "Ω"
                labUDM2.Text = "Ω"
            Case 3
                labUDM1.Text = "l/min"
                labUDM2.Text = "l/min"
            Case 4
                labUDM1.Text = "l/min"
                labUDM2.Text = "l/min"
            Case 5
                labUDM1.Text = "MΩ"
                labUDM2.Text = "MΩ"
            Case 6
                labUDM1.Text = "mA"
                labUDM2.Text = "mA"
            Case 7
                labUDM1.Text = "%"
                labUDM2.Text = "%"
        End Select
        ' Inizializza le istruzioni all'operatore
        Select Case _TrasduttoreInTaratura
            Case 1
                labIstruzioni.Text = "Collegare lo strumento master per la misura di tensione al raccordo MISURA TENSIONE ALIMENTAZIONE presente sul pannello del quadro, inserire il valore di tensione misurato dal master e cliccare sul pulsante START CICLO DI MISURA"
            Case 2
                labIstruzioni.Text = "Inserire il pezzo master, inserire il valore di resistenza misurato in precedenza e cliccare sul pulsante START CICLO DI MISURA"
            Case 3
                labIstruzioni.Text = "Verificare che la campana sia chiusa, inserire il valore di aria che si è precedentemente misurato e cliccare sul pulsante START CICLO DI MISURA"
            Case 3
                labIstruzioni.Text = "Verificare che la campana sia chiusa, inserire il valore di azoto che si è precedentemente misurato e cliccare sul pulsante START CICLO DI MISURA"
            Case 5
                labIstruzioni.Text = "Collegare lo strumento master per la misura dell'isolamento al raccordo MISURA ISOLAMENTO CELLA presente sul pannello del quadro, inserire il pezzo master, inserire il valore di resistenza misurato dal master e cliccare sul pulsante START CICLO DI MISURA"
            Case 6
                labIstruzioni.Text = "Collegare lo strumento master per la misura della corrente al raccordo MISURA O2% presente sul pannello del quadro, inserire il pezzo master, inserire il valore di corrente misurato dal master e cliccare sul pulsante START CICLO DI MISURA"
            Case 7
                labIstruzioni.Text = "Inserire il connettore ausiliario SL.0524 al posto del posaggio usato in fase di collaudo e collegarvi la sonda. Premere sul pulsante START CICLO DI MISURA e attendere per un minuto il riscaldamento della sonda prima di visualizzare i risultati"
        End Select
        ' Cancella tutte le misure visualizzate
        labMisura1.Text = ""
        labMisura2.Text = ""
        labMisura3.Text = ""
        labMisura4.Text = ""
        labMisura5.Text = ""
        labMisura6.Text = ""
        labMisura7.Text = ""
        labMisura8.Text = ""
        labMisura9.Text = ""
        labMisura10.Text = ""
    End Sub



    Private Sub tbTolleranzaAccettata_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbTolleranzaAccettata.KeyPress
        ' Se è stato inserito un punto lo sostituisce con la virgola
        If e.KeyChar = "." Then e.KeyChar = ","
    End Sub


    Private Sub tbTolleranzaAccettata_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tbTolleranzaAccettata.Validating
        Dim valore As Double

        ' Se il valore è interpretabile come single
        If (Double.TryParse(tbTolleranzaAccettata.Text, valore)) Then
            Select Case _TrasduttoreInTaratura
                Case 1
                    valore = Math.Round(valore, 2)
                    If (valore < 0.01) Then
                        tbTolleranzaAccettata.Text = "0,001"
                    Else
                        tbTolleranzaAccettata.Text = valore.ToString("0.000")
                    End If
                Case 2
                    valore = Math.Round(valore, 4)
                    If (valore < 0.0001) Then
                        tbTolleranzaAccettata.Text = "0,001"
                    Else
                        tbTolleranzaAccettata.Text = valore.ToString("0.000")
                    End If
                Case 3
                    valore = Math.Round(valore, 3)
                    If (valore < 0.001) Then
                        tbTolleranzaAccettata.Text = "0,001"
                    Else
                        tbTolleranzaAccettata.Text = valore.ToString("0.000")
                    End If
                Case 4
                    valore = Math.Round(valore, 3)
                    If (valore < 0.001) Then
                        tbTolleranzaAccettata.Text = "0,001"
                    Else
                        tbTolleranzaAccettata.Text = valore.ToString("0.000")
                    End If
                Case 5
                    valore = Math.Round(valore, 2)
                    If (valore < 0.01) Then
                        tbTolleranzaAccettata.Text = "0,001"
                    Else
                        tbTolleranzaAccettata.Text = valore.ToString("0.00")
                    End If

                Case 6
                    valore = Math.Round(valore, 2)
                    If (valore < 0.01) Then
                        tbTolleranzaAccettata.Text = "1"
                    Else
                        tbTolleranzaAccettata.Text = valore.ToString("0")
                    End If

                Case 7
                    valore = Math.Round(valore, 3)
                    If (valore < 0.001) Then
                        tbTolleranzaAccettata.Text = "0,001"
                    Else
                        tbTolleranzaAccettata.Text = valore.ToString("0.000")
                    End If
            End Select
        Else
            MsgBox("Il valore inserito non è valido", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            tbTolleranzaAccettata.SelectAll()
            tbTolleranzaAccettata.Focus()
        End If
    End Sub



    Private Sub tbValoreMaster_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbValoreMaster.KeyPress
        ' Se è stato inserito un punto lo sostituisce con la virgola
        If e.KeyChar = "." Then e.KeyChar = ","
    End Sub



    Private Sub tbValoreMaster_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbValoreMaster.Validating
        Dim valore As Double

        ' Se il valore è interpretabile come single
        If (Double.TryParse(tbValoreMaster.Text, valore)) Then
            Select Case _TrasduttoreInTaratura
                Case 1
                    valore = Math.Round(valore, 3)
                    tbValoreMaster.Text = valore.ToString("0.000")
                Case 2
                    valore = Math.Round(valore, 3)
                    tbValoreMaster.Text = valore.ToString("0.000")
                Case 3
                    valore = Math.Round(valore, 3)
                    tbValoreMaster.Text = valore.ToString("0.000")
                Case 4
                    valore = Math.Round(valore, 3)
                    tbValoreMaster.Text = valore.ToString("0.000")
                Case 5
                    valore = Math.Round(valore, 3)
                    tbValoreMaster.Text = valore.ToString("0.000")
                Case 6
                    valore = Math.Round(valore, 1)
                    tbValoreMaster.Text = valore.ToString("0")
                Case 7
                    valore = Math.Round(valore, 3)
                    tbValoreMaster.Text = valore.ToString("0.000")
            End Select
        Else
            MsgBox("Il valore inserito non è valido", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
            tbValoreMaster.SelectAll()
            tbValoreMaster.Focus()
        End If
    End Sub

    Private Sub tmrMonitor_Tick(sender As Object, e As EventArgs) Handles tmrMonitor.Tick
        tmrMonitor.Stop()

        tmrMonitor.Start()
    End Sub
End Class
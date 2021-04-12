Option Explicit On
Option Strict On

Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.IO

Public Class frmBackup
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
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Sub btnBackup_Click(sender As System.Object, e As System.EventArgs) Handles btnBackup.Click
        Dim errore As Boolean
        Dim nomeCartella As String = ""

        ' Se è selezionata almeno una voce di backup
        If (chkImpostazioni.Checked Or chkRicette.Checked Or chkLotti.Checked Or chkReport.Checked) Then
            ' Resetta il flag d'errore
            errore = False
            ' Verifica che la cartella di backup esista
            If Not (Directory.Exists(tbCartellaBackup.Text)) Then
                MsgBox("La cartella di backup non esiste.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                errore = True
            End If
            ' Crea la cartella del backup
            If Not (errore) Then
                Try
                    nomeCartella = tbCartellaBackup.Text & "\Backup " & Format(Date.Now, "yyyyMMdd HHmmss")
                    Directory.CreateDirectory(nomeCartella)
                Catch ex As Exception
                    MsgBox("Errore nella creazione della cartella del backup.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                    errore = True
                End Try
            End If
            ' Copia le impostazioni
            If (Not (errore) And chkImpostazioni.Checked) Then
                Try
                    Directory.CreateDirectory(nomeCartella & "\Impostazioni")
                    CopyDirectory(mGlobale.PercorsoImpostazioni, nomeCartella & "\Impostazioni")
                Catch ex As Exception
                    MsgBox("Errore nella copia delle impostazioni.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                    errore = True
                End Try
            End If
            ' Copia le ricette
            If (Not (errore) And chkRicette.Checked) Then
                Try
                    Directory.CreateDirectory(nomeCartella & "\Ricette")
                    CopyDirectory(mGlobale.PercorsoRicette, nomeCartella & "\Ricette")
                Catch ex As Exception
                    MsgBox("Errore nella copia delle ricette.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                    errore = True
                End Try
            End If
            ' Copia i lotti
            If (Not (errore) And chkLotti.Checked) Then
                Try
                    Directory.CreateDirectory(nomeCartella & "\Lotti")
                    CopyDirectory(mGlobale.PercorsoLotti, nomeCartella & "\Lotti")
                Catch ex As Exception
                    MsgBox("Errore nella copia dei lotti.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                    errore = True
                End Try
            End If
            ' Copia i report
            If (Not (errore) And chkReport.Checked) Then
                Try
                    Directory.CreateDirectory(nomeCartella & "\Report")
                    CopyDirectory(mGlobale.PercorsoReport, nomeCartella & "\Report")
                Catch ex As Exception
                    MsgBox("Errore nella copia dei report.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
                    errore = True
                End Try
            End If
            ' Se non si sono verificati errori
            If Not (errore) Then
                ' Visualizza un messaggio d'informazioni
                MsgBox("Backup effettuato con successo.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
            End If
        Else    ' Altrimenti, se non è selezionata nessuna voce di backup
            ' Visualizza un messaggio d'avviso
            MsgBox("Nessuna voce di backup selezionata.", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MsgBoxStyle), "Avviso")
        End If
    End Sub



    Private Sub btnSfoglia_Click(sender As System.Object, e As System.EventArgs) Handles btnSfoglia.Click
        ' Se l'utente ha confermato l'operazione
        If fbdSelezioneCartella.ShowDialog() = DialogResult.OK Then
            ' Aggiorna la cartella di backup
            tbCartellaBackup.Text = fbdSelezioneCartella.SelectedPath
        End If
    End Sub



    Private Sub btnUscita_Click(sender As System.Object, e As System.EventArgs) Handles btnUscita.Click
        ' Chiude la finestra
        Me.Close()
    End Sub



    Private Sub chkSingolaVoce_Click(sender As Object, e As System.EventArgs) Handles chkImpostazioni.Click, _
                                                                                      chkRicette.Click, _
                                                                                      chkLotti.Click, _
                                                                                      chkReport.Click
        ' Aggiorna lo stato della casella seleziona tutto
        chkSelezionaTutto.Checked = chkImpostazioni.Checked And _
                                    chkRicette.Checked And _
                                    chkLotti.Checked And _
                                    chkReport.Checked
    End Sub



    Private Sub chkSelezionaTutto_Click(sender As Object, e As System.EventArgs) Handles chkSelezionaTutto.Click
        ' Se la casella è selezionata
        If (chkSelezionaTutto.Checked) Then
            chkImpostazioni.Checked = True
            chkRicette.Checked = True
            chkLotti.Checked = True
            chkReport.Checked = True
        Else
            chkImpostazioni.Checked = False
            chkRicette.Checked = False
            chkLotti.Checked = False
            chkReport.Checked = False
        End If
    End Sub



    Private Sub frmBackup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Visualizza la cartella di backup
        tbCartellaBackup.Text = mImpostazioniGenerali.CartellaBackup
        ' Seleziona tutte le voci di backup
        chkSelezionaTutto.Checked = True
        chkImpostazioni.Checked = True
        chkRicette.Checked = True
        chkLotti.Checked = True
        chkReport.Checked = True
    End Sub
End Class
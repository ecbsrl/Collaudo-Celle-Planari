Option Explicit On
Option Strict Off

Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class cLotto
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _dataCreazione As String
    Private _nome As String
    Private _nomeRicetta As String
    Private _note As String
    Private _numeroBuoniNonRipassati As Integer
    Private _numeroBuoniRipassati As Integer
    Private _numeroOrdine As String
    Private _numeroScartiNonRipassati As Integer
    Private _numeroScartiRipassati As Integer
    Private _ricetta As New cRicetta
    Private _ricettaMaster As New cRicetta



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public Property DataCreazione As String
        Get
            DataCreazione = _dataCreazione
        End Get
        Set(value As String)
            _dataCreazione = value
        End Set
    End Property



    Public Property Nome As String
        Get
            Nome = _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property



    Public Property NomeRicetta As String
        Get
            NomeRicetta = _nomeRicetta
        End Get
        Set(value As String)
            _nomeRicetta = value
        End Set
    End Property



    Public Property Note As String
        Get
            Note = _note
        End Get
        Set(value As String)
            _note = value
        End Set
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



    Public Property NumeroOrdine As String
        Get
            NumeroOrdine = _numeroOrdine
        End Get
        Set(value As String)
            _numeroOrdine = value
        End Set
    End Property



    Public ReadOnly Property NumeroPezzi As Integer
        Get
            NumeroPezzi = Me.NumeroBuoni + Me.NumeroScarti
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



    Public Property Ricetta As cRicetta
        Get
            Ricetta = _ricetta
        End Get
        Set(value As cRicetta)
            _ricetta = value
        End Set
    End Property



    Public Property RicettaMaster As cRicetta
        Get
            RicettaMaster = _ricettaMaster
        End Get
        Set(value As cRicetta)
            _ricettaMaster = value
        End Set
    End Property



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function Cancella() As Boolean
        ' Cancella il lotto
        Cancella = Cancella(_nome)
        ' Inizializza il lotto
        Inizializza()
    End Function



    Public Function Cancella(ByVal nomeLotto As String) As Boolean
        Try
            ' Cancella la directory del lotto
            Directory.Delete(mGlobale.PercorsoLotti & "\" & nomeLotto, True)
            ' Restituisce False
            Cancella = False

        Catch ex As Exception
            ' Restituisce True
            Cancella = True
        End Try
    End Function



    Public Function Carica() As Boolean
        ' Carica il lotto
        Carica = Carica(_nome)
    End Function



    Public Function Carica(ByVal nomeLotto As String) As Boolean
        ' Imposta il nome del lotto
        _nome = nomeLotto
        ' Carica i contatori
        Carica = CaricaContatori()
        ' Carica i parametri
        Carica = Carica OrElse CaricaParametri()
        ' Carica la ricetta
        Carica = Carica OrElse CaricaRicetta()
        ' Carica la ricetta master
        Carica = Carica OrElse CaricaRicettaMaster()
    End Function



    Public Function CaricaContatori() As Boolean
        Dim campo() As String
        Dim file As StreamReader = Nothing
        Dim linea As String

        Try
            ' Apre il file
            file = New StreamReader(mGlobale.PercorsoLotti & "\" & _nome & "\Contatori.txt")
            ' Legge i valori
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _numeroBuoniNonRipassati = CInt(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _numeroScartiNonRipassati = CInt(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _numeroBuoniRipassati = CInt(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _numeroScartiRipassati = CInt(campo(1))
            '
            ' Restituisce False
            CaricaContatori = False

        Catch ex As Exception
            ' Restituisce True
            CaricaContatori = True

        Finally
            ' Chiude il file
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try
    End Function



    Public Function CaricaParametri() As Boolean
        Dim campo() As String
        Dim file As StreamReader = Nothing
        Dim linea As String

        Try
            ' Apre il file
            file = New StreamReader(mGlobale.PercorsoLotti & "\" & _nome & "\Parametri.txt")
            ' Legge i valori
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _nome = campo(1)
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _dataCreazione = campo(1)
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _numeroOrdine = campo(1)
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _nomeRicetta = campo(1)
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            campo(1) = campo(1).Replace("\crlf", vbCrLf)
            campo(1) = campo(1).Replace("\bk", "\")
            _note = campo(1)
            ' Restituisce False
            CaricaParametri = False

        Catch ex As Exception
            ' Restituisce True
            CaricaParametri = True

        Finally
            ' Chiude il file
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try
    End Function



    Public Function CaricaRicetta() As Boolean
        ' Carica la ricetta
        CaricaRicetta = _ricetta.CaricaDaFile(mGlobale.PercorsoLotti & "\" & _nome & "\Ricetta.txt")
    End Function



    Public Function CaricaRicettaMaster() As Boolean
        ' Carica la ricetta master
        CaricaRicettaMaster = _ricettaMaster.CaricaDaFile(mGlobale.PercorsoLotti & "\" & _nome & "\Ricetta master.txt")
    End Function



    Public Shared Function Esiste(ByVal nomeLotto As String) As Boolean
        ' Restituisce True se il lotto esiste
        Esiste = Directory.Exists(mGlobale.PercorsoLotti & "\" & nomeLotto)
    End Function



    Public Shared Function LeggiLista(ByRef nomeLotto() As String) As Boolean
        ' Legge la lista di lotti
        Try
            Dim di As New DirectoryInfo(mGlobale.PercorsoLotti)
            Dim sdi As DirectoryInfo() = di.GetDirectories
            ReDim nomeLotto(0 To sdi.Length - 1)
            For i = 0 To sdi.Length - 1
                nomeLotto(i) = sdi(i).Name
            Next
            LeggiLista = False

        Catch ex As Exception
            LeggiLista = True
        End Try
    End Function



    Public Sub Inizializza()
        ' Inizializza il lotto
        _dataCreazione = ""
        _nome = ""
        _nomeRicetta = ""
        _note = ""
        _numeroOrdine = ""
        _numeroBuoniNonRipassati = 0
        _numeroScartiNonRipassati = 0
        _numeroBuoniRipassati = 0
        _numeroScartiRipassati = 0
        _ricetta.Inizializza()
        _ricettaMaster.Inizializza()
    End Sub



    Public Function Salva() As Boolean
        ' Salva il lotto
        Salva = Salva(_nome)
    End Function



    Public Function Salva(ByVal nomeLotto As String) As Boolean
        Try
            ' Imposta il nome del lotto
            _nome = nomeLotto
            ' Crea la directory del lotto
            If Not (Directory.Exists(mGlobale.PercorsoLotti & "\" & _nome)) Then
                Directory.CreateDirectory(mGlobale.PercorsoLotti & "\" & _nome)
            End If
            ' Se è stata impostata una cartella di backup per i lotti
            If (mImpostazioniGenerali.CartellaBackupLotti <> "") Then
                ' Crea la directory del lotto se ancora non esiste
                If Not (Directory.Exists(mImpostazioniGenerali.CartellaBackupLotti & "\" & _nome)) Then
                    Directory.CreateDirectory(mImpostazioniGenerali.CartellaBackupLotti & "\" & _nome)
                End If
            End If
            ' Salva i contatori
            Salva = SalvaContatori()
            ' Salva i parametri
            Salva = Salva OrElse SalvaParametri()
            ' Salva la ricetta
            Salva = Salva OrElse SalvaRicetta()
            ' Salva la ricetta master
            Salva = Salva OrElse SalvaRicettaMaster()

        Catch ex As Exception
            ' Restituisce True
            Salva = True
        End Try
    End Function



    Public Function SalvaContatori() As Boolean
        Dim file As StreamWriter = Nothing

        Try
            ' Apre il file
            file = New StreamWriter(mGlobale.PercorsoLotti & "\" & _nome & "\Contatori.txt")
            ' Scrive i valori
            file.WriteLine("Numero buoni non ripassati" & vbTab & _numeroBuoniNonRipassati.ToString)
            file.WriteLine("Numero scarti non ripassati" & vbTab & _numeroScartiNonRipassati.ToString)
            file.WriteLine("Numero buoni ripassati" & vbTab & _numeroBuoniRipassati.ToString)
            file.WriteLine("Numero scarti ripassati" & vbTab & _numeroScartiRipassati.ToString)
            ' Restituisce False
            SalvaContatori = False

        Catch ex As Exception
            ' Restituisce True
            SalvaContatori = True

        Finally
            ' Chiude il file
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try
    End Function



    Public Function SalvaParametri() As Boolean
        Dim file As StreamWriter = Nothing

        Try
            ' Apre il file
            file = New StreamWriter(mGlobale.PercorsoLotti & "\" & _nome & "\Parametri.txt")
            ' Scrive i valori
            file.WriteLine("Nome" & vbTab & _nome)
            file.WriteLine("Data di creazione" & vbTab & _dataCreazione)
            file.WriteLine("Numero ordine" & vbTab & _numeroOrdine)
            file.WriteLine("Nome ricetta" & vbTab & _nomeRicetta)
            file.WriteLine("Note" & vbTab & _note.Replace("\", "\bk").Replace(vbCrLf, "\crlf"))
            ' Restituisce False
            SalvaParametri = False

        Catch ex As Exception
            ' Restituisce True
            SalvaParametri = True

        Finally
            ' Chiude il file
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try
    End Function



    Public Function SalvaRicetta() As Boolean
        ' Salva la ricetta
        SalvaRicetta = _ricetta.SalvaSuFile(mGlobale.PercorsoLotti & "\" & _nome & "\Ricetta.txt")
    End Function



    Public Function SalvaRicettaMaster() As Boolean
        ' Salva la ricetta master
        SalvaRicettaMaster = _ricettaMaster.SalvaSuFile(mGlobale.PercorsoLotti & "\" & _nome & "\Ricetta master.txt")
    End Function



    Public Function SalvaRisultati(ByRef risultati As cRisultati) As Boolean
        Dim nomeFile As String
        Dim sw As StreamWriter = Nothing

        Try
            ' Se il file non esiste
            nomeFile = mGlobale.PercorsoLotti & "\" & _nome & "\Risultati.txt"
            If Not (File.Exists(nomeFile)) Then
                ' Apre il file
                sw = New StreamWriter(nomeFile)
                ' Scrive l'intestazione delle colonne
                sw.WriteLine(risultati.DataCollaudo.Descrizione &
                             vbTab & risultati.OraCollaudo.Descrizione &
                             vbTab & "Esito di collaudo" &
                             vbTab & risultati.PezzoRipassato.Descrizione &
                             vbTab & risultati.Val.Descrizione &
                             vbTab & risultati.Rheater.Descrizione &
                             vbTab & risultati.CorrenteRiscaldatore.Descrizione &
                             vbTab & risultati.ResistenzaIsolamento.Descrizione &
                             vbTab & risultati.Lsu_TemperaturaOperativa.Descrizione &
                             vbTab & risultati.Lsu_O2.Descrizione &
                             vbTab & risultati.Lsu_ResistenzaCalibrazione.Descrizione &
                             vbTab & risultati.ADVIp.Descrizione &
                             vbTab & risultati.ADVlambda.Descrizione &
                             vbTab & risultati.ZfasIpEtas.Descrizione &
                             vbTab & risultati.ZfasIpTB.Descrizione)
                ' Chiude il file
                sw.Close()
                sw = Nothing
            End If
            ' Apre il file
            sw = File.AppendText(nomeFile)
            ' Aggiunge la stringa di risultati
            sw.WriteLine(risultati.DataCollaudo.ValoreStringa &
                         vbTab & risultati.OraCollaudo.ValoreStringa &
                         vbTab & CInt(risultati.Esito) &
                         vbTab & risultati.PezzoRipassato.ValoreStringa &
                         vbTab & risultati.Val.ValoreStringa &
                         vbTab & risultati.Rheater.ValoreStringa &
                         vbTab & risultati.CorrenteRiscaldatore.ValoreStringa &
                         vbTab & risultati.ResistenzaIsolamento.ValoreStringa &
                         vbTab & risultati.Lsu_TemperaturaOperativa.ValoreStringa &
                         vbTab & risultati.Lsu_O2.ValoreStringa &
                         vbTab & risultati.Lsu_ResistenzaCalibrazione.ValoreStringa &
                         vbTab & risultati.ADVIp.ValoreStringa &
                         vbTab & risultati.ADVlambda.ValoreStringa &
                         vbTab & risultati.ZfasIpEtas.ValoreStringa &
                         vbTab & risultati.ZfasIpTB.ValoreStringa)
            ' Chiude il file
            sw.Close()
            sw = Nothing
            ' Restituisce False
            SalvaRisultati = False

        Catch ex As Exception
            ' Chiude il file
            If (sw IsNot Nothing) Then
                sw.Close()
                sw = Nothing
            End If
            ' Restituisce True
            SalvaRisultati = True
        End Try
    End Function



    Public Function SalvaRisultatiMaster(ByVal nomeRicettaMaster As String, ByVal nomeRisultatoMaster As String, ByRef risultati As cRisultati) As Boolean
        Dim nomeFile As String
        Dim sw As StreamWriter = Nothing

        Try
            ' Se il file non esiste
            nomeFile = mGlobale.PercorsoRisultatiMaster & "\" & nomeRisultatoMaster & ".txt"
            If Not (File.Exists(nomeFile)) Then
                ' Apre il file
                sw = New StreamWriter(nomeFile)
                ' Scrive l'intestazione delle colonne
                sw.WriteLine(risultati.DataCollaudo.Descrizione &
                             vbTab & risultati.OraCollaudo.Descrizione &
                             vbTab & "Esito di collaudo" &
                             vbTab & risultati.PezzoRipassato.Descrizione &
                             vbTab & risultati.Val.Descrizione &
                             vbTab & risultati.Rheater.Descrizione &
                             vbTab & risultati.CorrenteRiscaldatore.Descrizione &
                             vbTab & risultati.ResistenzaIsolamento.Descrizione &
                             vbTab & risultati.Lsu_TemperaturaOperativa.Descrizione &
                             vbTab & risultati.Lsu_O2.Descrizione &
                             vbTab & risultati.Lsu_ResistenzaCalibrazione.Descrizione &
                             vbTab & risultati.ADVIp.Descrizione &
                             vbTab & risultati.ADVlambda.Descrizione &
                             vbTab & risultati.ZfasIpEtas.Descrizione &
                             vbTab & risultati.ZfasIpTB.Descrizione)
                ' Chiude il file
                sw.Close()
                sw = Nothing
            End If
            ' Apre il file
            sw = File.AppendText(nomeFile)
            ' Aggiunge la stringa di risultati
            sw.WriteLine(risultati.DataCollaudo.ValoreStringa &
                         vbTab & risultati.OraCollaudo.ValoreStringa &
                         vbTab & CInt(risultati.Esito) &
                         vbTab & risultati.PezzoRipassato.ValoreStringa &
                         vbTab & risultati.Val.ValoreStringa &
                         vbTab & risultati.Rheater.ValoreStringa &
                         vbTab & risultati.CorrenteRiscaldatore.ValoreStringa &
                         vbTab & risultati.ResistenzaIsolamento.ValoreStringa &
                         vbTab & risultati.Lsu_TemperaturaOperativa.ValoreStringa &
                         vbTab & risultati.Lsu_O2.ValoreStringa &
                         vbTab & risultati.Lsu_ResistenzaCalibrazione.ValoreStringa &
                         vbTab & risultati.ADVIp.ValoreStringa &
                         vbTab & risultati.ADVlambda.ValoreStringa &
                         vbTab & risultati.ZfasIpEtas.ValoreStringa &
                         vbTab & risultati.ZfasIpTB.ValoreStringa)
            ' Chiude il file
            sw.Close()
            sw = Nothing
            ' Restituisce False
            SalvaRisultatiMaster = False ' SalvaRisultatiMaster Or AggiornaExcelPezzoMaster(nomeRicettaMaster, nomeRisultatoMaster)

        Catch ex As Exception
            ' Chiude il file
            If (sw IsNot Nothing) Then
                sw.Close()
                sw = Nothing
            End If
            ' Restituisce True
            SalvaRisultatiMaster = True
        End Try
    End Function



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Function AggiornaExcelPezzoMaster(ByVal nomeRicettaMaster As String, ByVal nomeRisultatoMaster As String) As Boolean
        Dim app As Excel.Application
        Dim campo() As String
        Dim data As Date
        Dim linea As String
        Dim nomeFileExcel As String
        Dim percorsoCompleto As String
        Dim ricetta As New cRicetta
        Dim riga As Integer
        Dim risultati As New cRisultati
        Dim sr As StreamReader
        Dim workbook As Excel.Workbook
        Dim worksheet As Excel.Worksheet

        If (ricetta.Carica(nomeRicettaMaster)) Then
            MsgBox("Errore nel caricamento della ricetta.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If

        nomeFileExcel = mGlobale.PercorsoReportMaster & "\" & nomeRisultatoMaster & ".xls"
        percorsoCompleto = Path.GetFullPath(nomeFileExcel)
        Try
            ' Crea il file se non è già presente
            If (File.Exists(percorsoCompleto)) Then
                File.Delete(percorsoCompleto)
            End If
            File.Copy(mGlobale.PercorsoModelliReport & "\MA01946 - Report lotto.xls", nomeFileExcel, True)
            data = Date.Now
            ' Apre il file
            app = New Excel.Application
            workbook = app.Workbooks.Open(percorsoCompleto)
            worksheet = CType(workbook.Worksheets("Foglio1"), Excel.Worksheet)
            ' Scrive la voce MASTER
            worksheet.Cells(worksheet.Range("N4").Row, worksheet.Range("N4").Column).Value = "MASTER"
            ' Scrive la data
            worksheet.Cells(worksheet.Range("Q2").Row, worksheet.Range("R2").Column).Value = Format(Date.Now, "dd/MM/yyyy")
            ' Scrive il nome del file
            worksheet.Cells(worksheet.Range("Q3").Row, worksheet.Range("R3").Column).Value = nomeRisultatoMaster
            ' Scrive i parametri della ricetta
            worksheet.Cells(worksheet.Range("C11").Row, worksheet.Range("C11").Column).Value = (ricetta.Val_Min.Valore + ricetta.Val_Max.Valore) / 2
            worksheet.Cells(worksheet.Range("C12").Row, worksheet.Range("C12").Column).Value = "-" & Math.Round(((ricetta.Val_Min.Valore + ricetta.Val_Max.Valore) / 2 - ricetta.Val_Min.Valore), 2) &
                                                                                               "/+" & Math.Round((ricetta.Val_Max.Valore - (ricetta.Val_Min.Valore + ricetta.Val_Max.Valore) / 2), 2)
            worksheet.Cells(worksheet.Range("C13").Row, worksheet.Range("C13").Column).Value = ricetta.Val_Min.Valore
            worksheet.Cells(worksheet.Range("C14").Row, worksheet.Range("C14").Column).Value = ricetta.Val_Max.Valore
            '
            If (ricetta.Rheater_Abilitazione.Valore) Then
                worksheet.Cells(worksheet.Range("D11").Row, worksheet.Range("D11").Column).Value = (ricetta.Rheater_Min.Valore + ricetta.Rheater_Max.Valore) / 2
                worksheet.Cells(worksheet.Range("D12").Row, worksheet.Range("D12").Column).Value = "-" & ((ricetta.Rheater_Min.Valore + ricetta.Rheater_Max.Valore) / 2 - ricetta.Rheater_Min.Valore) &
                                                                                                   "/+" & (ricetta.Rheater_Max.Valore - (ricetta.Rheater_Min.Valore + ricetta.Rheater_Max.Valore) / 2)
                worksheet.Cells(worksheet.Range("D13").Row, worksheet.Range("D13").Column).Value = ricetta.Rheater_Min.Valore
                worksheet.Cells(worksheet.Range("D14").Row, worksheet.Range("D14").Column).Value = ricetta.Rheater_Max.Valore
            End If
            '
            If (ricetta.Lsu_Temperatura_Operativa_Abilitazione.Valore) Then
                worksheet.Cells(worksheet.Range("E11").Row, worksheet.Range("E11").Column).Value = (ricetta.Lsu_Temperatura_Operativa_Min.Valore + ricetta.Lsu_Temperatura_Operativa_Max.Valore) / 2
                worksheet.Cells(worksheet.Range("E12").Row, worksheet.Range("E12").Column).Value = "-" & ((ricetta.Lsu_Temperatura_Operativa_Min.Valore + ricetta.Lsu_Temperatura_Operativa_Max.Valore) / 2 - ricetta.Lsu_Temperatura_Operativa_Min.Valore) &
                                                                                                   "/+" & (ricetta.Lsu_Temperatura_Operativa_Max.Valore - (ricetta.Lsu_Temperatura_Operativa_Min.Valore + ricetta.Lsu_Temperatura_Operativa_Max.Valore) / 2)
                worksheet.Cells(worksheet.Range("E13").Row, worksheet.Range("E13").Column).Value = ricetta.Lsu_Temperatura_Operativa_Min.Valore
                worksheet.Cells(worksheet.Range("E14").Row, worksheet.Range("E14").Column).Value = ricetta.Lsu_Temperatura_Operativa_Max.Valore
            End If
            If (ricetta.Lsu_O2_Abilitazione.Valore) Then
                worksheet.Cells(worksheet.Range("F11").Row, worksheet.Range("F11").Column).Value = (ricetta.Lsu_O2_Min.Valore + ricetta.Lsu_O2_Max.Valore) / 2
                worksheet.Cells(worksheet.Range("F12").Row, worksheet.Range("F12").Column).Value = "-" & ((ricetta.Lsu_O2_Min.Valore + ricetta.Lsu_O2_Max.Valore) / 2 - ricetta.Lsu_O2_Min.Valore) &
                                                                                                   "/+" & (ricetta.Lsu_O2_Max.Valore - (ricetta.Lsu_O2_Min.Valore + ricetta.Lsu_O2_Max.Valore) / 2)
                worksheet.Cells(worksheet.Range("F13").Row, worksheet.Range("F13").Column).Value = ricetta.Lsu_O2_Min.Valore
                worksheet.Cells(worksheet.Range("F14").Row, worksheet.Range("F14").Column).Value = ricetta.Lsu_O2_Max.Valore
            End If
            If (ricetta.Corrente_Riscaldatore_Abilitazione.Valore) Then
                worksheet.Cells(worksheet.Range("G11").Row, worksheet.Range("G11").Column).Value = (ricetta.Corrente_Riscaldatore_Min.Valore + ricetta.Corrente_Riscaldatore_Max.Valore) / 2
                worksheet.Cells(worksheet.Range("G12").Row, worksheet.Range("G12").Column).Value = "-" & ((ricetta.Corrente_Riscaldatore_Min.Valore + ricetta.Corrente_Riscaldatore_Max.Valore) / 2 - ricetta.Corrente_Riscaldatore_Min.Valore) &
                                                                                                   "/+" & (ricetta.Corrente_Riscaldatore_Max.Valore - (ricetta.Corrente_Riscaldatore_Min.Valore + ricetta.Corrente_Riscaldatore_Max.Valore) / 2)
                worksheet.Cells(worksheet.Range("G13").Row, worksheet.Range("G13").Column).Value = ricetta.Corrente_Riscaldatore_Min.Valore
                worksheet.Cells(worksheet.Range("G14").Row, worksheet.Range("G14").Column).Value = ricetta.Corrente_Riscaldatore_Max.Valore
            End If
            If (ricetta.Lsu_Resistenza_Calibrazione_Abilitazione.Valore) Then
                worksheet.Cells(worksheet.Range("H11").Row, worksheet.Range("H11").Column).Value = (ricetta.Lsu_Resistenza_Calibrazione_Min.Valore + ricetta.Lsu_Resistenza_Calibrazione_Max.Valore) / 2
                worksheet.Cells(worksheet.Range("H12").Row, worksheet.Range("H12").Column).Value = "-" & ((ricetta.Lsu_Resistenza_Calibrazione_Min.Valore + ricetta.Lsu_Resistenza_Calibrazione_Max.Valore) / 2 - ricetta.Lsu_Resistenza_Calibrazione_Min.Valore) &
                                                                                                   "/+" & (ricetta.Lsu_Resistenza_Calibrazione_Max.Valore - (ricetta.Lsu_Resistenza_Calibrazione_Min.Valore + ricetta.Lsu_Resistenza_Calibrazione_Max.Valore) / 2)
                worksheet.Cells(worksheet.Range("H13").Row, worksheet.Range("H13").Column).Value = ricetta.Lsu_Resistenza_Calibrazione_Min.Valore
                worksheet.Cells(worksheet.Range("H14").Row, worksheet.Range("H14").Column).Value = ricetta.Lsu_Resistenza_Calibrazione_Max.Valore
            End If
            If (ricetta.Resistenza_Isolamento_Abilitazione.Valore) Then

                worksheet.Cells(worksheet.Range("I13").Row, worksheet.Range("I13").Column).Value = ricetta.Resistenza_Isolamento_Min.Valore
            End If
            ' Si apre il file di risultati dei pezzi master
            sr = New StreamReader(mGlobale.PercorsoRisultatiMaster & "\" & nomeRisultatoMaster & ".txt")
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
                risultati.Lsu_TemperaturaOperativa.Valore = campo(6)
                risultati.Lsu_O2.Valore = campo(7)
                risultati.CorrenteRiscaldatore.Valore = campo(8)
                risultati.Lsu_ResistenzaCalibrazione.Valore = campo(9)
                risultati.ResistenzaIsolamento.Valore = campo(10)
                ' Inserisce i risultati nel report
                worksheet.Cells(15 + riga, 1).Value = risultati.DataCollaudo.Valore
                worksheet.Cells(15 + riga, 2).Value = risultati.OraCollaudo.Valore
                worksheet.Cells(15 + riga, 3).Value = risultati.Val.Valore
                If (ricetta.Rheater_Abilitazione.Valore) Then
                    worksheet.Cells(15 + riga, 4).Value = risultati.Rheater.Valore
                End If
                If (ricetta.Lsu_Temperatura_Operativa_Abilitazione.Valore) Then
                    worksheet.Cells(15 + riga, 5).Value = risultati.Lsu_TemperaturaOperativa.Valore
                End If
                If (ricetta.Lsu_O2_Abilitazione.Valore) Then
                    worksheet.Cells(15 + riga, 6).Value = risultati.Lsu_O2.Valore
                End If
                If (ricetta.Corrente_Riscaldatore_Abilitazione.Valore) Then
                    worksheet.Cells(15 + riga, 7).Value = risultati.CorrenteRiscaldatore.Valore
                End If
                If (ricetta.Lsu_Resistenza_Calibrazione_Abilitazione.Valore) Then
                    worksheet.Cells(15 + riga, 8).Value = risultati.Lsu_ResistenzaCalibrazione.Valore
                End If
                If (ricetta.Resistenza_Isolamento_Abilitazione.Valore) Then
                    worksheet.Cells(15 + riga, 9).Value = risultati.ResistenzaIsolamento.Valore
                End If
                worksheet.Cells(15 + riga, 14).Value = IIf(risultati.PezzoRipassato.Valore, "SI", "NO")
                worksheet.Cells(15 + riga, 15).Value = EsitoFACET(risultati.Esito)
                worksheet.Rows(16 + riga).Insert()
                riga = riga + 1
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
            AggiornaExcelPezzoMaster = False
        Catch ex As Exception
            ' Setta il flag d'errore
            AggiornaExcelPezzoMaster = True
        End Try

    End Function

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
End Class
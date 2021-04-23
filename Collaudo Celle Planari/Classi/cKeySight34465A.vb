Option Explicit On
Option Strict On

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class cKeySight34465A
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    ' Costanti pronte
    Private Const _dimensioniBuffer = 100
    Private Const _inizioIdentificatore = "Keysight Technologies,34465A"

    ' Variabili private
    Private _client As TcpClient
    Private _connesso As Boolean
    Private _indirizzoIP As String
    Private _numeroPorta As Integer
    Private _stream As NetworkStream



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function ClearStatus() As Boolean
        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Esegue il comando
            ClearStatus = EseguiComando("*CLS", False)
        Else    ' Altrimenti, se lo strumento non è connesso
            ' Restituisce True
            ClearStatus = True
        End If
    End Function



    Public Function Connetti(ByVal indirizzoIP As String,
                             ByVal numeroPorta As Integer) As Boolean
        Dim identificatore As String = ""
        Dim t0 As Date

        ' Memorizza l'indirizzo IP ed il numero di porta
        _indirizzoIP = indirizzoIP
        _numeroPorta = numeroPorta
        Try
            ' Crea il client ed effettua la connessione
            _client = New TcpClient
            _client.Connect(_indirizzoIP, _numeroPorta)
            _stream = _client.GetStream
            ' Setta il flag di strumento connesso
            _connesso = True
            ' Resetta il registro di stato dello strumento
            Connetti = ClearStatus()
            ' Ritardo 50 ms
            Do
            Loop Until ((Date.Now - t0).TotalMilliseconds >= 50)
            ' Legge e verifica l'identificatore dello strumento
            Connetti = Connetti Or LeggiIdentificatore(identificatore)
            Connetti = Connetti Or Not (identificatore.StartsWith(_inizioIdentificatore))

        Catch ex As Exception
            ' Chiude e cancella gli oggetti per la comunicazione
            If (_stream IsNot Nothing) Then
                _stream.Close()
                _stream = Nothing
            End If
            If (_client IsNot Nothing) Then
                _client.Close()
                _client = Nothing
            End If
            ' Resetta il flag di strumento connesso
            _connesso = False
            ' Restituisce True
            Connetti = True
        End Try
    End Function



    Public Function Disconnetti() As Boolean
        Try
            ' Resetta lo strumento
            Disconnetti = Reset()
            ' Chiude e cancella gli oggetti per la comunicazione
            If (_stream IsNot Nothing) Then
                _stream.Close()
                _stream = Nothing
            End If
            If (_client IsNot Nothing) Then
                _client.Close()
                _client = Nothing
            End If
            ' Resetta il flag di strumento connesso
            _connesso = False

        Catch ex As Exception
            ' Restituisce True
            Disconnetti = True
        End Try
    End Function



    Public Function LeggiIdentificatore(ByRef identificatore As String) As Boolean
        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Esegue il comando
            LeggiIdentificatore = EseguiComando("*IDN?", True, 1, identificatore)
        Else    ' Altrimenti, se lo strumento non è connesso
            ' Restituisce True
            LeggiIdentificatore = True
        End If
    End Function



    Public Function MisuraCorrenteDC(ByVal risoluzione As Single, ByRef valore As Double) As Boolean
        Dim risposta As String = ""

        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Esegue il comando
            MisuraCorrenteDC = EseguiComando("MEAS:CURR:DC? " & risoluzione.ToString(CultureInfo.CreateSpecificCulture("en-US")), True, 3, risposta)
            If Not (MisuraCorrenteDC) Then
                valore = Val(risposta)
            Else
                valore = 0
            End If
        Else ' Altrimenti se los trumento non è connesso
            ' Restituisce True
            MisuraCorrenteDC = True
        End If
    End Function



    Public Function MisuraResistenza4Fili(ByRef valore As Double) As Boolean
        Dim risposta As String = ""

        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Esegue il comando
            MisuraResistenza4Fili = EseguiComando("MEAS:FRES? 100", True, 3, risposta)
            If Not (MisuraResistenza4Fili) Then
                valore = Val(risposta)
            Else
                valore = 0
            End If
        Else ' Altrimenti se los trumento non è connesso
            ' Restituisce True
            MisuraResistenza4Fili = True
        End If
    End Function



    Public Function MisuraTemperatura(ByRef valore As Double) As Boolean
        Dim risposta As String = ""

        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Esegue il comando
            MisuraTemperatura = EseguiComando("MEAS:TEMP? FRTD,85", True, 3, risposta)
            If Not (MisuraTemperatura) Then
                valore = Val(risposta) '+ CDbl(ImpostazioniAvanzate.OffsetMisuraTamb.Valore)
            Else
                valore = 0
            End If
        Else    ' Altrimenti, se lo strumento non è connesso
            ' Restituisce True
            MisuraTemperatura = True
        End If
    End Function



    Public Function MisuraTensioneAC(ByRef valore As Double) As Boolean
        Dim risposta As String = ""

        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Esegue il comando
            MisuraTensioneAC = EseguiComando("MEAS:VOLT:AC? 10, 0.001", True, 3, risposta)
            If Not (MisuraTensioneAC) Then
                valore = Val(risposta)
            Else
                valore = 0
            End If
        Else    ' Altrimenti, se lo strumento non è connesso
            ' Restituisce True
            MisuraTensioneAC = True
        End If
    End Function



    Public Function MisuraTensioneDC(ByRef valore As Double) As Boolean
        Dim risposta As String = ""

        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Esegue il comando
            MisuraTensioneDC = EseguiComando("MEAS:VOLT:DC? 100, 0.001", True, 3, risposta)
            If Not (MisuraTensioneDC) Then
                valore = Val(risposta)
            Else
                valore = 0
            End If
        Else    ' Altrimenti, se lo strumento non è connesso
            ' Restituisce True
            MisuraTensioneDC = True
        End If
    End Function



    Public Function Reset() As Boolean
        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Esegue il comando
            Reset = EseguiComando("*RST", False)
        Else    ' Altrimenti, se lo strumento non è connesso
            ' Restituisce True
            Reset = True
        End If
    End Function



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Function EseguiComando(ByVal comando As String,
                                   ByVal conRisposta As Boolean,
                                   Optional timeoutRisposta As Integer = 1,
                                   Optional ByRef risposta As String = "") As Boolean
        Dim bufferRx(0 To _dimensioniBuffer - 1) As Byte
        Dim bufferTx(0 To _dimensioniBuffer - 1) As Byte
        Dim numeroCaratteriRicevuti As Integer
        Dim rispostaRicevuta As Boolean
        Dim t0 As Date

        ' Se lo strumento è connesso
        If (_connesso) Then
            Try
                ' Svuota il buffer di ricezione
                If (_stream.DataAvailable) Then
                    _stream.Read(bufferRx, 0, _dimensioniBuffer)
                End If
                ' Converte il comando da stringa a vettore di byte
                bufferTx = System.Text.Encoding.ASCII.GetBytes(comando & vbLf)
                ' Trasmette il comando
                _stream.Write(bufferTx, 0, bufferTx.Length)
                ' Se il comando prevede risposta
                If (conRisposta) Then
                    ' Attende la risposta
                    numeroCaratteriRicevuti = 0
                    t0 = Date.Now
                    Do
                        If (_stream.DataAvailable) Then
                            numeroCaratteriRicevuti += _stream.Read(bufferRx, numeroCaratteriRicevuti, _dimensioniBuffer - numeroCaratteriRicevuti)
                        End If
                        rispostaRicevuta = (numeroCaratteriRicevuti > 1 AndAlso bufferRx(numeroCaratteriRicevuti - 1) = 10)
                    Loop Until (rispostaRicevuta Or (Date.Now - t0).TotalSeconds > timeoutRisposta)
                    ' Se è stata ricevuta la risposta
                    If (rispostaRicevuta) Then
                        ' Converte la risposta da vettore di byte a stringa
                        risposta = System.Text.Encoding.ASCII.GetString(bufferRx, 0, numeroCaratteriRicevuti - 1)
                    End If
                    ' Restituisce False
                    EseguiComando = False
                Else    ' Altrimenti, se il comando non prevede risposta
                    ' Restituisce False
                    EseguiComando = False
                End If

            Catch ex As Exception   ' If some unexpected errors happened
                ' Restituisce True
                EseguiComando = True
            End Try
        Else    ' Altrimenti, se lo strumento non è connesso
            ' Restituisce True
            EseguiComando = True
        End If
    End Function
End Class

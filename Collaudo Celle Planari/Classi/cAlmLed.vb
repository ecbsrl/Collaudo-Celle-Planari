Option Explicit On
Option Strict On

Imports System.IO.Ports

Public Class cAlmLed
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+

    'Costanti Pronte
    Private Const _timeoutStrumentoPronto = 0.1 ' s
    Private Const _timeoutRisposta_ms = 500

    'Variabili Private
    Private _connesso As Boolean
    Private _portaSeriale As SerialPort
    Private _misurazioneLambda As Double
    Private _misurazioneTemperatura As Double
    Private _misurazioneO2 As Double
    Private _errore(8) As Integer



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public ReadOnly Property ValoreLambda As Double
        Get
            ValoreLambda = _misurazioneLambda
        End Get
    End Property



    Public ReadOnly Property Temperatura As Double
        Get
            Temperatura = _misurazioneTemperatura
        End Get
    End Property



    Public ReadOnly Property O2 As Double
        Get
            O2 = _misurazioneO2
        End Get
    End Property



    Public ReadOnly Property CodiceErrore(ByVal index As Integer) As String
        Get
            Select Case _errore(index)
                Case 1
                    CodiceErrore = "Internal Communication Error"
                Case 2
                    CodiceErrore = "Internal Register Error"
                Case 3
                    CodiceErrore = "LSU Yellow Wire Short To Power"
                Case 4
                    CodiceErrore = "LSU Yellow Wire Short To GND"
                Case 5
                    CodiceErrore = "LSU Black Wire Short To Power"
                Case 6
                    CodiceErrore = "LSU Black Wire Short To GND"
                Case 7
                    CodiceErrore = "LSU Green Wire Short To Power"
                Case 8
                    CodiceErrore = "LSU Green Wire Short To GND"
                Case 9
                    CodiceErrore = "Operating Voltage Too Low"
                Case 10
                    CodiceErrore = "Heater Circuit Damaged"
                Case 11
                    CodiceErrore = "Heater Circuit Short to Power"
                Case 12
                    CodiceErrore = "Heater Circuit Short to GND"
                Case Else
                    CodiceErrore = "OK"
            End Select
        End Get
    End Property



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function ArrestaMisurazione() As Boolean
        ' Creo l'array di byte da inviare alla porta seriale
        Dim comando() As Byte = {&H80, &H8F, &HEA, &H3, &H9C, &H9, &H0, &HA1}
        'se lo strumento è connesso
        If (_connesso) Then
            'Esegue il comando
            ArrestaMisurazione = EseguiComando(comando, False)
        Else    'nel caso lo strumento non fosse connesso
            'restituisce true
            ArrestaMisurazione = True
        End If
    End Function



    Public Function AvviaMisurazione() As Boolean
        ' Creo l'array di byte da inviare alla porta seriale
        Dim comando() As Byte = {&H80, &H8F, &HEA, &H3, &H9C, &HD, &H0, &HA5}
        'se lo strumento è connesso
        If (_connesso) Then
            'Esegue il comando
            AvviaMisurazione = EseguiComando(comando, True)
        Else    'nel caso lo strumento non fosse connesso
            'restituisce true
            AvviaMisurazione = True
        End If
    End Function



    Public Function Connetti(ByVal portaSeriale As String,
                             ByVal baudrate As Integer) As Boolean

        Dim identificatore As String = ""
        Dim t0 As Date

        Try
            ' Crea, configura ed apre la porta seriale
            _portaSeriale = New SerialPort
            _portaSeriale.PortName = portaSeriale
            _portaSeriale.BaudRate = baudrate
            _portaSeriale.DataBits = 8
            _portaSeriale.Parity = Parity.None
            _portaSeriale.StopBits = StopBits.One
            _portaSeriale.Handshake = Handshake.None
            _portaSeriale.DtrEnable = True
            _portaSeriale.RtsEnable = True
            _portaSeriale.NewLine = vbLf
            _portaSeriale.Open()
            ' Setta il flag di strumento connesso
            _connesso = True
            ' Resetta il registro di stato dello strumento
            Connetti = False
            ' Ritardo 50 ms
            Do
            Loop Until ((Date.Now - t0).TotalMilliseconds >= 50)
            ' Attiva il controllo remoto
            'Connetti = Connetti Or attivaTriggerEsterno()
            'Connetti = False
            ' Ritardo 50 ms
            Do
            Loop Until ((Date.Now - t0).TotalMilliseconds >= 50)
            ' Legge e verifica l'identificatore dello strumento
            Connetti = Connetti Or LeggiIdentificatore()

        Catch ex As Exception
            ' Chiude e cancella l'oggetto porta seriale
            If (_portaSeriale IsNot Nothing) Then
                _portaSeriale.Close()
                _portaSeriale = Nothing
            End If
            ' Resetta il flag di strumento connesso
            _connesso = False
            ' Restituisce True
            Connetti = True
        End Try
    End Function



    Public Function Disconnetti() As Boolean
        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Chiude e cancella l'oggetto porta seriale
            _portaSeriale.Close()
            _portaSeriale = Nothing
            ' Resetta il flag di strumento connesso
            _connesso = False
            Disconnetti = False
        Else    ' Altrimenti, se lo strumento non è connesso
            ' Restituisce False
            Disconnetti = False
        End If
    End Function



    Public Function LeggiErrore() As Boolean
        ' Creo l'array di byte da inviare alla porta seriale
        Dim comando() As Byte = {&H80, &H8F, &HEA, &H3, &H9C, &HB, &H0, &HA3}
        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Esegue il comando
            LeggiErrore = EseguiComando(comando, True)
        Else    ' Altrimenti, se lo strumento non è connesso
            ' Restituisce True
            LeggiErrore = True
        End If
    End Function



    Public Function LeggiIdentificatore() As Boolean
        ' Creo l'array di byte da inviare alla porta seriale
        Dim comando() As Byte = {&H80, &H8F, &HEA, &H3, &H9C, &H1, &H0, &H99}
        ' Se lo strumento è connesso
        If (_connesso) Then
            ' Esegue il comando
            LeggiIdentificatore = EseguiComando(comando, True)
        Else    ' Altrimenti, se lo strumento non è connesso
            ' Restituisce True
            LeggiIdentificatore = True
        End If
    End Function



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Function EseguiComando(ByVal comando() As Byte,
                                   ByVal conRisposta As Boolean,
                                   Optional timeoutRisposta As Integer = 1,
                                   Optional risposta As String = "") As Boolean
        Dim ready As Boolean
        Dim timeout As Boolean
        Dim t0 As Date
        Dim byteRx(0 To 50) As Byte

        Try
            t0 = Date.Now
            ' Attende che lo strumento sia pronto a ricevere
            Do
                ready = _portaSeriale.DsrHolding
                timeout = ((Date.Now - t0).TotalSeconds > _timeoutStrumentoPronto)
            Loop Until (ready Or timeout)
            ' Se lo strumento è pronto a ricevere
            If (True) Then
                ' Svuota i buffer d'ingresso e uscita
                _portaSeriale.DiscardInBuffer()
                _portaSeriale.DiscardOutBuffer()
                ' Imposta il timeout di risposta
                _portaSeriale.ReadTimeout = timeoutRisposta * 1000
                ' Trasmette il comando
                _portaSeriale.Write(comando, 0, comando.Length)
                ' Se il comando prevede risposta
                If (conRisposta) Then
                    t0 = Date.Now
                    EseguiComando = True
                    Do
                    Loop Until (_portaSeriale.BytesToRead >= 15 Or (Date.Now - t0).TotalMilliseconds > _timeoutRisposta_ms)
                    ' Se i caratteri attesi sono stati ricevuti
                    If (_portaSeriale.BytesToRead >= 21) Then
                        _portaSeriale.Read(byteRx, 0, 22)
                        EseguiComando = False
                    Else
                        EseguiComando = True
                    End If
                    Select Case comando(7)
                        Case &HA5
                            ' Se il checksum è A5 effettuo misurazione
                            _misurazioneLambda = ((byteRx(6) * 256 + byteRx(7)) / 1000)
                            _misurazioneTemperatura = ((byteRx(16) * 256 + byteRx(17)) * 0.023438 - 273)
                            _misurazioneO2 = ((byteRx(20) * 256 + byteRx(21)) / 1024)
                        Case &HA3
                            ' Se il checksum è A3 verifico la presenza di un errore
                            _errore(0) = byteRx(12)
                            _errore(1) = byteRx(11)
                            _errore(2) = byteRx(10)
                            _errore(3) = byteRx(9)
                            _errore(4) = byteRx(8)
                            _errore(5) = byteRx(7)
                            _errore(6) = byteRx(6)
                        Case Else
                            ' Altrimenti verifico che il dispositivo connesso sia effettivamente la sonda
                            For i = 0 To 2
                                If (comando(i) <> byteRx(i)) Then
                                    EseguiComando = True
                                End If
                            Next
                    End Select
                Else    ' Altrimenti, se il comando non prevede risposta
                    ' Restituisce False
                    EseguiComando = False
                End If
            Else    ' Altrimenti, se lo strumento non è pronto a ricevere
                ' Restituisce True
                EseguiComando = True
            End If

        Catch ex As Exception
            ' Restituisce True
            EseguiComando = True
        End Try
    End Function
End Class

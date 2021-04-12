Option Explicit On
Option Strict On

Imports System.IO.Ports

Public Class cBurkertMFC8711
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Costanti private
    Private Const _timeoutRisposta_ms = 500

    ' Variabili private
    Private _indirizzo As Byte
    Private _fondoscala As Double
    Private _decimali As Byte
    Private _portaseriale As SerialPort

    ' Riferimenti esterni
    Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByVal pDst As IntPtr,
                                                                 ByVal pSrc As String,
                                                                 ByVal ByteLen As Long)



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public ReadOnly Property FondoScala As Double
        Get
            FondoScala = _fondoscala
        End Get
    End Property


    '+------------------------------------------------------------------------------+
    '|                          Costruttore e distruttore                           |
    '+------------------------------------------------------------------------------+
    Public Sub New(ByVal fondoscala As Double, ByVal decimali As Byte)
        ' Memorizza il valore di fondoscala e i decimali di risoluzione
        _fondoscala = fondoscala
        _decimali = decimali
    End Sub






    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function Connetti(ByVal portaSeriale As String, ByVal indirizzo As Byte, ByVal id As Long) As Boolean
        Dim identificatore As Long

        Try
            ' Memorizza l'indirizzo del sensore e il fondo scala
            _indirizzo = indirizzo
            ' Crea, configura ed apre la porta seriale
            _portaseriale = New SerialPort
            _portaseriale.PortName = portaSeriale
            _portaseriale.BaudRate = 9600
            _portaseriale.DataBits = 8
            _portaseriale.StopBits = StopBits.One
            _portaseriale.Parity = Parity.None
            _portaseriale.Handshake = Handshake.None
            _portaseriale.NewLine = vbCr
            _portaseriale.ReadTimeout = _timeoutRisposta_ms
            _portaseriale.Open()
            ' Legge l'identificatore
            identificatore = 0
            Connetti = Me.LeggiIdentificatore(identificatore)
            Connetti = Connetti OrElse Not (identificatore = id)

        Catch ex As Exception
            ' Cancella l'oggetto porta seriale
            _portaseriale = Nothing
            ' Restituisce True
            Connetti = True
        End Try
    End Function



    Public Function Disconnetti() As Boolean
        Try
            ' Chiude la porta seriale e cancella l'oggetto
            _portaseriale.Close()
            _portaseriale = Nothing
            ' Restituisce False
            Disconnetti = False

        Catch ex As Exception
            ' Restituisce True
            Disconnetti = True
        End Try
    End Function



    Public Function LeggiIdentificatore(ByRef identificatore As Long) As Boolean
        Dim status As Integer
        Dim dati(0 To 99) As Byte
        Dim device_status As Integer
        Dim manufacturer_identification_code As Integer
        Dim manufacturer_device_type_code As Integer
        Dim preambles_required As Integer
        Dim universal_command_rev As Integer
        Dim device_specific_command_rev As Integer
        Dim SW_rev As Integer
        Dim HW_rev As Integer
        Dim device_function_flags As Integer
        Dim device_ID_number As Long

        Try
            ' Cancellazione buffer di ricezione
            _portaseriale.DiscardInBuffer()
            ' Trasmette il comando
            If TxComando_0_ReadUniqueldentifier() = False Then
                ' Se la risposta è stata ricevuta
                If AttesaRispostaShort(12, 0, status, dati) = False Then
                    ' Se il primo byte è conforme (254 = Expansion)
                    If dati(0) = 254 Then
                        ' Estrazione dei dati
                        device_status = status
                        manufacturer_identification_code = dati(1)
                        manufacturer_device_type_code = dati(2)
                        preambles_required = dati(3)
                        universal_command_rev = dati(4)
                        device_specific_command_rev = dati(5)
                        SW_rev = dati(6)
                        HW_rev = dati(7)
                        device_function_flags = dati(8)
                        device_ID_number = dati(9) * 65535 + dati(10) * 256 + dati(11)
                        ' Restituzione identificatore
                        identificatore = device_ID_number
                        ' Restituisce False
                        LeggiIdentificatore = False
                    Else
                        ' Restituisce True
                        LeggiIdentificatore = True
                    End If
                Else
                    LeggiIdentificatore = True
                End If
            Else
                ' Restituisce True
                LeggiIdentificatore = True
            End If

        Catch ex As Exception
            ' Restituisce True
            LeggiIdentificatore = True
        End Try
    End Function



    Public Function LeggiMisura(ByRef misura As Double, Optional ByRef unitàmisura As String = "") As Boolean
        Dim status As Integer
        Dim dati(0 To 99) As Byte
        Dim byteMV(3) As Byte
        Dim MV As Single

        Try
            ' Cancellazione buffer di ricezione
            _portaseriale.DiscardInBuffer()
            ' Trasmette il comando
            If TxComando_1_ReadPrimaryVariable() = False Then
                ' Se la risposta è stata ricevuta
                If AttesaRispostaShort(5, 1, status, dati) = False Then
                    ' Estrazione dati e conversione in floating point (misura in percentuale del fondo scala)
                    byteMV(3) = dati(1)
                    byteMV(2) = dati(2)
                    byteMV(1) = dati(3)
                    byteMV(0) = dati(4)
                    MV = BitConverter.ToSingle(byteMV, 0)
                    ' Restituzione valore misura 
                    misura = Math.Round(MV, _decimali)
                    ' Restituzione unità di misura
                    Select Case dati(0)
                        Case 57
                            unitàmisura = "%"
                        Case 167
                            unitàmisura = "Nl"
                    End Select
                    ' Restituisce False
                    LeggiMisura = False
                Else
                    ' Restituisce True e misura 0
                    LeggiMisura = True
                    misura = 0
                End If
            Else
                ' Restituisce True e misura 0
                LeggiMisura = True
                misura = 0
            End If

        Catch ex As Exception
            ' Restituisce True e misura 0
            LeggiMisura = True
            misura = 0
        End Try
    End Function



    Public Function LeggiMisuraNl(ByRef portata As Double) As Boolean
        Dim misura As Double

        Try
            ' Legge la misura percentuale
            If LeggiMisura(misura) = False Then
                ' Restituisce False la misura in litri/minuto
                LeggiMisuraNl = False
                portata = Math.Round(misura / 100 * _fondoscala, _decimali)
            Else
                ' Restituisce True e portata 0
                LeggiMisuraNl = True
                portata = 0
            End If

        Catch ex As Exception
            ' Restituisce True e portata 0
            LeggiMisuraNl = True
            portata = 0
        End Try
    End Function



    Public Function SetPortata(ByVal Setpoint As Single) As Boolean
        'Dim SP As Single
        Dim dati(5) As Byte
        Dim bytesSP(4) As Byte
        Try
            ' Svuoto il buffer in ricezione
            _portaseriale.DiscardInBuffer()
            ' Limitazione setpoint
            If Setpoint < 0 Then Setpoint = 0
            If Setpoint > 100 Then Setpoint = 100
            ' Conversione del setpoint in floating point su 4 bytes
            'SP = Setpoint
            bytesSP = BitConverter.GetBytes(Setpoint)
            dati(0) = 1
            dati(1) = bytesSP(3)
            dati(2) = bytesSP(2)
            dati(3) = bytesSP(1)
            dati(4) = bytesSP(0)
            TrasmissioneComandoShort(&H98, dati)
            SetPortata = False
        Catch ex As Exception
            ' Restituisce True
            SetPortata = True
        End Try
    End Function



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Function Checksum(ByVal comando() As Byte) As Byte
        Dim a As Integer
        Dim cs As Byte

        For a = LBound(comando) To UBound(comando)
            cs = cs Xor comando(a)
        Next
        Checksum = cs
    End Function



    Private Function TxComando_0_ReadUniqueldentifier() As Boolean
        Dim byteComando(3) As Byte
        Dim byteTx(6) As Byte

        Try
            ' Definizione comando
            byteComando(0) = &H2
            byteComando(1) = CByte(&H80 + _indirizzo)
            byteComando(2) = &H0
            byteComando(3) = &H0
            ' Definizione pacchetto dati secondo protocollo
            byteTx(0) = &HFF
            byteTx(1) = &HFF
            byteTx(2) = byteComando(0)
            byteTx(3) = byteComando(1)
            byteTx(4) = byteComando(2)
            byteTx(5) = byteComando(3)
            byteTx(6) = Checksum(byteComando)
            ' Trasmissione pacchetto dati
            _portaseriale.Write(byteTx, 0, 7)
            ' Restituisce False
            TxComando_0_ReadUniqueldentifier = False

        Catch ex As Exception
            ' Restituisce True
            TxComando_0_ReadUniqueldentifier = True
        End Try
    End Function



    Private Function TxComando_1_ReadPrimaryVariable() As Boolean
        Dim byteComando(3) As Byte
        Dim byteTx(6) As Byte

        Try
            ' Definizione comando
            byteComando(0) = &H2
            byteComando(1) = CByte(&H80 + _indirizzo)
            byteComando(2) = &H1
            byteComando(3) = &H0
            ' Definizione pacchetto dati secondo protocollo
            byteTx(0) = &HFF
            byteTx(1) = &HFF
            byteTx(2) = byteComando(0)
            byteTx(3) = byteComando(1)
            byteTx(4) = byteComando(2)
            byteTx(5) = byteComando(3)
            byteTx(6) = Checksum(byteComando)
            ' Trasmissione pacchetto dati
            _portaseriale.Write(byteTx, 0, 7)
            ' Restituisce False
            TxComando_1_ReadPrimaryVariable = False

        Catch ex As Exception
            ' Restituisce True
            TxComando_1_ReadPrimaryVariable = True
        End Try
    End Function



    Private Function TrasmissioneComandoShort(ByVal Comando As Byte, ByVal Dati() As Byte) As Boolean
        Dim byteStringa(9) As Byte
        Dim byteTX(12) As Byte

        Try
            ' Preparo l'array con il dato da trasmettere
            byteStringa(0) = &H2
            byteStringa(1) = CByte(&H80 + _indirizzo)
            byteStringa(2) = Comando
            byteStringa(3) = 5
            byteStringa(4) = Dati(0)
            byteStringa(5) = Dati(1)
            byteStringa(6) = Dati(2)
            byteStringa(7) = Dati(3)
            byteStringa(8) = Dati(4)
            ' Preparo l'array con l'intero protocollo
            byteTX(0) = &HFF
            byteTX(1) = &HFF
            byteTX(2) = byteStringa(0)
            byteTX(3) = byteStringa(1)
            byteTX(4) = byteStringa(2)
            byteTX(5) = byteStringa(3)
            byteTX(6) = byteStringa(4)
            byteTX(7) = byteStringa(5)
            byteTX(8) = byteStringa(6)
            byteTX(9) = byteStringa(7)
            byteTX(10) = byteStringa(8)
            byteTX(11) = Checksum(byteStringa)
            ' Trasmissione array
            _portaseriale.Write(byteTX, 0, 12)
            TrasmissioneComandoShort = False
        Catch ex As Exception
            ' Restituisce True
            TrasmissioneComandoShort = True
        End Try

    End Function



    Private Function AttesaRispostaShort(ByVal byteAttesi As Byte, ByVal comando As Byte, ByRef status As Integer, ByRef Dati() As Byte) As Boolean
        Dim t0 As Date
        Dim byteRx(0 To 99) As Byte
        Dim a As Byte

        Try
            ' Attende la risposta
            t0 = Date.Now
            Do
            Loop Until (_portaseriale.BytesToRead >= byteAttesi + 9 Or (Date.Now - t0).TotalMilliseconds > _timeoutRisposta_ms)
            ' Se i caratteri attesi sono stati ricevuti
            If (_portaseriale.BytesToRead = byteAttesi + 9) Then
                _portaseriale.Read(byteRx, 0, _portaseriale.BytesToRead)
                ' Se l'header della risposta è coerente
                If (byteRx(0) = &HFF) And
                    (byteRx(1) = &HFF) And
                    (byteRx(2) = &H6) And
                    (byteRx(3) = CByte(&H80 + _indirizzo)) And
                    (byteRx(4) = comando) And
                    (byteRx(5) = CByte(byteAttesi + 2)) Then
                    ' Restituzione status e dati
                    status = byteRx(6) * 256 + byteRx(7)
                    For a = 0 To CByte(byteAttesi - 1)
                        Dati(a) = byteRx(8 + a)
                    Next
                    ' Restituisce False
                    AttesaRispostaShort = False
                Else
                    ' Restituisce True
                    AttesaRispostaShort = True
                End If
            Else
                AttesaRispostaShort = True
            End If

        Catch ex As Exception
            ' Restituisce True
            AttesaRispostaShort = True
        End Try
    End Function
End Class




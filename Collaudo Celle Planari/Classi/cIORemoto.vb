Option Explicit On
Option Strict On

Imports System.Threading
Imports System.Timers.Timer

Public Class cIORemoto
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    ' Enumerazione ingressi
    Public Enum eIngresso
        I00_PressostatoAria1 = 0
        I01_PressostatoAria2 = 1
        I02_PressostatoAzoto = 2
        I03 = 3
        I04 = 4
        I05 = 5
        I06_Emergenza = 6
        I07_Ausiliari = 7
        I10_BtnAvvioCiclo = 8
        I11_BtnScarto = 9
        I12_BtnReset = 10
        I13 = 11
        I14 = 12
        I15 = 13
        I16 = 14
        I17_SensorePresScarto = 15
        I20_CodPiastra1 = 16
        I21_CodPiastra2 = 17
        I22_CodPiastra4 = 18
        I23_FcCampanaAlta = 19
        I24_FcCampanaBassa = 20
        I25_FcPinzaAperta = 21
        I26_FcPinzaChiusa = 22
        I27_SensorePresPz = 23
    End Enum



    ' Enumerazione uscite
    Public Enum eUscita
        U00_DiscesaCampana = 0
        U01_SalitaCampana = 1
        U02_ChiusuraPinza = 2
        U03_AperturaPinza = 3
        U04_OnRaffreddamento = 4
        U05 = 5
        U06_LedRossiAvvio = 6
        U07_LedVerdiAvvio = 7
        U10_LampBuono = 8
        U11_LampScarto = 9
        U12_Cicalino = 10
        U13_RelèMis13VS = 11
        U14_RelèMisRiscaldatore = 12
        U15_RelèMisuraO2 = 13
        U16_RelèConnCellaLD = 14
        U17_RelèRiscaldatoreLD = 15
        U20_RelèConnDirettaLD = 16
        U21_RelèVoltmetroLD = 17
        U22_RelèConnCellaNTK = 18
        U23_RelèConnCellaPinIpNTK = 19
        U24_RelèRiscaldatoreNTK = 20
        U25_RelèConnDirettaNTK = 21
        U26_RelèAmperometroPinIpNTK = 22
        U27_RelèMisuraIsolamento = 23
    End Enum



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Costanti private
    Private Const _numeroIngressi = 24
    Private Const _numeroUscite = 25

    ' Variabili private
    Private _slio As cSLIO
    Private _statoIngresso(0 To _numeroIngressi - 1) As Boolean
    Private _statoUscita(0 To _numeroUscite - 1) As Boolean



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public ReadOnly Property DescrizioneIngresso(ByVal indice As eIngresso) As String
        Get
            Select Case indice
                Case eIngresso.I00_PressostatoAria1
                    DescrizioneIngresso = "I0.0 - Pressostato Aria 1"
                Case eIngresso.I01_PressostatoAria2
                    DescrizioneIngresso = "I0.1 - Pressostato Aria 2"
                Case eIngresso.I02_PressostatoAzoto
                    DescrizioneIngresso = "I0.2 - Pressostato Azoto"
                Case eIngresso.I03
                    DescrizioneIngresso = "I0.3 - Riserva"
                Case eIngresso.I04
                    DescrizioneIngresso = "I0.4 - Riserva"
                Case eIngresso.I05
                    DescrizioneIngresso = "I0.5 - Riserva"
                Case eIngresso.I06_Emergenza
                    DescrizioneIngresso = "I0.6 - Emergenza"
                Case eIngresso.I07_Ausiliari
                    DescrizioneIngresso = "I0.7 - Ausiliari"
                Case eIngresso.I10_BtnAvvioCiclo
                    DescrizioneIngresso = "I1.0 - Pulsante Avvio Ciclo"
                Case eIngresso.I11_BtnScarto
                    DescrizioneIngresso = "I1.1 - Pulsante Scarto"
                Case eIngresso.I12_BtnReset
                    DescrizioneIngresso = "I1.2 - Pulsante Reset"
                Case eIngresso.I13
                    DescrizioneIngresso = "I1.3 - Riserva"
                Case eIngresso.I14
                    DescrizioneIngresso = "I1.4 - Riserva"
                Case eIngresso.I15
                    DescrizioneIngresso = "I1.5 - Riserva"
                Case eIngresso.I16
                    DescrizioneIngresso = "I1.6 - Riserva"
                Case eIngresso.I17_SensorePresScarto
                    DescrizioneIngresso = "I1.7 - Sensore Presenza Scarto"
                Case eIngresso.I20_CodPiastra1
                    DescrizioneIngresso = "I2.0 - Cod Piastra 1"
                Case eIngresso.I21_CodPiastra2
                    DescrizioneIngresso = "I2.1 - Cod Piastra 2"
                Case eIngresso.I22_CodPiastra4
                    DescrizioneIngresso = "I2.2 - Cod Piastra 4"
                Case eIngresso.I23_FcCampanaAlta
                    DescrizioneIngresso = "I2.3 - Fondo Corsa Campana Alta"
                Case eIngresso.I24_FcCampanaBassa
                    DescrizioneIngresso = "I2.4 - Fondo Corsa Campana Bassa"
                Case eIngresso.I25_FcPinzaAperta
                    DescrizioneIngresso = "I2.5 - Fondo Corsa Pinza Aperta"
                Case eIngresso.I26_FcPinzaChiusa
                    DescrizioneIngresso = "I2.6 - Fondo Corsa Pinza Chiusa"
                Case eIngresso.I27_SensorePresPz
                    DescrizioneIngresso = "I2.7 - Sensore Presenza Pezzo"
                Case Else
                    DescrizioneIngresso = "???"
            End Select
        End Get
    End Property



    Public ReadOnly Property DescrizioneUscita(ByVal indice As eUscita) As String
        Get
            Select Case indice
                Case eUscita.U00_DiscesaCampana
                    DescrizioneUscita = "U0.0 - Discesa Campana"
                Case eUscita.U01_SalitaCampana
                    DescrizioneUscita = "U0.1 - Salita Campana"
                Case eUscita.U02_ChiusuraPinza
                    DescrizioneUscita = "U0.2 - Chiusura Pinza"
                Case eUscita.U03_AperturaPinza
                    DescrizioneUscita = "U0.3 - Apertura Pinza"
                Case eUscita.U04_OnRaffreddamento
                    DescrizioneUscita = "U0.4 - Raffreddamento"
                Case eUscita.U05
                    DescrizioneUscita = "U0.5 - Riserva"
                Case eUscita.U06_LedRossiAvvio
                    DescrizioneUscita = "U0.6 - Led Rossi Pulsante Avvio"
                Case eUscita.U07_LedVerdiAvvio
                    DescrizioneUscita = "U0.7 - Led Verdi Pulsante Avvio"
                Case eUscita.U10_LampBuono
                    DescrizioneUscita = "U1.0 - Lampada Buono"
                Case eUscita.U11_LampScarto
                    DescrizioneUscita = "U1.1 - Lampada Scarto"
                Case eUscita.U12_Cicalino
                    DescrizioneUscita = "U1.2 - Cicalino"
                Case eUscita.U13_RelèMis13VS
                    DescrizioneUscita = "U1.3 - Relè Misura 13V"
                Case eUscita.U14_RelèMisRiscaldatore
                    DescrizioneUscita = "U1.4 - Relè Misura R Riscaldatore"
                Case eUscita.U15_RelèMisuraO2
                    DescrizioneUscita = "U1.5 - Relè Misura O2%"
                Case eUscita.U16_RelèConnCellaLD
                    DescrizioneUscita = "U1.6 - Relè Connessione Cella LD"
                Case eUscita.U17_RelèRiscaldatoreLD
                    DescrizioneUscita = "U1.7 - Relè Connessione Riscaldatore LD"
                Case eUscita.U20_RelèConnDirettaLD
                    DescrizioneUscita = "U2.0 - Relè Connessione Diretta LD"
                Case eUscita.U21_RelèVoltmetroLD
                    DescrizioneUscita = "U2.1 - Relè Voltmetro LD"
                Case eUscita.U22_RelèConnCellaNTK
                    DescrizioneUscita = "U2.2 - Relè Connessione Cella NTK"
                Case eUscita.U23_RelèConnCellaPinIpNTK
                    DescrizioneUscita = "U2.3 - Relè Connessione Pin IP NTK"
                Case eUscita.U24_RelèRiscaldatoreNTK
                    DescrizioneUscita = "U2.4 - Relè Connessione Riscaldatore NTK"
                Case eUscita.U25_RelèConnDirettaNTK
                    DescrizioneUscita = "U2.5 - Relè Connessione Diretta NTK"
                Case eUscita.U26_RelèAmperometroPinIpNTK
                    DescrizioneUscita = "U2.6 - Relè Amperometro Pin IP NTK"
                Case eUscita.U27_RelèMisuraIsolamento
                    DescrizioneUscita = "U2.7 - Relè Misura Isolamento"
                Case Else
                    DescrizioneUscita = "???"
            End Select
        End Get
    End Property


    Public ReadOnly Property StatoIngresso(ByVal indice As eIngresso) As Boolean
        Get
            StatoIngresso = _statoIngresso(indice)
        End Get
    End Property



    Public ReadOnly Property StatoIngresso(ByVal indice As Integer) As Boolean
        Get
            StatoIngresso = _statoIngresso(indice)
        End Get
    End Property



    Public Property StatoUscita(ByVal indice As eUscita) As Boolean
        Get
            StatoUscita = _statoUscita(indice)
        End Get
        Set(value As Boolean)
            _statoUscita(indice) = value
        End Set
    End Property



    Public Property StatoUscita(ByVal indice As Integer) As Boolean
        Get
            StatoUscita = _statoUscita(indice)
        End Get
        Set(value As Boolean)
            _statoUscita(indice) = value
        End Set
    End Property



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function Connetti() As Boolean
        Dim e As Boolean

        ' Crea e connette lo SLIO
        _slio = New cSLIO
        e = _slio.Connect(mGlobale.Indirizzo_IP_Slio, mGlobale.Numero_Porta_Slio)
        ' Disattiva tutte le uscite
        For i = 0 To _numeroUscite - 1
            _statoUscita(i) = False
        Next
        e = e Or Me.Scrivi
        ' Restituisce il flag d'errore
        Connetti = e
    End Function



    Public Function Disconnetti() As Boolean
        Dim e As Boolean

        ' Disattiva tutte le uscite
        For i = 0 To _numeroUscite - 1
            _statoUscita(i) = False
        Next
        e = Me.Scrivi
        ' Disconnette e cancella lo SLIO
        e = e OrElse _slio.Disconnect()
        _slio = Nothing
        ' Restituisce il flag d'errore
        Disconnetti = e
    End Function



    Public Function Leggi() As Boolean
        ' Legge gli ingressi digitali
        Leggi = _slio.ReadInputBits(0, _numeroIngressi, _statoIngresso)
    End Function



    Public Function Scrivi() As Boolean
        ' Scrive le uscite digitali
        Scrivi = _slio.WriteOutputBits(0, _numeroUscite, _statoUscita)
    End Function



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
End Class

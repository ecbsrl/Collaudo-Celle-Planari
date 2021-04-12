Option Explicit On
Option Strict On

Imports System.IO

Public Class cRisultati
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    ' Costanti pubbliche

    ' Enumerazione esito
    Public Enum eEsito
        PezzoNonCollaudato = 0
        ProvaInCorso = 1
        Buono = 2
        ScartoVal = 3
        ScartoRheater = 4
        ScartoCorrenteRiscaldatore = 5
        ScartoResistenzaIsolamento = 6
        Lsu_ScartoTemperaturaOperativa = 7
        Lsu_ScartoO2 = 8
        Lsu_ScartoResistenzaCalibrazione = 9
        Adv_ScartoIp = 10
        Adv_ScartoLambda = 11
        Zfas_ScartoIpEtas = 12
        Zfas_ScartoIpTB = 13
    End Enum



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Costanti private
    Private Const _numeroMassimoValori = 100

    ' Enumerazione indice valore
    Private Enum eIndice
        DataCollaudo = 0
        OraCollaudo = 1
        PezzoRipassato = 2
        Val = 3
        Rheater = 4
        CorrenteRiscaldatore = 5
        ResistenzaIsolamento = 6
        Lsu_TemperaturaOperativa = 7
        Lsu_O2 = 8
        Lsu_ResistenzaCalibrazione = 9
        AdvIp = 10
        AdvLambda = 11
        ZfasIpEtas = 12
        ZfasIpTB = 13
    End Enum

    ' Variabili private
    Private _esito As eEsito
    Private _valore(0 To _numeroMassimoValori - 1) As cValoreRisultato



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public ReadOnly Property DescrizioneEsito As String
        Get
            Select Case _esito
                Case eEsito.PezzoNonCollaudato
                    DescrizioneEsito = "Pezzo non collaudato"
                Case eEsito.ProvaInCorso
                    DescrizioneEsito = "Prova in corso"
                Case eEsito.Buono
                    DescrizioneEsito = "Buono"
                Case eEsito.ScartoVal
                    DescrizioneEsito = "Scarto tensione alimentazione"
                Case eEsito.ScartoRheater
                    DescrizioneEsito = "Scarto resistenza riscaldatore"
                Case eEsito.Lsu_ScartoTemperaturaOperativa
                    DescrizioneEsito = "Scarto temperatura operativa"
                Case eEsito.Lsu_ScartoO2
                    DescrizioneEsito = "Scarto percentuale ossigeno"
                Case eEsito.ScartoCorrenteRiscaldatore
                    DescrizioneEsito = "Scarto corrente riscaldatore"
                Case eEsito.Lsu_ScartoResistenzaCalibrazione
                    DescrizioneEsito = "Scarto resistenza calibrazione"
                Case eEsito.ScartoResistenzaIsolamento
                    DescrizioneEsito = "Scarto resistenza isolamento"
                Case eEsito.Adv_ScartoIp
                    DescrizioneEsito = "ADV - Scarto corrente pumping"
                Case eEsito.Adv_ScartoLambda
                    DescrizioneEsito = "ADV - Scarto Lambda"
                Case eEsito.Zfas_ScartoIpEtas
                    DescrizioneEsito = "ZFAS - Scarto corrente pumping Etas"
                Case eEsito.Zfas_ScartoIpTB
                    DescrizioneEsito = "ZFAS - Scarto corrente pumping TB"
                Case Else
                    DescrizioneEsito = "???"
            End Select
        End Get
    End Property



    Public Property Esito As eEsito
        Get
            Esito = _esito
        End Get
        Set(ByVal value As eEsito)
            _esito = value
        End Set
    End Property



    Public Property DataCollaudo As cValoreRisultato
        Get
            DataCollaudo = _valore(eIndice.DataCollaudo)
        End Get
        Set(ByVal value As cValoreRisultato)
            _valore(eIndice.DataCollaudo) = value
        End Set
    End Property



    Public Property OraCollaudo As cValoreRisultato
        Get
            OraCollaudo = _valore(eIndice.OraCollaudo)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.OraCollaudo) = value
        End Set
    End Property



    Public Property PezzoRipassato As cValoreRisultato
        Get
            PezzoRipassato = _valore(eIndice.PezzoRipassato)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.PezzoRipassato) = value
        End Set
    End Property



    Public Property Val As cValoreRisultato
        Get
            Val = _valore(eIndice.Val)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.Val) = value
        End Set
    End Property



    Public Property Rheater As cValoreRisultato
        Get
            Rheater = _valore(eIndice.Rheater)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.Rheater) = value
        End Set
    End Property



    Public Property Lsu_TemperaturaOperativa As cValoreRisultato
        Get
            Lsu_TemperaturaOperativa = _valore(eIndice.Lsu_TemperaturaOperativa)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.Lsu_TemperaturaOperativa) = value
        End Set
    End Property



    Public Property Lsu_O2 As cValoreRisultato
        Get
            Lsu_O2 = _valore(eIndice.Lsu_O2)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.Lsu_O2) = value
        End Set
    End Property



    Public Property CorrenteRiscaldatore As cValoreRisultato
        Get
            CorrenteRiscaldatore = _valore(eIndice.CorrenteRiscaldatore)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.CorrenteRiscaldatore) = value
        End Set
    End Property



    Public Property Lsu_ResistenzaCalibrazione As cValoreRisultato
        Get
            Lsu_ResistenzaCalibrazione = _valore(eIndice.Lsu_ResistenzaCalibrazione)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.Lsu_ResistenzaCalibrazione) = value
        End Set
    End Property



    Public Property ResistenzaIsolamento As cValoreRisultato
        Get
            ResistenzaIsolamento = _valore(eIndice.ResistenzaIsolamento)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.ResistenzaIsolamento) = value
        End Set
    End Property



    Public Property ADVIp As cValoreRisultato
        Get
            ADVIp = _valore(eIndice.AdvIp)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.AdvIp) = value
        End Set
    End Property



    Public Property ADVlambda As cValoreRisultato
        Get
            ADVlambda = _valore(eIndice.AdvLambda)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.AdvLambda) = value
        End Set
    End Property



    Public Property ZfasIpEtas As cValoreRisultato
        Get
            ZfasIpEtas = _valore(eIndice.ZfasIpEtas)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.ZfasIpEtas) = value
        End Set
    End Property



    Public Property ZfasIpTB As cValoreRisultato
        Get
            ZfasIpTB = _valore(eIndice.ZfasIpTB)
        End Get
        Set(value As cValoreRisultato)
            _valore(eIndice.ZfasIpTB) = value
        End Set
    End Property



    Public ReadOnly Property Valore(ByVal indice As Integer) As cValoreRisultato
        Get
            Valore = _valore(indice)
        End Get
    End Property



    '+------------------------------------------------------------------------------+
    '|                          Costruttore e distruttore                           |
    '+------------------------------------------------------------------------------+
    Public Sub New()
        ' Configura i singoli valori
        Me.DataCollaudo = New cValoreRisultato(cValoreRisultato.eTipo.ValoreString)
        Me.DataCollaudo.Descrizione = "Data di collaudo"
        Me.DataCollaudo.Valore = "gg/mm/aaaa"

        Me.OraCollaudo = New cValoreRisultato(cValoreRisultato.eTipo.ValoreString)
        Me.OraCollaudo.Descrizione = "Ora di collaudo"
        Me.OraCollaudo.Valore = "hh:mm:ss"

        Me.PezzoRipassato = New cValoreRisultato(cValoreRisultato.eTipo.ValoreBoolean)
        Me.PezzoRipassato.Descrizione = "Pezzo ripassato"
        Me.PezzoRipassato.Valore = False

        Me.Val = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.Val.Simbolo = "Valim"
        Me.Val.Descrizione = "Tensione alimentazione"
        Me.Val.UnitàDiMisura = "V"
        Me.Val.NumeroDecimali = 3
        Me.Val.Valore = 0

        Me.Rheater = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.Rheater.Simbolo = "Rh"
        Me.Rheater.Descrizione = "Resistenza riscaldatore"
        Me.Rheater.UnitàDiMisura = "Ω"
        Me.Rheater.NumeroDecimali = 2
        Me.Rheater.Valore = 0

        Me.Lsu_TemperaturaOperativa = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.Lsu_TemperaturaOperativa.Simbolo = "LSU - T.op"
        Me.Lsu_TemperaturaOperativa.Descrizione = "LSU - Temperatura Operativa"
        Me.Lsu_TemperaturaOperativa.UnitàDiMisura = "°C"
        Me.Lsu_TemperaturaOperativa.NumeroDecimali = 1
        Me.Lsu_TemperaturaOperativa.Valore = 0

        Me.Lsu_O2 = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.Lsu_O2.Simbolo = "LSU - O2%"
        Me.Lsu_O2.Descrizione = "LSU - Percentuale di Ossigeno"
        Me.Lsu_O2.UnitàDiMisura = "%"
        Me.Lsu_O2.NumeroDecimali = 3
        Me.Lsu_O2.Valore = 0

        Me.CorrenteRiscaldatore = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.CorrenteRiscaldatore.Simbolo = "Ih"
        Me.CorrenteRiscaldatore.Descrizione = "Corrente riscaldatore a regime"
        Me.CorrenteRiscaldatore.UnitàDiMisura = "mA"
        Me.CorrenteRiscaldatore.NumeroDecimali = 0
        Me.CorrenteRiscaldatore.Valore = 0

        Me.Lsu_ResistenzaCalibrazione = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.Lsu_ResistenzaCalibrazione.Simbolo = "LSU - Rcal(I)"
        Me.Lsu_ResistenzaCalibrazione.Descrizione = "LSU - Resistenza calibrazione"
        Me.Lsu_ResistenzaCalibrazione.UnitàDiMisura = "Ω"
        Me.Lsu_ResistenzaCalibrazione.NumeroDecimali = 1
        Me.Lsu_ResistenzaCalibrazione.Valore = 0

        Me.ResistenzaIsolamento = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.ResistenzaIsolamento.Simbolo = "Ri-h"
        Me.ResistenzaIsolamento.Descrizione = "Resistenza isolamento layer interni"
        Me.ResistenzaIsolamento.UnitàDiMisura = "MΩ"
        Me.ResistenzaIsolamento.NumeroDecimali = 1
        Me.ResistenzaIsolamento.Valore = 0

        Me.ADVIp = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.ADVIp.Simbolo = "ADV-Ip"
        Me.ADVIp.Descrizione = "ADV - Corrente pumping"
        Me.ADVIp.UnitàDiMisura = "mA"
        Me.ADVIp.NumeroDecimali = 2
        Me.ADVIp.Valore = 0

        Me.ADVlambda = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.ADVlambda.Simbolo = "ADV-λ"
        Me.ADVlambda.Descrizione = "ADV - Lambda"
        Me.ADVlambda.UnitàDiMisura = "-"
        Me.ADVlambda.NumeroDecimali = 2
        Me.ADVlambda.Valore = 0

        Me.ZfasIpEtas = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.ZfasIpEtas.Simbolo = "ZFAS-Ip-Etas"
        Me.ZfasIpEtas.Descrizione = "ZFAS - Ip Etas"
        Me.ZfasIpEtas.UnitàDiMisura = "mA"
        Me.ZfasIpEtas.NumeroDecimali = 2
        Me.ZfasIpEtas.Valore = 0

        Me.ZfasIpTB = New cValoreRisultato(cValoreRisultato.eTipo.ValoreSingle)
        Me.ZfasIpTB.Simbolo = "ZFAS-Ip-TB"
        Me.ZfasIpTB.Descrizione = "ZFAS - Ip TB"
        Me.ZfasIpTB.UnitàDiMisura = "mA"
        Me.ZfasIpTB.NumeroDecimali = 2
        Me.ZfasIpTB.Valore = 0

        ' Inizializza i valori
        Me.Inizializza()
    End Sub



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Sub Inizializza()
        Dim i As Integer

        ' Imposta l'esito sconosciuto a pezzo non collaudato
        _esito = eEsito.PezzoNonCollaudato
        ' Imposta l'esito di tutti i valori a disabilitato
        For i = 0 To _numeroMassimoValori - 1
            If (_valore(i) IsNot Nothing) Then
                _valore(i).Esito = cValoreRisultato.eEsito.Disabilitato
            End If
        Next
    End Sub



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
End Class

Option Explicit On
Option Strict On

Imports System.IO

Public Class cRicetta
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Costanti private
    Private Const _numeroMassimoValori = 106

    ' Enumerazione indice valore
    Private Enum eIndice
        DataOraCreazione = 0
        DataOraModifica = 1
        IndiceRevisione = 2
        NomeRicettaMaster = 3
        CodiceAttrezzatura = 4
        TipologiaSonda = 5
        AbilitazioneMarcatura = 10
        TMarcatura = 11
        Val_Min = 20
        Val_Max = 21
        Rheater_Abilitazione = 30
        Rheater_Min = 31
        Rheater_Max = 32
        Corrente_Riscaldatore_Abilitazione = 40
        Corrente_Riscaldatore_Min = 41
        Corrente_riscaldatore_Max = 42
        Resistenza_Isolamento_Abilitazione = 50
        Resistenza_Isolamento_Min = 51
        Resistenza_Isolamento_Max = 52
        Tempo_Riscaldamento = 60
        Tempo_Raffreddamento = 61
        ' Aggiunti i valori per ADV e ZFAS
        Lsu_Flusso_Aria_Erogato = 70
        Lsu_Flusso_N2_Erogato = 71
        Lsu_Target_O2 = 72
        Lsu_Temp_Operativa_Abilitazione = 73
        Lsu_Temp_Operativa_Min = 74
        Lsu_Temp_Operativa_Max = 75
        Lsu_O2_Abilitazione = 76
        Lsu_O2_Min = 77
        Lsu_O2_Max = 78
        Lsu_Resistenza_Calibrazione_Abilitazione = 79
        Lsu_Resistenza_Calibrazione_Min = 80
        Lsu_Resistenza_Calibrazione_Max = 81
        Adv_Ip_Abilitazione = 90
        Adv_Ip_Min = 91
        Adv_Ip_Max = 92
        Adv_Lambda_Abilitazione = 93
        Adv_Lambda_Min = 94
        Adv_Lambda_Max = 95
        Zfas_IpEtas_Abilitazione = 100
        Zfas_IpEtas_Min = 101
        Zfas_IpEtas_Max = 102
        Zfas_IpTB_Abilitazione = 103
        Zfas_IpTB_Min = 104
        Zfas_IpTB_Max = 105
    End Enum

    ' Variabili private
    Private _valore(0 To _numeroMassimoValori - 1) As cValoreRicetta



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public Property DataOraCreazione As cValoreRicetta
        Get
            DataOraCreazione = _valore(eIndice.DataOraCreazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.DataOraCreazione) = value
        End Set
    End Property


    Public Property DataOraModifica As cValoreRicetta
        Get
            DataOraModifica = _valore(eIndice.DataOraModifica)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.DataOraModifica) = value
        End Set
    End Property


    Public Property IndiceRevisione As cValoreRicetta
        Get
            IndiceRevisione = _valore(eIndice.IndiceRevisione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.IndiceRevisione) = value
        End Set
    End Property


    Public Property NomeRicettaMaster As cValoreRicetta
        Get
            NomeRicettaMaster = _valore(eIndice.NomeRicettaMaster)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.NomeRicettaMaster) = value
        End Set
    End Property


    Public Property CodiceAttrezzatura As cValoreRicetta
        Get
            CodiceAttrezzatura = _valore(eIndice.CodiceAttrezzatura)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.CodiceAttrezzatura) = value
        End Set
    End Property



    Public Property TipologiaSonda As cValoreRicetta
        Get
            TipologiaSonda = _valore(eIndice.TipologiaSonda)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.TipologiaSonda) = value
        End Set
    End Property


    Public Property AbilitazioneMarcatura As cValoreRicetta
        Get
            AbilitazioneMarcatura = _valore(eIndice.AbilitazioneMarcatura)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.AbilitazioneMarcatura) = value
        End Set
    End Property


    Public Property Tmarcatura As cValoreRicetta
        Get
            Tmarcatura = _valore(eIndice.TMarcatura)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.TMarcatura) = value
        End Set
    End Property


    Public Property Val_Min As cValoreRicetta
        Get
            Val_Min = _valore(eIndice.Val_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Val_Min) = value
        End Set
    End Property


    Public Property Val_Max As cValoreRicetta
        Get
            Val_Max = _valore(eIndice.Val_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Val_Max) = value
        End Set
    End Property


    Public Property Rheater_Abilitazione As cValoreRicetta
        Get
            Rheater_Abilitazione = _valore(eIndice.Rheater_Abilitazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Rheater_Abilitazione) = value
        End Set
    End Property


    Public Property Rheater_Min As cValoreRicetta
        Get
            Rheater_Min = _valore(eIndice.Rheater_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Rheater_Min) = value
        End Set
    End Property


    Public Property Rheater_Max As cValoreRicetta
        Get
            Rheater_Max = _valore(eIndice.Rheater_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Rheater_Max) = value
        End Set
    End Property


    Public Property Lsu_Flusso_Aria_Erogato As cValoreRicetta
        Get
            Lsu_Flusso_Aria_Erogato = _valore(eIndice.Lsu_Flusso_Aria_Erogato)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_Flusso_Aria_Erogato) = value
        End Set
    End Property


    Public Property Lsu_Flusso_N2_Erogato As cValoreRicetta
        Get
            Lsu_Flusso_N2_Erogato = _valore(eIndice.Lsu_Flusso_N2_Erogato)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_Flusso_N2_Erogato) = value
        End Set
    End Property


    Public Property Lsu_Target_O2 As cValoreRicetta
        Get
            Lsu_Target_O2 = _valore(eIndice.Lsu_Target_O2)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_Target_O2) = value
        End Set
    End Property


    Public Property Tempo_Riscaldamento As cValoreRicetta
        Get
            Tempo_Riscaldamento = _valore(eIndice.Tempo_Riscaldamento)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Tempo_Riscaldamento) = value
        End Set
    End Property


    Public Property Lsu_Temperatura_Operativa_Abilitazione As cValoreRicetta
        Get
            Lsu_Temperatura_Operativa_Abilitazione = _valore(eIndice.Lsu_Temp_Operativa_Abilitazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_Temp_Operativa_Abilitazione) = value
        End Set
    End Property


    Public Property Lsu_Temperatura_Operativa_Min As cValoreRicetta
        Get
            Lsu_Temperatura_Operativa_Min = _valore(eIndice.Lsu_Temp_Operativa_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_Temp_Operativa_Min) = value
        End Set
    End Property


    Public Property Lsu_Temperatura_Operativa_Max As cValoreRicetta
        Get
            Lsu_Temperatura_Operativa_Max = _valore(eIndice.Lsu_Temp_Operativa_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_Temp_Operativa_Max) = value
        End Set
    End Property


    Public Property Lsu_O2_Abilitazione As cValoreRicetta
        Get
            Lsu_O2_Abilitazione = _valore(eIndice.Lsu_O2_Abilitazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_O2_Abilitazione) = value
        End Set
    End Property


    Public Property Lsu_O2_Min As cValoreRicetta
        Get
            Lsu_O2_Min = _valore(eIndice.Lsu_O2_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_O2_Min) = value
        End Set
    End Property


    Public Property Lsu_O2_Max As cValoreRicetta
        Get
            Lsu_O2_Max = _valore(eIndice.Lsu_O2_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_O2_Max) = value
        End Set
    End Property


    Public Property Corrente_Riscaldatore_Abilitazione As cValoreRicetta
        Get
            Corrente_Riscaldatore_Abilitazione = _valore(eIndice.Corrente_Riscaldatore_Abilitazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Corrente_Riscaldatore_Abilitazione) = value
        End Set
    End Property


    Public Property Corrente_Riscaldatore_Min As cValoreRicetta
        Get
            Corrente_Riscaldatore_Min = _valore(eIndice.Corrente_Riscaldatore_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Corrente_Riscaldatore_Min) = value
        End Set
    End Property


    Public Property Corrente_Riscaldatore_Max As cValoreRicetta
        Get
            Corrente_Riscaldatore_Max = _valore(eIndice.Corrente_riscaldatore_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Corrente_riscaldatore_Max) = value
        End Set
    End Property


    Public Property Lsu_Resistenza_Calibrazione_Abilitazione As cValoreRicetta
        Get
            Lsu_Resistenza_Calibrazione_Abilitazione = _valore(eIndice.Lsu_Resistenza_Calibrazione_Abilitazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_Resistenza_Calibrazione_Abilitazione) = value
        End Set
    End Property


    Public Property Lsu_Resistenza_Calibrazione_Min As cValoreRicetta
        Get
            Lsu_Resistenza_Calibrazione_Min = _valore(eIndice.Lsu_Resistenza_Calibrazione_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_Resistenza_Calibrazione_Min) = value
        End Set
    End Property


    Public Property Lsu_Resistenza_Calibrazione_Max As cValoreRicetta
        Get
            Lsu_Resistenza_Calibrazione_Max = _valore(eIndice.Lsu_Resistenza_Calibrazione_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Lsu_Resistenza_Calibrazione_Max) = value
        End Set
    End Property


    Public Property Resistenza_Isolamento_Abilitazione As cValoreRicetta
        Get
            Resistenza_Isolamento_Abilitazione = _valore(eIndice.Resistenza_Isolamento_Abilitazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Resistenza_Isolamento_Abilitazione) = value
        End Set
    End Property


    Public Property Resistenza_Isolamento_Min As cValoreRicetta
        Get
            Resistenza_Isolamento_Min = _valore(eIndice.Resistenza_Isolamento_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Resistenza_Isolamento_Min) = value
        End Set
    End Property


    Public Property Resistenza_Isolamento_Max As cValoreRicetta
        Get
            Resistenza_Isolamento_Max = _valore(eIndice.Resistenza_Isolamento_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Resistenza_Isolamento_Max) = value
        End Set
    End Property


    Public Property Tempo_Raffreddamento As cValoreRicetta
        Get
            Tempo_Raffreddamento = _valore(eIndice.Tempo_Raffreddamento)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Tempo_Raffreddamento) = value
        End Set
    End Property



    Public Property Adv_Ip_Abilitazione As cValoreRicetta
        Get
            Adv_Ip_Abilitazione = _valore(eIndice.Adv_Ip_Abilitazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Adv_Ip_Abilitazione) = value
        End Set
    End Property



    Public Property Adv_Ip_Min As cValoreRicetta
        Get
            Adv_Ip_Min = _valore(eIndice.Adv_Ip_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Adv_Ip_Min) = value
        End Set
    End Property



    Public Property Adv_Ip_Max As cValoreRicetta
        Get
            Adv_Ip_Max = _valore(eIndice.Adv_Ip_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Adv_Ip_Max) = value
        End Set
    End Property



    Public Property Adv_Lambda_Abilitazione As cValoreRicetta
        Get
            Adv_Lambda_Abilitazione = _valore(eIndice.Adv_Lambda_Abilitazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Adv_Lambda_Abilitazione) = value
        End Set
    End Property



    Public Property Adv_Lambda_Min As cValoreRicetta
        Get
            Adv_Lambda_Min = _valore(eIndice.Adv_Lambda_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Adv_Lambda_Min) = value
        End Set
    End Property



    Public Property Adv_Lambda_Max As cValoreRicetta
        Get
            Adv_Lambda_Max = _valore(eIndice.Adv_Lambda_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Adv_Lambda_Max) = value
        End Set
    End Property



    Public Property Zfas_IpEtas_Abilitazione As cValoreRicetta
        Get
            Zfas_IpEtas_Abilitazione = _valore(eIndice.Zfas_IpEtas_Abilitazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Zfas_IpEtas_Abilitazione) = value
        End Set
    End Property



    Public Property Zfas_IpEtas_Min As cValoreRicetta
        Get
            Zfas_IpEtas_Min = _valore(eIndice.Zfas_IpEtas_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Zfas_IpEtas_Min) = value
        End Set
    End Property



    Public Property Zfas_IpEtas_Max As cValoreRicetta
        Get
            Zfas_IpEtas_Max = _valore(eIndice.Zfas_IpEtas_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Zfas_IpEtas_Max) = value
        End Set
    End Property



    Public Property Zfas_IpTB_Abilitazione As cValoreRicetta
        Get
            Zfas_IpTB_Abilitazione = _valore(eIndice.Zfas_IpTB_Abilitazione)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Zfas_IpTB_Abilitazione) = value
        End Set
    End Property



    Public Property Zfas_IpTB_Min As cValoreRicetta
        Get
            Zfas_IpTB_Min = _valore(eIndice.Zfas_IpTB_Min)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Zfas_IpTB_Min) = value
        End Set
    End Property



    Public Property Zfas_IpTB_Max As cValoreRicetta
        Get
            Zfas_IpTB_Max = _valore(eIndice.Zfas_IpTB_Max)
        End Get
        Set(value As cValoreRicetta)
            _valore(eIndice.Zfas_IpTB_Max) = value
        End Set
    End Property




    Public ReadOnly Property Valore(ByVal indice As Integer) As cValoreRicetta
        Get
            Valore = _valore(indice)
        End Get
    End Property



    '+------------------------------------------------------------------------------+
    '|                          Costruttore e distruttore                           |
    '+------------------------------------------------------------------------------+
    Public Sub New()
        Me.DataOraCreazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreString)
        Me.DataOraCreazione.Descrizione = "Data ed ora di creazione"
        Me.DataOraCreazione.LunghezzaMassima = 30
        Me.DataOraCreazione.ValoreDefault = ""
        Me.DataOraCreazione.Valore = ""

        Me.DataOraModifica = New cValoreRicetta(cValoreRicetta.eTipo.ValoreString)
        Me.DataOraModifica.Descrizione = "Data ed ora dell'ultima modifica"
        Me.DataOraModifica.LunghezzaMassima = 30
        Me.DataOraModifica.ValoreDefault = ""
        Me.DataOraModifica.Valore = ""

        Me.IndiceRevisione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreString)
        Me.IndiceRevisione.Descrizione = "Indice revisione"
        Me.IndiceRevisione.LunghezzaMassima = 1
        Me.IndiceRevisione.ValoreDefault = "A"
        Me.IndiceRevisione.Valore = "A"

        Me.NomeRicettaMaster = New cValoreRicetta(cValoreRicetta.eTipo.ValoreString)
        Me.NomeRicettaMaster.Descrizione = "Nome ricetta master"
        Me.NomeRicettaMaster.LunghezzaMassima = 10
        Me.NomeRicettaMaster.ValoreDefault = ""
        Me.NomeRicettaMaster.Valore = ""

        Me.CodiceAttrezzatura = New cValoreRicetta(cValoreRicetta.eTipo.ValoreString)
        Me.CodiceAttrezzatura.Descrizione = "Codice attrezzatura"
        Me.CodiceAttrezzatura.LunghezzaMassima = 20
        Me.CodiceAttrezzatura.ValoreDefault = ""
        Me.CodiceAttrezzatura.Valore = ""

        Me.TipologiaSonda = New cValoreRicetta(cValoreRicetta.eTipo.ValoreString)
        Me.TipologiaSonda.Descrizione = "Tipologia Sonda"
        Me.TipologiaSonda.LunghezzaMassima = 20
        Me.TipologiaSonda.ValoreDefault = ""
        Me.TipologiaSonda.Valore = ""

        Me.AbilitazioneMarcatura = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.AbilitazioneMarcatura.Descrizione = "Abilitazione marcatura"
        Me.AbilitazioneMarcatura.ValoreDefault = True
        Me.AbilitazioneMarcatura.Valore = True

        Me.Tmarcatura = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Tmarcatura.Descrizione = "Durata marcatura"
        Me.Tmarcatura.UnitàDiMisura = "s"
        Me.Tmarcatura.NumeroDecimali = 1
        Me.Tmarcatura.ValoreMinimo = 1
        Me.Tmarcatura.ValoreDefault = 1
        Me.Tmarcatura.ValoreMassimo = 4.9
        Me.Tmarcatura.Valore = 1

        Me.Val_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Val_Min.Descrizione = "Tensione Alimentazione Minima"
        Me.Val_Min.UnitàDiMisura = "V"
        Me.Val_Min.NumeroDecimali = 3
        Me.Val_Min.ValoreMinimo = 1
        Me.Val_Min.ValoreDefault = 13.45
        Me.Val_Min.ValoreMassimo = 20
        Me.Val_Min.Valore = 13.45

        Me.Val_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Val_Max.Descrizione = "Tensione Alimentazione Massima"
        Me.Val_Max.UnitàDiMisura = "V"
        Me.Val_Max.NumeroDecimali = 3
        Me.Val_Max.ValoreMinimo = 1
        Me.Val_Max.ValoreDefault = 13.55
        Me.Val_Max.ValoreMassimo = 20
        Me.Val_Max.Valore = 13.55

        Me.Rheater_Abilitazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.Rheater_Abilitazione.Descrizione = "Resistenza Riscaldatore - Abilitazione test"
        Me.Rheater_Abilitazione.ValoreDefault = False
        Me.Rheater_Abilitazione.Valore = False

        Me.Rheater_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Rheater_Min.Descrizione = " Resistenza Riscaldatore Minima"
        Me.Rheater_Min.UnitàDiMisura = "Ω"
        Me.Rheater_Min.NumeroDecimali = 2
        Me.Rheater_Min.ValoreMinimo = 1
        Me.Rheater_Min.ValoreDefault = 2.6
        Me.Rheater_Min.ValoreMassimo = 10
        Me.Rheater_Min.Valore = 2.6

        Me.Rheater_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Rheater_Max.Descrizione = "Resistenza Riscaldatore Massima"
        Me.Rheater_Max.UnitàDiMisura = "Ω"
        Me.Rheater_Max.NumeroDecimali = 2
        Me.Rheater_Max.ValoreMinimo = 1
        Me.Rheater_Max.ValoreDefault = 3.9
        Me.Rheater_Max.ValoreMassimo = 10
        Me.Rheater_Max.Valore = 3.9

        Me.Lsu_Flusso_Aria_Erogato = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Lsu_Flusso_Aria_Erogato.Descrizione = "LSU - Flusso Aria Erogato"
        Me.Lsu_Flusso_Aria_Erogato.UnitàDiMisura = "NL/Minuto"
        Me.Lsu_Flusso_Aria_Erogato.NumeroDecimali = 3
        Me.Lsu_Flusso_Aria_Erogato.ValoreMinimo = 0
        Me.Lsu_Flusso_Aria_Erogato.ValoreDefault = 0.829
        Me.Lsu_Flusso_Aria_Erogato.ValoreMassimo = 2
        Me.Lsu_Flusso_Aria_Erogato.Valore = 0.829

        Me.Lsu_Flusso_N2_Erogato = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Lsu_Flusso_N2_Erogato.Descrizione = "LSU - Flusso N2 Erogato"
        Me.Lsu_Flusso_N2_Erogato.UnitàDiMisura = "NL/Minuto"
        Me.Lsu_Flusso_N2_Erogato.NumeroDecimali = 3
        Me.Lsu_Flusso_N2_Erogato.ValoreMinimo = 0
        Me.Lsu_Flusso_N2_Erogato.ValoreDefault = 1.213
        Me.Lsu_Flusso_N2_Erogato.ValoreMassimo = 2
        Me.Lsu_Flusso_N2_Erogato.Valore = 1.213

        Me.Lsu_Target_O2 = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Lsu_Target_O2.Descrizione = "LSU - Target O2 %"
        Me.Lsu_Target_O2.UnitàDiMisura = "%"
        Me.Lsu_Target_O2.NumeroDecimali = 3
        Me.Lsu_Target_O2.ValoreMinimo = 0
        Me.Lsu_Target_O2.ValoreDefault = 8.31
        Me.Lsu_Target_O2.ValoreMassimo = 25
        Me.Lsu_Target_O2.Valore = 8.31

        Me.Tempo_Riscaldamento = New cValoreRicetta(cValoreRicetta.eTipo.ValoreInteger)
        Me.Tempo_Riscaldamento.Descrizione = "LSU - Tempo di Riscaldamento"
        Me.Tempo_Riscaldamento.UnitàDiMisura = "s"
        Me.Tempo_Riscaldamento.NumeroDecimali = 0
        Me.Tempo_Riscaldamento.ValoreMinimo = 0
        Me.Tempo_Riscaldamento.ValoreDefault = 60
        Me.Tempo_Riscaldamento.ValoreMassimo = 120
        Me.Tempo_Riscaldamento.Valore = 60

        Me.Lsu_Temperatura_Operativa_Abilitazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.Lsu_Temperatura_Operativa_Abilitazione.Descrizione = "LSU - Temperatura Operativa - Abilitazione test"
        Me.Lsu_Temperatura_Operativa_Abilitazione.ValoreDefault = False
        Me.Lsu_Temperatura_Operativa_Abilitazione.Valore = False

        Me.Lsu_Temperatura_Operativa_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreInteger)
        Me.Lsu_Temperatura_Operativa_Min.Descrizione = "LSU - Temperatura Operativa Minima"
        Me.Lsu_Temperatura_Operativa_Min.UnitàDiMisura = "°C"
        Me.Lsu_Temperatura_Operativa_Min.NumeroDecimali = 1
        Me.Lsu_Temperatura_Operativa_Min.ValoreMinimo = 0
        Me.Lsu_Temperatura_Operativa_Min.ValoreDefault = 760
        Me.Lsu_Temperatura_Operativa_Min.ValoreMassimo = 999
        Me.Lsu_Temperatura_Operativa_Min.Valore = 760

        Me.Lsu_Temperatura_Operativa_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreInteger)
        Me.Lsu_Temperatura_Operativa_Max.Descrizione = "LSU - Temperatura Operativa Massima"
        Me.Lsu_Temperatura_Operativa_Max.UnitàDiMisura = "°C"
        Me.Lsu_Temperatura_Operativa_Max.NumeroDecimali = 1
        Me.Lsu_Temperatura_Operativa_Max.ValoreMinimo = 0
        Me.Lsu_Temperatura_Operativa_Max.ValoreDefault = 785
        Me.Lsu_Temperatura_Operativa_Max.ValoreMassimo = 999
        Me.Lsu_Temperatura_Operativa_Max.Valore = 785

        Me.Lsu_O2_Abilitazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.Lsu_O2_Abilitazione.Descrizione = "LSU - Percentuale Ossigeno - Abilitazione test"
        Me.Lsu_O2_Abilitazione.ValoreDefault = False
        Me.Lsu_O2_Abilitazione.Valore = False

        Me.Lsu_O2_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Lsu_O2_Min.Descrizione = "LSU - Percentuale Ossigeno Minima"
        Me.Lsu_O2_Min.UnitàDiMisura = "%"
        Me.Lsu_O2_Min.NumeroDecimali = 3
        Me.Lsu_O2_Min.ValoreMinimo = 0
        Me.Lsu_O2_Min.ValoreDefault = 8.31
        Me.Lsu_O2_Min.ValoreMassimo = 100
        Me.Lsu_O2_Min.Valore = 8.31

        Me.Lsu_O2_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Lsu_O2_Max.Descrizione = "LSU - Percentuale Ossigeno Massima"
        Me.Lsu_O2_Max.UnitàDiMisura = "%"
        Me.Lsu_O2_Max.NumeroDecimali = 3
        Me.Lsu_O2_Max.ValoreMinimo = 0
        Me.Lsu_O2_Max.ValoreDefault = 20
        Me.Lsu_O2_Max.ValoreMassimo = 100
        Me.Lsu_O2_Max.Valore = 20

        Me.Corrente_Riscaldatore_Abilitazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.Corrente_Riscaldatore_Abilitazione.Descrizione = "Corrente Riscaldatore a Regime - Abilitazione test"
        Me.Corrente_Riscaldatore_Abilitazione.ValoreDefault = False
        Me.Corrente_Riscaldatore_Abilitazione.Valore = False

        Me.Corrente_Riscaldatore_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Corrente_Riscaldatore_Min.Descrizione = "Corrente Minima Riscaldatore a Regime"
        Me.Corrente_Riscaldatore_Min.UnitàDiMisura = "mA"
        Me.Corrente_Riscaldatore_Min.NumeroDecimali = 0
        Me.Corrente_Riscaldatore_Min.ValoreMinimo = 0
        Me.Corrente_Riscaldatore_Min.ValoreDefault = 800
        Me.Corrente_Riscaldatore_Min.ValoreMassimo = 2000
        Me.Corrente_Riscaldatore_Min.Valore = 800

        Me.Corrente_Riscaldatore_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Corrente_Riscaldatore_Max.Descrizione = "Corrente Massima Riscaldatore a Regime"
        Me.Corrente_Riscaldatore_Max.UnitàDiMisura = "mA"
        Me.Corrente_Riscaldatore_Max.NumeroDecimali = 0
        Me.Corrente_Riscaldatore_Max.ValoreMinimo = 0
        Me.Corrente_Riscaldatore_Max.ValoreDefault = 1500
        Me.Corrente_Riscaldatore_Max.ValoreMassimo = 2000
        Me.Corrente_Riscaldatore_Max.Valore = 1500

        Me.Lsu_Resistenza_Calibrazione_Abilitazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.Lsu_Resistenza_Calibrazione_Abilitazione.Descrizione = "LSU - Resistenza di Calibrazione - Abilitazione test"
        Me.Lsu_Resistenza_Calibrazione_Abilitazione.ValoreDefault = False
        Me.Lsu_Resistenza_Calibrazione_Abilitazione.Valore = False

        Me.Lsu_Resistenza_Calibrazione_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Lsu_Resistenza_Calibrazione_Min.Descrizione = "LSU - Resistenza di Calibrazione Minima"
        Me.Lsu_Resistenza_Calibrazione_Min.UnitàDiMisura = "Ω"
        Me.Lsu_Resistenza_Calibrazione_Min.NumeroDecimali = 1
        Me.Lsu_Resistenza_Calibrazione_Min.ValoreMinimo = 0
        Me.Lsu_Resistenza_Calibrazione_Min.ValoreDefault = 30
        Me.Lsu_Resistenza_Calibrazione_Min.ValoreMassimo = 1000
        Me.Lsu_Resistenza_Calibrazione_Min.Valore = 30

        Me.Lsu_Resistenza_Calibrazione_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Lsu_Resistenza_Calibrazione_Max.Descrizione = "LSU - Resistenza di Calibrazione Massima"
        Me.Lsu_Resistenza_Calibrazione_Max.UnitàDiMisura = "Ω"
        Me.Lsu_Resistenza_Calibrazione_Max.NumeroDecimali = 1
        Me.Lsu_Resistenza_Calibrazione_Max.ValoreMinimo = 0
        Me.Lsu_Resistenza_Calibrazione_Max.ValoreDefault = 300
        Me.Lsu_Resistenza_Calibrazione_Max.ValoreMassimo = 1000
        Me.Lsu_Resistenza_Calibrazione_Max.Valore = 300

        Me.Resistenza_Isolamento_Abilitazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.Resistenza_Isolamento_Abilitazione.Descrizione = "Resistenza di Isolamento - Abilitazione test"
        Me.Resistenza_Isolamento_Abilitazione.ValoreDefault = False
        Me.Resistenza_Isolamento_Abilitazione.Valore = False

        Me.Resistenza_Isolamento_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Resistenza_Isolamento_Min.Descrizione = "Resistenza di Isolamento Minima"
        Me.Resistenza_Isolamento_Min.UnitàDiMisura = "MΩ"
        Me.Resistenza_Isolamento_Min.NumeroDecimali = 1
        Me.Resistenza_Isolamento_Min.ValoreMinimo = 0
        Me.Resistenza_Isolamento_Min.ValoreDefault = 0.4
        Me.Resistenza_Isolamento_Min.ValoreMassimo = 10
        Me.Resistenza_Isolamento_Min.Valore = 0.4

        Me.Resistenza_Isolamento_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Resistenza_Isolamento_Max.Descrizione = "Resistenza di Isolamento Massima"
        Me.Resistenza_Isolamento_Max.UnitàDiMisura = "MΩ"
        Me.Resistenza_Isolamento_Max.NumeroDecimali = 1
        Me.Resistenza_Isolamento_Max.ValoreMinimo = 0
        Me.Resistenza_Isolamento_Max.ValoreDefault = 10
        Me.Resistenza_Isolamento_Max.ValoreMassimo = 10
        Me.Resistenza_Isolamento_Max.Valore = 10

        Me.Tempo_Raffreddamento = New cValoreRicetta(cValoreRicetta.eTipo.ValoreInteger)
        Me.Tempo_Raffreddamento.Descrizione = "Tempo di Raffreddamento"
        Me.Tempo_Raffreddamento.UnitàDiMisura = "s"
        Me.Tempo_Raffreddamento.NumeroDecimali = 0
        Me.Tempo_Raffreddamento.ValoreMinimo = 0
        Me.Tempo_Raffreddamento.ValoreDefault = 60
        Me.Tempo_Raffreddamento.ValoreMassimo = 120
        Me.Tempo_Raffreddamento.Valore = 60

        Me.Adv_Ip_Abilitazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.Adv_Ip_Abilitazione.Descrizione = "ADV - Corrente Pumping Abilitazione"
        Me.Adv_Ip_Abilitazione.ValoreDefault = False
        Me.Adv_Ip_Abilitazione.Valore = False

        Me.Adv_Ip_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Adv_Ip_Min.Descrizione = "ADV - Corrente Pumping Minima"
        Me.Adv_Ip_Min.UnitàDiMisura = "mA"
        Me.Adv_Ip_Min.NumeroDecimali = 3
        Me.Adv_Ip_Min.ValoreMinimo = 0
        Me.Adv_Ip_Min.ValoreDefault = 0.335
        Me.Adv_Ip_Min.ValoreMassimo = 5
        Me.Adv_Ip_Min.Valore = 0.335

        Me.Adv_Ip_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Adv_Ip_Max.Descrizione = "ADV - Corrente Pumping Massima"
        Me.Adv_Ip_Max.UnitàDiMisura = "mA"
        Me.Adv_Ip_Max.NumeroDecimali = 3
        Me.Adv_Ip_Max.ValoreMassimo = 0
        Me.Adv_Ip_Max.ValoreDefault = 0.385
        Me.Adv_Ip_Max.ValoreMassimo = 5
        Me.Adv_Ip_Max.Valore = 0.385

        Me.Adv_Lambda_Abilitazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.Adv_Lambda_Abilitazione.Descrizione = "ADV - Lambda Abilitazione"
        Me.Adv_Lambda_Abilitazione.ValoreDefault = False
        Me.Adv_Lambda_Abilitazione.Valore = False

        Me.Adv_Lambda_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Adv_Lambda_Min.Descrizione = "ADV - Lambda Minimo"
        Me.Adv_Lambda_Min.UnitàDiMisura = "-"
        Me.Adv_Lambda_Min.NumeroDecimali = 2
        Me.Adv_Lambda_Min.ValoreMinimo = 0
        Me.Adv_Lambda_Min.ValoreDefault = 1.4
        Me.Adv_Lambda_Min.ValoreMassimo = 5
        Me.Adv_Lambda_Min.Valore = 1.4

        Me.Adv_Lambda_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Adv_Lambda_Max.Descrizione = "ADV - Lambda Massimo"
        Me.Adv_Lambda_Max.UnitàDiMisura = "-"
        Me.Adv_Lambda_Max.NumeroDecimali = 2
        Me.Adv_Lambda_Max.ValoreMassimo = 0
        Me.Adv_Lambda_Max.ValoreDefault = 1.46
        Me.Adv_Lambda_Max.ValoreMassimo = 5
        Me.Adv_Lambda_Max.Valore = 1.46

        Me.Zfas_IpEtas_Abilitazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.Zfas_IpEtas_Abilitazione.Descrizione = "ZFAS - Corrente Pumping Etas Abilitazione"
        Me.Zfas_IpEtas_Abilitazione.ValoreDefault = False
        Me.Zfas_IpEtas_Abilitazione.Valore = False

        Me.Zfas_IpEtas_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Zfas_IpEtas_Min.Descrizione = "ZFAS - Corrente Pumping Etas Minima"
        Me.Zfas_IpEtas_Min.UnitàDiMisura = "mA"
        Me.Zfas_IpEtas_Min.NumeroDecimali = 2
        Me.Zfas_IpEtas_Min.ValoreMinimo = 0
        Me.Zfas_IpEtas_Min.ValoreDefault = 4.61
        Me.Zfas_IpEtas_Min.ValoreMassimo = 10
        Me.Zfas_IpEtas_Min.Valore = 4.61

        Me.Zfas_IpEtas_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Zfas_IpEtas_Max.Descrizione = "ZFAS - Corrente Pumping Etas Massima"
        Me.Zfas_IpEtas_Max.UnitàDiMisura = "mA"
        Me.Zfas_IpEtas_Max.NumeroDecimali = 2
        Me.Zfas_IpEtas_Max.ValoreMassimo = 0
        Me.Zfas_IpEtas_Max.ValoreDefault = 5.89
        Me.Zfas_IpEtas_Max.ValoreMassimo = 10
        Me.Zfas_IpEtas_Max.Valore = 5.89

        Me.Zfas_IpTB_Abilitazione = New cValoreRicetta(cValoreRicetta.eTipo.ValoreBoolean)
        Me.Zfas_IpTB_Abilitazione.Descrizione = "ZFAS - Corrente Pumping TB Abilitazione"
        Me.Zfas_IpTB_Abilitazione.ValoreDefault = False

        Me.Zfas_IpEtas_Abilitazione.Valore = False
        Me.Zfas_IpTB_Min = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Zfas_IpTB_Min.Descrizione = "ZFAS - Corrente Pumping TB Minima"
        Me.Zfas_IpTB_Min.UnitàDiMisura = "mA"
        Me.Zfas_IpTB_Min.NumeroDecimali = 2
        Me.Zfas_IpTB_Min.ValoreMinimo = 0
        Me.Zfas_IpTB_Min.ValoreDefault = 3.8
        Me.Zfas_IpTB_Min.ValoreMassimo = 10
        Me.Zfas_IpTB_Min.Valore = 3.8

        Me.Zfas_IpTB_Max = New cValoreRicetta(cValoreRicetta.eTipo.ValoreSingle)
        Me.Zfas_IpTB_Max.Descrizione = "ZFAS - Corrente Pumping TB Massima"
        Me.Zfas_IpTB_Max.UnitàDiMisura = "mA"
        Me.Zfas_IpTB_Max.NumeroDecimali = 2
        Me.Zfas_IpTB_Max.ValoreMassimo = 0
        Me.Zfas_IpTB_Max.ValoreDefault = 4.8
        Me.Zfas_IpTB_Max.ValoreMassimo = 10
        Me.Zfas_IpTB_Max.Valore = 4.8
    End Sub



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Shared Function Cancella(ByVal nomeRicetta As String) As Boolean
        ' Cancella la ricetta
        Try
            ' Cancella il file
            File.Delete(mGlobale.PercorsoRicette & "\" & nomeRicetta & ".txt")
            ' Restituisce False
            Cancella = False

        Catch ex As Exception
            ' Restituisce True
            Cancella = True
        End Try
    End Function


    Public Function Carica(ByVal nomeRicetta As String) As Boolean
        ' Carica la ricetta
        Carica = CaricaDaFile(mGlobale.PercorsoRicette & "\" & nomeRicetta & ".txt")
    End Function


    Public Function CaricaDaFile(ByVal nomeFile As String) As Boolean
        Dim campo() As String
        Dim file As StreamReader = Nothing
        Dim linea As String

        Try
            ' Apre il file
            file = New StreamReader(nomeFile)
            ' Carica tutti i valori
            While Not (file.EndOfStream)
                linea = file.ReadLine
                campo = Split(linea, vbTab)
                _valore(CInt(campo(0))).ValoreStringa = campo(2)
            End While
            ' Restituisce False
            CaricaDaFile = False

        Catch ex As Exception
            ' Restituisce True
            CaricaDaFile = True

        Finally
            ' Chiude il file
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try
    End Function


    Public Shared Function Esiste(ByVal nomeRicetta As String) As Boolean
        ' Restituisce True se la ricetta esiste, False altrimenti
        Esiste = File.Exists(mGlobale.PercorsoRicette & "\" & nomeRicetta & ".txt")
    End Function


    Public Sub Inizializza()
        Dim i As Integer

        ' Imposta tutti i valori di default
        For i = 0 To _numeroMassimoValori - 1
            If (_valore(i) IsNot Nothing) Then
                _valore(i).Valore = _valore(i).ValoreDefault
            End If
        Next
    End Sub


    Public Shared Function LeggiLista(ByRef nomeRicetta() As String) As Boolean
        ' Restituisce la lista delle ricette
        Try
            Dim di As New DirectoryInfo(mGlobale.PercorsoRicette)
            Dim fi As FileInfo() = di.GetFiles()
            ReDim nomeRicetta(0 To fi.Length - 1)
            For i = 0 To fi.Length - 1
                nomeRicetta(i) = Left(fi(i).Name, InStr(fi(i).Name, ".txt") - 1)
            Next
            LeggiLista = False

        Catch ex As Exception
            LeggiLista = True
        End Try
    End Function


    Public Function Salva(ByVal nomeRicetta As String) As Boolean
        ' Salva la ricetta
        Salva = SalvaSuFile(mGlobale.PercorsoRicette & "\" & nomeRicetta & ".txt")
    End Function


    Public Function SalvaSuFile(ByVal percorso As String) As Boolean
        Dim file As StreamWriter = Nothing

        Try
            ' Apre il file
            file = New StreamWriter(percorso)
            ' Carica tutti i valori
            For i = 0 To _numeroMassimoValori - 1
                If (_valore(i) IsNot Nothing) Then
                    file.WriteLine(i.ToString & _
                                   vbTab & _valore(i).Descrizione & _
                                   vbTab & _valore(i).ValoreStringa & _
                                   vbTab & _valore(i).UnitàDiMisura)
                End If
            Next
            ' Restituisce False
            SalvaSuFile = False

        Catch ex As Exception
            ' Restituisce True
            SalvaSuFile = True

        Finally
            ' Chiude il file
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try
    End Function


    Public Shared Function SonoUguali(ByVal ricetta1 As cRicetta, ByVal ricetta2 As cRicetta) As Boolean
        Dim i As Integer

        ' Restituisce True se le ricette sono uguali, False altrimenti
        SonoUguali = True
        For i = 0 To _numeroMassimoValori - 1
            If (i <> eIndice.DataOraCreazione And i <> eIndice.DataOraModifica) Then
                If ((ricetta1._valore(i) IsNot Nothing And ricetta2._valore(i) IsNot Nothing) AndAlso _
                    (ricetta1._valore(i).ValoreStringa <> ricetta2._valore(i).ValoreStringa)) Then
                    SonoUguali = False
                    Exit For
                End If
            End If
        Next
    End Function



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
End Class
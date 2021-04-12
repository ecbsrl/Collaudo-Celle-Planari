Option Explicit On
Option Strict On

Public Class cValoreRisultato
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    ' Enumerazione esito
    Public Enum eEsito
        NonProvato = 0
        Disabilitato = 1
        Sconosciuto = 2
        Ok = 3
        Ko = 4
    End Enum

    ' Enumerazione tipo
    Public Enum eTipo
        ValoreBoolean = 0
        ValoreEnum = 1
        ValoreInteger = 2
        ValoreSingle = 3
        ValoreString = 4
    End Enum



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Costanti private
    Private Const _numeroMassimoValoriEnum = 10
    Private Const _valoreStringaFalse = "FALSO"
    Private Const _valoreStringaTrue = "VERO"

    ' Proprietà generali
    Private _tipo As eTipo
    Private _simbolo As String
    Private _descrizione As String
    Private _unitàDiMisura As String
    Private _esito As eEsito

    ' Proprietà specifiche ValoreBoolean
    Private _valoreBoolean As Boolean

    ' Proprietà specifiche ValoreEnum
    Private _numeroValoriEnum As Integer
    Private _descrizioneValoreEnum(0 To _numeroMassimoValoriEnum - 1) As String
    Private _valoreEnum As Integer

    ' Proprietà specifiche ValoreInteger
    Private _valoreInteger As Integer
    Private _valoreIntegerMinimo As Integer
    Private _valoreIntegerMassimo As Integer

    ' Proprietà specifiche ValoreSingle
    Private _numeroDecimali As Integer
    Private _valoreSingle As Single
    Private _valoreSingleMinimo As Single
    Private _valoreSingleMassimo As Single

    ' Proprietà specifiche ValoreString
    Private _valoreString As String



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public Property Simbolo As String
        Get
            Simbolo = _simbolo
        End Get
        Set(value As String)
            _simbolo = value
        End Set
    End Property



    Public Property Descrizione As String
        Get
            Descrizione = _descrizione
        End Get
        Set(value As String)
            _descrizione = value
        End Set
    End Property



    Public Property DescrizioneValoreEnum(ByVal indice As Integer) As String
        Get
            DescrizioneValoreEnum = _descrizioneValoreEnum(indice)
        End Get
        Set(value As String)
            _descrizioneValoreEnum(indice) = value
        End Set
    End Property



    Public Property Esito As eEsito
        Get
            Esito = _esito
        End Get
        Set(value As eEsito)
            _esito = value
        End Set
    End Property



    Public Property NumeroDecimali As Integer
        Get
            NumeroDecimali = _numeroDecimali
        End Get
        Set(value As Integer)
            _numeroDecimali = value
            _valoreSingle = CSng(Math.Round(_valoreSingle, _numeroDecimali))
            _valoreSingleMinimo = CSng(Math.Round(_valoreSingleMinimo, _numeroDecimali))
            _valoreSingleMassimo = CSng(Math.Round(_valoreSingleMassimo, _numeroDecimali))
        End Set
    End Property



    Public Property NumeroValoriEnum As Integer
        Get
            NumeroValoriEnum = _numeroValoriEnum
        End Get
        Set(value As Integer)
            _numeroValoriEnum = value
        End Set
    End Property



    Public ReadOnly Property Tipo As eTipo
        Get
            Tipo = _tipo
        End Get
    End Property



    Public Property UnitàDiMisura As String
        Get
            UnitàDiMisura = _unitàDiMisura
        End Get
        Set(value As String)
            _unitàDiMisura = value
        End Set
    End Property



    Public Property Valore As Object
        Get
            If (_tipo = eTipo.ValoreBoolean) Then
                Valore = _valoreBoolean
            ElseIf (_tipo = eTipo.ValoreEnum) Then
                Valore = _valoreEnum
            ElseIf (_tipo = eTipo.ValoreInteger) Then
                Valore = _valoreInteger
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                Valore = _valoreSingle
            Else
                Valore = _valoreString
            End If
        End Get
        Set(value As Object)
            If (_tipo = eTipo.ValoreBoolean) Then
                _valoreBoolean = CBool(value)
            ElseIf (_tipo = eTipo.ValoreEnum) Then
                _valoreEnum = CInt(value)
            ElseIf (_tipo = eTipo.ValoreInteger) Then
                _valoreInteger = CInt(value)
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                _valoreSingle = CSng(Math.Round(CDec(value), _numeroDecimali))
            Else
                _valoreString = CStr(value)
            End If
        End Set
    End Property



    Public Property Massimo As Object
        Get
            If (_tipo = eTipo.ValoreInteger) Then
                Massimo = _valoreIntegerMassimo
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                Massimo = _valoreSingleMassimo
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore  risultato")
                Massimo = Nothing
            End If
        End Get
        Set(ByVal value As Object)
            If (_tipo = eTipo.ValoreInteger) Then
                _valoreIntegerMassimo = CInt(value)
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                _valoreSingleMassimo = CSng(Math.Round(CDec(value), _numeroDecimali))
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore  risultato")
            End If
        End Set
    End Property



    Public Property MassimoStringa As String
        Get
            If (_tipo = eTipo.ValoreInteger) Then
                MassimoStringa = _valoreIntegerMassimo.ToString
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                MassimoStringa = _valoreSingleMassimo.ToString(mUtilità.FormatoStringa(_numeroDecimali))
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore  risultato")
            End If
        End Get
        Set(ByVal value As String)
            If (_tipo = eTipo.ValoreInteger) Then
                Me.Massimo = CInt(value)
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                Me.Massimo = CSng(Math.Round(CDec(value), _numeroDecimali))
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore  risultato")
            End If
        End Set
    End Property



    Public Property Minimo As Object
        Get
            If (_tipo = eTipo.ValoreInteger) Then
                Minimo = _valoreIntegerMinimo
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                Minimo = _valoreSingleMinimo
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore  risultato")
                Minimo = Nothing
            End If
        End Get
        Set(ByVal value As Object)
            If (_tipo = eTipo.ValoreInteger) Then
                _valoreIntegerMinimo = CInt(value)
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                _valoreSingleMinimo = CSng(Math.Round(CDec(value), _numeroDecimali))
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore  risultato")
            End If
        End Set
    End Property



    Public Property MinimoStringa As String
        Get
            If (_tipo = eTipo.ValoreInteger) Then
                MinimoStringa = _valoreIntegerMinimo.ToString
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                MinimoStringa = _valoreSingleMinimo.ToString(mUtilità.FormatoStringa(_numeroDecimali))
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore risultato")
            End If
        End Get
        Set(ByVal value As String)
            If (_tipo = eTipo.ValoreInteger) Then
                Me.Minimo = CInt(value)
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                Me.Minimo = CSng(Math.Round(CDec(value), _numeroDecimali))
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore risultato")
            End If
        End Set
    End Property



    Public Property ValoreStringa As String
        Get
            If (_tipo = eTipo.ValoreBoolean) Then
                ValoreStringa = CStr(IIf(_valoreBoolean, _valoreStringaTrue, _valoreStringaFalse))
            ElseIf (_tipo = eTipo.ValoreEnum) Then
                ValoreStringa = _descrizioneValoreEnum(_valoreEnum)
            ElseIf (_tipo = eTipo.ValoreInteger) Then
                ValoreStringa = _valoreInteger.ToString
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                ValoreStringa = _valoreSingle.ToString(mUtilità.FormatoStringa(_numeroDecimali))
            Else
                ValoreStringa = _valoreString
            End If
        End Get
        Set(ByVal value As String)
            If (_tipo = eTipo.ValoreBoolean) Then
                Me.Valore = (value = _valoreStringaTrue)
            ElseIf (_tipo = eTipo.ValoreEnum) Then
                For i = 0 To _numeroValoriEnum - 1
                    If (value = _descrizioneValoreEnum(i)) Then
                        Me.Valore = i
                        Exit For
                    End If
                Next
            ElseIf (_tipo = eTipo.ValoreInteger) Then
                Me.Valore = CInt(value)
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                Me.Valore = CSng(Math.Round(CDec(value), _numeroDecimali))
            Else
                Me.Valore = CStr(value)
            End If
        End Set
    End Property



    '+------------------------------------------------------------------------------+
    '|                          Costruttore e distruttore                           |
    '+------------------------------------------------------------------------------+
    Public Sub New(ByVal tipo As eTipo)
        _tipo = tipo
    End Sub



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function Prova() As eEsito
        If (_tipo = eTipo.ValoreInteger) Then
            If (_valoreInteger >= _valoreIntegerMinimo And _valoreInteger <= _valoreIntegerMassimo) Then
                _esito = eEsito.Ok
            Else
                _esito = eEsito.Ko
            End If
        ElseIf (_tipo = eTipo.ValoreSingle) Then
            If (_valoreSingle >= _valoreSingleMinimo And _valoreSingle <= _valoreSingleMassimo) Then
                _esito = eEsito.Ok
            Else
                _esito = eEsito.Ko
            End If
        End If
        Prova = _esito
    End Function



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+

End Class

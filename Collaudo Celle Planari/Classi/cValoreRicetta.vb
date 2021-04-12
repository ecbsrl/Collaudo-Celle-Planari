Option Explicit On
Option Strict On

Public Class cValoreRicetta
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    ' Enum tipo
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
    Private _descrizione As String
    Private _unitàDiMisura As String

    ' Proprietà specifiche ValoreBoolean
    Private _valoreBoolean As Boolean
    Private _valoreBooleanDefault As Boolean

    ' Proprietà specifiche ValoreEnum
    Private _numeroValoriEnum As Integer
    Private _descrizioneValoreEnum(0 To _numeroMassimoValoriEnum - 1) As String
    Private _valoreEnum As Integer
    Private _valoreEnumDefault As Integer

    ' Proprietà specifiche ValoreInteger
    Private _valoreInteger As Integer
    Private _valoreIntegerMinimo As Integer
    Private _valoreIntegerDefault As Integer
    Private _valoreIntegerMassimo As Integer

    ' Proprietà specifiche ValoreSingle
    Private _numeroDecimali As Integer
    Private _valoreSingle As Single
    Private _valoreSingleMinimo As Single
    Private _valoreSingleDefault As Single
    Private _valoreSingleMassimo As Single

    ' Proprietà specifiche ValoreString
    Private _lunghezzaMassima As Integer
    Private _valoreString As String
    Private _valoreStringDefault As String



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
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
            If (_tipo = eTipo.ValoreEnum) Then
                DescrizioneValoreEnum = _descrizioneValoreEnum(indice)
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore ricetta")
                DescrizioneValoreEnum = ""
            End If
        End Get
        Set(value As String)
            If (_tipo = eTipo.ValoreEnum) Then
                _descrizioneValoreEnum(indice) = value
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore ricetta")
            End If
        End Set
    End Property



    Public Property LunghezzaMassima As Integer
        Get
            If (_tipo = eTipo.ValoreString) Then
                LunghezzaMassima = _lunghezzaMassima
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore ricetta")
                LunghezzaMassima = 0
            End If
        End Get
        Set(value As Integer)
            If (_tipo = eTipo.ValoreString) Then
                _lunghezzaMassima = value
                If (_valoreString.Length > _lunghezzaMassima) Then
                    _valoreString = Left(_valoreString, _lunghezzaMassima)
                End If
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore ricetta")
            End If
        End Set
    End Property



    Public Property NumeroDecimali As Integer
        Get
            If (_tipo = eTipo.ValoreSingle) Then
                NumeroDecimali = _numeroDecimali
            Else
                NumeroDecimali = 0
            End If
        End Get
        Set(value As Integer)
            If (_tipo = eTipo.ValoreSingle) Then
                _numeroDecimali = value
                _valoreSingleDefault = CSng(Math.Round(_valoreSingleDefault, _numeroDecimali))
                _valoreSingleMinimo = CSng(Math.Round(_valoreSingleMinimo, _numeroDecimali))
                _valoreSingleMassimo = CSng(Math.Round(_valoreSingleMassimo, _numeroDecimali))
                _valoreSingle = CSng(Math.Round(_valoreSingle, _numeroDecimali))
            End If
        End Set
    End Property



    Public Property NumeroValoriEnum As Integer
        Get
            If (_tipo = eTipo.ValoreEnum) Then
                NumeroValoriEnum = _numeroValoriEnum
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore ricetta")
                NumeroValoriEnum = 0
            End If
        End Get
        Set(value As Integer)
            If (_tipo = eTipo.ValoreEnum) Then
                _numeroValoriEnum = value
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore ricetta")
            End If
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
                If (_valoreEnum < 0) Then
                    _valoreEnum = 0
                ElseIf (_valoreEnum > _numeroValoriEnum - 1) Then
                    _valoreEnum = _numeroValoriEnum
                End If
            ElseIf (_tipo = eTipo.ValoreInteger) Then
                _valoreInteger = CInt(value)
                If (_valoreInteger < _valoreIntegerMinimo) Then
                    _valoreInteger = _valoreIntegerMinimo
                ElseIf (_valoreInteger > _valoreIntegerMassimo) Then
                    _valoreInteger = _valoreIntegerMassimo
                End If
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                _valoreSingle = CSng(Math.Round(CDec(value), _numeroDecimali))
                If (_valoreSingle < _valoreSingleMinimo) Then
                    _valoreSingle = _valoreSingleMinimo
                ElseIf (_valoreSingle > _valoreSingleMassimo) Then
                    _valoreSingle = _valoreSingleMassimo
                End If
            Else
                _valoreString = CStr(value)
                If (_valoreString.Length > _lunghezzaMassima) Then
                    _valoreString = Left(CStr(value), _lunghezzaMassima)
                Else
                End If
            End If
        End Set
    End Property



    Public Property ValoreDefault As Object
        Get
            If (_tipo = eTipo.ValoreBoolean) Then
                ValoreDefault = _valoreBooleanDefault
            ElseIf (_tipo = eTipo.ValoreEnum) Then
                ValoreDefault = _valoreEnumDefault
            ElseIf (_tipo = eTipo.ValoreInteger) Then
                ValoreDefault = _valoreIntegerDefault
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                ValoreDefault = _valoreSingleDefault
            Else
                ValoreDefault = _valoreStringDefault
            End If
        End Get
        Set(value As Object)
            If (_tipo = eTipo.ValoreBoolean) Then
                _valoreBooleanDefault = CBool(value)
            ElseIf (_tipo = eTipo.ValoreEnum) Then
                _valoreEnumDefault = CInt(value)
            ElseIf (_tipo = eTipo.ValoreInteger) Then
                _valoreIntegerDefault = CInt(value)
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                _valoreSingleDefault = CSng(Math.Round(CDec(value), _numeroDecimali))
            Else
                _valoreStringDefault = CStr(value)
            End If
        End Set
    End Property



    Public Property ValoreMassimo As Object
        Get
            If (_tipo = eTipo.ValoreInteger) Then
                ValoreMassimo = _valoreIntegerMassimo
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                ValoreMassimo = _valoreSingleMassimo
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore ricetta")
                ValoreMassimo = Nothing
            End If
        End Get
        Set(value As Object)
            If (_tipo = eTipo.ValoreInteger) Then
                _valoreIntegerMassimo = CInt(value)
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                _valoreSingleMassimo = CSng(Math.Round(CDec(value), _numeroDecimali))
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore ricetta")
            End If
        End Set
    End Property



    Public Property ValoreMinimo As Object
        Get
            If (_tipo = eTipo.ValoreInteger) Then
                ValoreMinimo = _valoreIntegerMinimo
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                ValoreMinimo = _valoreSingleMinimo
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore ricetta")
                ValoreMinimo = Nothing
            End If
        End Get
        Set(value As Object)
            If (_tipo = eTipo.ValoreInteger) Then
                _valoreIntegerMinimo = CInt(value)
            ElseIf (_tipo = eTipo.ValoreSingle) Then
                _valoreSingleMinimo = CSng(Math.Round(CDec(value), _numeroDecimali))
            Else
                Throw New ApplicationException("Proprietà non supportata da questo tipo di valore ricetta")
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
        Set(value As String)
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
                Me.Valore = CSng(value)
            Else
                Me.Valore = CStr(value)
            End If
        End Set
    End Property



    '+------------------------------------------------------------------------------+
    '|                          Costruttore e distruttore                           |
    '+------------------------------------------------------------------------------+
    Public Sub New(ByVal tipo As eTipo)
        ' Imposta il tipo di valore
        _tipo = tipo
        ' Proprietà generali
        _descrizione = ""
        _unitàDiMisura = ""
        ' Proprietà specifiche ValoreBoolean
        _valoreBoolean = False
        _valoreBooleanDefault = False
        ' Proprietà specifiche ValoreEnum
        _numeroValoriEnum = 0
        _valoreEnum = 0
        _valoreEnumDefault = 0
        ' Proprietà specifiche ValoreInteger
        _valoreInteger = 0
        _valoreIntegerMinimo = 0
        _valoreIntegerDefault = 0
        _valoreIntegerMassimo = 0
        ' Proprietà specifiche ValoreSingle
        _numeroDecimali = 0
        _valoreSingle = 0
        _valoreSingleMinimo = 0
        _valoreSingleDefault = 0
        _valoreSingleMassimo = 0
        ' Proprietà specifiche ValoreString
        _lunghezzaMassima = 0
        _valoreString = ""
        _valoreStringDefault = ""
    End Sub



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
End Class

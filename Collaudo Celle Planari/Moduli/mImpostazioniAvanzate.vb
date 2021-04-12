Option Explicit On
Option Strict On

Imports System.IO

Module mImpostazioniAvanzate
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    ' Costanti pubbliche

    ' Mass Flow Controller Ossigeno
    Public Const OffsetMinimoMFC_O2 = -0.01
    Public Const OffsetMassimoMFC_O2 = 0.01
    Public Const DecimaliOffsetMFC_O2 = 3
    Public Const MoltiplicatoreMinimoMFC_O2 = 0.9
    Public Const MoltiplicatoreMassimoMFC_O2 = 1.1
    Public Const DecimaliMoltiplicatoreMFC_O2 = 3

    ' Mass Flow Controller Azoto
    Public Const OffsetMinimoMFC_N2 = -0.01
    Public Const OffsetMassimoMFC_N2 = 0.01
    Public Const DecimaliOffsetMFC_N2 = 3
    Public Const MoltiplicatoreMinimoMFC_N2 = 0.9
    Public Const MoltiplicatoreMassimoMFC_N2 = 1.1
    Public Const DecimaliMoltiplicatoreMFC_N2 = 3

    ' Misurazione Tensione
    Public Const OffsetMinimoMisuraTensione = -0.01
    Public Const OffsetMassimoMisuraTensione = 0.01
    Public Const DecimaliOffsetMisuraTensione = 3
    Public Const MoltiplicatoreMinimoMisuraTensione = 0.9
    Public Const MoltiplicatoreMassimoMisuraTensione = 1.1
    Public Const DecimaliMoltiplicatoreMisuraTensione = 3

    ' Misurazione Resistenza
    Public Const OffsetMinimoMisuraResistenza = -0.05
    Public Const OffsetMassimoMisuraResistenza = 0.05
    Public Const DecimaliOffsetMisuraResistenza = 3
    Public Const MoltiplicatoreMinimoMisuraResistenza = 0.9
    Public Const MoltiplicatoreMassimoMisuraResistenza = 1.1
    Public Const DecimaliMoltiplicatoreMisuraResistenza = 3

    ' Misurazione Corrente
    Public Const OffsetMinimoMisuraCorrente = -1
    Public Const OffsetMassimoMisuraCorrente = 1
    Public Const DecimaliOffsetMisuraCorrente = 2
    Public Const MoltiplicatoreMinimoMisuraCorrente = 0.9
    Public Const MoltiplicatoreMassimoMisuraCorrente = 1.1
    Public Const DecimaliMoltiplicatoreMisuraCorrente = 3

    ' Misurazione LSU O2%
    Public Const OffsetMinimoLsuO2 = -1
    Public Const OffsetMassimoLsuO2 = 1
    Public Const DecimaliOffsetLsuO2 = 2
    Public Const MoltiplicatoreMinimoLsuO2 = 0.9
    Public Const MoltiplicatoreMassimoLsuO2 = 1.1
    Public Const DecimaliMoltiplicatoreLsuO2 = 3

    ' Misurazione ADV Lambda
    Public Const OffsetMinimoAdvLambda = -1
    Public Const OffsetMassimoAdvLambda = 1
    Public Const DecimaliOffsetAdvLambda = 3
    Public Const MoltiplicatoreMinimoAdvLambda = 0.9
    Public Const MoltiplicatoreMassimoAdvLambda = 1.1
    Public Const DecimaliMoltiplicatoreAdvLambda = 3

    ' Misurazione ADV Corrente Pumping
    Public Const OffsetMinimoAdvCorrentePumping = -1
    Public Const OffsetMassimoAdvCorrentePumping = 1
    Public Const DecimaliOffsetAdvCorrentePumping = 3
    Public Const MoltiplicatoreMinimoAdvCorrentePumping = 0.9
    Public Const MoltiplicatoreMassimoAdvCorrentePumping = 1.1
    Public Const DecimaliMoltiplicatoreAdvCorrentePumping = 3

    ' Misurazione ZFAS Corrente Pumping Etas
    Public Const OffsetMinimoZfasCorrentePumpingEtas = -1
    Public Const OffsetMassimoZfasCorrentePumpingEtas = 1
    Public Const DecimaliOffsetZfasCorrentePumpingEtas = 3
    Public Const MoltiplicatoreMinimoZfasCorrentePumpingEtas = 0.9
    Public Const MoltiplicatoreMassimoZfasCorrentePumpingEtas = 1.1
    Public Const DecimaliMoltiplicatoreZfasCorrentePumpingEtas = 3

    ' Misurazione ZFAS Corrente Pumping To
    Public Const OffsetMinimoZfasCorrentePumpingTb = -1
    Public Const OffsetMassimoZfasCorrentePumpingTb = 1
    Public Const DecimaliOffsetZfasCorrentePumpingTb = 3
    Public Const MoltiplicatoreMinimoZfasCorrentePumpingTb = 0.9
    Public Const MoltiplicatoreMassimoZfasCorrentePumpingTb = 1.1
    Public Const DecimaliMoltiplicatoreZfasCorrentePumpingTb = 3


    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _offsetMFC_O2 As Single
    Private _moltiplicatoreMFC_O2 As Single
    Private _offsetMFC_N2 As Single
    Private _moltiplicatoreMFC_N2 As Single
    Private _offsetMisuraTensione As Single
    Private _moltiplicatoreMisuraTensione As Single
    Private _offsetMisuraResistenza As Single
    Private _moltiplicatoreMisuraResistenza As Single
    Private _offsetMisuraCorrente As Single
    Private _moltiplicatoreMisuraCorrente As Single
    Private _offsetLsuO2 As Single
    Private _moltiplicatoreLsuO2 As Single
    Private _offsetAdvLambda As Single
    Private _moltiplicatoreAdvLambda As Single
    Private _offsetAdvCorrentePumping As Single
    Private _moltiplicatoreAdvCorrentePumping As Single
    Private _offsetZfasCorrentePumpingEtas As Single
    Private _moltiplicatoreZfasCorrentePumpingEtas As Single
    Private _offsetZfasCorrentePumpingTb As Single
    Private _moltiplicatoreZfasCorrentePumpingTb As Single



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public Property OffsetMFC_O2 As Single
        Get
            OffsetMFC_O2 = _offsetMFC_O2
        End Get
        Set(value As Single)
            If (value < OffsetMinimoMFC_O2) Then
                _offsetMFC_O2 = OffsetMinimoMFC_O2
            ElseIf (value > OffsetMassimoMFC_O2) Then
                _offsetMFC_O2 = OffsetMassimoMFC_O2
            Else
                _offsetMFC_O2 = CSng(Math.Round(value, DecimaliOffsetMFC_O2))
            End If
        End Set
    End Property



    Public Property MoltiplicatoreMFC_O2 As Single
        Get
            MoltiplicatoreMFC_O2 = _moltiplicatoreMFC_O2
        End Get
        Set(value As Single)
            If (value < MoltiplicatoreMinimoMFC_O2) Then
                _moltiplicatoreMFC_O2 = MoltiplicatoreMinimoMFC_O2
            ElseIf (value > MoltiplicatoreMassimoMFC_O2) Then
                _moltiplicatoreMFC_O2 = MoltiplicatoreMassimoMFC_O2
            Else
                _moltiplicatoreMFC_O2 = CSng(Math.Round(value, DecimaliMoltiplicatoreMFC_O2))
            End If
        End Set
    End Property



    Public Property OffsetMFC_N2 As Single
        Get
            OffsetMFC_N2 = _offsetMFC_N2
        End Get
        Set(value As Single)
            If (value < OffsetMinimoMFC_N2) Then
                _offsetMFC_N2 = OffsetMinimoMFC_N2
            ElseIf (value > OffsetMassimoMFC_N2) Then
                _offsetMFC_N2 = OffsetMassimoMFC_N2
            Else
                _offsetMFC_N2 = CSng(Math.Round(value, DecimaliOffsetMFC_N2))
            End If
        End Set
    End Property



    Public Property MoltiplicatoreMFC_N2 As Single
        Get
            MoltiplicatoreMFC_N2 = _moltiplicatoreMFC_N2
        End Get
        Set(value As Single)
            If (value < MoltiplicatoreMinimoMFC_N2) Then
                _moltiplicatoreMFC_N2 = MoltiplicatoreMinimoMFC_N2
            ElseIf (value > MoltiplicatoreMassimoMFC_N2) Then
                _moltiplicatoreMFC_N2 = MoltiplicatoreMassimoMFC_N2
            Else
                _moltiplicatoreMFC_N2 = CSng(Math.Round(value, DecimaliMoltiplicatoreMFC_N2))
            End If
        End Set
    End Property



    Public Property OffsetMisuraTensione As Single
        Get
            OffsetMisuraTensione = _offsetMisuraTensione
        End Get
        Set(value As Single)
            If (value < OffsetMinimoMisuraTensione) Then
                _offsetMisuraTensione = OffsetMinimoMisuraTensione
            ElseIf (value > OffsetMassimoMisuraTensione) Then
                _offsetMisuraTensione = OffsetMassimoMisuraTensione
            Else
                _offsetMisuraTensione = CSng(Math.Round(value, DecimaliOffsetMisuraTensione))
            End If
        End Set
    End Property



    Public Property MoltiplicatoreMisuraTensione As Single
        Get
            MoltiplicatoreMisuraTensione = _moltiplicatoreMisuraTensione
        End Get
        Set(value As Single)
            If (value < MoltiplicatoreMinimoMisuraTensione) Then
                _moltiplicatoreMisuraTensione = MoltiplicatoreMinimoMisuraTensione
            ElseIf (value > MoltiplicatoreMassimoMisuraTensione) Then
                _moltiplicatoreMisuraTensione = MoltiplicatoreMassimoMisuraTensione
            Else
                _moltiplicatoreMisuraTensione = CSng(Math.Round(value, DecimaliMoltiplicatoreMisuraTensione))
            End If
        End Set
    End Property



    Public Property OffsetMisuraResistenza As Single
        Get
            OffsetMisuraResistenza = _offsetMisuraResistenza
        End Get
        Set(value As Single)
            If (value < OffsetMinimoMisuraResistenza) Then
                _offsetMisuraResistenza = OffsetMinimoMisuraResistenza
            ElseIf (value > OffsetMassimoMisuraResistenza) Then
                _offsetMisuraResistenza = OffsetMassimoMisuraResistenza
            Else
                _offsetMisuraResistenza = CSng(Math.Round(value, DecimaliOffsetMisuraResistenza))
            End If
        End Set
    End Property



    Public Property MoltiplicatoreMisuraResistenza As Single
        Get
            MoltiplicatoreMisuraResistenza = _moltiplicatoreMisuraResistenza
        End Get
        Set(value As Single)
            If (value < MoltiplicatoreMinimoMisuraResistenza) Then
                _moltiplicatoreMisuraResistenza = MoltiplicatoreMinimoMisuraResistenza
            ElseIf (value > MoltiplicatoreMassimoMisuraResistenza) Then
                _moltiplicatoreMisuraResistenza = MoltiplicatoreMassimoMisuraResistenza
            Else
                _moltiplicatoreMisuraResistenza = CSng(Math.Round(value, DecimaliMoltiplicatoreMisuraResistenza))
            End If
        End Set
    End Property



    Public Property OffsetMisuraCorrente As Single
        Get
            OffsetMisuraCorrente = _offsetMisuraCorrente
        End Get
        Set(value As Single)
            If (value < OffsetMinimoMisuraCorrente) Then
                _offsetMisuraCorrente = OffsetMinimoMisuraCorrente
            ElseIf (value > OffsetMassimoMisuraCorrente) Then
                _offsetMisuraCorrente = OffsetMassimoMisuraCorrente
            Else
                _offsetMisuraCorrente = CSng(Math.Round(value, DecimaliOffsetMisuraCorrente))
            End If
        End Set
    End Property



    Public Property MoltiplicatoreMisuraCorrente As Single
        Get
            MoltiplicatoreMisuraCorrente = _moltiplicatoreMisuraCorrente
        End Get
        Set(value As Single)
            If (value < MoltiplicatoreMinimoMisuraCorrente) Then
                _moltiplicatoreMisuraCorrente = MoltiplicatoreMinimoMisuraCorrente
            ElseIf (value > MoltiplicatoreMassimoMisuraCorrente) Then
                _moltiplicatoreMisuraCorrente = MoltiplicatoreMassimoMisuraCorrente
            Else
                _moltiplicatoreMisuraCorrente = CSng(Math.Round(value, DecimaliMoltiplicatoreMisuraCorrente))
            End If
        End Set
    End Property



    Public Property OffsetLsuO2 As Single
        Get
            OffsetLsuO2 = _offsetLsuO2
        End Get
        Set(value As Single)
            If (value < OffsetMinimoLsuO2) Then
                _offsetLsuO2 = OffsetMinimoLsuO2
            ElseIf (value > OffsetMassimoLsuO2) Then
                _offsetLsuO2 = OffsetMassimoLsuO2
            Else
                _offsetLsuO2 = CSng(Math.Round(value, DecimaliOffsetLsuO2))
            End If
        End Set
    End Property



    Public Property MoltiplicatoreLsuO2 As Single
        Get
            MoltiplicatoreLsuO2 = _moltiplicatoreLsuO2
        End Get
        Set(value As Single)
            If (value < MoltiplicatoreMinimoLsuO2) Then
                _moltiplicatoreLsuO2 = MoltiplicatoreMinimoLsuO2
            ElseIf (value > MoltiplicatoreMassimoLsuO2) Then
                _moltiplicatoreLsuO2 = MoltiplicatoreMassimoLsuO2
            Else
                _moltiplicatoreLsuO2 = CSng(Math.Round(value, DecimaliMoltiplicatoreLsuO2))
            End If
        End Set
    End Property



    Public Property OffsetAdvLambda As Single
        Get
            OffsetAdvLambda = _offsetAdvLambda
        End Get
        Set(value As Single)
            If (value < OffsetMinimoAdvLambda) Then
                _offsetAdvLambda = OffsetMinimoAdvLambda
            ElseIf (value > OffsetMassimoAdvLambda) Then
                _offsetAdvLambda = OffsetMassimoAdvLambda
            Else
                _offsetAdvLambda = CSng(Math.Round(value, DecimaliOffsetAdvLambda))
            End If
        End Set
    End Property



    Public Property MoltiplicatoreAdvLambda As Single
        Get
            MoltiplicatoreAdvLambda = _moltiplicatoreAdvLambda
        End Get
        Set(value As Single)
            If (value < MoltiplicatoreMinimoAdvLambda) Then
                _moltiplicatoreAdvLambda = MoltiplicatoreMinimoAdvLambda
            ElseIf (value > MoltiplicatoreMassimoAdvLambda) Then
                _moltiplicatoreAdvLambda = MoltiplicatoreMassimoAdvLambda
            Else
                _moltiplicatoreAdvLambda = CSng(Math.Round(value, DecimaliMoltiplicatoreAdvLambda))
            End If
        End Set
    End Property



    Public Property OffsetAdvCorrentePumping As Single
        Get
            OffsetAdvCorrentePumping = _offsetAdvCorrentePumping
        End Get
        Set(value As Single)
            If (value < OffsetMinimoAdvCorrentePumping) Then
                _offsetAdvCorrentePumping = OffsetMinimoAdvCorrentePumping
            ElseIf (value > OffsetMassimoAdvCorrentePumping) Then
                _offsetAdvCorrentePumping = OffsetMassimoAdvCorrentePumping
            Else
                _offsetAdvCorrentePumping = CSng(Math.Round(value, DecimaliOffsetAdvCorrentePumping))
            End If
        End Set
    End Property



    Public Property MoltiplicatoreAdvCorrentePumping As Single
        Get
            MoltiplicatoreAdvCorrentePumping = _moltiplicatoreAdvCorrentePumping
        End Get
        Set(value As Single)
            If (value < MoltiplicatoreMinimoAdvCorrentePumping) Then
                _moltiplicatoreAdvCorrentePumping = MoltiplicatoreMinimoAdvCorrentePumping
            ElseIf (value > MoltiplicatoreMassimoAdvCorrentePumping) Then
                _moltiplicatoreAdvCorrentePumping = MoltiplicatoreMassimoAdvCorrentePumping
            Else
                _moltiplicatoreAdvCorrentePumping = CSng(Math.Round(value, DecimaliMoltiplicatoreAdvCorrentePumping))
            End If
        End Set
    End Property



    Public Property OffsetZfasCorrentePumpingEtas As Single
        Get
            OffsetZfasCorrentePumpingEtas = _offsetZfasCorrentePumpingEtas
        End Get
        Set(value As Single)
            If (value < OffsetMinimoZfasCorrentePumpingEtas) Then
                _offsetZfasCorrentePumpingEtas = OffsetMinimoZfasCorrentePumpingEtas
            ElseIf (value > OffsetMassimoZfasCorrentePumpingEtas) Then
                _offsetZfasCorrentePumpingEtas = OffsetMassimoZfasCorrentePumpingEtas
            Else
                _offsetZfasCorrentePumpingEtas = CSng(Math.Round(value, DecimaliOffsetZfasCorrentePumpingEtas))
            End If
        End Set
    End Property



    Public Property MoltiplicatoreZfasCorrentePumpingEtas As Single
        Get
            MoltiplicatoreZfasCorrentePumpingEtas = _moltiplicatoreZfasCorrentePumpingEtas
        End Get
        Set(value As Single)
            If (value < MoltiplicatoreMinimoZfasCorrentePumpingEtas) Then
                _moltiplicatoreZfasCorrentePumpingEtas = MoltiplicatoreMinimoZfasCorrentePumpingEtas
            ElseIf (value > MoltiplicatoreMassimoZfasCorrentePumpingEtas) Then
                _moltiplicatoreZfasCorrentePumpingEtas = MoltiplicatoreMassimoZfasCorrentePumpingEtas
            Else
                _moltiplicatoreZfasCorrentePumpingEtas = CSng(Math.Round(value, DecimaliMoltiplicatoreZfasCorrentePumpingEtas))
            End If
        End Set
    End Property




    Public Property OffsetZfasCorrentePumpingTb As Single
        Get
            OffsetZfasCorrentePumpingTb = _offsetZfasCorrentePumpingTb
        End Get
        Set(value As Single)
            If (value < OffsetMinimoZfasCorrentePumpingTb) Then
                _offsetZfasCorrentePumpingTb = OffsetMinimoZfasCorrentePumpingTb
            ElseIf (value > OffsetMassimoZfasCorrentePumpingTb) Then
                _offsetZfasCorrentePumpingTb = OffsetMassimoZfasCorrentePumpingTb
            Else
                _offsetZfasCorrentePumpingTb = CSng(Math.Round(value, DecimaliOffsetZfasCorrentePumpingTb))
            End If
        End Set
    End Property



    Public Property MoltiplicatoreZfasCorrentePumpingTb As Single
        Get
            MoltiplicatoreZfasCorrentePumpingTb = _moltiplicatoreZfasCorrentePumpingTb
        End Get
        Set(value As Single)
            If (value < MoltiplicatoreMinimoZfasCorrentePumpingTb) Then
                _moltiplicatoreZfasCorrentePumpingTb = MoltiplicatoreMinimoZfasCorrentePumpingTb
            ElseIf (value > MoltiplicatoreMassimoZfasCorrentePumpingTb) Then
                _moltiplicatoreZfasCorrentePumpingTb = MoltiplicatoreMassimoZfasCorrentePumpingTb
            Else
                _moltiplicatoreZfasCorrentePumpingTb = CSng(Math.Round(value, DecimaliMoltiplicatoreZfasCorrentePumpingTb))
            End If
        End Set
    End Property



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function Carica(ByVal nomeFile As String) As Boolean
        Dim campo() As String
        Dim file As StreamReader = Nothing
        Dim linea As String

        Try
            ' Apre il file
            file = New StreamReader(nomeFile)
            ' Legge il contenuto del file
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            OffsetMFC_O2 = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            MoltiplicatoreMFC_O2 = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            OffsetMFC_N2 = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            MoltiplicatoreMFC_N2 = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            OffsetMisuraTensione = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            MoltiplicatoreMisuraTensione = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            OffsetMisuraResistenza = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            MoltiplicatoreMisuraResistenza = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            OffsetMisuraCorrente = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            MoltiplicatoreMisuraCorrente = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            OffsetLsuO2 = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            MoltiplicatoreLsuO2 = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            OffsetAdvLambda = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            MoltiplicatoreAdvLambda = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            OffsetAdvCorrentePumping = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            MoltiplicatoreAdvCorrentePumping = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            OffsetZfasCorrentePumpingEtas = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            MoltiplicatoreZfasCorrentePumpingEtas = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            OffsetZfasCorrentePumpingTb = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            MoltiplicatoreZfasCorrentePumpingTb = CSng(campo(1))
            ' Restituisce False
            Carica = False

        Catch ex As Exception
            ' Restituisce True
            Carica = True

        Finally
            ' Chiude il file
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try
    End Function



    Public Function Salva(ByVal nomeFile As String) As Boolean
        Dim file As StreamWriter = Nothing

        Try
            ' Apre il file
            file = New StreamWriter(nomeFile)
            ' Legge il contenuto del file
            file.WriteLine("Offset Mass Flow Controller O2 - NL/minuto" & vbTab & _offsetMFC_O2.ToString(mUtilità.FormatoStringa(DecimaliOffsetMFC_O2)))
            file.WriteLine("Moltiplicatore Mass Flow Controller O2" & vbTab & _moltiplicatoreMFC_O2.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreMFC_O2)))
            file.WriteLine("Offset Mass Flow Controller N2 - NL/minuto" & vbTab & _offsetMFC_N2.ToString(mUtilità.FormatoStringa(DecimaliOffsetMFC_N2)))
            file.WriteLine("Moltiplicatore Mass Flow Controller N2" & vbTab & _moltiplicatoreMFC_N2.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreMFC_N2)))
            file.WriteLine("Offset Misura Tensione - V" & vbTab & _offsetMisuraTensione.ToString(mUtilità.FormatoStringa(DecimaliOffsetMisuraTensione)))
            file.WriteLine("Moltiplicatore Misura Tensione" & vbTab & _moltiplicatoreMisuraTensione.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreMisuraTensione)))
            file.WriteLine("Offset misura portata / Nl/min" & vbTab & _offsetMisuraResistenza.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreMisuraResistenza)))
            file.WriteLine("Moltiplicatore misura portata" & vbTab & _moltiplicatoreMisuraResistenza.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreMisuraResistenza)))
            file.WriteLine("Offset misura posizione / mm" & vbTab & _offsetMisuraCorrente.ToString(mUtilità.FormatoStringa(DecimaliOffsetMisuraCorrente)))
            file.WriteLine("Moltiplicatore misura posizione" & vbTab & _moltiplicatoreMisuraCorrente.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreMisuraCorrente)))
            file.WriteLine("Offset LSU O2 / %" & vbTab & _offsetLsuO2.ToString(mUtilità.FormatoStringa(DecimaliOffsetLsuO2)))
            file.WriteLine("Moltiplicatore LSU O2" & vbTab & _moltiplicatoreLsuO2.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreLsuO2)))
            file.WriteLine("Offset ADV Lambda / -" & vbTab & _offsetAdvLambda.ToString(mUtilità.FormatoStringa(DecimaliOffsetAdvLambda)))
            file.WriteLine("Moltiplicatore ADV Lambda" & vbTab & _moltiplicatoreAdvLambda.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreAdvLambda)))
            file.WriteLine("Offset ADV Corrente Pumping / mA" & vbTab & _offsetAdvCorrentePumping.ToString(mUtilità.FormatoStringa(DecimaliOffsetAdvCorrentePumping)))
            file.WriteLine("Moltiplicatore ADV Corrente Pumping" & vbTab & _moltiplicatoreAdvCorrentePumping.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreAdvCorrentePumping)))
            file.WriteLine("Offset ZFAS Corrente Pumping Etas / mA" & vbTab & _offsetZfasCorrentePumpingEtas.ToString(mUtilità.FormatoStringa(DecimaliOffsetZfasCorrentePumpingEtas)))
            file.WriteLine("Moltiplicatore Corrente Pumping Etas" & vbTab & _moltiplicatoreZfasCorrentePumpingEtas.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreZfasCorrentePumpingEtas)))
            file.WriteLine("Offset LSU Corrente Pumping TB / mA" & vbTab & _offsetZfasCorrentePumpingTb.ToString(mUtilità.FormatoStringa(DecimaliOffsetZfasCorrentePumpingTb)))
            file.WriteLine("Moltiplicatore Corrente Pumping TB" & vbTab & _moltiplicatoreZfasCorrentePumpingTb.ToString(mUtilità.FormatoStringa(DecimaliMoltiplicatoreZfasCorrentePumpingTb)))
            ' Restituisce False
            Salva = False

        Catch ex As Exception
            ' Restituisce True
            Salva = True

        Finally
            ' Chiude il file
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try
    End Function



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
End Module

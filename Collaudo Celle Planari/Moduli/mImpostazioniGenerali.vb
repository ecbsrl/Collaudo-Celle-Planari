Option Explicit On
Option Strict On

Imports System.IO

Module mImpostazioniGenerali
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _abilitazioneCicliMaster As Boolean
    Private _abilitazioneCicloInterrottoSuScarto As Boolean
    Private _cartellaBackup As String
    Private _cartellaBackupLotti As String
    Private _cartellaBackupRicette As String
    Private _cartellaBackupTarature As String
    Private _cicliTotaliStazione As Integer
    Private _flussoAriaTaratura As Single
    Private _flussoAzotoTaratura As Single



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public Property AbilitazioneCicliMaster As Boolean
        Get
            AbilitazioneCicliMaster = _abilitazioneCicliMaster
        End Get
        Set(value As Boolean)
            _abilitazioneCicliMaster = value
        End Set
    End Property


    Public Property AbilitazioneCicloInterrottoSuScarto As Boolean
        Get
            AbilitazioneCicloInterrottoSuScarto = _abilitazioneCicloInterrottoSuScarto
        End Get
        Set(value As Boolean)
            _abilitazioneCicloInterrottoSuScarto = value
        End Set
    End Property


    Public Property CartellaBackup As String
        Get
            CartellaBackup = _cartellaBackup
        End Get
        Set(value As String)
            _cartellaBackup = value
        End Set
    End Property


    Public Property CartellaBackupLotti As String
        Get
            CartellaBackupLotti = _cartellaBackupLotti
        End Get
        Set(value As String)
            _cartellaBackupLotti = value
        End Set
    End Property



    Public Property CartellaBackupRicette As String
        Get
            CartellaBackupRicette = _cartellaBackupRicette
        End Get
        Set(value As String)
            _cartellaBackupRicette = value
        End Set
    End Property



    Public Property CartellaBackupTarature As String
        Get
            CartellaBackupTarature = _cartellaBackupTarature
        End Get
        Set(value As String)
            _cartellaBackupTarature = value
        End Set
    End Property



    Public Property CicliTotaliStazione As Integer
        Get
            CicliTotaliStazione = _cicliTotaliStazione
        End Get
        Set(value As Integer)
            _cicliTotaliStazione = value
        End Set
    End Property


    Public Property FlussoAriaTaratura As Single
        Get
            FlussoAriaTaratura = _flussoAriaTaratura
        End Get
        Set(value As Single)
            _flussoAriaTaratura = value
        End Set
    End Property


    Public Property FlussoAzotoTaratura As Single
        Get
            FlussoAzotoTaratura = _flussoAzotoTaratura
        End Get
        Set(value As Single)
            _flussoAzotoTaratura = value
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
            _abilitazioneCicliMaster = CBool(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _abilitazioneCicloInterrottoSuScarto = CBool(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _cartellaBackup = campo(1)
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _cartellaBackupLotti = campo(1)
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _cartellaBackupRicette = campo(1)
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _cartellaBackupTarature = campo(1)
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _cicliTotaliStazione = CInt(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _flussoAriaTaratura = CSng(campo(1))
            '
            linea = file.ReadLine
            campo = Split(linea, vbTab)
            _flussoAzotoTaratura = CSng(campo(1))

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
            file.WriteLine("Abilitazione cicli master" & vbTab & _abilitazioneCicliMaster.ToString)
            file.WriteLine("Abilitazione ciclo interrotto su scarto" & vbTab & _abilitazioneCicloInterrottoSuScarto.ToString)
            file.WriteLine("Cartella backup generale" & vbTab & _cartellaBackup)
            file.WriteLine("Cartella backup lotti" & vbTab & _cartellaBackupLotti)
            file.WriteLine("Cartella backup ricette" & vbTab & _cartellaBackupRicette)
            file.WriteLine("Cartella backup tarature" & vbTab & _cartellaBackupTarature)
            file.WriteLine("Cicli totali stazione" & vbTab & _cicliTotaliStazione.ToString)
            file.WriteLine("Flusso Aria per Taratura" & vbTab & _flussoAriaTaratura.ToString)
            file.WriteLine("Flusso Azoto per Taratura" & vbTab & _flussoAzotoTaratura.ToString)
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

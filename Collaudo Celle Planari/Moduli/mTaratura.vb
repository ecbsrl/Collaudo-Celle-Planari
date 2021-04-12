Option Explicit On
Option Strict On

Imports System.IO

Module mTaratura
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    Public Const IntervalloTaratura = 365



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    Private _dataTaratura As Date



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public Property DataTaratura As Date
        Get
            DataTaratura = _dataTaratura
        End Get
        Set(ByVal value As Date)
            _dataTaratura = value
        End Set
    End Property



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function CaricaDataTaratura() As Boolean
        Dim campo() As String
        Dim linea As String
        Dim sr As StreamReader = Nothing

        Try
            ' Apre il file
            sr = New StreamReader(mGlobale.NomeFileDataTaratura)
            ' Legge il contenuto del file
            linea = sr.ReadLine
            campo = Split(linea, vbTab)
            _dataTaratura = CDate(campo(1))
            ' Restituisce False
            CaricaDataTaratura = False

        Catch ex As Exception
            ' Restituisce True
            CaricaDataTaratura = True

        Finally
            ' Chiude il file
            If (sr IsNot Nothing) Then
                sr.Close()
                sr = Nothing
            End If
        End Try
    End Function



    Public Function SalvaDataTaratura() As Boolean
        Dim sw As StreamWriter = Nothing

        Try
            ' Apre il file
            sw = New StreamWriter(mGlobale.NomeFileDataTaratura)
            ' Scrive il contenuto del file
            sw.WriteLine("Data ultima taratura" & vbTab & Format(_dataTaratura, "dd/MM/yyyy"))
            ' Restituisce False
            SalvaDataTaratura = False

        Catch ex As Exception
            ' Restituisce True
            SalvaDataTaratura = True

        Finally
            ' Chiude il file
            If (sw IsNot Nothing) Then
                sw.Close()
                sw = Nothing
            End If
        End Try
    End Function



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
End Module

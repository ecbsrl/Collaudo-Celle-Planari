Option Explicit On
Option Strict On

Public Class cTimer
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _abilitazione As Boolean
    Private _intervallo As Single
    Private _t0 As Date



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public ReadOnly Property Stato As Boolean
        Get
            ' Restituisce True se il timer è abilitato ed è trascorso l'intervallo, False altrimenti
            Stato = (_abilitazione AndAlso ((Date.Now - _t0).TotalSeconds >= _intervallo))
        End Get
    End Property



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Sub Pilota(ByVal abilitazione As Boolean, _
                      ByVal intervallo As Single)
        ' Se l'abilitazione passa da False a True
        If (_abilitazione = False And abilitazione = True) Then
            ' Memorizza l'intervallo
            _intervallo = intervallo
            ' Memorizza il tempo
            _t0 = Date.Now
        End If
        ' Memorizza lo stato dell'abilitazione
        _abilitazione = abilitazione
    End Sub



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
End Class
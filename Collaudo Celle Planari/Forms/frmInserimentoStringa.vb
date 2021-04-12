Option Explicit On
Option Strict On

Public Class frmInserimentoStringa
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _descrizione As String
    Private _lunghezzaMassima As Integer
    Private _valore As String
    Private _valoreConfermato As Boolean



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public Property Descrizione As String
        Get
            Descrizione = _descrizione
        End Get
        Set(ByVal value As String)
            _descrizione = value
        End Set
    End Property



    Public Property LunghezzaMassima As Integer
        Get
            LunghezzaMassima = _lunghezzaMassima
        End Get
        Set(ByVal value As Integer)
            _lunghezzaMassima = value
        End Set
    End Property



    Public Property Valore As String
        Get
            Valore = _valore
        End Get
        Set(ByVal value As String)
            _valore = value
        End Set
    End Property



    Public ReadOnly Property ValoreConfermato As Boolean
        Get
            ValoreConfermato = _valoreConfermato
        End Get
    End Property



    '+------------------------------------------------------------------------------+
    '|                          Costruttore e distruttore                           |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        ' Resetta il flag di valore confermato
        _valoreConfermato = False
        ' Chiude la finestra
        Me.Close()
    End Sub



    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        ' Memorizza il valore
        _valore = tbValore.Text
        ' Setta il flag di valore confermato
        _valoreConfermato = True
        ' Chiude la finestra
        Me.Close()
    End Sub



    Private Sub frmImmissioneValore_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        ' Se è stato premuto il tasto Esc
        If (e.KeyChar = ChrW(Keys.Escape)) Then
            ' Simula la pressione del pulsante Annulla
            btnAnnulla.PerformClick()
            e.Handled = True
        ElseIf (e.KeyChar = ChrW(Keys.Return)) Then     ' Altrimenti, se è stato premuto il tasto Enter
            ' Simula la pressione del pulsante Ok
            btnOk.PerformClick()
            e.Handled = True
        Else ' Altrimenti, se è stato premuto un altro tasto
            ' Gestisce l'evento normalmente
            e.Handled = False
        End If
    End Sub



    Private Sub frmImmissioneValore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Visualizza la descrizione
        labDescrizione.Text = _descrizione
        ' Visualizza, evidenzia e seleziona il valore
        tbValore.MaxLength = _lunghezzaMassima
        tbValore.Text = _valore
        tbValore.SelectionStart = 0
        tbValore.SelectionLength = tbValore.Text.Length
        tbValore.Select()
        ' Resetta il flag di valore confermato
        _valoreConfermato = False
    End Sub
End Class
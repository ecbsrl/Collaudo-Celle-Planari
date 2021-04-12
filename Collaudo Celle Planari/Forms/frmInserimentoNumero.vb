Option Explicit On
Option Strict On

Public Class frmInserimentoNumero
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _decimali As Integer
    Private _descrizione As String
    Private _massimo As Double
    Private _minimo As Double
    Private _valore As Double
    Private _valoreConfermato As Boolean



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public Property Decimali As Integer
        Get
            Decimali = _decimali
        End Get
        Set(ByVal value As Integer)
            _decimali = value
        End Set
    End Property



    Public Property Descrizione As String
        Get
            Descrizione = _descrizione
        End Get
        Set(ByVal value As String)
            _descrizione = value
        End Set
    End Property



    Public Property Massimo As Double
        Get
            Massimo = _Massimo
        End Get
        Set(ByVal value As Double)
            _massimo = Math.Round(value, _decimali)
        End Set
    End Property



    Public Property Minimo As Double
        Get
            Minimo = _minimo
        End Get
        Set(ByVal value As Double)
            _minimo = Math.Round(value, _decimali)
        End Set
    End Property



    Public Property Valore As Double
        Get
            Valore = _valore
        End Get
        Set(ByVal value As Double)
            _valore = Math.Round(value, _decimali)
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
        ' Se il valore è convertibile in Double
        If (Double.TryParse(tbValore.Text, _valore)) Then
            ' Arrotonda il valore
            _valore = CSng(Math.Round(_valore, _decimali))
            ' Se il valore è compreso tra minimo e massimo
            If (_valore >= _minimo And _valore <= _massimo) Then
                ' Setta il flag di valore confermato
                _valoreConfermato = True
                ' Chiude la finestra
                Me.Close()
            Else    ' Altrimenti, se il valore non è compreso tra minimo e massimo
                ' Visualizza un messaggio d'errore
                MsgBox(String.Format("Il valore deve essere compreso tra {0} e {1}.", _
                                     _minimo.ToString(mUtilità.FormatoStringa(_decimali)), _
                                     _massimo.ToString(mUtilità.FormatoStringa(_decimali))), _
                       CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                       "Errore")
                ' Visualizza, evidenzia e seleziona il valore
                tbValore.Text = _valore.ToString(mUtilità.FormatoStringa(_decimali))
                tbValore.SelectionStart = 0
                tbValore.SelectionLength = tbValore.Text.Length
                tbValore.Select()
            End If
        Else    ' Altrimenti, se il valore non è convertibile in Double
            ' Visualizza un messaggio d'errore
            MsgBox("Il valore immesso non è valido.", _
                   CType(vbCritical + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                   "Errore")
        End If
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
        tbValore.Text = _valore.ToString(mUtilità.FormatoStringa(_decimali))
        tbValore.SelectionStart = 0
        tbValore.SelectionLength = tbValore.Text.Length
        tbValore.Select()
        ' Resetta il flag di valore confermato
        _valoreConfermato = False
    End Sub
End Class
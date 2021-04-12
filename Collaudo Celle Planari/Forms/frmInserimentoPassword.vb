Option Explicit On
Option Strict On

Public Class frmInserimentoPassword
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _descrizione As String
    Private _password As String
    Private _passwordConfermata As Boolean



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



    Public Property Password As String
        Get
            Password = _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property



    Public ReadOnly Property PasswordConfermata As Boolean
        Get
            PasswordConfermata = _passwordConfermata
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
        ' Resetta il flag di password confermata
        _passwordConfermata = False
        ' Chiude la finestra
        Me.Close()
    End Sub



    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        ' Memorizza la password
        _password = tbPassword.text
        ' Setta il flag di password confermata
        _passwordConfermata = True
        ' Chiude la finestra
        Me.Close()
    End Sub



    Private Sub chkNascondiCaratteri_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkNascondiCaratteri.CheckedChanged
        ' Nasconde o mostra i caratteri della password
        If (chkNascondiCaratteri.Checked) Then
            tbPassword.PasswordChar = "*"c
        Else
            tbPassword.PasswordChar = Chr(0)
        End If
        tbPassword.Select()
    End Sub



    Private Sub frmInserimentoPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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



    Private Sub frmInserimentoPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Resetta il flag di password confermata
        _passwordConfermata = False
        ' Visualizza la descrizione
        labDescrizione.Text = _descrizione
        ' Svuota e seleziona la password
        tbPassword.Text = ""
        tbPassword.Select()
        ' Nasconde i caratteri della password
        chkNascondiCaratteri.Checked = True
    End Sub
End Class
Option Explicit On
Option Strict On

Imports System.IO

Module mGestorePassword
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Costanti private
    Private Const _numeroLivelli = 2

    ' Variabili private
    Private _livello As Integer
    Private _password(0 To _numeroLivelli - 1) As String



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public ReadOnly Property Livello As Integer
        Get
            Livello = _livello
        End Get
    End Property



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function CaricaFile(ByVal nomeFile As String) As Boolean
        Dim campo() As String
        Dim file As StreamReader = Nothing
        Dim i As Integer
        Dim riga As String

        Try
            ' Apre il file
            file = New StreamReader(nomeFile)
            ' Legge le password
            For i = 0 To _numeroLivelli - 1
                riga = file.ReadLine
                campo = Split(riga, vbTab)
                _password(i) = campo(1)
            Next
            ' Restituisce False
            CaricaFile = False

        Catch ex As Exception
            ' Restituisce True
            CaricaFile = True

        Finally
            ' Chiude il file
            If (file IsNot Nothing) Then
                file.Close()
                file = Nothing
            End If
        End Try
    End Function



    Public Function ImpostaPassword(ByVal nuovaPassword As String) As Boolean
        ' Se il livello attuale è diverso da 0
        If (_livello <> 0) Then
            ' Imposta la password del livello attuale
            _password(_livello - 1) = nuovaPassword
            ' Restituisce False
            ImpostaPassword = False
        Else    ' Altrimenti, se il livello attuale è 0
            ' Restituisce True
            ImpostaPassword = True
        End If
    End Function



    Public Function Login(ByVal livelloRichiesto As Integer) As Integer
        Dim i As Integer

        ' Se il livello attuale è 0
        If (_livello = 0) Then
            ' Configura e visualizza la finestra d'inserimento password
            If (livelloRichiesto = 0) Then
                frmInserimentoPassword.Descrizione = "Inserire la password"
            Else
                frmInserimentoPassword.Descrizione = String.Format("Inserire la password di {0}° livello", livelloRichiesto)
            End If
            frmInserimentoPassword.ShowDialog()
            ' Se la password è confermata
            If (frmInserimentoPassword.PasswordConfermata) Then
                ' Verifica la password
                For i = 0 To _numeroLivelli - 1
                    If (frmInserimentoPassword.Password = _password(i)) Then
                        Exit For
                    End If
                Next
                ' Visualizza un messaggio ed imposta il livello
                If ((livelloRichiesto = 0 And i < _numeroLivelli) Or (i = livelloRichiesto - 1)) Then
                    MsgBox("Password riconosciuta.", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Informazione")
                    _livello = i + 1
                Else
                    MsgBox("Password non riconosciuta.", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MsgBoxStyle), "Avviso")
                    _livello = 0
                End If
            End If
        ElseIf (livelloRichiesto <> 0 And _livello < livelloRichiesto) Then
            MsgBox("Per effettuare l'operazione è necessario una password di livello superiore.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Errore")
        End If
        ' Restituisce il livello della password
        Login = _livello
    End Function



    Public Sub Logout()
        ' Imposta il livello attuale a 0
        _livello = 0
    End Sub



    Public Function SalvaFile(ByVal nomeFile As String) As Boolean
        Dim file As StreamWriter = Nothing
        Dim i As Integer

        Try
            ' Apre il file
            file = New StreamWriter(nomeFile)
            ' Salva le password
            For i = 0 To _numeroLivelli - 1
                file.WriteLine("Password di " & (i + 1).ToString & "° livello" & vbTab & _password(i))
            Next
            ' Restituisce False
            SalvaFile = False

        Catch ex As Exception
            ' Restituisce True
            SalvaFile = True

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

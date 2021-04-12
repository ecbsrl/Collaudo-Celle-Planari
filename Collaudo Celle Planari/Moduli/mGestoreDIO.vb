Option Explicit On
Option Strict On

Module mGestoreDIO
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    ' Enumerazione ingresso
    Public Enum eIngresso
        PressioneAriaOk = 0
        EmergenzaPremuta = 1
        AusiliariInseriti = 2
        PulsanteAvvio = 3
        PulsanteScarto = 4
        Ingresso05 = 5
        Ingresso06 = 6
        Ingresso07 = 7
        Ingresso10 = 8
        Ingresso11 = 9
        Ingresso12 = 10
        Ingresso13 = 11
        Ingresso14 = 12
        Ingresso15 = 13
        Ingresso16 = 14
        Ingresso17 = 15
    End Enum
    Public Const NumeroIngressi = 16

    ' Enumerazione uscita
    Public Enum eUscita
        LedRossoPulsanteAvvio = 0
        LedVerdePulsanteAvvio = 1
        LampadaBuono = 2
        LampadaScarto = 3
        Cicalino = 4
        EV1_GeneratoreVuoto = 5
        EV2_ErogazioneVuoto = 6
        EV3_ScaricoVuoto = 7
        EV4_ErogazionePressione = 8
        EV5_ScaricoPressione = 9
        Marcatore = 10
        Uscita13 = 11
        Uscita14 = 12
        Uscita15 = 13
        Uscita16 = 14
        Uscita17 = 15
    End Enum
    Public Const NumeroUscite = 16



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+
    ' Variabili private
    Private _statoIngresso(0 To NumeroIngressi - 1) As Boolean
    Private _statoUscita(0 To NumeroUscite - 1) As Boolean



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+
    Public ReadOnly Property DescrizioneIngresso(ByVal indice As eIngresso) As String
        Get
            Select Case indice
                Case eIngresso.PressioneAriaOk
                    DescrizioneIngresso = "I0.0 - Pressione aria ok"
                Case eIngresso.EmergenzaPremuta
                    DescrizioneIngresso = "I0.1 - Emergenza premuta"
                Case eIngresso.AusiliariInseriti
                    DescrizioneIngresso = "I0.2 - Ausiliari inseriti"
                Case eIngresso.PulsanteAvvio
                    DescrizioneIngresso = "I0.3 - Pulsante avvio ciclo"
                Case eIngresso.PulsanteScarto
                    DescrizioneIngresso = "I0.4 - Pulsante ripristino scarto"
                Case eIngresso.Ingresso05
                    DescrizioneIngresso = "I0.5 - Riserva"
                Case eIngresso.Ingresso06
                    DescrizioneIngresso = "I0.6 - Riserva"
                Case eIngresso.Ingresso07
                    DescrizioneIngresso = "I0.7 - Riserva"
                Case eIngresso.Ingresso10
                    DescrizioneIngresso = "I1.0 - Riserva"
                Case eIngresso.Ingresso11
                    DescrizioneIngresso = "I1.1 - Riserva"
                Case eIngresso.Ingresso12
                    DescrizioneIngresso = "I1.2 - Riserva"
                Case eIngresso.Ingresso13
                    DescrizioneIngresso = "I1.3 - Riserva"
                Case eIngresso.Ingresso14
                    DescrizioneIngresso = "I1.4 - Riserva"
                Case eIngresso.Ingresso15
                    DescrizioneIngresso = "I1.5 - Riserva"
                Case eIngresso.Ingresso16
                    DescrizioneIngresso = "I1.6 - Riserva"
                Case eIngresso.Ingresso17
                    DescrizioneIngresso = "I1.7 - Riserva"
                Case Else
                    DescrizioneIngresso = "???"
            End Select
        End Get
    End Property



    Public ReadOnly Property DescrizioneUscita(ByVal indice As eUscita) As String
        Get
            Select Case indice
                Case eUscita.LedRossoPulsanteAvvio
                    DescrizioneUscita = "U0.0 - Led rossi pulsante avvio ciclo"
                Case eUscita.LedVerdePulsanteAvvio
                    DescrizioneUscita = "U0.1 - Led verdi pulsante avvio ciclo"
                Case eUscita.LampadaBuono
                    DescrizioneUscita = "U0.2 - Lampada buono"
                Case eUscita.LampadaScarto
                    DescrizioneUscita = "U0.3 - Lampada scarto"
                Case eUscita.Cicalino
                    DescrizioneUscita = "U0.4 - Cicalino"
                Case eUscita.EV1_GeneratoreVuoto
                    DescrizioneUscita = "U0.5 - EV1 generatore di vuoto"
                Case eUscita.EV2_ErogazioneVuoto
                    DescrizioneUscita = "U0.6 - EV2 erogazione vuoto"
                Case eUscita.EV3_ScaricoVuoto
                    DescrizioneUscita = "U0.7 - EV3 scarico vuoto"
                Case eUscita.EV4_ErogazionePressione
                    DescrizioneUscita = "U1.0 - EV4 erogazione pressione "
                Case eUscita.EV5_ScaricoPressione
                    DescrizioneUscita = "U1.1 - EV5 scarico pressione"
                Case eUscita.Marcatore
                    DescrizioneUscita = "U1.2 - Marcatore"
                Case eUscita.Uscita13
                    DescrizioneUscita = "U1.3 - Riserva"
                Case eUscita.Uscita14
                    DescrizioneUscita = "U1.4 - Riserva"
                Case eUscita.Uscita15
                    DescrizioneUscita = "U1.5 - Riserva"
                Case eUscita.Uscita16
                    DescrizioneUscita = "U1.6 - Riserva"
                Case eUscita.Uscita17
                    DescrizioneUscita = "U1.7 - Riserva"
                Case Else
                    DescrizioneUscita = "???"
            End Select
        End Get
    End Property



    Public ReadOnly Property StatoIngresso(ByVal indice As eIngresso) As Boolean
        Get
            StatoIngresso = _statoIngresso(indice)
        End Get
    End Property



    Public ReadOnly Property StatoUscita(ByVal indice As eUscita) As Boolean
        Get
            StatoUscita = _statoUscita(indice)
        End Get
    End Property



    '+------------------------------------------------------------------------------+
    '|                          Costruttore e distruttore                           |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Function Arresta() As Boolean
        ' Resetta tutte le uscite
        Arresta = False
        For i = 0 To NumeroUscite - 1
            'Arresta = Arresta Or DisattivaUscita(CType(i, eUscita))
        Next
    End Function



    'Public Function AttivaUscita(ByVal indice As eUscita) As Boolean
    '    ' Attiva l'uscita specificata
    '    AttivaUscita = ScriviUscita(indice, True)
    'End Function



    'Public Function DisattivaUscita(ByVal indice As eUscita) As Boolean
    '    ' Disattiva l'uscita specificata
    '    DisattivaUscita = ScriviUscita(indice, False)
    'End Function



    'Public Function LeggiIngressi() As Boolean
    '    Legge gli ingressi
    '    LeggiIngressi = Scheda_IO_1.LeggiIngressi And Scheda_IO_2.LeggiIngressi
    '    ' Aggiorna l'immagine degli ingressi
    '    _statoIngresso(0) = Scheda_IO_1.StatoIngresso(0)
    '    _statoIngresso(1) = Scheda_IO_1.StatoIngresso(1)
    '    _statoIngresso(2) = Scheda_IO_1.StatoIngresso(2)
    '    _statoIngresso(3) = Scheda_IO_1.StatoIngresso(3)
    '    _statoIngresso(4) = Scheda_IO_1.StatoIngresso(4)
    '    _statoIngresso(5) = Scheda_IO_1.StatoIngresso(5)
    '    _statoIngresso(6) = Scheda_IO_1.StatoIngresso(6)
    '    _statoIngresso(7) = Scheda_IO_1.StatoIngresso(7)
    '    _statoIngresso(8) = Scheda_IO_2.StatoIngresso(0)
    '    _statoIngresso(9) = Scheda_IO_2.StatoIngresso(1)
    '    _statoIngresso(10) = Scheda_IO_2.StatoIngresso(2)
    '    _statoIngresso(11) = Scheda_IO_2.StatoIngresso(3)
    '    _statoIngresso(12) = Scheda_IO_2.StatoIngresso(4)
    '    _statoIngresso(13) = Scheda_IO_2.StatoIngresso(5)
    '    _statoIngresso(14) = Scheda_IO_2.StatoIngresso(6)
    '    _statoIngresso(15) = Scheda_IO_2.StatoIngresso(7)
    'End Function



    'Public Function ScriviUscita(ByVal indice As eUscita, _
    '                             ByVal stato As Boolean) As Boolean
    '    ' Scrive l'uscita specificata
    '    _statoUscita(indice) = stato
    '    If indice <= 7 Then
    '        ScriviUscita = Scheda_IO_1.ScriviUscita(indice, stato)
    '    Else
    '        ScriviUscita = Scheda_IO_2.ScriviUscita(indice - 8, stato)
    '    End If
    'End Function



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
End Module
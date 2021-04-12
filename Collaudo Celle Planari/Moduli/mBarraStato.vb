Option Explicit On
Option Strict On

Module mBarraStato
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+
    Public Sub Aggiorna(ByRef barraStato As StatusStrip)
        ' Riferimento alla barra di stato
        With barraStato
            ' Aggiorna il pannello 0 (nome lotto)
            .Items.Item(0).Text = "Nome lotto:" & mGestoreCollaudo.Lotto.Nome
            ' Aggiorna il pannello 1 (nome ricetta)
            .Items.Item(1).Text = "Nome ricetta: " & mGestoreCollaudo.Lotto.NomeRicetta
            ' Aggiorna il pannello 2 (livello password)
            .Items.Item(2).Text = "Livello password: " & mGestorePassword.Livello
            ' Aggiorna il pannello 3 (data e ora)
            .Items.Item(3).Text = Format(Date.Now, "dd/MM/yyyy, HH:mm:ss")
        End With
    End Sub



    Public Sub Inizializza(ByRef barraStato As StatusStrip)
        Dim label As ToolStripStatusLabel

        ' Riferimento alla barra di stato
        With barraStato
            ' Crea i pannelli
            .Items.Add(New ToolStripStatusLabel)
            .Items.Add(New ToolStripStatusLabel)
            .Items.Add(New ToolStripStatusLabel)
            .Items.Add(New ToolStripStatusLabel)
            ' Inizializza il pannello 0 (nome lotto)
            label = CType(.Items.Item(0), ToolStripStatusLabel)
            label.AutoSize = False
            label.BorderSides = ToolStripStatusLabelBorderSides.All
            label.BorderStyle = Border3DStyle.SunkenOuter
            label.Width = CInt(0.298 * .Width)
            label.TextAlign = ContentAlignment.MiddleCenter
            ' Inizializza il pannello 1 (nome ricetta)
            label = CType(.Items.Item(1), ToolStripStatusLabel)
            label.AutoSize = False
            label.BorderSides = ToolStripStatusLabelBorderSides.All
            label.BorderStyle = Border3DStyle.SunkenOuter
            label.Width = CInt(0.298 * .Width)
            label.TextAlign = ContentAlignment.MiddleCenter
            ' Inizializza il pannello 2 (livello password)
            label = CType(.Items.Item(2), ToolStripStatusLabel)
            label.AutoSize = False
            label.BorderSides = ToolStripStatusLabelBorderSides.All
            label.BorderStyle = Border3DStyle.SunkenOuter
            label.Width = CInt(0.29 * .Width)
            label.TextAlign = ContentAlignment.MiddleCenter
            ' Inizializza il pannello 3 (data e ora)
            label = CType(.Items.Item(3), ToolStripStatusLabel)
            label.AutoSize = False
            label.BorderSides = ToolStripStatusLabelBorderSides.All
            label.BorderStyle = Border3DStyle.SunkenOuter
            label.Width = CInt(0.105 * .Width)
            label.TextAlign = ContentAlignment.MiddleCenter
        End With
        ' Aggiorna la barra di stato
        mBarraStato.Aggiorna(barraStato)
    End Sub



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
End Module
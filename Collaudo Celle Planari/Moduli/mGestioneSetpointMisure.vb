Module mGestioneSetpointMisure



    Public Function SetPortataMFC_O2(ByVal Portata As Single) As Boolean
        Dim Setpoint As Double

        Setpoint = (Portata + mImpostazioniAvanzate.OffsetMFC_O2) * mImpostazioniAvanzate.MoltiplicatoreMFC_O2
        SetPortataMFC_O2 = mGlobale.Mass_Flow_Controller_O2.SetPortata(Setpoint)
    End Function



    Public Function SetPortataMFC_N2(ByVal Portata As Single) As Boolean
        Dim Setpoint As Double

        Setpoint = (Portata + mImpostazioniAvanzate.OffsetMFC_N2) * mImpostazioniAvanzate.MoltiplicatoreMFC_N2
        SetPortataMFC_N2 = mGlobale.Mass_Flow_Controller_N2.SetPortata(Setpoint)
    End Function



    Public Function MisuraTensione(ByRef Tensione As Double) As Boolean
        Dim MisuraCorretta As Double

        MisuraTensione = mGlobale.Multimetro.MisuraTensioneDC(MisuraCorretta)
        MisuraCorretta = (MisuraCorretta + mImpostazioniAvanzate.OffsetMisuraTensione) * mImpostazioniAvanzate.MoltiplicatoreMisuraTensione
        Tensione = Math.Round(MisuraCorretta, 3)
    End Function



    Public Function MisuraResistenza(ByRef Resistenza As Double) As Boolean
        Dim MisuraCorretta As Double

        MisuraResistenza = mGlobale.Multimetro.MisuraResistenza4Fili(MisuraCorretta)
        MisuraCorretta = (MisuraCorretta + mImpostazioniAvanzate.OffsetMisuraResistenza) * mImpostazioniAvanzate.MoltiplicatoreMisuraResistenza
        Resistenza = Math.Round(MisuraCorretta, 3)
    End Function



    Public Function MisuraCorrente(ByVal Scala As Single, ByRef Corrente As Double) As Boolean
        Dim MisuraCorretta As Double

        MisuraCorrente = mGlobale.Multimetro.MisuraCorrenteDC(Scala, MisuraCorretta)
        MisuraCorretta = (MisuraCorretta + mImpostazioniAvanzate.OffsetMisuraCorrente) * mImpostazioniAvanzate.MoltiplicatoreMisuraCorrente
        Corrente = Math.Round(MisuraCorretta, 10)
    End Function



    Public Function MisureAdv(ByRef ip As Double, ByRef lambda As Double) As Boolean
        Dim tensione As Double

        MisureAdv = mGestioneSetpointMisure.MisuraTensione(tensione)
        lambda = ((tensione * (15.04 / 5) + 7.35) / 14.7) * mImpostazioniAvanzate.MoltiplicatoreAdvLambda + mImpostazioniAvanzate.OffsetAdvLambda
        ip = -0.3221 * (lambda * lambda) + 1.6713 * lambda - 1.3069
    End Function



    Public Function MisureZfas(ByRef ipEtas As Double, ByRef ipTb As Double) As Boolean
        Dim corrente As Double

        MisureZfas = mGestioneSetpointMisure.MisuraCorrente(0.01, corrente)
        ipEtas = mImpostazioniAvanzate.MoltiplicatoreZfasCorrentePumpingEtas * (Math.Abs(corrente) * 1000) + mImpostazioniAvanzate.OffsetZfasCorrentePumpingEtas
        ipTb = (Math.Abs(corrente) * 1000) * mImpostazioniAvanzate.MoltiplicatoreZfasCorrentePumpingTb + mImpostazioniAvanzate.OffsetZfasCorrentePumpingTb
    End Function
End Module

'+------------------------------------------------------------------------------+
'|                                  Changelog                                   |
'|  1.0 - prima release                                                         |
'|  1.1 - modificata gestione taratura O2% e gestione report risultati master   |
'|  1.2 - inserito target O2%                                                   |
'|  1.3 - corretto il numero di decimali nel report risultati                   |
'|  1.4 - corretta una involontaria visualizzazione di valori disabilitati      |
'|  2.0 - upgrade software/hardware per la gestione delle sonde ADV e ZFAS-U2   |
'+------------------------------------------------------------------------------+

Option Explicit On
Option Strict On

Imports System.IO

Module mGlobale
    '+------------------------------------------------------------------------------+
    '|                           Dichiarazioni pubbliche                            |
    '+------------------------------------------------------------------------------+
    ' Costanti pubbliche
    Public Const DescrizioneMacchina = "MA.01946 - Banco collaudo celle planari per sonde WB"
    Public Const VersioneSoftware = "2.0_20210217_DF"

    Public Const Porta_Trasduttore_Portata_O2 = "COM2"
    Public Const Porta_Trasduttore_Portata_N2 = "COM5"
    Public Const Indirizzo_Trasduttore_Portata = 1
    Public Const ID_Trasduttore_Portata_O2 = 14581771
    Public Const ID_Trasduttore_Portata_N2 = 14581772

    Public Const Indirizzo_IP_Slio = "192.168.0.2"
    Public Const Numero_Porta_Slio = 502

    Public Const Indirizzo_IP_Multimetro = "192.168.0.4"
    Public Const Numero_Porta_Multimetro = 5025

    Public Const Porta_Lambda = "COM6"
    Public Const Baudrate_Lambda = 9600

    ' Variabili pubbliche
    Public Mass_Flow_Controller_O2 As New cBurkertMFC8711(2, 3)
    Public Mass_Flow_Controller_N2 As New cBurkertMFC8711(2, 3)
    Public IOremoto As New cIORemoto
    Public Multimetro As New cKeySight34465A
    Public Lambda As New cAlmLed

    ' Variabili read only
    Public ReadOnly BasePath As String = Left(Directory.GetCurrentDirectory, Directory.GetCurrentDirectory.IndexOf("Planari 2021") + 18)
    Public ReadOnly NomeFileDataTaratura As String = BasePath & "\Archivio\Impostazioni\Data ultima taratura.txt"
    Public ReadOnly NomeFileImpostazioniAvanzate As String = BasePath & "\Archivio\Impostazioni\Impostazioni avanzate.txt"
    Public ReadOnly NomeFileImpostazioniGenerali As String = BasePath & "\Archivio\Impostazioni\Impostazioni generali.txt"
    Public ReadOnly PercorsoFileLottoUtilizzato As String = BasePath & "\Archivio\Impostazioni\Lotto utilizzato.txt"
    Public ReadOnly NomeFilePassword As String = BasePath & "\Archivio\Impostazioni\Password.txt"
    Public ReadOnly PercorsoExcel As String = "C:\Program Files\Microsoft Office\Office16\EXCEL.EXE"
    Public ReadOnly PercorsoImpostazioni As String = BasePath & "\Archivio\Impostazioni"
    Public ReadOnly PercorsoLotti As String = BasePath & "\Archivio\Lotti"
    Public ReadOnly PercorsoReport As String = BasePath & "\Archivio\Report"
    Public ReadOnly PercorsoRicette As String = BasePath & "\Archivio\Ricette"
    Public ReadOnly PercorsoModelliReport As String = BasePath & "\Archivio\Report\Modelli"
    Public ReadOnly PercorsoReportLotti As String = BasePath & "\Archivio\Report\Lotti"
    Public ReadOnly PercorsoReportRicette As String = BasePath & "\Archivio\Report\Ricette"
    Public ReadOnly PercorsoReportTarature As String = BasePath & "\Archivio\Report\Tarature"
    Public ReadOnly PercorsoRisultatiMaster As String = BasePath & "\Archivio\Risultati Master"
    Public ReadOnly PercorsoReportMaster As String = BasePath & "\Archivio\Report\Master"



    '+------------------------------------------------------------------------------+
    '|                            Dichiarazioni private                             |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                  Proprietà                                   |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                               Metodi pubblici                                |
    '+------------------------------------------------------------------------------+



    '+------------------------------------------------------------------------------+
    '|                                Metodi privati                                |
    '+------------------------------------------------------------------------------+
End Module
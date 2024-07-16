Module modMain
    Public gsCodUsr As String
    Public gsUser As String
    Public estInventario As String
    Public gsMenuNodeId As String
    Public gnOpcion As String
    Public gnOpcion2 As String
    Public gnOpcion3 As String
    Public gsCode As String
    Public estadoProduccion As String
    Public gsCode2 As String
    Public gsCode3 As String
    Public tcBOLETA As Double
    Public gsCode4 As String
    Public gsCode5 As String
    Public gsCode6 As String
    Public gsCode7 As String
    Public gsCode8 As String
    Public gsCode9 As String
    Public gsCode10 As String
    Public gsCode11 As String
    Public gsCode12 As String
    Public gsCode13 As String
    Public opePagoCob As String
    Public tcOperacion As Double
    Public Cerrar As String
    Public Cerrardup As String
    Public gsMes As String
    Public sMes1 As String
    Public gsAño As String
    Public sTDoc As String
    Public sSDoc As String
    Public sNDoc As String
    Public SPerDoc As String
    Public sTOpe As String
    Public sCos As String
    Public sObsOp As String
    Public sMov As String
    Public flagAccion As String
    Public flagAccion1 As String
    Public sAño As String = DateTime.Now.ToString("yyyy")
    Public sAñoLD As String = DateTime.Now.ToString("yyyy")
    Public sMes As String = DateTime.Now.ToString("MMMM")
    Public sMesLD As String = DateTime.Now.ToString("MMMM")
    Public sMes2 As String = DateTime.Now.ToString("MM")
    Public sFecha As String = DateTime.Now.ToString("yyyy/MM/dd")
    Public sFecCom As String
    Public gContador As Integer = 0
    Public sBusqueda As String
    Public sUni As String
    Public sFecAnu As String = "0"
    Public sEstAlmac As String = "0"
    Public sBusAlm As String = "0"
    Public gCliente As String = Nothing
    Public gLinea As String = Nothing
    Public gLinea2 As String = Nothing
    Public gLinea3 As String = Nothing
    Public codProcesoBP As String = Nothing
    Public gSubLinea As String = Nothing
    Public gArt As String = Nothing
    Public gCodAct As String = Nothing
    'usado para verificar repetidos en la guia
    Public contcant As Integer = 0
    Public sest1 As String
    Public sOp As String
    Public ccoCod As String

    Public gsError As String
    Public gsError2 As String
    Public gsError3 As String
    Public gsError4 As String

    Public gsRptArgs() As Object
    Public gsRptArgsUtil() As Object
    Public gsRptPath As String
    Public gsPathRpt As String
    Public gsIpserver As String = "\\192.168.1.7\"

    Public gsCodAlm As String
    Public gsOperacion As String

    'BIND CARD'
    Public bcSERIE As String
    Public bcNUMERO As String
    Public bcCODART As String
    Public bcCANTIDAD As String
    Public bcARTICULO As String
    Public bcESTADO As String
    Public bcMEDIDA As String
    Public bcUSUARIO As String
    Public bcFECGENE As String
    Public cco As String
    Public bcLOTE As String
    Public bcKARDEX As String
    Public bcGUIA As String

    'BUSCAR DOCUMENTO LD
    Public ldTDoc As String
    Public ldSERIE As String
    Public ldNUMERO As String
    Public ldCUENTA As String
    Public ldCUENTADEST As String
    Public ldFECHA As String
    Public ldPROVEEDOR As String
    Public ldSIGNO As String
    Public ldTCAMB As String
    Public ldIMPORTE As String
    Public ldDIMPORTE As String
    Public ldMONEDA As String
    Public ldANHO As String
    Public lsNrodOC As String
    Public ldNomProveedor As String
    Public ldRegContable As String
    Public fecGenPago As Date

    'BUSCAR TC SBS
    Public fechaTCSBS As String
    Public operacionTCSBS As String
    Public prefBanco As String
    Public tipOperacion As String
    Public estadoTC As Integer
    Public tipOpe As String
    Public tipMon As String

    'DATOS PAGOSA
    Public pagoFlujo As String
    Public pagoCaja As String

    'DATOS ROTULOGUIAS
    Public numReq As String
    Public artCodReq As String
    Public cantArtGuia As String
    Public numGUia As String
    Public serGuia As String
    Public tipGuia As String

    'DATOS PRESTAMO
    Public modifica As String
End Module

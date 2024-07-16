
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBCTA_FACTURACIONBL
    Private ELTBCTA_FACTURACIONDAL As New ELTBCTA_FACTURACIONDAL

    Public Function SelectAll(ByVal sAnio As String) As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectAll(sAnio)
    End Function

    Public Function SelectMaxCtafacturacion(ByVal Code As String, ByVal Code2 As String, ByVal Code3 As String, ByVal Code4 As String, ByVal Code5 As String, ByVal Linea As String, ByVal SubLineas As String, ByVal CodAct As String) As String
        Return ELTBCTA_FACTURACIONDAL.SelectMaxCtafacturacion(Code, Code2, Code3, Code4, Code5, Linea, SubLineas, CodAct)
    End Function

    Public Function VerificarRegistro(ByVal sanho As String) As DataTable
        Return ELTBCTA_FACTURACIONDAL.VerificarRegistro(sanho)
    End Function
    Public Function InsertRegistro(ByVal sanho As String)
        ELTBCTA_FACTURACIONDAL.InsertRegistro(sanho)
    End Function
    Public Function SaveRow(ByVal ELTBCTA_FACTURACIONBE As ELTBCTA_FACTURACIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal Datos As String) As String
        Return ELTBCTA_FACTURACIONDAL.SaveRow(ELTBCTA_FACTURACIONBE, ELMVLOGSBE, flagAccion, Datos)
    End Function

    Public Function SelectRow(ByVal gsCode As String, ByVal gsCode2 As String, ByVal gsCode3 As String, ByVal gsCode4 As String, ByVal gsCode5 As String, ByVal gLinea As String, ByVal gSubLineas As String, ByVal gCodAct As String, ByVal gArt As String) As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectRow(gsCode, gsCode2, gsCode3, gsCode4, gsCode5, gLinea, gSubLineas, gCodAct, gArt)
    End Function
    Public Function SelectRow1(ByVal sCode As String, ByVal sSer As String, ByVal sNum As String) As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectRow1(sCode, sSer, sNum)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectRowGrid(sCode, sOpcion)
    End Function
    Public Function SelectArticulo() As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectArticulo()
    End Function
    Public Function SelectCtas(ByVal fecyear As String) As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectCtas(fecyear)
    End Function
    Public Function SelectCtasLineaEvanse() As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectCtasLineaEvanse()
    End Function
    Public Function SelectVendedor() As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectVendedor()
    End Function
    Public Function SelectArticulosAsiento(ByVal sAnho As String, ByVal sMesanho As String) As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectArticulosAsiento(sAnho, sMesanho)
    End Function
    Public Function SelectArtncnd(ByVal sAnho As String, ByVal sMesanho As String) As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectArtncnd(sAnho, sMesanho)
    End Function
    Public Function DatosFactura(ByVal sCode As String, ByVal sAnho As String, ByVal sMes As String) As String
        Return ELTBCTA_FACTURACIONDAL.DatosFactura(sCode, sAnho, sMes)
    End Function
    Public Function SelectTipo_Mov() As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectTipo_Mov()
    End Function
    Public Function SelectT_Moneda() As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectT_Moneda()
    End Function
    Public Function SelectCTAFC(ByVal sCode As String) As String
        Return ELTBCTA_FACTURACIONDAL.SelectCTAFC(sCode)
    End Function
    Public Function SelectTipMovCOD(ByVal sCode As String) As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectTipMovCOD(sCode)
    End Function
    Public Function SelectMonCOD(ByVal sCode As String) As DataTable
        Return ELTBCTA_FACTURACIONDAL.SelectMonCOD(sCode)
    End Function

End Class


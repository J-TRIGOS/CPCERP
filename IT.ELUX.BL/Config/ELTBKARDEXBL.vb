Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBKARDEXBL
    Private ELTBKARDEXDAL As New ELTBKARDEXDAL
    Public Function SelectAll() As DataTable
        Return ELTBKARDEXDAL.SelectAll()
    End Function
    Public Function SelRow() As DataTable
        Return ELTBKARDEXDAL.SelRow()
    End Function
    Public Function SelRowPRECIO() As DataTable
        Return ELTBKARDEXDAL.SelRowPRECIO()
    End Function
    Public Function SelRow1() As DataTable
        Return ELTBKARDEXDAL.SelRow1()
    End Function
    Public Function SelRow2(ByVal sCod As String, ByVal sFam As String, ByVal sCodArt As String) As DataTable
        Return ELTBKARDEXDAL.SelRow2(sCod, sFam, sCodArt)
    End Function
    Public Function SelRow3(ByVal sCod As String, ByVal sFam As String, ByVal sCodArt As String, ByVal sAnho As String) As DataTable
        Return ELTBKARDEXDAL.SelRow3(sCod, sFam, sCodArt, sAnho)
    End Function

    Public Function SelListaArt(ByVal sCod As String) As DataTable
        Return ELTBKARDEXDAL.SelListaArt(sCod)
    End Function
    Public Function SelRow4(ByVal sCod As String, ByVal sCodArt As String, ByVal sAnho As String) As DataTable
        Return ELTBKARDEXDAL.SelRow4(sCod, sCodArt, sAnho)
    End Function
    Public Function SelTipMov(ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Return ELTBKARDEXDAL.SelTipMov(sSER, sNRO, sART, sANHO)
    End Function
    Public Function SelNroPrd(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Return ELTBKARDEXDAL.SelNroPrd(sTDOC, sSER, sNRO, sART, sANHO)
    End Function
    Public Function SelNroPrd00ALM(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Return ELTBKARDEXDAL.SelNroPrd00ALM(sTDOC, sSER, sNRO, sART, sANHO)
    End Function
    Public Function SelPrdSolm(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Return ELTBKARDEXDAL.SelPrdSolm(sTDOC, sSER, sNRO, sART, sANHO)
    End Function
    Public Function SelPrdSolmSABC(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Return ELTBKARDEXDAL.SelPrdSolmSABC(sTDOC, sSER, sNRO, sART, sANHO)
    End Function
    Public Function SelNroRein(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Return ELTBKARDEXDAL.SelNroRein(sTDOC, sSER, sNRO, sART, sANHO)
    End Function
    Public Function SelNroReinSABC(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Return ELTBKARDEXDAL.SelNroReinSABC(sTDOC, sSER, sNRO, sART, sANHO)
    End Function
    Public Function SelNroFall(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Return ELTBKARDEXDAL.SelNroFall(sTDOC, sSER, sNRO, sART, sANHO)
    End Function
    Public Function SelNroSolmPrd(ByVal sTDOC As String, ByVal sSER As String, ByVal sNRO As String, ByVal sART As String, ByVal sANHO As String) As String
        Return ELTBKARDEXDAL.SelNroSolmPrd(sTDOC, sSER, sNRO, sART, sANHO)
    End Function
    Public Function SelPrecioTransf(ByVal sANHO As String, ByVal smes1 As String, ByVal smes2 As String) As DataTable
        Return ELTBKARDEXDAL.SelPrecioTransf(sANHO, smes1, smes2)
    End Function

    Public Function SelectTEMP_KARDEX_MOV(ByVal sANHO As String) As DataTable
        Return ELTBKARDEXDAL.SelectTEMP_KARDEX_MOV(sANHO)
    End Function
    Public Function SelPrecioTransf3(ByVal sANHO As String, ByVal smes1 As String, ByVal smes2 As String) As DataTable
        Return ELTBKARDEXDAL.SelPrecioTransf3(sANHO, smes1, smes2)
    End Function
    Public Function SelRowKar(ByVal AÑO As String, ByVal fec As Date, ByVal fec2 As Date,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKar(AÑO, fec, fec2, alm, cod)
    End Function
    Public Function SelRowKar1(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKar1(AÑO, fec, fec2, alm, cod)
    End Function
    Public Function SelRowKar2(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKar2(AÑO, fec, fec2, alm, cod)
    End Function
    Public Function SelRowKar3(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKar3(AÑO, fec, fec2, alm, cod)
    End Function
    Public Function SelRowKar4(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKar4(AÑO, fec, fec2, alm, cod)
    End Function
    Public Function SelRowKar5(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKar5(AÑO, fec, fec2, alm, cod)
    End Function

    Public Function SelRowKarxCont(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKarxCont(AÑO, fec, fec2, alm, cod)
    End Function

    Public Function SelRowKarx6(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKarx6(AÑO, fec, fec2, alm, cod)
    End Function
    Public Function SelRowKarx7(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKarx7(AÑO, fec, fec2, alm, cod)
    End Function

    Public Function SelRowKarx8(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKarx8(AÑO, fec, fec2, alm, cod)
    End Function
    Public Function SelRowKarPP6(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKarPP6(AÑO, fec, fec2, alm, cod)
    End Function
    Public Function SelRowKar7(ByVal AÑO As String, ByVal fec As String, ByVal fec2 As String,
                              ByVal alm As String, ByVal cod As String) As DataTable
        Return ELTBKARDEXDAL.SelRowKar7(AÑO, fec, fec2, alm, cod)
    End Function
    Public Function SelPrecio(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String,
                              ByVal pCANTIDAD As Double) As DataTable
        Return ELTBKARDEXDAL.SelPrecio(tDOC, SDOC, NDOC, ART, pCANTIDAD)
    End Function
    Public Function SelPrecioPRD(ByVal NDOC As String, ByVal ART As String) As DataTable
        Return ELTBKARDEXDAL.SelPrecioPRD(NDOC, ART)
    End Function
    Public Function SelPrecioPRDSolm(ByVal NDOC As String, ByVal ART As String, ByVal T_MOVINV As String, ByVal FEC As String) As DataTable
        Return ELTBKARDEXDAL.SelPrecioPRDSolm(NDOC, ART, T_MOVINV, FEC)
    End Function
    Public Function SelPrecioPRDSolmKARDEXK(ByVal NDOC As String, ByVal ART As String, ByVal T_MOVINV As String, ByVal FEC As Date) As DataTable
        Return ELTBKARDEXDAL.SelPrecioPRDSolmKARDEXK(NDOC, ART, T_MOVINV, FEC)
    End Function
    Public Function SelPrecio1(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String) As DataTable
        Return ELTBKARDEXDAL.SelPrecio1(tDOC, SDOC, NDOC, ART)
    End Function
    Public Function SelPrecioOc(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal ANHO1 As String, ByVal ANHO2 As String) As DataTable
        Return ELTBKARDEXDAL.SelPrecioOC(tDOC, SDOC, NDOC, ART, ANHO1, ANHO2)
    End Function
    Public Function SelCuentaComprasNC(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal ANHO1 As String, ByVal ANHO2 As String) As DataTable
        Return ELTBKARDEXDAL.SelCuentaComprasNC(tDOC, SDOC, NDOC, ART, ANHO1, ANHO2)
    End Function
    Public Function SelCuentaCompras(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal ANHO1 As String) As DataTable
        Return ELTBKARDEXDAL.SelCuentaCompras(tDOC, SDOC, NDOC, ART, ANHO1)
    End Function
    Public Function SelCuenta_destComprasNC(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal ANHO1 As String, ByVal ANHO2 As String) As DataTable
        Return ELTBKARDEXDAL.SelCuenta_destComprasNC(tDOC, SDOC, NDOC, ART, ANHO1, ANHO2)
    End Function
    Public Function SelCuenta_destCompras(ByVal tDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal ANHO1 As String) As DataTable
        Return ELTBKARDEXDAL.SelCuenta_destCompras(tDOC, SDOC, NDOC, ART, ANHO1)
    End Function
    Public Function SelPrecio2(ByVal SDOC As String, ByVal NDOC As String, ByVal ART As String, ByVal Anho As String, ByVal X As String) As DataTable
        Return ELTBKARDEXDAL.SelPrecio2(SDOC, NDOC, ART, Anho, X)
    End Function

    Public Function SaveRow(ByVal ELTBKARDEXBE As ELTBKARDEXBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView,
                          ByVal sublinea As String, ByVal sfam As String, ByVal sart As String) As String
        Return ELTBKARDEXDAL.SaveRow(ELTBKARDEXBE, ELMVLOGSBE, flagAccion, dg, sublinea, sfam, sart)
    End Function

    Public Function ActualizarFechaCompra(ByVal codigo As String, ByVal tipo As String, ByVal serie As String, ByVal nro As String) As DataTable
        Return ELTBKARDEXDAL.ActualizarFechaCompra(codigo, tipo, serie, nro)
    End Function
End Class

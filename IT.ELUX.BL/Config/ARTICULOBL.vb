Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ARTICULOBL
    Private ARTICULODAL As New ARTICULODAL

#Region "SQL"

    Public Function LastCodigo(ByVal sCode As String) As String
        Return ARTICULODAL.LastCodigo(sCode)
    End Function
    Public Function getMedida(ByVal sCode As String) As String
        Return ARTICULODAL.getMedida(sCode)
    End Function

    Public Function getUniMed(ByVal sCode As String) As String
        Return ARTICULODAL.getUniMed(sCode)
    End Function
    Public Function SelectArticuloStock(ByVal sCod As String, ByVal sAlm As String) As DataTable
        Return ARTICULODAL.SelectArticuloStock(sCod, sAlm)
    End Function

    Public Function verificarUSuario(ByVal codUser As String) As DataTable
        Return ARTICULODAL.verificarUSuario(codUser)
    End Function
    Public Function LastCodAntiguo() As String
        Return ARTICULODAL.LastCodAntiguo()
    End Function
    Public Function SetStock(ByVal sCode As String) As Double
        Return ARTICULODAL.SetStock(sCode)
    End Function
    Public Function CodCCNU() As DataTable
        Return ARTICULODAL.CodCCNU()
    End Function
    Public Function CodCCNU1() As DataTable
        Return ARTICULODAL.CodCCNU1()
    End Function
    Public Function SelPreOrd(ByVal sArt As String, ByVal sCTCT As String, ByVal sMoneda As String) As Double
        Return ARTICULODAL.SelPreOrd(sArt, sCTCT, sMoneda)
    End Function
    Public Function SelPreFec(ByVal sArt As String, ByVal sCTCT As String, ByVal sMoneda As String) As String
        Return ARTICULODAL.SelPreFec(sArt, sCTCT, sMoneda)
    End Function
    Public Function SetPrecio(ByVal sCode As String, ByVal sCliente As String) As String
        Return ARTICULODAL.SetPrecio(sCode, sCliente)
    End Function
    Public Function SetPrecio1(ByVal sCode As String, ByVal sCliente As String) As String
        Return ARTICULODAL.SetPrecio1(sCode, sCliente)
    End Function
    Public Function SelectAll(ByVal sCode As String) As DataTable
        Return ARTICULODAL.SelectAll(sCode)
    End Function
    Public Function SelectAll1(ByVal sCode As String) As DataTable
        Return ARTICULODAL.SelectAll1(sCode)
    End Function
    Public Function SelectELTBARTSTOCKALL(ByVal sCode As String, ByVal sAlm As String) As DataTable
        Return ARTICULODAL.SelectELTBARTSTOCKALL(sCode, sAlm)
    End Function
    Public Function SelectAllprecio(ByVal sCode As String) As DataTable
        Return ARTICULODAL.SelectAllprecio(sCode)
    End Function

    Public Function SelectUniMed(ByVal sCode As String) As String
        Return ARTICULODAL.SelectUniMed(sCode)
    End Function
    Public Function SelectNomGrupCor(ByVal sCode As String) As String
        Return ARTICULODAL.SelectNomGrupCor(sCode)
    End Function

    Public Function SelectNom(ByVal sCode As String) As String
        Return ARTICULODAL.SelectNom(sCode)
    End Function
    Public Function SelectNomCCNU(ByVal sCode As String) As String
        Return ARTICULODAL.SelectNomCCNU(sCode)
    End Function
    Public Function getMedida_old(ByVal sCode As String) As String
        Return ARTICULODAL.getMedida_old(sCode)
    End Function

    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Return ARTICULODAL.SelectNro(sCode, sSer)
    End Function

    Public Function SelPrecioArt(ByVal sCode As String) As Int32
        Return ARTICULODAL.SelPrecioArt(sCode)
    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String, ByVal sfec As String) As String
        Return ARTICULODAL.SelectNro1(sCode, sSer, sfec)
    End Function

    Public Function SelectAct() As DataTable
        Return ARTICULODAL.SelectAct()
    End Function

    Public Function SelectAct1(ByVal sCode As String) As String
        Return ARTICULODAL.SelectAct1(sCode)
    End Function

    Public Function SelectArt(ByVal sCode As String) As DataTable
        Return ARTICULODAL.SelectArt(sCode)
    End Function

    Public Function SelectArt5(ByVal sCode As String) As DataTable
        Return ARTICULODAL.SelectArt5(sCode)
    End Function

    Public Function SelectArt1(ByVal sCode As String) As DataTable
        Return ARTICULODAL.SelectArt1(sCode)
    End Function

    Public Function SelectArt6(ByVal sCode As String) As DataTable
        Return ARTICULODAL.SelectArt6(sCode)
    End Function

    Public Function SelectArt7(ByVal sCode As String) As String
        Return ARTICULODAL.SelectArt7(sCode)
    End Function

    Public Function SelectContar(ByVal sCode As String, ByVal sCtct As String) As Int32
        Return ARTICULODAL.SelectContar(sCode, sCtct)
    End Function

    Public Function SelectArt2(ByVal sCode As String) As String
        Return ARTICULODAL.SelectArt2(sCode)
    End Function

    Public Function SelectArt3(ByVal sCode As String) As String
        Return ARTICULODAL.SelectArt3(sCode)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ARTICULODAL.SelectRow(sCode)
    End Function

    Public Function getListdgv(ByVal sCodecat As String, ByVal sCodeart As String) As DataTable
        Return ARTICULODAL.getListdgv(sCodecat, sCodeart)
    End Function

    Public Function getListdgvAct(ByVal sCodecat As String, ByVal sCodeart As String) As DataTable
        Return ARTICULODAL.getListdgvAct(sCodecat, sCodeart)
    End Function

    Public Function getListdgvVehi(ByVal sCodecat As String, ByVal sCodeart As String) As DataTable
        Return ARTICULODAL.getListdgvVehi(sCodecat, sCodeart)
    End Function

    Public Function getListdgv1(ByVal sCodeart As String) As DataTable
        Return ARTICULODAL.getListdgv1(sCodeart)
    End Function

    Public Function getListdgv2(ByVal sCodeart As String) As DataTable ', ByVal sIndex As String) As DataTable
        Return ARTICULODAL.getListdgv2(sCodeart) ', sIndex)
    End Function

    'REALIZADO PARA PRUEBAS
    Public Function getListdgv3(ByVal sCodeart As String) As DataTable
        Return ARTICULODAL.getListdgv3(sCodeart)
    End Function

    Public Function getListdgv4(ByVal sCodeart As String, ByVal sCodeArt1 As String) As DataTable
        Return ARTICULODAL.getListdgv4(sCodeart, sCodeArt1)
    End Function

    Public Function getListdgv5(ByVal sCodeart As String) As DataTable
        Return ARTICULODAL.getListdgv5(sCodeart)
    End Function

    Public Function getListdgv6(ByVal sCodeart As String) As DataTable
        Return ARTICULODAL.getListdgv6(sCodeart)
    End Function

    Public Function getListdgv7(ByVal sCodeart As String, ByVal opcion As String) As DataTable
        Return ARTICULODAL.getListdgv7(sCodeart, opcion)
    End Function

    Public Function ContRep(ByVal sCodeart As String, ByVal sCtct As String) As Int32
        Return ARTICULODAL.ContRep(sCodeart, sCtct)
    End Function

    Public Function getListdgv4(ByVal sCodeart As String) As DataTable
        Return ARTICULODAL.getListdgv4(sCodeart)
    End Function
    '-----

    Public Function SelectDescripcion() As DataTable
        Return ARTICULODAL.getListcmb()
    End Function

    Public Function SelectSerArtD(ByVal sTip As String, ByVal sCode As String) As DataTable
        Return ARTICULODAL.getListSerArtD(sTip, sCode)
    End Function

    Public Function SelectNroArtD(ByVal sTip As String, ByVal sSer As String, ByVal sCode As String) As DataTable
        Return ARTICULODAL.getListNroArtD(sTip, sSer, sCode)
    End Function

    Public Function ListadoCC() As DataTable
        Return ARTICULODAL.ListadoCC()
    End Function

    Public Function SelectDescripcion1() As DataTable
        Return ARTICULODAL.getListcmb1()
    End Function
    Public Function SelectDescripcion2() As DataTable
        Return ARTICULODAL.getListcmb2()
    End Function

    Public Function getListcmblin1() As DataTable
        Return ARTICULODAL.getListcmblin1()
    End Function

    Public Function getListLinearticulo() As DataTable
        Return ARTICULODAL.getListLinearticulo()
    End Function

    Public Function SelectDescripcion1(ByVal sCode As String) As DataTable
        Return ARTICULODAL.getListcmb1(sCode)
    End Function

    Public Function SelectCCxArt(ByVal codigo As String) As DataTable
        Return ARTICULODAL.SelectCCxArt(codigo)
    End Function

    Public Function getcmbsub1(ByVal sCode As String) As DataTable
        Return ARTICULODAL.getcmbsub1(sCode)
    End Function


    Public Function SelectDescripcion3(ByVal sCode As String) As DataTable
        Return ARTICULODAL.SelectDescripcion3(sCode)
    End Function

    Public Function getListSubLinea1(ByVal sCode As String) As DataTable
        Return ARTICULODAL.getListSubLinea1(sCode)
    End Function

    Public Function getListSubLin() As DataTable
        Return ARTICULODAL.getListSubLin()
    End Function

    Public Function SelectDescripcion2(ByVal sCode As String) As DataTable
        Return ARTICULODAL.getListcmb2(sCode)
    End Function

    Public Function SelectFamilia1() As DataTable
        Return ARTICULODAL.getListcmb3()
    End Function

    Public Function SelectFamilia2() As DataTable
        Return ARTICULODAL.getListcmb4()
    End Function

    Public Function SelectFamilia3() As DataTable
        Return ARTICULODAL.getListcmb5()
    End Function

    Public Function SelectFamilia4() As DataTable
        Return ARTICULODAL.getListcmb6()
    End Function

    Public Function SelectFamilia5() As DataTable
        Return ARTICULODAL.getListcmb7()
    End Function

    Public Function SelectUndMed() As DataTable
        Return ARTICULODAL.getListcmb8()
    End Function

    Public Function Art_CompExp(ByVal sCode As String) As DataTable
        Return ARTICULODAL.Art_CompExp(sCode)
    End Function

    Public Function SelectCCosto() As DataTable
        Return ARTICULODAL.getListcmb9()
    End Function

    Public Function getListcmb10() As DataTable
        Return ARTICULODAL.getListcmb10()
    End Function

    Public Function getListcmb11() As DataTable
        Return ARTICULODAL.getListcmb11()
    End Function

    Public Function getListcmb12() As DataTable
        Return ARTICULODAL.getListcmb12()
    End Function

    Public Function getListcmb14() As DataTable
        Return ARTICULODAL.getListcmb14()
    End Function

    Public Function getListcmb15(ByVal sCode As String) As String
        Return ARTICULODAL.getListcmb15(sCode)
    End Function

    Public Function art_cco(ByVal sCode As String) As String
        Return ARTICULODAL.art_cco(sCode)
    End Function

    Public Function ProcNom(ByVal sCode As String) As String
        Return ARTICULODAL.ProcNom(sCode)
    End Function

    Public Function VerProc(ByVal sCode As String) As String
        Return ARTICULODAL.VerProc(sCode)
    End Function

    Public Function SelVerNroSolm(ByVal sCode As String, ByVal sSer As String, ByVal sNro As String, ByVal sArt As String) As String
        Return ARTICULODAL.SelVerNroSolm(sCode, sSer, sNro, sArt)
    End Function

    Public Function SelVerSerSolm(ByVal sCode As String, ByVal sSer As String, ByVal sNro As String, ByVal sArt As String) As String
        Return ARTICULODAL.SelVerSerSolm(sCode, sSer, sNro, sArt)
    End Function

    Public Function getListcmb13() As DataTable
        Return ARTICULODAL.getListcmb13()
    End Function

    Public Function getArticuloAnterior() As DataTable
        Return ARTICULODAL.getArticuloAnterior()
    End Function

    Public Function getArticuloAnterior1() As DataTable
        Return ARTICULODAL.getArticuloAnterior1()
    End Function

    Public Function getArticuloActivo() As DataTable
        Return ARTICULODAL.getArticuloActivo()
    End Function

    Public Function getArticuloAnterior2() As DataTable
        Return ARTICULODAL.getArticuloAnterior2()
    End Function

    Public Function getArticuloAnterior4() As DataTable
        Return ARTICULODAL.getArticuloAnterior4()
    End Function

    Public Function getArticuloAnterior5() As DataTable
        Return ARTICULODAL.getArticuloAnterior5()
    End Function
    Public Function getArticuloAnterior6() As DataTable
        Return ARTICULODAL.getArticuloAnterior6()
    End Function
    Public Function getArticuloAnterior7() As DataTable
        Return ARTICULODAL.getArticuloAnterior7()
    End Function
    Public Function getArticuloAnterior8() As DataTable
        Return ARTICULODAL.getArticuloAnterior8()
    End Function
    Public Function getArtLineaSub(ByVal cod As String) As DataTable
        Return ARTICULODAL.getArtLineaSub(cod)
    End Function
    Public Function getArticuloAntE17() As DataTable
        Return ARTICULODAL.getArticuloAntE17()
    End Function
    Public Function getArticuloCliente(ByVal sRuc As String) As DataTable
        Return ARTICULODAL.getArticulocliente(sRuc)
    End Function

    Public Function getArtMant() As DataTable
        Return ARTICULODAL.getArtMant()
    End Function

    Public Function getOpciones(ByVal sCat As String) As DataTable
        Return ARTICULODAL.getOpciones(sCat)
    End Function

    Public Function getArtstk(ByVal sCodAlm As String, ByVal sSubLinea As String) As DataTable
        Return ARTICULODAL.getArtstk(sCodAlm, sSubLinea)
    End Function

#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal ARTICULOBE As ARTICULOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
        Return ARTICULODAL.SaveRow(ARTICULOBE, flagAccion, ELMVLOGSBE)
    End Function
    Public Function SaveRowFast(ByVal ARTICULOBE As ARTICULOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
        Return ARTICULODAL.SaveRowFast(ARTICULOBE, flagAccion, ELMVLOGSBE)
    End Function
    Public Function ReporteKardex(ByVal flagAccion As String, ByVal ARTICULOBE As ARTICULOBE) As String
        'Verifica el kardex
        Return ARTICULODAL.ReporteKardex(flagAccion, ARTICULOBE)

    End Function
    Public Function UpdRow(ByVal ARTICULOBE As ARTICULOBE, ByVal flagAccion As String) As String
        Return ARTICULODAL.UpdRow(ARTICULOBE, flagAccion)
    End Function
#End Region

End Class

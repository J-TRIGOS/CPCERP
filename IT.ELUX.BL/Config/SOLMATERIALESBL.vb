Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class SOLMATERIALESBL
    Private SOLMATERIALESDAL As New SOLMATERIALESDAL

#Region "SQL"
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Return SOLMATERIALESDAL.SelectNro(sCode, sSer)
    End Function

    Public Function listTot(ByVal ser As String, ByVal nro As String) As Int32
        Return SOLMATERIALESDAL.listTot(ser, nro)
    End Function

    Public Function SelectAllAp(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectAllAp(sFecAño, sFecMes)
    End Function

    Public Function SelectAll(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectAll(sT_doc, sAño, sMes)
    End Function

    Public Function SelectAllUsuario(ByVal sT_doc As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectAllUsuario(sT_doc, sAño, sMes)
    End Function

    Public Function SelectActivos1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectActivos1(sFecAño, sFecMes)
    End Function

    Public Function SelectRecursos(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectRecursos(sFecAño, sFecMes)
    End Function

    Public Function SelectASQ(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectASQ(sFecAño, sFecMes)
    End Function

    Public Function SelectALM(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectALM(sFecAño, sFecMes)
    End Function

    Public Function SelectLOG(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectLOG(sFecAño, sFecMes)
    End Function

    Public Function SelectCONT(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectCONT(sFecAño, sFecMes)
    End Function

    Public Function SelectVentas(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectVentas(sFecAño, sFecMes)
    End Function

    Public Function SelectMant(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return SOLMATERIALESDAL.SelectMant(sFecAño, sFecMes)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return SOLMATERIALESDAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return SOLMATERIALESDAL.SelectRow(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function SelLinea(ByVal sCod As String) As String
        Return SOLMATERIALESDAL.SelLinea(sCod)
    End Function

    Public Function list1(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String,
                         ByVal fec As Date, ByVal sCos As String)
        Return SOLMATERIALESDAL.list1(tdoc, sdoc, ndoc, fec, sCos)
    End Function

    Public Function list2(ByVal tdoc As String, ByVal sdoc As String, ByVal ndoc As String, ByVal sCos As String)
        Return SOLMATERIALESDAL.list2(tdoc, sdoc, ndoc, sCos)
    End Function

    Public Function gArea(ByVal tlinea As String)
        Return SOLMATERIALESDAL.gArea(tlinea)
    End Function

    Public Function gArea1(ByVal tlinea As String)
        Return SOLMATERIALESDAL.gArea1(tlinea)
    End Function

    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sArt As String) As DataTable
        Return SOLMATERIALESDAL.getListdgv1(sT_doc, sS_doc, sN_doc, sArt)
    End Function

    Public Function SelectUsuario(ByVal sCode As String) As String
        Return SOLMATERIALESDAL.SelectUsuario(sCode)
    End Function
#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                            ByVal dg As DataGridView) As String

        Return SOLMATERIALESDAL.SaveRow(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, flagAccion, dg)

    End Function


    Public Function UpdRow(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal flagAccion As String) As String

        Return SOLMATERIALESDAL.UpdRow(SOLMATERIALESBE, flagAccion)

    End Function
    Public Function UpdRowDoc(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal flagAccion As String) As String

        Return SOLMATERIALESDAL.UpdRowDoc(SOLMATERIALESBE, flagAccion)

    End Function

    Public Function SaveRow1(ByVal SOLMATERIALESBE As SOLMATERIALESBE, ByVal ELTBDETSOLMATERIALESBE As ELTBDETSOLMATERIALESBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                             ByVal flagAccion As String, ByVal dgv As DataGridView, ByVal sord As String, ByVal nord As String) As String
        Return SOLMATERIALESDAL.SaveRow1(SOLMATERIALESBE, ELTBDETSOLMATERIALESBE, ELMVLOGSBE, flagAccion, dgv, sord, nord)
    End Function

    Public Function SelectArt(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Return SOLMATERIALESDAL.SelectArt(sTdoc, sSer, sNro)
    End Function

    Public Function SelectRow(ByVal sTdoc As String, ByVal sSer As String, ByVal sNro As String, ByVal sCod As String) As DataTable
        Return SOLMATERIALESDAL.SelectRow(sTdoc, sSer, sNro, sCod)
    End Function

#End Region
End Class

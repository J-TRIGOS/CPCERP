Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELORDEN_PROGRAMBL
    Private ELORDEN_PROGRAMDAL As New ELORDEN_PROGRAMDAL

#Region "Lectura de Datos"
    Public Function SelPerAll() As DataTable
        Return ELORDEN_PROGRAMDAL.SelPerAll()
    End Function

    Public Function SelectProcesoCOD(ByVal codigo As String) As DataTable
        Return ELORDEN_PROGRAMDAL.SelectProcesoCOD(codigo)
    End Function

    Public Function SelectMaxTransp(ByVal anho As String) As String
        Return ELORDEN_PROGRAMDAL.SelectMaxTransp(anho)
    End Function

    Public Function SelectGroupDet(ByVal sCod As String) As String
        Return ELORDEN_PROGRAMDAL.SelectGroupDet(sCod)
    End Function

    Public Function SelNroProd(ByVal sCod As String) As String
        Return ELORDEN_PROGRAMDAL.SelNroProd(sCod)
    End Function

    Public Function SelectMaxLibro() As String
        Return ELORDEN_PROGRAMDAL.SelectMaxLibro()
    End Function

    Public Function getListdgv1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String, ByVal sCod_art As String) As DataTable
        Return ELORDEN_PROGRAMDAL.getListdgv1(sT_doc, sS_doc, sN_doc, sCod_art)
    End Function

    Public Function SelectRow(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Return ELORDEN_PROGRAMDAL.SelectRow(sTdoc, sSDoc, sNDoc)
    End Function

    Public Function SelectRowDetalle(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Return ELORDEN_PROGRAMDAL.SelectRowDetalle(sTdoc, sSDoc, sNDoc)
    End Function

    Public Function SelectNro_Orden(ByVal sTdoc As String) As DataTable
        Return ELORDEN_PROGRAMDAL.SelectNro_Orden(sTdoc)
    End Function

    Public Function SelectLineaProd(ByVal ccosto As String) As DataTable
        Return ELORDEN_PROGRAMDAL.SelectLineaProd(ccosto)
    End Function

    Public Function SelectProcesoArt() As DataTable
        Return ELORDEN_PROGRAMDAL.SelectProcesoArt()
    End Function
    Public Function SelectLineaProduSelect(ByVal sTdoc As String) As DataTable
        Return ELORDEN_PROGRAMDAL.SelectLineaProduSelect(sTdoc)
    End Function

    Public Function SelectOrdenesProdu(ByVal sTdoc As String) As DataTable
        Return ELORDEN_PROGRAMDAL.SelectOrdenesProdu(sTdoc)
    End Function

    Public Function VerificarRepetido(ByVal cod As String) As Boolean
        Return ELORDEN_PROGRAMDAL.VerificarRepetido(cod)
    End Function

    Public Function ArtProd(ByVal cod As String) As Boolean
        Return ELORDEN_PROGRAMDAL.ArtProd(cod)
    End Function

    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELORDEN_PROGRAMDAL.SelectAll(anho, mes)
    End Function

    Public Function list1(ByVal var As String)
        Return ELORDEN_PROGRAMDAL.list1(var)
    End Function

    Public Function listProdTot(ByVal ser As String, ByVal nro As String)
        Return ELORDEN_PROGRAMDAL.listProdTot(ser, nro)
    End Function

    Public Function listSolmTot(ByVal ser As String, ByVal nro As String)
        Return ELORDEN_PROGRAMDAL.listSolmTot(ser, nro)
    End Function

    Public Function listFallTot(ByVal ser As String, ByVal nro As String)
        Return ELORDEN_PROGRAMDAL.listFallTot(ser, nro)
    End Function

    Public Function listReinTot(ByVal ser As String, ByVal nro As String)
        Return ELORDEN_PROGRAMDAL.listReinTot(ser, nro)
    End Function

    Public Function ListArt(ByVal codco As String, ByVal art_cod As String) As DataTable
        Return ELORDEN_PROGRAMDAL.ListArt(codco, art_cod)
    End Function

    Public Function RPTSEGPRDORD(ByVal numOP As String) As DataTable
        Return ELORDEN_PROGRAMDAL.RPTSEGPRDORD(numOP)
    End Function
#End Region

    Public Function SaveRow(ByVal ELORDEN_PROGRAMBE As ELORDEN_PROGRAMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagaccion As String, ByVal dg As DataGridView, ByVal ELORDEN_DET_PROGRAMBE As ELORDEN_DET_PROGRAMBE) As String
        Return ELORDEN_PROGRAMDAL.SaveRow(ELORDEN_PROGRAMBE, ELMVLOGSBE, flagaccion, dg, ELORDEN_DET_PROGRAMBE)
    End Function
    Public Function SaveRow1(ByVal ELPRODUCCIONBE As ELPRODUCCIONBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagaccion As String) As String
        Return ELORDEN_PROGRAMDAL.SaveRow1(ELPRODUCCIONBE, ELMVLOGSBE, flagaccion)
    End Function
    Public Function ReportePrograma(ByVal flagAccion As String, ByVal sAño As String,
                           ByVal sMes As String, ByVal sDia As String, ByVal sTurn As String, ByVal sCCO As String,
                           ByVal sfec As String, ByVal numero As String) As String
        'Verifica el kardex
        Return ELORDEN_PROGRAMDAL.ReportePrograma(flagAccion, sAño, sMes, sDia, sTurn, sCCO, sfec, numero)
    End Function

    Public Function SelectAllOP(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELORDEN_PROGRAMDAL.SelectAllOP(anho, mes)
    End Function
End Class

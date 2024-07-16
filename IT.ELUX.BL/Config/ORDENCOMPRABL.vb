Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ORDENCOMPRABL
    Private ORDENCOMPRADAL As New ORDENCOMPRADAL
#Region "Lectura de Datos"

#Region "SQL"

    Public Function SelectT_DOC(ByVal sCod As String) As DataTable
        Return ORDENCOMPRADAL.SelectT_DOC(sCod)
    End Function

    Public Function SelectT_MOVINV() As DataTable
        Return ORDENCOMPRADAL.SelectT_MOVINV()
    End Function

    Public Function SelectF_PAGO() As DataTable
        Return ORDENCOMPRADAL.SelectF_PAGO()
    End Function

    Public Function SelectF_ENT() As DataTable
        Return ORDENCOMPRADAL.SelectF_ENT()
    End Function

    Public Function SelectAll(ByVal sCode As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return ORDENCOMPRADAL.SelectAll(sCode, sAño, sMes)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ORDENCOMPRADAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function

    Public Function SelectMoneda() As DataTable
        Return ORDENCOMPRADAL.SelectMoneda()
    End Function

    Public Function SelectVendedor() As DataTable
        Return ORDENCOMPRADAL.SelectVendedor()
    End Function

    Public Function SelectCliente() As DataTable
        Return ORDENCOMPRADAL.SelectCliente()
    End Function

    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Return ORDENCOMPRADAL.SelectNro1(sCode, sSer)
    End Function

    Public Function SelectCatalogo(ByVal sCode As String) As String
        Return ORDENCOMPRADAL.SelectCatalogo(sCode)
    End Function

    Public Function SelectF_PAGO_ENT_Ult(ByVal sCode As String) As String
        Return ORDENCOMPRADAL.SelectF_PAGO_ENT_Ult(sCode)
    End Function

    Public Function SelectOC(ByVal sCode As String, ByVal sNUM As String) As String
        Return ORDENCOMPRADAL.SelectOC(sCode, sNUM)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ORDENCOMPRADAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Return ORDENCOMPRADAL.SelectDir(sCod)
    End Function

    Public Function lv_fec(ByVal fec1 As Date, ByVal fec2 As Date)
        Return ORDENCOMPRADAL.lv_fec(fec1, fec2)
    End Function

    Public Function SearchNro(ByVal sNRO As String) As DataTable
        Return ORDENCOMPRADAL.SearchNro(sNRO)
    End Function

    Public Function ArtNro(ByVal sNRO As String) As DataTable
        Return ORDENCOMPRADAL.ArtNro(sNRO)
    End Function

    Public Function SelProv(ByVal sNRO As String) As String
        Return ORDENCOMPRADAL.SelProv(sNRO)
    End Function

    Public Function SelCantOT(ByVal sNRO As String, ByVal sART As String) As String
        Return ORDENCOMPRADAL.SelCantOT(sNRO, sART)
    End Function

    Public Function FecProv(ByVal sNRO As String) As String
        Return ORDENCOMPRADAL.FecProv(sNRO)
    End Function

    Public Function SelectComAllFiltro(ByVal saño As String, ByVal smes As String, ByVal serie As String,
                                       ByVal nro As String, ByVal ruc As String, ByVal art As String,
                                       ByVal nart As String) As DataTable
        Return ORDENCOMPRADAL.SelectComAllFiltro(saño, smes, serie, nro, ruc, art, nart)
    End Function
#End Region

#End Region

#Region "Grabar Datos"

    Public Function SelectNroAnu(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Return ORDENCOMPRADAL.SelectNroAnu(sTip, sSer, sNro)
    End Function
    Public Function SaveRow(ByVal ORDENCOMPRABE As ORDENCOMPRABE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ORDENCOMPRADAL.SaveRow(ORDENCOMPRABE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg)
    End Function

#End Region


End Class

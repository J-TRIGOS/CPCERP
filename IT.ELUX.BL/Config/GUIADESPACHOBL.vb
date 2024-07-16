Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class GUIADESPACHOBL
    Private GUIADESPACHODAL As New GUIADESPACHODAL
    Public Function SelectAll(ByVal sCode As String, ByVal sAño As String, ByVal sMes As String) As DataTable
        Return GUIADESPACHODAL.SelectAll(sCode, sAño, sMes)
    End Function
    Public Function SelectNro1(ByVal sCode As String, ByVal sSer As String) As Int32
        Return GUIADESPACHODAL.SelectNro1(sCode, sSer)
    End Function
    Public Function SelectRowActa(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIADESPACHODAL.SelectRowActa(sCode, sS_doc, sN_doc)
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIADESPACHODAL.SelectRow(sCode, sS_doc, sN_doc)
    End Function
    Public Function getListdgv_Gd(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIADESPACHODAL.getListdgv_GD(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function SelectT_DOC(tdoc As String) As DataTable
        Return GUIADESPACHODAL.SelectT_DOC(tdoc)
    End Function
    Public Function SelectT_Transp() As DataTable
        Return GUIADESPACHODAL.SelectT_Transp()
    End Function

    Public Function SelectT_MOVINV() As DataTable
        Return GUIADESPACHODAL.SelectT_MOVINV()
    End Function

    Public Function SelectF_PAGO() As DataTable
        Return GUIADESPACHODAL.SelectF_PAGO()
    End Function

    Public Function SelectRowcodChofer(ByVal cod As String, ByVal chofer As String) As String
        Return GUIADESPACHODAL.SelectRowcodChofer(cod, chofer)
    End Function
    Public Function SelectT_TranspChoferrow(ByVal tcod As String, ByVal tcode As String) As DataTable
        Return GUIADESPACHODAL.SelectT_TranspChoferRow(tcod, tcode)
    End Function

    Public Function SelectF_ENT() As DataTable
        Return GUIADESPACHODAL.SelectF_ENT()
    End Function
    Public Function SelectMoneda() As DataTable
        Return GUIADESPACHODAL.SelectMoneda()
    End Function

    Public Function SelectVendedor() As DataTable
        Return GUIADESPACHODAL.SelectVendedor()
    End Function

    Public Function SelectCliente() As DataTable
        Return GUIADESPACHODAL.SelectCliente()
    End Function

    Public Function SelectDirProv() As DataTable
        Return GUIADESPACHODAL.SelectDirProv()
    End Function

    Public Function SelectDir(ByVal sCod As String) As DataTable
        Return GUIADESPACHODAL.SelectDir(sCod)
    End Function

    Public Function getListdgv(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return GUIADESPACHODAL.getListdgv(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function getDatostransp(ByVal sT_codigo As String) As DataTable
        Return GUIADESPACHODAL.getDatostransp(sT_codigo)
    End Function

    Public Function SelectT_TranspChofer(tcod As String) As DataTable
        Return GUIADESPACHODAL.SelectT_TranspChofer(tcod)
    End Function

    Public Function SelectT_TranspTractor(ByVal tcod As String) As DataTable
        Return GUIADESPACHODAL.SelectT_TranspTractor(tcod)
    End Function

    Public Function getDatostranspTractor(ByVal sT_codigo As String, ByVal codtransp As String) As DataTable
        Return GUIADESPACHODAL.getDatostranspTractor(sT_codigo, codtransp)
    End Function

    Public Function SelectGetCantidadPallets(ByVal cantidadpalle As Double, ByVal diametro As String) As DataTable
        Return GUIADESPACHODAL.SelectGetCantidadPallets(cantidadpalle, diametro)
    End Function

    Public Function SelectGetCodviru(ByVal cliente As String, ByVal articulo As String) As DataTable
        Return GUIADESPACHODAL.SelectGetCodviru(cliente, articulo)
    End Function

    Public Function SelectGetUbigeo(ByVal cliente As String, ByVal dir As String) As DataTable
        Return GUIADESPACHODAL.SelectGetUbigeo(cliente, dir)
    End Function
#Region "Grabar Datos"
    Public Function SaveRow(ByVal GUIADESPACHOBE As GUIADESPACHOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView, ByVal scodcat As String, ByVal sEst As String,
                            ByVal dg1 As DataTable) As String
        Return GUIADESPACHODAL.SaveRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg, scodcat, sEst, dg1)
    End Function
    Public Function SelectMaxTrans(ByVal T_anio As String) As String
        Return GUIADESPACHODAL.SelectMaxTrans(T_anio)
    End Function
    Public Function SaveRowActa(ByVal GUIADESPACHOBE As GUIADESPACHOBE, ByVal DET_DOCUMENTOBE As DET_DOCUMENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                            ByVal flagAccion As String, ByVal dg As DataGridView, ByVal Tpaquete As String, ByVal sEst As String, ByVal dg1 As DataTable) As String
        Return GUIADESPACHODAL.SaveRow(GUIADESPACHOBE, DET_DOCUMENTOBE, ELMVLOGSBE, flagAccion, dg, Tpaquete, sEst, dg1)
    End Function
    Public Function SelectDataOP(ByVal TDOC As String, ByVal SDOC As String, ByVal NDOC As String, ByVal ARTICULO As String) As String
        Return GUIADESPACHODAL.SelectDataOP(TDOC, SDOC, NDOC, ARTICULO)
    End Function

#End Region
End Class

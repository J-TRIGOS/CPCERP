
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELDECLARACIONDUABL
    Private ELDECLARACIONDUADAL As New ELDECLARACIONDUADAL

    Public Function SelGuiaAll() As DataTable
        Return ELDECLARACIONDUADAL.SelGuiaAll()
    End Function
    Public Function SelectAll() As DataTable
        Return ELDECLARACIONDUADAL.SelectAll()
    End Function
    Public Function SelEasyPeelAll() As DataTable
        Return ELDECLARACIONDUADAL.SelEasyAll()
    End Function
    Public Function SeltapaplastAll() As DataTable
        Return ELDECLARACIONDUADAL.SelTapaPlasAll()
    End Function
    Public Function SelTapaTeleAll() As DataTable
        Return ELDECLARACIONDUADAL.SelTapaTeleAll()
    End Function
    Public Function SelectGuias(ByVal Nroguia As String, ByVal Nroserie As String) As DataTable
        Return ELDECLARACIONDUADAL.SelectGuias(Nroguia, Nroserie)
    End Function
    Public Function SelectMaxTransp() As String
        Return ELDECLARACIONDUADAL.SelectMaxTransp()
    End Function
    Public Function SelectRowCountP() As String
        Return ELDECLARACIONDUADAL.SelectRowCountP()
    End Function
    Public Function SelectRowCountT() As String
        Return ELDECLARACIONDUADAL.SelectRowCountT()
    End Function
    Public Function SelectRowCount() As String
        Return ELDECLARACIONDUADAL.SelectRowCount()
    End Function

    Public Function SelectGetDataEspe(ByVal Articulo As String) As String
        Return ELDECLARACIONDUADAL.SelectGetDataEspe(Articulo)
    End Function

    Public Function SelectGetData(ByVal Nroguia As String, ByVal Nroserie As String) As String
        Return ELDECLARACIONDUADAL.SelectGetData(Nroguia, Nroserie)
    End Function

    Public Function SelectGetLote(ByVal Nroguia As String) As String
        Return ELDECLARACIONDUADAL.SelectGetLote(Nroguia)
    End Function

    Public Function SelectGetDataEasy(ByVal producto As String) As String
        Return ELDECLARACIONDUADAL.SelectGetDataEasy(producto)
    End Function
    Public Function SelectGetDataTapaPlas(ByVal producto As String) As String
        Return ELDECLARACIONDUADAL.SelectGetDataTapaPlas(producto)
    End Function
    Public Function SelectGetDataTapaTel(ByVal producto As String) As String
        Return ELDECLARACIONDUADAL.SelectGetDataTapaTel(producto)
    End Function
    Public Function SaveRow(ByVal ELDECLARACIONDUABE As ELDECLARACIONDUABE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String
        Return ELDECLARACIONDUADAL.SaveRow(ELDECLARACIONDUABE, flagAccion, ELMVLOGSBE)
    End Function
    Public Function SelectGetART_GETDATOS(ByVal fecha As String, ByVal articulo As String) As DataTable
        Return ELDECLARACIONDUADAL.SelectGetART_GETDATOS(fecha, articulo)
    End Function
    Public Function SelectGetART_SALDO_FEC(ByVal fecha As String, ByVal fecha_fin As String, ByVal anho As String, ByVal articulo As String) As DataTable
        Return ELDECLARACIONDUADAL.SelectGetART_SALDO_FEC(fecha, fecha_fin, anho, articulo)
    End Function
    Public Function SelectGetART_SUM_STK(ByVal fecha As String, ByVal fecha_fin As String, ByVal articulo As String) As DataTable
        Return ELDECLARACIONDUADAL.SelectGetART_SUM_STK(fecha, fecha_fin, articulo)
    End Function
    Public Function SelectGetFecha(ByVal fecha As String, ByVal nro As String) As DataTable
        Return ELDECLARACIONDUADAL.SelectGetFecha(fecha, nro)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sARTCOD As String) As DataTable
        Return ELDECLARACIONDUADAL.SelectRow(sCode, sARTCOD)
    End Function

    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELDECLARACIONDUADAL.SelectAll(anho, mes)
    End Function
    Public Function SelectFacturasG() As DataTable
        Return ELDECLARACIONDUADAL.SelectFacturasG()
    End Function
    Public Function getListDua(ByVal sT_doc1 As String, ByVal sS_doc1 As String, ByVal sN_doc1 As String, ByVal articulo As String,
                               ByVal sFecha As String) As DataTable
        Return ELDECLARACIONDUADAL.getListDua(sT_doc1, sS_doc1, sN_doc1, articulo, sFecha)
    End Function
    Public Function getListdgv(ByVal sT_doc1 As String, ByVal sS_doc1 As String, ByVal sN_doc1 As String) As DataTable
        Return ELDECLARACIONDUADAL.getListdgv(sT_doc1, sS_doc1, sN_doc1)
    End Function
    Public Function SelectArticulo(ByVal sNro As String) As DataTable
        Return ELDECLARACIONDUADAL.SelectArticulo(sNro)
    End Function
End Class


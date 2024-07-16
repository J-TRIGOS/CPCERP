Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class REPORTE_TRABAJOBL

    Private REPORTE_TRABAJODAL As New REPORTE_TRABAJODAL

    Public Function SelectNro(ByVal sTip As String, ByVal sSer As String) As Int32
        Return REPORTE_TRABAJODAL.SelectNro(sTip, sSer)
    End Function
    Public Function SelectDia(ByVal sDni As String, ByVal sAct As String, ByVal sfec As String, ByVal sTur As String, ByVal sFac As String) As DataTable
        Return REPORTE_TRABAJODAL.SelectDia(sDni, sAct, sfec, sTur, sFac)
    End Function
    Public Function SaveRow(ByVal REPORTE_TRABAJOBE As REPORTE_TRABAJOBE, ByVal REPORTE_DETTRABAJOBE As REPORTE_DETTRABAJOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return REPORTE_TRABAJODAL.SaveRow(REPORTE_TRABAJOBE, REPORTE_DETTRABAJOBE, ELMVLOGSBE, flagAccion, dg)
    End Function
    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String, ByVal sUser As String) As DataTable
        Return REPORTE_TRABAJODAL.SelectAll(sFecAño, sFecMes, sUser)
    End Function
    Public Function SelectAllHEJ(ByVal sFecAño As String, ByVal sFecMes As String, ByVal sUser As String) As DataTable
        Return REPORTE_TRABAJODAL.SelectAllHEJ(sFecAño, sFecMes, sUser)
    End Function
    Public Function SelectAllHEJP(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return REPORTE_TRABAJODAL.SelectAllHEJP(sFecAño, sFecMes)
    End Function
    Public Function SelectRow(ByVal sCod As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Return REPORTE_TRABAJODAL.SelectRow(sCod, sSer, sNro)
    End Function
    Public Function SelectRowDet(ByVal sCod As String, ByVal sSer As String, ByVal sNro As String) As DataTable
        Return REPORTE_TRABAJODAL.SelectRowDet(sCod, sSer, sNro)
    End Function
    Public Function SelectActivos1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return REPORTE_TRABAJODAL.SelectActivos1(sFecAño, sFecMes)
    End Function
    Public Function SelectUsuario(ByVal sCode As String) As DataTable
        Return REPORTE_TRABAJODAL.SelectUsuario(sCode)
    End Function
    Public Function listcco_cod(ByVal sCod As String) As DataTable
        Return REPORTE_TRABAJODAL.listcco_cod(sCod)
    End Function
    Public Function listcco_cod_c(ByVal sCod As String) As DataTable
        Return REPORTE_TRABAJODAL.listcco_cod_c(sCod)
    End Function
    Public Function SelectRowOM(ByVal sSer As String, ByVal sNro As String) As DataTable
        Return REPORTE_TRABAJODAL.SelectRowOM(sSer, sNro)
    End Function
    Public Function SelPermiso(ByVal sCode As String) As String
        Return REPORTE_TRABAJODAL.SelPermiso(sCode)
    End Function
End Class

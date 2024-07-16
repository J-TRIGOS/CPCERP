Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBMANTENIMIENTOBL
    Private ELTBMANTENIMIENTODAL As New ELTBMANTENIMIENTODAL
    Public Function SelectAll(ByVal sFec As String) As DataTable
        Return ELTBMANTENIMIENTODAL.SelectAll(sFec)
    End Function
    Public Function SelectAllTo(ByVal sFec As String) As DataTable
        Return ELTBMANTENIMIENTODAL.SelectAllTo(sFec)
    End Function
    Public Function SelectRow(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBMANTENIMIENTODAL.SelectRow(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function SelectTecnico(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBMANTENIMIENTODAL.SelectTecnico(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function SelectPlano(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBMANTENIMIENTODAL.SelectPlano(sT_doc, sS_doc, sN_doc)
    End Function
    Public Function Selectarea() As DataTable
        Return ELTBMANTENIMIENTODAL.Selectarea()
    End Function
    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Return ELTBMANTENIMIENTODAL.SelectNro(sCode, sSer)
    End Function

    Public Function SaveRow(ByVal ELTBMANTENIMIENTOBE As ELTBMANTENIMIENTOBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String, ByVal dgt As DataGridView, ByVal dgp As DataGridView) As String
        Return ELTBMANTENIMIENTODAL.SaveRow(ELTBMANTENIMIENTOBE, ELMVLOGSBE, flagAccion, dgt, dgp)
    End Function
    Public Function SelectCenCos(ByVal sCODUSER As String) As String
        Return ELTBMANTENIMIENTODAL.SelectCenCos(sCODUSER)
    End Function
    Public Function gArea(ByVal tlinea As String)
        Return ELTBMANTENIMIENTODAL.gArea(tlinea)
    End Function
    Public Function SelectNom(ByVal sCart As String) As String
        Return ELTBMANTENIMIENTODAL.SelectNom(sCart)
    End Function
    Public Function list(ByVal sCod As String) As DataTable
        Return ELTBMANTENIMIENTODAL.list(sCod)
    End Function
End Class

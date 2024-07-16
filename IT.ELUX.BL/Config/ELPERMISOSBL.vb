
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELPERMISOSBL
    Private ELPERMISOSDAL As New ELPERMISOSDAL

    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELPERMISOSDAL.SelectAll(Anho, Mes)
    End Function
    Public Function SelectAllS(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELPERMISOSDAL.SelectAllS(Anho, Mes)
    End Function

    Public Function SaveRowS(ByVal ELPERMISOSBE As ELPERMISOSBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
        Return ELPERMISOSDAL.SaveRowS(ELPERMISOSBE, ELMVLOGSBE, flagAccion)
    End Function
    Public Function SaveRow(ByVal ELPERMISOSBE As ELPERMISOSBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
        Return ELPERMISOSDAL.SaveRow(ELPERMISOSBE, ELMVLOGSBE, flagAccion)
    End Function
    Public Function SelectNro(ByVal sSer As String) As Int32
        Return ELPERMISOSDAL.SelectNro(sSer)
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal sCode2 As String) As DataTable
        Return ELPERMISOSDAL.SelectRow(sCode, sCode2)
    End Function
    Public Function SelectRowS(ByVal sCode As String, ByVal sCode2 As String) As DataTable
        Return ELPERMISOSDAL.SelectRowS(sCode, sCode2)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String) As DataTable
        Return ELPERMISOSDAL.SelectRowGrid(sCode)
    End Function

    Public Function SelectSuspenCOD(ByVal codigo As String) As DataTable
        Return ELPERMISOSDAL.SelectSuspenCOD(codigo)
    End Function

    Public Function SelectSuspension() As DataTable
        Return ELPERMISOSDAL.SelectSuspension()
    End Function

    Public Function SelectPerCOD(ByVal codigo As String) As DataTable
        Return ELPERMISOSDAL.SelectPerCOD(codigo)
    End Function

    Public Function VerificarRepetido(ByVal codigo As String, ByVal prdo As String) As Boolean
        Return ELPERMISOSDAL.VerificarRepetido(codigo, prdo)
    End Function

    Public Function SelectPeriodoCOD(ByVal anho As String, ByVal codigo As String) As DataTable
        Return ELPERMISOSDAL.SelectPeriodoCOD(anho, codigo)
    End Function
    Public Function SelectAreaCOD(ByVal codigo As String) As DataTable
        Return ELPERMISOSDAL.SelectAreaCOD(codigo)
    End Function

    Public Function SelectPeriodo(ByVal anho As String) As DataTable
        Return ELPERMISOSDAL.SelectPeriodo(anho)
    End Function
    Public Function SelectArea() As DataTable
        Return ELPERMISOSDAL.SelectArea()
    End Function

    Public Function ContarRegistros() As String
        Return ELPERMISOSDAL.ContarRegistros()
    End Function

End Class


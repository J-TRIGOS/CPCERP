
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELVACACIONESBL
    Private ELVACACIONESDAL As New ELVACACIONESDAL

    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELVACACIONESDAL.SelectAll(Anho, Mes)
    End Function

    Public Function SaveRow(ByVal ELVACACIONESBE As ELVACACIONESBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELVACACIONESDAL.SaveRow(ELVACACIONESBE, flagAccion, dg)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sCode2 As String) As DataTable
        Return ELVACACIONESDAL.SelectRow(sCode, sCode2)
    End Function
    Public Function SelectVacaciones(ByVal sPer As String, ByVal sFec1 As String, ByVal sFec2 As String) As DataTable
        Return ELVACACIONESDAL.SelectVacaciones(sPer, sFec1, sFec2)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String) As DataTable
        Return ELVACACIONESDAL.SelectRowGrid(sCode)
    End Function

    Public Function SelectSuspenCOD(ByVal codigo As String) As DataTable
        Return ELVACACIONESDAL.SelectSuspenCOD(codigo)
    End Function

    Public Function SelectSuspension() As DataTable
        Return ELVACACIONESDAL.SelectSuspension()
    End Function

    Public Function SelectPerCOD(ByVal codigo As String) As DataTable
        Return ELVACACIONESDAL.SelectPerCOD(codigo)
    End Function

    Public Function VerificarRepetido(ByVal codigo As String, ByVal prdo As String) As Boolean
        Return ELVACACIONESDAL.VerificarRepetido(codigo, prdo)
    End Function

    Public Function SelectPeriodoCOD(ByVal anho As String, ByVal codigo As String) As DataTable
        Return ELVACACIONESDAL.SelectPeriodoCOD(anho, codigo)
    End Function

    Public Function SelectPeriodo(ByVal anho As String) As DataTable
        Return ELVACACIONESDAL.SelectPeriodo(anho)
    End Function

    Public Function SelectPeriodo2(ByVal anho As String) As DataTable
        Return ELVACACIONESDAL.SelectPeriodo2(anho)
    End Function

    Public Function ContarRegistros() As String
        Return ELVACACIONESDAL.ContarRegistros()
    End Function

End Class


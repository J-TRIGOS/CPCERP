
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELPROGRAMACIONBL
    Private ELPROGRAMACIONDAL As New ELPROGRAMACIONDAL

    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELPROGRAMACIONDAL.SelectAll(Anho, Mes)
    End Function

    Public Function SaveRow(ByVal ELPROGRAMACIONBE As ELPROGRAMACIONBE, ByVal flagAccion As String, ByVal dgvdatos As DataGridView) As String
        Return ELPROGRAMACIONDAL.SaveRow(ELPROGRAMACIONBE, flagAccion, dgvdatos)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sCode2 As String) As DataTable
        Return ELPROGRAMACIONDAL.SelectRow(sCode, sCode2)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String) As DataTable
        Return ELPROGRAMACIONDAL.SelectRowGrid(sCode)
    End Function

    Public Function SelectSuspenCOD(ByVal codigo As String) As DataTable
        Return ELPROGRAMACIONDAL.SelectSuspenCOD(codigo)
    End Function

    Public Function SelectSuspension() As DataTable
        Return ELPROGRAMACIONDAL.SelectSuspension()
    End Function

    Public Function SelectPerCOD(ByVal codigo As String) As DataTable
        Return ELPROGRAMACIONDAL.SelectPerCOD(codigo)
    End Function

    Public Function VerificarRepetido(ByVal codigo As String, ByVal prdo As String) As Boolean
        Return ELPROGRAMACIONDAL.VerificarRepetido(codigo, prdo)
    End Function

    Public Function SelectPeriodoCOD(ByVal anho As String, ByVal codigo As String) As DataTable
        Return ELPROGRAMACIONDAL.SelectPeriodoCOD(anho, codigo)
    End Function
    Public Function SelectAreaCOD(ByVal codigo As String) As DataTable
        Return ELPROGRAMACIONDAL.SelectAreaCOD(codigo)
    End Function

    Public Function SelectPeriodo(ByVal anho As String) As DataTable
        Return ELPROGRAMACIONDAL.SelectPeriodo(anho)
    End Function
    Public Function SelectArea() As DataTable
        Return ELPROGRAMACIONDAL.SelectArea()
    End Function


    Public Function ContarRegistros() As String
        Return ELPROGRAMACIONDAL.ContarRegistros()
    End Function

End Class


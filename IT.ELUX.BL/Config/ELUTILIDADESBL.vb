
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELUTILIDADESBL
    Private ELUTILIDADESDAL As New ELUTILIDADESDAL

    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELUTILIDADESDAL.SelectAll(Anho, Mes)
    End Function

    Public Function SaveRow(ByVal ELUTILIDADESBE As ELUTILIDADESBE, ByVal flagAccion As String) As String
        Return ELUTILIDADESDAL.SaveRow(ELUTILIDADESBE, flagAccion)
    End Function

    Public Function SelectMaxPeriodo() As String
        Return ELUTILIDADESDAL.SelectMaxPeriodo()
    End Function

    Public Function SelectRow(ByVal sTDoc As String, ByVal sSDoc As String) As DataTable
        Return ELUTILIDADESDAL.SelectRow(sTDoc, sSDoc)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String) As DataTable
        Return ELUTILIDADESDAL.SelectRowGrid(sCode)
    End Function

    Public Function SelectSuspenCOD(ByVal codigo As String) As DataTable
        Return ELUTILIDADESDAL.SelectSuspenCOD(codigo)
    End Function

    Public Function SelectSuspension() As DataTable
        Return ELUTILIDADESDAL.SelectSuspension()
    End Function

    Public Function SelectPerCOD(ByVal codigo As String) As DataTable
        Return ELUTILIDADESDAL.SelectPerCOD(codigo)
    End Function

    Public Function VerificarRepetido(ByVal anho As String, ByVal per_cod As String) As Boolean
        Return ELUTILIDADESDAL.VerificarRepetido(anho, per_cod)
    End Function

    Public Function SelectPeriodoCOD(ByVal anho As String, ByVal codigo As String) As DataTable
        Return ELUTILIDADESDAL.SelectPeriodoCOD(anho, codigo)
    End Function

    Public Function SelectPeriodo(ByVal anho As String) As DataTable
        Return ELUTILIDADESDAL.SelectPeriodo(anho)
    End Function

    Public Function ContarRegistros() As String
        Return ELUTILIDADESDAL.ContarRegistros()
    End Function

End Class


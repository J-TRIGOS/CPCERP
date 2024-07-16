Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBTIPOCAMBIOBL
    Private ELTBTIPOCAMBIODAL As New ELTBTIPOCAMBIODAL

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBTIPOCAMBIODAL.SelectAll(sFecAño, sFecMes)
    End Function

    Public Function SelectAll1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBTIPOCAMBIODAL.SelectAll1(sFecAño, sFecMes)
    End Function

    Public Function SelectMaxTransp() As String
        Return ELTBTIPOCAMBIODAL.SelectMaxTransp()
    End Function

    Public Function SaveRow(ByVal ELTBTIPOCAMBIOBE As ELTBTIPOCAMBIOBE, ByVal flagAccion As String) As String
        Return ELTBTIPOCAMBIODAL.SaveRow(ELTBTIPOCAMBIOBE, flagAccion)
    End Function

    Public Function SaveRowCmb(ByVal ELTBTIPOCAMBIOBE As ELTBTIPOCAMBIOBE, ByVal flagAccion As String) As String
        Return ELTBTIPOCAMBIODAL.SaveRowCmb(ELTBTIPOCAMBIOBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBTIPOCAMBIODAL.SelectRow(sCode)
    End Function
    Public Function SelectRow1(ByVal sCode As String) As DataTable
        Return ELTBTIPOCAMBIODAL.SelectRow1(sCode)
    End Function
    Public Function Verificar_Repetido(ByVal sCode As String) As DataTable
        Return ELTBTIPOCAMBIODAL.Verificar_Repetido(sCode)
    End Function

    Public Function SelectT_Moneda() As DataTable
        Return ELTBTIPOCAMBIODAL.SelectT_Moneda()
    End Function

    Public Function CalcularDolares(ByVal mon As String, ByVal monto As String, ByVal tc As String) As DataTable
        Return ELTBTIPOCAMBIODAL.CalcularDolares(mon, monto, tc)
    End Function
End Class

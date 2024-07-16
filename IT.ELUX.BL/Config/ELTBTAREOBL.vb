
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBTAREOBL
    Private ELTBTAREODAL As New ELTBTAREODAL

    Public Function SelectAll(ByVal Anho As String, ByVal Mes As String) As DataTable
        Return ELTBTAREODAL.SelectAll(Anho, Mes)
    End Function

    Public Function SaveRow(ByVal ELTBTAREOBE As ELTBTAREOBE, ByVal flagAccion As String, ByVal dgtareo As DataGridView) As String
        Return ELTBTAREODAL.SaveRow(ELTBTAREOBE, flagAccion, dgtareo)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBTAREODAL.SelectRow(sCode)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String) As DataTable
        Return ELTBTAREODAL.SelectRowGrid(sCode)
    End Function

    Public Function SelectPerCOD(ByVal codigo As String) As DataTable
        Return ELTBTAREODAL.SelectPerCOD(codigo)
    End Function

    Public Function SelectCondiPago() As DataTable
        Return ELTBTAREODAL.SelectCondiPago()
    End Function

    Public Function SelectPaisCod(ByVal sCode As String) As DataTable
        Return ELTBTAREODAL.SelectPaisCod(sCode)
    End Function
    Public Function ContarRegistros() As String
        Return ELTBTAREODAL.ContarRegistros()
    End Function

End Class


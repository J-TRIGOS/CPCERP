
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELCONTRATOBL
    Private ELCONTRATODAL As New ELCONTRATODAL
    Public Function SelPerAll(ByVal nro As String) As DataTable
        Return ELCONTRATODAL.SelPerAll(nro)
    End Function

    Public Function SelectAll(ByVal Anho As String) As DataTable
        Return ELCONTRATODAL.SelectAll(Anho)
    End Function

    Public Function SaveRow(ByVal ELCONTRATOBE As ELCONTRATOBE, ByVal flagAccion As String, ByVal dgtareo As DataGridView) As String
        Return ELCONTRATODAL.SaveRow(ELCONTRATOBE, flagAccion, dgtareo)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELCONTRATODAL.SelectRow(sCode)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String) As DataTable
        Return ELCONTRATODAL.SelectRowGrid(sCode)
    End Function

    Public Function SelectPerCOD(ByVal codigo As String) As DataTable
        Return ELCONTRATODAL.SelectPerCOD(codigo)
    End Function

    Public Function SelectCondiPago() As DataTable
        Return ELCONTRATODAL.SelectCondiPago()
    End Function

    Public Function SelectDgvProv(ByVal sMesAño As String, ByVal sProd As String) As DataTable
        Return ELCONTRATODAL.SelectDgvProv(sMesAño, sProd)
    End Function

    Public Function SelectDgvProvCTS(ByVal sMesAño As String, ByVal sProd As String) As DataTable
        Return ELCONTRATODAL.SelectDgvProvCTS(sMesAño, sProd)
    End Function

    Public Function SelectDgvProvGra(ByVal sMesAño As String, ByVal sProd As String) As DataTable
        Return ELCONTRATODAL.SelectDgvProvGra(sMesAño, sProd)
    End Function

    Public Function SelectComPer(ByVal pPRDO As String) As DataTable
        Return ELCONTRATODAL.SelectComPer(pPRDO)
    End Function

    Public Function SelectHorNocPer(ByVal pPRDO As String) As DataTable
        Return ELCONTRATODAL.SelectHorNocPer(pPRDO)
    End Function

    Public Function SelectHorNocPer1(ByVal pPRDO As String) As DataTable
        Return ELCONTRATODAL.SelectHorNocPer1(pPRDO)
    End Function

    Public Function SelectPaisCod(ByVal sCode As String) As DataTable
        Return ELCONTRATODAL.SelectPaisCod(sCode)
    End Function
    Public Function ContarRegistros() As String
        Return ELCONTRATODAL.ContarRegistros()
    End Function
    'PROVISION VACACIONES
    Public Function PROGVACA(ByVal PRDO As String, ByVal flagaccion As String, ByVal dg As DataGridView) As String
        'Verifica el kardex
        Return ELCONTRATODAL.PROGVACA(PRDO, flagaccion, dg)
    End Function

End Class


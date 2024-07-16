
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBREGISTRO_NROBL
    Private ELTBREGISTRO_NRODAL As New ELTBREGISTRO_NRODAL

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBREGISTRO_NRODAL.SelectAll(sFecAño, sFecMes)
    End Function

    Public Function SelectMaxTransp() As String
        Return ELTBREGISTRO_NRODAL.SelectMaxTransp()
    End Function

    Public Function SaveRow(ByVal ELTBREGISTRO_NROBE As ELTBREGISTRO_NROBE, ByVal flagAccion As String) As String
        Return ELTBREGISTRO_NRODAL.SaveRow(ELTBREGISTRO_NROBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sCode2 As String, ByVal sCode3 As String, ByVal sCode4 As String) As DataTable
        Return ELTBREGISTRO_NRODAL.SelectRow(sCode, sCode2, sCode3, sCode4)
    End Function
    Public Function VerificarRegistro(ByVal sanho As String) As DataTable
        Return ELTBREGISTRO_NRODAL.VerificarRegistro(sanho)
    End Function
    Public Function InsertRegistro(ByVal sanho As String)
        ELTBREGISTRO_NRODAL.InsertRegistro(sanho)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Return ELTBREGISTRO_NRODAL.SelectRowGrid(sCode, sOpcion)
    End Function
    Public Function SelectTipOpe(ByVal Anio As String) As DataTable
        Return ELTBREGISTRO_NRODAL.SelectTipOpe(Anio)
    End Function
    Public Function SelectTipOpeCOD(ByVal Anio As String, ByVal Cod As String) As DataTable
        Return ELTBREGISTRO_NRODAL.SelectTipOpeCOD(Anio, Cod)
    End Function
    Public Function VerificarRepetido(ByVal Anio As String, ByVal Cod As String, ByVal t_ope As String, ByVal prebanco As String) As Boolean
        Return ELTBREGISTRO_NRODAL.VerificarRepetido(Anio, Cod, t_ope, prebanco)
    End Function
    Public Function SelectPrefBanco() As DataTable
        Return ELTBREGISTRO_NRODAL.SelectPrefBanco()
    End Function

    Public Function SelectBanco() As DataTable
        Return ELTBREGISTRO_NRODAL.SelectBanco()
    End Function
    Public Function SelectPrefBancoCOD(ByVal codigo As String) As DataTable
        Return ELTBREGISTRO_NRODAL.SelectPrefBancoCOD(codigo)
    End Function
    Public Function SelectVendedor() As DataTable
        Return ELTBREGISTRO_NRODAL.SelectVendedor()
    End Function
    Public Function SelectActi_Serv() As DataTable
        Return ELTBREGISTRO_NRODAL.SelectActi_Serv()
    End Function
End Class


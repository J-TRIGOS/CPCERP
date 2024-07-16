
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBCUENTA_OPEBL
    Private ELTBCUENTA_OPEDAL As New ELTBCUENTA_OPEDAL

    Public Function SelectAll(ByVal sFecAño As String) As DataTable
        Return ELTBCUENTA_OPEDAL.SelectAll(sFecAño)
    End Function

    Public Function SelectMaxTransp() As String
        Return ELTBCUENTA_OPEDAL.SelectMaxTransp()
    End Function

    Public Function SaveRow(ByVal ELTBCUENTA_OPBE As ELTBCUENTA_OPBE, ByVal flagAccion As String) As String
        Return ELTBCUENTA_OPEDAL.SaveRow(ELTBCUENTA_OPBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sCode2 As String, ByVal sCode3 As String, ByVal sCode4 As String, ByVal sCode5 As String) As DataTable
        Return ELTBCUENTA_OPEDAL.SelectRow(sCode, sCode2, sCode3, sCode4, sCode5)
    End Function
    Public Function VerificarRegistro() As DataTable
        Return ELTBCUENTA_OPEDAL.VerificarRegistro()
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Return ELTBCUENTA_OPEDAL.SelectRowGrid(sCode, sOpcion)
    End Function
    Public Function SelectTipOpe(ByVal Anio As String) As DataTable
        Return ELTBCUENTA_OPEDAL.SelectTipOpe(Anio)
    End Function
    Public Function SelectTipOpeCOD(ByVal Anio As String, ByVal Cod As String) As DataTable
        Return ELTBCUENTA_OPEDAL.SelectTipOpeCOD(Anio, Cod)
    End Function
    Public Function VerificarRepetido(ByVal tipo As String, ByVal doc As String, ByVal afecto As String, ByVal importe As String) As Boolean
        Return ELTBCUENTA_OPEDAL.VerificarRepetido(tipo, doc, afecto, importe)
    End Function
    Public Function SelectCta(ByVal codigo As String) As DataTable
        Return ELTBCUENTA_OPEDAL.SelectCta(codigo)
    End Function
    Public Function SelectTipImpto() As DataTable
        Return ELTBCUENTA_OPEDAL.SelectTipImpto()
    End Function
    Public Function SelectTipImptoCOD(ByVal codigo As String) As DataTable
        Return ELTBCUENTA_OPEDAL.SelectTipImptoCOD(codigo)
    End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String) As Boolean
        Return ELTBCUENTA_OPEDAL.VerificarRepetido(Code, Code2)
    End Function
    Public Function SelectCtaCodigo(ByVal anho As String, ByVal cod As String) As DataTable
        Return ELTBCUENTA_OPEDAL.SelectCtaCodigo(anho, cod)
    End Function
End Class


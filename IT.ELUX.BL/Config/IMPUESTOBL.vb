
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class IMPUESTOBL
    Private IMPUESTODAL As New IMPUESTODAL

    Public Function SelectAll() As DataTable
        Return IMPUESTODAL.SelectAll()
    End Function

    'Public Function SelectMaxTransp(ByVal sFecAño As String, ByVal sFecmes As String, ByVal sTipo_ope As String, ByVal sNro_reg As String) As String
    '    Return IMPUESTODAL.SelectMaxTransp(sFecAño, sFecmes, sTipo_ope, sNro_reg)
    'End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String) As Boolean
        Return IMPUESTODAL.VerificarRepetido(Code, Code2)
    End Function
    Public Function SaveRow(ByVal IMPUESTOBE As IMPUESTOBE, ByVal flagAccion As String) As String
        Return IMPUESTODAL.SaveRow(IMPUESTOBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return IMPUESTODAL.SelectRow(sCode)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Return IMPUESTODAL.SelectRowGrid(sCode, sOpcion)
    End Function
    Public Function SelectTipOpe(ByVal Anio As String) As DataTable
        Return IMPUESTODAL.SelectTipOpe(Anio)
    End Function
    Public Function VerificarRepetido(ByVal Anio As String) As Boolean
        Return IMPUESTODAL.VerificarRepetido(Anio)
    End Function
End Class


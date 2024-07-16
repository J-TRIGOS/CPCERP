
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBMOVIMIENTOBL
    Private ELTBMOVIMIENTODAL As New ELTBMOVIMIENTODAL

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecmes As String) As DataTable
        Return ELTBMOVIMIENTODAL.SelectAll(sFecAño, sFecmes)
    End Function

    Public Function SelectMaxTransp(ByVal sFecAño As String, ByVal sFecmes As String, ByVal sTipo_ope As String, ByVal sNro_reg As String) As String
        Return ELTBMOVIMIENTODAL.SelectMaxTransp(sFecAño, sFecmes, sTipo_ope, sNro_reg)
    End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String) As Boolean
        Return ELTBMOVIMIENTODAL.VerificarRepetido(Code, Code2)
    End Function
    Public Function SaveRow(ByVal ELTBMOVIMIENTOBE As ELTBMOVIMIENTOBE, ByVal flagAccion As String) As String
        Return ELTBMOVIMIENTODAL.SaveRow(ELTBMOVIMIENTOBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal gsCode2 As String, ByVal gsCode3 As String, ByVal gsCode4 As String, ByVal gsCode5 As String) As DataTable
        Return ELTBMOVIMIENTODAL.SelectRow(sCode, gsCode2, gsCode3, gsCode4, gsCode5)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Return ELTBMOVIMIENTODAL.SelectRowGrid(sCode, sOpcion)
    End Function
    Public Function SelectUbigeo() As DataTable
        Return ELTBMOVIMIENTODAL.SelectUbigeo()
    End Function
    Public Function SelectVendedor() As DataTable
        Return ELTBMOVIMIENTODAL.SelectVendedor()
    End Function
    Public Function SelectActi_Serv() As DataTable
        Return ELTBMOVIMIENTODAL.SelectActi_Serv()
    End Function
    Public Function SelectT_Moneda() As DataTable
        Return ELTBMOVIMIENTODAL.SelectT_Moneda()
    End Function
    Public Function SelectT_Documento() As DataTable
        Return ELTBMOVIMIENTODAL.SelectT_Documento()
    End Function
    Public Function SelectTipOpe(ByVal Anio As String) As DataTable
        Return ELTBMOVIMIENTODAL.SelectTipOpe(Anio)
    End Function
End Class


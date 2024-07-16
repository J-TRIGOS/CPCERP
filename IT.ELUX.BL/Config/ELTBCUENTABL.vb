
Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBCUENTABL
    Private ELTBCUENTADAL As New ELTBCUENTADAL

    Public Function SelectAll(ByVal sFecAño As String) As DataTable
        Return ELTBCUENTADAL.SelectAll(sFecAño)
    End Function

    Public Function SelectMaxTransp() As String
        Return ELTBCUENTADAL.SelectMaxTransp()
    End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String) As Boolean
        Return ELTBCUENTADAL.VerificarRepetido(Code, Code2)
    End Function
    Public Function SaveRow(ByVal ELTBCUENTABE As ELTBCUENTABE, ByVal flagAccion As String) As String
        Return ELTBCUENTADAL.SaveRow(ELTBCUENTABE, flagAccion)
    End Function
    Public Function VerificarRegistro(ByVal sanho As String) As DataTable
        Return ELTBCUENTADAL.VerificarRegistro(sanho)
    End Function
    Public Function InsertRegistro(ByVal sanho As String)
        ELTBCUENTADAL.InsertRegistro(sanho)
    End Function
    Public Function SelectRow(ByVal sCode As String, ByVal gsCode2 As String) As DataTable
        Return ELTBCUENTADAL.SelectRow(sCode, gsCode2)
    End Function
    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Return ELTBCUENTADAL.SelectRowGrid(sCode, sOpcion)
    End Function
    Public Function SelectUbigeo() As DataTable
        Return ELTBCUENTADAL.SelectUbigeo()
    End Function
    Public Function SelectVendedor() As DataTable
        Return ELTBCUENTADAL.SelectVendedor()
    End Function
    Public Function SelectActi_Serv() As DataTable
        Return ELTBCUENTADAL.SelectActi_Serv()
    End Function
    Public Function SelectT_Moneda() As DataTable
        Return ELTBCUENTADAL.SelectT_Moneda()
    End Function
End Class


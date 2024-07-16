Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBSTIEMBL

    Private ELTBSTIEMDAL As New ELTBSTIEMDAL
    Public Function SelectActivos(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBSTIEMDAL.SelectActivos(sFecAño, sFecMes)
    End Function

    Public Function SelectActivos1(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBSTIEMDAL.SelectActivos1(sFecAño, sFecMes)
    End Function

    Public Function SelectAllHEJ(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBSTIEMDAL.SelectAllHEJ(sFecAño, sFecMes)
    End Function

    Public Function SelectAll(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBSTIEMDAL.SelectAll(sFecAño, sFecMes)
    End Function

    Public Function SelectBonoPro(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBSTIEMDAL.SelectBonoPro(sFecAño, sFecMes)
    End Function

    Public Function SelectAllHEJP(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBSTIEMDAL.SelectAllHEJP(sFecAño, sFecMes)
    End Function

    Public Function SelectAllHERH(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBSTIEMDAL.SelectAllHERH(sFecAño, sFecMes)
    End Function

    Public Function SelectAllAp(ByVal sFecAño As String, ByVal sFecMes As String) As DataTable
        Return ELTBSTIEMDAL.SelectAllAp(sFecAño, sFecMes)
    End Function

    Public Function SelectRow(ByVal sCOD As String, ByVal sSER As String, ByVal sNRO As String) As DataTable
        Return ELTBSTIEMDAL.SelectRow(sCOD, sSER, sNRO)
    End Function

    Public Function SelectRow1(ByVal sT_doc As String, ByVal sS_doc As String, ByVal sN_doc As String) As DataTable
        Return ELTBSTIEMDAL.SelectRow1(sT_doc, sS_doc, sN_doc)
    End Function

    Public Function LastCodigo(ByVal sCode As String, ByVal sSer As String) As String
        Return ELTBSTIEMDAL.LastCodigo(sCode, sSer)
    End Function

    Public Function lineastiem(ByVal sSer As String, ByVal sNum As String) As String
        Return ELTBSTIEMDAL.lineastiem(sSer, sNum)
    End Function

    Public Function SelectNro(ByVal sCode As String, ByVal sSer As String) As Int32
        Return ELTBSTIEMDAL.SelectNro(sCode, sSer)
    End Function

    Public Function SelPermiso(ByVal sCode As String) As String
        Return ELTBSTIEMDAL.SelPermiso(sCode)
    End Function

    Public Function OK_CCO_COD(ByVal sCode As String) As String
        Return ELTBSTIEMDAL.OK_CCO_COD(sCode)
    End Function

    Public Function VerificarFeriado(ByVal fecha As String) As DataTable
        Return ELTBSTIEMDAL.VerificarFeriado(fecha)
    End Function


#Region "Grabar Datos"


    Public Function SaveRow(ByVal ELTBSTIEMBE As ELTBSTIEMBE, ByVal ELTBDETSTIEMBE As ELTBDETSTIEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                             ByVal dg As DataGridView) As String

        Return ELTBSTIEMDAL.SaveRow(ELTBSTIEMBE, ELTBDETSTIEMBE, ELMVLOGSBE, flagAccion, dg)

    End Function

#End Region
End Class

Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBMTIEMBL
    Private ELTBMTIEMDAL As New ELTBMTIEMDAL
    Public Function LastCodigo(ByVal sCode As String, ByVal sSer As String) As String
        Return ELTBMTIEMDAL.LastCodigo(sCode, sSer)
    End Function
    Public Function SelectAllLines() As DataTable
        Return ELTBMTIEMDAL.SelectAllLines()
    End Function
    Public Function SelectAll(ByVal sFec As String) As DataTable
        Return ELTBMTIEMDAL.SelectAll(sFec)
    End Function
    Public Function SelectNom(ByVal sCode As String, ByVal sSer As String) As String
        Return ELTBMTIEMDAL.SelectNom(sCode, sSer)
    End Function
    Public Function SelectNroOm(ByVal sSer As String, ByVal sCode As String) As DataTable
        Return ELTBMTIEMDAL.SelectNroOm(sSer, sCode)
    End Function
    Public Function SelectRows(ByVal sCode As String) As DataTable
        Return ELTBMTIEMDAL.SelectRows(sCode)
    End Function
    Public Function SaveRow(ByVal ELTBMTIEMBE As ELTBMTIEMBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELTBMTIEMDAL.SaveRow(ELTBMTIEMBE, flagAccion, dg)
    End Function
    Public Function SelectRow(ByVal sCOD As String, ByVal sSER As String, ByVal sNRO As String) As DataTable
        Return ELTBMTIEMDAL.SelectRow(sCOD, sSER, sNRO)
    End Function
    Public Function SelectRowDet(ByVal sCOD As String, ByVal sSER As String, ByVal sNRO As String) As DataTable
        Return ELTBMTIEMDAL.SelectRowDet(sCOD, sSER, sNRO)
    End Function
    Public Function SelectActi() As DataTable
        Return ELTBMTIEMDAL.SelectActi()
    End Function
End Class

Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELALBARANBL
    Private ELALBARANDAL As New ELALBARANDAL
    Public Function SelGuia() As DataTable
        Return ELALBARANDAL.SelGuia()
    End Function
    Public Function SelectAl2(ByVal sNroD As String, ByVal sSerD As String) As DataTable
        Return ELALBARANDAL.SelectAl2(sNroD, sSerD)
    End Function
    Public Function SelectArt(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As DataTable
        Return ELALBARANDAL.SelectArt(sNroD, sSerD, sArt)
    End Function
    Public Function SelectDet(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As DataTable
        Return ELALBARANDAL.SelectDet(sNroD, sSerD, sArt)
    End Function
    Public Function SaveRow(ByVal ELALBARANBE As ELALBARANBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELALBARANDAL.SaveRow(ELALBARANBE, flagAccion, dg)
    End Function
    Public Function LastCodigo(ByVal sSer As String) As String
        Return ELALBARANDAL.LastCodigo(sSer)
    End Function
    Public Function SelectOk(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As String
        Return ELALBARANDAL.SelectOk(sNroD, sSerD, sArt)
    End Function
    Public Function SelectAl4(ByVal sNroD As String, ByVal sSerD As String, ByVal sArt As String) As DataTable
        Return ELALBARANDAL.SelectAl4(sNroD, sSerD, sArt)
    End Function
End Class

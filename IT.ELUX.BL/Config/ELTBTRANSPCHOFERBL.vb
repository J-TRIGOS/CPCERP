Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBTRANSPCHOFERBL
    Private ELTBTRANSPCHOFERDAL As New ELTBTRANSPCHOFERDAL

    Public Function SelectAll() As DataTable
        Return ELTBTRANSPCHOFERDAL.SelectAll()
    End Function

    Public Function SelectMaxTransp(ByVal sCode As String) As String
        Return ELTBTRANSPCHOFERDAL.SelectMaxTransp(sCode)
    End Function

    Public Function SaveRow(ByVal ELTBTRANSPCHOFERBE As ELTBTRANSPCHOFERBE, ByVal flagAccion As String) As String
        Return ELTBTRANSPCHOFERDAL.SaveRow(ELTBTRANSPCHOFERBE, flagAccion)
    End Function

    Public Function SelectRow(ByVal sCode As String, ByVal sCode_cho As String) As DataTable
        Return ELTBTRANSPCHOFERDAL.SelectRow(sCode, sCode_cho)
    End Function

    Public Function SelectT_Transp() As DataTable
        Return ELTBTRANSPCHOFERDAL.SelectT_Transp()
    End Function
End Class

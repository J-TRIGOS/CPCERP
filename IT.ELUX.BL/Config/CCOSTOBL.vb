Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class CCOSTOBL
    Private CCOSTODAL As New CCOSTODAL
    Public Function LastCodigo() As String
        Return CCOSTODAL.LastCodigo()
    End Function

    Public Function SelectAllLines() As DataTable
        Return CCOSTODAL.SelectAllLines()
    End Function

    Public Function LastCodigo1(ByVal sCode As String) As String
        Return CCOSTODAL.LastCodigo1(sCode)
    End Function

    Public Function SelectAll() As DataTable
        Return CCOSTODAL.SelectAll()
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return CCOSTODAL.SelectRow(sCode)
    End Function

    Public Function SelectClasi() As DataTable
        Return CCOSTODAL.SelectClasi()
    End Function

    Public Function SelectNom(ByVal sCode As String) As String
        Return CCOSTODAL.SelectNom(sCode)
    End Function

    Public Function Selectcodlin(ByVal sCode As String) As String
        Return CCOSTODAL.Selectcodlin(sCode)
    End Function

    Public Function getListdgv(ByVal sCod As String) As DataTable
        Return CCOSTODAL.getListdgv(sCod)
    End Function
#Region "Grabar Datos"

    Public Function SaveRow(ByVal CCOSTOBE As CCOSTOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String

        Return CCOSTODAL.SaveRow(CCOSTOBE, flagAccion, ELMVLOGSBE)

    End Function

#End Region
End Class

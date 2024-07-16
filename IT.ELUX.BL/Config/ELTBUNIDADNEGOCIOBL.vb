Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBUNIDADNEGOCIOBL
    Private ELTBUNIDADNEGOCIODAL As New ELTBUNIDADNEGOCIODAL
    Public Function SelectAll() As DataTable

        Return ELTBUNIDADNEGOCIODAL.SelectAll()

    End Function
    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBUNIDADNEGOCIODAL.SelectRow(sCode)

    End Function
    'Public Function LastCodigo() As String

    '    Return ELTBUNIDADNEGOCIODAL.LastCodigo()

    'End Function
    Public Function SaveRow(ByVal ELTBUNIDADNEGOCIOBE As ELTBUNIDADNEGOCIOBE, ByVal flagAccion As String, ByVal ELMVLOGSBE As ELMVLOGSBE) As String

        Return ELTBUNIDADNEGOCIODAL.SaveRow(ELTBUNIDADNEGOCIOBE, flagAccion, ELMVLOGSBE)

    End Function
End Class

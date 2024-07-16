Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELORDEN_MANTBL
    Private ELORDEN_MANTDAL As New ELORDEN_MANTDAL

    Public Function SelectAll(ByVal anho As String, ByVal mes As String) As DataTable
        Return ELORDEN_MANTDAL.SelectAll(anho, mes)
    End Function
#Region "Lectura de Datos"
    Public Function SelectMaxTransp(ByVal anho As String) As String
        Return ELORDEN_MANTDAL.SelectMaxTransp(anho)
    End Function

    Public Function SelectLineaMantSelect(ByVal sTdoc As String, ByVal sSer As String) As DataTable
        Return ELORDEN_MANTDAL.SelectLineaMantSelect(sTdoc, sSer)
    End Function
    Public Function list1(ByVal var As String)
        Return ELORDEN_MANTDAL.list1(var)
    End Function
    Public Function SelectRow(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Return ELORDEN_MANTDAL.SelectRow(sTdoc, sSDoc, sNDoc)
    End Function
    Public Function SelectRowDetalle(ByVal sTdoc As String, ByVal sSDoc As String, ByVal sNDoc As String) As DataTable
        Return ELORDEN_MANTDAL.SelectRowDetalle(sTdoc, sSDoc, sNDoc)
    End Function
#End Region
    Public Function SaveRow(ByVal ELORDEN_MANTBE As ELORDEN_MANTBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagaccion As String, ByVal dg As DataGridView, ByVal ELORDEN_DET_MANTBE As ELORDEN_DET_MANTBE) As String
        Return ELORDEN_MANTDAL.SaveRow(ELORDEN_MANTBE, ELMVLOGSBE, flagaccion, dg, ELORDEN_DET_MANTBE)
    End Function
    Public Function SaveRow1(ByVal ELTBMANTENIMIENTOBE As ELTBMANTENIMIENTOBE, ByVal ELORDEN_MANTBE As ELORDEN_MANTBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagaccion As String) As String
        Return ELORDEN_MANTDAL.SaveRow1(ELTBMANTENIMIENTOBE, ELORDEN_MANTBE, ELMVLOGSBE, flagaccion)
    End Function
End Class

Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBTAREABL
    Private ELTBTAREADAL As New ELTBTAREADAL
    Public Function SelectNro1() As Int32
        Return ELTBTAREADAL.SelectNro1()
    End Function
    Public Function SelectRow(ByVal sCOD As String) As DataTable
        Return ELTBTAREADAL.SelectRow(sCOD)
    End Function
    Public Function SelectAll() As DataTable
        Return ELTBTAREADAL.SelectAll()
    End Function
    Public Function SaveRow(ByVal ELTBTAREABE As ELTBTAREABE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String) As String
        Return ELTBTAREADAL.SaveRow(ELTBTAREABE, ELMVLOGSBE, flagAccion)
    End Function
End Class

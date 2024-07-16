Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class PARCIALBL
    Private PARCIALDAL As New PARCIALDAL
    Public Function getListdgv(ByVal sTip As String, ByVal sSer As String, ByVal sNro As String, ByVal sArt As String) As DataTable
        Return PARCIALDAL.getListdgv(sTip, sSer, sNro, sArt)
    End Function
    Public Function SaveRow(ByVal PARCIALBE As PARCIALBE, ByVal ELMVLOGSBE As ELMVLOGSBE, ByVal flagAccion As String,
                            ByVal dgv As DataGridView) As String
        Return PARCIALDAL.SaveRow(PARCIALBE, ELMVLOGSBE, flagAccion, dgv)
    End Function
End Class

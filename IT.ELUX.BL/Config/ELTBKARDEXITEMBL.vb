Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBKARDEXITEMBL
    Private ELTBKARDEXITEMDAL As New ELTBKARDEXITEMDAL
    Public Function SelectRow(ByVal sCode As String, ByVal sPRDO As String, ByVal sTipo As String, ByVal sNro As String) As DataTable
        Return ELTBKARDEXITEMDAL.SelectRow(sCode, sPRDO, sTipo, sNro)
    End Function
    Public Function SaveRow(ByVal ELTBKARDEXITEMBE As ELTBKARDEXITEMBE, ByVal ELMVLOGSBE As ELMVLOGSBE,
                         ByVal flagAccion As String) As String
        Return ELTBKARDEXITEMDAL.SaveRow(ELTBKARDEXITEMBE, ELMVLOGSBE, flagAccion)
    End Function

    Public Function VerificarDatos(ByVal ELTBKARDEXITEMBE As ELTBKARDEXITEMBE) As DataTable
        Return ELTBKARDEXITEMDAL.VerificarDatos(ELTBKARDEXITEMBE)
    End Function
End Class

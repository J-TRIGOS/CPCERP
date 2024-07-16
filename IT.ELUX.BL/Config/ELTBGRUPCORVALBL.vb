Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBGRUPCORVALBL
    Private ELTBGRUPCORVALDAL As New ELTBGRUPCORVALDAL
#Region "Lectura de Datos"

    Public Sub SelectRow(ByVal sCode As String, ByVal lv As ListBox)

        ELTBGRUPCORVALDAL.SelectRow(sCode, lv)

    End Sub
    Public Sub SelectRow1(ByVal sCode As String, ByVal lv As ListBox)

        ELTBGRUPCORVALDAL.SelectRow1(sCode, lv)

    End Sub
    Public Function SelectRow1(ByVal sCode As String) As DataTable

        Return ELTBGRUPCORVALDAL.SelectRow1(sCode)

    End Function

#End Region


#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBGRUPCORVALBE As ELTBGRUPCORVALBE, ByVal flagAccion As String, ByVal lv As ListBox) As String

        Return ELTBGRUPCORVALDAL.SaveRow(ELTBGRUPCORVALBE, flagAccion, lv)

    End Function
    Public Function SaveRowRC(ByVal ELTBGRUPCORVALBE As ELTBGRUPCORVALBE, ByVal flagAccion As String, ByVal lv As ListView) As String

        Return ELTBGRUPCORVALDAL.SaveRowRC(ELTBGRUPCORVALBE, flagAccion, lv)

    End Function

#End Region
End Class

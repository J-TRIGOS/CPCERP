Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBGRUPCORBL
    Private ELTBGRUPCORDAL As New ELTBGRUPCORDAL

#Region "Lectura de Datos"

    Public Function LastCodigo() As String

        Return ELTBGRUPCORDAL.LastCodigo()

    End Function

    Public Function SelectAll() As DataTable

        Return ELTBGRUPCORDAL.SelectAll()

    End Function


    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBGRUPCORDAL.SelectRow(sCode)

    End Function
    Public Function SelectDescripcion() As DataTable

        Return ELTBGRUPCORDAL.LISTCMB()

    End Function
#End Region


#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBGRUPCORBE As ELTBGRUPCORBE, ByVal flagAccion As String) As String

        Return ELTBGRUPCORDAL.SaveRow(ELTBGRUPCORBE, flagAccion)

    End Function

#End Region
End Class

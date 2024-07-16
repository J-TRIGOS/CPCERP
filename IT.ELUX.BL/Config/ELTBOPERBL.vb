Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBOPERBL
    Private ELTBPROCDAL As New ELTBOPERDAL

#Region "Lectura de Datos"

    Public Function LastCodigo() As String

        Return ELTBPROCDAL.LastCodigo()

    End Function

    Public Function SelectAll() As DataTable

        Return ELTBPROCDAL.SelectAll()

    End Function


    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBPROCDAL.SelectRow(sCode)

    End Function
    Public Function SelectDescripcion() As DataTable

        Return ELTBPROCDAL.LISTCMB()

    End Function

    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region


#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBOPERBE As ELTBOPERBE, ByVal flagAccion As String) As String

        Return ELTBPROCDAL.SaveRow(ELTBOPERBE, flagAccion)

    End Function

#End Region
End Class

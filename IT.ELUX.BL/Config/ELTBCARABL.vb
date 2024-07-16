Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBCARABL
    Private ELTBCARADAL As New ELTBCARADAL

#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    Public Function LastCodigo() As String

        Return ELTBCARADAL.LastCodigo()

    End Function

    Public Function SelectAll() As DataTable

        Return ELTBCARADAL.SelectAll()

    End Function


    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBCARADAL.SelectRow(sCode)

    End Function
    Public Function SelectDescripcion() As DataTable

        Return ELTBCARADAL.LISTCMB()

    End Function

    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region

#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBCARABE As ELTBCARABE, ByVal flagAccion As String) As String

        Return ELTBCARADAL.SaveRow(ELTBCARABE, flagAccion)

    End Function

#End Region


End Class

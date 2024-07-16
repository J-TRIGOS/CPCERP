Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBALMACENBL

    Private ELTBALMACENDAL As New ELTBALMACENDAL

#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    Public Function LastCodigo() As String

        Return ELTBALMACENDAL.LastCodigo()

    End Function

    Public Function SelectAll() As DataTable

        Return ELTBALMACENDAL.SelectAll()

    End Function

    Public Function SelectAll1() As DataTable

        Return ELTBALMACENDAL.SelectAll1()

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBALMACENDAL.SelectRow(sCode)

    End Function


    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region

#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBALMACENBE As ELTBALMACENBE, ByVal flagAccion As String) As String

        Return ELTBALMACENDAL.SaveRow(ELTBALMACENBE, flagAccion)

    End Function

#End Region


End Class

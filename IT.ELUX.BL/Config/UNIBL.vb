Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class UNIBL
    Private UNIDAL As New UNIDAL

#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    'Public Function LastCodigo() As String

    '    Return UNIDAL.LastCodigo()

    'End Function

    Public Function SelectAll() As DataTable

        Return UNIDAL.SelectAll()

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return UNIDAL.SelectRow(sCode)

    End Function


    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region

#End Region

#Region "Grabar Datos"

    Public Function DeleteMenu(ByVal sql As String) As DataTable


        ''Return oUsuarioDAL.DeleteMenu(oUsuarioBE)

    End Function

    Public Function SaveRow(ByVal UNIBE As UNIBE, ByVal flagAccion As String) As String

        Return UNIDAL.SaveRow(UNIBE, flagAccion)

    End Function

#End Region
End Class

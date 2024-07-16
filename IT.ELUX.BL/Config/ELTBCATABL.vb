Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBCATABL
    Private ELTBCATADAL As New ELTBCATADAL

#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    Public Function LastCodigo() As String

        Return ELTBCATADAL.LastCodigo()

    End Function

    Public Function SelectAll() As DataTable

        Return ELTBCATADAL.SelectAll()

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBCATADAL.SelectRow(sCode)

    End Function


    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region

#End Region

#Region "Grabar Datos"

    'Public Function DeleteMenu(ByVal sql As String) As DataTable


    '    ''Return oUsuarioDAL.DeleteMenu(oUsuarioBE)

    'End Function

    Public Function SaveRow(ByVal ELTBCATABE As ELTBCATABE, ByVal flagAccion As String) As String

        Return ELTBCATADAL.SaveRow(ELTBCATABE, flagAccion)

    End Function

#End Region

End Class

Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBMESSAGEBL
    Private ELTBMESSAGEDAL As New ELTBMESSAGEDAL

#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    Public Function LastCodigo() As String

        Return ELTBMESSAGEDAL.LastCodigo()

    End Function

    Public Function SelectAll() As DataTable

        Return ELTBMESSAGEDAL.SelectAll()

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBMESSAGEDAL.SelectRow(sCode)

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

    Public Function SaveRow(ByVal ELTBMESSAGEBE As ELTBMESSAGEBE, ByVal flagAccion As String) As String

        Return ELTBMESSAGEDAL.SaveRow(ELTBMESSAGEBE, flagAccion)

    End Function

#End Region
End Class

Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBLINESBL
    Private ELTBLINESDAL As New ELTBLINESDAL

#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    Public Function LastCodigo() As String

        Return ELTBLINESDAL.LastCodigo()

    End Function

    Public Function SelectAll() As DataTable

        Return ELTBLINESDAL.SelectAll()

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBLINESDAL.SelectRow(sCode)

    End Function

    Public Function SelectDescri(ByVal sCode As String) As String

        Return ELTBLINESDAL.SelectDescri(sCode)

    End Function

    Public Function SelectAllLines() As DataTable

        Return ELTBLINESDAL.SelectAllLines()

    End Function

    Public Function SelectLines() As DataTable

        Return ELTBLINESDAL.SelectLines()

    End Function

    Public Function SelectLines1() As DataTable

        Return ELTBLINESDAL.SelectLines1()

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

    Public Function SaveRow(ByVal ELTBLINESBE As ELTBLINESBE, ByVal flagAccion As String) As String

        Return ELTBLINESDAL.SaveRow(ELTBLINESBE, flagAccion)

    End Function

    'Public Function SaveRowSubLine(ByVal ELTBLINESBE As ELTBLINESBE, ByVal flagAccion As String) As String

    '    Return ELTBLINESDAL.SaveRowSubLine(ELTBLINESBE, flagAccion)

    'End Function

#End Region

End Class

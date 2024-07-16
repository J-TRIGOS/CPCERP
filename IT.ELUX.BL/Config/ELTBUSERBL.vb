Imports IT.ELUX.BE
Imports IT.ELUX.DAL

Public Class ELTBUSERBL

    Private ELTBUSERDAL As New ELTBUSERDAL

#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    Public Function LastCodigo() As String
        Return ELTBUSERDAL.LastCodigo()
    End Function

    Public Function SelectAll() As DataTable
        Return ELTBUSERDAL.SelectAll()
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBUSERDAL.SelectRow(sCode)
    End Function

    Public Function Login(ByVal sUser As String, ByVal sPass As String) As String
        Return ELTBUSERDAL.Login(sUser, sPass)
    End Function

    Public Function SelectUsuNvl(ByVal sCod As String) As String
        Return ELTBUSERDAL.SelectUsuNvl(sCod)
    End Function

    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region

#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBUSERBE As ELTBUSERBE, ByVal flagAccion As String) As String
        Return ELTBUSERDAL.SaveRow(ELTBUSERBE, flagAccion)
    End Function

#End Region


End Class

Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBAREABL
    Private ELTBAREADAL As New ELTBAREADAL

#Region "Lectura de Datos"

    Public Function LastCodigo() As String
        Return ELTBAREADAL.LastCodigo()
    End Function

    Public Function SelNomLin(ByVal sCod As String) As String
        Return ELTBAREADAL.SelNomLin(sCod)
    End Function

    Public Function CodExiste(ByVal sCod As String, ByVal sCCO As String) As String
        Return ELTBAREADAL.CodExiste(sCod, sCCO)
    End Function

    Public Function SelectAll() As DataTable

        Return ELTBAREADAL.SelectAll()

    End Function


    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBAREADAL.SelectRow(sCode)

    End Function
    Public Function SelectDescripcion() As DataTable

        Return ELTBAREADAL.LISTCMB()

    End Function

    'Public Function ListDt(ByVal sql As String) As DataTable

    '    Return ELTBUSERDAL.ListDt(sql)

    'End Function

#End Region


#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBAREABE As ELTBAREABE, ByVal flagAccion As String, ByVal dg As DataGridView) As String
        Return ELTBAREADAL.SaveRow(ELTBAREABE, flagAccion, dg)
    End Function

#End Region
End Class

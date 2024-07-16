Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELSUBLINESBL
    Private ELSUBLINESDAL As New ELSUBLINESDAL
#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    Public Function LastCodigo(ByVal sCode As String) As String

        Return ELSUBLINESDAL.LastCodigo(sCode)

    End Function

    Public Function SelectAll(ByVal sCode As String) As DataTable

        Return ELSUBLINESDAL.SelectAll(sCode)

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELSUBLINESDAL.SelectRow(sCode)

    End Function



#End Region

#End Region

#Region "Grabar Datos"


    Public Function SaveRow(ByVal ELSUBLINESBE As ELSUBLINESBE, ByVal flagAccion As String, ByVal dg As DataGridView) As String

        Return ELSUBLINESDAL.SaveRow(ELSUBLINESBE, flagAccion, dg)

    End Function

#End Region

End Class

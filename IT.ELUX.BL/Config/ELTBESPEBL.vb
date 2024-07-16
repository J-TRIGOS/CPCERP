Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBESPEBL
    Private ELTBESPEDAL As New ELTBESPEDAL
#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"


    Public Function SelectAll(ByVal sCode As String) As DataTable

        Return ELTBESPEDAL.SelectAll(sCode)

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBESPEDAL.SelectRow(sCode)

    End Function



#End Region

#End Region

#Region "Grabar Datos"


    Public Function SaveRow(ByVal ELTBESPEBE As ELTBESPEBE, ByVal flagAccion As String, ByVal dg As DataGridView,
                            ByVal sCodArt As String, ByVal sCodCat As String) As String

        Return ELTBESPEDAL.SaveRow(ELTBESPEBE, flagAccion, dg, sCodArt, sCodCat)

    End Function

#End Region

End Class

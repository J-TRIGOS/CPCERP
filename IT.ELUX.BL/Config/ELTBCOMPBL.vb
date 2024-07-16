Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBCOMPBL
    Private ELTBCOMPDAL As New ELTBCOMPDAL
#Region "Lectura de Datos"

#Region "SQL"


    Public Function SelectAll(ByVal sCode As String) As DataTable

        Return ELTBCOMPDAL.SelectAll(sCode)

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBCOMPDAL.SelectRow(sCode)

    End Function



#End Region

#End Region

#Region "Grabar Datos"


    Public Function SaveRow(ByVal ELTBCOMPBE As ELTBCOMPBE, ByVal flagAccion As String, ByVal dg As DataGridView,
                            ByVal sCodArt As String) As String
        Return ELTBCOMPDAL.SaveRow(ELTBCOMPBE, flagAccion, dg, sCodArt)
    End Function

    Public Function SaveRowCMP(ByVal ELTBCOMPBE As ELTBCOMPBE, ByVal flagAccion As String, ByVal dg As DataGridView,
                            ByVal sCodArt As String) As String
        Return ELTBCOMPDAL.SaveRowCMP(ELTBCOMPBE, flagAccion, dg, sCodArt)
    End Function

#End Region
End Class

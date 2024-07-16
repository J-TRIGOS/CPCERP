Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBREAPBL
    Private ELTBREAPDAL As New ELTBREAPDAL


#Region "SQL"


    Public Function SelectAll(ByVal sCode As String) As DataTable
        Return ELTBREAPDAL.SelectAll(sCode)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBREAPDAL.SelectRow(sCode)
    End Function

    Public Function SelAreaCCO(ByVal sCode As String) As DataTable
        Return ELTBREAPDAL.SelAreaCCO(sCode)
    End Function


#End Region

#Region "Grabar Datos"

    Public Function SaveRow(ByVal ELTBREAPBE As ELTBREAPBE, ByVal flagAccion As String, ByVal dg As DataGridView,
                            ByVal scodecat As String) As String

        Return ELTBREAPDAL.SaveRow(ELTBREAPBE, flagAccion, dg, scodecat)

    End Function

#End Region
End Class

Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBREPOBL
    Private ELTBREPODAL As New ELTBREPODAL
#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    'Public Function LastCodigo(ByVal sCode As String) As String

    '    Return ELTBRECCDAL.LastCodigo(sCode)

    'End Function

    Public Function SelectAll(ByVal sCode As String) As DataTable

        Return ELTBREPODAL.SelectAll(sCode)

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBREPODAL.SelectRow(sCode)

    End Function

    Public Sub ActualizarUnidxHora(ByVal codigo As String, ByVal unid As String)
        ELTBREPODAL.ActualizarUnidxHora(codigo, unid)
    End Sub




#End Region

#End Region

#Region "Grabar Datos"

    Public Function DeleteMenu(ByVal sql As String) As DataTable


        ''Return oUsuarioDAL.DeleteMenu(oUsuarioBE)

    End Function

    Public Function SaveRow(ByVal ELTBREPOBE As ELTBREPOBE, ByVal flagAccion As String, ByVal dg As DataGridView,
                            ByVal scodecat As String) As String

        Return ELTBREPODAL.SaveRow(ELTBREPOBE, flagAccion, dg, scodecat)

    End Function


#End Region
End Class

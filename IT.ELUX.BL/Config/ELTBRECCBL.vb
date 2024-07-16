Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBRECCBL
    Private ELTBRECCDAL As New ELTBRECCDAL
#Region "Lectura de Datos"

#Region "SP"

#End Region

#Region "SQL"

    'Public Function LastCodigo(ByVal sCode As String) As String

    '    Return ELTBRECCDAL.LastCodigo(sCode)

    'End Function

    Public Function SelectAll(ByVal sCode As String) As DataTable

        Return ELTBRECCDAL.SelectAll(sCode)

    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable

        Return ELTBRECCDAL.SelectRow(sCode)

    End Function



#End Region

#End Region

#Region "Grabar Datos"

    Public Function DeleteMenu(ByVal sql As String) As DataTable


        ''Return oUsuarioDAL.DeleteMenu(oUsuarioBE)

    End Function

    Public Function SaveRow(ByVal ELTBRECCBE As ELTBRECCBE, ByVal flagAccion As String, ByVal dg As DataGridView,
                            ByVal scodecat As String) As String

        Return ELTBRECCDAL.SaveRow(ELTBRECCBE, flagAccion, dg, scodecat)

    End Function

#End Region

End Class

Imports IT.ELUX.BE
Imports IT.ELUX.DAL
Public Class ELTBGRUPOBL
    Private ELTBGRUPODAL As New ELTBGRUPODAL

#Region "Lectura de Datos"

#Region "SQL"

    Public Function LastCodigo() As String
        Return ELTBGRUPODAL.LastCodigo()
    End Function

    Public Function SelectAll() As DataTable
        Return ELTBGRUPODAL.SelectAll()
    End Function

    Public Function SearhGroup(ByVal sCod As String) As DataTable
        Return ELTBGRUPODAL.SearhGroup(sCod)
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Return ELTBGRUPODAL.SelectRow(sCode)
    End Function

    Public Function SelectDescripcion() As DataTable
        Return ELTBGRUPODAL.LISTCMB()
    End Function

    Public Function list1() As DataTable
        Return ELTBGRUPODAL.list1()
    End Function

    Public Function list2(ByVal sCod As String) As DataTable
        Return ELTBGRUPODAL.list2(sCod)
    End Function

    Public Function listcco_cod(ByVal sCod As String) As DataTable
        Return ELTBGRUPODAL.listcco_cod(sCod)
    End Function

    Public Function SearhDetGrup(ByVal sCod As String) As DataTable
        Return ELTBGRUPODAL.SearhDetGrup(sCod)
    End Function

    Public Function listgrupo() As DataTable
        Return ELTBGRUPODAL.listgrupo()
    End Function

    Public Function SearhCCO() As DataTable
        Return ELTBGRUPODAL.SearhCCO()
    End Function
    Public Function SearhALLCCO(ByVal sCod As String) As DataTable
        Return ELTBGRUPODAL.SearhALLCCO(sCod)
    End Function
    Public Function SearhPERCAL() As DataTable
        Return ELTBGRUPODAL.SearhPERCAL()
    End Function
#End Region

#End Region

#Region "Grabar Datos"

    'Public Function DeleteMenu(ByVal sql As String) As DataTable


    '    ''Return oUsuarioDAL.DeleteMenu(oUsuarioBE)

    'End Function

    Public Function SaveRow(ByVal ELTBGRUPOBE As ELTBGRUPOBE, ByVal ELTBDETGRUPOBE As ELTBDETGRUPOBE, ByVal flagAccion As String,
                            ByVal dg As DataGridView, ByVal cod As String) As String

        Return ELTBGRUPODAL.SaveRow(ELTBGRUPOBE, ELTBDETGRUPOBE, flagAccion, dg, cod)

    End Function

#End Region

End Class

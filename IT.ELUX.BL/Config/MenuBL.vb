'Imports IT.ELUX.BE  'Importamos la capa de entidades
Imports IT.ELUX.DAL

Public Class MenuBL

    Dim oMenu As New MenuDAL

    Public Function ListMenu(ByVal sCodUsr As String) As DataTable
        Return oMenu.ListMenu(sCodUsr)
    End Function

    Public Function ListMenu1(ByVal sCodUsr As String, ByVal sCodMnu As String) As DataTable
        Return oMenu.ListMenu1(sCodUsr, sCodMnu)
    End Function

    'Public Function ListMenuEmpresa(ByVal sCodEmp As String, ByVal sDB As String) As DataTable
    '    Return oMenu.ListMenuEmpresa(sCodEmp, sDB)
    'End Function

    'Public Function ListMenuSistema(ByVal sCodEmp As String, ByVal sCodSis As String, ByVal sDB As String) As DataTable
    '    Return oMenu.ListMenuSistema(sCodEmp, sCodSis, sDB)
    'End Function

    'Public Function ListTablaPermisos(ByVal sCodSis As String, ByVal sCodTab As String, ByVal sDB As String) As DataTable
    '    Return oMenu.ListTablaPermisos(sCodSis, sCodTab, sDB)
    'End Function
End Class
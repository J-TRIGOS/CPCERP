Imports IT.Admin.BE
Imports System.Data
Imports System.Data.SqlClient
Imports IT.Admin.Connect
Imports System.Text

Public Class MenuDAL
    Inherits BaseDatosMSSQL

    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function ListMenu(ByVal sCodEmp As String, ByVal sCodUsr As String, ByVal sDB As String) As DataTable
        Dim cmd As New SqlCommand
        ''Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        'Crypto("RRHH", "USP_Crp_PLmvhrex_InsertRow", , , 1)
        Using dr As SqlDataReader = Me.GetDataReader(sDB + "..USP_Crp_TGMenu_Access_List", {New SqlParameter("@CodEmp", sCodEmp),
                                                                                         New SqlParameter("@CodUsr", sCodUsr)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        'Crypto("RRHH", "USP_Crp_PLmvhrex_InsertRow", sqlCon, sqlTrans, 1)

        Return dt

    End Function

    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function ListMenuEmpresa(ByVal sCodEmp As String, ByVal sDB As String) As DataTable
        Dim cmd As New SqlCommand
        ''Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Using dr As SqlDataReader = Me.GetDataReader(sDB + "..USP_TGMenu_Empresa_List", {New SqlParameter("@CodEmp", sCodEmp)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    'Listado de menu de un sistema
    Public Function ListMenuSistema(ByVal sCodEmp As String, ByVal sCodSis As String, ByVal sDB As String) As DataTable
        Dim cmd As New SqlCommand
        ''Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Using dr As SqlDataReader = Me.GetDataReader(sDB + "..USP_TGMenu_Sistema_List", {New SqlParameter("@CodEmp", sCodEmp),
                                                                                         New SqlParameter("@CodSis", sCodSis)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    'Listado de menu de un sistema
    Public Function ListTablaPermisos(ByVal sCodSis As String, ByVal sCodTab As String, ByVal sDB As String) As DataTable
        Dim cmd As New SqlCommand
        ''Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Using dr As SqlDataReader = Me.GetDataReader(sDB + "..USP_TGTabla_Permiso_List", {New SqlParameter("@CodSis", sCodSis),
                                                                                          New SqlParameter("@CodTab", sCodTab)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt

    End Function

    'Return oMenu.ListTablaPermisos(sCodEmp, sCodSis, sCodTab, sCodUsr)
End Class

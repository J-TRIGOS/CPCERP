Imports System.Data
'Imports Oracle.DataAccess.Client
Imports Oracle.ManagedDataAccess.Client


'Imports System.Data.OracleClient
'Imports System.Data.or
Imports IT.ELUX.Connect
Imports System.Text

Public Class MenuDAL
    Inherits BaseDatosORACLE

    'Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    'un Datatable
    Public Function ListMenu(ByVal sCodUsr As String) As DataTable
        Dim cmd As New OracleCommand

        ''Dim da As New OracleDataAdapter
        Dim dt As New DataTable

        'Command.Parameters.Add(New OracleParameter("N_EMPNO", OracleType.Number)).Value = 7369
        'Command.Parameters.Add(New OracleParameter("IO_CURSOR", OracleType.Cursor)).Direction = ParameterDirection.Output




        '  Using dr As OracleDataReader = Me.GetDataReader("..USP_Crp_TGMenu_Access_List", {New OracleParameter("@CodUsr", sCodUsr)})
        Using dr As OracleDataReader = Me.GetDataReader("SP_MENU_ACCESOS", {New OracleParameter("@CodUsr", sCodUsr)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using


        Return dt

    End Function
    Public Function ListMenu1(ByVal sCodUsr As String, ByVal sCodMnu As String) As DataTable
        Dim cmd As New OracleCommand
        Dim dt As New DataTable
        '  Using dr As OracleDataReader = Me.GetDataReader("..USP_Crp_TGMenu_Access_List", {New OracleParameter("@CodUsr", sCodUsr)})
        Using dr As OracleDataReader = Me.GetDataReader("SP_MENU_ACCESOS1", {New OracleParameter("@CodUsr", sCodUsr),
                                                                             New OracleParameter("@sCodMnu", sCodMnu)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    ''Funcion que me va permitir capturar la lista de registros en la tabla y que me va retornar
    ''un Datatable
    'Public Function ListMenuEmpresa(ByVal sCodEmp As String, ByVal sDB As String) As DataTable
    '    Dim cmd As New OracleCommand
    '    ''Dim da As New OracleDataAdapter
    '    Dim dt As New DataTable

    '    Using dr As OracleDataReader = Me.GetDataReader(sDB + "..USP_TGMenu_Empresa_List", {New OracleParameter("@CodEmp", sCodEmp)})
    '        If dr.HasRows Then
    '            dt.Load(dr)
    '        End If
    '    End Using
    '    Return dt

    'End Function

    ''Listado de menu de un sistema
    'Public Function ListMenuSistema(ByVal sCodEmp As String, ByVal sCodSis As String, ByVal sDB As String) As DataTable
    '    Dim cmd As New OracleCommand
    '    ''Dim da As New OracleDataAdapter
    '    Dim dt As New DataTable

    '    Using dr As OracleDataReader = Me.GetDataReader(sDB + "..USP_TGMenu_Sistema_List", {New OracleParameter("@CodEmp", sCodEmp),
    '                                                                                     New OracleParameter("@CodSis", sCodSis)})
    '        If dr.HasRows Then
    '            dt.Load(dr)
    '        End If
    '    End Using
    '    Return dt

    'End Function

    ''Listado de menu de un sistema
    'Public Function ListTablaPermisos(ByVal sCodSis As String, ByVal sCodTab As String, ByVal sDB As String) As DataTable
    '    Dim cmd As New OracleCommand
    '    ''Dim da As New OracleDataAdapter
    '    Dim dt As New DataTable

    '    Using dr As OracleDataReader = Me.GetDataReader(sDB + "..USP_TGTabla_Permiso_List", {New OracleParameter("@CodSis", sCodSis),
    '                                                                                      New OracleParameter("@CodTab", sCodTab)})
    '        If dr.HasRows Then
    '            dt.Load(dr)
    '        End If
    '    End Using
    '    Return dt

    'End Function

    'Return oMenu.ListTablaPermisos(sCodEmp, sCodSis, sCodTab, sCodUsr)
End Class

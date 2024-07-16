Imports IT.ELUX.BE 'Importamos la capa de entidades, si tienen error es porque no se agrego la referencia
Imports Oracle.ManagedDataAccess.Client
Imports IT.ELUX.Connect

Public Class ELTBCONCEPTOSDAL
    'Instanciamos el objeto _Conexion de la clase Conexion para obtener la cadena de conexion a la BD
    '' Dim _Conexion As New Conexion
    Inherits BaseDatosORACLE
    Public sUnid As String
    Public sNumero As String
    Public sNumero1 As String
    Public sNomArt As String
    'Public ELMVLOGSBE As New ELMVLOGSBE

    Public Function SelectAll() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RELCONCEPTOS_SELECTALL", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectTipImpto() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_IMPTO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerificarRepetido(ByVal Code As String, ByVal Code2 As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CUENTA_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode", Code), New Oracle.ManagedDataAccess.Client.OracleParameter("@gscode2", Code2)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
    Public Function SelectTipImptoCOD(ByVal codigo As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_OPE_COD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", codigo)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRow(ByVal sCode As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RELCONCEPTOS_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function VerificarRegistro() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CT_REG_NRO_VERIFICAR_REG", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectRowGrid(ByVal sCode As String, ByVal sOpcion As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CLIENTEGRID_SELECTROW", {New Oracle.ManagedDataAccess.Client.OracleParameter("@code", sCode), New Oracle.ManagedDataAccess.Client.OracleParameter("@opcion", sOpcion)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectTipOpe(ByVal Anio As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_COMBO_T_OPE", {New Oracle.ManagedDataAccess.Client.OracleParameter("@Anio", Anio)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function SelectCta(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_OPE_CUENTA", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    'IMPLEMENTADO RECIEN-D-------------------------------------------------
    Public Function SelectCtaCodigo(ByVal anho As String, ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CTA_OPE_CUENTACOD", {New Oracle.ManagedDataAccess.Client.OracleParameter("@ANHO", anho),
                                                                                                                 New Oracle.ManagedDataAccess.Client.OracleParameter("@COD", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function VerificarRepetido(ByVal tipo As String, ByVal doc As String, ByVal afecto As String, ByVal importe As String) As Boolean
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CTA_OPE_RG_VERIFICAR", {New Oracle.ManagedDataAccess.Client.OracleParameter("@tipo", tipo), New Oracle.ManagedDataAccess.Client.OracleParameter("@doc", doc),
                                                        New Oracle.ManagedDataAccess.Client.OracleParameter("@afecto", afecto), New Oracle.ManagedDataAccess.Client.OracleParameter("@importe", importe)})
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Public Function SelectConceptoCOD(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CODIGO_CONCEPTO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function Select_Concepto() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RELCONCEPTOS_COMBO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    ''sdasdasdasdasdasdasdsadasd
    Public Function SelectTipoConceCOD(ByVal cod As String) As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable

        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_CODIGO_TIPOCO", {New Oracle.ManagedDataAccess.Client.OracleParameter("@cod", cod)})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function

    Public Function Select_TipoConcepto() As DataTable
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As Oracle.ManagedDataAccess.Client.OracleDataReader = Me.GetDataReader("SP_RELCONCEPTOS_TCO", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt
    End Function
    Public Function SelectMaxTransp() As String
        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        Dim dt As New DataTable
        Using dr As OracleDataReader = Me.GetDataReader("SP_CONCEPTOS_LASTCOD", {})
            If dr.HasRows Then
                dt.Load(dr)
            End If
        End Using
        Return dt.Rows(0).Item(0)
    End Function

    Private Sub InsertRow(ByVal ELTBCONCEPTOSBE As ELTBCONCEPTOSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RELCONCEPTOS_INSERTROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase         
        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.nom
        cmd.Parameters.Add("@cpto_cod", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cpto_cod
        cmd.Parameters.Add("@t_per_cod", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.t_per_cod
        cmd.Parameters.Add("@porc", OracleDbType.Double).Value = ELTBCONCEPTOSBE.porc
        cmd.Parameters.Add("@monto", OracleDbType.Double).Value = ELTBCONCEPTOSBE.monto
        cmd.Parameters.Add("@t_cpto", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.t_cpto
        cmd.Parameters.Add("@t_impres", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.t_impres
        cmd.Parameters.Add("@cta_adm", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cta_adm
        cmd.Parameters.Add("@cta_plan", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cta_plan
        cmd.Parameters.Add("@cta_ven", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cta_ven
        cmd.Parameters.Add("@cta_splan", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cta_splan
        cmd.Parameters.Add("@cta_hab", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cta_hab
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.signo
        cmd.Parameters.Add("@signo1", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.signo1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBCLIENTEBE.Dia4  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se registro el cliente : " + ELTBCLIENTEBE.cod + "-" + ELTBCLIENTEBE.nom
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    Private Sub UpdateRow(ByVal ELTBCONCEPTOSBE As ELTBCONCEPTOSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_RELCONCEPTOS_UPDATEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@cod", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cod
        cmd.Parameters.Add("@nom", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.nom
        cmd.Parameters.Add("@cpto_cod", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cpto_cod
        cmd.Parameters.Add("@t_per_cod", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.t_per_cod
        cmd.Parameters.Add("@porc", OracleDbType.Double).Value = ELTBCONCEPTOSBE.porc
        cmd.Parameters.Add("@monto", OracleDbType.Double).Value = ELTBCONCEPTOSBE.monto
        cmd.Parameters.Add("@t_cpto", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.t_cpto
        cmd.Parameters.Add("@t_impres", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.t_impres
        cmd.Parameters.Add("@cta_adm", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cta_adm
        cmd.Parameters.Add("@cta_plan", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cta_plan
        cmd.Parameters.Add("@cta_ven", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cta_ven
        cmd.Parameters.Add("@cta_splan", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cta_splan
        cmd.Parameters.Add("@cta_hab", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.cta_hab
        cmd.Parameters.Add("@signo", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.signo
        cmd.Parameters.Add("@signo1", OracleDbType.Varchar2).Value = ELTBCONCEPTOSBE.signo1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'AUDITORIA
        'cmd = New Oracle.ManagedDataAccess.Client.OracleCommand
        'cmd.CommandText = "SP_ELMVLOGS_INSERTROW"
        'cmd.Connection = sqlCon
        'cmd.Transaction = sqlTrans
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("pLOG_CODOPE", OracleDbType.Char).Value = "1"
        'cmd.Parameters.Add("pLOG_CODUSU", OracleDbType.Char).Value = ELTBCLIENTEBE.Dia4  'cod usu
        'cmd.Parameters.Add("pLOG_OBSERV", OracleDbType.Char).Value = "Se actualizo el cliente : " + ELTBCLIENTEBE.cod + "-" + ELTBCLIENTEBE.nom
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
    End Sub

    'Metodo para Eliminar 
    Private Sub DeleteRow(ByVal ELTBCONCEPTOSBE As ELTBCONCEPTOSBE, ByVal sqlCon As Oracle.ManagedDataAccess.Client.OracleConnection,
                          ByVal sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction)

        Dim cmd As New Oracle.ManagedDataAccess.Client.OracleCommand
        cmd.CommandText = "SP_CLIENTE_DELETEROW"
        cmd.Connection = sqlCon
        cmd.Transaction = sqlTrans
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add("@cod", OracleDbType.Char).Value = ELTBCLIENTEBE.cod
        cmd.ExecuteNonQuery()

    End Sub

    Public Function SaveRow(ByVal ELTBCONCEPTOSBE As ELTBCONCEPTOSBE, ByVal flagAccion As String) As String
        Dim resultado As String = "OK"
        Dim cn As New Oracle.ManagedDataAccess.Client.OracleConnection
        Dim sqlTrans As Oracle.ManagedDataAccess.Client.OracleTransaction
        '' Dim correlativo As String

        ''cn = _Conexion.Conexion
        cn = ConnectionBegin()
        '' cn.Open()
        sqlTrans = cn.BeginTransaction

        Try
            'N:Nuevo   M:Modificar   E:Eliminar 

            If flagAccion = "N" Then
                ''correlativo = LastCodigo()
                ''MonedaBE.mon_codigo = MonedaBE.mon_codigo
                InsertRow(ELTBCONCEPTOSBE, cn, sqlTrans)
            End If

            If flagAccion = "M" Then
                UpdateRow(ELTBCONCEPTOSBE, cn, sqlTrans)
            End If

            If flagAccion = "E" Then
                DeleteRow(ELTBCONCEPTOSBE, cn, sqlTrans)
            End If

            sqlTrans.Commit()
            resultado = "OK"

        Catch ex As Oracle.ManagedDataAccess.Client.OracleException
            sqlTrans.Rollback()
            resultado = ex.Message
        Catch ex As Exception
            sqlTrans.Rollback()
            resultado = ex.Message
        Finally
            If resultado = "OK" Then
                cn.Dispose()
            End If
            sqlTrans = Nothing
        End Try

        Return resultado

    End Function
End Class
